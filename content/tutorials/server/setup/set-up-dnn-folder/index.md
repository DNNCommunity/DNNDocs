---
uid: set-up-dnn-folder
locale: en
title: Set Up the DNN Folder and the User Account
dnnversion: 09.02.00
next-topic: set-up-iis
links: ["[DNN Wiki: Setting up Your Module Development Environment](https://www.dnnsoftware.com/wiki/setting-up-your-module-development-environment)","[Setting up your DotNetNuke Module Development Environment by Chris Hammond](https://www.christoc.com/Tutorials/All-Tutorials/aid/1)","[DNN Community Blog: Installing DNN by Clinton Patterson](https://www.dnnsoftware.com/community-blog/cid/155070/installing-dnn)","[Microsoft blog: How to: Unblock a downloaded file to avoid security warnings](https://blogs.msdn.microsoft.com/delay/p/unblockingdownloadedfile/)"]
---

# Set Up the DNN Folder and the User Account

## Steps

1.  [Download DNN and extract the files.](https://www.dnnsoftware.com/community/download/)

    > [!NOTE]
    > If you get a Windows Security Warning while attempting to unzip the file, you might need to [unblock the DNN zip file](https://blogs.msdn.microsoft.com/delay/p/unblockingdownloadedfile/) then try again. 
    
    
    > [!WARNING]
    > For your protection, remember to download or unzip files from reliable sources only.

    The folder where you extract the files becomes the DNN installation folder.

    **Developers and Designers:** For module or theme development, you don't need the source files.

2.  Determine the user account used to run your website.

    The account name differs, depending on your IIS and Windows version:

    | If your OS is  |  and your IIS version is a  |  then the account name is  |
    |---|---|---|
    | Windows Vista Windows Server 2008  |  IIS 7  | localmachine\\Network Service |
    | Windows 7  Windows Server 2008 R2  |   IIS 7.5  | the **NETWORK SERVICE** account \- or - the **IIS AppPool\\AppPoolName**, which is the name of the automatically generated app.  |
    | Windows 8  Windows Server 2012  |   IIS 8 |
    |  Windows 10  |  IIS 10  |


3.  Give **Full** or **Modify** permissions for the DNN installation folder to the user account that will run your website.
    1.  In Windows Explorer, right-click on the DNN installation folder, and choose Properties.



        ![Right-click on the DNN folder and choose Properties](/images/scr-FolderPerms-1.png)



    2.  Go to the Security tab and click/tap Edit....



        ![In the Security tab, click/tap Edit...](/images/scr-FolderPerms-2.png)



    3.  Click/Tap Add....



        ![Click/Tap Add...](/images/scr-FolderPerms-3.png)



    4.  In Select Users or Groups, enter the user name, then click/tap Check Names. After the name is resolved, click/tap OK.



        ![In Select Users or Groups, enter the user name, then click/tap Check Names.](/images/scr-FolderPerms-5a.png)



    5.  Highlight the newly added user name and check Full Control and Modify under Allow.



        ![Highlight the newly added user name and check Full Control and Modify under Allow.](/images/scr-FolderPerms-6.png)
