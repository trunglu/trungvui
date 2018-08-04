using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace GP8000.Payroll
{
	/// <summary>
	/// Summary description for frmTaTXT.
	/// </summary>
	public class frmTaTXT : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button cmd_can;
		private System.Windows.Forms.Button cmd_ok;
		public System.Windows.Forms.TextBox txt;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmTaTXT()
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
			this.cmd_can = new System.Windows.Forms.Button();
			this.cmd_ok = new System.Windows.Forms.Button();
			this.txt = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// cmd_can
			// 
			this.cmd_can.BackColor = System.Drawing.Color.Pink;
			this.cmd_can.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.cmd_can.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_can.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmd_can.Location = new System.Drawing.Point(157, 116);
			this.cmd_can.Name = "cmd_can";
			this.cmd_can.Size = new System.Drawing.Size(88, 36);
			this.cmd_can.TabIndex = 5;
			this.cmd_can.Text = "button2";
			// 
			// cmd_ok
			// 
			this.cmd_ok.BackColor = System.Drawing.Color.Pink;
			this.cmd_ok.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.cmd_ok.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_ok.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmd_ok.Location = new System.Drawing.Point(33, 116);
			this.cmd_ok.Name = "cmd_ok";
			this.cmd_ok.Size = new System.Drawing.Size(88, 36);
			this.cmd_ok.TabIndex = 4;
			this.cmd_ok.Text = "button1";
			this.cmd_ok.Click += new System.EventHandler(this.cmd_ok_Click);
			// 
			// txt
			// 
			this.txt.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txt.Location = new System.Drawing.Point(7, 4);
			this.txt.MaxLength = 50;
			this.txt.Multiline = true;
			this.txt.Name = "txt";
			this.txt.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txt.Size = new System.Drawing.Size(264, 104);
			this.txt.TabIndex = 3;
			this.txt.Text = "";
			// 
			// frmTaTXT
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
			this.ClientSize = new System.Drawing.Size(278, 158);
			this.Controls.Add(this.cmd_can);
			this.Controls.Add(this.cmd_ok);
			this.Controls.Add(this.txt);
			this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmTaTXT";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmTaTXT";
			this.Load += new System.EventHandler(this.frmTaTXT_Load);
			this.ResumeLayout(false);

		}
		#endregion

		private void frmTaTXT_Load(object sender, System.EventArgs e)
		{
			Basic.Function.PublicFunction.L_Init_Label(this);	
		}

		private void cmd_ok_Click(object sender, System.EventArgs e)
		{
		
		}
	}
}
