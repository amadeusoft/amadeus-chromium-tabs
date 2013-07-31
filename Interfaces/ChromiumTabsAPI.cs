using System;
using MonoMac.Foundation;
using MonoMac.AppKit;
using MonoMac.ObjCRuntime;
using System.Drawing;

namespace Amadeus.Chromium.Tabs {	
	
    // No code will be generated for these enumerations,
    // but they are still needed here for the generator
    // to work. These are added to the project's Enums.cs.

	public enum CTBrowserCommand {
	  CTBrowserCommandNewWindow                 = 34000,
	  CTBrowserCommandNewIncognitoWindow        = 34001,
	  CTBrowserCommandCloseWindow               = 34012,
	  CTBrowserCommandAlwaysOnTop               = 34013,
	  CTBrowserCommandNewTab                    = 34014,
	  CTBrowserCommandCloseTab                  = 34015,
	  CTBrowserCommandSelectNextTab             = 34016,
	  CTBrowserCommandSelectPreviousTab         = 34017,
	  CTBrowserCommandSelectTab0                = 34018,
	  CTBrowserCommandSelectTab1                = 34019,
	  CTBrowserCommandSelectTab2                = 34020,
	  CTBrowserCommandSelectTab3                = 34021,
	  CTBrowserCommandSelectTab4                = 34022,
	  CTBrowserCommandSelectTab5                = 34023,
	  CTBrowserCommandSelectTab6                = 34024,
	  CTBrowserCommandSelectTab7                = 34025,
	  CTBrowserCommandSelectLastTab             = 34026,
	  CTBrowserCommandDuplicateTab              = 34027,
	  CTBrowserCommandRestoreTab                = 34028,
	  CTBrowserCommandShowAsTab                 = 34029,
	  CTBrowserCommandFullscreen                = 34030,
	  CTBrowserCommandExit                      = 34031,
	  CTBrowserCommandMoveTabNext               = 34032,
	  CTBrowserCommandMoveTabPrevious           = 34033
	};

	public enum CTWindowOpenDisposition {
	  CTWindowOpenDispositionCurrentTab,
	  CTWindowOpenDispositionNewForegroundTab,
	  CTWindowOpenDispositionNewBackgroundTab,
	};

	[BaseType (typeof (NSObject))]
	interface CTBrowser : CTTabStripModelDelegate {

        [Export ("initWithMode:")]
        IntPtr Constructor (bool offTheRecord);

		[Export ("windowController")]
		CTBrowserWindowController WindowController { get;  }

		[Export ("window")]
		NSWindow Window { get;  }

		[Static]
		[Export ("browser")]
		CTBrowser Browser ();

        [Static]
        [Export ("browserWithMode:")]
        CTBrowser Browser (bool offTheRecord);

		[Export ("createToolbarController")]
		CTToolbarController CreateToolbarController ();

		[Export ("createTabContentsControllerWithContents:")]
		CTTabContentsController CreateTabContentsControllerWithContents (CTTabContents contents);

		[Export ("createBlankTabBasedOn:")]
		CTTabContents CreateBlankTabBasedOn ([NullAllowed]CTTabContents baseContents);

        // The following are already being imported from
        // CTTabStripModelDelegate.

//		[Export ("addBlankTabAtIndex:inForeground:")]
//		CTTabContents AddBlankTabAtIndex (int index, bool foreground);
//
//		[Export ("addBlankTabInForeground:")]
//		CTTabContents AddBlankTabInForeground (bool foreground);

		[Export ("addBlankTab")]
		CTTabContents AddBlankTab ();

		[Export ("addTabContents:atIndex:inForeground:")]
		CTTabContents AddTabContents (CTTabContents contents, int index, bool foreground);

		[Export ("addTabContents:inForeground:")]
		CTTabContents AddTabContents (CTTabContents contents, bool foreground);

		[Export ("addTabContents:")]
		CTTabContents AddTabContents (CTTabContents contents);

        [Export ("isOffTheRecord")]
        bool IsOffTheRecord { get; }

		[Export ("newWindow")]
		void NewWindow ();

		[Export ("closeWindow")]
		void CloseWindow ();

		[Export ("closeTab")]
		void CloseTab ();

		[Export ("selectNextTab")]
		void SelectNextTab ();

		[Export ("selectPreviousTab")]
		void SelectPreviousTab ();

		[Export ("moveTabNext")]
		void MoveTabNext ();

		[Export ("moveTabPrevious")]
		void MoveTabPrevious ();

		[Export ("selectTabAtIndex:")]
		void SelectTabAtIndex (int index);

