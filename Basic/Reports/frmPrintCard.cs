using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;
using System.Diagnostics;
using System.Data.SqlClient;
using C1.C1PrintDocument;
//using CrystalDecisions.Shared;
//using CrystalDecisions.CrystalReports.Engine;
using Basic.Function;

namespace GP8000.Reports
{
	/// <summary>
	/// Summary description for frmAccReport.
	/// </summary>
	public class frmPrintCard : System.Windows.Forms.Form
	{
		public DataSet ds;
		public string fileReport, nameReport,st;
		private C1.Win.C1Report.C1Report QuangVietCard;
		private C1.C1PrintDocument.C1PrintDocument c1PrintDocument1;
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
		
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmPrintCard(string st, string fileReport, string nameReport)
		{
			//this.ds=ds;
			this.st=st;
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
			this.QuangVietCard = new C1.Win.C1Report.C1Report();
			this.c1PrintDocument1 = new C1.C1PrintDocument.C1PrintDocument();
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
			((System.ComponentModel.ISupportInitialize)(this.QuangVietCard)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.c1PrintPreview1)).BeginInit();
			this.SuspendLayout();
			// 
			// QuangVietCard
			// 
			this.QuangVietCard.ReportDefinition = "<!--Report *** QuangVietCard ***--><Report version=\"2.5.20051.166\"><Name>QuangVie" +
				"tCard</Name><DataSource /><Layout><Width>5250</Width><MarginLeft>72</MarginLeft>" +
				"<MarginTop>72</MarginTop><MarginRight>72</MarginRight><MarginBottom>43.2</Margin" +
				"Bottom><Orientation>1</Orientation><Columns>2</Columns><PaperSize>9</PaperSize><" +
				"/Layout><Font><Name>Segoe UI</Name><Size>9</Size></Font><Groups /><Sections><Sec" +
				"tion><Name>Detail</Name><Type>0</Type><Height>3220</Height></Section><Section><N" +
				"ame>Header</Name><Type>1</Type><Height>125</Height><Visible>0</Visible></Section" +
				"><Section><Name>Footer</Name><Type>2</Type><Visible>0</Visible></Section><Sectio" +
				"n><Name>PageHeader</Name><Type>3</Type><Height>175</Height><Visible>0</Visible><" +
				"BackColor>16768194</BackColor></Section><Section><Name>PageFooter</Name><Type>4<" +
				"/Type><Height>230</Height><Visible>0</Visible></Section></Sections><Fields><Fiel" +
				"d><Name>Field13</Name><Section>0</Section><Width>5055</Width><Height>915</Height" +
				"><ZOrder>-1</ZOrder><BackColor>9498256</BackColor><BackStyle>1</BackStyle></Fiel" +
				"d><Field><Name>Field1</Name><Section>0</Section><Width>5055</Width><Height>3165<" +
				"/Height><BorderStyle>1</BorderStyle></Field><Field><Name>Field3</Name><Section>0" +
				"</Section><Left>75</Left><Top>30</Top><Width>1110</Width><Height>810</Height><Pi" +
				"cture encoding=\"base64\">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</Pi" +
				"cture></Field><Field><Name>Field2</Name><Section>0</Section><Text>Kwang Viet Gar" +
				"ment Co., Ltd.</Text><Left>1230</Left><Top>120</Top><Width>3750</Width><Height>3" +
				"45</Height><Align>6</Align><ForeColor>2263842</ForeColor><WordWrap>0</WordWrap><" +
				"Font><Bold>-1</Bold><Name>Times New Roman</Name><Size>13</Size></Font></Field><F" +
				"ield><Name>Field5</Name><Section>0</Section><Text>Name:</Text><Left>1545</Left><" +
				"Top>990</Top><Width>1170</Width><Height>300</Height><Font><Bold>-1</Bold><Name>T" +
				"ahoma</Name><Size>12</Size></Font></Field><Field><Name>EMP_NM</Name><Section>0</" +
				"Section><Text>=[EMP_NM]</Text><Calculated>-1</Calculated><Left>1575</Left><Top>1" +
				"380</Top><Width>3390</Width><Height>390</Height><Align>0</Align><ForeColor>16711" +
				"680</ForeColor><Font><Name>Tahoma</Name><Size>9.75</Size></Font></Field><Field><" +
				"Name>Field4</Name><Section>0</Section><Text>=[PIC_DR]</Text><Calculated>-1</Calc" +
				"ulated><Left>60</Left><Top>1020</Top><Width>1395</Width><Height>1920</Height><Bo" +
				"rderStyle>1</BorderStyle></Field><Field><Name>Field8</Name><Section>0</Section><" +
				"Text>Dept:</Text><Left>1560</Left><Top>1980</Top><Width>735</Width><Height>345</" +
				"Height><Font><Bold>-1</Bold><Name>Tahoma</Name><Size>12</Size></Font></Field><Fi" +
				"eld><Name>DEP_NM</Name><Section>0</Section><Text>=[DEP_NM]</Text><Calculated>-1<" +
				"/Calculated><Left>2595</Left><Top>1995</Top><Width>2310</Width><Height>345</Heig" +
				"ht><Align>0</Align><ForeColor>16711680</ForeColor><Font><Name>Tahoma</Name><Size" +
				">9.75</Size></Font></Field><Field><Name>Field11</Name><Section>0</Section><Text>" +
				"廣越製衣股份有限公司</Text><Left>1185</Left><Top>480</Top><Width>3810</Width><Height>360</" +
				"Height><Align>7</Align><ForeColor>2263842</ForeColor><WordWrap>0</WordWrap><Font" +
				"><Bold>-1</Bold><Name>Khmer UI</Name><Size>10</Size></Font></Field><Field><Name>" +
				"EMP_ID</Name><Section>0</Section><Text>=[EMP_ID]</Text><Calculated>-1</Calculate" +
				"d><Left>2580</Left><Top>2517</Top><Width>2410</Width><Height>372</Height><Align>" +
				"0</Align><ForeColor>16711680</ForeColor><Font><Name>Tahoma</Name><Size>9.75</Siz" +
				"e></Font></Field><Field><Name>Field15</Name><Section>0</Section><Text>ID:</Text>" +
				"<Left>1560</Left><Top>2535</Top><Width>930</Width><Height>255</Height><Font><Bol" +
				"d>-1</Bold><Name>Tahoma</Name><Size>12</Size></Font></Field></Fields></Report>";
			this.QuangVietCard.ReportName = "QuangVietCard";
			// 
			// c1PrintDocument1
			// 
			this.c1PrintDocument1.C1DPageSettings = "color:False;landscape:False;margins:100,100,100,100;papersize:850,1100,TABlAHQAdA" +
				"BlAHIA";
			this.c1PrintDocument1.ColumnSpacingStr = "0.5in";
			this.c1PrintDocument1.ColumnSpacingUnit.DefaultType = true;
			this.c1PrintDocument1.ColumnSpacingUnit.UnitValue = "0.5in";
			this.c1PrintDocument1.DefaultUnit = C1.C1PrintDocument.UnitTypeEnum.Inch;
			this.c1PrintDocument1.DocumentName = "";
			// 
			// c1PrintPreview1
			// 
			this.c1PrintPreview1.C1DPageSettings = "color:False;landscape:False;margins:100,100,100,100;papersize:827,1169,QQA0AA==";
			this.c1PrintPreview1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.c1PrintPreview1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
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
			// frmPrintCard
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
			this.ClientSize = new System.Drawing.Size(696, 554);
			this.Controls.Add(this.c1PrintPreview1);
			this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "frmPrintCard";
			this.Text = "frmPrintCard";
			this.Load += new System.EventHandler(this.frmPrintCard_Load);
			((System.ComponentModel.ISupportInitialize)(this.QuangVietCard)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.c1PrintPreview1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void frmPrintCard_Load(object sender, System.EventArgs e)
		{
			
			st = st.Replace("FILB01A", "a");
			DataTable dt = new DataTable();
			dt.Columns.Add("EMP_ID", typeof(string));
			dt.Columns.Add("EMP_NM", typeof(string));
			dt.Columns.Add("PIC_DR", typeof(Image));
			dt.Columns.Add("CRD_NO", typeof(string));
			dt.Columns.Add("POS_NM", typeof(string));
			dt.Columns.Add("INH_DT", typeof(string));
			dt.Columns.Add("BIR_DT", typeof(string));
			dt.Columns.Add("DEP_NM", typeof(string));
			//dt.Columns.Add("INH_DT", typeof(DateTime));
			string sql = string.Empty;
			sql = "select a.EMP_ID,a.EMP_I1,EMP_NM,EMP_N1,b.DEP_ID,DEP_NM,INH_DT,BIR_DT,CRD_NO,POS_NM FROM FILB01A a LEFT OUTER JOIN FILA02A b ON a.DEP_ID=b.DEP_ID";
			sql += " LEFT OUTER JOIN FILA07A c ON c.POS_ID=a.POS_ID ";
			sql += " WHERE ISNULL(VAC_BT,0)=0 AND ISNULL(DEL_BT,0)=0 ";
			if (st != "")
				sql += " AND " + st;
			sql += " ORDER BY b.DEP_ID,a.EMP_ID";
			Func.RecordSet rs = new Func.RecordSet(sql, PublicFunction.C_con);
			for (int i = 0; i < rs.rows; i++)
			{
				DataRow dr = dt.NewRow();
				dr["EMP_ID"] = rs.record(i, "EMP_ID");
				dr["EMP_NM"] = rs.record(i, "EMP_NM");
				SqlConnection con = new SqlConnection(PublicFunction.C_con.ConnectionString);
				con.Open();
				SqlCommand Sqlcmd = new SqlCommand("Select PIC_DR FROM FILB01AB WHERE EMP_ID='" + rs.record(i, "EMP_ID") + "'", con);
				object obj = Sqlcmd.ExecuteScalar();
				con.Close();
				if (obj != System.DBNull.Value && obj != null)
				{
					byte[] content = (byte[])obj;
					if (content.Length > 0)
					{
						System.IO.MemoryStream stream = new System.IO.MemoryStream(content);
						dr["PIC_DR"] = Image.FromStream(stream);						
					}
				}
				dr["POS_NM"] = rs.record(i, "POS_NM");
				dr["DEP_NM"] = rs.record(i, "DEP_NM");
				dr["INH_DT"] = DateTime.Parse(rs.record(i, "INH_DT") + "").ToString("dd/MM/yyyy");
				if (PublicFunction.IsDate(rs.record(i, "BIR_DT") + ""))
					dr["BIR_DT"] = DateTime.Parse(rs.record(i, "BIR_DT") + "").ToString("dd/MM/yyyy");
				else
					dr["BIR_DT"] = rs.record(i, "BIR_DT");
				dt.Rows.Add(dr);
			}
			//dtb = dt;
			//
			if(PublicFunction.CUS_ID=="50")//quang viet
			{
				QuangVietCard.Fields["Field4"].Picture = "PIC_DR";			
				QuangVietCard.Load(this.fileReport,this.nameReport);
				QuangVietCard.DataSource.Recordset=dt;//this.ds.Tables[0];
				c1PrintPreview1.Document=QuangVietCard.Document;
				//c1PrintDocument1.DocumentName=QuangVietCard ;
				

				
				
			}
		}


	}
}
