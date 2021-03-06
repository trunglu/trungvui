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
	/// Summary description for Rehong_ATM.
	/// </summary>
	public class Rehong_ThongKeLuongNV
	{
		Excel.Application oExcel;
		Excel.Worksheet oSheet, oTemplate;
		
		string strDateChoose ="", strWhere ="";
		public Rehong_ThongKeLuongNV(Excel.Application oExcel, NativeWindow xlMain, Hashtable hs)
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
			string ngayChon = Convert.ToDateTime(strDateChoose).ToString("yyyy-MM-dd");
			string ngayDauThangSauChon= Convert.ToDateTime(strDateChoose).AddMonths(1).ToString("yyyy-MM-dd");
			
			string sql=string.Format("select EMP_NM,EMP_N1, nhanvien.EMP_ID, INH_DT, POS_NM, bophan.DEP_NM , ACC_NO, BHX_NO, BIR_DT, bophan.Priority " +
									"from FILB01A nhanvien " +
									"join FILA02A bophan on nhanvien.DEP_ID = bophan.DEP_ID " +
									"join FILA07A chucvu on nhanvien.POS_ID = chucvu.POS_ID " +
									"join FILB01AF BHXH on nhanvien.EMP_ID = BHXH.EMP_ID " +
									"join FILB01AC nghiviec on nghiviec.EMP_ID = nhanvien.EMP_ID " +
									"{0} (nhanvien.VAC_BT = 1 and nghiviec.VAC_DT > '{1}' and nghiviec.VAC_DT < '{2}')  order by bophan.Priority, nhanvien.EMP_ID asc", strWhere,ngayChon,ngayDauThangSauChon);
			Func.RecordSet rsData = new Func.RecordSet(sql,PublicFunction.C_con);
			
			//Build excel title
			BuildTitle("A","A",3,"BÁO BIỂU THỐNG KÊ LƯƠNG / 工資統計表 [MM/YYYY]", string.Format("BÁO BIỂU THỐNG KÊ LƯƠNG / 工資統計表 {0}", strDateChoose));

			if(rsData != null && rsData.rows>0)
			{
				//Build excel row
				int iRow = BuildExcelRow(rsData,true,"A","X",7);
				
				//Format cells date
//				Excel.Range rgDate = oSheet.get_Range(oSheet.Cells[8,5],oSheet.Cells[iRow-1,5]);		
//				rgDate.NumberFormat = "dd/MM/yyyy";				
//				
				//Format cells currency
				Excel.Range rgCurrency = oSheet.get_Range(oSheet.Cells[7,7],oSheet.Cells[iRow-1,20]);		
				rgCurrency.NumberFormat = "#,##0";				
				
				//Format total:
				Excel.Range rgTotal = oSheet.get_Range(oSheet.Cells[iRow,1],oSheet.Cells[iRow,6]);
				rgTotal.HorizontalAlignment = HorizontalAlignment.Right;
				rgTotal.VerticalAlignment = HorizontalAlignment.Right;

				//Draw border
				ReportExcel2.DrawBorders(oSheet, 7, 1, iRow, 24);

				//Build footer
				BuildFooter(iRow,1,6,"TOTAL:");
				BuildTotalSum(iRow);
			}
		}
		ArrayList arrListSum = new ArrayList();
		private void BuildTotalSum(int idx)
		{
			string strG = "",strH="", strI="",strJ="",strK="",strL="",strM="",strN="",strO="",strP="",strQ="",strR="",strS="",strT="",strU="";//,strV="",strW="",strX=""
			for(int x = 0; x < arrListSum.Count; x++)
			{
				string iSTART = arrListSum[x].ToString().Split('|')[0];
				string iEND = arrListSum[x].ToString().Split('|')[1];

				strG = BuildSumTotalSumItem("G",iSTART,iEND,strG);
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
//				strV = BuildSumTotalSumItem("V",iSTART,iEND,strV);
//				strW = BuildSumTotalSumItem("W",iSTART,iEND,strW);
//				strX = BuildSumTotalSumItem("X",iSTART,iEND,strX);
			}
			BuildFooter(idx,7,7,strG);		
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
//			BuildFooter(idx,22,22,strV);
//			BuildFooter(idx,23,23,strW);
//			BuildFooter(idx,24,24,strX);
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
				string bp = rsData.record(x,5);
				if(strBoPhanTitle != bp)
				{
					if(strBoPhanTitle != "")
					{						
						end = fromRow -1;
						arrListSum.Add(string.Format("{0}|{1}",start,end));

						//Build total
						BuildFooter(fromRow,4,6,string.Format("TOTAL {0}:",strBoPhanTitle));				
						BuildFooter(fromRow,7,7,string.Format("=sum(G{1}:G{0})",end,start));
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
//						BuildFooter(fromRow,22,22,string.Format("=sum(V{1}:V{0})",end,start));
//						BuildFooter(fromRow,23,23,string.Format("=sum(W{1}:W{0})",end,start));
//						BuildFooter(fromRow,24,24,string.Format("=sum(X{1}:X{0})",end,start));
						fromRow++;
					}
					//instant new row
					object[,] data1 = new object[1, rsData.cols+17];				
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
				object[,] data = new object[1, rsData.cols+17];				

				//get a row
				for(int y = 1; y < rsData.cols-2 + stt;y++)
				{
					data[0,y] = rsData.record(x,y - stt);	
					if(y==6)
						data[0,21] = rsData.record(x,6);
					if(y==7)
						data[0,22] = rsData.record(x,7);
					if(y==8)
						data[0,23] = rsData.record(x,8);
				}
				
				string id = rsData.record(x,2);											
				
				//bind data min to row
				string sqlMin=string.Format("select muc_luongcoban,muc_trachnhiem,muc_kynang,muc_nhatro,muc_dochai,300000 as chuyencan from FILD03A " +
											"where SEQ_NO = (select Min(SEQ_NO) as seqMax from FILD03A where (DON_AP =0 or DON_AP is NULL )and EMP_ID = '{0}') "+
											"and EMP_ID = '{0}'", id);	
				Func.RecordSet rsDataMin = new Func.RecordSet(sqlMin,PublicFunction.C_con);
				
				for(int y = 0; y < rsDataMin.cols;y++)				
					data[0,y+6] = rsDataMin.record(0,y);				

				//bind data max to row	
				string sqlMax=string.Format("select muc_luongcoban,muc_trachnhiem,muc_kynang,muc_nhatro,muc_dochai,300000 as chuyencan , soconnho from FILD03A " +
					"where SEQ_NO = (select Max(SEQ_NO) as seqMax from FILD03A where (DON_AP =0 or DON_AP is NULL )and EMP_ID = '{0}') "+
					"and EMP_ID = '{0}'", id);	
				Func.RecordSet rsDataMax = new Func.RecordSet(sqlMax,PublicFunction.C_con);
				
				for(int y = 0; y < rsDataMax.cols;y++)
				{
					data[0,y + 13] = rsDataMax.record(0,y);	
					data[0,20] = rsDataMax.record(0,6);
				}

				//bind value STT
				if(isSTT)
					data[0,0] = iSTT;						
				
				//sum value total hoc viec
				data[0,12] = Convert.ToInt32(data[0,6]) + Convert.ToInt32(data[0,7]) + Convert.ToInt32(data[0,8]) + Convert.ToInt32(data[0,9]) + Convert.ToInt32(data[0,10]) + Convert.ToInt32(data[0,11]);

				//sum value total hien tai
				data[0,19] = Convert.ToInt32(data[0,13]) + Convert.ToInt32(data[0,14]) + Convert.ToInt32(data[0,15]) + Convert.ToInt32(data[0,16]) + Convert.ToInt32(data[0,17]) + Convert.ToInt32(data[0,18]);
				//format cell
				//data[0,4] = Convert.ToDateTime(data[0,4]).ToString("dd/MM/yyyy");
				data[0,4] = Convert.ToDateTime(data[0,4]).ToString("dd/MM/yyyy");
				DateTime s=Convert.ToDateTime(data[0,4]);
				if(s.Day>12)					
					data[0,4] = Convert.ToDateTime(data[0,4]).ToString("dd/MM/yyyy");
				else
					data[0,4] = Convert.ToDateTime(data[0,4]).ToString("MM/dd/yyyy");

				data[0,21] = Convert.ToString(data[0,21]);
				data[0,22] = Convert.ToString(data[0,22]);

				string t=Convert.ToString(data[0,23]);
				if(t.Length>6)
				{
					data[0,23] = Convert.ToDateTime(data[0,23]).ToString("dd/MM/yyyy");
					DateTime d=Convert.ToDateTime(data[0,23]);
					if(d.Day>12)					
						data[0,23] = Convert.ToDateTime(data[0,23]).ToString("dd/MM/yyyy");
					else
						data[0,23] = Convert.ToDateTime(data[0,23]).ToString("MM/dd/yyyy");
				}

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
					BuildFooter(fromRow,7,7,string.Format("=sum(G{1}:G{0})",end,start));
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
//					BuildFooter(fromRow,22,22,string.Format("=sum(V{1}:V{0})",end,start));
//					BuildFooter(fromRow,23,23,string.Format("=sum(W{1}:W{0})",end,start));
//					BuildFooter(fromRow,24,24,string.Format("=sum(X{1}:X{0})",end,start));
					fromRow++;
				}
			}
			return fromRow;
		}			
	}
}