		[Export ("selectLastTab")]
		void SelectLastTab ();

		[Export ("duplicateTab")]
		void DuplicateTab ();

		[Export ("executeCommand:")]
		void OnExecuteCommand (int cmd);
		
		[Export ("executeCommand:withDisposition:")]
		void OnExecuteCommand (int cmd, CTWindowOpenDisposition disposition);

		[Static]
		[Export ("executeCommand:")]
		void ExecuteCommand (int cmd);

		[Export ("loadingStateDidChange:")]
		void LoadingStateDidChange (CTTabContents contents);

		[Export ("windowDidBeginToClose")]
		void WindowDidBeginToClose ();

		[Export ("tabCount")]
		int TabCount ();

		[Export ("selectedTabIndex")]
		int SelectedTabIndex ();

		[Export ("selectedTabContents")]
		CTTabContents SelectedTabContents ();

		[Export ("tabContentsAtIndex:")]
		CTTabContents TabContentsAtIndex (int index);

		[Export ("allTabContents")]
		NSArray AllTabContents ();

		[Export ("indexOfTabContents:")]
		int IndexOfTabContents (CTTabContents contents);

		[Export ("selectTabContentsAtIndex:userGesture:")]
		void SelectTabContentsAtIndex (int index, bool userGesture);

		[Export ("updateTabStateAtIndex:")]
		void UpdateTabStateAtIndex (int index);

		[Export ("updateTabStateForContent:")]
		void UpdateTabStateForContent (CTTabContents contents);

		[Export ("replaceTabContentsAtIndex:withTabContents:")]
		void ReplaceTabContentsAtIndex (int index, CTTabContents contents);

		[Export ("closeTabAtIndex:makeHistory:")]
		void CloseTabAtIndex (int index, bool makeHistory);

		[Export ("closeAllTabs")]
		void CloseAllTabs ();

	}

	[BaseType (typeof (CTTabWindowController))]
	interface CTBrowserWindowController {
		[Export ("tabStripController")]
		CTTabStripController TabStripController { get;  }

		[Export ("toolbarController")]
		CTToolbarController ToolbarController { get;  }

		[Export ("browser")]
		CTBrowser Browser { get;  }

		[Export ("isFullscreen")]
		bool IsFullscreen { get;  }

		[Export ("hasToolbar")]
		bool HasToolbar { get;  }

		[Static]
		[Export ("mainBrowserWindowController")]
		CTBrowserWindowController MainBrowserWindowController ();

		[Static]
		[Export ("browserWindowControllerForWindow:")]
		CTBrowserWindowController BrowserWindowControllerForWindow (NSWindow window);

		[Static]
		[Export ("browserWindowControllerForView:")]
		CTBrowserWindowController BrowserWindowControllerForView (NSView view);

		[Static]
		[Export ("browserWindowController")]
		CTBrowserWindowController BrowserWindowController ();

		[Export ("initWithWindowNibPath:browser:")]
		IntPtr Constructor (string windowNibPath, CTBrowser browser);

		[Export ("initWithBrowser:")]
		IntPtr Constructor (CTBrowser browser);

		[Export ("themePatternPhase")]
		PointF ThemePatternPhase ();

		[Action ("saveAllDocuments:")]
		void SaveAllDocuments (NSObject sender);

		[Action ("openDocument:")]
		void OpenDocument (NSObject sender);

		[Action ("newDocument:")]
		void NewDocument (NSObject sender);

		[Export ("selectedTabContents")]
		CTTabContents SelectedTabContents ();

		[Export ("selectedTabIndex")]
		int SelectedTabIndex ();

		[Export ("updateToolbarWithContents:shouldRestoreState:")]
		void UpdateToolbarWithContents (CTTabContents tab, bool shouldRestore);

		[Export ("activate")]
		void Activate ();

		[Export ("focusTabContents")]
		void FocusTabContents ();

		[Export ("layoutTabContentArea:")]
		void LayoutTabContentArea (RectangleF frame);

	}

	[BaseType (typeof (NSDocument))]
	interface CTTabContents {
		[Export ("isApp")]
		bool IsApp { get; set;  }

		[Export ("isLoading")]
		bool IsLoading { get; set;  }

		[Export ("isCrashed")]
		bool IsCrashed { get; set;  }

		[Export ("isWaitingForResponse")]
		bool IsWaitingForResponse { get; set;  }

		[Export ("isVisible")]
		bool IsVisible { get; set;  }

		[Export ("isSelected")]
		bool IsSelected { get; set;  }

		[Export ("isTeared")]
		bool IsTeared { get; set;  }

