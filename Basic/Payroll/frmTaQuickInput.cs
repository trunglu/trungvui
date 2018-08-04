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
namespace GP8000.Payroll
{
	/// <summary>
	/// Summary description for frmTaQuickInput.
	/// </summary>
	public class frmTaQuickInput : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel5;
		private Navigator1._0.NavigatorAuto nav;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Panel panel8;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DateTimePicker dt;
		private System.Windows.Forms.Button cmd_add1;
		private System.Windows.Forms.Button cmd_add2;
		public Boolean acc=true;
		private System.Windows.Forms.TextBox wid;
		private System.Windows.Forms.TextBox dwid;
		private C1.Win.C1FlexGrid.C1FlexGrid vs;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmTaQuickInput()
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel5 = new System.Windows.Forms.Panel();
			this.nav = new Navigator1._0.NavigatorAuto();
			this.panel6 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label5 = new System.Windows.Forms.Label();
			this.panel4 = new System.Windows.Forms.Panel();
			this.panel8 = new System.Windows.Forms.Panel();
			this.dt = new System.Windows.Forms.DateTimePicker();
			this.label1 = new System.Windows.Forms.Label();
			this.wid = new System.Windows.Forms.TextBox();
			this.cmd_add1 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.dwid = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.cmd_add2 = new System.Windows.Forms.Button();
			this.vs = new C1.Win.C1FlexGrid.C1FlexGrid();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel5.SuspendLayout();
			this.panel6.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel8.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.vs)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Controls.Add(this.panel3);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(964, 500);
			this.panel1.TabIndex = 5;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.panel5);
			this.panel2.Controls.Add(this.panel6);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 36);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(964, 464);
			this.panel2.TabIndex = 6;
			// 
			// panel5
			// 
			this.panel5.Controls.Add(this.panel8);
			this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel5.Location = new System.Drawing.Point(0, 32);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(964, 432);
			this.panel5.TabIndex = 5;
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
			this.nav.Location = new System.Drawing.Point(4, 4);
			this.nav.MSG_Exit = false;
			this.nav.MulltiDel = false;
			this.nav.Name = "nav";
			this.nav.Security = 0;
			this.nav.ShowPopupMenu = true;
			this.nav.Size = new System.Drawing.Size(344, 32);
			this.nav.TabIndex = 11;
			this.nav.Tag = "";
			this.nav.ToolBar_Auto = true;
			this.nav.UserID = null;
			this.nav.VisibleGrid = true;
			this.nav.Where = null;
			// 
			// panel6
			// 
			this.panel6.BackColor = System.Drawing.Color.AliceBlue;
			this.panel6.Controls.Add(this.label1);
			this.panel6.Controls.Add(this.dwid);
			this.panel6.Controls.Add(this.label3);
			this.panel6.Controls.Add(this.dt);
			this.panel6.Controls.Add(this.cmd_add2);
			this.panel6.Controls.Add(this.cmd_add1);
			this.panel6.Controls.Add(this.wid);
			this.panel6.Controls.Add(this.label2);
			this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel6.Location = new System.Drawing.Point(0, 0);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(964, 32);
			this.panel6.TabIndex = 4;
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
			this.panel3.Size = new System.Drawing.Size(964, 36);
			this.panel3.TabIndex = 5;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label5.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.label5.Location = new System.Drawing.Point(348, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(616, 36);
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
			this.panel4.Size = new System.Drawing.Size(348, 36);
			this.panel4.TabIndex = 10;
			// 
			// panel8
			// 
			this.panel8.Controls.Add(this.vs);
			this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.panel8.Location = new System.Drawing.Point(0, 0);
			this.panel8.Name = "panel8";
			this.panel8.Size = new System.Drawing.Size(964, 432);
			this.panel8.TabIndex = 13;
			// 
			// dt
			// 
			this.dt.CustomFormat = "yyyy/MM/dd";
			this.dt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dt.Location = new System.Drawing.Point(100, 4);
			this.dt.Name = "dt";
			this.dt.Size = new System.Drawing.Size(108, 23);
			this.dt.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(4, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(96, 20);
			this.label1.TabIndex = 1;
			this.label1.Text = "label1";
			// 
			// wid
			// 
			this.wid.Location = new System.Drawing.Point(300, 4);
			this.wid.Name = "wid";
			this.wid.TabIndex = 2;
			this.wid.Text = "";
			this.wid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.wid_KeyDown);
			// 
			// cmd_add1
			// 
			this.cmd_add1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_add1.Location = new System.Drawing.Point(400, 4);
			this.cmd_add1.Name = "cmd_add1";
			this.cmd_add1.TabIndex = 3;
			this.cmd_add1.Text = "button1";
			this.cmd_add1.Click += new System.EventHandler(this.cmd_add1_Click);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(220, 8);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 20);
			this.label2.TabIndex = 4;
			this.label2.Text = "label2";
			// 
			// dwid
			// 
			this.dwid.Location = new System.Drawing.Point(592, 4);
			this.dwid.Name = "dwid";
			this.dwid.TabIndex = 5;
			this.dwid.Text = "";
			this.dwid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dwid_KeyDown);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(508, 8);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(84, 20);
			this.label3.TabIndex = 7;
			this.label3.Text = "label3";
			// 
			// cmd_add2
			// 
			this.cmd_add2.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_add2.Location = new System.Drawing.Point(692, 4);
			this.cmd_add2.Name = "cmd_add2";
			this.cmd_add2.TabIndex = 6;
			this.cmd_add2.Text = "button2";
			this.cmd_add2.Click += new System.EventHandler(this.cmd_add2_Click);
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
			this.vs.Size = new System.Drawing.Size(964, 432);
			this.vs.Styles = ((C1.Win.C1FlexGrid.CellStyleCollection)(new C1.Win.C1FlexGrid.CellStyleCollection("")));
			this.vs.TabIndex = 12;
			// 
			// frmTaQuickInput
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
			this.ClientSize = new System.Drawing.Size(964, 500);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "frmTaQuickInput";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmTaQuickInput";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.frmTaQuickInput_Load);
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel5.ResumeLayout(false);
			this.panel6.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.panel8.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.vs)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void frmTaQuickInput_Load(object sender, System.EventArgs e)
		{
			Init_vs();
			Basic.Function.PublicFunction.L_Init_Label(this);	
			dt.CustomFormat=PublicFunction.GetOption("DATE");
		}
		Func.RecordSet rsitem;
		private void Init_vs()
		{
//			vs.Rows[0].HeightDisplay= vs.Rows[0].HeightDisplay*2;
//			vs.Styles["Fixed"].WordWrap=true;
			nav.cmd_copy.Visible=false;
			nav.cmd_delete.Visible=false;
			nav.cmd_report.Visible=false;
			nav.cmd_search.Visible=false;
			nav.cmd_add.Visible=false;
			nav.cmd_refresh.Visible=false;
			nav.sql="SELECT SEQ_NO,a.EMP_ID,EMP_I1,EMP_NM,CHA_DT";
			string sql="";		
			sql="Select * from FILD01A  where BAS_BT=1 order by SEQ_NO";			
			rsitem=new Func.RecordSet(sql,PublicFunction.C_con);
			for(int i=0;i<rsitem.rows;i++)
			{
				nav.sql+=",["+rsitem.record(i,"COL_NM")+"]";
			}
			nav.sql+=",a.NOT_DR,a.BLT_NM,a.BLT_DT ";
			nav.sql+=" from FILD03A a Left JOIN FILB01A b on a.EMP_ID=b.EMP_ID  Left JOIN FILB01AC c on a.EMP_ID=c.EMP_ID";
			nav.tb="FILD03A";
			PublicFunction.InitNav(this,vs,nav);		
			nav.Msg_ExitSave=true;					
			
			vs.EnabledChanged+=new EventHandler(vs_EnabledChanged);			
			//			nav.ToolBar_Auto=false;
			//			nav.TBarClick+=new ToolBarButtonClickEventHandler(nav_TBarClick);	
		
			for(int i=0;i<rsitem.rows;i++)
			{
				vs.Cols[rsitem.record(i,"COL_NM")].Visible=false;
				if(rsitem.record(i,"COL_NM")!="BacLuong")
				{
					vs.Cols[rsitem.record(i,"COL_NM")].DataType=typeof(Double);
					vs.Cols[rsitem.record(i,"COL_NM")].Format="#,###";
				}
				vs.Cols[rsitem.record(i,"COL_NM")].Width=75;
			}			

			if(acc)
				sql="Select * from FILD01A  where BAS_BT=1 and ACC_BT=1 order by SEQ_NO";
			else
				sql="Select * from FILD01A  where BAS_BT=1 and HUR_BT=1 order by SEQ_NO";
			Func.RecordSet rs=new Func.RecordSet(sql,PublicFunction.C_con);
			for(int i=0;i<rs.rows;i++)
			{
				
				vs.Cols[rs.record(i,"COL_NM")].Visible=true;;
			}			
			vs.Cols.Frozen=vs.Cols["EMP_NM"].Index;
			vs.Cols["EMP_ID"].AllowEditing=false;
			vs.Cols["EMP_I1"].AllowEditing=false;
			vs.Cols["EMP_NM"].AllowEditing=false;
			//vs.Cols["CHA_DT"].AllowEditing=false;
			vs.Cols["CHA_DT"].Format=PublicFunction.GetOption("DATE");	
			vs.Cols["BLT_NM"].AllowEditing=false;
			vs.Cols["BLT_DT"].AllowEditing=false;					
			vs.AfterEdit+=new RowColEventHandler(vs_AfterEdit);
			vs.SelectionMode=C1.Win.C1FlexGrid.SelectionModeEnum.CellRange; 
		}

		private void vs_EnabledChanged(object sender, EventArgs e)
		{				
			for(int i=0;i<rsitem.rows;i++)
			{
				try
				{
					vs.Cols[rsitem.record(i,"COL_NM")].Caption=rsitem.record(i,"COL_"+PublicFunction.L_Lag);
				}
				catch{}
			}			
		}

		private void cmd_add1_Click(object sender, System.EventArgs e)
		{
			Func.RecordSet rs=new Func.RecordSet("Select EMP_ID,EMP_I1,EMP_NM from FILB01A where EMP_ID=N'"+wid.Text+"'",PublicFunction.C_con);
			add(rs);
			wid.Focus();
		}
		private void cmd_add2_Click(object sender, System.EventArgs e)
		{
			Func.RecordSet rs=new Func.RecordSet("Select EMP_ID,EMP_I1,EMP_NM from FILB01A where EMP_I1=N'"+dwid.Text+"'",PublicFunction.C_con);
			add(rs);
			dwid.Focus();
		}	
	
		
		private void dwid_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyCode==Keys.Enter)
			{
				Func.RecordSet rs=new Func.RecordSet("Select EMP_ID,EMP_I1,EMP_NM from FILB01A where EMP_I1=N'"+dwid.Text
					+"' and (DEL_BT=0 or DEL_BT is null)  and  "+PublicFunction.Get_TYP(this.Tag,""),PublicFunction.C_con);
				add(rs);
				dwid.Focus();
			}		
		}

		private void wid_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyCode==Keys.Enter)
			{
				Func.RecordSet rs=new Func.RecordSet("Select EMP_ID,EMP_I1,EMP_NM from FILB01A where EMP_ID=N'"+wid.Text
					+"' and (DEL_BT=0 or DEL_BT is null)  and  "+PublicFunction.Get_TYP(this.Tag,""),PublicFunction.C_con);
				add(rs);
				wid.Focus();
			}
		}	

		


		private void add(Func.RecordSet rs)
		{			
			if(rs.rows<=0)
				return;
			dwid.Text=wid.Text="";
			vs.Rows.Count++;
			int row=vs.Rows.Count-1;
			vs.Rows[row].UserData=2;
			vs.Rows[row][0]=row;
			vs.Rows[row]["EMP_ID"]=rs.record(0,"EMP_ID");
			vs.Rows[row]["EMP_I1"]=rs.record(0,"EMP_I1");
			vs.Rows[row]["EMP_NM"]=rs.record(0,"EMP_NM");
			vs.Rows[row]["CHA_DT"]=DateTime.Parse(dt.Value+"").ToString("yyyy/MM/dd");
			vs.Rows[row]["BLT_NM"]=PublicFunction.A_UserID;			
			vs.Rows[row]["BLT_DT"]=T_String.GetDate().ToString("yyyy/MM/dd HH:mm");
			GetOldSalary(row,rs.record(0,"EMP_ID"));
			vs.AutoSizeCols();
		}
		private void GetOldSalary(int row,string EMP_ID)
		{
			vs.Rows[row]["SEQ_NO"]=T_String.GetMax("MAX(SEQ_NO)","FILD03A","EMP_ID=N'"+EMP_ID+"'");
			string sql;
			sql="Select * from FILD03A where EMP_ID=N'"+EMP_ID+"' and (DON_AP=0 or DON_AP is null) ORDER BY SEQ_NO DESC";
			Func.RecordSet rs=new Func.RecordSet(sql,PublicFunction.C_con);
			if(rs.rows<=0) return;			
			for(int i=0;i<rsitem.rows;i++)
			{
				vs.Rows[vs.Row][rsitem.record(i,"COL_NM")]=rs.record(0,rsitem.record(i,"COL_NM"));			
			}
		}

		private void vs_AfterEdit(object sender, RowColEventArgs e)
		{
			string dt=T_String.GetDate().ToString("yyyy/MM/dd HH:mm");
			for (int i=vs.Selection.r1;i<=vs.Selection.r2;i++)
			{
				for (int j=vs.Selection.c1;j<=vs.Selection.c2;j++)
				{
					if(PublicFunction.CUS_ID=="51")
						vs[i,j ]=vs[e.Row,e.Col];
					else
					{
						if (vs.Cols[j].AllowEditing && vs.Cols[j].DataType==typeof(double))
						{
							vs[i,j ]=vs[e.Row,e.Col];										
						}
					}
				}				
			}
		}

	


	
	}
}
