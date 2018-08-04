using System;
using System.IO;
using System.Windows;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using Navigator1;
using System.Collections;
using System.Drawing;
using GP8000.Personnel.Report;

namespace Basic.Function
{
	/// <summary>
	/// Summary description for PublicFunction.
	/// </summary>
	public class PublicFunction
	{
		public static string DT_server,DT_database,DT_databasedel,DT_username,DT_password,AD_Login,AD_Key;
		public static string DTGP_server,DTGP_database,DTGP_username,DTGP_password;
		public static string Path=Application.StartupPath,C_ConStrForRPT="";
		public static SqlConnection C_con,C_condel;
		public static string L_Lag,L_FontName,L_FontSize;
		public static Boolean L_State=false,GPS=false,CUS_GPS=false;
		public static string A_UserID,A_Group_ID,A_Pass;	
		public static string CUS_ID,L_Lag1="";
		public static string C_Connect,C_port,C_Setting,C_WaitCOM;
		public static int min;
		public static int absent=5;
		public static string  WID="";
		public static int WIDLEN=0,tinhphepnam=0;
		

		public PublicFunction()
		{
			//
			// TODO: Add constructor logic here
			//
		}

		public static void Init_System()
		{
			GPS=(T_String.IsNullTo0(GetOption("GPS")+"")==1);
			openfilekey();
			Get_Note();
			connection();
			CUS_ID=F_GetNote("[CUS_ID]",Path+"//CUS.ini");	
			L_Lag1=GetConfig("RP");
			
			if (L_Lag1!="VN" && L_Lag1!="CH" && L_Lag1!="EN" ) L_Lag1="";
			WID=GetOption("WID");
			WIDLEN=T_String.IsNullTo0(GetOption("WIDLEN")+"");

			Double dt1=T_String.IsNullTo00(T_String.GetDate().ToString("yyyyMMddHHmm"));
			Double dt=T_String.IsNullTo00(DateTime.Now.AddMinutes(6).ToString("yyyyMMddHHmm"));		
			Double dt2=T_String.IsNullTo00(DateTime.Now.AddMinutes(-6).ToString("yyyyMMddHHmm"));		
			if(dt1<dt2 || dt1>dt)
				MessageBox.Show(PublicFunction.L_Get_Msg("msg",300)+" "+ T_String.GetDate().ToString("yyyy/MM/dd HH:mm") );
			absent=T_String.IsNullTo0(PublicFunction.GetOption("ABSENTVACATE"));
			switch(PublicFunction.CUS_ID)
			{
				case "1":
				case "7" :
					tinhphepnam=1;
					break;
				case "10" :
					tinhphepnam=1;
					break;
			}
		}
		#region Connection
		public static void connection()
		{
			//C_con=new SqlConnection();
			C_con=connect(DT_server,DT_database,DT_username,DT_password);
			if (DT_databasedel!="")
				C_condel=connect(DT_server,DT_databasedel,DT_username,DT_password);
			C_ConStrForRPT="Provider=SQLOLEDB.1;Data Source="+DT_server+"; Initial Catalog="+DT_database+
			"; User ID="+DT_username+"; Password="+DT_password+";";
		}

		public static SqlConnection connect(string servername,string databasename,string usernm,string pass)
		{
				
			SqlConnection con=new SqlConnection();
			try
			{		
				con.ConnectionString="workstation id="+System.Environment.MachineName+";packet size=4096;user id="+usernm+
					";data source="+servername+";persist security info=True;initial catalog="+databasename+";password="+pass;
				con.Open();
				return con;
			}			
			catch (Exception ex)
			{
				MessageBox.Show("Can't connect to Server" + servername+ " "+ex.Message);
				return null;
			}
		}

//		public static SqlConnection connect(string servername,string databasename,string usernm,string pass)
//		{
//			SqlConnection con=new SqlConnection();
//			try
//			{		
//				con.ConnectionString="workstation id="+System.Environment.MachineName+";packet size=4096;user id="+usernm+
//					";data source="+servername+";persist security info=True;initial catalog="+databasename+";password="+pass;
//				con.Open();
//				return con;
//			}
//			catch (SqlException)
//			{
//				MessageBox.Show("Can't connect to ["+con.ConnectionString+"]");
//				return null;
//			}
//		}
		#endregion
		#region Execute
		public static void SQL_Execute(string sql,SqlConnection con)
		{
			try
			{
				if(con.State==ConnectionState.Closed)
					con.Open();
				SqlCommand cmd=new SqlCommand(sql,con);
				cmd.ExecuteNonQuery();				
			}
			catch(SqlException)
			{
				throw;
			}
		}
		public static void SQL_Execute(string sql,SqlConnection con,Boolean mess)
		{
			try
			{
				if(con.State==ConnectionState.Closed)
					con.Open();
				SqlCommand cmd=new SqlCommand(sql,con);
				cmd.ExecuteNonQuery();				
			}
			catch(SqlException ex)
			{
				MessageBox.Show(sql + " \n Execute Sql Error . Number:" + ex.Number + ". Description Error:" + ex.Message  );
				
			}
		}


		public static Boolean SQL_Execute(string sql)
		{
			try
			{
				if(C_con.State==ConnectionState.Closed)
					C_con.Open();
				SqlCommand cmd=new SqlCommand(sql,C_con);
				cmd.ExecuteNonQuery();
				return true;
			}
			catch(SqlException ex)
			{
				MessageBox.Show(sql + " \n Execute Sql Error . Number:" + ex.Number + ". Description Error:" + ex.Message  );
				return false;
			}
		}

		public static int SQL_Execute(string sql,Boolean returnvalue)
		{
			try
			{
				if(C_con.State==ConnectionState.Closed)
					C_con.Open();
				SqlCommand cmd=new SqlCommand(sql,C_con);
				cmd.ExecuteNonQuery();
				return 0;
			}
			catch(SqlException ex)
			{
				//MessageBox.Show(sql + " \n Execute Sql Error . Number:" + ex.Number + ". Description Error:" + ex.Message  );
				return ex.Number;
			}
		}
		public static SqlException SQL_Execute(string sql,int i)
		{
			try
			{
				if(C_con.State==ConnectionState.Closed)
					C_con.Open();
				SqlCommand cmd=new SqlCommand(sql,C_con);
				cmd.ExecuteNonQuery();
				return null;
			}
			catch(SqlException ex)
			{
				//MessageBox.Show(sql + " \n Execute Sql Error . Number:" + ex.Number + ". Description Error:" + ex.Message  );
				return ex;
			}
		}
#endregion
		#region Get Option
		public static string GetOption(string note)
		{
			string fn;
			fn=Path+"//option.ini";
			return F_GetNote("["+note+"]",fn);
		}		
		#endregion
		#region  Get_Config		
		public static void  Get_Note()
		{
			string fn;
			fn=Path+"//config.ini";
			L_Lag=F_GetNote("[LAG]",fn);
			L_FontName=F_GetNote("[FONTNAME]",fn);
			L_FontSize=F_GetNote("[FONTSIZE]",fn);
			A_UserID=F_GetNote("[USERID]",fn);	
	
			C_Connect=F_GetNote("[Connect_COM]",fn);
			C_port=F_GetNote("[PORT]",fn);
			C_Setting=F_GetNote("[Setting]",fn);
			C_WaitCOM=F_GetNote("[WaitCOM]",fn);
			min=T_String.IsNullTo0(F_GetNote("[MIN]",fn));
		}

