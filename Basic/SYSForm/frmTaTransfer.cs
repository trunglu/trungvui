using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Threading;
using System.Data;
using System.Data.SqlClient;
using GP8000.Function;
using Basic.Form;
using Basic.Function;

namespace GP8000.SYSForm
{
	/// <summary>
	/// Summary description for frmTaTransfer.
	/// </summary>
	public class frmTaTransfer : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txt_server;
		private System.Windows.Forms.TextBox txt_data;
		private System.Windows.Forms.TextBox txt_user;
		private System.Windows.Forms.TextBox txt_pass;
		private System.Windows.Forms.Button button1;
		double m;
		private System.Windows.Forms.ProgressBar pro;
		private System.Windows.Forms.Label lb;
		private System.Windows.Forms.Label lb1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmTaTransfer()
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
			this.txt_server = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txt_data = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txt_user = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txt_pass = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.pro = new System.Windows.Forms.ProgressBar();
			this.lb = new System.Windows.Forms.Label();
			this.lb1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txt_server
			// 
			this.txt_server.Location = new System.Drawing.Point(116, 12);
			this.txt_server.Name = "txt_server";
			this.txt_server.Size = new System.Drawing.Size(188, 23);
			this.txt_server.TabIndex = 0;
			this.txt_server.Text = "10.0.0.86";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(24, 20);
			this.label1.Name = "label1";
			this.label1.TabIndex = 1;
			this.label1.Text = "Server";
			// 
			// txt_data
			// 
			this.txt_data.Location = new System.Drawing.Point(116, 40);
			this.txt_data.Name = "txt_data";
			this.txt_data.Size = new System.Drawing.Size(188, 23);
			this.txt_data.TabIndex = 2;
			this.txt_data.Text = "GP_cartina";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(24, 48);
			this.label2.Name = "label2";
			this.label2.TabIndex = 3;
			this.label2.Text = "Database";
			// 
			// txt_user
			// 
			this.txt_user.Location = new System.Drawing.Point(408, 8);
			this.txt_user.Name = "txt_user";
			this.txt_user.Size = new System.Drawing.Size(188, 23);
			this.txt_user.TabIndex = 4;
			this.txt_user.Text = "sa";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(316, 16);
			this.label3.Name = "label3";
			this.label3.TabIndex = 5;
			this.label3.Text = "User ID";
			// 
			// txt_pass
			// 
			this.txt_pass.Location = new System.Drawing.Point(408, 36);
			this.txt_pass.Name = "txt_pass";
			this.txt_pass.Size = new System.Drawing.Size(188, 23);
			this.txt_pass.TabIndex = 6;
			this.txt_pass.Text = "";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(316, 44);
			this.label4.Name = "label4";
			this.label4.TabIndex = 7;
			this.label4.Text = "Password";
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button1.Location = new System.Drawing.Point(244, 148);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(96, 32);
			this.button1.TabIndex = 8;
			this.button1.Text = "Transfer";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// pro
			// 
			this.pro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pro.Location = new System.Drawing.Point(0, 76);
			this.pro.Name = "pro";
			this.pro.Size = new System.Drawing.Size(736, 16);
			this.pro.TabIndex = 9;
			// 
			// lb
			// 
			this.lb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.lb.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.lb.ForeColor = System.Drawing.Color.White;
			this.lb.Location = new System.Drawing.Point(0, 92);
			this.lb.Name = "lb";
			this.lb.Size = new System.Drawing.Size(732, 23);
			this.lb.TabIndex = 10;
			this.lb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lb1
			// 
			this.lb1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.lb1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.lb1.ForeColor = System.Drawing.Color.White;
			this.lb1.Location = new System.Drawing.Point(0, 116);
			this.lb1.Name = "lb1";
			this.lb1.Size = new System.Drawing.Size(732, 23);
			this.lb1.TabIndex = 11;
			this.lb1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// frmTaTransfer
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
			this.ClientSize = new System.Drawing.Size(732, 420);
			this.Controls.Add(this.lb1);
			this.Controls.Add(this.lb);
			this.Controls.Add(this.pro);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.txt_pass);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txt_user);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txt_data);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txt_server);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "frmTaTransfer";
			this.Text = "frmTaTransfer";
			this.ResumeLayout(false);

		}
		#endregion

		private void button1_Click(object sender, System.EventArgs e)
		{
			Thread th=new Thread(new ThreadStart(Tran));
			th.Start();
		}
		private void Tran()
		{
			SqlConnection convb=PublicFunction.connect(txt_server.Text,txt_data.Text,txt_user.Text,txt_pass.Text);
			SqlConnection con=new SqlConnection( PublicFunction.C_con.ConnectionString);
			m=0;
			if(convb.State==ConnectionState.Closed )
				convb.Open();
			if(con.State==ConnectionState.Closed )
				con.Open();
			
			FILA02A(convb,con);
			FILA03A(convb,con);
			FILA04A(convb,con);
			FILA05A(convb,con);
			FILA06A(convb,con);
			FILA07A(convb,con);
			FILA08A(convb,con);
			FILA09A(convb,con);
			FILA10A(convb,con);
			FILA11A(convb,con);
			FILA12A(convb,con);
			FILA13A(convb,con);
			FILA14A(convb,con);
			FILA15A(convb,con);
			FILB01A(convb,con);
			//FILC01A(convb,con);
			FILC03A(convb,con);

			convb.Close();
			con.Close();
		}

		private void FILA02A(SqlConnection convb,SqlConnection con)
		{
			string sql="Select * from Department";
			Func.RecordSet rs=new Func.RecordSet(sql,convb);
			sql="Delete  from FILA02A";
			PublicFunction.SQL_Execute(sql,con,true);
			for(int i=0;i<rs.rows;i++)
			{
				sql="Insert Into FILA02A(DEP_ID,DEP_NM,DEP_N1,DEP_HG,PEO_TT) values(";
				sql+="N'"+rs.record(i,"DeptID")+"',N'"+rs.record(i,"DeptName")+"',";
				sql+="N'"+rs.record(i,"DeptNameF")+"',N'"+rs.record(i,"Higher_upID")+"',";
				sql+="'"+rs.record(i,"Total")+"')";
				PublicFunction.SQL_Execute(sql,con,true);
				pro.Value=(int) ((i+1)*100/rs.rows);	
				m++;
				lb.Text=i+"/"+rs.rows +" FILA02A";
				lb1.Text=m+"";
			}
		}
		private void FILA03A(SqlConnection convb,SqlConnection con)
		{
			string sql="Select * from City";
			Func.RecordSet rs=new Func.RecordSet(sql,convb);
			sql="Delete  from FILA03A";
			PublicFunction.SQL_Execute(sql,con,true);
			for(int i=0;i<rs.rows;i++)
			{
				sql="Insert Into FILA03A(CIT_ID,CIT_NM) values(";
				sql+="N'"+ PublicFunction.S_Right("000"+rs.record(i,"ID_City"),3)+"',N'"+rs.record(i,"CityName")+"')";				
				PublicFunction.SQL_Execute(sql,con,true);
				m++;
				pro.Value=(int) ((i+1)*100/rs.rows);	
				m++;
				lb.Text=i+"/"+rs.rows +" FILA03A";
				lb1.Text=m+"";
			}
		}
		private void FILA04A(SqlConnection convb,SqlConnection con)
		{
			string sql="Select * from Education";
			Func.RecordSet rs=new Func.RecordSet(sql,convb);
			sql="Delete  from FILA04A";
			PublicFunction.SQL_Execute(sql,con,true);
			for(int i=0;i<rs.rows;i++)
			{
				sql="Insert Into FILA04A(EDU_ID,EDU_NM) values(";
				sql+="N'"+ PublicFunction.S_Right("000"+rs.record(i,"ID_Education"),3)+"',N'"+rs.record(i,"EduName")+"')";				
				PublicFunction.SQL_Execute(sql,con,true);
				pro.Value=(int) ((i+1)*100/rs.rows);	
				m++;
				lb.Text=i+"/"+rs.rows +" FILA04A";
				lb1.Text=m+"";
				
			}
		}
		private void FILA05A(SqlConnection convb,SqlConnection con)
		{
			string sql="Select * from Profession";
			Func.RecordSet rs=new Func.RecordSet(sql,convb);
			sql="Delete  from FILA05A";
			PublicFunction.SQL_Execute(sql,con,true);
			for(int i=0;i<rs.rows;i++)
			{
				sql="Insert Into FILA05A(PRO_ID,PRO_NM) values(";
				sql+="N'"+ PublicFunction.S_Right("000"+rs.record(i,"ID_Profession"),3)+"',N'"+rs.record(i,"ProName")+"')";				
				PublicFunction.SQL_Execute(sql,con,true);
				pro.Value=(int) ((i+1)*100/rs.rows);			
				m++;
				lb.Text=i+"/"+rs.rows +" FILA05A";
				lb1.Text=m+"";
			}
		}
		private void FILA06A(SqlConnection convb,SqlConnection con)
		{
			string sql="Select * from VacateList";
			Func.RecordSet rs=new Func.RecordSet(sql,convb);
			sql="Delete  from FILA06A";
			PublicFunction.SQL_Execute(sql,con,true);
			for(int i=0;i<rs.rows;i++)
			{
				sql="Insert Into FILA06A(VAC_ID,VAC_NM) values(";
				sql+="N'"+ PublicFunction.S_Right("000"+rs.record(i,"ID_VacateList"),3)+"',N'"+rs.record(i,"Name")+"')";				
				PublicFunction.SQL_Execute(sql,con,true);							
				m++;
				pro.Value=(int) ((i+1)*100/rs.rows);		
				lb.Text=i+"/"+rs.rows +" FILA06A";
				lb1.Text=m+"";
			}
		}
		private void FILA07A(SqlConnection convb,SqlConnection con)
		{
			string sql="Select * from Position";
			Func.RecordSet rs=new Func.RecordSet(sql,convb);
			sql="Delete  from FILA07A";
			PublicFunction.SQL_Execute(sql,con,true);
			for(int i=0;i<rs.rows;i++)
			{
				sql="Insert Into FILA07A(POS_ID,POS_NM,POS_N1) values(";
				sql+="N'"+ PublicFunction.S_Right("000"+rs.record(i,"ID_Position"),3)+"',N'"+rs.record(i,"PosName")+"',";
				sql+="N'"+rs.record(i,"PostNameF")+"')";				
				PublicFunction.SQL_Execute(sql,con,true);
				m++;
				pro.Value=(int) ((i+1)*100/rs.rows);	
				lb.Text=i+"/"+rs.rows +" FILA07A";
				lb1.Text=m+"";
			}
		}
		private void FILA08A(SqlConnection convb,SqlConnection con)
		{
			string sql="Select * from GroupTable";
			Func.RecordSet rs=new Func.RecordSet(sql,convb);
			sql="Delete  from FILA08A";
			PublicFunction.SQL_Execute(sql,con,true);
			for(int i=0;i<rs.rows;i++)
			{
				sql="Insert Into FILA08A(GRP_ID,GRP_NM) values(";
				sql+="N'"+ PublicFunction.S_Right("000"+rs.record(i,"ID_Group"),3)+"',N'"+rs.record(i,"gName")+"')";				
				PublicFunction.SQL_Execute(sql,con,true);
				m++;
				pro.Value=(int) ((i+1)*100/rs.rows);	
				lb.Text=i+"/"+rs.rows +" FILA08A";
				lb1.Text=m+"";
			}
		}
		private void FILA09A(SqlConnection convb,SqlConnection con)
		{
			string sql="Select * from GroupType";
			Func.RecordSet rs=new Func.RecordSet(sql,convb);
			sql="Delete  from FILA09A";
			PublicFunction.SQL_Execute(sql,con,true);
			for(int i=0;i<rs.rows;i++)
			{
				sql="Insert Into FILA09A(GRT_ID,GRT_NM,GRP_ID,AMT_QT) values(";
				sql+="N'"+ PublicFunction.S_Right("000"+rs.record(i,"ID_GroupType"),3)+"',N'"+rs.record(i,"gtName")+"',";
				sql+="N'"+ PublicFunction.S_Right("000"+rs.record(i,"ID_Group"),3)+"','"+rs.record(i,"AMOUNT")+"')";
				PublicFunction.SQL_Execute(sql,con,true);
				m++;
				pro.Value=(int) ((i+1)*100/rs.rows);	
				lb.Text=i+"/"+rs.rows +" FILA09A";
				lb1.Text=m+"";
			}
		}
		private void FILA10A(SqlConnection convb,SqlConnection con)
		{
			string sql="Select * from Graduation";
			Func.RecordSet rs=new Func.RecordSet(sql,convb);
			sql="Delete  from FILA10A";
			PublicFunction.SQL_Execute(sql,con,true);
			for(int i=0;i<rs.rows;i++)
			{
				sql="Insert Into FILA10A(GRA_ID,GRA_NM) values(";
				sql+="N'"+ PublicFunction.S_Right("000"+rs.record(i,"ID_Graduation"),3)+"',N'"+rs.record(i,"GraName")+"')";				
				PublicFunction.SQL_Execute(sql,con,true);
				m++;
				pro.Value=(int) ((i+1)*100/rs.rows);	
				lb.Text=i+"/"+rs.rows +" FILA10A";
				lb1.Text=m+"";
			}
		}
		private void FILA11A(SqlConnection convb,SqlConnection con)
		{
			string sql="Select * from Type";
			Func.RecordSet rs=new Func.RecordSet(sql,convb);
			sql="Delete  from FILA11A";
			PublicFunction.SQL_Execute(sql,con,true);
			for(int i=0;i<rs.rows;i++)
			{
				sql="Insert Into FILA11A(TYP_ID,TYP_NM) values(";
				sql+="N'"+ PublicFunction.S_Right("000"+rs.record(i,"ID_Type"),3)+"',N'"+rs.record(i,"Name")+"')";				
				PublicFunction.SQL_Execute(sql,con,true);
				m++;
				pro.Value=(int) ((i+1)*100/rs.rows);	
				lb.Text=i+"/"+rs.rows +" FILA11A";
				lb1.Text=m+"";
			}
		}
		private void FILA12A(SqlConnection convb,SqlConnection con)
		{
			string sql="Select * from Country";
			Func.RecordSet rs=new Func.RecordSet(sql,convb);
			sql="Delete  from FILA12A";
			PublicFunction.SQL_Execute(sql,con,true);
			for(int i=0;i<rs.rows;i++)
			{
				sql="Insert Into FILA12A(COU_ID,COU_NM) values(";
				sql+="N'"+ PublicFunction.S_Right("000"+rs.record(i,"ID_Country"),3)+"',N'"+rs.record(i,"Name")+"')";				
				PublicFunction.SQL_Execute(sql,con,true);
				m++;
				pro.Value=(int) ((i+1)*100/rs.rows);	
				lb.Text=i+"/"+rs.rows +" FILA12A";
				lb1.Text=m+"";
			}
		}
		private void FILA13A(SqlConnection convb,SqlConnection con)
		{
			string sql="Select * from BonusFinedList";
			Func.RecordSet rs=new Func.RecordSet(sql,convb);
			sql="Delete  from FILA13A";
			PublicFunction.SQL_Execute(sql,con,true);
			for(int i=0;i<rs.rows;i++)
			{
				sql="Insert Into FILA13A(BAF_ID,BAF_NM,TPE_ID,AMT_QT) values(";
				sql+="N'"+ PublicFunction.S_Right("000"+rs.record(i,"ID_BonusFinedList"),3)+"',N'"+rs.record(i,"Name")+"',";
				sql+="N'"+rs.record(i,"Type")+"','"+rs.record(i,"Amount")+"')";				
				PublicFunction.SQL_Execute(sql,con,true);
				m++;
				pro.Value=(int) ((i+1)*100/rs.rows);	
				lb.Text=i+"/"+rs.rows +" FILA13A";
				lb1.Text=m+"";
			}
		}
		private void FILA14A(SqlConnection convb,SqlConnection con)
		{
			string sql="Select * from JuryType";
			Func.RecordSet rs=new Func.RecordSet(sql,convb);
			sql="Delete  from FILA14A";
			PublicFunction.SQL_Execute(sql,con,true);
			for(int i=0;i<rs.rows;i++)
			{
				sql="Insert Into FILA14A(JUR_ID,JUR_NM) values(";
				sql+="N'"+ PublicFunction.S_Right("000"+rs.record(i,"ID_JuryType"),3)+"',N'"+rs.record(i,"Name")+"')";				
				PublicFunction.SQL_Execute(sql,con,true);
				m++;
				pro.Value=(int) ((i+1)*100/rs.rows);	
				lb.Text=i+"/"+rs.rows +" FILA14A";
				lb1.Text=m+"";
			}
		}
		private void FILA15A(SqlConnection convb,SqlConnection con)
		{
			string sql="Select * from MLeaveList";
			Func.RecordSet rs=new Func.RecordSet(sql,convb);
			sql="Delete  from FILA15A";
			PublicFunction.SQL_Execute(sql,con,true);
			for(int i=0;i<rs.rows;i++)
			{
				sql="Insert Into FILA15A(LEA_ID,LEA_NM) values(";
				sql+="N'"+ PublicFunction.S_Right("000"+rs.record(i,"ID_MLeaveList"),3)+"',N'"+rs.record(i,"Name")+"')";				
				PublicFunction.SQL_Execute(sql,con,true);
				m++;
				pro.Value=(int) ((i+1)*100/rs.rows);	
				lb.Text=i+"/"+rs.rows +" FILA15A";
				lb1.Text=m+"";
			}
		}

		private void FILC01A(SqlConnection convb,SqlConnection con)
		{
			string sql="Select * from DataSwitch";
			Func.RecordSet rs=new Func.RecordSet(sql,convb);
			sql="Delete  from FILC01A";
			PublicFunction.SQL_Execute(sql,con,true);
			for(int i=0;i<rs.rows;i++)
			{
				sql="Insert Into FILC01A(DAT_TM,EMP_ID,CRD_DT,CRD_TM,CRD_NO,REA_NO) values(";
				sql+="N'"+ GetDT(rs.record(i,"dDate"),"yyyyMMdd")+rs.record(i,"dTime")+"',N'"+rs.record(i,"ID_Employee")+"',";
				sql+=""+ GetDT(rs.record(i,"dDate"))+",'"+rs.record(i,"dTime")+"',";				
				sql+="N'"+ rs.record(i,"CardNo")+"',N'"+rs.record(i,"ReaderNo")+"')";				
				PublicFunction.SQL_Execute(sql,con,true);
				m++;
				pro.Value=(int) ((i+1)*100/rs.rows);	
				lb.Text=i+"/"+rs.rows +" FILC01A";
				lb1.Text=m+"";
			}
		}
		private void FILC03A(SqlConnection convb,SqlConnection con)
		{
			string sql="Select * from MonthShift";
			string v="";
			Func.RecordSet rs=new Func.RecordSet(sql,convb);
			sql="Delete  from FILC03A";
			PublicFunction.SQL_Execute(sql,con,true);
			for(int i=0;i<rs.rows;i++)
			{
				sql="Insert Into FILC03A(EMP_ID,YYY_MM";
				v="";
				for(int n=1;n<=31;n++)
				{
					sql+=",DAY_"+n.ToString("00");
					v+=",N'"+rs.record(i,"m"+n.ToString("00"))+"'";
				}
				sql+=") values(";
				sql+="N'"+rs.record(i,"ID_Employee")+"',";
				sql+="N'"+ rs.record(i,"YM")+"'";			
				sql+=v+")";
				PublicFunction.SQL_Execute(sql,con,true);
				m++;
				pro.Value=(int) ((i+1)*100/rs.rows);	
				lb.Text=i+"/"+rs.rows +" FILC03A";
				lb1.Text=m+"";				
			}
		}
		
		private void FILB01A(SqlConnection convb,SqlConnection con)
		{
			string sql="Select * from Employee";
			Func.RecordSet rs=new Func.RecordSet(sql,convb);
			sql="Delete  from FILB01A";
			PublicFunction.SQL_Execute(sql,con,true);
			for(int i=0;i<rs.rows;i++)
			{
				sql="Insert Into FILB01A(EMP_ID,EMP_I1,EMP_NM,EMP_N1,BIR_DT,SEX_BT,MAR_BT"+
					",DEP_ID,COU_ID,CRD_NO,POS_ID,ADD_DR,ADD_D1,INH_DT,CRD_ID,CRD_DT"+
					",CRD_LC,CIT_ID,RAC_NM,NAT_CO,EDU_ID,PRO_ID,GRA_ID,TEL_NO,TYP_ID"+
					",ACC_NO,ACC_NM,BNK_NM,NEW_BT,MEA_BT,REM_DR,ATT_BT,VAC_BT,DEL_BT"+
					",GRT_ID,GRP_ID,LCK_BT,BHX_BT,DIR_BT"+
					") values(";



				sql+="N'"+ rs.record(i,"ID_Employee")+"',N'"+rs.record(i,"eCard")+"',";
				sql+="N'"+ rs.record(i,"eName")+"',N'"+rs.record(i,"eNameF")+"',";
				sql+="N'"+ GetDT1(rs.record(i,"eDOB"))+"',N'"+rs.record(i,"eSex")+"',";
				sql+="N'"+ rs.record(i,"eMarriage")+"',N'"+rs.record(i,"eDepartment")+"',";
				sql+="N'"+ PublicFunction.S_Right("000"+rs.record(i,"eNationality"),3)+"',N'"+rs.record(i,"eCardNo")+"',";
				sql+="N'"+ PublicFunction.S_Right("000"+rs.record(i,"ePosition"),3)+"',N'"+rs.record(i,"eAddress")+"',";
				sql+="N'"+rs.record(i,"ePAddress")+"',"+GetDT(rs.record(i,"eInHouseDay"))+",";
				sql+="N'"+rs.record(i,"eIDCard")+"',"+GetDT(rs.record(i,"IDCARDDATE"))+",";
				sql+="N'"+rs.record(i,"IDCARDLOC")+"',N'"+PublicFunction.S_Right("000"+rs.record(i,"eCity"),3)+"',";
				sql+="N'"+rs.record(i,"DanToc")+"',N'"+PublicFunction.S_Right("000"+rs.record(i,"NguyenQuan"),3)+"',";
				sql+="N'"+PublicFunction.S_Right("000"+rs.record(i,"eEducation"),3)+"',N'"+PublicFunction.S_Right("000"+rs.record(i,"eProfession"),3)+"',";
				sql+="N'"+PublicFunction.S_Right("000"+rs.record(i,"eGraduation"),3)+"',N'"+rs.record(i,"eTel")+"',";
				sql+="N'"+PublicFunction.S_Right("000"+rs.record(i,"eType"),3)+"',";
				sql+="N'"+rs.record(i,"NO_ATM")+"',N'"+rs.record(i,"ATMAccountName")+"',";
				sql+="N'"+rs.record(i,"ATMOffices")+"',N'"+rs.record(i,"eNewOld")+"',";
				sql+="N'"+rs.record(i,"eMeal")+"',N'"+rs.record(i,"eNote")+"',";
				sql+="N'"+rs.record(i,"eAttendanceCard")+"',N'"+rs.record(i,"eVacate")+"',";
				sql+="N'"+rs.record(i,"eDel")+"',";
				sql+="N'"+PublicFunction.S_Right("000"+rs.record(i,"eTypeGroup"),3)+"',N'"+PublicFunction.S_Right("000"+rs.record(i,"eGroup"),3)+"',";
				sql+="N'"+rs.record(i,"eLock")+"',N'"+rs.record(i,"eBitInsurance")+"',";
				sql+="N'"+rs.record(i,"eTypeLabour")+"')";

				PublicFunction.SQL_Execute(sql,con,true);
				m++;
				pro.Value=(int) ((i+1)*100/rs.rows);	
				lb.Text=i+"/"+rs.rows +" FILB01A";
				lb1.Text=m+"";
			}
		}	
		private string GetDT(string dt)
		{
			try
			{
				return "'"+DateTime.Parse(dt).ToString("yyyy/MM/dd")+"'";
			}
			catch{return "Default";
			}
		}
		private string GetDT(string dt,string format)
		{
			try
			{
				return ""+DateTime.Parse(dt).ToString(format)+"";
			}
			catch
			{
				return "Default";
			}
		}
		private string GetDT1(string dt)
		{
			try
			{
				return DateTime.Parse(dt).ToString("yyyy/MM/dd");
			}
			catch
			{
				if(dt!="")
					return dt;
				return "Default";
			}
		}
	}
}
