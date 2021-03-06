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
			string sql=string.Format("select nhanvien.EMP_ID, bophan.DEP_ID, EMP_NM ,EMP_N1, POS_NM " +
									"from FILB01A nhanvien " +
									"join FILA02A bophan on nhanvien.DEP_ID = bophan.DEP_ID " +
									"join FILA07A chucvu on nhanvien.POS_ID = chucvu.POS_ID " +
									"left join FILB01AC nghiviec on nghiviec.EMP_ID = nhanvien.EMP_ID " +
									"{0} (nghiviec.VAC_DT is null or nghiviec.VAC_DT > {1}) order by bophan.DEP_NM, nhanvien.EMP_ID asc", strWhere,ngayCuoiThangChon);
	
			Func.RecordSet rsData = new Func.RecordSet(sql,PublicFunction.C_con);
			
			//Build excel title
			BuildTitle("B","B",3,"[MM/YYYY]", strDateChoose);
			BuildTitle("B","B",4,"[YYYY]", strDateChoose.Split('/')[1]);
			BuildTitle("B","B",4,"[MM]", strDateChoose.Split('/')[0]);

			if(rsData != null && rsData.rows>0)
			{
				//Build excel row
				int iRow = BuildExcelRow(rsData,true,"A","Y",8);
				
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
				ReportExcel2.DrawBorders(oSheet, 8, 1, iRow, 25);

				//Build footer
				BuildFooter(iRow,1,6,"TOTAL");
				

				BuildFooter(iRow,7,7,string.Format("=sum(G8:G{0})",iRow-1));
				BuildFooter(iRow,8,8,string.Format("=sum(H8:H{0})",iRow-1));
				BuildFooter(iRow,9,9,string.Format("=sum(I8:I{0})",iRow-1));
				BuildFooter(iRow,10,10,string.Format("=sum(J8:J{0})",iRow-1));
				BuildFooter(iRow,11,11,string.Format("=sum(K8:K{0})",iRow-1));
				BuildFooter(iRow,12,12,string.Format("=sum(L8:L{0})",iRow-1));
				BuildFooter(iRow,13,13,string.Format("=sum(M8:M{0})",iRow-1));
				BuildFooter(iRow,14,14,string.Format("=sum(N8:N{0})",iRow-1));
				BuildFooter(iRow,15,15,string.Format("=sum(O8:O{0})",iRow-1));
				BuildFooter(iRow,16,16,string.Format("=sum(P8:P{0})",iRow-1));
				BuildFooter(iRow,17,17,string.Format("=sum(Q8:Q{0})",iRow-1));
				BuildFooter(iRow,18,18,string.Format("=sum(R8:R{0})",iRow-1));
				BuildFooter(iRow,19,19,string.Format("=sum(S8:S{0})",iRow-1));
				BuildFooter(iRow,20,20,string.Format("=sum(T8:T{0})",iRow-1));
				BuildFooter(iRow,21,21,string.Format("=sum(U8:U{0})",iRow-1));
				BuildFooter(iRow,22,22,string.Format("=sum(V8:V{0})",iRow-1));
				BuildFooter(iRow,23,23,string.Format("=sum(W8:W{0})",iRow-1));
				BuildFooter(iRow,24,24,string.Format("=sum(X8:X{0})",iRow-1));

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
				
			//Build excel row
			for(int x = 0; x < rsData.rows; x++)
			{
				//instant new row
				object[,] data = new object[1, rsData.cols+21];				

				//get a row
				for(int y = 0; y < rsData.cols + stt;y++)				
					data[0,y] = rsData.record(x,y - stt);				
				
				string id = rsData.record(x,"EMP_ID");											
				
				string dbGP = PublicFunction.DT_database;
				string dbGPS = PublicFunction.DTGP_database;

				//bind data min to row
				string sqlMin=string.Format("SELECT gp_luong.muc_luongcoban as 'LuongCoBan', " +
								"ISNULL((gp_tk.OTT_HR - gps_tk.OTT_HR) + (gp_tk.OT1_HR - gps_tk.OT1_HR),0) as 'SoGioTangCaThuong1.5', " +
								"ISNULL(ROUND(gp_luong.muc_luongcoban/208*((gp_tk.OTT_HR - gps_tk.OTT_HR) + (gp_tk.OT1_HR - gps_tk.OT1_HR))*1.5,0),0) as 'ThanhTien1.5', " +
								"ISNULL((gp_tk.NIG_OT - gps_tk.NIG_OT),0) as 'SoGioTangCaCaDem1.95', " +
								"ISNULL(ROUND(gp_luong.muc_luongcoban/208*(gp_tk.NIG_OT - gps_tk.NIG_OT)*1.95,0),0) as 'ThanhTien1.95', " +
								"ISNULL((gp_tk.OVO_HR - gps_tk.OVO_HR),0) + ISNULL((gp_tk.NIG_OV - gps_tk.NIG_OV),0) as 'SoGioTangCaQuaDem2.15', " +
								"ISNULL(ROUND(gp_luong.muc_luongcoban/208*((gp_tk.OVO_HR - gps_tk.OVO_HR)+(gp_tk.NIG_OV - gps_tk.NIG_OV))*2.15,0),0) as 'ThanhTien2.15', " +
								"ISNULL((gp_tk.DOF_HR - gps_tk.DOF_HR) + (gp_tk.PRO_HR - gps_tk.PRO_HR) + (gp_tk.DOF_OT - gps_tk.DOF_OT),0) as 'SoGioTangCaNgayNghi2.0', " +
								"ISNULL(ROUND(gp_luong.muc_luongcoban/208* ((gp_tk.DOF_HR - gps_tk.DOF_HR) + (gp_tk.PRO_HR - gps_tk.PRO_HR) + (gp_tk.DOF_OT - gps_tk.DOF_OT))*2.0,0),0) as 'ThanhTien2.0', " +
								"ISNULL((gp_tk.HOL_HR - gps_tk.HOL_HR),0) as 'SoGioTangCaNgayLe3.0', " +
								"ISNULL(ROUND(gp_luong.muc_luongcoban/208*(gp_tk.HOL_HR - gps_tk.HOL_HR)*3.0,0),0) as 'ThanhTien3.0', " +
								"ISNULL((gp_tk.PhuCap30Per - gps_tk.PhuCap30Per),0) as 'SoGioPCCaDem30%', " +
								"ISNULL(ROUND(gp_luong.muc_luongcoban/208*(gp_tk.PhuCap30Per - gps_tk.PhuCap30Per)*0.3,0),0) as 'ThanhTienPC30%', " +
								"ISNULL((gp_tk.DOF_OV - gps_tk.DOF_OV),0) as 'SoGioTCQuaDemCN', " +
								"ISNULL(ROUND(gp_luong.muc_luongcoban/208*(gp_tk.DOF_OV - gps_tk.DOF_OV)*2.7,0),0) as 'ThanhTienTCQuaDemCN', " +
								
								"(ROUND(gp_luong.muc_luongcoban/208*(ISNULL((gp_tk.OTT_HR - gps_tk.OTT_HR),0) + ISNULL((gp_tk.OT1_HR - gps_tk.OT1_HR),0))*1.5,0))+ " +
								"(ROUND(gp_luong.muc_luongcoban/208*ISNULL((gp_tk.NIG_OT - gps_tk.NIG_OT),0)*1.95,0)) + " +
								"(ROUND(gp_luong.muc_luongcoban/208*(ISNULL((gp_tk.OVO_HR - gps_tk.OVO_HR),0)+ISNULL((gp_tk.NIG_OV - gps_tk.NIG_OV),0))*2.15,0))  + " +
								"(ROUND(gp_luong.muc_luongcoban/208* (ISNULL((gp_tk.DOF_HR - gps_tk.DOF_HR),0) + ISNULL((gp_tk.PRO_HR - gps_tk.PRO_HR),0) + ISNULL((gp_tk.DOF_OT - gps_tk.DOF_OT),0))*2.0,0)) + " +
								"(ROUND(gp_luong.muc_luongcoban/208*ISNULL((gp_tk.HOL_HR - gps_tk.HOL_HR),0)*3.0,0)) + " +
								"(ROUND(gp_luong.muc_luongcoban/208* ISNULL((gp_tk.PhuCap30Per - gps_tk.PhuCap30Per),0)*0.3,0)) + " +
								"(ROUND(gp_luong.muc_luongcoban/208* ISNULL((gp_tk.DOF_OV - gps_tk.DOF_OV),0)*2.7,0))  as 'TongThanhTien', " +

								"ISNULL((gp_luong.boithuong - gps_luong.boithuong),0) as 'BoiThuong', " +

								"((ROUND(gp_luong.muc_luongcoban/208*(ISNULL((gp_tk.OTT_HR - gps_tk.OTT_HR),0) + ISNULL((gp_tk.OT1_HR - gps_tk.OT1_HR),0))*1.5,0))+ " +
								"(ROUND(gp_luong.muc_luongcoban/208*ISNULL((gp_tk.NIG_OT - gps_tk.NIG_OT),0)*1.95,0)) + " +
								"(ROUND(gp_luong.muc_luongcoban/208*(ISNULL((gp_tk.OVO_HR - gps_tk.OVO_HR),0)+ISNULL((gp_tk.NIG_OV - gps_tk.NIG_OV),0))*2.15,0))  + " +
								"(ROUND(gp_luong.muc_luongcoban/208* (ISNULL((gp_tk.DOF_HR - gps_tk.DOF_HR),0) + ISNULL((gp_tk.PRO_HR - gps_tk.PRO_HR),0) + ISNULL((gp_tk.DOF_OT - gps_tk.DOF_OT),0))*2.0,0)) + " +
								"(ROUND(gp_luong.muc_luongcoban/208*ISNULL((gp_tk.HOL_HR - gps_tk.HOL_HR),0)*3.0,0)) + " +
								"(ROUND(gp_luong.muc_luongcoban/208* ISNULL((gp_tk.PhuCap30Per - gps_tk.PhuCap30Per),0)*0.3,0)) + " +
								"(ROUND(gp_luong.muc_luongcoban/208* ISNULL((gp_tk.DOF_OV - gps_tk.DOF_OV),0)*2.7,0)) ) -" +
								"ISNULL((gp_luong.boithuong - gps_luong.boithuong),0) " +
								"FROM [{2}].[dbo].[FILC06AA] gp_tk " +
								"join [{3}].[dbo].[FILC06AA] gps_tk on gp_tk.EMP_ID = gps_tk.EMP_ID " +
								"join [{2}].[dbo].[FILD02A] gp_luong on gp_tk.EMP_ID = gp_luong.EMP_ID " +
								"join [{3}].[dbo].[FILD02A] gps_luong on gps_tk.EMP_ID = gps_luong.EMP_ID " +
								"where (gp_tk.YYY_MM = '{1}' and gp_tk.EMP_ID = '{0}') and " + 
										"(gps_tk.YYY_MM = '{1}' and gps_tk.EMP_ID = '{0}') and " +
										"(gp_luong.YYY_MM = '{1}' and gp_luong.EMP_ID = '{0}') and " + 
										"(gps_luong.YYY_MM = '{1}' and gps_luong.EMP_ID = '{0}') and gp_tk.SEQ_NO = 2 and gps_tk.SEQ_NO = 2", id,strDateChoose.Split('/')[1]+strDateChoose.Split('/')[0],dbGP,dbGPS);
				Func.RecordSet rsDataRow = new Func.RecordSet(sqlMin,PublicFunction.C_con);
				
				for(int y = 0; y < rsDataRow.cols;y++)				
					data[0,y+6] = rsDataRow.record(0,y);								

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
			}
			return fromRow;
		}			
	}
}
