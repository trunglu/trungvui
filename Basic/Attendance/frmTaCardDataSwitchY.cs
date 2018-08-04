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
using Microsoft.VisualBasic;
using GP8000.Function;

namespace GP8000.Attendance
{
	/// <summary>
	/// Summary description for frmTaCardDataSwitch.
	/// </summary>
	public class frmTaCardDataSwitch : System.Windows.Forms.Form
	{
		private float MAX_OT_WEEK, MAX_OT_YEAR;	//Dung cho han che tang ca trong GPS
		private int numTransfered;

		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label1;
		private C1.Win.C1Input.C1DateEdit dt2;
		private C1.Win.C1Input.C1DateEdit dt1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Button cmd_att;
		private GP8000.UserControl.CrtTaCondition1 control1;
		private System.Windows.Forms.Button cmd_close;
		private Func.RecordSet Set,rsTypeShift,rsType;
		private System.Windows.Forms.Label label3;
		private Boolean Stop;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.ProgressBar pro1;
		private System.Windows.Forms.ProgressBar pro2;
		private System.Windows.Forms.Label c1;
		private System.Windows.Forms.Label c3;
		private System.Windows.Forms.Label tm;
		private System.Windows.Forms.TextBox err;
		private System.Windows.Forms.Button cmd_Stop;
		private System.ComponentModel.IContainer components;
		//private string table;

