using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using Basic.Form;
using Basic.Function;
namespace GP8000.Personnel
{
	/// <summary>
	/// Summary description for frmTaWorkAgain.
	/// </summary>
	public class frmTaWorkAgain : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label5;
		public System.Windows.Forms.TextBox txt_note;
		private System.Windows.Forms.Label label2;
		public C1.Win.C1Input.C1DateEdit dt;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button cmd_ok;
		private System.Windows.Forms.Button cmd_can;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txt1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txt2;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmTaWorkAgain(string wid,string name)
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			txt1.Text=wid;
			txt2.Text=name;
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
			this.label5 = new System.Windows.Forms.Label();
			this.txt_note = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.dt = new C1.Win.C1Input.C1DateEdit();
			this.label1 = new System.Windows.Forms.Label();
			this.cmd_ok = new System.Windows.Forms.Button();
			this.cmd_can = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.txt1 = new System.Windows.Forms.TextBox();
			this.txt2 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dt)).BeginInit();
			this.SuspendLayout();
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.label5.Dock = System.Windows.Forms.DockStyle.Top;
			this.label5.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.label5.Location = new System.Drawing.Point(0, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(358, 36);
			this.label5.TabIndex = 12;
			this.label5.Tag = "";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txt_note
			// 
			this.txt_note.BackColor = System.Drawing.SystemColors.Window;
			this.txt_note.Location = new System.Drawing.Point(125, 132);
			this.txt_note.MaxLength = 100;
			this.txt_note.Multiline = true;
			this.txt_note.Name = "txt_note";
			this.txt_note.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txt_note.Size = new System.Drawing.Size(216, 52);
			this.txt_note.TabIndex = 136;
			this.txt_note.Tag = "";
			this.txt_note.Text = "";
			// 
			// label2
			// 
			this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label2.Location = new System.Drawing.Point(18, 140);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(112, 23);
			this.label2.TabIndex = 135;
			this.label2.Tag = "";
			this.label2.Text = "VAC_ID";
			// 
			// dt
			// 
			this.dt.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat;
			this.dt.Location = new System.Drawing.Point(125, 104);
			this.dt.Name = "dt";
			this.dt.Size = new System.Drawing.Size(216, 23);
			this.dt.TabIndex = 138;
			this.dt.Tag = null;
			// 
			// label1
			// 
			this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label1.Location = new System.Drawing.Point(18, 112);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(112, 23);
			this.label1.TabIndex = 137;
			this.label1.Tag = "";
			this.label1.Text = "VAC_ID";
			// 
			// cmd_ok
			// 
			this.cmd_ok.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_ok.Location = new System.Drawing.Point(47, 196);
			this.cmd_ok.Name = "cmd_ok";
			this.cmd_ok.Size = new System.Drawing.Size(108, 32);
			this.cmd_ok.TabIndex = 139;
			this.cmd_ok.Text = "OK";
			this.cmd_ok.Click += new System.EventHandler(this.cmd_ok_Click);
			// 
			// cmd_can
			// 
			this.cmd_can.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_can.Location = new System.Drawing.Point(203, 196);
			this.cmd_can.Name = "cmd_can";
			this.cmd_can.Size = new System.Drawing.Size(108, 32);
			this.cmd_can.TabIndex = 140;
			this.cmd_can.Text = "Cancel";
			this.cmd_can.Click += new System.EventHandler(this.cmd_can_Click);
			// 
			// label4
			// 
			this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label4.Location = new System.Drawing.Point(18, 56);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(112, 23);
			this.label4.TabIndex = 142;
			this.label4.Tag = "";
			this.label4.Text = "VAC_ID";
			// 
			// txt1
			// 
			this.txt1.BackColor = System.Drawing.Color.LemonChiffon;
			this.txt1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txt1.Location = new System.Drawing.Point(125, 48);
			this.txt1.MaxLength = 20;
			this.txt1.Name = "txt1";
			this.txt1.ReadOnly = true;
			this.txt1.Size = new System.Drawing.Size(216, 23);
			this.txt1.TabIndex = 143;
			this.txt1.Tag = "";
			this.txt1.Text = "textBox3";
			// 
			// txt2
			// 
			this.txt2.BackColor = System.Drawing.Color.LemonChiffon;
			this.txt2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txt2.Location = new System.Drawing.Point(125, 76);
			this.txt2.MaxLength = 20;
			this.txt2.Name = "txt2";
			this.txt2.ReadOnly = true;
			this.txt2.Size = new System.Drawing.Size(216, 23);
			this.txt2.TabIndex = 145;
			this.txt2.Tag = "";
			this.txt2.Text = "textBox3";
			// 
			// label3
			// 
			this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label3.Location = new System.Drawing.Point(18, 84);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(112, 23);
			this.label3.TabIndex = 144;
			this.label3.Tag = "";
			this.label3.Text = "VAC_ID";
			// 
			// frmTaWorkAgain
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
			this.ClientSize = new System.Drawing.Size(358, 238);
			this.Controls.Add(this.txt2);
			this.Controls.Add(this.txt1);
			this.Controls.Add(this.cmd_can);
			this.Controls.Add(this.cmd_ok);
			this.Controls.Add(this.dt);
			this.Controls.Add(this.txt_note);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label2);
			this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmTaWorkAgain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmTaWorkAgain";
			this.Load += new System.EventHandler(this.frmTaWorkAgain_Load);
			((System.ComponentModel.ISupportInitialize)(this.dt)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void frmTaWorkAgain_Load(object sender, System.EventArgs e)
		{
			Basic.Function.PublicFunction.L_Init_Label(this);
			dt.CustomFormat=PublicFunction.GetOption("DATE");
			dt.Value=T_String.GetDate();
		}

		private void cmd_ok_Click(object sender, System.EventArgs e)
		{
			this.DialogResult=DialogResult.OK;
		}

		private void cmd_can_Click(object sender, System.EventArgs e)
		{
			this.DialogResult=DialogResult.Cancel;
		}
	}
}
