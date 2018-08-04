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
using GP8000.Function;

namespace GP8000.CardComparison
{
	/// <summary>
	/// Summary description for frmTaComparion.
	/// </summary>
	public class frmTaComparison : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label c1;
		private System.Windows.Forms.ProgressBar pro1;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Panel panel2;
		private C1.Win.C1Input.C1DateEdit dt2;
		private C1.Win.C1Input.C1DateEdit dt1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button cmd_close;
		private System.Windows.Forms.Button cmd_ok;
		private GP8000.UserControl.CrtTaCondition1 control1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox cb;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmTaComparison()
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.c1 = new System.Windows.Forms.Label();
			this.pro1 = new System.Windows.Forms.ProgressBar();
			this.panel5 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.cb = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.dt2 = new C1.Win.C1Input.C1DateEdit();
			this.dt1 = new C1.Win.C1Input.C1DateEdit();
			this.label1 = new System.Windows.Forms.Label();
			this.cmd_close = new System.Windows.Forms.Button();
			this.cmd_ok = new System.Windows.Forms.Button();
			this.control1 = new GP8000.UserControl.CrtTaCondition1();
			this.label2 = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label5 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dt2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dt1)).BeginInit();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.c1);
			this.panel1.Controls.Add(this.pro1);
			this.panel1.Controls.Add(this.panel5);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 36);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(832, 404);
			this.panel1.TabIndex = 18;
			// 
			// c1
			// 
			this.c1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.c1.BackColor = System.Drawing.Color.Black;
			this.c1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.c1.ForeColor = System.Drawing.Color.White;
			this.c1.Location = new System.Drawing.Point(0, 200);
			this.c1.Name = "c1";
			this.c1.Size = new System.Drawing.Size(832, 28);
			this.c1.TabIndex = 8;
			this.c1.Tag = "N";
			this.c1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pro1
			// 
			this.pro1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pro1.Location = new System.Drawing.Point(0, 180);
			this.pro1.Name = "pro1";
			this.pro1.Size = new System.Drawing.Size(832, 16);
			this.pro1.TabIndex = 2;
			// 
			// panel5
			// 
			this.panel5.BackColor = System.Drawing.Color.CornflowerBlue;
			this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel5.Location = new System.Drawing.Point(0, 176);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(832, 4);
			this.panel5.TabIndex = 1;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.cb);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.dt2);
			this.panel2.Controls.Add(this.dt1);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Controls.Add(this.cmd_close);
			this.panel2.Controls.Add(this.cmd_ok);
			this.panel2.Controls.Add(this.control1);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(832, 176);
			this.panel2.TabIndex = 0;
			// 
			// cb
			// 
			this.cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cb.Items.AddRange(new object[] {
													"In1",
													"In2",
													"In3",
													"In4"});
			this.cb.Location = new System.Drawing.Point(536, 72);
			this.cb.Name = "cb";
			this.cb.Size = new System.Drawing.Size(132, 24);
			this.cb.TabIndex = 156;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(452, 76);
			this.label3.Name = "label3";
			this.label3.TabIndex = 155;
			this.label3.Text = "label3";
			// 
			// dt2
			// 
			this.dt2.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat;
			this.dt2.Location = new System.Drawing.Point(536, 44);
			this.dt2.Name = "dt2";
			this.dt2.Size = new System.Drawing.Size(132, 23);
			this.dt2.TabIndex = 150;
			this.dt2.Tag = null;
			// 
			// dt1
			// 
			this.dt1.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat;
			this.dt1.Location = new System.Drawing.Point(536, 16);
			this.dt1.Name = "dt1";
			this.dt1.Size = new System.Drawing.Size(132, 23);
			this.dt1.TabIndex = 149;
			this.dt1.Tag = null;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(452, 20);
			this.label1.Name = "label1";
			this.label1.TabIndex = 1;
			this.label1.Text = "label1";
			// 
			// cmd_close
			// 
			this.cmd_close.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_close.Location = new System.Drawing.Point(688, 108);
			this.cmd_close.Name = "cmd_close";
			this.cmd_close.Size = new System.Drawing.Size(136, 40);
			this.cmd_close.TabIndex = 154;
			this.cmd_close.Text = "button3";
			this.cmd_close.Click += new System.EventHandler(this.cmd_close_Click);
			// 
			// cmd_ok
			// 
			this.cmd_ok.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_ok.Location = new System.Drawing.Point(688, 32);
			this.cmd_ok.Name = "cmd_ok";
			this.cmd_ok.Size = new System.Drawing.Size(136, 40);
			this.cmd_ok.TabIndex = 152;
			this.cmd_ok.Text = "OK";
			this.cmd_ok.Click += new System.EventHandler(this.cmd_ok_Click);
			// 
			// control1
			// 
			this.control1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.control1.Location = new System.Drawing.Point(0, 4);
			this.control1.Name = "control1";
			this.control1.Size = new System.Drawing.Size(444, 164);
			this.control1.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(452, 48);
			this.label2.Name = "label2";
			this.label2.TabIndex = 151;
			this.label2.Text = "label2";
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.panel3.Controls.Add(this.label5);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel3.Location = new System.Drawing.Point(0, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(832, 36);
			this.panel3.TabIndex = 17;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label5.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.label5.Location = new System.Drawing.Point(0, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(832, 36);
			this.label5.TabIndex = 11;
			this.label5.Tag = "";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// frmTaComparison
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
			this.ClientSize = new System.Drawing.Size(832, 440);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel3);
			this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "frmTaComparison";
			this.Text = "frmTaComparison";
			this.Load += new System.EventHandler(this.frmTaComparion_Load);
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dt2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dt1)).EndInit();
			this.panel3.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void frmTaComparion_Load(object sender, System.EventArgs e)
		{
			Basic.Function.PublicFunction.L_Init_Label(this);
			control1.InitCB(this.Tag);
			control1.Initlabel();
			cb.SelectedIndex=0;
			DateTime dt=T_String.GetDate();
			dt2.Value=dt;	
			dt1.Value=dt.AddDays(-1);	
			dt1.CustomFormat=dt2.CustomFormat=PublicFunction.GetOption("DATE");	
		}

		private void cmd_close_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void cmd_ok_Click(object sender, System.EventArgs e)
		{
			Thread th=new Thread(new ThreadStart(Com));
			th.Start();
		}

		private void Com()
		{
			SqlConnection con=new SqlConnection(PublicFunction.C_con.ConnectionString);
			con.Open();
			string dttime=T_String.GetDate().ToString("yyyy/MM/dd HH:mm");
			string f="";
			switch(cb.Text)
			{
				case "In1":
					f="ONN_01";
					break;
				case "In2":
					f="ONN_02";
					break;
				case "In3":
					f="ONN_03";
					break;
				case "In4":
					f="ONN_04";
					break;
			}
			string sql="";
			sql="(Select EMP_ID from FILB01A where "+control1.GetWhere("")+")";
			sql="select EMP_ID,ATT_DT,SHI_ID,ONN_01,ONN_02,ONN_03,ONN_04 from FILC06A where EMP_ID in"+sql+
				" and ATT_DT between '"+ DateTime.Parse(dt1.Value+"").ToString("yyyy/MM/dd")+"' and '"+
				DateTime.Parse(dt2.Value+"").ToString("yyyy/MM/dd")+"'";
			
			Func.RecordSet rs=new Func.RecordSet(sql,con);
			for(int i=0;i<rs.rows;i++)
			{
				c1.Text= rs.record(i,"EMP_ID") + " __ "+ (int)((i+1)*100/rs.rows)+"% __ " + (i+1)+"/"+rs.rows;
				double t=T_String.IsNullTo0(rs.record(i,f));
				if(t>0)
				{
					sql="insert into GSC_FILE01B(ATT_DT,SHI_ID,INN_NO,EMP_ID"
						+",ATT_TM,BLT_NM,BLT_DT) values(";
					sql+="'"+DateTime.Parse(rs.record(i,"ATT_DT")).ToString("yyyy/MM/dd")+"',";
					sql+="N'"+rs.record(i,"SHI_ID")+"',";
					sql+="N'"+cb.Text+"',";
					sql+="N'"+rs.record(i,"EMP_ID")+"',";
					sql+=""+t+",";
					sql+="N'"+PublicFunction.A_UserID+"',";
					sql+="'"+dttime+"')";		
					try
					{
						PublicFunction.SQL_Execute(sql,con);
					}
					catch(SqlException ex)
					{
						if (ex.Number!=2627)
							MessageBox.Show(sql + " \n Execute Sql Error . Number:" + ex.Number + ". Description Error:" + ex.Message  );						
					}
				}
				pro1.Value=(int)((i+1)*100/rs.rows);
			}

			if(PublicFunction.CUS_ID=="7")
			{

				sql="(Select EMP_ID from FILB01A where "+control1.GetWhere("")+")";
				sql="select * from GSC_FILE01C where EMP_ID in"+sql+
					" and ATT_DT between '"+ DateTime.Parse(dt1.Value+"").ToString("yyyy/MM/dd")+"' and '"+
					DateTime.Parse(dt2.Value+"").ToString("yyyy/MM/dd")+"' and INN_NO=N'"+cb.Text+"'";
			
				rs=new Func.RecordSet(sql,con);
				for(int i=0;i<rs.rows;i++)
				{
					c1.Text= rs.record(i,"EMP_ID") + " __ "+ (int)((i+1)*100/rs.rows)+"% __ " + (i+1)+"/"+rs.rows;
					sql="update GSC_FILE01B set WOK_TM="+T_String.IsNullTo0(rs.record(i,"WOK_TM"))
						+" where EMP_ID=N'"+rs.record(i,"EMP_ID")+"' and ATT_DT='"+
						DateTime.Parse(rs.record(i,"ATT_DT")).ToString("yyyy/MM/dd")+"' and SHI_ID=N'"+
						rs.record(i,"SHI_ID")+"' and INN_NO=N'"+cb.Text+"'";
					try
					{
						PublicFunction.SQL_Execute(sql,con);
					}
					catch(SqlException ex)
					{
						if (ex.Number!=2627)
							MessageBox.Show(sql + " \n Execute Sql Error . Number:" + ex.Number + ". Description Error:" + ex.Message  );						
					}
					pro1.Value=(int)((i+1)*100/rs.rows);
				}

			}


			MessageBox.Show(PublicFunction.L_Get_Msg("Staff",1));
			con.Close();
		}
		
			
	}
}
