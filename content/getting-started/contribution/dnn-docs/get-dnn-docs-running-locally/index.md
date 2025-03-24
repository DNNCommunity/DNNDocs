---
uid: get-dnn-docs-running-locally
locale: en
title: Get DNN Docs Running Locally
dnnversion: 09.02.00
---

# Get DNN Docs Running Locally

The project uses the `docfx` library to pull XML comments from the DNN Platform source code and combine that with articles written in Markdown to form the documentation for DNN.

## Installing Git
If you do not have Git installed you will need to install Git first. You can find instructions on installing Git from [here](https://git-scm.com/book/en/v2/Getting-Started-Installing-Git)

## Installing dotnet
Our cross-platform build scripts handle obtaining docfx for you, however you will need to have the latest .net SDK installed. [Download .NET](https://dotnet.microsoft.com/en-us/download)

## Setting Up the DNN Docs Project
The next step is to clone this repo. 'Cloning the repo' will simply create a copy of the repo (files and folders) on your local machine so that you can work with them.

Note the following example command clones the repo to the location of `c:\dev`. Update the `c:\dev` location to your location of choice on your machine.
```
c:\dev> git clone https://github.com/DNNCommunity/DNNDocs.git
```

The previous command will have created a folder called `DNNDocs` in the `c:\dev` folder. Navigate to that directory by using the cd (Change Directory) command. `cd` into the `DNNDocs` folder.
```
c:\dev> cd DNNDocs
```

## Running the DNN Docs Project Locally
You should now be able to run the development version of the docs locally with the following command:

```
./build.cmd
```

> [!NOTE]
> You should run your shell in administrator mode for this to work!

The first time, the compilation process could take quite a while. You may see a couple of warning messages. Eventually, you should see a message similar to:
```
Serving "C:\dev\DNNDocs\_site" on https://localhost:8080
```

Open that page up in your browser to see the documentation.

[https://localhost:8080](https://localhost:8080)

> [!NOTE]
> Depending on the configuration of your development environment, you may need to use the non-SSL version of the local website URL instead.

[http://localhost:8080](http://localhost:8080)

### Optional git integrations
We use a handful of plugins that will not work unless you have a valid authentication to github REST APIs. This step is optional but if not performed, you won't get some of the features like displaying contributors on pages. If you need to work in that area you will need to [Setup a git personal access token](https://docs.github.com/en/authentication/keeping-your-account-and-data-secure/managing-your-personal-access-tokens). Once that is created, copy your token (you will only view it once) and create a `.env` file at the root of the project with a line like this (everything after the `=` sign is the token you copied).

```
GITHUB_TOKEN=github_pat_xxxxxxxxxx
```