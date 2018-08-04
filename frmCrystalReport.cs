using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports.Engine;
using Basic.Function;

namespace GGM3000.SYSForm
{
	/// <summary>
	/// Summary description for frmAccReport.
	/// </summary>
	public class frmCrystalReport : System.Windows.Forms.Form
	{
		public DataSet ds;
		public string fileReport, nameReport;
		private C1.Win.C1PrintPreview.C1PrintPreview c1PrintPreview1;
		private C1.Win.C1PrintPreview.PreviewToolBarButton c1pBtnFileOpen1;
		private C1.Win.C1PrintPreview.PreviewToolBarButton c1pBtnFileSave1;
		private C1.Win.C1PrintPreview.PreviewToolBarButton c1pBtnFilePrint1;
		private C1.Win.C1PrintPreview.PreviewToolBarButton c1pBtnPageSetup1;
		private C1.Win.C1PrintPreview.PreviewToolBarButton c1pBtnReflow1;
		private C1.Win.C1PrintPreview.PreviewToolBarButton c1pBtnStop1;
		private C1.Win.C1PrintPreview.PreviewToolBarButton c1pBtnDocInfo1;
		private C1.Win.C1PrintPreview.PreviewToolBarButton c1pBtnSeparator1;
		private C1.Win.C1PrintPreview.PreviewToolBarButton c1pBtnShowNavigationBar1;
		private C1.Win.C1PrintPreview.PreviewToolBarButton c1pBtnSeparator2;
		private C1.Win.C1PrintPreview.PreviewToolBarButton c1pBtnMouseHand1;
		private C1.Win.C1PrintPreview.PreviewToolBarButton c1pBtnMouseZoom1;
		private C1.Win.C1PrintPreview.PreviewToolBarButton c1pBtnMouseZoomOut1;
		private C1.Win.C1PrintPreview.PreviewToolBarButton c1pBtnMouseSelect1;
		private C1.Win.C1PrintPreview.PreviewToolBarButton c1pBtnFindText1;
		private C1.Win.C1PrintPreview.PreviewToolBarButton c1pBtnSeparator3;
		private C1.Win.C1PrintPreview.PreviewToolBarButton c1pBtnGoFirst1;
		private C1.Win.C1PrintPreview.PreviewToolBarButton c1pBtnGoPrev1;
		private C1.Win.C1PrintPreview.PreviewToolBarButton c1pBtnGoNext1;
		private C1.Win.C1PrintPreview.PreviewToolBarButton c1pBtnGoLast1;
		private C1.Win.C1PrintPreview.PreviewToolBarButton c1pBtnSeparator4;
		private C1.Win.C1PrintPreview.PreviewToolBarButton c1pBtnHistoryPrev1;
		private C1.Win.C1PrintPreview.PreviewToolBarButton c1pBtnHistoryNext1;
		private C1.Win.C1PrintPreview.PreviewToolBarButton c1pBtnSeparator5;
		private C1.Win.C1PrintPreview.PreviewToolBarButton c1pBtnZoomOut1;
		private C1.Win.C1PrintPreview.PreviewToolBarButton c1pBtnZoomIn1;
		private C1.Win.C1PrintPreview.PreviewToolBarButton c1pBtnSeparator6;
		private C1.Win.C1PrintPreview.PreviewToolBarButton c1pBtnViewActualSize1;
		private C1.Win.C1PrintPreview.PreviewToolBarButton c1pBtnViewFullPage1;
		private C1.Win.C1PrintPreview.PreviewToolBarButton c1pBtnViewPageWidth1;
		private C1.Win.C1PrintPreview.PreviewToolBarButton c1pBtnViewTwoPages1;
		private C1.Win.C1PrintPreview.PreviewToolBarButton c1pBtnViewFourPages1;
		private C1.Win.C1PrintPreview.PreviewToolBarButton c1pBtnSeparator7;
		private C1.Win.C1PrintPreview.PreviewToolBarButton c1pBtnHelp1;
		private C1.Win.C1Report.C1Report c1Report1;
		
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmCrystalReport(DataSet ds, string fileReport, string nameReport)
		{
			this.ds=ds;
			this.fileReport=fileReport;
			this.nameReport=nameReport;
			InitializeComponent();
		}
		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.c1PrintPreview1 = new C1.Win.C1PrintPreview.C1PrintPreview();
			this.c1pBtnFileOpen1 = new C1.Win.C1PrintPreview.PreviewToolBarButton();
			this.c1pBtnFileSave1 = new C1.Win.C1PrintPreview.PreviewToolBarButton();
			this.c1pBtnFilePrint1 = new C1.Win.C1PrintPreview.PreviewToolBarButton();
			this.c1pBtnPageSetup1 = new C1.Win.C1PrintPreview.PreviewToolBarButton();
			this.c1pBtnReflow1 = new C1.Win.C1PrintPreview.PreviewToolBarButton();
			this.c1pBtnStop1 = new C1.Win.C1PrintPreview.PreviewToolBarButton();
			this.c1pBtnDocInfo1 = new C1.Win.C1PrintPreview.PreviewToolBarButton();
			this.c1pBtnSeparator1 = new C1.Win.C1PrintPreview.PreviewToolBarButton();
			this.c1pBtnShowNavigationBar1 = new C1.Win.C1PrintPreview.PreviewToolBarButton();
			this.c1pBtnSeparator2 = new C1.Win.C1PrintPreview.PreviewToolBarButton();
			this.c1pBtnMouseHand1 = new C1.Win.C1PrintPreview.PreviewToolBarButton();
			this.c1pBtnMouseZoom1 = new C1.Win.C1PrintPreview.PreviewToolBarButton();
			this.c1pBtnMouseZoomOut1 = new C1.Win.C1PrintPreview.PreviewToolBarButton();
			this.c1pBtnMouseSelect1 = new C1.Win.C1PrintPreview.PreviewToolBarButton();
			this.c1pBtnFindText1 = new C1.Win.C1PrintPreview.PreviewToolBarButton();
			this.c1pBtnSeparator3 = new C1.Win.C1PrintPreview.PreviewToolBarButton();
			this.c1pBtnGoFirst1 = new C1.Win.C1PrintPreview.PreviewToolBarButton();
			this.c1pBtnGoPrev1 = new C1.Win.C1PrintPreview.PreviewToolBarButton();
			this.c1pBtnGoNext1 = new C1.Win.C1PrintPreview.PreviewToolBarButton();
			this.c1pBtnGoLast1 = new C1.Win.C1PrintPreview.PreviewToolBarButton();
			this.c1pBtnSeparator4 = new C1.Win.C1PrintPreview.PreviewToolBarButton();
			this.c1pBtnHistoryPrev1 = new C1.Win.C1PrintPreview.PreviewToolBarButton();
			this.c1pBtnHistoryNext1 = new C1.Win.C1PrintPreview.PreviewToolBarButton();
			this.c1pBtnSeparator5 = new C1.Win.C1PrintPreview.PreviewToolBarButton();
			this.c1pBtnZoomOut1 = new C1.Win.C1PrintPreview.PreviewToolBarButton();
			this.c1pBtnZoomIn1 = new C1.Win.C1PrintPreview.PreviewToolBarButton();
			this.c1pBtnSeparator6 = new C1.Win.C1PrintPreview.PreviewToolBarButton();
			this.c1pBtnViewActualSize1 = new C1.Win.C1PrintPreview.PreviewToolBarButton();
			this.c1pBtnViewFullPage1 = new C1.Win.C1PrintPreview.PreviewToolBarButton();
			this.c1pBtnViewPageWidth1 = new C1.Win.C1PrintPreview.PreviewToolBarButton();
			this.c1pBtnViewTwoPages1 = new C1.Win.C1PrintPreview.PreviewToolBarButton();
			this.c1pBtnViewFourPages1 = new C1.Win.C1PrintPreview.PreviewToolBarButton();
			this.c1pBtnSeparator7 = new C1.Win.C1PrintPreview.PreviewToolBarButton();
			this.c1pBtnHelp1 = new C1.Win.C1PrintPreview.PreviewToolBarButton();
			this.c1Report1 = new C1.Win.C1Report.C1Report();
			((System.ComponentModel.ISupportInitialize)(this.c1PrintPreview1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.c1Report1)).BeginInit();
			this.SuspendLayout();
			// 
			// c1PrintPreview1
			// 
			this.c1PrintPreview1.C1DPageSettings = "color:False;landscape:False;margins:100,100,100,100;papersize:720,2970,YwB1AHMAdA" +
				"BvAG0A";
			this.c1PrintPreview1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.c1PrintPreview1.Location = new System.Drawing.Point(0, 0);
			this.c1PrintPreview1.Name = "c1PrintPreview1";
			this.c1PrintPreview1.NavigationBar.Cursor = System.Windows.Forms.Cursors.Default;
			this.c1PrintPreview1.NavigationBar.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.c1PrintPreview1.NavigationBar.OutlineView.Cursor = System.Windows.Forms.Cursors.Default;
			this.c1PrintPreview1.NavigationBar.OutlineView.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.c1PrintPreview1.NavigationBar.OutlineView.Indent = 19;
			this.c1PrintPreview1.NavigationBar.OutlineView.ItemHeight = 19;
			this.c1PrintPreview1.NavigationBar.OutlineView.TabIndex = 0;
			this.c1PrintPreview1.NavigationBar.OutlineView.Visible = false;
			this.c1PrintPreview1.NavigationBar.Padding = new System.Drawing.Point(6, 3);
			this.c1PrintPreview1.NavigationBar.TabIndex = 2;
			this.c1PrintPreview1.NavigationBar.ThumbnailsView.AutoArrange = true;
			this.c1PrintPreview1.NavigationBar.ThumbnailsView.Cursor = System.Windows.Forms.Cursors.Default;
			this.c1PrintPreview1.NavigationBar.ThumbnailsView.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.c1PrintPreview1.NavigationBar.ThumbnailsView.TabIndex = 0;
			this.c1PrintPreview1.NavigationBar.ThumbnailsView.Visible = true;
			this.c1PrintPreview1.NavigationBar.Width = 160;
			this.c1PrintPreview1.Size = new System.Drawing.Size(696, 554);
			this.c1PrintPreview1.Splitter.Cursor = System.Windows.Forms.Cursors.VSplit;
			this.c1PrintPreview1.Splitter.Width = 3;
			this.c1PrintPreview1.StatusBar.Cursor = System.Windows.Forms.Cursors.Default;
			this.c1PrintPreview1.StatusBar.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.c1PrintPreview1.StatusBar.TabIndex = 4;
			this.c1PrintPreview1.TabIndex = 0;
			this.c1PrintPreview1.ToolBar.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
																									   this.c1pBtnFileOpen1,
																									   this.c1pBtnFileSave1,
																									   this.c1pBtnFilePrint1,
																									   this.c1pBtnPageSetup1,
																									   this.c1pBtnReflow1,
																									   this.c1pBtnStop1,
																									   this.c1pBtnDocInfo1,
																									   this.c1pBtnSeparator1,
																									   this.c1pBtnShowNavigationBar1,
																									   this.c1pBtnSeparator2,
																									   this.c1pBtnMouseHand1,
																									   this.c1pBtnMouseZoom1,
																									   this.c1pBtnMouseZoomOut1,
																									   this.c1pBtnMouseSelect1,
																									   this.c1pBtnFindText1,
																									   this.c1pBtnSeparator3,
																									   this.c1pBtnGoFirst1,
																									   this.c1pBtnGoPrev1,
																									   this.c1pBtnGoNext1,
																									   this.c1pBtnGoLast1,
																									   this.c1pBtnSeparator4,
																									   this.c1pBtnHistoryPrev1,
																									   this.c1pBtnHistoryNext1,
																									   this.c1pBtnSeparator5,
																									   this.c1pBtnZoomOut1,
																									   this.c1pBtnZoomIn1,
																									   this.c1pBtnSeparator6,
																									   this.c1pBtnViewActualSize1,
																									   this.c1pBtnViewFullPage1,
																									   this.c1pBtnViewPageWidth1,
																									   this.c1pBtnViewTwoPages1,
																									   this.c1pBtnViewFourPages1,
																									   this.c1pBtnSeparator7,
																									   this.c1pBtnHelp1});
			this.c1PrintPreview1.ToolBar.Cursor = System.Windows.Forms.Cursors.Default;
			this.c1PrintPreview1.ToolBar.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			// 
			// c1pBtnFileOpen1
			// 
			this.c1pBtnFileOpen1.Action = C1.Win.C1PrintPreview.ToolBarButtonActionEnum.Custom;
			this.c1pBtnFileOpen1.ImageIndex = 0;
			this.c1pBtnFileOpen1.ToolTipText = "File Open";
			// 
			// c1pBtnFileSave1
			// 
			this.c1pBtnFileSave1.Action = C1.Win.C1PrintPreview.ToolBarButtonActionEnum.Custom;
			this.c1pBtnFileSave1.ImageIndex = 1;
			this.c1pBtnFileSave1.ToolTipText = "File Save";
			// 
			// c1pBtnFilePrint1
			// 
			this.c1pBtnFilePrint1.Action = C1.Win.C1PrintPreview.ToolBarButtonActionEnum.Custom;
			this.c1pBtnFilePrint1.ImageIndex = 2;
			this.c1pBtnFilePrint1.ToolTipText = "Print";
			// 
			// c1pBtnPageSetup1
			// 
			this.c1pBtnPageSetup1.Action = C1.Win.C1PrintPreview.ToolBarButtonActionEnum.Custom;
			this.c1pBtnPageSetup1.ImageIndex = 3;
			this.c1pBtnPageSetup1.ToolTipText = "Page Setup";
			// 
			// c1pBtnReflow1
			// 
			this.c1pBtnReflow1.Action = C1.Win.C1PrintPreview.ToolBarButtonActionEnum.Custom;
			this.c1pBtnReflow1.ImageIndex = 4;
			this.c1pBtnReflow1.ToolTipText = "Reflow";
			// 
			// c1pBtnStop1
			// 
			this.c1pBtnStop1.Action = C1.Win.C1PrintPreview.ToolBarButtonActionEnum.Custom;
			this.c1pBtnStop1.ImageIndex = 5;
			this.c1pBtnStop1.ToolTipText = "Stop";
			this.c1pBtnStop1.Visible = false;
			// 
			// c1pBtnDocInfo1
			// 
			this.c1pBtnDocInfo1.Action = C1.Win.C1PrintPreview.ToolBarButtonActionEnum.Custom;
			this.c1pBtnDocInfo1.Enabled = false;
			this.c1pBtnDocInfo1.ImageIndex = 26;
			this.c1pBtnDocInfo1.ToolTipText = "Document information";
			// 
			// c1pBtnSeparator1
			// 
			this.c1pBtnSeparator1.Action = C1.Win.C1PrintPreview.ToolBarButtonActionEnum.Custom;
			this.c1pBtnSeparator1.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// c1pBtnShowNavigationBar1
			// 
			this.c1pBtnShowNavigationBar1.Action = C1.Win.C1PrintPreview.ToolBarButtonActionEnum.Custom;
			this.c1pBtnShowNavigationBar1.ImageIndex = 6;
			this.c1pBtnShowNavigationBar1.Pushed = true;
			this.c1pBtnShowNavigationBar1.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton;
			this.c1pBtnShowNavigationBar1.ToolTipText = "Show Navigation Bar";
			// 
			// c1pBtnSeparator2
			// 
			this.c1pBtnSeparator2.Action = C1.Win.C1PrintPreview.ToolBarButtonActionEnum.Custom;
			this.c1pBtnSeparator2.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// c1pBtnMouseHand1
			// 
			this.c1pBtnMouseHand1.Action = C1.Win.C1PrintPreview.ToolBarButtonActionEnum.Custom;
			this.c1pBtnMouseHand1.ImageIndex = 7;
			this.c1pBtnMouseHand1.Pushed = true;
			this.c1pBtnMouseHand1.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton;
			this.c1pBtnMouseHand1.ToolTipText = "Hand Tool";
			// 
			// c1pBtnMouseZoom1
			// 
			this.c1pBtnMouseZoom1.Action = C1.Win.C1PrintPreview.ToolBarButtonActionEnum.Custom;
			this.c1pBtnMouseZoom1.ImageIndex = 8;
			this.c1pBtnMouseZoom1.Style = System.Windows.Forms.ToolBarButtonStyle.DropDownButton;
			this.c1pBtnMouseZoom1.ToolTipText = "Zoom In Tool";
			// 
			// c1pBtnMouseZoomOut1
			// 
			this.c1pBtnMouseZoomOut1.Action = C1.Win.C1PrintPreview.ToolBarButtonActionEnum.Custom;
			this.c1pBtnMouseZoomOut1.ImageIndex = 25;
			this.c1pBtnMouseZoomOut1.Style = System.Windows.Forms.ToolBarButtonStyle.DropDownButton;
			this.c1pBtnMouseZoomOut1.ToolTipText = "Zoom Out Tool";
			this.c1pBtnMouseZoomOut1.Visible = false;
			// 
			// c1pBtnMouseSelect1
			// 
			this.c1pBtnMouseSelect1.Action = C1.Win.C1PrintPreview.ToolBarButtonActionEnum.Custom;
			this.c1pBtnMouseSelect1.ImageIndex = 9;
			this.c1pBtnMouseSelect1.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton;
			this.c1pBtnMouseSelect1.ToolTipText = "Select Text";
			// 
			// c1pBtnFindText1
			// 
			this.c1pBtnFindText1.Action = C1.Win.C1PrintPreview.ToolBarButtonActionEnum.Custom;
			this.c1pBtnFindText1.ImageIndex = 10;
			this.c1pBtnFindText1.ToolTipText = "Find Text";
			// 
			// c1pBtnSeparator3
			// 
			this.c1pBtnSeparator3.Action = C1.Win.C1PrintPreview.ToolBarButtonActionEnum.Custom;
			this.c1pBtnSeparator3.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// c1pBtnGoFirst1
			// 
			this.c1pBtnGoFirst1.Action = C1.Win.C1PrintPreview.ToolBarButtonActionEnum.Custom;
			this.c1pBtnGoFirst1.Enabled = false;
			this.c1pBtnGoFirst1.ImageIndex = 11;
			this.c1pBtnGoFirst1.ToolTipText = "First Page";
			// 
			// c1pBtnGoPrev1
			// 
			this.c1pBtnGoPrev1.Action = C1.Win.C1PrintPreview.ToolBarButtonActionEnum.Custom;
			this.c1pBtnGoPrev1.Enabled = false;
			this.c1pBtnGoPrev1.ImageIndex = 12;
			this.c1pBtnGoPrev1.ToolTipText = "Previous Page";
			// 
			// c1pBtnGoNext1
			// 
			this.c1pBtnGoNext1.Action = C1.Win.C1PrintPreview.ToolBarButtonActionEnum.Custom;
			this.c1pBtnGoNext1.ImageIndex = 13;
			this.c1pBtnGoNext1.ToolTipText = "Next Page";
			// 
			// c1pBtnGoLast1
			// 
			this.c1pBtnGoLast1.Action = C1.Win.C1PrintPreview.ToolBarButtonActionEnum.Custom;
			this.c1pBtnGoLast1.ImageIndex = 14;
			this.c1pBtnGoLast1.ToolTipText = "Last Page";
			// 
			// c1pBtnSeparator4
			// 
			this.c1pBtnSeparator4.Action = C1.Win.C1PrintPreview.ToolBarButtonActionEnum.Custom;
			this.c1pBtnSeparator4.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// c1pBtnHistoryPrev1
			// 
			this.c1pBtnHistoryPrev1.Action = C1.Win.C1PrintPreview.ToolBarButtonActionEnum.Custom;
			this.c1pBtnHistoryPrev1.Enabled = false;
			this.c1pBtnHistoryPrev1.ImageIndex = 15;
			this.c1pBtnHistoryPrev1.Style = System.Windows.Forms.ToolBarButtonStyle.DropDownButton;
			this.c1pBtnHistoryPrev1.ToolTipText = "Previous View";
			// 
			// c1pBtnHistoryNext1
			// 
			this.c1pBtnHistoryNext1.Action = C1.Win.C1PrintPreview.ToolBarButtonActionEnum.Custom;
			this.c1pBtnHistoryNext1.Enabled = false;
			this.c1pBtnHistoryNext1.ImageIndex = 16;
			this.c1pBtnHistoryNext1.Style = System.Windows.Forms.ToolBarButtonStyle.DropDownButton;
			this.c1pBtnHistoryNext1.ToolTipText = "Next View";
			// 
			// c1pBtnSeparator5
			// 
			this.c1pBtnSeparator5.Action = C1.Win.C1PrintPreview.ToolBarButtonActionEnum.Custom;
			this.c1pBtnSeparator5.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			this.c1pBtnSeparator5.Visible = false;
			// 
			// c1pBtnZoomOut1
			// 
			this.c1pBtnZoomOut1.Action = C1.Win.C1PrintPreview.ToolBarButtonActionEnum.Custom;
			this.c1pBtnZoomOut1.ImageIndex = 17;
			this.c1pBtnZoomOut1.ToolTipText = "Zoom Out";
			this.c1pBtnZoomOut1.Visible = false;
			// 
			// c1pBtnZoomIn1
			// 
			this.c1pBtnZoomIn1.Action = C1.Win.C1PrintPreview.ToolBarButtonActionEnum.Custom;
			this.c1pBtnZoomIn1.ImageIndex = 18;
			this.c1pBtnZoomIn1.ToolTipText = "Zoom In";
			this.c1pBtnZoomIn1.Visible = false;
			// 
			// c1pBtnSeparator6
			// 
			this.c1pBtnSeparator6.Action = C1.Win.C1PrintPreview.ToolBarButtonActionEnum.Custom;
			this.c1pBtnSeparator6.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			this.c1pBtnSeparator6.Visible = false;
			// 
			// c1pBtnViewActualSize1
			// 
			this.c1pBtnViewActualSize1.Action = C1.Win.C1PrintPreview.ToolBarButtonActionEnum.Custom;
			this.c1pBtnViewActualSize1.ImageIndex = 19;
			this.c1pBtnViewActualSize1.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton;
			this.c1pBtnViewActualSize1.ToolTipText = "Actual Size";
			// 
			// c1pBtnViewFullPage1
			// 
			this.c1pBtnViewFullPage1.Action = C1.Win.C1PrintPreview.ToolBarButtonActionEnum.Custom;
			this.c1pBtnViewFullPage1.ImageIndex = 20;
			this.c1pBtnViewFullPage1.Pushed = true;
			this.c1pBtnViewFullPage1.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton;
			this.c1pBtnViewFullPage1.ToolTipText = "Full Page";
			// 
			// c1pBtnViewPageWidth1
			// 
			this.c1pBtnViewPageWidth1.Action = C1.Win.C1PrintPreview.ToolBarButtonActionEnum.Custom;
			this.c1pBtnViewPageWidth1.ImageIndex = 21;
			this.c1pBtnViewPageWidth1.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton;
			this.c1pBtnViewPageWidth1.ToolTipText = "Page Width";
			// 
			// c1pBtnViewTwoPages1
			// 
			this.c1pBtnViewTwoPages1.Action = C1.Win.C1PrintPreview.ToolBarButtonActionEnum.Custom;
			this.c1pBtnViewTwoPages1.ImageIndex = 22;
			this.c1pBtnViewTwoPages1.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton;
			this.c1pBtnViewTwoPages1.ToolTipText = "Two Pages";
			// 
			// c1pBtnViewFourPages1
			// 
			this.c1pBtnViewFourPages1.Action = C1.Win.C1PrintPreview.ToolBarButtonActionEnum.Custom;
			this.c1pBtnViewFourPages1.ImageIndex = 23;
			this.c1pBtnViewFourPages1.Style = System.Windows.Forms.ToolBarButtonStyle.DropDownButton;
			this.c1pBtnViewFourPages1.ToolTipText = "Four Pages";
			// 
			// c1pBtnSeparator7
			// 
			this.c1pBtnSeparator7.Action = C1.Win.C1PrintPreview.ToolBarButtonActionEnum.Custom;
			this.c1pBtnSeparator7.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			this.c1pBtnSeparator7.Visible = false;
			// 
			// c1pBtnHelp1
			// 
			this.c1pBtnHelp1.Action = C1.Win.C1PrintPreview.ToolBarButtonActionEnum.Custom;
			this.c1pBtnHelp1.ImageIndex = 24;
			this.c1pBtnHelp1.ToolTipText = "Help";
			this.c1pBtnHelp1.Visible = false;
			// 
			// c1Report1
			// 
			this.c1Report1.ReportDefinition = "<!--Report *** BillReportVN ***--><Report version=\"2.5.20051.166\"><Name>BillRepor" +
				"tVN</Name><DataSource><ConnectionString>Provider=SQLOLEDB;Password=glinton99;Per" +
				"sist Security Info=True;User ID=sa;Initial Catalog=RESTAURANT;Data Source=10.0.0" +
				".86</ConnectionString><RecordSource>PARAMETERS BIL_NO string \'\',  REP_NO string " +
				"\'\';\r\nspRptReceipt(BIL_NO, REP_NO)</RecordSource></DataSource><Layout><Width>4095" +
				"</Width><MarginLeft>0</MarginLeft><MarginTop>0</MarginTop><MarginRight>0</Margin" +
				"Right><MarginBottom>0</MarginBottom><Orientation>1</Orientation></Layout><Font><" +
				"Name>Arial</Name><Size>8.25</Size></Font><Groups /><Sections><Section><Name>Deta" +
				"il</Name><Type>0</Type><Height>300</Height></Section><Section><Name>Header</Name" +
				"><Type>1</Type><Height>2535</Height></Section><Section><Name>Footer</Name><Type>" +
				"2</Type><Height>270</Height><Visible>0</Visible></Section><Section><Name>PageHea" +
				"der</Name><Type>3</Type><Height>315</Height></Section><Section><Name>PageFooter<" +
				"/Name><Type>4</Type><Height>1025</Height><OnPrint>Field13=Sum(AMT_QT)</OnPrint><" +
				"/Section></Sections><Fields><Field><Name>titleLbl</Name><Section>1</Section><Tex" +
				"t>70-72 Ngô Đức Kế, Quận 1, Tp. HCM</Text><Left>75</Left><Top>120</Top><Width>39" +
				"30</Width><Height>320</Height><Align>7</Align><ForeColor>128</ForeColor><Font><B" +
				"old>-1</Bold><Name>Arial</Name><Size>8.25</Size></Font></Field><Field><Name>titl" +
				"eLbl1</Name><Section>1</Section><Text>ĐT: (08) 73 360708</Text><Left>75</Left><T" +
				"op>435</Top><Width>3930</Width><Height>320</Height><Align>7</Align><ForeColor>12" +
				"8</ForeColor><Font><Bold>-1</Bold><Name>Arial</Name><Size>8.25</Size></Font></Fi" +
				"eld><Field><Name>titleLbl2</Name><Section>1</Section><Text>HÓA ĐƠN THANH TOÁN</T" +
				"ext><Left>75</Left><Top>750</Top><Width>3930</Width><Height>510</Height><Align>7" +
				"</Align><ForeColor>128</ForeColor><Font><Bold>-1</Bold><Name>Arial</Name><Size>1" +
				"4.25</Size></Font></Field><Field><Name>titleLbl3</Name><Section>1</Section><Text" +
				">Ngày :</Text><Left>75</Left><Top>1275</Top><Width>810</Width><Height>315</Heigh" +
				"t><Align>6</Align><ForeColor>128</ForeColor><Font><Bold>-1</Bold><Name>Arial</Na" +
				"me><Size>8.25</Size></Font></Field><Field><Name>Field1</Name><Section>1</Section" +
				"><Text>BIL_DT</Text><Calculated>-1</Calculated><Format>Date</Format><Left>900</L" +
				"eft><Top>1275</Top><Width>900</Width><Height>315</Height><Align>6</Align><Font><" +
				"Bold>-1</Bold><Name>Arial</Name><Size>8.25</Size></Font></Field><Field><Name>tit" +
				"leLbl4</Name><Section>1</Section><Text>Thu Ngân :</Text><Left>1815</Left><Top>12" +
				"75</Top><Width>885</Width><Height>315</Height><Align>6</Align><ForeColor>128</Fo" +
				"reColor><Font><Bold>-1</Bold><Name>Arial</Name><Size>8.25</Size></Font></Field><" +
				"Field><Name>Field2</Name><Section>1</Section><Text>CSH_NM</Text><Calculated>-1</" +
				"Calculated><Left>2775</Left><Top>1275</Top><Width>1230</Width><Height>315</Heigh" +
				"t><Align>6</Align><Font><Bold>-1</Bold><Name>Arial</Name><Size>8.25</Size></Font" +
				"></Field><Field><Name>titleLbl5</Name><Section>1</Section><Text>Số HĐ :</Text><L" +
				"eft>75</Left><Top>1590</Top><Width>810</Width><Height>315</Height><Align>6</Alig" +
				"n><ForeColor>128</ForeColor><Font><Bold>-1</Bold><Name>Arial</Name><Size>8.25</S" +
				"ize></Font></Field><Field><Name>Field3</Name><Section>1</Section><Text>BIL_NO</T" +
				"ext><Calculated>-1</Calculated><Left>900</Left><Top>1590</Top><Width>900</Width>" +
				"<Height>315</Height><Align>6</Align><Font><Bold>-1</Bold><Name>Arial</Name><Size" +
				">8.25</Size></Font></Field><Field><Name>titleLbl6</Name><Section>1</Section><Tex" +
				"t>Bàn :</Text><Left>1815</Left><Top>1590</Top><Width>885</Width><Height>315</Hei" +
				"ght><Align>6</Align><ForeColor>128</ForeColor><Font><Bold>-1</Bold><Name>Arial</" +
				"Name><Size>8.25</Size></Font></Field><Field><Name>Field4</Name><Section>1</Secti" +
				"on><Text>TBL_ID</Text><Calculated>-1</Calculated><Left>2775</Left><Top>1590</Top" +
				"><Width>1230</Width><Height>315</Height><Align>6</Align><Font><Bold>-1</Bold><Na" +
				"me>Arial</Name><Size>8.25</Size></Font></Field><Field><Name>titleLbl7</Name><Sec" +
				"tion>1</Section><Text>Giờ Vào :</Text><Left>75</Left><Top>1905</Top><Width>810</" +
				"Width><Height>315</Height><Align>6</Align><ForeColor>128</ForeColor><Font><Bold>" +
				"-1</Bold><Name>Arial</Name><Size>8.25</Size></Font></Field><Field><Name>Field5</" +
				"Name><Section>1</Section><Text>COM_IN</Text><Calculated>-1</Calculated><Left>900" +
				"</Left><Top>1905</Top><Width>900</Width><Height>315</Height><Align>6</Align><Fon" +
				"t><Bold>-1</Bold><Name>Arial</Name><Size>8.25</Size></Font></Field><Field><Name>" +
				"titleLbl8</Name><Section>1</Section><Text>Giờ Ra :</Text><Left>1815</Left><Top>1" +
				"905</Top><Width>885</Width><Height>315</Height><Align>6</Align><ForeColor>128</F" +
				"oreColor><Font><Bold>-1</Bold><Name>Arial</Name><Size>8.25</Size></Font></Field>" +
				"<Field><Name>Field6</Name><Section>1</Section><Text>Format(Now, \"Medium Time\")</" +
				"Text><Calculated>-1</Calculated><Left>2910</Left><Top>1995</Top><Width>30</Width" +
				"><Height>30</Height></Field><Field><Name>Field7</Name><Section>1</Section><Text>" +
				"Format(Now, \"Medium Time\")</Text><Calculated>-1</Calculated><Format>Time</Format" +
				"><Left>2775</Left><Top>1905</Top><Width>1230</Width><Height>315</Height><Align>6" +
				"</Align><Font><Bold>-1</Bold><Name>Arial</Name><Size>8.25</Size></Font></Field><" +
				"Field><Name>titleLbl9</Name><Section>1</Section><Text>Tên K.H:</Text><Left>75</L" +
				"eft><Top>2220</Top><Width>810</Width><Height>315</Height><Align>6</Align><ForeCo" +
				"lor>128</ForeColor><Font><Bold>-1</Bold><Name>Arial</Name><Size>8.25</Size></Fon" +
				"t></Field><Field><Name>Field8</Name><Section>1</Section><Text>CUS_NM</Text><Calc" +
				"ulated>-1</Calculated><Left>900</Left><Top>2220</Top><Width>3105</Width><Height>" +
				"315</Height><Align>6</Align><Font><Bold>-1</Bold><Name>Arial</Name><Size>8.25</S" +
				"ize></Font></Field><Field><Name>titleLbl10</Name><Section>3</Section><Text>Stt</" +
				"Text><Left>75</Left><Width>300</Width><Height>315</Height><Align>7</Align><ForeC" +
				"olor>128</ForeColor><Font><Bold>-1</Bold><Name>Arial</Name><Size>8.25</Size></Fo" +
				"nt></Field><Field><Name>titleLbl11</Name><Section>3</Section><Text>Tên Món</Text" +
				"><Left>390</Left><Width>1635</Width><Height>315</Height><Align>7</Align><ForeCol" +
				"or>128</ForeColor><Font><Bold>-1</Bold><Name>Arial</Name><Size>8.25</Size></Font" +
				"></Field><Field><Name>titleLbl12</Name><Section>3</Section><Text>S.L</Text><Left" +
				">2040</Left><Width>375</Width><Height>315</Height><Align>7</Align><ForeColor>128" +
				"</ForeColor><Font><Bold>-1</Bold><Name>Arial</Name><Size>8.25</Size></Font></Fie" +
				"ld><Field><Name>titleLbl13</Name><Section>3</Section><Text>Đ.G</Text><Left>2430<" +
				"/Left><Width>675</Width><Height>315</Height><Align>7</Align><ForeColor>128</Fore" +
				"Color><Font><Bold>-1</Bold><Name>Arial</Name><Size>8.25</Size></Font></Field><Fi" +
				"eld><Name>titleLbl14</Name><Section>3</Section><Text>T. Tiền</Text><Left>3150</L" +
				"eft><Width>855</Width><Height>315</Height><Align>7</Align><ForeColor>128</ForeCo" +
				"lor><Font><Bold>-1</Bold><Name>Arial</Name><Size>8.25</Size></Font></Field><Fiel" +
				"d><Name>Field9</Name><Section>0</Section><Text>FDK_VN</Text><Calculated>-1</Calc" +
				"ulated><Left>390</Left><Width>1635</Width><Height>300</Height><Align>6</Align><F" +
				"ont><Name>Arial</Name><Size>6.75</Size></Font></Field><Field><Name>Field10</Name" +
				"><Section>0</Section><Text>FDK_QT</Text><Calculated>-1</Calculated><Format>#,##0" +
				"</Format><Left>2040</Left><Width>375</Width><Height>300</Height><Align>7</Align>" +
				"<Font><Name>Arial</Name><Size>6.75</Size></Font></Field><Field><Name>Field11</Na" +
				"me><Section>0</Section><Text>UNT_PR</Text><Calculated>-1</Calculated><Format>#,#" +
				"#0.00</Format><Left>2430</Left><Width>675</Width><Height>300</Height><Align>8</A" +
				"lign><Font><Name>Arial</Name><Size>6.75</Size></Font></Field><Field><Name>Field1" +
				"2</Name><Section>0</Section><Text>AMT_QT</Text><Calculated>-1</Calculated><Forma" +
				"t>#,##0</Format><Left>3150</Left><Width>855</Width><Height>300</Height><Align>8<" +
				"/Align><Font><Name>Arial</Name><Size>6.75</Size></Font></Field><Field><Name>titl" +
				"eLbl15</Name><Section>4</Section><Text>Cảm ơn và hẹn gặp lại!!!!</Text><Left>90<" +
				"/Left><Top>570</Top><Width>2970</Width><Height>315</Height><Align>7</Align><Fore" +
				"Color>128</ForeColor><Font><Bold>-1</Bold><Name>Arial</Name><Size>8.25</Size></F" +
				"ont></Field><Field><Name>Field13</Name><Section>4</Section><Text>Field13</Text><" +
				"Format>#,##0.00</Format><Left>2670</Left><Top>45</Top><Width>1335</Width><Height" +
				">345</Height><Align>8</Align><Font><Bold>-1</Bold><Name>Arial</Name><Size>8.25</" +
				"Size></Font></Field></Fields></Report>";
			this.c1Report1.ReportName = "BillReportVN";
			// 
			// frmCrystalReport
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
			this.ClientSize = new System.Drawing.Size(696, 554);
			this.Controls.Add(this.c1PrintPreview1);
			this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "frmCrystalReport";
			this.Text = "frmCrystalReport";
			this.Load += new System.EventHandler(this.frmCrystalReport_Load);
			((System.ComponentModel.ISupportInitialize)(this.c1PrintPreview1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.c1Report1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void frmCrystalReport_Load(object sender, System.EventArgs e)
		{
			c1Report1.Load(this.fileReport,this.nameReport);
			c1Report1.DataSource.Recordset=this.ds.Tables[0];
			c1PrintPreview1.Document=c1Report1.Document;
		}


	}
}
