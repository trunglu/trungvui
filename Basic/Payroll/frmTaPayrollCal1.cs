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


namespace GP8000.Payroll
{
	/// <summary>
	/// Summary description for frmTaCardDataSwitch.
	/// </summary>
	public class frmTaPayrollCal : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Button cmd_att;
		private GP8000.UserControl.CrtTaCondition1 control1;
		private System.Windows.Forms.Button cmd_close;
		private SqlConnection con1;
		private System.Windows.Forms.ProgressBar pro1;
		private System.Windows.Forms.Label c1;
		private C1.Win.C1Input.C1DateEdit dt3;
		private System.Windows.Forms.Label label6;
		private C1.Win.C1Input.C1DateEdit dt2;
		private C1.Win.C1Input.C1DateEdit dt1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton r1;
		private System.Windows.Forms.RadioButton r2;
		private System.Windows.Forms.Panel p1;	
		private Func.RecordSet rs_LCB;
		private System.Windows.Forms.Button cmd_sa;
		private System.Windows.Forms.Button cmd_staff;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.PictureBox pictureBox1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmTaPayrollCal()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmTaPayrollCal));
			this.panel3 = new System.Windows.Forms.Panel();
			this.label5 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.c1 = new System.Windows.Forms.Label();
			this.pro1 = new System.Windows.Forms.ProgressBar();
			this.panel5 = new System.Windows.Forms.Panel();
			this.p1 = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.cmd_staff = new System.Windows.Forms.Button();
			this.dt3 = new C1.Win.C1Input.C1DateEdit();
			this.label6 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.r2 = new System.Windows.Forms.RadioButton();
			this.r1 = new System.Windows.Forms.RadioButton();
			this.dt2 = new C1.Win.C1Input.C1DateEdit();
			this.dt1 = new C1.Win.C1Input.C1DateEdit();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.cmd_close = new System.Windows.Forms.Button();
			this.cmd_att = new System.Windows.Forms.Button();
			this.control1 = new GP8000.UserControl.CrtTaCondition1();
			this.cmd_sa = new System.Windows.Forms.Button();
			this.panel3.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel2.SuspendLayout();
			this.p1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dt3)).BeginInit();
			this.groupBox1.SuspendLayout();
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
			this.panel3.Size = new System.Drawing.Size(996, 36);
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
			this.label5.Size = new System.Drawing.Size(996, 36);
			this.label5.TabIndex = 11;
			this.label5.Tag = "";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.panel4);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Controls.Add(this.panel5);
			this.panel1.Controls.Add(this.p1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 36);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(996, 400);
			this.panel1.TabIndex = 14;
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.label3);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel4.Location = new System.Drawing.Point(0, 232);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(996, 168);
			this.panel4.TabIndex = 174;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.LemonChiffon;
			this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label3.Location = new System.Drawing.Point(0, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(996, 168);
			this.label3.TabIndex = 172;
			this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.c1);
			this.panel2.Controls.Add(this.pro1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 180);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(996, 52);
			this.panel2.TabIndex = 173;
			// 
			// c1
			// 
			this.c1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.c1.BackColor = System.Drawing.Color.Black;
			this.c1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.c1.ForeColor = System.Drawing.Color.White;
			this.c1.Location = new System.Drawing.Point(4, 20);
			this.c1.Name = "c1";
			this.c1.Size = new System.Drawing.Size(988, 28);
			this.c1.TabIndex = 8;
			this.c1.Tag = "N";
			this.c1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pro1
			// 
			this.pro1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pro1.Location = new System.Drawing.Point(4, 4);
			this.pro1.Name = "pro1";
			this.pro1.Size = new System.Drawing.Size(988, 16);
			this.pro1.TabIndex = 2;
			// 
			// panel5
			// 
			this.panel5.BackColor = System.Drawing.Color.CornflowerBlue;
			this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel5.Location = new System.Drawing.Point(0, 176);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(996, 4);
			this.panel5.TabIndex = 1;
			// 
			// p1
			// 
			this.p1.Controls.Add(this.pictureBox1);
			this.p1.Controls.Add(this.cmd_staff);
			this.p1.Controls.Add(this.dt3);
			this.p1.Controls.Add(this.label6);
			this.p1.Controls.Add(this.groupBox1);
			this.p1.Controls.Add(this.dt2);
			this.p1.Controls.Add(this.dt1);
			this.p1.Controls.Add(this.label1);
			this.p1.Controls.Add(this.label2);
			this.p1.Controls.Add(this.cmd_close);
			this.p1.Controls.Add(this.cmd_att);
			this.p1.Controls.Add(this.control1);
			this.p1.Controls.Add(this.cmd_sa);
			this.p1.Dock = System.Windows.Forms.DockStyle.Top;
			this.p1.Location = new System.Drawing.Point(0, 0);
			this.p1.Name = "p1";
			this.p1.Size = new System.Drawing.Size(996, 176);
			this.p1.TabIndex = 0;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(836, 4);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(148, 168);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 172;
			this.pictureBox1.TabStop = false;
			// 
			// cmd_staff
			// 
			this.cmd_staff.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_staff.Location = new System.Drawing.Point(688, 12);
			this.cmd_staff.Name = "cmd_staff";
			this.cmd_staff.Size = new System.Drawing.Size(136, 32);
			this.cmd_staff.TabIndex = 170;
			this.cmd_staff.Text = "cal";
			this.cmd_staff.Click += new System.EventHandler(this.cmd_staff_Click);
			// 
			// dt3
			// 
			this.dt3.CustomFormat = "yyyyMM";
			this.dt3.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat;
			this.dt3.Location = new System.Drawing.Point(540, 68);
			this.dt3.Name = "dt3";
			this.dt3.Size = new System.Drawing.Size(132, 23);
			this.dt3.TabIndex = 167;
			this.dt3.Tag = null;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(456, 72);
			this.label6.Name = "label6";
			this.label6.TabIndex = 168;
			this.label6.Text = "label6";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.r2);
			this.groupBox1.Controls.Add(this.r1);
			this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox1.Location = new System.Drawing.Point(456, 88);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(216, 72);
			this.groupBox1.TabIndex = 169;
			this.groupBox1.TabStop = false;
			this.groupBox1.Tag = "N";
			// 
			// r2
			// 
			this.r2.Checked = true;
			this.r2.Location = new System.Drawing.Point(12, 44);
			this.r2.Name = "r2";
			this.r2.Size = new System.Drawing.Size(184, 24);
			this.r2.TabIndex = 1;
			this.r2.TabStop = true;
			this.r2.Text = "radioButton2";
			// 
			// r1
			// 
			this.r1.Location = new System.Drawing.Point(12, 16);
			this.r1.Name = "r1";
			this.r1.Size = new System.Drawing.Size(184, 24);
			this.r1.TabIndex = 0;
			this.r1.Text = "radioButton1";
			// 
			// dt2
			// 
			this.dt2.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat;
			this.dt2.Location = new System.Drawing.Point(540, 40);
			this.dt2.Name = "dt2";
			this.dt2.Size = new System.Drawing.Size(132, 23);
			this.dt2.TabIndex = 163;
			this.dt2.Tag = null;
			this.dt2.ValueChanged += new System.EventHandler(this.dt2_ValueChanged);
			// 
			// dt1
			// 
			this.dt1.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat;
			this.dt1.Location = new System.Drawing.Point(540, 12);
			this.dt1.Name = "dt1";
			this.dt1.Size = new System.Drawing.Size(132, 23);
			this.dt1.TabIndex = 162;
			this.dt1.Tag = null;
			this.dt1.TextChanged += new System.EventHandler(this.dt1_TextChanged);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(456, 16);
			this.label1.Name = "label1";
			this.label1.TabIndex = 161;
			this.label1.Text = "label1";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(456, 44);
			this.label2.Name = "label2";
			this.label2.TabIndex = 164;
			this.label2.Text = "label2";
			// 
			// cmd_close
			// 
			this.cmd_close.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_close.Location = new System.Drawing.Point(688, 126);
			this.cmd_close.Name = "cmd_close";
			this.cmd_close.Size = new System.Drawing.Size(136, 32);
			this.cmd_close.TabIndex = 154;
			this.cmd_close.Text = "button3";
			this.cmd_close.Click += new System.EventHandler(this.cmd_close_Click);
			// 
			// cmd_att
			// 
			this.cmd_att.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_att.Location = new System.Drawing.Point(688, 88);
			this.cmd_att.Name = "cmd_att";
			this.cmd_att.Size = new System.Drawing.Size(136, 32);
			this.cmd_att.TabIndex = 152;
			this.cmd_att.Text = "cal";
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
			// cmd_sa
			// 
			this.cmd_sa.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_sa.Location = new System.Drawing.Point(688, 50);
			this.cmd_sa.Name = "cmd_sa";
			this.cmd_sa.Size = new System.Drawing.Size(136, 32);
			this.cmd_sa.TabIndex = 153;
			this.cmd_sa.Text = "cal";
			this.cmd_sa.Click += new System.EventHandler(this.cmd_sa_Click);
			// 
			// frmTaPayrollCal
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
			this.ClientSize = new System.Drawing.Size(996, 436);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel3);
			this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "frmTaPayrollCal";
			this.Text = "frmTaPayrollCal";
			this.Load += new System.EventHandler(this.frmTaCardDataSwitch_Load);
			this.panel3.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.p1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dt3)).EndInit();
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dt2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dt1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void frmTaCardDataSwitch_Load(object sender, System.EventArgs e)
		{			
			Basic.Function.PublicFunction.L_Init_Label(this);
			control1.InitCB(this.Tag);
			control1.Initlabel();		
			//dt3.Value=dt2.Value=dt1.Value=T_String.GetDate();		
			dt3.Value=dt1.Value=T_String.GetDate().ToString("yyyy/MM")+"/01";
			DateTime ngay=(DateTime)dt1.Value;
			dt2.Value=ngay.AddMonths(1).ToString("yyyy/MM")+"/01";
			dt2.Value=DateTime.Parse(dt2.Value.ToString()).AddDays(-1);
			dt1.CustomFormat=dt2.CustomFormat=PublicFunction.GetOption("DATE");		
		}	

		private void cmd_close_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void cmd_att_Click(object sender, System.EventArgs e)
		{
			Thread th=new Thread(new ThreadStart(Transfer1));
			th.Start();
//			Transfer1();
		}

		private void cmd_sa_Click(object sender, System.EventArgs e)
		{
			Thread th=new Thread(new ThreadStart(Transfer));
			th.Start();
		}
		#region Transfer

		private void Transfer()
		{		
			p1.Enabled=false;
			con1=new SqlConnection(PublicFunction.C_con.ConnectionString);
			if(con1.State==ConnectionState.Closed )
				con1.Open();
			string sql="",dt=T_String.GetDate().ToString("yyyy/MM/dd HH:mm");	
			DateTime d2=DateTime.Parse(dt2.Value+"");
			string SEQ_NO="";
			string YYY_MM=dt3.Text;
			if(r1.Checked)
				SEQ_NO="1";
			else
				SEQ_NO="2";
			rs_LCB=new Func.RecordSet("Select * from FILD01A where BAS_BT=1",con1);
			sql=" delete FILD02A FROM FILB01AC C WHERE FILD02A.EMP_ID=C.EMP_ID AND VAC_DT<='"+ DateTime.Parse(dt1.Value+"").ToString("yyyy/MM/dd") +"' and YYY_MM=N'"+YYY_MM+"'";
			PublicFunction.SQL_Execute(sql,con1);
			sql="Select Distinct a.EMP_ID,EMP_NM,DEP_I1,EMP_DW  from FILC06AA a "+
				 "INNER JOIN FILF01A b ON a.EMP_ID=b.EMP_ID and a.SEQ_NO="+SEQ_NO+" and a.YYY_MM=N'"+YYY_MM+"'"
				+" where "+control1.GetWhere("b",false);
			Func.RecordSet rs=new Func.RecordSet(sql,con1);
			try
			{
				for(int i=0;i<rs.rows;i++)
				{
					string EMP_ID=rs.record(i,"EMP_ID");
					string DEP_ID=rs.record(i,"DEP_I1"),EMP_DW=rs.record(i,"EMP_DW");										
					c1.Text=rs.record(i,"EMP_ID")+" - "+rs.record(i,"EMP_NM")+" | "+((i+1)+"/"+rs.rows);
					string wh;
					sql="Select LCK_BT from FILD02A ";
					wh=" where EMP_ID=N'"+rs.record(i,"EMP_ID")+"' and "
						+"YYY_MM=N'"+dt3.Text+"' and SEQ_NO=";
					if(r1.Checked)
						wh+="1";
					else
						wh+="2";
					Func.RecordSet rs1=new Func.RecordSet(sql+wh ,con1);
					if(rs1.rows<=0 || (rs1.rows>0 &&  rs1.record(0,"LCK_BT")!="True"))
					{
//						if(rs1.rows>0 )
//						{
//							sql="Delete  from FILD02A ";
//							PublicFunction.SQL_Execute(sql+wh);
//						}
						sql="Insert Into FILD02A(EMP_ID,DEP_ID,EMP_DW,YYY_MM,SEQ_NO,REM_DR,BLT_NM,BLT_DT) values(";
						sql+="N'"+EMP_ID+"',N'"+DEP_ID+"',N'"+EMP_DW+"',N'"+YYY_MM+"',";
						if(r1.Checked)
							sql+="1";
						else
							sql+="2";
						sql+=",N'"+DateTime.Parse(dt1.Value+"").ToString("yyyy/MM/dd")+"~"+DateTime.Parse(dt2.Value+"").ToString("yyyy/MM/dd")+"'";
						sql+=",N'"+PublicFunction.A_UserID+"','"+dt+"')";
						try
						{
							PublicFunction.SQL_Execute(sql,con1);									
						}
						catch(SqlException ex){if(ex.Number!=2627 )MessageBox.Show(ex.Message);}
						if(!r1.Checked)
						{
							int seq=T_String.IsNullTo0(T_String.GetDataFromSQL("Count(*)","FILC06AA","EMP_ID=N'"+EMP_ID+"' and YYY_MM=N'"+YYY_MM+"' and SEQ_NO=3"));
							if(seq>0)
							{
								sql="Insert Into FILD02A(EMP_ID,DEP_ID,YYY_MM,SEQ_NO,REM_DR,BLT_NM,BLT_DT) values(";
								sql+="N'"+rs.record(i,"EMP_ID")+"',N'"+DEP_ID+"',N'"+dt3.Text+"',3";							
								sql+=",N'"+DateTime.Parse(dt1.Value+"").ToString("yyyy/MM/dd")+"~"+DateTime.Parse(dt2.Value+"").ToString("yyyy/MM/dd")+"'";
								sql+=",N'"+PublicFunction.A_UserID+"','"+dt+"')";
								try
								{
									PublicFunction.SQL_Execute(sql,con1);									
								}
								catch(SqlException ex){if(ex.Number!=2627 )MessageBox.Show(ex.Message);}
						
								sql="Insert Into FILD02A(EMP_ID,DEP_ID,YYY_MM,SEQ_NO,REM_DR,BLT_NM,BLT_DT) values(";
								sql+="N'"+rs.record(i,"EMP_ID")+"',N'"+DEP_ID+"',N'"+dt3.Text+"',4";							
								sql+=",N'"+DateTime.Parse(dt1.Value+"").ToString("yyyy/MM/dd")+"~"+DateTime.Parse(dt2.Value+"").ToString("yyyy/MM/dd")+"'";
								sql+=",N'"+PublicFunction.A_UserID+"','"+dt+"')";
								try
								{
									PublicFunction.SQL_Execute(sql,con1);									
								}
								catch(SqlException ex){if(ex.Number!=2627 )MessageBox.Show(ex.Message);}
								LCB(EMP_ID,YYY_MM,3,con1);	
								LCB(EMP_ID,YYY_MM,4,con1);	
//								Formula(EMP_ID,YYY_MM,3,con1);
//								Formula(EMP_ID,YYY_MM,4,con1);
							}
							LCB(EMP_ID,YYY_MM,2,con1);	
//							Formula(EMP_ID,YYY_MM,2,con1);
						}
						else						
						{
							LCB(EMP_ID,YYY_MM,1,con1);	
//							Formula(EMP_ID,YYY_MM,1,con1);							
						}
						//						else
						//						{
						//
						//						}
							
					}
					pro1.Value=(int)(i+1)*100/rs.rows;
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
				p1.Enabled=true;
			}	
			pro1.Value=100;
			con1.Close();
			p1.Enabled=true;
		}	
 
		private void Transfer1()
		{		
			p1.Enabled=false;
			con1=new SqlConnection(PublicFunction.C_con.ConnectionString);
			if(con1.State==ConnectionState.Closed )
				con1.Open();
			string sql="",dt=T_String.GetDate().ToString("yyyy/MM/dd HH:mm");	
			rs_LCB=new Func.RecordSet("Select * from FILD01A where BAS_BT=1",con1);
			sql="Select Distinct a.EMP_ID,EMP_NM from FILC06AA a,FILF01A b where a.EMP_ID=b.EMP_ID and "+control1.GetWhere("b",false);
			Func.RecordSet rs=new Func.RecordSet(sql,con1);
			try
			{
				for(int i=0;i<rs.rows;i++)
				{
					string EMP_ID=rs.record(i,"EMP_ID");
					string YYY_MM=dt3.Text;
					c1.Text=rs.record(i,"EMP_ID")+" - "+rs.record(i,"EMP_NM")+" | "+(i+1)+"/"+rs.rows;
					string wh;
					sql="Select LCK_BT from FILD02A ";
					wh=" where EMP_ID=N'"+rs.record(i,"EMP_ID")+"' and "
						+"YYY_MM=N'"+dt3.Text+"' and SEQ_NO=";
					if(r1.Checked)
						wh+="1";
					else
						wh+="2";
					Func.RecordSet rs1=new Func.RecordSet(sql+wh ,con1);
					if(rs1.rows<=0 || (rs1.rows>0 &&  rs1.record(0,"LCK_BT")!="True"))
					{
						if(rs1.rows>0 )
						{
						}
					PublicFunction.SQL_Execute(sql,con1);
						if(!r1.Checked)
						{
							int seq=T_String.IsNullTo0(T_String.GetDataFromSQL("Count(*)","FILC06AA","EMP_ID=N'"+EMP_ID+"' and YYY_MM=N'"+YYY_MM+"' and SEQ_NO=3"));
							if(seq>0)
							{
								Formula(EMP_ID,YYY_MM,3,seq,con1);
								Formula(EMP_ID,YYY_MM,4,seq,con1);
								TongCong(EMP_ID,YYY_MM,2,con1);
							}
							Formula(EMP_ID,YYY_MM,2,seq,con1);
						}
						else						
						{
							Formula(EMP_ID,YYY_MM,1,0,con1);							
						}
						
					}
					pro1.Value=(int)(i+1)*100/rs.rows;
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
				p1.Enabled=true;
			}	
			pro1.Value=100;
			con1.Close();
			p1.Enabled=true;
		}	

		public void LCB(string EMP_ID,string YYY_MM,int SEQ_NO,SqlConnection con1)
		{
			string sql="";	
			Func.RecordSet rs;
			sql="Select * from FILD03A where  (DON_AP=0 OR DON_AP is null) and EMP_ID=N'"+EMP_ID+"' "
					+" and (CHA_DT>'"+ DateTime.Parse(dt1.Value +"").ToString("yyyy/MM/dd")+"' and CHA_DT<='"
					+DateTime.Parse(dt2.Value +"").ToString("yyyy/MM/dd")+"')";
			if(SEQ_NO==4 || SEQ_NO==3) // luong thay doi trong thang
			{
				if(SEQ_NO==4)
				{
					sql+=" ORDER BY CHA_DT desc";
					rs=new Func.RecordSet(sql,con1);					
				}
				else				
				{
					sql="Select * from FILD03A where  (DON_AP=0 OR DON_AP is null) and EMP_ID=N'"+EMP_ID+"' "
						+" and   CHA_DT<='"
						+DateTime.Parse(dt2.Value +"").ToString("yyyy/MM/dd")+"'";
					sql+=" ORDER BY CHA_DT desc";
					rs=new Func.RecordSet(sql,con1);		
					
				}
				if(rs.rows<0)
				{
					sql="Select * from FILD03A where  (DON_AP=0 OR DON_AP is null) and EMP_ID=N'"+EMP_ID+"' ORDER BY CHA_DT desc";
					rs=new Func.RecordSet(sql,con1);	
				}
			}
			else
			{		
				sql="Select * from FILD03A where  (DON_AP=0 OR DON_AP is null) and CHA_DT<='"
					+DateTime.Parse(dt2.Value +"").ToString("yyyy/MM/dd")+"' and EMP_ID=N'"+EMP_ID+"' ORDER BY CHA_DT desc";
				rs=new Func.RecordSet(sql,con1);	
			}	

			sql="Select * from FILD02A where  EMP_ID=N'"+EMP_ID+"' and YYY_MM=N'"+YYY_MM+"' and SEQ_NO="+SEQ_NO;
			Func.RecordSet rs1=new Func.RecordSet(sql,con1);
			sql="";
			if(rs.rows<=0)
				return;
			for(int i=0;i<rs_LCB.rows;i++)
			{
				if( T_String.IsNullTo00(rs1.record(0,rs_LCB.record(i,"COL_NM"))+"")<=0) 
				{
					if(sql!="") sql+=",";
					if(SEQ_NO==3 && rs.rows>1)					
						sql+=""+rs_LCB.record(i,"COL_NM")+"="+T_String.IsNullTo00(rs.record(1,rs_LCB.record(i,"COL_NM"))+"");
					
					else
						sql+=""+rs_LCB.record(i,"COL_NM")+"="+T_String.IsNullTo00(rs.record(0,rs_LCB.record(i,"COL_NM"))+"");
				}
			}
			if(sql!="")
			{
				sql="update FILD02A  set " +sql+" where EMP_ID=N'"+EMP_ID+"' and SEQ_NO="+SEQ_NO+" and YYY_MM=N'"+YYY_MM+"'";
				PublicFunction.SQL_Execute(sql,con1);
			}
		}
	
		public void Formula(string EMP_ID,string YYY_MM,int SEQ_NO, int seq, SqlConnection con1)
		{
//			PublicFunction.Copy_Table(
			string sql="Select * from FILD01B where ";
			if (SEQ_NO==1)
				sql+="FST_BT=1";
			else
			{
				if(SEQ_NO==2)
				{
					sql+="LST_BT=1";
				}
				else
				{
					if(SEQ_NO==3)
					{
						sql+="BEF_BT=1";
					}
					else						
						sql+="AFT_BT=1";
				}
			}

			if (seq > 0 && SEQ_NO==2) sql += " and isnull(SUM_BT,0)=0";

			Func.RecordSet rs2=new Func.RecordSet(sql+" ORDER BY SEQ_N1",con1);
			for(int n=0;n<rs2.rows;n++)
			{
				try
				{
					sql=rs2.record(n,"SQL_DR")+" and FILD02A.EMP_ID=N'"+EMP_ID+"' and FILD02A.YYY_MM=N'"+YYY_MM+"' and FILD02A.YYY_MM= FILC06AA.YYY_MM";
					sql+=" and  FILD02A.SEQ_NO="+SEQ_NO +" and FILD02A.SEQ_NO=FILC06AA.SEQ_NO and (FILD02A.LCK_BT=0 or FILD02A.LCK_BT is null)";
					
					if((sql.IndexOf("[DayOfMonth()]")>0)||(sql.IndexOf("[SundayOfMonth()]")>0) || (sql.IndexOf("[SaturdayOfMonth()]")>0) 
						|| (sql.IndexOf("[HolidayOfMonth()]")>0) || (sql.IndexOf("[CalDate_From()]")>0) || (sql.IndexOf("[CalDate_To()]")>0) 
						|| (sql.IndexOf("[VacateDaysNoSUN()]")>0) || (sql.IndexOf("[CalDate_Month()]")>0))
					{
						sql=FunSql(EMP_ID,sql,YYY_MM,con1);
					}
					PublicFunction.SQL_Execute(sql,con1);
				}
				catch(Exception ex)
				{
					MessageBox.Show(ex.Message+" " +sql);									
				}	
			}
		}

		public void TongCong(string EMP_ID,string YYY_MM,int SEQ_NO,SqlConnection con1)
		{
			//			PublicFunction.Copy_Table(
			string sql="Select * from FILD01B where  BEF_BT=1 and AFT_BT=1 and ITE_NM IN (SELECT '['+COL_NM+']' FROM FILD01A) and SUM_BT=1";
			
			Func.RecordSet rs2=new Func.RecordSet(sql+" ORDER BY SEQ_N1",con1);
			for(int n=0;n<rs2.rows;n++)
			{
				try
				{
					string ITE_NM=rs2.record(n,"ITE_NM");
					Double ITE_NM3,ITE_NM4;
					
					ITE_NM3=T_String.IsNullTo00(T_String.GetDataFromSQL(ITE_NM,"FILD02A",
						"EMP_ID=N'"+EMP_ID+"' and YYY_MM=N'"+YYY_MM+"' and SEQ_NO=3" ));
					ITE_NM4=T_String.IsNullTo00(T_String.GetDataFromSQL(ITE_NM,"FILD02A",
						"EMP_ID=N'"+EMP_ID+"' and YYY_MM=N'"+YYY_MM+"' and SEQ_NO=4" ));
					sql="update FILD02A set "+ITE_NM+"="+(ITE_NM3+ITE_NM4)+" where EMP_ID=N'"+EMP_ID+"' and YYY_MM=N'"+YYY_MM+"' and SEQ_NO=2";
					PublicFunction.SQL_Execute(sql,con1);
				}
				catch(Exception ex)
				{
					MessageBox.Show(ex.Message+" " +sql);									
				}	
			}
		}

		private string FunSql(string EMP_ID,string sql,string YYY_MM,SqlConnection con)
		{
            DateTime dt=new DateTime(T_String.IsNullTo0(PublicFunction.S_Left(YYY_MM,4)),
				T_String.IsNullTo0(PublicFunction.S_Right(YYY_MM,2)),1);
//			if(sql.IndexOf("[DayOfMonth()]")>0)
//				sql=sql.Replace("[DayOfMonth()]",DayOfMonth(dt)+"");
//			if(sql.IndexOf("[SundayOfMonth()]")>0)
//				sql=sql.Replace("[SundayOfMonth()]",SundayOfMonth(dt)+"");
//			sql=sql.Replace("[SaturdayOfMonth()]",SaturdayOfMonth(dt)+"");
//			sql=sql.Replace("[HolidayOfMonth()]",HolidayOfMonth(dt,con)+"");

			if(sql.IndexOf("[DayOfMonth()]")>0)
				sql=sql.Replace("[DayOfMonth()]",DayOfMonth()+"");
			if(sql.IndexOf("[SundayOfMonth()]")>0)
				sql=sql.Replace("[SundayOfMonth()]",SundayOfMonth()+"");
			sql=sql.Replace("[SaturdayOfMonth()]",SaturdayOfMonth()+"");
			sql=sql.Replace("[HolidayOfMonth()]",HolidayOfMonth(con)+"");
			// ___________________________________________________
			sql=sql.Replace("[CalDate_From()]",CalDate_From()+"");
			sql=sql.Replace("[CalDate_To()]",CalDate_To()+"");
			sql=sql.Replace("[CalDate_Month()]",CalDate_Month()+"");
			//sql=sql.Replace("[VacateDays())]",VacateDays()+"");
			if(sql.IndexOf("[VacateDaysNoSUN()]")>0)
				sql=sql.Replace("[VacateDaysNoSUN()]",VacateDaysNoSUN(EMP_ID,con,dt)+"");
			return sql;
		}
		private int VacateDaysNoSUN(string EMP_ID,SqlConnection con,DateTime dt)
		{
			Func.RecordSet rs=new Func.RecordSet("Select VAC_DT from FILB01AC where EMP_ID=N'"+
				EMP_ID+"'",con);
//			if (rs.rows==0)
//			{
//				rs=new Func.RecordSet("Select VAC_DT from FILB01ACA where EMP_ID=N'"+
//				EMP_ID+"' and datediff(month,VAC_DT,'"+dt.ToString("yyyy/MM/dd")+"')=0",con);
//			}

			Func.RecordSet rs1=new Func.RecordSet("Select INH_DT from FILB01A where EMP_ID=N'"+
				EMP_ID+"'",con);
			if(rs.rows<=0 && rs1.rows<=0)
				return 0;
			try
			{
				int count=0;										
				if(rs.rows>0)
				{
					DateTime d1=DateTime.Parse(rs.record(0,0));
					DateTime d2= DateTime.Parse(dt2.Value+"");						
					while( T_String.IsNullTo0(d1.ToString("yyyyMMdd")) <T_String.IsNullTo0(d2.ToString("yyyyMMdd")))
					{
						if(d1.DayOfWeek!=DayOfWeek.Sunday)
							count++;
						d1=d1.AddDays(1);
					}
					
				}
				if(rs1.rows>0)
				{
					DateTime d1=DateTime.Parse(dt1.Value+"");
					DateTime d2= DateTime.Parse(rs1.record(0,0));						
					while( T_String.IsNullTo0(d1.ToString("yyyyMMdd")) <T_String.IsNullTo0(d2.ToString("yyyyMMdd")))
					{
						if(d1.DayOfWeek!=DayOfWeek.Sunday)
							count++;
						d1=d1.AddDays(1);
					}
				}
				return count;
			}
			catch{return 0;}
		}
		private string CalDate_From()
		{
			return "'"+DateTime.Parse(dt1.Value+"").ToString("yyyy/MM/dd")+"'";
		}

		private string CalDate_To()
		{
			return "'"+DateTime.Parse(dt2.Value+"").ToString("yyyy/MM/dd")+"'";
		}

		private string CalDate_Month()
		{
			return "'"+DateTime.Parse(dt3.Value+"").ToString("yyyyMM")+"'";
		}
		
/*
		private int DayOfMonth(DateTime dt)
		{
			return DateTime.DaysInMonth(dt.Year,dt.Month);
		}
		private int SundayOfMonth(DateTime dt)
		{
			int dem=0;
			for(int i=1;i<=DateTime.DaysInMonth(dt.Year,dt.Month);i++)
			{
				DateTime d=new DateTime(dt.Year, dt.Month,i);
				if(d.DayOfWeek==System.DayOfWeek.Sunday)
					dem++;
			}
			return dem;
		}
		private int SaturdayOfMonth(DateTime dt)
		{
			int dem=0;
			for(int i=1;i<=DateTime.DaysInMonth(dt.Year,dt.Month);i++)
			{
				DateTime d=new DateTime(dt.Year, dt.Month,i);
				if(d.DayOfWeek==System.DayOfWeek.Saturday)
					dem++;
			}
			return dem;
		}
		private int HolidayOfMonth(DateTime dt,SqlConnection con)
		{
			Func.RecordSet rs=new Func.RecordSet("Select * from FILA16A where YYY_YY=N'"
				+dt.Year+"' and MMM_MM="+dt.Month,con);
			if(rs.rows<=0)
				return 0;
			int dem=0;
			for(int i=1;i<=DateTime.DaysInMonth(dt.Year,dt.Month);i++)
			{
				if(rs.record(0,"h"+i)=="True")
					dem++;
			}
			return dem;
		}
*/
		private int DayOfMonth()
		{
			int dem=0;
			DateTime ngaybatdau= (DateTime) dt1.Value;
			DateTime ngayketthuc= (DateTime) dt2.Value;
			while(T_String.IsNullTo0(ngaybatdau.ToString("yyyyMMdd"))<=T_String.IsNullTo0(ngayketthuc.ToString("yyyyMMdd")))// tung Ngay
			{
				dem++;
				ngaybatdau=ngaybatdau.AddDays(1);
			}
			return dem;
		}

		private int SundayOfMonth()
		{
			int dem=0;
			DateTime ngaybatdau= (DateTime) dt1.Value;
			DateTime ngayketthuc= (DateTime) dt2.Value;
			while(T_String.IsNullTo0(ngaybatdau.ToString("yyyyMMdd"))<=T_String.IsNullTo0(ngayketthuc.ToString("yyyyMMdd")))// tung Ngay
			{
				if(ngaybatdau.DayOfWeek==System.DayOfWeek.Sunday)
					dem++;
				ngaybatdau=ngaybatdau.AddDays(1);
			}
			return dem;
		}
		private int SaturdayOfMonth()
		{
			int dem=0;
			DateTime ngaybatdau= (DateTime) dt1.Value;
			DateTime ngayketthuc= (DateTime) dt2.Value;
			while(T_String.IsNullTo0(ngaybatdau.ToString("yyyyMMdd"))<=T_String.IsNullTo0(ngayketthuc.ToString("yyyyMMdd")))// tung Ngay
			{
				if(ngaybatdau.DayOfWeek==System.DayOfWeek.Saturday)
					dem++;
				ngaybatdau=ngaybatdau.AddDays(1);
			}
			return dem;
		}
		private int HolidayOfMonth(SqlConnection con)
		{
			int dem=0;
			DateTime ngaybatdau= (DateTime) dt1.Value;
			DateTime ngayketthuc= (DateTime) dt2.Value;
			while(T_String.IsNullTo0(ngaybatdau.ToString("yyyyMMdd"))<=T_String.IsNullTo0(ngayketthuc.ToString("yyyyMMdd")))// tung Ngay
			{
				Func.RecordSet rs=new Func.RecordSet("Select h" + ngaybatdau.Day + " from FILA16A where YYY_YY=N'"
					+ngaybatdau.Year+"' and MMM_MM="+ngaybatdau.Month,con);
				if(rs.rows<=0)
					return 0;
				if(rs.record(0,"h"+ngaybatdau.Day)=="True")
					dem++;
				ngaybatdau=ngaybatdau.AddDays(1);
			}
			return dem;
		}
		#endregion	

		private void cmd_staff_Click(object sender, System.EventArgs e)
		{
			GP8000.Payroll.frmTaTransferStaff dlg=new GP8000.Payroll.frmTaTransferStaff();
			dlg.dt1.CustomFormat=dlg.dt2.CustomFormat=PublicFunction.GetOption("DATE");		
			dlg.dt1.Value=dt1.Value;
			dlg.dt2.Value=dt2.Value;
			dlg.Tag=this.Tag;
			dlg.ShowDialog();
		}

		private void dt1_TextChanged(object sender, System.EventArgs e)
		{
			dt3.Value = dt1.Value ;
			DateTime ngay=(DateTime)dt1.Value;
			dt2.Value=ngay.AddMonths(1).ToString("yyyy/MM")+"/01";
			dt2.Value=DateTime.Parse(dt2.Value.ToString()).AddDays(-1);
		}

		private void dt2_ValueChanged(object sender, System.EventArgs e)
		{
			dt3.Value=dt2.Value;
		}
	}
}
