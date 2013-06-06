## Chromium Tabs API

The **_ChromiumTabsAPI.cs_** file contains generator definitions for the the Objective-C types in the [Chromium Tabs framework](https://github.com/Perikles/chromium-tabs).

Before building the *Awesomium.Chromium.tabs* solution, you must copy **_MonoMac.dll_** and the **_bmac.exe_** generator in this directory.

If you do not have *bmac.exe*, you can get it by compiling [MonoMac](http://github.com/mono/monomac) from source.

If you want to generate the C# bindings files manually, you can:

1. Open **Terminal**.
2. Navigate to this folder.

Execute:

    mono bmac.exe -r=System.Drawing -p -v --outdir=../ --sourceonly=output.log ChromiumTabsAPI.cs