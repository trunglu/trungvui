using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using Basic.Function;

namespace Basic.Form
{
	/// <summary>
	/// Summary description for frmControlTable.
	/// </summary>
	public class frmControlTable : System.Windows.Forms.Form
	{
		private C1.Win.C1Command.C1CommandDock c1CommandDock1;
		private C1.Win.C1Command.C1DockingTab c1DockingTab1;
		private C1.Win.C1Command.C1DockingTabPage c1DockingTabPage1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private Navigator1._0.NavigatorAuto nav2;		
		private C1.Win.C1Command.C1DockingTabPage c1DockingTabPage2;
		private System.Windows.Forms.TreeView tree;
		private Navigator1._0.NavigatorAuto nav1;
		private C1.Win.C1FlexGrid.C1FlexGrid vs1;
		private C1.Win.C1FlexGrid.C1FlexGrid vs;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Button button1;
		private C1.Win.C1Command.C1CommandDock c1CommandDock2;
		private C1.Win.C1Command.C1DockingTab c1DockingTab2;
		private C1.Win.C1Command.C1DockingTabPage c1DockingTabPage3;
		private Navigator1._0.NavigatorAuto nav3;
		private System.Windows.Forms.Panel panel4;
		private C1.Win.C1FlexGrid.C1FlexGrid vs2;		
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmControlTable()
		{
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
			this.c1CommandDock1 = new C1.Win.C1Command.C1CommandDock();
			this.c1DockingTab1 = new C1.Win.C1Command.C1DockingTab();
			this.c1DockingTabPage1 = new C1.Win.C1Command.C1DockingTabPage();
			this.panel2 = new System.Windows.Forms.Panel();
			this.vs = new C1.Win.C1FlexGrid.C1FlexGrid();
			this.nav1 = new Navigator1._0.NavigatorAuto();
			this.c1DockingTabPage2 = new C1.Win.C1Command.C1DockingTabPage();
			this.tree = new System.Windows.Forms.TreeView();
			this.nav2 = new Navigator1._0.NavigatorAuto();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.vs1 = new C1.Win.C1FlexGrid.C1FlexGrid();
			this.button1 = new System.Windows.Forms.Button();
			this.c1CommandDock2 = new C1.Win.C1Command.C1CommandDock();
			this.c1DockingTab2 = new C1.Win.C1Command.C1DockingTab();
			this.c1DockingTabPage3 = new C1.Win.C1Command.C1DockingTabPage();
			this.vs2 = new C1.Win.C1FlexGrid.C1FlexGrid();
			this.nav3 = new Navigator1._0.NavigatorAuto();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandDock1)).BeginInit();
			this.c1CommandDock1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.c1DockingTab1)).BeginInit();
			this.c1DockingTab1.SuspendLayout();
			this.c1DockingTabPage1.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.vs)).BeginInit();
			this.c1DockingTabPage2.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.vs1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandDock2)).BeginInit();
			this.c1CommandDock2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.c1DockingTab2)).BeginInit();
			this.c1DockingTab2.SuspendLayout();
			this.c1DockingTabPage3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.vs2)).BeginInit();
			this.SuspendLayout();
			// 
			// c1CommandDock1
			// 
			this.c1CommandDock1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.c1CommandDock1.Controls.Add(this.c1DockingTab1);
			this.c1CommandDock1.Dock = System.Windows.Forms.DockStyle.Left;
			this.c1CommandDock1.Id = 1;
			this.c1CommandDock1.Location = new System.Drawing.Point(0, 0);
			this.c1CommandDock1.Name = "c1CommandDock1";
			this.c1CommandDock1.Size = new System.Drawing.Size(292, 506);
			// 
			// c1DockingTab1
			// 
			this.c1DockingTab1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
			this.c1DockingTab1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.c1DockingTab1.CanAutoHide = true;
			this.c1DockingTab1.CanMoveTabs = true;
			this.c1DockingTab1.Controls.Add(this.c1DockingTabPage1);
			this.c1DockingTab1.Controls.Add(this.c1DockingTabPage2);
			this.c1DockingTab1.Location = new System.Drawing.Point(0, 0);
			this.c1DockingTab1.Name = "c1DockingTab1";
			this.c1DockingTab1.SelectedIndex = 2;
			this.c1DockingTab1.ShowCaption = true;
			this.c1DockingTab1.Size = new System.Drawing.Size(290, 504);
			this.c1DockingTab1.TabIndex = 0;
			this.c1DockingTab1.TabSizeMode = C1.Win.C1Command.TabSizeModeEnum.User;
			this.c1DockingTab1.TabStyle = C1.Win.C1Command.TabStyleEnum.WindowsXP;
			// 
			// c1DockingTabPage1
			// 
			this.c1DockingTabPage1.Controls.Add(this.panel2);
			this.c1DockingTabPage1.ImageIndex = -1;
			this.c1DockingTabPage1.Location = new System.Drawing.Point(0, 0);
			this.c1DockingTabPage1.Name = "c1DockingTabPage1";
			this.c1DockingTabPage1.Size = new System.Drawing.Size(287, 477);
			this.c1DockingTabPage1.TabIndex = 0;
			this.c1DockingTabPage1.Text = "From_Table";
			// 
			// panel2
			// 
			this.panel2.AutoScroll = true;
			this.panel2.Controls.Add(this.vs);
			this.panel2.Controls.Add(this.nav1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 23);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(287, 454);
			this.panel2.TabIndex = 0;
			// 
			// vs
			// 
			this.vs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.vs.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.XpThemes;
			this.vs.ColumnInfo = "10,1,0,0,0,100,Columns:0{Width:38;}\t";
			this.vs.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
			this.vs.Location = new System.Drawing.Point(8, 32);
			this.vs.Name = "vs";
			this.vs.Size = new System.Drawing.Size(272, 416);
			this.vs.Styles = ((C1.Win.C1FlexGrid.CellStyleCollection)(new C1.Win.C1FlexGrid.CellStyleCollection("")));
			this.vs.TabIndex = 11;
			this.vs.AfterRowColChange += new C1.Win.C1FlexGrid.RangeEventHandler(this.vs_AfterRowColChange);
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
			this.nav1.Location = new System.Drawing.Point(8, 0);
			this.nav1.MSG_Exit = false;
			this.nav1.MulltiDel = false;
			this.nav1.Name = "nav1";
			this.nav1.Security = 0;
			this.nav1.ShowPopupMenu = false;
			this.nav1.Size = new System.Drawing.Size(278, 32);
			this.nav1.TabIndex = 10;
			this.nav1.ToolBar_Auto = true;
			this.nav1.UserID = null;
			this.nav1.VisibleGrid = true;
			this.nav1.Where = null;
			// 
			// c1DockingTabPage2
			// 
			this.c1DockingTabPage2.Controls.Add(this.tree);
			this.c1DockingTabPage2.ImageIndex = -1;
			this.c1DockingTabPage2.Location = new System.Drawing.Point(0, 0);
			this.c1DockingTabPage2.Name = "c1DockingTabPage2";
			this.c1DockingTabPage2.Size = new System.Drawing.Size(287, 477);
			this.c1DockingTabPage2.TabIndex = 1;
			this.c1DockingTabPage2.Text = "Table_Field";
			// 
			// tree
			// 
			this.tree.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.tree.ImageIndex = -1;
			this.tree.Location = new System.Drawing.Point(0, 47);
			this.tree.Name = "tree";
			this.tree.SelectedImageIndex = -1;
			this.tree.Size = new System.Drawing.Size(288, 430);
			this.tree.TabIndex = 0;
			this.tree.DoubleClick += new System.EventHandler(this.tree_DoubleClick);
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
			this.nav2.Location = new System.Drawing.Point(4, 4);
			this.nav2.MSG_Exit = false;
			this.nav2.MulltiDel = true;
			this.nav2.Name = "nav2";
			this.nav2.Security = 0;
			this.nav2.ShowPopupMenu = false;
			this.nav2.Size = new System.Drawing.Size(320, 32);
			this.nav2.TabIndex = 9;
			this.nav2.ToolBar_Auto = true;
			this.nav2.UserID = null;
			this.nav2.VisibleGrid = true;
			this.nav2.Where = null;
			this.nav2.TBarClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.nav2_TBarClick);
			// 
			// panel1
			// 
			this.panel1.AutoScroll = true;
			this.panel1.Controls.Add(this.panel3);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(292, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(680, 506);
			this.panel1.TabIndex = 11;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.panel4);
			this.panel3.Controls.Add(this.c1CommandDock2);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel3.Location = new System.Drawing.Point(0, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(680, 506);
			this.panel3.TabIndex = 11;
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.vs1);
			this.panel4.Controls.Add(this.button1);
			this.panel4.Controls.Add(this.nav2);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel4.Location = new System.Drawing.Point(0, 0);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(236, 506);
			this.panel4.TabIndex = 1;
			// 
			// vs1
			// 
			this.vs1.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.Both;
			this.vs1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.vs1.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.XpThemes;
			this.vs1.ColumnInfo = "10,1,0,0,0,100,Columns:0{Width:38;}\t";
			this.vs1.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
			this.vs1.Location = new System.Drawing.Point(4, 36);
			this.vs1.Name = "vs1";
			this.vs1.Size = new System.Drawing.Size(232, 468);
			this.vs1.Styles = ((C1.Win.C1FlexGrid.CellStyleCollection)(new C1.Win.C1FlexGrid.CellStyleCollection("")));
			this.vs1.TabIndex = 10;
			this.vs1.DoubleClick += new System.EventHandler(this.vs1_DoubleClick);
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button1.Location = new System.Drawing.Point(144, 4);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(88, 28);
			this.button1.TabIndex = 11;
			this.button1.Tag = "N";
			this.button1.Text = "Show";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// c1CommandDock2
			// 
			this.c1CommandDock2.Controls.Add(this.c1DockingTab2);
			this.c1CommandDock2.Dock = System.Windows.Forms.DockStyle.Right;
			this.c1CommandDock2.Id = 2;
			this.c1CommandDock2.Location = new System.Drawing.Point(236, 0);
			this.c1CommandDock2.Name = "c1CommandDock2";
			this.c1CommandDock2.Size = new System.Drawing.Size(444, 506);
			// 
			// c1DockingTab2
			// 
			this.c1DockingTab2.Alignment = System.Windows.Forms.TabAlignment.Bottom;
			this.c1DockingTab2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.c1DockingTab2.CanAutoHide = true;
			this.c1DockingTab2.CanMoveTabs = true;
			this.c1DockingTab2.Controls.Add(this.c1DockingTabPage3);
			this.c1DockingTab2.Location = new System.Drawing.Point(0, 0);
			this.c1DockingTab2.Name = "c1DockingTab2";
			this.c1DockingTab2.SelectedIndex = 0;
			this.c1DockingTab2.ShowCaption = true;
			this.c1DockingTab2.ShowSingleTab = false;
			this.c1DockingTab2.Size = new System.Drawing.Size(444, 506);
			this.c1DockingTab2.TabIndex = 0;
			this.c1DockingTab2.TabSizeMode = C1.Win.C1Command.TabSizeModeEnum.Fit;
			this.c1DockingTab2.TabStyle = C1.Win.C1Command.TabStyleEnum.WindowsXP;
			// 
			// c1DockingTabPage3
			// 
			this.c1DockingTabPage3.Controls.Add(this.vs2);
			this.c1DockingTabPage3.Controls.Add(this.nav3);
			this.c1DockingTabPage3.ImageIndex = -1;
			this.c1DockingTabPage3.Location = new System.Drawing.Point(4, 1);
			this.c1DockingTabPage3.Name = "c1DockingTabPage3";
			this.c1DockingTabPage3.Size = new System.Drawing.Size(439, 504);
			this.c1DockingTabPage3.TabIndex = 0;
			this.c1DockingTabPage3.Text = "Page3";
			// 
			// vs2
			// 
			this.vs2.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.Both;
			this.vs2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.vs2.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.XpThemes;
			this.vs2.ColumnInfo = "10,1,0,0,0,100,Columns:0{Width:38;}\t";
			this.vs2.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
			this.vs2.Location = new System.Drawing.Point(4, 76);
			this.vs2.Name = "vs2";
			this.vs2.Size = new System.Drawing.Size(432, 428);
			this.vs2.Styles = ((C1.Win.C1FlexGrid.CellStyleCollection)(new C1.Win.C1FlexGrid.CellStyleCollection("")));
			this.vs2.TabIndex = 12;
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
			this.nav3.Location = new System.Drawing.Point(4, 24);
			this.nav3.MSG_Exit = false;
			this.nav3.MulltiDel = false;
			this.nav3.Name = "nav3";
			this.nav3.Security = 0;
			this.nav3.ShowPopupMenu = false;
			this.nav3.Size = new System.Drawing.Size(278, 32);
			this.nav3.TabIndex = 11;
			this.nav3.ToolBar_Auto = true;
			this.nav3.UserID = null;
			this.nav3.VisibleGrid = true;
			this.nav3.Where = null;
			// 
			// frmControlTable
			// 
			this.AutoScale = false;
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
			this.AutoScroll = true;
			this.ClientSize = new System.Drawing.Size(972, 506);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.c1CommandDock1);
			this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "frmControlTable";
			this.Text = "frmControlTable";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.frmControlTable_Load);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandDock1)).EndInit();
			this.c1CommandDock1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.c1DockingTab1)).EndInit();
			this.c1DockingTab1.ResumeLayout(false);
			this.c1DockingTabPage1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.vs)).EndInit();
			this.c1DockingTabPage2.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.vs1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandDock2)).EndInit();
			this.c1CommandDock2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.c1DockingTab2)).EndInit();
			this.c1DockingTab2.ResumeLayout(false);
			this.c1DockingTabPage3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.vs2)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void frmControlTable_Load(object sender, System.EventArgs e)
		{
			Func.Fun.ExecuteSQL("Delete from SYS_SQL_SELECT where [ID] not in(Select ID from SYS_SQL_FROM)",PublicFunction.C_con,true);
			nav2.cmd_search.Visible=false;
			nav2.cmd_report.Visible=false;
			nav2.cmd_copy.Visible=false;

			nav2.Grid=vs1;			
			nav2.FormName=this.Name+"_vs1";
			nav2.Connection=Function.PublicFunction.C_con;
			
			nav2.Init_Control();
			nav2.ToolBar_Auto=false;
			nav2.form=this;

			nav1.cmd_search.Visible=false;
			nav1.cmd_report.Visible=false;
			nav1.cmd_copy.Visible=false;
			nav1.Grid=vs;			
			nav1.FormName=this.Name+"_vs";
			nav1.Connection=Function.PublicFunction.C_con;			
			
			nav1.Init_Control();
			nav1.Show_VS();
			Show_VS1();


			nav3.cmd_copy.Visible=false;
			nav3.cmd_report.Visible=false;
			nav3.cmd_search.Visible=false;			
			nav3.Grid=vs2;
			nav3.FormName=this.Name+"_vs2";
			nav3.Connection=Function.PublicFunction.C_con;		
			nav3.Init_Control();
			nav3.ToolBar_Auto=false;
			nav3.TBarClick+=new ToolBarButtonClickEventHandler(nav3_TBarClick);
			vs2.AfterEdit+=new C1.Win.C1FlexGrid.RowColEventHandler(vs2_AfterEdit);

			//PublicFunction.L_Init_Label(this);
			nav1.Init_PMenu_Color();
			nav2.Init_PMenu_Color();				

			Init_Tree();
		
			c1DockingTab1.SelectedIndex=0;
			
		}

		private void Show_VS1()
		{
			if (vs.Row>0 && nav1.State)
			{						
				nav2.Show_VS("[ID]=N'"+vs.Rows[vs.Row]["ID"]+"' ORDER BY SEQ");
			}
		}

		private void vs_AfterRowColChange(object sender, C1.Win.C1FlexGrid.RangeEventArgs e)
		{
			if (e.OldRange.r1!=e.NewRange.r2)
			{				
				Show_VS1();
			}
		}

		private void Init_Tree()
		{
			string sql;
			TreeNode node,node1;
			sql = "SELECT [id],[name] From sysobjects where [xtype]=N'U' order by [name]";							
			Func.RecordSet rs=new Func.RecordSet(sql,Function.PublicFunction.C_con);
			Func.RecordSet rs1;
			for (int i=0;i<rs.rows;i++)
			{
				node=new TreeNode(rs.record(i,1));
				sql = "SELECT c.[name] FROM syscolumns c INNER JOIN systypes ty ON c.xtype = ty.xtype"+
						" WHERE (ty.name <> N'sysname') and c.id="+rs.record(i,0) + " Order By c.[colid]";
				rs1=new Func.RecordSet(sql,Function.PublicFunction.C_con);
				for (int j=0;j<rs1.rows;j++)
				{
					node1=new TreeNode(rs1.record(j,0));
					node.Nodes.Add(node1);
				}
				tree.Nodes.Add(node);
			}

		}

		private void tree_DoubleClick(object sender, System.EventArgs e)
		{
			nav2.ToolBar_Click(new ToolBarButtonClickEventArgs(nav2.cmd_add));
			vs1.Rows[vs1.Rows.Count-1]["ID1"]=max()+1;					
			vs1.Rows[vs1.Rows.Count-1]["ID"]=vs.Rows[vs.Row]["ID"];
			vs1.Rows[vs1.Rows.Count-1]["NAME"]=tree.SelectedNode.Text;
			vs1.Rows[vs1.Rows.Count-1]["FIELD"]=tree.SelectedNode.Text;			
		}

		private int max()
		{
			int m;			
			m=0;
			for (int i=1;i<vs1.Rows.Count-1;i++)
			{
				if (Function.T_String.IsNullTo0(vs1.GetData(i,"ID1").ToString())>m)
					m=Function.T_String.IsNullTo0(vs1.GetData(i,"ID1").ToString());
			}						
			return m;
		}

		private void nav2_TBarClick(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
		{
			if (e.Button.Equals(nav2.cmd_save))
			{
				for (int i=1;i<vs1.Rows.Count;i++)
				{
					vs1.Rows[i]["SEQ"]=i;
					if (vs1.Rows[i].UserData+""!="2")
						vs1.Rows[i].UserData=1;
				}
			}
			nav2.ToolBar_Click(e);
			if (e.Button.Equals(nav2.cmd_add))
			{
				vs1.Rows[vs1.Rows.Count-1]["ID1"]=max()+1;					
				vs1.Rows[vs1.Rows.Count-1]["ID"]=vs.Rows[vs.Row]["ID"];					
			}
		}

		private void vs1_DoubleClick(object sender, System.EventArgs e)
		{
			if(vs1.Row>0)
			{			
				nav3.ToolBar_Click(new ToolBarButtonClickEventArgs(nav3.cmd_add));
				int m=T_String.GetMax("MAX(ID)","SYS_LABEL_VS","NAME=N'"+vs1.Rows[vs1.Row]["ID"]+"'");
				if(vs1.Rows.Count-2>0)
				{
					if(m<=T_String.IsNullTo0(vs2.Rows[vs2.Rows.Count-2]["ID"]+""))
						m=T_String.IsNullTo0(vs2.Rows[vs2.Rows.Count-2]["ID"]+"")+1;
				}
				vs2.Rows[vs2.Rows.Count-1]["ID"]=m;			
				vs2.Rows[vs2.Rows.Count-1]["NAME"]=vs1.Rows[vs1.Row]["ID"];			
				vs2.Rows[vs2.Rows.Count-1]["FNAME"]=vs1.Rows[vs1.Row]["NAME"];	
				vs2.AutoSizeCols();
			}
		}

		private void button1_Click(object sender, System.EventArgs e)
		{			
			if(vs1.Row<=0)
			{	
				vs2.Rows.Count=1;
				return;
			}
			nav3.Show_VS("NAME=N'"+vs1.Rows[vs1.Row]["ID"]+"'");
		}
		private void nav3_TBarClick(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
		{		
			if(vs1.Row>0)
			{
				nav3.ToolBar_Click(e);
				if (e.Button.Equals(nav3.cmd_add))
				{
					int m=T_String.GetMax("MAX(ID)","SYS_LABEL_VS","NAME=N'"+vs1.Rows[vs1.Row]["ID"]+"'");
					if(vs1.Rows.Count-2>0)
					{
						if(m<=T_String.IsNullTo0(vs2.Rows[vs2.Rows.Count-2]["ID"]+""))
							m=T_String.IsNullTo0(vs2.Rows[vs2.Rows.Count-2]["ID"]+"")+1;
					}
					vs2.Rows[vs2.Rows.Count-1]["ID"]=m;
					vs2.Rows[vs2.Rows.Count-1]["NAME"]=vs1.Rows[vs1.Row]["ID"];			
				}
			}
		}

		private void vs2_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			vs2.AutoSizeCols();
		}
	}
}
