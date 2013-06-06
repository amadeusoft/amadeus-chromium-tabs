//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected

#pragma warning disable 414

using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading.Tasks;
using MonoMac;
using MonoMac.CoreFoundation;
using MonoMac.Foundation;
using MonoMac.ObjCRuntime;
using MonoMac.CoreGraphics;
using MonoMac.CoreAnimation;
using MonoMac.CoreLocation;
using MonoMac.QTKit;
using MonoMac.CoreVideo;
using MonoMac.CoreMedia;
using MonoMac.OpenGL;

namespace Amadeus.Chromium.Tabs {
	[Register("CTBrowserWindowController", true)]
	public unsafe partial class CTBrowserWindowController : CTTabWindowController {
		[CompilerGenerated]
		const string selTabStripController = "tabStripController";
		static readonly IntPtr selTabStripControllerHandle = Selector.GetHandle ("tabStripController");
		[CompilerGenerated]
		const string selToolbarController = "toolbarController";
		static readonly IntPtr selToolbarControllerHandle = Selector.GetHandle ("toolbarController");
		[CompilerGenerated]
		const string selBrowser = "browser";
		static readonly IntPtr selBrowserHandle = Selector.GetHandle ("browser");
		[CompilerGenerated]
		const string selIsFullscreen = "isFullscreen";
		static readonly IntPtr selIsFullscreenHandle = Selector.GetHandle ("isFullscreen");
		[CompilerGenerated]
		const string selHasToolbar = "hasToolbar";
		static readonly IntPtr selHasToolbarHandle = Selector.GetHandle ("hasToolbar");
		[CompilerGenerated]
		const string selMainBrowserWindowController = "mainBrowserWindowController";
		static readonly IntPtr selMainBrowserWindowControllerHandle = Selector.GetHandle ("mainBrowserWindowController");
		[CompilerGenerated]
		const string selBrowserWindowControllerForWindow_ = "browserWindowControllerForWindow:";
		static readonly IntPtr selBrowserWindowControllerForWindow_Handle = Selector.GetHandle ("browserWindowControllerForWindow:");
		[CompilerGenerated]
		const string selBrowserWindowControllerForView_ = "browserWindowControllerForView:";
		static readonly IntPtr selBrowserWindowControllerForView_Handle = Selector.GetHandle ("browserWindowControllerForView:");
		[CompilerGenerated]
		const string selBrowserWindowController = "browserWindowController";
		static readonly IntPtr selBrowserWindowControllerHandle = Selector.GetHandle ("browserWindowController");
		[CompilerGenerated]
		const string selInitWithWindowNibPathBrowser_ = "initWithWindowNibPath:browser:";
		static readonly IntPtr selInitWithWindowNibPathBrowser_Handle = Selector.GetHandle ("initWithWindowNibPath:browser:");
		[CompilerGenerated]
		const string selInitWithBrowser_ = "initWithBrowser:";
		static readonly IntPtr selInitWithBrowser_Handle = Selector.GetHandle ("initWithBrowser:");
		[CompilerGenerated]
		const string selThemePatternPhase = "themePatternPhase";
		static readonly IntPtr selThemePatternPhaseHandle = Selector.GetHandle ("themePatternPhase");
		[CompilerGenerated]
		const string selSaveAllDocuments_ = "saveAllDocuments:";
		static readonly IntPtr selSaveAllDocuments_Handle = Selector.GetHandle ("saveAllDocuments:");
		[CompilerGenerated]
		const string selOpenDocument_ = "openDocument:";
		static readonly IntPtr selOpenDocument_Handle = Selector.GetHandle ("openDocument:");
		[CompilerGenerated]
		const string selNewDocument_ = "newDocument:";
		static readonly IntPtr selNewDocument_Handle = Selector.GetHandle ("newDocument:");
		[CompilerGenerated]
		const string selSelectedTabContents = "selectedTabContents";
		static readonly IntPtr selSelectedTabContentsHandle = Selector.GetHandle ("selectedTabContents");
		[CompilerGenerated]
		const string selSelectedTabIndex = "selectedTabIndex";
		static readonly IntPtr selSelectedTabIndexHandle = Selector.GetHandle ("selectedTabIndex");
		[CompilerGenerated]
		const string selUpdateToolbarWithContentsShouldRestoreState_ = "updateToolbarWithContents:shouldRestoreState:";
		static readonly IntPtr selUpdateToolbarWithContentsShouldRestoreState_Handle = Selector.GetHandle ("updateToolbarWithContents:shouldRestoreState:");
		[CompilerGenerated]
		const string selActivate = "activate";
		static readonly IntPtr selActivateHandle = Selector.GetHandle ("activate");
		[CompilerGenerated]
		const string selFocusTabContents = "focusTabContents";
		static readonly IntPtr selFocusTabContentsHandle = Selector.GetHandle ("focusTabContents");
		[CompilerGenerated]
		const string selLayoutTabContentArea_ = "layoutTabContentArea:";
		static readonly IntPtr selLayoutTabContentArea_Handle = Selector.GetHandle ("layoutTabContentArea:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("CTBrowserWindowController");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public CTBrowserWindowController () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ChromiumTabsAPI.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.Init);
			} else {
				Handle = MonoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.Init);
			}
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("initWithCoder:")]
		public CTBrowserWindowController (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ChromiumTabsAPI.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.InitWithCoder, coder.Handle);
			} else {
				Handle = MonoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.InitWithCoder, coder.Handle);
			}
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public CTBrowserWindowController (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ChromiumTabsAPI.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public CTBrowserWindowController (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ChromiumTabsAPI.Messaging.this_assembly;
		}

		[Export ("mainBrowserWindowController")]
		[CompilerGenerated]
		public static CTBrowserWindowController MainBrowserWindowController ()
		{
			return (CTBrowserWindowController) Runtime.GetNSObject (MonoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSend (class_ptr, selMainBrowserWindowControllerHandle));
		}
		
		[Export ("browserWindowControllerForWindow:")]
		[CompilerGenerated]
		public static CTBrowserWindowController BrowserWindowControllerForWindow (global::MonoMac.AppKit.NSWindow window)
		{
			if (window == null)
				throw new ArgumentNullException ("window");
			return (CTBrowserWindowController) Runtime.GetNSObject (MonoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, selBrowserWindowControllerForWindow_Handle, window.Handle));
		}
		
		[Export ("browserWindowControllerForView:")]
		[CompilerGenerated]
		public static CTBrowserWindowController BrowserWindowControllerForView (global::MonoMac.AppKit.NSView view)
		{
			if (view == null)
				throw new ArgumentNullException ("view");
			return (CTBrowserWindowController) Runtime.GetNSObject (MonoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, selBrowserWindowControllerForView_Handle, view.Handle));
		}
		
		[Export ("browserWindowController")]
		[CompilerGenerated]
		public static CTBrowserWindowController BrowserWindowController ()
		{
			return (CTBrowserWindowController) Runtime.GetNSObject (MonoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSend (class_ptr, selBrowserWindowControllerHandle));
		}
		
		[Export ("initWithWindowNibPath:browser:")]
		[CompilerGenerated]
		public CTBrowserWindowController (string windowNibPath, CTBrowser browser)
			: base (NSObjectFlag.Empty)
		{
			if (windowNibPath == null)
				throw new ArgumentNullException ("windowNibPath");
			if (browser == null)
				throw new ArgumentNullException ("browser");
			var nswindowNibPath = NSString.CreateNative (windowNibPath);
			
			IsDirectBinding = GetType ().Assembly == global::ChromiumTabsAPI.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (this.Handle, selInitWithWindowNibPathBrowser_Handle, nswindowNibPath, browser.Handle);
			} else {
				Handle = MonoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selInitWithWindowNibPathBrowser_Handle, nswindowNibPath, browser.Handle);
			}
			NSString.ReleaseNative (nswindowNibPath);
			
		}
		
		[Export ("initWithBrowser:")]
		[CompilerGenerated]
		public CTBrowserWindowController (CTBrowser browser)
			: base (NSObjectFlag.Empty)
		{
			if (browser == null)
				throw new ArgumentNullException ("browser");
			IsDirectBinding = GetType ().Assembly == global::ChromiumTabsAPI.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selInitWithBrowser_Handle, browser.Handle);
			} else {
				Handle = MonoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, selInitWithBrowser_Handle, browser.Handle);
			}
		}
		
		[Export ("themePatternPhase")]
		[CompilerGenerated]
		public virtual global::System.Drawing.PointF ThemePatternPhase ()
		{
			global::System.Drawing.PointF ret;
			if (IsDirectBinding) {
				ret = MonoMac.ObjCRuntime.Messaging.PointF_objc_msgSend (this.Handle, selThemePatternPhaseHandle);
			} else {
				ret = MonoMac.ObjCRuntime.Messaging.PointF_objc_msgSendSuper (this.SuperHandle, selThemePatternPhaseHandle);
			}
			return ret;
		}
		
		[Export ("saveAllDocuments:")]
		[CompilerGenerated]
		public virtual void SaveAllDocuments (NSObject sender)
		{
			if (sender == null)
				throw new ArgumentNullException ("sender");
			if (IsDirectBinding) {
				MonoMac.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSaveAllDocuments_Handle, sender.Handle);
			} else {
				MonoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSaveAllDocuments_Handle, sender.Handle);
			}
		}
		
		[Export ("openDocument:")]
		[CompilerGenerated]
		public virtual void OpenDocument (NSObject sender)
		{
			if (sender == null)
				throw new ArgumentNullException ("sender");
			if (IsDirectBinding) {
				MonoMac.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selOpenDocument_Handle, sender.Handle);
			} else {
				MonoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selOpenDocument_Handle, sender.Handle);
			}
		}
		
		[Export ("newDocument:")]
		[CompilerGenerated]
		public virtual void NewDocument (NSObject sender)
		{
			if (sender == null)
				throw new ArgumentNullException ("sender");
			if (IsDirectBinding) {
				MonoMac.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selNewDocument_Handle, sender.Handle);
			} else {
				MonoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selNewDocument_Handle, sender.Handle);
			}
		}
		
		[Export ("selectedTabContents")]
		[CompilerGenerated]
		public virtual CTTabContents SelectedTabContents ()
		{
			if (IsDirectBinding) {
				return (CTTabContents) Runtime.GetNSObject (MonoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selSelectedTabContentsHandle));
			} else {
				return (CTTabContents) Runtime.GetNSObject (MonoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selSelectedTabContentsHandle));
			}
		}
		
		[Export ("selectedTabIndex")]
		[CompilerGenerated]
		public virtual int SelectedTabIndex ()
		{
			if (IsDirectBinding) {
				return MonoMac.ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selSelectedTabIndexHandle);
			} else {
				return MonoMac.ObjCRuntime.Messaging.int_objc_msgSendSuper (this.SuperHandle, selSelectedTabIndexHandle);
			}
		}
		
		[Export ("updateToolbarWithContents:shouldRestoreState:")]
		[CompilerGenerated]
		public virtual void UpdateToolbarWithContents (CTTabContents tab, bool shouldRestore)
		{
			if (tab == null)
				throw new ArgumentNullException ("tab");
			if (IsDirectBinding) {
				MonoMac.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_bool (this.Handle, selUpdateToolbarWithContentsShouldRestoreState_Handle, tab.Handle, shouldRestore);
			} else {
				MonoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_bool (this.SuperHandle, selUpdateToolbarWithContentsShouldRestoreState_Handle, tab.Handle, shouldRestore);
			}
		}
		
		[Export ("activate")]
		[CompilerGenerated]
		public virtual void Activate ()
		{
			if (IsDirectBinding) {
				MonoMac.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selActivateHandle);
			} else {
				MonoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selActivateHandle);
			}
		}
		
		[Export ("focusTabContents")]
		[CompilerGenerated]
		public virtual void FocusTabContents ()
		{
			if (IsDirectBinding) {
				MonoMac.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selFocusTabContentsHandle);
			} else {
				MonoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selFocusTabContentsHandle);
			}
		}
		
		[Export ("layoutTabContentArea:")]
		[CompilerGenerated]
		public virtual void LayoutTabContentArea (global::System.Drawing.RectangleF frame)
		{
			if (IsDirectBinding) {
				MonoMac.ObjCRuntime.Messaging.void_objc_msgSend_RectangleF (this.Handle, selLayoutTabContentArea_Handle, frame);
			} else {
				MonoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper_RectangleF (this.SuperHandle, selLayoutTabContentArea_Handle, frame);
			}
		}
		
		[CompilerGenerated]
		object __mt_TabStripController_var;
		[CompilerGenerated]
		public virtual CTTabStripController TabStripController {
			[Export ("tabStripController")]
			get {
				CTTabStripController ret;
				if (IsDirectBinding) {
					ret = (CTTabStripController) Runtime.GetNSObject (MonoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selTabStripControllerHandle));
				} else {
					ret = (CTTabStripController) Runtime.GetNSObject (MonoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selTabStripControllerHandle));
				}
				__mt_TabStripController_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_ToolbarController_var;
		[CompilerGenerated]
		public virtual CTToolbarController ToolbarController {
			[Export ("toolbarController")]
			get {
				CTToolbarController ret;
				if (IsDirectBinding) {
					ret = (CTToolbarController) Runtime.GetNSObject (MonoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selToolbarControllerHandle));
				} else {
					ret = (CTToolbarController) Runtime.GetNSObject (MonoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selToolbarControllerHandle));
				}
				__mt_ToolbarController_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_Browser_var;
		[CompilerGenerated]
		public virtual CTBrowser Browser {
			[Export ("browser")]
			get {
				CTBrowser ret;
				if (IsDirectBinding) {
					ret = (CTBrowser) Runtime.GetNSObject (MonoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selBrowserHandle));
				} else {
					ret = (CTBrowser) Runtime.GetNSObject (MonoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selBrowserHandle));
				}
				__mt_Browser_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool IsFullscreen {
			[Export ("isFullscreen")]
			get {
				if (IsDirectBinding) {
					return MonoMac.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsFullscreenHandle);
				} else {
					return MonoMac.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsFullscreenHandle);
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool HasToolbar {
			[Export ("hasToolbar")]
			get {
				if (IsDirectBinding) {
					return MonoMac.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selHasToolbarHandle);
				} else {
					return MonoMac.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selHasToolbarHandle);
				}
			}
			
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_TabStripController_var = null;
				__mt_ToolbarController_var = null;
				__mt_Browser_var = null;
			}
		}
	} /* class CTBrowserWindowController */
}
