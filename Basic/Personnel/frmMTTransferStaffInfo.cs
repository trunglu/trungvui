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

namespace GP8000.Payroll
{
	/// <summary>
	/// Summary description for frmTaTransfer.
	/// </summary>
	public class frmMTTransferStaffInfo : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Panel panel7;
		private Navigator1._0.NavigatorAuto nav;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Splitter splitter1;
		private C1.Win.C1FlexGrid.C1FlexGrid vs;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton r2;
		private System.Windows.Forms.RadioButton r1;
		private GP8000.UserControl.CrtTaCondition1 control1;
		private System.Windows.Forms.Label label1;
		private C1.Win.C1Input.C1DateEdit dt1;
		private C1.Win.C1Input.C1DateEdit dt2;
		private System.Windows.Forms.Button cmd_close;
		private System.Windows.Forms.Button cmd_tran;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Label c1;
		private System.Windows.Forms.ProgressBar pro1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmMTTransferStaffInfo()
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
			this.c1 = new System.Windows.Forms.Label();
			this.pro1 = new System.Windows.Forms.ProgressBar();
			this.panel6 = new System.Windows.Forms.Panel();
			this.panel5 = new System.Windows.Forms.Panel();
			this.dt1 = new C1.Win.C1Input.C1DateEdit();
			this.control1 = new GP8000.UserControl.CrtTaCondition1();
			this.dt2 = new C1.Win.C1Input.C1DateEdit();
			this.label1 = new System.Windows.Forms.Label();
			this.cmd_close = new System.Windows.Forms.Button();
			this.cmd_tran = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.r2 = new System.Windows.Forms.RadioButton();
			this.r1 = new System.Windows.Forms.RadioButton();
			this.splitter1 = new System.Windows.Forms.Splitter();
			this.panel4 = new System.Windows.Forms.Panel();
			this.vs = new C1.Win.C1FlexGrid.C1FlexGrid();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label5 = new System.Windows.Forms.Label();
			this.panel7 = new System.Windows.Forms.Panel();
			this.nav = new Navigator1._0.NavigatorAuto();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dt1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dt2)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.panel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.vs)).BeginInit();
			this.panel3.SuspendLayout();
			this.panel7.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Controls.Add(this.panel3);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(788, 452);
			this.panel1.TabIndex = 0;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.c1);
			this.panel2.Controls.Add(this.pro1);
			this.panel2.Controls.Add(this.panel6);
			this.panel2.Controls.Add(this.panel5);
			this.panel2.Controls.Add(this.splitter1);
			this.panel2.Controls.Add(this.panel4);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 36);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(788, 416);
			this.panel2.TabIndex = 9;
			// 
			// c1
			// 
			this.c1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.c1.BackColor = System.Drawing.Color.Black;
			this.c1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.c1.ForeColor = System.Drawing.Color.White;
			this.c1.Location = new System.Drawing.Point(4, 380);
			this.c1.Name = "c1";
			this.c1.Size = new System.Drawing.Size(780, 28);
			this.c1.TabIndex = 181;
			this.c1.Tag = "N";
			this.c1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pro1
			// 
			this.pro1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pro1.Location = new System.Drawing.Point(4, 360);
			this.pro1.Name = "pro1";
			this.pro1.Size = new System.Drawing.Size(780, 16);
			this.pro1.TabIndex = 180;
			// 
			// panel6
			// 
			this.panel6.BackColor = System.Drawing.Color.CornflowerBlue;
			this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel6.Location = new System.Drawing.Point(0, 352);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(788, 4);
			this.panel6.TabIndex = 179;
			// 
			// panel5
			// 
			this.panel5.Controls.Add(this.dt1);
			this.panel5.Controls.Add(this.control1);
			this.panel5.Controls.Add(this.dt2);
			this.panel5.Controls.Add(this.label1);
			this.panel5.Controls.Add(this.cmd_close);
			this.panel5.Controls.Add(this.cmd_tran);
			this.panel5.Controls.Add(this.label6);
			this.panel5.Controls.Add(this.groupBox1);
			this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel5.Location = new System.Drawing.Point(0, 187);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(788, 165);
			this.panel5.TabIndex = 178;
			// 
			// dt1
			// 
			this.dt1.CustomFormat = "yyyyMM";
			this.dt1.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat;
			this.dt1.Location = new System.Drawing.Point(516, 16);
			this.dt1.Name = "dt1";
			this.dt1.Size = new System.Drawing.Size(120, 23);
			this.dt1.TabIndex = 170;
			this.dt1.Tag = null;
			// 
			// control1
			// 
			this.control1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.control1.Location = new System.Drawing.Point(4, -4);
			this.control1.Name = "control1";
			this.control1.Size = new System.Drawing.Size(444, 164);
			this.control1.TabIndex = 173;
			// 
			// dt2
			// 
			this.dt2.CustomFormat = "yyyyMM";
			this.dt2.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat;
			this.dt2.Location = new System.Drawing.Point(516, 44);
			this.dt2.Name = "dt2";
			this.dt2.Size = new System.Drawing.Size(120, 23);
			this.dt2.TabIndex = 174;
			this.dt2.Tag = null;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(452, 44);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(72, 23);
			this.label1.TabIndex = 175;
			this.label1.Text = "label1";
			// 
			// cmd_close
			// 
			this.cmd_close.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_close.Location = new System.Drawing.Point(648, 100);
			this.cmd_close.Name = "cmd_close";
			this.cmd_close.Size = new System.Drawing.Size(136, 40);
			this.cmd_close.TabIndex = 177;
			this.cmd_close.Text = "button3";
			this.cmd_close.Click += new System.EventHandler(this.cmd_close_Click);
			// 
			// cmd_tran
			// 
			this.cmd_tran.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_tran.Location = new System.Drawing.Point(648, 28);
			this.cmd_tran.Name = "cmd_tran";
			this.cmd_tran.Size = new System.Drawing.Size(136, 40);
			this.cmd_tran.TabIndex = 176;
			this.cmd_tran.Text = "cal";
			this.cmd_tran.Click += new System.EventHandler(this.cmd_tran_Click);
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(452, 16);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(72, 23);
			this.label6.TabIndex = 171;
			this.label6.Text = "label6";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.r2);
			this.groupBox1.Controls.Add(this.r1);
			this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox1.Location = new System.Drawing.Point(452, 80);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(184, 76);
			this.groupBox1.TabIndex = 172;
			this.groupBox1.TabStop = false;
			this.groupBox1.Tag = "N";
			// 
			// r2
			// 
			this.r2.Checked = true;
			this.r2.Location = new System.Drawing.Point(12, 44);
			this.r2.Name = "r2";
			this.r2.Size = new System.Drawing.Size(168, 24);
			this.r2.TabIndex = 1;
			this.r2.TabStop = true;
			this.r2.Text = "radioButton2";
			// 
			// r1
			// 
			this.r1.Location = new System.Drawing.Point(12, 16);
			this.r1.Name = "r1";
			this.r1.Size = new System.Drawing.Size(168, 24);
			this.r1.TabIndex = 0;
			this.r1.Text = "radioButton1";
			// 
			// splitter1
			// 
			this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
			this.splitter1.Location = new System.Drawing.Point(0, 184);
			this.splitter1.Name = "splitter1";
			this.splitter1.Size = new System.Drawing.Size(788, 3);
			this.splitter1.TabIndex = 1;
			this.splitter1.TabStop = false;
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.vs);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel4.Location = new System.Drawing.Point(0, 0);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(788, 184);
			this.panel4.TabIndex = 0;
			// 
			// vs
			// 
			this.vs.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.Both;
			this.vs.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.XpThemes;
			this.vs.ColumnInfo = "10,1,0,0,0,100,Columns:0{Width:38;}\t";
			this.vs.Dock = System.Windows.Forms.DockStyle.Fill;
			this.vs.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
			this.vs.Location = new System.Drawing.Point(0, 0);
			this.vs.Name = "vs";
			this.vs.Size = new System.Drawing.Size(788, 184);
			this.vs.Styles = ((C1.Win.C1FlexGrid.CellStyleCollection)(new C1.Win.C1FlexGrid.CellStyleCollection("")));
			this.vs.TabIndex = 14;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.panel3.Controls.Add(this.label5);
			this.panel3.Controls.Add(this.panel7);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel3.Location = new System.Drawing.Point(0, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(788, 36);
			this.panel3.TabIndex = 8;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label5.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.label5.Location = new System.Drawing.Point(348, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(440, 36);
			this.label5.TabIndex = 12;
			this.label5.Tag = "";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel7
			// 
			this.panel7.Controls.Add(this.nav);
			this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel7.Location = new System.Drawing.Point(0, 0);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(348, 36);
			this.panel7.TabIndex = 0;
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
			this.nav.Location = new System.Drawing.Point(0, 2);
			this.nav.MSG_Exit = false;
			this.nav.MulltiDel = false;
			this.nav.Name = "nav";
			this.nav.Security = 0;
			this.nav.ShowPopupMenu = true;
			this.nav.Size = new System.Drawing.Size(400, 32);
			this.nav.TabIndex = 14;
			this.nav.Tag = "";
			this.nav.ToolBar_Auto = true;
			this.nav.UserID = null;
			this.nav.VisibleGrid = true;
			this.nav.Where = null;
			// 
			// frmMTTransferStaffInfo
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
			this.ClientSize = new System.Drawing.Size(788, 452);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "frmMTTransferStaffInfo";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmMTTransferStaffInfo";
			this.Load += new System.EventHandler(this.frmTaTransfer_Load);
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel5.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dt1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dt2)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.vs)).EndInit();
			this.panel3.ResumeLayout(false);
			this.panel7.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void frmTaTransfer_Load(object sender, System.EventArgs e)
		{
			Init_Form();						
		}
		private void Init_Form()
		{		
			//dt.Value=T_String.GetDate();
			Init_vs();
			control1.InitCB(this.Tag);
			control1.Initlabel();	
			dt1.Value=dt2.Value=T_String.GetDate();	
			Basic.Function.PublicFunction.L_Init_Label(this);				
		}

		private void Init_vs()
		{		
			nav.cmd_copy.Visible=false;
			nav.cmd_report.Visible=false;
			nav.cmd_search.Visible=false;
			nav.cmd_delete.Visible=false;
			nav.cmd_add.Visible=false;		
			nav.cmd_save.Visible=false;		
			PublicFunction.InitNav(this,vs,nav);	
			vs.Cols["COL"].DataType=typeof(Boolean);
			nav.Show_VS("BAS_BT=0 or BAS_BT is null order by SEQ_NO");			
		}

		private void cmd_close_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void cmd_tran_Click(object sender, System.EventArgs e)
		{
			Thread th=new Thread(new ThreadStart(Transfer));
			th.Start();
		}

		private void Transfer()
		{
			cmd_tran.Enabled=control1.Enabled=false;			
			int SEQ_NO=1;
			if(r2.Checked)
				SEQ_NO=2;
			SqlConnection con=new SqlConnection(PublicFunction.C_con.ConnectionString);
			if(con.State==ConnectionState.Closed )
				con.Open();
			string sql="",dt=T_String.GetDate().ToString("yyyy/MM/dd HH:mm");
			control1.Enabled=true;
			sql="Select a.EMP_ID,EMP_NM,b.DEP_ID  ";
			for(int j=1;j<vs.Rows.Count;j++)
			{
				if(vs.Rows[j]["COL"]+""=="True")
				{
					sql+=",["+vs.Rows[j]["COL_NM"]+"]";
				}
			}
			sql+=" from FILD02A a,FILB01A b where a.EMP_ID=b.EMP_ID and "
				+control1.GetWhere("b",true) +" and SEQ_NO="+SEQ_NO+" and YYY_MM=N'"+dt1.Text+"'";
			Func.RecordSet rs=new Func.RecordSet(sql,con);
			for (int i=0;i<rs.rows;i++)
			{
				c1.Text=rs.record(i,"EMP_ID")+"_"+rs.record(i,"EMP_NM")+"   _    "
					+(i+1)+"/"+rs.rows +"_" +((int)(i+1)*100/rs.rows) +"%";
				for(int j=1;j<vs.Rows.Count;j++)
				{
					if(vs.Rows[j]["COL"]+""=="True")
					{						
						sql="update FILD02A set ["+vs.Rows[j]["COL_NM"]+"]="
							+ T_String.IsNullTo00(rs.record(i,vs.Rows[j]["COL_NM"]+"")) +" where (["+vs.Rows[j]["COL_NM"]+"]=0 or"
							+ " ["+vs.Rows[j]["COL_NM"]+"] is null ) and EMP_ID=N'"+rs.record(i,"EMP_ID")
							+"' and YYY_MM=N'"+dt2.Text+"' and SEQ_NO="+SEQ_NO;
						PublicFunction.SQL_Execute(sql,con);
					}
				}
				pro1.Value=((int)(i+1)*100/rs.rows);
			}
			cmd_tran.Enabled=control1.Enabled=true;
			con.Close();
			MessageBox.Show(PublicFunction.L_Get_Msg("Staff",1));
			

		}
	}
}
