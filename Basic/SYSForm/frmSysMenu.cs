using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using Basic.Function;

namespace Basic.Form
{
	/// <summary>
	/// Summary description for frmSysMenu.
	/// </summary>
	public class frmSysMenu : System.Windows.Forms.Form
	{
		private System.Windows.Forms.TreeView Tree;
		private Navigator1._0.NavigatorAuto nav1;
		private System.Windows.Forms.Button cmd_sys;
		private System.Windows.Forms.Button cmd_ref;
		private C1.Win.C1FlexGrid.C1FlexGrid vs;
		private System.Windows.Forms.Button cmd_label;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmSysMenu()
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
			this.Tree = new System.Windows.Forms.TreeView();
			this.vs = new C1.Win.C1FlexGrid.C1FlexGrid();
			this.nav1 = new Navigator1._0.NavigatorAuto();
			this.cmd_sys = new System.Windows.Forms.Button();
			this.cmd_ref = new System.Windows.Forms.Button();
			this.cmd_label = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.vs)).BeginInit();
			this.SuspendLayout();
			// 
			// Tree
			// 
			this.Tree.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left)));
			this.Tree.ImageIndex = -1;
			this.Tree.Location = new System.Drawing.Point(8, 32);
			this.Tree.Name = "Tree";
			this.Tree.SelectedImageIndex = -1;
			this.Tree.Size = new System.Drawing.Size(208, 368);
			this.Tree.TabIndex = 0;
			this.Tree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.Tree_AfterSelect);
			// 
			// vs
			// 
			this.vs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.vs.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.XpThemes;
			this.vs.ColumnInfo = "10,1,0,0,0,100,Columns:0{Width:38;}\t";
			this.vs.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
			this.vs.Location = new System.Drawing.Point(224, 32);
			this.vs.Name = "vs";
			this.vs.Size = new System.Drawing.Size(372, 368);
			this.vs.Styles = ((C1.Win.C1FlexGrid.CellStyleCollection)(new C1.Win.C1FlexGrid.CellStyleCollection("")));
			this.vs.TabIndex = 2;
			// 
			// nav1
			// 
			this.nav1.BackColor = System.Drawing.SystemColors.Control;
			this.nav1.Connection = null;
			this.nav1.ConnectionDel = null;
			this.nav1.Font = new System.Drawing.Font("Tahoma", 9.75F);
			this.nav1.FormName = null;
			this.nav1.Grid = null;
			this.nav1.Location = new System.Drawing.Point(220, 0);
			this.nav1.Name = "nav1";
			this.nav1.Security = 0;
			this.nav1.Size = new System.Drawing.Size(408, 32);
			this.nav1.TabIndex = 4;
			this.nav1.ToolBar_Auto = true;
			this.nav1.UserID = null;
			this.nav1.Where = null;
			this.nav1.TBarClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.nav1_TBarClick);
			// 
			// cmd_sys
			// 
			this.cmd_sys.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_sys.Location = new System.Drawing.Point(8, 3);
			this.cmd_sys.Name = "cmd_sys";
			this.cmd_sys.Size = new System.Drawing.Size(64, 28);
			this.cmd_sys.TabIndex = 5;
			this.cmd_sys.Text = "System";
			this.cmd_sys.Click += new System.EventHandler(this.cmd_sys_Click);
			// 
			// cmd_ref
			// 
			this.cmd_ref.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_ref.Location = new System.Drawing.Point(152, 3);
			this.cmd_ref.Name = "cmd_ref";
			this.cmd_ref.Size = new System.Drawing.Size(64, 28);
			this.cmd_ref.TabIndex = 6;
			this.cmd_ref.Text = "Refresh";
			this.cmd_ref.Click += new System.EventHandler(this.button1_Click);
			// 
			// cmd_label
			// 
			this.cmd_label.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_label.Location = new System.Drawing.Point(81, 3);
			this.cmd_label.Name = "cmd_label";
			this.cmd_label.Size = new System.Drawing.Size(64, 28);
			this.cmd_label.TabIndex = 7;
			this.cmd_label.Tag = "N";
			this.cmd_label.Text = "Label";
			this.cmd_label.Click += new System.EventHandler(this.cmd_label_Click);
			// 
			// frmSysMenu
			// 
			this.AutoScale = false;
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
			this.ClientSize = new System.Drawing.Size(603, 404);
			this.Controls.Add(this.cmd_label);
			this.Controls.Add(this.cmd_ref);
			this.Controls.Add(this.cmd_sys);
			this.Controls.Add(this.nav1);
			this.Controls.Add(this.vs);
			this.Controls.Add(this.Tree);
			this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "frmSysMenu";
			this.Text = "frmSysMenu";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.frmSysMenu_Load);
			this.Closed += new System.EventHandler(this.frmSysMenu_Closed);
			((System.ComponentModel.ISupportInitialize)(this.vs)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void frmSysMenu_Load(object sender, System.EventArgs e)
		{	
			nav1.Grid=vs;			
			nav1.FormName=this.Name+"_vs";
			nav1.Connection=Function.PublicFunction.C_con;
			nav1.ConnectionDel=Function.PublicFunction.C_condel;
			nav1.UserID=Function.PublicFunction.A_UserID;
			nav1.Init_Control();
			nav1.Show_VS();
			nav1.form=this;			
			PublicFunction.L_Init_Label(this);

			TreeNode node=new TreeNode("Root");
			Tree.Nodes.Add (node);
			Init_Tree(node,-1);				
			Tree.SelectedNode=node;
		}

		private void Init_Tree(TreeNode root,int ID)
		{
			Func.RecordSet rs=new Func.RecordSet("Select * from SYS_MENU where H_ID="+ID+" ORDER BY SEQ",Function.PublicFunction.C_con);
			TreeNode node;
			for (int i=0; i<rs.rows;i++)
			{
				node=new TreeNode(rs.record(i,"ID")+"-"+rs.record(i,PublicFunction.L_Lag));
				root.Nodes.Add(node);
				Init_Tree(node,Function.T_String.IsNullTo0(rs.record(i,"ID")));
			}
		}

		private void Tree_AfterSelect(object sender, System.Windows.Forms.TreeViewEventArgs e)
		{
			if (e.Node.Text!="Root")
				nav1.Show_VS("H_ID="+T_String.Left(e.Node.Text,"-"));
			else
				nav1.Show_VS("H_ID=-1");
		}

		private void nav1_TBarClick(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
		{
			try
			{
				if (e.Button.Equals(nav1.cmd_add))
				{
					string st;
					if (Tree.SelectedNode.Text!="Root")
						st=T_String.Left(Tree.SelectedNode.Text,"-");
					else
						st="-1";
					vs.Rows[vs.Rows.Count-1]["H_ID"]=st;
					vs.Rows[vs.Rows.Count-1]["ID"]=Get_ID();
				}		
				if (e.Button.Equals(nav1.cmd_report))
				{
					ArrayList arColsVisible = new ArrayList();
					for (int i=0; i<vs.Cols.Count ; i++)
						arColsVisible.Add(vs.Cols[i].Visible );
					Basic.Function.ReportExcel.ExportToExcel_FromVS(vs, arColsVisible);
				}
			}
			catch(Exception){}
		}

		private int Get_ID()
		{
			int k;
			Func.RecordSet rs=new Func.RecordSet("Select Count(*) from SYS_MENU",PublicFunction.C_con);
			if (rs.rows>0)
				k=T_String.IsNullTo0(rs.record(0,0));
			else
				k=0;
			for (int i=1;i<=k;i++)
			{
				rs=new Func.RecordSet("Select * from SYS_MENU where ID="+i,PublicFunction.C_con);
				if (rs.rows<=0)
					return i;
			}
			return -1;
		
		}

		private void frmSysMenu_Closed(object sender, System.EventArgs e)
		{
			nav1.Save_SEQ();
		}

		private void cmd_sys_Click(object sender, System.EventArgs e)
		{
			frmSYS_System dlg=new frmSYS_System ();
			dlg.ShowDialog();
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			Tree.Nodes.Clear();
			TreeNode node=new TreeNode("Root");
			Tree.Nodes.Add (node);
			Init_Tree(node,-1);				
			Tree.SelectedNode=node;
		}

		private void cmd_label_Click(object sender, System.EventArgs e)
		{
			frmLabel dlg=new frmLabel();
			dlg.ShowDialog();
		}
	}
}
