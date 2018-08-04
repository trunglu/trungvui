using System;
using System.IO;
using System.Windows;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Collections;
using System.Drawing;
using GP8000.Personnel.Report;
using Basic.Form;
using Basic.Function;

namespace GP8000.Payroll
{
	/// <summary>
	/// Summary description for frmTaAddCol.
	/// </summary>
	public class frmTaAddColPayroll : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button cmd_ok;
		private System.Windows.Forms.Button cmd_can;
		private System.Windows.Forms.Label label5;
		public System.Windows.Forms.TextBox txt1;
		public System.Windows.Forms.TextBox txt2;
		public System.Windows.Forms.TextBox txt3;
		public System.Windows.Forms.TextBox txt4;
		public System.Windows.Forms.TextBox txt5;
		private System.Windows.Forms.ComboBox cb;
		private System.Windows.Forms.CheckBox ck;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmTaAddColPayroll()
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
			this.label1 = new System.Windows.Forms.Label();
			this.txt1 = new System.Windows.Forms.TextBox();
			this.txt2 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txt3 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txt4 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.cmd_ok = new System.Windows.Forms.Button();
			this.cmd_can = new System.Windows.Forms.Button();
			this.txt5 = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.cb = new System.Windows.Forms.ComboBox();
			this.ck = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(20, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(140, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "label1";
			// 
			// txt1
			// 
			this.txt1.Location = new System.Drawing.Point(144, 8);
			this.txt1.MaxLength = 20;
			this.txt1.Name = "txt1";
			this.txt1.Size = new System.Drawing.Size(108, 23);
			this.txt1.TabIndex = 0;
			this.txt1.Text = "";
			// 
			// txt2
			// 
			this.txt2.Location = new System.Drawing.Point(144, 36);
			this.txt2.MaxLength = 50;
			this.txt2.Name = "txt2";
			this.txt2.Size = new System.Drawing.Size(332, 23);
			this.txt2.TabIndex = 3;
			this.txt2.Text = "";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(20, 40);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(140, 20);
			this.label2.TabIndex = 2;
			this.label2.Text = "label2";
			// 
			// txt3
			// 
			this.txt3.Location = new System.Drawing.Point(144, 64);
			this.txt3.MaxLength = 50;
			this.txt3.Name = "txt3";
			this.txt3.Size = new System.Drawing.Size(332, 23);
			this.txt3.TabIndex = 4;
			this.txt3.Text = "";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(20, 68);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(140, 20);
			this.label3.TabIndex = 4;
			this.label3.Text = "label3";
			// 
			// txt4
			// 
			this.txt4.Location = new System.Drawing.Point(144, 92);
			this.txt4.MaxLength = 50;
			this.txt4.Name = "txt4";
			this.txt4.Size = new System.Drawing.Size(332, 23);
			this.txt4.TabIndex = 5;
			this.txt4.Text = "";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(20, 96);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(140, 20);
			this.label4.TabIndex = 6;
			this.label4.Text = "label4";
			// 
			// cmd_ok
			// 
			this.cmd_ok.Location = new System.Drawing.Point(123, 152);
			this.cmd_ok.Name = "cmd_ok";
			this.cmd_ok.Size = new System.Drawing.Size(104, 40);
			this.cmd_ok.TabIndex = 7;
			this.cmd_ok.Text = "Ok";
			this.cmd_ok.Click += new System.EventHandler(this.cmd_ok_Click);
			// 
			// cmd_can
			// 
			this.cmd_can.Location = new System.Drawing.Point(263, 152);
			this.cmd_can.Name = "cmd_can";
			this.cmd_can.Size = new System.Drawing.Size(104, 40);
			this.cmd_can.TabIndex = 8;
			this.cmd_can.Text = "Can";
			this.cmd_can.Click += new System.EventHandler(this.cmd_can_Click);
			// 
			// txt5
			// 
			this.txt5.Location = new System.Drawing.Point(144, 120);
			this.txt5.MaxLength = 50;
			this.txt5.Name = "txt5";
			this.txt5.Size = new System.Drawing.Size(332, 23);
			this.txt5.TabIndex = 6;
			this.txt5.Text = "";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(20, 124);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(140, 20);
			this.label5.TabIndex = 10;
			this.label5.Text = "label5";
			// 
			// cb
			// 
			this.cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cb.Items.AddRange(new object[] {
													"Decimal",
													"String",
													"Bit"});
			this.cb.Location = new System.Drawing.Point(252, 8);
			this.cb.Name = "cb";
			this.cb.Size = new System.Drawing.Size(112, 24);
			this.cb.TabIndex = 1;
			// 
			// ck
			// 
			this.ck.Location = new System.Drawing.Point(368, 8);
			this.ck.Name = "ck";
			this.ck.TabIndex = 2;
			this.ck.Text = "ck";
			// 
			// frmTaAddColPayroll
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
			this.ClientSize = new System.Drawing.Size(490, 198);
			this.Controls.Add(this.ck);
			this.Controls.Add(this.txt5);
			this.Controls.Add(this.txt4);
			this.Controls.Add(this.txt3);
			this.Controls.Add(this.txt2);
			this.Controls.Add(this.txt1);
			this.Controls.Add(this.cb);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.cmd_can);
			this.Controls.Add(this.cmd_ok);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmTaAddColPayroll";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmTaAddColPayroll";
			this.Load += new System.EventHandler(this.frmTaAddCol_Load);
			this.ResumeLayout(false);

		}
		#endregion