		public static void  savefileconfig()
		{
			StreamWriter f;			
			try
			{
				f=File.CreateText(Path + "\\config.ini");				
				f.WriteLine("[LAG]="+L_Lag);
				f.WriteLine("[FONTNAME]="+L_FontName);
				f.WriteLine("[FONTSIZE]="+L_FontSize);
				f.WriteLine("[USERID]="+A_UserID);

				f.WriteLine("[Connect_COM]="+C_Connect);
				f.WriteLine("[PORT]="+C_port);
				f.WriteLine("[Setting]="+C_Setting);
				f.WriteLine("[WaitCOM]="+C_WaitCOM);
				f.WriteLine("[MIN]="+min);
				f.Close();
				PublicFunction.WriteToLogInfo(A_UserID,false);
				string sql="UPDATE SYS_CONTROL_USER SET STATE=0 WHERE USER_ID=N'"+A_UserID+"'";
				PublicFunction.SQL_Execute(sql);
			}
			catch (IOException )
			{
				MessageBox.Show("config.ini file no found","Error",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Error);
			}
		}
		public static void  SaveID(string id)
		{
			StreamWriter f;			
			try
			{
				f=File.CreateText(Path + "\\ID.ini");
				f.WriteLine("[ID]="+id);
				f.Close();								
			}
			catch (IOException )
			{
				MessageBox.Show("ID.ini file no found","Error",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Error);
			}
		}
#endregion
		#region Get Connection String
		public static void  openfilekey()
		{
			StreamReader f;
			try
			{
				f=File.OpenText(Path + "\\VT.BS");						
				
				if(GPS && PublicFunction.CUS_GPS)
				{
					DTGP_server=encode(f.ReadLine(),"DT_server");
					DTGP_database=encode(f.ReadLine(),"DT_database");	
					DTGP_username=encode(f.ReadLine(),"DT_username");
					DTGP_password=encode(f.ReadLine(),"DT_password");
					
					AD_Key=encode(f.ReadLine(),"AD_Key");
					DT_databasedel=encode(f.ReadLine(),"DT_databasedel");
					AD_Login=encode(f.ReadLine(),"AD_Login");	

					DT_server=encode(f.ReadLine(),"DTGP_server");
					DT_database=encode(f.ReadLine(),"DTGP_database");		
					DT_username=encode(f.ReadLine(),"DTGP_username");
					DT_password=encode(f.ReadLine(),"DTGP_password");
				}
				else
				{
					GPS=PublicFunction.CUS_GPS=false;
					DT_server=encode(f.ReadLine(),"DT_server");
					DT_database=encode(f.ReadLine(),"DT_database");	
					DT_username=encode(f.ReadLine(),"DT_username");
					DT_password=encode(f.ReadLine(),"DT_password");
					
					AD_Key=encode(f.ReadLine(),"AD_Key");
					DT_databasedel=encode(f.ReadLine(),"DT_databasedel");
					AD_Login=encode(f.ReadLine(),"AD_Login");	
				

					DTGP_server=encode(f.ReadLine(),"DTGP_server");
					DTGP_database=encode(f.ReadLine(),"DTGP_database");		
					DTGP_username=encode(f.ReadLine(),"DTGP_username");
					DTGP_password=encode(f.ReadLine(),"DTGP_password");
				}

				f.Close();			
			}
			catch (IOException )
			{
				MessageBox.Show("VT.BS file no found","Error",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Error);
			}
		}

		public static void  savefilekey()
		{
			StreamWriter f;			
			try
			{
				f=File.CreateText(Path + "\\VT.BS");		
				f.WriteLine(code(DT_server,"DT_server"));
				f.WriteLine(code(DT_database,"DT_database"));
				f.WriteLine(code(DT_username,"DT_username"));
				f.WriteLine(code(DT_password,"DT_password"));
				f.WriteLine(code(AD_Key,"AD_Key"));
				f.WriteLine(code(DT_databasedel,"DT_databasedel"));
				f.WriteLine(code(AD_Login,"AD_Login"));

				f.WriteLine(code(DTGP_server,"DTGP_server"));
				f.WriteLine(code(DTGP_database,"DTGP_database"));
				f.WriteLine(code(DTGP_username,"DTGP_username"));
				f.WriteLine(code(DTGP_password,"DTGP_password"));
				f.Close();			
			}
			catch (IOException )
			{
				MessageBox.Show("VT.BS file no found","Error",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Error);
			}
		}
#endregion
		#region Get Data from File
		public static string[] Get_Arr_Node(string _sNode, string _sFile)
		{
			try
			{
				string str;

				str = PublicFunction.F_GetNote(_sNode, _sFile);

				if (str == null || str == "")
					return null;

				string []arrNode = str.Split(',');

				for (int i=0; i<arrNode.Length; i++)
					arrNode[i] = arrNode[i].Trim();
				
				return arrNode;
			}
			catch
			{
				
			}

			return null;
		}

		public static string F_GetNote(string note,string FileName)//lay du lieu tu file config
		{
			try
			{
				string st;
				StreamReader f;
				f=File.OpenText(FileName);
				while (true)
				{
					st=f.ReadLine();
					if (st==null) 
					{
						f.Close();
						return null;
					}
					if (S_Left(st,note.Length)==note) 
					{
						f.Close();
						return st.Replace(note+"=","");
					}
				}								
			}
			catch(IOException)
			{
				MessageBox.Show(FileName+" file no found","Error",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Error);
			}
			return null;
		}
#endregion
		#region string
		public static string S_Right(string st,int count)
		{
			if ( st+""=="" || count>st.Length  || count<0)
				return "";
			return st.Remove(0,st.Length-count);
		}

		public static string S_Left(string st,int count)
		{
			if (st+""=="" ||  count>st.Length || count<0)
				return "";
			return st.Remove(count,st.Length-count);
		}
		
