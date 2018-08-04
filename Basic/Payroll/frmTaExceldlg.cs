using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace GP8000.Payroll
{
	/// <summary>
	/// Summary description for frmTaExceldlg.
	/// </summary>
	public class frmTaExceldlg : System.Windows.Forms.Form
	{
		public System.Windows.Forms.ProgressBar pro;
		public System.Windows.Forms.Label lb;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmTaExceldlg()
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
			this.pro = new System.Windows.Forms.ProgressBar();
			this.lb = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// pro
			// 
			this.pro.Dock = System.Windows.Forms.DockStyle.Top;
			this.pro.Location = new System.Drawing.Point(0, 0);
			this.pro.Name = "pro";
			this.pro.Size = new System.Drawing.Size(460, 20);
			this.pro.TabIndex = 0;
			// 
			// lb
			// 
			this.lb.BackColor = System.Drawing.Color.Black;
			this.lb.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lb.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lb.ForeColor = System.Drawing.Color.Blue;
			this.lb.Location = new System.Drawing.Point(0, 20);
			this.lb.Name = "lb";
			this.lb.Size = new System.Drawing.Size(460, 28);
			this.lb.TabIndex = 1;
			this.lb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// frmTaExceldlg
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
			this.ClientSize = new System.Drawing.Size(460, 48);
			this.Controls.Add(this.lb);
			this.Controls.Add(this.pro);
			this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frmTaExceldlg";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.TransparencyKey = System.Drawing.Color.Black;
			this.ResumeLayout(false);

		}
		#endregion
	}
}
