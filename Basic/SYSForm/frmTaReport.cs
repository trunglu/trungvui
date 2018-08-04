using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using Basic;
using Basic.Function;
using C1.Win.C1Report;
using C1.C1Excel;
namespace Basic.Form
{
	/// <summary>
	/// Summary description for frmTaReport.
	/// </summary>
	public class frmTaReport : System.Windows.Forms.Form
	{
		private C1.Win.C1Report.C1Report c1r;
		private string sql;
		private int id;
		public string w1,w2,w3,w4;
		private C1.Win.C1PrintPreview.C1PrintPreview cpp;
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
		//private DataDynamics.ActiveReports.Viewer.Viewer v1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmTaReport(int ID,string sql)
		{
			//
			// Required for Windows Form Designer support
			//
			this.id=ID;
			this.sql=sql;
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
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
			this.c1r = new C1.Win.C1Report.C1Report();
			this.cpp = new C1.Win.C1PrintPreview.C1PrintPreview();
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
			((System.ComponentModel.ISupportInitialize)(this.c1r)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cpp)).BeginInit();
			this.SuspendLayout();
			// 
			// c1r
			// 
			this.c1r.ReportDefinition = @"<!--Report *** Unnamed Report ***--><Report version=""2.5.20051.166""><DataSource /><Layout><Orientation>1</Orientation></Layout><Font><Name>Arial</Name><Size>9</Size></Font><Groups /><Sections><Section><Name>Detail</Name><Type>0</Type><Visible>0</Visible></Section><Section><Name>Header</Name><Type>1</Type><Visible>0</Visible></Section><Section><Name>Footer</Name><Type>2</Type><Visible>0</Visible></Section><Section><Name>PageHeader</Name><Type>3</Type><Visible>0</Visible></Section><Section><Name>PageFooter</Name><Type>4</Type><Visible>0</Visible></Section></Sections><Fields /></Report>";
			// 
			// cpp
			// 
			this.cpp.C1DPageSettings = "color:False;landscape:False;margins:100,100,100,100;papersize:827,1169,QQA0AA==";
			this.cpp.Dock = System.Windows.Forms.DockStyle.Fill;
			this.cpp.Location = new System.Drawing.Point(0, 0);
			this.cpp.Name = "cpp";
			this.cpp.NavigationBar.Cursor = System.Windows.Forms.Cursors.Default;
			this.cpp.NavigationBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cpp.NavigationBar.OutlineView.Cursor = System.Windows.Forms.Cursors.Default;
			this.cpp.NavigationBar.OutlineView.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cpp.NavigationBar.OutlineView.Indent = 19;
			this.cpp.NavigationBar.OutlineView.ItemHeight = 16;
			this.cpp.NavigationBar.OutlineView.TabIndex = 0;
			this.cpp.NavigationBar.OutlineView.Visible = false;
			this.cpp.NavigationBar.Padding = new System.Drawing.Point(6, 3);
			this.cpp.NavigationBar.TabIndex = 2;
			this.cpp.NavigationBar.ThumbnailsView.AutoArrange = true;
			this.cpp.NavigationBar.ThumbnailsView.Cursor = System.Windows.Forms.Cursors.Default;
			this.cpp.NavigationBar.ThumbnailsView.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cpp.NavigationBar.ThumbnailsView.TabIndex = 0;
			this.cpp.NavigationBar.ThumbnailsView.Visible = true;
			this.cpp.NavigationBar.Width = 160;
			this.cpp.Size = new System.Drawing.Size(692, 458);
			this.cpp.Splitter.Cursor = System.Windows.Forms.Cursors.VSplit;
			this.cpp.Splitter.Width = 3;
			this.cpp.StatusBar.Cursor = System.Windows.Forms.Cursors.Default;
			this.cpp.StatusBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cpp.StatusBar.TabIndex = 4;
			this.cpp.TabIndex = 0;
			this.cpp.ToolBar.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
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
			this.cpp.ToolBar.Cursor = System.Windows.Forms.Cursors.Default;
			this.cpp.ToolBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			// 
			// c1pBtnFileOpen1
			// 
			this.c1pBtnFileOpen1.Action = C1.Win.C1PrintPreview.ToolBarButtonActionEnum.FileOpen;
			this.c1pBtnFileOpen1.ImageIndex = 0;
			this.c1pBtnFileOpen1.ToolTipText = "File Open";
			// 
			// c1pBtnFileSave1
			// 
			this.c1pBtnFileSave1.Action = C1.Win.C1PrintPreview.ToolBarButtonActionEnum.FileSave;
			this.c1pBtnFileSave1.ImageIndex = 1;
			this.c1pBtnFileSave1.ToolTipText = "File Save";
			// 
			// c1pBtnFilePrint1
			// 
			this.c1pBtnFilePrint1.Action = C1.Win.C1PrintPreview.ToolBarButtonActionEnum.FilePrint;
			this.c1pBtnFilePrint1.ImageIndex = 2;
			this.c1pBtnFilePrint1.ToolTipText = "Print";
			// 
			// c1pBtnPageSetup1
			// 
			this.c1pBtnPageSetup1.Action = C1.Win.C1PrintPreview.ToolBarButtonActionEnum.PageSetup;
			this.c1pBtnPageSetup1.ImageIndex = 3;
			this.c1pBtnPageSetup1.ToolTipText = "Page Setup";
			// 
			// c1pBtnReflow1
			// 
			this.c1pBtnReflow1.Action = C1.Win.C1PrintPreview.ToolBarButtonActionEnum.Reflow;
			this.c1pBtnReflow1.ImageIndex = 4;
			this.c1pBtnReflow1.ToolTipText = "Reflow";
			// 
			// c1pBtnStop1
			// 
			this.c1pBtnStop1.Action = C1.Win.C1PrintPreview.ToolBarButtonActionEnum.Stop;
			this.c1pBtnStop1.ImageIndex = 5;
			this.c1pBtnStop1.ToolTipText = "Stop";
			this.c1pBtnStop1.Visible = false;
			// 
			// c1pBtnDocInfo1
			// 
			this.c1pBtnDocInfo1.Action = C1.Win.C1PrintPreview.ToolBarButtonActionEnum.DocInfo;
			this.c1pBtnDocInfo1.Enabled = false;
			this.c1pBtnDocInfo1.ImageIndex = 26;
			this.c1pBtnDocInfo1.ToolTipText = "Document information";
			// 
			// c1pBtnSeparator1
			// 
			this.c1pBtnSeparator1.Action = C1.Win.C1PrintPreview.ToolBarButtonActionEnum.None;
			this.c1pBtnSeparator1.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// c1pBtnShowNavigationBar1
			// 
			this.c1pBtnShowNavigationBar1.Action = C1.Win.C1PrintPreview.ToolBarButtonActionEnum.ShowNavigationBar;
			this.c1pBtnShowNavigationBar1.ImageIndex = 6;
			this.c1pBtnShowNavigationBar1.Pushed = true;
			this.c1pBtnShowNavigationBar1.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton;
			this.c1pBtnShowNavigationBar1.ToolTipText = "Show Navigation Bar";
			// 
			// c1pBtnSeparator2
			// 
			this.c1pBtnSeparator2.Action = C1.Win.C1PrintPreview.ToolBarButtonActionEnum.None;
			this.c1pBtnSeparator2.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// c1pBtnMouseHand1
			// 
			this.c1pBtnMouseHand1.Action = C1.Win.C1PrintPreview.ToolBarButtonActionEnum.MouseHand;
			this.c1pBtnMouseHand1.ImageIndex = 7;
			this.c1pBtnMouseHand1.Pushed = true;
			this.c1pBtnMouseHand1.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton;
			this.c1pBtnMouseHand1.ToolTipText = "Hand Tool";
			// 
			// c1pBtnMouseZoom1
			// 
			this.c1pBtnMouseZoom1.Action = C1.Win.C1PrintPreview.ToolBarButtonActionEnum.MouseZoom;
			this.c1pBtnMouseZoom1.ImageIndex = 8;
			this.c1pBtnMouseZoom1.Style = System.Windows.Forms.ToolBarButtonStyle.DropDownButton;
			this.c1pBtnMouseZoom1.ToolTipText = "Zoom In Tool";
			// 
			// c1pBtnMouseZoomOut1
			// 
			this.c1pBtnMouseZoomOut1.Action = C1.Win.C1PrintPreview.ToolBarButtonActionEnum.MouseZoomOut;
			this.c1pBtnMouseZoomOut1.ImageIndex = 25;
			this.c1pBtnMouseZoomOut1.Style = System.Windows.Forms.ToolBarButtonStyle.DropDownButton;
			this.c1pBtnMouseZoomOut1.ToolTipText = "Zoom Out Tool";
			this.c1pBtnMouseZoomOut1.Visible = false;
			// 
			// c1pBtnMouseSelect1
			// 
			this.c1pBtnMouseSelect1.Action = C1.Win.C1PrintPreview.ToolBarButtonActionEnum.MouseSelect;
			this.c1pBtnMouseSelect1.ImageIndex = 9;
			this.c1pBtnMouseSelect1.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton;
			this.c1pBtnMouseSelect1.ToolTipText = "Select Text";
			// 
			// c1pBtnFindText1
			// 
			this.c1pBtnFindText1.Action = C1.Win.C1PrintPreview.ToolBarButtonActionEnum.FindText;
			this.c1pBtnFindText1.ImageIndex = 10;
			this.c1pBtnFindText1.ToolTipText = "Find Text";
			// 
			// c1pBtnSeparator3
			// 
			this.c1pBtnSeparator3.Action = C1.Win.C1PrintPreview.ToolBarButtonActionEnum.None;
			this.c1pBtnSeparator3.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// c1pBtnGoFirst1
			// 
			this.c1pBtnGoFirst1.Action = C1.Win.C1PrintPreview.ToolBarButtonActionEnum.GoFirst;
			this.c1pBtnGoFirst1.Enabled = false;
			this.c1pBtnGoFirst1.ImageIndex = 11;
			this.c1pBtnGoFirst1.ToolTipText = "First Page";
			// 
			// c1pBtnGoPrev1
			// 
			this.c1pBtnGoPrev1.Action = C1.Win.C1PrintPreview.ToolBarButtonActionEnum.GoPrev;
			this.c1pBtnGoPrev1.Enabled = false;
			this.c1pBtnGoPrev1.ImageIndex = 12;
			this.c1pBtnGoPrev1.ToolTipText = "Previous Page";
			// 
			// c1pBtnGoNext1
			// 
			this.c1pBtnGoNext1.Action = C1.Win.C1PrintPreview.ToolBarButtonActionEnum.GoNext;
			this.c1pBtnGoNext1.ImageIndex = 13;
			this.c1pBtnGoNext1.ToolTipText = "Next Page";
			// 
			// c1pBtnGoLast1
			// 
			this.c1pBtnGoLast1.Action = C1.Win.C1PrintPreview.ToolBarButtonActionEnum.GoLast;
			this.c1pBtnGoLast1.ImageIndex = 14;
			this.c1pBtnGoLast1.ToolTipText = "Last Page";
			// 
			// c1pBtnSeparator4
			// 
			this.c1pBtnSeparator4.Action = C1.Win.C1PrintPreview.ToolBarButtonActionEnum.None;
			this.c1pBtnSeparator4.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// c1pBtnHistoryPrev1
			// 
			this.c1pBtnHistoryPrev1.Action = C1.Win.C1PrintPreview.ToolBarButtonActionEnum.HistoryPrev;
			this.c1pBtnHistoryPrev1.Enabled = false;
			this.c1pBtnHistoryPrev1.ImageIndex = 15;
			this.c1pBtnHistoryPrev1.Style = System.Windows.Forms.ToolBarButtonStyle.DropDownButton;
			this.c1pBtnHistoryPrev1.ToolTipText = "Previous View";
			// 
			// c1pBtnHistoryNext1
			// 
			this.c1pBtnHistoryNext1.Action = C1.Win.C1PrintPreview.ToolBarButtonActionEnum.HistoryNext;
			this.c1pBtnHistoryNext1.Enabled = false;
			this.c1pBtnHistoryNext1.ImageIndex = 16;
			this.c1pBtnHistoryNext1.Style = System.Windows.Forms.ToolBarButtonStyle.DropDownButton;
			this.c1pBtnHistoryNext1.ToolTipText = "Next View";
			// 
			// c1pBtnSeparator5
			// 
			this.c1pBtnSeparator5.Action = C1.Win.C1PrintPreview.ToolBarButtonActionEnum.None;
			this.c1pBtnSeparator5.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			this.c1pBtnSeparator5.Visible = false;
			// 
			// c1pBtnZoomOut1
			// 
			this.c1pBtnZoomOut1.Action = C1.Win.C1PrintPreview.ToolBarButtonActionEnum.ZoomOut;
			this.c1pBtnZoomOut1.ImageIndex = 17;
			this.c1pBtnZoomOut1.ToolTipText = "Zoom Out";
			this.c1pBtnZoomOut1.Visible = false;
			// 
			// c1pBtnZoomIn1
			// 
			this.c1pBtnZoomIn1.Action = C1.Win.C1PrintPreview.ToolBarButtonActionEnum.ZoomIn;
			this.c1pBtnZoomIn1.ImageIndex = 18;
			this.c1pBtnZoomIn1.ToolTipText = "Zoom In";
			this.c1pBtnZoomIn1.Visible = false;
			// 
			// c1pBtnSeparator6
			// 
			this.c1pBtnSeparator6.Action = C1.Win.C1PrintPreview.ToolBarButtonActionEnum.None;
			this.c1pBtnSeparator6.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			this.c1pBtnSeparator6.Visible = false;
			// 
			// c1pBtnViewActualSize1
			// 
			this.c1pBtnViewActualSize1.Action = C1.Win.C1PrintPreview.ToolBarButtonActionEnum.ViewActualSize;
			this.c1pBtnViewActualSize1.ImageIndex = 19;
			this.c1pBtnViewActualSize1.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton;
			this.c1pBtnViewActualSize1.ToolTipText = "Actual Size";
			// 
			// c1pBtnViewFullPage1
			// 
			this.c1pBtnViewFullPage1.Action = C1.Win.C1PrintPreview.ToolBarButtonActionEnum.ViewFullPage;
			this.c1pBtnViewFullPage1.ImageIndex = 20;
			this.c1pBtnViewFullPage1.Pushed = true;
			this.c1pBtnViewFullPage1.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton;
			this.c1pBtnViewFullPage1.ToolTipText = "Full Page";
			// 
			// c1pBtnViewPageWidth1
			// 
			this.c1pBtnViewPageWidth1.Action = C1.Win.C1PrintPreview.ToolBarButtonActionEnum.ViewPageWidth;
			this.c1pBtnViewPageWidth1.ImageIndex = 21;
			this.c1pBtnViewPageWidth1.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton;
			this.c1pBtnViewPageWidth1.ToolTipText = "Page Width";
			// 
			// c1pBtnViewTwoPages1
			// 
			this.c1pBtnViewTwoPages1.Action = C1.Win.C1PrintPreview.ToolBarButtonActionEnum.ViewTwoPages;
			this.c1pBtnViewTwoPages1.ImageIndex = 22;
			this.c1pBtnViewTwoPages1.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton;
			this.c1pBtnViewTwoPages1.ToolTipText = "Two Pages";
			// 
			// c1pBtnViewFourPages1
			// 
			this.c1pBtnViewFourPages1.Action = C1.Win.C1PrintPreview.ToolBarButtonActionEnum.ViewFourPages;
			this.c1pBtnViewFourPages1.ImageIndex = 23;
			this.c1pBtnViewFourPages1.Style = System.Windows.Forms.ToolBarButtonStyle.DropDownButton;
			this.c1pBtnViewFourPages1.ToolTipText = "Four Pages";
			// 
			// c1pBtnSeparator7
			// 
			this.c1pBtnSeparator7.Action = C1.Win.C1PrintPreview.ToolBarButtonActionEnum.None;
			this.c1pBtnSeparator7.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			this.c1pBtnSeparator7.Visible = false;
			// 
			// c1pBtnHelp1
			// 
			this.c1pBtnHelp1.Action = C1.Win.C1PrintPreview.ToolBarButtonActionEnum.Help;
			this.c1pBtnHelp1.ImageIndex = 24;
			this.c1pBtnHelp1.ToolTipText = "Help";
			this.c1pBtnHelp1.Visible = false;
			// 
			// frmTaReport
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(692, 458);
			this.Controls.Add(this.cpp);
			this.Name = "frmTaReport";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmTaReport";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.frmTaReport_Load);
			((System.ComponentModel.ISupportInitialize)(this.c1r)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cpp)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void frmTaReport_Load(object sender, System.EventArgs e)
		{			
			this.Text="Report";
			RPT();
		}

