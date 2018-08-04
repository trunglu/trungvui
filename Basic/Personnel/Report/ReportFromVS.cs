using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using Basic;
using Basic.Function;
using C1.C1Excel;
using Func;
namespace GP8000.Personnel.Report
{
	/// <summary>
	/// Summary description for RPTTaCardComparison.
	/// </summary>
	public class ReportFromVS
	{
		public ReportFromVS()
		{
			//
			// TODO: Add constructor logic here
			//
		}		

		public void RPT2(C1XLBook book,C1.Win.C1FlexGrid.C1FlexGrid vs,string title,string filename)
		{
			//string ID="RPT1";
			book = new C1XLBook();			
		
			XLSheet sheet = book.Sheets[0];			
			FormatExcel.Init_Excel(sheet);			
			sheet.Name ="Sheet1";		

			XLStyle Title=FormatExcel.Get_Style(book,16,true,XLAlignVertEnum.Center,XLAlignHorzEnum.Center,true,false,"");
			XLStyle Caption=FormatExcel.Get_Style(book,10,true,XLAlignVertEnum.Center,XLAlignHorzEnum.Center,true,true,"");
			XLStyle StringN=FormatExcel.Get_Style(book,10,false,XLAlignVertEnum.Undefined,XLAlignHorzEnum.Undefined,false,false,"");
			XLStyle String=FormatExcel.Get_Style(book,10,false,XLAlignVertEnum.Undefined,XLAlignHorzEnum.Undefined,false,true,"");
			XLStyle Number=FormatExcel.Get_Style(book,10,false,XLAlignVertEnum.Undefined,XLAlignHorzEnum.Undefined,false,true,"#,##0.00");
			
			sheet.Columns[0].Width = 500;

			int r = 0,cols=0;
			ArrayList a=new ArrayList();
			for (int i=0;i<vs.Cols.Count;i++)
			{
				if(vs.Cols[i].Visible==true)
				{
					cols++;
					a.Add(i);
				}
			}
			sheet.MergedCells.Add(r,0,1,cols);
			sheet.Rows[r].Height=800;
			FormatExcel.Set_Cell(sheet[r,0],
				T_String.GetDataFromSQL("COM_N1","FILA01A"),Title);
			r++;
			sheet.MergedCells.Add(r,0,1,cols);
			sheet.Rows[r].Height=800;
			FormatExcel.Set_Cell(sheet[r,0],title,Title);
			r++;
			FormatExcel.Set_Cell(sheet[r,cols-6],PublicFunction.L_Get_RPT("RptTa",1)+":"+PublicFunction.A_UserID,StringN);
			r++;
			FormatExcel.Set_Cell(sheet[r,cols-6],PublicFunction.L_Get_RPT("RptTa",2)+":"+T_String.GetDate().ToString("yyyy/MM/dd HH:mm"),StringN);

			r++;
			for (int j=0;j<vs.Rows.Count;j++)
			{
				for (int i=0;i<a.Count;i++)
				{
					if (j==0)
						FormatExcel.Set_Cell(sheet[r,i],vs.Rows[j][(int)a[i]]+"",Caption);
					else
					{
						if(vs.Cols[(int)a[i]].DataType==typeof(DateTime))
							try
							{
								FormatExcel.Set_Cell(sheet[r,i], DateTime.Parse(vs.Rows[j][(int)a[i]]+"").ToString(vs.Cols[(int)a[i]].Format),String);
								sheet.Columns[i].Width = 1500;
							}
							catch{FormatExcel.Set_Cell(sheet[r,i],"",String);}
						else
						{
							if(vs.Cols[(int)a[i]].DataType==typeof(Boolean))
							{
								if(vs.GetDataDisplay(j,(int)a[i])+""!="True")
									FormatExcel.Set_Cell(sheet[r,i], "False",String);
								else
									FormatExcel.Set_Cell(sheet[r,i], "True",String);
							}
							else
							{
								if (vs.Cols[(int)a[i]].DataType==typeof(String))
									FormatExcel.Set_Cell(sheet[r,i], vs.GetDataDisplay(j,(int)a[i])+"",String);
								else
								{
//									FormatExcel.Set_Cell(sheet[r,i],"",String);
//									sheet[r,i].Value= T_String.IsNullTo00(vs.GetDataDisplay(j,(int)a[i]));
									FormatExcel.Set_Cell(sheet[r,i], vs.GetDataDisplay(j,(int)a[i])+"",String);
								}
									//FormatExcel.Set_Cell(sheet[r,i], vs.GetDataDisplay(j,(int)a[i])+"",Number);
							}
						}
					}
				}
				r++;
			}			
			sheet.Columns[1].Width = 1200;
			sheet.Columns[2].Width = 1000;
			sheet.Columns[3].Width = 3000;
			try
			{
				string fileName = Application.StartupPath + @"\\Reports\\"+filename+".xls";
				book.Save(fileName);				
				System.Diagnostics.Process.Start(fileName);
			}
			catch
			{
				MessageBox.Show("You must close "+filename+".xls file first!!!!!");
				return;
			}			
		}


