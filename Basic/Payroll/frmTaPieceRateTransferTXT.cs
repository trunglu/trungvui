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
using System.Text;
using System.Data.OleDb;
using ADODB;
using System.Globalization;
namespace GP8000.Payroll
{
	/// <summary>
	/// Summary description for frmTaPieceRateTransferTXT.
	/// </summary>
	public class frmTaPieceRateTransferTXT : System.Windows.Forms.Form
	{
		private System.Windows.Forms.OpenFileDialog f2;
		private System.Windows.Forms.FolderBrowserDialog f1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Button cmd2;
		private System.Windows.Forms.Button cmd1;
		private System.Windows.Forms.TextBox txt_file1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txt_path1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button bttransfer;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.ListBox lb1;
		private System.Windows.Forms.ListBox lb2;
		private C1.Win.C1Input.C1DateEdit dt1;
		private Boolean stop,fin;
		private System.Windows.Forms.Label c1;
		private System.Windows.Forms.Label label1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmTaPieceRateTransferTXT()
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
			this.f2 = new System.Windows.Forms.OpenFileDialog();
			this.f1 = new System.Windows.Forms.FolderBrowserDialog();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.panel6 = new System.Windows.Forms.Panel();
			this.lb2 = new System.Windows.Forms.ListBox();
			this.panel5 = new System.Windows.Forms.Panel();
			this.lb1 = new System.Windows.Forms.ListBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.dt1 = new C1.Win.C1Input.C1DateEdit();
			this.bttransfer = new System.Windows.Forms.Button();
			this.cmd2 = new System.Windows.Forms.Button();
			this.cmd1 = new System.Windows.Forms.Button();
			this.txt_file1 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txt_path1 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.c1 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel6.SuspendLayout();
			this.panel5.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dt1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.panel3);
			this.panel1.Controls.Add(this.panel4);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(736, 506);
			this.panel1.TabIndex = 0;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.c1);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel3.Location = new System.Drawing.Point(0, 488);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(736, 18);
			this.panel3.TabIndex = 3;
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.panel6);
			this.panel4.Controls.Add(this.panel5);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel4.Location = new System.Drawing.Point(0, 136);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(736, 370);
			this.panel4.TabIndex = 2;
			// 
			// panel6
			// 
			this.panel6.Controls.Add(this.lb2);
			this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel6.Location = new System.Drawing.Point(200, 0);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(536, 370);
			this.panel6.TabIndex = 1;
			// 
			// lb2
			// 
			this.lb2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lb2.ItemHeight = 16;
			this.lb2.Location = new System.Drawing.Point(0, 0);
			this.lb2.Name = "lb2";
			this.lb2.Size = new System.Drawing.Size(536, 356);
			this.lb2.TabIndex = 6;
			this.lb2.SelectedIndexChanged += new System.EventHandler(this.lb2_SelectedIndexChanged);
			// 
			// panel5
			// 
			this.panel5.Controls.Add(this.lb1);
			this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel5.Location = new System.Drawing.Point(0, 0);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(200, 370);
			this.panel5.TabIndex = 0;
			// 
			// lb1
			// 
			this.lb1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lb1.ItemHeight = 16;
			this.lb1.Location = new System.Drawing.Point(0, 0);
			this.lb1.Name = "lb1";
			this.lb1.Size = new System.Drawing.Size(200, 356);
			this.lb1.TabIndex = 4;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.label1);
			this.panel2.Controls.Add(this.dt1);
			this.panel2.Controls.Add(this.bttransfer);
			this.panel2.Controls.Add(this.cmd2);
			this.panel2.Controls.Add(this.cmd1);
			this.panel2.Controls.Add(this.txt_file1);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Controls.Add(this.txt_path1);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(736, 136);
			this.panel2.TabIndex = 0;
			// 
			// dt1
			// 
			this.dt1.CustomFormat = "yyyyMM";
			this.dt1.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat;
			this.dt1.Location = new System.Drawing.Point(144, 8);
			this.dt1.Name = "dt1";
			this.dt1.Size = new System.Drawing.Size(100, 23);
			this.dt1.TabIndex = 149;
			this.dt1.Tag = null;
			// 
			// bttransfer
			// 
			this.bttransfer.Location = new System.Drawing.Point(248, 96);
			this.bttransfer.Name = "bttransfer";
			this.bttransfer.Size = new System.Drawing.Size(104, 32);
			this.bttransfer.TabIndex = 20;
			this.bttransfer.Text = "Transfer";
			this.bttransfer.Click += new System.EventHandler(this.bttransfer_Click);
			// 
			// cmd2
			// 
			this.cmd2.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd2.Location = new System.Drawing.Point(552, 64);
			this.cmd2.Name = "cmd2";
			this.cmd2.Size = new System.Drawing.Size(28, 23);
			this.cmd2.TabIndex = 19;
			this.cmd2.Tag = "N";
			this.cmd2.Text = "...";
			this.cmd2.Click += new System.EventHandler(this.cmd2_Click);
			// 
			// cmd1
			// 
			this.cmd1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmd1.Location = new System.Drawing.Point(552, 40);
			this.cmd1.Name = "cmd1";
			this.cmd1.Size = new System.Drawing.Size(28, 23);
			this.cmd1.TabIndex = 18;
			this.cmd1.Tag = "N";
			this.cmd1.Text = "...";
			this.cmd1.Click += new System.EventHandler(this.cmd1_Click);
			// 
			// txt_file1
			// 
			this.txt_file1.Location = new System.Drawing.Point(104, 64);
			this.txt_file1.Name = "txt_file1";
			this.txt_file1.Size = new System.Drawing.Size(444, 23);
			this.txt_file1.TabIndex = 17;
			this.txt_file1.Text = "";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(8, 64);
			this.label4.Name = "label4";
			this.label4.TabIndex = 16;
			this.label4.Text = "Type";
			// 
			// txt_path1
			// 
			this.txt_path1.Location = new System.Drawing.Point(104, 40);
			this.txt_path1.Name = "txt_path1";
			this.txt_path1.Size = new System.Drawing.Size(444, 23);
			this.txt_path1.TabIndex = 15;
			this.txt_path1.Text = "";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(8, 40);
			this.label2.Name = "label2";
			this.label2.TabIndex = 14;
			this.label2.Text = "Path";
			// 
			// c1
			// 
			this.c1.BackColor = System.Drawing.Color.Black;
			this.c1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.c1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.c1.ForeColor = System.Drawing.Color.White;
			this.c1.Location = new System.Drawing.Point(0, -5);
			this.c1.Name = "c1";
			this.c1.Size = new System.Drawing.Size(736, 23);
			this.c1.TabIndex = 7;
			this.c1.Tag = "N";
			this.c1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(120, 24);
			this.label1.TabIndex = 150;
			this.label1.Text = "Select month";
			// 
			// frmTaPieceRateTransferTXT
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
			this.ClientSize = new System.Drawing.Size(736, 506);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "frmTaPieceRateTransferTXT";
			this.Text = "frmTaPieceRateTransferTXT";
			this.Load += new System.EventHandler(this.frmTaPieceRateTransferTXT_Load);
			this.panel1.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.panel6.ResumeLayout(false);
			this.panel5.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dt1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void frmTaPieceRateTransferTXT_Load(object sender, System.EventArgs e)
		{
			dt1.Value=T_String.GetDate();
			txt_path1.Text=PublicFunction.GetOption("PIECERATE_PATH");
		}

		private void cmd1_Click(object sender, System.EventArgs e)
		{
			f1.SelectedPath=txt_path1.Text;
			if (f1.ShowDialog(this)==DialogResult.OK)
			{
				txt_path1.Text=f1.SelectedPath;
			}
		}

		private void cmd2_Click(object sender, System.EventArgs e)
		{
			f2.InitialDirectory=txt_path1.Text;	
			f2.Filter =" Text File (*.txt)|*.txt";
			if (f2.ShowDialog(this)== DialogResult.OK)			
			{				
				txt_file1.Text=f2.FileName;
			}
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

		private bool CreateTextFolder(string _sAppPath, int _iSEQ_NO)
		{
			try
			{
				if (!Directory.Exists(_sAppPath + "\\PieceRateText" + _iSEQ_NO.ToString()))
				{
					Directory.CreateDirectory(_sAppPath + "\\PieceRateText" + _iSEQ_NO.ToString());
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show (ex.Message);
				return false;
			}

			return true;
		}
//		private void Get_Staff()
//		{
//			Func.RecordSet rs=new Func.RecordSet("Select EMP_ID,CRD_NO from FILB01A where VAC_BT is null OR VAC_BT=0",PublicFunction.C_con);
//			EMP_ID=new ArrayList();
//			CRD_NO=new ArrayList();
//			for(int i=0;i<rs.rows;i++)
//			{
//				EMP_ID.Add(rs.record(i,"EMP_ID"));
//				CRD_NO.Add(rs.record(i,"CRD_NO"));
//			}
//		}

		private DateTime AQ800(string st)
		{
			try
			{
				string st1=st;
				int y=T_String.IsNullTo0( PublicFunction.S_Left(st1,4));
				st1=PublicFunction.S_Right(st1,st1.Length-4);
				int m=T_String.IsNullTo0(PublicFunction.S_Left(st1,2));
//				st1=PublicFunction.S_Right(st1,st1.Length-2);
//				int d=T_String.IsNullTo0(PublicFunction.S_Left(st1,2));
				DateTime dt=new DateTime(y,m,1);
				return dt;
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
		private void Transfer(ListBox _lbxFile, ListBox _lbxRecord, Label _lbNumRec, int _iSEQ_NO, ref bool _bFin)
		{
			//			bool bContinue = false;
			SqlConnection SqlCon = new SqlConnection(PublicFunction.C_con.ConnectionString);
			SqlCon.Open();

			string str_Con;	//string connection
			ADODB.Connection ad_Con = new ADODB.ConnectionClass();
			ADODB.Recordset ad_Rs = new ADODB.RecordsetClass();

			string S_sDir =txt_path1.Text ; //T_String.GetDataFromSQL("DIR_DR","GP_SYS_READER","SEQ_NO='" + _iSEQ_NO + "'", SqlCon);
			string S_sFile =txt_file1.Text ; //T_String.GetDataFromSQL("FIL_NM", "GP_SYS_READER", "SEQ_NO='" + _iSEQ_NO + "'", SqlCon);
			string sDateFormat=PublicFunction.GetOption("SCHEMA_DateFormat");
			string sDouble="";
			sDouble=PublicFunction.GetOption("SCHEMA_DOUBLE");
			//int S_dbBook = T_String.IsNullTo0(T_String.GetDataFromSQL("RCD_FG", "GP_SYS_READER", "SEQ_NO='" + _iSEQ_NO + "'", SqlCon));
			string S_sAppPath = Application.StartupPath.ToString(); 

			if (!GetFileName(_lbxFile, S_sDir, S_sFile, SqlCon))
			{
				_bFin = true;
				return;
			}

			if (!CreateTextFolder(S_sAppPath, _iSEQ_NO))
			{
				_bFin = true;
				return;
			}

			str_Con = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + S_sAppPath + "\\PieceRateText" + _iSEQ_NO.ToString() + ";Extended Properties='text;HDR=Yes;FMT=Delimited';";

			if (!ADODB_Connect(ad_Con, str_Con)) 
			{
				_bFin = true;
				return;
			}

			for (int i=0; i<_lbxFile.Items.Count; i++)
			{
				_lbxFile.SelectedIndex = i;

				ad_Rs = FillTextFileToRecordset(S_sDir, _lbxFile.Items[i].ToString(), S_sAppPath + "\\PieceRateText" + _iSEQ_NO.ToString(), ad_Con);

				if (ad_Rs.EOF )
				{
					
				}
				else
				{
										
					while (ad_Rs.EOF == false)
					{
						string REA_NO;
						string sql, EMP_ID;
						double LSP;

						if (stop)
						{
							
							ad_Rs.Close();
							ADODB_Close(ad_Con);
							return;
						}

						REA_NO = ad_Rs.Fields["READER_NO"].Value.ToString();						
						EMP_ID=REA_NO.Substring(12,5);
						LSP=T_String.IsNullTo00(REA_NO.Substring(19,REA_NO.Length-19));
//						CRD_NO = ad_Rs.Fields["CARD_NO"].Value.ToString();
//						CRD_DT=ad_Rs.Fields["DAYS"].Value.ToString();
//						CRD_DT.Trim();						
						
						try
						{		
							sql="UPDATE  FILD02A SET PieceRate="+LSP+" WHERE EMP_ID='"+EMP_ID+"' AND YYY_MM='"+dt1.Text +"' AND SEQ_NO=2";							
				
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
						catch(Exception ex)
						{
							//								if (bContinue == false)
							//								{
							if (MessageBox.Show (ex.Message + "\n\rText File: " + _lbxFile.Items[i].ToString() + 								
								"\r\nContinue!","Error!", System.Windows.Forms.MessageBoxButtons.YesNo) == DialogResult.No)
							{
								stop = true;
							}
							//									bContinue = true;
							//								}
						}
	
						_lbxRecord.Items.Add(EMP_ID+"  "+LSP.ToString());
						_lbxRecord.SelectedIndex = _lbxRecord.Items.Count-1;
						//						_lbNumRec.Text = (ad_Rs.Bookmark ) + "/" + ad_Rs.RecordCount.ToString();
						//						_lbNumRec.Text = (S_dbBook.ToString()+1) + "/" + ad_Rs.RecordCount.ToString();

						
						ad_Rs.MoveNext();
					}
				}
				
			}
			

			_bFin = true;

			SqlCon.Close();
			ad_Rs.Close();
			ADODB_Close(ad_Con);

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
					sSchema.Append("Col1=READER_NO Text Width 30\r\n");
//					sSchema.Append("Col2=CARD_NO Text Width 8\r\n");
//					sSchema.Append("Col3=PieceRate Text Width 8\r\n");
//					sSchema.Append("Col4=HOURS Text Width 4\r\n");
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
		private void bttransfer_Click(object sender, System.EventArgs e)
		{
			//Boolean fin=false;
			Transfer(lb1,lb2,c1,0,ref fin);
		}

		private void lb2_SelectedIndexChanged(object sender, System.EventArgs e)
		{
		
		}
	}
}
