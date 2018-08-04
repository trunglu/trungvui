using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using Basic.Form;
using Basic.Function;
using System.IO;
using System.Diagnostics;
using System.Threading;
using System.Data;
using System.Data.SqlClient;
using C1.Win.C1FlexGrid;

namespace GP8000.Personnel
{
	/// <summary>
	/// Summary description for frmTaRecycleBin.
	/// </summary>
	public class frmTaRecycleBin : System.Windows.Forms.Form
	{
		private C1.Win.C1Command.C1CommandDock c1CommandDock1;
		private C1.Win.C1Command.C1DockingTab c1DockingTab1;
		private C1.Win.C1Command.C1DockingTabPage c1DockingTabPage1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Panel panel4;
		private GP8000.UserControl.CrtTaDepartment Dep;
		private Navigator1._0.NavigatorAuto nav;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.TextBox txt3;
		private System.Windows.Forms.TextBox txt2;
		private System.Windows.Forms.TextBox txt1;
		private System.Windows.Forms.Panel panel5;
		private C1.Win.C1FlexGrid.C1FlexGrid vs;
		private System.Windows.Forms.TextBox txt_CRD_ID;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmTaRecycleBin()
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
			this.Dep = new GP8000.UserControl.CrtTaDepartment();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel5 = new System.Windows.Forms.Panel();
			this.vs = new C1.Win.C1FlexGrid.C1FlexGrid();
			this.panel6 = new System.Windows.Forms.Panel();
			this.txt_CRD_ID = new System.Windows.Forms.TextBox();
			this.txt3 = new System.Windows.Forms.TextBox();
			this.txt2 = new System.Windows.Forms.TextBox();
			this.txt1 = new System.Windows.Forms.TextBox();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label5 = new System.Windows.Forms.Label();
			this.panel4 = new System.Windows.Forms.Panel();
			this.nav = new Navigator1._0.NavigatorAuto();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandDock1)).BeginInit();
			this.c1CommandDock1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.c1DockingTab1)).BeginInit();
			this.c1DockingTab1.SuspendLayout();
			this.c1DockingTabPage1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.vs)).BeginInit();
			this.panel6.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel4.SuspendLayout();
			this.SuspendLayout();
			// 
			// c1CommandDock1
			// 
			this.c1CommandDock1.Controls.Add(this.c1DockingTab1);
			this.c1CommandDock1.Dock = System.Windows.Forms.DockStyle.Left;
			this.c1CommandDock1.Id = 1;
			this.c1CommandDock1.Location = new System.Drawing.Point(0, 0);
			this.c1CommandDock1.Name = "c1CommandDock1";
			this.c1CommandDock1.Size = new System.Drawing.Size(264, 476);
			// 
			// c1DockingTab1
			// 
			this.c1DockingTab1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
			this.c1DockingTab1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.c1DockingTab1.CanAutoHide = true;
			this.c1DockingTab1.CanMoveTabs = true;
			this.c1DockingTab1.Controls.Add(this.c1DockingTabPage1);
			this.c1DockingTab1.Location = new System.Drawing.Point(0, 0);
			this.c1DockingTab1.Name = "c1DockingTab1";
			this.c1DockingTab1.SelectedIndex = 0;
			this.c1DockingTab1.ShowCaption = true;
			this.c1DockingTab1.ShowSingleTab = false;
			this.c1DockingTab1.Size = new System.Drawing.Size(264, 476);
			this.c1DockingTab1.TabIndex = 0;
			this.c1DockingTab1.TabSizeMode = C1.Win.C1Command.TabSizeModeEnum.Fit;
			this.c1DockingTab1.TabStyle = C1.Win.C1Command.TabStyleEnum.WindowsXP;
			// 
			// c1DockingTabPage1
			// 
			this.c1DockingTabPage1.Controls.Add(this.Dep);
			this.c1DockingTabPage1.ImageIndex = -1;
			this.c1DockingTabPage1.Location = new System.Drawing.Point(1, 1);
			this.c1DockingTabPage1.Name = "c1DockingTabPage1";
			this.c1DockingTabPage1.Size = new System.Drawing.Size(259, 474);
			this.c1DockingTabPage1.TabIndex = 0;
			this.c1DockingTabPage1.Text = "Page1";
			// 
			// Dep
			// 
			this.Dep.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Dep.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Dep.Location = new System.Drawing.Point(0, 20);
			this.Dep.Name = "Dep";
			this.Dep.Size = new System.Drawing.Size(259, 454);
			this.Dep.TabIndex = 2;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Controls.Add(this.panel3);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(264, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(756, 476);
			this.panel1.TabIndex = 1;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.panel5);
			this.panel2.Controls.Add(this.panel6);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 36);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(756, 440);
			this.panel2.TabIndex = 6;
			// 
			// panel5
			// 
			this.panel5.Controls.Add(this.vs);
			this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel5.Location = new System.Drawing.Point(0, 28);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(756, 412);
			this.panel5.TabIndex = 5;
			// 
			// vs
			// 
			this.vs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.vs.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.XpThemes;
			this.vs.ColumnInfo = "10,1,0,0,0,100,Columns:0{Width:38;}\t";
			this.vs.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.vs.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
			this.vs.Location = new System.Drawing.Point(4, 4);
			this.vs.Name = "vs";
			this.vs.Size = new System.Drawing.Size(748, 400);
			this.vs.Styles = ((C1.Win.C1FlexGrid.CellStyleCollection)(new C1.Win.C1FlexGrid.CellStyleCollection("")));
			this.vs.TabIndex = 11;
			// 
			// panel6
			// 
			this.panel6.BackColor = System.Drawing.Color.AliceBlue;
			this.panel6.Controls.Add(this.txt_CRD_ID);
			this.panel6.Controls.Add(this.txt3);
			this.panel6.Controls.Add(this.txt2);
			this.panel6.Controls.Add(this.txt1);
			this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel6.Location = new System.Drawing.Point(0, 0);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(756, 28);
			this.panel6.TabIndex = 4;
			// 
			// txt_CRD_ID
			// 
			this.txt_CRD_ID.BackColor = System.Drawing.Color.LemonChiffon;
			this.txt_CRD_ID.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txt_CRD_ID.Location = new System.Drawing.Point(404, 2);
			this.txt_CRD_ID.MaxLength = 20;
			this.txt_CRD_ID.Name = "txt_CRD_ID";
			this.txt_CRD_ID.Size = new System.Drawing.Size(132, 23);
			this.txt_CRD_ID.TabIndex = 74;
			this.txt_CRD_ID.Tag = "CRD_ID";
			this.txt_CRD_ID.Text = "textBox3";
			this.txt_CRD_ID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
			this.txt_CRD_ID.Leave += new System.EventHandler(this.textBox1_Leave);
			this.txt_CRD_ID.Enter += new System.EventHandler(this.textBox1_Enter);
			// 
			// txt3
			// 
			this.txt3.BackColor = System.Drawing.Color.LemonChiffon;
			this.txt3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txt3.Location = new System.Drawing.Point(272, 2);
			this.txt3.MaxLength = 20;
			this.txt3.Name = "txt3";
			this.txt3.Size = new System.Drawing.Size(132, 23);
			this.txt3.TabIndex = 73;
			this.txt3.Tag = "EMP_NM";
			this.txt3.Text = "textBox3";
			this.txt3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
			this.txt3.Leave += new System.EventHandler(this.textBox1_Leave);
			this.txt3.Enter += new System.EventHandler(this.textBox1_Enter);
			// 
			// txt2
			// 
			this.txt2.BackColor = System.Drawing.Color.LemonChiffon;
			this.txt2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txt2.Location = new System.Drawing.Point(140, 2);
			this.txt2.MaxLength = 20;
			this.txt2.Name = "txt2";
			this.txt2.Size = new System.Drawing.Size(132, 23);
			this.txt2.TabIndex = 72;
			this.txt2.Tag = "EMP_I1";
			this.txt2.Text = "textBox3";
			this.txt2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
			this.txt2.Leave += new System.EventHandler(this.textBox1_Leave);
			this.txt2.Enter += new System.EventHandler(this.textBox1_Enter);
			// 
			// txt1
			// 
			this.txt1.BackColor = System.Drawing.Color.LemonChiffon;
			this.txt1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txt1.Location = new System.Drawing.Point(8, 2);
			this.txt1.MaxLength = 20;
			this.txt1.Name = "txt1";
			this.txt1.Size = new System.Drawing.Size(132, 23);
			this.txt1.TabIndex = 71;
			this.txt1.Tag = "EMP_ID";
			this.txt1.Text = "textBox3";
			this.txt1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
			this.txt1.Leave += new System.EventHandler(this.textBox1_Leave);
			this.txt1.Enter += new System.EventHandler(this.textBox1_Enter);
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.panel3.Controls.Add(this.label5);
			this.panel3.Controls.Add(this.panel4);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.panel3.Location = new System.Drawing.Point(0, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(756, 36);
			this.panel3.TabIndex = 5;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label5.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.label5.Location = new System.Drawing.Point(356, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(400, 36);
			this.label5.TabIndex = 11;
			this.label5.Tag = "";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.panel4.Controls.Add(this.nav);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.panel4.Location = new System.Drawing.Point(0, 0);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(356, 36);
			this.panel4.TabIndex = 10;
			// 
			// nav
			// 
			this.nav.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.nav.Connection = null;
			this.nav.ConnectionDel = null;
			this.nav.Font = new System.Drawing.Font("Tahoma", 9.75F);
			this.nav.form = null;
			this.nav.FormName = null;
			this.nav.Grid = null;
			this.nav.History = false;
			this.nav.IsNull = true;
			this.nav.Language = "EN";
			this.nav.Location = new System.Drawing.Point(4, 3);
			this.nav.MSG_Exit = false;
			this.nav.MulltiDel = false;
			this.nav.Name = "nav";
			this.nav.Security = 0;
			this.nav.ShowPopupMenu = true;
			this.nav.Size = new System.Drawing.Size(344, 32);
			this.nav.TabIndex = 10;
			this.nav.Tag = "";
			this.nav.ToolBar_Auto = true;
			this.nav.UserID = null;
			this.nav.VisibleGrid = true;
			this.nav.Where = null;
			// 
			// frmTaRecycleBin
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
			this.ClientSize = new System.Drawing.Size(1020, 476);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.c1CommandDock1);
			this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "frmTaRecycleBin";
			this.Text = "frmTaRecycleBin";
			this.Load += new System.EventHandler(this.frmTaRecycleBin_Load);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandDock1)).EndInit();
			this.c1CommandDock1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.c1DockingTab1)).EndInit();
			this.c1DockingTab1.ResumeLayout(false);
			this.c1DockingTabPage1.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel5.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.vs)).EndInit();
			this.panel6.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void frmTaRecycleBin_Load(object sender, System.EventArgs e)
		{
			Init_Form();			
		}	
		#region Init Form
		private void Init_Form()
		{					
			Dep.Init_Tree(this.Tag+"");
			Dep.vs1.AfterRowColChange+=new RangeEventHandler(Depvs1_AfterRowColChange);
			Dep.Show_Tree();
			Init_vs();					
			Basic.Function.PublicFunction.L_Init_Label(this);					
			Init_CB();				
		}
		private void Init_vs()
		{
			nav.cmd_refresh.Visible=nav.cmd_save.Visible=nav.cmd_search.Visible=nav.cmd_report.Visible=nav.cmd_add.Visible=nav.cmd_copy.Visible=false;			
			PublicFunction.InitNav(this,vs,nav);			
			vs.AllowEditing=false;
			vs.Cols["CRD_DT"].Format=PublicFunction.GetOption("DATE");
			vs.Cols["INH_DT"].Format=PublicFunction.GetOption("DATE");	
			vs.DoubleClick+=new EventHandler(vs_DoubleClick);
			nav.TBarClick+=new ToolBarButtonClickEventHandler(nav_TBarClick);
			nav.ToolBar_Auto=false;
			vs.EnabledChanged+=new EventHandler(vs_EnabledChanged);
		}

		private void  Init_CB()
		{			
			string sql;			
			//Department
			sql=PublicFunction.GetDep(this.Tag+"");			
			vs.Cols["DEP_ID"].DataMap=PublicFunction.InitCBForVS(sql);			
			//City
			sql="Select CIT_ID,CIT_NM from FILA03A";		
			vs.Cols["CIT_ID"].DataMap=PublicFunction.InitCBForVS(sql);
			//education
			sql="Select EDU_ID,EDU_NM from FILA04A";		
			vs.Cols["EDU_ID"].DataMap=PublicFunction.InitCBForVS(sql);
			//Profession
			sql="Select PRO_ID,PRO_NM from FILA05A";		
			vs.Cols["PRO_ID"].DataMap=PublicFunction.InitCBForVS(sql);
			//Graduation
			sql="Select GRA_ID,GRA_NM from FILA10A";	
			vs.Cols["GRA_ID"].DataMap=PublicFunction.InitCBForVS(sql);			
			//Position
			sql="Select POS_ID,POS_NM from FILA07A";		
			vs.Cols["POS_ID"].DataMap=PublicFunction.InitCBForVS(sql);
			//Nguyen Quan Native Place
			sql="Select COU_ID,COU_NM from FILA12A";
			vs.Cols["NAT_CO"].DataMap=PublicFunction.InitCBForVS(sql);
			//Nature Loai Nhan Vien
			sql="Select TYP_ID,TYP_NM from FILA11A";
			vs.Cols["TYP_ID"].DataMap=PublicFunction.InitCBForVS(sql);
			//Group
			sql="Select GRP_ID,GRP_NM from FILA08A";	
			vs.Cols["GRP_ID"].DataMap=PublicFunction.InitCBForVS(sql);
			//Type Group
			sql="Select GRT_ID,GRT_NM from FILA09A";		
			vs.Cols["GRT_ID"].DataMap=PublicFunction.InitCBForVS(sql);
			//Nationality
			sql="Select COU_ID,COU_NM from FILA12A";			
			vs.Cols["COU_ID"].DataMap=PublicFunction.InitCBForVS(sql);			
		}
		#endregion
		#region ShowData
		private void Show_VS()
		{
			if(Dep.vs1.Row<=0)
			{
				vs.Rows.Count=1;			
				return;
			}
			nav.Show_VS("DEP_ID in "+Dep.Get_DepAll()+" and DEL_BT=1");						
		}		
		#endregion
			
		#region  Event
		
		private void Depvs1_AfterRowColChange(object sender, RangeEventArgs e)
		{
			if(e.OldRange.r1!=e.NewRange.r1)
			{
				Show_VS();
			}
		}
		#endregion			

		#region Search
		private void textBox1_Enter(object sender, System.EventArgs e)
		{
			TextBox txt=(TextBox)sender;
			if (txt.Text==vs.Cols[txt.Tag+""].Caption)
				txt.Text="";
		}

		private void textBox1_Leave(object sender, System.EventArgs e)
		{
			TextBox txt=(TextBox)sender;
			if (txt.Text=="")
				txt.Text=vs.Cols[txt.Tag+""].Caption;
		}

		private void textBox1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyCode==Keys.Enter)
			{
				string f=((TextBox)sender).Tag+"";			
				string sql;				
				if(((TextBox)sender).Text+""!="")
					sql=f+" like N'%"+((TextBox)sender).Text+"%'";
				else
					sql="1=1";
				sql=sql+" and DEP_ID in (Select DEP_ID  from SYS_SECURITY_DEP"+
					" where MNU_ID="+this.Tag+" and ALL_BT=1 and DEL_BT=1 and USER_ID=N'"+PublicFunction.A_UserID+"')";					
				nav.Show_VS(sql);						
			}
		}
		private void vs_DoubleClick(object sender, EventArgs e)
		{
			if(vs.Row<=0)
				return;
			if(MessageBox.Show(this,PublicFunction.L_Get_Msg("msg",15),this.Text,MessageBoxButtons.YesNo)==DialogResult.Yes)
			{				
				SqlConnection con=new SqlConnection(PublicFunction.C_con.ConnectionString);
				con.Open();													
				SqlTransaction tran=con.BeginTransaction();				
				try
				{
					string sql="";	
					sql="Update FILB01A set DEL_BT=0 where EMP_ID=N'"+vs.Rows[vs.Row]["EMP_ID"]+"'";
					SqlCommand cmd=new SqlCommand(sql,con,tran);
					cmd.ExecuteNonQuery();									
					sql="delete from FILB01AD where EMP_ID=N'"+vs.Rows[vs.Row]["EMP_ID"]+"'";
					cmd=new SqlCommand(sql,con,tran);
					cmd.ExecuteNonQuery();						
					vs.RemoveItem(vs.Row);
					tran.Commit();																								
				}				
				catch(Exception ex)
				{
					tran.Rollback();
					MessageBox.Show(ex.Message);
					con.Close();	
					return;
				}									
				MessageBox.Show(PublicFunction.L_Get_Msg("Staff",1));
				con.Close();	
			}	
		}
		
		#endregion

		private void nav_TBarClick(object sender, ToolBarButtonClickEventArgs e)
		{
			if (e.Button.Equals(nav.cmd_delete))
			{
				if(MessageBox.Show(this,PublicFunction.L_Get_Msg("msg",90),this.Text,MessageBoxButtons.YesNo)==DialogResult.Yes)
				{
					string emp_id=vs.Rows[vs.Row]["EMP_ID"]+"";
					nav.ToolBar_Click(e);	
					//				if(MessageBox.Show(this,PublicFunction.L_Get_Msg("msg",15),this.Text,MessageBoxButtons.YesNo)==DialogResult.Yes)
					//				{	
					if(nav.Msg_Delete)
					{
						string sql="",wh;
						//wh=" where EMP_ID not in(Select EMP_ID from FILB01A)";
						wh=" where EMP_ID ='"+emp_id+"'";
						sql="Delete from FILB01AA" +wh;
						PublicFunction.SQL_Execute(sql);
						sql="Delete from FILB01AB" +wh;
						PublicFunction.SQL_Execute(sql);
						sql="Delete from FILB01AC" +wh;
						PublicFunction.SQL_Execute(sql);
						sql="Delete from FILB01ACA" +wh;
						PublicFunction.SQL_Execute(sql);
						sql="Delete from FILB01AD" +wh;
						PublicFunction.SQL_Execute(sql);
						sql="Delete from FILB01AD" +wh;
						PublicFunction.SQL_Execute(sql);
						sql="Delete from FILB01AF" +wh;
						PublicFunction.SQL_Execute(sql);
						sql="Delete from FILB02A" +wh;
						PublicFunction.SQL_Execute(sql);
						sql="Delete from FILB03A" +wh;
						PublicFunction.SQL_Execute(sql);
						sql="Delete from FILB04A" +wh;
						PublicFunction.SQL_Execute(sql);
						sql="Delete from FILB05A" +wh;
						PublicFunction.SQL_Execute(sql);

						sql="Delete from FILC01A" +wh;
						PublicFunction.SQL_Execute(sql);
						sql="Delete from FILC03A" +wh;
						PublicFunction.SQL_Execute(sql);
						sql="Delete from FILC04A" +wh;
						PublicFunction.SQL_Execute(sql);
						sql="Delete from FILC04B" +wh;
						PublicFunction.SQL_Execute(sql);
						sql="Delete from FILC05A" +wh;
						PublicFunction.SQL_Execute(sql);
						sql="Delete from FILC06A" +wh;
						PublicFunction.SQL_Execute(sql);
						sql="Delete from FILC06AA" +wh;
						PublicFunction.SQL_Execute(sql);					
					}
				}
				return;
			}
			nav.ToolBar_Click(e);
		}

		private void vs_EnabledChanged(object sender, EventArgs e)
		{
			txt1.Text=vs.Cols[txt1.Tag+""].Caption;
			txt2.Text=vs.Cols[txt2.Tag+""].Caption;
			txt3.Text=vs.Cols[txt3.Tag+""].Caption;
			txt_CRD_ID.Text=vs.Cols[txt_CRD_ID.Tag+""].Caption;
		}
	}
}
