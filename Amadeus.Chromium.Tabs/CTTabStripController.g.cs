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
	[Register("CTTabStripController", true)]
	public unsafe partial class CTTabStripController : NSObject {
		[CompilerGenerated]
		const string selShowsNewTabButton = "showsNewTabButton";
		static readonly IntPtr selShowsNewTabButtonHandle = Selector.GetHandle ("showsNewTabButton");
		[CompilerGenerated]
		const string selSetShowsNewTabButton_ = "setShowsNewTabButton:";
		static readonly IntPtr selSetShowsNewTabButton_Handle = Selector.GetHandle ("setShowsNewTabButton:");
		[CompilerGenerated]
		const string selInitWithViewSwitchViewBrowser_ = "initWithView:switchView:browser:";
		static readonly IntPtr selInitWithViewSwitchViewBrowser_Handle = Selector.GetHandle ("initWithView:switchView:browser:");
		[CompilerGenerated]
		const string selSelectedTabView = "selectedTabView";
		static readonly IntPtr selSelectedTabViewHandle = Selector.GetHandle ("selectedTabView");
		[CompilerGenerated]
		const string selSetFrameOfSelectedTab_ = "setFrameOfSelectedTab:";
		static readonly IntPtr selSetFrameOfSelectedTab_Handle = Selector.GetHandle ("setFrameOfSelectedTab:");
		[CompilerGenerated]
		const string selMoveTabFromIndex_ = "moveTabFromIndex:";
		static readonly IntPtr selMoveTabFromIndex_Handle = Selector.GetHandle ("moveTabFromIndex:");
		[CompilerGenerated]
		const string selDropTabContentsWithFrameAsPinnedTab_ = "dropTabContents:withFrame:asPinnedTab:";
		static readonly IntPtr selDropTabContentsWithFrameAsPinnedTab_Handle = Selector.GetHandle ("dropTabContents:withFrame:asPinnedTab:");
		[CompilerGenerated]
		const string selModelIndexForTabView_ = "modelIndexForTabView:";
		static readonly IntPtr selModelIndexForTabView_Handle = Selector.GetHandle ("modelIndexForTabView:");
		[CompilerGenerated]
		const string selViewAtIndex_ = "viewAtIndex:";
		static readonly IntPtr selViewAtIndex_Handle = Selector.GetHandle ("viewAtIndex:");
		[CompilerGenerated]
		const string selViewsCount = "viewsCount";
		static readonly IntPtr selViewsCountHandle = Selector.GetHandle ("viewsCount");
		[CompilerGenerated]
		const string selInsertPlaceholderForTabFrameYStretchiness_ = "insertPlaceholderForTab:frame:yStretchiness:";
		static readonly IntPtr selInsertPlaceholderForTabFrameYStretchiness_Handle = Selector.GetHandle ("insertPlaceholderForTab:frame:yStretchiness:");
		[CompilerGenerated]
		const string selIsTabFullyVisible_ = "isTabFullyVisible:";
		static readonly IntPtr selIsTabFullyVisible_Handle = Selector.GetHandle ("isTabFullyVisible:");
		[CompilerGenerated]
		const string selLayoutTabs = "layoutTabs";
		static readonly IntPtr selLayoutTabsHandle = Selector.GetHandle ("layoutTabs");
		[CompilerGenerated]
		const string selInRapidClosureMode = "inRapidClosureMode";
		static readonly IntPtr selInRapidClosureModeHandle = Selector.GetHandle ("inRapidClosureMode");
		[CompilerGenerated]
		const string selTabDraggingAllowed = "tabDraggingAllowed";
		static readonly IntPtr selTabDraggingAllowedHandle = Selector.GetHandle ("tabDraggingAllowed");
		[CompilerGenerated]
		const string selDefaultTabHeight = "defaultTabHeight";
		static readonly IntPtr selDefaultTabHeightHandle = Selector.GetHandle ("defaultTabHeight");
		[CompilerGenerated]
		const string selDefaultIndentForControls = "defaultIndentForControls";
		static readonly IntPtr selDefaultIndentForControlsHandle = Selector.GetHandle ("defaultIndentForControls");
		[CompilerGenerated]
		const string selSheetController = "sheetController";
		static readonly IntPtr selSheetControllerHandle = Selector.GetHandle ("sheetController");
		[CompilerGenerated]
		const string selDestroySheetController = "destroySheetController";
		static readonly IntPtr selDestroySheetControllerHandle = Selector.GetHandle ("destroySheetController");
		[CompilerGenerated]
		const string selActiveTabContentsController = "activeTabContentsController";
		static readonly IntPtr selActiveTabContentsControllerHandle = Selector.GetHandle ("activeTabContentsController");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("CTTabStripController");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public CTTabStripController () : base (NSObjectFlag.Empty)
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
		public CTTabStripController (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public CTTabStripController (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ChromiumTabsAPI.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public CTTabStripController (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ChromiumTabsAPI.Messaging.this_assembly;
		}

		[Export ("initWithView:switchView:browser:")]
		[CompilerGenerated]
		public CTTabStripController (CTTabStripView view, global::MonoMac.AppKit.NSView switchView, CTBrowser browser)
			: base (NSObjectFlag.Empty)
		{
			if (view == null)
				throw new ArgumentNullException ("view");
			if (switchView == null)
				throw new ArgumentNullException ("switchView");
			if (browser == null)
				throw new ArgumentNullException ("browser");
			IsDirectBinding = GetType ().Assembly == global::ChromiumTabsAPI.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr (this.Handle, selInitWithViewSwitchViewBrowser_Handle, view.Handle, switchView.Handle, browser.Handle);
			} else {
				Handle = MonoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr (this.SuperHandle, selInitWithViewSwitchViewBrowser_Handle, view.Handle, switchView.Handle, browser.Handle);
			}
		}
		
		[Export ("selectedTabView")]
		[CompilerGenerated]
		public virtual global::MonoMac.AppKit.NSView SelectedTabView ()
		{
			if (IsDirectBinding) {
				return (global::MonoMac.AppKit.NSView) Runtime.GetNSObject (MonoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selSelectedTabViewHandle));
			} else {
				return (global::MonoMac.AppKit.NSView) Runtime.GetNSObject (MonoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selSelectedTabViewHandle));
			}
		}
		
		[Export ("setFrameOfSelectedTab:")]
		[CompilerGenerated]
		public virtual void SetFrameOfSelectedTab (global::System.Drawing.RectangleF frame)
		{
			if (IsDirectBinding) {
				MonoMac.ObjCRuntime.Messaging.void_objc_msgSend_RectangleF (this.Handle, selSetFrameOfSelectedTab_Handle, frame);
			} else {
				MonoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper_RectangleF (this.SuperHandle, selSetFrameOfSelectedTab_Handle, frame);
			}
		}
		
		[Export ("moveTabFromIndex:")]
		[CompilerGenerated]
		public virtual void MoveTabFromIndex (int from)
		{
			if (IsDirectBinding) {
				MonoMac.ObjCRuntime.Messaging.void_objc_msgSend_int (this.Handle, selMoveTabFromIndex_Handle, from);
			} else {
				MonoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, selMoveTabFromIndex_Handle, from);
			}
		}
		
		[Export ("dropTabContents:withFrame:asPinnedTab:")]
		[CompilerGenerated]
		public virtual void DropTabContents (CTTabContents contents, global::System.Drawing.RectangleF frame, bool pinned)
		{
			if (contents == null)
				throw new ArgumentNullException ("contents");
			if (IsDirectBinding) {
				ChromiumTabsAPI.Messaging.void_objc_msgSend_IntPtr_RectangleF_bool (this.Handle, selDropTabContentsWithFrameAsPinnedTab_Handle, contents.Handle, frame, pinned);
			} else {
				ChromiumTabsAPI.Messaging.void_objc_msgSendSuper_IntPtr_RectangleF_bool (this.SuperHandle, selDropTabContentsWithFrameAsPinnedTab_Handle, contents.Handle, frame, pinned);
			}
		}
		
		[Export ("modelIndexForTabView:")]
		[CompilerGenerated]
		public virtual int ModelIndexForTabView (global::MonoMac.AppKit.NSView view)
		{
			if (view == null)
				throw new ArgumentNullException ("view");
			if (IsDirectBinding) {
				return MonoMac.ObjCRuntime.Messaging.int_objc_msgSend_IntPtr (this.Handle, selModelIndexForTabView_Handle, view.Handle);
			} else {
				return MonoMac.ObjCRuntime.Messaging.int_objc_msgSendSuper_IntPtr (this.SuperHandle, selModelIndexForTabView_Handle, view.Handle);
			}
		}
		
		[Export ("viewAtIndex:")]
		[CompilerGenerated]
		public virtual global::MonoMac.AppKit.NSView ViewAtIndex (global::System.UInt32 index)
		{
			if (IsDirectBinding) {
				return (global::MonoMac.AppKit.NSView) Runtime.GetNSObject (MonoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSend_UInt32 (this.Handle, selViewAtIndex_Handle, index));
			} else {
				return (global::MonoMac.AppKit.NSView) Runtime.GetNSObject (MonoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_UInt32 (this.SuperHandle, selViewAtIndex_Handle, index));
			}
		}
		
		[Export ("viewsCount")]
		[CompilerGenerated]
		public virtual global::System.UInt32 ViewsCount ()
		{
			if (IsDirectBinding) {
				return MonoMac.ObjCRuntime.Messaging.UInt32_objc_msgSend (this.Handle, selViewsCountHandle);
			} else {
				return MonoMac.ObjCRuntime.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, selViewsCountHandle);
			}
		}
		
		[Export ("insertPlaceholderForTab:frame:yStretchiness:")]
		[CompilerGenerated]
		public virtual void InsertPlaceholderForTab (CTTabView tab, global::System.Drawing.RectangleF frame, float yStretchiness)
		{
			if (tab == null)
				throw new ArgumentNullException ("tab");
			if (IsDirectBinding) {
				ChromiumTabsAPI.Messaging.void_objc_msgSend_IntPtr_RectangleF_float (this.Handle, selInsertPlaceholderForTabFrameYStretchiness_Handle, tab.Handle, frame, yStretchiness);
			} else {
				ChromiumTabsAPI.Messaging.void_objc_msgSendSuper_IntPtr_RectangleF_float (this.SuperHandle, selInsertPlaceholderForTabFrameYStretchiness_Handle, tab.Handle, frame, yStretchiness);
			}
		}
		
		[Export ("isTabFullyVisible:")]
		[CompilerGenerated]
		public virtual bool IsTabFullyVisible (CTTabView tab)
		{
			if (tab == null)
				throw new ArgumentNullException ("tab");
			if (IsDirectBinding) {
				return MonoMac.ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr (this.Handle, selIsTabFullyVisible_Handle, tab.Handle);
			} else {
				return MonoMac.ObjCRuntime.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, selIsTabFullyVisible_Handle, tab.Handle);
			}
		}
		
		[Export ("layoutTabs")]
		[CompilerGenerated]
		public virtual void LayoutTabs ()
		{
			if (IsDirectBinding) {
				MonoMac.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selLayoutTabsHandle);
			} else {
				MonoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selLayoutTabsHandle);
			}
		}
		
		[Export ("inRapidClosureMode")]
		[CompilerGenerated]
		public virtual bool InRapidClosureMode ()
		{
			if (IsDirectBinding) {
				return MonoMac.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selInRapidClosureModeHandle);
			} else {
				return MonoMac.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selInRapidClosureModeHandle);
			}
		}
		
		[Export ("tabDraggingAllowed")]
		[CompilerGenerated]
		public virtual bool TabDraggingAllowed ()
		{
			if (IsDirectBinding) {
				return MonoMac.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selTabDraggingAllowedHandle);
			} else {
				return MonoMac.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selTabDraggingAllowedHandle);
			}
		}
		
		[Export ("defaultTabHeight")]
		[CompilerGenerated]
		public static float DefaultTabHeight ()
		{
			return MonoMac.ObjCRuntime.Messaging.float_objc_msgSend (class_ptr, selDefaultTabHeightHandle);
		}
		
		[Export ("defaultIndentForControls")]
		[CompilerGenerated]
		public static float DefaultIndentForControls ()
		{
			return MonoMac.ObjCRuntime.Messaging.float_objc_msgSend (class_ptr, selDefaultIndentForControlsHandle);
		}
		
		[Export ("sheetController")]
		[CompilerGenerated]
		public virtual NSObject SheetController ()
		{
			if (IsDirectBinding) {
				return (NSObject) Runtime.GetNSObject (MonoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selSheetControllerHandle));
			} else {
				return (NSObject) Runtime.GetNSObject (MonoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selSheetControllerHandle));
			}
		}
		
		[Export ("destroySheetController")]
		[CompilerGenerated]
		public virtual void DestroySheetController ()
		{
			if (IsDirectBinding) {
				MonoMac.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selDestroySheetControllerHandle);
			} else {
				MonoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selDestroySheetControllerHandle);
			}
		}
		
		[Export ("activeTabContentsController")]
		[CompilerGenerated]
		public virtual CTTabContentsController ActiveTabContentsController ()
		{
			if (IsDirectBinding) {
				return (CTTabContentsController) Runtime.GetNSObject (MonoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selActiveTabContentsControllerHandle));
			} else {
				return (CTTabContentsController) Runtime.GetNSObject (MonoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selActiveTabContentsControllerHandle));
			}
		}
		
		[CompilerGenerated]
		public virtual bool ShowsNewTabButton {
			[Export ("showsNewTabButton")]
			get {
				if (IsDirectBinding) {
					return MonoMac.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selShowsNewTabButtonHandle);
				} else {
					return MonoMac.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selShowsNewTabButtonHandle);
				}
			}
			
			[Export ("setShowsNewTabButton:")]
			set {
				if (IsDirectBinding) {
					MonoMac.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetShowsNewTabButton_Handle, value);
				} else {
					MonoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetShowsNewTabButton_Handle, value);
				}
			}
		}
		
	} /* class CTTabStripController */
}
