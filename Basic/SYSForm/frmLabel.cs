using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using Basic.Function;

namespace Basic.Form
{
	/// <summary>
	/// Summary description for Label.
	/// </summary>
	public class frmLabel : System.Windows.Forms.Form
	{
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.TabPage tabPage4;
		private Navigator1._0.NavigatorAuto nav4;
		private C1.Win.C1FlexGrid.C1FlexGrid vs4;
		private C1.Win.C1FlexGrid.C1FlexGrid vs1;
		private Navigator1._0.NavigatorAuto nav1;
		private C1.Win.C1FlexGrid.C1FlexGrid vs2;
		private Navigator1._0.NavigatorAuto nav2;
		private Navigator1._0.NavigatorAuto nav3;
		private C1.Win.C1FlexGrid.C1FlexGrid vs3;
		private System.Windows.Forms.TabPage tabPage5;
		private System.Windows.Forms.TabPage tabPage6;
		private C1.Win.C1FlexGrid.C1FlexGrid vs5;
		private Navigator1._0.NavigatorAuto nav5;
		private C1.Win.C1FlexGrid.C1FlexGrid vs6;
		private Navigator1._0.NavigatorAuto nav6;
		private string LB,RPT,PMENU;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmLabel(string LB,string RPT,string PMENU)
		{
            this.LB=LB;		
			this.RPT=RPT;
			this.PMENU=PMENU;
			InitializeComponent();		
		}

