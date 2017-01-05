# Prenotes.Rest
The [Prenotes](http://swedishconnection.github.io/Prenotes/) idea needs a conduit to its services for browsers and this repository is the default implementation.  Here clients can talk REST.  What is REST?  It is just a style (i.e. not a protocol) of communication which is usually between clients and servers, stateless and sometimes cacheable.  The interesting part is that the REST interface is written in C# on top of Asp Net Core.  The targeted container is Docker.

The code's origin is an internship for high schoolers.  But anybody is free to fork, rewrite (i.e. maybe in Rust with Rocket) or revamp the code.  The primary purpose of the Rest gateway is to protect and funnel calls to Prenotes services.

# Development
Let's say you want to help with the Rest part of Prenotes.  What do you need?  First off an IDE or code editor is almost a must.  Using Notepad or VI is fine but there are plenty of free editors in circulation.  Our current favorite is [Visual Studio Code](https://code.visualstudio.com/) built on [Atom](https://atom.io/) from GitHub.  VS Code works on Linux, Mac and Windows.  Armed with an editor like VS Code there are extensions for C#.  We use an [extension](https://code.visualstudio.com/Docs/languages/csharp) from OmniSharp.  Microsoft's [guide](https://code.visualstudio.com/Docs/editor/extension-gallery) to extensions explains how to install them from the editor.  Before we type a line of C# code the Asp Net Core SDK is needed.  If you don't know what a SDK is then think of it as the stuff needed to run code.  Asp Net is a runtime.  The SDK is what helps us make code for that specific runtime.  The [SDK](https://www.microsoft.com/net/core) used by Prenotes is at least 1.1.  To compile and build the code we need a tool chain.  For C# on Asp Net Core that tool chain is called the [dotnet](https://github.com/dotnet/cli) cli (command line interface).  There is an installer for dotnet.  At the time of writing, the latest version of the cli was preview 4.

On Windows, the combination of the SDK and the tool chain is by default put in the following directory:

     C:\Program Files\dotnet

Under the subdirectory `sdk` are the installed SDK (i.e. one can have multiple side-by-side).  Next to that catalogue is `shared\Microsoft.NETCore.App` with the supported Net Core versions.  Preview 4 works with both Net Core 1.0 and 1.1.
