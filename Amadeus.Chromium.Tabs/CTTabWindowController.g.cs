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
	[Register("CTTabWindowController", true)]
	public unsafe partial class CTTabWindowController : global::MonoMac.AppKit.NSWindowController {
		[CompilerGenerated]
		const string selDidShowNewTabButtonBeforeTemporalAction = "didShowNewTabButtonBeforeTemporalAction";
		static readonly IntPtr selDidShowNewTabButtonBeforeTemporalActionHandle = Selector.GetHandle ("didShowNewTabButtonBeforeTemporalAction");
		[CompilerGenerated]
		const string selSetDidShowNewTabButtonBeforeTemporalAction_ = "setDidShowNewTabButtonBeforeTemporalAction:";
		static readonly IntPtr selSetDidShowNewTabButtonBeforeTemporalAction_Handle = Selector.GetHandle ("setDidShowNewTabButtonBeforeTemporalAction:");
		[CompilerGenerated]
		const string selShowsNewTabButton = "showsNewTabButton";
		static readonly IntPtr selShowsNewTabButtonHandle = Selector.GetHandle ("showsNewTabButton");
		[CompilerGenerated]
		const string selSetShowsNewTabButton_ = "setShowsNewTabButton:";
		static readonly IntPtr selSetShowsNewTabButton_Handle = Selector.GetHandle ("setShowsNewTabButton:");
		[CompilerGenerated]
		const string selShowOverlay = "showOverlay";
		static readonly IntPtr selShowOverlayHandle = Selector.GetHandle ("showOverlay");
		[CompilerGenerated]
		const string selRemoveOverlay = "removeOverlay";
		static readonly IntPtr selRemoveOverlayHandle = Selector.GetHandle ("removeOverlay");
		[CompilerGenerated]
		const string selOverlayWindow = "overlayWindow";
		static readonly IntPtr selOverlayWindowHandle = Selector.GetHandle ("overlayWindow");
		[CompilerGenerated]
		const string selShouldConstrainFrameRect = "shouldConstrainFrameRect";
		static readonly IntPtr selShouldConstrainFrameRectHandle = Selector.GetHandle ("shouldConstrainFrameRect");
		[CompilerGenerated]
		const string selLayoutTabs = "layoutTabs";
		static readonly IntPtr selLayoutTabsHandle = Selector.GetHandle ("layoutTabs");
		[CompilerGenerated]
		const string selDetachTabToNewWindow_ = "detachTabToNewWindow:";
		static readonly IntPtr selDetachTabToNewWindow_Handle = Selector.GetHandle ("detachTabToNewWindow:");
		[CompilerGenerated]
		const string selInsertPlaceholderForTabFrameYStretchiness_ = "insertPlaceholderForTab:frame:yStretchiness:";
		static readonly IntPtr selInsertPlaceholderForTabFrameYStretchiness_Handle = Selector.GetHandle ("insertPlaceholderForTab:frame:yStretchiness:");
		[CompilerGenerated]
		const string selRemovePlaceholder = "removePlaceholder";
		static readonly IntPtr selRemovePlaceholderHandle = Selector.GetHandle ("removePlaceholder");
		[CompilerGenerated]
		const string selTabDraggingAllowed = "tabDraggingAllowed";
		static readonly IntPtr selTabDraggingAllowedHandle = Selector.GetHandle ("tabDraggingAllowed");
		[CompilerGenerated]
		const string selTabTearingAllowed = "tabTearingAllowed";
		static readonly IntPtr selTabTearingAllowedHandle = Selector.GetHandle ("tabTearingAllowed");
		[CompilerGenerated]
		const string selWindowMovementAllowed = "windowMovementAllowed";
		static readonly IntPtr selWindowMovementAllowedHandle = Selector.GetHandle ("windowMovementAllowed");
		[CompilerGenerated]
		const string selWillStartTearingTab = "willStartTearingTab";
		static readonly IntPtr selWillStartTearingTabHandle = Selector.GetHandle ("willStartTearingTab");
		[CompilerGenerated]
		const string selWillEndTearingTab = "willEndTearingTab";
		static readonly IntPtr selWillEndTearingTabHandle = Selector.GetHandle ("willEndTearingTab");
		[CompilerGenerated]
		const string selDidEndTearingTab = "didEndTearingTab";
		static readonly IntPtr selDidEndTearingTabHandle = Selector.GetHandle ("didEndTearingTab");
		[CompilerGenerated]
		const string selIsTabFullyVisible_ = "isTabFullyVisible:";
		static readonly IntPtr selIsTabFullyVisible_Handle = Selector.GetHandle ("isTabFullyVisible:");
		[CompilerGenerated]
		const string selCanReceiveFrom_ = "canReceiveFrom:";
		static readonly IntPtr selCanReceiveFrom_Handle = Selector.GetHandle ("canReceiveFrom:");
		[CompilerGenerated]
		const string selMoveTabViewFromController_ = "moveTabView:fromController:";
		static readonly IntPtr selMoveTabViewFromController_Handle = Selector.GetHandle ("moveTabView:fromController:");
		[CompilerGenerated]
		const string selNumberOfTabs = "numberOfTabs";
		static readonly IntPtr selNumberOfTabsHandle = Selector.GetHandle ("numberOfTabs");
		[CompilerGenerated]
		const string selHasLiveTabs = "hasLiveTabs";
		static readonly IntPtr selHasLiveTabsHandle = Selector.GetHandle ("hasLiveTabs");
		[CompilerGenerated]
		const string selSelectedTabView = "selectedTabView";
		static readonly IntPtr selSelectedTabViewHandle = Selector.GetHandle ("selectedTabView");
		[CompilerGenerated]
		const string selSelectedTabTitle = "selectedTabTitle";
		static readonly IntPtr selSelectedTabTitleHandle = Selector.GetHandle ("selectedTabTitle");
		[CompilerGenerated]
		const string selHasTabStrip = "hasTabStrip";
		static readonly IntPtr selHasTabStripHandle = Selector.GetHandle ("hasTabStrip");
		[CompilerGenerated]
		const string selUseVerticalTabs = "useVerticalTabs";
		static readonly IntPtr selUseVerticalTabsHandle = Selector.GetHandle ("useVerticalTabs");
		[CompilerGenerated]
		const string selIsTabDraggable_ = "isTabDraggable:";
		static readonly IntPtr selIsTabDraggable_Handle = Selector.GetHandle ("isTabDraggable:");
		[CompilerGenerated]
		const string selSetTabIsDraggable_ = "setTab:isDraggable:";
		static readonly IntPtr selSetTabIsDraggable_Handle = Selector.GetHandle ("setTab:isDraggable:");
		[CompilerGenerated]
		const string selDeferPerformClose = "deferPerformClose";
		static readonly IntPtr selDeferPerformCloseHandle = Selector.GetHandle ("deferPerformClose");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("CTTabWindowController");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public CTTabWindowController () : base (NSObjectFlag.Empty)
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
		public CTTabWindowController (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public CTTabWindowController (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ChromiumTabsAPI.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public CTTabWindowController (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ChromiumTabsAPI.Messaging.this_assembly;
		}

		[Export ("showOverlay")]
		[CompilerGenerated]
		public virtual void ShowOverlay ()
		{
			if (IsDirectBinding) {
				MonoMac.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selShowOverlayHandle);
			} else {
				MonoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selShowOverlayHandle);
			}
		}
		
		[Export ("removeOverlay")]
		[CompilerGenerated]
		public virtual void RemoveOverlay ()
		{
			if (IsDirectBinding) {
				MonoMac.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selRemoveOverlayHandle);
			} else {
				MonoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selRemoveOverlayHandle);
			}
		}
		
		[Export ("overlayWindow")]
		[CompilerGenerated]
		public virtual global::MonoMac.AppKit.NSWindow OverlayWindow ()
		{
			if (IsDirectBinding) {
				return (global::MonoMac.AppKit.NSWindow) Runtime.GetNSObject (MonoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selOverlayWindowHandle));
			} else {
				return (global::MonoMac.AppKit.NSWindow) Runtime.GetNSObject (MonoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selOverlayWindowHandle));
			}
		}
		
		[Export ("shouldConstrainFrameRect")]
		[CompilerGenerated]
		public virtual bool ShouldConstrainFrameRect ()
		{
			if (IsDirectBinding) {
				return MonoMac.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selShouldConstrainFrameRectHandle);
			} else {
				return MonoMac.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selShouldConstrainFrameRectHandle);
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
		
		[Export ("detachTabToNewWindow:")]
		[CompilerGenerated]
		public virtual CTTabWindowController DetachTabToNewWindow (CTTabView tabView)
		{
			if (tabView == null)
				throw new ArgumentNullException ("tabView");
			if (IsDirectBinding) {
				return (CTTabWindowController) Runtime.GetNSObject (MonoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selDetachTabToNewWindow_Handle, tabView.Handle));
			} else {
				return (CTTabWindowController) Runtime.GetNSObject (MonoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, selDetachTabToNewWindow_Handle, tabView.Handle));
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
		
		[Export ("removePlaceholder")]
		[CompilerGenerated]
		public virtual void RemovePlaceholder ()
		{
			if (IsDirectBinding) {
				MonoMac.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selRemovePlaceholderHandle);
			} else {
				MonoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selRemovePlaceholderHandle);
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
		
		[Export ("tabTearingAllowed")]
		[CompilerGenerated]
		public virtual bool TabTearingAllowed ()
		{
			if (IsDirectBinding) {
				return MonoMac.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selTabTearingAllowedHandle);
			} else {
				return MonoMac.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selTabTearingAllowedHandle);
			}
		}
		
		[Export ("windowMovementAllowed")]
		[CompilerGenerated]
		public virtual bool WindowMovementAllowed ()
		{
			if (IsDirectBinding) {
				return MonoMac.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selWindowMovementAllowedHandle);
			} else {
				return MonoMac.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selWindowMovementAllowedHandle);
			}
		}
		
		[Export ("willStartTearingTab")]
		[CompilerGenerated]
		public virtual void WillStartTearingTab ()
		{
			if (IsDirectBinding) {
				MonoMac.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selWillStartTearingTabHandle);
			} else {
				MonoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selWillStartTearingTabHandle);
			}
		}
		
		[Export ("willEndTearingTab")]
		[CompilerGenerated]
		public virtual void WillEndTearingTab ()
		{
			if (IsDirectBinding) {
				MonoMac.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selWillEndTearingTabHandle);
			} else {
				MonoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selWillEndTearingTabHandle);
			}
		}
		
		[Export ("didEndTearingTab")]
		[CompilerGenerated]
		public virtual void DidEndTearingTab ()
		{
			if (IsDirectBinding) {
				MonoMac.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selDidEndTearingTabHandle);
			} else {
				MonoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selDidEndTearingTabHandle);
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
		
		[Export ("canReceiveFrom:")]
		[CompilerGenerated]
		public virtual bool CanReceiveFrom (CTTabWindowController source)
		{
			if (source == null)
				throw new ArgumentNullException ("source");
			if (IsDirectBinding) {
				return MonoMac.ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr (this.Handle, selCanReceiveFrom_Handle, source.Handle);
			} else {
				return MonoMac.ObjCRuntime.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, selCanReceiveFrom_Handle, source.Handle);
			}
		}
		
		[Export ("moveTabView:fromController:")]
		[CompilerGenerated]
		public virtual void MoveTabView (global::MonoMac.AppKit.NSView view, CTTabWindowController controller)
		{
			if (view == null)
				throw new ArgumentNullException ("view");
			if (controller == null)
				throw new ArgumentNullException ("controller");
			if (IsDirectBinding) {
				MonoMac.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, selMoveTabViewFromController_Handle, view.Handle, controller.Handle);
			} else {
				MonoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selMoveTabViewFromController_Handle, view.Handle, controller.Handle);
			}
		}
		
		[Export ("numberOfTabs")]
		[CompilerGenerated]
		public virtual int NumberOfTabs ()
		{
			if (IsDirectBinding) {
				return MonoMac.ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selNumberOfTabsHandle);
			} else {
				return MonoMac.ObjCRuntime.Messaging.int_objc_msgSendSuper (this.SuperHandle, selNumberOfTabsHandle);
			}
		}
		
		[Export ("hasLiveTabs")]
		[CompilerGenerated]
		public virtual bool HasLiveTabs ()
		{
			if (IsDirectBinding) {
				return MonoMac.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selHasLiveTabsHandle);
			} else {
				return MonoMac.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selHasLiveTabsHandle);
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
		
		[Export ("selectedTabTitle")]
		[CompilerGenerated]
		public virtual string SelectedTabTitle ()
		{
			if (IsDirectBinding) {
				return NSString.FromHandle (MonoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selSelectedTabTitleHandle));
			} else {
				return NSString.FromHandle (MonoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selSelectedTabTitleHandle));
			}
		}
		
		[Export ("hasTabStrip")]
		[CompilerGenerated]
		public virtual bool HasTabStrip ()
		{
			if (IsDirectBinding) {
				return MonoMac.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selHasTabStripHandle);
			} else {
				return MonoMac.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selHasTabStripHandle);
			}
		}
		
		[Export ("useVerticalTabs")]
		[CompilerGenerated]
		public virtual bool UseVerticalTabs ()
		{
			if (IsDirectBinding) {
				return MonoMac.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selUseVerticalTabsHandle);
			} else {
				return MonoMac.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selUseVerticalTabsHandle);
			}
		}
		
		[Export ("isTabDraggable:")]
		[CompilerGenerated]
		public virtual bool IsTabDraggable (global::MonoMac.AppKit.NSView tabView)
		{
			if (tabView == null)
				throw new ArgumentNullException ("tabView");
			if (IsDirectBinding) {
				return MonoMac.ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr (this.Handle, selIsTabDraggable_Handle, tabView.Handle);
			} else {
				return MonoMac.ObjCRuntime.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, selIsTabDraggable_Handle, tabView.Handle);
			}
		}
		
		[Export ("setTab:isDraggable:")]
		[CompilerGenerated]
		public virtual void SetTab (global::MonoMac.AppKit.NSView tabView, bool draggable)
		{
			if (tabView == null)
				throw new ArgumentNullException ("tabView");
			if (IsDirectBinding) {
				MonoMac.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_bool (this.Handle, selSetTabIsDraggable_Handle, tabView.Handle, draggable);
			} else {
				MonoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_bool (this.SuperHandle, selSetTabIsDraggable_Handle, tabView.Handle, draggable);
			}
		}
		
		[Export ("deferPerformClose")]
		[CompilerGenerated]
		public virtual void DeferPerformClose ()
		{
			if (IsDirectBinding) {
				MonoMac.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selDeferPerformCloseHandle);
			} else {
				MonoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selDeferPerformCloseHandle);
			}
		}
		
		[CompilerGenerated]
		public virtual bool DidShowNewTabButtonBeforeTemporalAction {
			[Export ("didShowNewTabButtonBeforeTemporalAction")]
			get {
				if (IsDirectBinding) {
					return MonoMac.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selDidShowNewTabButtonBeforeTemporalActionHandle);
				} else {
					return MonoMac.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selDidShowNewTabButtonBeforeTemporalActionHandle);
				}
			}
			
			[Export ("setDidShowNewTabButtonBeforeTemporalAction:")]
			set {
				if (IsDirectBinding) {
					MonoMac.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetDidShowNewTabButtonBeforeTemporalAction_Handle, value);
				} else {
					MonoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetDidShowNewTabButtonBeforeTemporalAction_Handle, value);
				}
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
		
	} /* class CTTabWindowController */
}