		public void RPTta(C1XLBook book,string RPT_ID,string title,string wh)
		{
			//string ID="RPT1";
			book = new C1XLBook();			
		
			XLSheet sheet = book.Sheets[0];			
			FormatExcel.Init_Excel(sheet);			
			sheet.Name ="Sheet1";		

			XLStyle Title=FormatExcel.Get_Style(book,16,true,XLAlignVertEnum.Center,XLAlignHorzEnum.Center,true,false,"");
			XLStyle Caption=FormatExcel.Get_Style(book,10,true,XLAlignVertEnum.Center,XLAlignHorzEnum.Center,true,true,"");
			XLStyle StringN=FormatExcel.Get_Style(book,10,false,XLAlignVertEnum.Undefined,XLAlignHorzEnum.Undefined,false,false,"");
			XLStyle String=FormatExcel.Get_Style(book,10,false,XLAlignVertEnum.Undefined,XLAlignHorzEnum.Undefined,false,true,"");
			XLStyle INT=FormatExcel.Get_Style(book,10,false,XLAlignVertEnum.Undefined,XLAlignHorzEnum.Undefined,false,true,"#,###");
			XLStyle GIO=FormatExcel.Get_Style(book,10,false,XLAlignVertEnum.Undefined,XLAlignHorzEnum.Undefined,false,true,"#,###");
			XLStyle DOU=FormatExcel.Get_Style(book,10,false,XLAlignVertEnum.Undefined,XLAlignHorzEnum.Undefined,false,true,"#,###.##");
			
			
			string sql="";
			sql="Select * from FILE07B where RPT_ID=N'"+RPT_ID+"' and SHO_BT=1 ORDER BY SEQ_NO";
			Func.RecordSet rscon=new Func.RecordSet(sql,PublicFunction.C_con);
			sql= GET_SQL(rscon,wh);
			Func.RecordSet 	rs=new RecordSet(sql,PublicFunction.C_con);			
			try
			{
				if(rs.rows<=0)
					return;
			}
			catch{return;}
			int r = 0,cols=0;
			ArrayList a=new ArrayList();
			a.Add(0);		
			sheet.Columns[0].Width = 680;
			for (int i=0;i<rs.cols;i++)
			{				
				cols++;				
				a.Add(i);				
			}

			// tieu de
			sheet.MergedCells.Add(r,0,1,cols);
			sheet.Rows[r].Height=800;
			FormatExcel.Set_Cell(sheet[r,0],
				T_String.GetDataFromSQL("COM_N1","FILA01A"),Title);
			r++;
			sheet.MergedCells.Add(r,0,1,cols);
			sheet.Rows[r].Height=800;
			FormatExcel.Set_Cell(sheet[r,0],title,Title);
			r++;
			FormatExcel.Set_Cell(sheet[r,cols-2],PublicFunction.L_Get_RPT("RptTa",1)+":"+PublicFunction.A_UserID,StringN);
			r++;
			FormatExcel.Set_Cell(sheet[r,cols-2],PublicFunction.L_Get_RPT("RptTa",2)+":"+T_String.GetDate().ToString("yyyy/MM/dd HH:mm"),StringN);
			r++;
			FormatExcel.Set_Cell(sheet[r,0],"STT",Caption);
			for(int i=0;i<rscon.rows;i++)
			{				
				FormatExcel.Set_Cell(sheet[r,i+1],rscon.record(i,"COL_NM"),Caption);
				sheet.Columns[i+1].Width = T_String.IsNullTo0( rscon.record(i,"WID_VL"))* 17;
			}

			r++;

			//

			for(int i=0;i<rs.rows;i++)
			{
				FormatExcel.Set_Cell(sheet[r,0], i+1+"",INT);
				for(int c=0;c<rscon.rows;c++)
				{		
					int c1=c+1;
					switch (rscon.record(c,"TYP_ID")+"")
					{
						case "1":// DateTime
						{
							try
							{
								FormatExcel.Set_Cell(sheet[r,c1], DateTime.Parse(rs.record(i,c)+"").ToString("yyyy/MM/dd"),String);
							}
							catch{FormatExcel.Set_Cell(sheet[r,c1],"",String);}
							break;
						}						
						case "2":// boolean		
						{							
							if(rs.record(i,c)+""!="True")
								FormatExcel.Set_Cell(sheet[r,c1], "False",String);
							else
								FormatExcel.Set_Cell(sheet[r,c1], "True",String);
							break;
						}
						case "":
						{
							FormatExcel.Set_Cell(sheet[r,c1], rs.record(i,c),String);
							break;
						}
						case "3": // 00:00
						{
							FormatExcel.Set_Cell(sheet[r,c1], T_String.IsNullTo00(rs.record(i,c)).ToString("##:##"),String);
//							if(rscon.record(c,"SUM_BT")+""=="True")
//							{
//								a[c1]= T_String.CongTG(T_String.IsNullTo00(a[c1]+""),T_String.IsNullTo00(rs.record(i,c)));
//							}
							break;
						}
						case "4": // double
						{
							FormatExcel.Set_Cell(sheet[r,c1], T_String.IsNullTo00(rs.record(i,c)).ToString("#,###.##"),DOU);
							if(rscon.record(c,"SUM_BT")+""=="True")
							{
								a[c1]= T_String.IsNullTo00(a[c1]+"")+T_String.IsNullTo00(rs.record(i,c));
							}
							break;
						}
						case "5": // int
						{
							FormatExcel.Set_Cell(sheet[r,c1], T_String.IsNullTo00(rs.record(i,c)).ToString("#,###.##"),INT);
							if(rscon.record(c,"SUM_BT")+""=="True")
							{
								a[c1]= T_String.IsNullTo00(a[c1]+"")+T_String.IsNullTo00(rs.record(i,c));
							}
							break;
						}
					}					
				}
				r++;
				if(i+1==rs.rows) //dong cuoi
				{
					for(int c=0;c<rscon.rows;c++)
					{		
						int c1=c+1;
						if(rscon.record(c,"SUM_BT")+""=="True")
						{
							switch (rscon.record(c,"TYP_ID")+"")
							{					
							
									//							case "3": // 00:00
									//							{
									//								FormatExcel.Set_Cell(sheet[r,c1], T_String.IsNullTo00(a[c1]+"").ToString("##:##"),String);							
									//								break;
									//							}
								case "4": // double
								{
									FormatExcel.Set_Cell(sheet[r,c1], T_String.IsNullTo00(a[c1]+"").ToString("#,###.##"),DOU);								
									break;
								}
								case "5": // int
								{
									FormatExcel.Set_Cell(sheet[r,c1], T_String.IsNullTo00(a[c1]+"").ToString("#,###.##"),INT);								
									break;
								}
							}	
						}
					}

				}
			}

			


//			}			

			try
			{
				string fileName = Application.StartupPath + @"\\Reports\\TAPO_"+RPT_ID+".xls";
				book.Save(fileName);				
				System.Diagnostics.Process.Start(fileName);
			}
			catch
			{
				MessageBox.Show("You must close TAPO_"+RPT_ID+".xls file first!!!!!");
				return;
			}			
		}

