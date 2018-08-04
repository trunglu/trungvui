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
	/// Summary description for frmTaTransferStaff.
	/// </summary>
	public class frmTaTransferStaff : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.RadioButton r1;
		private System.Windows.Forms.RadioButton r2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.RadioButton r4;
		private System.Windows.Forms.RadioButton r3;
		private System.Windows.Forms.RadioButton r6;
		private System.Windows.Forms.RadioButton r5;
		private System.Windows.Forms.Button cmd_ok;
		private System.Windows.Forms.Button cmd_can;
		private System.Windows.Forms.DateTimePicker dt;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.GroupBox groupBox6;
		private System.Windows.Forms.RadioButton r8;
		private System.Windows.Forms.RadioButton r7;
		private System.Windows.Forms.RadioButton r10;
		private System.Windows.Forms.RadioButton r9;
		public C1.Win.C1Input.C1DateEdit dt2;
		public C1.Win.C1Input.C1DateEdit dt1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmTaTransferStaff()
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
			this.cmd_can = new System.Windows.Forms.Button();
			this.cmd_ok = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.dt = new System.Windows.Forms.DateTimePicker();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.r2 = new System.Windows.Forms.RadioButton();
			this.r1 = new System.Windows.Forms.RadioButton();
			this.label3 = new System.Windows.Forms.Label();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.r4 = new System.Windows.Forms.RadioButton();
			this.r3 = new System.Windows.Forms.RadioButton();
			this.label4 = new System.Windows.Forms.Label();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.r6 = new System.Windows.Forms.RadioButton();
			this.r5 = new System.Windows.Forms.RadioButton();
			this.label6 = new System.Windows.Forms.Label();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.r8 = new System.Windows.Forms.RadioButton();
			this.r7 = new System.Windows.Forms.RadioButton();
			this.label7 = new System.Windows.Forms.Label();
			this.groupBox6 = new System.Windows.Forms.GroupBox();
			this.r10 = new System.Windows.Forms.RadioButton();
			this.r9 = new System.Windows.Forms.RadioButton();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label5 = new System.Windows.Forms.Label();
			this.dt2 = new C1.Win.C1Input.C1DateEdit();
			this.dt1 = new C1.Win.C1Input.C1DateEdit();
			this.panel1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.groupBox5.SuspendLayout();
			this.groupBox6.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dt2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dt1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.cmd_can);
			this.panel1.Controls.Add(this.cmd_ok);
			this.panel1.Controls.Add(this.groupBox1);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(434, 322);
			this.panel1.TabIndex = 0;
			// 
			// cmd_can
			// 
			this.cmd_can.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_can.Location = new System.Drawing.Point(244, 280);
			this.cmd_can.Name = "cmd_can";
			this.cmd_can.Size = new System.Drawing.Size(92, 32);
			this.cmd_can.TabIndex = 3;
			this.cmd_can.Text = "button2";
			this.cmd_can.Click += new System.EventHandler(this.cmd_can_Click);
			// 
			// cmd_ok
			// 
			this.cmd_ok.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_ok.Location = new System.Drawing.Point(88, 280);
			this.cmd_ok.Name = "cmd_ok";
			this.cmd_ok.Size = new System.Drawing.Size(92, 32);
			this.cmd_ok.TabIndex = 2;
			this.cmd_ok.Text = "button1";
			this.cmd_ok.Click += new System.EventHandler(this.cmd_ok_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.dt2);
			this.groupBox1.Controls.Add(this.dt1);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.dt);
			this.groupBox1.Controls.Add(this.groupBox2);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.groupBox3);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.groupBox4);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.groupBox5);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.groupBox6);
			this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox1.Location = new System.Drawing.Point(8, 40);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(420, 232);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "groupBox1";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(8, 52);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(132, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "label2";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(8, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(132, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "label1";
			// 
			// dt
			// 
			this.dt.CalendarFont = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dt.CustomFormat = "yyyyMM";
			this.dt.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dt.Location = new System.Drawing.Point(140, 20);
			this.dt.Name = "dt";
			this.dt.Size = new System.Drawing.Size(100, 23);
			this.dt.TabIndex = 0;
			this.dt.Value = new System.DateTime(2008, 10, 2, 14, 48, 52, 109);
			this.dt.Visible = false;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.r2);
			this.groupBox2.Controls.Add(this.r1);
			this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox2.Location = new System.Drawing.Point(140, 40);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(272, 40);
			this.groupBox2.TabIndex = 3;
			this.groupBox2.TabStop = false;
			this.groupBox2.Tag = "N";
			// 
			// r2
			// 
			this.r2.Checked = true;
			this.r2.Location = new System.Drawing.Point(140, 12);
			this.r2.Name = "r2";
			this.r2.TabIndex = 1;
			this.r2.TabStop = true;
			this.r2.Text = "radioButton1";
			// 
			// r1
			// 
			this.r1.Location = new System.Drawing.Point(8, 12);
			this.r1.Name = "r1";
			this.r1.TabIndex = 0;
			this.r1.Text = "radioButton1";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(8, 88);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(132, 23);
			this.label3.TabIndex = 4;
			this.label3.Text = "label3";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.r4);
			this.groupBox3.Controls.Add(this.r3);
			this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox3.Location = new System.Drawing.Point(140, 76);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(272, 40);
			this.groupBox3.TabIndex = 5;
			this.groupBox3.TabStop = false;
			this.groupBox3.Tag = "N";
			// 
			// r4
			// 
			this.r4.Checked = true;
			this.r4.Location = new System.Drawing.Point(140, 12);
			this.r4.Name = "r4";
			this.r4.TabIndex = 1;
			this.r4.TabStop = true;
			this.r4.Text = "radioButton1";
			// 
			// r3
			// 
			this.r3.Location = new System.Drawing.Point(8, 12);
			this.r3.Name = "r3";
			this.r3.TabIndex = 0;
			this.r3.Text = "radioButton1";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(8, 124);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(132, 23);
			this.label4.TabIndex = 6;
			this.label4.Text = "label4";
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.r6);
			this.groupBox4.Controls.Add(this.r5);
			this.groupBox4.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox4.Location = new System.Drawing.Point(140, 112);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(272, 40);
			this.groupBox4.TabIndex = 7;
			this.groupBox4.TabStop = false;
			this.groupBox4.Tag = "N";
			// 
			// r6
			// 
			this.r6.Checked = true;
			this.r6.Location = new System.Drawing.Point(140, 12);
			this.r6.Name = "r6";
			this.r6.TabIndex = 1;
			this.r6.TabStop = true;
			this.r6.Text = "radioButton1";
			// 
			// r5
			// 
			this.r5.Location = new System.Drawing.Point(8, 12);
			this.r5.Name = "r5";
			this.r5.TabIndex = 0;
			this.r5.Text = "radioButton1";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(8, 160);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(132, 23);
			this.label6.TabIndex = 8;
			this.label6.Text = "label6";
			// 
			// groupBox5
			// 
			this.groupBox5.Controls.Add(this.r8);
			this.groupBox5.Controls.Add(this.r7);
			this.groupBox5.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox5.Location = new System.Drawing.Point(140, 148);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(272, 40);
			this.groupBox5.TabIndex = 9;
			this.groupBox5.TabStop = false;
			this.groupBox5.Tag = "N";
			// 
			// r8
			// 
			this.r8.Checked = true;
			this.r8.Location = new System.Drawing.Point(140, 12);
			this.r8.Name = "r8";
			this.r8.TabIndex = 1;
			this.r8.TabStop = true;
			this.r8.Text = "radioButton1";
			// 
			// r7
			// 
			this.r7.Location = new System.Drawing.Point(8, 12);
			this.r7.Name = "r7";
			this.r7.TabIndex = 0;
			this.r7.Text = "radioButton1";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(8, 196);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(132, 23);
			this.label7.TabIndex = 10;
			this.label7.Text = "label7";
			// 
			// groupBox6
			// 
			this.groupBox6.Controls.Add(this.r10);
			this.groupBox6.Controls.Add(this.r9);
			this.groupBox6.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox6.Location = new System.Drawing.Point(140, 184);
			this.groupBox6.Name = "groupBox6";
			this.groupBox6.Size = new System.Drawing.Size(272, 40);
			this.groupBox6.TabIndex = 11;
			this.groupBox6.TabStop = false;
			this.groupBox6.Tag = "N";
			// 
			// r10
			// 
			this.r10.Checked = true;
			this.r10.Location = new System.Drawing.Point(140, 12);
			this.r10.Name = "r10";
			this.r10.TabIndex = 1;
			this.r10.TabStop = true;
			this.r10.Text = "radioButton1";
			// 
			// r9
			// 
			this.r9.Location = new System.Drawing.Point(8, 12);
			this.r9.Name = "r9";
			this.r9.TabIndex = 0;
			this.r9.Text = "radioButton1";
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.panel2.Controls.Add(this.label5);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(434, 32);
			this.panel2.TabIndex = 0;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label5.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.label5.Location = new System.Drawing.Point(0, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(434, 32);
			this.label5.TabIndex = 12;
			this.label5.Tag = "";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// dt2
			// 
			this.dt2.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat;
			this.dt2.Location = new System.Drawing.Point(272, 16);
			this.dt2.Name = "dt2";
			this.dt2.Size = new System.Drawing.Size(132, 23);
			this.dt2.TabIndex = 165;
			this.dt2.Tag = null;
			// 
			// dt1
			// 
			this.dt1.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat;
			this.dt1.Location = new System.Drawing.Point(140, 16);
			this.dt1.Name = "dt1";
			this.dt1.Size = new System.Drawing.Size(132, 23);
			this.dt1.TabIndex = 164;
			this.dt1.Tag = null;
			// 
			// frmTaTransferStaff
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
			this.ClientSize = new System.Drawing.Size(434, 322);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmTaTransferStaff";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmTaTransferStaff";
			this.Load += new System.EventHandler(this.frmTaTransferStaff_Load);
			this.panel1.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.groupBox5.ResumeLayout(false);
			this.groupBox6.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dt2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dt1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void frmTaTransferStaff_Load(object sender, System.EventArgs e)
		{
			Basic.Function.PublicFunction.L_Init_Label(this);		
			dt.Value=T_String.GetDate().AddMonths(-1);
			dt1.CustomFormat=dt2.CustomFormat=PublicFunction.GetOption("DATE");	
		}

		private void cmd_ok_Click(object sender, System.EventArgs e)
		{
			Thread th=new Thread(new ThreadStart(Transfer));
			th.Start();
		}

		private void Transfer()
		{
			cmd_ok.Enabled=false;

			SqlConnection con =new SqlConnection(PublicFunction.C_con.ConnectionString);
			con.Open();
			string sql="";
			sql="Delete from FILF01A";
			PublicFunction.SQL_Execute(sql);
			sql="Insert Into FILF01A select a.*,b.VAC_DT from FILB01A a Left JOIN "
				+"FILB01AC b on a.EMP_ID=b.EMP_ID where (isnull(VAC_BT,0)=0 or VAC_DT>='"+
				DateTime.Parse(dt1.Value+"").ToString("yyyy/MM/dd") +"') and INH_DT<='"+ DateTime.Parse(dt2.Value+"").ToString("yyyy/MM/dd") +"'";
			PublicFunction.SQL_Execute(sql);
			
			//Huynh sua lai cu va moi
//			PublicFunction.SQL_Execute("update FILF01A set VAC_BT=0");
			CheckNew_Old(r2.Checked,"FILB03A","DEP_I2","DEP_I1","DEP_ID",con,"" );
			CheckNew_Old(r4.Checked,"FILB02A","POS_I1","POS_ID","POS_ID",con,"" );			
			CheckNew_Old(r6.Checked,"FILB07A","LEV_I1","LEV_ID","LEV_ID",con,"and LEV_BT=1" );
			CheckNew_Old(r8.Checked,"FILB07A","GRP_I1","GRP_ID","GRP_ID",con,"and GRP_BT=1" );
			CheckNew_Old(r10.Checked,"FILB07A","GRT_I1","GRT_ID","GRT_ID",con,"and GRT_BT=1" );

			cmd_ok.Enabled=true;
			MessageBox.Show(PublicFunction.L_Get_Msg("staff",1));
		}

		private void CheckNew_Old(Boolean check,string tb, string fname, string fname1,string fupdate,SqlConnection con ,string and)
		{
//			if(!check)
			
			string sql="";
			string tam="";
			sql="select EMP_ID,"+fname+","+ fname1+" from " +tb+" where SEQ_DT>'"+DateTime.Parse(dt2.Value+"").ToString("yyyy/MM/dd")+"'"+and;
				//DateTime.Parse(dt.Value+"").ToString("yyyy/MM")+"/01 00:00' and SEQ_DT<'"
//				DateTime.Parse(dt.Value+"").ToString("yyyy")+"/"
//				+ (DateTime.Parse(dt.Value+"").AddMonths(1).Month).ToString("00")
//				+"/01 00:00' " +and;
			if(!check)
				sql+=" Order By SEQ_DT desc";
			Func.RecordSet rs=new Func.RecordSet(sql,con);
			for(int i=0;i<rs.rows;i++)
			{
				if (tb=="FILB03A")
				{
					if(check)
						tam=fname;
					else
						tam=fname1;
					sql="Update FILD02A set "+fupdate+"=N'"+rs.record(i,tam)+"' where EMP_ID=N'"
						+rs.record(i,"EMP_ID")+"' and YYY_MM='"+DateTime.Parse(dt.Value+"").ToString("yyyyMM")+"'";
					PublicFunction.SQL_Execute(sql);
				}
				if(check)
					sql="update FILF01A set "+fupdate+"=N'"+rs.record(i,fname)+"' where EMP_ID=N'"
						+rs.record(i,"EMP_ID")+"'";
				else
					sql="update FILF01A set "+fupdate+"=N'"+rs.record(i,fname1)+"' where EMP_ID=N'"
						+rs.record(i,"EMP_ID")+"'";
				PublicFunction.SQL_Execute(sql);
			}
		}

		private void cmd_can_Click(object sender, System.EventArgs e)
		{
			Close();
		}
	}
}
