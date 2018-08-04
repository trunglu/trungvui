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
				string strWhere = "",dTime = "";
				if(control1 != null)
				{
					strWhere = GP8000.Function.Common.Ints.BuildWhereQuery(control1);							
					strWhere = strWhere.IndexOf("WHERE") != -1 ? strWhere + " AND" : "WHERE" ;				
					dTime = string.Format("(chamcong.ATT_DT >= '{0}' AND chamcong.ATT_DT<='{1}') And ca.PC30Per = 1",Convert.ToDateTime(dt1.Value).ToString("yyyy-MM-dd"), Convert.ToDateTime(dt2.Value).ToString("yyyy-MM-dd"));				
				}
				else
				{
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
								
				ArrayList arrListEMP_ID = GetListValueByCol(rsData,"EMP_ID");
				ArrayList arrListATT_DT = GetListValueByCol(rsData,"ATT_DT");
				
				for(int x = 0; x < arrListEMP_ID.Count;x++)
				{
					string empID = arrListEMP_ID[x].ToString();
					for(int y = 0; y < arrListATT_DT.Count; y++)
					{						
						string att = arrListATT_DT[y].ToString();
						
						string sqlData = string.Format("select * from FILC06A chamcong "+
							"join FILC02B ca on chamcong.SHI_ID = ca.SHI_ID "+
							"where EMP_ID = N'{0}' "+
							"and ATT_DT = '{1}'  and ca.PC30Per=1 "+
							"order by SEQ_NO asc", empID, att);

						Func.RecordSet data=new Func.RecordSet(sqlData,con);												
						double on_1 = Convert.ToDouble(data.record(0,"ONN_01"));
						double on_2 = Convert.ToDouble(data.record(0,"ONN_02"));
						double on_3 = Convert.ToDouble(data.record(0,"ONN_03"));
						double on_4 = Convert.ToDouble(data.record(0,"ONN_04"));
						double on_5 = Convert.ToDouble(data.record(0,"ONN_05"));
						double off_1 = Convert.ToDouble(data.record(0,"OFF_01"));
						double off_2 = Convert.ToDouble(data.record(0,"OFF_02"));
						double off_3 = Convert.ToDouble(data.record(0,"OFF_03"));
						double off_4 = Convert.ToDouble(data.record(0,"OFF_04"));
						double off_5 = Convert.ToDouble(data.record(0,"OFF_05"));
						
						ArrayList arrListCa = new ArrayList();
						for(int z = 0; z < data.rows;z++)						
							arrListCa.Add(data.record(z,"ONN_TM")+ "|" + data.record(z,"OFF_TM"));							
						
						//arrListCa.Reverse();
						double totalTM = 0;
						for(int a= 0; a < arrListCa.Count;a++)						
							totalTM += Tru2Gio(Convert.ToDouble(arrListCa[a].ToString().Split('|')[1]), Convert.ToDouble(arrListCa[a].ToString().Split('|')[0]));													
						
						for(int a= 0; a < arrListCa.Count;a++)
						{
							double onTM = Convert.ToDouble(arrListCa[a].ToString().Split('|')[0]);
							double offTM = Convert.ToDouble(arrListCa[a].ToString().Split('|')[1]);
							if(on_2 >0)
							{
								//								if(Convert.ToDouble(arrListCa[a].ToString().Split('|')[0]) <= (off_1.ToString().Length > 2 ? off_1 : 9000 + off_1) && 
								//									Convert.ToDouble(arrListCa[a].ToString().Split('|')[1]) >= (on_2.ToString().Length > 2 ? on_2 : 9000 + on_2))
								if(ConvertGioNhoHon(onTM,off_1) <= ConvertGioLonHon(onTM, off_1) && ConvertGioNhoHon(offTM,on_2) >= ConvertGioLonHon(offTM, on_2))
								{
									totalTM = totalTM-(on_2 - off_1);
								}
							}
							
							if(off_2 >0 && on_3 >0)
							{
								if(ConvertGioNhoHon(onTM,off_2) <= ConvertGioLonHon(onTM, off_2) && ConvertGioNhoHon(offTM,on_3) >= ConvertGioLonHon(offTM, on_3))
								{
									totalTM = totalTM-(on_2 - off_1);
								}
							}

							if(off_3 >0 && on_4 >0)
							{
								if(ConvertGioNhoHon(onTM,off_3) <= ConvertGioLonHon(onTM, off_3) && ConvertGioNhoHon(offTM,on_4) >= ConvertGioLonHon(offTM, on_4))
								{
									totalTM = totalTM-(on_2 - off_1);
								}
							}

							if(off_4 >0 && on_5 >0)
							{
								if(ConvertGioNhoHon(onTM,off_4) <= ConvertGioLonHon(onTM, off_4) && ConvertGioNhoHon(offTM,on_5) >= ConvertGioLonHon(offTM, on_5))
								{
									totalTM = totalTM-(on_2 - off_1);
								}
							}
						}
						
						if(totalTM < 0 || 
							(on_1 == 0 && off_1 ==0) &&
							(on_2 == 0 && off_2 ==0) 
							)
							totalTM = 0;
						string updatePhuCap = string.Format("update FILC06A set PhuCap30Per = {2} "+
							"where ATT_DT = '{1}' and EMP_ID = N'{0}'",empID, att,totalTM);
						PublicFunction.SQL_Execute(updatePhuCap,con,true);																												
					}
				}
						

				//PublicFunction.SQL_Execute(sql,con,true);
			}	
			catch(Exception ex)
			{
				MessageBox.Show("CalPhuCap30");
			}
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

		public ArrayList GetListTime(DateTime d1, DateTime d2)
		{
			ArrayList arrList = new ArrayList();
			for(DateTime x = d1; x <= d2; x= x.AddMinutes(1))
			{
				arrList.Add(x.ToString("HH:mm"));				
			}
			return arrList;
		}

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
	}
}
