---
uid: prompt
locale: en
title: Prompt - The Command Line Interface (CLI) for DNN
dnnversion: 09.02.00
---

# Prompt: The Command Line Interface for DNN

## What Is Prompt?
DNN Prompt is a Command Line Interface (CLI) that runs within DNN.  It allows you to more efficiently perform many administrative tasks with a command that would ordinarily require multiple clicks and page loads or simply aren’t available in the UI.  You can create users, reset their passwords, create and modify pages, list and modify scheduled tasks and more. It is extensible so you can add your own custom commands and its API allows it to be accessed from other environments like Powershell — making remote management  possible.

Prompt was originally created by Kelly Ford and donated to the community. It first became available in DNN v.9.2.0.  

## Running Prompt
> [!Note]
> Prompt is only accessible only to SuperUser accounts and won’t be visible to other users.
 
To start Prompt, select it from the Settings menu on the Persona Bar.

![](/images/scr-prompt-pb-start-prompt.png)

This will bring up the Prompt window which looks and functions similarly to other command line shells.

![](/images/scr-prompt-main-window.png)

## What Can You Do With It?
Now that you have a blinking cursor, what's next? The easiest way to answer that question is to type `help` at the prompt and hit `ENTER` on your keyboard. 

![](/images/scr-prompt-help-command.png)

You’ll be presented with a list of built-in commands you can execute in Prompt. Even though Prompt is a “command line” tool, it runs in the browser. Prompt leverages this fact to make it easier to use and learn than a typical CLI. As you use Prompt, you will often see blue links. Clicking them will pre-populate the command line for you. It is a great way to save typing and learn how to use various commands.

In the case of the Help’s list of commands, you can click on any of the blue links and Prompt generate a command like: `help <command name>`. All you have to do is hit`ENTER`.

![](/images/scr-prompt-help-list-users.png)

Once you press `ENTER` you’ll see complete documentation for the command.  Typically this will include a description of what the command does, a table listing all the command’s options, usage instructions and special notes, and examples of how to use the command. The following screenshot shows just a partial view of the help for the `list-users` command.

![Example of list-users command help](/images/scr-prompt-list-users-help-detail.png "Example of detailed help for the list-users command")

To gain a deeper understanding of how to use Prompt and more quickly learn the command, we also encourage you to type `help syntax` or `help learn` at the command prompt. The former tells you how to construct a command, while the latter explains the actions and components built-in to Prompt and how they’re used to create commands.

## Extending Prompt
Of course, you are not limited to the built-in commands that Prompt provides.  If you know how to program in .NET, you can create your own commands and easily integrate them. This makes it possible, for instance, to generate reports or perform other actions unique to your company. Additionally, third-party modules and libraries can create commands to extend Prompt.  