		public static string encode(string st,string key)
		{					
			return QD.TripleDES.DecryptWithKey(st,QD.TripleDES.Encrypt(key));				
			
		}

		public static string code(string st,string key)
		{
			return QD.TripleDES.EncryptWithKey(st,QD.TripleDES.Encrypt(key));
		}

//		public static string code(string st)
//		{
//			string temp,t;
//			temp="";
//			for( int i=0;i<st.Length;i++)
//			{
//				t=(Convert.ToInt16(st[i])+9)+"";
//				t=t.PadLeft(4,'0');
//				temp= temp + t;
//			}
//			return temp;
//		}
//
//		public static string encode(string st)
//		{
//			string temp,t;
//			temp="";
//			while (st!="" && st!=null)
//			{
//				t=st.Remove(4,st.Length-4);
//				st=st.Remove(0,4);				
//				temp=temp + Convert.ToChar((T_String.IsNullTo0 (t))-9);
//			}
//			return temp;
//		}
#endregion
		#region Get Label
		public static string L_GetLabel(string Name, int ID)
		{
			string sql;
			sql="select ["+L_Lag+"] from [SYS_LABEL] where [NAME]=N'"+Name+"' and [ID]="+ID;
			Func.RecordSet rs=new Func.RecordSet(sql,C_con);
			if(rs.rows>0)
				return rs.record(0,0);
			return "Can't find "+Name+"_"+ID;
		}

		public static string L_GetLabel(string Name, string FName)
		{
			string sql;
			sql="select ["+L_Lag+"] from [SYS_LABEL] where [NAME]=N'"+Name+"' and FNAME=N'"+T_String.sqlsql(FName)+"'";
			Func.RecordSet rs=new Func.RecordSet(sql,C_con);
			if(rs.rows>0)
				return rs.record(0,0);
			return "Can't find "+Name+"_"+FName;
		}

		public static string L_Get_Msg(string Name, int ID)
		{
			string sql;
			sql="select ["+L_Lag+"] from [SYS_MSG] where [NAME]=N'"+Name+"' and [ID]="+ID;
			Func.RecordSet rs=new Func.RecordSet(sql,C_con);
			if(rs.rows>0)
				return rs.record(0,0);
			return "Can't find "+Name+"_"+ID;
		}

		public static string L_Get_Msg(string Name, string FName)
		{
			string sql;
			sql="select ["+L_Lag+"] from [SYS_MSG] where [NAME]=N'"+Name+"' and FNAME=N'"+T_String.sqlsql(FName)+"'";
			Func.RecordSet rs=new Func.RecordSet(sql,C_con);
			if(rs.rows>0)
				return rs.record(0,0);
			return "Can't find "+Name+"_"+FName;
		}
		public static string L_Get_Msg(string Name, int ID,SqlConnection con)
		{
			string sql;
			sql="select ["+L_Lag+"] from [SYS_MSG] where [NAME]=N'"+Name+"' and [ID]="+ID;
			Func.RecordSet rs=new Func.RecordSet(sql,con);
			if(rs.rows>0)
				return rs.record(0,0);
			return "Can't find "+Name+"_"+ID;
		}

		public static string L_Get_Msg(string Name, string FName,SqlConnection con)
		{
			string sql;
			sql="select ["+L_Lag+"] from [SYS_MSG] where [NAME]=N'"+Name+"' and FNAME=N'"+T_String.sqlsql(FName)+"'";
			Func.RecordSet rs=new Func.RecordSet(sql,con);
			if(rs.rows>0)
				return rs.record(0,0);
			return "Can't find "+Name+"_"+FName;
		}
		public static string L_Get_RPT(string Name, int ID)
		{
			return L_Get_RPT(Name,ID,false);
		}
		public static string L_Get_RPT(string Name, int ID, Boolean down)
		{			 
			string sql;
			sql="["+L_Lag+"]";
			if (L_Lag1!="")
			{
				if (down)
					sql="["+L_Lag+"] + '\n' + ["+L_Lag1+"] as a" ;
				else
					sql="["+L_Lag+"] + ' ' + ["+L_Lag1+"] as a" ;
			}
			sql="select "+sql+" from [SYS_LABEL_RPT] where [NAME]=N'"+Name+"' and [ID]="+ID;
			Func.RecordSet rs=new Func.RecordSet(sql,C_con);
			if(rs.rows>0)
				return rs.record(0,0);
			return "Can't find "+Name+"_"+ID;
		}
		public static string L_Get_RPT(string Name, string FName)
		{
			return L_Get_RPT(Name,FName,false);
		}
		public static string L_Get_RPT(string Name, string FName, Boolean down)
		{
			string sql;
			sql="["+L_Lag+"]";
			if (L_Lag1!="")
			{
				if (down)
					sql="["+L_Lag+"] + '\n' + ["+L_Lag1+"] as a" ;
				else
					sql="["+L_Lag+"] + ' ' + ["+L_Lag1+"] as a" ;
			}
			sql="select "+sql+" from [SYS_LABEL_RPT] where [NAME]=N'"+Name+"' and FNAME=N'"+FName+"'";
			Func.RecordSet rs=new Func.RecordSet(sql,C_con);
			if(rs.rows>0)
				return rs.record(0,0);
			return "Can't find "+Name+"_"+FName;
		}

		public static string L_Get_PopMenu(string Name, int ID)
		{
			string sql;
			sql="select ["+L_Lag+"] from [SYS_LABEL_PMENU] where [NAME]=N'"+Name+"' and [ID]="+ID;
			Func.RecordSet rs=new Func.RecordSet(sql,C_con);
			if(rs.rows>0)
				return rs.record(0,0);
			return "Can't find "+Name+"_"+ID;
		}

		public static string L_Get_PopMenu(string Name, string FName)
		{
			string sql;
			sql="select ["+L_Lag+"] from [SYS_LABEL_PMENU] where [NAME]=N'"+Name+"' and FNAME=N'"+FName+"'";
			Func.RecordSet rs=new Func.RecordSet(sql,C_con);
			if(rs.rows>0)
				return rs.record(0,0);
			return "Can't find "+Name+"_"+FName;
		}