		private void RPT()
		{
			try
			{
				DataSource ds;
				switch (id)
				{
					case 0:				
						//GGM3000.Workshop.Report.RptTaForCuttingBundleMaintain.BarcodeForDahsheng(sql,c1r);
						GGM3000.Workshop.Report.RptTaForCuttingBundleMaintain.BarcodeForCartina(sql,c1r);
						break;
					case 1:				
						GGM3000.Workshop.Report.RptTaForCuttingBundleMaintain.CardNoForDahsheng(sql,c1r,w1,w2);
						break;		
					case 2:				
						c1r.Load(PublicFunction.Path+"\\LoadReport\\frmTaBarcodeInput.xml","UnclaimedBarcode");
						InitLabel("UnclaimedBarcode");
						c1r.Fields["lb1"].Text=c1r.Fields["lb1"].Text +": " + w1;
						c1r.Fields["lb2"].Text=c1r.Fields["lb2"].Text +": " ;
						ds = c1r.DataSource;
						ds.ConnectionString=PublicFunction.C_ConStrForRPT;
						ds.RecordSource=sql;	
						break;	
					case 3:				
						c1r.Load(PublicFunction.Path+"\\LoadReport\\frmTaOrderOperationMaintain.xml","SewingSectionReport");
						InitLabel("SewingSectionReport");
						c1r.Fields["lb1"].Text=w1;
						c1r.Fields["lb2"].Text=w2;
						c1r.Fields["lb3"].Text=w3;
						ds = c1r.DataSource;
						ds.ConnectionString=PublicFunction.C_ConStrForRPT;
						ds.RecordSource=sql;	
						break;
					case 4: //	Bundle card STD		
						c1r.Load(PublicFunction.Path+"\\LoadReport\\frmTaCuttingBundleMaintain.xml","BundleCard");
						InitLabel("BundleCard");
//						c1r.Fields["lb1"].Text=w1;
//						c1r.Fields["lb2"].Text=w2;
//						c1r.Fields["lb3"].Text=w3;
						ds = c1r.DataSource;
						ds.ConnectionString=PublicFunction.C_ConStrForRPT;
						ds.RecordSource=sql;	
						break;
				}			
				cpp.Document = c1r.Document;						
			}
			catch{}
			
		}		

		private void InitLabel(string ID)
		{
			for(int i=0;i<c1r.Fields.Count;i++)
			{
				if (c1r.Fields[i].Calculated!=true  && (c1r.Fields[i].Tag+"")!="N")
				{
					c1r.Fields[i].Text=PublicFunction.L_Get_RPT(ID,c1r.Fields[i].Name);
				}
			}
		}
	}
}


