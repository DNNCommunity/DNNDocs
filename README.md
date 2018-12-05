# DNN Platform Documentation

The documentation site for the open source Content Management System DNN (formerly DotNetNuke).

The project uses the `docfx` library to pull XML comments from the DNN Platform source code and combine that with articles written in Markdown to form the documentation for DNN.

## Installing DocFX
DocFX may be installed on Windows via _Chocolatey_ by calling `choco install docfx -y`

If you are on MacOS you can install it with _Homebrew_ `brew install docfx`

Or you can download and unzip `docfx.zip` from [GitHub](https://github.com/dotnet/docfx/releases), extract it to a folder and then set your `PATH` to that folder so you can run it anywhere.

## Setting Up the DNN Docs Project
After installing DocFX, the next step is to clone this repo. 
```
c:\dev> git clone https://github.com/DNNCommunity/dnn-docs.git
```

Currently the DocFX version of the documentation is on the `docfx` branch, so `cd` into the `dnn-docs` folder and checkout that branch
```
c:\dev\dnn-docs> git checkout docfx
```

Next, you'll need to fork and/or clone the [Dnn.Platform repository](https://github.com/dnnsoftware/Dnn.Platform) _into_ a sub-folder of the dnn-docs root folder. The reason is that the project reads the XML comments in the source code and creates API documentation from that, in addition to the documentation center articles.
```
c:\dev\dnn-docs>git clone https://github.com/dnnsoftware/Dnn.Platform.git
```

## Running the DNN Docs Project Locally
You should now be able to run the development version of the docs locally with the following command:

```
docfx --serve
```

The first time, the compilation process could take quite a while. You will also likely see a lot of warning messages. Eventually, you should see a message similar to:
```
Serving "C:\dev\dnn-docs\_site" on http://localhost:8080
```

Open that page up in your browser to see the documentation.
