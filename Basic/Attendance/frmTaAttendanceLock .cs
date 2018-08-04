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

namespace GP8000.Reports
{
	/// <summary>
	/// Summary description for frmTaHRReport.
	/// </summary>
	public class frmTaAttendanceLock : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Splitter splitter1;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Panel p1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.DateTimePicker dt_dt1;
		private System.Windows.Forms.DateTimePicker dt_dt2;
		private GP8000.UserControl.CrtTaCondition1 control1;
		private System.Windows.Forms.Panel p5;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button btUnLock;
		private System.Windows.Forms.Button cmd_ok;
		private System.Windows.Forms.Button cmd_close;
		private System.Windows.Forms.RadioButton rdatt;
		private System.Windows.Forms.RadioButton rdaddup;
		private System.Windows.Forms.RadioButton rdsalary;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmTaAttendanceLock()
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
			this.panel4 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.btUnLock = new System.Windows.Forms.Button();
			this.cmd_ok = new System.Windows.Forms.Button();
			this.cmd_close = new System.Windows.Forms.Button();
			this.panel5 = new System.Windows.Forms.Panel();
			this.rdsalary = new System.Windows.Forms.RadioButton();
			this.rdaddup = new System.Windows.Forms.RadioButton();
			this.rdatt = new System.Windows.Forms.RadioButton();
			this.panel6 = new System.Windows.Forms.Panel();
			this.p5 = new System.Windows.Forms.Panel();
			this.control1 = new GP8000.UserControl.CrtTaCondition1();
			this.p1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.dt_dt2 = new System.Windows.Forms.DateTimePicker();
			this.dt_dt1 = new System.Windows.Forms.DateTimePicker();
			this.splitter1 = new System.Windows.Forms.Splitter();
			this.panel3.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel5.SuspendLayout();
			this.p5.SuspendLayout();
			this.p1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.panel3.Controls.Add(this.label5);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel3.Location = new System.Drawing.Point(0, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(760, 36);
			this.panel3.TabIndex = 5;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label5.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.label5.Location = new System.Drawing.Point(0, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(760, 36);
			this.label5.TabIndex = 11;
			this.label5.Tag = "N";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.panel4);
			this.panel1.Controls.Add(this.splitter1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 36);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(760, 318);
			this.panel1.TabIndex = 6;
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.panel2);
			this.panel4.Controls.Add(this.panel5);
			this.panel4.Controls.Add(this.panel6);
			this.panel4.Controls.Add(this.p5);
			this.panel4.Controls.Add(this.p1);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel4.Location = new System.Drawing.Point(3, 0);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(757, 318);
			this.panel4.TabIndex = 2;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.btUnLock);
			this.panel2.Controls.Add(this.cmd_ok);
			this.panel2.Controls.Add(this.cmd_close);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 264);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(757, 52);
			this.panel2.TabIndex = 29;
			// 
			// btUnLock
			// 
			this.btUnLock.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btUnLock.Location = new System.Drawing.Point(200, 8);
			this.btUnLock.Name = "btUnLock";
			this.btUnLock.Size = new System.Drawing.Size(88, 36);
			this.btUnLock.TabIndex = 31;
			this.btUnLock.Text = "UnLock";
			this.btUnLock.Click += new System.EventHandler(this.btUnLock_Click);
			// 
			// cmd_ok
			// 
			this.cmd_ok.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_ok.Location = new System.Drawing.Point(40, 8);
			this.cmd_ok.Name = "cmd_ok";
			this.cmd_ok.Size = new System.Drawing.Size(88, 36);
			this.cmd_ok.TabIndex = 29;
			this.cmd_ok.Text = "Lock";
			this.cmd_ok.Click += new System.EventHandler(this.cmd_ok_Click);
			// 
			// cmd_close
			// 
			this.cmd_close.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_close.Location = new System.Drawing.Point(368, 8);
			this.cmd_close.Name = "cmd_close";
			this.cmd_close.Size = new System.Drawing.Size(104, 36);
			this.cmd_close.TabIndex = 30;
			this.cmd_close.Text = "Close";
			this.cmd_close.Click += new System.EventHandler(this.cmd_close_Click);
			// 
			// panel5
			// 
			this.panel5.Controls.Add(this.rdsalary);
			this.panel5.Controls.Add(this.rdaddup);
			this.panel5.Controls.Add(this.rdatt);
			this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel5.Location = new System.Drawing.Point(0, 212);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(757, 52);
			this.panel5.TabIndex = 28;
			// 
			// rdsalary
			// 
			this.rdsalary.Location = new System.Drawing.Point(400, 16);
			this.rdsalary.Name = "rdsalary";
			this.rdsalary.Size = new System.Drawing.Size(144, 16);
			this.rdsalary.TabIndex = 2;
			this.rdsalary.Tag = "N";
			this.rdsalary.Text = "Salary";
			// 
			// rdaddup
			// 
			this.rdaddup.Location = new System.Drawing.Point(216, 18);
			this.rdaddup.Name = "rdaddup";
			this.rdaddup.Size = new System.Drawing.Size(144, 16);
			this.rdaddup.TabIndex = 1;
			this.rdaddup.Tag = "N";
			this.rdaddup.Text = "Month Add Up";
			// 
			// rdatt
			// 
			this.rdatt.Location = new System.Drawing.Point(24, 16);
			this.rdatt.Name = "rdatt";
			this.rdatt.Size = new System.Drawing.Size(144, 16);
			this.rdatt.TabIndex = 0;
			this.rdatt.Tag = "N";
			this.rdatt.Text = "Daily Attendance";
			// 
			// panel6
			// 
			this.panel6.BackColor = System.Drawing.Color.CornflowerBlue;
			this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel6.Location = new System.Drawing.Point(0, 208);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(757, 4);
			this.panel6.TabIndex = 5;
			// 
			// p5
			// 
			this.p5.Controls.Add(this.control1);
			this.p5.Dock = System.Windows.Forms.DockStyle.Top;
			this.p5.Location = new System.Drawing.Point(0, 36);
			this.p5.Name = "p5";
			this.p5.Size = new System.Drawing.Size(757, 172);
			this.p5.TabIndex = 4;
			// 
			// control1
			// 
			this.control1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.control1.Location = new System.Drawing.Point(8, 0);
			this.control1.Name = "control1";
			this.control1.Size = new System.Drawing.Size(460, 176);
			this.control1.TabIndex = 0;
			// 
			// p1
			// 
			this.p1.Controls.Add(this.label1);
			this.p1.Controls.Add(this.dt_dt2);
			this.p1.Controls.Add(this.dt_dt1);
			this.p1.Dock = System.Windows.Forms.DockStyle.Top;
			this.p1.Location = new System.Drawing.Point(0, 0);
			this.p1.Name = "p1";
			this.p1.Size = new System.Drawing.Size(757, 36);
			this.p1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(120, 23);
			this.label1.TabIndex = 2;
			this.label1.Text = "label1";
			this.label1.Visible = false;
			// 
			// dt_dt2
			// 
			this.dt_dt2.CustomFormat = "yyyy/MM/dd";
			this.dt_dt2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dt_dt2.Location = new System.Drawing.Point(276, 8);
			this.dt_dt2.Name = "dt_dt2";
			this.dt_dt2.Size = new System.Drawing.Size(108, 23);
			this.dt_dt2.TabIndex = 1;
			// 
			// dt_dt1
			// 
			this.dt_dt1.CustomFormat = "yyyy/MM/dd";
			this.dt_dt1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dt_dt1.Location = new System.Drawing.Point(144, 8);
			this.dt_dt1.Name = "dt_dt1";
			this.dt_dt1.Size = new System.Drawing.Size(108, 23);
			this.dt_dt1.TabIndex = 0;
			// 
			// splitter1
			// 
			this.splitter1.Location = new System.Drawing.Point(0, 0);
			this.splitter1.Name = "splitter1";
			this.splitter1.Size = new System.Drawing.Size(3, 318);
			this.splitter1.TabIndex = 1;
			this.splitter1.TabStop = false;
			// 
			// frmTaAttendanceLock
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
			this.ClientSize = new System.Drawing.Size(760, 354);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel3);
			this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "frmTaAttendanceLock";
			this.Text = "frmTaAttendanceLock";
			this.Load += new System.EventHandler(this.frmTaHRReport_Load);
			this.panel3.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel5.ResumeLayout(false);
			this.p5.ResumeLayout(false);
			this.p1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void frmTaHRReport_Load(object sender, System.EventArgs e)		
		{
			//Basic.Function.PublicFunction.L_Init_Label(this);			
			dt_dt1.CustomFormat=dt_dt2.CustomFormat=PublicFunction.GetOption("DATE");
			control1.InitCB(this.Tag);
			control1.Initlabel();
			rdatt.Checked=true;
		}		

		private void cmd_close_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}	

		private void cmd_ok_Click(object sender, System.EventArgs e)
		{
//			label5.Text="....is running!!!";
//			panel2.Enabled=false;
			string st="",sql="",sql1="",sql2="",where1="",where2="";
			where1=((DateTime)dt_dt1.Value).ToString("yyyy/MM/dd");
			where2=((DateTime)dt_dt2.Value).ToString("yyyy/MM/dd");
			st=control1.GetWhere("b",false);
			sql=string.Format("UPDATE {0} SET USR_CK='",Function.Common.Ints.tbChamCong)+ PublicFunction.A_UserID +string.Format("',LOC_B1=1 from FILB01A b where {0}.EMP_ID=b.EMP_ID ",Function.Common.Ints.tbChamCong)
				+"AND (LOC_B1=0 or LOC_B1 IS NULL) and "+st
				+" AND ATT_DT>='"+where1 +"' AND ATT_DT<='"+where2+"'";
			where1=((DateTime)dt_dt1.Value).ToString("yyyyMM");
			where2=((DateTime)dt_dt2.Value).ToString("yyyyMM");
			sql1=string.Format("UPDATE {0} SET LST_NM='",Function.Common.Ints.tbTongKet)+ PublicFunction.A_UserID +"',LST_DT='"+T_String.GetDate().ToString("yyyy/MM/dd HH:mm")+"',LOC_B1=1"
				+string.Format(" from FILB01A b where {0}.EMP_ID=b.EMP_ID and ",Function.Common.Ints.tbTongKet)+st
				+" AND ISNULL(LOC_B1,0)=0 and YYY_MM>='"+where1 +"' AND YYY_MM<='"+where2+"'";
			sql2=string.Format("UPDATE {0} SET LST_NM='",Function.Common.Ints.tbLuongTD)+ PublicFunction.A_UserID +"',LST_DT='"+T_String.GetDate().ToString("yyyy/MM/dd HH:mm")+string.Format("',{0}.LCK_BT=1",Function.Common.Ints.tbLuongTD)
				+string.Format(" from FILB01A b where {0}.EMP_ID=b.EMP_ID and ",Function.Common.Ints.tbLuongTD)+st
				+string.Format(" AND ISNULL({0}.LCK_BT,0)=0 and YYY_MM>='",Function.Common.Ints.tbLuongTD)+where1 +"' AND YYY_MM<='"+where2+"'";
			if(rdatt.Checked)			
			{						
				PublicFunction.SQL_Execute(sql);
			}

			if(rdaddup.Checked)			
			{						
				PublicFunction.SQL_Execute(sql1);
				where1=DateTime.Parse(((DateTime)dt_dt1.Value).ToString("yyyy/MM")+"/01").ToString("yyyy/MM/dd");
				where2=DateTime.Parse(((DateTime)dt_dt2.Value).ToString("yyyy/MM")+"/01").AddMonths(1).AddDays(-1).ToString("yyyy/MM/dd");
				sql=string.Format("UPDATE {0} SET USR_CK='",Function.Common.Ints.tbChamCong)+ PublicFunction.A_UserID +string.Format("',LOC_B1=1 from FILB01A b where {0}.EMP_ID=b.EMP_ID ",Function.Common.Ints.tbChamCong)
					+"AND (LOC_B1=0 or LOC_B1 IS NULL) and "+st
					+" AND ATT_DT>='"+where1 +"' AND ATT_DT<='"+where2+"'";
				PublicFunction.SQL_Execute(sql);
			}

			if(rdsalary.Checked)
			{					
				PublicFunction.SQL_Execute(sql2);
				PublicFunction.SQL_Execute(sql1);
				where1=DateTime.Parse(((DateTime)dt_dt1.Value).ToString("yyyy/MM")+"/01").ToString("yyyy/MM/dd");
				where2=DateTime.Parse(((DateTime)dt_dt2.Value).ToString("yyyy/MM")+"/01").AddMonths(1).AddDays(-1).ToString("yyyy/MM/dd");
				sql=string.Format("UPDATE {0} SET USR_CK='",Function.Common.Ints.tbChamCong)+ PublicFunction.A_UserID +string.Format("',LOC_B1=1 from FILB01A b where {0}.EMP_ID=b.EMP_ID ",Function.Common.Ints.tbChamCong)
					+"AND (LOC_B1=0 or LOC_B1 IS NULL) and "+st
					+" AND ATT_DT>='"+where1 +"' AND ATT_DT<='"+where2+"'";
				PublicFunction.SQL_Execute(sql);
			}
			
			MessageBox.Show("......Finished!!!!!!!!!");
				
		}

		private void dt_m_ValueChanged(object sender, System.EventArgs e)
		{
		
		}

		private void btUnLock_Click(object sender, System.EventArgs e)
		{
			string st="",sql="",sql1="",sql2="",where1="",where2="";
			where1=((DateTime)dt_dt1.Value).ToString("yyyy/MM/dd");
			where2=((DateTime)dt_dt2.Value).ToString("yyyy/MM/dd");
			st=control1.GetWhere("b",false);
			//old code
//			sql="UPDATE FILC06A SET USR_CK='',LOC_B1= null from FILB01A b where FILC06A.EMP_ID=b.EMP_ID "
//				+"AND isnull(LOC_B1,0)=1 and (USR_CK='"+PublicFunction.A_UserID +"'  or USR_CK is null) and "+st
//				+" AND ATT_DT>='"+where1 +"' AND ATT_DT<='"+where2+"'";
//			where1=((DateTime)dt_dt1.Value).ToString("yyyyMM");
//			where2=((DateTime)dt_dt2.Value).ToString("yyyyMM");
//			sql1="UPDATE FILC06AA SET LST_NM='"+ PublicFunction.A_UserID +"',LST_DT='"+T_String.GetDate().ToString("yyyy/MM/dd HH:mm")+"',LOC_B1= null"
//				+" from FILB01A b where FILC06AA.EMP_ID=b.EMP_ID AND (FILC06AA.LST_NM='"+ PublicFunction.A_UserID +"'  or FILC06AA.LST_NM is null) and "+st
//				+" AND ISNULL(LOC_B1,0)=1 and YYY_MM>='"+where1 +"' AND YYY_MM<='"+where2+"'";
//			sql2="UPDATE FILD02A SET LST_NM='"+ PublicFunction.A_UserID +"',LST_DT='"+T_String.GetDate().ToString("yyyy/MM/dd HH:mm")+"',FILD02A.LCK_BT=null"
//				+" from FILB01A b where FILD02A.EMP_ID=b.EMP_ID AND (FILD02A.LST_NM='"+ PublicFunction.A_UserID +"'  or FILC06AA.LST_NM is null) and "+st
//				+" AND ISNULL(FILD02A.LCK_BT,0)=1 and YYY_MM>='"+where1 +"' AND YYY_MM<='"+where2+"'";

			//new code
			if(PublicFunction.A_UserID == "admin" || PublicFunction.A_UserID == "vinhtuyen" )
			{
				sql=string.Format("UPDATE {0} SET USR_CK='',LOC_B1= 0 from FILB01A b where {0}.EMP_ID=b.EMP_ID ",Function.Common.Ints.tbChamCong)
					+"AND isnull(LOC_B1,0)=1 and "+st
					+" AND ATT_DT>='"+where1 +"' AND ATT_DT<='"+where2+"'";
				where1=((DateTime)dt_dt1.Value).ToString("yyyyMM");
				where2=((DateTime)dt_dt2.Value).ToString("yyyyMM");
				sql1=string.Format("UPDATE {0} SET LST_NM='",Function.Common.Ints.tbTongKet)+ PublicFunction.A_UserID +"',LST_DT='"+T_String.GetDate().ToString("yyyy/MM/dd HH:mm")+"',LOC_B1= 0"
					+string.Format(" from FILB01A b where {0}.EMP_ID=b.EMP_ID and ",Function.Common.Ints.tbTongKet)+st
					+" AND ISNULL(LOC_B1,0)=1 and YYY_MM>='"+where1 +"' AND YYY_MM<='"+where2+"'";
				sql2=string.Format("UPDATE {0} SET LST_NM='",Function.Common.Ints.tbLuongTD)+ PublicFunction.A_UserID +"',LST_DT='"+T_String.GetDate().ToString("yyyy/MM/dd HH:mm")+"',LCK_BT=0"
					+string.Format(" from FILB01A b where {0}.EMP_ID=b.EMP_ID and ",Function.Common.Ints.tbLuongTD)+st
					+string.Format(" AND ISNULL({0}.LCK_BT,0)=1 and YYY_MM>='",Function.Common.Ints.tbLuongTD)+where1 +"' AND YYY_MM<='"+where2+"'";
			}
			else
			{
				sql=string.Format("UPDATE {0} SET USR_CK='',LOC_B1= 0 from FILB01A b where {0}.EMP_ID=b.EMP_ID ",Function.Common.Ints.tbChamCong)
					+"AND isnull(LOC_B1,0)=1 and (USR_CK='"+PublicFunction.A_UserID +"'  or USR_CK is null) and "+st
					+" AND ATT_DT>='"+where1 +"' AND ATT_DT<='"+where2+"'";
				where1=((DateTime)dt_dt1.Value).ToString("yyyyMM");
				where2=((DateTime)dt_dt2.Value).ToString("yyyyMM");
				sql1=string.Format("UPDATE {0} SET LST_NM='",Function.Common.Ints.tbTongKet)+ PublicFunction.A_UserID +"',LST_DT='"+T_String.GetDate().ToString("yyyy/MM/dd HH:mm")+"',LOC_B1= 0"
					+string.Format(" from FILB01A b where {0}.EMP_ID=b.EMP_ID AND ({0}.LST_NM='",Function.Common.Ints.tbTongKet)+ PublicFunction.A_UserID +string.Format("'  or {0}.LST_NM is null) and ",Function.Common.Ints.tbTongKet)+st
					+" AND ISNULL(LOC_B1,0)=1 and YYY_MM>='"+where1 +"' AND YYY_MM<='"+where2+"'";
				sql2=string.Format("UPDATE {0} SET LST_NM='",Function.Common.Ints.tbLuongTD)+ PublicFunction.A_UserID +"',LST_DT='"+T_String.GetDate().ToString("yyyy/MM/dd HH:mm")+"',LCK_BT=0"
					+string.Format(" from FILB01A b where {0}.EMP_ID=b.EMP_ID AND ({0}.LST_NM='",Function.Common.Ints.tbLuongTD)+ PublicFunction.A_UserID +"'  or FILD02A.LST_NM is null) and "+st
					+string.Format(" AND ISNULL({0}.LCK_BT,0)=1 and YYY_MM>='",Function.Common.Ints.tbLuongTD)+where1 +"' AND YYY_MM<='"+where2+"'";
			}

			if(rdatt.Checked)
			{		
				PublicFunction.SQL_Execute(sql);
			}
			if(rdaddup.Checked)
			{							
				PublicFunction.SQL_Execute(sql1);				
			}
			if(rdsalary.Checked)
			{					
				PublicFunction.SQL_Execute(sql2);				
			}			
			MessageBox.Show("......Finished!!!!!!!!!");
		}
	}
}
