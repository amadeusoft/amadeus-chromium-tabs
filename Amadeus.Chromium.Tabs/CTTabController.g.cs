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
	[Register("CTTabController", true)]
	public unsafe partial class CTTabController : global::MonoMac.AppKit.NSViewController {
		[CompilerGenerated]
		const string selLoadingState = "loadingState";
		static readonly IntPtr selLoadingStateHandle = Selector.GetHandle ("loadingState");
		[CompilerGenerated]
		const string selSetLoadingState_ = "setLoadingState:";
		static readonly IntPtr selSetLoadingState_Handle = Selector.GetHandle ("setLoadingState:");
		[CompilerGenerated]
		const string selAction = "action";
		static readonly IntPtr selActionHandle = Selector.GetHandle ("action");
		[CompilerGenerated]
		const string selSetAction_ = "setAction:";
		static readonly IntPtr selSetAction_Handle = Selector.GetHandle ("setAction:");
		[CompilerGenerated]
		const string selApp = "app";
		static readonly IntPtr selAppHandle = Selector.GetHandle ("app");
		[CompilerGenerated]
		const string selSetApp_ = "setApp:";
		static readonly IntPtr selSetApp_Handle = Selector.GetHandle ("setApp:");
		[CompilerGenerated]
		const string selMini = "mini";
		static readonly IntPtr selMiniHandle = Selector.GetHandle ("mini");
		[CompilerGenerated]
		const string selSetMini_ = "setMini:";
		static readonly IntPtr selSetMini_Handle = Selector.GetHandle ("setMini:");
		[CompilerGenerated]
		const string selPhantom = "phantom";
		static readonly IntPtr selPhantomHandle = Selector.GetHandle ("phantom");
		[CompilerGenerated]
		const string selSetPhantom_ = "setPhantom:";
		static readonly IntPtr selSetPhantom_Handle = Selector.GetHandle ("setPhantom:");
		[CompilerGenerated]
		const string selPinned = "pinned";
		static readonly IntPtr selPinnedHandle = Selector.GetHandle ("pinned");
		[CompilerGenerated]
		const string selSetPinned_ = "setPinned:";
		static readonly IntPtr selSetPinned_Handle = Selector.GetHandle ("setPinned:");
		[CompilerGenerated]
		const string selSelected = "selected";
		static readonly IntPtr selSelectedHandle = Selector.GetHandle ("selected");
		[CompilerGenerated]
		const string selSetSelected_ = "setSelected:";
		static readonly IntPtr selSetSelected_Handle = Selector.GetHandle ("setSelected:");
		[CompilerGenerated]
		const string selTarget = "target";
		static readonly IntPtr selTargetHandle = Selector.GetHandle ("target");
		[CompilerGenerated]
		const string selSetTarget_ = "setTarget:";
		static readonly IntPtr selSetTarget_Handle = Selector.GetHandle ("setTarget:");
		[CompilerGenerated]
		const string selIconView = "iconView";
		static readonly IntPtr selIconViewHandle = Selector.GetHandle ("iconView");
		[CompilerGenerated]
		const string selSetIconView_ = "setIconView:";
		static readonly IntPtr selSetIconView_Handle = Selector.GetHandle ("setIconView:");
		[CompilerGenerated]
		const string selMinTabWidth = "minTabWidth";
		static readonly IntPtr selMinTabWidthHandle = Selector.GetHandle ("minTabWidth");
		[CompilerGenerated]
		const string selMaxTabWidth = "maxTabWidth";
		static readonly IntPtr selMaxTabWidthHandle = Selector.GetHandle ("maxTabWidth");
		[CompilerGenerated]
		const string selMinSelectedTabWidth = "minSelectedTabWidth";
		static readonly IntPtr selMinSelectedTabWidthHandle = Selector.GetHandle ("minSelectedTabWidth");
		[CompilerGenerated]
		const string selMiniTabWidth = "miniTabWidth";
		static readonly IntPtr selMiniTabWidthHandle = Selector.GetHandle ("miniTabWidth");
		[CompilerGenerated]
		const string selAppTabWidth = "appTabWidth";
		static readonly IntPtr selAppTabWidthHandle = Selector.GetHandle ("appTabWidth");
		[CompilerGenerated]
		const string selInitWithNibNameBundle_ = "initWithNibName:bundle:";
		static readonly IntPtr selInitWithNibNameBundle_Handle = Selector.GetHandle ("initWithNibName:bundle:");
		[CompilerGenerated]
		const string selTabView = "tabView";
		static readonly IntPtr selTabViewHandle = Selector.GetHandle ("tabView");
		[CompilerGenerated]
		const string selCloseTab_ = "closeTab:";
		static readonly IntPtr selCloseTab_Handle = Selector.GetHandle ("closeTab:");
		[CompilerGenerated]
		const string selInRapidClosureMode = "inRapidClosureMode";
		static readonly IntPtr selInRapidClosureModeHandle = Selector.GetHandle ("inRapidClosureMode");
		[CompilerGenerated]
		const string selUpdateVisibility = "updateVisibility";
		static readonly IntPtr selUpdateVisibilityHandle = Selector.GetHandle ("updateVisibility");
		[CompilerGenerated]
		const string selUpdateTitleColor = "updateTitleColor";
		static readonly IntPtr selUpdateTitleColorHandle = Selector.GetHandle ("updateTitleColor");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("CTTabController");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public CTTabController () : base (NSObjectFlag.Empty)
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
		public CTTabController (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public CTTabController (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ChromiumTabsAPI.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public CTTabController (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ChromiumTabsAPI.Messaging.this_assembly;
		}

		[Export ("minTabWidth")]
		[CompilerGenerated]
		public static float MinTabWidth ()
		{
			return MonoMac.ObjCRuntime.Messaging.float_objc_msgSend (class_ptr, selMinTabWidthHandle);
		}
		
		[Export ("maxTabWidth")]
		[CompilerGenerated]
		public static float MaxTabWidth ()
		{
			return MonoMac.ObjCRuntime.Messaging.float_objc_msgSend (class_ptr, selMaxTabWidthHandle);
		}
		
		[Export ("minSelectedTabWidth")]
		[CompilerGenerated]
		public static float MinSelectedTabWidth ()
		{
			return MonoMac.ObjCRuntime.Messaging.float_objc_msgSend (class_ptr, selMinSelectedTabWidthHandle);
		}
		
		[Export ("miniTabWidth")]
		[CompilerGenerated]
		public static float MiniTabWidth ()
		{
			return MonoMac.ObjCRuntime.Messaging.float_objc_msgSend (class_ptr, selMiniTabWidthHandle);
		}
		
		[Export ("appTabWidth")]
		[CompilerGenerated]
		public static float AppTabWidth ()
		{
			return MonoMac.ObjCRuntime.Messaging.float_objc_msgSend (class_ptr, selAppTabWidthHandle);
		}
		
		[Export ("initWithNibName:bundle:")]
		[CompilerGenerated]
		public CTTabController (string nibName, NSBundle bundle)
			: base (NSObjectFlag.Empty)
		{
			if (nibName == null)
				throw new ArgumentNullException ("nibName");
			if (bundle == null)
				throw new ArgumentNullException ("bundle");
			var nsnibName = NSString.CreateNative (nibName);
			
			IsDirectBinding = GetType ().Assembly == global::ChromiumTabsAPI.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (this.Handle, selInitWithNibNameBundle_Handle, nsnibName, bundle.Handle);
			} else {
				Handle = MonoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selInitWithNibNameBundle_Handle, nsnibName, bundle.Handle);
			}
			NSString.ReleaseNative (nsnibName);
			
		}
		
		[Export ("tabView")]
		[CompilerGenerated]
		public virtual CTTabView TabView ()
		{
			if (IsDirectBinding) {
				return (CTTabView) Runtime.GetNSObject (MonoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selTabViewHandle));
			} else {
				return (CTTabView) Runtime.GetNSObject (MonoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selTabViewHandle));
			}
		}
		
		[Export ("closeTab:")]
		[CompilerGenerated]
		public virtual void CloseTab (NSObject sender)
		{
			if (sender == null)
				throw new ArgumentNullException ("sender");
			if (IsDirectBinding) {
				MonoMac.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selCloseTab_Handle, sender.Handle);
			} else {
				MonoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selCloseTab_Handle, sender.Handle);
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
		
		[Export ("updateVisibility")]
		[CompilerGenerated]
		public virtual void UpdateVisibility ()
		{
			if (IsDirectBinding) {
				MonoMac.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selUpdateVisibilityHandle);
			} else {
				MonoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selUpdateVisibilityHandle);
			}
		}
		
		[Export ("updateTitleColor")]
		[CompilerGenerated]
		public virtual void UpdateTitleColor ()
		{
			if (IsDirectBinding) {
				MonoMac.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selUpdateTitleColorHandle);
			} else {
				MonoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selUpdateTitleColorHandle);
			}
		}
		
		[CompilerGenerated]
		public virtual int LoadingState {
			[Export ("loadingState")]
			get {
				if (IsDirectBinding) {
					return MonoMac.ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selLoadingStateHandle);
				} else {
					return MonoMac.ObjCRuntime.Messaging.int_objc_msgSendSuper (this.SuperHandle, selLoadingStateHandle);
				}
			}
			
			[Export ("setLoadingState:")]
			set {
				if (IsDirectBinding) {
					MonoMac.ObjCRuntime.Messaging.void_objc_msgSend_int (this.Handle, selSetLoadingState_Handle, value);
				} else {
					MonoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, selSetLoadingState_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual Selector Action {
			[Export ("action")]
			get {
				if (IsDirectBinding) {
					return new Selector (MonoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selActionHandle));
				} else {
					return new Selector (MonoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selActionHandle));
				}
			}
			
			[Export ("setAction:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoMac.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetAction_Handle, value.Handle);
				} else {
					MonoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetAction_Handle, value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool App {
			[Export ("app")]
			get {
				if (IsDirectBinding) {
					return MonoMac.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selAppHandle);
				} else {
					return MonoMac.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selAppHandle);
				}
			}
			
			[Export ("setApp:")]
			set {
				if (IsDirectBinding) {
					MonoMac.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetApp_Handle, value);
				} else {
					MonoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetApp_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool Mini {
			[Export ("mini")]
			get {
				if (IsDirectBinding) {
					return MonoMac.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selMiniHandle);
				} else {
					return MonoMac.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selMiniHandle);
				}
			}
			
			[Export ("setMini:")]
			set {
				if (IsDirectBinding) {
					MonoMac.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetMini_Handle, value);
				} else {
					MonoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetMini_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool Phantom {
			[Export ("phantom")]
			get {
				if (IsDirectBinding) {
					return MonoMac.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selPhantomHandle);
				} else {
					return MonoMac.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selPhantomHandle);
				}
			}
			
			[Export ("setPhantom:")]
			set {
				if (IsDirectBinding) {
					MonoMac.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetPhantom_Handle, value);
				} else {
					MonoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetPhantom_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool Pinned {
			[Export ("pinned")]
			get {
				if (IsDirectBinding) {
					return MonoMac.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selPinnedHandle);
				} else {
					return MonoMac.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selPinnedHandle);
				}
			}
			
			[Export ("setPinned:")]
			set {
				if (IsDirectBinding) {
					MonoMac.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetPinned_Handle, value);
				} else {
					MonoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetPinned_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool Selected {
			[Export ("selected")]
			get {
				if (IsDirectBinding) {
					return MonoMac.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selSelectedHandle);
				} else {
					return MonoMac.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selSelectedHandle);
				}
			}
			
			[Export ("setSelected:")]
			set {
				if (IsDirectBinding) {
					MonoMac.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetSelected_Handle, value);
				} else {
					MonoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetSelected_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_Target_var;
		[CompilerGenerated]
		public virtual NSObject Target {
			[Export ("target")]
			get {
				NSObject ret;
				if (IsDirectBinding) {
					ret = (NSObject) Runtime.GetNSObject (MonoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selTargetHandle));
				} else {
					ret = (NSObject) Runtime.GetNSObject (MonoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selTargetHandle));
				}
				__mt_Target_var = ret;
				return ret;
			}
			
			[Export ("setTarget:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoMac.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetTarget_Handle, value.Handle);
				} else {
					MonoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetTarget_Handle, value.Handle);
				}
				__mt_Target_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_IconView_var;
		[CompilerGenerated]
		public virtual global::MonoMac.AppKit.NSView IconView {
			[Export ("iconView")]
			get {
				global::MonoMac.AppKit.NSView ret;
				if (IsDirectBinding) {
					ret = (global::MonoMac.AppKit.NSView) Runtime.GetNSObject (MonoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selIconViewHandle));
				} else {
					ret = (global::MonoMac.AppKit.NSView) Runtime.GetNSObject (MonoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selIconViewHandle));
				}
				__mt_IconView_var = ret;
				return ret;
			}
			
			[Export ("setIconView:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoMac.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetIconView_Handle, value.Handle);
				} else {
					MonoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetIconView_Handle, value.Handle);
				}
				__mt_IconView_var = value;
			}
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_Target_var = null;
				__mt_IconView_var = null;
			}
		}
	} /* class CTTabController */
}
