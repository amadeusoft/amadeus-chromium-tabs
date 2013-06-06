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
	[Register("CTTabView", true)]
	public unsafe partial class CTTabView : global::MonoMac.AppKit.NSView {
		[CompilerGenerated]
		const string selState = "state";
		static readonly IntPtr selStateHandle = Selector.GetHandle ("state");
		[CompilerGenerated]
		const string selSetState_ = "setState:";
		static readonly IntPtr selSetState_Handle = Selector.GetHandle ("setState:");
		[CompilerGenerated]
		const string selHoverAlpha = "hoverAlpha";
		static readonly IntPtr selHoverAlphaHandle = Selector.GetHandle ("hoverAlpha");
		[CompilerGenerated]
		const string selSetHoverAlpha_ = "setHoverAlpha:";
		static readonly IntPtr selSetHoverAlpha_Handle = Selector.GetHandle ("setHoverAlpha:");
		[CompilerGenerated]
		const string selAlertAlpha = "alertAlpha";
		static readonly IntPtr selAlertAlphaHandle = Selector.GetHandle ("alertAlpha");
		[CompilerGenerated]
		const string selSetAlertAlpha_ = "setAlertAlpha:";
		static readonly IntPtr selSetAlertAlpha_Handle = Selector.GetHandle ("setAlertAlpha:");
		[CompilerGenerated]
		const string selIsClosing = "isClosing";
		static readonly IntPtr selIsClosingHandle = Selector.GetHandle ("isClosing");
		[CompilerGenerated]
		const string selSetClosing_ = "setClosing:";
		static readonly IntPtr selSetClosing_Handle = Selector.GetHandle ("setClosing:");
		[CompilerGenerated]
		const string selSetTrackingEnabled_ = "setTrackingEnabled:";
		static readonly IntPtr selSetTrackingEnabled_Handle = Selector.GetHandle ("setTrackingEnabled:");
		[CompilerGenerated]
		const string selStartAlert = "startAlert";
		static readonly IntPtr selStartAlertHandle = Selector.GetHandle ("startAlert");
		[CompilerGenerated]
		const string selCancelAlert = "cancelAlert";
		static readonly IntPtr selCancelAlertHandle = Selector.GetHandle ("cancelAlert");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("CTTabView");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public CTTabView () : base (NSObjectFlag.Empty)
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
		public CTTabView (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public CTTabView (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ChromiumTabsAPI.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public CTTabView (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ChromiumTabsAPI.Messaging.this_assembly;
		}

		[Export ("setTrackingEnabled:")]
		[CompilerGenerated]
		public virtual void SetTrackingEnabled (bool enabled)
		{
			if (IsDirectBinding) {
				MonoMac.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetTrackingEnabled_Handle, enabled);
			} else {
				MonoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetTrackingEnabled_Handle, enabled);
			}
		}
		
		[Export ("startAlert")]
		[CompilerGenerated]
		public virtual void StartAlert ()
		{
			if (IsDirectBinding) {
				MonoMac.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selStartAlertHandle);
			} else {
				MonoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selStartAlertHandle);
			}
		}
		
		[Export ("cancelAlert")]
		[CompilerGenerated]
		public virtual void CancelAlert ()
		{
			if (IsDirectBinding) {
				MonoMac.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selCancelAlertHandle);
			} else {
				MonoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selCancelAlertHandle);
			}
		}
		
		[CompilerGenerated]
		public virtual global::MonoMac.AppKit.NSCellStateValue State {
			[Export ("state")]
			get {
				if (IsDirectBinding) {
					return (global::MonoMac.AppKit.NSCellStateValue) MonoMac.ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selStateHandle);
				} else {
					return (global::MonoMac.AppKit.NSCellStateValue) MonoMac.ObjCRuntime.Messaging.int_objc_msgSendSuper (this.SuperHandle, selStateHandle);
				}
			}
			
			[Export ("setState:")]
			set {
				if (IsDirectBinding) {
					MonoMac.ObjCRuntime.Messaging.void_objc_msgSend_int (this.Handle, selSetState_Handle, (int)value);
				} else {
					MonoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, selSetState_Handle, (int)value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual float HoverAlpha {
			[Export ("hoverAlpha")]
			get {
				if (IsDirectBinding) {
					return MonoMac.ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selHoverAlphaHandle);
				} else {
					return MonoMac.ObjCRuntime.Messaging.float_objc_msgSendSuper (this.SuperHandle, selHoverAlphaHandle);
				}
			}
			
			[Export ("setHoverAlpha:")]
			set {
				if (IsDirectBinding) {
					MonoMac.ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetHoverAlpha_Handle, value);
				} else {
					MonoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, selSetHoverAlpha_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual float AlertAlpha {
			[Export ("alertAlpha")]
			get {
				if (IsDirectBinding) {
					return MonoMac.ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selAlertAlphaHandle);
				} else {
					return MonoMac.ObjCRuntime.Messaging.float_objc_msgSendSuper (this.SuperHandle, selAlertAlphaHandle);
				}
			}
			
			[Export ("setAlertAlpha:")]
			set {
				if (IsDirectBinding) {
					MonoMac.ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetAlertAlpha_Handle, value);
				} else {
					MonoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, selSetAlertAlpha_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool Closing {
			[Export ("isClosing")]
			get {
				if (IsDirectBinding) {
					return MonoMac.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsClosingHandle);
				} else {
					return MonoMac.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsClosingHandle);
				}
			}
			
			[Export ("setClosing:")]
			set {
				if (IsDirectBinding) {
					MonoMac.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetClosing_Handle, value);
				} else {
					MonoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetClosing_Handle, value);
				}
			}
		}
		
	} /* class CTTabView */
}
