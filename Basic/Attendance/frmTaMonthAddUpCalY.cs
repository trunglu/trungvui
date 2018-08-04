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


namespace GP8000.Attendance
{
	/// <summary>
	/// Summary description for frmTaCardDataSwitch.
	/// </summary>
	public class frmTaMonthAddUpCal : System.Windows.Forms.Form
	{
		private string FILC06A, FILC06AA, FILC07A;

		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label1;
		private C1.Win.C1Input.C1DateEdit dt2;
		private C1.Win.C1Input.C1DateEdit dt1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel panel5;
		private GP8000.UserControl.CrtTaCondition1 control1;
		private System.Windows.Forms.Button cmd_close;		
		private System.Windows.Forms.ProgressBar pro1;
		private System.Windows.Forms.ProgressBar pro2;
		private System.Windows.Forms.Label c1;	
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button cmd_mon;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox cb;
		private C1.Win.C1Input.C1DateEdit dt3;
		private System.Windows.Forms.Label label6;		
		Func.RecordSet LEA;
		private Boolean Stop;
		private System.Windows.Forms.Button cmd_stop;
		private System.Windows.Forms.Panel panel4;		
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmTaMonthAddUpCal()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			if (PublicFunction.GPS)
			{
				FILC06A = "FILC06AS";
				FILC06AA = "FILC06AAS";
				FILC07A = "FILC07AS";
			}
			else
			{
				FILC06A = "FILC06A";
				FILC06AA = "FILC06AA";
				FILC07A = "FILC07A";
			}
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
			this.cmd_stop = new System.Windows.Forms.Button();
			this.c1 = new System.Windows.Forms.Label();
			this.pro2 = new System.Windows.Forms.ProgressBar();
			this.pro1 = new System.Windows.Forms.ProgressBar();
			this.panel5 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.dt3 = new C1.Win.C1Input.C1DateEdit();
			this.label6 = new System.Windows.Forms.Label();
			this.cb = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.dt2 = new C1.Win.C1Input.C1DateEdit();
			this.dt1 = new C1.Win.C1Input.C1DateEdit();
			this.label1 = new System.Windows.Forms.Label();
			this.cmd_close = new System.Windows.Forms.Button();
			this.cmd_mon = new System.Windows.Forms.Button();
			this.control1 = new GP8000.UserControl.CrtTaCondition1();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.panel4 = new System.Windows.Forms.Panel();
			this.panel3.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dt3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dt2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dt1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.panel3.Controls.Add(this.label5);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel3.Location = new System.Drawing.Point(0, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(840, 36);
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
			this.label5.Size = new System.Drawing.Size(840, 36);
			this.label5.TabIndex = 11;
			this.label5.Tag = "";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.cmd_stop);
			this.panel1.Controls.Add(this.c1);
			this.panel1.Controls.Add(this.pro2);
			this.panel1.Controls.Add(this.pro1);
			this.panel1.Controls.Add(this.panel5);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 36);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(840, 312);
			this.panel1.TabIndex = 14;
			// 
			// cmd_stop
			// 
			this.cmd_stop.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_stop.Location = new System.Drawing.Point(352, 260);
			this.cmd_stop.Name = "cmd_stop";
			this.cmd_stop.Size = new System.Drawing.Size(136, 40);
			this.cmd_stop.TabIndex = 155;
			this.cmd_stop.Text = "Stop";
			this.cmd_stop.Click += new System.EventHandler(this.cmd_stop_Click);
			// 
			// c1
			// 
			this.c1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.c1.BackColor = System.Drawing.Color.Black;
			this.c1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.c1.ForeColor = System.Drawing.Color.White;
			this.c1.Location = new System.Drawing.Point(0, 220);
			this.c1.Name = "c1";
			this.c1.Size = new System.Drawing.Size(840, 28);
			this.c1.TabIndex = 8;
			this.c1.Tag = "N";
			this.c1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pro2
			// 
			this.pro2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pro2.Location = new System.Drawing.Point(0, 200);
			this.pro2.Name = "pro2";
			this.pro2.Size = new System.Drawing.Size(840, 16);
			this.pro2.TabIndex = 3;
			// 
			// pro1
			// 
			this.pro1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pro1.Location = new System.Drawing.Point(0, 180);
			this.pro1.Name = "pro1";
			this.pro1.Size = new System.Drawing.Size(840, 16);
			this.pro1.TabIndex = 2;
			// 
			// panel5
			// 
			this.panel5.BackColor = System.Drawing.Color.CornflowerBlue;
			this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel5.Location = new System.Drawing.Point(0, 176);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(840, 4);
			this.panel5.TabIndex = 1;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.dt3);
			this.panel2.Controls.Add(this.label6);
			this.panel2.Controls.Add(this.cb);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Controls.Add(this.dt2);
			this.panel2.Controls.Add(this.dt1);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Controls.Add(this.cmd_close);
			this.panel2.Controls.Add(this.cmd_mon);
			this.panel2.Controls.Add(this.control1);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.panel4);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(840, 176);
			this.panel2.TabIndex = 0;
			// 
			// dt3
			// 
			this.dt3.CustomFormat = "yyyyMM";
			this.dt3.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat;
			this.dt3.Location = new System.Drawing.Point(536, 68);
			this.dt3.Name = "dt3";
			this.dt3.Size = new System.Drawing.Size(132, 23);
			this.dt3.TabIndex = 159;
			this.dt3.Tag = null;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(452, 72);
			this.label6.Name = "label6";
			this.label6.TabIndex = 160;
			this.label6.Text = "label6";
			// 
			// cb
			// 
			this.cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cb.Location = new System.Drawing.Point(536, 96);
			this.cb.Name = "cb";
			this.cb.Size = new System.Drawing.Size(132, 24);
			this.cb.TabIndex = 158;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(452, 100);
			this.label4.Name = "label4";
			this.label4.TabIndex = 157;
			this.label4.Text = "label4";
			// 
			// dt2
			// 
			this.dt2.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat;
			this.dt2.Location = new System.Drawing.Point(536, 40);
			this.dt2.Name = "dt2";
			this.dt2.Size = new System.Drawing.Size(132, 23);
			this.dt2.TabIndex = 150;
			this.dt2.Tag = null;
			this.dt2.TextChanged += new System.EventHandler(this.dt2_TextChanged);
			this.dt2.Leave += new System.EventHandler(this.dt2_Leave);
			// 
			// dt1
			// 
			this.dt1.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat;
			this.dt1.Location = new System.Drawing.Point(536, 12);
			this.dt1.Name = "dt1";
			this.dt1.Size = new System.Drawing.Size(132, 23);
			this.dt1.TabIndex = 149;
			this.dt1.Tag = null;
			this.dt1.TextChanged += new System.EventHandler(this.dt1_TextChanged);
			this.dt1.Leave += new System.EventHandler(this.dt2_Leave);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(452, 16);
			this.label1.Name = "label1";
			this.label1.TabIndex = 1;
			this.label1.Text = "label1";
			// 
			// cmd_close
			// 
			this.cmd_close.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_close.Location = new System.Drawing.Point(692, 104);
			this.cmd_close.Name = "cmd_close";
			this.cmd_close.Size = new System.Drawing.Size(136, 40);
			this.cmd_close.TabIndex = 154;
			this.cmd_close.Text = "Close";
			this.cmd_close.Click += new System.EventHandler(this.cmd_close_Click);
			// 
			// cmd_mon
			// 
			this.cmd_mon.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_mon.Location = new System.Drawing.Point(692, 28);
			this.cmd_mon.Name = "cmd_mon";
			this.cmd_mon.Size = new System.Drawing.Size(136, 40);
			this.cmd_mon.TabIndex = 152;
			this.cmd_mon.Text = "Month Add Up";
			this.cmd_mon.Click += new System.EventHandler(this.cmd_mon_Click);
			// 
			// control1
			// 
			this.control1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.control1.Location = new System.Drawing.Point(0, 4);
			this.control1.Name = "control1";
			this.control1.Size = new System.Drawing.Size(444, 164);
			this.control1.TabIndex = 0;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.SystemColors.Control;
			this.label3.Location = new System.Drawing.Point(712, 88);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(32, 23);
			this.label3.TabIndex = 156;
			this.label3.Tag = "N";
			this.label3.Text = "->>";
			this.label3.Visible = false;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(452, 44);
			this.label2.Name = "label2";
			this.label2.TabIndex = 151;
			this.label2.Text = "label2";
			// 
			// panel4
			// 
			this.panel4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.panel4.Location = new System.Drawing.Point(448, 4);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(232, 164);
			this.panel4.TabIndex = 162;
			// 
			// frmTaMonthAddUpCal
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
			this.ClientSize = new System.Drawing.Size(840, 348);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel3);
			this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "frmTaMonthAddUpCal";
			this.Text = "frmTaMonthAddUpCal";
			this.Load += new System.EventHandler(this.frmTaCardDataSwitch_Load);
			this.panel3.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dt3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dt2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dt1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void frmTaCardDataSwitch_Load(object sender, System.EventArgs e)
		{			
			Basic.Function.PublicFunction.L_Init_Label(this);
			control1.InitCB(this.Tag);
			control1.Initlabel();
//			dt3.Value=dt2.Value=dt1.Value=T_String.GetDate();
			int day=T_String.IsNullTo0(PublicFunction.GetOption("DAYCLOSE")+"");
			if (day<=0) day=1;

			dt1.Value = DateTime.Parse((day < 15 ? T_String.GetDate().ToString("yyyy/MM") : T_String.GetDate().AddMonths(-1).ToString("yyyy/MM")) + "/" + day);
			dt2.Value = ((DateTime)dt1.Value).AddMonths(1).AddDays(-1);
			dt3.Value = dt2.Value;
			dt1.CustomFormat=dt2.CustomFormat=PublicFunction.GetOption("DATE");

			string sql="Select FNAME,"+PublicFunction.L_Lag+" from  SYS_LABEL where [NAME]=N'frmTaMonthAddUpCal' and (FName='1' or FName='2')";
			PublicFunction.InitCB(cb,sql,false);
			CheckFieldName();
			this.Closed+=new EventHandler(frmTaMonthAddUpCal_Closed);
			cmd_stop.Visible=false;
			cb.SelectedValue=2;
		}

		private void CheckFieldName()
		{
			string sql, frmMonth = "frmTaMonthAddUp000_vs";
			
			if (PublicFunction.GPS) frmMonth = "frmTaMonthAddUp001_vs";
			LEA =new Func.RecordSet("Select * from FILA15A",PublicFunction.C_con);
			for(int i=0;i<LEA.rows;i++)
			{
				if (!Func.Fun.CheckFieldOfTable(PublicFunction.C_con, FILC06AA,"LEA_"+LEA.record(i,"LEA_ID")))
				{					
					sql="Alter table " + FILC06AA  + " Add ["+"LEA_"+ LEA.record(i,"LEA_ID")+"] float";
					PublicFunction.SQL_Execute(sql);

					sql=T_String.IsNullTo0(T_String.GetDataFromSQL("MAX([ID])","SYS_LABEL_VS_ATT","[NAME]="+
						"N'" + frmMonth + "'"))+1+"";
					sql="Insert Into SYS_LABEL_VS_ATT values("+
						"N'" + frmMonth + "',"+sql+","
						+"N'"+LEA.record(i,"LEA_NM")+"',N'"+LEA.record(i,"LEA_NM")+"',"
						+"N'"+LEA.record(i,"LEA_NM")+"',N'"+LEA.record(i,"LEA_NM")+"',N'"+"LEA_"+ LEA.record(i,"LEA_ID")+"')";
					PublicFunction.SQL_Execute(sql);					
				
					sql=T_String.IsNullTo0(T_String.GetDataFromSQL("MAX([ID1])","GP_SYS_SQL_SELECT","[ID]="+
						"N'" + frmMonth + "'"))+1+"";
					sql="Insert Into GP_SYS_SQL_SELECT([ID],ID1,[NAME],[FIELD],SEQ) values("
						+"N'" + frmMonth + "',"+sql+","
						+"N'"+"LEA_"+ LEA.record(i,"LEA_ID")+"',N'"+"LEA_"+ LEA.record(i,"LEA_ID")+"',"+sql+")";
					PublicFunction.SQL_Execute(sql);
				}
			}
		}		

		private void cmd_close_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void cmd_mon_Click(object sender, System.EventArgs e)
		{
			DateTime d1=(DateTime)dt1.Value;
			DateTime d2=(DateTime)dt2.Value;
			DateTime d3=(DateTime)dt3.Value;

			if(T_String.IsNullTo0(d1.ToString("yyyyMMdd"))>T_String.IsNullTo0(d2.ToString("yyyyMMdd")))
			{
				MessageBox.Show(PublicFunction.L_Get_Msg("msg",216));
				return;
			}

			Stop=false;
			Thread th=new Thread(new ThreadStart(Cal));
			th.Start();
		}
		private void Cal()
		{	
			string sql;
			cmd_stop.Visible=true;
			panel2.Enabled=false;
			SqlConnection con1=new SqlConnection(PublicFunction.C_con.ConnectionString);
			if(con1.State==ConnectionState.Closed )
				con1.Open();

			string YYY_MM=dt3.Text;
			string dt=T_String.GetDate().ToString("yyyy/MM/dd HH:mm");

			DateTime d1=(DateTime)dt1.Value;
			DateTime d2=(DateTime)dt2.Value;
			
			ArrayList a=new ArrayList();			

			while(T_String.IsNullTo0(d1.ToString("yyyyMMdd"))<=T_String.IsNullTo0(d2.ToString("yyyyMMdd")))// tung Ngay
			{
				string data=T_String.GetDataFromSQL("h"+d1.Day,"FILA16A","YYY_YY="+d1.Year+" and MMM_MM="+d1.Month);
				if (data+""=="True")
				{
					a.Add(d1.ToString("yyyyMMdd"));	
				}
				d1=d1.AddDays(1);
			}

			d1=(DateTime)dt1.Value;
			d2=(DateTime)dt2.Value;

			Func.RecordSet sal;
			sql="Select TYP_ID from GP_SYS_SHIFT";
			Func.RecordSet rsshift=new Func.RecordSet(sql,PublicFunction.C_con);
			sql="Select * from " + FILC07A + " where MON_BT=1";
			Func.RecordSet ATTFOR=new Func.RecordSet(sql,PublicFunction.C_con);
			
			sql="Select a.EMP_ID,EMP_NM,CONVERT(nvarchar(10),VAC_DT,111) VAC_DT,a.EMP_I1,a.DEP_ID,CONVERT(nvarchar(10),INH_DT,111) INH_DT from FILB01A  a Left JOIN FILB01AC b on a.EMP_ID=b.EMP_ID where  " 
				+control1.GetWhere("a",false)+" and (VAC_DT>'"+d1.ToString("yyyy/MM/dd")+"' or VAC_DT is null or a.VAC_BT=0 or a.VAC_BT is null)"
				+ " and INH_DT<='" + d2.ToString("yyyy/MM/dd") +"'";
				
			Func.RecordSet rs=new Func.RecordSet(sql,con1);
			string sql1="";
			for(int i=0;i<rs.rows;i++)  // Tung Nhan Vien
			{
				if(Stop)
				{
					return;
				}
				c1.Text=rs.record(i,"EMP_ID")+" - "+rs.record(i,"EMP_NM");

				//Ktra lock thang
				if (T_String.GetDataFromSQL("ISNULL(LOC_B1,0) LOC_B1", FILC06AA, "EMP_ID=N'"+rs.record(i,"EMP_ID")+"' and YYY_MM=N'"+YYY_MM+"' AND SEQ_NO=2") != "True")
				{
					sql="Delete from " + FILC06AA + " where EMP_ID=N'"+rs.record(i,"EMP_ID")+"' and YYY_MM=N'"+YYY_MM+"'";
					if(cb.SelectedValue+""=="1")
						sql+=" and SEQ_NO=1"; // nua thang
					else
						sql+=" and SEQ_NO in(2,3,4)";// 2 nguyen thang, 3 truoc khi doi luong, 4 sau khi doi luong 
					PublicFunction.SQL_Execute(sql,con1,true);
					// doi bo phan
					sql="SELECT * FROM FILB03A WHERE  (SEQ_DT>'"+d2.ToString("yyyy/MM/dd")
						+"' and EMP_ID=N'"+rs.record(i,"EMP_ID")+"') ORDER BY SEQ_DT ASC"; // doi bo phan
					Func.RecordSet rs1=new Func.RecordSet(sql,con1);				
					string DEP_I1,EMP_DW;
					if(rs1.rows>0)
					{
						DEP_I1=rs1.record(0,"DEP_I1");// thay doi bo phan
						EMP_DW=rs1.record(0,"EMP_I3"); 
					}					
					else
					{
						DEP_I1=rs.record(i,"DEP_ID");
						EMP_DW=rs.record(i,"EMP_I1"); 					
					}
					//
					sql="Insert into " + FILC06AA + "(EMP_ID,YYY_MM,DEP_I1,EMP_DW,BLT_NM,BLT_DT,NOT_DR,SEQ_NO) values(";
					sql+="N'"+rs.record(i,"EMP_ID")+"',N'"+YYY_MM+"',";
					sql+="N'"+DEP_I1+"',N'"+EMP_DW+"',";
					sql+="N'"+PublicFunction.A_UserID+"','"+dt+"',";
					sql+="N'"+d1.ToString("yyyy/MM/dd")+"~"+d2.ToString("yyyy/MM/dd")+"',";
					string sql11="Select EMP_ID,CHA_DT from FILD03A where EMP_ID=N'"+rs.record(i,"EMP_ID")+"' and CHA_DT>'"+
						d1.ToString("yyyy/MM/dd")+"' and CHA_DT<='"+d2.ToString("yyyy/MM/dd")+"' AND ISNULL(DON_AP,0)=0" +
						" AND CHA_DT<>'" + rs.record(i, "INH_DT") + "'";

					sal=new Func.RecordSet(sql11,con1);
					if(cb.SelectedValue+""=="1")
					{
						sql1=sql+"1)";
						PublicFunction.SQL_Execute(sql1,con1,true);					
					}
					else
					{
						sql1=sql+"2)";
						PublicFunction.SQL_Execute(sql1,con1,true);					
						if(sal.rows>0)
						{
							sql="Insert into " + FILC06AA + "(EMP_ID,YYY_MM,BLT_NM,BLT_DT,NOT_DR,SEQ_NO) values(";
							sql+="N'"+rs.record(i,"EMP_ID")+"',N'"+YYY_MM+"',";
							sql+="N'"+PublicFunction.A_UserID+"','"+dt+"',";
							sql+="N'"+d1.ToString("yyyy/MM/dd")+"~"+DateTime.Parse(sal.record(0,"CHA_DT")).AddDays(-1).ToString("yyyy/MM/dd")+"',";
							sal=new Func.RecordSet("Select EMP_ID,CHA_DT from FILD03A where EMP_ID=N'"+rs.record(i,"EMP_ID")+"' and CHA_DT>'"+
								d1.ToString("yyyy/MM/dd")+"' and CHA_DT<='"+d2.ToString("yyyy/MM/dd")+"' and ISNULL(DON_AP,0)=0",con1);
							sql1=sql+"3)";
							PublicFunction.SQL_Execute(sql1,con1,true);		
							sql="Insert into " + FILC06AA + "(EMP_ID,YYY_MM,BLT_NM,BLT_DT,NOT_DR,SEQ_NO) values(";
							sql+="N'"+rs.record(i,"EMP_ID")+"',N'"+YYY_MM+"',";
							sql+="N'"+PublicFunction.A_UserID+"','"+dt+"',";
							sql+="N'"+DateTime.Parse(sal.record(0,"CHA_DT")).ToString("yyyy/MM/dd")+"~"+d2.ToString("yyyy/MM/dd")+"',";
							sal=new Func.RecordSet("Select EMP_ID,CHA_DT from FILD03A where EMP_ID=N'"+rs.record(i,"EMP_ID")+"' and CHA_DT>'"+
								d1.ToString("yyyy/MM/dd")+"' and CHA_DT<='"+d2.ToString("yyyy/MM/dd")+"' and ISNULL(DON_AP,0)=0",con1);
							sql1=sql+"4)";
							PublicFunction.SQL_Execute(sql1,con1,true);		
						}
					}

					CalShift(rsshift,rs.record(i,"EMP_ID"),cb.SelectedValue+"",con1,sal);
					CalATTFOR(ATTFOR,rs.record(i,"EMP_ID"),cb.SelectedValue+"",con1,sal);
					Normal(rs.record(i,"EMP_ID"),cb.SelectedValue+"",con1,sal);
					LEAVE(rs.record(i,"EMP_ID"),cb.SelectedValue+"",con1,sal);
					BonusFined(rs.record(i,"EMP_ID"),cb.SelectedValue+"",con1,sal);
					CalHoliday(rs.record(i,"EMP_ID"),rs.record(i,"INH_DT"),rs.record(i,"VAC_DT"),a,cb.SelectedValue+"",con1,sal);
				}

				pro1.Value=100;
				pro2.Value=(int)(i+1)*100/rs.rows;
			}		
			pro2.Value=100;			
			c1.Text=PublicFunction.L_Get_Msg("Staff",1);
			panel2.Enabled=true;
			cmd_stop.Visible=false;
		}

		private void CalShift(Func.RecordSet rs,string EMP_ID,string SEQ_NO,SqlConnection con,Func.RecordSet sal) // tinh gio cong
		{
			for(int i=0;i<rs.rows;i++)  // Tung Nhan Vien
			{
				string Item=rs.record(i,"TYP_ID");
				UpdateItem(Item,EMP_ID,SEQ_NO,con,true,sal);			
			}
		}
		private void CalHoliday(string EMP_ID,string INH_DT,string dt,ArrayList a,string SEQ_NO,SqlConnection con,Func.RecordSet sal)// cong gio cong ngay nghi le
		{		
			if (a.Count==0 )
				return;
			int m=0,m1=0,m2=0;
//			if(dt+""!="")
//			{
//			string data2=T_String.GetDataFromSQL("LEA_I1","FILC06A","ATT_DT='"+ d1.ToString("yyyy/MM/dd") +"' and LEA_I1 IN (SELECT  LEA_ID FROM FILA15A WHERE HOL_BT=0)");
//			if (data2+""=="8")
//			{
			Double dt1=0;
			Double INH=0;
			if(INH_DT+""!="")
				INH=T_String.IsNullTo00(DateTime.Parse(INH_DT).ToString("yyyyMMdd"));	
			else
				INH=9999999999;

			if(dt+""!="")
				dt1=T_String.IsNullTo00(DateTime.Parse(dt).ToString("yyyyMMdd"));	
			else
				dt1=9999999999;
			Double dt4=0;

			if(sal.rows>0)
				dt4=T_String.IsNullTo00(DateTime.Parse(sal.record(0,"CHA_DT")).ToString("yyyyMMdd"));
			Func.RecordSet rsATT;
			string sql;
			
			for(int i=0;i<a.Count;i++) 
			{		
				if(dt1<=T_String.IsNullTo00(a[i]+""))
					break;
				string s=a[i]+"";
				sql="select * from FILC04A where EMP_ID='"+EMP_ID+"' AND '"+   a[i] +"' BETWEEN STR_DT AND END_DT and LEA_ID IN (SELECT  LEA_ID FROM FILA15A WHERE HOL_BT=1)";
				rsATT=new Func.RecordSet(sql,con);
				if (rsATT.rows<=0)
				{
					if(INH<T_String.IsNullTo00(a[i]+""))
					{
						if(SEQ_NO=="2")
						{
							if(sal.rows>0 && sal.rows>0)
							{	
								if(dt4<T_String.IsNullTo00(a[i]+""))// sau khi doi luong
									m1++;
								else // truoc khi doi luong
									m2++;
							}
						}
						m++;
					}	
				}
			}
			if(m<=0)
				return;
			m=m*8;
			m1=m1*8;
			m2=m2*8;
//			}
//			else
//				m=a.Count*8;
			string YYY_MM=dt3.Text;
			sql="Update " + FILC06AA + " set [HOL_TT]="+m;
			sql+=" where EMP_ID=N'"+EMP_ID+"' and YYY_MM=N'"+
				YYY_MM+"' and SEQ_NO="+SEQ_NO;
			PublicFunction.SQL_Execute(sql,con,true);
			if(SEQ_NO=="2" && sal.rows>0)
			{
				sql="Update " + FILC06AA + " set [HOL_TT]="+m2;
				sql+=" where EMP_ID=N'"+EMP_ID+"' and YYY_MM=N'"+
					YYY_MM+"' and SEQ_NO=3";
				PublicFunction.SQL_Execute(sql,con,true);
				sql="Update " + FILC06AA + " set [HOL_TT]="+m1;
				sql+=" where EMP_ID=N'"+EMP_ID+"' and YYY_MM=N'"+
					YYY_MM+"' and SEQ_NO=4";
				PublicFunction.SQL_Execute(sql,con,true);
			}
		}	
		private void CalATTFOR(Func.RecordSet rs,string EMP_ID,string SEQ_NO,SqlConnection con,Func.RecordSet sal)
		{		
			for(int i=0;i<rs.rows;i++)  
			{
				string Item=rs.record(i,"COL_NM");
				if(rs.record(i,"GIO_BT")=="True")				
					UpdateItem(Item,EMP_ID,SEQ_NO,con,true,sal);
				else
					UpdateItem(Item,EMP_ID,SEQ_NO,con,false,sal);
			}
		}		
		private void LEAVE(string EMP_ID,string SEQ_NO,SqlConnection con,Func.RecordSet sal)
		{			
			string sql="",sql1;
			for(int i=0;i<LEA.rows;i++)
			{
				UpdateItemLeave(LEA.record(i,"LEA_ID"),EMP_ID,SEQ_NO,con,sal);
				if(sql!="") sql+="+";
				sql+="[LEA_"+LEA.record(i,"LEA_ID")+"]";
			}
			if(sql!="")
			{
				sql1="update " + FILC06AA + " set LEA_QT="+sql+" where EMP_ID=N'"+EMP_ID+"' and YYY_MM=N'"
					+dt3.Text+"' and SEQ_NO="+SEQ_NO;
				PublicFunction.SQL_Execute(sql1,con,true);
				if(SEQ_NO=="2" && sal.rows>0)
				{
					sql1="update " + FILC06AA + " set LEA_QT="+sql+" where EMP_ID=N'"+EMP_ID+"' and YYY_MM=N'"
						+dt3.Text+"' and SEQ_NO=3";
					PublicFunction.SQL_Execute(sql1,con,true);
					sql1="update " + FILC06AA + " set LEA_QT="+sql+" where EMP_ID=N'"+EMP_ID+"' and YYY_MM=N'"
						+dt3.Text+"' and SEQ_NO=4";
					PublicFunction.SQL_Execute(sql1,con,true);
				}
			}
		}

		private void BonusFined(string EMP_ID,string SEQ_NO,SqlConnection con,Func.RecordSet sal)
		{			
			string sql="",sql1="";
			DateTime d1=(DateTime)dt1.Value;
			DateTime d2=(DateTime)dt2.Value;
			//Xu ly khen thuong truoc sau do xu ly phat
			//Thuong
			sql="Select DISTINCT (Select sum(AMT_QT) FROM FILD04A a LEFT OUTER JOIN FILA13A b ON a.BAF_ID=b.BAF_ID"+
				" Where b.TPE_ID=1 and EMP_ID='"+EMP_ID+
				"' and SEQ_DT between '"+d1.ToString("yyyy/MM/dd")+"' and '"+d2.ToString("yyyy/MM/dd")+"') AS Khenthuong,"+
				"(Select sum(AMT_QT) FROM FILD04A a LEFT OUTER JOIN FILA13A b ON a.BAF_ID=b.BAF_ID"+
				" Where (b.TPE_ID = 0 or b.TPE_ID IS NULL) and EMP_ID='"+EMP_ID+
				"' and SEQ_DT between '"+d1.ToString("yyyy/MM/dd")+"' and '"+d2.ToString("yyyy/MM/dd")+"') AS Xuphat"+
				" FROM FILD04A WHERE SEQ_DT BETWEEN '"+d1.ToString("yyyy/MM/dd")+"' and '"+d2.ToString("yyyy/MM/dd")+"' AND EMP_ID='"+EMP_ID+"'";
			Func.RecordSet rsbonusfined=new Func.RecordSet(sql,con);
			if (rsbonusfined.rows!=0)
			{
				sql1="update " + FILC06AA + " set BOS_AM="+T_String.IsNullTo0(rsbonusfined.record(0,"Khenthuong"))+
					",FIN_AM="+T_String.IsNullTo0(rsbonusfined.record(0,"Xuphat"))+" where EMP_ID=N'"+EMP_ID+"' and YYY_MM=N'"
					+dt3.Text+"' and SEQ_NO="+SEQ_NO;
				PublicFunction.SQL_Execute(sql1,con,true);
				if(SEQ_NO=="2" && sal.rows>0)
				{
					sql1="update " + FILC06AA + " set BOS_AM="+T_String.IsNullTo0(rsbonusfined.record(0,"Khenthuong"))+
						",FIN_AM="+T_String.IsNullTo0(rsbonusfined.record(0,"Xuphat"))+" where EMP_ID=N'"+EMP_ID+"' and YYY_MM=N'"
						+dt3.Text+"' and SEQ_NO=3";
					PublicFunction.SQL_Execute(sql1,con,true);
					sql1="update " + FILC06AA + " set BOS_AM="+T_String.IsNullTo0(rsbonusfined.record(0,"Khenthuong"))+
						",FIN_AM="+T_String.IsNullTo0(rsbonusfined.record(0,"Xuphat"))+" where EMP_ID=N'"+EMP_ID+"' and YYY_MM=N'"
						+dt3.Text+"' and SEQ_NO=4";
					PublicFunction.SQL_Execute(sql1,con,true);
				}
			}
		}

		private void UpdateItemLeave(string LEA_ID,string EMP_ID,string SEQ_NO,SqlConnection con,Func.RecordSet sal)
		{
			string YYY_MM=dt3.Text;
			DateTime d1=(DateTime)dt1.Value;
			DateTime d2=(DateTime)dt2.Value;
			string sql="",sql1,Item;			
			Double t1,t2,t3;
			Item="LEA_H1";
			sql="ROUND(SUM((FLOOR(["+Item+"]/100)+(["+Item+"]/100-FLOOR(["+Item+"]/100))/0.6)),2)";
			sql1="EMP_ID=N'"+EMP_ID+"' and ATT_DT between '"+d1.ToString("yyyy/MM/dd")+
				"' and '"+d2.ToString("yyyy/MM/dd")+"' and LEA_I1=N'"+LEA_ID+"'";
			t1=T_String.IsNullTo00(T_String.GetDataFromSQL(sql, FILC06A, sql1));
			Item="LEA_H2";
			sql="ROUND(SUM((FLOOR(["+Item+"]/100)+(["+Item+"]/100-FLOOR(["+Item+"]/100))/0.6)),2)";
			sql1="EMP_ID=N'"+EMP_ID+"' and ATT_DT between '"+d1.ToString("yyyy/MM/dd")+
				"' and '"+d2.ToString("yyyy/MM/dd")+"' and LEA_I2=N'"+LEA_ID+"'";
			t2=T_String.IsNullTo00(T_String.GetDataFromSQL(sql, FILC06A, sql1));
			Item="LEA_H3";
			sql="ROUND(SUM((FLOOR(["+Item+"]/100)+(["+Item+"]/100-FLOOR(["+Item+"]/100))/0.6)),2)";
			sql1="EMP_ID=N'"+EMP_ID+"' and ATT_DT between '"+d1.ToString("yyyy/MM/dd")+
				"' and '"+d2.ToString("yyyy/MM/dd")+"' and LEA_I3=N'"+LEA_ID+"'";
			t3=T_String.IsNullTo00(T_String.GetDataFromSQL(sql, FILC06A, sql1));			
			
			t1=t1+t2+t3;

			sql="Update " + FILC06AA + " set ["+"LEA_"+LEA_ID+"]="+t1.ToString("##0.##");
			sql+=" where EMP_ID=N'"+EMP_ID+"' and YYY_MM=N'"+
				YYY_MM+"' and SEQ_NO="+SEQ_NO;
			PublicFunction.SQL_Execute(sql,con,true);
			if(SEQ_NO=="2" && sal.rows>0)
			{
				Item="LEA_H1";
				sql="ROUND(SUM((FLOOR(["+Item+"]/100)+(["+Item+"]/100-FLOOR(["+Item+"]/100))/0.6)),2)";
				sql1="EMP_ID=N'"+EMP_ID+"' and ATT_DT between '"+d1.ToString("yyyy/MM/dd")+
					"' and '"+DateTime.Parse(sal.record(0,"CHA_DT")+"").AddDays(-1).ToString("yyyy/MM/dd")+"' and LEA_I1=N'"+LEA_ID+"'";
				t1=T_String.IsNullTo00(T_String.GetDataFromSQL(sql, FILC06A, sql1));

				Item="LEA_H2";
				sql="ROUND(SUM((FLOOR(["+Item+"]/100)+(["+Item+"]/100-FLOOR(["+Item+"]/100))/0.6)),2)";
				sql1="EMP_ID=N'"+EMP_ID+"' and ATT_DT between '"+d1.ToString("yyyy/MM/dd")+
					"' and '"+DateTime.Parse(sal.record(0,"CHA_DT")+"").AddDays(-1).ToString("yyyy/MM/dd")+"' and LEA_I2=N'"+LEA_ID+"'";
				t2=T_String.IsNullTo00(T_String.GetDataFromSQL(sql, FILC06A, sql1));
				Item="LEA_H3";
				sql="ROUND(SUM((FLOOR(["+Item+"]/100)+(["+Item+"]/100-FLOOR(["+Item+"]/100))/0.6)),2)";
				sql1="EMP_ID=N'"+EMP_ID+"' and ATT_DT between '"+d1.ToString("yyyy/MM/dd")+
					"' and '"+DateTime.Parse(sal.record(0,"CHA_DT")+"").AddDays(-1).ToString("yyyy/MM/dd")+"' and LEA_I3=N'"+LEA_ID+"'";
				t3=T_String.IsNullTo00(T_String.GetDataFromSQL(sql, FILC06A, sql1));
			
				t1=t1+t2+t3;

				sql="Update " + FILC06AA + " set ["+"LEA_"+LEA_ID+"]="+t1.ToString("##0.##");
				sql+=" where EMP_ID=N'"+EMP_ID+"' and YYY_MM=N'"+
					YYY_MM+"' and SEQ_NO="+3;
				PublicFunction.SQL_Execute(sql,con,true); //truoc khi thay doi luong

				Item="LEA_H1";
				sql="ROUND(SUM((FLOOR(["+Item+"]/100)+(["+Item+"]/100-FLOOR(["+Item+"]/100))/0.6)),2)";
				sql1="EMP_ID=N'"+EMP_ID+"' and ATT_DT between '"+DateTime.Parse(sal.record(0,"CHA_DT")+"").ToString("yyyy/MM/dd")+
					"' and '"+d2.ToString("yyyy/MM/dd")+"' and LEA_I1=N'"+LEA_ID+"'";
				t1=T_String.IsNullTo00(T_String.GetDataFromSQL(sql, FILC06A, sql1));
				Item="LEA_H2";
				sql="ROUND(SUM((FLOOR(["+Item+"]/100)+(["+Item+"]/100-FLOOR(["+Item+"]/100))/0.6)),2)";
				sql1="EMP_ID=N'"+EMP_ID+"' and ATT_DT between '"+DateTime.Parse(sal.record(0,"CHA_DT")+"").ToString("yyyy/MM/dd")+
					"' and '"+d2.ToString("yyyy/MM/dd")+"' and LEA_I2=N'"+LEA_ID+"'";
				t2=T_String.IsNullTo00(T_String.GetDataFromSQL(sql, FILC06A, sql1));
				Item="LEA_H3";
				sql="ROUND(SUM((FLOOR(["+Item+"]/100)+(["+Item+"]/100-FLOOR(["+Item+"]/100))/0.6)),2)";
				sql1="EMP_ID=N'"+EMP_ID+"' and ATT_DT between '"+DateTime.Parse(sal.record(0,"CHA_DT")+"").ToString("yyyy/MM/dd")+
					"' and '"+d2.ToString("yyyy/MM/dd")+"' and LEA_I3=N'"+LEA_ID+"'";
				t3=T_String.IsNullTo00(T_String.GetDataFromSQL(sql, FILC06A, sql1));
			
				t1=t1+t2+t3;

				sql="Update " + FILC06AA + " set ["+"LEA_"+LEA_ID+"]="+t1.ToString("##0.##");
				sql+=" where EMP_ID=N'"+EMP_ID+"' and YYY_MM=N'"+
					YYY_MM+"' and SEQ_NO="+4;
				PublicFunction.SQL_Execute(sql,con,true); // sau khi thay doi luong
			}
		}
		private void Normal(string EMP_ID,string SEQ_NO,SqlConnection con,Func.RecordSet sal)
		{
			UpdateItem("LAT_MN",EMP_ID,SEQ_NO,con,true,sal);
			UpdateItem("LAT_TM",EMP_ID,SEQ_NO,con,false,sal);
			UpdateItem("EAR_MN",EMP_ID,SEQ_NO,con,true,sal);
			UpdateItem("EAR_TM",EMP_ID,SEQ_NO,con,false,sal);
			UpdateItem("ABS_MN",EMP_ID,SEQ_NO,con,true,sal);
			UpdateItem("ABS_TM",EMP_ID,SEQ_NO,con,false,sal);
			UpdateItem("OTR_HR",EMP_ID,SEQ_NO,con,true,sal);
			UpdateItem("ATT_DY",EMP_ID,SEQ_NO,con,false,sal,4);
			UpdateItem("NIG_DY",EMP_ID,SEQ_NO,con,false,sal,4);
		}
		private void UpdateItem(string Item,string EMP_ID,string SEQ_NO,SqlConnection con,Boolean giophut,Func.RecordSet sal)
		{
			UpdateItem(Item,EMP_ID,SEQ_NO,con,giophut,sal,2);
		}
		private void UpdateItem(string Item,string EMP_ID,string SEQ_NO,SqlConnection con,Boolean giophut,Func.RecordSet sal,int round)
		{
			string YYY_MM=dt3.Text;
			DateTime d1=(DateTime)dt1.Value;
			DateTime d2=(DateTime)dt2.Value;
			string sql="",sql1="";						
			sql="Update " + FILC06AA + " set ["+Item+"]=";
			if(giophut)
				sql+="(Select ROUND(SUM((FLOOR(["+Item+"]/100)+(["+Item+"]/100-FLOOR(["+Item+"]/100))/0.6)),2) " ;
			else
				sql+="(Select ROUND(SUM(["+Item+"]),"+round+") " ;
			sql1=sql+" from " + FILC06A + " where EMP_ID=N'"+EMP_ID+"' and ATT_DT between '"+d1.ToString("yyyy/MM/dd")+
				"' and '"+d2.ToString("yyyy/MM/dd")+"') where EMP_ID=N'"+EMP_ID+"' and YYY_MM=N'"+
				YYY_MM+"' and SEQ_NO="+SEQ_NO;
			PublicFunction.SQL_Execute(sql1,con,true);
			if(SEQ_NO=="2" && sal.rows>0)
			{
				sql1=sql+" from " + FILC06A + " where EMP_ID=N'"+EMP_ID+"' and ATT_DT between '"+d1.ToString("yyyy/MM/dd")+
					"' and '"+DateTime.Parse(sal.record(0,"CHA_DT")+"").AddDays(-1).ToString("yyyy/MM/dd")+"') where EMP_ID=N'"+EMP_ID+"' and YYY_MM=N'"+
					YYY_MM+"' and SEQ_NO="+3;
				PublicFunction.SQL_Execute(sql1,con,true); // truoc thay doi luong 

				sql1=sql+" from " + FILC06A + " where EMP_ID=N'"+EMP_ID+"' and ATT_DT between '"+DateTime.Parse(sal.record(0,"CHA_DT")+"").ToString("yyyy/MM/dd")+
					"' and '"+d2.ToString("yyyy/MM/dd")+"') where EMP_ID=N'"+EMP_ID+"' and YYY_MM=N'"+
					YYY_MM+"' and SEQ_NO="+4;
				PublicFunction.SQL_Execute(sql1,con,true); // sau thay doi luong 
			}
		}

		private void frmTaMonthAddUpCal_Closed(object sender, EventArgs e)
		{
			Stop=true;
		}

		private void cmd_stop_Click(object sender, System.EventArgs e)
		{
			Stop=true;
			cmd_stop.Visible=false;
			panel2.Enabled=true;
		}
	

		private void dt2_Leave(object sender, System.EventArgs e)
		{
			DateTime d1=(DateTime)dt1.Value;
			DateTime d2=(DateTime)dt2.Value;
			int day=0;
			while(T_String.IsNullTo0(d1.ToString("yyyyMMdd"))<=T_String.IsNullTo0(d2.ToString("yyyyMMdd")))// tung Ngay
			{
				day++;
				d1=d1.AddDays(1);
			}
			if(day>=15)
				cb.SelectedValue=2;
			else
				cb.SelectedValue=1;
			if (((DateTime)dt1.Value).Day  < 15)
				dt3.Value=dt1.Value;
			else
				dt3.Value = dt2.Value;
		}

		private void dt1_TextChanged(object sender, System.EventArgs e)
		{
			dt2.Value=((DateTime)dt1.Value).AddMonths(1).AddDays(-1);
			if (((DateTime)dt1.Value).Day > 15)
				dt3.Value = dt2.Value;
			else
				dt3.Value = dt1.Value;
		}

		private void dt2_TextChanged(object sender, System.EventArgs e)
		{
			if (((DateTime)dt1.Value).Day > 15)
				dt3.Value = dt2.Value;
			else
				dt3.Value = dt1.Value;
		}
	}
}
