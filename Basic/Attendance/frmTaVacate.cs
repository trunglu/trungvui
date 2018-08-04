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
	/// Summary description for frmTaVacate.
	/// </summary>
	public class frmTaVacate : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox txt_note;
		private C1.Win.C1Input.C1DateEdit dt;
		private System.Windows.Forms.ComboBox cb;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button cmd_ok;
		private System.Windows.Forms.Button cmd_can;
		public System.Windows.Forms.TextBox EMP_ID;
		public System.Windows.Forms.TextBox DEP_ID;
		public System.Windows.Forms.TextBox EMP_NM;
		public System.Windows.Forms.TextBox POS_ID;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmTaVacate()
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
			this.EMP_ID = new System.Windows.Forms.TextBox();
			this.DEP_ID = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.EMP_NM = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.POS_ID = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.txt_note = new System.Windows.Forms.TextBox();
			this.dt = new C1.Win.C1Input.C1DateEdit();
			this.cb = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.cmd_ok = new System.Windows.Forms.Button();
			this.cmd_can = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dt)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 12);
			this.label1.Name = "label1";
			this.label1.TabIndex = 0;
			this.label1.Text = "label1";
			// 
			// EMP_ID
			// 
			this.EMP_ID.Location = new System.Drawing.Point(108, 8);
			this.EMP_ID.Name = "EMP_ID";
			this.EMP_ID.ReadOnly = true;
			this.EMP_ID.Size = new System.Drawing.Size(168, 23);
			this.EMP_ID.TabIndex = 1;
			this.EMP_ID.Text = "";
			// 
			// DEP_ID
			// 
			this.DEP_ID.Location = new System.Drawing.Point(380, 36);
			this.DEP_ID.Name = "DEP_ID";
			this.DEP_ID.ReadOnly = true;
			this.DEP_ID.Size = new System.Drawing.Size(168, 23);
			this.DEP_ID.TabIndex = 3;
			this.DEP_ID.Text = "";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(12, 40);
			this.label2.Name = "label2";
			this.label2.TabIndex = 2;
			this.label2.Text = "label2";
			// 
			// EMP_NM
			// 
			this.EMP_NM.Location = new System.Drawing.Point(108, 36);
			this.EMP_NM.Name = "EMP_NM";
			this.EMP_NM.ReadOnly = true;
			this.EMP_NM.Size = new System.Drawing.Size(168, 23);
			this.EMP_NM.TabIndex = 5;
			this.EMP_NM.Text = "";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(280, 12);
			this.label3.Name = "label3";
			this.label3.TabIndex = 4;
			this.label3.Text = "label3";
			// 
			// POS_ID
			// 
			this.POS_ID.Location = new System.Drawing.Point(380, 8);
			this.POS_ID.Name = "POS_ID";
			this.POS_ID.ReadOnly = true;
			this.POS_ID.Size = new System.Drawing.Size(168, 23);
			this.POS_ID.TabIndex = 7;
			this.POS_ID.Text = "";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(280, 40);
			this.label4.Name = "label4";
			this.label4.TabIndex = 6;
			this.label4.Text = "label4";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Moccasin;
			this.panel1.Controls.Add(this.EMP_NM);
			this.panel1.Controls.Add(this.EMP_ID);
			this.panel1.Controls.Add(this.DEP_ID);
			this.panel1.Controls.Add(this.POS_ID);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(560, 68);
			this.panel1.TabIndex = 8;
			// 
			// txt_note
			// 
			this.txt_note.BackColor = System.Drawing.SystemColors.Window;
			this.txt_note.Location = new System.Drawing.Point(108, 104);
			this.txt_note.MaxLength = 100;
			this.txt_note.Multiline = true;
			this.txt_note.Name = "txt_note";
			this.txt_note.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txt_note.Size = new System.Drawing.Size(440, 52);
			this.txt_note.TabIndex = 140;
			this.txt_note.Tag = "";
			this.txt_note.Text = "";
			// 
			// dt
			// 
			this.dt.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat;
			this.dt.Location = new System.Drawing.Point(380, 72);
			this.dt.Name = "dt";
			this.dt.Size = new System.Drawing.Size(168, 23);
			this.dt.TabIndex = 138;
			this.dt.Tag = null;
			// 
			// cb
			// 
			this.cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cb.Location = new System.Drawing.Point(108, 72);
			this.cb.Name = "cb";
			this.cb.Size = new System.Drawing.Size(168, 24);
			this.cb.TabIndex = 136;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(12, 80);
			this.label5.Name = "label5";
			this.label5.TabIndex = 141;
			this.label5.Text = "label5";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(280, 80);
			this.label6.Name = "label6";
			this.label6.TabIndex = 142;
			this.label6.Text = "label6";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(12, 104);
			this.label7.Name = "label7";
			this.label7.TabIndex = 143;
			this.label7.Text = "label7";
			// 
			// cmd_ok
			// 
			this.cmd_ok.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_ok.Location = new System.Drawing.Point(114, 164);
			this.cmd_ok.Name = "cmd_ok";
			this.cmd_ok.Size = new System.Drawing.Size(108, 32);
			this.cmd_ok.TabIndex = 144;
			this.cmd_ok.Text = "Vacate";
			this.cmd_ok.Click += new System.EventHandler(this.cmd_ok_Click);
			// 
			// cmd_can
			// 
			this.cmd_can.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.cmd_can.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_can.Location = new System.Drawing.Point(338, 164);
			this.cmd_can.Name = "cmd_can";
			this.cmd_can.Size = new System.Drawing.Size(108, 32);
			this.cmd_can.TabIndex = 145;
			this.cmd_can.Text = "Cancel";
			// 
			// frmTaVacate
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
			this.ClientSize = new System.Drawing.Size(560, 204);
			this.Controls.Add(this.cmd_can);
			this.Controls.Add(this.cmd_ok);
			this.Controls.Add(this.txt_note);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.dt);
			this.Controls.Add(this.cb);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label6);
			this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmTaVacate";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmTaVacate";
			this.Load += new System.EventHandler(this.frmTaVacate_Load);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dt)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void frmTaVacate_Load(object sender, System.EventArgs e)
		{
			//Vacate
			string sql="Select VAC_ID,VAC_NM from FILA06A";						
			PublicFunction.InitCB(cb,sql);
			cb.SelectedValue="002";
			Basic.Function.PublicFunction.L_Init_Label(this);
			dt.CustomFormat=PublicFunction.GetOption("DATE");
			dt.Value=T_String.GetDate();			
		}

		private void cmd_ok_Click(object sender, System.EventArgs e)
		{
			if(cb.SelectedValue+""=="")
			{
				MessageBox.Show(PublicFunction.L_Get_Msg("POS",10));
				return;
			}				
			if(MessageBox.Show(this,PublicFunction.L_Get_Msg("msg",13),this.Text,MessageBoxButtons.YesNo)==DialogResult.Yes)
			{				
				SqlConnection con=new SqlConnection(PublicFunction.C_con.ConnectionString);
				con.Open();				
				
				SqlTransaction tran=con.BeginTransaction();				
				try
				{
					string sql="";												
					sql="Insert Into FILB01AC(EMP_ID,VAC_ID,VAC_DT,NOT_DR,BLT_NM,BLT_DT,VAT_BT)  values("
						+"N'"+EMP_ID.Text+"',"
						+"N'"+cb.SelectedValue+"',"
						+"'"+((DateTime)dt.Value).ToString("yyyy/MM/dd")+"',"
						+"N'"+txt_note.Text+"',N'"+PublicFunction.A_UserID+"','"+T_String.GetDate().ToString("yyyy/MM/dd HH:mm")+"',";
					if( T_String.IsNullTo0(T_String.GetDate().ToString("yyyyMMdd"))>= T_String.IsNullTo0(((DateTime)dt.Value).ToString("yyyyMMdd")))						
						sql+="0)";
					else
						sql+="1)";
					SqlCommand cmd=new SqlCommand(sql,con,tran);
					cmd.ExecuteNonQuery();		
					
					if( T_String.IsNullTo0(T_String.GetDate().ToString("yyyyMMdd"))>= T_String.IsNullTo0(((DateTime)dt.Value).ToString("yyyyMMdd")))
					{
						sql="Update FILB01A set VAC_BT=1,CRD_NO='' where EMP_ID=N'"+EMP_ID.Text+"'";
						cmd=new SqlCommand(sql,con,tran);
						cmd.ExecuteNonQuery();						
					}
					tran.Commit();																	
				}				
				catch(Exception ex)
				{
					tran.Rollback();
					MessageBox.Show(ex.Message);
					return;
				}									
				MessageBox.Show(PublicFunction.L_Get_Msg("Staff",1));
				con.Close();	
				DialogResult=DialogResult.OK;
			}
		}
	}
}
