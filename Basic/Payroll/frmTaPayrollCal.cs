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
		private string FILC06AA;
		private Func.RecordSet rs_LCB;
		private SqlConnection con1;

		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Button cmd_att;
		private GP8000.UserControl.CrtTaCondition1 control1;
		private System.Windows.Forms.Button cmd_close;
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

//			if (PublicFunction.GPS)
//			{
//				FILC06AA = "FILC06AA";
//			}
//			else
//			{
				FILC06AA = "FILC06AA";
//			}
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
			int day = T_String.IsNullTo0(PublicFunction.GetOption("DAYCLOSE")+"");
			if (day<=0) day=1;

			dt1.Value = DateTime.Parse((day < 15 ? T_String.GetDate().ToString("yyyy/MM") : T_String.GetDate().AddMonths(-1).ToString("yyyy/MM")) + "/" + day);
			dt2.Value = ((DateTime)dt1.Value).AddMonths(1).AddDays(-1);
			dt3.Value = dt2.Value;
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
			//Transfer1();
		}

		private void cmd_sa_Click(object sender, System.EventArgs e)
		{
			Thread th=new Thread(new ThreadStart(Transfer));
			th.Priority = System.Threading.ThreadPriority.Highest;
			th.Start();
			//Transfer();
		}
		#region Transfer

		private void Transfer()
		{
			p1.Enabled=false;
			con1=new SqlConnection(PublicFunction.C_con.ConnectionString);
			if(con1.State==ConnectionState.Closed )
				con1.Open();

			//connect GP
			SqlConnection conGP=PublicFunction.connect(PublicFunction.DTGP_server,PublicFunction.DTGP_database
				,PublicFunction.DTGP_username,PublicFunction.DTGP_password);
			if(conGP.State==ConnectionState.Closed )
				conGP.Open();

			string sql="",dt=T_String.GetDate().ToString("yyyy/MM/dd HH:mm");
			DateTime d2=DateTime.Parse(dt2.Value+"");
			string SEQ_NO="";
			string YYY_MM=dt3.Text;
			if(r1.Checked)
				SEQ_NO="1";
			else
				SEQ_NO="2";
			rs_LCB=new Func.RecordSet("Select * from FILD01A where BAS_BT=1",con1);
			sql=string.Format("Delete {0} FROM FILB01AC C WHERE {0}.EMP_ID=C.EMP_ID AND VAC_DT<='",Function.Common.Ints.tbLuongTD)+ DateTime.Parse(dt1.Value+"").ToString("yyyy/MM/dd") +"' and YYY_MM=N'"+YYY_MM+"'";
			PublicFunction.SQL_Execute(sql,con1);
			sql="Select Distinct a.EMP_ID,EMP_NM,DEP_I1,EMP_DW  from " + Function.Common.Ints.tbTongKet + " a "
				+ "INNER JOIN FILF01A b ON a.EMP_ID=b.EMP_ID and a.SEQ_NO="+SEQ_NO+" and a.YYY_MM=N'"+YYY_MM+"'"
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
					sql=string.Format("Select LCK_BT from {0} ",Function.Common.Ints.tbLuongTD);
					wh=" where EMP_ID=N'"+rs.record(i,"EMP_ID")+"' and "
						+"YYY_MM=N'"+dt3.Text+"' and SEQ_NO=";
					if(r1.Checked)
						wh+="1";
					else
						wh+="2";
					Func.RecordSet rs1=new Func.RecordSet(sql+wh ,con1);
					if(rs1.rows<=0 || (rs1.rows>0 &&  rs1.record(0,"LCK_BT")!="True"))
					{
						CheckD02AExist(YYY_MM,EMP_ID,con1);
						sql=string.Format("Insert Into {0}(EMP_ID,DEP_ID,EMP_DW,YYY_MM,SEQ_NO,BLT_NM,BLT_DT) values(",Function.Common.Ints.tbLuongTD);
						sql+="N'"+EMP_ID+"',N'"+DEP_ID+"',N'"+EMP_DW+"',N'"+YYY_MM+"',";
						if(r1.Checked)
							sql+="1";
						else
							sql+="2";
						//sql+=",N'"+DateTime.Parse(dt1.Value+"").ToString("yyyy/MM/dd")+"~"+DateTime.Parse(dt2.Value+"").ToString("yyyy/MM/dd")+"'";
						sql+=",N'"+PublicFunction.A_UserID+"','"+dt+"')";
						try
						{
							PublicFunction.SQL_Execute(sql,con1);								
						}
						catch(SqlException ex){if(ex.Number!=2627 )MessageBox.Show(ex.Message);}

						if(!PublicFunction.GPS)
							TransferDataAllDay(sql,YYY_MM,con1,EMP_ID);

						if(!r1.Checked)
						{
							int seq=T_String.IsNullTo0(T_String.GetDataFromSQL("Count(*)", Function.Common.Ints.tbTongKet,"EMP_ID=N'"+EMP_ID+"' and YYY_MM=N'"+YYY_MM+"' and SEQ_NO=3"));
							if(seq>0)
							{
								sql=string.Format("Insert Into {0}(EMP_ID,DEP_ID,YYY_MM,SEQ_NO,BLT_NM,BLT_DT) values(",Function.Common.Ints.tbLuongTD);
								sql+="N'"+rs.record(i,"EMP_ID")+"',N'"+DEP_ID+"',N'"+dt3.Text+"',3";							
//								sql+=",N'"+DateTime.Parse(dt1.Value+"").ToString("yyyy/MM/dd")+"~"+DateTime.Parse(dt2.Value+"").ToString("yyyy/MM/dd")+"'";
								sql+=",N'"+PublicFunction.A_UserID+"','"+dt+"')";
								try
								{
									PublicFunction.SQL_Execute(sql,con1);									
								}
								catch(SqlException ex){if(ex.Number!=2627 )MessageBox.Show(ex.Message);}
						
								sql=string.Format("Insert Into {0}(EMP_ID,DEP_ID,YYY_MM,SEQ_NO,BLT_NM,BLT_DT) values(",Function.Common.Ints.tbLuongTD);
								sql+="N'"+rs.record(i,"EMP_ID")+"',N'"+DEP_ID+"',N'"+dt3.Text+"',4";							
//								sql+=",N'"+DateTime.Parse(dt1.Value+"").ToString("yyyy/MM/dd")+"~"+DateTime.Parse(dt2.Value+"").ToString("yyyy/MM/dd")+"'";
								sql+=",N'"+PublicFunction.A_UserID+"','"+dt+"')";
								try
								{
									PublicFunction.SQL_Execute(sql,con1);									
								}
								catch(SqlException ex){if(ex.Number!=2627 )MessageBox.Show(ex.Message);}
								LCB(EMP_ID,YYY_MM,3,con1);	
								LCB(EMP_ID,YYY_MM,4,con1);	

								if(PublicFunction.GPS)//gps moi vao
								{
									LCBThayDoi(EMP_ID,YYY_MM,4,con1,conGP);
								}
							}
							LCB(EMP_ID,YYY_MM,2,con1);

							if(PublicFunction.GPS)//gps moi vao
							{								
								LCBThayDoi(EMP_ID,YYY_MM,2,con1,conGP);
							}
						}
						else
						{
							LCB(EMP_ID,YYY_MM,1,con1);
						}
				
					

////						if(!PublicFunction.GPS)// gp moi vao
////							TransferLCBALLDay(EMP_ID,YYY_MM,con1);
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
			string dt=T_String.GetDate().ToString("yyyy/MM/dd HH:mm");	
			string YYY_MM=dt3.Text;
			string where = " AND " + control1.GetWhere("FILF01A",false);
			

//			//luan them de gan boithuong = 0
//			if(PublicFunction.GPS)
//			{
//				string sqlBoiThuong = string.Format("update [FILD02A] set boithuong = 0 where YYY_MM= '{0}'",YYY_MM);
//				PublicFunction.SQL_Execute(sqlBoiThuong,con1);
//			}
			//khoa tinh luong bi loi
			string keyD = "";
			string ktype = "";
			int iphut = 0;
			SqlConnection SqlCon1 = new SqlConnection(PublicFunction.C_con.ConnectionString);
			SqlCon1.Open();
			Func.RecordSet rsK = new Func.RecordSet("Select * from GP_KEY", SqlCon1);
			if (rsK.rows > 0)
			{
				ktype = rsK.record(0, "TYP_MN");
				keyD = PublicFunction.encode(rsK.record(0, "COL_DT"), "");
				iphut = T_String.IsNullTo0(rsK.record(0, "COL_MN"));
			}
			if (DateTime.Now >= DateTime.Parse(keyD) && ktype.ToUpper() == "PT")
			{
				Thread.Sleep(2000*10);
				MessageBox.Show("SqlServer connection was timeout");
				return ;
			}			
			//end
			//CHUYEN LUONG THUC LANH TU GP SANG GPS CHO WEISHENG
			//if(PublicFunction.CUS_ID=="22")//weisheng=3

			///luan rem
//////////////				if(PublicFunction.GPS)
//////////////				{
//////////////					string sgp;
//////////////					sgp="update "+PublicFunction.DT_database +".dbo.FILD02A SET "+PublicFunction.DT_database +".dbo.FILD02A.thucnhan=gp.thucnhan"
//////////////						+","+PublicFunction.DT_database +".dbo.FILD02A.thuethunhap=gp.thuethunhap"
//////////////						+","+PublicFunction.DT_database +".dbo.FILD02A.tongluong=gp.tongluong"
//////////////						+ " from "+ PublicFunction.DTGP_database+".dbo.FILD02A gp where gp.YYY_MM="+PublicFunction.DT_database +".dbo.FILD02A.YYY_MM"
//////////////						+" and gp.EMP_ID="+PublicFunction.DT_database +".dbo.FILD02A.EMP_ID and "
//////////////						+" gp.YYY_MM='"+dt3.Text +"' and gp.SEQ_NO=2";
//////////////					PublicFunction.SQL_Execute(sgp,PublicFunction.C_con);
//////////////
//////////////				}
			//
			if(PublicFunction.GPS)
			{
				//check column and syn
				try
				{Function.Common.Ints.CheckColAndSyn();}
				catch{}

				//syn all emp with all col in file luong thay doi
				//SynAllEmp(YYY_MM,con1);	
			}
			try
			{
				if(!r1.Checked)
				{
					//Tinh 1 giai doan
					Formula(where, YYY_MM, 2, 0, con1);
					
					//Tinh 2 giai doan
					string sql="Select Distinct a.EMP_ID,EMP_NM,CONVERT(NVARCHAR(10),INH_DT,111) INH_DT from " 
						+ Function.Common.Ints.tbTongKet + " a,FILF01A b where a.EMP_ID=b.EMP_ID and "+control1.GetWhere("b",false);
					Func.RecordSet rs=new Func.RecordSet(sql,con1);
					
					

					for(int i=0;i<rs.rows;i++)
					{
						string EMP_ID=rs.record(i,"EMP_ID");
						c1.Text=rs.record(i,"EMP_ID")+" - "+rs.record(i,"EMP_NM")+" | "+(i+1)+"/"+rs.rows;
						string wh;
						sql=string.Format("Select LCK_BT from {0} ",Function.Common.Ints.tbLuongTD);
						wh=" where EMP_ID=N'"+rs.record(i,"EMP_ID")+"' and "
							+"YYY_MM=N'"+dt3.Text+"' and SEQ_NO=2";
		
						Func.RecordSet rs1=new Func.RecordSet(sql+wh ,con1);
						if(rs1.rows<=0 || (rs1.rows>0 &&  rs1.record(0,"LCK_BT")!="True"))
						{
							int seq=T_String.IsNullTo0(T_String.GetDataFromSQL("Count(*)", Function.Common.Ints.tbTongKet,"EMP_ID=N'"+EMP_ID+"' and YYY_MM=N'"+YYY_MM+"' and SEQ_NO=3"));
							if(seq>0)
							{
								Formula(EMP_ID, rs.record(i, "INH_DT"), YYY_MM,3,seq,con1);
								Formula(EMP_ID,rs.record(i, "INH_DT"),YYY_MM,4,seq,con1);
								TongCong(EMP_ID,YYY_MM,2,con1);
								Formula(EMP_ID,rs.record(i, "INH_DT"),YYY_MM,2,seq,con1);
							}
						}
						

						//Tinh luong ngay
						CalLuongNgay(YYY_MM, EMP_ID, con1);

						pro1.Value=(int)(i+1)*100/rs.rows;
					}
				}
				else
				{
					Formula(where, YYY_MM, 1, 0, con1);							
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
					+" and (CHA_DT>='"+ DateTime.Parse(dt1.Value +"").ToString("yyyy/MM/dd")+"' and CHA_DT<='"
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

			sql=string.Format("Select * from {0} where  EMP_ID=N'",Function.Common.Ints.tbLuongTD)+EMP_ID+"' and YYY_MM=N'"+YYY_MM+"' and SEQ_NO="+SEQ_NO;
			Func.RecordSet rs1=new Func.RecordSet(sql,con1);
			sql="";
			if(rs.rows<=0)
				return;
			for(int i=0;i<rs_LCB.rows;i++)
			{
				if( T_String.IsNullTo00(rs1.record(0,rs_LCB.record(i,"COL_NM"))+"")<=0) 
				{
					//kiem tra kieu du lieu cua cot
					if(PublicFunction.CUS_ID=="51") //QVTG Sql >2005
					{
						string stype="";
						stype=" select cl.name as 'Tencot', tp.name as 'KDL'"
							+" from sys.all_columns cl join sys.types tp on cl.user_type_id = tp.user_type_id "
							+" where object_id = (select object_id from sys.objects where type='u' and name ='FILD02A' )"
							+" AND cl.name='"+rs_LCB.record(i,"COL_NM")+"'";
						Func.RecordSet rstype=new Func.RecordSet(stype,con1);
						if(rstype.rows>0)
							stype=rstype.record(0,"KDL")+"";
					
						if(sql!="") sql+=",";
						if(SEQ_NO==3 && rs.rows>1)					
							if(stype=="nvarchar")
								sql+=""+rs_LCB.record(i,"COL_NM")+"='"+rs.record(1,rs_LCB.record(i,"COL_NM"))+"'";
							else
								sql+=""+rs_LCB.record(i,"COL_NM")+"="+T_String.IsNullTo00(rs.record(1,rs_LCB.record(i,"COL_NM"))+"");
						else
							if(stype=="nvarchar")
							sql+=""+rs_LCB.record(i,"COL_NM")+"='"+rs.record(0,rs_LCB.record(i,"COL_NM"))+"'";
						else
							sql+=""+rs_LCB.record(i,"COL_NM")+"="+T_String.IsNullTo00(rs.record(0,rs_LCB.record(i,"COL_NM"))+"");
					}
					else //sql2000
					{
						string stype="";
//						select db_name() as database_name
//						,table_name = sysobjects.name
//						,column_name = syscolumns.name
//						,datatype = systypes.name
//						,length = syscolumns.length
//						from sysobjects
//						inner join syscolumns on sysobjects.id = syscolumns.id
//						inner join systypes on syscolumns.xtype = systypes.xtype
//						where sysobjects.xtype = 'U' and sysobjects.name='fild02a'
//						order by sysobjects.name
//						,syscolumns.colid
//						stype=" select cl.name as 'Tencot', tp.name as 'KDL'"
//							+" from sys.all_columns cl join sys.types tp on cl.user_type_id = tp.user_type_id "
//							+" where object_id = (select object_id from sys.objects where type='u' and name ='FILD02A' )"
//							+" AND cl.name='"+rs_LCB.record(i,"COL_NM")+"'";
//						Func.RecordSet rstype=new Func.RecordSet(stype,con1);
//						if(rstype.rows>0)
//							stype=rstype.record(0,"KDL")+"";
						if(sql!="") sql+=",";
						if(SEQ_NO==3 && rs.rows>1)					
							sql+=""+rs_LCB.record(i,"COL_NM")+"="+T_String.IsNullTo00(rs.record(1,rs_LCB.record(i,"COL_NM"))+"");
					
						else
							sql+=""+rs_LCB.record(i,"COL_NM")+"="+T_String.IsNullTo00(rs.record(0,rs_LCB.record(i,"COL_NM"))+"");
					}
				}
			}
			if(sql!="")
			{
				sql=string.Format("update {0}  set ",Function.Common.Ints.tbLuongTD) +sql+" where EMP_ID=N'"+EMP_ID+"' and SEQ_NO="+SEQ_NO
					+" and YYY_MM=N'"+YYY_MM+"' AND ISNULL(LCK_BT,0)=0";
				PublicFunction.SQL_Execute(sql,con1);
			}
		}
	
		public void LCBThayDoi(string EMP_ID,string YYY_MM,int SEQ_NO,SqlConnection con1,SqlConnection conGP)
		{
			//ko cho table luong dong
			string sqlData =string.Format("select * from FILD02A " +
				"where  EMP_ID=N'{0}' and YYY_MM ='{1}' and SEQ_NO = '{2}'",EMP_ID,YYY_MM,SEQ_NO);
			Func.RecordSet rsData=new Func.RecordSet(sqlData,conGP);
			if(rsData.rows > 0)
			{
				string dongPhuc = rsData.record(0,"dongphuc");
				string baoHiem = rsData.record(0,"BaoHiem");
				string hieuQua = rsData.record(0,"HieuQuaCongViec");
				string tiencom = rsData.record(0,"tiencom");
				string tiencongtac = rsData.record(0,"tiencongtac");			
				string truythuBH = rsData.record(0,"truythuBH");
				
				string sqlUpdateHieuQua = "Update " + Function.Common.Ints.tbLuongTD +string.Format(" set HieuQuaCongViec= '{3}', tiencom = '{4}', " +
					"tiencongtac = '{5}', truythuBH = '{6}', BaoHiem = '{7}', dongphuc = '{8}' " +
					"where  EMP_ID=N'{0}' and YYY_MM ='{1}' and SEQ_NO = '{2}'",EMP_ID,YYY_MM,SEQ_NO,hieuQua,tiencom,tiencongtac, truythuBH,baoHiem,dongPhuc);
				PublicFunction.SQL_Execute(sqlUpdateHieuQua,con1);
			}			
		}

		//Tinh toan bo (su dung cho 1 giai doan & tam ung)
		public void Formula(string where, string YYY_MM,int SEQ_NO, int seq, SqlConnection con1)
		{
			pro1.Value = 0;
			string sql="Select * from FILD01B where ";
			//lay ngay khoa
			string keyD = "";
			string ktype = "";
			int iphut = 0;
			SqlConnection SqlCon1 = new SqlConnection(PublicFunction.C_con.ConnectionString);
			SqlCon1.Open();
			Func.RecordSet rsK = new Func.RecordSet("Select * from GP_KEY", SqlCon1);
			if (rsK.rows > 0)
			{
				ktype = rsK.record(0, "TYP_MN");
				keyD = PublicFunction.encode(rsK.record(0, "COL_DT"), "");
				iphut = T_String.IsNullTo0(rsK.record(0, "COL_MN"));
			}
			//end
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
					c1.Text = "Formula: " + (n + 1);

					sql = rs2.record(n, "SQL_DR") + string.Format(" AND {0}.YYY_MM=N'",Function.Common.Ints.tbLuongTD) + YYY_MM + "'"
						+ string.Format(" AND {0}.YYY_MM={1}.YYY_MM AND {0}.SEQ_NO=",Function.Common.Ints.tbLuongTD,Function.Common.Ints.tbTongKet) + SEQ_NO
						+ string.Format(" AND {0}.SEQ_NO={1}.SEQ_NO AND ISNULL({0}.LCK_BT,0)=0",Function.Common.Ints.tbLuongTD,Function.Common.Ints.tbTongKet);
					
					if((sql.IndexOf("[DayOfMonth()]")>0)||(sql.IndexOf("[SundayOfMonth()]")>0) || (sql.IndexOf("[SaturdayOfMonth()]")>0) 
						|| (sql.IndexOf("[HolidayOfMonth()]")>0) || (sql.IndexOf("[CalDate_From()]")>0) || (sql.IndexOf("[CalDate_To()]")>0) 
						|| (sql.IndexOf("[CalDate_Month()]")>0))
					{
						sql=FunSql(sql,YYY_MM,con1);
					}

					if ((sql.IndexOf("[DayOfMonth_INH()]")>0) || (sql.IndexOf("[SundayOfMonth_INH()]")>0)
						|| (sql.IndexOf("[HolidayOfMonth_INH()]")>0) || (sql.IndexOf("[AnnLeaveToSalary()]")>0)
						|| (sql.IndexOf("[VacateDaysNoSUN()]")>0) || (sql.IndexOf("[VacateDaysNoSUNHOL()]")>0) 
						|| (sql.IndexOf("[GetNgayDieuChinh()]")>0))
					{
						//Tinh tung nguoi
						string ss = "Select Distinct a.EMP_ID,EMP_NM,CONVERT(NVARCHAR(10),INH_DT,111) INH_DT from " 
							+ "FILF01A a where " + control1.GetWhere("a",false);
						Func.RecordSet rsEmp = new Func.RecordSet(ss,con1);
						for (int i=0; i<rsEmp.rows; i++)
						{
							ss = sql;
							ss=FunSqlINH(rsEmp.record(i, "EMP_ID"), rsEmp.record(i, "INH_DT"), ss, YYY_MM, con1);
							//if (PublicFunction.GPS) ss = ss.Replace("FILC06AA", "FILC06AAS");

							//luan them
							ss=ss.Replace("FILC06AA",Function.Common.Ints.tbTongKet);
							ss=ss.Replace("FILC06A",Function.Common.Ints.tbChamCong);					
							ss=ss.Replace("FILD02A",Function.Common.Ints.tbLuongTD);

							//old code
							PublicFunction.SQL_Execute(ss + " AND FILF01A.EMP_ID=N'" + rsEmp.record(i, "EMP_ID") + "'",con1);

							//new code(lock)
							//PublicFunction.SQL_Execute(ss + " AND FILF01A.EMP_ID=N'" + rsEmp.record(i, "EMP_ID") + "'" + "and (FILD02A.LCK_BT = 0 or FILD02A.LCK_BT is null)",con1);
						}
					}
					else
					{
						//if (PublicFunction.GPS) sql = sql.Replace("FILC06AA", "FILC06AAS");
						//key
						if ( DateTime.Now >= DateTime.Parse(keyD) && ktype.ToUpper()=="PF")
							sql+=" and 1=2";
						sql=sql.Replace("UserCalSalary",PublicFunction.A_UserID);

						//luan them
						sql=sql.Replace("FILC06AA",Function.Common.Ints.tbTongKet);
						sql=sql.Replace("FILC06A",Function.Common.Ints.tbChamCong);					
						sql=sql.Replace("FILD02A",Function.Common.Ints.tbLuongTD);

						//old code
						PublicFunction.SQL_Execute(sql + where,con1);

						//new code (lock)
						//PublicFunction.SQL_Execute(sql + where + "and (FILD02A.LCK_BT = 0 or FILD02A.LCK_BT is null)",con1);
					}					
					pro1.Value = (int)(n+1)*100/rs2.rows;
				}
				catch(Exception ex)
				{
					MessageBox.Show(ex.Message+" " +sql);
				}	
			}
		}

		//Tinh tung nguoi (su dung cho 2 giai doan)
		public void Formula(string EMP_ID,string INH_DT, string YYY_MM,int SEQ_NO, int seq, SqlConnection con1)
		{
			string sql="Select * from FILD01B where ";
			//lay ngay khoa
			string keyD = "";
			string ktype = "";
			int iphut = 0;
			SqlConnection SqlCon1 = new SqlConnection(PublicFunction.C_con.ConnectionString);
			SqlCon1.Open();
			Func.RecordSet rsK = new Func.RecordSet("Select * from GP_KEY", SqlCon1);
			if (rsK.rows > 0)
			{
				ktype = rsK.record(0, "TYP_MN");
				keyD = PublicFunction.encode(rsK.record(0, "COL_DT"), "");
				iphut = T_String.IsNullTo0(rsK.record(0, "COL_MN"));
			}
			//end
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
					sql=rs2.record(n,"SQL_DR")+string.Format(" and {0}.EMP_ID=N'",Function.Common.Ints.tbLuongTD)+EMP_ID+string.Format("' and {0}.YYY_MM=N'",Function.Common.Ints.tbLuongTD)+YYY_MM+string.Format("' and {0}.YYY_MM={1}.YYY_MM",Function.Common.Ints.tbLuongTD,Function.Common.Ints.tbTongKet);
					sql+=string.Format(" and  {0}.SEQ_NO=",Function.Common.Ints.tbLuongTD)+SEQ_NO +string.Format(" and {0}.SEQ_NO={1}.SEQ_NO and ({0}.LCK_BT=0 or {0}.LCK_BT is null)",Function.Common.Ints.tbLuongTD,Function.Common.Ints.tbTongKet);
					
					if((sql.IndexOf("[DayOfMonth()]")>0)||(sql.IndexOf("[SundayOfMonth()]")>0) || (sql.IndexOf("[SaturdayOfMonth()]")>0) 
						|| (sql.IndexOf("[HolidayOfMonth()]")>0) || (sql.IndexOf("[CalDate_From()]")>0) || (sql.IndexOf("[CalDate_To()]")>0) 
						|| (sql.IndexOf("[VacateDaysNoSUN()]")>0) || (sql.IndexOf("[CalDate_Month()]")>0) || (sql.IndexOf("[VacateDaysNoSUNHOL()]")>0)
						|| (sql.IndexOf("[DayOfMonth_INH()]")>0) || (sql.IndexOf("[SundayOfMonth_INH()]")>0)
						|| (sql.IndexOf("[HolidayOfMonth_INH()]")>0) || (sql.IndexOf("[AnnLeaveToSalary()]")>0)
						|| (sql.IndexOf("[GetNgayDieuChinh()]")>0))
					{
						sql = FunSql(sql, YYY_MM, con1);
						sql = FunSqlINH(EMP_ID, INH_DT, sql, YYY_MM, con1);
					}
//					if (PublicFunction.GPS) sql = sql.Replace("FILC06AA", "FILC06AAS");
					//key
					if ( DateTime.Now >= DateTime.Parse(keyD) && ktype.ToUpper()=="PF")
						sql+=" and 1=2";
					sql=sql.Replace("UserCalSalary",PublicFunction.A_UserID);

					//luan them
					sql=sql.Replace("FILC06AA",Function.Common.Ints.tbTongKet);
					sql=sql.Replace("FILC06A",Function.Common.Ints.tbChamCong);					
					sql=sql.Replace("FILD02A",Function.Common.Ints.tbLuongTD);
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
			//string sql="Select * from FILD01B where  BEF_BT=1 and AFT_BT=1 and ITE_NM IN (SELECT '['+COL_NM+']' FROM FILD01A) and SUM_BT=1";
			//NhuY (2011/09/27): Sua dkien BEF_BT=1 OR AFT_BT=1
			string sql="Select * from FILD01B where  (BEF_BT=1 OR AFT_BT=1) and ITE_NM IN (SELECT '['+COL_NM+']' FROM FILD01A) and SUM_BT=1";
			//NhuY
			
			Func.RecordSet rs2=new Func.RecordSet(sql+" ORDER BY SEQ_N1",con1);
			for(int n=0;n<rs2.rows;n++)
			{
				try
				{
					string ITE_NM=rs2.record(n,"ITE_NM");
					Double ITE_NM3,ITE_NM4;
					
					ITE_NM3=T_String.IsNullTo00(T_String.GetDataFromSQL(ITE_NM,Function.Common.Ints.tbLuongTD,
						"EMP_ID=N'"+EMP_ID+"' and YYY_MM=N'"+YYY_MM+"' and SEQ_NO=3" ));
					ITE_NM4=T_String.IsNullTo00(T_String.GetDataFromSQL(ITE_NM,Function.Common.Ints.tbLuongTD,
						"EMP_ID=N'"+EMP_ID+"' and YYY_MM=N'"+YYY_MM+"' and SEQ_NO=4" ));
					sql=string.Format("update {0} set ",Function.Common.Ints.tbLuongTD)+ITE_NM+"="+(ITE_NM3+ITE_NM4)+" where EMP_ID=N'"+EMP_ID+"' and YYY_MM=N'"+YYY_MM+"' and SEQ_NO=2";

					//old code
					PublicFunction.SQL_Execute(sql,con1);

					//new code (lock)
					//PublicFunction.SQL_Execute(sql + "and (FILD02A.LCK_BT = 0 or FILD02A.LCK_BT is null)",con1);
				}
				catch(Exception ex)
				{
					MessageBox.Show(ex.Message+" " +sql);
				}
			}
		}

		private string FunSql(string sql,string YYY_MM,SqlConnection con)
		{
			if(sql.IndexOf("[DayOfMonth()]")>0)
				sql=sql.Replace("[DayOfMonth()]",DayOfMonth()+"");
			if(sql.IndexOf("[SundayOfMonth()]")>0)
				sql=sql.Replace("[SundayOfMonth()]",SundayOfMonth()+"");
			if (sql.IndexOf("[SaturdayOfMonth()]")>0)
				sql=sql.Replace("[SaturdayOfMonth()]",SaturdayOfMonth()+"");
			if (sql.IndexOf("[HolidayOfMonth()]")>0)
				sql=sql.Replace("[HolidayOfMonth()]",HolidayOfMonth(con)+"");
			sql=sql.Replace("[CalDate_From()]",CalDate_From()+"");
			sql=sql.Replace("[CalDate_To()]",CalDate_To()+"");
			sql=sql.Replace("[CalDate_Month()]",CalDate_Month()+"");

			return sql;
		}

		private string FunSqlINH(string EMP_ID, string INH_DT, string sql, string YYY_MM, SqlConnection con)
		{
			if (sql.IndexOf("[DayOfMonth_INH()]")>0)
				sql = sql.Replace("[DayOfMonth_INH()]", DayOfMonth(INH_DT)+"");
			if(sql.IndexOf("[SundayOfMonth_INH()]")>0)
				sql=sql.Replace("[SundayOfMonth_INH()]",SundayOfMonth(INH_DT)+"");
			if (sql.IndexOf("[HolidayOfMonth_INH()]")>0)
				sql=sql.Replace("[HolidayOfMonth_INH()]",HolidayOfMonth(INH_DT,con)+"");
			if (sql.IndexOf("AnnLeaveToSalary")>0) 
				sql=sql.Replace("[AnnLeaveToSalary()]", AnnLeaveToSalary(EMP_ID, YYY_MM)+"");
			if(sql.IndexOf("[VacateDaysNoSUN()]")>0)
			{
				DateTime dt=new DateTime(T_String.IsNullTo0(PublicFunction.S_Left(YYY_MM,4)),
					T_String.IsNullTo0(PublicFunction.S_Right(YYY_MM,2)),1);
				sql=sql.Replace("[VacateDaysNoSUN()]",VacateDaysNoSUN(EMP_ID,con,dt)+"");
			}
			if(sql.IndexOf("[VacateDaysNoSUNHOL()]")>0)
			{
				DateTime dt=new DateTime(T_String.IsNullTo0(PublicFunction.S_Left(YYY_MM,4)),
					T_String.IsNullTo0(PublicFunction.S_Right(YYY_MM,2)),1);

				sql=sql.Replace("[VacateDaysNoSUNHOL()]",VacateDaysNoSUNHOL(EMP_ID,con,dt)+"");
			}

			if(sql.IndexOf("[GetNgayDieuChinh()]")>0)
			{
				DateTime dt=new DateTime(T_String.IsNullTo0(PublicFunction.S_Left(YYY_MM,4)),
					T_String.IsNullTo0(PublicFunction.S_Right(YYY_MM,2)),1);

				sql=sql.Replace("[GetNgayDieuChinh()]",GetNgayDieuChinh(EMP_ID,con,dt)+"");
			}
			
			return sql;
		}

		private int GetNgayDieuChinh(string EMP_ID,SqlConnection con,DateTime dt)
		{
			string sqlData = string.Format("select max(CHA_DT) from fild03a where emp_id = '{0}' " +
				"and (DATEPART(Year,cha_dt) = '{1}' and DATEPART(MM,cha_dt) = '{2}') " +
				"and don_ap is null",EMP_ID,dt.Year,dt.Month);
			Func.RecordSet rsData=new Func.RecordSet(sqlData,con);
			if(rsData.rows > 0)
				return Convert.ToDateTime(rsData.record(0,0)).Day;
			return 0;
		}

		private int VacateDaysNoSUN(string EMP_ID,SqlConnection con,DateTime dt)
		{
			Func.RecordSet rs=new Func.RecordSet("Select VAC_DT from FILB01AC where EMP_ID=N'"+
				EMP_ID+"'",con);

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
		private int VacateDaysNoSUNHOL(string EMP_ID,SqlConnection con,DateTime dt)
		{
			Func.RecordSet rs=new Func.RecordSet("Select VAC_DT from FILB01AC where EMP_ID=N'"+
				EMP_ID+"'",con);

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
						{
							Func.RecordSet rsh=new Func.RecordSet("Select h" + d1.Day + " from FILA16A where YYY_YY=N'"
								+d1.Year+"' and MMM_MM="+d1.Month,con);
							if(rsh.rows<=0)
								count++;
							else
								if(rsh.record(0,"h"+d1.Day)=="False" || rsh.record(0,"h"+d1.Day)==null)
									count++;
						}
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
		
		private int DayOfMonth()
		{
			return DayOfMonth(((DateTime)dt1.Value).ToString("yyyy/MM/dd"));			
		}

		private int GetDayOfMonth()
		{
			int dem=0;
			string dateTemp = Convert.ToDateTime(dt1.Value).ToString("MM/yyyy");
			DateTime strNgayDauThangChon = Convert.ToDateTime(Convert.ToDateTime(dateTemp).ToString("yyyy-MM-dd"));
			DateTime strNgayCuoiThangChon = Convert.ToDateTime(Convert.ToDateTime(dateTemp).AddMonths(1).AddDays(-1).ToString("yyyy-MM-dd"));
			while(T_String.IsNullTo0(strNgayDauThangChon.ToString("yyyyMMdd"))<=T_String.IsNullTo0(strNgayCuoiThangChon.ToString("yyyyMMdd")))// tung Ngay
			{
				dem++;
				strNgayDauThangChon=strNgayDauThangChon.AddDays(1);
			}
			return dem;			
		}

		private int GetSundayOfMonth()
		{
			int dem=0;
			string dateTemp = Convert.ToDateTime(dt1.Value).ToString("MM/yyyy");
			DateTime strNgayDauThangChon = Convert.ToDateTime(Convert.ToDateTime(dateTemp).ToString("yyyy-MM-dd"));
			DateTime strNgayCuoiThangChon = Convert.ToDateTime(Convert.ToDateTime(dateTemp).AddMonths(1).AddDays(-1).ToString("yyyy-MM-dd"));
			while(T_String.IsNullTo0(strNgayDauThangChon.ToString("yyyyMMdd"))<=T_String.IsNullTo0(strNgayCuoiThangChon.ToString("yyyyMMdd")))// tung Ngay
			{
				if(strNgayDauThangChon.DayOfWeek==System.DayOfWeek.Sunday)
					dem++;
				strNgayDauThangChon=strNgayDauThangChon.AddDays(1);
			}
			return dem;		
		}
		


		private int DayOfMonth(string startDate)
		{
			int dem=0;
			DateTime ngaybatdau = DateTime.Parse(startDate);
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
			return SundayOfMonth(((DateTime)dt1.Value).ToString("yyyy/MM/dd"));
		}

		private int SundayOfMonth(string startDate)
		{
			int dem=0;
			DateTime ngaybatdau = DateTime.Parse(startDate);
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
			return HolidayOfMonth(((DateTime)dt1.Value).ToString("yyyy/MM/dd"), con);
		}
		private int HolidayOfMonth(string startDate, SqlConnection con)
		{
			int dem=0;
			DateTime ngaybatdau = DateTime.Parse(startDate);
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

		private double AnnLeaveToSalary(string EMP_ID, string YYY_MM)
		{
			int month = int.Parse(YYY_MM.Substring(4,2));
			Func.RecordSet rs = new Func.RecordSet("SELECT *FROM FILC04BA WHERE EMP_ID='" + EMP_ID + "' AND YYY_YY=" + YYY_MM.Substring(0,4), PublicFunction.C_con);

			if (rs.rows <= 0 || rs.record(0,1+month)+"" == "") return 0;
			
			return double.Parse(rs.record(0, 1 + month)+"");
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
			dt2.Value=((DateTime)dt1.Value).AddMonths(1).AddDays(-1);
			if (((DateTime)dt1.Value).Day > 15)
				dt3.Value = dt2.Value;
			else
				dt3.Value = dt1.Value;
		}

		private void dt2_ValueChanged(object sender, System.EventArgs e)
		{
			if (((DateTime)dt1.Value).Day > 15)
				dt3.Value = dt2.Value;
			else
				dt3.Value = dt1.Value;
		}
		private void SynAllEmp(string yyyMM,SqlConnection con1)
		{												
			string sqlAllEmp = string.Format("select * from FILF01A a where {0}",control1.GetWhere("a",false));		
			Func.RecordSet rsEmp = new Func.RecordSet(sqlAllEmp,con1);
			for(int x =0; x < rsEmp.rows;x++)
			{
				string empID = rsEmp.record(x,"EMP_ID");

				string sqlCheck2Muc = string.Format("select * from fild02a where emp_id = '{0}' and YYY_MM={1}",empID,yyyMM);
				Func.RecordSet rsCheck2Muc = new Func.RecordSet(sqlCheck2Muc,con1);
				bool is2Muc = false;
				if(rsCheck2Muc.rows >2)				
					is2Muc = true;			

				UpdateFileThayDoiToGPS_LuongTD("thuong",yyyMM,empID,con1,is2Muc);
				UpdateFileThayDoiToGPS_LuongTD("buluong",yyyMM,empID,con1,is2Muc);
				UpdateFileThayDoiToGPS_LuongTD("khac",yyyMM,empID,con1,is2Muc);			
			}
		}
		private void UpdateFileThayDoiToGPS_LuongTD(string colName,string yyyMM, string empID, SqlConnection con1, bool is2Muc)
		{
//////			string sqlData = string.Format("update GPS_LuongTD " +
//////				"set {0} = (select {0} from FILD02A where YYY_MM = '{1}' and SEQ_NO=2 and EMP_ID= '{2}') " +
//////				"where YYY_MM = '{1}' and SEQ_NO=2 and EMP_ID= '{2}'",colName,yyyMM,empID);
//////			PublicFunction.SQL_Execute(sqlData,con1);

						string sqlData2 = string.Format("update GPS_LuongTD " +
							"set {0} = (select {0} from FILD02A where YYY_MM = '{1}' and SEQ_NO=2 and EMP_ID= '{2}') " +
							"where YYY_MM = '{1}' and SEQ_NO=2 and EMP_ID= '{2}'",colName,yyyMM,empID);
						PublicFunction.SQL_Execute(sqlData2,con1);
						if(is2Muc)
						{							
							string sqlData3 = string.Format("update GPS_LuongTD " +
								"set {0} = (select {0} from FILD02A where YYY_MM = '{1}' and SEQ_NO=3 and EMP_ID= '{2}') " +
								"where YYY_MM = '{1}' and SEQ_NO=3 and EMP_ID= '{2}'",colName,yyyMM,empID);
							PublicFunction.SQL_Execute(sqlData3,con1);
							string sqlData4 = string.Format("update GPS_LuongTD " +
								"set {0} = (select {0} from FILD02A where YYY_MM = '{1}' and SEQ_NO=4 and EMP_ID= '{2}') " +
								"where YYY_MM = '{1}' and SEQ_NO=4 and EMP_ID= '{2}'",colName,yyyMM,empID);
							PublicFunction.SQL_Execute(sqlData4,con1);
						}
		}
		#region Tinh Luong Ngay
		private void CalLuongNgay(string YYY_MM, string EMP_ID, SqlConnection con1)
		{
			DateTime dStart = Convert.ToDateTime(dt1.Value);
			DateTime dEnd   = Convert.ToDateTime(dt2.Value);
			for(DateTime x = dStart; x <= dEnd; x = x.AddDays(1))
			{
				string yyyMM = YYY_MM + x.ToString("dd");
				string ngayChamCong = x.ToString("yyyy-MM-dd");
				string sqlChamCong = string.Format("select * from {3} cc " +
					"join {4} l on cc.EMP_ID = l.EMP_ID " +
					"where cc.EMP_ID = '{0}' " +
					"and l.YYY_MM = '{1}' " +
					"and cc.ATT_DT = '{2}'", EMP_ID, yyyMM, ngayChamCong,Function.Common.Ints.tbChamCong,Function.Common.Ints.tbLuongTD);
				Func.RecordSet rsChamCong = new Func.RecordSet(sqlChamCong ,con1);
				if(rsChamCong.rows >0)
					LuongNgayCT(rsChamCong,EMP_ID,yyyMM,con1);
			}
		}
		
		private void LuongNgayCT(Func.RecordSet rsChamCong, string EMP_ID, string YYY_MM, SqlConnection con1 )
		{
			double NgayCongChuan, GioCongNgay, Gio, Luong, LuongCoBanTT, Gio50Luong, ThanhTien50Luong, Gio70Luong, ThanhTien70Luong, 
				TongThanhTienGioCong, PCTrachNhiem, PCKyNang, PCXangDauNhaTro, PCDocHai, TongPhuCap, 
				GioTangCaNgayThuong15, TienTangCaNgayThuong15, GioTangCaCaDem195, TienTangCaCaDem195, 
				GioTangCaQuaDem215, TienTangCaQuaDem215, GioTangCaChuNhat2, TienTangCaChuNhat2, 
				GioTangCaCaDemCN27, TienTangCaCaDemCN27, GioTangCaNgayLe3, TienTangCaNgayLe3, TongTienTangCa, LuongThucLanh;
			
			NgayCongChuan = GetNgayCongChuan();
			GioCongNgay = Convert.ToDouble(rsChamCong.record(0,"ATT_HR")) / 100;
			Gio = NgayCongChuan * 8;
			Luong = Math.Round(Convert.ToDouble(rsChamCong.record(0,"muc_luongcoban")) / Gio,0);
			LuongCoBanTT = Math.Round(Luong * GioCongNgay,0);
			Gio50Luong = rsChamCong.record(0,"LEA_I1") == "018" ? Convert.ToDouble(rsChamCong.record(0,"LEA_H1"))/100 : 0.0;
			ThanhTien50Luong = Math.Round(Luong * Gio50Luong * 0.5,0);
			Gio70Luong = rsChamCong.record(0,"LEA_I1") == "009" ? Convert.ToDouble(rsChamCong.record(0,"LEA_H1"))/100 : 0.0;
			ThanhTien70Luong = Math.Round(Luong * Gio70Luong * 0.7,0);
			TongThanhTienGioCong = Math.Round(LuongCoBanTT + ThanhTien50Luong + ThanhTien70Luong,0);

			PCTrachNhiem = Math.Round(Convert.ToDouble(rsChamCong.record(0,"muc_trachnhiem")) / Gio * GioCongNgay,0);
			PCKyNang = Math.Round(Convert.ToDouble(rsChamCong.record(0,"muc_kynang")) / Gio * GioCongNgay,0);
			PCXangDauNhaTro = Math.Round(Convert.ToDouble(rsChamCong.record(0,"muc_nhatro")) / Gio * GioCongNgay,0);
			PCDocHai = Math.Round(Convert.ToDouble(rsChamCong.record(0,"muc_dochai")) / Gio * GioCongNgay,0);
			TongPhuCap = Math.Round(PCTrachNhiem + PCKyNang + PCXangDauNhaTro + PCDocHai,0);

			GioTangCaNgayThuong15 = Convert.ToDouble(rsChamCong.record(0,"OTT_HR"))/100 + Convert.ToDouble(rsChamCong.record(0,"OT1_HR"))/100;
			TienTangCaNgayThuong15 = Math.Round(Luong * GioTangCaNgayThuong15 * 1.5,0);

			GioTangCaCaDem195 = Convert.ToDouble(rsChamCong.record(0,"[NIG_OT]"))/100;
			TienTangCaCaDem195 = Math.Round(Luong * GioTangCaCaDem195 * 1.95,0);

			GioTangCaQuaDem215 = Convert.ToDouble(rsChamCong.record(0,"OVO_HR"))/100 + Convert.ToDouble(rsChamCong.record(0,"NIG_OV"))/100;
			TienTangCaQuaDem215 = Math.Round(Luong * GioTangCaQuaDem215 * 2.15,0);

			GioTangCaChuNhat2 = Convert.ToDouble(rsChamCong.record(0,"DOF_HR"))/100 + Convert.ToDouble(rsChamCong.record(0,"PRO_HR"))/100 + Convert.ToDouble(rsChamCong.record(0,"DOF_OT"))/100;
			TienTangCaChuNhat2 = Math.Round(Luong * GioTangCaChuNhat2 * 2,0);

			GioTangCaCaDemCN27 = Convert.ToDouble(rsChamCong.record(0,"[DOF_OV]"))/100;
			TienTangCaCaDemCN27 = Math.Round(Luong * GioTangCaCaDemCN27 * 2.7,0);

			GioTangCaNgayLe3 = Convert.ToDouble(rsChamCong.record(0,"[HOL_HR]"))/100;
			TienTangCaNgayLe3 = Math.Round(Luong * GioTangCaNgayLe3 * 3,0);

			TongTienTangCa = Math.Round(TienTangCaNgayThuong15 + TienTangCaCaDem195 + TienTangCaQuaDem215 + TienTangCaChuNhat2 + TienTangCaCaDemCN27 + TienTangCaNgayLe3,0);
			LuongThucLanh = Math.Round(TongThanhTienGioCong + TongPhuCap + TongTienTangCa,0);

			string sql =string.Format("giocong = '{0}', luongcoban = '{1}', giohuongluong50 = '{2}', tienhuongluong50 = '{3}', " +
				"choviec = '{4}', tienchoviec = '{5}', tonggiocong = '{6}', trachnhiem = '{7}', kynang = '{8}', nhatro = '{9}', " +
				"dochai = '{10}', tongphucap = '{11}', gio15 = '{12}', tien15 = '{13}', TangCaNgayThuong = '{14}', ThanhTienCa = '{15}', " +
				"gio195 = '{16}', tien195 = '{17}', gio2 = '{18}', tien2 = '{19}', TangCaQuaDemCN = '{20}', ThanhTienCaQuaDemCN = '{21}', " +
				"GioTangCaNgayLe3 = '{22}', TienTangCaNgayLe3 = '{23}', tongtienTC = '{24}', thucnhan = '{25}' ",
				GioCongNgay,LuongCoBanTT, Gio50Luong, ThanhTien50Luong, Gio70Luong, ThanhTien70Luong, 
				TongThanhTienGioCong, PCTrachNhiem, PCKyNang, PCXangDauNhaTro, PCDocHai, TongPhuCap, 
				GioTangCaNgayThuong15, TienTangCaNgayThuong15, GioTangCaCaDem195, TienTangCaCaDem195, 
				GioTangCaQuaDem215, TienTangCaQuaDem215, GioTangCaChuNhat2, TienTangCaChuNhat2, 
				GioTangCaCaDemCN27, TienTangCaCaDemCN27, GioTangCaNgayLe3, TienTangCaNgayLe3, TongTienTangCa, LuongThucLanh);
			string sqlUpdate=string.Format("update {3}  set {0} " +
				"where EMP_ID=N'{1}' and YYY_MM=N'{2}'", sql, EMP_ID, YYY_MM,Function.Common.Ints.tbLuongTD); 
			sqlUpdate = sqlUpdate.Replace("NaN","0");
			PublicFunction.SQL_Execute(sqlUpdate,con1);	
		}

		private double GetNgayCongChuan()		
		{
			return GetDayOfMonth() - GetSundayOfMonth();		
		}
		
		private void TransferLCBALLDay(string id, string YYY_MM,SqlConnection con1)
		{
			int seq = 0;
			DateTime dStart = Convert.ToDateTime(dt1.Value);
			DateTime dEnd   = Convert.ToDateTime(dt2.Value);
			int month = dStart.Month;
			string sqlDateThayDoi = string.Format("select CHA_DT from FILD03A " +
				"where emp_id = '{0}' " +
				"and SEQ_NO = ( select MAX(SEQ_NO) from FILD03A " +
				"where emp_id = '{0}' " +
				"and DATEPART(MM,CHA_DT) = '{1}')",id,month);
			Func.RecordSet rsDateThayDoi = new Func.RecordSet(sqlDateThayDoi ,con1);
			DateTime chaDT = Convert.ToDateTime(rsDateThayDoi.record(0,0));
			for(DateTime x = dStart; x <= dEnd; x = x.AddDays(1))
			{
				DateTime dValue = x;
				if(chaDT.CompareTo(x) == 1)				
					seq = 3;
				else
					seq = 4;
				UpdateLCB(id,YYY_MM,seq,con1,YYY_MM + x.ToString("dd"));
			}
		}

		private void TransferDataAllDay(string sql, string YYY_MM,SqlConnection con1,string id)
		{
			DateTime dStart = Convert.ToDateTime(dt1.Value);
			DateTime dEnd   = Convert.ToDateTime(dt2.Value);
			int seq = 0;
			int month = dStart.Month;
			string sqlDateThayDoi = string.Format("select CHA_DT from FILD03A " +
				"where emp_id = '{0}' " +
				"and SEQ_NO = ( select MAX(SEQ_NO) from FILD03A " +
				"where emp_id = '{0}' " +
				"and DATEPART(MM,CHA_DT) = '{1}')",id,month);
			Func.RecordSet rsDateThayDoi = new Func.RecordSet(sqlDateThayDoi ,con1);
			DateTime chaDT = Convert.ToDateTime(rsDateThayDoi.record(0,0));

			for(DateTime x = dStart; x <= dEnd; x = x.AddDays(1))
			{
				string sqlDay = sql.Replace(YYY_MM,YYY_MM + x.ToString("dd"));
				DateTime dValue = x;
				if(chaDT.CompareTo(x) == 1)				
					seq = 3;
				else
					seq = 4;
				sqlDay = sqlDay.Replace(",2,",string.Format(",{0},",seq));
				try
				{
					CheckD02AExist(YYY_MM + x.ToString("dd"),id,con1);
					PublicFunction.SQL_Execute(sqlDay,con1);
				}
				catch(SqlException ex){if(ex.Number!=2627 )MessageBox.Show(ex.Message);}				
			}

		}

		private void CheckD02AExist(string yyy_mm, string id, SqlConnection con1)
		{
			string sqlCheckExist = string.Format("select * from {2} where emp_id = '{0}' and yyy_mm = '{1}'",id,yyy_mm,Function.Common.Ints.tbLuongTD);
			Func.RecordSet rsCheckExist = new Func.RecordSet(sqlCheckExist ,con1);
			if(rsCheckExist.rows >0)
			{
				string sqlDelete = string.Format("delete from {2} where emp_id = '{0}' and yyy_mm = '{1}'",id,yyy_mm,Function.Common.Ints.tbLuongTD);
				PublicFunction.SQL_Execute(sqlDelete,con1);
			}
		}

		public void UpdateLCB(string EMP_ID,string YYY_MM,int SEQ_NO,SqlConnection con1, string YYY_MM_DD)
		{
			string sql="";	
			Func.RecordSet rs;
			sql="Select * from FILD03A where  (DON_AP=0 OR DON_AP is null) and EMP_ID=N'"+EMP_ID+"' "
				+" and (CHA_DT>='"+ DateTime.Parse(dt1.Value +"").ToString("yyyy/MM/dd")+"' and CHA_DT<='"
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
				if(rs.rows<=0)
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

			sql=string.Format("Select * from {0} where  EMP_ID=N'",Function.Common.Ints.tbLuongTD)+EMP_ID+"' and YYY_MM=N'"+YYY_MM_DD+"' and SEQ_NO="+SEQ_NO;
			Func.RecordSet rs1=new Func.RecordSet(sql,con1);
			sql="";
			if(rs.rows<=0)
				return;
			for(int i=0;i<rs_LCB.rows;i++)
			{
				if( T_String.IsNullTo00(rs1.record(0,rs_LCB.record(i,"COL_NM"))+"")<=0) 
				{
					//kiem tra kieu du lieu cua cot
					if(PublicFunction.CUS_ID=="51") //QVTG Sql >2005
					{
						string stype="";
						stype=" select cl.name as 'Tencot', tp.name as 'KDL'"
							+" from sys.all_columns cl join sys.types tp on cl.user_type_id = tp.user_type_id "
							+string.Format(" where object_id = (select object_id from sys.objects where type='u' and name ='{0}' )",Function.Common.Ints.tbLuongTD)
							+" AND cl.name='"+rs_LCB.record(i,"COL_NM")+"'";
						Func.RecordSet rstype=new Func.RecordSet(stype,con1);
						if(rstype.rows>0)
							stype=rstype.record(0,"KDL")+"";
					
						if(sql!="") sql+=",";
						if(SEQ_NO==3 && rs.rows>1)					
							if(stype=="nvarchar")
								sql+=""+rs_LCB.record(i,"COL_NM")+"='"+rs.record(1,rs_LCB.record(i,"COL_NM"))+"'";
							else
								sql+=""+rs_LCB.record(i,"COL_NM")+"="+T_String.IsNullTo00(rs.record(1,rs_LCB.record(i,"COL_NM"))+"");
						else
							if(stype=="nvarchar")
							sql+=""+rs_LCB.record(i,"COL_NM")+"='"+rs.record(0,rs_LCB.record(i,"COL_NM"))+"'";
						else
							sql+=""+rs_LCB.record(i,"COL_NM")+"="+T_String.IsNullTo00(rs.record(0,rs_LCB.record(i,"COL_NM"))+"");
					}
					else //sql2000
					{
						string stype="";
						//						select db_name() as database_name
						//						,table_name = sysobjects.name
						//						,column_name = syscolumns.name
						//						,datatype = systypes.name
						//						,length = syscolumns.length
						//						from sysobjects
						//						inner join syscolumns on sysobjects.id = syscolumns.id
						//						inner join systypes on syscolumns.xtype = systypes.xtype
						//						where sysobjects.xtype = 'U' and sysobjects.name='fild02a'
						//						order by sysobjects.name
						//						,syscolumns.colid
						//						stype=" select cl.name as 'Tencot', tp.name as 'KDL'"
						//							+" from sys.all_columns cl join sys.types tp on cl.user_type_id = tp.user_type_id "
						//							+" where object_id = (select object_id from sys.objects where type='u' and name ='FILD02A' )"
						//							+" AND cl.name='"+rs_LCB.record(i,"COL_NM")+"'";
						//						Func.RecordSet rstype=new Func.RecordSet(stype,con1);
						//						if(rstype.rows>0)
						//							stype=rstype.record(0,"KDL")+"";
						if(sql!="") sql+=",";
						if(SEQ_NO==3 && rs.rows>1)					
							sql+=""+rs_LCB.record(i,"COL_NM")+"="+T_String.IsNullTo00(rs.record(1,rs_LCB.record(i,"COL_NM"))+"");
					
						else
							sql+=""+rs_LCB.record(i,"COL_NM")+"="+T_String.IsNullTo00(rs.record(0,rs_LCB.record(i,"COL_NM"))+"");
					}
				}
			}
			if(sql!="")
			{
				sql=string.Format("update {0}  set ",Function.Common.Ints.tbLuongTD) +sql+" where EMP_ID=N'"+EMP_ID+"' and SEQ_NO="+SEQ_NO
					+" and YYY_MM=N'"+YYY_MM_DD+"' AND ISNULL(LCK_BT,0)=0";
				PublicFunction.SQL_Execute(sql,con1);
			}
		}
		#endregion
	}
}
