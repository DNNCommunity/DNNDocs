# DNN Platform Documentation

The [documentation site](https://dnndocs.com/) for the open source Content Management System DNN (formerly DotNetNuke).

The project uses the `docfx` library to pull XML comments from the DNN Platform source code and combine that with articles written in Markdown to form the documentation for DNN.

## Installing Git
If you do not have Git installed, you will need to install it first. You can find instructions at [Git's Installation Guide](https://git-scm.com/book/en/v2/Getting-Started-Installing-Git).

## Installing DocFX
You'll also need DocFX installed as a command-line tool.  This can be accomplished using

  * [Chocolatey](https://chocolatey.org/) for Windows via `choco install docfx -y`
  * [Homebrew](https://brew.sh/) for macOS via `brew install docfx`

Alternatively, you can download the latest release of `docfx.zip` from [DocFX's GitHub Releases](https://github.com/dotnet/docfx/releases), extract it to a local directory, and add that directory to `PATH` so you can run it anywhere.

## Setting Up the DNN Docs Project
After installing DocFX, the next step is to fork this repository from GitHub to your own GitHub repository in order to give you write access on your own copy (if you don't have a GitHub account, you can create a free one).
Simply click the Fork button above to get started.

After your own fork is created, you need to copy the repository into your local machine, this is called cloning. This will create a copy of the DNNDocs Git repository (its directories and folders) on your local machine so that you can work with them there.

The following command will clone your forked repository to your working directory, so you may wish to `cd` to an appropriate directory first.

```
git clone https://github.com/your-github-user-name/DNNDocs.git
```

The previous command will have created a folder titled `DNNDocs` in your working directory.  So, for example, if you had been working in `C:\dev\`, the previous command would have created `C:\dev\DNNDocs\`.

```
cd DNNDocs
```

The references from your local copy (**clone**) to their respective GitHub repositories are called **remotes**. By default the previous clone automatically setup a remote called **origin** to your fork on GitHub and you have read-write access to it (you can **pull** and **push** to it). In order to be able to **pull** the latest changes from other contributors on the official DNNDocs repository, you need to setup another remote to it, we call that remote **upstream**. In order to set it up, run the following command:

```
git remote add upstream https://github.com/DNNCommunity/DNNDocs
```

Unless you are part of the DNNDocs core team, you will only have read access (you can only **pull**) to this remote.

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

## Contributing
You are now all setup to start your first contribution.

First, it is recommended to create a new branch to collect your changes without touching the **master** branch, this will make it easier later when you will need to **pull** the latest changes from the **upstream** remote (the official repository). You can use any branch name that makes sense to you as long as it does not have spaces or special characters other than - and _. Popular naming conventions are something that describes the issue solved or simply the issue number. To create a new branch you can type the following command:

```
git checkout -b your-branch-name
```

Next you can start editing documentation and saving files using your favorite text editor (Visual Studio Code, Atom, Sublime Text, Brackets Notedpad++, etc). When you are done with your changes you can verify the modified files. Some code editors will actually show a status of the modified files in their UI. If you want to verify it using the command line you can run the following command:

```
git status
```

In Git parlance, a logical set of changes is called a **commit**. All your current changes are just temporary until you actually _commit_ to propose them, hence the name **commit**. To create a commit you first need to **stage** your changes, this is adding the files you want to commit into a list (staged changes). For simplicity, we are assuming that all the changes you saw in `git status` are to be included in the commit. To stage all changes, run the following command:

```
git add .
```

The `.` above means all changed files, if that is not the case you can replace the preceding command with either a globbing pattern or each filename you want to stage for the commit. If you want to verify what is staged or not staged, you can repeat the `git status` command.

Now that we have selected what goes into the **commit**, let's actually create our commit using the following command.

```
git commit -m "Here you can enter a commit message that summarizes the changes in this commit."
```

Congratulations, you have created your first commit! The next step is to push your local branch to the web, because right now this commit only exists in your computer. This step is called a **push**. Without parameters, the **push** command pushes **commits** to the default **remote** (in our case **origin**) into the same branch. The problem is that our branch is currently only local, so we need on the first push to specify the **remote** and the **branch** name. Again, most code editors have a UI to make this simpler, but in the command line, the command would be:

```
git push -u origin your-branch-name
```

Now your changes are available in your **fork** of the repository for anyone to view. Remember how you only have read access to the **upstream** (or offical repository)? Since we cannot push there, they need to pull. The next and last step is to propose your changes, or in other works, request from DNNDocs team to **pull** your changes, hence the name **pull request**. You can create a **pull request** directly in the browser, if you navigate the the origin or the upstream repositories any soon, you will see a banner showing the recent pushes and a button to create a pull request. If for some reason you do not see that banner, navigate to your fork and select your branch in the branches dropdown, you will see a "Create Pull Request" button.

**Congratulations, you just created your first pull request!**

## Updating from upstream

A couple of days or weeks have passed and you are still all setup to continue contributing, but sice time has past, other awesome contributors have been working hard and now **upstream**, **origin** and your local **clone** may be out of sync with different content. Let's bring those back in sync. Remember how you can only read (**pull**) from the official repository (**upstream** remote) but you can read and write (**pull** and **push**) to your fork (**origin** remote). This means we will need to pull from upstream to your local clone and then push this back to your origin to get the 3 back in sync. But first we need to change our branch to the default (**master**) branch. Here is the series of commands to do what is explained in the paragraph:

```
git checkout master
git pull upstream master
git push
```

Everything is now updated per the latest changes everywhere, you are ready for your next contribution, scroll up and repeat from the "create a branch for your changes" step, rinse and repeat.
