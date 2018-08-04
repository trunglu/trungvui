using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace GP8000.Attendance
{
	/// <summary>
	/// Summary description for frmTaInputData.
	/// </summary>
	public class frmTaInputData : System.Windows.Forms.Form
	{
		public System.Windows.Forms.TextBox txt;
		private System.Windows.Forms.Button cmd_ok;
		private System.Windows.Forms.Button button1;
		public System.Windows.Forms.Label lb;
		public System.Windows.Forms.TextBox txt1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmTaInputData()
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
			this.lb = new System.Windows.Forms.Label();
			this.txt1 = new System.Windows.Forms.TextBox();
			this.txt = new System.Windows.Forms.TextBox();
			this.cmd_ok = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lb
			// 
			this.lb.Location = new System.Drawing.Point(10, 172);
			this.lb.Name = "lb";
			this.lb.TabIndex = 0;
			this.lb.Tag = "N";
			// 
			// txt1
			// 
			this.txt1.Location = new System.Drawing.Point(106, 168);
			this.txt1.Name = "txt1";
			this.txt1.Size = new System.Drawing.Size(380, 23);
			this.txt1.TabIndex = 1;
			this.txt1.Text = "";
			// 
			// txt
			// 
			this.txt.BackColor = System.Drawing.Color.LemonChiffon;
			this.txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt.Dock = System.Windows.Forms.DockStyle.Top;
			this.txt.Location = new System.Drawing.Point(0, 0);
			this.txt.Multiline = true;
			this.txt.Name = "txt";
			this.txt.ReadOnly = true;
			this.txt.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txt.Size = new System.Drawing.Size(496, 164);
			this.txt.TabIndex = 26;
			this.txt.Text = "";
			// 
			// cmd_ok
			// 
			this.cmd_ok.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.cmd_ok.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_ok.Location = new System.Drawing.Point(126, 200);
			this.cmd_ok.Name = "cmd_ok";
			this.cmd_ok.Size = new System.Drawing.Size(92, 36);
			this.cmd_ok.TabIndex = 27;
			this.cmd_ok.Text = "OK";
			this.cmd_ok.Click += new System.EventHandler(this.cmd_ok_Click);
			// 
			// button1
			// 
			this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button1.Location = new System.Drawing.Point(278, 200);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(92, 36);
			this.button1.TabIndex = 28;
			this.button1.Text = "Exit";
			// 
			// frmTaInputData
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
			this.ClientSize = new System.Drawing.Size(496, 240);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.cmd_ok);
			this.Controls.Add(this.txt);
			this.Controls.Add(this.txt1);
			this.Controls.Add(this.lb);
			this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "frmTaInputData";
			this.Text = "frmTaInputData";
			this.ResumeLayout(false);

		}
		#endregion

		private void cmd_ok_Click(object sender, System.EventArgs e)
		{
		
		}
	}
}
