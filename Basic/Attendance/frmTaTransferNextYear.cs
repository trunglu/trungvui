using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using Basic.Form;
using Basic.Function;
using System.IO;
using System.Threading;
using System.Data;
using System.Data.SqlClient;
namespace GP8000.Attendance
{
	/// <summary>
	/// Summary description for frmTaCalAnnualLeave.
	/// </summary>
	public class frmTaTransferNextYear : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button cmd_close;
		private GP8000.UserControl.CrtTaCondition1 control1;
		private System.Windows.Forms.Button cmd_OK;
		private System.Windows.Forms.ProgressBar pro;
		private System.Windows.Forms.Label lb;
		private Boolean stop;
		private System.Windows.Forms.Label lb2;
		private DateTime dt;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DateTimePicker YYY_YY;		
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmTaTransferNextYear()
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
			this.YYY_YY = new System.Windows.Forms.DateTimePicker();
			this.label1 = new System.Windows.Forms.Label();
			this.control1 = new GP8000.UserControl.CrtTaCondition1();
			this.cmd_close = new System.Windows.Forms.Button();
			this.cmd_OK = new System.Windows.Forms.Button();
			this.pro = new System.Windows.Forms.ProgressBar();
			this.lb = new System.Windows.Forms.Label();
			this.lb2 = new System.Windows.Forms.Label();
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
			this.panel3.Size = new System.Drawing.Size(446, 36);
			this.panel3.TabIndex = 5;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label5.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.label5.Location = new System.Drawing.Point(0, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(446, 36);
			this.label5.TabIndex = 11;
			this.label5.Tag = "";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// YYY_YY
			// 
			this.YYY_YY.CustomFormat = "yyyy";
			this.YYY_YY.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.YYY_YY.Location = new System.Drawing.Point(100, 36);
			this.YYY_YY.Name = "YYY_YY";
			this.YYY_YY.Size = new System.Drawing.Size(104, 23);
			this.YYY_YY.TabIndex = 32;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 44);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(92, 23);
			this.label1.TabIndex = 31;
			this.label1.Text = "label1";
			// 
			// control1
			// 
			this.control1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.control1.Location = new System.Drawing.Point(0, 60);
			this.control1.Name = "control1";
			this.control1.Size = new System.Drawing.Size(448, 164);
			this.control1.TabIndex = 6;
			// 
			// cmd_close
			// 
			this.cmd_close.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_close.Location = new System.Drawing.Point(259, 296);
			this.cmd_close.Name = "cmd_close";
			this.cmd_close.Size = new System.Drawing.Size(116, 36);
			this.cmd_close.TabIndex = 27;
			this.cmd_close.Text = "Close";
			this.cmd_close.Click += new System.EventHandler(this.cmd_close_Click);
			// 
			// cmd_OK
			// 
			this.cmd_OK.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_OK.Location = new System.Drawing.Point(72, 296);
			this.cmd_OK.Name = "cmd_OK";
			this.cmd_OK.Size = new System.Drawing.Size(116, 36);
			this.cmd_OK.TabIndex = 26;
			this.cmd_OK.Text = "OK";
			this.cmd_OK.Click += new System.EventHandler(this.cmd_OK_Click);
			// 
			// pro
			// 
			this.pro.Location = new System.Drawing.Point(4, 228);
			this.pro.Name = "pro";
			this.pro.Size = new System.Drawing.Size(432, 16);
			this.pro.TabIndex = 28;
			// 
			// lb
			// 
			this.lb.BackColor = System.Drawing.Color.Black;
			this.lb.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lb.ForeColor = System.Drawing.Color.White;
			this.lb.Location = new System.Drawing.Point(4, 244);
			this.lb.Name = "lb";
			this.lb.Size = new System.Drawing.Size(432, 23);
			this.lb.TabIndex = 29;
			this.lb.Tag = "N";
			this.lb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lb2
			// 
			this.lb2.BackColor = System.Drawing.Color.Black;
			this.lb2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lb2.ForeColor = System.Drawing.Color.White;
			this.lb2.Location = new System.Drawing.Point(4, 264);
			this.lb2.Name = "lb2";
			this.lb2.Size = new System.Drawing.Size(432, 23);
			this.lb2.TabIndex = 30;
			this.lb2.Tag = "N";
			this.lb2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// frmTaTransferNextYear
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
			this.ClientSize = new System.Drawing.Size(446, 338);
			this.Controls.Add(this.YYY_YY);
			this.Controls.Add(this.lb2);
			this.Controls.Add(this.lb);
			this.Controls.Add(this.pro);
			this.Controls.Add(this.cmd_close);
			this.Controls.Add(this.cmd_OK);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.control1);
			this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmTaTransferNextYear";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmTaTransferNextYear";
			this.Load += new System.EventHandler(this.frmTaCalAnnualLeave_Load);
			this.panel3.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion
		#region Load
		private void frmTaCalAnnualLeave_Load(object sender, System.EventArgs e)
		{			
			Basic.Function.PublicFunction.L_Init_Label(this);				
			control1.InitCB(this.Tag);
			control1.Initlabel();
			this.Closed+=new EventHandler(frmTaCalAnnualLeave_Closed);
		}
		#endregion
		#region Event
		private void cmd_close_Click(object sender, System.EventArgs e)
		{
			this.DialogResult=DialogResult.Cancel;
		}

		private void cmd_OK_Click(object sender, System.EventArgs e)
		{
			stop=false;			
			Thread th=new Thread(new System.Threading.ThreadStart(TransferToYear));
			th.Start();		
		}
		#endregion			
		#region Chuyen Sang Nam
		private void TransferToYear()
		{
			dt=T_String.GetDate();
			lb.Text= "";
			lb2.Text= "";
			cmd_OK.Enabled=false;
			SqlConnection con=new SqlConnection(PublicFunction.C_con.ConnectionString);
			con.Open();
			string sql="Select EMP_ID,EMP_NM from FILB01A";
			//sql+=" where "+control1.GetWhere("");
			//sql+=" where VAC_BT=1 or "+control1.GetWhere("");
			sql+=" where "+control1.GetWhere("",false);
			//sql+=" where VAC_BT=1 and EMP_ID in (select EMP_ID from  FILB01AC where VAC_DT>='getdate()') or "+control1.GetWhere("");
		
			
			Func.RecordSet rs=new Func.RecordSet(sql,con);
			for(int i=0;i<rs.rows;i++)
			{
				if(stop)
				{
					return;
				}
				TransferStaff(rs.record(i,"EMP_ID")+"",con);
				lb.Text= (i+1)+"/"+rs.rows+" __ "+((int)(i+1)*100/rs.rows)+"%";
				lb2.Text= rs.record(i,"EMP_ID")+" __ "+rs.record(i,"EMP_NM");
				pro.Value=(int)(i+1)*100/rs.rows;
			}
			lb2.Text=PublicFunction.L_Get_Msg("Staff",1);
			cmd_OK.Enabled=true;
		}
		private void TransferStaff(string EMP_ID,SqlConnection con)
		{
			checkStaff(EMP_ID,con);
			string sql="Select * from FILC04B where EMP_ID=N'"+EMP_ID+"' and YYY_YY=N'"+YYY_YY.Text+"'";
			Func.RecordSet rs=new Func.RecordSet(sql,con);
			if(rs.rows<0)
				return;
			double songay=0;
//			songay+=T_String.IsNullTo00(rs.record(0,"HAV_QT"));
//			songay+=T_String.IsNullTo00(rs.record(0,"ADD_QT"));
//			songay+=T_String.IsNullTo00(rs.record(0,"LST_QT"));
//			songay-=T_String.IsNullTo00(rs.record(0,"DID_QT"));
			//songay-=T_String.IsNullTo00(rs.record(0,"BOR_QT"));
			songay+=T_String.IsNullTo00(rs.record(0,"TLCN"));
			songay+=T_String.IsNullTo00(rs.record(0,"BOR_QT"));
			songay+=T_String.IsNullTo00(rs.record(0,"ADD_QT"));
			songay+=T_String.IsNullTo00(rs.record(0,"LST_QT"));
			songay+=T_String.IsNullTo00(rs.record(0,"SUP_QT")); 
			songay-=T_String.IsNullTo00(rs.record(0,"DID_QT"));
//			if (songay - Math.Floor(songay)>0.5 && songay >0)
//			{
//				songay =Math.Floor(songay) +1 ;
//			}
			sql="update FILC04B set LST_QT="+songay+" where EMP_ID=N'"+EMP_ID+"' and YYY_YY=N'"+
				((int)(T_String.IsNullTo0(YYY_YY.Text)+1)).ToString("0000")+"'";
			PublicFunction.SQL_Execute(sql,con);
		}
		#endregion
		#region Fun
		public  void checkStaff(string EMP_ID,SqlConnection con)
		{			
			if(T_String.IsNullTo0(T_String.GetDataFromSQL("Count(*)","FILC04B","EMP_ID=N'"+EMP_ID+"' and YYY_YY=N'"
				+((int)(T_String.IsNullTo0(YYY_YY.Text)+1)).ToString("0000")+"'"))<=0 && T_String.GetDataFromSQL("VAC_BT","FILB01A","EMP_ID=N'"+EMP_ID+"'")!="True")
			{
				string sql="";
				sql="Insert Into FILC04B(YYY_YY,EMP_ID,BLT_NM,BLT_DT) values (N'"
					+((int)(T_String.IsNullTo0(YYY_YY.Text)+1)).ToString("0000")
					+"',N'"+EMP_ID+"',N'"+PublicFunction.A_UserID+"','"+dt.ToString("yyyy/MM/dd HH:mm")+"')";
				PublicFunction.SQL_Execute(sql,con);
			}
		}

		private void frmTaCalAnnualLeave_Closed(object sender, EventArgs e)
		{
			stop=true;
		}
		#endregion
	}
}
