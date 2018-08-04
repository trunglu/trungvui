using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using Basic.Form;
using Basic.Function;
using System.IO;
using System.Diagnostics;

namespace GP8000.Personnel.FormRPT
{
	/// <summary>
	/// Summary description for frmTaPrintWID.
	/// </summary>
	public class frmTaPrintWID : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button cmd_print;
		private System.Windows.Forms.Button cmd_close;
		public System.Windows.Forms.CheckBox ck;
		public System.Windows.Forms.Panel p1;
		public string sql;
		private GP8000.UserControl.CrtTaCondition1 condition1;
		public System.Windows.Forms.CheckBox ck_cur;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmTaPrintWID()
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
			this.condition1 = new GP8000.UserControl.CrtTaCondition1();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.cmd_print = new System.Windows.Forms.Button();
			this.cmd_close = new System.Windows.Forms.Button();
			this.ck = new System.Windows.Forms.CheckBox();
			this.p1 = new System.Windows.Forms.Panel();
			this.ck_cur = new System.Windows.Forms.CheckBox();
			this.p1.SuspendLayout();
			this.SuspendLayout();
			// 
			// condition1
			// 
			this.condition1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.condition1.Location = new System.Drawing.Point(4, 4);
			this.condition1.Name = "condition1";
			this.condition1.Size = new System.Drawing.Size(452, 172);
			this.condition1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(16, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(72, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "label1";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(76, 4);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(72, 23);
			this.textBox1.TabIndex = 2;
			this.textBox1.Text = "";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(184, 4);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(72, 23);
			this.textBox2.TabIndex = 3;
			this.textBox2.Text = "";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.Location = new System.Drawing.Point(152, 4);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(36, 23);
			this.label2.TabIndex = 4;
			this.label2.Tag = "N";
			this.label2.Text = "->>";
			// 
			// cmd_print
			// 
			this.cmd_print.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_print.Location = new System.Drawing.Point(102, 232);
			this.cmd_print.Name = "cmd_print";
			this.cmd_print.Size = new System.Drawing.Size(92, 36);
			this.cmd_print.TabIndex = 5;
			this.cmd_print.Text = "Print";
			this.cmd_print.Click += new System.EventHandler(this.cmd_print_Click);
			// 
			// cmd_close
			// 
			this.cmd_close.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_close.Location = new System.Drawing.Point(270, 232);
			this.cmd_close.Name = "cmd_close";
			this.cmd_close.Size = new System.Drawing.Size(92, 36);
			this.cmd_close.TabIndex = 6;
			this.cmd_close.Text = "Close";
			this.cmd_close.Click += new System.EventHandler(this.cmd_close_Click);
			// 
			// ck
			// 
			this.ck.Checked = true;
			this.ck.CheckState = System.Windows.Forms.CheckState.Checked;
			this.ck.Location = new System.Drawing.Point(12, 200);
			this.ck.Name = "ck";
			this.ck.TabIndex = 7;
			this.ck.Text = "checkBox1";
			this.ck.CheckedChanged += new System.EventHandler(this.ck_CheckedChanged);
			// 
			// p1
			// 
			this.p1.Controls.Add(this.textBox1);
			this.p1.Controls.Add(this.label1);
			this.p1.Controls.Add(this.textBox2);
			this.p1.Controls.Add(this.label2);
			this.p1.Enabled = false;
			this.p1.Location = new System.Drawing.Point(116, 192);
			this.p1.Name = "p1";
			this.p1.Size = new System.Drawing.Size(320, 32);
			this.p1.TabIndex = 8;
			// 
			// ck_cur
			// 
			this.ck_cur.Location = new System.Drawing.Point(12, 168);
			this.ck_cur.Name = "ck_cur";
			this.ck_cur.Size = new System.Drawing.Size(268, 24);
			this.ck_cur.TabIndex = 10;
			this.ck_cur.Text = "checkBox1";
			this.ck_cur.CheckedChanged += new System.EventHandler(this.ck_cur_CheckedChanged);
			// 
			// frmTaPrintWID
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
			this.ClientSize = new System.Drawing.Size(450, 274);
			this.Controls.Add(this.ck_cur);
			this.Controls.Add(this.p1);
			this.Controls.Add(this.ck);
			this.Controls.Add(this.cmd_close);
			this.Controls.Add(this.cmd_print);
			this.Controls.Add(this.condition1);
			this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmTaPrintWID";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmTaPrintWID";
			this.Load += new System.EventHandler(this.frmTaPrintWID_Load);
			this.p1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void frmTaPrintWID_Load(object sender, System.EventArgs e)
		{
			condition1.InitCB(this.Tag);
			condition1.Initlabel();
			Basic.Function.PublicFunction.L_Init_Label(this);
		}

		private void cmd_close_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}
		public string stf; 
		private void cmd_print_Click(object sender, System.EventArgs e)
		{
				switch (PublicFunction.CUS_ID)
				{	case "8":
						if(ck_cur.Checked)
						{
							sql="Select  *"//a.*,DEP_NM,DEP_N1,POS_NM,b.COL_NO "
								+"from FILB01A a left outer join FILA02A b on a.DEP_ID=b.DEP_ID left outer join FILA07A c on a.POS_ID=c.POS_ID left outer join FILB01AB d on a.EMP_ID=d.EMP_ID "
								+"where a.EMP_ID=N'"+stf+"'";
						}
						else
						{
							if(ck.Checked)
							{
								sql="Select  *"//a.*,DEP_NM,DEP_N1,POS_NM,b.COL_NO "
									+"from FILB01A a left outer join FILA02A b on a.DEP_ID=b.DEP_ID left outer join FILA07A c on a.POS_ID=c.POS_ID left outer join FILB01AB d on a.EMP_ID=d.EMP_ID "
									+"where ";
								sql+=condition1.GetWhere("a",true);
							}
							else
							{
								int a=T_String.IsNullTo0(textBox1.Text+""); 
								int b=T_String.IsNullTo0(textBox2.Text+""); 
								a=(a - 1) * 10;
								b = b * 10;
								sql="Select  *"//a.*,DEP_NM,DEP_N1,POS_NM,b.COL_NO "
									+"from FILB01A a left outer join FILA02A b on a.DEP_ID=b.DEP_ID left outer join FILA07A c on a.POS_ID=c.POS_ID left outer join FILB01AB d on a.EMP_ID=d.EMP_ID "
									+"where ";
								sql+=condition1.GetWhere("a",true);
						
								sql+= " and a.EMP_ID  not in (Select Top "+a+" EMP_ID from FILB01A where "+condition1.GetWhere("FILB01A",true)+")";
						
							}
						}
						break;
					default: 
					if(ck_cur.Checked)
					{
						sql="Select  *"//a.*,DEP_NM,DEP_N1,POS_NM,b.COL_NO "
							+"from FILB01A a,FILA02A b,FILA07A c, FILB01AB d "
							+"where a.DEP_ID=b.DEP_ID and a.POS_ID=c.POS_ID and a.EMP_ID=d.EMP_ID and a.EMP_ID=N'"+stf+"'";
					}
					else
					{
						if(ck.Checked)
						{
							sql="Select  *"//a.*,DEP_NM,DEP_N1,POS_NM,b.COL_NO "
								+"from FILB01A a,FILA02A b,FILA07A c, FILB01AB d "
								+"where a.DEP_ID=b.DEP_ID and a.POS_ID=c.POS_ID and a.EMP_ID=d.EMP_ID and ";
							sql+=condition1.GetWhere("a",true);
						}
						else
						{
							int a=T_String.IsNullTo0(textBox1.Text+""); 
							int b=T_String.IsNullTo0(textBox2.Text+""); 
							a=(a - 1) * 10;
							b = b * 10;
							sql="Select  *"//a.*,DEP_NM,DEP_N1,POS_NM,b.COL_NO "
								+"from FILB01A a,FILA02A b,FILA07A c, FILB01AB d "
								+"where a.DEP_ID=b.DEP_ID and a.POS_ID=c.POS_ID and a.EMP_ID=d.EMP_ID and ";
							sql+=condition1.GetWhere("a",true);
						
							sql+= " and a.EMP_ID  not in (Select Top "+a+" EMP_ID from FILB01A where "+condition1.GetWhere("FILB01A",true)+")";
						
						}
					}
						break;
			}
			Debug.Write(sql);
			this.DialogResult=DialogResult.OK;
		}

		private void ck_CheckedChanged(object sender, System.EventArgs e)
		{
			p1.Enabled=!ck.Checked;
		}

		private void ck_cur_CheckedChanged(object sender, System.EventArgs e)
		{			
			condition1.Enabled=!ck_cur.Checked;
		}

		
	}
}