		public frmTaCardDataSwitch()
		{
			//
			// Required for Windows Form Designer support
			//
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
			this.components = new System.ComponentModel.Container();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label5 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.err = new System.Windows.Forms.TextBox();
			this.tm = new System.Windows.Forms.Label();
			this.panel7 = new System.Windows.Forms.Panel();
			this.panel6 = new System.Windows.Forms.Panel();
			this.c3 = new System.Windows.Forms.Label();
			this.c1 = new System.Windows.Forms.Label();
			this.pro2 = new System.Windows.Forms.ProgressBar();
			this.pro1 = new System.Windows.Forms.ProgressBar();
			this.label4 = new System.Windows.Forms.Label();
			this.panel5 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.cmd_Stop = new System.Windows.Forms.Button();
			this.dt2 = new C1.Win.C1Input.C1DateEdit();
			this.dt1 = new C1.Win.C1Input.C1DateEdit();
			this.label1 = new System.Windows.Forms.Label();
			this.cmd_close = new System.Windows.Forms.Button();
			this.cmd_att = new System.Windows.Forms.Button();
			this.control1 = new GP8000.UserControl.CrtTaCondition1();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.panel3.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel6.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dt2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dt1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.panel3.Controls.Add(this.label5);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel3.Location = new System.Drawing.Point(0, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(992, 36);
			this.panel3.TabIndex = 13;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label5.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.label5.Location = new System.Drawing.Point(0, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(992, 36);
			this.label5.TabIndex = 11;
			this.label5.Tag = "";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.panel4);
			this.panel1.Controls.Add(this.panel5);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 36);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(992, 580);
			this.panel1.TabIndex = 14;
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.err);
			this.panel4.Controls.Add(this.tm);
			this.panel4.Controls.Add(this.panel7);
			this.panel4.Controls.Add(this.panel6);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel4.Location = new System.Drawing.Point(0, 180);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(992, 400);
			this.panel4.TabIndex = 9;
			// 
			// err
			// 
			this.err.BackColor = System.Drawing.Color.LightSteelBlue;
			this.err.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.err.Dock = System.Windows.Forms.DockStyle.Fill;
			this.err.Location = new System.Drawing.Point(0, 136);
			this.err.Multiline = true;
			this.err.Name = "err";
			this.err.ReadOnly = true;
			this.err.Size = new System.Drawing.Size(992, 264);
			this.err.TabIndex = 17;
			this.err.Text = "";
			// 
			// tm
			// 
			this.tm.BackColor = System.Drawing.Color.Black;
			this.tm.Dock = System.Windows.Forms.DockStyle.Top;
			this.tm.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tm.ForeColor = System.Drawing.Color.Red;
			this.tm.Location = new System.Drawing.Point(0, 108);
			this.tm.Name = "tm";
			this.tm.Size = new System.Drawing.Size(992, 28);
			this.tm.TabIndex = 16;
			this.tm.Tag = "N";
			this.tm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel7
			// 
			this.panel7.BackColor = System.Drawing.Color.CornflowerBlue;
			this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel7.Location = new System.Drawing.Point(0, 104);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(992, 4);
			this.panel7.TabIndex = 10;
			// 
			// panel6
			// 
			this.panel6.Controls.Add(this.c3);
			this.panel6.Controls.Add(this.c1);
			this.panel6.Controls.Add(this.pro2);
			this.panel6.Controls.Add(this.pro1);
			this.panel6.Controls.Add(this.label4);
			this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel6.Location = new System.Drawing.Point(0, 0);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(992, 104);
			this.panel6.TabIndex = 9;
			// 
			// c3
			// 
			this.c3.BackColor = System.Drawing.Color.Black;
			this.c3.Dock = System.Windows.Forms.DockStyle.Top;
			this.c3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.c3.ForeColor = System.Drawing.Color.White;
			this.c3.Location = new System.Drawing.Point(0, 79);
			this.c3.Name = "c3";
			this.c3.Size = new System.Drawing.Size(992, 24);
			this.c3.TabIndex = 13;
			this.c3.Tag = "N";
			this.c3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// c1
			// 
			this.c1.BackColor = System.Drawing.Color.Black;
			this.c1.Dock = System.Windows.Forms.DockStyle.Top;
			this.c1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.c1.ForeColor = System.Drawing.Color.White;
			this.c1.Location = new System.Drawing.Point(0, 55);
			this.c1.Name = "c1";
			this.c1.Size = new System.Drawing.Size(992, 24);
			this.c1.TabIndex = 12;
			this.c1.Tag = "N";
			this.c1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pro2
			// 
			this.pro2.Dock = System.Windows.Forms.DockStyle.Top;
			this.pro2.Location = new System.Drawing.Point(0, 39);
			this.pro2.Name = "pro2";
			this.pro2.Size = new System.Drawing.Size(992, 16);
			this.pro2.TabIndex = 11;
			// 
			// pro1
			// 
			this.pro1.Dock = System.Windows.Forms.DockStyle.Top;
			this.pro1.Location = new System.Drawing.Point(0, 23);
			this.pro1.Name = "pro1";
			this.pro1.Size = new System.Drawing.Size(992, 16);
			this.pro1.TabIndex = 10;
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.label4.Dock = System.Windows.Forms.DockStyle.Top;
			this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.RoyalBlue;
			this.label4.Location = new System.Drawing.Point(0, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(992, 23);
			this.label4.TabIndex = 0;
			this.label4.Text = "label4";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel5
			// 
			this.panel5.BackColor = System.Drawing.Color.CornflowerBlue;
			this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel5.Location = new System.Drawing.Point(0, 176);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(992, 4);
			this.panel5.TabIndex = 1;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.cmd_Stop);
			this.panel2.Controls.Add(this.dt2);
			this.panel2.Controls.Add(this.dt1);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Controls.Add(this.cmd_close);
			this.panel2.Controls.Add(this.cmd_att);
			this.panel2.Controls.Add(this.control1);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(992, 176);
			this.panel2.TabIndex = 0;
			// 
			// cmd_Stop
			// 
			this.cmd_Stop.Enabled = false;
			this.cmd_Stop.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_Stop.Location = new System.Drawing.Point(688, 68);
			this.cmd_Stop.Name = "cmd_Stop";
			this.cmd_Stop.Size = new System.Drawing.Size(136, 40);
			this.cmd_Stop.TabIndex = 155;
			this.cmd_Stop.Text = "button1";
			this.cmd_Stop.Click += new System.EventHandler(this.cmd_Stop_Click);
			// 
			// dt2
			// 
			this.dt2.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat;
			this.dt2.Location = new System.Drawing.Point(536, 44);
			this.dt2.Name = "dt2";
			this.dt2.Size = new System.Drawing.Size(132, 23);
			this.dt2.TabIndex = 150;
			this.dt2.Tag = null;
			// 
			// dt1
			// 
			this.dt1.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat;
			this.dt1.Location = new System.Drawing.Point(536, 16);
			this.dt1.Name = "dt1";
			this.dt1.Size = new System.Drawing.Size(132, 23);
			this.dt1.TabIndex = 149;
			this.dt1.Tag = null;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(452, 20);
			this.label1.Name = "label1";
			this.label1.TabIndex = 1;
			this.label1.Text = "label1";
			// 
			// cmd_close
			// 
			this.cmd_close.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_close.Location = new System.Drawing.Point(688, 120);
			this.cmd_close.Name = "cmd_close";
			this.cmd_close.Size = new System.Drawing.Size(136, 40);
			this.cmd_close.TabIndex = 154;
			this.cmd_close.Text = "button3";
			this.cmd_close.Click += new System.EventHandler(this.cmd_close_Click);
			// 
			// cmd_att
			// 
			this.cmd_att.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_att.Location = new System.Drawing.Point(688, 16);
			this.cmd_att.Name = "cmd_att";
			this.cmd_att.Size = new System.Drawing.Size(136, 40);
			this.cmd_att.TabIndex = 152;
			this.cmd_att.Text = "button1";
			this.cmd_att.Click += new System.EventHandler(this.cmd_att_Click);
			// 
			// control1
			// 
			this.control1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.control1.Location = new System.Drawing.Point(0, 4);
			this.control1.Name = "control1";
			this.control1.Size = new System.Drawing.Size(444, 164);
			this.control1.TabIndex = 0;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.SystemColors.Control;
			this.label3.Location = new System.Drawing.Point(512, 92);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(32, 23);
			this.label3.TabIndex = 156;
			this.label3.Tag = "N";
			this.label3.Text = "->>";
			this.label3.Visible = false;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(452, 48);
			this.label2.Name = "label2";
			this.label2.TabIndex = 151;
			this.label2.Text = "label2";
			// 
			// timer1
			// 
			this.timer1.Interval = 1000;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// frmTaCardDataSwitch
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
			this.ClientSize = new System.Drawing.Size(992, 616);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel3);
			this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "frmTaCardDataSwitch";
			this.Text = "frmTaCardDataSwitch";
			this.Load += new System.EventHandler(this.frmTaCardDataSwitch_Load);
			this.Closed += new System.EventHandler(this.frmTaCardDataSwitch_Closed_1);
			this.panel3.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.panel6.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dt2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dt1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void frmTaCardDataSwitch_Load(object sender, System.EventArgs e)
		{
			//Lock Fashionline: 2012/08/14
			if (DateAndTime.DateDiff("D", "2012/08/14", T_String.GetDate().ToString("yyyy/MM/dd"),
				Microsoft.VisualBasic.FirstDayOfWeek.Sunday, Microsoft.VisualBasic.FirstWeekOfYear.Jan1)<=0)
			if(!PublicFunction.GPS)
			{
				string dt60=PublicFunction.GetOption("DT6000");
				if(dt60+""=="1")
				{
					if(PublicFunction.AccessLevel(36,3))
					{
						frmTaGetDataFrDT TaGetDataFrDT=new frmTaGetDataFrDT();
						TaGetDataFrDT.Tag=this.Tag;
						TaGetDataFrDT.ShowDialog();
					}
				}
				else
				{
					string chuyenschema=PublicFunction.GetOption("SCHEMA");
					if (chuyenschema+""=="1")
					{
						frmTaTransferFromTXTSC dlg=new frmTaTransferFromTXTSC();
						dlg.ShowDialog();
					}
					else
					{
						frmTaTransferFromTXT dlg=new frmTaTransferFromTXT();
						dlg.ShowDialog();
					}
				}
			}
			else
			{
				cmd_Stop.Visible = false;
				pro2.Visible=false;
			}

			Basic.Function.PublicFunction.L_Init_Label(this);
			control1.InitCB(this.Tag);
			control1.Initlabel();
			DateTime dt=T_String.GetDate();
			dt2.Value=dt;
			dt1.Value=dt.AddDays(-1);
			dt1.CustomFormat=dt2.CustomFormat=PublicFunction.GetOption("DATE");
			this.Closed+=new EventHandler(frmTaCardDataSwitch_Closed);

			if (File.Exists("att.txt"))
			{
				cmd_Stop.Enabled = true;
				cmd_Stop.Text = PublicFunction.L_GetLabel(this.Name, 8);
				SetCondition();
			}
			else
				cmd_Stop.Tag = "Pause";
		}

