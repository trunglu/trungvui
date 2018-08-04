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
using GP8000.Function;


namespace GP8000.Attendance
{
	/// <summary>
	/// Summary description for frmTaCardDataSwitch.
	/// </summary>
	public class frmTaSubsidyCal : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label1;
		private C1.Win.C1Input.C1DateEdit dt2;
		private C1.Win.C1Input.C1DateEdit dt1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel panel5;
		private GP8000.UserControl.CrtTaCondition1 control1;
		private System.Windows.Forms.Button cmd_close;		
		private System.Windows.Forms.ProgressBar pro1;
		private System.Windows.Forms.ProgressBar pro2;
		private System.Windows.Forms.Label c1;	
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button cmd_mon;
		private C1.Win.C1Input.C1DateEdit dt3;
		private System.Windows.Forms.Label label6;		
		Func.RecordSet LEA;
		private Boolean Stop;
		private System.Windows.Forms.Button cmd_stop;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.CheckBox chkUpdateSalary;		
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmTaSubsidyCal()
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
			this.panel3 = new System.Windows.Forms.Panel();
			this.label5 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.cmd_stop = new System.Windows.Forms.Button();
			this.c1 = new System.Windows.Forms.Label();
			this.pro2 = new System.Windows.Forms.ProgressBar();
			this.pro1 = new System.Windows.Forms.ProgressBar();
			this.panel5 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.dt3 = new C1.Win.C1Input.C1DateEdit();
			this.label6 = new System.Windows.Forms.Label();
			this.dt2 = new C1.Win.C1Input.C1DateEdit();
			this.dt1 = new C1.Win.C1Input.C1DateEdit();
			this.label1 = new System.Windows.Forms.Label();
			this.cmd_close = new System.Windows.Forms.Button();
			this.cmd_mon = new System.Windows.Forms.Button();
			this.control1 = new GP8000.UserControl.CrtTaCondition1();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.panel4 = new System.Windows.Forms.Panel();
			this.chkUpdateSalary = new System.Windows.Forms.CheckBox();
			this.panel3.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dt3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dt2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dt1)).BeginInit();
			this.panel4.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.panel3.Controls.Add(this.label5);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel3.Location = new System.Drawing.Point(0, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(840, 36);
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
			this.label5.Size = new System.Drawing.Size(840, 36);
			this.label5.TabIndex = 11;
			this.label5.Tag = "";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.cmd_stop);
			this.panel1.Controls.Add(this.c1);
			this.panel1.Controls.Add(this.pro2);
			this.panel1.Controls.Add(this.pro1);
			this.panel1.Controls.Add(this.panel5);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 36);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(840, 312);
			this.panel1.TabIndex = 14;
			// 
			// cmd_stop
			// 
			this.cmd_stop.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_stop.Location = new System.Drawing.Point(352, 260);
			this.cmd_stop.Name = "cmd_stop";
			this.cmd_stop.Size = new System.Drawing.Size(136, 40);
			this.cmd_stop.TabIndex = 155;
			this.cmd_stop.Text = "Stop";
			this.cmd_stop.Click += new System.EventHandler(this.cmd_stop_Click);
			// 
			// c1
			// 
			this.c1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.c1.BackColor = System.Drawing.Color.Black;
			this.c1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.c1.ForeColor = System.Drawing.Color.White;
			this.c1.Location = new System.Drawing.Point(0, 220);
			this.c1.Name = "c1";
			this.c1.Size = new System.Drawing.Size(840, 28);
			this.c1.TabIndex = 8;
			this.c1.Tag = "N";
			this.c1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pro2
			// 
			this.pro2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pro2.Location = new System.Drawing.Point(0, 200);
			this.pro2.Name = "pro2";
			this.pro2.Size = new System.Drawing.Size(840, 16);
			this.pro2.TabIndex = 3;
			// 
			// pro1
			// 
			this.pro1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pro1.Location = new System.Drawing.Point(0, 180);
			this.pro1.Name = "pro1";
			this.pro1.Size = new System.Drawing.Size(840, 16);
			this.pro1.TabIndex = 2;
			// 
			// panel5
			// 
			this.panel5.BackColor = System.Drawing.Color.CornflowerBlue;
			this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel5.Location = new System.Drawing.Point(0, 176);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(840, 4);
			this.panel5.TabIndex = 1;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.dt3);
			this.panel2.Controls.Add(this.label6);
			this.panel2.Controls.Add(this.dt2);
			this.panel2.Controls.Add(this.dt1);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Controls.Add(this.cmd_close);
			this.panel2.Controls.Add(this.cmd_mon);
			this.panel2.Controls.Add(this.control1);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.panel4);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(840, 176);
			this.panel2.TabIndex = 0;
			// 
			// dt3
			// 
			this.dt3.CustomFormat = "yyyyMM";
			this.dt3.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat;
			this.dt3.Location = new System.Drawing.Point(536, 68);
			this.dt3.Name = "dt3";
			this.dt3.Size = new System.Drawing.Size(132, 23);
			this.dt3.TabIndex = 159;
			this.dt3.Tag = null;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(452, 72);
			this.label6.Name = "label6";
			this.label6.TabIndex = 160;
			this.label6.Text = "label6";
			// 
			// dt2
			// 
			this.dt2.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat;
			this.dt2.Location = new System.Drawing.Point(536, 40);
			this.dt2.Name = "dt2";
			this.dt2.Size = new System.Drawing.Size(132, 23);
			this.dt2.TabIndex = 150;
			this.dt2.Tag = null;
			this.dt2.Leave += new System.EventHandler(this.dt2_Leave);
			// 
			// dt1
			// 
			this.dt1.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat;
			this.dt1.Location = new System.Drawing.Point(536, 12);
			this.dt1.Name = "dt1";
			this.dt1.Size = new System.Drawing.Size(132, 23);
			this.dt1.TabIndex = 149;
			this.dt1.Tag = null;
			this.dt1.Leave += new System.EventHandler(this.dt2_Leave);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(452, 16);
			this.label1.Name = "label1";
			this.label1.TabIndex = 1;
			this.label1.Text = "label1";
			// 
			// cmd_close
			// 
			this.cmd_close.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_close.Location = new System.Drawing.Point(692, 104);
			this.cmd_close.Name = "cmd_close";
			this.cmd_close.Size = new System.Drawing.Size(136, 40);
			this.cmd_close.TabIndex = 154;
			this.cmd_close.Text = "Close";
			this.cmd_close.Click += new System.EventHandler(this.cmd_close_Click);
			// 
			// cmd_mon
			// 
			this.cmd_mon.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_mon.Location = new System.Drawing.Point(692, 28);
			this.cmd_mon.Name = "cmd_mon";
			this.cmd_mon.Size = new System.Drawing.Size(136, 40);
			this.cmd_mon.TabIndex = 152;
			this.cmd_mon.Text = "Subsidy";
			this.cmd_mon.Click += new System.EventHandler(this.cmd_mon_Click);
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
			this.label3.Location = new System.Drawing.Point(712, 88);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(32, 23);
			this.label3.TabIndex = 156;
			this.label3.Tag = "N";
			this.label3.Text = "->>";
			this.label3.Visible = false;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(452, 44);
			this.label2.Name = "label2";
			this.label2.TabIndex = 151;
			this.label2.Text = "label2";
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.chkUpdateSalary);
			this.panel4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.panel4.Location = new System.Drawing.Point(448, 4);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(232, 164);
			this.panel4.TabIndex = 162;
			// 
			// chkUpdateSalary
			// 
			this.chkUpdateSalary.Location = new System.Drawing.Point(8, 96);
			this.chkUpdateSalary.Name = "chkUpdateSalary";
			this.chkUpdateSalary.Size = new System.Drawing.Size(208, 24);
			this.chkUpdateSalary.TabIndex = 0;
			this.chkUpdateSalary.Text = "checkBox1";
			// 
			// frmTaSubsidyCal
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
			this.ClientSize = new System.Drawing.Size(840, 348);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel3);
			this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "frmTaSubsidyCal";
			this.Text = "frmTaSubsidyCal";
			this.Load += new System.EventHandler(this.frmTaCardDataSwitch_Load);
			this.panel3.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dt3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dt2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dt1)).EndInit();
			this.panel4.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void frmTaCardDataSwitch_Load(object sender, System.EventArgs e)
		{			
			Basic.Function.PublicFunction.L_Init_Label(this);
			control1.InitCB(this.Tag);
			control1.Initlabel();
			dt3.Value=dt2.Value=dt1.Value=T_String.GetDate();				
			dt1.CustomFormat=dt2.CustomFormat=PublicFunction.GetOption("DATE");		
			string sql="Select FNAME,"+PublicFunction.L_Lag+" from  SYS_LABEL where [NAME]=N'frmTaSubsidyCal' and (FName='1' or FName='2')";
			//PublicFunction.InitCB(cb,sql,false);
			chkUpdateSalary.Checked=true;
			this.Closed+=new EventHandler(frmTaSubsidyCal_Closed);
			cmd_stop.Visible=false;
		}

		private void cmd_close_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void cmd_mon_Click(object sender, System.EventArgs e)
		{
			DateTime d1=(DateTime)dt1.Value;
			DateTime d2=(DateTime)dt2.Value;
			DateTime d3=(DateTime)dt3.Value;

			if(T_String.IsNullTo0(d1.ToString("yyyyMMdd"))>T_String.IsNullTo0(d2.ToString("yyyyMMdd")))
			{
				MessageBox.Show(PublicFunction.L_Get_Msg("msg",216));
				return;
			}
			if(d3.Year<d1.Year || d3.Month<d1.Month || d3.Year>d2.Year)
			{
				MessageBox.Show(PublicFunction.L_Get_Msg("msg",216));
				return;
			}

			Stop=false;
			Thread th=new Thread(new ThreadStart(Cal));
			th.Start();
		}
		private void Cal()
		{	
			//string sql;
			cmd_stop.Visible=true;
			panel2.Enabled=false;
			SqlConnection con1=new SqlConnection(PublicFunction.C_con.ConnectionString);
			if(con1.State==ConnectionState.Closed )
				con1.Open();

			string YYY_MM=dt3.Text;
			string dt=T_String.GetDate().ToString("yyyy/MM/dd HH:mm");
			string sql="Delete from FILG03A where YYY_MM=N'"+YYY_MM+"' and EMP_ID in (";
			sql+="Select EMP_ID from FILB01A where " +control1.GetWhere("")+")";
			PublicFunction.SQL_Execute(sql,con1,true);			
			

			DateTime d1=(DateTime)dt1.Value;
			DateTime d2=(DateTime)dt2.Value;
			DateTime d3=(DateTime)dt3.Value;

			Func.RecordSet sal;
			
			sql="Select a.EMP_ID,EMP_NM,VAC_DT,a.EMP_I1,a.DEP_ID,INH_DT from FILB01A  a Left JOIN FILB01AC b on a.EMP_ID=b.EMP_ID where  " 
				+control1.GetWhere("a",false)+" and (VAC_DT>'"+d1.ToString("yyyy/MM/dd")+"' or VAC_DT is null)"
				+ " and INH_DT<='" + d2.ToString("yyyy/MM/dd") +"'";
				
			Func.RecordSet rs=new Func.RecordSet(sql,con1);
			string sql1="";
			for(int i=0;i<rs.rows;i++)  // Tung Nhan Vien
			{
				if(Stop)
				{
					return;
				}
				c1.Text=rs.record(i,"EMP_ID")+" - "+rs.record(i,"EMP_NM");
				sql="Delete from FILG03A where EMP_ID=N'"+rs.record(i,"EMP_ID")+"' and YYY_MM=N'"+YYY_MM+"' ";
				PublicFunction.SQL_Execute(sql,con1,true);	
				string sql11="Select Sum(EFF_AM) AS EFF_AM From FILG02B a Left JOIN FILB01A b on a.EMP_ID=b.EMP_ID";
					sql11+=" Where a.EMP_ID='"+rs.record(i,"EMP_ID")+"'";
					sql11+=" and a.YYY_MM between '"+d1.ToString("yyyy/MM/dd")+"' and '"+ d2.ToString("yyyy/MM/dd") +"'";
				sal=new Func.RecordSet(sql11,con1);
				
				string tam;
				if (sal.rows<=0)
					tam="0";
				else
					tam=sal.record(0,"EFF_AM");
				if (tam==null)
					tam="0";
				sql="Insert into FILG03A(EMP_ID,YYY_MM,EFF_AM,BLT_NM,BLT_DT,NOT_DR) values(";
				sql+="N'"+rs.record(i,"EMP_ID")+"',N'"+YYY_MM+"',"+tam+",";
				sql+="N'"+PublicFunction.A_UserID+"','"+dt+"',";
				sql+="N'"+d1.ToString("yyyy/MM/dd")+"~"+d2.ToString("yyyy/MM/dd")+"')";
				PublicFunction.SQL_Execute(sql,con1,true);				
				
				if (chkUpdateSalary.Checked==true)
				{
					sql="Update FILD02A set TienSubsidy="+tam+" where EMP_ID='"+rs.record(i,"EMP_ID")+"'";
					sql+=" AND YYY_MM='"+d3.ToString("yyyyMM")+"'";

					PublicFunction.SQL_Execute(sql,con1,true);
				}
				pro1.Value=100;
				pro2.Value=(int)(i+1)*100/rs.rows;
			}		
			pro2.Value=100;			
			c1.Text=PublicFunction.L_Get_Msg("Staff",1);
			panel2.Enabled=true;
			cmd_stop.Visible=false;
		}

		private void frmTaSubsidyCal_Closed(object sender, EventArgs e)
		{
			Stop=true;
		}

		private void cmd_stop_Click(object sender, System.EventArgs e)
		{
			Stop=true;
			cmd_stop.Visible=false;
			panel2.Enabled=true;
		}

		private void dt2_Leave(object sender, System.EventArgs e)
		{
			DateTime d1=(DateTime)dt1.Value;
			DateTime d2=(DateTime)dt2.Value;
			int day=0;
			while(T_String.IsNullTo0(d1.ToString("yyyyMMdd"))<=T_String.IsNullTo0(d2.ToString("yyyyMMdd")))// tung Ngay
			{
				day++;
				d1=d1.AddDays(1);
			}
			dt3.Value=dt1.Value;
		}
	}
}