		[Export ("delegate")]
		NSObject Delegate { get; [NullAllowed]set;  }

		[Export ("view")]
		NSView View { get; [NullAllowed]set;  }

		[Export ("title")]
		string Title { get; [NullAllowed]set;  }

		[Export ("icon")]
		NSImage Icon { get; [NullAllowed]set;  }

		[Export ("browser")]
		CTBrowser Browser { get; set;  }

		[Export ("parentOpener")]
		CTTabContents ParentOpener { get; set;  }

		[Export ("hasIcon")]
		bool HasIcon { get;  }

		[Export ("initWithBaseTabContents:")]
		IntPtr Constructor ([NullAllowed]CTTabContents baseContents);

		[Export ("destroy:")]
		void Destroy (NSObject sender);

		[Export ("makeKeyAndOrderFront:")]
		void MakeKeyAndOrderFront (NSObject sender);

		[Export ("becomeFirstResponder")]
		bool BecomeFirstResponder ();

		[Export ("closingOfTabDidStart:")]
		void ClosingOfTabDidStart ([NullAllowed]NSObject model);

		[Export ("tabDidInsertIntoBrowser:atIndex:inForeground:")]
		void TabDidInsertIntoBrowser (CTBrowser browser, int index, bool foreground);

		[Export ("tabReplaced:inBrowser:atIndex:")]
		void TabReplacedinBrowser (CTTabContents oldContents, CTBrowser browser, int index);

		[Export ("tabWillCloseInBrowser:atIndex:")]
		void TabWillCloseInBrowser (CTBrowser browser, int index);

		[Export ("tabDidDetachFromBrowser:atIndex:")]
		void TabDidDetachFromBrowser (CTBrowser browser, int index);

		[Export ("tabDidBecomeVisible")]
		void TabDidBecomeVisible ();

		[Export ("tabDidResignVisible")]
		void TabDidResignVisible ();

		[Export ("tabWillBecomeSelected")]
		void TabWillBecomeSelected ();

		[Export ("tabWillResignSelected")]
		void TabWillResignSelected ();

		[Export ("tabDidBecomeSelected")]
		void TabDidBecomeSelected ();

		[Export ("tabDidResignSelected")]
		void TabDidResignSelected ();

		[Export ("tabWillBecomeTeared")]
		void TabWillBecomeTeared ();

		[Export ("tabWillResignTeared")]
		void TabWillResignTeared ();

		[Export ("tabDidResignTeared")]
		void TabDidResignTeared ();

		[Export ("viewFrameDidChange:")]
		void ViewFrameDidChange (RectangleF newFrame);

	}

	[BaseType (typeof (NSObject))]
	[Model]
	interface TabContentsDelegate {
		[Abstract]
		[Export ("reload")]
		bool Reload ();

	}

	[BaseType (typeof (NSViewController))]
	interface CTTabContentsController {
		[Export ("initWithNibName:bundle:contents:")]
		IntPtr Constructor (string name, NSBundle bundle, CTTabContents contents);

		[Export ("initWithContents:")]
		IntPtr Constructor (CTTabContents contents);

		[Export ("isCurrentTab")]
		bool IsCurrentTab ();

		[Export ("willResignSelectedTab")]
		void WillResignSelectedTab ();

		[Export ("willBecomeSelectedTab")]
		void WillBecomeSelectedTab ();

		[Export ("ensureContentsVisible")]
		void EnsureContentsVisible ();

		[Export ("tabDidChange:")]
		void TabDidChange (CTTabContents updatedContents);

	}

	[BaseType (typeof (NSViewController))]
	interface CTTabController {
		[Export ("loadingState")]
		int LoadingState { get; set;  }

		[Export ("action")]
		Selector Action { get; set;  }

		[Export ("app")]
		bool App { get; set;  }

		[Export ("mini")]
		bool Mini { get; set;  }

		[Export ("phantom")]
		bool Phantom { get; set;  }

		[Export ("pinned")]
		bool Pinned { get; set;  }

		[Export ("selected")]
		bool Selected { get; set;  }

		[Export ("target")]
		NSObject Target { get; set;  }

		[Static]
		[Export ("minTabWidth")]
		float MinTabWidth ();

		[Static]
		[Export ("maxTabWidth")]
		float MaxTabWidth ();

		[Static]
		[Export ("minSelectedTabWidth")]
		float MinSelectedTabWidth ();

		[Static]
		[Export ("miniTabWidth")]
		float MiniTabWidth ();

		[Static]
		[Export ("appTabWidth")]
		float AppTabWidth ();

