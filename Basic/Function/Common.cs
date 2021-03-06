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

namespace GP8000.Function
{
	/// <summary>
	/// Summary description for Common.
	/// </summary>
	public class Common
	{
		static Common ints = null;			
		public static Common Ints
		{
			get
			{
				if (ints == null)
					ints = new Common();
				return ints;
			}
		}

		public string tbChamCong="";
		public string tbTongKet="";	
		public string tbLuongTD="";		
		public void BuildTableGP_GPS()
		{
			if(PublicFunction.GPS)
			{
				tbChamCong = "GPS_ChamCong";
				tbTongKet = "GPS_TongKet";
				tbLuongTD = "GPS_LuongTD";
			}
			else
			{
				tbChamCong = "FILC06A";
				tbTongKet = "FILC06AA";	
				tbLuongTD = "FILD02A";
			}
		}

		public string BuildWhereQuery(GP8000.UserControl.CrtTaCondition1 control1 )
		{
			bool isAll = control1.R_ALL.Checked == true ? true: false;			
			
			string result="";
			if(!isAll)
			{				
				string strField = control1.ck.Checked == false ? "EMP_ID":"EMP_I1";
				if(control1.R_DEP.Checked)	//bo phan								
					result = string.Format("WHERE bophan.DEP_NM = N'{0}'", control1.CB_DEP.Text.ToString());				
				else if(control1.R_WID.Checked)	// ma
				{
					string from = control1.txt_fr.Text;
					string to= control1.txt_to.Text;										
					result = string.Format("WHERE nhanvien.{0} Between N'{1}' and N'{2}'",strField, from,to);
				}
				else if(control1.R_NON.Checked)	// khong lien tuc
				{
					string arrayList="";
					for (int i=0;i<control1.list.Count;i++)
					{
						if(arrayList!="")
							arrayList+=",";
						arrayList+="N'"+control1.list[i]+"'";
					}										
					result = string.Format("WHERE nhanvien.{0} in ({1})",strField, arrayList);
				}
			}
			else	
				result = "";
			return result;
		}


