---
uid: ts-located-assemblys-manifest-definition-does-not-match-assembly-reference
locale: en
title: "Troubleshooting: The located assembly's manifest definition does not match the assembly reference"
dnnversion: 04.00.00
related-topics: ts-missing-persona-bar
---

# Troubleshooting: The located assembly's manifest definition does not match the assembly reference

## Symptom  

This error can be displayed as a full page error that does not allow the site to load, or it can be logged in the Admin Logs.

![Full screen error](/images/scr-binding-redirect-ysod.png)

![Admin Logs error](/images/scr-binding-redirect-admin-logs.png)


## Possible Cause

The site's `web.config` file (which can be accessed either via the file system or [through the Config Manager in the Persona Bar](xref:access-web-config)) includes a number of `bindingRedirect` entries like this:</p>

```xml
<dependentAssembly xmlns="urn:schemas-microsoft-com:asm.v1">
  <assemblyIdentity name="Newtonsoft.Json" publicKeyToken="30ad4fe6b2a6aeed" />
  <bindingRedirect oldVersion="0.0.0.0-32767.32767.32767.32767" newVersion="12.0.0.0" />
</dependentAssembly>
```

What this is saying is that the assembly (DLL file, compiled code) with the given identity (name is `Newtonsoft.Json`, signed with the public key `30ad4fe6b2a6aeed`) is valid for use when any version is requested (i.e. in the range from version `0.0.0.0` to version `32767.32767.32767.32767`) and should use the version `12.0.0.0`. This `newVersion` value typically needs to match the version of the DLL file in the `bin` folder.

## Solutions

> [!IMPORTANT]
> All of these solutions involve editing the `web.config` file. Doing so could have a negative impact on the performance of your website.  The saved file will trigger the website to restart, which will clear the memory caches. This could result in the website appearing to load slowly and even throwing errors temporarily in some instances.  It's suggested to only update the `web.config` file during non-peak hours on mission-critical websites.

### Introduce a missing `bindingRedirect` entry

If multiple components (e.g. modules, providers, or other extensions) in your site are using different versions of the same strong-named assembly, there will need to be a binding redirect to allow them all to use the version in the `bin` folder. If the [extensions' manifest](xref:dnn-manifest-schema) uses an assembly component, the DNN installer will automatically add and update these binding redirects. If there is not an existing redirect for the assembly in the error message, add one. For the `newVersion` you need to use the .NET version, which often does not match the file version. One option for finding this version is to open the DLL file in a decompiler (such as [dotPeek](https://www.jetbrains.com/decompiler/)) and look for `AssemblyVersion`. You can also use PowerShell to read this information, using a command like this (substituting your site's path):

```pwsh
[System.Reflection.AssemblyName]::GetAssemblyName('C:\inetpub\wwwroot\mysite.com\bin\Newtonsoft.Json.dll').Version.ToString()
```

> [!IMPORTANT]
> Using an incorrect version for the `newVersion` attribute of the `bindingRedirect` may cause your site not to load (see the full page error above).

### Expand `oldVersion` range for binding redirect

If there is an existing `bindingRedirect`, then it isn't covering the conflict which is causing the error. The most common reason for this is that the version range in the `oldVersion` attribute doesn't cover all conflicting versions. Updating `oldVersion` to use a wide range (e.g. `0.0.0.0-32767.32767.32767.32767`) will typically resolve this.

### Synchronize versions of `.dll` files and `bindingRedirect` entries

If the site has a full page error, a relatively quick way to resolve any mismatches it to use the [BindingRedirects PowerShell module](https://www.powershellgallery.com/packages/BindingRedirects) which has a command to synchronize the binding redirects in the `web.config` with the files in the `bin` (though it won't add new binding redirects). To use that, run `Install-Module -Name BindingRedirects` (see <a href="https://docs.microsoft.com/en-us/powershell/scripting/gallery/installing-psget">the getting started docs</a> if `Install-Module` isn't available on your system). Once the PowerShell module is installed, call `Sync-BindingRedirect 'C:\inetpub\wwwroot\mysite.com\web.config'` (using the site's actual path) to update any incorrect binding redirects.