		[Export ("initWithNibName:bundle:")]
		IntPtr Constructor (string nibName, NSBundle bundle);

		[Export ("tabView")]
		CTTabView TabView ();

		[Action ("closeTab:")]
		void CloseTab (NSObject sender);

		[Export ("inRapidClosureMode")]
		bool InRapidClosureMode ();

		[Export ("updateVisibility")]
		void UpdateVisibility ();

		[Export ("updateTitleColor")]
		void UpdateTitleColor ();

		//Detected properties
		[Export ("iconView")]
		NSView IconView { get; set; }

	}
	
	[BaseType (typeof (NSObject))]
	[Model]
	interface CTTabControllerTarget {
		[Abstract]
		[Export ("closeTab:")]
		void CloseTab (NSObject sender);

	}
	
	[BaseType (typeof (NSObject))]
	interface CTTabStripController {
		[Export ("showsNewTabButton")]
		bool ShowsNewTabButton { get; set;  }

		[Export ("initWithView:switchView:browser:")]
		IntPtr Constructor (CTTabStripView view, NSView switchView, CTBrowser browser);

		[Export ("selectedTabView")]
		NSView SelectedTabView ();

		[Export ("setFrameOfSelectedTab:")]
		void SetFrameOfSelectedTab (RectangleF frame);

		[Export ("moveTabFromIndex:")]
		void MoveTabFromIndex (int from);

		[Export ("dropTabContents:withFrame:asPinnedTab:")]
		void DropTabContents (CTTabContents contents, RectangleF frame, bool pinned);

		[Export ("modelIndexForTabView:")]
		int ModelIndexForTabView (NSView view);

		[Export ("viewAtIndex:")]
		NSView ViewAtIndex (uint index);

		[Export ("viewsCount")]
		uint ViewsCount ();

		[Export ("insertPlaceholderForTab:frame:yStretchiness:")]
		void InsertPlaceholderForTab (CTTabView tab, RectangleF frame, float yStretchiness);

		[Export ("isTabFullyVisible:")]
		bool IsTabFullyVisible (CTTabView tab);

		[Export ("layoutTabs")]
		void LayoutTabs ();

		[Export ("inRapidClosureMode")]
		bool InRapidClosureMode ();

		[Export ("tabDraggingAllowed")]
		bool TabDraggingAllowed ();

		[Static]
		[Export ("defaultTabHeight")]
		float DefaultTabHeight ();

		[Static]
		[Export ("defaultIndentForControls")]
		float DefaultIndentForControls ();

		[Export ("sheetController")]
		NSObject SheetController ();

		[Export ("destroySheetController")]
		void DestroySheetController ();

		[Export ("activeTabContentsController")]
		CTTabContentsController ActiveTabContentsController ();

	}

	[BaseType (typeof (NSObject))]
	[Model]
	interface CTTabStripModelDelegate {
		[Abstract]
		[Export ("addBlankTabInForeground:")]
		CTTabContents AddBlankTabInForeground (bool foreground);

		[Abstract]
		[Export ("addBlankTabAtIndex:inForeground:")]
		CTTabContents AddBlankTabAtIndex (int index, bool foreground);

		[Abstract]
		[Export ("createNewStripWithContents:")]
		CTBrowser CreateNewStripWithContents (CTTabContents contents);

		[Abstract]
		[Export ("canDuplicateContentsAt:")]
		bool CanDuplicateContentsAt (int index);

		[Abstract]
		[Export ("duplicateContentsAt:")]
		void DuplicateContentsAt (int index);

		[Abstract]
		[Export ("closeFrameAfterDragSession")]
		void CloseFrameAfterDragSession ();

		[Abstract]
		[Export ("createHistoricalTab:")]
		void CreateHistoricalTab (CTTabContents contents);

		[Abstract]
		[Export ("runUnloadListenerBeforeClosing:")]
		bool RunUnloadListenerBeforeClosing (CTTabContents contents);

		[Abstract]
		[Export ("canRestoreTab")]
		bool CanRestoreTab ();

		[Abstract]
		[Export ("restoreTab")]
		void RestoreTab ();

		[Abstract]
		[Export ("canCloseContentsAt:")]
		bool CanCloseContentsAt (int index);

		[Abstract]
		[Export ("canCloseTab")]
		bool CanCloseTab ();
	}

	[BaseType (typeof (NSView))]
	interface CTTabStripView {
		[Outlet ("NewTabButton")]
		NSObject NewTabButton { get; set;  }

		[Export ("dropArrowShown")]
		bool DropArrowShown { get; set;  }

