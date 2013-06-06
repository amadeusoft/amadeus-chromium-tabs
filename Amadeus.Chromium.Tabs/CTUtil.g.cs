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
	[Register("CTUtil", true)]
	public unsafe partial class CTUtil : NSObject {
		[CompilerGenerated]
		const string selBundleForResourceOfType_ = "bundleForResource:ofType:";
		static readonly IntPtr selBundleForResourceOfType_Handle = Selector.GetHandle ("bundleForResource:ofType:");
		[CompilerGenerated]
		const string selBundleForResource_ = "bundleForResource:";
		static readonly IntPtr selBundleForResource_Handle = Selector.GetHandle ("bundleForResource:");
		[CompilerGenerated]
		const string selPathForResourceOfType_ = "pathForResource:ofType:";
		static readonly IntPtr selPathForResourceOfType_Handle = Selector.GetHandle ("pathForResource:ofType:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("CTUtil");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public CTUtil () : base (NSObjectFlag.Empty)
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
		public CTUtil (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public CTUtil (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ChromiumTabsAPI.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public CTUtil (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ChromiumTabsAPI.Messaging.this_assembly;
		}

		[Export ("bundleForResource:ofType:")]
		[CompilerGenerated]
		public static NSBundle BundleForResource (string name, string ext)
		{
			if (name == null)
				throw new ArgumentNullException ("name");
			if (ext == null)
				throw new ArgumentNullException ("ext");
			var nsname = NSString.CreateNative (name);
			var nsext = NSString.CreateNative (ext);
			
			NSBundle ret;
			ret = (NSBundle) Runtime.GetNSObject (MonoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (class_ptr, selBundleForResourceOfType_Handle, nsname, nsext));
			NSString.ReleaseNative (nsname);
			NSString.ReleaseNative (nsext);
			
			return ret;
		}
		
		[Export ("bundleForResource:")]
		[CompilerGenerated]
		public static NSBundle BundleForResource (string name)
		{
			if (name == null)
				throw new ArgumentNullException ("name");
			var nsname = NSString.CreateNative (name);
			
			NSBundle ret;
			ret = (NSBundle) Runtime.GetNSObject (MonoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, selBundleForResource_Handle, nsname));
			NSString.ReleaseNative (nsname);
			
			return ret;
		}
		
		[Export ("pathForResource:ofType:")]
		[CompilerGenerated]
		public static string PathForResource (string name, string ext)
		{
			if (name == null)
				throw new ArgumentNullException ("name");
			if (ext == null)
				throw new ArgumentNullException ("ext");
			var nsname = NSString.CreateNative (name);
			var nsext = NSString.CreateNative (ext);
			
			string ret;
			ret = NSString.FromHandle (MonoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (class_ptr, selPathForResourceOfType_Handle, nsname, nsext));
			NSString.ReleaseNative (nsname);
			NSString.ReleaseNative (nsext);
			
			return ret;
		}
		
	} /* class CTUtil */
}