		public static string L_GetLabel_VS(string Name, string FName)
		{
			string sql;
			sql="select ["+L_Lag+"] from [SYS_LABEL_VS] where [NAME]=N'"+Name+"' and FNAME=N'"+FName+"'";
			Func.RecordSet rs=new Func.RecordSet(sql,C_con);
			if(rs.rows>0)
				return rs.record(0,0);
			return "Can't find "+Name+"_"+FName;
		}
		public static string L_GetLabel_VS(string Name, string FName,string tb)
		{
			string sql;
			sql="select ["+L_Lag+"] from "+tb+" where [NAME]=N'"+Name+"' and FNAME=N'"+FName+"'";
			Func.RecordSet rs=new Func.RecordSet(sql,C_con);
			if(rs.rows>0)
				return rs.record(0,0);
			return "Can't find "+Name+"_"+FName;
		}
		public static string L_GetLabel_VS(string Name, int ID)
		{
			string sql;
			sql="select ["+L_Lag+"] from [SYS_LABEL_VS] where [NAME]=N'"+Name+"' and ID="+ID+"";
			Func.RecordSet rs=new Func.RecordSet(sql,C_con);
			if(rs.rows>0)
				return rs.record(0,0);
			return "Can't find "+Name+"_"+ID;
		}
		public static void L_Init_Label(System.Windows.Forms.Form fr)
		{
			L_Init_Label(fr,fr.Name);
		}
		public static void L_Init_Label(C1.Win.C1FlexGrid.C1FlexGrid vs,string frName)
		{
			L_Init_Label(vs,frName,"SYS_LABEL_VS_ATT");
		}
		public static void L_Init_Label(C1.Win.C1FlexGrid.C1FlexGrid vs,string frName,string tb)
		{
			System.Drawing.Font font=new System.Drawing.Font(L_FontName
				,float.Parse(L_FontSize), System.Drawing.FontStyle.Regular, System.Drawing.
				GraphicsUnit.Point, ((System.Byte)(0)));						
			vs.Font=font;						
			for(int j=1;j<vs.Cols.Count;j++)
			{
				if (vs.Cols[j].Name=="SYSSEL")
					vs.Cols[j][0]=L_GetLabel_VS("Public","SYS_SEL");
				else
					vs.Cols[j][0]=L_GetLabel_VS(frName,vs.Cols[j].Name,tb);
			}			
			vs.AutoSizeCols();
		}
		public static void L_Init_Label(System.Windows.Forms.Form fr,string frName)
		{
			GP8000.Function.TaHelp help=new GP8000.Function.TaHelp(fr);
			System.Drawing.Font font=new System.Drawing.Font(L_FontName
				,float.Parse(L_FontSize), System.Drawing.FontStyle.Regular, System.Drawing.
				GraphicsUnit.Point, ((System.Byte)(0)));			
			fr.Text=PublicFunction.L_GetLabel(frName,frName);
			fr.Font=font;
			ArrayList nav=new ArrayList(); 
			for(int i=0;i<fr.Controls.Count;i++)
			{			
				switch (fr.Controls[i].GetType().FullName)
				{
					case "C1.Win.C1FlexGrid.C1FlexGrid":
						if ((fr.Controls[i].Tag+"")=="N") break;
						C1.Win.C1FlexGrid.C1FlexGrid vs;
						vs=((C1.Win.C1FlexGrid.C1FlexGrid)fr.Controls[i]);
						for(int j=1;j<vs.Cols.Count;j++)
						{
							if (vs.Cols[j].Name=="SYSSEL")
								vs.Cols[j][0]=L_GetLabel_VS("Public","SYS_SEL");
							else
								vs.Cols[j][0]=L_GetLabel_VS(frName+"_"+vs.Name,vs.Cols[j].Name);
						}
						vs.AutoSizeCols();
						break;
					case "System.Windows.Forms.Label":
					case "System.Windows.Forms.Button":
					case "System.Windows.Forms.CheckBox":
					case "System.Windows.Forms.RadioButton":	
						if ((fr.Controls[i].Tag+"")=="N") break;
						fr.Controls[i].Text=PublicFunction.L_GetLabel(frName,fr.Controls[i].Name);
						break;					
					case "System.Windows.Forms.GroupBox":
						L_Init_Label((System.Windows.Forms.GroupBox)fr.Controls[i],frName,nav);
						if ((fr.Controls[i].Tag+"")=="N") break;
						fr.Controls[i].Text=PublicFunction.L_GetLabel(frName,fr.Controls[i].Name);						
						break;
					case "C1.Win.C1Command.C1CommandDock":
						L_Init_Label((C1.Win.C1Command.C1CommandDock)fr.Controls[i],frName,nav);
						break;
					case "C1.Win.C1Command.C1DockingTab":
						L_Init_Label((C1.Win.C1Command.C1DockingTab)fr.Controls[i],frName,nav);
						break;
					case "C1.Win.C1Command.C1DockingTabPage":
						L_Init_Label((C1.Win.C1Command.C1DockingTabPage)fr.Controls[i],frName,nav);
						if ((fr.Controls[i].Tag+"")=="N") break;
						fr.Controls[i].Text=PublicFunction.L_GetLabel(frName,fr.Controls[i].Name);						
						break;
					case "System.Windows.Forms.Panel":
						L_Init_Label((System.Windows.Forms.Panel)fr.Controls[i],frName,nav);
						break;
					
					case "Navigator1._0.NavigatorAuto":
						if ((fr.Controls[i].Tag+"")=="N") break;
						nav.Add(fr.Controls[i]);
						break;
				}
				//				fr.Controls[i].Font=font;
			}

			for (int i=0;i<nav.Count;i++)
			{
				if (((Navigator1._0.NavigatorAuto)nav[i]).Tag+""!="N") 
				{
					((Navigator1._0.NavigatorAuto)nav[i]).Init_PMenu_Color();
					for (int j=0;j<((Navigator1._0.NavigatorAuto)nav[i]).TBar.Buttons.Count;j++)			
						if (((Navigator1._0.NavigatorAuto)nav[i]).TBar.Buttons[j].Style!=ToolBarButtonStyle.Separator)
						{
							((Navigator1._0.NavigatorAuto)nav[i]).TBar.Buttons[j].ToolTipText=L_GetLabel("SYS_NAV",((Navigator1._0.NavigatorAuto)nav[i]).TBar.Buttons[j].Tag+"");						
						}
					((Navigator1._0.NavigatorAuto)nav[i]).Grid.Enabled=	!((Navigator1._0.NavigatorAuto)nav[i]).Grid.Enabled;
					((Navigator1._0.NavigatorAuto)nav[i]).Grid.Enabled=	!((Navigator1._0.NavigatorAuto)nav[i]).Grid.Enabled;
				}
			}
		}

