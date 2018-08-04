using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using Basic.Function;

namespace Basic.Form
{
	/// <summary>
	/// Summary description for frmTaLicence.
	/// </summary>
	public class frmTaLicence : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label lb;
		public System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button button1;
		public System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmTaLicence()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmTaLicence));
			this.lb = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lb
			// 
			this.lb.BackColor = System.Drawing.Color.Transparent;
			this.lb.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lb.Location = new System.Drawing.Point(18, 7);
			this.lb.Name = "lb";
			this.lb.Size = new System.Drawing.Size(364, 196);
			this.lb.TabIndex = 6;
			this.lb.Tag = "N";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(60, 207);
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.Size = new System.Drawing.Size(324, 23);
			this.textBox1.TabIndex = 7;
			this.textBox1.Text = "";
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button1.Location = new System.Drawing.Point(144, 264);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(112, 28);
			this.button1.TabIndex = 8;
			this.button1.Text = "OK";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(60, 236);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(324, 23);
			this.textBox2.TabIndex = 9;
			this.textBox2.Text = "";
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Location = new System.Drawing.Point(8, 212);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(48, 20);
			this.label1.TabIndex = 10;
			this.label1.Text = "Code :";
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Location = new System.Drawing.Point(8, 240);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(48, 20);
			this.label2.TabIndex = 11;
			this.label2.Text = "Key   :";
			// 
			// frmTaLicence
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(400, 300);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.lb);
			this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frmTaLicence";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmTaLicence";
			this.Load += new System.EventHandler(this.frmTaLicence_Load);
			this.ResumeLayout(false);

		}
		#endregion

		private void frmTaLicence_Load(object sender, System.EventArgs e)
		{
			lb.Text="Taiwan:	\n"+
				"Glinton Information Inc. 永錡資訊股份有限公司 \n"+
				"台北市民生東路五段171號4樓之2 \n"+
				"Tel: 8862-27648036 Fax: 8862-27617048 \n"+
				"Email: service@glinton.com.tw \n \n" +
				"Việt Nam: \n" +
				"Công Ty TNHH Vĩnh Tuyền 永泉資訊有限公司 \n"+
				"55 Lam Sơn P.2, Q.Tân Bình,TP. HCM \n"+
				"Tel:848-2968469/70 Fax:848-8440045 \n"+
				"Email: vnservice@glinton.com.tw \n";
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			if (textBox2.Text==LIC.EncryptWithKey(textBox1.Text))
			{
				LIC.AddLic(textBox2.Text);
				this.DialogResult=DialogResult.OK;
			}
			else
				this.DialogResult=DialogResult.Cancel;
		}
	}
}
