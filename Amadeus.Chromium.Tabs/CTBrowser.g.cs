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
	[Register("CTBrowser", true)]
	public unsafe partial class CTBrowser : NSObject {
		[CompilerGenerated]
		const string selWindowController = "windowController";
		static readonly IntPtr selWindowControllerHandle = Selector.GetHandle ("windowController");
		[CompilerGenerated]
		const string selWindow = "window";
		static readonly IntPtr selWindowHandle = Selector.GetHandle ("window");
		[CompilerGenerated]
		const string selBrowser = "browser";
		static readonly IntPtr selBrowserHandle = Selector.GetHandle ("browser");
		[CompilerGenerated]
		const string selCreateToolbarController = "createToolbarController";
		static readonly IntPtr selCreateToolbarControllerHandle = Selector.GetHandle ("createToolbarController");
		[CompilerGenerated]
		const string selCreateTabContentsControllerWithContents_ = "createTabContentsControllerWithContents:";
		static readonly IntPtr selCreateTabContentsControllerWithContents_Handle = Selector.GetHandle ("createTabContentsControllerWithContents:");
		[CompilerGenerated]
		const string selCreateBlankTabBasedOn_ = "createBlankTabBasedOn:";
		static readonly IntPtr selCreateBlankTabBasedOn_Handle = Selector.GetHandle ("createBlankTabBasedOn:");
		[CompilerGenerated]
		const string selAddBlankTab = "addBlankTab";
		static readonly IntPtr selAddBlankTabHandle = Selector.GetHandle ("addBlankTab");
		[CompilerGenerated]
		const string selAddTabContentsAtIndexInForeground_ = "addTabContents:atIndex:inForeground:";
		static readonly IntPtr selAddTabContentsAtIndexInForeground_Handle = Selector.GetHandle ("addTabContents:atIndex:inForeground:");
		[CompilerGenerated]
		const string selAddTabContentsInForeground_ = "addTabContents:inForeground:";
		static readonly IntPtr selAddTabContentsInForeground_Handle = Selector.GetHandle ("addTabContents:inForeground:");
		[CompilerGenerated]
		const string selAddTabContents_ = "addTabContents:";
		static readonly IntPtr selAddTabContents_Handle = Selector.GetHandle ("addTabContents:");
		[CompilerGenerated]
		const string selNewWindow = "newWindow";
		static readonly IntPtr selNewWindowHandle = Selector.GetHandle ("newWindow");
		[CompilerGenerated]
		const string selCloseWindow = "closeWindow";
		static readonly IntPtr selCloseWindowHandle = Selector.GetHandle ("closeWindow");
		[CompilerGenerated]
		const string selCloseTab = "closeTab";
		static readonly IntPtr selCloseTabHandle = Selector.GetHandle ("closeTab");
		[CompilerGenerated]
		const string selSelectNextTab = "selectNextTab";
		static readonly IntPtr selSelectNextTabHandle = Selector.GetHandle ("selectNextTab");
		[CompilerGenerated]
		const string selSelectPreviousTab = "selectPreviousTab";
		static readonly IntPtr selSelectPreviousTabHandle = Selector.GetHandle ("selectPreviousTab");
		[CompilerGenerated]
		const string selMoveTabNext = "moveTabNext";
		static readonly IntPtr selMoveTabNextHandle = Selector.GetHandle ("moveTabNext");
		[CompilerGenerated]
		const string selMoveTabPrevious = "moveTabPrevious";
		static readonly IntPtr selMoveTabPreviousHandle = Selector.GetHandle ("moveTabPrevious");
		[CompilerGenerated]
		const string selSelectTabAtIndex_ = "selectTabAtIndex:";
		static readonly IntPtr selSelectTabAtIndex_Handle = Selector.GetHandle ("selectTabAtIndex:");
		[CompilerGenerated]
		const string selSelectLastTab = "selectLastTab";
		static readonly IntPtr selSelectLastTabHandle = Selector.GetHandle ("selectLastTab");
		[CompilerGenerated]
		const string selDuplicateTab = "duplicateTab";
		static readonly IntPtr selDuplicateTabHandle = Selector.GetHandle ("duplicateTab");
		[CompilerGenerated]
		const string selExecuteCommand_ = "executeCommand:";
		static readonly IntPtr selExecuteCommand_Handle = Selector.GetHandle ("executeCommand:");
		[CompilerGenerated]
		const string selExecuteCommandWithDisposition_ = "executeCommand:withDisposition:";
		static readonly IntPtr selExecuteCommandWithDisposition_Handle = Selector.GetHandle ("executeCommand:withDisposition:");
		[CompilerGenerated]
		const string selLoadingStateDidChange_ = "loadingStateDidChange:";
		static readonly IntPtr selLoadingStateDidChange_Handle = Selector.GetHandle ("loadingStateDidChange:");
		[CompilerGenerated]
		const string selWindowDidBeginToClose = "windowDidBeginToClose";
		static readonly IntPtr selWindowDidBeginToCloseHandle = Selector.GetHandle ("windowDidBeginToClose");
		[CompilerGenerated]
		const string selTabCount = "tabCount";
		static readonly IntPtr selTabCountHandle = Selector.GetHandle ("tabCount");
		[CompilerGenerated]
		const string selSelectedTabIndex = "selectedTabIndex";
		static readonly IntPtr selSelectedTabIndexHandle = Selector.GetHandle ("selectedTabIndex");
		[CompilerGenerated]
		const string selSelectedTabContents = "selectedTabContents";
		static readonly IntPtr selSelectedTabContentsHandle = Selector.GetHandle ("selectedTabContents");
		[CompilerGenerated]
		const string selTabContentsAtIndex_ = "tabContentsAtIndex:";
		static readonly IntPtr selTabContentsAtIndex_Handle = Selector.GetHandle ("tabContentsAtIndex:");
		[CompilerGenerated]
		const string selAllTabContents = "allTabContents";
		static readonly IntPtr selAllTabContentsHandle = Selector.GetHandle ("allTabContents");
		[CompilerGenerated]
		const string selIndexOfTabContents_ = "indexOfTabContents:";
		static readonly IntPtr selIndexOfTabContents_Handle = Selector.GetHandle ("indexOfTabContents:");
		[CompilerGenerated]
		const string selSelectTabContentsAtIndexUserGesture_ = "selectTabContentsAtIndex:userGesture:";
		static readonly IntPtr selSelectTabContentsAtIndexUserGesture_Handle = Selector.GetHandle ("selectTabContentsAtIndex:userGesture:");
		[CompilerGenerated]
		const string selUpdateTabStateAtIndex_ = "updateTabStateAtIndex:";
		static readonly IntPtr selUpdateTabStateAtIndex_Handle = Selector.GetHandle ("updateTabStateAtIndex:");
		[CompilerGenerated]
		const string selUpdateTabStateForContent_ = "updateTabStateForContent:";
		static readonly IntPtr selUpdateTabStateForContent_Handle = Selector.GetHandle ("updateTabStateForContent:");
		[CompilerGenerated]
		const string selReplaceTabContentsAtIndexWithTabContents_ = "replaceTabContentsAtIndex:withTabContents:";
		static readonly IntPtr selReplaceTabContentsAtIndexWithTabContents_Handle = Selector.GetHandle ("replaceTabContentsAtIndex:withTabContents:");
		[CompilerGenerated]
		const string selCloseTabAtIndexMakeHistory_ = "closeTabAtIndex:makeHistory:";
		static readonly IntPtr selCloseTabAtIndexMakeHistory_Handle = Selector.GetHandle ("closeTabAtIndex:makeHistory:");
		[CompilerGenerated]
		const string selCloseAllTabs = "closeAllTabs";
		static readonly IntPtr selCloseAllTabsHandle = Selector.GetHandle ("closeAllTabs");
		[CompilerGenerated]
		const string selAddBlankTabInForeground_ = "addBlankTabInForeground:";
		static readonly IntPtr selAddBlankTabInForeground_Handle = Selector.GetHandle ("addBlankTabInForeground:");
		[CompilerGenerated]
		const string selAddBlankTabAtIndexInForeground_ = "addBlankTabAtIndex:inForeground:";
		static readonly IntPtr selAddBlankTabAtIndexInForeground_Handle = Selector.GetHandle ("addBlankTabAtIndex:inForeground:");
		[CompilerGenerated]
		const string selCreateNewStripWithContents_ = "createNewStripWithContents:";
		static readonly IntPtr selCreateNewStripWithContents_Handle = Selector.GetHandle ("createNewStripWithContents:");
		[CompilerGenerated]
		const string selCanDuplicateContentsAt_ = "canDuplicateContentsAt:";
		static readonly IntPtr selCanDuplicateContentsAt_Handle = Selector.GetHandle ("canDuplicateContentsAt:");
		[CompilerGenerated]
		const string selDuplicateContentsAt_ = "duplicateContentsAt:";
		static readonly IntPtr selDuplicateContentsAt_Handle = Selector.GetHandle ("duplicateContentsAt:");
		[CompilerGenerated]
		const string selCloseFrameAfterDragSession = "closeFrameAfterDragSession";
		static readonly IntPtr selCloseFrameAfterDragSessionHandle = Selector.GetHandle ("closeFrameAfterDragSession");
		[CompilerGenerated]
		const string selCreateHistoricalTab_ = "createHistoricalTab:";
		static readonly IntPtr selCreateHistoricalTab_Handle = Selector.GetHandle ("createHistoricalTab:");
		[CompilerGenerated]
		const string selRunUnloadListenerBeforeClosing_ = "runUnloadListenerBeforeClosing:";
		static readonly IntPtr selRunUnloadListenerBeforeClosing_Handle = Selector.GetHandle ("runUnloadListenerBeforeClosing:");
		[CompilerGenerated]
		const string selCanRestoreTab = "canRestoreTab";
		static readonly IntPtr selCanRestoreTabHandle = Selector.GetHandle ("canRestoreTab");
		[CompilerGenerated]
		const string selRestoreTab = "restoreTab";
		static readonly IntPtr selRestoreTabHandle = Selector.GetHandle ("restoreTab");
		[CompilerGenerated]
		const string selCanCloseContentsAt_ = "canCloseContentsAt:";
		static readonly IntPtr selCanCloseContentsAt_Handle = Selector.GetHandle ("canCloseContentsAt:");
		[CompilerGenerated]
		const string selCanCloseTab = "canCloseTab";
		static readonly IntPtr selCanCloseTabHandle = Selector.GetHandle ("canCloseTab");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("CTBrowser");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public CTBrowser () : base (NSObjectFlag.Empty)
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
		public CTBrowser (NSCoder coder) : base (NSObjectFlag.Empty)
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
		public CTBrowser (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ChromiumTabsAPI.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public CTBrowser (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ChromiumTabsAPI.Messaging.this_assembly;
		}

		[Export ("browser")]
		[CompilerGenerated]
		public static CTBrowser Browser ()
		{
			return (CTBrowser) Runtime.GetNSObject (MonoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSend (class_ptr, selBrowserHandle));
		}
		
		[Export ("createToolbarController")]
		[CompilerGenerated]
		public virtual CTToolbarController CreateToolbarController ()
		{
			if (IsDirectBinding) {
				return (CTToolbarController) Runtime.GetNSObject (MonoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selCreateToolbarControllerHandle));
			} else {
				return (CTToolbarController) Runtime.GetNSObject (MonoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selCreateToolbarControllerHandle));
			}
		}
		
		[Export ("createTabContentsControllerWithContents:")]
		[CompilerGenerated]
		public virtual CTTabContentsController CreateTabContentsControllerWithContents (CTTabContents contents)
		{
			if (contents == null)
				throw new ArgumentNullException ("contents");
			if (IsDirectBinding) {
				return (CTTabContentsController) Runtime.GetNSObject (MonoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selCreateTabContentsControllerWithContents_Handle, contents.Handle));
			} else {
				return (CTTabContentsController) Runtime.GetNSObject (MonoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, selCreateTabContentsControllerWithContents_Handle, contents.Handle));
			}
		}
		
		[Export ("createBlankTabBasedOn:")]
		[CompilerGenerated]
		public virtual CTTabContents CreateBlankTabBasedOn (CTTabContents baseContents)
		{
			if (IsDirectBinding) {
				return (CTTabContents) Runtime.GetNSObject (MonoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selCreateBlankTabBasedOn_Handle, baseContents == null ? IntPtr.Zero : baseContents.Handle));
			} else {
				return (CTTabContents) Runtime.GetNSObject (MonoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, selCreateBlankTabBasedOn_Handle, baseContents == null ? IntPtr.Zero : baseContents.Handle));
			}
		}
		
		[Export ("addBlankTab")]
		[CompilerGenerated]
		public virtual CTTabContents AddBlankTab ()
		{
			if (IsDirectBinding) {
				return (CTTabContents) Runtime.GetNSObject (MonoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selAddBlankTabHandle));
			} else {
				return (CTTabContents) Runtime.GetNSObject (MonoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selAddBlankTabHandle));
			}
		}
		
		[Export ("addTabContents:atIndex:inForeground:")]
		[CompilerGenerated]
		public virtual CTTabContents AddTabContents (CTTabContents contents, int index, bool foreground)
		{
			if (contents == null)
				throw new ArgumentNullException ("contents");
			if (IsDirectBinding) {
				return (CTTabContents) Runtime.GetNSObject (ChromiumTabsAPI.Messaging.IntPtr_objc_msgSend_IntPtr_int_bool (this.Handle, selAddTabContentsAtIndexInForeground_Handle, contents.Handle, index, foreground));
			} else {
				return (CTTabContents) Runtime.GetNSObject (ChromiumTabsAPI.Messaging.IntPtr_objc_msgSendSuper_IntPtr_int_bool (this.SuperHandle, selAddTabContentsAtIndexInForeground_Handle, contents.Handle, index, foreground));
			}
		}
		
		[Export ("addTabContents:inForeground:")]
		[CompilerGenerated]
		public virtual CTTabContents AddTabContents (CTTabContents contents, bool foreground)
		{
			if (contents == null)
				throw new ArgumentNullException ("contents");
			if (IsDirectBinding) {
				return (CTTabContents) Runtime.GetNSObject (MonoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_bool (this.Handle, selAddTabContentsInForeground_Handle, contents.Handle, foreground));
			} else {
				return (CTTabContents) Runtime.GetNSObject (MonoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr_bool (this.SuperHandle, selAddTabContentsInForeground_Handle, contents.Handle, foreground));
			}
		}
		
		[Export ("addTabContents:")]
		[CompilerGenerated]
		public virtual CTTabContents AddTabContents (CTTabContents contents)
		{
			if (contents == null)
				throw new ArgumentNullException ("contents");
			if (IsDirectBinding) {
				return (CTTabContents) Runtime.GetNSObject (MonoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selAddTabContents_Handle, contents.Handle));
			} else {
				return (CTTabContents) Runtime.GetNSObject (MonoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, selAddTabContents_Handle, contents.Handle));
			}
		}
		
		[Export ("newWindow")]
		[CompilerGenerated]
		public virtual void NewWindow ()
		{
			if (IsDirectBinding) {
				MonoMac.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selNewWindowHandle);
			} else {
				MonoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selNewWindowHandle);
			}
		}
		
		[Export ("closeWindow")]
		[CompilerGenerated]
		public virtual void CloseWindow ()
		{
			if (IsDirectBinding) {
				MonoMac.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selCloseWindowHandle);
			} else {
				MonoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selCloseWindowHandle);
			}
		}
		
		[Export ("closeTab")]
		[CompilerGenerated]
		public virtual void CloseTab ()
		{
			if (IsDirectBinding) {
				MonoMac.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selCloseTabHandle);
			} else {
				MonoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selCloseTabHandle);
			}
		}
		
		[Export ("selectNextTab")]
		[CompilerGenerated]
		public virtual void SelectNextTab ()
		{
			if (IsDirectBinding) {
				MonoMac.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selSelectNextTabHandle);
			} else {
				MonoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selSelectNextTabHandle);
			}
		}
		
		[Export ("selectPreviousTab")]
		[CompilerGenerated]
		public virtual void SelectPreviousTab ()
		{
			if (IsDirectBinding) {
				MonoMac.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selSelectPreviousTabHandle);
			} else {
				MonoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selSelectPreviousTabHandle);
			}
		}
		
		[Export ("moveTabNext")]
		[CompilerGenerated]
		public virtual void MoveTabNext ()
		{
			if (IsDirectBinding) {
				MonoMac.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selMoveTabNextHandle);
			} else {
				MonoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selMoveTabNextHandle);
			}
		}
		
		[Export ("moveTabPrevious")]
		[CompilerGenerated]
		public virtual void MoveTabPrevious ()
		{
			if (IsDirectBinding) {
				MonoMac.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selMoveTabPreviousHandle);
			} else {
				MonoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selMoveTabPreviousHandle);
			}
		}
		
		[Export ("selectTabAtIndex:")]
		[CompilerGenerated]
		public virtual void SelectTabAtIndex (int index)
		{
			if (IsDirectBinding) {
				MonoMac.ObjCRuntime.Messaging.void_objc_msgSend_int (this.Handle, selSelectTabAtIndex_Handle, index);
			} else {
				MonoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, selSelectTabAtIndex_Handle, index);
			}
		}
		
		[Export ("selectLastTab")]
		[CompilerGenerated]
		public virtual void SelectLastTab ()
		{
			if (IsDirectBinding) {
				MonoMac.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selSelectLastTabHandle);
			} else {
				MonoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selSelectLastTabHandle);
			}
		}
		
		[Export ("duplicateTab")]
		[CompilerGenerated]
		public virtual void DuplicateTab ()
		{
			if (IsDirectBinding) {
				MonoMac.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selDuplicateTabHandle);
			} else {
				MonoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selDuplicateTabHandle);
			}
		}
		
		[Export ("executeCommand:")]
		[CompilerGenerated]
		public virtual void OnExecuteCommand (int cmd)
		{
			if (IsDirectBinding) {
				MonoMac.ObjCRuntime.Messaging.void_objc_msgSend_int (this.Handle, selExecuteCommand_Handle, cmd);
			} else {
				MonoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, selExecuteCommand_Handle, cmd);
			}
		}
		
		[Export ("executeCommand:withDisposition:")]
		[CompilerGenerated]
		public virtual void OnExecuteCommand (int cmd, CTWindowOpenDisposition disposition)
		{
			if (IsDirectBinding) {
				MonoMac.ObjCRuntime.Messaging.void_objc_msgSend_int_int (this.Handle, selExecuteCommandWithDisposition_Handle, cmd, (int)disposition);
			} else {
				MonoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper_int_int (this.SuperHandle, selExecuteCommandWithDisposition_Handle, cmd, (int)disposition);
			}
		}
		
		[Export ("executeCommand:")]
		[CompilerGenerated]
		public static void ExecuteCommand (int cmd)
		{
			MonoMac.ObjCRuntime.Messaging.void_objc_msgSend_int (class_ptr, selExecuteCommand_Handle, cmd);
		}
		
		[Export ("loadingStateDidChange:")]
		[CompilerGenerated]
		public virtual void LoadingStateDidChange (CTTabContents contents)
		{
			if (contents == null)
				throw new ArgumentNullException ("contents");
			if (IsDirectBinding) {
				MonoMac.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selLoadingStateDidChange_Handle, contents.Handle);
			} else {
				MonoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selLoadingStateDidChange_Handle, contents.Handle);
			}
		}
		
		[Export ("windowDidBeginToClose")]
		[CompilerGenerated]
		public virtual void WindowDidBeginToClose ()
		{
			if (IsDirectBinding) {
				MonoMac.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selWindowDidBeginToCloseHandle);
			} else {
				MonoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selWindowDidBeginToCloseHandle);
			}
		}
		
		[Export ("tabCount")]
		[CompilerGenerated]
		public virtual int TabCount ()
		{
			if (IsDirectBinding) {
				return MonoMac.ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selTabCountHandle);
			} else {
				return MonoMac.ObjCRuntime.Messaging.int_objc_msgSendSuper (this.SuperHandle, selTabCountHandle);
			}
		}
		
		[Export ("selectedTabIndex")]
		[CompilerGenerated]
		public virtual int SelectedTabIndex ()
		{
			if (IsDirectBinding) {
				return MonoMac.ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selSelectedTabIndexHandle);
			} else {
				return MonoMac.ObjCRuntime.Messaging.int_objc_msgSendSuper (this.SuperHandle, selSelectedTabIndexHandle);
			}
		}
		
		[Export ("selectedTabContents")]
		[CompilerGenerated]
		public virtual CTTabContents SelectedTabContents ()
		{
			if (IsDirectBinding) {
				return (CTTabContents) Runtime.GetNSObject (MonoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selSelectedTabContentsHandle));
			} else {
				return (CTTabContents) Runtime.GetNSObject (MonoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selSelectedTabContentsHandle));
			}
		}
		
		[Export ("tabContentsAtIndex:")]
		[CompilerGenerated]
		public virtual CTTabContents TabContentsAtIndex (int index)
		{
			if (IsDirectBinding) {
				return (CTTabContents) Runtime.GetNSObject (MonoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSend_int (this.Handle, selTabContentsAtIndex_Handle, index));
			} else {
				return (CTTabContents) Runtime.GetNSObject (MonoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_int (this.SuperHandle, selTabContentsAtIndex_Handle, index));
			}
		}
		
		[Export ("allTabContents")]
		[CompilerGenerated]
		public virtual NSArray AllTabContents ()
		{
			if (IsDirectBinding) {
				return (NSArray) Runtime.GetNSObject (MonoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selAllTabContentsHandle));
			} else {
				return (NSArray) Runtime.GetNSObject (MonoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selAllTabContentsHandle));
			}
		}
		
		[Export ("indexOfTabContents:")]
		[CompilerGenerated]
		public virtual int IndexOfTabContents (CTTabContents contents)
		{
			if (contents == null)
				throw new ArgumentNullException ("contents");
			if (IsDirectBinding) {
				return MonoMac.ObjCRuntime.Messaging.int_objc_msgSend_IntPtr (this.Handle, selIndexOfTabContents_Handle, contents.Handle);
			} else {
				return MonoMac.ObjCRuntime.Messaging.int_objc_msgSendSuper_IntPtr (this.SuperHandle, selIndexOfTabContents_Handle, contents.Handle);
			}
		}
		
		[Export ("selectTabContentsAtIndex:userGesture:")]
		[CompilerGenerated]
		public virtual void SelectTabContentsAtIndex (int index, bool userGesture)
		{
			if (IsDirectBinding) {
				MonoMac.ObjCRuntime.Messaging.void_objc_msgSend_int_bool (this.Handle, selSelectTabContentsAtIndexUserGesture_Handle, index, userGesture);
			} else {
				MonoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper_int_bool (this.SuperHandle, selSelectTabContentsAtIndexUserGesture_Handle, index, userGesture);
			}
		}
		
		[Export ("updateTabStateAtIndex:")]
		[CompilerGenerated]
		public virtual void UpdateTabStateAtIndex (int index)
		{
			if (IsDirectBinding) {
				MonoMac.ObjCRuntime.Messaging.void_objc_msgSend_int (this.Handle, selUpdateTabStateAtIndex_Handle, index);
			} else {
				MonoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, selUpdateTabStateAtIndex_Handle, index);
			}
		}
		
		[Export ("updateTabStateForContent:")]
		[CompilerGenerated]
		public virtual void UpdateTabStateForContent (CTTabContents contents)
		{
			if (contents == null)
				throw new ArgumentNullException ("contents");
			if (IsDirectBinding) {
				MonoMac.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selUpdateTabStateForContent_Handle, contents.Handle);
			} else {
				MonoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selUpdateTabStateForContent_Handle, contents.Handle);
			}
		}
		
		[Export ("replaceTabContentsAtIndex:withTabContents:")]
		[CompilerGenerated]
		public virtual void ReplaceTabContentsAtIndex (int index, CTTabContents contents)
		{
			if (contents == null)
				throw new ArgumentNullException ("contents");
			if (IsDirectBinding) {
				MonoMac.ObjCRuntime.Messaging.void_objc_msgSend_int_IntPtr (this.Handle, selReplaceTabContentsAtIndexWithTabContents_Handle, index, contents.Handle);
			} else {
				MonoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper_int_IntPtr (this.SuperHandle, selReplaceTabContentsAtIndexWithTabContents_Handle, index, contents.Handle);
			}
		}
		
		[Export ("closeTabAtIndex:makeHistory:")]
		[CompilerGenerated]
		public virtual void CloseTabAtIndex (int index, bool makeHistory)
		{
			if (IsDirectBinding) {
				MonoMac.ObjCRuntime.Messaging.void_objc_msgSend_int_bool (this.Handle, selCloseTabAtIndexMakeHistory_Handle, index, makeHistory);
			} else {
				MonoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper_int_bool (this.SuperHandle, selCloseTabAtIndexMakeHistory_Handle, index, makeHistory);
			}
		}
		
		[Export ("closeAllTabs")]
		[CompilerGenerated]
		public virtual void CloseAllTabs ()
		{
			if (IsDirectBinding) {
				MonoMac.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selCloseAllTabsHandle);
			} else {
				MonoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selCloseAllTabsHandle);
			}
		}
		
		[Export ("addBlankTabInForeground:")]
		[CompilerGenerated]
		public virtual CTTabContents AddBlankTabInForeground (bool foreground)
		{
			if (IsDirectBinding) {
				return (CTTabContents) Runtime.GetNSObject (MonoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSend_bool (this.Handle, selAddBlankTabInForeground_Handle, foreground));
			} else {
				return (CTTabContents) Runtime.GetNSObject (MonoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_bool (this.SuperHandle, selAddBlankTabInForeground_Handle, foreground));
			}
		}
		
		[Export ("addBlankTabAtIndex:inForeground:")]
		[CompilerGenerated]
		public virtual CTTabContents AddBlankTabAtIndex (int index, bool foreground)
		{
			if (IsDirectBinding) {
				return (CTTabContents) Runtime.GetNSObject (MonoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSend_int_bool (this.Handle, selAddBlankTabAtIndexInForeground_Handle, index, foreground));
			} else {
				return (CTTabContents) Runtime.GetNSObject (MonoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_int_bool (this.SuperHandle, selAddBlankTabAtIndexInForeground_Handle, index, foreground));
			}
		}
		
		[Export ("createNewStripWithContents:")]
		[CompilerGenerated]
		public virtual CTBrowser CreateNewStripWithContents (CTTabContents contents)
		{
			if (contents == null)
				throw new ArgumentNullException ("contents");
			if (IsDirectBinding) {
				return (CTBrowser) Runtime.GetNSObject (MonoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selCreateNewStripWithContents_Handle, contents.Handle));
			} else {
				return (CTBrowser) Runtime.GetNSObject (MonoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, selCreateNewStripWithContents_Handle, contents.Handle));
			}
		}
		
		[Export ("canDuplicateContentsAt:")]
		[CompilerGenerated]
		public virtual bool CanDuplicateContentsAt (int index)
		{
			if (IsDirectBinding) {
				return MonoMac.ObjCRuntime.Messaging.bool_objc_msgSend_int (this.Handle, selCanDuplicateContentsAt_Handle, index);
			} else {
				return MonoMac.ObjCRuntime.Messaging.bool_objc_msgSendSuper_int (this.SuperHandle, selCanDuplicateContentsAt_Handle, index);
			}
		}
		
		[Export ("duplicateContentsAt:")]
		[CompilerGenerated]
		public virtual void DuplicateContentsAt (int index)
		{
			if (IsDirectBinding) {
				MonoMac.ObjCRuntime.Messaging.void_objc_msgSend_int (this.Handle, selDuplicateContentsAt_Handle, index);
			} else {
				MonoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, selDuplicateContentsAt_Handle, index);
			}
		}
		
		[Export ("closeFrameAfterDragSession")]
		[CompilerGenerated]
		public virtual void CloseFrameAfterDragSession ()
		{
			if (IsDirectBinding) {
				MonoMac.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selCloseFrameAfterDragSessionHandle);
			} else {
				MonoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selCloseFrameAfterDragSessionHandle);
			}
		}
		
		[Export ("createHistoricalTab:")]
		[CompilerGenerated]
		public virtual void CreateHistoricalTab (CTTabContents contents)
		{
			if (contents == null)
				throw new ArgumentNullException ("contents");
			if (IsDirectBinding) {
				MonoMac.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selCreateHistoricalTab_Handle, contents.Handle);
			} else {
				MonoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selCreateHistoricalTab_Handle, contents.Handle);
			}
		}
		
		[Export ("runUnloadListenerBeforeClosing:")]
		[CompilerGenerated]
		public virtual bool RunUnloadListenerBeforeClosing (CTTabContents contents)
		{
			if (contents == null)
				throw new ArgumentNullException ("contents");
			if (IsDirectBinding) {
				return MonoMac.ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr (this.Handle, selRunUnloadListenerBeforeClosing_Handle, contents.Handle);
			} else {
				return MonoMac.ObjCRuntime.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, selRunUnloadListenerBeforeClosing_Handle, contents.Handle);
			}
		}
		
		[Export ("canRestoreTab")]
		[CompilerGenerated]
		public virtual bool CanRestoreTab ()
		{
			if (IsDirectBinding) {
				return MonoMac.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selCanRestoreTabHandle);
			} else {
				return MonoMac.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selCanRestoreTabHandle);
			}
		}
		
		[Export ("restoreTab")]
		[CompilerGenerated]
		public virtual void RestoreTab ()
		{
			if (IsDirectBinding) {
				MonoMac.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selRestoreTabHandle);
			} else {
				MonoMac.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selRestoreTabHandle);
			}
		}
		
		[Export ("canCloseContentsAt:")]
		[CompilerGenerated]
		public virtual bool CanCloseContentsAt (int index)
		{
			if (IsDirectBinding) {
				return MonoMac.ObjCRuntime.Messaging.bool_objc_msgSend_int (this.Handle, selCanCloseContentsAt_Handle, index);
			} else {
				return MonoMac.ObjCRuntime.Messaging.bool_objc_msgSendSuper_int (this.SuperHandle, selCanCloseContentsAt_Handle, index);
			}
		}
		
		[Export ("canCloseTab")]
		[CompilerGenerated]
		public virtual bool CanCloseTab ()
		{
			if (IsDirectBinding) {
				return MonoMac.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selCanCloseTabHandle);
			} else {
				return MonoMac.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selCanCloseTabHandle);
			}
		}
		
		[CompilerGenerated]
		object __mt_WindowController_var;
		[CompilerGenerated]
		public virtual CTBrowserWindowController WindowController {
			[Export ("windowController")]
			get {
				CTBrowserWindowController ret;
				if (IsDirectBinding) {
					ret = (CTBrowserWindowController) Runtime.GetNSObject (MonoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selWindowControllerHandle));
				} else {
					ret = (CTBrowserWindowController) Runtime.GetNSObject (MonoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selWindowControllerHandle));
				}
				__mt_WindowController_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_Window_var;
		[CompilerGenerated]
		public virtual global::MonoMac.AppKit.NSWindow Window {
			[Export ("window")]
			get {
				global::MonoMac.AppKit.NSWindow ret;
				if (IsDirectBinding) {
					ret = (global::MonoMac.AppKit.NSWindow) Runtime.GetNSObject (MonoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selWindowHandle));
				} else {
					ret = (global::MonoMac.AppKit.NSWindow) Runtime.GetNSObject (MonoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selWindowHandle));
				}
				__mt_Window_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_WindowController_var = null;
				__mt_Window_var = null;
			}
		}
	} /* class CTBrowser */
}