		private void CheckFieldName()
		{
			rsTypeShift=new Func.RecordSet("Select * from GP_SYS_SHIFT",PublicFunction.C_con);
			for(int i=0;i<rsTypeShift.rows;i++)
			{
				if (!Func.Fun.CheckFieldOfTable(PublicFunction.C_con,"FILC06A",rsTypeShift.record(i,"TYP_ID")))
				{
					string sql;
					sql="Alter table FILC06A Add ["+rsTypeShift.record(i,"TYP_ID")+"] float";
					PublicFunction.SQL_Execute(sql);
					sql="Alter table FILC06AA Add ["+rsTypeShift.record(i,"TYP_ID")+"] float";
					PublicFunction.SQL_Execute(sql);
				}
			}
		}
		private void cmd_close_Click(object sender, System.EventArgs e)
		{
			Stop=true;
			this.Close();
		}
		private void cmd_att_Click(object sender, System.EventArgs e)
		{
			if (sender != null)
				numTransfered = 0;
			control1.Enabled = dt1.Enabled = dt2.Enabled = false;
			cmd_close.Enabled = false;
			cmd_att.Enabled=false;
			cmd_Stop.Enabled = false;
			err.Text = "";

			timer1.Enabled=true;
			timer1.Start();

			if(PublicFunction.GPS)
			{
				Stop=false;

				Thread th1=new Thread(new ThreadStart(Transfer_GPS));
				th1.Start();
//				Transfer_GPS();
			}
			else
			{
				cmd_Stop.Text = PublicFunction.L_GetLabel(this.Name, 7);
				cmd_Stop.Tag = "Pause";

				Thread th=new Thread(new ThreadStart(Transfer));
				th.Priority = ThreadPriority.Highest;
				th.Start();
//				Transfer();
			}
		}

