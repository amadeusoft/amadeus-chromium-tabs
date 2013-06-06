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
	[Register("CTTabStripModelDelegate", true)]
	[Model]
	public unsafe abstract partial class CTTabStripModelDelegate : NSObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("NSObject");
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public CTTabStripModelDelegate () : base (NSObjectFlag.Empty)
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
		public CTTabStripModelDelegate (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public CTTabStripModelDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ChromiumTabsAPI.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public CTTabStripModelDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ChromiumTabsAPI.Messaging.this_assembly;
		}

		[Export ("addBlankTabInForeground:")]
		[CompilerGenerated]
		public abstract CTTabContents AddBlankTabInForeground (bool foreground);
		[Export ("addBlankTabAtIndex:inForeground:")]
		[CompilerGenerated]
		public abstract CTTabContents AddBlankTabAtIndex (int index, bool foreground);
		[Export ("createNewStripWithContents:")]
		[CompilerGenerated]
		public abstract CTBrowser CreateNewStripWithContents (CTTabContents contents);
		[Export ("canDuplicateContentsAt:")]
		[CompilerGenerated]
		public abstract bool CanDuplicateContentsAt (int index);
		[Export ("duplicateContentsAt:")]
		[CompilerGenerated]
		public abstract void DuplicateContentsAt (int index);
		[Export ("closeFrameAfterDragSession")]
		[CompilerGenerated]
		public abstract void CloseFrameAfterDragSession ();
		[Export ("createHistoricalTab:")]
		[CompilerGenerated]
		public abstract void CreateHistoricalTab (CTTabContents contents);
		[Export ("runUnloadListenerBeforeClosing:")]
		[CompilerGenerated]
		public abstract bool RunUnloadListenerBeforeClosing (CTTabContents contents);
		[Export ("canRestoreTab")]
		[CompilerGenerated]
		public abstract bool CanRestoreTab ();
		[Export ("restoreTab")]
		[CompilerGenerated]
		public abstract void RestoreTab ();
		[Export ("canCloseContentsAt:")]
		[CompilerGenerated]
		public abstract bool CanCloseContentsAt (int index);
		[Export ("canCloseTab")]
		[CompilerGenerated]
		public abstract bool CanCloseTab ();
	} /* class CTTabStripModelDelegate */
}