		#region phu cap 30%	
		/// <summary>
		/// Phu cap 30 %
		/// </summary>
		public void CalPhuCap30(SqlConnection con, GP8000.UserControl.CrtTaCondition1 control1,C1.Win.C1Input.C1DateEdit dt1, C1.Win.C1Input.C1DateEdit dt2, string eID, string attDT)
		{
			try
			{			
				bool isMessage = false;
				if(PublicFunction.GPS)
				{				
					string sql = string.Format("update FILC06A set PhuCap30Per = 0, PRO_HR = 0 where SHI_ID = '00'");
					Func.RecordSet rsPC00=new Func.RecordSet(sql,con);	
					isMessage = true;
				}
				else	
				{
					
					//Get where
					string strWhere = "",dTime = "";
					if(control1 != null)
					{
						isMessage = true;
						strWhere = GP8000.Function.Common.Ints.BuildWhereQuery(control1);							
						strWhere = strWhere.IndexOf("WHERE") != -1 ? strWhere + " AND" : "WHERE" ;				
						dTime = string.Format("(chamcong.ATT_DT >= '{0}' AND chamcong.ATT_DT<='{1}') And ca.PC30Per = 1",Convert.ToDateTime(dt1.Value).ToString("yyyy-MM-dd"), Convert.ToDateTime(dt2.Value).ToString("yyyy-MM-dd"));				
					}
					else
					{
						isMessage = false;
						strWhere = string.Format("WHERE nhanvien.EMP_ID = N'{0}'",eID);
						dTime = string.Format(" AND chamcong.ATT_DT = '{0}'",attDT);
					}
					string sql=string.Format("select chamcong.EMP_ID, chamcong.ONN_01, chamcong.OFF_01, chamcong.ONN_02, chamcong.OFF_02, chamcong.ONN_03, chamcong.OFF_03, chamcong.ONN_04, chamcong.OFF_04, chamcong.ONN_05, chamcong.OFF_05, ca.ONN_TM, ca.OFF_TM, chamcong.ATT_DT " +
						"from FILB01A nhanvien " +
						"join FILA02A bophan on nhanvien.DEP_ID = bophan.DEP_ID " +
						"join FILA07A chucvu on nhanvien.POS_ID = chucvu.POS_ID " +
						"left join FILB01AC nghiviec on nghiviec.EMP_ID = nhanvien.EMP_ID " +
						"join FILC06A chamcong on nhanvien.EMP_ID = chamcong.EMP_ID " +
						"join FILC02B ca on chamcong.SHI_ID = ca.SHI_ID " +
						"{0} {1} ", strWhere, dTime);										
				
					Func.RecordSet rsData=new Func.RecordSet(sql,con);
				
					//Get list empID & list attDT
					ArrayList arrListEMP_ID = GetListValueByCol(rsData,"EMP_ID");				
					ArrayList arrListATT_DT = GetListValueByCol(rsData,"ATT_DT");
				
					for(int x = 0; x < arrListEMP_ID.Count;x++) 
					{
						string empID = arrListEMP_ID[x].ToString(); //Get a empID
						for(int y = 0; y < arrListATT_DT.Count; y++) 
						{						
							string att = Convert.ToDateTime(arrListATT_DT[y]).ToString("yyyy-MM-dd"); //Get a attDT
						
							string sqlData = string.Format("select * from FILC06A chamcong "+
								"join FILC02B ca on chamcong.SHI_ID = ca.SHI_ID "+
								"where EMP_ID = N'{0}' "+
								"and ATT_DT = '{1}'  and ca.PC30Per=1 "+
								"order by SEQ_NO asc", empID, att);

							Func.RecordSet data=new Func.RecordSet(sqlData,con);												
												
							ArrayList arrListGioTM = new ArrayList();
							ArrayList arrListGio = new ArrayList();

							//Get all minute TM
							for(int z = 0; z < data.rows;z++)
								arrListGioTM.AddRange(GetListTime(data.record(z,"ONN_TM"),data.record(z,"OFF_TM")));
						
							//Get all minute employ
							arrListGio.AddRange(GetListTime(data.record(0,"ONN_01"),data.record(0,"OFF_01")));
							arrListGio.AddRange(GetListTime(data.record(0,"ONN_02"),data.record(0,"OFF_02")));
							arrListGio.AddRange(GetListTime(data.record(0,"ONN_03"),data.record(0,"OFF_03")));
							arrListGio.AddRange(GetListTime(data.record(0,"ONN_04"),data.record(0,"OFF_04")));
							arrListGio.AddRange(GetListTime(data.record(0,"ONN_05"),data.record(0,"OFF_05")));											
						
							//Get all minute work
							ArrayList arrListResult = new ArrayList();
							arrListResult.AddRange(GetDulicateItem(arrListGioTM,arrListGio));
						
							//Get hour work
							double strResult = (Convert.ToDouble(arrListResult.Count) / 60);
							strResult = ConvertHour(arrListResult.Count,strResult);
						

							string updatePhuCap = string.Format("update FILC06A set PhuCap30Per = {2} "+
								"where ATT_DT = '{1}' and EMP_ID = N'{0}'",empID, att, strResult);
							PublicFunction.SQL_Execute(updatePhuCap,con,true);													
						}
					}			
				}
				if(isMessage)
					MessageBox.Show("Tính phụ cấp thành công!!!");

			}	
			catch(Exception ex)
			{
				//MessageBox.Show("CalPhuCap30");
			}
		}
		
		private double ConvertHour(int v1, double v2)
		{
			int a = v1 / 60;
			double le = v2 - a;
			double b =0;
			if (le*60 >= 25 && le*60 <= 54)
				b = Convert.ToDouble(a) + 0.5;
			else if(le*60 >= 55)
				b= Convert.ToDouble(a) + 1;
			else
				b= Convert.ToDouble(a);
			return b;
		}

		public ArrayList GetListTime(string strOn, string strOff)
		{
			if(strOn != null)
			{
				//Get full hour 4 so
				strOn = ConvertNumberHourFull(strOn);
				strOff = ConvertNumberHourFull(strOff);
			
				//Get 2 character left or right
				int intOnL = Convert.ToInt32(strOn.Substring(0,2));
				int intOnR = Convert.ToInt32(strOn.Substring(2,2));			
				int intOffL = Convert.ToInt32(strOff.Substring(0,2));
				int intOffR = Convert.ToInt32(strOff.Substring(2,2));
				int intOffDay = 1;
			
				//if on == 24 then -1'
				if(intOnL == 24)
				{
					intOnL = 23;
					intOnR = 59;
				}

				if(intOffL == 24)
				{
					intOffL = 23;
					intOffR = 59;
				}
			
				//if off < on then day++
				if(intOffL < intOnL)
					intOffDay++;

				DateTime d1 = new DateTime(2015,5,1,intOnL, intOnR,0);
				DateTime d2 = new DateTime(2015,5,intOffDay,intOffL, intOffR,0);
			
				//get all hour minute 
				ArrayList arrList = new ArrayList();
				for(DateTime x = d1; x <= d2; x= x.AddMinutes(1))			
					arrList.Add(x.ToString("HH:mm"));				
			
				return arrList;
			}
			return new ArrayList();
		}

