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
	[Register("CTToolbarController", true)]
	public unsafe partial class CTToolbarController : global::MonoMac.AppKit.NSViewController {
		[CompilerGenerated]
		const string selInitWithNibNameBundleBrowser_ = "initWithNibName:bundle:browser:";
		static readonly IntPtr selInitWithNibNameBundleBrowser_Handle = Selector.GetHandle ("initWithNibName:bundle:browser:");
		[CompilerGenerated]
		const string selSetDividerOpacity_ = "setDividerOpacity:";
		static readonly IntPtr selSetDividerOpacity_Handle = Selector.GetHandle ("setDividerOpacity:");
		[CompilerGenerated]
		const string selUpdateToolbarWithContentsShouldRestoreState_ = "updateToolbarWithContents:shouldRestoreState:";
		static readonly IntPtr selUpdateToolbarWithContentsShouldRestoreState_Handle = Selector.GetHandle ("updateToolbarWithContents:shouldRestoreState:");
		[CompilerGenerated]
		const string selCustomFieldEditorForObject_ = "customFieldEditorForObject:";
		static readonly IntPtr selCustomFieldEditorForObject_Handle = Selector.GetHandle ("customFieldEditorForObject:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("CTToolbarController");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public CTToolbarController () : base (NSObjectFlag.Empty)
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
		public CTToolbarController (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public CTToolbarController (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ChromiumTabsAPI.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public CTToolbarController (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ChromiumTabsAPI.Messaging.this_assembly;
		}

		[Export ("initWithNibName:bundle:browser:")]
		[CompilerGenerated]
		public CTToolbarController (string nibName, NSBundle bundle, CTBrowser browser)
			: base (NSObjectFlag.Empty)
		{
			if (nibName == null)
				throw new ArgumentNullException ("nibName");
			if (bundle == null)
				throw new ArgumentNullException ("bundle");
			if (browser == null)
				throw new ArgumentNullException ("browser");
			var nsnibName = NSString.CreateNative (nibName);
			
			IsDirectBinding = GetType ().Assembly == global::ChromiumTabsAPI.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr (this.Handle, selInitWithNibNameBundleBrowser_Handle, nsnibName, bundle.Handle, browser.Handle);
			} else {
				Handle = MonoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr (this.SuperHandle, selInitWithNibNameBundleBrowser_Handle, nsnibName, bundle.Handle, browser.Handle);
			}
			NSString.ReleaseNative (nsnibName);
			
		}
		
		[Export ("setDividerOpacity:")]
		[CompilerGenerated]
		public virtual void SetDividerOpacity (float opacity)
		{
			if (IsDirectBinding) {
				MonoMac.ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetDividerOpacity_Handle, opacity);
			} else {
				MonoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, selSetDividerOpacity_Handle, opacity);
			}
		}
		
		[Export ("updateToolbarWithContents:shouldRestoreState:")]
		[CompilerGenerated]
		public virtual void UpdateToolbarWithContents (CTTabContents contents, bool shouldRestore)
		{
			if (IsDirectBinding) {
				MonoMac.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_bool (this.Handle, selUpdateToolbarWithContentsShouldRestoreState_Handle, contents == null ? IntPtr.Zero : contents.Handle, shouldRestore);
			} else {
				MonoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_bool (this.SuperHandle, selUpdateToolbarWithContentsShouldRestoreState_Handle, contents == null ? IntPtr.Zero : contents.Handle, shouldRestore);
			}
		}
		
		[Export ("customFieldEditorForObject:")]
		[CompilerGenerated]
		public virtual NSObject CustomFieldEditorForObject (NSObject obj)
		{
			if (obj == null)
				throw new ArgumentNullException ("obj");
			if (IsDirectBinding) {
				return (NSObject) Runtime.GetNSObject (MonoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selCustomFieldEditorForObject_Handle, obj.Handle));
			} else {
				return (NSObject) Runtime.GetNSObject (MonoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, selCustomFieldEditorForObject_Handle, obj.Handle));
			}
		}
		
	} /* class CTToolbarController */
}
