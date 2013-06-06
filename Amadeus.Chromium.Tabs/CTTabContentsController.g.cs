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
	[Register("CTTabContentsController", true)]
	public unsafe partial class CTTabContentsController : global::MonoMac.AppKit.NSViewController {
		[CompilerGenerated]
		const string selInitWithNibNameBundleContents_ = "initWithNibName:bundle:contents:";
		static readonly IntPtr selInitWithNibNameBundleContents_Handle = Selector.GetHandle ("initWithNibName:bundle:contents:");
		[CompilerGenerated]
		const string selInitWithContents_ = "initWithContents:";
		static readonly IntPtr selInitWithContents_Handle = Selector.GetHandle ("initWithContents:");
		[CompilerGenerated]
		const string selIsCurrentTab = "isCurrentTab";
		static readonly IntPtr selIsCurrentTabHandle = Selector.GetHandle ("isCurrentTab");
		[CompilerGenerated]
		const string selWillResignSelectedTab = "willResignSelectedTab";
		static readonly IntPtr selWillResignSelectedTabHandle = Selector.GetHandle ("willResignSelectedTab");
		[CompilerGenerated]
		const string selWillBecomeSelectedTab = "willBecomeSelectedTab";
		static readonly IntPtr selWillBecomeSelectedTabHandle = Selector.GetHandle ("willBecomeSelectedTab");
		[CompilerGenerated]
		const string selEnsureContentsVisible = "ensureContentsVisible";
		static readonly IntPtr selEnsureContentsVisibleHandle = Selector.GetHandle ("ensureContentsVisible");
		[CompilerGenerated]
		const string selTabDidChange_ = "tabDidChange:";
		static readonly IntPtr selTabDidChange_Handle = Selector.GetHandle ("tabDidChange:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("CTTabContentsController");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public CTTabContentsController () : base (NSObjectFlag.Empty)
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
		public CTTabContentsController (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public CTTabContentsController (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ChromiumTabsAPI.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public CTTabContentsController (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ChromiumTabsAPI.Messaging.this_assembly;
		}

		[Export ("initWithNibName:bundle:contents:")]
		[CompilerGenerated]
		public CTTabContentsController (string name, NSBundle bundle, CTTabContents contents)
			: base (NSObjectFlag.Empty)
		{
			if (name == null)
				throw new ArgumentNullException ("name");
			if (bundle == null)
				throw new ArgumentNullException ("bundle");
			if (contents == null)
				throw new ArgumentNullException ("contents");
			var nsname = NSString.CreateNative (name);
			
			IsDirectBinding = GetType ().Assembly == global::ChromiumTabsAPI.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr (this.Handle, selInitWithNibNameBundleContents_Handle, nsname, bundle.Handle, contents.Handle);
			} else {
				Handle = MonoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr (this.SuperHandle, selInitWithNibNameBundleContents_Handle, nsname, bundle.Handle, contents.Handle);
			}
			NSString.ReleaseNative (nsname);
			
		}
		
		[Export ("initWithContents:")]
		[CompilerGenerated]
		public CTTabContentsController (CTTabContents contents)
			: base (NSObjectFlag.Empty)
		{
			if (contents == null)
				throw new ArgumentNullException ("contents");
			IsDirectBinding = GetType ().Assembly == global::ChromiumTabsAPI.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selInitWithContents_Handle, contents.Handle);
			} else {
				Handle = MonoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, selInitWithContents_Handle, contents.Handle);
			}
		}
		
		[Export ("isCurrentTab")]
		[CompilerGenerated]
		public virtual bool IsCurrentTab ()
		{
			if (IsDirectBinding) {
				return MonoMac.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsCurrentTabHandle);
			} else {
				return MonoMac.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsCurrentTabHandle);
			}
		}
		
		[Export ("willResignSelectedTab")]
		[CompilerGenerated]
		public virtual void WillResignSelectedTab ()
		{
			if (IsDirectBinding) {
				MonoMac.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selWillResignSelectedTabHandle);
			} else {
				MonoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selWillResignSelectedTabHandle);
			}
		}
		
		[Export ("willBecomeSelectedTab")]
		[CompilerGenerated]
		public virtual void WillBecomeSelectedTab ()
		{
			if (IsDirectBinding) {
				MonoMac.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selWillBecomeSelectedTabHandle);
			} else {
				MonoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selWillBecomeSelectedTabHandle);
			}
		}
		
		[Export ("ensureContentsVisible")]
		[CompilerGenerated]
		public virtual void EnsureContentsVisible ()
		{
			if (IsDirectBinding) {
				MonoMac.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selEnsureContentsVisibleHandle);
			} else {
				MonoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selEnsureContentsVisibleHandle);
			}
		}
		
		[Export ("tabDidChange:")]
		[CompilerGenerated]
		public virtual void TabDidChange (CTTabContents updatedContents)
		{
			if (updatedContents == null)
				throw new ArgumentNullException ("updatedContents");
			if (IsDirectBinding) {
				MonoMac.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selTabDidChange_Handle, updatedContents.Handle);
			} else {
				MonoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selTabDidChange_Handle, updatedContents.Handle);
			}
		}
		
	} /* class CTTabContentsController */
}
