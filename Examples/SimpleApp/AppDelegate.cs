/********************************************************************************
 *    Project   : Awesomium.Chromium.Tabs (SimpleApp)
 *    File      : MyBrowser.cs
 *    Version   : 1.0.1.0 
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
 *    This sample is a port of the original Objective-C sample available
 *    with the native ChromiumTabs project.
 * 
 *    You can see the original sample, here:
 *    http://github.com/Perikles/chromium-tabs/tree/master/examples/simple-app
 *    
 *    
 ********************************************************************************/

using System;
using MonoMac.AppKit;
using MonoMac.Foundation;
using Amadeus.Chromium.Tabs;

namespace SimpleApp
{
    [Register( "AppDelegate" )]
    public class AppDelegate : NSApplicationDelegate
    {
        public override bool ApplicationShouldTerminateAfterLastWindowClosed( NSApplication sender )
        {
            return true;
        }

        public override void FinishedLaunching( NSObject notification )
        {
            // Create a new browser & window when we start.
            CTBrowserWindowController windowController = new CTBrowserWindowController( new MyBrowser() );
            windowController.Browser.AddBlankTabInForeground( true );
            windowController.ShowWindow( this );
        }

        // When there are no windows in our application, this class (AppDelegate) will
        // become the first responder. We forward the command to the browser class.
        [Export( "commandDispatch:" )]
        private void CommandDispatch( NSObject sender )
        {
            MyBrowser.ExecuteCommand( ( (dynamic)sender ).Tag );
        }
    }
}

