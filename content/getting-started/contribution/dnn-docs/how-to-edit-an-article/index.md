---
uid: how-to-edit-an-article
locale: en
title: Edit an Article
dnnversion: 10.02.00
related-topics: 
---

# Edit an Article (running DNN Docs Locally on Your Machine)

## Prerequisites
  1. **Get DNN Docs Running Locally**: In order to edit an article you need to get DNN Docs running locally on your machine. Follow the steps on the [Get DNN Docs Running Locally page](xref:get-dnn-docs-running-locally) before proceeding.

  2. **Markdown**: Docs uses markdown syntax to format the docs files. Markdown is simple to pick up on. Familiarize yourself with the [Markdown Guide to DocFx](xref:markdown-guide-to-docfx) before making updates to content. 


Now that you've gotten DNN Docs running locally (congrats BTW!) we will talk through the steps for making an edit (in your local repo), previewing the (local) edit, pushing it to your forked repo (on the Github.com website), then creating a Pull Request on the Github.com website. First using Git; second using Visual Studio.

## Steps to Edit an Article & Create a Pull Request using Git

1. Fork the [DNN Docs Repo](https://github.com/DNNCommunity/DNNDocs) into your own Repo on Github.
   ![Fork DNN Docs Screenshot](/images/GitHub_InBrowser_ForkDnnDocs.jpg)



2. Set your remote repositories. We will use the terms "upstream" and "origin". Note: when you originally cloned the repo locally (in the "Getting DNN Docs Running Locally" pre-requisite) the locally cloned repo was named ```origin``` implicitly (as well).

   Type ```git remote add upstream https://github.com/DNNCommunity/DNNDocs``` to add the main DNN Docs repo as your "upstream" repo

   > [!NOTE]
   > Remotes can be named anything you like. Find out your remotes by typing ```git remote -v```

   Type ```git remote -v``` to list your remotes. If you are new to Git then you should have 2 remotes. Your ```origin``` and ```upstream``` where ```origin``` is your forked repo and your ```upstream``` is the main DNN Docs repo; both on Github.

3. Create an [Issue](https://github.com/DNNCommunity/DNNDocs/issues) on GitHub that corresponds with the edit you're working on by clicking the "New Issue" button in the browser. Be sure to include relevant information providing context to the issue in the description/comment section. This helps reviewers understand what you're working on. 

    Make note of the issue number that GitHub generates.

    ![GitHub Issue Screenshot](/images/GitHub_InBrowser_Issue.jpg)


4. Create a new branch for your work. Typically branch names align with the issue number for ease of tracking.

   **Example Branch Name**: ```issue-107```

   **Example Git Command to Create New Branch**: ```git checkout -b issue-107```

5. Make your edits
6. Preview your work locally by invoking the ```docfx --serve``` in your terminal (in VS Code, Powershell, etc.). This will run DNN Docs locally on your machine at a URL similar to this ```localhost:8080```. Click the link  or copy/paste it into your browser.
7. Use ```git status``` to review the files you are working on and ensure the proper files are being tracked.
    ![git status screenshot](/images/git-status-screenshot.jpg)

8. Use ```git add [INSERT FILE NAME]``` to stage a single file or ```git add .``` to stage *all* modified files to be committed.
    ![git add screenshot](/images/git-add-screenshot.jpg)



9. Use ```git commit -m [INSERT YOUR COMMIT MESSAGE HERE]``` to commit your files. The ```-m``` stands for "message". Replace the *INSERT YOUR COMMIT MESSAGE HERE* text with brief and relevant text summarizing your commit
10. Use ```git push origin [INSERT A NEW BRANCH NAME HERE]``` to push your updated files to your remote repo (on Github with name ```origin```). Replace the *INSERT A NEW BRANCH NAME HERE* with the name of your new branch. In this example ```issue-107```
Go to step 11. below.


## Steps to Edit an Article & Create a Pull Request using Visual Studio
1. Cloning the repository from Visual Studio, as described on [Get DNN Docs Running Locally page](xref:get-dnn-docs-running-locally), has forked the [DNN Docs Repo](https://github.com/DNNCommunity/DNNDocs) into your own Repo on Github.
2. Step 'Set your remote repositories' is (at this moment) not necessary.
3. Create an [Issue](https://github.com/DNNCommunity/DNNDocs/issues) on GitHub that corresponds with the edit you're working on by clicking the "New Issue" button in the browser. Be sure to include relevant information providing context to the issue in the description/comment section. This helps reviewers understand what you're working on. 

    Make note of the issue number that GitHub generates.

    ![GitHub Issue Screenshot](/images/GitHub_InBrowser_Issue.jpg)
4. Create a new branch for your work using Visual Studio menu item 'Git...New Branch..'
![Visual Studio 2026 Create New Branch](/images/DnnDocs_VS2026_CreateNewBranch.png)
For more elaborate instructions on how to create a new branch in Visual Studio see https://learn.microsoft.com/en-us/visualstudio/version-control/git-create-branch?view=visualstudio.
5. Make your edits
6. & 7. & 8. Preview your work and files locally using the 'Git Changes' tab in Visual Studio.
![Visual Studio 2026 Git Changes Tab](/images/DnnDocs_VS2026_GitChangesTab.png)
9. & 10. Commit the changed and added files by clicking 'Commit All and Push'.
![Visual Studio 2026 Commit Changes](/images/DnnDocs_VS2026_GitChanges_CommitAllAndPush.png)



## Common Steps to Edit an Article & Create a Pull Request (for both Git and Visual Studio)
11. Go to your forked GitHub repo on GitHub.com. GitHub should detect the updated code and prompt you to make a pull request.
    ![Git compare and pull request screenshot](/images/GitHub_InBrowser_CompareAndPullRequest.jpg)

12. Create a Pull Request on Github.com by clicking the "Compare and Create Pull Request" button. In the description/comments section be sure to include the text "Resolves ```#[INSERT ISSUE NUMBER HERE]``` where your previously created issue number is associated with this pull request.

    ![Git pull request resolves](/images/GitHub_InBrowser_PullRequestResolves.jpg)




> [!TIP]
> Want more info on Git? Check out the free, online **[GitBook](https://git-scm.com/book/en/v2)**