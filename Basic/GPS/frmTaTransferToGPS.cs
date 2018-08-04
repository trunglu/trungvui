using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using Basic.Form;
using Basic.Function;
using System.Data;
using System.Data.SqlClient;
using System.Threading;

namespace GP8000.GPS
{
	/// <summary>
	/// Summary description for frmTaTransferToGPS.
	/// </summary>
	public class frmTaTransferToGPS : System.Windows.Forms.Form
	{
		private C1.Win.C1Command.C1CommandDock c1CommandDock1;
		private C1.Win.C1Command.C1DockingTab c1DockingTab1;
		private C1.Win.C1Command.C1DockingTabPage c1DockingTabPage1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label l;
		private System.Windows.Forms.Panel panel3;
		private Navigator1._0.NavigatorAuto nav;
		private C1.Win.C1FlexGrid.C1FlexGrid vss;
		private C1.Win.C1FlexGrid.C1FlexGrid vs;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Label l1;
		private System.Windows.Forms.Label l2;
		private System.Windows.Forms.ProgressBar pro1;
		private System.Windows.Forms.ProgressBar pro2;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.ListBox li;
		private C1.Win.C1Input.C1DateEdit dt1;
		private C1.Win.C1Input.C1DateEdit dt2;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmTaTransferToGPS()
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
			this.vss = new C1.Win.C1FlexGrid.C1FlexGrid();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.panel7 = new System.Windows.Forms.Panel();
			this.vs = new C1.Win.C1FlexGrid.C1FlexGrid();
			this.panel6 = new System.Windows.Forms.Panel();
			this.li = new System.Windows.Forms.ListBox();
			this.panel5 = new System.Windows.Forms.Panel();
			this.pro2 = new System.Windows.Forms.ProgressBar();
			this.pro1 = new System.Windows.Forms.ProgressBar();
			this.l2 = new System.Windows.Forms.Label();
			this.l1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.l = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.nav = new Navigator1._0.NavigatorAuto();
			this.dt1 = new C1.Win.C1Input.C1DateEdit();
			this.dt2 = new C1.Win.C1Input.C1DateEdit();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandDock1)).BeginInit();
			this.c1CommandDock1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.c1DockingTab1)).BeginInit();
			this.c1DockingTab1.SuspendLayout();
			this.c1DockingTabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.vss)).BeginInit();
			this.panel1.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel7.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.vs)).BeginInit();
			this.panel6.SuspendLayout();
			this.panel5.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dt1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dt2)).BeginInit();
			this.SuspendLayout();
			// 
			// c1CommandDock1
			// 
			this.c1CommandDock1.Controls.Add(this.c1DockingTab1);
			this.c1CommandDock1.Dock = System.Windows.Forms.DockStyle.Left;
			this.c1CommandDock1.Id = 1;
			this.c1CommandDock1.Location = new System.Drawing.Point(0, 0);
			this.c1CommandDock1.Name = "c1CommandDock1";
			this.c1CommandDock1.Size = new System.Drawing.Size(340, 496);
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
			this.c1DockingTab1.Size = new System.Drawing.Size(340, 496);
			this.c1DockingTab1.TabIndex = 0;
			this.c1DockingTab1.TabSizeMode = C1.Win.C1Command.TabSizeModeEnum.Fit;
			this.c1DockingTab1.TabStyle = C1.Win.C1Command.TabStyleEnum.WindowsXP;
			// 
			// c1DockingTabPage1
			// 
			this.c1DockingTabPage1.Controls.Add(this.vss);
			this.c1DockingTabPage1.ImageIndex = -1;
			this.c1DockingTabPage1.Location = new System.Drawing.Point(1, 1);
			this.c1DockingTabPage1.Name = "c1DockingTabPage1";
			this.c1DockingTabPage1.Size = new System.Drawing.Size(335, 494);
			this.c1DockingTabPage1.TabIndex = 0;
			this.c1DockingTabPage1.Text = "Page1";
			// 
			// vss
			// 
			this.vss.AllowEditing = false;
			this.vss.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.XpThemes;
			this.vss.ColumnInfo = "10,1,0,0,0,100,Columns:0{Width:38;}\t";
			this.vss.Dock = System.Windows.Forms.DockStyle.Fill;
			this.vss.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.vss.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
			this.vss.Location = new System.Drawing.Point(0, 20);
			this.vss.Name = "vss";
			this.vss.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;
			this.vss.Size = new System.Drawing.Size(335, 474);
			this.vss.Styles = ((C1.Win.C1FlexGrid.CellStyleCollection)(new C1.Win.C1FlexGrid.CellStyleCollection("")));
			this.vss.TabIndex = 29;
			this.vss.Tag = "N";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.panel4);
			this.panel1.Controls.Add(this.panel5);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(340, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(732, 496);
			this.panel1.TabIndex = 2;
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.panel7);
			this.panel4.Controls.Add(this.panel6);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel4.Location = new System.Drawing.Point(0, 36);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(732, 316);
			this.panel4.TabIndex = 4;
			// 
			// panel7
			// 
			this.panel7.Controls.Add(this.vs);
			this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel7.Location = new System.Drawing.Point(0, 0);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(456, 316);
			this.panel7.TabIndex = 1;
			// 
			// vs
			// 
			this.vs.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.XpThemes;
			this.vs.ColumnInfo = "10,1,0,0,0,100,Columns:0{Width:38;}\t";
			this.vs.Dock = System.Windows.Forms.DockStyle.Fill;
			this.vs.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.vs.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
			this.vs.Location = new System.Drawing.Point(0, 0);
			this.vs.Name = "vs";
			this.vs.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.CellRange;
			this.vs.Size = new System.Drawing.Size(456, 316);
			this.vs.Styles = ((C1.Win.C1FlexGrid.CellStyleCollection)(new C1.Win.C1FlexGrid.CellStyleCollection("")));
			this.vs.TabIndex = 30;
			// 
			// panel6
			// 
			this.panel6.Controls.Add(this.li);
			this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel6.Location = new System.Drawing.Point(456, 0);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(276, 316);
			this.panel6.TabIndex = 0;
			// 
			// li
			// 
			this.li.Dock = System.Windows.Forms.DockStyle.Fill;
			this.li.ItemHeight = 16;
			this.li.Location = new System.Drawing.Point(0, 0);
			this.li.Name = "li";
			this.li.Size = new System.Drawing.Size(276, 308);
			this.li.TabIndex = 0;
			// 
			// panel5
			// 
			this.panel5.BackColor = System.Drawing.Color.LightSteelBlue;
			this.panel5.Controls.Add(this.pro2);
			this.panel5.Controls.Add(this.pro1);
			this.panel5.Controls.Add(this.l2);
			this.panel5.Controls.Add(this.l1);
			this.panel5.Controls.Add(this.button1);
			this.panel5.Controls.Add(this.button2);
			this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel5.Location = new System.Drawing.Point(0, 352);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(732, 144);
			this.panel5.TabIndex = 3;
			// 
			// pro2
			// 
			this.pro2.Dock = System.Windows.Forms.DockStyle.Top;
			this.pro2.Location = new System.Drawing.Point(0, 69);
			this.pro2.Name = "pro2";
			this.pro2.Size = new System.Drawing.Size(732, 23);
			this.pro2.TabIndex = 5;
			// 
			// pro1
			// 
			this.pro1.Dock = System.Windows.Forms.DockStyle.Top;
			this.pro1.Location = new System.Drawing.Point(0, 46);
			this.pro1.Name = "pro1";
			this.pro1.Size = new System.Drawing.Size(732, 23);
			this.pro1.TabIndex = 4;
			// 
			// l2
			// 
			this.l2.BackColor = System.Drawing.Color.Black;
			this.l2.Dock = System.Windows.Forms.DockStyle.Top;
			this.l2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.l2.ForeColor = System.Drawing.Color.White;
			this.l2.Location = new System.Drawing.Point(0, 23);
			this.l2.Name = "l2";
			this.l2.Size = new System.Drawing.Size(732, 23);
			this.l2.TabIndex = 3;
			this.l2.Tag = "N";
			this.l2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// l1
			// 
			this.l1.BackColor = System.Drawing.Color.Black;
			this.l1.Dock = System.Windows.Forms.DockStyle.Top;
			this.l1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.l1.ForeColor = System.Drawing.Color.White;
			this.l1.Location = new System.Drawing.Point(0, 0);
			this.l1.Name = "l1";
			this.l1.Size = new System.Drawing.Size(732, 23);
			this.l1.TabIndex = 2;
			this.l1.Tag = "N";
			this.l1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button1.Location = new System.Drawing.Point(111, 100);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(128, 36);
			this.button1.TabIndex = 0;
			this.button1.Text = "button1";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button2.Location = new System.Drawing.Point(285, 100);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(128, 36);
			this.button2.TabIndex = 1;
			this.button2.Text = "button2";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.panel2.Controls.Add(this.dt2);
			this.panel2.Controls.Add(this.dt1);
			this.panel2.Controls.Add(this.l);
			this.panel2.Controls.Add(this.panel3);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(732, 36);
			this.panel2.TabIndex = 1;
			// 
			// l
			// 
			this.l.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.l.Dock = System.Windows.Forms.DockStyle.Fill;
			this.l.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.l.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.l.Location = new System.Drawing.Point(424, 0);
			this.l.Name = "l";
			this.l.Size = new System.Drawing.Size(308, 36);
			this.l.TabIndex = 6;
			this.l.Tag = "";
			this.l.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.l.Visible = false;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.nav);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel3.Location = new System.Drawing.Point(0, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(424, 36);
			this.panel3.TabIndex = 0;
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
			this.nav.ShowPopupMenu = false;
			this.nav.Size = new System.Drawing.Size(416, 32);
			this.nav.TabIndex = 30;
			this.nav.ToolBar_Auto = true;
			this.nav.UserID = null;
			this.nav.VisibleGrid = true;
			this.nav.Where = null;
			// 
			// dt1
			// 
			this.dt1.CustomFormat = "yyyyMM";
			this.dt1.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat;
			this.dt1.Location = new System.Drawing.Point(460, 4);
			this.dt1.Name = "dt1";
			this.dt1.Size = new System.Drawing.Size(80, 23);
			this.dt1.TabIndex = 168;
			this.dt1.Tag = null;
			// 
			// dt2
			// 
			this.dt2.CustomFormat = "yyyyMM";
			this.dt2.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat;
			this.dt2.Location = new System.Drawing.Point(552, 4);
			this.dt2.Name = "dt2";
			this.dt2.Size = new System.Drawing.Size(80, 23);
			this.dt2.TabIndex = 169;
			this.dt2.Tag = null;
			// 
			// frmTaTransferToGPS
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
			this.ClientSize = new System.Drawing.Size(1072, 496);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.c1CommandDock1);
			this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "frmTaTransferToGPS";
			this.Text = "frmTaTransferToGPS";
			this.Load += new System.EventHandler(this.frmTaTransferToGPS_Load);
			this.Closed += new System.EventHandler(this.frmTaTransferToGPS_Closed);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandDock1)).EndInit();
			this.c1CommandDock1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.c1DockingTab1)).EndInit();
			this.c1DockingTab1.ResumeLayout(false);
			this.c1DockingTabPage1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.vss)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.panel7.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.vs)).EndInit();
			this.panel6.ResumeLayout(false);
			this.panel5.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dt1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dt2)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void frmTaTransferToGPS_Load(object sender, System.EventArgs e)
		{			
			show_vss();
			init_vs();	
			Basic.Function.PublicFunction.L_Init_Label(this);
			if (PublicFunction.A_Group_ID!="Admin")
				vs.Enabled=false;			
			dt1.Value=T_String.GetDate();
			dt2.Value=T_String.GetDate();
		}

		private void init_vs()
		{
			PublicFunction.InitNav(this,vs,nav);			
			vs.SelectionMode=C1.Win.C1FlexGrid.SelectionModeEnum.CellRange; 
			nav.Show_VS();
			nav.cmd_copy.Visible=nav.cmd_report.Visible=nav.cmd_search.Visible=false;	
			vs.AfterEdit+=new C1.Win.C1FlexGrid.RowColEventHandler(vs_AfterEdit);
		}

		private void show_vss()
		{
			vss.Cols.Count=2;
			vss.Cols[1].Name="TAB_NM";
			vss.Rows.Count=1;
			string sql;
			
			sql = "SELECT [id],[name] From sysobjects where [xtype]=N'U' order by [name]";							
			Func.RecordSet rs=new Func.RecordSet(sql,PublicFunction.C_con);			
			for (int i=0;i<rs.rows;i++)
			{				
				vss.Rows.Count++;
				vss.Rows[vss.Rows.Count-1][0]=vss.Rows.Count-1;
				vss.Rows[vss.Rows.Count-1]["TAB_NM"]=rs.record(i,1);
			}
			vss.DoubleClick+=new EventHandler(vss_DoubleClick);
			vss.KeyDown+=new KeyEventHandler(vss_KeyDown);
		}

		private void vss_DoubleClick(object sender, EventArgs e)
		{
			insert();
		}

		private void vss_KeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode==Keys.Enter)
			{
				insert();
				vss.Focus();			
			}

		}

		private void insert()
		{
			if(vss.Row>0)
			{
				string tb=vss.Rows[vss.Row]["TAB_NM"]+"";
				int i=0;
				for(i=1;i<vs.Rows.Count;i++)
				{
					if(tb==vs.Rows[i]["TAB_NM"]+"")
					{
						i=-1;
						break;
					}
				}
				if(i>=vs.Rows.Count)
				{
					nav.ToolBar_Click(new System.Windows.Forms.ToolBarButtonClickEventArgs(nav.cmd_add));
					vs.Rows[vs.Rows.Count-1]["TAB_NM"]=tb;
					nav.SaveRow(vs.Rows.Count-1);
				}
			}
		}
		Boolean stop;
		private void button1_Click(object sender, System.EventArgs e)
		{
			if(PublicFunction.GetOption("ServerGPS_GP")=="1")
			{
				if(PublicFunction.DT_database==PublicFunction.DTGP_database)
				{
					MessageBox.Show("Both of GP database and GPS database is the same name, can not Synchronize");
					return;
				}
			}
			stop=false;
			Thread th=new Thread(new ThreadStart(Tran));
			th.Priority=ThreadPriority.Highest;
			th.Start();
			button1.Enabled=false;
		}

		private void Tran()
		{
			SqlConnection conGP=new SqlConnection(PublicFunction.C_con.ConnectionString);
			SqlConnection conGPS=PublicFunction.connect(PublicFunction.DTGP_server,PublicFunction.DTGP_database
				,PublicFunction.DTGP_username,PublicFunction.DTGP_password);
			li.Items.Clear();
			for(int i=1;i<vs.Rows.Count;i++)
			{
				if(stop)
				{
					button1.Enabled=true;
					return;
				}
				Boolean insert=false, update=false,delete=false;
				if(vs.Rows[i]["INS_BT"]+""=="True")
					insert=true;
				if(vs.Rows[i]["UPD_BT"]+""=="True")
					update=true;
				if(vs.Rows[i]["DEL_BT"]+""=="True")
					delete=true;
				if(insert || update || delete)
					if(PublicFunction.GetOption("ServerGPS_GP")=="1")//QV Cu Chi
						ImportTable_New(vs.Rows[i]["TAB_NM"]+"",conGP,conGPS,insert, update,delete,l2,pro2);
					else
						ImportTable(vs.Rows[i]["TAB_NM"]+"",conGP,conGPS,insert, update,delete,l2,pro2);

                l1.Text=vs.Rows[i]["MEN_NM"]+" - " +(int)i*100/vs.Rows.Count+"%";
				pro1.Value= (int)i*100/vs.Rows.Count;
				li.Items.Add(vs.Rows[i]["MEN_NM"]+"");
			}
			pro1.Value=100;
			l1.Text="100%";
			li.Items.Add("____"+ PublicFunction.L_Get_Msg("Staff",1)+ "____");
			MessageBox.Show(PublicFunction.L_Get_Msg("Staff",1));
		}
		private void ImportTable_New(string table,SqlConnection confr,SqlConnection conto,Boolean insert,Boolean update,Boolean delete,Label lb,ProgressBar pro)		
		{
			string sql;
			if(table=="FILD02A")
			{
				DateTime ddate1,ddate2;
				ddate1=(DateTime) dt1.Value;
				ddate2=(DateTime) dt2.Value;
				while(ddate1<=ddate2)
				{
					sql="Delete "+table;
					sql=sql+ " where YYY_MM='"+ddate1.ToString("yyyyMM") +"' and isnull(LCK_BT,0)=0";
					PublicFunction.SQL_Execute(sql,conto);
					sql="insert into "+PublicFunction.DTGP_database+".dbo."+table+" select * From "+table;
					sql=sql+ " where YYY_MM='"+ddate1.ToString("yyyyMM") +"'";
					sql+=" and EMP_ID NOT IN (SELECT EMP_ID FROM "+PublicFunction.DTGP_database+".dbo."+table;
					sql+=" where YYY_MM='"+ddate1.ToString("yyyyMM") +"' )";
					PublicFunction.SQL_Execute(sql,confr);
					ddate1= ddate1.AddMonths(1);
				}
			}
//			else if(table=="FILD03A")
//			{
//				DateTime ddate1,ddate2;
//				ddate1=(DateTime) dt1.Value;
//				ddate2=(DateTime) dt2.Value;
//				
//				sql="Delete "+table;
//				sql=sql+ " where CHA_DT>='"+ddate1.AddMonths(-1).ToString("yyyy/MM/dd") +"' ";
//				PublicFunction.SQL_Execute(sql,conto);
//				sql="insert into "+PublicFunction.DTGP_database+".dbo."+table+" select * From "+table;
//				sql=sql+ " where CHA_DT>='"+ddate1.AddMonths(-1).ToString("yyyy/MM/dd")+"'";
//				//					sql+=" and EMP_ID NOT IN (SELECT EMP_ID FROM "+PublicFunction.DTGP_database+".dbo."+table;
//				//					sql+=" where YYY_MM='"+ddate1.ToString("yyyyMM") +"' )";
//				PublicFunction.SQL_Execute(sql,confr);
//					
//			}
			else
			{
				sql="Delete "+table;
				PublicFunction.SQL_Execute(sql,conto);
				sql="insert into "+PublicFunction.DTGP_database+".dbo."+table+" select * From "+table;
				PublicFunction.SQL_Execute(sql,confr);
			}
		}
		private void ImportTable(string table,SqlConnection confr,SqlConnection conto,Boolean insert,Boolean update,Boolean delete,Label lb,ProgressBar pro)		
		{			
			ArrayList fname=new ArrayList();
			ArrayList key=new ArrayList();
			ArrayList type=new ArrayList();
			ArrayList pic=new ArrayList();
			string sql,sql1,wh,st,st1;
			if (!PublicFunction.CheckFieldOfTable(conto,table))
				return;			

			sql="select * from "+table;
			if (table=="FILD02A")
			{
				sql=sql+ " where (YYY_MM>='"+dt1.Text +"' and YYY_MM<='"+ dt2.Text +"')";
			}
			Func.RecordSet  rs=new Func.RecordSet(sql,confr);
			sql="Insert Into ["+table+"] (";
			for(int i=0;i<rs.cols;i++)
			{		
				if (Func.Fun.CheckFieldOfTable(conto,table,rs.Field(i)))
				{
					fname.Add(rs.Field(i));
					key.Add(Func.Fun.CheckPrimaryKey(conto,table,rs.Field(i)));
					st=Func.Fun.GetTypeField(conto,table,rs.Field(i));
					type.Add(st);
					if (i!=0) sql+=",";
					sql+="["+rs.Field(i)+"]";	
					if (st=="6")
						pic.Add(rs.Field(i));			
				}
			}
			
			int del=0,ins=0,upd=0;
			sql+=") values(";
			if(insert || update)
			{
				for(int j=0;j<rs.rows;j++)
				{
					if(stop)
					{
						button1.Enabled=true;
						return;
					}
					sql1="";wh="";st1="";
					for(int i=0;i<fname.Count;i++)
					{	
				
						//insert
						if (sql1!="") sql1+=",";
					
						if (pic.IndexOf(fname[i]+"")>=0 || rs.record(j,fname[i]+"")==null || rs.record(j,fname[i]+"")=="" )			
						{
							if ((Boolean)key[i])
								sql1= sql1 + "''";
							else
								sql1= sql1 + "Default";
						}
							// Get TypeName of Field,  return {1 (nvarchar,char..), 2 (datetime), 3 (bit), 4 (float), 5 (int)}					
						else
						{						
							switch ((string)type[i])// DataType
							{
								case "1":
									sql1=sql1+"N'" + T_String.sqlsql(rs.record(j,fname[i]+"")) +"'";
									break;
								case "2":						
									sql1=sql1+"'"+  DateTime.Parse(rs.record(j,fname[i]+"")).ToString("yyyy/MM/dd HH:mm:ss")+"'";
									break;
								case "3":
									if (rs.record(j,fname[i]+"")=="True")
										sql1=sql1+ "1";
									else if (rs.record(j,fname[i]+"")=="False")
										sql1=sql1+"0";
									else
										sql1=sql1+ rs.record(j,fname[i]+"");
									break;												
								case "4":
									sql1=sql1 + rs.record(j,fname[i]+"");
									break;
								case "5":
									sql1=sql1 + rs.record(j,fname[i]+"");
									break;
								default:
									sql1=sql1+"N'" + T_String.sqlsql(rs.record(j,fname[i]+"")) +"'";					
									break;
							}
						}
					
						//Delete
						if ((Boolean)key[i])
						{
							if (wh!="") wh+=" and ";
						
							// Get TypeName of Field,  return {1 (nvarchar,char..), 2 (datetime), 3 (bit), 4 (float), 5 (int)}
							switch ((string)type[i])// DataType
							{
								case "1":
									wh=wh+fname[i]+"=N'" + T_String.sqlsql(rs.record(j,fname[i]+"")) +"'";
									break;
								case "2":						
									wh=wh+fname[i]+"='"+  DateTime.Parse(rs.record(j,fname[i]+"")).ToString("yyyy/MM/dd HH:mm:ss")+"'";
									break;
								case "3":
									if (rs.record(j,fname[i]+"")=="True")
										wh=wh+fname[i]+ "=1";
									else if (rs.record(j,fname[i]+"")=="False")
										wh=wh+fname[i]+"=0";
									else
										wh=wh+fname[i]+"="+ rs.record(j,fname[i]+"");
									break;												
								case "4":
									wh=wh+fname[i]+"=" + rs.record(j,fname[i]+"");
									break;
								case "5":
									wh=wh+fname[i]+"=" + rs.record(j,fname[i]+"");
									break;
								default:
									wh=wh+fname[i]+"=N'" + T_String.sqlsql(rs.record(j,fname[i]+"")) +"'";					
									break;
							}
						}
						if ((Boolean)key[i])
						{
							if (st1!="") st1+=" and ";
							if (Func.Fun.GetTypeField(conto,table,fname[i]+"")=="2")
							{
								if (rs.record(j,fname[i]+"")+""=="")
									st1+=fname[i]+"=''";
								else
									st1+=fname[i]+"='"+  DateTime.Parse(rs.record(j,fname[i]+"")).ToString("yyyy/MM/dd HH:mm:ss") +"'";
							}
							else
							{
								st1+=fname[i]+"='"+  T_String.sqlsql(rs.record(j,fname[i]+""))+"'";
							}
						}
					}

					Boolean have=false;
					Func.RecordSet rr;
					if(wh!="")
					{
						rr=new Func.RecordSet("Select * from ["+table+"] where "+wh,conto);
						if(rr.rows>0)
							have=true;													
					}
					if(have)
					{
						if(update)
						{
							if(wh!="")
							{
								PublicFunction.SQL_Execute("Delete from ["+table+"] where "+wh,conto);
								PublicFunction.SQL_Execute(sql+sql1+")",conto);		
								for(int m=0;m<pic.Count;m++)
								{
					
									if(st1!="")
									{
										st="Select ["+pic[m]+"] from ["+table+"] where " + st1;
										UploadImageToSQL(LoadImageFrom(st,confr),pic[m]+"",table,wh,conto);
									}
								}	
								upd++;
							}
						}
					}
					else
					{
						if(insert)
						{
							PublicFunction.SQL_Execute(sql+sql1+")",conto);		
							for(int m=0;m<pic.Count;m++)
							{
					
								if(st1!="")
								{
									st="Select ["+pic[m]+"] from ["+table+"] where " + st1;
									UploadImageToSQL(LoadImageFrom(st,confr),pic[m]+"",table,wh,conto);
								}
							}		
							ins++;
						}
					}										

					lb.Text= "[Insert and Update] _ " +j+"/"+rs.rows+" records. ";
					pro.Value=(int)(j*100/rs.rows);								
				}
				lb.Text= "[Insert and Update] _ " +rs.rows+"/"+rs.rows+" records. ";
			}
			pro.Value=100;	
			li.Items.Add("___[Insert]:"+ins+" records.");
			li.Items.Add("___[Update]:"+upd+" records.");


			//delete
			if(delete)
			{
				sql="select * from "+table;
				rs=new Func.RecordSet(sql,conto);				
				for(int i=0;i<rs.cols;i++)
				{		
					fname=new ArrayList();
					key=new ArrayList();
					type=new ArrayList();
					pic=new ArrayList();
					if (Func.Fun.CheckFieldOfTable(confr,table,rs.Field(i)))
					{
						fname.Add(rs.Field(i));
						key.Add(Func.Fun.CheckPrimaryKey(confr,table,rs.Field(i)));
						st=Func.Fun.GetTypeField(confr,table,rs.Field(i));
						type.Add(st);
						if (i!=0) sql+=",";
						sql+="["+rs.Field(i)+"]";	
						if (st=="6")
							pic.Add(rs.Field(i));			
					}
				}
			
				sql+=") values(";
				for(int j=0;j<rs.rows;j++)
				{
					if(stop)
					{
						button1.Enabled=true;
						return;
					}
				
					sql1="";wh="";st1="";
					for(int i=0;i<fname.Count;i++)
					{	
				
						//insert
						if (sql1!="") sql1+=",";				
						
						//Delete
						if ((Boolean)key[i])
						{
							if (wh!="") wh+=" and ";
						
							// Get TypeName of Field,  return {1 (nvarchar,char..), 2 (datetime), 3 (bit), 4 (float), 5 (int)}
							switch ((string)type[i])// DataType
							{
								case "1":
									wh=wh+fname[i]+"=N'" + T_String.sqlsql(rs.record(j,fname[i]+"")) +"'";
									break;
								case "2":						
									wh=wh+fname[i]+"='"+  DateTime.Parse(rs.record(j,fname[i]+"")).ToString("yyyy/MM/dd HH:mm:ss")+"'";
									break;
								case "3":
									if (rs.record(j,fname[i]+"")=="True")
										wh=wh+fname[i]+ "=1";
									else if (rs.record(j,fname[i]+"")=="False")
										wh=wh+fname[i]+"=0";
									else
										wh=wh+fname[i]+"="+ rs.record(j,fname[i]+"");
									break;												
								case "4":
									wh=wh+fname[i]+"=" + rs.record(j,fname[i]+"");
									break;
								case "5":
									wh=wh+fname[i]+"=" + rs.record(j,fname[i]+"");
									break;
								default:
									wh=wh+fname[i]+"=N'" + T_String.sqlsql(rs.record(j,fname[i]+"")) +"'";					
									break;
							}
						}						
					}
					Boolean have=false;
					Func.RecordSet rr;
					if(wh!="")
					{
						rr=new Func.RecordSet("Select * from ["+table+"] where "+wh,confr);
						if(rr.rows>0)
							have=true;													
					}
					if(!have)
					{
						if(wh!="")
						{
							PublicFunction.SQL_Execute("Delete from ["+table+"] where "+wh,conto);														
							del++;
						}
					}					
					lb.Text= "[Delete] _ " +j+"/"+rs.rows+" records. ";
					pro.Value=(int)(j*100/rs.rows);								
				}
				pro.Value=100;	
				lb.Text= "[Delete] _ " +rs.rows+"/"+rs.rows+" records. ";
				li.Items.Add("___[Delete]:"+del+" records.");
			}
		}

		public  void UploadImageToSQL(byte[] bytes,string Field,string Table,string where,SqlConnection con)
		{
			
			try
			{
				string sql=null;
				sql="update "+Table+" set "+Field+" =@image";
				if (where !="")
				{
					sql=sql+" where " + where;
				}				
				//byte[] bytes = ImageFunction.ReadBitmapFromFile(ImageFile);
				SqlCommand cmd =new SqlCommand(sql,con); 
				SqlParameter  imageParameter = cmd.Parameters.Add("@image",SqlDbType.Binary );
				imageParameter.Value =bytes ;
				imageParameter.Size =bytes.Length ;
				cmd.ExecuteNonQuery();				
			}
			catch
			{
				throw;
			}
		
		}
		public byte[] LoadImageFrom(string sql,SqlConnection conm)
		{		
			try
			{
				SqlCommand Sqlcmd=new SqlCommand(sql,conm );
			
				object obj = Sqlcmd.ExecuteScalar();
				if (obj == System.DBNull.Value || obj==null)
				{				
					return null;
				}
				byte[] content = (byte[])obj;
				if (content.Length<=0) 
					return null;
				System.IO.MemoryStream stream = new System.IO.MemoryStream(content);
				return stream.ToArray();
			}
			catch(SqlException ex)
			{
				MessageBox.Show(ex.Message);
				return null;
			}
		}

		private void vs_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			for (int i=vs.Selection.r1;i<=vs.Selection.r2;i++)
			{
				for (int j=vs.Selection.c1;j<=vs.Selection.c2;j++)
				{
					if (vs.Cols[j].DataType==typeof(Boolean))
					{
						vs[i,j ]=vs[e.Row,e.Col];
						vs.Rows[i].UserData=1;
					}
				}
			}
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void frmTaTransferToGPS_Closed(object sender, System.EventArgs e)
		{
			stop=true;
		}

		private void c1DateEdit1_TextChanged(object sender, System.EventArgs e)
		{
		
		}
	}
}
