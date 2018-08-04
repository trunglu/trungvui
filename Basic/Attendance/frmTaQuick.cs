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

namespace GP8000.Attendance
{
	/// <summary>
	/// Summary description for frmTaQuick.
	/// </summary>
	public class frmTaQuick : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.TextBox txt;
		private System.Windows.Forms.RadioButton r1;
		private System.Windows.Forms.RadioButton r2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label1;
		private C1.Win.C1Input.C1DateEdit dt;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox cb;
		private System.Windows.Forms.CheckBox ck;
		private C1.Win.C1FlexGrid.C1FlexGrid vs;
		private System.Windows.Forms.Button cmd_ok;
		private System.Windows.Forms.Button cmd_close;
		private System.Windows.Forms.TextBox day;
		private System.Windows.Forms.TextBox txt_EMP_NM;
		private System.Windows.Forms.Label l;
		private System.Windows.Forms.Button cmd_clear;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmTaQuick()
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
			this.panel4 = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel5 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.cb = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.day = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.dt = new C1.Win.C1Input.C1DateEdit();
			this.label1 = new System.Windows.Forms.Label();
			this.txt = new System.Windows.Forms.TextBox();
			this.r1 = new System.Windows.Forms.RadioButton();
			this.r2 = new System.Windows.Forms.RadioButton();
			this.label4 = new System.Windows.Forms.Label();
			this.ck = new System.Windows.Forms.CheckBox();
			this.vs = new C1.Win.C1FlexGrid.C1FlexGrid();
			this.cmd_ok = new System.Windows.Forms.Button();
			this.cmd_close = new System.Windows.Forms.Button();
			this.txt_EMP_NM = new System.Windows.Forms.TextBox();
			this.l = new System.Windows.Forms.Label();
			this.cmd_clear = new System.Windows.Forms.Button();
			this.panel3.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel5.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dt)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.vs)).BeginInit();
			this.SuspendLayout();
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.panel3.Controls.Add(this.label5);
			this.panel3.Controls.Add(this.panel4);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel3.Location = new System.Drawing.Point(0, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(708, 36);
			this.panel3.TabIndex = 14;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label5.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.label5.Location = new System.Drawing.Point(8, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(700, 36);
			this.label5.TabIndex = 11;
			this.label5.Tag = "";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel4
			// 
			this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel4.Location = new System.Drawing.Point(0, 0);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(8, 36);
			this.panel4.TabIndex = 10;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.panel5);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 36);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(708, 398);
			this.panel1.TabIndex = 15;
			// 
			// panel5
			// 
			this.panel5.Controls.Add(this.vs);
			this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel5.Location = new System.Drawing.Point(232, 0);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(476, 398);
			this.panel5.TabIndex = 1;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.cmd_clear);
			this.panel2.Controls.Add(this.l);
			this.panel2.Controls.Add(this.txt_EMP_NM);
			this.panel2.Controls.Add(this.cmd_close);
			this.panel2.Controls.Add(this.cmd_ok);
			this.panel2.Controls.Add(this.ck);
			this.panel2.Controls.Add(this.cb);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.day);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.dt);
			this.panel2.Controls.Add(this.txt);
			this.panel2.Controls.Add(this.r1);
			this.panel2.Controls.Add(this.r2);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(232, 398);
			this.panel2.TabIndex = 0;
			// 
			// cb
			// 
			this.cb.AllowDrop = true;
			this.cb.Location = new System.Drawing.Point(88, 120);
			this.cb.Name = "cb";
			this.cb.Size = new System.Drawing.Size(120, 24);
			this.cb.TabIndex = 23;
			this.cb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cb_KeyDown);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(8, 124);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(84, 23);
			this.label3.TabIndex = 22;
			this.label3.Text = "label3";
			// 
			// day
			// 
			this.day.Location = new System.Drawing.Point(88, 148);
			this.day.Name = "day";
			this.day.Size = new System.Drawing.Size(120, 23);
			this.day.TabIndex = 19;
			this.day.Text = "";
			this.day.KeyDown += new System.Windows.Forms.KeyEventHandler(this.day_KeyDown);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(8, 152);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(84, 23);
			this.label2.TabIndex = 20;
			this.label2.Text = "label2";
			// 
			// dt
			// 
			this.dt.CustomFormat = "yyyy/MM";
			this.dt.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat;
			this.dt.Location = new System.Drawing.Point(88, 8);
			this.dt.Name = "dt";
			this.dt.Size = new System.Drawing.Size(120, 23);
			this.dt.TabIndex = 18;
			this.dt.Tag = null;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(84, 23);
			this.label1.TabIndex = 17;
			this.label1.Text = "label1";
			// 
			// txt
			// 
			this.txt.Location = new System.Drawing.Point(88, 64);
			this.txt.Name = "txt";
			this.txt.Size = new System.Drawing.Size(120, 23);
			this.txt.TabIndex = 13;
			this.txt.Text = "";
			this.txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
			// 
			// r1
			// 
			this.r1.Checked = true;
			this.r1.Location = new System.Drawing.Point(12, 36);
			this.r1.Name = "r1";
			this.r1.Size = new System.Drawing.Size(84, 24);
			this.r1.TabIndex = 14;
			this.r1.TabStop = true;
			this.r1.Text = "radioButton1";
			this.r1.CheckedChanged += new System.EventHandler(this.r1_CheckedChanged);
			// 
			// r2
			// 
			this.r2.Location = new System.Drawing.Point(100, 36);
			this.r2.Name = "r2";
			this.r2.Size = new System.Drawing.Size(112, 24);
			this.r2.TabIndex = 15;
			this.r2.Text = "radioButton2";
			this.r2.CheckedChanged += new System.EventHandler(this.r1_CheckedChanged);
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(8, 68);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(84, 23);
			this.label4.TabIndex = 16;
			this.label4.Text = "label4";
			// 
			// ck
			// 
			this.ck.Checked = true;
			this.ck.CheckState = System.Windows.Forms.CheckState.Checked;
			this.ck.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.ck.Location = new System.Drawing.Point(212, 124);
			this.ck.Name = "ck";
			this.ck.Size = new System.Drawing.Size(16, 24);
			this.ck.TabIndex = 24;
			this.ck.Tag = "N";
			this.ck.Text = "checkBox1";
			// 
			// vs
			// 
			this.vs.AllowEditing = false;
			this.vs.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.XpThemes;
			this.vs.ColumnInfo = "10,1,0,0,0,100,Columns:0{Width:38;}\t";
			this.vs.Dock = System.Windows.Forms.DockStyle.Fill;
			this.vs.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.vs.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
			this.vs.Location = new System.Drawing.Point(0, 0);
			this.vs.Name = "vs";
			this.vs.Size = new System.Drawing.Size(476, 398);
			this.vs.Styles = ((C1.Win.C1FlexGrid.CellStyleCollection)(new C1.Win.C1FlexGrid.CellStyleCollection("")));
			this.vs.TabIndex = 11;
			// 
			// cmd_ok
			// 
			this.cmd_ok.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_ok.Location = new System.Drawing.Point(54, 180);
			this.cmd_ok.Name = "cmd_ok";
			this.cmd_ok.Size = new System.Drawing.Size(124, 32);
			this.cmd_ok.TabIndex = 25;
			this.cmd_ok.Text = "change";
			this.cmd_ok.Click += new System.EventHandler(this.cmd_ok_Click);
			// 
			// cmd_close
			// 
			this.cmd_close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.cmd_close.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_close.Location = new System.Drawing.Point(54, 268);
			this.cmd_close.Name = "cmd_close";
			this.cmd_close.Size = new System.Drawing.Size(124, 32);
			this.cmd_close.TabIndex = 26;
			this.cmd_close.Text = "button2";
			// 
			// txt_EMP_NM
			// 
			this.txt_EMP_NM.BackColor = System.Drawing.Color.LemonChiffon;
			this.txt_EMP_NM.Location = new System.Drawing.Point(4, 92);
			this.txt_EMP_NM.Name = "txt_EMP_NM";
			this.txt_EMP_NM.ReadOnly = true;
			this.txt_EMP_NM.Size = new System.Drawing.Size(204, 23);
			this.txt_EMP_NM.TabIndex = 27;
			this.txt_EMP_NM.Text = "";
			// 
			// l
			// 
			this.l.BackColor = System.Drawing.SystemColors.Info;
			this.l.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.l.Location = new System.Drawing.Point(0, 302);
			this.l.Name = "l";
			this.l.Size = new System.Drawing.Size(232, 96);
			this.l.TabIndex = 28;
			this.l.Tag = "N";
			this.l.Text = "label6";
			this.l.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// cmd_clear
			// 
			this.cmd_clear.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_clear.Location = new System.Drawing.Point(54, 224);
			this.cmd_clear.Name = "cmd_clear";
			this.cmd_clear.Size = new System.Drawing.Size(124, 32);
			this.cmd_clear.TabIndex = 29;
			this.cmd_clear.Text = "change";
			this.cmd_clear.Click += new System.EventHandler(this.cmd_clear_Click);
			// 
			// frmTaQuick
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
			this.ClientSize = new System.Drawing.Size(708, 434);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel3);
			this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmTaQuick";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmTaQuick";
			this.Load += new System.EventHandler(this.frmTaQuick_Load);
			this.panel3.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel5.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dt)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.vs)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void frmTaQuick_Load(object sender, System.EventArgs e)
		{	
			Init_vs();

			Basic.Function.PublicFunction.L_Init_Label(this);
			string sql="Select SHI_ID from FILC02A";
			Func.RecordSet rs=new Func.RecordSet(sql,PublicFunction.C_con);
			for(int i=0;i<rs.rows;i++)
			{
				cb.Items.Add(rs.record(i,0));
				
			}			
			dt.Value=T_String.GetDate();
		}

		private void Init_vs()
		{
			vs.Cols.Count=7;
			vs.Cols[1].Name="EMP_ID";
			vs.Cols[2].Name="EMP_I1";
			vs.Cols[3].Name="EMP_NM";
			vs.Cols[4].Name="DEP_ID";
			vs.Cols[5].Name="DT";
			vs.Cols[6].Name="SHI_ID";
			vs.Rows.Count=1;
			string sql=PublicFunction.GetDep(this.Tag+"");			
			vs.Cols["DEP_ID"].DataMap=PublicFunction.InitCBForVS(sql);	
		}

		string EMP_ID,EMP_I1,EMP_NM,DEP_ID;
		private void txt_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyCode==Keys.Enter)
			{
				string sql="select EMP_ID,EMP_I1,EMP_NM,DEP_ID from FILB01A where ";
				if(r1.Checked)
					sql+="EMP_ID=N'"+txt.Text+"'";
				else
					sql+="EMP_I1=N'"+txt.Text+"'";
				sql+=" and DEP_ID  in (Select DEP_ID  from SYS_SECURITY_DEP"+
					" where MNU_ID="+this.Tag+" and ALL_BT=1  and USER_ID=N'"+PublicFunction.A_UserID+"')";
				Func.RecordSet rs=new Func.RecordSet(sql,PublicFunction.C_con);
				if(rs.rows<0)
				{
					MessageBox.Show(PublicFunction.L_Get_Msg("msg",76));
					EMP_ID=EMP_I1=EMP_NM=DEP_ID="";
					txt_EMP_NM.Text="";
					txt.Focus();
				}
				EMP_ID=rs.record(0,"EMP_ID");
				EMP_I1=rs.record(0,"EMP_I1");
				EMP_NM=rs.record(0,"EMP_NM");
				DEP_ID=rs.record(0,"DEP_ID");
				txt_EMP_NM.Text=EMP_NM;
				if(ck.Checked)
					day.Focus();
				else
					cb.Focus();
			}
		}

		private void r1_CheckedChanged(object sender, System.EventArgs e)
		{
			label4.Text=r1.Text;
			if(r2.Checked)
				label4.Text=r2.Text;
		}

		private void cb_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyCode==Keys.Enter)
			{
				day.Focus();
			}
		
		}

		private void day_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyCode==Keys.Enter)
			{
				change();
			}

		}

		private void cmd_ok_Click(object sender, System.EventArgs e)
		{
			change();
		}

		private void change()
		{
			string YYY_MM=DateTime.Parse(dt.Value+"").ToString("yyyyMM");
			int d=T_String.IsNullTo0(day.Text);
			if(d<=0 || d>31)
			{
				l.Text=PublicFunction.L_Get_Msg("msg",89);
				day.Focus();
				return;
			}
			else
			{
				int c=T_String.GetMax("Count(*)","FILC03A","EMP_ID=N'"+EMP_ID+"' and YYY_MM=N'"+YYY_MM+"'");
				if(c<=1)
				{
					string st="";
					st=label4+": " + txt.Text+" - "+EMP_NM +" \n ";
					st=label1+": " + YYY_MM +" \n ";
					st=PublicFunction.L_Get_Msg("msg",87);
					l.Text=st;
				}
				else
				{
					string sql="";
					sql="update FILC03A set DAY_"+d.ToString("00")+"=N'"+cb.Text+"' where EMP_ID=N'"
						+EMP_ID+"' and YYY_MM=N'"+YYY_MM+"'";
					PublicFunction.SQL_Execute(sql);
					vs.Rows.Count++;
					int r=vs.Rows.Count-1;
					vs.Rows[r][0]=r;
					vs.Rows[r]["EMP_ID"]=EMP_ID;
					vs.Rows[r]["EMP_I1"]=EMP_I1;
					vs.Rows[r]["EMP_NM"]=EMP_NM;
					vs.Rows[r]["DEP_ID"]=DEP_ID;
					vs.Rows[r]["DT"]=DateTime.Parse(dt.Value+"").ToString("yyyy/MM")+"/"+d.ToString("00");
					vs.Rows[r]["SHI_ID"]=cb.Text;
					vs.AutoSizeCols();
					

					string st="";
					st=label4+": " + txt.Text+" - "+EMP_NM +" \n ";
					st=label1+": " + YYY_MM +" \n ";
					st=PublicFunction.L_Get_Msg("Staff",1);
					l.Text=st;
				}
			}

			EMP_ID=EMP_I1=EMP_NM=DEP_ID="";
			txt.Text="";
			txt_EMP_NM.Text="";
			day.Text="";
			txt.Focus();
		}

		private void cmd_clear_Click(object sender, System.EventArgs e)
		{
			vs.Rows.Count=1;
		}
	}
}