		public static void L_Init_Label(System.Windows.Forms.GroupBox fr,string name,ArrayList nav)
		{
			System.Drawing.Font font=new System.Drawing.Font(L_FontName
				,float.Parse(L_FontSize), System.Drawing.FontStyle.Regular, System.Drawing.
				GraphicsUnit.Point, ((System.Byte)(0)));			
			fr.Font=font;			
			for(int i=0;i<fr.Controls.Count;i++)
			{					
				switch (fr.Controls[i].GetType().FullName)
				{
					case "C1.Win.C1FlexGrid.C1FlexGrid":
						if ((fr.Controls[i].Tag+"")=="N") break;
						C1.Win.C1FlexGrid.C1FlexGrid vs;
						vs=((C1.Win.C1FlexGrid.C1FlexGrid)fr.Controls[i]);
						for(int j=1;j<vs.Cols.Count;j++)
						{
							if (vs.Cols[j].Name=="SYSSEL")
								vs.Cols[j][0]=L_GetLabel_VS("Public","SYS_SEL");
							else
								vs.Cols[j][0]=L_GetLabel_VS(name+"_"+vs.Name,vs.Cols[j].Name);
						}
						vs.AutoSizeCols();
						break;
					case "System.Windows.Forms.Label":
					case "System.Windows.Forms.Button":
					case "System.Windows.Forms.CheckBox":					
					case "System.Windows.Forms.RadioButton":	
						if ((fr.Controls[i].Tag+"")=="N") break;
						fr.Controls[i].Text=PublicFunction.L_GetLabel(name,fr.Controls[i].Name);
						break;		
					case "System.Windows.Forms.GroupBox":
						L_Init_Label((System.Windows.Forms.GroupBox)fr.Controls[i],name,nav);
						if ((fr.Controls[i].Tag+"")=="N") break;
						fr.Controls[i].Text=PublicFunction.L_GetLabel(name,fr.Controls[i].Name);					
						break;					
					case "C1.Win.C1Command.C1CommandDock":
						L_Init_Label((C1.Win.C1Command.C1CommandDock)fr.Controls[i],name,nav);
						break;
					case "C1.Win.C1Command.C1DockingTab":
						L_Init_Label((C1.Win.C1Command.C1DockingTab)fr.Controls[i],name,nav);
						break;
					case "C1.Win.C1Command.C1DockingTabPage":
						L_Init_Label((C1.Win.C1Command.C1DockingTabPage)fr.Controls[i],name,nav);
						if ((fr.Controls[i].Tag+"")=="N") break;
						fr.Controls[i].Text=PublicFunction.L_GetLabel(name,fr.Controls[i].Name);						
						break;
					case "System.Windows.Forms.Panel":						
						L_Init_Label((System.Windows.Forms.Panel)fr.Controls[i],name,nav);
						break;
					case "Navigator1._0.NavigatorAuto":	
						if ((fr.Controls[i].Tag+"")=="N") break;
						nav.Add(fr.Controls[i]);
						break;
				}				
			}
		}

		public static void L_Init_Label(System.Windows.Forms.Panel fr,string name,ArrayList nav)
		{
			if (fr.Tag+""=="N")
				return;
			System.Drawing.Font font=new System.Drawing.Font(L_FontName
				,float.Parse(L_FontSize), System.Drawing.FontStyle.Regular, System.Drawing.
				GraphicsUnit.Point, ((System.Byte)(0)));			
			fr.Font=font;			
			for(int i=0;i<fr.Controls.Count;i++)
			{			
				switch (fr.Controls[i].GetType().FullName)
				{
					case "C1.Win.C1FlexGrid.C1FlexGrid":
						if ((fr.Controls[i].Tag+"")=="N") break;
						C1.Win.C1FlexGrid.C1FlexGrid vs;
						vs=((C1.Win.C1FlexGrid.C1FlexGrid)fr.Controls[i]);
						for(int j=1;j<vs.Cols.Count;j++)
						{
							if (vs.Cols[j].Name=="SYSSEL")
								vs.Cols[j][0]=L_GetLabel_VS("Public","SYS_SEL");
							else
								vs.Cols[j][0]=L_GetLabel_VS(name+"_"+vs.Name,vs.Cols[j].Name);
						}
						vs.AutoSizeCols();
						break;
					case "System.Windows.Forms.Label":
					case "System.Windows.Forms.Button":
					case "System.Windows.Forms.CheckBox":					
					case "System.Windows.Forms.RadioButton":
						if ((fr.Controls[i].Tag+"")=="N") break;
						fr.Controls[i].Text=PublicFunction.L_GetLabel(name,fr.Controls[i].Name);
						break;		
					case "System.Windows.Forms.GroupBox":
						L_Init_Label((System.Windows.Forms.GroupBox)fr.Controls[i],name,nav);
						if ((fr.Controls[i].Tag+"")=="N") break;
						fr.Controls[i].Text=PublicFunction.L_GetLabel(name,fr.Controls[i].Name);						
						break;					
					case "C1.Win.C1Command.C1CommandDock":
						L_Init_Label((C1.Win.C1Command.C1CommandDock)fr.Controls[i],name,nav);
						break;
					case "C1.Win.C1Command.C1DockingTab":
						L_Init_Label((C1.Win.C1Command.C1DockingTab)fr.Controls[i],name,nav);
						break;
					case "C1.Win.C1Command.C1DockingTabPage":
						L_Init_Label((C1.Win.C1Command.C1DockingTabPage)fr.Controls[i],name,nav);
						if ((fr.Controls[i].Tag+"")=="N") break;
						fr.Controls[i].Text=PublicFunction.L_GetLabel(name,fr.Controls[i].Name);						
						break;
					case "System.Windows.Forms.Panel":						
						L_Init_Label((System.Windows.Forms.Panel)fr.Controls[i],name,nav);
						break;
					case "Navigator1._0.NavigatorAuto":						
						nav.Add(fr.Controls[i]);
						break;
				}
				//				fr.Controls[i].Font=font;
			}
		}

