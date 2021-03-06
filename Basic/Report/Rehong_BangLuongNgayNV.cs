using System;
using Excel = Microsoft.Office.Interop.Excel;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Reflection;
using System.Data;
using System.Data.SqlClient;
using Basic;
using Basic.Function;
using System.Collections;
namespace GP8000.Report
{
	/// <summary>
	/// Summary description for JeaMust_BangLuong
	/// </summary>
	public class Rehong_BangLuongNgayNV
	{
		Excel.Application oExcel;
		Excel.Worksheet oSheet, oTemplate;
		
		string strDateChoose ="", strWhere ="",strStatus="";
		string strThangChon="",ngayChon="",ngayDauThangSauChon="",ngayCuoiThangChon="";
		public Rehong_BangLuongNgayNV(Excel.Application oExcel, NativeWindow xlMain, Hashtable hs)
		{
			try	
			{
				this.oExcel = oExcel;
				oSheet = (Excel.Worksheet)oExcel.Worksheets[1];
				oSheet.Activate();
				this.oTemplate = oExcel.Sheets["Template"] as Excel.Worksheet;								

				//param
				strDateChoose = hs["strDateChoose"].ToString();				
				strWhere = hs["strWhere"].ToString();			
				//strStatus = hs["strStatus"].ToString();

				strThangChon = Convert.ToDateTime(strDateChoose).ToString("yyyyMMdd");
				string dateTemp = Convert.ToDateTime(strDateChoose).ToString("MM/yyyy");;
				ngayChon = Convert.ToDateTime(dateTemp).ToString("yyyy-MM-dd");
				ngayDauThangSauChon= Convert.ToDateTime(dateTemp).AddMonths(1).ToString("yyyy-MM-dd");
				ngayCuoiThangChon = Convert.ToDateTime(dateTemp).AddMonths(1).AddDays(-1).ToString("yyyy-MM-dd");
				BuildExcel();
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}
		
		/// <summary>
		/// Build excel and export
		/// </summary>
		private void BuildExcel()
		{			
			
			strWhere = strWhere.IndexOf("WHERE") != -1 ? strWhere + " AND" : "WHERE" ;
			string sql = "";
			//if(strStatus=="CL")
			//{
				
//				sql=string.Format("select nhanvien.INH_DT, nhanvien.EMP_NM, nhanvien.EMP_N1, chucvu.POS_NM, " +
//					"nhanvien.EMP_ID, bophan.DEP_NM, l.muc_luongcoban, giocong, luongcoban, giohuongluong50, " +
//					"tienhuongluong50, choviec, tienchoviec, tonggiocong, trachnhiem, kynang, nhatro, dochai, " +
//					"tongphucap, gio15, tien15, TangCaNgayThuong, ThanhTienCa, gio195, tien195, gio2, tien2, " +
//					"TangCaQuaDemCN, ThanhTienCaQuaDemCN, GioTangCaNgayLe3, TienTangCaNgayLe3, tongtienTC, thucnhan " +
//					"from FILB01A nhanvien " +
//					"join FILA02A bophan on nhanvien.DEP_ID = bophan.DEP_ID " +
//					"join FILA07A chucvu on nhanvien.POS_ID = chucvu.POS_ID " +
//					"left join FILB01AC nghiviec on nghiviec.EMP_ID = nhanvien.EMP_ID " +
//					"left join FILD02A l on nhanvien.EMP_ID = l.EMP_ID " +
//					"{0} (nghiviec.VAC_DT is null or nghiviec.VAC_DT > '{1}') and l.YYY_MM = '{2}' " +
//					"order by bophan.DEP_NM, nhanvien.EMP_ID asc", strWhere,ngayCuoiThangChon,strThangChon);
			//}
			//else if(strStatus=="NV")
			//{
				
			sql=string.Format("select nhanvien.INH_DT, nhanvien.EMP_NM, nhanvien.EMP_N1, chucvu.POS_NM, " +
					"nhanvien.EMP_ID, bophan.DEP_NM, l.muc_luongcoban, giocong, luongcoban, giohuongluong50, " +
					"tienhuongluong50, choviec, tienchoviec, tonggiocong, trachnhiem, kynang, nhatro, dochai, " +
					"tongphucap, gio15, tien15, TangCaNgayThuong, ThanhTienCa, gio195, tien195, gio2, tien2, " +
					"TangCaQuaDemCN, ThanhTienCaQuaDemCN, GioTangCaNgayLe3, TienTangCaNgayLe3, tongtienTC, thucnhan " +
					"from FILB01A nhanvien " +
					"join FILA02A bophan on nhanvien.DEP_ID = bophan.DEP_ID " +
					"join FILA07A chucvu on nhanvien.POS_ID = chucvu.POS_ID " +
					"left join FILB01AC nghiviec on nghiviec.EMP_ID = nhanvien.EMP_ID " +
					string.Format("left join {0} l on nhanvien.EMP_ID = l.EMP_ID ",Function.Common.Ints.tbLuongTD) +
					"{0} (nhanvien.VAC_BT = 1 and nghiviec.VAC_DT > '{1}' and nghiviec.VAC_DT < '{2}') and l.YYY_MM = '{3}' " +
					"order by bophan.DEP_NM, nhanvien.EMP_ID asc", strWhere,ngayChon,ngayDauThangSauChon,strThangChon);
					
			//}		
			//sql=sql.Replace("FILD02A",Function.Common.Ints.tbLuongTD);
			Func.RecordSet rsData = new Func.RecordSet(sql,PublicFunction.C_con);
			
			//Build excel title			
			BuildTitle("A","A",3,"[DD]", Convert.ToDateTime(strDateChoose).ToString("dd"));
			BuildTitle("A","A",3,"[MM]", Convert.ToDateTime(strDateChoose).ToString("MM"));
			BuildTitle("A","A",3,"[YYYY]", Convert.ToDateTime(strDateChoose).ToString("yyyy"));
				

			if(rsData != null && rsData.rows>0)
			{
				//Build excel row
				int iRow = BuildExcelRow(rsData,true,"A","AI",7);
				
				//Format cells date
				Excel.Range rgDate = oSheet.get_Range(oSheet.Cells[8,2],oSheet.Cells[iRow-1,2]);		
				rgDate.NumberFormat = "dd/MM/yyyy";				
				
				//Format cells currency
//				Excel.Range rgCurrency = oSheet.get_Range(oSheet.Cells[7,7],oSheet.Cells[iRow-1,20]);		
//				rgCurrency.NumberFormat = "#,##0";				
				
				//Format total:
//				Excel.Range rgTotal = oSheet.get_Range(oSheet.Cells[iRow,1],oSheet.Cells[iRow,6]);
//				rgTotal.HorizontalAlignment = HorizontalAlignment.Right;
//				rgTotal.VerticalAlignment = HorizontalAlignment.Right;

				//Draw border
				ReportExcel2.DrawBorders(oSheet, 7, 1, iRow, 35);

				//Build footer
				BuildFooter(iRow,1,3,"合計 TỔNG CỘNG");						
				BuildTotalSum(iRow);

				iRow++;
				iRow++;
				//Build Chu ky
				BuildFooter(iRow,3,3,"總  經  理");
				BuildFooter(iRow,13,14,"副總");
				BuildFooter(iRow,20,20,"会计");
				BuildFooter(iRow,32,32,"人事");

				iRow++;
				BuildFooter(iRow,3,3,"Tổng Giám Đốc");
				BuildFooter(iRow,13,14,"Phó Giám Đốc");
				BuildFooter(iRow,20,20,"Kế Toán");
				BuildFooter(iRow,32,32,"Nhân Sự");
//				iRow= iRow + 7;
//				BuildFooter(iRow,5,6,"Yang Cheng Lung");
//				BuildFooter(iRow,47,53,"Huỳnh Bửu Dinh");
//				BuildFooter(iRow,71,73,"Trương Thị Kim Thoa");

			}
		}
		ArrayList arrListSum = new ArrayList();


		private void BuildTotalSum(int idx)
		{
			//string strE = "",strF="", strAM="",strAN="",strAO="",strAP="",strAQ="",strAR="",strAS="",strAT="",strAU="",strAV="";
			//string strVal="";
			
			for(int x = 8; x <= 34; x++)
			{
				string strVal="";
				string strCol = ConvertCol_IntToString(x);
				for(int y = 0; y < arrListSum.Count; y++)
				{
					string iSTART = arrListSum[y].ToString().Split('|')[0];
					string iEND = arrListSum[y].ToString().Split('|')[1];

						
					strVal = BuildSumTotalSumItem(strCol,iSTART,iEND,strVal);
				}
				BuildFooter(idx,x,x,strVal);				
			}		

//			for(int x = 0; x < arrListSum.Count; x++)
//			{
//				string iSTART = arrListSum[x].ToString().Split('|')[0];
//				string iEND = arrListSum[x].ToString().Split('|')[1];
//				
//					
//
//				strE = BuildSumTotalSumItem("E",iSTART,iEND,strE);
//				strF = BuildSumTotalSumItem("F",iSTART,iEND,strF);
//				strAM = BuildSumTotalSumItem("AM",iSTART,iEND,strAM);
//				strAN = BuildSumTotalSumItem("AN",iSTART,iEND,strAN);
//				strAO = BuildSumTotalSumItem("AO",iSTART,iEND,strAO);
//				strAP = BuildSumTotalSumItem("AP",iSTART,iEND,strAP);
//				strAQ = BuildSumTotalSumItem("AQ",iSTART,iEND,strAQ);
//				strAR = BuildSumTotalSumItem("AR",iSTART,iEND,strAR);
//				strAS = BuildSumTotalSumItem("AS",iSTART,iEND,strAS);
//				strAT = BuildSumTotalSumItem("AT",iSTART,iEND,strAT);
//				strAU = BuildSumTotalSumItem("AU",iSTART,iEND,strAU);
//				strAV = BuildSumTotalSumItem("AV",iSTART,iEND,strAV);	
//			
//			}
//			BuildFooter(idx,5,5,strE);
//			BuildFooter(idx,6,6,strF);
//			BuildFooter(idx,39,39,strAM);
//			BuildFooter(idx,40,40,strAN);
//			BuildFooter(idx,41,41,strAO);
//			BuildFooter(idx,42,42,strAP);
//			BuildFooter(idx,43,43,strAQ);
//			BuildFooter(idx,44,44,strAR);
//			BuildFooter(idx,45,45,strAS);
//			BuildFooter(idx,46,46,strAT);
//			BuildFooter(idx,47,47,strAU);
//			BuildFooter(idx,48,48,strAV);					
		}

		private string BuildSumTotalSumItem(string character, string iStart,string iEnd,string strResult)
		{			
			if(strResult == "")
				strResult = string.Format("=sum({2}{0}:{2}{1}) ",iStart,iEnd,character);
			else	
				strResult += string.Format(" + sum({2}{0}:{2}{1})",iStart,iEnd,character);
			return strResult;
		}

		/// <summary>
		/// Build footer
		/// </summary>
		/// <param name="row">row index</param>
		/// <param name="colFrom"> column index from</param>
		/// <param name="colTo">column index to</param>
		/// <param name="footerValue">footer value</param>
		private void BuildFooter(int row, int colFrom, int colTo, string footerValue)
		{
			Excel.Range rg = oSheet.get_Range(oSheet.Cells[row,colFrom],oSheet.Cells[row,colTo]);
			rg.Merge(Type.Missing);
			rg.Value2 = footerValue;
			rg.Cells.Font.Bold = true;
		}

		/// <summary>
		/// Replace excel value
		/// </summary>
		/// <param name="from">from cell</param>
		/// <param name="to">to cell</param>
		/// <param name="rowValue">row value</param>
		/// <param name="oldValue">old value</param>
		/// <param name="newValue">new value</param>
		private void BuildTitle(string from, string to, int rowValue, string oldValue, string newValue)
		{
			//Get title
			object objTitle = oSheet.get_Range(string.Format("{1}{0}:{2}{0}", rowValue, from, to), Missing.Value).get_Value(Excel.XlRangeValueDataType.xlRangeValueDefault);

			//Replace value
			objTitle = objTitle.ToString().Replace(oldValue,newValue);			

			//Set title
			oSheet.get_Range(string.Format("{1}{0}:{2}{0}", rowValue, from, to), Missing.Value).set_Value(Excel.XlRangeValueDataType.xlRangeValueDefault,objTitle);
		}
		
		

		/// <summary>
		/// Build excel row
		/// </summary>
		/// <param name="rsData">source</param>
		/// <param name="isSTT">have STT</param>
		/// <param name="from">from cell</param>
		/// <param name="to">to cell</param>
		/// <param name="fromRow">row add value</param>
		/// <returns></returns>
		private int BuildExcelRow(Func.RecordSet rsData, bool isSTT, string from, string to, int fromRow)
		{				
			int iSTT = 1;				
			int stt = isSTT == true ? 1 : 0;
			string strBoPhanTitle = "";			
			int start = 0, end = 0;
			string oldEMP_ID = "";
			bool isMerge = false;
			ArrayList excludeTotalOnRow = new ArrayList();
			//Build excel row
			for(int x = 0; x < rsData.rows; x++)
			{								
				//Them group bo phan
				string bp = rsData.record(x,"DEP_NM");
				if(strBoPhanTitle != bp)
				{
					if(strBoPhanTitle != "")
					{						
						end = fromRow -1;
						//arrListSum.Add(string.Format("{0}|{1}",start,end));
						arrListSum.Add(string.Format("{0}|{1}",fromRow,fromRow));
						BuildFooter(fromRow,1,3,string.Format("Tổng cộng {0}:",strBoPhanTitle));
						//Build total
						for(int y = 8; y <= 34; y++)
						{
							string strCol = ConvertCol_IntToString(y);
							BuildFooter(fromRow,y,y,string.Format("=sum({2}{0}:{2}{1}) {3}",start,end,strCol,GetExcludeCol(excludeTotalOnRow,strCol)));
						}											
						fromRow++;
					}

					//instant new row
					object[,] data1 = new object[1, rsData.cols+50];
					strBoPhanTitle = bp;
					data1[0,1] = bp;
					
					oSheet.get_Range(string.Format("{1}{0}:{2}{0}", fromRow,from,to), Missing.Value)
						.set_Value(Excel.XlRangeValueDataType.xlRangeValueDefault, data1);
					
					oSheet.get_Range(string.Format("{1}{0}:{2}{0}", fromRow,from,to), Missing.Value).Cells.Font.Bold = true;
					oSheet.get_Range(string.Format("{1}{0}:{2}{0}", fromRow,from,to), Missing.Value).Cells.Font.Size = 12;
			
					fromRow++;
					start = fromRow;
					iSTT=1;	
					
				}
				
				//Dòng 1 của 1 nhân viên
				object[,] data = new object[1, rsData.cols+50];				
				//Dòng 2 của 1 nhân viên
				//object[,] data2 = new object[1, rsData.cols+50];
				
				string id = rsData.record(x,"EMP_ID");																

				//get a row
				for(int y = 0; y < rsData.cols + stt;y++)				
					data[0,y+1] = rsData.record(x,y);				
			
				//bind value STT
				if(isSTT)
					data[0,0] = iSTT;													
				
//				//bind value sex
//				if(rsData.record(x,4).Equals("False"))
//					data[0,4] = "X";
//				else
//					data[0,4] = "";


				//bind value
				oSheet.get_Range(string.Format("{1}{0}:{2}{0}", fromRow,from,to), Missing.Value)
					.set_Value(Excel.XlRangeValueDataType.xlRangeValueDefault, data);										
				
				
//				if(oldEMP_ID == id && isMerge == false )
//				{
//					//format in dam,to mau cho dong total nguoi 2 muc luong					
//					oSheet.get_Range(string.Format("{1}{0}:{2}{0}", fromRow+1,"A","AJ"), Missing.Value).Cells.Font.Bold = true;
//					oSheet.get_Range(string.Format("{1}{0}:{2}{0}", fromRow+1,"A","AJ"), Missing.Value).Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.FromArgb(255,255,200));	//196,215,155				
//					iSTT--;
//					
//					MergeCol2Luong(fromRow,1,iSTT.ToString());					
//					MergeCol2Luong(fromRow,2,id);
//					MergeCol2Luong(fromRow,3,rsData.record(x,2));
//					MergeCol2Luong(fromRow,4,"");
//					MergeCol2Luong(fromRow,5,data[0,4].ToString());
//					//MergeCol2Luong(fromRow,6,rsData.record(x,4));
//					//MergeCol2Luong(fromRow,13,rsData.record(x,12));					
//
//					isMerge = true;
//					excludeTotalOnRow.Add(fromRow -1);
//					excludeTotalOnRow.Add(fromRow);	
//				}
//				else if(oldEMP_ID == id && isMerge == true )
//				{
//					isMerge = false;
//					iSTT--;
//				}

				fromRow++;
				iSTT++;	
								
				

				//oldEMP_ID = id;


				if(x == rsData.rows-1)
				{
					end = fromRow -1;
					//arrListSum.Add(string.Format("{0}|{1}",start,end));
					arrListSum.Add(string.Format("{0}|{1}",fromRow,fromRow));
					BuildFooter(fromRow,1,3,string.Format("Tổng cộng {0}:",strBoPhanTitle));
					//Build total
					for(int y = 8; y <= 34; y++)
					{
						string strCol = ConvertCol_IntToString(y);
						BuildFooter(fromRow,y,y,string.Format("=sum({2}{0}:{2}{1}) {3}",start,end,strCol,GetExcludeCol(excludeTotalOnRow,strCol)));
					}
					fromRow++;
				}
			}
			return fromRow;
		}		

		private string GetExcludeCol(ArrayList arrListRowExclude, string col)
		{
			string strResult = "";
			if(arrListRowExclude.Count > 0)
			{
				for(int x =0; x < arrListRowExclude.Count; x++)									
					strResult += string.Format("-{0}{1}",col,arrListRowExclude[x]);				
			}
			return strResult;
		}

		/// <summary>
		/// mer doi voi nguoi 2 luong
		/// </summary>
		/// <param name="col"></param>
		/// <param name="val"></param>
		private void MergeCol2Luong(int idxRow,int col, string val)
		{
			oSheet.get_Range(oSheet.Cells[idxRow-1,col],oSheet.Cells[idxRow+1,col]).ClearContents();
			oSheet.get_Range(oSheet.Cells[idxRow-1,col],oSheet.Cells[idxRow+1,col]).Merge(Type.Missing);
			oSheet.get_Range(oSheet.Cells[idxRow-1,col],oSheet.Cells[idxRow+1,col]).set_Value(Excel.XlRangeValueDataType.xlRangeValueDefault, val);
		}

		private string CalPhuCapChuyenCan(string chuyenCan)
		{
			if(chuyenCan == "A")
				return "300000";
			else if(chuyenCan == "A")
				return "150000";
			else
				return "0";
		}
	
//		private object[,] BindPhepIntoChiTiet(string id,object[,] source, int idxRow)
//		{
//			string sqlPhepNam=string.Format("select SHR_NM, CONVERT(varchar(10), Cast( hou_dy as decimal(10, 0))),STR_DT , END_DT from filc04a phep " +
//										"join FILA15A loai on phep.lea_id = loai.lea_id " +
//										"where EMP_ID = '{0}' and (STR_DT >= '{1}' and END_DT <= '{2}')", id, Convert.ToDateTime(ngayDauThangSauChon).AddMonths(-1).ToString("yyyy-MM-dd"),ngayCuoiThangChon);	
//			Func.RecordSet rsPhepNam = new Func.RecordSet(sqlPhepNam, PublicFunction.C_con);
//			for(int x = 0; x < rsPhepNam.rows;x++)
//			{
//				string strTenPhep = rsPhepNam.record(x,0);
//				string strGioPhep = rsPhepNam.record(x,1);
//				DateTime strStartDate = DateTime.Parse(rsPhepNam.record(x,2));
//				DateTime strEndDate = DateTime.Parse(rsPhepNam.record(x,3));
//
//				ArrayList arrListDay = new ArrayList();
//				for(DateTime y = strStartDate; y <= strEndDate; y= y.AddDays(1))	
//				{
//					//arrListDay.Add(y.Day);				
//					int idxCol = GetColumnExcelByDay(y.Day.ToString());
//
//					if(Convert.ToInt16(strGioPhep) == 8)
//						source[0,idxCol-1] = strTenPhep;
//					else
//						source[0,idxCol-1] = Convert0ToHide(source[0,idxCol-1].ToString()) + strTenPhep + strGioPhep;
//
//					oSheet.get_Range(oSheet.Cells[idxRow,idxCol],oSheet.Cells[idxRow,idxCol]).ColumnWidth  = 5;
//				}
//
//				
//	
//			}
//			return source;
//		}

		private string Convert0ToHide(string val)
		{
			if(val == "0")
				return "";
			else 
				return val;

		}

		

		private int ConvertHourToMinute(string hour)
		{
			if(hour.Length == 4)			
				return Convert.ToInt32(hour) / 100 * 60 ;
			else if(hour.Length == 3)
				return Convert.ToInt32(hour.Substring(0,1)) * 60 + Convert.ToInt32(hour.Substring(1,2));
			return Convert.ToInt16(hour);
		}		

		private string ConvertCol_IntToString(int col)
		{
			ArrayList arrD = new ArrayList();
			//G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,V,W,X,Y,Z,AA,AB,AC,AD,AE,AF,AG,AH,AI,AK,AL,AM,AN,AO,AP,AQ,AR,AS,AT,AU,AV,AW,
			//AX,AY,AZ,BA,BB,BC,BD,BE,BF,BG,BH,BI,BJ,BK,BL,BM,BN,BO,BP,BQ,BR,BS,BT
			//7->72
			arrD.Add("6|F");arrD.Add("7|G");arrD.Add("8|H");arrD.Add("9|I");arrD.Add("10|J");
			arrD.Add("11|K");arrD.Add("12|L");arrD.Add("13|M");arrD.Add("14|N");arrD.Add("15|O");
			arrD.Add("16|P");arrD.Add("17|Q");arrD.Add("18|R");arrD.Add("19|S");arrD.Add("20|T");
			arrD.Add("21|U");arrD.Add("22|V");arrD.Add("23|W");arrD.Add("24|X");arrD.Add("25|Y");
			arrD.Add("26|Z");arrD.Add("27|AA");arrD.Add("28|AB");arrD.Add("29|AC");arrD.Add("30|AD");
			arrD.Add("31|AE");arrD.Add("32|AF");arrD.Add("33|AG");arrD.Add("34|AH");arrD.Add("35|AI");
			arrD.Add("36|AJ");
//			arrD.Add("37|AK");arrD.Add("38|AL");arrD.Add("39|AM");arrD.Add("40|AN");
//			arrD.Add("41|AO");arrD.Add("42|AP");arrD.Add("43|AQ");arrD.Add("44|AR");arrD.Add("45|AS");
//			arrD.Add("46|AT");arrD.Add("47|AU");arrD.Add("48|AV");arrD.Add("49|AW");arrD.Add("50|AX");
//			arrD.Add("51|AY");arrD.Add("52|AZ");arrD.Add("53|BA");arrD.Add("54|BB");arrD.Add("55|BC");
//			arrD.Add("56|BD");arrD.Add("57|BE");arrD.Add("58|BF");arrD.Add("59|BG");arrD.Add("60|BH");
//			arrD.Add("61|BI");arrD.Add("62|BJ");arrD.Add("63|BK");arrD.Add("64|BL");arrD.Add("65|BM");
//			arrD.Add("66|BN");arrD.Add("67|BO");arrD.Add("68|BP");arrD.Add("69|BQ");arrD.Add("70|BR");
//			arrD.Add("71|BS");arrD.Add("72|BT");

			for(int x = 0; x < arrD.Count;x++)
			{
				string d = arrD[x].ToString().Split('|')[0];
				if(col.ToString() == d)
					return arrD[x].ToString().Split('|')[1];				
			}			
			return "";			
		}

		private string ConvertNull(object val)
		{
			if(val == null)
				return "";
			try
			{
				if(val.ToString() == "0" || val.ToString() == "0.0" || val.ToString() == "")
					return "-";
				else
					return val.ToString();
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			return val.ToString();
		}
	}
}
