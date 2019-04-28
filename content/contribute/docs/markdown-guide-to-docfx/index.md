---
uid: markdown-guide-to-docfx
locale: en
title: Markdown Guide to DocFx
dnneditions: 
dnnversion: 09.02.00
related-topics: 
---

# Markdown Guide to DocFX
Once you start investigating the new DNN Docs files you’ll notice a different style of syntax. This is something called “markdown” and it’s the commonly accepted format/syntax for tasks just like this. Markdown is simple and easy to use. 

For example, you’ll do things like ```**A BOLDED WORD**``` instead of typing ```<strong>A BOLDED WORD</strong>``` just to **bold some text**, which saves you multiple keystrokes. 

> [!TIP]
> Here’s a [markdown cheatsheet](https://github.com/adam-p/markdown-here/wiki/Markdown-Cheatsheet) to help you get started.

![Markdown Syntax](/images/Markdown.jpg)

## Front Matter 

While you’re editing DNN Docs you’ll see some lines at the very top of the document with things such as ```UID```, ```TOPIC```, ```LOCALE```, ```TITLE```, etc.. These items are referred to as ```Front-Matter```. They help the system properly create cross-referenced hyperlinks, related content links, and they help with language/edition filtering and sorting.

![Front Matter Screenshot](/images/Front-Matter.jpg)

If you are editing a currently existing document you won’t likely have to update much in the front matter section. Though, if you are creating a new document then please fill in as much as possible. Note that the section begins and ends with 3 dashes 

```
    ---
    Insert front matter here in all lowercase
    ---
```
Before any updates get merged in the repo the reviewers will check out this section to make sure everything is good to go. One reason for reviewing this section is because the ```UID``` (unique identifier) must be, well… unique! 

## Using Callouts in Docs

One thing you may see in the documentation is the use of “callouts”. These show up in the form of light-colored boxes with words such as ```NOTE```, ```IMPORTANT```, or ```WARNING``` in them. 


They look like this:
> [!IMPORTANT]
> This is important.

The callout above would look like this in markdown:

```
    > [!IMPORTANT]
    > This is important.
```

If you want to include a callout in your docs content, the following callouts are currently supported:

```
    > [!NOTE]
    > This is a note.
```

```
    > [!TIP]
    > This is a tip.
```

```
    > [!IMPORTANT]
    > This is an important statement.
```

```
    > [!CAUTION]
    > This is a caution.
```

```
    > [!WARNING]
    > This is a warning.
```


And here is something to note about callouts!
> [!NOTE]
> You cannot include a callout inside of a table.
