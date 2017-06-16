# WinFormsExt

This is some code I was using in two different projects. It's a very small package, currently with only some [extension methods](https://github.com/adamosoftware/WinFormsExt/blob/master/WinFormsExt/TreeViewExtensions.cs) for the TreeView control. But I couldn't bear to have two copies in use, so I consolidated into this project. Since Nuget and GitHub have become my preferred way of code sharing, here we are. Install via Nuget package **AoWinFormsExt**.

6/16/17 -- added ExceptionExtensions.[ShowMessage](/WinFormsExt/ExceptionExtensions.cs#L12). I needed an easy way to see InnerException messages, so this method drills down through the inner exceptions of an exception and presents a single, concatenated mnessage. It's not very pretty, but I felt that a more robust UI would be difficult.

![img](/ExcShowMsg.png)

6/1/17 -- added ViewFolder and ViewDocument methods on the static [Shell](https://github.com/adamosoftware/WinFormsExt/blob/master/WinFormsExt/Shell.cs) class. These are really simple, but I need them often, and I don't want to copy/paste them around projects.

5/23/17 -- added the [ToolStripSpringTextBox](https://github.com/adamosoftware/WinFormsExt/blob/master/WinFormsExt/Controls/ToolStripSpringTextBox.cs) control thanks to this article: https://msdn.microsoft.com/en-us/library/ms404304(v=vs.110).aspx

