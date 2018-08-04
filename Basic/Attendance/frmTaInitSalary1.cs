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
	/// Summary description for frmTaInitSalary.
	/// </summary>
	public class frmTaInitSalary : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label c1;
		private System.Windows.Forms.ProgressBar pro2;
		private System.Windows.Forms.ProgressBar pro1;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.CheckBox ck1;
		private C1.Win.C1Input.C1DateEdit dt2;
		private C1.Win.C1Input.C1DateEdit dt1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button cmd_close;
		private System.Windows.Forms.Button cmd_ok;
		private GP8000.UserControl.CrtTaCondition1 control1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmTaInitSalary()
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
			this.c1 = new System.Windows.Forms.Label();
			this.pro2 = new System.Windows.Forms.ProgressBar();
			this.pro1 = new System.Windows.Forms.ProgressBar();
			this.panel5 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.ck1 = new System.Windows.Forms.CheckBox();
			this.dt2 = new C1.Win.C1Input.C1DateEdit();
			this.dt1 = new C1.Win.C1Input.C1DateEdit();
			this.label1 = new System.Windows.Forms.Label();
			this.cmd_close = new System.Windows.Forms.Button();
			this.cmd_ok = new System.Windows.Forms.Button();
			this.control1 = new GP8000.UserControl.CrtTaCondition1();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.panel3.SuspendLayout();
			this.panel1.SuspendLayout();
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
			this.panel3.Size = new System.Drawing.Size(928, 36);
			this.panel3.TabIndex = 16;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label5.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.label5.Location = new System.Drawing.Point(0, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(928, 36);
			this.label5.TabIndex = 11;
			this.label5.Tag = "";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.c1);
			this.panel1.Controls.Add(this.pro2);
			this.panel1.Controls.Add(this.pro1);
			this.panel1.Controls.Add(this.panel5);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 36);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(928, 256);
			this.panel1.TabIndex = 17;
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
			this.c1.Size = new System.Drawing.Size(928, 28);
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
			this.pro2.Size = new System.Drawing.Size(928, 16);
			this.pro2.TabIndex = 3;
			// 
			// pro1
			// 
			this.pro1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pro1.Location = new System.Drawing.Point(0, 180);
			this.pro1.Name = "pro1";
			this.pro1.Size = new System.Drawing.Size(928, 16);
			this.pro1.TabIndex = 2;
			// 
			// panel5
			// 
			this.panel5.BackColor = System.Drawing.Color.CornflowerBlue;
			this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel5.Location = new System.Drawing.Point(0, 176);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(928, 4);
			this.panel5.TabIndex = 1;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.ck1);
			this.panel2.Controls.Add(this.dt2);
			this.panel2.Controls.Add(this.dt1);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Controls.Add(this.cmd_close);
			this.panel2.Controls.Add(this.cmd_ok);
			this.panel2.Controls.Add(this.control1);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(928, 176);
			this.panel2.TabIndex = 0;
			// 
			// ck1
			// 
			this.ck1.Location = new System.Drawing.Point(456, 72);
			this.ck1.Name = "ck1";
			this.ck1.Size = new System.Drawing.Size(212, 24);
			this.ck1.TabIndex = 159;
			this.ck1.Text = "checkBox1";
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
			this.cmd_close.Location = new System.Drawing.Point(688, 108);
			this.cmd_close.Name = "cmd_close";
			this.cmd_close.Size = new System.Drawing.Size(136, 40);
			this.cmd_close.TabIndex = 154;
			this.cmd_close.Text = "button3";
			this.cmd_close.Click += new System.EventHandler(this.cmd_close_Click);
			// 
			// cmd_ok
			// 
			this.cmd_ok.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_ok.Location = new System.Drawing.Point(688, 32);
			this.cmd_ok.Name = "cmd_ok";
			this.cmd_ok.Size = new System.Drawing.Size(136, 40);
			this.cmd_ok.TabIndex = 152;
			this.cmd_ok.Text = "OK";
			this.cmd_ok.Click += new System.EventHandler(this.cmd_ok_Click);
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
			this.label3.Location = new System.Drawing.Point(588, 144);
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
			// frmTaInitSalary
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
			this.ClientSize = new System.Drawing.Size(928, 292);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel3);
			this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "frmTaInitSalary";
			this.Text = "frmTaInitSalary";
			this.Load += new System.EventHandler(this.frmTaInitSalary_Load);
			this.panel3.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dt2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dt1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void frmTaInitSalary_Load(object sender, System.EventArgs e)
		{
			Basic.Function.PublicFunction.L_Init_Label(this);
			control1.InitCB(this.Tag);
			control1.Initlabel();
			DateTime dt=T_String.GetDate();
			dt2.Value=dt;	
			dt1.Value=dt;	
			dt1.CustomFormat=dt2.CustomFormat="yyyyMM";				
		
		}

		private void cmd_ok_Click(object sender, System.EventArgs e)
		{
			if(MessageBox.Show(PublicFunction.L_Get_Msg("msg",121),this.Text,MessageBoxButtons.OKCancel)==DialogResult.OK)			
			{
				DateTime d1=(DateTime)dt1.Value;
				DateTime d2=(DateTime)dt2.Value;
				string sql="";
				//THU THEM DE XOA NHUNG DONG TINH LUONG 2 LAN
				sql = "delete FILD02A WHERE SEQ_NO>2 AND YYY_MM  between '" + d1.ToString("yyyyMM") + "'"
					+ " and '" + d2.ToString("yyyyMM") + "' and EMP_ID in (Select EMP_ID from FILB01A where " +
					control1.GetWhere("", !ck1.Checked) + ")";
				PublicFunction.SQL_Execute(sql);
				sql = "";				
				Func.RecordSet rs_LCB=new Func.RecordSet("Select * from FILD01A where INI_BT=1",PublicFunction.C_con);
				for (int i=0;i<rs_LCB.rows;i++)
				{
					if(sql!="") sql+=",";
					sql+="["+rs_LCB.record(i,"COL_NM")+"]=0";
				}
				sql="update FILD02A  set "+sql+	"where YYY_MM between '"+ d1.ToString("yyyyMM")+"'"
					+" and '" +d2.ToString("yyyyMM")+"' and EMP_ID in (Select EMP_ID from FILB01A where "+
					control1.GetWhere("",!ck1.Checked)+") and (LCK_BT is null or LCK_BT=0) ";			
				PublicFunction.SQL_Execute(sql);
				MessageBox.Show(PublicFunction.L_Get_Msg("Staff",1));
			}
		}

		private void cmd_close_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}
	}
}
