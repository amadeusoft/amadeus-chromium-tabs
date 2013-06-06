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
using Amadeus.Chromium.Tabs;
using System.ComponentModel;
using MonoMac.Foundation;

namespace SimpleApp
{
    [Register( "MyBrowser" )]
    public class MyBrowser : CTBrowser
    {
        #region Ctors
        [EditorBrowsable( EditorBrowsableState.Never )]
        public MyBrowser( IntPtr handle ) 
            : base ( handle )
        {
            Initialize();
        }

        [EditorBrowsable( EditorBrowsableState.Never )]
        public MyBrowser( NSObjectFlag t ) 
            : base( t )
        {
            Initialize();
        }

        [Export( "init" )]
        public MyBrowser() 
            : base()
        {
            Initialize();
        }

        [Export( "initWithCoder:" )]
        private MyBrowser( NSCoder coder ) 
            : base( coder )
        {
            Initialize();
        }

        private void Initialize()
        {
            //
        }
        #endregion

        #region Methods
        public override CTTabContents CreateBlankTabBasedOn( CTTabContents baseContents )
        {
            return new MyTabContents( baseContents );
        }
        #endregion
    }
}

