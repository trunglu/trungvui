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
	/// Summary description for Rehong_TienMatNV.
	/// </summary>
	public class Rehong_TienMatNV
	{
		Excel.Application oExcel;
		Excel.Worksheet oSheet, oTemplate;
		
		string dateChuyenKhoan = "",strWhere = "";
		public Rehong_TienMatNV(Excel.Application oExcel, NativeWindow xlMain, Hashtable hs)
		{
			try	
			{
				this.oExcel = oExcel;
				oSheet = (Excel.Worksheet)oExcel.Worksheets[1];
				oSheet.Activate();
				this.oTemplate = oExcel.Sheets["Template"] as Excel.Worksheet;
				dateChuyenKhoan = hs["dateChuyenKhoan"].ToString();		
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
			string ngayChon = Convert.ToDateTime(dateChuyenKhoan).ToString("yyyy-MM-dd");
			string ngayDauThangSauChon= Convert.ToDateTime(dateChuyenKhoan).AddMonths(1).ToString("yyyy-MM-dd");
			strWhere = strWhere.IndexOf("WHERE") != -1 ? strWhere + " AND" : "WHERE" ;
			string sql=string.Format("SELECT bophan.DEP_NM, nhanvien.EMP_ID, bophan.DEP_ID, nhanvien.EMP_NM, bangluong.thucnhan "
			+ "FROM FILB01A nhanvien "
			+ "join FILA02A bophan on nhanvien.DEP_ID = bophan.DEP_ID "
			+ string.Format("join {0} bangluong on nhanvien.EMP_ID = bangluong.EMP_ID ",Function.Common.Ints.tbLuongTD)
			+ "join FILB01AC nghiviec on nghiviec.EMP_ID = nhanvien.EMP_ID "
			+ "{3} ((ACC_NM is null or acc_no is  null) "		
			+ "or (nhanvien.ACC_NM ='' or nhanvien.ACC_NO ='')) "
		    + "AND (nhanvien.VAC_BT = 1 and nghiviec.VAC_DT > '{1}' and nghiviec.VAC_DT < '{2}') "
			+ "and bangluong.SEQ_NO = 2 and YYY_MM= '{0}'  order by bophan.DEP_NM, nhanvien.EMP_ID asc",Convert.ToDateTime(dateChuyenKhoan).ToString("yyyyMM"),ngayChon,ngayDauThangSauChon,strWhere);			
			Func.RecordSet rsData = new Func.RecordSet(sql,PublicFunction.C_con);
			
			//Build excel title
			BuildTitle("A","A",3,"[MM/YYYY]", dateChuyenKhoan);			
			BuildTitle("A","A",4,"[YYYY]", Convert.ToDateTime(dateChuyenKhoan).ToString("yyyy"));	
			BuildTitle("A","A",4,"[MM]", Convert.ToDateTime(dateChuyenKhoan).ToString("MM"));	

			if(rsData != null && rsData.rows>0)
			{
				//Build excel row
				int iRow = BuildExcelRow(rsData,true,"A","G",6);				

				

				//Draw border
				ReportExcel2.DrawBorders(oSheet, 6, 1, iRow, 7);
				
				//sum
				BuildFooter(iRow,1,5,"TOTAL:");
				BuildTotalSum(iRow);
				//BuildFooter(iRow,6,6,string.Format("=sum({0}{1}:{0}{2}) ","F",6,iRow-1));
				iRow++;

				//Build footer
				BuildFooter(iRow,1,2,"Tổng Giám Đốc");
				BuildFooter(iRow,3,5,"Phó Tổng Giám Đốc");
				BuildFooter(iRow,6,6,"Kế Toán");
				BuildFooter(iRow,8,8,"Nhân Sự");
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
		

		ArrayList arrListSum = new ArrayList();
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
			///////////////////
			string strBoPhanTitle = "";
			
			int start = 0, end = 0;	

			//Build excel row
			for(int x = 0; x < rsData.rows; x++)
			{
				//Them group bo phan
				string bp = rsData.record(x,0);
				if(strBoPhanTitle != bp)
				{
					if(strBoPhanTitle != "")
					{						
						end = fromRow -1;
						arrListSum.Add(string.Format("{0}|{1}",start,end));

						//Build total
						BuildFooter(fromRow,1,5,string.Format("TOTAL {0}:",strBoPhanTitle));				
						BuildFooter(fromRow,6,6,string.Format("=sum(F{1}:F{0})",end,start));												fromRow++;
					}

					//instant new row
					object[,] data1 = new object[1, rsData.cols+15];				
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
				/////////////////

				//instant new row
				object[,] data = new object[1, rsData.cols+2];

				//get a row
				for(int y = 0; y < rsData.cols + stt;y++)				
					data[0,y] = rsData.record(x,y - stt);									

				//bind value STT
				if(isSTT)
					data[0,0] = iSTT;

				//format cell
				data[0,6] = "";
				//data[0,3] = Convert.ToDateTime(data[0,3]).ToString("dd/MM/yyyy");

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
					BuildFooter(fromRow,1,5,string.Format("TOTAL {0}:",strBoPhanTitle));				
					BuildFooter(fromRow,6,6,string.Format("=sum(F{1}:F{0})",end,start));					
					fromRow++;
				}
			}
			return fromRow;
		}	
		
		private void BuildTotalSum(int idx)
		{
			string strF = "";
			for(int x = 0; x < arrListSum.Count; x++)
			{
				string iSTART = arrListSum[x].ToString().Split('|')[0];
				string iEND = arrListSum[x].ToString().Split('|')[1];

				strF = BuildSumTotalSumItem("F",iSTART,iEND,strF);				
			}
			BuildFooter(idx,6,6,strF);		
		}

		private string BuildSumTotalSumItem(string character, string iStart,string iEnd,string strResult)
		{			
			if(strResult == "")
				strResult = string.Format("=sum({2}{0}:{2}{1}) ",iStart,iEnd,character);
			else	
				strResult += string.Format(" + sum({2}{0}:{2}{1})",iStart,iEnd,character);
			return strResult;
		}
	}
}
