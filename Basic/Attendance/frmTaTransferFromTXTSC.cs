using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using Basic.Form;
using Basic.Function;
using System.IO;
using System.Text;
using System.Threading;
using System.Data;
using System.Data.SqlClient;
using System.Data.OleDb;
using ADODB;
using System.Globalization;
//using System.Globalization;

namespace GP8000.Attendance
{
	/// <summary>
	/// Summary description for frmTaTransferFromTXT.
	/// </summary>
	public class frmTaTransferFromTXTSC : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel5;
		private string dt;// ngay hien tai
		private int CRD_MN;// so phut the lap lai
		private ArrayList EMP_ID,CRD_NO;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.ListBox lb1;
		private System.Windows.Forms.ListBox lb2;
		private System.Windows.Forms.ListBox lb3;
		private System.Windows.Forms.ListBox lb4;
		private System.Windows.Forms.Label c1;
		private System.Windows.Forms.Button button1;
		private Boolean stop,fin1,fin2;
		private System.Windows.Forms.Label c2;
		private string sReaNo_VS1,sReaNo_VS2;		
		//private string BT;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmTaTransferFromTXTSC()
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
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel5 = new System.Windows.Forms.Panel();
			this.button1 = new System.Windows.Forms.Button();
			this.c1 = new System.Windows.Forms.Label();
			this.panel4 = new System.Windows.Forms.Panel();
			this.panel7 = new System.Windows.Forms.Panel();
			this.lb4 = new System.Windows.Forms.ListBox();
			this.lb3 = new System.Windows.Forms.ListBox();
			this.panel6 = new System.Windows.Forms.Panel();
			this.lb2 = new System.Windows.Forms.ListBox();
			this.lb1 = new System.Windows.Forms.ListBox();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label5 = new System.Windows.Forms.Label();
			this.c2 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel5.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel7.SuspendLayout();
			this.panel6.SuspendLayout();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Controls.Add(this.panel3);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(780, 400);
			this.panel1.TabIndex = 0;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.panel5);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 36);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(780, 364);
			this.panel2.TabIndex = 14;
			// 
			// panel5
			// 
			this.panel5.Controls.Add(this.button1);
			this.panel5.Controls.Add(this.panel4);
			this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel5.Location = new System.Drawing.Point(0, 0);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(780, 364);
			this.panel5.TabIndex = 1;
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button1.Location = new System.Drawing.Point(336, 324);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(108, 36);
			this.button1.TabIndex = 7;
			this.button1.Text = "Stop";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// c1
			// 
			this.c1.BackColor = System.Drawing.Color.Black;
			this.c1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.c1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.c1.ForeColor = System.Drawing.Color.White;
			this.c1.Location = new System.Drawing.Point(0, 293);
			this.c1.Name = "c1";
			this.c1.Size = new System.Drawing.Size(384, 23);
			this.c1.TabIndex = 6;
			this.c1.Tag = "N";
			this.c1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.panel7);
			this.panel4.Controls.Add(this.panel6);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel4.Location = new System.Drawing.Point(0, 0);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(780, 316);
			this.panel4.TabIndex = 0;
			// 
			// panel7
			// 
			this.panel7.Controls.Add(this.lb4);
			this.panel7.Controls.Add(this.lb3);
			this.panel7.Controls.Add(this.c2);
			this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel7.Location = new System.Drawing.Point(384, 0);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(396, 316);
			this.panel7.TabIndex = 1;
			// 
			// lb4
			// 
			this.lb4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lb4.ItemHeight = 16;
			this.lb4.Location = new System.Drawing.Point(136, 0);
			this.lb4.Name = "lb4";
			this.lb4.Size = new System.Drawing.Size(260, 292);
			this.lb4.TabIndex = 6;			
			// 
			// lb3
			// 
			this.lb3.Dock = System.Windows.Forms.DockStyle.Left;
			this.lb3.ItemHeight = 16;
			this.lb3.Location = new System.Drawing.Point(0, 0);
			this.lb3.Name = "lb3";
			this.lb3.Size = new System.Drawing.Size(136, 292);
			this.lb3.TabIndex = 4;
			// 
			// panel6
			// 
			this.panel6.Controls.Add(this.lb2);
			this.panel6.Controls.Add(this.lb1);
			this.panel6.Controls.Add(this.c1);
			this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel6.Location = new System.Drawing.Point(0, 0);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(384, 316);
			this.panel6.TabIndex = 0;
			// 
			// lb2
			// 
			this.lb2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lb2.ItemHeight = 16;
			this.lb2.Location = new System.Drawing.Point(136, 0);
			this.lb2.Name = "lb2";
			this.lb2.Size = new System.Drawing.Size(248, 292);
			this.lb2.TabIndex = 5;
			// 
			// lb1
			// 
			this.lb1.Dock = System.Windows.Forms.DockStyle.Left;
			this.lb1.ItemHeight = 16;
			this.lb1.Location = new System.Drawing.Point(0, 0);
			this.lb1.Name = "lb1";
			this.lb1.Size = new System.Drawing.Size(136, 292);
			this.lb1.TabIndex = 3;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.panel3.Controls.Add(this.label5);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel3.Location = new System.Drawing.Point(0, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(780, 36);
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
			this.label5.Size = new System.Drawing.Size(780, 36);
			this.label5.TabIndex = 11;
			this.label5.Tag = "";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// c2
			// 
			this.c2.BackColor = System.Drawing.Color.Black;
			this.c2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.c2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.c2.ForeColor = System.Drawing.Color.White;
			this.c2.Location = new System.Drawing.Point(0, 293);
			this.c2.Name = "c2";
			this.c2.Size = new System.Drawing.Size(396, 23);
			this.c2.TabIndex = 7;
			this.c2.Tag = "N";
			this.c2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// frmTaTransferFromTXT
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
			this.ClientSize = new System.Drawing.Size(780, 400);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "frmTaTransferFromTXT";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmTaTransferFromTXT";
			this.Closing += new System.ComponentModel.CancelEventHandler(this.frmTaTransferFromTXT_Closing);
			this.Load += new System.EventHandler(this.frmTaTransferFromTXT_Load);
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel5.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.panel7.ResumeLayout(false);
			this.panel6.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void frmTaTransferFromTXT_Load(object sender, System.EventArgs e)
		{			
			fin1=fin2=false;
			stop=false;
			Get_Staff();
			dt=T_String.GetDate().ToString("yyyy/MM/dd HH:mm");
			CRD_MN=T_String.IsNullTo0(T_String.GetDataFromSQL("CRD_MN","GP_SYS_SETTING"));
			sReaNo_VS1 = PublicFunction.GetOption("MAYTOILET1");
			sReaNo_VS2 = PublicFunction.GetOption("MAYTOILET2");
			sReaNo_VS1+=";"+sReaNo_VS2 ;			
			Thread th1 = new Thread(new ThreadStart(TransferY1));
			th1.Priority = ThreadPriority.Highest;
			th1.Start();
			//TransferY1();
			Thread th2 = new Thread(new ThreadStart(TransferY2));
			th2.Priority = ThreadPriority.Highest;
			th2.Start();
			//TransferY2();

		}

		private void TransferY1()
		{
			TransferY(lb1, lb2, c1, 0, ref fin1);
			if (fin2) this.Close();
		}

		private void TransferY2()
		{
			TransferY(lb3, lb4, c2, 1, ref fin2);
			if (fin1) this.Close();
		}

		private void TransferY(ListBox _lbxFile, ListBox _lbxRecord, Label _lbNumRec, int _iSEQ_NO, ref bool _bFin)
		{
//			bool bContinue = false;
			SqlConnection SqlCon = new SqlConnection(PublicFunction.C_con.ConnectionString);
			SqlCon.Open();
			string keyD="";
			string stype="";
			int iphut=0;
			string str_Con;	//string connection
			ADODB.Connection ad_Con = new ADODB.ConnectionClass();
			ADODB.Recordset ad_Rs = new ADODB.RecordsetClass();

			string S_sDir = T_String.GetDataFromSQL("DIR_DR","GP_SYS_READER","SEQ_NO='" + _iSEQ_NO + "'", SqlCon);
			string S_sFile = T_String.GetDataFromSQL("FIL_NM", "GP_SYS_READER", "SEQ_NO='" + _iSEQ_NO + "'", SqlCon);
			string sDateFormat=PublicFunction.GetOption("SCHEMA_DateFormat");
			string sDouble="";
			sDouble=PublicFunction.GetOption("SCHEMA_DOUBLE");
			int S_dbBook = T_String.IsNullTo0(T_String.GetDataFromSQL("RCD_FG", "GP_SYS_READER", "SEQ_NO='" + _iSEQ_NO + "'", SqlCon));
			string S_sAppPath = Application.StartupPath.ToString(); 
			//key			
			SqlConnection SqlCon1 = new SqlConnection(PublicFunction.C_con.ConnectionString);
			SqlCon1.Open();
			Func.RecordSet rsK=new Func.RecordSet ("Select * from GP_KEY",SqlCon1);
			if (rsK.rows>0)
			{
				stype=rsK.record(0,"TYP_MN") ;
				keyD=PublicFunction.encode(rsK.record(0,"COL_DT"),"") ;
				iphut=T_String.IsNullTo0(rsK.record(0,"COL_MN"));
			}
			
			//end
			DateTime dtFG=AQ800(PublicFunction.S_Left(GetName(S_sFile),8));
			if(dtFG==new DateTime(1,1,1) )//if(PublicFunction.CUS_ID=="400")
			{
				if (!GetFileNameTHU(_lbxFile, S_sDir, S_sFile, SqlCon))
				{
					_bFin = true;
					return;
				}
			}
			else
			{
				if (!GetFileName(_lbxFile, S_sDir, S_sFile, SqlCon))
				{
					_bFin = true;
					return;
				}
			}

			if (!CreateTextFolder(S_sAppPath, _iSEQ_NO))
			{
				_bFin = true;
				return;
			}

			str_Con = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + S_sAppPath + "\\Text" + _iSEQ_NO.ToString() + ";Extended Properties='text;HDR=Yes;FMT=Delimited';";

			if (!ADODB_Connect(ad_Con, str_Con)) 
			{
				_bFin = true;
				return;
			}

			for (int i=0; i<_lbxFile.Items.Count; i++)
			{
				string sREA_NO=string.Empty;
				if(dtFG==new DateTime(1,1,1))//if(PublicFunction.CUS_ID=="400")//su dung may van tay
				{										
					sREA_NO=_lbxFile.Items[i].ToString();
					sREA_NO=PublicFunction.S_Left(sREA_NO,sREA_NO.Length-12);
				}
				_lbxFile.SelectedIndex = i;
				ad_Rs = FillTextFileToRecordset(S_sDir, _lbxFile.Items[i].ToString(), S_sAppPath + "\\Text" + _iSEQ_NO.ToString(), ad_Con);

				if (ad_Rs.EOF || (S_dbBook > ad_Rs.RecordCount && GetName(S_sFile) == _lbxFile.Items[i].ToString()))
				{
					if (i < _lbxFile.Items.Count - 1)
						S_dbBook = 1;
				}
				else
				{
					if (i>0) S_dbBook = 0;
					if (S_dbBook > 0) ad_Rs.Move(S_dbBook - 1, 1); 
					
					while (ad_Rs.EOF == false)
					{
						string REA_NO, CRD_NO, CRD_DT, CRD_TM, CRD_TM_02="";
						string sql, EMP_ID;
						double TM;

						if (stop)
						{
							sql="UPDATE GP_SYS_READER SET RCD_FG="+ S_dbBook +",FIL_NM=N'"+ S_sDir + "\\" + _lbxFile.Items[i].ToString() +"' where SEQ_NO='" + _iSEQ_NO + "'";
							PublicFunction.SQL_Execute(sql, SqlCon);
							ad_Rs.Close();
							ADODB_Close(ad_Con);
							return;
						}

						REA_NO = ad_Rs.Fields["READER_NO"].Value.ToString();
						CRD_NO = ad_Rs.Fields["CARD_NO"].Value.ToString();
						CRD_DT=ad_Rs.Fields["DAYS"].Value.ToString();
						CRD_DT.Trim();
						CRD_TM="";
						if (PublicFunction.CUS_ID=="300" && _iSEQ_NO ==1)//KenYa
						{
							string sdateh="";
							sdateh=CRD_DT;
							CRD_NO="00" + CRD_NO ;
							CRD_DT=sdateh.Substring(0,10);
							CRD_DT=CRD_DT.Replace("/","");
							CRD_TM=sdateh.Remove(0,11);
							CRD_TM =CRD_TM.Replace(":", "");
						}
						if(dtFG==new DateTime(1,1,1)) //if(PublicFunction.CUS_ID=="400")//may van tay
						{
							REA_NO=sREA_NO;
						}
						if (sDateFormat=="" || sDateFormat==null)
						{
							CRD_DT = ad_Rs.Fields["DAYS"].Value.ToString().Replace("/", "").Replace("-","");
						}
						else if (CRD_DT!="" && sDateFormat=="fr-FR" )
						{
							try
							{
							IFormatProvider culture = new System.Globalization.CultureInfo("fr-FR", true);

							// Alternate choice: If the string has been input by an end user, you might 
							// want to format it according to the current culture:
							// IFormatProvider culture = System.Threading.Thread.CurrentThread.CurrentCulture;
							CRD_DT = DateTime.Parse(CRD_DT, culture, System.Globalization.DateTimeStyles.None).ToString("yyyyMMdd");

//								CRD_DT = CRD_DT.Split("d",2);//DateTime.Parse(CRD_DT).ToString() ;// .ToString(sDateFormat);
//								CRD_DT = DateTime.Parse(CRD_DT).ToString("yyyyMMdd");
							}
							catch
							{
							}
						}
						if(PublicFunction.CUS_ID!="300" || _iSEQ_NO!=1)//kenya
							CRD_TM = ad_Rs.Fields["HOURS"].Value.ToString().Replace(":", "");
						
						try
						{
							if (CRD_NO!="" && CRD_TM!="" && CRD_DT!="")
							{
								DateTime dt1=GetDateTime(CRD_DT,CRD_TM).AddMinutes(-CRD_MN);
								DateTime dt2=GetDateTime(CRD_DT,CRD_TM).AddMinutes(CRD_MN);

								TM = T_String.IsNullTo00(CRD_TM);
								if (TM == 0)
								{
									TM = 2400.0;
									CRD_TM = "2400";
									CRD_DT=GetDate(CRD_DT).AddDays(-1).ToString("yyyyMMdd");
								}

								sql="(DAT_TM>"+dt1.ToString("yyyyMMddHHmm")+" and DAT_TM<"+dt2.ToString("yyyyMMddHHmm")
									+") and CRD_NO=N'"+CRD_NO+"'";
								if (! PublicFunction.SqlExists(SqlCon, "FILC01A", "CRD_DT='" + CRD_DT + "' AND CRD_NO='" + CRD_NO + "'"
									+ " AND (DAT_TM BETWEEN '" + dt1.ToString("yyyyMMddHHmm") + "' AND '" + dt2.ToString("yyyyMMddHHmm") + "' OR CRD_TM=" + TM  + ")"))
								{
//								if(T_String.IsNullTo0(T_String.GetDataFromSQL("top 1 1 ","FILC01A",sql, SqlCon))<=0 &&
//									T_String.IsNullTo0(T_String.GetDataFromSQL("top 1 1", "FILC01A", "DAT_TM=N'"+CRD_DT+CRD_TM+"' and CRD_NO=N'"+CRD_NO+"'", SqlCon))<=0)
								
									int index=this.CRD_NO.IndexOf(CRD_NO);
									if(index>=0)
										EMP_ID=this.EMP_ID[index]+"";
									else
										EMP_ID="";
							//==============================CHIA 2 TH DOC DU LIEU CHAM CONG VA DOC DU LIEU CHO MAY QUAN LY TOILET
									if (sReaNo_VS1.IndexOf(REA_NO,0)<0)//(REA_NO != sReaNo_VS1 && REA_NO != sReaNo_VS2 )
									{
										sql = "Insert into FILC01A(DAT_TM,EMP_ID,SWI_DT,USR_NM,CRD_DT,CRD_TM,CRD_NO,REA_NO,FIL_NM) values(";
										sql += "N'" + CRD_DT + CRD_TM + "',N'" + EMP_ID + "','" + dt + "',N'" + PublicFunction.A_UserID + "',";
										sql += "'" + CRD_DT + "'," + TM + ",";
										sql += "N'" + CRD_NO + "',N'" + REA_NO + "',";
										sql += "N'" + S_sDir + "\\" + _lbxFile.Items[i].ToString() + "')";
									}
									else
									{
										sql = "Insert into FILC01A_VS(DAT_TM,EMP_ID,SWI_DT,USR_NM,CRD_DT,CRD_TM,CRD_NO,REA_NO,FIL_NM) values(";
										sql += "N'" + CRD_DT + CRD_TM + "',N'" + EMP_ID + "','" + dt + "',N'" + PublicFunction.A_UserID + "',";
										sql += "'" + CRD_DT + "'," + TM + ",";
										sql += "N'" + CRD_NO + "',N'" + REA_NO + "',";
										sql += "N'" + S_sDir + "\\" + _lbxFile.Items[i].ToString() + "')";
									}

//									sql="Insert into FILC01A(DAT_TM,EMP_ID,SWI_DT,USR_NM,CRD_DT,CRD_TM,CRD_NO,REA_NO,FIL_NM) values(";
//									sql+="N'"+CRD_DT+CRD_TM+"',N'"+EMP_ID+"','"+dt+"',N'"+PublicFunction.A_UserID+"',";
//									sql+="'"+CRD_DT+"',"+TM+",";
//									sql+="N'"+CRD_NO+"',N'"+REA_NO+"',";
//									sql+="N'"+ S_sDir + "\\" + _lbxFile.Items[i].ToString() +"')";
				
									try
									{				
										PublicFunction.SQL_Execute(sql, SqlCon);
									}
									catch(SqlException ex)
									{
										if (ex.Number!=2627 )
										{
											MessageBox.Show(ex.Message+"");
										}
									}								
								}

								if (sDouble!="" && sDouble!=null)
								{
									try
									{
										CRD_TM_02 = ad_Rs.Fields["HOURS_02"].Value.ToString().Replace(":", "");
									}
									catch
									{
									}
								}

								if (sDouble!="" && sDouble!=null && CRD_TM_02!="")
								{
									dt1=GetDateTime(CRD_DT,CRD_TM_02).AddMinutes(-CRD_MN);
									dt2=GetDateTime(CRD_DT,CRD_TM_02).AddMinutes(CRD_MN);

									TM = T_String.IsNullTo00(CRD_TM_02);
									if (TM == 0)
									{
										TM = 2400.0;
										CRD_TM = "2400";
										CRD_DT=GetDate(CRD_DT).AddDays(-1).ToString("yyyyMMdd");
									}
									sql="(DAT_TM>"+dt1.ToString("yyyyMMddHHmm")+" and DAT_TM<"+dt2.ToString("yyyyMMddHHmm")
										+") and CRD_NO=N'"+CRD_NO+"'";

//									if(T_String.IsNullTo0(T_String.GetDataFromSQL(" top 1 1","FILC01A",sql, SqlCon))<=0 && //COUNT(DAT_TM)
//										T_String.IsNullTo0(T_String.GetDataFromSQL("top 1 1", "FILC01A", "DAT_TM=N'"+CRD_DT+CRD_TM_02+"' and CRD_NO=N'"+CRD_NO+"'", SqlCon))<=0) //COUNT(EMP_ID)
									if (! PublicFunction.SqlExists(SqlCon, "FILC01A", "CRD_DT='" + CRD_DT + "' AND CRD_NO='" + CRD_NO + "'"
										+ " AND (DAT_TM BETWEEN '" + dt1.ToString("yyyyMMddHHmm") + "' AND '" + dt2.ToString("yyyyMMddHHmm") + "' OR CRD_TM=" + TM  + ")"))
									{
										int index=this.CRD_NO.IndexOf(CRD_NO);
										if(index>=0)
											EMP_ID=this.EMP_ID[index]+"";
										else
											EMP_ID="";
										//==============================CHIA 2 TH DOC DU LIEU CHAM CONG VA DOC DU LIEU CHO MAY QUAN LY TOILET
										if (sReaNo_VS1.IndexOf(REA_NO,0)<0)//(REA_NO != sReaNo_VS1 && REA_NO != sReaNo_VS2)
										{
											sql = "Insert into FILC01A(DAT_TM,EMP_ID,SWI_DT,USR_NM,CRD_DT,CRD_TM,CRD_NO,REA_NO,FIL_NM) values(";
											sql += "N'" + CRD_DT + CRD_TM_02 + "',N'" + EMP_ID + "','" + dt + "',N'" + PublicFunction.A_UserID + "',";
											sql += "'" + CRD_DT + "'," + T_String.IsNullTo00(CRD_TM_02) + ",";
											sql += "N'" + CRD_NO + "',N'" + REA_NO + "',";
											sql += "N'" + S_sDir + "\\" + _lbxFile.Items[i].ToString() + "')";
										}
										else
										{
											sql = "Insert into FILC01A_VS(DAT_TM,EMP_ID,SWI_DT,USR_NM,CRD_DT,CRD_TM,CRD_NO,REA_NO,FIL_NM) values(";
											sql += "N'" + CRD_DT + CRD_TM_02 + "',N'" + EMP_ID + "','" + dt + "',N'" + PublicFunction.A_UserID + "',";
											sql += "'" + CRD_DT + "'," + T_String.IsNullTo00(CRD_TM_02) + ",";
											sql += "N'" + CRD_NO + "',N'" + REA_NO + "',";
											sql += "N'" + S_sDir + "\\" + _lbxFile.Items[i].ToString() + "')";
										}
//										sql="Insert into FILC01A(DAT_TM,EMP_ID,SWI_DT,USR_NM,CRD_DT,CRD_TM,CRD_NO,REA_NO,FIL_NM) values(";
//										sql+="N'"+CRD_DT+CRD_TM_02+"',N'"+EMP_ID+"','"+dt+"',N'"+PublicFunction.A_UserID+"',";
//										sql+="'"+CRD_DT+"',"+T_String.IsNullTo00(CRD_TM_02)+",";
//										sql+="N'"+CRD_NO+"',N'"+REA_NO+"',";
//										sql+="N'"+ S_sDir + "\\" + _lbxFile.Items[i].ToString() +"')";
				
										try
										{				
											PublicFunction.SQL_Execute(sql, SqlCon);
										}
										catch(SqlException ex)
										{
											if (ex.Number!=2627 )
											{
												MessageBox.Show(ex.Message+"");
											}
										}
									}

								}
							}
							
						}
						catch(Exception ex)
						{
//								if (bContinue == false)
//								{
									if (MessageBox.Show (ex.Message + "\n\rText File: " + _lbxFile.Items[i].ToString() + 
										", Bookmarks: " + Convert.ToString(S_dbBook+1) +
										"\r\nContinue!","Error!", System.Windows.Forms.MessageBoxButtons.YesNo) == DialogResult.No)
									{
										stop = true;
									}
//									bContinue = true;
//								}
						}
	
						_lbxRecord.Items.Add(CRD_NO+"  "+CRD_DT+"  "+CRD_TM+ "  " +CRD_TM_02);
						_lbxRecord.SelectedIndex = _lbxRecord.Items.Count-1;
//						_lbNumRec.Text = (ad_Rs.Bookmark ) + "/" + ad_Rs.RecordCount.ToString();
//						_lbNumRec.Text = (S_dbBook.ToString()+1) + "/" + ad_Rs.RecordCount.ToString();

						S_dbBook ++;
						ad_Rs.MoveNext();
						//Tao khoa lam cho chuyen du lieu chay cham
						//LAY NGAY KHOA DUOI SQL
						if (stype.ToUpper()=="AS") 
						{
							if ( DateTime.Now >= DateTime.Parse(keyD))																	
								Thread.Sleep(500*iphut) ;
						}						
					}
				}
				
			}

			if(_lbxFile.Items.Count>0)
			{
				string sql="update  GP_SYS_READER set RCD_FG="+ S_dbBook +", FIL_NM=N'"+ S_sDir + "\\" + _lbxFile.Items[_lbxFile.Items.Count-1]+"' where SEQ_NO=N'" + _iSEQ_NO + "'";
				PublicFunction.SQL_Execute(sql, SqlCon);
			}

			_bFin = true;

			SqlCon.Close();
			ad_Rs.Close();
			ADODB_Close(ad_Con);

		}

		private bool GetFileName(ListBox _lbxFile, string _sDir, string _sFile, SqlConnection _con)
		{
			try
			{
				int i, j;

				DateTime S_dDt = AQ800(GetName(_sFile));

				if (S_dDt == new DateTime(1,1,1))
					return false;

				string []lsFile = Directory.GetFiles(_sDir, "*.txt");
				Array.Sort(lsFile);

				j = 0;
				for (i=0; i<lsFile.Length; i++)
				{
					string sFileName = string.Empty;
					sFileName = lsFile[i].Substring(lsFile[i].LastIndexOf("\\") + 1);
					DateTime dDt = AQ800(sFileName);
					
					if (T_String.CompareDate(dDt, S_dDt) && dDt != new DateTime(1,1,1))
					{
						_lbxFile.Items.Insert(j, sFileName);
						j ++;
					}
				}
			}
			catch
			{
				//MessageBox.Show (ex.Message);
				return false;
			}

			return true;
		}
		private bool GetFileNameTHU(ListBox _lbxFile, string _sDir, string _sFile, SqlConnection _con)
		{
			try
			{
				int i, j;
				string sfile,sfile1;				
				sfile1 = GetName(_sFile);				
				//cty vinh tuyen
				if(PublicFunction.CUS_ID=="0")
					sfile1= sfile1.Substring(6,4)+sfile1.Substring(0,2)+sfile1.Substring(3,2)+sfile1.Substring(10,2);
				else
					sfile1= PublicFunction.S_Right(PublicFunction.S_Left(sfile1,sfile1.Length -4),8)+PublicFunction.S_Left(sfile1,sfile1.Length-12);
				DateTime S_dDt = AQ800THU(GetName(_sFile));
				if (S_dDt == new DateTime(1,1,1))
					return false;

				string []lsFile = Directory.GetFiles(_sDir, "*.txt");
				//string []lsFile1 = Directory.GetFiles(_sDir, "*.txt");
				for(i=0;i<lsFile.Length;i++)
				{
					sfile=lsFile[i].Substring(lsFile[i].LastIndexOf("\\") + 1);
					//lsFile1[i]=sfile;					
					if(PublicFunction.CUS_ID=="0")
						lsFile[i]= sfile.Substring(6,4)+sfile.Substring(0,2)+sfile.Substring(3,2)+sfile.Substring(10,2);
					else
						lsFile[i]=PublicFunction.S_Right(PublicFunction.S_Left(sfile,sfile.Length -4),8)+PublicFunction.S_Left(sfile,sfile.Length-12);
				}
				Array.Sort(lsFile);

				j = 0;
				for (i=0; i<lsFile.Length; i++)
				{
					string sFileName = string.Empty;
					sFileName = lsFile[i];//.Substring(lsFile[i].LastIndexOf("\\") + 1);
					DateTime dDt = AQ800(sFileName);

					if ( sFileName.CompareTo(sfile1)>=0 && dDt != new DateTime(1,1,1))//sFileName.CompareTo(sfile1)>=0 &&
					{
						string sFileName1=string.Empty;						
						if (PublicFunction.CUS_ID=="0")
							sFileName1=sFileName.Substring(4,2)+"-"+sFileName.Substring(6,2)+"-"+sFileName.Substring(0,4)+sFileName.Substring(8,2)+".txt";
						else
							sFileName1=PublicFunction.S_Right(sFileName,sFileName.Length-8)+PublicFunction.S_Left(sFileName,8)+".txt";
						_lbxFile.Items.Insert(j, sFileName1 );
						j ++;
					}
				}
			}
			catch
			{
				//MessageBox.Show (ex.Message);
				return false;
			}

			return true;
		}

		private bool CreateTextFolder(string _sAppPath, int _iSEQ_NO)
		{
			try
			{
				if (!Directory.Exists(_sAppPath + "\\Text" + _iSEQ_NO.ToString()))
				{
					Directory.CreateDirectory(_sAppPath + "\\Text" + _iSEQ_NO.ToString());
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show (ex.Message);
				return false;
			}

			return true;
		}

		private ADODB.Recordset FillTextFileToRecordset(string _sDir, string _sFile, string _sDesPath, ADODB.Connection _ad_Con)
		{
			ADODB.Recordset rs = new ADODB.RecordsetClass();

			try
			{
				string s;
				StreamReader strR = new StreamReader(_sDir + "\\" + _sFile);
				StreamWriter strW = new StreamWriter(_sDesPath + "\\" + _sFile);
				strW.Write(strR.ReadToEnd());

				strR.Close();
				strW.Close();

				WriteSchemaFile(_sDir, _sFile, _sDesPath);

				s = "SELECT * FROM [" + _sFile + "]";

				rs.Open(s, _ad_Con, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly,-1);

			}
			catch(Exception ex)
			{
				MessageBox.Show (ex.Message);
			}
			
			return rs;
		}

		private bool ADODB_Connect(ADODB.Connection _ad_Con, string _strCon)
		{
			try
			{
				if (_ad_Con.State == 1)
				{
					_ad_Con.Close();
				}

				_ad_Con.Open(_strCon,"","",0);
			}
			catch(Exception ex)
			{
				MessageBox.Show (ex.Message);
				return false;
			}
			return true;
		}

		private void ADODB_Close(ADODB.Connection _ad_Con)
		{
			try
			{
				_ad_Con.Close();
			}
			catch
			{
			
			}
		}

		//private StringBuilder sSchema = new StringBuilder();
		private void WriteSchemaFile(string _sDir, string _sFile, string _sDesPath)
		{
			StringBuilder sSchema = new StringBuilder();
			if (sSchema.Length == 0)
			{
				if (!File.Exists(_sDir + "\\Schema.ini"))
				{
					sSchema.Append("ColNameHeader=False\r\n");
					sSchema.Append("Format=FixedLength\r\n");
					sSchema.Append("CharacterSet=OEM\r\n");
					sSchema.Append("Col1=READER_NO Text Width 3\r\n");
					sSchema.Append("Col2=CARD_NO Text Width 10\r\n");
                    sSchema.Append("Col3=DAYS Text Width 8\r\n");
					sSchema.Append("Col4=HOURS Text Width 4\r\n");
				}
				else
				{
					string sLine = string.Empty;
					StreamReader strR = new StreamReader(_sDir + "\\Schema.ini");
					strR.ReadLine();
					while((sLine = strR.ReadLine()) != null)
					{
						sSchema.Append(sLine + "\r\n");
						sLine = string.Empty;
					}
					strR.Close();
				}
			}
			StreamWriter strW = new StreamWriter(_sDesPath + "\\Schema.ini");
			strW.Write("[" + _sFile + "]" + "\r\n" + sSchema);
			strW.Close();
		}

		private void Get_Staff()
		{
			Func.RecordSet rs=new Func.RecordSet("Select EMP_ID,CRD_NO from FILB01A where VAC_BT is null OR VAC_BT=0",PublicFunction.C_con);
			EMP_ID=new ArrayList();
			CRD_NO=new ArrayList();
			for(int i=0;i<rs.rows;i++)
			{
				EMP_ID.Add(rs.record(i,"EMP_ID"));
				CRD_NO.Add(rs.record(i,"CRD_NO"));
			}
		}

		private DateTime AQ800(string st)
		{
			try
			{				
					string st1=st;
					int y=T_String.IsNullTo0( PublicFunction.S_Left(st1,4));
					st1=PublicFunction.S_Right(st1,st1.Length-4);
					int m=T_String.IsNullTo0(PublicFunction.S_Left(st1,2));
					st1=PublicFunction.S_Right(st1,st1.Length-2);
					int d=T_String.IsNullTo0(PublicFunction.S_Left(st1,2));
					DateTime dt=new DateTime(y,m,d);
					return dt;
				
			}
			catch(Exception)
			{
				return new DateTime(1,1,1);
			}
		}
		private DateTime AQ800THU(string st)
		{
			try
			{
				string st11=PublicFunction.S_Right(st,12);
				int y1, m1,d1;
				if(PublicFunction.CUS_ID=="0")
				{
					st11=PublicFunction.S_Left(st,10);
					y1=T_String.IsNullTo0( PublicFunction.S_Right(st11,4));
					m1=T_String.IsNullTo0(st11.Substring(0,2));
					d1=T_String.IsNullTo0(st11.Substring(3,2));					
				}
				else
				{
					y1=T_String.IsNullTo0( PublicFunction.S_Left(st11,4));
					st11=PublicFunction.S_Right(st11,st11.Length-4);
					m1=T_String.IsNullTo0(PublicFunction.S_Left(st11,2));
					st11=PublicFunction.S_Right(st11,st11.Length-2);
					d1=T_String.IsNullTo0(PublicFunction.S_Left(st11,2));
				}
				DateTime dt1=new DateTime(y1,m1,d1);
				return dt1;
			}
			catch(Exception)
			{
				return new DateTime(1,1,1);
			}
		}

		private string GetName(string thumuc)
		{
			try
			{
				int n=thumuc.LastIndexOf("\\");
				if(n<0)
					return thumuc;
				return thumuc.Remove(0,n+1);
			}
			catch(Exception)
			{
				return "";
			}
		}		

		private DateTime GetDateTime(string st,string time)
		{
			try
			{
				string st1=st;
				int y=T_String.IsNullTo0( PublicFunction.S_Left(st1,4));
				st1=PublicFunction.S_Right(st1,st1.Length-4);
				int MM=T_String.IsNullTo0(PublicFunction.S_Left(st1,2));
				st1=PublicFunction.S_Right(st1,st1.Length-2);
				int d=T_String.IsNullTo0(PublicFunction.S_Left(st1,2));
				int HH=T_String.IsNullTo0( PublicFunction.S_Left(time,2));
				int mm=T_String.IsNullTo0( PublicFunction.S_Right(time,2));
				DateTime dt=new DateTime( y,MM,d,HH,mm,0,0);
				return dt;
			}
			catch(Exception)
			{
				return new DateTime(1,1,1);
			}
		}

		private DateTime GetDate(string st)
		{
			try
			{	
				string st1=st;
				int y=T_String.IsNullTo0( PublicFunction.S_Left(st1,4));
				st1=PublicFunction.S_Right(st1,st1.Length-4);
				int MM=T_String.IsNullTo0(PublicFunction.S_Left(st1,2));
				st1=PublicFunction.S_Right(st1,st1.Length-2);
				int d=T_String.IsNullTo0(PublicFunction.S_Left(st1,2));
				DateTime dt=new DateTime(y,MM,d);
				return dt;
			}
			catch(Exception)
			{
				return new DateTime(1,1,1);
			}
		}
	
		private void button1_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void frmTaTransferFromTXT_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			stop=true;
		}

	}
}
