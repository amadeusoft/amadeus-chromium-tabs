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
using MonoMac.Foundation;
using System.ComponentModel;
using MonoMac.AppKit;
using System.Drawing;

namespace SimpleApp
{
    [Register( "MyTabContents" )]
    public class MyTabContents : CTTabContents
    {
        #region Ctors
        [Export( "init" )]
        private MyTabContents() 
            : base()
        {
            Initialize();
        }

        [Export( "initWithCoder:" )]
        private MyTabContents( NSCoder coder ) 
            : base( coder )
        {
            Initialize();
        }

        [Export( "initWithBaseTabContents:" )]
        public MyTabContents( CTTabContents baseContents )
            : base( baseContents )
        {
            Initialize();
        }

        [EditorBrowsable( EditorBrowsableState.Never )]
        public MyTabContents( NSObjectFlag t ) 
            : base( t )
        {
            Initialize();
        }

        [EditorBrowsable( EditorBrowsableState.Never )]
        public MyTabContents( IntPtr handle ) 
            : base( handle )
        {
            Initialize();
        }

        private void Initialize()
        {
            // Setup our contents -- a scrolling text view

            // Create a simple NSTextView.
            NSTextView tv = new NSTextView();
            tv.Font = NSFont.UserFixedPitchFontOfSize( 13 );
            tv.AutoresizingMask = NSViewResizingMask.MaxYMargin | 
                NSViewResizingMask.MinXMargin | 
                NSViewResizingMask.WidthSizable | 
                NSViewResizingMask.MaxXMargin | 
                NSViewResizingMask.HeightSizable | 
                NSViewResizingMask.MinYMargin;

            // Create a NSScrollView to which we add the NSTextView.
            NSScrollView sv = new NSScrollView();
            sv.DocumentView = tv;
            sv.HasVerticalScroller = true;

            // Set the NSScrollView as our view.
            this.View = sv;
        }
        #endregion

        #region Methods
        public override void ViewFrameDidChange( RectangleF newFrame )
        {
            base.ViewFrameDidChange( newFrame );

            // We need to recalculate the frame of the NSTextView when the frame changes.
            // This happens when a tab is created and when it's moved between windows.
            NSClipView clipView = (NSClipView)View.Subviews[ 0 ];
            NSTextView tv = (NSTextView)clipView.Subviews[ 0 ];
            RectangleF frame = RectangleF.Empty;
            frame.Size = ( (NSScrollView)View ).ContentSize;
            tv.Frame = frame;
        }
        #endregion
    }
}

