# DNN Platform Documentation

The documentation site for the open source Content Management System DNN (formerly DotNetNuke).

The project uses the `docfx` library to pull XML comments from the DNN Platform source code and combine that with articles written in Markdown to form the documentation for DNN.

## Installing Git
If you do not have Git installed, you will need to install it first. You can find instructions at [Git's Installation Guide](https://git-scm.com/book/en/v2/Getting-Started-Installing-Git).

## Installing DocFX
You'll also need DocFX installed as a command-line tool.  This can be accomplished using

  * [Chocolatey](https://chocolatey.org/) for Windows via `choco install docfx -y`
  * [Homebrew](https://brew.sh/) for macOS via `brew install docfx`

Alternatively, you can download the latest release of `docfx.zip` from [DocFX's GitHub Releases](https://github.com/dotnet/docfx/releases), extract it to a local directory, and add that directory to `PATH` so you can run it anywhere.

## Setting Up the DNN Docs Project
After installing DocFX, the next step is to clone this repository from GitHub to your local machine.  This will create a copy of the DNNDocs Git repository (its directories and folders) on your local machine so that you can work with them there.

The following command will clone this repository to your working directory, so you may wish to `cd` to an appropriate directory first.

```
git clone https://github.com/DNNCommunity/DNNDocs.git
```

The previous command will have created a folder titled `DNNDocs` in your working directory.  So, for example, if you had been working in `C:\dev\`, the previous command would have created `C:\dev\DNNDocs\`.

```
cd DNNDocs
```

Next, you'll need to clone the [Dnn.Platform repository](https://github.com/dnnsoftware/Dnn.Platform) into a **subdirectory** of `DNNDocs` so that DocFX can parse its source code for structured XML comments to generate DNN's API documentation and the documentation center articles.

Navigate into the newly created `DNNDocs` directory and clone the *Dnn.Platform*.  This could take a few minutes depending on your connection speed.

```
cd DNNDocs
git clone https://github.com/dnnsoftware/Dnn.Platform.git
```

## Running the DNN Docs Project Locally
You should now be able to run the development version of the docs locally with the following command:

```
docfx --serve
```

If you installed `docfx` using Chocolatey for Windows, you will need to run your shell as an administrator.

The compilation process could take quite a while.  You may see some warning messages.  Eventually, you should see a message similar to:
```
Serving "C:\dev\DNNDocs\_site" on http://localhost:8080
```

You can now open <a href="http://localhost:8080" target="_blank">http://localhost:8080</a> in your web browser to view your local DNNDocs app.
