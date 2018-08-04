using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using Basic.Form;
using Basic.Function;

namespace GP8000.Attendance
{
	/// <summary>
	/// Summary description for frmTaRound.
	/// </summary>
	public class frmTaRound : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label lb;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox ROU_MN;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox SEQ_HR;
		private System.Windows.Forms.Button cmd_close;
		private System.Windows.Forms.Button cmd_ok;
		public string st;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmTaRound(string st)
		{
			this.st=st;
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
			this.label10 = new System.Windows.Forms.Label();
			this.ROU_MN = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.SEQ_HR = new System.Windows.Forms.TextBox();
			this.cmd_close = new System.Windows.Forms.Button();
			this.cmd_ok = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lb
			// 
			this.lb.BackColor = System.Drawing.Color.Moccasin;
			this.lb.Dock = System.Windows.Forms.DockStyle.Right;
			this.lb.Location = new System.Drawing.Point(308, 0);
			this.lb.Name = "lb";
			this.lb.Size = new System.Drawing.Size(448, 188);
			this.lb.TabIndex = 49;
			this.lb.Tag = "N";
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(72, 44);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(224, 23);
			this.label10.TabIndex = 47;
			this.label10.Tag = "SEQ_HR";
			this.label10.Text = "label10";
			// 
			// ROU_MN
			// 
			this.ROU_MN.Location = new System.Drawing.Point(12, 36);
			this.ROU_MN.Name = "ROU_MN";
			this.ROU_MN.Size = new System.Drawing.Size(56, 23);
			this.ROU_MN.TabIndex = 1;
			this.ROU_MN.Tag = "ROU_MN";
			this.ROU_MN.Text = "";
			this.ROU_MN.Leave += new System.EventHandler(this.ROU_MN_Leave);
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(72, 12);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(224, 23);
			this.label9.TabIndex = 48;
			this.label9.Tag = "ROU_MN";
			this.label9.Text = "label9";
			// 
			// SEQ_HR
			// 
			this.SEQ_HR.Location = new System.Drawing.Point(12, 4);
			this.SEQ_HR.Name = "SEQ_HR";
			this.SEQ_HR.Size = new System.Drawing.Size(56, 23);
			this.SEQ_HR.TabIndex = 0;
			this.SEQ_HR.Tag = "SEQ_HR";
			this.SEQ_HR.Text = "";
			this.SEQ_HR.Leave += new System.EventHandler(this.ROU_MN_Leave);
			// 
			// cmd_close
			// 
			this.cmd_close.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_close.Location = new System.Drawing.Point(96, 136);
			this.cmd_close.Name = "cmd_close";
			this.cmd_close.Size = new System.Drawing.Size(116, 36);
			this.cmd_close.TabIndex = 3;
			this.cmd_close.Text = "Close";
			this.cmd_close.Click += new System.EventHandler(this.cmd_close_Click);
			// 
			// cmd_ok
			// 
			this.cmd_ok.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_ok.Location = new System.Drawing.Point(96, 84);
			this.cmd_ok.Name = "cmd_ok";
			this.cmd_ok.Size = new System.Drawing.Size(116, 36);
			this.cmd_ok.TabIndex = 2;
			this.cmd_ok.Text = "Save";
			this.cmd_ok.Click += new System.EventHandler(this.cmd_ok_Click);
			// 
			// frmTaRound
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
			this.ClientSize = new System.Drawing.Size(756, 188);
			this.Controls.Add(this.cmd_close);
			this.Controls.Add(this.cmd_ok);
			this.Controls.Add(this.lb);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.ROU_MN);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.SEQ_HR);
			this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frmTaRound";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmTaRound";
			this.Load += new System.EventHandler(this.frmTaRound_Load);
			this.ResumeLayout(false);

		}
		#endregion

		private void frmTaRound_Load(object sender, System.EventArgs e)
		{
			Basic.Function.PublicFunction.L_Init_Label(this);	
			if(st+""!= "" && st.Length>=5)
			{
				SEQ_HR.Text=T_String.IsNullTo0(PublicFunction.S_Left(st,2))+"";
				ROU_MN.Text=T_String.IsNullTo0(PublicFunction.S_Right(st,2))+"";
				tinhgio();
			}
		}

		private void ROU_MN_Leave(object sender, System.EventArgs e)
		{
			tinhgio();
		}
		private void tinhgio()
		{
			int SEQ=T_String.IsNullTo0(SEQ_HR.Text); 
			int ROU=T_String.IsNullTo0(ROU_MN.Text);
			int tm1=0,tm=0;			
			lb.Text="";
			if(SEQ==0)	
			{
				lb.Text=PublicFunction.L_Get_Msg("msg",33);
				return;			
			}			
			string gio=PublicFunction.L_Get_Msg("msg",31);
			string va=PublicFunction.L_Get_Msg("msg",32);
			for(int i=1;i<=SEQ;i++)
			{
				tm=(int)((60/SEQ)*i);
				tm1=(int)tm-ROU;
				lb.Text+=gio+"<="+tm+" "+va+" "+gio+">="+tm1+" => "+gio+"="+tm+" ; ";
				tm=(int)((60/SEQ)*(i-1));
				lb.Text+=gio+"<"+tm1+" "+va+" "+gio+">"+tm+" => "+gio+"="+tm+"\n";
			}
		}

		private void cmd_ok_Click(object sender, System.EventArgs e)
		{
			st=T_String.IsNullTo0(SEQ_HR.Text).ToString("00")+"-"+T_String.IsNullTo0(ROU_MN.Text).ToString("00");;			
			this.DialogResult=DialogResult.OK;
		}

		private void cmd_close_Click(object sender, System.EventArgs e)
		{
			this.DialogResult=DialogResult.Cancel;
		}

		
		
	}
}
