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

## Installing DocFX
DocFX may be installed on Windows via _Chocolatey_ by calling `choco install docfx -y`

If you are on MacOS you can install it with _Homebrew_ `brew install docfx`

Or you can download and unzip `docfx.zip` from [GitHub](https://github.com/dotnet/docfx/releases), extract it to a folder and then set your `PATH` to that folder so you can run it anywhere.

## Setting Up the DNN Docs Project
After installing DocFX, the next step is to clone this repo.  'Cloning the repo' will simply create a copy of the repo (files and folders) on your local machine so that you can work with them.

Note the following example command clones the repo to the location of `c:\dev`. Update the `c:\dev` location to your location of choice on your machine.
```
c:\dev> git clone https://github.com/DNNCommunity/DNNDocs.git
```

The previous command will have created a folder called `DNNDocs` in the `c:\dev` folder. Navigate to that directory by using the cd (Change Directory) command. `cd` into the `DNNDocs` folder.
```
c:\dev> cd DNNDocs
```

Next, you'll need to fork and/or clone the [Dnn.Platform repository](https://github.com/dnnsoftware/Dnn.Platform) into a **sub-folder** of the `DNNDocs` root folder. The reason is that the project reads the XML comments in the source code and creates API documentation from that, in addition to the documentation center articles.

Please note that you don't need to create the sub-folder, it will be created for you when running the command shown below.  Also, the cloning for this repository could take a few minutes depending on your internet connection speed.
```
c:\dev\DNNDocs>git clone https://github.com/dnnsoftware/Dnn.Platform.git
```

If you've run the `clone` command from the path we've been using, you'll now have the DNN repository at the expected path as in the example below. 

_c:\dev\DNNDocs\Dnn.Platform_  

> [!NOTE]
> Don't worry about the DNN source code existing here. It is already being ignored for any future commits.

## Running the DNN Docs Project Locally
You should now be able to run the development version of the docs locally with the following command:

```
docfx --serve
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