		public static void L_Init_Label(C1.Win.C1Command.C1CommandDock fr,string name,ArrayList nav)
		{
			System.Drawing.Font font=new System.Drawing.Font(L_FontName
				,float.Parse(L_FontSize), System.Drawing.FontStyle.Regular, System.Drawing.
				GraphicsUnit.Point, ((System.Byte)(0)));			
			fr.Font=font;			
			for(int i=0;i<fr.Controls.Count;i++)
			{			
				switch (fr.Controls[i].GetType().FullName)
				{
					case "C1.Win.C1FlexGrid.C1FlexGrid":
						if ((fr.Controls[i].Tag+"")=="N") break;
						C1.Win.C1FlexGrid.C1FlexGrid vs;
						vs=((C1.Win.C1FlexGrid.C1FlexGrid)fr.Controls[i]);
						for(int j=1;j<vs.Cols.Count;j++)
						{
							if (vs.Cols[j].Name=="SYSSEL")
								vs.Cols[j][0]=L_GetLabel_VS("Public","SYS_SEL");
							else
								vs.Cols[j][0]=L_GetLabel_VS(name+"_"+vs.Name,vs.Cols[j].Name);
						}
						vs.AutoSizeCols();						
						break;
					case "System.Windows.Forms.Label":
					case "System.Windows.Forms.Button":
					case "System.Windows.Forms.CheckBox":					
					case "System.Windows.Forms.RadioButton":
						if ((fr.Controls[i].Tag+"")=="N") break;
						fr.Controls[i].Text=PublicFunction.L_GetLabel(name,fr.Controls[i].Name);
						break;		
					case "System.Windows.Forms.GroupBox":
						L_Init_Label((System.Windows.Forms.GroupBox)fr.Controls[i],name,nav);
						if ((fr.Controls[i].Tag+"")=="N") break;
						fr.Controls[i].Text=PublicFunction.L_GetLabel(name,fr.Controls[i].Name);						
						break;					
					case "C1.Win.C1Command.C1CommandDock":
						L_Init_Label((C1.Win.C1Command.C1CommandDock)fr.Controls[i],name,nav);
						break;
					case "C1.Win.C1Command.C1DockingTab":
						L_Init_Label((C1.Win.C1Command.C1DockingTab)fr.Controls[i],name,nav);
						break;
					case "C1.Win.C1Command.C1DockingTabPage":
						L_Init_Label((C1.Win.C1Command.C1DockingTabPage)fr.Controls[i],name,nav);
						if ((fr.Controls[i].Tag+"")=="N") break;
						fr.Controls[i].Text=PublicFunction.L_GetLabel(name,fr.Controls[i].Name);						
						break;
					case "System.Windows.Forms.Panel":						
						L_Init_Label((System.Windows.Forms.Panel)fr.Controls[i],name,nav);
						break;
					case "Navigator1._0.NavigatorAuto":						
						nav.Add(fr.Controls[i]);
						break;
				}
				//				fr.Controls[i].Font=font;
			}
		}

		public static void L_Init_Label(C1.Win.C1Command.C1DockingTab fr,string name,ArrayList nav)
		{
			System.Drawing.Font font=new System.Drawing.Font(L_FontName
				,float.Parse(L_FontSize), System.Drawing.FontStyle.Regular, System.Drawing.
				GraphicsUnit.Point, ((System.Byte)(0)));			
			fr.Font=font;			
			for(int i=0;i<fr.Controls.Count;i++)
			{			
				switch (fr.Controls[i].GetType().FullName)
				{
					case "C1.Win.C1FlexGrid.C1FlexGrid":
						if ((fr.Controls[i].Tag+"")=="N") break;
						C1.Win.C1FlexGrid.C1FlexGrid vs;
						vs=((C1.Win.C1FlexGrid.C1FlexGrid)fr.Controls[i]);
						for(int j=1;j<vs.Cols.Count;j++)
						{
							if (vs.Cols[j].Name=="SYSSEL")
								vs.Cols[j][0]=L_GetLabel_VS("Public","SYS_SEL");
							else
								vs.Cols[j][0]=L_GetLabel_VS(name+"_"+vs.Name,vs.Cols[j].Name);
						}
						vs.AutoSizeCols();
						break;
					case "System.Windows.Forms.Label":
					case "System.Windows.Forms.Button":
					case "System.Windows.Forms.CheckBox":					
					case "System.Windows.Forms.RadioButton":
						if ((fr.Controls[i].Tag+"")=="N") break;
						fr.Controls[i].Text=PublicFunction.L_GetLabel(name,fr.Controls[i].Name);
						break;		
					case "System.Windows.Forms.GroupBox":
						L_Init_Label((System.Windows.Forms.GroupBox)fr.Controls[i],name,nav);
						if ((fr.Controls[i].Tag+"")=="N") break;
						fr.Controls[i].Text=PublicFunction.L_GetLabel(name,fr.Controls[i].Name);						
						break;					
					case "C1.Win.C1Command.C1CommandDock":
						L_Init_Label((C1.Win.C1Command.C1CommandDock)fr.Controls[i],name,nav);
						break;
					case "C1.Win.C1Command.C1DockingTab":
						L_Init_Label((C1.Win.C1Command.C1DockingTab)fr.Controls[i],name,nav);
						break;
					case "C1.Win.C1Command.C1DockingTabPage":
						L_Init_Label((C1.Win.C1Command.C1DockingTabPage)fr.Controls[i],name,nav);
						if ((fr.Controls[i].Tag+"")=="N") break;
						fr.Controls[i].Text=PublicFunction.L_GetLabel(name,fr.Controls[i].Name);						
						break;
					case "System.Windows.Forms.Panel":						
						L_Init_Label((System.Windows.Forms.Panel)fr.Controls[i],name,nav);
						break;
					case "Navigator1._0.NavigatorAuto":						
						nav.Add(fr.Controls[i]);
						break;
				}
				//				fr.Controls[i].Font=font;
			}
		}
		
		public static void L_Init_Label(C1.Win.C1Command.C1DockingTabPage fr,string name,ArrayList nav)
		{
			System.Drawing.Font font=new System.Drawing.Font(L_FontName
				,float.Parse(L_FontSize), System.Drawing.FontStyle.Regular, System.Drawing.
				GraphicsUnit.Point, ((System.Byte)(0)));			
			fr.Font=font;			
			for(int i=0;i<fr.Controls.Count;i++)
			{			
				switch (fr.Controls[i].GetType().FullName)
				{
					case "C1.Win.C1FlexGrid.C1FlexGrid":
						if ((fr.Controls[i].Tag+"")=="N") break;
						C1.Win.C1FlexGrid.C1FlexGrid vs;
						vs=((C1.Win.C1FlexGrid.C1FlexGrid)fr.Controls[i]);
						for(int j=1;j<vs.Cols.Count;j++)
						{
							if (vs.Cols[j].Name=="SYSSEL")
								vs.Cols[j][0]=L_GetLabel_VS("Public","SYS_SEL");
							else
								vs.Cols[j][0]=L_GetLabel_VS(name+"_"+vs.Name,vs.Cols[j].Name);
						}
						vs.AutoSizeCols();					
						break;
					case "System.Windows.Forms.Label":
					case "System.Windows.Forms.Button":
					case "System.Windows.Forms.CheckBox":					
					case "System.Windows.Forms.RadioButton":
						if ((fr.Controls[i].Tag+"")=="N") break;
						fr.Controls[i].Text=PublicFunction.L_GetLabel(name,fr.Controls[i].Name);
						break;		
					case "System.Windows.Forms.GroupBox":
						L_Init_Label((System.Windows.Forms.GroupBox)fr.Controls[i],name,nav);
						if ((fr.Controls[i].Tag+"")=="N") break;
						fr.Controls[i].Text=PublicFunction.L_GetLabel(name,fr.Controls[i].Name);						
						break;					
					case "C1.Win.C1Command.C1CommandDock":
						L_Init_Label((C1.Win.C1Command.C1CommandDock)fr.Controls[i],name,nav);
						break;
					case "C1.Win.C1Command.C1DockingTab":
						L_Init_Label((C1.Win.C1Command.C1DockingTab)fr.Controls[i],name,nav);
						break;
					case "C1.Win.C1Command.C1DockingTabPage":
						L_Init_Label((C1.Win.C1Command.C1DockingTabPage)fr.Controls[i],name,nav);
						if ((fr.Controls[i].Tag+"")=="N") break;
						fr.Controls[i].Text=PublicFunction.L_GetLabel(name,fr.Controls[i].Name);						
						break;
					case "System.Windows.Forms.Panel":						
						L_Init_Label((System.Windows.Forms.Panel)fr.Controls[i],name,nav);
						break;
					case "Navigator1._0.NavigatorAuto":						
						nav.Add(fr.Controls[i]);
						break;
				}
				//				fr.Controls[i].Font=font;
			}
		}
#endregion
		#region security
	
