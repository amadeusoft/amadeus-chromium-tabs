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
	[Register("CTTabStripView", true)]
	public unsafe partial class CTTabStripView : global::MonoMac.AppKit.NSView {
		[CompilerGenerated]
		const string selNewTabButton = "NewTabButton";
		static readonly IntPtr selNewTabButtonHandle = Selector.GetHandle ("NewTabButton");
		[CompilerGenerated]
		const string selSetNewTabButton_ = "setNewTabButton:";
		static readonly IntPtr selSetNewTabButton_Handle = Selector.GetHandle ("setNewTabButton:");
		[CompilerGenerated]
		const string selDropArrowShown = "dropArrowShown";
		static readonly IntPtr selDropArrowShownHandle = Selector.GetHandle ("dropArrowShown");
		[CompilerGenerated]
		const string selSetDropArrowShown_ = "setDropArrowShown:";
		static readonly IntPtr selSetDropArrowShown_Handle = Selector.GetHandle ("setDropArrowShown:");
		[CompilerGenerated]
		const string selDropArrowPosition = "dropArrowPosition";
		static readonly IntPtr selDropArrowPositionHandle = Selector.GetHandle ("dropArrowPosition");
		[CompilerGenerated]
		const string selSetDropArrowPosition_ = "setDropArrowPosition:";
		static readonly IntPtr selSetDropArrowPosition_Handle = Selector.GetHandle ("setDropArrowPosition:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("CTTabStripView");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public CTTabStripView () : base (NSObjectFlag.Empty)
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
		public CTTabStripView (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public CTTabStripView (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ChromiumTabsAPI.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public CTTabStripView (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ChromiumTabsAPI.Messaging.this_assembly;
		}

		[CompilerGenerated]
		object __mt_NewTabButton_var;
		[CompilerGenerated]
		public virtual NSObject NewTabButton {
			[Export ("NewTabButton")]
			get {
				NSObject ret;
				if (IsDirectBinding) {
					ret = (NSObject) Runtime.GetNSObject (MonoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selNewTabButtonHandle));
				} else {
					ret = (NSObject) Runtime.GetNSObject (MonoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selNewTabButtonHandle));
				}
				__mt_NewTabButton_var = ret;
				return ret;
			}
			
			[Export ("setNewTabButton:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoMac.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetNewTabButton_Handle, value.Handle);
				} else {
					MonoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetNewTabButton_Handle, value.Handle);
				}
				__mt_NewTabButton_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual bool DropArrowShown {
			[Export ("dropArrowShown")]
			get {
				if (IsDirectBinding) {
					return MonoMac.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selDropArrowShownHandle);
				} else {
					return MonoMac.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selDropArrowShownHandle);
				}
			}
			
			[Export ("setDropArrowShown:")]
			set {
				if (IsDirectBinding) {
					MonoMac.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetDropArrowShown_Handle, value);
				} else {
					MonoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetDropArrowShown_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.Drawing.PointF DropArrowPosition {
			[Export ("dropArrowPosition")]
			get {
				global::System.Drawing.PointF ret;
				if (IsDirectBinding) {
					ret = MonoMac.ObjCRuntime.Messaging.PointF_objc_msgSend (this.Handle, selDropArrowPositionHandle);
				} else {
					ret = MonoMac.ObjCRuntime.Messaging.PointF_objc_msgSendSuper (this.SuperHandle, selDropArrowPositionHandle);
				}
				return ret;
			}
			
			[Export ("setDropArrowPosition:")]
			set {
				if (IsDirectBinding) {
					MonoMac.ObjCRuntime.Messaging.void_objc_msgSend_PointF (this.Handle, selSetDropArrowPosition_Handle, value);
				} else {
					MonoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper_PointF (this.SuperHandle, selSetDropArrowPosition_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_NewTabButton_var = null;
			}
		}
	} /* class CTTabStripView */
}
