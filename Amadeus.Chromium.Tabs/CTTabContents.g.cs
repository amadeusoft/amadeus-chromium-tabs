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
	[Register("CTTabContents", true)]
	public unsafe partial class CTTabContents : global::MonoMac.AppKit.NSDocument {
		[CompilerGenerated]
		const string selIsApp = "isApp";
		static readonly IntPtr selIsAppHandle = Selector.GetHandle ("isApp");
		[CompilerGenerated]
		const string selSetIsApp_ = "setIsApp:";
		static readonly IntPtr selSetIsApp_Handle = Selector.GetHandle ("setIsApp:");
		[CompilerGenerated]
		const string selIsLoading = "isLoading";
		static readonly IntPtr selIsLoadingHandle = Selector.GetHandle ("isLoading");
		[CompilerGenerated]
		const string selSetIsLoading_ = "setIsLoading:";
		static readonly IntPtr selSetIsLoading_Handle = Selector.GetHandle ("setIsLoading:");
		[CompilerGenerated]
		const string selIsCrashed = "isCrashed";
		static readonly IntPtr selIsCrashedHandle = Selector.GetHandle ("isCrashed");
		[CompilerGenerated]
		const string selSetIsCrashed_ = "setIsCrashed:";
		static readonly IntPtr selSetIsCrashed_Handle = Selector.GetHandle ("setIsCrashed:");
		[CompilerGenerated]
		const string selIsWaitingForResponse = "isWaitingForResponse";
		static readonly IntPtr selIsWaitingForResponseHandle = Selector.GetHandle ("isWaitingForResponse");
		[CompilerGenerated]
		const string selSetIsWaitingForResponse_ = "setIsWaitingForResponse:";
		static readonly IntPtr selSetIsWaitingForResponse_Handle = Selector.GetHandle ("setIsWaitingForResponse:");
		[CompilerGenerated]
		const string selIsVisible = "isVisible";
		static readonly IntPtr selIsVisibleHandle = Selector.GetHandle ("isVisible");
		[CompilerGenerated]
		const string selSetIsVisible_ = "setIsVisible:";
		static readonly IntPtr selSetIsVisible_Handle = Selector.GetHandle ("setIsVisible:");
		[CompilerGenerated]
		const string selIsSelected = "isSelected";
		static readonly IntPtr selIsSelectedHandle = Selector.GetHandle ("isSelected");
		[CompilerGenerated]
		const string selSetIsSelected_ = "setIsSelected:";
		static readonly IntPtr selSetIsSelected_Handle = Selector.GetHandle ("setIsSelected:");
		[CompilerGenerated]
		const string selIsTeared = "isTeared";
		static readonly IntPtr selIsTearedHandle = Selector.GetHandle ("isTeared");
		[CompilerGenerated]
		const string selSetIsTeared_ = "setIsTeared:";
		static readonly IntPtr selSetIsTeared_Handle = Selector.GetHandle ("setIsTeared:");
		[CompilerGenerated]
		const string selDelegate = "delegate";
		static readonly IntPtr selDelegateHandle = Selector.GetHandle ("delegate");
		[CompilerGenerated]
		const string selSetDelegate_ = "setDelegate:";
		static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle ("setDelegate:");
		[CompilerGenerated]
		const string selView = "view";
		static readonly IntPtr selViewHandle = Selector.GetHandle ("view");
		[CompilerGenerated]
		const string selSetView_ = "setView:";
		static readonly IntPtr selSetView_Handle = Selector.GetHandle ("setView:");
		[CompilerGenerated]
		const string selTitle = "title";
		static readonly IntPtr selTitleHandle = Selector.GetHandle ("title");
		[CompilerGenerated]
		const string selSetTitle_ = "setTitle:";
		static readonly IntPtr selSetTitle_Handle = Selector.GetHandle ("setTitle:");
		[CompilerGenerated]
		const string selIcon = "icon";
		static readonly IntPtr selIconHandle = Selector.GetHandle ("icon");
		[CompilerGenerated]
		const string selSetIcon_ = "setIcon:";
		static readonly IntPtr selSetIcon_Handle = Selector.GetHandle ("setIcon:");
		[CompilerGenerated]
		const string selBrowser = "browser";
		static readonly IntPtr selBrowserHandle = Selector.GetHandle ("browser");
		[CompilerGenerated]
		const string selSetBrowser_ = "setBrowser:";
		static readonly IntPtr selSetBrowser_Handle = Selector.GetHandle ("setBrowser:");
		[CompilerGenerated]
		const string selParentOpener = "parentOpener";
		static readonly IntPtr selParentOpenerHandle = Selector.GetHandle ("parentOpener");
		[CompilerGenerated]
		const string selSetParentOpener_ = "setParentOpener:";
		static readonly IntPtr selSetParentOpener_Handle = Selector.GetHandle ("setParentOpener:");
		[CompilerGenerated]
		const string selHasIcon = "hasIcon";
		static readonly IntPtr selHasIconHandle = Selector.GetHandle ("hasIcon");
		[CompilerGenerated]
		const string selInitWithBaseTabContents_ = "initWithBaseTabContents:";
		static readonly IntPtr selInitWithBaseTabContents_Handle = Selector.GetHandle ("initWithBaseTabContents:");
		[CompilerGenerated]
		const string selDestroy_ = "destroy:";
		static readonly IntPtr selDestroy_Handle = Selector.GetHandle ("destroy:");
		[CompilerGenerated]
		const string selMakeKeyAndOrderFront_ = "makeKeyAndOrderFront:";
		static readonly IntPtr selMakeKeyAndOrderFront_Handle = Selector.GetHandle ("makeKeyAndOrderFront:");
		[CompilerGenerated]
		const string selBecomeFirstResponder = "becomeFirstResponder";
		static readonly IntPtr selBecomeFirstResponderHandle = Selector.GetHandle ("becomeFirstResponder");
		[CompilerGenerated]
		const string selClosingOfTabDidStart_ = "closingOfTabDidStart:";
		static readonly IntPtr selClosingOfTabDidStart_Handle = Selector.GetHandle ("closingOfTabDidStart:");
		[CompilerGenerated]
		const string selTabDidInsertIntoBrowserAtIndexInForeground_ = "tabDidInsertIntoBrowser:atIndex:inForeground:";
		static readonly IntPtr selTabDidInsertIntoBrowserAtIndexInForeground_Handle = Selector.GetHandle ("tabDidInsertIntoBrowser:atIndex:inForeground:");
		[CompilerGenerated]
		const string selTabReplacedInBrowserAtIndex_ = "tabReplaced:inBrowser:atIndex:";
		static readonly IntPtr selTabReplacedInBrowserAtIndex_Handle = Selector.GetHandle ("tabReplaced:inBrowser:atIndex:");
		[CompilerGenerated]
		const string selTabWillCloseInBrowserAtIndex_ = "tabWillCloseInBrowser:atIndex:";
		static readonly IntPtr selTabWillCloseInBrowserAtIndex_Handle = Selector.GetHandle ("tabWillCloseInBrowser:atIndex:");
		[CompilerGenerated]
		const string selTabDidDetachFromBrowserAtIndex_ = "tabDidDetachFromBrowser:atIndex:";
		static readonly IntPtr selTabDidDetachFromBrowserAtIndex_Handle = Selector.GetHandle ("tabDidDetachFromBrowser:atIndex:");
		[CompilerGenerated]
		const string selTabDidBecomeVisible = "tabDidBecomeVisible";
		static readonly IntPtr selTabDidBecomeVisibleHandle = Selector.GetHandle ("tabDidBecomeVisible");
		[CompilerGenerated]
		const string selTabDidResignVisible = "tabDidResignVisible";
		static readonly IntPtr selTabDidResignVisibleHandle = Selector.GetHandle ("tabDidResignVisible");
		[CompilerGenerated]
		const string selTabWillBecomeSelected = "tabWillBecomeSelected";
		static readonly IntPtr selTabWillBecomeSelectedHandle = Selector.GetHandle ("tabWillBecomeSelected");
		[CompilerGenerated]
		const string selTabWillResignSelected = "tabWillResignSelected";
		static readonly IntPtr selTabWillResignSelectedHandle = Selector.GetHandle ("tabWillResignSelected");
		[CompilerGenerated]
		const string selTabDidBecomeSelected = "tabDidBecomeSelected";
		static readonly IntPtr selTabDidBecomeSelectedHandle = Selector.GetHandle ("tabDidBecomeSelected");
		[CompilerGenerated]
		const string selTabDidResignSelected = "tabDidResignSelected";
		static readonly IntPtr selTabDidResignSelectedHandle = Selector.GetHandle ("tabDidResignSelected");
		[CompilerGenerated]
		const string selTabWillBecomeTeared = "tabWillBecomeTeared";
		static readonly IntPtr selTabWillBecomeTearedHandle = Selector.GetHandle ("tabWillBecomeTeared");
		[CompilerGenerated]
		const string selTabWillResignTeared = "tabWillResignTeared";
		static readonly IntPtr selTabWillResignTearedHandle = Selector.GetHandle ("tabWillResignTeared");
		[CompilerGenerated]
		const string selTabDidResignTeared = "tabDidResignTeared";
		static readonly IntPtr selTabDidResignTearedHandle = Selector.GetHandle ("tabDidResignTeared");
		[CompilerGenerated]
		const string selViewFrameDidChange_ = "viewFrameDidChange:";
		static readonly IntPtr selViewFrameDidChange_Handle = Selector.GetHandle ("viewFrameDidChange:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("CTTabContents");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public CTTabContents () : base (NSObjectFlag.Empty)
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
		public CTTabContents (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public CTTabContents (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ChromiumTabsAPI.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public CTTabContents (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ChromiumTabsAPI.Messaging.this_assembly;
		}

		[Export ("initWithBaseTabContents:")]
		[CompilerGenerated]
		public CTTabContents (CTTabContents baseContents)
			: base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ChromiumTabsAPI.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selInitWithBaseTabContents_Handle, baseContents == null ? IntPtr.Zero : baseContents.Handle);
			} else {
				Handle = MonoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, selInitWithBaseTabContents_Handle, baseContents == null ? IntPtr.Zero : baseContents.Handle);
			}
		}
		
		[Export ("destroy:")]
		[CompilerGenerated]
		public virtual void Destroy (NSObject sender)
		{
			if (sender == null)
				throw new ArgumentNullException ("sender");
			if (IsDirectBinding) {
				MonoMac.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selDestroy_Handle, sender.Handle);
			} else {
				MonoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selDestroy_Handle, sender.Handle);
			}
		}
		
		[Export ("makeKeyAndOrderFront:")]
		[CompilerGenerated]
		public virtual void MakeKeyAndOrderFront (NSObject sender)
		{
			if (sender == null)
				throw new ArgumentNullException ("sender");
			if (IsDirectBinding) {
				MonoMac.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selMakeKeyAndOrderFront_Handle, sender.Handle);
			} else {
				MonoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selMakeKeyAndOrderFront_Handle, sender.Handle);
			}
		}
		
		[Export ("becomeFirstResponder")]
		[CompilerGenerated]
		public virtual bool BecomeFirstResponder ()
		{
			if (IsDirectBinding) {
				return MonoMac.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selBecomeFirstResponderHandle);
			} else {
				return MonoMac.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selBecomeFirstResponderHandle);
			}
		}
		
		[Export ("closingOfTabDidStart:")]
		[CompilerGenerated]
		public virtual void ClosingOfTabDidStart (NSObject model)
		{
			if (IsDirectBinding) {
				MonoMac.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selClosingOfTabDidStart_Handle, model == null ? IntPtr.Zero : model.Handle);
			} else {
				MonoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selClosingOfTabDidStart_Handle, model == null ? IntPtr.Zero : model.Handle);
			}
		}
		
		[Export ("tabDidInsertIntoBrowser:atIndex:inForeground:")]
		[CompilerGenerated]
		public virtual void TabDidInsertIntoBrowser (CTBrowser browser, int index, bool foreground)
		{
			if (browser == null)
				throw new ArgumentNullException ("browser");
			if (IsDirectBinding) {
				MonoMac.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_int_bool (this.Handle, selTabDidInsertIntoBrowserAtIndexInForeground_Handle, browser.Handle, index, foreground);
			} else {
				MonoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_int_bool (this.SuperHandle, selTabDidInsertIntoBrowserAtIndexInForeground_Handle, browser.Handle, index, foreground);
			}
		}
		
		[Export ("tabReplaced:inBrowser:atIndex:")]
		[CompilerGenerated]
		public virtual void TabReplacedinBrowser (CTTabContents oldContents, CTBrowser browser, int index)
		{
			if (oldContents == null)
				throw new ArgumentNullException ("oldContents");
			if (browser == null)
				throw new ArgumentNullException ("browser");
			if (IsDirectBinding) {
				MonoMac.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr_int (this.Handle, selTabReplacedInBrowserAtIndex_Handle, oldContents.Handle, browser.Handle, index);
			} else {
				MonoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_int (this.SuperHandle, selTabReplacedInBrowserAtIndex_Handle, oldContents.Handle, browser.Handle, index);
			}
		}
		
		[Export ("tabWillCloseInBrowser:atIndex:")]
		[CompilerGenerated]
		public virtual void TabWillCloseInBrowser (CTBrowser browser, int index)
		{
			if (browser == null)
				throw new ArgumentNullException ("browser");
			if (IsDirectBinding) {
				MonoMac.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_int (this.Handle, selTabWillCloseInBrowserAtIndex_Handle, browser.Handle, index);
			} else {
				MonoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_int (this.SuperHandle, selTabWillCloseInBrowserAtIndex_Handle, browser.Handle, index);
			}
		}
		
		[Export ("tabDidDetachFromBrowser:atIndex:")]
		[CompilerGenerated]
		public virtual void TabDidDetachFromBrowser (CTBrowser browser, int index)
		{
			if (browser == null)
				throw new ArgumentNullException ("browser");
			if (IsDirectBinding) {
				MonoMac.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_int (this.Handle, selTabDidDetachFromBrowserAtIndex_Handle, browser.Handle, index);
			} else {
				MonoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_int (this.SuperHandle, selTabDidDetachFromBrowserAtIndex_Handle, browser.Handle, index);
			}
		}
		
		[Export ("tabDidBecomeVisible")]
		[CompilerGenerated]
		public virtual void TabDidBecomeVisible ()
		{
			if (IsDirectBinding) {
				MonoMac.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selTabDidBecomeVisibleHandle);
			} else {
				MonoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selTabDidBecomeVisibleHandle);
			}
		}
		
		[Export ("tabDidResignVisible")]
		[CompilerGenerated]
		public virtual void TabDidResignVisible ()
		{
			if (IsDirectBinding) {
				MonoMac.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selTabDidResignVisibleHandle);
			} else {
				MonoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selTabDidResignVisibleHandle);
			}
		}
		
		[Export ("tabWillBecomeSelected")]
		[CompilerGenerated]
		public virtual void TabWillBecomeSelected ()
		{
			if (IsDirectBinding) {
				MonoMac.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selTabWillBecomeSelectedHandle);
			} else {
				MonoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selTabWillBecomeSelectedHandle);
			}
		}
		
		[Export ("tabWillResignSelected")]
		[CompilerGenerated]
		public virtual void TabWillResignSelected ()
		{
			if (IsDirectBinding) {
				MonoMac.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selTabWillResignSelectedHandle);
			} else {
				MonoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selTabWillResignSelectedHandle);
			}
		}
		
		[Export ("tabDidBecomeSelected")]
		[CompilerGenerated]
		public virtual void TabDidBecomeSelected ()
		{
			if (IsDirectBinding) {
				MonoMac.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selTabDidBecomeSelectedHandle);
			} else {
				MonoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selTabDidBecomeSelectedHandle);
			}
		}
		
		[Export ("tabDidResignSelected")]
		[CompilerGenerated]
		public virtual void TabDidResignSelected ()
		{
			if (IsDirectBinding) {
				MonoMac.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selTabDidResignSelectedHandle);
			} else {
				MonoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selTabDidResignSelectedHandle);
			}
		}
		
		[Export ("tabWillBecomeTeared")]
		[CompilerGenerated]
		public virtual void TabWillBecomeTeared ()
		{
			if (IsDirectBinding) {
				MonoMac.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selTabWillBecomeTearedHandle);
			} else {
				MonoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selTabWillBecomeTearedHandle);
			}
		}
		
		[Export ("tabWillResignTeared")]
		[CompilerGenerated]
		public virtual void TabWillResignTeared ()
		{
			if (IsDirectBinding) {
				MonoMac.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selTabWillResignTearedHandle);
			} else {
				MonoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selTabWillResignTearedHandle);
			}
		}
		
		[Export ("tabDidResignTeared")]
		[CompilerGenerated]
		public virtual void TabDidResignTeared ()
		{
			if (IsDirectBinding) {
				MonoMac.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selTabDidResignTearedHandle);
			} else {
				MonoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selTabDidResignTearedHandle);
			}
		}
		
		[Export ("viewFrameDidChange:")]
		[CompilerGenerated]
		public virtual void ViewFrameDidChange (global::System.Drawing.RectangleF newFrame)
		{
			if (IsDirectBinding) {
				MonoMac.ObjCRuntime.Messaging.void_objc_msgSend_RectangleF (this.Handle, selViewFrameDidChange_Handle, newFrame);
			} else {
				MonoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper_RectangleF (this.SuperHandle, selViewFrameDidChange_Handle, newFrame);
			}
		}
		
		[CompilerGenerated]
		public virtual bool IsApp {
			[Export ("isApp")]
			get {
				if (IsDirectBinding) {
					return MonoMac.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsAppHandle);
				} else {
					return MonoMac.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsAppHandle);
				}
			}
			
			[Export ("setIsApp:")]
			set {
				if (IsDirectBinding) {
					MonoMac.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetIsApp_Handle, value);
				} else {
					MonoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetIsApp_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool IsLoading {
			[Export ("isLoading")]
			get {
				if (IsDirectBinding) {
					return MonoMac.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsLoadingHandle);
				} else {
					return MonoMac.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsLoadingHandle);
				}
			}
			
			[Export ("setIsLoading:")]
			set {
				if (IsDirectBinding) {
					MonoMac.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetIsLoading_Handle, value);
				} else {
					MonoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetIsLoading_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool IsCrashed {
			[Export ("isCrashed")]
			get {
				if (IsDirectBinding) {
					return MonoMac.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsCrashedHandle);
				} else {
					return MonoMac.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsCrashedHandle);
				}
			}
			
			[Export ("setIsCrashed:")]
			set {
				if (IsDirectBinding) {
					MonoMac.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetIsCrashed_Handle, value);
				} else {
					MonoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetIsCrashed_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool IsWaitingForResponse {
			[Export ("isWaitingForResponse")]
			get {
				if (IsDirectBinding) {
					return MonoMac.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsWaitingForResponseHandle);
				} else {
					return MonoMac.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsWaitingForResponseHandle);
				}
			}
			
			[Export ("setIsWaitingForResponse:")]
			set {
				if (IsDirectBinding) {
					MonoMac.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetIsWaitingForResponse_Handle, value);
				} else {
					MonoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetIsWaitingForResponse_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool IsVisible {
			[Export ("isVisible")]
			get {
				if (IsDirectBinding) {
					return MonoMac.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsVisibleHandle);
				} else {
					return MonoMac.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsVisibleHandle);
				}
			}
			
			[Export ("setIsVisible:")]
			set {
				if (IsDirectBinding) {
					MonoMac.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetIsVisible_Handle, value);
				} else {
					MonoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetIsVisible_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool IsSelected {
			[Export ("isSelected")]
			get {
				if (IsDirectBinding) {
					return MonoMac.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsSelectedHandle);
				} else {
					return MonoMac.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsSelectedHandle);
				}
			}
			
			[Export ("setIsSelected:")]
			set {
				if (IsDirectBinding) {
					MonoMac.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetIsSelected_Handle, value);
				} else {
					MonoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetIsSelected_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool IsTeared {
			[Export ("isTeared")]
			get {
				if (IsDirectBinding) {
					return MonoMac.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsTearedHandle);
				} else {
					return MonoMac.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsTearedHandle);
				}
			}
			
			[Export ("setIsTeared:")]
			set {
				if (IsDirectBinding) {
					MonoMac.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetIsTeared_Handle, value);
				} else {
					MonoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetIsTeared_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_Delegate_var;
		[CompilerGenerated]
		public virtual NSObject Delegate {
			[Export ("delegate")]
			get {
				NSObject ret;
				if (IsDirectBinding) {
					ret = (NSObject) Runtime.GetNSObject (MonoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selDelegateHandle));
				} else {
					ret = (NSObject) Runtime.GetNSObject (MonoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selDelegateHandle));
				}
				__mt_Delegate_var = ret;
				return ret;
			}
			
			[Export ("setDelegate:")]
			set {
				if (IsDirectBinding) {
					MonoMac.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetDelegate_Handle, value == null ? IntPtr.Zero : value.Handle);
				} else {
					MonoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetDelegate_Handle, value == null ? IntPtr.Zero : value.Handle);
				}
				__mt_Delegate_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_View_var;
		[CompilerGenerated]
		public virtual global::MonoMac.AppKit.NSView View {
			[Export ("view")]
			get {
				global::MonoMac.AppKit.NSView ret;
				if (IsDirectBinding) {
					ret = (global::MonoMac.AppKit.NSView) Runtime.GetNSObject (MonoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selViewHandle));
				} else {
					ret = (global::MonoMac.AppKit.NSView) Runtime.GetNSObject (MonoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selViewHandle));
				}
				__mt_View_var = ret;
				return ret;
			}
			
			[Export ("setView:")]
			set {
				if (IsDirectBinding) {
					MonoMac.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetView_Handle, value == null ? IntPtr.Zero : value.Handle);
				} else {
					MonoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetView_Handle, value == null ? IntPtr.Zero : value.Handle);
				}
				__mt_View_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual string Title {
			[Export ("title")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selTitleHandle));
				} else {
					return NSString.FromHandle (MonoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selTitleHandle));
				}
			}
			
			[Export ("setTitle:")]
			set {
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoMac.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetTitle_Handle, nsvalue);
				} else {
					MonoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetTitle_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		object __mt_Icon_var;
		[CompilerGenerated]
		public virtual global::MonoMac.AppKit.NSImage Icon {
			[Export ("icon")]
			get {
				global::MonoMac.AppKit.NSImage ret;
				if (IsDirectBinding) {
					ret = (global::MonoMac.AppKit.NSImage) Runtime.GetNSObject (MonoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selIconHandle));
				} else {
					ret = (global::MonoMac.AppKit.NSImage) Runtime.GetNSObject (MonoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selIconHandle));
				}
				__mt_Icon_var = ret;
				return ret;
			}
			
			[Export ("setIcon:")]
			set {
				if (IsDirectBinding) {
					MonoMac.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetIcon_Handle, value == null ? IntPtr.Zero : value.Handle);
				} else {
					MonoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetIcon_Handle, value == null ? IntPtr.Zero : value.Handle);
				}
				__mt_Icon_var = value;
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
			
			[Export ("setBrowser:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoMac.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetBrowser_Handle, value.Handle);
				} else {
					MonoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetBrowser_Handle, value.Handle);
				}
				__mt_Browser_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_ParentOpener_var;
		[CompilerGenerated]
		public virtual CTTabContents ParentOpener {
			[Export ("parentOpener")]
			get {
				CTTabContents ret;
				if (IsDirectBinding) {
					ret = (CTTabContents) Runtime.GetNSObject (MonoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selParentOpenerHandle));
				} else {
					ret = (CTTabContents) Runtime.GetNSObject (MonoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selParentOpenerHandle));
				}
				__mt_ParentOpener_var = ret;
				return ret;
			}
			
			[Export ("setParentOpener:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoMac.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetParentOpener_Handle, value.Handle);
				} else {
					MonoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetParentOpener_Handle, value.Handle);
				}
				__mt_ParentOpener_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual bool HasIcon {
			[Export ("hasIcon")]
			get {
				if (IsDirectBinding) {
					return MonoMac.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selHasIconHandle);
				} else {
					return MonoMac.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selHasIconHandle);
				}
			}
			
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_Delegate_var = null;
				__mt_View_var = null;
				__mt_Icon_var = null;
				__mt_Browser_var = null;
				__mt_ParentOpener_var = null;
			}
		}
	} /* class CTTabContents */
}