		/// <summary>
		/// Access Level
		/// </summary>
		/// <param name="MenuID"></param>
		/// <param name="UserID"></param>
		/// <param name="con"></param>
		/// <param name="Type">1=add ; 2=delete ; 3=update ;4=print	 </param> 	
		/// <returns></returns>

		static public Boolean AccessLevel(Object MenuID,int Type)
		{
			return AccessLevel((int)MenuID,Type);
		}
		static public Boolean AccessLevel(int MenuID,int Type)
		{
			if (MenuID==0 || A_UserID==null) return true;
			string st,sql;
			st="";
			switch (Type)
			{
				case 1:
					st="ADD";
					break;
				case 2:
					st="DELETE";
					break;
				case 3:
					st="UPDATE";
					break;
				case 4:
					st="PRINT";
					break;
				case 5:
					st="USAGE";
					break;
			}
			if (st=="") return false;
			sql="Select [" +st+"] from SYS_SECURITY a,SYS_USER b where b.GROUP_ID=a.GROUP_ID and USER_ID=N'"+A_UserID+"' and MNU_ID="+MenuID;
			Func.RecordSet rs=new Func.RecordSet(sql,C_con);
			if (rs.rows>0 && rs.record(0,0)=="True") 	return true;
			return false;

		}
#endregion
		#region Init
		static public void InitNav(System.Windows.Forms.Form fr,C1.Win.C1FlexGrid.C1FlexGrid vs,Navigator1._0.NavigatorAuto nav1,string frName)
		{
			nav1.Grid=vs;	
			nav1.FormName=frName;   ;			
			nav1.Connection=PublicFunction.C_con;
			nav1.form=fr;
			nav1.Language=PublicFunction.L_Lag;
			// Security
			nav1.Security=(int)fr.Tag;
			nav1.UserID=PublicFunction.A_UserID;			
			
			if (CUS_ID=="4") // Cartina
				nav1.History=true;
			else 
				nav1.History=false;
			if (PublicFunction.C_condel!=null && PublicFunction.C_condel.State==ConnectionState.Open)
				nav1.ConnectionDel=PublicFunction.C_condel;
		}
		static public void InitNav(System.Windows.Forms.Form fr,C1.Win.C1FlexGrid.C1FlexGrid vs,Navigator1._0.NavigatorAuto nav1)
		{
			nav1.Grid=vs;	
			nav1.FormName=fr.Name+"_" + vs.Name   ;			
			nav1.Connection=PublicFunction.C_con;
			nav1.form=fr;
			nav1.Language=PublicFunction.L_Lag;
			// Security
			nav1.Security=(int)fr.Tag;
			nav1.UserID=PublicFunction.A_UserID;
			nav1.Init_Control();
			
			if (CUS_ID=="4") // Cartina
				nav1.History=true;
			else 
				nav1.History=false;
			if (PublicFunction.C_condel!=null && PublicFunction.C_condel.State==ConnectionState.Open)
				nav1.ConnectionDel=PublicFunction.C_condel;
		}
		static public void InitNav(System.Windows.Forms.Form fr,C1.Win.C1FlexGrid.C1FlexGrid vs,Navigator1._0.Navigator nav1)
		{
			nav1.Grid=vs;										
			nav1.form=fr;			
		}
		public static Hashtable InitCBForVS(string sql)
		{
			Func.RecordSet rs=new Func.RecordSet(sql,PublicFunction.C_con);
			Hashtable a=new Hashtable();
			a.Add("","");
			for(int i=0;i<rs.rows;i++)
			{
				a.Add(rs.record(i,0),rs.record(i,1));
			}
			return a;
		}
		public static Hashtable InitCBForVS(string sql,Boolean empty)
		{
			Func.RecordSet rs=new Func.RecordSet(sql,PublicFunction.C_con);
			Hashtable a=new Hashtable();			
			for(int i=0;i<rs.rows;i++)
			{
				a.Add(rs.record(i,0),rs.record(i,1));
			}
			return a;
		}
		public static void InitCB(ComboBox cb, string sql,Boolean empty)
		{
			Func.RecordSet rs=new Func.RecordSet(sql,PublicFunction.C_con);			
			DataTable tb1=new DataTable("CB");			
			tb1.Columns.Add(rs.Field(0));
			tb1.Columns.Add(rs.Field(1));			
			DataRow a= tb1.NewRow();
			if(empty)
			{
				a[rs.Field(0)]="";
				a[rs.Field(1)]="";
				tb1.Rows.Add(a);						
			}
			for(int i=0;i<rs.rows;i++)
			{
				a= tb1.NewRow();
				a[rs.Field(0)]=rs.record(i,0);
				a[rs.Field(1)]=rs.record(i,1);
				tb1.Rows.Add(a);				
			}			
			cb.DataSource=tb1;
			cb.DisplayMember=rs.Field(1);
			cb.ValueMember=rs.Field(0);
		}
		public static void InitCB(ComboBox cb, string sql)
		{
			InitCB(cb,sql,true);
			
		}		
		public static string GetDep(string ID)
		{	
			string sql;
			sql="Select a.DEP_ID,DEP_NM  from SYS_SECURITY_DEP a,FILA02A b where a.MNU_ID="+ID
				+" and a.ALL_BT=1 and a.DEP_ID=b.DEP_ID and USER_ID=N'"+A_UserID+"'";		
			return sql;
		}
		#endregion
		#region state
		static public string CheckState(string id)
		{
			string result="";
			string mac_nm;
			Func.RecordSet rs=new Func.RecordSet("SELECT * FROM SYS_CONTROL_USER WHERE USER_ID=N'"+id+"'",PublicFunction.C_con);
			if(rs.rows>0)// da tung dang nhap vao he thong
			{
				if(rs.record(0,"STATE").ToString()=="True")//hien tai dang dang nhap vao he thong tren 1 may nao do'
				{
					mac_nm=rs.record(0,"MAC_NM");
					if(mac_nm!=Environment.MachineName.ToString())// moi them dong nay
						result="User '"+id+"' has logged in machine name '"+mac_nm+"'";
					else
					{
						string sql="";
						sql="UPDATE SYS_CONTROL_USER SET TIM_DR='"+DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")+"' where USER_ID=N'"+id+"'";
						PublicFunction.SQL_Execute(sql);
					}
				}
				else//hien tai chua dang nhap tren may nao
				{
					string sql="";
					sql="UPDATE SYS_CONTROL_USER SET STATE=1,MAC_NM=N'"+Environment.MachineName.ToString()+"',TIM_DR='"+DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")+"' where USER_ID=N'"+id+"'";
					PublicFunction.SQL_Execute(sql);
				}
			}
			else// chua dang nhap he thong lan nao
			{
				string sql="";
				sql="INSERT INTO SYS_CONTROL_USER VALUES (N'"+id+"',1,'"+Environment.MachineName.ToString()+"','"+DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")+"')";
				PublicFunction.SQL_Execute(sql);
			}
			return result;
		}
		static public void WriteToLogInfo(string uid,bool log) // true :login , false :logout
		{

			string sql;
			if(log) // Log in
			{
				sql="INSERT INTO SYS_LOG_INFO (USER_ID,MAC_DR,LOGIN_DT) VALUES (N'"+uid+"',N'"+Environment.MachineName.ToString()+"','"+DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")+"')";
				PublicFunction.SQL_Execute(sql);
			}
			else // Log out
			{
				sql="SELECT * FROM SYS_CONTROL_USER WHERE USER_ID=N'"+uid+"'";
				Func.RecordSet rs=new Func.RecordSet(sql,PublicFunction.C_con);
				if(rs.rows>0)
				{
					sql="UPDATE SYS_LOG_INFO SET LOGOUT_DT='"+DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")+"' WHERE USER_ID=N'"+uid+"' and LOGIN_DT='"+DateTime.Parse(rs.record(0,"TIM_DR")).ToString("yyyy/MM/dd HH:mm:ss")+"'";     
					PublicFunction.SQL_Execute(sql);
				}
			}
		}
		#endregion	
		#region Get from xml
		
