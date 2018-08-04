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


namespace GP8000.Payroll
{
	/// <summary>
	/// Summary description for frmTaCardDataSwitch.
	/// </summary>
	public class frmTaNotesSlipCal : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Button cmd_att;
		private GP8000.UserControl.CrtTaCondition1 control1;
		private System.Windows.Forms.Button cmd_close;
		private SqlConnection con1;
		private System.Windows.Forms.ProgressBar pro1;
		private System.Windows.Forms.Label c1;
		private C1.Win.C1Input.C1DateEdit dt3;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel p1;	
		private Func.RecordSet rsm,rsr;
		private System.Windows.Forms.ComboBox cb;
		private System.Windows.Forms.ComboBox cb1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmTaNotesSlipCal()
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.c1 = new System.Windows.Forms.Label();
			this.pro1 = new System.Windows.Forms.ProgressBar();
			this.panel5 = new System.Windows.Forms.Panel();
			this.p1 = new System.Windows.Forms.Panel();
			this.cb1 = new System.Windows.Forms.ComboBox();
			this.cb = new System.Windows.Forms.ComboBox();
			this.dt3 = new C1.Win.C1Input.C1DateEdit();
			this.label6 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.control1 = new GP8000.UserControl.CrtTaCondition1();
			this.cmd_att = new System.Windows.Forms.Button();
			this.cmd_close = new System.Windows.Forms.Button();
			this.panel3.SuspendLayout();
			this.panel1.SuspendLayout();
			this.p1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dt3)).BeginInit();
			this.SuspendLayout();
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.panel3.Controls.Add(this.label5);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel3.Location = new System.Drawing.Point(0, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(692, 36);
			this.panel3.TabIndex = 13;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label5.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.label5.Location = new System.Drawing.Point(0, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(692, 36);
			this.label5.TabIndex = 11;
			this.label5.Tag = "";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.c1);
			this.panel1.Controls.Add(this.pro1);
			this.panel1.Controls.Add(this.panel5);
			this.panel1.Controls.Add(this.p1);
			this.panel1.Controls.Add(this.cmd_att);
			this.panel1.Controls.Add(this.cmd_close);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 36);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(692, 280);
			this.panel1.TabIndex = 14;
			// 
			// c1
			// 
			this.c1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.c1.BackColor = System.Drawing.Color.Black;
			this.c1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.c1.ForeColor = System.Drawing.Color.White;
			this.c1.Location = new System.Drawing.Point(4, 196);
			this.c1.Name = "c1";
			this.c1.Size = new System.Drawing.Size(684, 32);
			this.c1.TabIndex = 8;
			this.c1.Tag = "N";
			this.c1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pro1
			// 
			this.pro1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pro1.Location = new System.Drawing.Point(4, 176);
			this.pro1.Name = "pro1";
			this.pro1.Size = new System.Drawing.Size(684, 20);
			this.pro1.TabIndex = 2;
			// 
			// panel5
			// 
			this.panel5.BackColor = System.Drawing.Color.CornflowerBlue;
			this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel5.Location = new System.Drawing.Point(0, 168);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(692, 4);
			this.panel5.TabIndex = 1;
			// 
			// p1
			// 
			this.p1.Controls.Add(this.cb1);
			this.p1.Controls.Add(this.cb);
			this.p1.Controls.Add(this.dt3);
			this.p1.Controls.Add(this.label6);
			this.p1.Controls.Add(this.label1);
			this.p1.Controls.Add(this.label2);
			this.p1.Controls.Add(this.control1);
			this.p1.Dock = System.Windows.Forms.DockStyle.Top;
			this.p1.Location = new System.Drawing.Point(0, 0);
			this.p1.Name = "p1";
			this.p1.Size = new System.Drawing.Size(692, 168);
			this.p1.TabIndex = 0;
			// 
			// cb1
			// 
			this.cb1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cb1.Location = new System.Drawing.Point(532, 72);
			this.cb1.Name = "cb1";
			this.cb1.Size = new System.Drawing.Size(152, 24);
			this.cb1.TabIndex = 170;
			// 
			// cb
			// 
			this.cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cb.Location = new System.Drawing.Point(532, 44);
			this.cb.Name = "cb";
			this.cb.Size = new System.Drawing.Size(152, 24);
			this.cb.TabIndex = 169;
			// 
			// dt3
			// 
			this.dt3.CustomFormat = "yyyyMM";
			this.dt3.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat;
			this.dt3.Location = new System.Drawing.Point(532, 16);
			this.dt3.Name = "dt3";
			this.dt3.Size = new System.Drawing.Size(152, 23);
			this.dt3.TabIndex = 167;
			this.dt3.Tag = null;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(448, 76);
			this.label6.Name = "label6";
			this.label6.TabIndex = 168;
			this.label6.Text = "label6";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(448, 20);
			this.label1.Name = "label1";
			this.label1.TabIndex = 161;
			this.label1.Text = "label1";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(448, 48);
			this.label2.Name = "label2";
			this.label2.TabIndex = 164;
			this.label2.Text = "label2";
			// 
			// control1
			// 
			this.control1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.control1.Location = new System.Drawing.Point(0, 4);
			this.control1.Name = "control1";
			this.control1.Size = new System.Drawing.Size(444, 164);
			this.control1.TabIndex = 0;
			// 
			// cmd_att
			// 
			this.cmd_att.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_att.Location = new System.Drawing.Point(160, 236);
			this.cmd_att.Name = "cmd_att";
			this.cmd_att.Size = new System.Drawing.Size(136, 40);
			this.cmd_att.TabIndex = 152;
			this.cmd_att.Text = "cal";
			this.cmd_att.Click += new System.EventHandler(this.cmd_att_Click);
			// 
			// cmd_close
			// 
			this.cmd_close.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_close.Location = new System.Drawing.Point(396, 236);
			this.cmd_close.Name = "cmd_close";
			this.cmd_close.Size = new System.Drawing.Size(136, 40);
			this.cmd_close.TabIndex = 154;
			this.cmd_close.Text = "button3";
			this.cmd_close.Click += new System.EventHandler(this.cmd_close_Click);
			// 
			// frmTaNotesSlipCal
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
			this.ClientSize = new System.Drawing.Size(692, 316);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel3);
			this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmTaNotesSlipCal";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmTaNotesSlipCal";
			this.Load += new System.EventHandler(this.frmTaCardDataSwitch_Load);
			this.panel3.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.p1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dt3)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void frmTaCardDataSwitch_Load(object sender, System.EventArgs e)
		{			
			Basic.Function.PublicFunction.L_Init_Label(this);
			control1.InitCB(this.Tag);
			control1.Initlabel();
			dt3.Value=T_String.GetDate();	

			string sql="Select [ID] as SEQ_NO,"+PublicFunction.L_Lag+" from SYS_LABEL where [NAME]=N'frmTaNotesSlip_Type'";
			PublicFunction.InitCB(cb,sql,false);

			sql="Select COL_NM,COL_"+PublicFunction.L_Lag+" from FILD01A ";
			PublicFunction.InitCB(cb1,sql,false);
		}	

		private void cmd_close_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void cmd_att_Click(object sender, System.EventArgs e)
		{
			Thread th=new Thread(new ThreadStart(Transfer));
			th.Start();
		}
		#region Transfer
		private void Transfer()
		{		
			p1.Enabled=false;
			con1=new SqlConnection(PublicFunction.C_con.ConnectionString);
			if(con1.State==ConnectionState.Closed )
				con1.Open();
			string sql="",dt=T_String.GetDate().ToString("yyyy/MM/dd HH:mm"),cot=cb1.SelectedValue+"";
			sql="Delete from FILD06A";
			PublicFunction.SQL_Execute(sql,con1);
			sql="Select * from FILD05A order by MON_QT desc"	;
			rsm=new Func.RecordSet(sql,con1);
			sql="Select * from FILD07A"	;
			rsr=new Func.RecordSet(sql,con1);
			sql="Select Distinct a.EMP_ID,EMP_NM,"+cot +" from FILD02A a Left JOIN FILB01A b on a.EMP_ID=b.EMP_ID and YYY_MM=N'"
				+dt3.Text+"' and a.SEQ_NO="+cb.SelectedValue+" where "+control1.GetWhere("b",false)+"  and  "+PublicFunction.Get_TYP(this.Tag,"");	
			Func.RecordSet rs=new Func.RecordSet(sql,con1);
			for(int i=0;i<rs.rows;i++)
			{
                string EMP_ID=rs.record(i,"EMP_ID");
				double tien=T_String.IsNullTo00(rs.record(i,cot)+"");
				c1.Text	=EMP_ID+"-*-"+rs.record(i,"EMP_NM")+" ___ "+ i+"/"+rs.rows;
				//sql="Delete from FILD06A where EMP_ID=N'"+EMP_ID+"' and YYY_MM=N'"+dt3.Text+"' and SEQ_NO="+cb.SelectedValue;
				//PublicFunction.SQL_Execute(sql,con1);
				Double AMT_Q1=Round(tien); 
				sql="insert into FILD06A(EMP_ID,YYY_MM,SEQ_NO,COL_NM,AMT_QT,AMT_Q1,BLT_NM,BLT_DT) values(";
				sql+="N'"+EMP_ID+"',N'"+dt3.Text+"',"+cb.SelectedValue+",N'"+cot+"',"+tien+","+AMT_Q1+",N'"+
					PublicFunction.A_UserID+"','"+dt+"')";
				PublicFunction.SQL_Execute(sql,con1);
				sql="Update FILD02A set ["+cot +"]="+T_String.IsNullTo00(AMT_Q1+"")+", ROU_NM=N'"+
					PublicFunction.A_UserID+"',ROU_DT='"+dt+"' where EMP_ID=N'"+EMP_ID+"'";
				PublicFunction.SQL_Execute(sql,con1);
				cal(EMP_ID,dt3.Text,cb.SelectedValue+"",AMT_Q1,con1);
				pro1.Value=(int)i*100/rs.rows;
			}			
			pro1.Value=100;
			con1.Close();
			p1.Enabled=true;
		}	

		private Double Round(Double QT)
		{
			int v=(int)QT;			
			int max=T_String.IsNullTo0(rsr.record(rsr.rows-1,"TOO_QT"));
			if(max<=0)
				return QT;
			int v1=v%max;
			v=v-v1;			
			for(int i=0;i<rsr.rows;i++)
			{
				int m1=T_String.IsNullTo0(rsr.record(i,"FRM_QT"));
				int m2=T_String.IsNullTo0(rsr.record(i,"TOO_QT"));
				int vl=T_String.IsNullTo0(rsr.record(i,"VAL_QT"));
				if(v1>=m1 && v1<=m2)
					return (int)(v+vl);
			}
			return QT;
		}

		private void cal(string EMP_ID,string YYY_MM,string SEQ_NO,double AMT_QT,SqlConnection con)
		{
			double tien=AMT_QT;
			string sql="";
			for(int i=0;i<rsm.rows;i++)
			{
				int MON_QT=T_String.IsNullTo0(rsm.record(i,"MON_QT"));
				if(MON_QT<=0)
					break;
				int m=(int)(tien/MON_QT);
				tien=tien-(m*MON_QT);
				if(sql!="") sql+=",";
				sql+=rsm.record(i,"COL_NO")+"="+m;
			}
			if (sql=="") return;
			sql="Update FILD06A set "+sql+" where EMP_ID=N'"+EMP_ID+"' and YYY_MM=N'"+YYY_MM+"' and SEQ_NO="+SEQ_NO;
			try
			{
				PublicFunction.SQL_Execute(sql,con);
			}
			catch(SqlException ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		
		
		#endregion	
	
	}
}