		private string ConvertNumberHourFull(string v)
		{
			if(v.ToString().Length ==1)
				return "000" + v.ToString();
			else if(v.ToString().Length ==2)
				return "00" + v.ToString();	
			else if(v.ToString().Length ==3)
				return "0" + v.ToString();	
			else 
				return v.ToString();	
		}

		private string ConvertHourFullNumber(int v1,double v2)
		{
			int a = v1 / 60;
			double le = v2 - a;
			string result = "";
			if(a.ToString().Length ==1)
				result = a.ToString() + "00";
			else if(a.ToString().Length ==2)
				result = a.ToString() + "00";	
			else if(a.ToString().Length ==3)
				result = a.ToString() + "0";	
			else 
				result = a.ToString();	

			double temp  = Convert.ToDouble(result) + (le * 60);
			result = temp.ToString();
			return result;
		}
		
		private double ConvertGioLonHon(double v1, double v2)
		{			
			if((v1 > 1000) && (v2.ToString().Length == 2 || v2.ToString().Length == 3))				
				return v2 + 3000;
			else
				return v2;
		}


		private double ConvertGioNhoHon(double v1, double v2)
		{						
			if((v2 > 1000) && (v1.ToString().Length == 2 || v1.ToString().Length == 3))	
				return v1 + 3000;
			else 
				return v1;
		}

		private double GetTimePC(double on, double off, double onTM, double offTM)
		{
			try
			{
				double outPC = off >= offTM ? offTM : off;
				double qdTime = Tru2Gio(Convert.ToDouble(offTM), Convert.ToDouble(onTM));
				double result = Tru2Gio(outPC,on);
				result = Convert.ToInt32(result >= qdTime ? qdTime : result);
				return result;
			}
			catch(Exception ex)
			{
				MessageBox.Show("GetTimePC");
			}
			return 0;
		}

		private double Tru2Gio(double h1, double h2)
		{
			try
			{						
				//h1 = h1 /100;
				//h2 = h2 /100;
				//double result = (Convert.ToDouble(h1.ToString().Substring(0,1)) - Convert.ToDouble(h2.ToString().Substring(0,1))) + (Convert.ToDouble(h1.ToString().Substring(1,2)) - Convert.ToDouble(h2.ToString().Substring(1,2))/60);

				string strH1 = h1.ToString();
				string strH2 = h2.ToString();
				string strH1_ = strH1.Substring(0,1);
				string strH1__ = strH1.Substring(1,2);
				string strH2_ = strH2.Substring(0,2);
				string strH2__ = strH2.Substring(1,2);
				
				double res = 0;
				if(h1.ToString().Length == 3)
					res = (Convert.ToDouble(h1.ToString().Substring(0,1)) - Convert.ToDouble(h2.ToString().Substring(0,1))) + (Convert.ToDouble(h1.ToString().Substring(1,2)) - Convert.ToDouble(h2.ToString().Substring(1,2))/60);				
				else if(h1.ToString().Length == 4)
					res = (Convert.ToDouble(h1.ToString().Substring(0,2)) - Convert.ToDouble(h2.ToString().Substring(0,2))) + (Convert.ToDouble(h1.ToString().Substring(2,2)) - Convert.ToDouble(h2.ToString().Substring(2,2))/60);				
				return res;
			}
			catch(Exception ex)
			{
				MessageBox.Show("Tru2Gio");
			}
			return 0;
		}

