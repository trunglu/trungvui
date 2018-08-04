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
using C1.Win.C1FlexGrid;


namespace GP8000.Personnel
{
	/// <summary>
	/// Summary description for frmTaQuickUploadImage.
	/// </summary>
	public class frmTaQuickUploadImage : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button cmd1;
		private System.Windows.Forms.Button cmd_ok;
		private System.Windows.Forms.Button cmd_close;
		private System.Windows.Forms.FolderBrowserDialog op;
		private System.Windows.Forms.ListBox lb;
		private System.Windows.Forms.ProgressBar progressBar1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmTaQuickUploadImage()
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
			this.label1 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.cmd1 = new System.Windows.Forms.Button();
			this.lb = new System.Windows.Forms.ListBox();
			this.cmd_ok = new System.Windows.Forms.Button();
			this.cmd_close = new System.Windows.Forms.Button();
			this.op = new System.Windows.Forms.FolderBrowserDialog();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.panel3.Controls.Add(this.label5);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel3.Location = new System.Drawing.Point(0, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(428, 36);
			this.panel3.TabIndex = 6;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label5.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.label5.Location = new System.Drawing.Point(0, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(428, 36);
			this.label5.TabIndex = 11;
			this.label5.Tag = "";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(4, 44);
			this.label1.Name = "label1";
			this.label1.TabIndex = 7;
			this.label1.Text = "label1";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(92, 40);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(304, 23);
			this.textBox1.TabIndex = 8;
			this.textBox1.Text = "";
			// 
			// cmd1
			// 
			this.cmd1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd1.Location = new System.Drawing.Point(396, 40);
			this.cmd1.Name = "cmd1";
			this.cmd1.Size = new System.Drawing.Size(28, 23);
			this.cmd1.TabIndex = 9;
			this.cmd1.Tag = "N";
			this.cmd1.Text = "...";
			this.cmd1.Click += new System.EventHandler(this.cmd1_Click);
			// 
			// lb
			// 
			this.lb.ItemHeight = 16;
			this.lb.Location = new System.Drawing.Point(4, 68);
			this.lb.Name = "lb";
			this.lb.Size = new System.Drawing.Size(420, 212);
			this.lb.TabIndex = 10;
			// 
			// cmd_ok
			// 
			this.cmd_ok.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_ok.Location = new System.Drawing.Point(92, 306);
			this.cmd_ok.Name = "cmd_ok";
			this.cmd_ok.Size = new System.Drawing.Size(88, 32);
			this.cmd_ok.TabIndex = 11;
			this.cmd_ok.Text = "button1";
			this.cmd_ok.Click += new System.EventHandler(this.cmd_ok_Click);
			// 
			// cmd_close
			// 
			this.cmd_close.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_close.Location = new System.Drawing.Point(248, 306);
			this.cmd_close.Name = "cmd_close";
			this.cmd_close.Size = new System.Drawing.Size(88, 32);
			this.cmd_close.TabIndex = 12;
			this.cmd_close.Text = "button2";
			this.cmd_close.Click += new System.EventHandler(this.cmd_close_Click);
			// 
			// progressBar1
			// 
			this.progressBar1.Location = new System.Drawing.Point(4, 280);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(420, 20);
			this.progressBar1.TabIndex = 13;
			// 
			// frmTaQuickUploadImage
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
			this.ClientSize = new System.Drawing.Size(428, 342);
			this.Controls.Add(this.progressBar1);
			this.Controls.Add(this.cmd_close);
			this.Controls.Add(this.cmd_ok);
			this.Controls.Add(this.lb);
			this.Controls.Add(this.cmd1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.panel3);
			this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmTaQuickUploadImage";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmTaQuickUploadImage";
			this.Load += new System.EventHandler(this.frmTaQuickUploadImage_Load);
			this.panel3.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void frmTaQuickUploadImage_Load(object sender, System.EventArgs e)
		{
			Basic.Function.PublicFunction.L_Init_Label(this);	
		}

		private void cmd1_Click(object sender, System.EventArgs e)
		{
			op.SelectedPath= textBox1.Text;
			if(op.ShowDialog()==DialogResult.OK) 
				textBox1.Text=op.SelectedPath;
		}

		private void cmd_close_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void cmd_ok_Click(object sender, System.EventArgs e)
		{
			Thread th=new Thread(new System.Threading.ThreadStart(upload));
			th.Start();
			string []f1=Directory.GetFiles(textBox1.Text,"*.jpg");
			//lb.Items.AddRange(f1);
			for(int i=0;i<f1.Length;i++)
			{
			}		
		}
		
		
		private void upload()
		{		
			string []f1=Directory.GetFiles(textBox1.Text,"*.jpg");
			//lb.Items.AddRange(f1);
			for(int i=0;i<f1.Length;i++)
			{					
				try
				{	
					
					System.IO.FileInfo a=new FileInfo(f1[i]);	
					if (PublicFunction.CUS_ID=="300")//KenYa
					{
						if(a.Length<=100000)
						{
							string fn=f1[i];
							string CRD_ID="",EMP_I1="";
							string EMP_ID=fn.Replace(".jpg","");
						
							EMP_ID=EMP_ID.Replace(".JPG","");
							EMP_ID=EMP_ID.Remove(0,EMP_ID.LastIndexOf("\\")+1);
							if(EMP_ID.LastIndexOf("_")>0)
								EMP_I1=EMP_ID.Substring(0,EMP_ID.LastIndexOf("_"));
							CRD_ID=EMP_ID.Remove(0,EMP_ID.LastIndexOf("_")+1);
							if(T_String.IsNullTo0(T_String.GetDataFromSQL("COUNT(EMP_I1)","FILB01A","EMP_I1=N'"+EMP_I1+"' AND CRD_ID='"+CRD_ID+"'"))>0)
							{
								lb.Items.Add(f1[i]);
								if(T_String.IsNullTo0(T_String.GetDataFromSQL("COUNT(EMP_ID)","FILB01AB","EMP_ID=N'"+T_String.GetDataFromSQL("EMP_ID","FILB01A","EMP_I1='"+EMP_I1+"'AND CRD_ID='"+CRD_ID+"'")+"'"))<=0)
									PublicFunction.SQL_Execute("Insert Into FILB01AB(EMP_ID) values(N'"+T_String.GetDataFromSQL("EMP_ID","FILB01A","EMP_I1='"+EMP_I1+"'AND CRD_ID='"+CRD_ID+"'")+"')");
								ImageFunction.UploadImageToSQL(fn,"PIC_DR","FILB01AB","EMP_ID=N'"+T_String.GetDataFromSQL("EMP_ID","FILB01A","EMP_I1='"+EMP_I1+"'AND CRD_ID='"+CRD_ID+"'")+"'");							
							}
						}
					}
					else
					{
						if(a.Length<=100000)
						{
							string fn=f1[i];
							string EMP_ID=fn.Replace(".jpg","");
							EMP_ID=EMP_ID.Replace(".JPG","");
							EMP_ID=EMP_ID.Remove(0,EMP_ID.LastIndexOf("\\")+1);
							if(T_String.IsNullTo0(T_String.GetDataFromSQL("COUNT(EMP_ID)","FILB01A","EMP_ID=N'"+EMP_ID+"'"))>0)
							{
								lb.Items.Add(f1[i]);
								if(T_String.IsNullTo0(T_String.GetDataFromSQL("COUNT(EMP_ID)","FILB01AB","EMP_ID=N'"+EMP_ID+"'"))<=0)
									PublicFunction.SQL_Execute("Insert Into FILB01AB(EMP_ID) values(N'"+EMP_ID+"')");
								ImageFunction.UploadImageToSQL(fn,"PIC_DR","FILB01AB","EMP_ID=N'"+EMP_ID+"'");							
							}
						}
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show(this, ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}	
				progressBar1.Value=(int)(i*100)/f1.Length;
			}
			MessageBox.Show(PublicFunction.L_Get_Msg("Staff",1));
		}
	}
}
