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
	/// Summary description for Rehong_TangCaVuot.
	/// </summary>
	public class Rehong_TangCaVuot
	{
		Excel.Application oExcel;
		Excel.Worksheet oSheet, oTemplate;
		
		string strDateChoose ="", strWhere ="";
		string strBoPhan="",strWorkHour="",strDateTimeTo="",strDateTimeFrom="";
		public Rehong_TangCaVuot(Excel.Application oExcel, NativeWindow xlMain, Hashtable hs)
		{
			try	
			{
				this.oExcel = oExcel;
				oSheet = (Excel.Worksheet)oExcel.Worksheets[1];
				oSheet.Activate();
				this.oTemplate = oExcel.Sheets["Template"] as Excel.Worksheet;								

				//param
				strDateChoose =hs["strDateChoose"].ToString();				
				strWhere=hs["strWhere"].ToString();				
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
			string ngayCuoiThangChon = Convert.ToDateTime(strDateChoose).AddMonths(1).AddDays(-1).ToString("yyyy-MM-dd");
			string sql=string.Format("select nhanvien.EMP_ID, bophan.DEP_ID, EMP_NM , EMP_N1, POS_NM, ACC_NO, bophan.DEP_NM, bophan.Priority " +
									"from FILB01A nhanvien " +
									"join FILA02A bophan on nhanvien.DEP_ID = bophan.DEP_ID " +
									"join FILA07A chucvu on nhanvien.POS_ID = chucvu.POS_ID " +
									"left join FILB01AC nghiviec on nghiviec.EMP_ID = nhanvien.EMP_ID " +
									"{0} (nghiviec.VAC_DT is null or nghiviec.VAC_DT > '{1}') order by bophan.Priority, nhanvien.EMP_ID asc", strWhere,ngayCuoiThangChon);
	
			Func.RecordSet rsData = new Func.RecordSet(sql,PublicFunction.C_con);
			
			//Build excel title
			BuildTitle("B","B",3,"[MM/YYYY]", strDateChoose);
			BuildTitle("B","B",4,"[YYYY]", strDateChoose.Split('/')[1]);
			BuildTitle("B","B",4,"[MM]", strDateChoose.Split('/')[0]);

			if(rsData != null && rsData.rows>0)
			{
				//Build excel row
				int iRow = BuildExcelRow(rsData,true,"A","AB",8);
				
				//Format cells date
//				Excel.Range rgDate = oSheet.get_Range(oSheet.Cells[7,5],oSheet.Cells[iRow-1,5]);		
//				rgDate.NumberFormat = "mm/dd/yyyy";				
				
				//Format cells currency
//				Excel.Range rgCurrency = oSheet.get_Range(oSheet.Cells[7,7],oSheet.Cells[iRow-1,20]);		
//				rgCurrency.NumberFormat = "#,##0";				
				
				//Format total:
				Excel.Range rgTotal = oSheet.get_Range(oSheet.Cells[iRow,1],oSheet.Cells[iRow,6]);
				rgTotal.HorizontalAlignment = HorizontalAlignment.Right;
				rgTotal.VerticalAlignment = HorizontalAlignment.Right;

				//Draw border
				ReportExcel2.DrawBorders(oSheet, 8, 1, iRow, 28);

				//Build footer
				BuildFooter(iRow,1,6,"TOTAL");
				
				BuildTotalSum(iRow);

//				BuildFooter(iRow,7,7,string.Format("=sum(G8:G{0})",iRow-1));
//				BuildFooter(iRow,8,8,string.Format("=sum(H8:H{0})",iRow-1));
//				BuildFooter(iRow,9,9,string.Format("=sum(I8:I{0})",iRow-1));
//				BuildFooter(iRow,10,10,string.Format("=sum(J8:J{0})",iRow-1));
//				BuildFooter(iRow,11,11,string.Format("=sum(K8:K{0})",iRow-1));
//				BuildFooter(iRow,12,12,string.Format("=sum(L8:L{0})",iRow-1));
//				BuildFooter(iRow,13,13,string.Format("=sum(M8:M{0})",iRow-1));
//				BuildFooter(iRow,14,14,string.Format("=sum(N8:N{0})",iRow-1));
//				BuildFooter(iRow,15,15,string.Format("=sum(O8:O{0})",iRow-1));
//				BuildFooter(iRow,16,16,string.Format("=sum(P8:P{0})",iRow-1));
//				BuildFooter(iRow,17,17,string.Format("=sum(Q8:Q{0})",iRow-1));
//				BuildFooter(iRow,18,18,string.Format("=sum(R8:R{0})",iRow-1));
//				BuildFooter(iRow,19,19,string.Format("=sum(S8:S{0})",iRow-1));
//				BuildFooter(iRow,20,20,string.Format("=sum(T8:T{0})",iRow-1));
//				BuildFooter(iRow,21,21,string.Format("=sum(U8:U{0})",iRow-1));
//				BuildFooter(iRow,22,22,string.Format("=sum(V8:V{0})",iRow-1));
//				BuildFooter(iRow,23,23,string.Format("=sum(W8:W{0})",iRow-1));
//				BuildFooter(iRow,24,24,string.Format("=sum(X8:X{0})",iRow-1));

				iRow++;
				iRow++;
				//Build footer
				BuildFooter(iRow,1,3,"Tổng Giám Đốc");
				BuildFooter(iRow,4,5,"                               Phó Tổng Giám Đốc");
				BuildFooter(iRow,11,13,"Kế Toán");
				BuildFooter(iRow,24,25,"Nhân Sự");

				iRow++;
				BuildFooter(iRow,1,3,"總  經  理");
				BuildFooter(iRow,4,5,"                               副總");
				BuildFooter(iRow,11,13,"会计");
				BuildFooter(iRow,24,25,"人事");
			}
		}
		
		ArrayList arrListSum = new ArrayList();

		private void BuildTotalSum(int idx)
		{
			string strG = "",strH="", strI="",strJ="",strK="",strL="",strM="",strN="",strO="",strP="",strQ="",strR="",strS="",strT="",strU="",strV="",strW="",strX="",strY="",strZ="",strAA="";
			for(int x = 0; x < arrListSum.Count; x++)
			{
				string iSTART = arrListSum[x].ToString().Split('|')[0];
				string iEND = arrListSum[x].ToString().Split('|')[1];

				//strG = BuildSumTotalSumItem("G",iSTART,iEND,strG);
				strH = BuildSumTotalSumItem("H",iSTART,iEND,strH);
				strI = BuildSumTotalSumItem("I",iSTART,iEND,strI);
				strJ = BuildSumTotalSumItem("J",iSTART,iEND,strJ);
				strK = BuildSumTotalSumItem("K",iSTART,iEND,strK);
				strL = BuildSumTotalSumItem("L",iSTART,iEND,strL);
				strM = BuildSumTotalSumItem("M",iSTART,iEND,strM);
				strN = BuildSumTotalSumItem("N",iSTART,iEND,strN);
				strO = BuildSumTotalSumItem("O",iSTART,iEND,strO);
				strP = BuildSumTotalSumItem("P",iSTART,iEND,strP);
				strQ = BuildSumTotalSumItem("Q",iSTART,iEND,strQ);
				strR = BuildSumTotalSumItem("R",iSTART,iEND,strR);
				strS = BuildSumTotalSumItem("S",iSTART,iEND,strS);
				strT = BuildSumTotalSumItem("T",iSTART,iEND,strT);
				strU = BuildSumTotalSumItem("U",iSTART,iEND,strU);
				strV = BuildSumTotalSumItem("V",iSTART,iEND,strV);
				strW = BuildSumTotalSumItem("W",iSTART,iEND,strW);
				strX = BuildSumTotalSumItem("X",iSTART,iEND,strX);
				strY = BuildSumTotalSumItem("Y",iSTART,iEND,strY);
				strZ = BuildSumTotalSumItem("Z",iSTART,iEND,strZ);
				strAA = BuildSumTotalSumItem("AA",iSTART,iEND,strAA);
			}
			//BuildFooter(idx,7,7,strG);		
			BuildFooter(idx,8,8,strH);
			BuildFooter(idx,9,9,strI);
			BuildFooter(idx,10,10,strJ);
			BuildFooter(idx,11,11,strK);
			BuildFooter(idx,12,12,strL);
			BuildFooter(idx,13,13,strM);
			BuildFooter(idx,14,14,strN);
			BuildFooter(idx,15,15,strO);
			BuildFooter(idx,16,16,strP);
			BuildFooter(idx,17,17,strQ);
			BuildFooter(idx,18,18,strR);
			BuildFooter(idx,19,19,strS);
			BuildFooter(idx,20,20,strT);
			BuildFooter(idx,21,21,strU);
			BuildFooter(idx,22,22,strV);
			BuildFooter(idx,23,23,strW);
			BuildFooter(idx,24,24,strX);
			BuildFooter(idx,25,25,strY);
			BuildFooter(idx,26,26,strZ);
			BuildFooter(idx,27,27,strAA);
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

			//Build excel row
			for(int x = 0; x < rsData.rows; x++)
			{
				//Them group bo phan
				string bp = rsData.record(x,6);
				if(strBoPhanTitle != bp)
				{
					if(strBoPhanTitle != "")
					{						
						end = fromRow -1;
						arrListSum.Add(string.Format("{0}|{1}",start,end));

						//Build total
						BuildFooter(fromRow,1,6,string.Format("TOTAL {0}:",strBoPhanTitle));				
						//BuildFooter(fromRow,7,7,string.Format("=sum(G{1}:G{0})",end,start));
						BuildFooter(fromRow,8,8,string.Format("=sum(H{1}:H{0})",end,start));
						BuildFooter(fromRow,9,9,string.Format("=sum(I{1}:I{0})",end,start));
						BuildFooter(fromRow,10,10,string.Format("=sum(J{1}:J{0})",end,start));
						BuildFooter(fromRow,11,11,string.Format("=sum(K{1}:K{0})",end,start));
						BuildFooter(fromRow,12,12,string.Format("=sum(L{1}:L{0})",end,start));
						BuildFooter(fromRow,13,13,string.Format("=sum(M{1}:M{0})",end,start));
						BuildFooter(fromRow,14,14,string.Format("=sum(N{1}:N{0})",end,start));
						BuildFooter(fromRow,15,15,string.Format("=sum(O{1}:O{0})",end,start));
						BuildFooter(fromRow,16,16,string.Format("=sum(P{1}:P{0})",end,start));
						BuildFooter(fromRow,17,17,string.Format("=sum(Q{1}:Q{0})",end,start));
						BuildFooter(fromRow,18,18,string.Format("=sum(R{1}:R{0})",end,start));
						BuildFooter(fromRow,19,19,string.Format("=sum(S{1}:S{0})",end,start));
						BuildFooter(fromRow,20,20,string.Format("=sum(T{1}:T{0})",end,start));
						BuildFooter(fromRow,21,21,string.Format("=sum(U{1}:U{0})",end,start));
						BuildFooter(fromRow,22,22,string.Format("=sum(V{1}:V{0})",end,start));
						BuildFooter(fromRow,23,23,string.Format("=sum(W{1}:W{0})",end,start));
						BuildFooter(fromRow,24,24,string.Format("=sum(X{1}:X{0})",end,start));
						BuildFooter(fromRow,25,25,string.Format("=sum(Y{1}:Y{0})",end,start));
						BuildFooter(fromRow,26,26,string.Format("=sum(Z{1}:Z{0})",end,start));
						BuildFooter(fromRow,27,27,string.Format("=sum(AA{1}:AA{0})",end,start));
						fromRow++;
					}

					//instant new row
					object[,] data1 = new object[1, rsData.cols+24];				
					strBoPhanTitle = bp;
					data1[0,1] = bp;
					
					oSheet.get_Range(string.Format("{1}{0}:{2}{0}", fromRow,from,to), Missing.Value)
						.set_Value(Excel.XlRangeValueDataType.xlRangeValueDefault, data1);
					
					oSheet.get_Range(string.Format("{1}{0}:{2}{0}", fromRow,from,to), Missing.Value).Cells.Font.Bold = true;
					oSheet.get_Range(string.Format("{1}{0}:{2}{0}", fromRow,from,to), Missing.Value).Cells.Font.Size = 16;
			
					fromRow++;
					start = fromRow;
					iSTT=1;	
				}

				//instant new row
				object[,] data = new object[1, rsData.cols+24];				

				//get a row
				for(int y = 1; y < rsData.cols-1 + stt;y++)				
					data[0,y] = rsData.record(x,y - stt);				
				
				string id = rsData.record(x,"EMP_ID");											
				
				string dbGP = PublicFunction.DT_database;
				string dbGPS = PublicFunction.DTGP_database;
				
				string strTien15 = "isnull(round((gp_luong.tien15-gps_luong.tien15),0),0)";
				string strTien195 = "isnull(round((gp_luong.ThanhTienCa-gps_luong.ThanhTienCa),0),0)";
				string strTien215 = "isnull(round((gp_luong.tien195-gps_luong.tien195),0),0)";
				string strTien2 = "isnull(round((gp_luong.tien2-gps_luong.tien2),0),0)";
				string strTien3 = "isnull(round((gp_luong.TienTangCaNgayLe3-gps_luong.TienTangCaNgayLe3),0),0)";
				string strTienPC = "isnull(round((gp_luong.ThanhTienPC30 - gps_luong.ThanhTienPC30),0),0)";
				string strTienCN = "isnull(round((gp_luong.ThanhTienCaQuaDemCN - gps_luong.ThanhTienCaQuaDemCN),0),0)";
				string strtiencom = "isnull(gp_luong.tiencom,0)";
				string strTongTienTC = string.Format("({0}+{1}+{2}+{3}+{4}+{5}+{6}+{7})",strTien15, strTien195, strTien215, strTien2, strTien3, strTienPC, strTienCN, strtiencom);
				string strBoiThuong = "ISNULL((gp_luong.boithuong - gps_luong.boithuong),0)";
				string strThueTNCao = "ISNULL((gp_luong.thuethunhap - gps_luong.thuethunhap),0)";
				string strThucLanh = string.Format("({0}-{1}-{2})", strTongTienTC, strBoiThuong, strThueTNCao);
				strThucLanh = string.Format("(select case when {0} < 0 then 0 else {0} end)", strThucLanh);				
				
				//bind data min to row
				string sqlMin=string.Format("SELECT gp_luong.muc_luongcoban as 'LuongCoBan', gp_luong.tiencom as 'tiencom'," +
								"ISNULL((gp_luong.gio15 - gps_luong.gio15),0) as 'SoGioTangCaThuong1.5', " +
								 strTien15 + " as 'ThanhTien1.5', " +
								"ISNULL((gp_luong.TangCaNgayThuong - gps_luong.TangCaNgayThuong),0) as 'SoGioTangCaCaDem1.95', " +
								 strTien195 + " as 'ThanhTien1.95', "+
								"ISNULL((gp_luong.gio195 - gps_luong.gio195),0) as 'SoGioTangCaQuaDem2.15', " +
								 strTien215 + " as 'ThanhTien2.15', " +			
								"ISNULL((gp_luong.gio2 - gps_luong.gio2),0) as 'SoGioTangCaNgayNghi2.0', " +
					             strTien2 + " as 'ThanhTien2.0',  "+
								"ISNULL((gp_luong.GioTangCaNgayLe3 - gps_luong.GioTangCaNgayLe3),0) as 'SoGioTangCaNgayLe3.0', " +
								 strTien3 + " as 'ThanhTien3.0', " +
								"ISNULL((gp_tk.PhuCap30Per - gps_tk.PhuCap30Per),0) as 'SoGioPCCaDem30%', " +
								 strTienPC + " as 'ThanhTienPC30%', " +
								"ISNULL((gp_luong.TangCaQuaDemCN - gps_luong.TangCaQuaDemCN),0) as 'SoGioTCQuaDemCN',  " +
								 strTienCN + " as 'ThanhTienTCQuaDemCN',  " +

								//"isnull(round((gp_luong.tongluong - gps_luong.tongluong),0),0)as 'TongThanhTien', " +
								strTongTienTC + " as 'TongThanhTien', " +
								strBoiThuong + " as 'BoiThuong', " +
								strThueTNCao + " as 'ThueThuNhap', " +
								strThucLanh + " as 'TongTienThucLanh' " +

								"FROM [{2}].[dbo].[FILC06AA] gp_tk " +
								"join [{3}].[dbo].[GPS_TongKet] gps_tk on gp_tk.EMP_ID = gps_tk.EMP_ID " +
								"join [{2}].[dbo].[FILD02A] gp_luong on gp_tk.EMP_ID = gp_luong.EMP_ID " +
								"join [{3}].[dbo].[GPS_LuongTD] gps_luong on gps_tk.EMP_ID = gps_luong.EMP_ID " +
								"where (gp_tk.YYY_MM = '{1}' and gp_tk.EMP_ID = '{0}') and " + 
										"(gps_tk.YYY_MM = '{1}' and gps_tk.EMP_ID = '{0}') and " +
										"(gp_luong.YYY_MM = '{1}' and gp_luong.EMP_ID = '{0}') and " + 
										"(gps_luong.YYY_MM = '{1}' and gps_luong.EMP_ID = '{0}') and gp_tk.SEQ_NO = 2 and gps_tk.SEQ_NO = 2 and gp_luong.SEQ_NO = 2 and gps_luong.SEQ_NO = 2", id,strDateChoose.Split('/')[1]+strDateChoose.Split('/')[0],dbGP,dbGPS);
				Func.RecordSet rsDataRow = new Func.RecordSet(sqlMin,PublicFunction.C_con);
				
				for(int y = 0; y < rsDataRow.cols;y++)				
					data[0,y+7] = rsDataRow.record(0,y);								

				//bind value STT
				if(isSTT)
					data[0,0] = iSTT;						
				
				//sum value total hoc viec
				//data[0,12] = Convert.ToInt32(data[0,6]) + Convert.ToInt32(data[0,7]) + Convert.ToInt32(data[0,8]) + Convert.ToInt32(data[0,9]) + Convert.ToInt32(data[0,10]) + Convert.ToInt32(data[0,11]);

				//sum value total hien tai
				//data[0,19] = Convert.ToInt32(data[0,13]) + Convert.ToInt32(data[0,14]) + Convert.ToInt32(data[0,15]) + Convert.ToInt32(data[0,16]) + Convert.ToInt32(data[0,17]) + Convert.ToInt32(data[0,18]);
				//format cell
				//data[0,4] = Convert.ToDateTime(data[0,4]).ToString("dd/MM/yyyy");

				//bind value
				oSheet.get_Range(string.Format("{1}{0}:{2}{0}", fromRow,from,to), Missing.Value)
					.set_Value(Excel.XlRangeValueDataType.xlRangeValueDefault, data);
								
				fromRow++;
				iSTT++;	

				if(x == rsData.rows-1)
				{
					end = fromRow -1;
					arrListSum.Add(string.Format("{0}|{1}",start,end));

					//Build total
					BuildFooter(fromRow,4,6,string.Format("TOTAL {0}:",strBoPhanTitle));				
					//BuildFooter(fromRow,7,7,string.Format("=sum(G{1}:G{0})",end,start));
					BuildFooter(fromRow,8,8,string.Format("=sum(H{1}:H{0})",end,start));
					BuildFooter(fromRow,9,9,string.Format("=sum(I{1}:I{0})",end,start));
					BuildFooter(fromRow,10,10,string.Format("=sum(J{1}:J{0})",end,start));
					BuildFooter(fromRow,11,11,string.Format("=sum(K{1}:K{0})",end,start));
					BuildFooter(fromRow,12,12,string.Format("=sum(L{1}:L{0})",end,start));
					BuildFooter(fromRow,13,13,string.Format("=sum(M{1}:M{0})",end,start));
					BuildFooter(fromRow,14,14,string.Format("=sum(N{1}:N{0})",end,start));
					BuildFooter(fromRow,15,15,string.Format("=sum(O{1}:O{0})",end,start));
					BuildFooter(fromRow,16,16,string.Format("=sum(P{1}:P{0})",end,start));
					BuildFooter(fromRow,17,17,string.Format("=sum(Q{1}:Q{0})",end,start));
					BuildFooter(fromRow,18,18,string.Format("=sum(R{1}:R{0})",end,start));
					BuildFooter(fromRow,19,19,string.Format("=sum(S{1}:S{0})",end,start));
					BuildFooter(fromRow,20,20,string.Format("=sum(T{1}:T{0})",end,start));
					BuildFooter(fromRow,21,21,string.Format("=sum(U{1}:U{0})",end,start));
					BuildFooter(fromRow,22,22,string.Format("=sum(V{1}:V{0})",end,start));
					BuildFooter(fromRow,23,23,string.Format("=sum(W{1}:W{0})",end,start));
					BuildFooter(fromRow,24,24,string.Format("=sum(X{1}:X{0})",end,start));
					BuildFooter(fromRow,25,25,string.Format("=sum(Y{1}:Y{0})",end,start));
					BuildFooter(fromRow,26,26,string.Format("=sum(Z{1}:Z{0})",end,start));
					BuildFooter(fromRow,27,27,string.Format("=sum(AA{1}:AA{0})",end,start));
					fromRow++;
				}
			}
			return fromRow;
		}			
	}
}