		//Get list value by column
		private ArrayList GetListValueByCol(Func.RecordSet source, string column)
		{
			ArrayList arrList = new ArrayList();
			try
			{				
				for(int x = 0; x < source.rows; x++)
				{
					object v = source.record(x,column);
					if(arrList.IndexOf(v) == -1) //if arrList is not contain v then add(not duplicate)
						arrList.Add(v);
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show("GetListValueByCol");
			}
			return arrList;
		}

		#endregion



		public ArrayList GetDulicateItem(ArrayList arr1, ArrayList arr2)
		{			
			ArrayList newList = new ArrayList();

			for(int x = 0 ; x <arr1.Count;x++)
			{
				if(arr2.Contains(arr1[x]))
				{
					newList.Add(arr1[x]);
				}
			}
			return newList;
		}

		/// <summary>
		/// CalCaNgayNghi
		/// </summary>
		public void CalCaNgayNghi(SqlConnection con, GP8000.UserControl.CrtTaCondition1 control1,C1.Win.C1Input.C1DateEdit dt1, C1.Win.C1Input.C1DateEdit dt2, string eID, string attDT)
		{
			try
			{			
				bool isMessage = false;
				//Get where
				string strWhere = "",dTime = "";
				//				if(control1 != null)
				//				{
				//					isMessage = true;
				//					strWhere = GP8000.Function.Common.Ints.BuildWhereQuery(control1);							
				//					strWhere = strWhere.IndexOf("WHERE") != -1 ? strWhere + " AND" : "WHERE" ;				
				//					dTime = string.Format("(chamcong.ATT_DT >= '{0}' AND chamcong.ATT_DT<='{1}') And ca.PC30Per = 1",Convert.ToDateTime(dt1.Value).ToString("yyyy-MM-dd"), Convert.ToDateTime(dt2.Value).ToString("yyyy-MM-dd"));				
				//				}
				//				else
				//				{
				isMessage = false;
				strWhere = string.Format("WHERE nhanvien.EMP_ID = N'{0}'",eID);
				dTime = string.Format(" AND chamcong.ATT_DT = '{0}'",attDT);
				//}
				string sql=string.Format("select chamcong.EMP_ID, chamcong.ONN_01, chamcong.OFF_01, chamcong.ONN_02, chamcong.OFF_02, chamcong.ONN_03, chamcong.OFF_03, chamcong.ONN_04, chamcong.OFF_04, chamcong.ONN_05, chamcong.OFF_05, ca.ONN_TM, ca.OFF_TM, chamcong.ATT_DT " +
					"from FILB01A nhanvien " +
					"join FILA02A bophan on nhanvien.DEP_ID = bophan.DEP_ID " +
					"join FILA07A chucvu on nhanvien.POS_ID = chucvu.POS_ID " +
					"left join FILB01AC nghiviec on nghiviec.EMP_ID = nhanvien.EMP_ID " +
					"join FILC06A chamcong on nhanvien.EMP_ID = chamcong.EMP_ID " +
					"join FILC02B ca on chamcong.SHI_ID = ca.SHI_ID " +
					"{0} {1} ", strWhere, dTime);										
				
				Func.RecordSet rsData=new Func.RecordSet(sql,con);
				
				//Get list empID & list attDT
				ArrayList arrListEMP_ID = GetListValueByCol(rsData,"EMP_ID");				
				ArrayList arrListATT_DT = GetListValueByCol(rsData,"ATT_DT");
				
				for(int x = 0; x < arrListEMP_ID.Count;x++) 
				{
					string empID = arrListEMP_ID[x].ToString(); //Get a empID
					for(int y = 0; y < arrListATT_DT.Count; y++) 
					{						
						string att = Convert.ToDateTime(arrListATT_DT[y]).ToString("yyyy-MM-dd"); //Get a attDT
						
						string sqlData = string.Format("select * from FILC06A chamcong "+
							"join FILC02B ca on chamcong.SHI_ID = ca.SHI_ID "+
							"where EMP_ID = N'{0}' "+
							"and ATT_DT = '{1}'  and ca.TYP_ID= 'DOF_HR' "+
							"order by SEQ_NO asc", empID, att);

						Func.RecordSet data=new Func.RecordSet(sqlData,con);												
												
						ArrayList arrListGioTM = new ArrayList();
						ArrayList arrListGio = new ArrayList();

						//Get all minute TM
						for(int z = 0; z < data.rows;z++)
							arrListGioTM.AddRange(GetListTime(data.record(z,"ONN_TM"),data.record(z,"OFF_TM")));
						
						//Get all minute employ
						arrListGio.AddRange(GetListTime(data.record(0,"ONN_01"),data.record(0,"OFF_01")));
						arrListGio.AddRange(GetListTime(data.record(0,"ONN_02"),data.record(0,"OFF_02")));
						arrListGio.AddRange(GetListTime(data.record(0,"ONN_03"),data.record(0,"OFF_03")));
						arrListGio.AddRange(GetListTime(data.record(0,"ONN_04"),data.record(0,"OFF_04")));
						arrListGio.AddRange(GetListTime(data.record(0,"ONN_05"),data.record(0,"OFF_05")));											
						
						//Get all minute work
						ArrayList arrListResult = new ArrayList();
						arrListResult.AddRange(GetDulicateItem(arrListGioTM,arrListGio));
						
						//Get hour work
						double strResult = (Convert.ToDouble(arrListResult.Count) / 60);
						strResult = ConvertHour(arrListResult.Count,strResult);
						
						string r = ConvertHourFullNumber(arrListResult.Count,strResult);
//						string updatePhuCap = string.Format("update FILC06A set DOF_HR = {2} "+
//							"where ATT_DT = '{1}' and EMP_ID = N'{0}'",empID, att, r);
//						PublicFunction.SQL_Execute(updatePhuCap,con,true);	
						//// luc truoc co doan nay de cong 30 phut vao ca ngay nghi nay khoa  lai (22-01-2016)						
					}
				}			
			
				if(isMessage)
					MessageBox.Show("Tính phụ cấp thành công!!!");
			}	
			catch(Exception ex)
			{
				MessageBox.Show("CalPhuCap30");
			}
		}

//		public void LockKey(string key)
//		{
//			//tao khoa nhap phep bao loi                   
//			string keyD = "";
//			string ktype = "";
//			int iphut = 0;
//			SqlConnection SqlCon1 = new SqlConnection(PublicFunction.C_con.ConnectionString);
//			SqlCon1.Open();
//			Func.RecordSet rsK = new Func.RecordSet("Select * from GP_KEY", SqlCon1);
//			if (rsK.rows > 0)
//			{
//				ktype = rsK.record(0, "TYP_MN");
//				keyD = PublicFunction.encode(rsK.record(0, "COL_DT"), "");
//				iphut = T_String.IsNullTo0(rsK.record(0, "COL_MN"));
//			}
//			if (DateTime.Now >= DateTime.Parse(keyD) && ktype.ToUpper()=="LT")
//			{
//				Thread.Sleep(2000*10);
//				MessageBox.Show("There are some errors occurred. Can not execute Sqlcommand");
//				return;
//			}
//			// end 
//		}
		
		public void CheckColAndSyn()
		{
			ArrayList arrListColSql1 = Function.Common.Ints.GetColumnsNameSQL("FILD02A");
			ArrayList arrListColSql2 = Function.Common.Ints.GetColumnsNameSQL("GPS_LuongTD");
			ArrayList arrListItem = Function.Common.Ints.GetNotDulicateItem(arrListColSql1,arrListColSql2);
			for(int x =0 ;x < arrListItem.Count;x++)
			{
				string colSYN = arrListItem[x].ToString();				
				Function.Common.Ints.InsertNewColSQL(colSYN);				
			}
		}

		public void InsertNewColSQL(string colName)
		{
			SqlConnection con=new SqlConnection(PublicFunction.C_con.ConnectionString);
			con.Open();		
			SqlTransaction tran=con.BeginTransaction();
			try
			{		
				string sql="";
				sql=string.Format("Alter table GPS_LuongTD Add [{0}] float default(0)",colName);
				SqlCommand cmd=new SqlCommand(sql,con,tran);
				cmd.ExecuteNonQuery();
				
				tran.Commit();
			}
			catch(SqlException ex)
			{
				tran.Rollback();
				MessageBox.Show(ex.Message);	
				return;
			}
			con.Close();
		}
		public ArrayList GetNotDulicateItem(ArrayList arr1, ArrayList arr2)
		{			
			ArrayList newList = new ArrayList();

			for(int x = 0 ; x <arr1.Count;x++)
			{
				if(!arr2.Contains(arr1[x]))
				{
					newList.Add(arr1[x]);
				}
			}
			return newList;
		}

		public ArrayList GetColumnsNameSQL(string tableName)
		{
			ArrayList arrList = new ArrayList();						
			using (SqlConnection connection = new SqlConnection(PublicFunction.C_con.ConnectionString))

			using (SqlCommand command = connection.CreateCommand())
			{
				command.CommandText = string.Format("select c.name from sys.columns c inner join sys.tables t on t.object_id = c.object_id and t.name = '{0}' and t.type = 'U'",tableName);
				connection.Open();
				using (SqlDataReader reader = command.ExecuteReader())
				{
					while (reader.Read())
					{
						arrList.Add(reader.GetString(0));
					}
				}
			}			
			return arrList;
		}
		
	}
}
