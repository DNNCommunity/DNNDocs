---
uid: how-to-edit-an-article
locale: en
title: Edit an Article
dnnversion: 09.02.00
related-topics: 
---

# Edit an Article

## Prerequisites
  1. **Get DNN Docs Running Locally**: In order to edit an article you need to get DNN Docs running locally on your machine. Follow the steps on the [Get DNN Docs Running Locally page](xref:get-dnn-docs-running-locally) before proceeding.

  2. **Markdown**: Docs uses markdown syntax to format the docs files. Markdown is simple to pick up on. Familiarize yourself with the [Markdown Guide to DocFx](xref:markdown-guide-to-docfx) before making updates to content. 


Now that you've gotten DNN Docs running locally (congrats BTW!) we will talk through the steps for making an edit, previewing the edit, pushing it to your forked repo, then creating a Pull Request.

## Steps to Edit an Article & Create a Pull Request

1. Fork the [DNN Docs Repo](https://github.com/DNNCommunity/DNNDocs) into your own Repo.
   ![Fork DNN Docs Screenshot](/images/fork-screenshot.jpg)



2. Set your remote repositories. We will use the terms "upstream" and "origin". When you originally cloned the repo (in the "Getting DNN Docs Running Locally" pre-requisite) the ```origin``` was added for you implicitly.

   Type ```git remote add upstream https://github.com/DNNCommunity/DNNDocs``` to add the main DNN Docs repo as your "upstream" repo

   > [!NOTE]
   > Remotes can be named anything you like. Find out your remotes by typing ```git remote -v```

   Type ```git remote -v``` to list your remotes. If you are new to Git then you should have 2 remotes. Your ```origin``` and ```upstream``` where ```origin``` is your forked repo and your ```upstream``` is the main DNN Docs repo.

3. Create an [Issue](https://github.com/DNNCommunity/DNNDocs/issues) on GitHub that corresponds with the edit you're working on by clicking the "New Issue" button in the browser. Be sure to include relevant information providing context to the issue in the description/comment section. This helps reviewers understand what you're working on. 

    Make note of the issue number that GitHub generates.

    ![GitHub Issue Screenshot](/images/git-issue-screenshot.jpg)


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
10. Use ```git push origin [INSERT A NEW BRANCH NAME HERE]``` to push your updated files to your repo. Replace the *INSERT A NEW BRANCH NAME HERE* with the name of your new branch
11. Go to your forked GitHub repo on GitHub.com. GitHub should detect the updated code and prompt you to make a pull request.
    ![Git compare and pull request screenshot](/images/git-compare-and-pull-request-screenshot.jpg)

12. Create a Pull Request by clicking the "Compare and Create Pull Request" button. In the description/comments section be sure to incoude the text "Resolves ```#[INSERT ISSUE NUMBER HERE]``` where your previously created issue number is associated with this pull request.

    ![Git pull request resolves](/images/git-pull-request-resolves-screenshot.jpg)




> [!TIP]
> Want more info on Git? Check out the free, online **[GitBook](https://git-scm.com/book/en/v2)**
