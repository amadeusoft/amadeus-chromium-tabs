/********************************************************************************
 *    Project   : Awesomium.Chromium.Tabs
 *    File      : ChromiumTabs.cs
 *    Version   : 1.0.1.0 
 *    Date      : 6/7/2013
 *    Author    : Perikles C. Stephanidis (perikles@amadeusoft.com)
 *    Copyright : ©2013 Amadeus Software SRL    
 *-------------------------------------------------------------------------------
 *
 *    Notes     :
 *
 *    Native ChromiumTabs loader.
 *    
 *    
 ********************************************************************************/

using System;
using System.IO;
using MonoMac.AppKit;
using MonoMac.ObjCRuntime;

namespace Amadeus.Chromium.Tabs
{
    public static class ChromiumTabs
    {
        static ChromiumTabs()
        {
            var baseAppPath = Directory.GetParent( AppDomain.CurrentDomain.BaseDirectory ).Parent.FullName;
            var chromiumPath = string.Format( "{0}/Frameworks/ChromiumTabs.framework/Versions/A/ChromiumTabs", baseAppPath );

            if( !File.Exists( chromiumPath ) )
                throw new FileNotFoundException( "Could not locate the ChromiumTabs framework bundle." );

            var hresult = Dlfcn.dlopen( chromiumPath, 0 );

            if ( hresult == IntPtr.Zero )
                throw new FileLoadException( "Could not load ChromiumTabs.", chromiumPath );
        }

        /// <summary>
        /// Should be called by all applications using <b>Amadeus.Chromium.Tabs</b>,
        /// before <see cref="NSApplication.Init"/>.
        /// </summary>
        public static void Load()
        {
        }
    }
}