		private void frmTaAddCol_Load(object sender, System.EventArgs e)
		{
			cb.SelectedIndex=0;
			Basic.Function.PublicFunction.L_Init_Label(this);
		}

		private void cmd_ok_Click(object sender, System.EventArgs e)
		{
			if(txt1.Text+""=="" || txt2.Text+""=="" || txt3.Text+""=="" || txt4.Text+""==""  || txt5.Text+""=="" )
			{
				MessageBox.Show("Please Input All Data!");
				return;
			}
			if(Func.Fun.CheckFieldOfTable( PublicFunction.C_con,txt1.Text,"FILD02A"))
			{
				MessageBox.Show(txt1.Text+" Column Is Existed!");
				return;
			}
			SqlConnection con=new SqlConnection(PublicFunction.C_con.ConnectionString);
			con.Open();		
			SqlTransaction tran=con.BeginTransaction();
			try
			{
				string tp=" float";

				switch (cb.Text.ToString().ToUpper())
				{
					case "STRING":
						tp = "nvarchar(50)";
						break;
					case "Decimal":
						tp = "float";
						break;
					case "BIT":
						tp = "bit";
						break;
				}

				string sql="";
				sql="Alter table FILD02A Add ["+txt1.Text+"] "+tp +" default(0)";
				SqlCommand cmd=new SqlCommand(sql,con,tran);
				cmd.ExecuteNonQuery();

				sql="Insert Into FILD01A(COL_NM, SEQ_NO, COL_EN, COL_VN, COL_CH, COL_TT,"+
					"HUR_BT, ACC_BT, BAS_BT, LCK_BT, HID_BT, QIN_BT) values("+
					"N'"+txt1.Text+"',Default,N'"+txt2.Text+"',"+
					"N'"+txt3.Text+"',N'"+txt5.Text+"',"+
					"N'"+txt4.Text+"',0,";
				if(ck.Checked)
					sql+="1,1,0,1,0)";
				else
					sql+="0,0,0,0,0)";
				cmd=new SqlCommand(sql,con,tran);
				cmd.ExecuteNonQuery();

				sql="Alter table FILD03A Add ["+txt1.Text+"] "+tp;
				cmd=new SqlCommand(sql,con,tran);
				cmd.ExecuteNonQuery();
				sql="Alter table FILA19A Add ["+txt1.Text+"] "+tp;
				cmd=new SqlCommand(sql,con,tran);
				cmd.ExecuteNonQuery();
				
				tran.Commit();
			}
			catch(SqlException ex)
			{
				tran.Rollback();
				MessageBox.Show(ex.Message);	
				return;
			}
			con.Close();
			this.DialogResult=DialogResult.OK;
		}

		private void cmd_can_Click(object sender, System.EventArgs e)
		{
			this.DialogResult=DialogResult.Cancel;
		}
	}
}
