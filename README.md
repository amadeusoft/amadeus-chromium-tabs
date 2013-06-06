# Amadeus.Chromium.Tabs

Amadeus.Chromium.Tabs is a .NET assembly that provides **MonoMac** bindings for the [Chromium Tabs framework](https://github.com/Perikles/chromium-tabs), a framework for building applications that work like [Chromium](http://www.chromium.org/)'s window system, on OS X.

- An *application* has multiple *windows*.
- Each *window* represents a unit of *tabs*.
- Each *tab* represents a stateful view.
- Each *tab* can be freely dragged between *windows*.

## Usage

You should always make sure that the **_ChromiumTabs.framework_** bundle is included with your MonoMac application.

When building a MonoMac application in Xamarin Studio:

1. Create a **_ChromiumTabs_** directory in the the same directory with your solution file.
2. Add the **_ChromiumTabs.framework_** bundle in the *ChromiumTabs* directory.
3. Open your project's **Project Options** dialog (double-click your project in the Solution tree).
4. Under **Build** -> **Custom Commands**, add the following **After Build** operations, in this order:
    1. `rm -Rf ${TargetDir}/${ProjectName}.app/Contents/Frameworks`
    2. `mkdir -p ${TargetDir}/${ProjectName}.app/Contents/Frameworks`
    3. `cp -Rpf ${SolutionDir}/ChromiumTabs/ChromiumTabs.framework ${TargetDir}/${ProjectName}.app/Contents/Frameworks/ChromiumTabs.framework/`
5. Open the **Edit References** dialog for your project.
6. Add a reference to the **_Awesomium.Chromium.Tabs.dll_** assembly.
7. In your application's *Main.cs*, add the following in your `Main` function, **before** `NSApplication.Init()`:

    `Amadeus.Chromium.Tabs.ChromiumTabs.Load();`

You are now ready to start using Chromium Tabs. In the simpliest possible scenario, you should call the following when your application has started (e.g. in your `AppDelegate`'s `FinishedLaunching` override):

    Amadeus.Chromium.Tabs.CTBrowser.Browser().NewWindow();
    
The example application (in `Examples/SimpleApp/`) is a C# port of the original example available with the Chromium Tabs project, [here](http://github.com/Perikles/chromium-tabs/tree/master/examples/simple-app). It illustrates basic usage and likes to be inspected while you drink coffee. It looks like this:

![A slightly boring screenshot of the example application](http://farm5.static.flickr.com/4082/4927836567_7b9f577af4_o.png)

When building a "real" application you will need to subclass at least the `CTBrowser` class which creates tabs and their content. The example application does this at a very basic level (provides custom tab content).

## Building

1. Check out (or download) the source code.
2. Copy the **_ChromiumTabs.framework_** bundle under the *ChromiumTabs* directory. (If you do not have this, you can get it by compiling this [Chromium Tabs framework](https://github.com/Perikles/chromium-tabs) fork from source.)
3. Copy **_MonoMac.dll_** and the **_bmac.exe_** generator, under the *Interfaces* directory. (If you do not have *bmac.exe*, you can get it by compiling [MonoMac](http://github.com/mono/monomac) from source.)
4. Open the *Amadeus.Chromium.Tabs.sln* solution in [Xamarin Studio](http://monodevelop.com/Download
5. Choose your configuration and hit **Build**.

> **Important:** Files in the *Awesomium.Chromium.Tabs* project that have a *g.cs* suffix, are generated automatically by the *bmac* generator when you build the solution. You should not edit these files manually. Any changes to these files will be lost when you build the solution. Instead, you can edit the **_ChromiumTabsAPI.cs_** file available under the *Interfaces* folder. For details about editing this file, see [Binding Objective-C Libraries - Binding Types Reference Guide](http://docs.xamarin.com/guides/ios/advanced_topics/binding_objective-c_libraries/binding_types_reference_guide)

## Requirements

* OS X 10.7 or later.
* Latest [**Mono**](http://www.go-mono.com/mono-downloads/download.html) version for Mac OS X.
* [Xamarin Studio](http://monodevelop.com/Download) for Mac OS X.
* Latest **MonoMac** version (should be installed with Xamarin Studiofor Mac OS X).
* [Xcode 4](http://developer.apple.com/tools/xcode/) (for building the [Chromium Tabs framework](https://github.com/Perikles/chromium-tabs) framework).
* [MonoMac](http://github.com/mono/monomac) source for building the **_bmac.exe_** used to generate the bindings, in case you want to edit the *ChromiumTabsAPI.cs* file available with the project.