		public string GET_SQL(Func.RecordSet rs,string where)
		{
			string sql="",wh="",sort="";
			for(int i=0;i<rs.rows;i++)
			{
				string s=T_String.GetDataFromSQL("SQL_DR","SYS_BS_TAPRINTOUT_GETCOLS","COL_ID='"+ rs.record(i,"COL_ID") +"'");
				if(sql!="") sql+=",";				
				if ( s!=null && s != ""  )// rs.record(i,"TAB_DR")=="" || rs.record(i,"TAB_DR")==null)
					sql+="(" + s+ ") " + rs.record(i,"COL_ID");
				else
					sql+=rs.record(i,"TAB_DR")+"."+rs.record(i,"COL_ID");
				if(rs.record(i,"SRT_BT")+""=="True")
				{
					if(sort!="") sort+=",";
					sort+=rs.record(i,"TAB_DR")+"."+rs.record(i,"COL_ID");
				}
				if(rs.record(i,"CON_C1")+""!="" &&  rs.record(i,"CON_D1")+""!="" ) // dieu kien 1
				{					
					wh+="and ("+rs.record(i,"TAB_DR")+"."+rs.record(i,"COL_ID")+" "+rs.record(i,"CON_C1")+" ";
					if(rs.record(i,"COL_ID")=="1") // datetime
						wh+="'"+ DateTime.Parse(rs.record(i,"CON_D1")+"").ToString("yyyy/MM/dd")+"'";
					else
					{
						if(rs.record(i,"COL_ID")=="2") // bit
						{
							if(rs.record(i,"CON_D1")+""=="1")
								wh+=rs.record(i,"CON_D1");
							else
							{
								wh+=rs.record(i,"CON_D1")+" or "+rs.record(i,"TAB_DR")+"."+rs.record(i,"COL_ID")+" is null" ;
							}
						}
						else // char
						{
							if(rs.record(i,"CON_C1")=="like")
								wh+="N'%"+rs.record(i,"CON_D1")+"%'";
							else
								wh+="N'"+rs.record(i,"CON_D1")+"'";
						}
					}
					if(rs.record(i,"CON_C2")+""!="" &&  rs.record(i,"CON_D2")+""!="" ) //dieu kien 2
					{
						wh+=" "+rs.record(i,"AND_OR")+" ";
						wh+="("+rs.record(i,"TAB_DR")+"."+rs.record(i,"COL_ID")+" "+rs.record(i,"CON_C2")+" ";
						if(rs.record(i,"COL_ID")=="2") // bit
						{
							if(rs.record(i,"CON_D2")+""=="1")
								wh+=rs.record(i,"CON_D2");
							else
							{
								wh+=rs.record(i,"CON_D2")+" or "+rs.record(i,"TAB_DR")+"."+rs.record(i,"COL_ID")+" is null" ;
							}
						}
						else // char
						{
							if(rs.record(i,"CON_C2")=="like")
								wh+="N'%"+rs.record(i,"CON_D2")+"%'";
							else
								wh+="N'"+rs.record(i,"CON_D2")+"'";
						}
					}
					wh+=")";

				}
			}
			string from;
			from= " from FILC06A,FILB01A where FILC06A.EMP_ID=FILB01A.EMP_ID ";
			sql="select "+sql+from+wh +" and "+ where;
			if(sort!="")
				sql+=" order by " + sort;
			return sql;

		}

	}
}
