using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using Basic.Form;
using Basic.Function;
using System.Data;
using System.Data.SqlClient;
using System.Threading;
using System.Data.OleDb;
using System.IO;


namespace GP8000.Backup
{
	/// <summary>
	/// Summary description for frmTaBackup.
	/// </summary>
	public class frmTaBackup : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label l;
		private System.Windows.Forms.Panel panel3;
		private C1.Win.C1Input.C1DateEdit dt2;
		private C1.Win.C1Input.C1DateEdit dt1;
		private System.Windows.Forms.Label lb2;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.TextBox txt3;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.ProgressBar pro;
		private System.Windows.Forms.Button cmd_close;
		private System.Windows.Forms.Button cmd_OK;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.FolderBrowserDialog ff;
		private System.Windows.Forms.Button cmd_stop;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private C1.Win.C1Input.C1DateEdit mm1;
		private C1.Win.C1Input.C1DateEdit mm2;
		private System.Windows.Forms.Label lll;
		private System.Windows.Forms.Label ll;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmTaBackup()
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
			this.panel2 = new System.Windows.Forms.Panel();
			this.l = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.dt2 = new C1.Win.C1Input.C1DateEdit();
			this.dt1 = new C1.Win.C1Input.C1DateEdit();
			this.lb2 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.cmd_close = new System.Windows.Forms.Button();
			this.cmd_OK = new System.Windows.Forms.Button();
			this.lll = new System.Windows.Forms.Label();
			this.panel6 = new System.Windows.Forms.Panel();
			this.pro = new System.Windows.Forms.ProgressBar();
			this.panel5 = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.button3 = new System.Windows.Forms.Button();
			this.txt3 = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.panel7 = new System.Windows.Forms.Panel();
			this.ff = new System.Windows.Forms.FolderBrowserDialog();
			this.cmd_stop = new System.Windows.Forms.Button();
			this.mm1 = new C1.Win.C1Input.C1DateEdit();
			this.label1 = new System.Windows.Forms.Label();
			this.mm2 = new C1.Win.C1Input.C1DateEdit();
			this.label2 = new System.Windows.Forms.Label();
			this.ll = new System.Windows.Forms.Label();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dt2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dt1)).BeginInit();
			this.panel1.SuspendLayout();
			this.panel6.SuspendLayout();
			this.panel4.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.panel7.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.mm1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mm2)).BeginInit();
			this.SuspendLayout();
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.panel2.Controls.Add(this.l);
			this.panel2.Controls.Add(this.panel3);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(808, 36);
			this.panel2.TabIndex = 1;
			// 
			// l
			// 
			this.l.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.l.Dock = System.Windows.Forms.DockStyle.Fill;
			this.l.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.l.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.l.Location = new System.Drawing.Point(4, 0);
			this.l.Name = "l";
			this.l.Size = new System.Drawing.Size(804, 36);
			this.l.TabIndex = 6;
			this.l.Tag = "";
			this.l.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel3
			// 
			this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel3.Location = new System.Drawing.Point(0, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(4, 36);
			this.panel3.TabIndex = 0;
			// 
			// dt2
			// 
			this.dt2.CustomFormat = "yyyy/MM/dd";
			this.dt2.EmptyAsNull = true;
			this.dt2.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat;
			this.dt2.Location = new System.Drawing.Point(272, 20);
			this.dt2.Name = "dt2";
			this.dt2.Size = new System.Drawing.Size(144, 23);
			this.dt2.TabIndex = 7;
			this.dt2.Tag = null;
			// 
			// dt1
			// 
			this.dt1.CustomFormat = "yyyy/MM/dd";
			this.dt1.EmptyAsNull = true;
			this.dt1.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat;
			this.dt1.Location = new System.Drawing.Point(104, 20);
			this.dt1.Name = "dt1";
			this.dt1.Size = new System.Drawing.Size(144, 23);
			this.dt1.TabIndex = 6;
			this.dt1.Tag = null;
			// 
			// lb2
			// 
			this.lb2.Location = new System.Drawing.Point(12, 24);
			this.lb2.Name = "lb2";
			this.lb2.TabIndex = 4;
			this.lb2.Tag = "";
			this.lb2.Text = "label4";
			// 
			// label7
			// 
			this.label7.ForeColor = System.Drawing.Color.Black;
			this.label7.Location = new System.Drawing.Point(248, 24);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(24, 16);
			this.label7.TabIndex = 5;
			this.label7.Tag = "N";
			this.label7.Text = "->";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.panel7);
			this.panel1.Controls.Add(this.lll);
			this.panel1.Controls.Add(this.panel6);
			this.panel1.Controls.Add(this.panel5);
			this.panel1.Controls.Add(this.panel4);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 36);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(808, 400);
			this.panel1.TabIndex = 8;
			// 
			// cmd_close
			// 
			this.cmd_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cmd_close.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_close.Location = new System.Drawing.Point(446, 48);
			this.cmd_close.Name = "cmd_close";
			this.cmd_close.Size = new System.Drawing.Size(116, 36);
			this.cmd_close.TabIndex = 14;
			this.cmd_close.Text = "Close";
			this.cmd_close.Click += new System.EventHandler(this.cmd_close_Click);
			// 
			// cmd_OK
			// 
			this.cmd_OK.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_OK.Location = new System.Drawing.Point(246, 48);
			this.cmd_OK.Name = "cmd_OK";
			this.cmd_OK.Size = new System.Drawing.Size(116, 36);
			this.cmd_OK.TabIndex = 13;
			this.cmd_OK.Text = "Backup";
			this.cmd_OK.Click += new System.EventHandler(this.cmd_OK_Click);
			// 
			// lll
			// 
			this.lll.BackColor = System.Drawing.Color.Black;
			this.lll.Dock = System.Windows.Forms.DockStyle.Top;
			this.lll.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lll.ForeColor = System.Drawing.Color.White;
			this.lll.Location = new System.Drawing.Point(0, 132);
			this.lll.Name = "lll";
			this.lll.Size = new System.Drawing.Size(808, 28);
			this.lll.TabIndex = 12;
			this.lll.Tag = "N";
			this.lll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel6
			// 
			this.panel6.Controls.Add(this.pro);
			this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel6.Location = new System.Drawing.Point(0, 112);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(808, 20);
			this.panel6.TabIndex = 11;
			// 
			// pro
			// 
			this.pro.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pro.Location = new System.Drawing.Point(0, 0);
			this.pro.Name = "pro";
			this.pro.Size = new System.Drawing.Size(808, 20);
			this.pro.TabIndex = 0;
			// 
			// panel5
			// 
			this.panel5.BackColor = System.Drawing.Color.LightSteelBlue;
			this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel5.Location = new System.Drawing.Point(0, 108);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(808, 4);
			this.panel5.TabIndex = 10;
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.groupBox1);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel4.Location = new System.Drawing.Point(0, 0);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(808, 108);
			this.panel4.TabIndex = 9;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.mm1);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.mm2);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.button3);
			this.groupBox1.Controls.Add(this.txt3);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.dt1);
			this.groupBox1.Controls.Add(this.lb2);
			this.groupBox1.Controls.Add(this.dt2);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox1.Location = new System.Drawing.Point(0, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(808, 108);
			this.groupBox1.TabIndex = 8;
			this.groupBox1.TabStop = false;
			this.groupBox1.Tag = "N";
			// 
			// button3
			// 
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button3.Location = new System.Drawing.Point(768, 76);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(28, 23);
			this.button3.TabIndex = 10;
			this.button3.Tag = "N";
			this.button3.Text = "...";
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// txt3
			// 
			this.txt3.BackColor = System.Drawing.Color.LemonChiffon;
			this.txt3.Location = new System.Drawing.Point(104, 76);
			this.txt3.Name = "txt3";
			this.txt3.ReadOnly = true;
			this.txt3.Size = new System.Drawing.Size(668, 23);
			this.txt3.TabIndex = 9;
			this.txt3.Text = "";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(12, 80);
			this.label6.Name = "label6";
			this.label6.TabIndex = 8;
			this.label6.Tag = "";
			this.label6.Text = "label4";
			// 
			// panel7
			// 
			this.panel7.Controls.Add(this.ll);
			this.panel7.Controls.Add(this.cmd_close);
			this.panel7.Controls.Add(this.cmd_OK);
			this.panel7.Controls.Add(this.cmd_stop);
			this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel7.Location = new System.Drawing.Point(0, 160);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(808, 240);
			this.panel7.TabIndex = 15;
			// 
			// cmd_stop
			// 
			this.cmd_stop.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd_stop.Location = new System.Drawing.Point(248, 48);
			this.cmd_stop.Name = "cmd_stop";
			this.cmd_stop.Size = new System.Drawing.Size(116, 36);
			this.cmd_stop.TabIndex = 15;
			this.cmd_stop.Text = "Stop";
			this.cmd_stop.Visible = false;
			this.cmd_stop.Click += new System.EventHandler(this.cmd_stop_Click);
			// 
			// mm1
			// 
			this.mm1.CustomFormat = "yyyyMM";
			this.mm1.EmptyAsNull = true;
			this.mm1.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat;
			this.mm1.Location = new System.Drawing.Point(104, 48);
			this.mm1.Name = "mm1";
			this.mm1.Size = new System.Drawing.Size(144, 23);
			this.mm1.TabIndex = 13;
			this.mm1.Tag = null;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 52);
			this.label1.Name = "label1";
			this.label1.TabIndex = 11;
			this.label1.Tag = "";
			this.label1.Text = "label4";
			// 
			// mm2
			// 
			this.mm2.CustomFormat = "yyyyMM";
			this.mm2.EmptyAsNull = true;
			this.mm2.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat;
			this.mm2.Location = new System.Drawing.Point(272, 48);
			this.mm2.Name = "mm2";
			this.mm2.Size = new System.Drawing.Size(144, 23);
			this.mm2.TabIndex = 14;
			this.mm2.Tag = null;
			// 
			// label2
			// 
			this.label2.ForeColor = System.Drawing.Color.Black;
			this.label2.Location = new System.Drawing.Point(248, 52);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(24, 16);
			this.label2.TabIndex = 12;
			this.label2.Tag = "N";
			this.label2.Text = "->";
			// 
			// ll
			// 
			this.ll.BackColor = System.Drawing.Color.Black;
			this.ll.Dock = System.Windows.Forms.DockStyle.Top;
			this.ll.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.ll.ForeColor = System.Drawing.Color.White;
			this.ll.Location = new System.Drawing.Point(0, 0);
			this.ll.Name = "ll";
			this.ll.Size = new System.Drawing.Size(808, 28);
			this.ll.TabIndex = 16;
			this.ll.Tag = "N";
			this.ll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// frmTaBackup
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
			this.ClientSize = new System.Drawing.Size(808, 436);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel2);
			this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "frmTaBackup";
			this.Text = "frmTaBackup";
			this.Load += new System.EventHandler(this.frmTaBackup_Load);
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dt2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dt1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel6.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.panel7.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.mm1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.mm2)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void frmTaBackup_Load(object sender, System.EventArgs e)
		{
			Basic.Function.PublicFunction.L_Init_Label(this);	
			mm1.Value=mm2.Value=dt1.Value=dt2.Value=T_String.GetDate();
		}

		private void button3_Click(object sender, System.EventArgs e)
		{
			if(ff.ShowDialog()==DialogResult.OK)
			{
				txt3.Text=ff.SelectedPath;
			}
		}

		private void cmd_OK_Click(object sender, System.EventArgs e)
		{
			if(txt3.Text!="")
			{
                stop=false;
				CL();
				Thread th=new Thread(new ThreadStart(BK));
				th.Priority=ThreadPriority.Highest;
				th.Start();
			}
			else
			{
				MessageBox.Show(PublicFunction.L_GetLabel(this.Name,12));
			}
		}

		private void BK()
		{
			lll.Text=PublicFunction.L_GetLabel(this.Name,8);
			CopyFile();
			lll.Text=PublicFunction.L_GetLabel(this.Name,9);
			SqlConnection con=new SqlConnection(PublicFunction.C_con.ConnectionString);
			con.Open();
			OleDbConnection conmdb=new OleDbConnection();
			conmdb=ConnectMDB(txt3.Text+"\\hqt_data.mdb");
			if (conmdb.State!=ConnectionState.Open)
			{
				CL();
				MessageBox.Show(PublicFunction.L_GetLabel(this.Name,11));
				return;
			}	

			string sql="";
			
			if(!ExportStructure(conmdb,con))
			{
				stop=true;
				MessageBox.Show("Error!!!!");
				lll.Text="Error!!!!";			
				CL();
				return;
			}


			sql = "select name,id,xtype,-1 as t from sysobjects where xtype='u' Order by name";
			Func.RecordSet rstb=new Func.RecordSet(sql,con);
			for(int i=0;i<rstb.rows;i++)
			{
				if(stop)
				{
					CL();
					return;
				}
				ll.Text=rstb.record(i,"name");
				if(rstb.record(i,"name")!="dtproperties")
				{
					string wh="";
					wh=Get_where(rstb.record(i,"name"),con);
					if(wh!="+BOQUA+")
					{
						if(!ExportTable(rstb.record(i,"name"),wh,conmdb,con))
						{
							stop=true;
							MessageBox.Show("Error!!!! " +rstb.record(i,"name"));
							lll.Text="Error!!!!";						
							CL();
							return;
						}
					}
				}
				pro.Value=(int)((i+1)*100/rstb.rows);
			}				
			pro.Value=100;
			lll.Text=PublicFunction.L_GetLabel(this.Name,10);
			MessageBox.Show(PublicFunction.L_GetLabel(this.Name,10));
			con.Close();
			conmdb.Close();
			stop=true;
			CL();
		}

		private void CopyFile()
		{			
			copythumuc(PublicFunction.Path,txt3.Text);
		}

		

		private string Get_where(string tb,SqlConnection con)
		{
			string sql="Select * from GP_BACKUP where tb=N'"+tb+"'";
			Func.RecordSet rs=new Func.RecordSet(sql,con);
			if(rs.rows<=0)
				return "";
			string wh="";
			if(rs.record(0,"BOQUA")+""=="1")
			{
				return "+BOQUA+";
			}
			if(rs.record(0,"YYY_MM")+""!="")
			{
				if(wh!="") wh+=" and ";
				wh+= rs.record(0,"YYY_MM")+" between '"+mm1.Text+"' and '"+mm1.Text+"'";
			}
			if(rs.record(0,"YYY_MM_DD")+""!="")
			{
				if(wh!="") wh+=" and ";
				wh+= rs.record(0,"YYY_MM_DD")+" between '"+DateTime.Parse(dt1.Value +"") +"' and '"+DateTime.Parse(dt2.Value +"") +"'";
			}
			if(rs.record(0,"CON")+""!="")
			{
				if(wh!="") wh+=" and ";
				wh+= rs.record(0,"CON");
			}
			return wh;
		}

		private void CL()
		{
			cmd_stop.Visible=!stop;
			cmd_OK.Visible=stop;
		}

		

		#region MDB
		private Boolean ExportTable(string table,string wh, OleDbConnection conm,SqlConnection con)
		{
			string sql="";			
			sql="DROP VIEW TAN_BK";
			try
			{
				PublicFunction.SQL_Execute(sql,con);
			}
			catch{}	
			sql="Create View TAN_BK as Select * from ["+ table+"]";
			if(wh!="")
				sql+=" where " +wh;
			PublicFunction.SQL_Execute(sql,con,true);

			RecordSetMDB rs1=new RecordSetMDB("Select * from EXP_TB where tb='"+table+"'",conm);

			if(rs1.rows<=0)
			{
				sql= "SELECT * INTO [" + table + 
					"] FROM [ODBC;Driver=SQL Server;SERVER=" + PublicFunction.DT_server + ";DATABASE=" + PublicFunction.DT_database ;
				sql = sql + ";UID=" + PublicFunction.DT_username  + ";PWD=" + PublicFunction.DT_password  + ";].[TAN_BK]";
				//				if(wh!="")
				//					sql+=" where " +wh;
			}
			else
			{
				sql= "Insert INTO [" + table + 
					"] SELECT *  FROM [ODBC;Driver=SQL Server;SERVER=" + PublicFunction.DT_server + ";DATABASE=" + PublicFunction.DT_database ;
				sql = sql + ";UID=" + PublicFunction.DT_username  + ";PWD=" + PublicFunction.DT_password  + ";].[TAN_BK]";
				//				if(wh!="")
				//					sql+=" where " +wh;
			}
			Boolean t= Excute_MDB(sql,conm);			
			sql="Insert Into EXP_TB values('"+table+"')";
			Excute_MDB(sql,conm);
			sql="DROP VIEW TAN_BK";
			PublicFunction.SQL_Execute(sql,con);
			return t;
		}

		private Boolean ExportStructure(OleDbConnection conm,SqlConnection con)
		{
			string sql="";			
			sql="DROP VIEW TAN_BK";
			try
			{
				PublicFunction.SQL_Execute(sql,con);
			}
			catch{}	
		
			sql = "Create View TAN_BK as select name,id from sysobjects where xtype='u' ";
			PublicFunction.SQL_Execute(sql,con,true);
			sql= "SELECT * INTO [hqtan_TB] FROM [ODBC;Driver=SQL Server;SERVER=" + PublicFunction.DT_server + ";DATABASE=" + PublicFunction.DT_database ;
			sql = sql + ";UID=" + PublicFunction.DT_username  + ";PWD=" + PublicFunction.DT_password  + ";].[TAN_BK]";						
			Boolean t= Excute_MDB(sql,conm);
			if(!t)
				return t;	
			sql="DROP VIEW TAN_BK";
			PublicFunction.SQL_Execute(sql,con);


			sql=  " Create View TAN_BK as SELECT c.colid,c.name,ty.name AS datatype,c.length,c.isnullable,c.cdefault,c.prec,c.id" +
				" FROM syscolumns c INNER JOIN systypes ty ON c.xtype = ty.xtype WHERE (ty.name <> N'sysname')"+
				" and  c.id in(select id from sysobjects where xtype='u')  ";			
			PublicFunction.SQL_Execute(sql,con,true);			
			sql= "SELECT * INTO [hqtan_FD] FROM [ODBC;Driver=SQL Server;SERVER=" + PublicFunction.DT_server + ";DATABASE=" + PublicFunction.DT_database ;
			sql = sql + ";UID=" + PublicFunction.DT_username  + ";PWD=" + PublicFunction.DT_password  + ";].[TAN_BK]";						
			t= Excute_MDB(sql,conm);			
		
			sql="DROP VIEW TAN_BK";
			PublicFunction.SQL_Execute(sql,con);

			return t;			
		}
		private OleDbConnection  ConnectMDB(string filename)
		{			
			try
			{
				System.IO.File.Copy(PublicFunction.Path+"\\Dll\\Blank.mdb",filename,true);
				string st="Provider=Microsoft.Jet.OLEDB.4.0;Data Source="
					+filename+";Jet OLEDB:Database Password=p@ssw0rd411982;";
				OleDbConnection conm = new OleDbConnection(st);				
				conm.Open();										
				string sql="Create Table EXP_TB(tb memo)";	
				Excute_MDB(sql,conm);		
				sql="Create Table EXP_INFO(tb memo,thumuc memo)";	
				Excute_MDB(sql,conm);
				sql="Insert Into EXP_INFO values('Date:"+DateTime.Parse(dt1.Value+"").ToString("yyyy/MM/dd")+
					"~"+DateTime.Parse(dt2.Value+"").ToString("yyyy/MM/dd") +
					". Year/Month:"+mm1.Text +"~"+mm2.Text+ "','"+GetName(PublicFunction.Path)+"')";
				Excute_MDB(sql,conm);
				sql="Insert Into SENDER values('"+PublicFunction.A_UserID+"','"+T_String.GetDate().ToString("yyyy/MM/dd HH:mm:ss") +"')";
				Excute_MDB(sql,conm);
				return conm;
			}
			catch(Exception)
			{
				//MessageBox.Show("Can't connect to MDB file");
				return null;
			}
		}
	

		private Boolean Excute_MDB(string sql,OleDbConnection conm)
		{
			try
			{
				OleDbCommand cmd=new OleDbCommand(sql,conm);
				cmd.ExecuteNonQuery();
				return true;
			}
			catch(OleDbException ex)
			{
				MessageBox.Show(ex.Message);
				return false;
			}
		}
		#endregion

		Boolean stop=false;
		private void cmd_stop_Click(object sender, System.EventArgs e)
		{
			stop=true;;
		}

		private void cmd_close_Click(object sender, System.EventArgs e)
		{
			stop=true;;
			this.Close();
		}

		#region	 record
		public class RecordSetMDB
		{
			public DataSet ds;
			public int  rows;
			public int cols;
			public int Bookmarks;
			public RecordSetMDB(string sql,OleDbConnection con)
			{
				ds=new DataSet();			
				try
				{				
					OleDbDataAdapter cmd=new OleDbDataAdapter(sql,con);			
					cmd.Fill(ds);
					rows=ds.Tables[0].Rows.Count;
					cols=ds.Tables[0].Columns.Count;				
				}
				catch(OleDbException ex )
				{
					MessageBox.Show(ex.Message +"..SQL Error. Sql: " + sql);				
				}
			}
		
			public string record(int row,int col)
			{
				try
				{
					if (ds.Tables[0].Rows[row][col].ToString()=="")
						return null;
					return ds.Tables[0].Rows[row][col].ToString();
				}
				catch(Exception)
				{
			
					return null;
				}
			}

			public string record(int row,string col)
			{
				try
				{
					if (ds.Tables[0].Rows[row][col].ToString()=="")
						return null;
					return ds.Tables[0].Rows[row][col].ToString();
				}
				catch(Exception)
				{
					return null;
				}
			}

			public string Field(int col)
			{
				try
				{
					return ds.Tables[0].Columns[col].ColumnName;
				}
				catch(Exception ex)
				{
					MessageBox.Show( ds.Tables[0].TableName+ " . Description Error:" + ex.Message  );
					return "";
				}
			}

		}
		#endregion		
		#region copy file
		private void copythumuc(string thumuc,string des)
		{			
			string tenthumuc=GetName(thumuc);
			Directory.CreateDirectory(des+"\\"+tenthumuc);
			string []a=Directory.GetFiles(thumuc);
			string []b=Directory.GetDirectories(thumuc);
			for(int i=0;i<a.Length;i++)
			{
				if(stop)
				{				
					return;
				}
				string st=a[i];
				string st1=des+"\\"+tenthumuc+"\\"+GetName(a[i]+"");
				ll.Text=GetName(a[i]);
				File.Copy(st,st1,true);				
			}
			for(int i=0;i<b.Length;i++)
			{
				string st=b[i];
				string st1=des+"\\"+tenthumuc+"\\"+GetName(b[i]+"");
				copythumuc(st,st1);
			}
		}
		private string GetName(string thumuc)
		{
			int n=thumuc.LastIndexOf("\\");
			return thumuc.Remove(0,n+1);
		}
		#endregion
	

	}
}