		[Export ("dropArrowPosition")]
		PointF DropArrowPosition { get; set;  }

	}	

	[BaseType (typeof (NSView))]
	interface CTTabView {
		[Export ("state")]
		NSCellStateValue State { get; set;  }

		[Export ("hoverAlpha")]
		float HoverAlpha { get; set;  }

		[Export ("alertAlpha")]
		float AlertAlpha { get; set;  }

		[Export ("closing")]
		bool Closing { [Bind ("isClosing")] get; set;  }

		[Export ("setTrackingEnabled:")]
		void SetTrackingEnabled (bool enabled);

		[Export ("startAlert")]
		void StartAlert ();

		[Export ("cancelAlert")]
		void CancelAlert ();

	}

	[BaseType (typeof (NSWindowController))]
	interface CTTabWindowController {

		[Export ("didShowNewTabButtonBeforeTemporalAction")]
		bool DidShowNewTabButtonBeforeTemporalAction { get; set;  }

		[Export ("showsNewTabButton")]
		bool ShowsNewTabButton { get; set;  }

		[Export ("showOverlay")]
		void ShowOverlay ();

		[Export ("removeOverlay")]
		void RemoveOverlay ();

		[Export ("overlayWindow")]
		NSWindow OverlayWindow ();

		[Export ("shouldConstrainFrameRect")]
		bool ShouldConstrainFrameRect ();

		[Export ("layoutTabs")]
		void LayoutTabs ();

		[Export ("detachTabToNewWindow:")]
		CTTabWindowController DetachTabToNewWindow (CTTabView tabView);

		[Export ("insertPlaceholderForTab:frame:yStretchiness:")]
		void InsertPlaceholderForTab (CTTabView tab, RectangleF frame, float yStretchiness);

		[Export ("removePlaceholder")]
		void RemovePlaceholder ();

		[Export ("tabDraggingAllowed")]
		bool TabDraggingAllowed ();

		[Export ("tabTearingAllowed")]
		bool TabTearingAllowed ();

		[Export ("windowMovementAllowed")]
		bool WindowMovementAllowed ();

		[Export ("willStartTearingTab")]
		void WillStartTearingTab ();

		[Export ("willEndTearingTab")]
		void WillEndTearingTab ();

		[Export ("didEndTearingTab")]
		void DidEndTearingTab ();

		[Export ("isTabFullyVisible:")]
		bool IsTabFullyVisible (CTTabView tab);

		[Export ("canReceiveFrom:")]
		bool CanReceiveFrom (CTTabWindowController source);

		[Export ("moveTabView:fromController:")]
		void MoveTabView (NSView view, CTTabWindowController controller);

		[Export ("numberOfTabs")]
		int NumberOfTabs ();

		[Export ("hasLiveTabs")]
		bool HasLiveTabs ();

		[Export ("selectedTabView")]
		NSView SelectedTabView ();

		[Export ("selectedTabTitle")]
		string SelectedTabTitle ();

		[Export ("hasTabStrip")]
		bool HasTabStrip ();

		[Export ("useVerticalTabs")]
		bool UseVerticalTabs ();

		[Export ("isTabDraggable:")]
		bool IsTabDraggable (NSView tabView);

		[Export ("setTab:isDraggable:")]
		void SetTab (NSView tabView, bool draggable);

		[Export ("deferPerformClose")]
		void DeferPerformClose ();

	}

	[BaseType (typeof (NSViewController))]
	interface CTToolbarController {
		[Export ("initWithNibName:bundle:browser:")]
		IntPtr Constructor (string nibName, NSBundle bundle, CTBrowser browser);

		[Export ("setDividerOpacity:")]
		void SetDividerOpacity (float opacity);

		[Export ("updateToolbarWithContents:shouldRestoreState:")]
		void UpdateToolbarWithContents ([NullAllowed]CTTabContents contents, bool shouldRestore);

		[Export ("customFieldEditorForObject:")]
		NSObject CustomFieldEditorForObject (NSObject obj);

	}

	[BaseType (typeof (NSView))]
	interface CTToolbarView {
		[Export ("dividerOpacity")]
		float DividerOpacity { get; set;  }

	}

	[BaseType (typeof (NSObject))]
	interface CTUtil {
		[Static]
		[Export ("bundleForResource:ofType:")]
		NSBundle BundleForResource (string name, string ext);

		[Static]
		[Export ("bundleForResource:")]
		NSBundle BundleForResource (string name);

		[Static]
		[Export ("pathForResource:ofType:")]
		string PathForResource (string name, string ext);

	}
	
}