		public static string GetConfig(string ID)
		{			
			string configFilePath = PublicFunction.Path + "\\Option.xml";
			try
			{
				System.Data.DataSet ds = new DataSet();
				ds.ReadXml(configFilePath);
				return ds.Tables["Config"].Rows[0][ID]+"";			
			}
			catch
			{
				return "error"+ID;
			}
		}
		#endregion

		public static void  Copy_Table(string FromTable, string NewTable,SqlConnection con)
		{
			string sql,st="",key="";
			string IDTable=T_String.GetDataFromSQL("ID","sysobjects","name='"+FromTable+"'");			
			sql=  "SELECT c.colid,c.name,ty.name AS datatype,c.length,c.isnullable,c.cdefault,c.prec,c.id" +
				" FROM syscolumns c INNER JOIN systypes ty ON c.xtype = ty.xtype WHERE (ty.name <> N'sysname')"+
				" AND c.id = N'"+ IDTable + "' order by colid ";
			Func.RecordSet rs =new Func.RecordSet(sql,con);
			for(int i=0;i<rs.rows;i++)
			{
				if(i!=0) st+=",";
				st+="["+rs.record(i,"name")+"] "; // ten bang
				st+=rs.record(i,"datatype");
				if(S_Right(rs.record(i,"datatype"),4)=="char" || S_Right(rs.record(i,"datatype"),6)=="binary")
				{
					 st+= "(" + rs.record(i,"length")+ ") "; // chieu dai
				}
				if(rs.record(i,"cdefault")+""!="0") // default
				{					
					string tam=T_String.GetDataFromSQL("text","syscomments","id="+rs.record(i,"cdefault"));	
					if(tam!="")
					{
						st+=" Default "+tam;
					}
				}
				if(rs.record(i,"isnullable")+""=="0") // allow null
					st+=" not null";
				int count=T_String.IsNullTo0(T_String.GetDataFromSQL("Count(*)","sysindexkeys","indid=1 and id="+IDTable+" and colid="+rs.record(i,"colid"))+"");
				if(count>0)
				{
					if (key!="") key+=",";
					key+="["+rs.record(i,"name")+"] ";
				}
			}
			st="Create Table ["+NewTable+"]("+st;
			if(key!="")
			{
				int count=T_String.IsNullTo0(T_String.GetDataFromSQL("Count(*)","sysobjects","name='"+NewTable+"'"));
				if(count<=0)				
					st+=" , CONSTRAINT PK_"+NewTable+" PRIMARY KEY ("+key+"))";
				else
					st+=" , CONSTRAINT PK1_"+NewTable+" PRIMARY KEY ("+key+"))";       
				
			}
			else
				st+=")";
			SQL_Execute(st,con);
		}


		public static string Get_TYP(object tag,string tb)
		{
			return Get_TYP(tag+"",tb);
		}
		public static string Get_TYP(string tag,string tb)
		{	
			string st="";			
			st=T_String.GetDataFromSQL("TYP_BT","SYS_MENU","ID="+tag);
			if(st+""=="True")
			{
				if(tb!="")
					st=	" ("+ tb+".TYP_ID in (Select TYP_ID  from SYS_SECURITY_TYP"+
						" where MNU_ID="+tag+" and ALL_BT=1 and USER_ID=N'"+PublicFunction.A_UserID+"'))";
				else
					st=	"( TYP_ID in (Select TYP_ID  from SYS_SECURITY_TYP"+
						" where MNU_ID="+tag+" and ALL_BT=1 and USER_ID=N'"+PublicFunction.A_UserID+"'))";
				return st;
			}
			return " 1=1 " ;
		}

		public static Boolean CheckFieldOfTable(SqlConnection con,string tb)
		{
			string sql;
			sql = "SELECT distinct c.id,c.colid FROM syscolumns c INNER JOIN systypes"+
				" ty ON c.xtype = ty.xtype INNER JOIN sysobjects s " +
				"ON c.id=s.id  WHERE (ty.name <> N'sysname') and " +
				"(s.name =N'" + tb + "')";
			Func.RecordSet ds=new Func.RecordSet(sql,con);
			if (ds.rows==0)  return false;			
			return true;
		}
	
	}
}
