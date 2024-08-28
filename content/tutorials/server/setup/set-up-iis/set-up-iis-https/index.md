---
uid: set-up-iis-https
locale: en
title: Enable and Set Up IIS
dnnversion: 09.02.00
---

# Create a Trusted Certificate for Internal Webservers

## Prerequisites

[Enable and Set Up IIS](xref:set-up-iis)

[Download OpenSSL](https://slproweb.com/products/Win32OpenSSL.html). You need the "full" version (not the "light" one).


![Download the full version](/images/DownloadOpenSSL.png)


## Steps

1.    Install OpenSSL.

      Copy the OpenSSL DLLs to The OpenSSL binaries (/bin) directory during installation.


      ![Install OpenSSL](/images/InstallOpenSSL.png)

2.    Create some directories.

      *  *RootPath*\Certificates
         -  *RootPath*\Certificates\RootCA
         -  *RootPath*\Certificates\\*SiteName*
            -  *RootPath*\Certificates\\*SiteName*\\.rnd
            -  *RootPath*\Certificates\\*SiteName*\newcerts

      *RootPath* is somewhere on your hard disk, e.g. `C:` or `D:\Workspace`

      *SiteName* is the directory for the site you want to create the certificate for, e.g. `dnndev.me`

3.    Create two files in the *SiteName*:

      *  `index.txt` and
      *  `serial` (without extension)

      Edit the file `serial` with any text editor, enter "1000" (without the hyphens), save and close the file.

      ![Edit serial file](/images/EditSerialFileWithTextEditor.png)

4.    Create a batch file in the *RootPath*\Certificates directory and name it `envvars.bat`:

      ```
      SET SITE2SIGN=%1
      SET ROOTCA=.\RootCA
      SET ROOTCA_COMPANY_NAME=*CompanyName*-RootCA
      SET FQDN=%1

      SET RANDFILE=.\%SITE2SIGN%\.rnd
      SET OPENSSL_CONF=.\%SITE2SIGN%.cnf
      SET OpenSSL_HOME=C:\Program Files\OpenSSL-WIN64
      ```
   
      (Change \*CompanyName\* to your company name)
   
5.    Create another batch file in the *RootPath*\Certificates directory and name it `RootCA.bat`:

      ```
      if [%1]==[] GOTO CERT_ONLY
      
      REM Create the private key for the Root CA
      openssl req -newkey rsa:2048 -sha256 -keyout %ROOTCA%\%ROOTCA_COMPANY_NAME%.key

      :CERT_ONLY
      REM Create the certificate for the Root CA
      openssl req -new -x509 -days 3650 -key %ROOTCA%\%ROOTCA_COMPANY_NAME%.key -out %ROOTCA%\%ROOTCA_COMPANY_NAME%.crt
      ```

6.    Create another batch file in the *RootPath*\Certificates directory and name it `ClientCert.bat`:

      ```
      REM Create a key for the client
      openssl req -newkey rsa:2048 -sha256 -keyout .\%SITE2SIGN%\%FQDN%.key

      REM Create the certificate signing request
      openssl req -new -key .\%SITE2SIGN%\%FQDN%.key -out .\%SITE2SIGN%\%FQDN%.csr

      REM Sign the certificate for the client
      openssl ca -days 365 -in .\%SITE2SIGN%\%FQDN%.csr -out .\%SITE2SIGN%\%FQDN%.crt -keyfile %ROOTCA%\%ROOTCA_COMPANY_NAME%.key -cert %ROOTCA%\%ROOTCA_COMPANY_NAME%.crt -policy policy_anything

      REM Export to Public-Key Cryptography Standards (PKCS)
      openssl pkcs12 -export -in .\%SITE2SIGN%\%FQDN%.crt -inkey .\%SITE2SIGN%\%FQDN%.key -certfile %ROOTCA%\%ROOTCA_COMPANY_NAME%.crt -out .\%SITE2SIGN%\%FQDN%.p12
      ```

7.    Configure OpenSSL

      Copy the file `C:\Program Files\Common Files\SSL\openssl.cnf` to the *RootPath*\Certificates directory. Rename the file to SiteDirectory.cnf.
   
      Open the copied file with a text editor and make the following changes:
   
      1.    Search for `[ CA_Default ]`. Change the line
         
            `dir = ./demoCA`
            
            to
            
            `dir = ./*SiteName*`
            
            (Change \*SiteName\* to the *SiteName* above)
         
      2.    Uncomment (remove the "#") the line (a few lines below):
         
            `copy_extensions = copy`
         
      3.    Search for `[ req ]`. Enter a new line between the lines starting with `distinguished_name` and `attributes`:
      
            `emailAddress = *EmailAddress*`
            
            (Change \*EmailAddress\* to your email address)
         
      4.    Uncomment the line (a few lines below) - leave the inline comment (second hashtag):
         
            `req_extensions = v3_req # The extensions to add to a certificate request`
         
      5.    Search for `[ req_distinguished_name ]`. Change the default country name ("AU") with your country (2 letter ISO code, eg. AT, NL, FR, DE...), eg.

            `countryName_default = AT`
         
      6.    Change the line
         
            `stateOrProvinceName_default	= Some-State`
            
            to your state, e.g.
            
            `stateOrProvinceName_default = Tyrol`

      7.    Add a line after the line
         
            `localityName = Locality Name (eg, city)`

            with a localityName_default setting with the value of the name of your city, eg.

            `localityName_default = Innsbruck`

      8.    Change the line

            `0.organizationName_default	= Internet Widgits Pty Ltd`

            to

            `0.organizationName_default = *CompanyName*`
            
            (Change \*CompanyName\* to your company name)

      9.    (optional) Uncomment the line
      
            `organizationalUnitName_default =`
            
            and add a unit name, eg.

            `organizationalUnitName_default = IT Department`
         
      10.   Add a line after the line

            `commonName = Common Name (e.g. server FQDN or YOUR name)`

            with a commonName_default setting with the FQDN of your intranet webserver, eg.

            `commonName_default = *SiteName*`
            
            (Change \*SiteName\* to the *SiteName* above)

      11.   Add a line after the line

            `emailAddress = Email Address`
            
            with an emailAddress_default setting with your email address, eg.

            `emailAddress_default = *EmailAddress*`
            
            (Change \*EmailAddress\* to your email address)
            
      12.   Search for `[ v3_req ]`. Add two lines after the line
      
            `keyUsage = nonRepudiation, digitalSignature, keyEncipherment`
            
            with extendedKeyUsage and subjectAltName settings:
            
            ```
            extendedKeyUsage = serverAuth
            subjectAltName = DNS:SiteDirectory.your.domain
            ```
            
      13.   Search for `[ v3_ca ]`. Uncomment the two lines

            ```
            subjectAltName=email:copy
            issuerAltName=issuer:copy
            ```
            
      14.   Search for `[ tsa_config1 ]`. Change the line

            `dir = ./demoCA`

            to

            `dir = ./*SiteName*`

            (Change \*SiteName\* to the *SiteName* above)

      Save the file and close the editor.
      
8.    Create Root Certificate

      Open the `Win64 OpenSSL Command Prompt` and execute
      
      ```
      cd *RootPath*\Certificates
      envvar.bat *SiteDirectory*
      RootCA.bat new
      ```
      
      (Change \*RootPath\* and \*SiteDirectory\* to the appropriate values)
      
      You will find three files:
      
         - *RootPath*\Certificates\RootCA\\*CompanyName*-RootCA.key
         - *RootPath*\Certificates\RootCA\\*CompanyName*-RootCA.crt
      
      Copy the `.key` file to a really really safe place! This certifice is yalid for 10 years, but when you renew it you need the private key file, so don´t loose it!

      To renew the certificate in 10 years, you have to make sure that the .key file is in the RootCA directory, then execute

      `RootCA.bat`

9.    Create the Client Certificate

      Execute
      
      `ClientCert.bat`
      
      In your ClientCert directory you will find a file called index.txt.attr. Open it with any text editor and change the line

      `unique_subject = yes`

      to

      `unique_subject = no`
      
      ![Change index.txt.attr](/images/ChangeIndexTxtAttr.png)

      This allows you to re-generate the client certificate in case anything went wrong.
   
10.   Webserver

      1.    If you have not done all of the above on your webserver, copy two files anywhere to it:
      
            - *RootPath*\Certificates\RootCA\\*CompanyName*-RootCA.key
            - *RootPath*\Certificates\\*SiteName*\\*SiteName*.p12
      
      2.    Start MMC, go to File :: Add/Remove Snap-in..., add Certificate, and select Local computer.
      
      3.    Right click Trusted Root Certification Authorities and go to All tasks :: Import..., select the .crt file and place it in Trusted Root
            Certification Authorities.
            
            ![Import RootCA](/images/ImportRootCA.png)
            
      4.    Right click Web Hosting and go to All tasks :: Import.... When browsing, select Personal Information Exchange (*.pfx, *.p12) as the file type
            and select the .p12 file. Select Web Hosting as the certificate store.
            
            ![Import Client Certificate](/images/ImportClientCert.png)
            
      5.    Open IIS Management Console and add a binding to your website:
      
            ![Bind certificate to website](/images/BindWebsiteSSL.png)
            
11.   Distibute Certificate

      Import the Root CA Certificate to all clients who will browse to the site as described above. In a Domain this can be done using group policies,
      see [Distribute Certificates to Client Computers by Using Group Policy](https://learn.microsoft.com/en-us/windows-server/identity/ad-fs/deployment/distribute-certificates-to-client-computers-by-using-group-policy)
      for details.
      

