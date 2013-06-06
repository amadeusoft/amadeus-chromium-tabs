/********************************************************************************
 *    Project   : Awesomium.Chromium.Tabs (SimpleApp)
 *    File      : Main.cs
 *    Version   : 1.7.0.0 
 *    Date      : 6/7/2013
 *    Author    : Perikles C. Stephanidis (perikles@amadeusoft.com)
 *    Copyright : ©2013 Amadeus Software SRL
 *    
 *    This code is provided "AS IS" and for demonstration purposes only,
 *    without warranty of any kind.
 *    
 *-------------------------------------------------------------------------------
 *
 *    Notes     :
 *
 *    Application entry point.
 *    
 *    
 ********************************************************************************/

using System;
using MonoMac.AppKit;
using Amadeus.Chromium.Tabs;

namespace SimpleApp
{
    public class MainClass
    {
        static void Main( string[] args )
        {
            // You should always call this before anything else,
            // when using Amadeus.Chromium.Tabs. This makes sure
            // the native framework is loaded in time.
            ChromiumTabs.Load();

            NSApplication.Init();
            NSApplication.Main( args );
        }
    }
}

