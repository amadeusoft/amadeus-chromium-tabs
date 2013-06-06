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

namespace ChromiumTabsAPI {
	public partial class Messaging {
		static internal System.Reflection.Assembly this_assembly = typeof (Messaging).Assembly;

		const string LIBOBJC_DYLIB = "/usr/lib/libobjc.dylib";

		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		public extern static IntPtr IntPtr_objc_msgSend_IntPtr_int_bool (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, bool arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		public extern static IntPtr IntPtr_objc_msgSendSuper_IntPtr_int_bool (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, bool arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		public extern static void void_objc_msgSend_IntPtr_RectangleF_bool (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.Drawing.RectangleF arg2, bool arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		public extern static void void_objc_msgSendSuper_IntPtr_RectangleF_bool (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.Drawing.RectangleF arg2, bool arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSend")]
		public extern static void void_objc_msgSend_IntPtr_RectangleF_float (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.Drawing.RectangleF arg2, float arg3);
		[DllImport (LIBOBJC_DYLIB, EntryPoint="objc_msgSendSuper")]
		public extern static void void_objc_msgSendSuper_IntPtr_RectangleF_float (IntPtr receiver, IntPtr selector, IntPtr arg1, global::System.Drawing.RectangleF arg2, float arg3);
	}
}
