﻿//------------------------------------------------------------------------------
// <copyright file="ToolWindow1.cs" company="Company">
//     Copyright (c) Company.  All rights reserved.
// </copyright>
//------------------------------------------------------------------------------

namespace AzureIoTHubConnectedService
{
    using System;
    using System.Runtime.InteropServices;
    using Microsoft.VisualStudio.Shell;
    using Microsoft.VisualStudio.Shell.Interop;

    /// <summary>
    /// This class implements the tool window exposed by this package and hosts a user control.
    /// </summary>
    /// <remarks>
    /// In Visual Studio tool windows are composed of a frame (implemented by the shell) and a pane,
    /// usually implemented by the package implementer.
    /// <para>
    /// This class derives from the ToolWindowPane class provided from the MPF in order to use its
    /// implementation of the IVsUIElementPane interface.
    /// </para>
    /// </remarks>
    [Guid("f61ff8f0-482f-401f-ab0f-8a5133c4a195")]
    public class UtilityWindowHubs : ToolWindowPane
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UtilityWindow"/> class.
        /// </summary>
        public UtilityWindowHubs() : base(null)
        {
            this.Caption = "IoT Hubs";

            // This is the user control hosted by the tool window; Note that, even if this class implements IDisposable,
            // we are not calling Dispose on this object. This is because ToolWindowPane calls Dispose on
            // the object returned by the Content property.
            this.Content = new WizardPageHubSelectionView();
        }
        public override void OnToolWindowCreated()
        {
            IVsWindowFrame windowFrame = (IVsWindowFrame)Frame;

            windowFrame.SetProperty((int)__VSFPROPID.VSFPROPID_FrameMode, VSFRAMEMODE.VSFM_Dock);
            //windowFrame.SetProperty((int)__VSFPROPID.VSFPROPID_IsWindowTabbed, __VSTABBEDMODE.VSTABBEDMODE_SelectedTab);

            //object varFlags;
            //windowFrame.GetProperty((int)__VSFPROPID.VSFPROPID_CreateToolWinFlags, out varFlags);
            //int flags = (int)varFlags | (int)__VSCREATETOOLWIN2.CTW_fDocumentLikeTool;
            //windowFrame.SetProperty((int)__VSFPROPID.VSFPROPID_CreateToolWinFlags, flags);

            base.OnToolWindowCreated();
        }
    }
}