		public frmLabel()
		{
			this.LB="";		
			this.RPT="";
			this.PMENU="";
			//
			// Required for Windows Form Designer support
			//
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
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.vs1 = new C1.Win.C1FlexGrid.C1FlexGrid();
			this.nav1 = new Navigator1._0.NavigatorAuto();
			this.tabPage4 = new System.Windows.Forms.TabPage();
			this.vs4 = new C1.Win.C1FlexGrid.C1FlexGrid();
			this.nav4 = new Navigator1._0.NavigatorAuto();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.vs2 = new C1.Win.C1FlexGrid.C1FlexGrid();
			this.nav2 = new Navigator1._0.NavigatorAuto();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.vs3 = new C1.Win.C1FlexGrid.C1FlexGrid();
			this.nav3 = new Navigator1._0.NavigatorAuto();
			this.tabPage5 = new System.Windows.Forms.TabPage();
			this.vs5 = new C1.Win.C1FlexGrid.C1FlexGrid();
			this.nav5 = new Navigator1._0.NavigatorAuto();
			this.tabPage6 = new System.Windows.Forms.TabPage();
			this.vs6 = new C1.Win.C1FlexGrid.C1FlexGrid();
			this.nav6 = new Navigator1._0.NavigatorAuto();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.vs1)).BeginInit();
			this.tabPage4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.vs4)).BeginInit();
			this.tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.vs2)).BeginInit();
			this.tabPage3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.vs3)).BeginInit();
			this.tabPage5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.vs5)).BeginInit();
			this.tabPage6.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.vs6)).BeginInit();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage4);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Controls.Add(this.tabPage5);
			this.tabControl1.Controls.Add(this.tabPage6);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(860, 389);
			this.tabControl1.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.vs1);
			this.tabPage1.Controls.Add(this.nav1);
			this.tabPage1.Location = new System.Drawing.Point(4, 25);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Size = new System.Drawing.Size(852, 360);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Label For Message";
			// 
			// vs1
			// 
			this.vs1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.vs1.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.XpThemes;
			this.vs1.ColumnInfo = "10,1,0,0,0,100,Columns:0{Width:38;}\t";
			this.vs1.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
			this.vs1.Location = new System.Drawing.Point(8, 32);
			this.vs1.Name = "vs1";
			this.vs1.Size = new System.Drawing.Size(837, 320);
			this.vs1.Styles = ((C1.Win.C1FlexGrid.CellStyleCollection)(new C1.Win.C1FlexGrid.CellStyleCollection("")));
			this.vs1.TabIndex = 8;
			// 
			// nav1
			// 
			this.nav1.BackColor = System.Drawing.SystemColors.Control;
			this.nav1.Connection = null;
			this.nav1.ConnectionDel = null;
			this.nav1.Font = new System.Drawing.Font("Tahoma", 9.75F);
			this.nav1.form = null;
			this.nav1.FormName = null;
			this.nav1.Grid = null;
			this.nav1.History = false;
			this.nav1.IsNull = true;
			this.nav1.Language = "EN";
			this.nav1.Location = new System.Drawing.Point(4, 0);
			this.nav1.MSG_Exit = false;
			this.nav1.MulltiDel = false;
			this.nav1.Name = "nav1";
			this.nav1.Security = 0;
			this.nav1.ShowPopupMenu = false;
			this.nav1.Size = new System.Drawing.Size(408, 32);
			this.nav1.TabIndex = 7;
			this.nav1.ToolBar_Auto = true;
			this.nav1.UserID = null;
			this.nav1.VisibleGrid = true;
			this.nav1.Where = null;
			// 
			// tabPage4
			// 
			this.tabPage4.Controls.Add(this.vs4);
			this.tabPage4.Controls.Add(this.nav4);
			this.tabPage4.Location = new System.Drawing.Point(4, 25);
			this.tabPage4.Name = "tabPage4";
			this.tabPage4.Size = new System.Drawing.Size(852, 360);
			this.tabPage4.TabIndex = 3;
			this.tabPage4.Text = "Label";
			// 
			// vs4
			// 
			this.vs4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.vs4.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.XpThemes;
			this.vs4.ColumnInfo = "10,1,0,0,0,100,Columns:0{Width:38;}\t";
			this.vs4.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
			this.vs4.Location = new System.Drawing.Point(4, 32);
			this.vs4.Name = "vs4";
			this.vs4.Size = new System.Drawing.Size(845, 324);
			this.vs4.Styles = ((C1.Win.C1FlexGrid.CellStyleCollection)(new C1.Win.C1FlexGrid.CellStyleCollection("")));
			this.vs4.TabIndex = 6;
			// 
			// nav4
			// 
			this.nav4.BackColor = System.Drawing.SystemColors.Control;
			this.nav4.Connection = null;
			this.nav4.ConnectionDel = null;
			this.nav4.Font = new System.Drawing.Font("Tahoma", 9.75F);
			this.nav4.form = null;
			this.nav4.FormName = null;
			this.nav4.Grid = null;
			this.nav4.History = false;
			this.nav4.IsNull = true;
			this.nav4.Language = "EN";
			this.nav4.Location = new System.Drawing.Point(0, 0);
			this.nav4.MSG_Exit = false;
			this.nav4.MulltiDel = false;
			this.nav4.Name = "nav4";
			this.nav4.Security = 0;
			this.nav4.ShowPopupMenu = false;
			this.nav4.Size = new System.Drawing.Size(408, 32);
			this.nav4.TabIndex = 5;
			this.nav4.ToolBar_Auto = true;
			this.nav4.UserID = null;
			this.nav4.VisibleGrid = true;
			this.nav4.Where = null;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.vs2);
			this.tabPage2.Controls.Add(this.nav2);
			this.tabPage2.Location = new System.Drawing.Point(4, 25);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Size = new System.Drawing.Size(852, 360);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Label For Grid";
			// 
			// vs2
			// 
			this.vs2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.vs2.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.XpThemes;
			this.vs2.ColumnInfo = "10,1,0,0,0,100,Columns:0{Width:38;}\t";
			this.vs2.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
			this.vs2.Location = new System.Drawing.Point(8, 32);
			this.vs2.Name = "vs2";
			this.vs2.Size = new System.Drawing.Size(841, 324);
			this.vs2.Styles = ((C1.Win.C1FlexGrid.CellStyleCollection)(new C1.Win.C1FlexGrid.CellStyleCollection("")));
			this.vs2.TabIndex = 8;
			// 
			// nav2
			// 
			this.nav2.BackColor = System.Drawing.SystemColors.Control;
			this.nav2.Connection = null;
			this.nav2.ConnectionDel = null;
			this.nav2.Font = new System.Drawing.Font("Tahoma", 9.75F);
			this.nav2.form = null;
			this.nav2.FormName = null;
			this.nav2.Grid = null;
			this.nav2.History = false;
			this.nav2.IsNull = true;
			this.nav2.Language = "EN";
			this.nav2.Location = new System.Drawing.Point(4, 0);
			this.nav2.MSG_Exit = false;
			this.nav2.MulltiDel = false;
			this.nav2.Name = "nav2";
			this.nav2.Security = 0;
			this.nav2.ShowPopupMenu = false;
			this.nav2.Size = new System.Drawing.Size(408, 32);
			this.nav2.TabIndex = 7;
			this.nav2.ToolBar_Auto = true;
			this.nav2.UserID = null;
			this.nav2.VisibleGrid = true;
			this.nav2.Where = null;
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.vs3);
			this.tabPage3.Controls.Add(this.nav3);
			this.tabPage3.Location = new System.Drawing.Point(4, 25);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Size = new System.Drawing.Size(852, 360);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "Label For Menu(report)";
			// 
			// vs3
			// 
			this.vs3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.vs3.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.XpThemes;
			this.vs3.ColumnInfo = "10,1,0,0,0,100,Columns:0{Width:38;}\t";
			this.vs3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.vs3.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
			this.vs3.Location = new System.Drawing.Point(8, 32);
			this.vs3.Name = "vs3";
			this.vs3.Size = new System.Drawing.Size(841, 324);
			this.vs3.Styles = ((C1.Win.C1FlexGrid.CellStyleCollection)(new C1.Win.C1FlexGrid.CellStyleCollection("")));
			this.vs3.TabIndex = 8;
			// 
			// nav3
			// 
			this.nav3.BackColor = System.Drawing.SystemColors.Control;
			this.nav3.Connection = null;
			this.nav3.ConnectionDel = null;
			this.nav3.Font = new System.Drawing.Font("Tahoma", 9.75F);
			this.nav3.form = null;
			this.nav3.FormName = null;
			this.nav3.Grid = null;
			this.nav3.History = false;
			this.nav3.IsNull = true;
			this.nav3.Language = "EN";
			this.nav3.Location = new System.Drawing.Point(4, 0);
			this.nav3.MSG_Exit = false;
			this.nav3.MulltiDel = false;
			this.nav3.Name = "nav3";
			this.nav3.Security = 0;
			this.nav3.ShowPopupMenu = false;
			this.nav3.Size = new System.Drawing.Size(408, 32);
			this.nav3.TabIndex = 7;
			this.nav3.ToolBar_Auto = true;
			this.nav3.UserID = null;
			this.nav3.VisibleGrid = true;
			this.nav3.Where = null;
			// 
			// tabPage5
			// 
			this.tabPage5.Controls.Add(this.vs5);
			this.tabPage5.Controls.Add(this.nav5);
			this.tabPage5.Location = new System.Drawing.Point(4, 25);
			this.tabPage5.Name = "tabPage5";
			this.tabPage5.Size = new System.Drawing.Size(852, 360);
			this.tabPage5.TabIndex = 4;
			this.tabPage5.Text = "Label for RPT";
			// 
			// vs5
			// 
			this.vs5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.vs5.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.XpThemes;
			this.vs5.ColumnInfo = "10,1,0,0,0,100,Columns:0{Width:38;}\t";
			this.vs5.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
			this.vs5.Location = new System.Drawing.Point(6, 34);
			this.vs5.Name = "vs5";
			this.vs5.Size = new System.Drawing.Size(845, 324);
			this.vs5.Styles = ((C1.Win.C1FlexGrid.CellStyleCollection)(new C1.Win.C1FlexGrid.CellStyleCollection("")));
			this.vs5.TabIndex = 8;
			// 
			// nav5
			// 
			this.nav5.BackColor = System.Drawing.SystemColors.Control;
			this.nav5.Connection = null;
			this.nav5.ConnectionDel = null;
			this.nav5.Font = new System.Drawing.Font("Tahoma", 9.75F);
			this.nav5.form = null;
			this.nav5.FormName = null;
			this.nav5.Grid = null;
			this.nav5.History = false;
			this.nav5.IsNull = true;
			this.nav5.Language = "EN";
			this.nav5.Location = new System.Drawing.Point(2, 2);
			this.nav5.MSG_Exit = false;
			this.nav5.MulltiDel = false;
			this.nav5.Name = "nav5";
			this.nav5.Security = 0;
			this.nav5.ShowPopupMenu = false;
			this.nav5.Size = new System.Drawing.Size(408, 32);
			this.nav5.TabIndex = 7;
			this.nav5.ToolBar_Auto = true;
			this.nav5.UserID = null;
			this.nav5.VisibleGrid = true;
			this.nav5.Where = null;
			// 
			// tabPage6
			// 
			this.tabPage6.Controls.Add(this.vs6);
			this.tabPage6.Controls.Add(this.nav6);
			this.tabPage6.Location = new System.Drawing.Point(4, 25);
			this.tabPage6.Name = "tabPage6";
			this.tabPage6.Size = new System.Drawing.Size(852, 360);
			this.tabPage6.TabIndex = 5;
			this.tabPage6.Text = "Label For PMenu";
			// 
			// vs6
			// 
			this.vs6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.vs6.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.XpThemes;
			this.vs6.ColumnInfo = "10,1,0,0,0,100,Columns:0{Width:38;}\t";
			this.vs6.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
			this.vs6.Location = new System.Drawing.Point(6, 34);
			this.vs6.Name = "vs6";
			this.vs6.Size = new System.Drawing.Size(845, 324);
			this.vs6.Styles = ((C1.Win.C1FlexGrid.CellStyleCollection)(new C1.Win.C1FlexGrid.CellStyleCollection("")));
			this.vs6.TabIndex = 8;
			// 
			// nav6
			// 
			this.nav6.BackColor = System.Drawing.SystemColors.Control;
			this.nav6.Connection = null;
			this.nav6.ConnectionDel = null;
			this.nav6.Font = new System.Drawing.Font("Tahoma", 9.75F);
			this.nav6.form = null;
			this.nav6.FormName = null;
			this.nav6.Grid = null;
			this.nav6.History = false;
			this.nav6.IsNull = true;
			this.nav6.Language = "EN";
			this.nav6.Location = new System.Drawing.Point(2, 2);
			this.nav6.MSG_Exit = false;
			this.nav6.MulltiDel = false;
			this.nav6.Name = "nav6";
			this.nav6.Security = 0;
			this.nav6.ShowPopupMenu = false;
			this.nav6.Size = new System.Drawing.Size(408, 32);
			this.nav6.TabIndex = 7;
			this.nav6.ToolBar_Auto = true;
			this.nav6.UserID = null;
			this.nav6.VisibleGrid = true;
			this.nav6.Where = null;
			// 
			// frmLabel
			// 
			this.AutoScale = false;
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
			this.ClientSize = new System.Drawing.Size(860, 389);
			this.Controls.Add(this.tabControl1);
			this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "frmLabel";
			this.Text = "Label";
			this.Load += new System.EventHandler(this.frmLabel_Load);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.vs1)).EndInit();
			this.tabPage4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.vs4)).EndInit();
			this.tabPage2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.vs2)).EndInit();
			this.tabPage3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.vs3)).EndInit();
			this.tabPage5.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.vs5)).EndInit();
			this.tabPage6.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.vs6)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void frmLabel_Load(object sender, System.EventArgs e)
		{
			nav1.cmd_search.Visible=false;
			nav1.cmd_report.Visible=false;			
			nav1.Grid=vs1;			
			nav1.FormName=this.Name+"_vs1";
			nav1.Connection=PublicFunction.C_con;			
			nav1.Init_Control();			
			nav1.Init_PMenu_Color();
			nav1.Show_VS();


			nav2.cmd_search.Visible=false;
			nav2.cmd_report.Visible=false;			
			nav2.Grid=vs2;			
			nav2.FormName=this.Name+"_vs2";
			nav2.Connection=PublicFunction.C_con;			
			nav2.Init_Control();						
			nav2.Init_PMenu_Color();
			nav2.Show_VS(LB);

			nav3.cmd_search.Visible=false;
			nav3.cmd_report.Visible=false;			
			nav3.Grid=vs3;			
			nav3.FormName=this.Name+"_vs3";
			nav3.Connection=PublicFunction.C_con;			
			nav3.Init_Control();						
			nav3.Init_PMenu_Color();
			nav3.Show_VS();

			nav4.cmd_search.Visible=false;
			nav4.cmd_report.Visible=false;			
			nav4.Grid=vs4;			
			nav4.FormName=this.Name+"_vs4";
			nav4.Connection=PublicFunction.C_con;			
			nav4.Init_Control();						
			nav4.Init_PMenu_Color();
			nav4.Show_VS(LB);
			for(int i=4;i<vs2.Cols.Count-1;i++)
			{
				vs2.Cols[i].Width=500;
//				vs2.AllowResizing();
				vs2.AutoSizeRows();				
				
			}
			for(int i=4;i<vs1.Cols.Count-1;i++)
			{
				vs1.Cols[i].Width=500;
				vs1.AutoSizeRows();
			}
			for(int i=4;i<vs4.Cols.Count-1;i++)
			{
				vs4.Cols[i].Width=500;
//				vs4.AllowResizing();
				vs4.AutoSizeRows();
			}
		//			nav5.cmd_search.Visible=false;
		//			nav5.cmd_report.Visible=false;			
		//			nav5.Grid=vs5;			
		//			nav5.FormName=this.Name+"_vs5";
		//			nav5.Connection=PublicFunction.C_con;
		//			
		////			nav5.Init_Control();						
		////			nav5.Init_PMenu_Color();
		////			nav5.Show_VS(RPT);
		//
		//			nav6.cmd_search.Visible=false;
		//			nav6.cmd_report.Visible=false;			
		//			nav6.Grid=vs6;			
		//			nav6.FormName=this.Name+"_vs6";
		//			nav6.Connection=PublicFunction.C_con;			
		//			nav6.Init_Control();						
		//			nav6.Init_PMenu_Color();
		//			nav6.Show_VS(PMENU);


	}
	}
}