		#region GPS
		private void Transfer_GPS()
		{
			c1.Text="";
			c3.Text="";
			string sql="";
			SqlConnection con1=new SqlConnection(PublicFunction.C_con.ConnectionString);
			con1.Open();
			if(!Func.Fun.CheckFieldOfTable(con1, "FILC06AS","hqtan_TT"))
			{
				sql="Alter table FILC06AS Add [hqtan_TT] float default(0)";
				PublicFunction.SQL_Execute(sql,con1);
			}
			if(!Func.Fun.CheckFieldOfTable(con1,"FILC06AS","hqtan_TT1"))
			{
				sql="Alter table FILC06AS Add [hqtan_TT1] float default(0)";
				PublicFunction.SQL_Execute(sql,con1);
			}
			string table="FILC06A_"+PublicFunction.A_UserID;
			sql="Drop Table ["+table+"]";
			try
			{
				PublicFunction.SQL_Execute(sql,con1);
			}
			catch{}
			PublicFunction.Copy_Table("FILC06AS",table,con1);

			cmd_att.Enabled=false;

			DateTime d1=(DateTime)dt1.Value;
			DateTime d2=(DateTime)dt2.Value;
			string wh=  " EMP_ID in (select DISTINCT EMP_ID from FILB01A where " +control1.GetWhere("",false)
				+") and ( ATT_DT between '"+d1.ToString("yyyy/MM/dd")+"' and '"+d2.ToString("yyyy/MM/dd")+"')";

			ImportTable(true,"FILC06A",table,con1,true,true,true,label4,pro1,wh);
			PublicFunction.SQL_Execute("UPDATE [" + table + "] SET LOC_B1=0, USR_CK=''", con1);
			
			string sql1="Select * from FILC08AS where RUN_BT=1 order by SEQ_N1";
			Func.RecordSet rs=new Func.RecordSet(sql1,con1);
			//SSSSSPG
			sql1 = "SELECT ISNULL(MAX_WK,0) MAX_WK, ISNULL(MAX_YR,0) MAX_YR FROM GP_SYS_SETTING";
			Func.RecordSet rsSet = new Func.RecordSet(sql1, con1);
			MAX_OT_WEEK = float.Parse(rsSet.record(0, "MAX_WK"));
			MAX_OT_YEAR = float.Parse(rsSet.record(0, "MAX_YR"));

			if(T_String.GetDataFromSQL("WEE_BY","FILC14A",con1)=="False")
				GPSSSSSSS(table,con1,true,label4,pro1);
			else
				GPSSSSSSS(table,con1,false,label4,pro1);
			// Formula
			c1.Text="*** Formula ***";
			try
			{
				for(int i=0;i<rs.rows;i++)
				{
					if(Stop)
						return;
					sql=rs.record(i,"SQL_DR");
					if(sql+""!="")
					{
						sql=sql.Replace("FILC06AS","[" + table + "]").Replace("[[" + table + "]]", "[" + table + "]");
						PublicFunction.SQL_Execute(sql,con1,true);
					}
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

			sql = "SET ROWCOUNT 1000 \r\n"
				+ "WHILE 1=1 \r\n"
				+ "BEGIN \r\n"
				+ "DELETE FROM FILC06AS WHERE EXISTS (SELECT 1 FROM [" + table + "] WHERE EMP_ID=FILC06AS.EMP_ID)"
				+ " AND ATT_DT BETWEEN '" + ((DateTime)dt1.Value).ToString("yyyy/MM/dd") 
				+ "' AND '" + ((DateTime)dt2.Value).ToString("yyyy/MM/dd") + "' AND ISNULL(LOC_B1,0)=0 \r\n"
				+ " IF @@ROWCOUNT=0 BREAK \r\n"
				+ "END \r\n"
				+ "SET ROWCOUNT 0";
			PublicFunction.SQL_Execute(sql, con1, 200);

			PublicFunction.SQL_Execute(sql,con1,true);

			sql="Insert into FILC06AS select * from ["+table+"]"
				+ " WHERE NOT EXISTS (SELECT EMP_ID FROM FILC06AS WHERE FILC06AS.ATT_DT=[" + table + "].ATT_DT"
				+ " AND FILC06AS.EMP_ID=[" + table + "].EMP_ID AND FILC06AS.LOC_B1=1)";
			PublicFunction.SQL_Execute(sql,con1,100);

			//Khoi tao lai ban dau
			control1.Enabled = dt1.Enabled = dt2.Enabled = true;
			cmd_att.Enabled= cmd_Stop.Enabled = cmd_close.Enabled = true;
			timer1.Stop();
			timer1.Enabled=false;
			con1.Close();

			c3.Text=PublicFunction.L_Get_Msg("Staff",1);	
			//MessageBox.Show(PublicFunction.L_Get_Msg("Staff",1));	
		}

		private void GPSSSSSSS(string tb,SqlConnection con1,Boolean type,Label lb,ProgressBar pro)
		{
			DateTime d1=(DateTime)dt1.Value;
			DateTime d2=(DateTime)dt2.Value;
			DateTime d = d1;
			long dd, days = DateAndTime.DateDiff("D", d1, d2, FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1);
			string sql, GRP_FO="";

			dd = 0;
			//Chay cong thuc GPS
			while (dd<=days)
			{
				if (Stop) return;
				
				sql="";
				if (type)
				{
					sql="select h"+d.Day+" from FILC13A where YYY_YY=N'"+d.Year.ToString("0000")+"' and MMM_MM="+d.Month;
					Func.RecordSet rs=new Func.RecordSet(sql,con1);
					if(rs.rows>0 && rs.record(0,0)!="" && rs.record(0,0)!=null)
					{
						GRP_FO = rs.record(0,0);
						CALGPS(tb, GRP_FO, d.ToString("yyyy/MM/dd"), con1, con1);
					}
				}
				else
				{
					switch(d.DayOfWeek)
					{
						case DayOfWeek.Monday:
							sql="1";
							break;
						case DayOfWeek.Tuesday:
							sql="2";
							break;
						case DayOfWeek.Wednesday:
							sql="3";
							break;
						case DayOfWeek.Thursday:
							sql="4";
							break;
						case DayOfWeek.Friday:
							sql="5";
							break;
						case DayOfWeek.Saturday:
							sql="6";
							break;
						case DayOfWeek.Sunday:
							sql="7";
							break;
					}
					sql="select h"+sql+" from FILC14A where YYY_YY=N'qtan'";
					Func.RecordSet rs=new Func.RecordSet(sql,con1);					
					if(rs.rows>0 && rs.record(0,0)!="" && rs.record(0,0)!=null)
					{
						GRP_FO = rs.record(0,0);
						CALGPS(tb, GRP_FO, d.ToString("yyyy/MM/dd"), con1, con1);	
					}
				}

				d = d.AddDays(1);
				dd ++;

				lb.Text= d.ToString("yyyy/MM/dd");
				pro.Value=(int)((dd)*100/(days+1));
			}

			//Cat gio quet the hop ly
			sql = "UPDATE [" + tb + "] SET ONN_02=0,OFF_02=0, OFF_01="
				+ " CASE"
				+ " WHEN OTT_HR>0 THEN"
					+ " (CAST(OTT_HR AS INT)/100+CAST(OFF_TM AS INT)/100)*100"
					+ " +(CAST(OTT_HR AS INT)%100+CAST(OFF_TM AS INT)%100)%60"
					+ " +(CAST(OTT_HR AS INT)%100+CAST(OFF_TM AS INT)%100)/60*100"
					+ " +CAST(OFF_01 AS INT)%10"
				+ " WHEN NIG_OT>0 THEN"
					+ " (CAST(NIG_OT AS INT)/100+CAST(OFF_TM AS INT)/100)*100"
					+ " +(CAST(NIG_OT AS INT)%100+CAST(OFF_TM AS INT)%100)%60"
					+ " +(CAST(NIG_OT AS INT)%100+CAST(OFF_TM AS INT)%100)/60*100"
					+ " +CAST(OFF_01 AS INT)%10"
				+ " WHEN ATT_HR>0 AND OFF_TM<OFF_01 AND EAR_MN>0 THEN"
					+ " CAST(CAST(OFF_TM AS INT)/100+CAST(OFF_TM AS INT)%100/60.0"
					+ " -(CAST(EAR_MN AS INT)/100+CAST(EAR_MN AS INT)%100/60.0) AS INT)/1*100"
					+ " +CAST((CAST(OFF_TM AS INT)/100+CAST(OFF_TM AS INT)%100/60.0"
					+ " -(CAST(EAR_MN AS INT)/100+CAST(EAR_MN AS INT)%100/60.0))*10 AS INT)%10*6"
				+ " WHEN NIG_HR>0 AND OFF_TM<OFF_01 AND EAR_MN>0 THEN"
					+ " CAST(CAST(OFF_TM AS INT)/100+CAST(OFF_TM AS INT)%100/60.0"
					+ " -(CAST(EAR_MN AS INT)/100+CAST(EAR_MN AS INT)%100/60.0) AS INT)/1*100"
					+ " +CAST((CAST(OFF_TM AS INT)/100+CAST(OFF_TM AS INT)%100/60.0"
					+ " -(CAST(EAR_MN AS INT)/100+CAST(EAR_MN AS INT)%100/60.0))*10 AS INT)%10*6"
				+ " WHEN (ATT_HR>0 OR NIG_HR>0) AND OFF_TM<OFF_01 AND EAR_MN=0 THEN"
					+ " OFF_TM+CAST(OFF_01 AS INT)%10"
				+ " ELSE OFF_01"
				+ " End"
				+ " FROM FILC02A s"
				+ " Where s.SHI_ID=[" + tb + "].SHI_ID";
			PublicFunction.SQL_Execute(sql, con1);

			pro.Value = 100;
		}
		private void CALGPS(string tb,string GRP_FO,string ngay,SqlConnection conGPS,SqlConnection conGP)
		{
			string sql="";			
			sql="select * from FILC12B where GRP_FO=N'"+GRP_FO+"' order by SEQ_NO";
			Func.RecordSet rsf=new Func.RecordSet(sql,conGP);
			sql="";
			string vl;
			for(int i=0;i<rsf.rows;i++)
			{
				string col1=rsf.record(i,"COL_NM1"),col2=rsf.record(i,"COL_NM2"),fun=rsf.record(i,"FUN_ID");
				double gio=T_String.IsNullTo00(rsf.record(i,"CON_DR"));
				if(fun!="")
				{
					sql="select SQL_DR from FILC11A where FUN_ID=N'"+fun+"'";
					Func.RecordSet rsff=new Func.RecordSet(sql,conGP);
					if(rsff.rows>0)
					{
						sql=rsff.record(0,0);
						sql=sql.Replace("FILC06A", "[" + tb + "]").Replace("[[" + tb + "]]", "[" + tb + "]");
						sql+=" and ["+tb+"].ATT_DT='"+ngay+"'";
						PublicFunction.SQL_Execute(sql,conGPS,true);
					}
				}
				else
				{
					if(col1!=""  && col2!="")
					{
						sql="update ["+tb+"] set ["+col2+"]=";
						vl="(FLOOR(["+col2+"]/100)+(["+col2+"]/100-FLOOR(["+col2+"]/100))/0.6)";
						vl="("+vl+"+ (FLOOR(["+col1+"]/100)+(["+col1+"]/100-FLOOR(["+col1+"]/100))/0.6)-"+gio+")";
						vl= "FLOOR("+vl+") * 100 + ("+vl+" - FLOOR("+vl+")) * 60";
						sql+="("+vl+")";
						sql+=" , ";
						sql+="[hqtan_TT]=";
						vl="(FLOOR([hqtan_TT]/100)+([hqtan_TT]/100-FLOOR([hqtan_TT]/100))/0.6)";
						vl="("+vl+"+ (FLOOR(["+col1+"]/100)+(["+col1+"]/100-FLOOR(["+col1+"]/100))/0.6)-"+gio+")";
						vl= "FLOOR("+vl+") * 100 + ("+vl+" - FLOOR("+vl+")) * 60";
						sql+="("+vl+")";
						sql+=" , ";
						sql+="["+col1+"]=";
						vl= "FLOOR("+gio+") * 100 + ("+gio+" - FLOOR("+gio+")) * 60";
						sql+=vl+" where "+col1+">"+vl;
						sql+=" and ATT_DT='"+ngay+"'";
						PublicFunction.SQL_Execute(sql,conGPS,true);
					}
				}
			}

			//Gioi han tang ca theo tuan, quy ...
			switch(PublicFunction.CUS_ID)
			{
				case "40":
					SplitOTWeek_FVN(tb, DateTime.Parse(ngay));
					break;
			}
		}

		//Tach tuan: Fashionline (Far East Apparel)
		private void SplitOTWeek_FVN(string tb, DateTime date)
		{
			DateTime dtF1, dtF2;
			string sql, ss="";

			dtF1 = DateAndTime.DateAdd("D", -DateAndTime.Weekday(date, FirstDayOfWeek.Monday), date);
			if (DateAndTime.DateDiff("D", dtF1, dt1.Value, FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1)>0)
			{
				dtF2 = (DateTime)dt1.Value;
				ss = "(SELECT ISNULL(SUM(CAST(OTT_HR AS INT)/100+CAST(NIG_OT AS INT)/100"
				+ "+CAST(OTT_HR AS INT)%100/60.0+CAST(NIG_OT AS INT)%100/60.0),0) FROM FILC06AS a"
				+ " WHERE a.EMP_ID=e.EMP_ID AND a.ATT_DT BETWEEN '" + dtF1.ToString("yyyy/MM/dd")
				+ "' AND '" + ((DateTime)dt1.Value).AddDays(-1).ToString("yyyy/MM/dd") + "')+";
			}
			else
			{
				dtF2 = dtF1;
			}

			sql = "UPDATE [" + tb + "] SET _TCs=(CAST(_TCs AS INT)/100+CAST(OTT_HR AS INT)/100"
				+ "+(CAST(_TCs AS INT)%100+CAST(OTT_HR AS INT)%100)/60)*100+(CAST(_TCs AS INT)%100"
				+ "+CAST(OTT_HR AS INT)%100)%60, OTT_HR=0"
				+ " FROM FILB01A e WHERE e.EMP_ID=[" + tb + "].EMP_ID AND " + ss
				+ " (SELECT ISNULL(SUM(CAST(OTT_HR AS INT)/100+CAST(NIG_OT AS INT)/100"
				+ "+CAST(OTT_HR AS INT)%100/60.0+CAST(NIG_OT AS INT)%100/60.0),0) FROM [" + tb + "] a"
				+ " WHERE a.EMP_ID=e.EMP_ID AND a.ATT_DT BETWEEN '" + dtF2.ToString("yyyy/MM/dd")
				+ "' AND '" + date.ToString("yyyy/MM/dd") + "')>" + MAX_OT_WEEK
				+ " AND ATT_DT='" + date.ToString("yyyy/MM/dd") + "'";
			PublicFunction.SQL_Execute(sql);
		}

		#endregion
		
		#region Import_data_from_GP_ToGPS
		private void ImportTable(Boolean dau,string tablefr,string table,SqlConnection con1,Boolean insert,Boolean update,Boolean delete,Label lb,ProgressBar pro,string wh1)		
		{			
			ArrayList fname=new ArrayList();
			ArrayList key=new ArrayList();
			ArrayList type=new ArrayList();
			ArrayList pic=new ArrayList();
			string sql,sql1,wh,st,st1;
			if (!PublicFunction.CheckFieldOfTable(con1,table))
				return;			

			sql="select * from "+tablefr+" where "+wh1;
			Func.RecordSet  rs=new Func.RecordSet(sql,con1);
			sql="Insert Into ["+table+"] (";
			for(int i=0;i<rs.cols;i++)
			{		
				if (Func.Fun.CheckFieldOfTable(con1,table,rs.Field(i)))
				{
					fname.Add(rs.Field(i));
					key.Add(Func.Fun.CheckPrimaryKey(con1,table,rs.Field(i)));
					st=Func.Fun.GetTypeField(con1,table,rs.Field(i));
					type.Add(st);
					if (i!=0) sql+=",";
					sql+="["+rs.Field(i)+"]";	
					if (st=="6")
						pic.Add(rs.Field(i));			
				}
			}
			int fr=0,to=0,tc=0;			
			
			fr=0;
			to=rs.rows;
			tc=to;

			sql+=") values(";
			for(int j=fr;j<to;j++)
			{				
				if(Stop)
				{
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
								sql1=sql1+"'"+ DateTime.Parse(rs.record(j,fname[i]+"")).ToString("yyyy/MM/dd HH:mm:ss")+"'";
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
								wh=wh+fname[i]+"='"+ DateTime.Parse(rs.record(j,fname[i]+"")).ToString("yyyy/MM/dd HH:mm:ss")+"'";
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
						if (Func.Fun.GetTypeField(con1,table,fname[i]+"")=="2")
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
				
				PublicFunction.SQL_Execute(sql+sql1+")",con1);												

				lb.Text= rs.record(j,"EMP_ID")+ " _ " +j+"/"+tc+" records. ";
				pro.Value=(int)(j*100/tc);								
			}
			lb.Text= tc+"/"+tc+" records. ";
			pro.Value=100;	
		}

		#endregion
		
		#region Transfer
		int vat=0;
		int s=0;
		int p=0;
		int h=0;
		Func.RecordSet rs;
		string table;
		private void Transfer()
		{
			vat=T_String.GetMax("MAX(SEQ_NO)","FILC10A");
			Stop=false;
			table="FILC06A_"+PublicFunction.A_UserID;
			//--Neu chuyen tiep -->
			string sql;
			if (numTransfered == 0)
			{
				sql = "IF  EXISTS (SELECT * FROM sysobjects WHERE name=N'" + table + "' AND type='U') Drop Table ["+table+"]";
				PublicFunction.SQL_Execute(sql, PublicFunction.C_con, 180);
				PublicFunction.Copy_Table("FILC06A",table,PublicFunction.C_con);
			}
			//<--

			Set=new Func.RecordSet("Select * from GP_SYS_SETTING",PublicFunction.C_con);
			rsType=new Func.RecordSet("Select TYP_ID,ROU_DR from GP_SYS_SHIFT",PublicFunction.C_con);	
			CheckFieldName();

			DateTime d1=(DateTime)dt1.Value;
			DateTime d2=(DateTime)dt2.Value;
			sql="Select a.EMP_ID,a.EMP_I1,EMP_NM,DEP_ID,CONVERT(NVARCHAR(10),VAC_DT,111) VAC_DT,"
				+"CONVERT(NVARCHAR(10),INH_DT,111) INH_DT,CRD_NO from FILB01A  a Left JOIN  FILB01AC b on a.EMP_ID=b.EMP_ID where " 
				+control1.GetWhere("a",false)+" and ATT_BT=1 and (VAC_DT is null or VAC_DT>='"+d1.ToString("yyyy/MM/dd")+"') and INH_DT is not null";

			rs=new Func.RecordSet(sql,PublicFunction.C_con);

			tm.Text="00:00:00";
			s=0;
			p=0;
			h=0;

			timer1.Enabled=true;
			timer1.Start();

			process();
		}

		private void process()
		{
			string sql="";
			SqlConnection con1=new SqlConnection(PublicFunction.C_con.ConnectionString+";TimeOut=100");
			if(con1.State==ConnectionState.Closed )
				con1.Open();

			DateTime d1=(DateTime)dt1.Value;
			DateTime d2=(DateTime)dt2.Value;
			int ngay=0;

			while(T_String.IsNullTo0(d1.ToString("yyyyMMdd"))<=T_String.IsNullTo0(d2.ToString("yyyyMMdd")))// tung Ngay
			{
				ngay++;
				d1=d1.AddDays(1);
			}
			// sua theo ngay nghi
			d1=(DateTime)dt1.Value;
			d2=(DateTime)dt2.Value;

			int row = rs.rows;
			TaCardData ta=new TaCardData();
			ta.table=this.table;
			ta.err=err;
			ta.Set=Set;
			ta.rsTypeShift=rsTypeShift;

			int i=numTransfered;
			try
			{
				cmd_Stop.Enabled = true;
				sql = "DELETE FROM [" + table + "] WHERE EMP_ID='" + rs.record(i, "EMP_ID") + "'";
				PublicFunction.SQL_Execute(sql, con1);

				for(i=numTransfered;i<row;i++)  // Tung Nhan Vien
				{
					if(Stop)
					{
						control1.Enabled = dt1.Enabled = dt2.Enabled = true;
						SaveCondition(i);
						numTransfered = i;
						cmd_Stop.Enabled = cmd_att.Enabled = cmd_close.Enabled = true;
						return;
					}
					DateTime INH_DT= DateTime.Parse(rs.record(i,"INH_DT")+"");
					d1=(DateTime)dt1.Value;
					d2=(DateTime)dt2.Value;
					if (T_String.IsNullTo0(d1.ToString("yyyyMMdd"))<=T_String.IsNullTo0(INH_DT.ToString("yyyyMMdd")))
						d1=INH_DT;
					int dem=1;
					sql="SELECT SEQ_NO, CONVERT(NVARCHAR(10),SEQ_DT,111) SEQ_DT, EMP_ID, EMP_I3, EMP_I4, DEP_I1, DEP_I2"
						+ " FROM FILB03A WHERE  (SEQ_DT>'"+d1.ToString("yyyy/MM/dd")
						+"' and EMP_ID=N'"+rs.record(i,"EMP_ID")+"') ORDER BY SEQ_DT ASC"; // doi bo phan
					Func.RecordSet rs1=new Func.RecordSet(sql,con1);
					int mm=0;
					// sua theo ngay nghi
					int VAC=0;
					if(rs.record(i,"VAC_DT")+""!="")
						VAC=T_String.IsNullTo0(DateTime.Parse(rs.record(i,"VAC_DT")+"").ToString("yyyyMMdd"));

					//NhuY: sua xoa nghi viec
					if (VAC!=0 && VAC<=T_String.IsNullTo0(d2.ToString("yyyyMMdd")))
					{
						d2 = DateTime.Parse(rs.record(i, "VAC_DT")+"").AddDays(-1);
						sql="Delete from FILC06A where ATT_DT>='" + rs.record(i,"VAC_DT") + "' and EMP_ID=N'"+rs.record(i,"EMP_ID")+"'";
						try
						{
							PublicFunction.SQL_Execute(sql,con1);
						}
						catch(SqlException ex)
						{
							err.Text+= ex.Message;
						}
					}
					//NhuY.
					while(T_String.IsNullTo0(d1.ToString("yyyyMMdd"))<=T_String.IsNullTo0(d2.ToString("yyyyMMdd")))// tung Ngay
					{
						c1.Text=rs.record(i,"EMP_ID")+" - "+rs.record(i,"EMP_NM")+" - "+d1.ToString("yyyy/MM/dd");											

						int m;
						for(m=mm;m<rs1.rows;m++)
						{
							if(T_String.IsNullTo0(d1.ToString("yyyyMMdd"))<T_String.IsNullTo0( DateTime.Parse(rs1.record(m,"SEQ_DT")).ToString("yyyyMMdd")))
							{
								break;
							}
						}
						mm=m;
						sql="Update FILC01A set YSD_BT=0 where EMP_ID=N'"+rs.record(i,"EMP_ID")+"' and CRD_DT='"+d1.AddDays(1).ToString("yyyy/MM/dd")+"'";
					
						try
						{
							PublicFunction.SQL_Execute(sql,con1,true);
							sql = "";
						}
						catch(SqlException ex)
						{
							err.Text+= ex.Message;
						}
					
						if(m>=rs1.rows)
							ta.AttStaff(rs.record(i,"EMP_ID"),d1,con1,rs.record(i,"DEP_ID"),rs.record(i,"EMP_I1")); // ko thay doi bo phan
						else
							ta.AttStaff(rs.record(i,"EMP_ID"),d1,con1,rs1.record(mm,"DEP_I1"),rs1.record(mm,"EMP_I3")); // thay doi bo phan					
						d1=d1.AddDays(1);
						pro1.Value=(int)dem*100/ngay;
						dem++;
					}

					d1=(DateTime)dt1.Value;
					d2=(DateTime)dt2.Value;
					dem=1;
					//absent to vacate
					while(T_String.IsNullTo0(d1.ToString("yyyyMMdd"))<=T_String.IsNullTo0(d2.ToString("yyyyMMdd")))// tung Ngay
					{
						c1.Text=rs.record(i,"EMP_ID")+" - "+rs.record(i,"EMP_NM")+" - "+d1.ToString("yyyy/MM/dd");											
						TaAttendance.AbsentToVacate(rs.record(i,"EMP_ID"),d1.ToString("yyyy/MM/dd"),con1,table);
						d1=d1.AddDays(1);
						dem++;
					}
					pro1.Value=100;
					pro2.Value=(int)(i+1)*100/row;
					c3.Text=(i+1)+"/"+row+" - "+pro2.Value+"%";
				}

				pro2.Value=100;	

				Formula(con1);

				c1.Text = PublicFunction.L_GetLabel(this.Name, 9);			

				sql = "SET ROWCOUNT 1000 \r\n"
					+ "WHILE 1=1 \r\n"
					+ "BEGIN \r\n"
					+ "DELETE FROM FILC06A WHERE EXISTS (SELECT 1 FROM [" + table + "] WHERE EMP_ID=FILC06A.EMP_ID)"
					+ " AND ATT_DT BETWEEN '" + ((DateTime)dt1.Value).ToString("yyyy/MM/dd") 
					+ "' AND '" + ((DateTime)dt2.Value).ToString("yyyy/MM/dd") + "' AND ISNULL(LOC_BT,0)=0 AND ISNULL(LOC_B1,0)=0 \r\n"
					+ " IF @@ROWCOUNT=0 BREAK \r\n"
					+ "END \r\n"
					+ "SET ROWCOUNT 0";
				PublicFunction.SQL_Execute(sql, con1, 200);

				c1.Text = PublicFunction.L_GetLabel(this.Name, 10);
				sql = "Insert into FILC06A select * from ["+table+"]";
				PublicFunction.SQL_Execute(sql,con1);

				File.Delete("att.txt");

			}
			catch(Exception ex)
			{
				err.Text += ex.Message + "\r\nprocess\r\n";
			}

			control1.Enabled = dt1.Enabled = dt2.Enabled = true;
			if (err.Text != "")
			{
				SaveCondition(i);
				cmd_Stop.Text = PublicFunction.L_GetLabel(this.Name, 8);
				cmd_Stop.Tag = "";
				c1.Text = PublicFunction.L_GetLabel(this.Name, 13);
			}
			else
			{
				cmd_Stop.Enabled = false;
				c1.Text=PublicFunction.L_Get_Msg("Staff",1,con1);
			}

			cmd_att.Enabled=true;
			cmd_close.Enabled = true;

			timer1.Stop();
			timer1.Enabled=false;
			con1.Close();

			if(T_String.GetMax("MAX(SEQ_NO)","FILC10A")>vat)
			{
				frmTaAbsentVacate dlg=new frmTaAbsentVacate();
				dlg.Tag=this.Tag;
				dlg.ShowDialog();
			}
		}
		#endregion

		private void Formula(SqlConnection con)
		{
			string sql="";
			sql="Select * from FILC08A where RUN_BT=1 order by SEQ_N1";
			Func.RecordSet rs=new Func.RecordSet(sql,con);
			try
			{
				for(int i=0;i<rs.rows;i++)
				{
					sql=rs.record(i,"SQL_DR");
					if(sql+""!="")
					{
						sql=sql.Replace("FILC06A", "[" + table + "]");
						PublicFunction.SQL_Execute(sql,con,true);
					}
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
	
		#region Func
		public  int IsN(Object st1)
		{		
			try
			{ 
				string st=st1+""; 
				if (st+""=="")
					return 0;			
				return Int32.Parse(st=st.Replace(",",""));
			}
			catch(Exception){return 0;}
		}	
		public  Double IsD(Object st1)
		{
			try
			{
				string st=st1+""; 
				if (st+""=="")
					return 0;
				return Double.Parse(st=st.Replace(",",""));
			}
			catch(Exception){return 0;}
		}
		#endregion

		private void frmTaCardDataSwitch_Closed(object sender, EventArgs e)
		{
			Stop=true;
		}

		private void timer1_Tick(object sender, System.EventArgs e)
		{
			s++;
			if(s>=60)
			{
				s=0;
				p++;
			}
			if(p>=60)
			{
				p=0;
				h++;
			}
			tm.Text=h.ToString("00")+":"+p.ToString("00")+":"+s.ToString("00");
		}

		private void frmTaCardDataSwitch_Closed_1(object sender, System.EventArgs e)
		{
			Stop=true;
		}

		#region NhuY
		private void SaveCondition(int num)
		{
			string str = PublicFunction.A_UserID.ToUpper() + "\r\n"
				+ num.ToString() + "\r\n"
				+ control1.R_ALL.Checked + "\r\n"
				+ control1.R_Par.Checked + "\r\n"
				+ control1.R_DEP.Checked + "\r\n"
				+ control1.R_WID.Checked + "\r\n"
				+ control1.ck.Checked + "\r\n"
				+ control1.CB_DEP.SelectedValue + "\r\n"
				+ control1.txt_fr.Text + "\r\n"
				+ control1.txt_to.Text + "\r\n"
				+ ((DateTime)dt1.Value).ToString("yyyy/MM/dd") + "\r\n"
				+ ((DateTime)dt2.Value).ToString("yyyy/MM/dd") + "\r\n";

			for (int i=0; i<control1.list.Count; i++)
				str += control1.list[i] + "\r\n";

			StreamWriter strW = new StreamWriter("att.txt");
			strW.Write(str);
			strW.Close();
		}

		private void SetCondition()
		{
			if (!File.Exists("att.txt"))
				return;

			try
			{
				StreamReader strR = new StreamReader("att.txt");
			
				if (PublicFunction.A_UserID.ToUpper() != strR.ReadLine())
					return ;

				numTransfered = Convert.ToInt32("0"+strR.ReadLine());
				control1.R_ALL.Checked = Convert.ToBoolean(strR.ReadLine());
				control1.R_Par.Checked = Convert.ToBoolean(strR.ReadLine());
				control1.R_DEP.Checked = Convert.ToBoolean(strR.ReadLine());
				control1.R_WID.Checked = Convert.ToBoolean(strR.ReadLine());
				control1.ck.Checked = Convert.ToBoolean(strR.ReadLine());
				control1.CB_DEP.SelectedValue = strR.ReadLine();
				control1.txt_fr.Text = strR.ReadLine();
				control1.txt_to.Text = strR.ReadLine();
				dt1.Value = strR.ReadLine();
				dt2.Value = strR.ReadLine();

				strR.Close();
			}
			catch
			{
				numTransfered = 0;
				cmd_Stop.Enabled = false;
				cmd_Stop.Text = PublicFunction.L_GetLabel(this.Name, 7);
				cmd_Stop.Tag = "Pause";
			}
		}

		private void cmd_Stop_Click(object sender, System.EventArgs e)
		{
			cmd_Stop.Enabled = false;
			if (cmd_Stop.Tag+"" != "Pause")
			{
				SetCondition();
				cmd_Stop.Text = PublicFunction.L_GetLabel(this.Name, 7);
				cmd_att_Click(null, null);
			}
			else
			{
				timer1.Stop();
				Stop = true;
				cmd_Stop.Text = PublicFunction.L_GetLabel(this.Name, 8);
				cmd_Stop.Tag = "";
			}
		}
		#endregion
	}
}
