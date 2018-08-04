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
using Basic.Form;
using Basic.Function;
namespace GP8000.Function
{
	/// <summary>
	/// Summary description for TaCardData.
	/// </summary>
	public class TaCardData
	{
		public string table;
		public TextBox err;
		public Func.RecordSet Set,rsTypeShift;
		public TaCardData()
		{
			//
			// TODO: Add constructor logic here
			//
		}
		

		
		
		#region AttStaff
		public void AttStaff(string EMP_ID,DateTime d1,SqlConnection con,string DEP_ID,string EMP_I1)
		{
			string sql="";
			sql="Select LOC_BT,LOC_B1 from FILC06A where EMP_ID=N'"+EMP_ID+"' and ATT_DT='"+d1.ToString("yyyy/MM/dd")+"'";
			Func.RecordSet rs=new Func.RecordSet(sql,con);		
			if(rs.rows>0)
			{
				if (rs.record(0, "LOC_BT") + "" == "True" || rs.record(0, "LOC_B1") + "" == "True")
					return;
				// Thu sua, ko xoa tung nguoi khi chuyen ma xoa toan bo truoc khi insert tu bang tam vao, tranh TH mat du lieu neu bi loi giua chung
				//else 
				//{
				//    sql="Delete from FILC06A where EMP_ID=N'"+EMP_ID+"' and ATT_DT='"+d1.ToString("yyyy/MM/dd")+"'";
				//    try
				//    {
				//        PublicFunction.SQL_Execute(sql,con);
				//    }
				//    catch(SqlException ex)
				//    {
				//        err.Text+= ex.Message;
				//    }
				//}
			}

			string Shift=GetShift(EMP_ID,d1,con);			
			if(Shift==null)
			{
				//				sql="Insert Into ["+table+"](EMP_ID,ATT_DT,DEP_ID,SHI_ID)";
				//				sql+=" Values("
				//					+"N'"+EMP_ID+"',"
				//					+"'"+d1.ToString("yyyy/MM/dd")+"',N'"+DEP_ID+"',"
				//					+"N'NoShift')";
				//				PublicFunction.SQL_Execute(sql,con,true);
				InsertNoShift(EMP_ID,"NoShift",d1,con,DEP_ID,EMP_I1);
				return;
			}
			sql="Select * from FILC02B where SHI_ID=N'"+Shift+"' ORDER BY SEQ_NO";			
			Func.RecordSet rsca=new Func.RecordSet(sql,con);

			if(Shift=="00" && rsca.rows<=0)
			{
				//				sql="Insert Into ["+table+"](EMP_ID,ATT_DT,DEP_ID,SHI_ID)";
				//				sql+=" Values("
				//					+"N'"+EMP_ID+"',"
				//					+"'"+d1.ToString("yyyy/MM/dd")+"',N'"+DEP_ID+"',"
				//					+"N'"+Shift+"')";
				//				PublicFunction.SQL_Execute(sql,con,true);
				InsertNoShift(EMP_ID,"00",d1,con,DEP_ID,EMP_I1);
			}
			else
			{
				AttStaffByShift(EMP_ID,Shift,d1,con,DEP_ID,EMP_I1,rsca);
			}
		}

		private void InsertNoShift(string EMP_ID,string SHI_NM,DateTime d1,SqlConnection con,string DEP_ID,string EMP_I1)
		{
			string sql="Select CRD_TM,DAT_TM from FILC01A where EMP_ID=N'"+EMP_ID
				+"' and CRD_DT='"+d1.ToString("yyyy/MM/dd")+"' and (YSD_BT is null or YSD_BT=0)"
				+" ORDER BY CRD_TM ";
			Func.RecordSet rsdata=new Func.RecordSet(sql,con);

			string values="",Insert="";
			Insert="Insert Into ["+table+"](EMP_ID,ATT_DT,DEP_ID,EMP_I1,SHI_ID,NIG_TM,"
				+"ONN_01,OFF_01,ONN_02,OFF_02,ONN_03,OFF_03,ONN_04,OFF_04,ONN_05,OFF_05,"
				+"ONN_06,OFF_06,OFF_07,ONN_07,OFF_08,ONN_08,ONN_09,OFF_09,ONN_10,OFF_10"
				+") Values";

			values="N'"+EMP_ID+"',"
				+"'"+d1.ToString("yyyy/MM/dd")+"',N'"+DEP_ID+"',N'"+EMP_I1+"',"
				+"N'"+SHI_NM+"',-1";				
			for(int i=1;i<=10;i++)
			{			
				if((i*2)-2>=rsdata.rows)					
					values+=",0";
				else
					values+=","+rsdata.record((i*2)-2,"CRD_TM");	
				if((i*2)-1>=rsdata.rows)					
					values+=",0";
				else
					values+=","+rsdata.record((i*2)-1,"CRD_TM");	
			}
			sql=Insert + "("+values+")";
			try
			{
				PublicFunction.SQL_Execute(sql,con);	
			}
			catch(SqlException ex)
			{
				err.Text+= ex.Message;
			}
		}
		#endregion
		#region GetShift
		private string GetShift(string EMP_ID,DateTime d1,SqlConnection con)
		{
			string Shift=T_String.GetDataFromSQL("DAY_"+d1.Day.ToString("00"),"FILC03A","EMP_ID=N'"
				+EMP_ID+"' and YYY_MM=N'"+d1.ToString("yyyyMM")+"'",con);
			if(Shift+""=="")
				return null;			
			return Shift;
		}
		#endregion
		#region AttStaffByShift
		private void AttStaffByShift(string EMP_ID,string SHI_ID,DateTime d1,SqlConnection con,string DEP_ID,string EMP_I1,Func.RecordSet rsca )
		{		

			double MIN=T_String.IsNullTo0(T_String.GetDataFromSQL("MIN_HR","FILC02A","SHI_ID=N'"+SHI_ID+"'",con));

			string sql="Select CRD_TM,DAT_TM from FILC01A where EMP_ID=N'"+EMP_ID
				+"' and CRD_DT='"+d1.ToString("yyyy/MM/dd")+"' and (YSD_BT is null or YSD_BT=0)"
				+" and CRD_TM>"+MIN+" ORDER BY CRD_TM ";
			Func.RecordSet rsdata=new Func.RecordSet(sql,con);
			if(rsca.rows<=0)
				return;

			ArrayList Ca=new ArrayList();
			ArrayList ATT=new ArrayList();
			double maxca=0;
			int cadem=0;
			for(int i=0;i<rsca.rows;i++)
			{
				Ca.Add(rsca.record(i,"ONN_TM"));
				Ca.Add(rsca.record(i,"OFF_TM"));
				double c1=IsN(rsca.record(i,"ONN_TM"));
				double c2=IsN(rsca.record(i,"ONN_TM"));
				if(cadem==0 && (rsca.record(i,"TYP_ID")=="ATT_HR" || rsca.record(i,"TYP_ID")=="NIG_HR") )
				{
					if(c1>maxca)
						maxca=c1;
					else
						cadem=1;
					if(c2>maxca)
						maxca=c2;
					else
						cadem=1;
				}
			}
			Ca.Add(0);
			Ca.Add(0);
			Ca.Add(0);
			Ca.Add(0);
			Ca.Add(0);
			Ca.Add(0);
			Ca.Add(0);
			Ca.Add(0);
			int dem=0;// vi tri quet
			int tg=0;
			int count=0; //so lan quet the
			int tcqd=0;		
			double NIG_TM=0;
			double OVOT=T_String.IsNullTo0(T_String.GetDataFromSQL("MAX_HR","FILC02A","SHI_ID=N'"+SHI_ID+"'",con));			
			Boolean bif=false;
			Boolean add12=false;
			Boolean add13=false;
			int addtg=0;
			while(dem<Ca.Count || tg<rsdata.rows)
			{
				if(tg>=rsdata.rows )
					break;	
				if (dem >= Ca.Count)
					break;
				int t1=IsN(rsdata.record(tg,"CRD_TM"));
				string DAT_TM=rsdata.record(tg,"DAT_TM");
				int t2=IsN(rsdata.record(tg+1,"CRD_TM"));
				int c1=IsN(Ca[dem]+"");
				int c2;
				if(OVOT!=0 && tcqd>0 && OVOT<t1)
					break;
				if(dem+1<Ca.Count)
					c2=IsN(Ca[dem+1]+"");
				else
					c2=IsN(Ca[dem]+"");
				//=========Thu them gio quet the tu dong luc an com khi xet option [MEAL_ON]=1, QuangViet TG
				if(tg>0 && PublicFunction.CUS_ID  =="51" )//&& !bif)
				{
					Boolean is12=true;
					int itg;
					//truong hop them 1300
					if(IsN(rsdata.record(tg,"CRD_TM"))<=1230 && IsN(rsdata.record(tg,"CRD_TM"))>=1200)
					{
						for(int i1=0 ;i1<rsdata.rows ;i1++)
						{
							itg=IsN(rsdata.record(i1,"CRD_TM"));
							if(itg>1230 && itg<1305) is12=false;
							if(itg !=IsN(rsdata.record(tg,"CRD_TM")) && itg>=1200 && itg<=1230) is12=false;
						}
						bif=IsN(rsdata.record(0,"CRD_TM"))<1200 && IsN(rsdata.record(rsdata.rows-1,"CRD_TM"))>1300;
						bif=bif & is12;						
						if(bif)
						{
							itg=IsN(rsdata.record(0,"CRD_TM").Substring(rsdata.record(0,"CRD_TM").Length -1,1));
							add13=true;
							if(itg==0)
								addtg=1300;
							else
								addtg=1200+60-itg;
							//ATT.Add(1200+60-itg);
						}
					}					
					//truong hop them 1200
//					if(!bif)
//					{
					if(IsN(rsdata.record(tg,"CRD_TM"))>1230 && IsN(rsdata.record(tg,"CRD_TM"))<=1305)
					{
						is12=true;
						for(int i1=0 ;i1<rsdata.rows ;i1++)
						{
							itg=IsN(rsdata.record(i1,"CRD_TM"));
							if(itg>=1200 && itg<1230) is12=false;
							if(itg !=IsN(rsdata.record(tg,"CRD_TM")) && itg>1230 && itg<=1305) is12=false;
						}						
						bif=IsN(rsdata.record(0,"CRD_TM"))<1200 && IsN(rsdata.record(rsdata.rows-1,"CRD_TM"))>1300;
						bif=bif & is12;						
						if(bif)
						{
							itg=IsN(rsdata.record(0,"CRD_TM").Substring(rsdata.record(0,"CRD_TM").Length -1,1));
							add12=true;
							addtg=1200+itg;
							//ATT.Add(1200+itg);
						}
					}

					//truong hop them 1800
					if(IsN(rsdata.record(tg,"CRD_TM"))<=1745 && IsN(rsdata.record(tg,"CRD_TM"))>=1730)
					{
						is12=true;
						for(int i1=0 ;i1<rsdata.rows ;i1++)
						{
							itg=IsN(rsdata.record(i1,"CRD_TM"));
							if(itg>1745 && itg<1805) is12=false;
							if(itg !=IsN(rsdata.record(tg,"CRD_TM")) && itg>=1730 && itg<=1745) is12=false;
						}
						bif=IsN(rsdata.record(0,"CRD_TM"))<=1630 && IsN(rsdata.record(rsdata.rows-1,"CRD_TM"))>=1805;
						bif=bif & is12;						
						if(bif)
						{
							itg=IsN(rsdata.record(0,"CRD_TM").Substring(rsdata.record(0,"CRD_TM").Length -1,1));
							add13=true;
							if(itg==0)
								addtg=1800;
							else
								addtg=1700+60-itg;
							//ATT.Add(1200+60-itg);
						}
					}
					//truong hop them 1730									
					if(IsN(rsdata.record(tg,"CRD_TM"))>1745 && IsN(rsdata.record(tg,"CRD_TM"))<=1805)
					{
						is12=true;
						for(int i1=0 ;i1<rsdata.rows ;i1++)
						{
							itg=IsN(rsdata.record(i1,"CRD_TM"));
							if(itg>=1700 && itg<1745) is12=false;
							if(itg !=IsN(rsdata.record(tg,"CRD_TM")) && itg>1745 && itg<=1805) is12=false;
						}						
						bif=IsN(rsdata.record(0,"CRD_TM"))<=1630 && IsN(rsdata.record(rsdata.rows-1,"CRD_TM"))>=1805;
						bif=bif & is12;						
						if(bif)
						{
							itg=IsN(rsdata.record(0,"CRD_TM").Substring(rsdata.record(0,"CRD_TM").Length -1,1));
							add12=true;
							addtg=1730+itg;
							//ATT.Add(1200+itg);
						}
					}
				}
				//END MEAL_ON
				if(t1==c1 || (dem+1)==Ca.Count || c1==0)  // dung thoi gian
				{
					//if(rsdata.rows<=tg+1 && (dem%2)==0 && (count%2)==1  && count!=0 && ( t2>c1 || t2==0) )
					//trungthu
//					if( (ATT.Count%2)!=(count%2))
//					{
//						ATT.Add(0);
//						dem++;	
//					}
					if(add12 ) 
					{
						ATT.Add(addtg);
						add12=false;						
					}
					ATT.Add(t1);
					if(add13 ) 
					{
						ATT.Add(addtg);
						add13=false;						
					}					
					NIG_TM=TangQuaDem(EMP_ID,DAT_TM,tcqd,con,t1,NIG_TM,ATT);
					count++;
					dem++;
					tg++;
				}
				else
				{
					if(t1<c1 ) // < kiem tra thoi gian crd ke tiep [di som]
					{
						//trungthu
//						if( (ATT.Count%2)!=(count%2))
//						{
//							ATT.Add(0);
//							dem++;	
//						}
						//end
						if(add12 ) 
						{
							ATT.Add(addtg);
							add12=false;						
						}
						ATT.Add(t1);
						//them gio com tu dong
						if(add13 ) 
						{
							ATT.Add(addtg);
							add13=false;							
						}
						NIG_TM=TangQuaDem(EMP_ID,DAT_TM,tcqd,con,t1,NIG_TM,ATT);
						count++;
						dem++;
						tg++;
					}
					else
					{						
						if(Math.Abs(t1-c1)<Math.Abs(t1-c2)) // dung thoi gian
						{
							if(rsdata.rows<=tg+1) // lan quet the cuoi trong ngay
							{
								//trungthu
//								if( (ATT.Count%2)!=(count%2))
//								{
//									ATT.Add(0);
//									dem++;	
//								}
								if(add12 ) 
								{
									ATT.Add(addtg);
									add12=false;						
								}
								ATT.Add(t1);
								if(add13) 
								{
									ATT.Add(addtg);
									add13=false;									
								}
								NIG_TM=TangQuaDem(EMP_ID,DAT_TM,tcqd,con,t1,NIG_TM,ATT);
								count++;
								dem++;
								tg++;								
							}		
							else
							{
								//trungthu
//								if( (ATT.Count%2)!=(count%2))
//								{
//									ATT.Add(0);
//									dem++;	
//								}
								if(add12 ) 
								{
									ATT.Add(addtg);
									add12=false;						
								}
								ATT.Add(t1);
								if(add13) 
								{
									ATT.Add(addtg);
									add13=false;									
								}
								NIG_TM=TangQuaDem(EMP_ID,DAT_TM,tcqd,con,t1,NIG_TM,ATT);
								count++;
								dem++;
								tg++;
							}
						}
						else // kiem tra  tg ca ke tiep
						{
							if(dem<rsca.rows)
							{
								int k=((int)(dem/2));
								string h="ONN_BT";
								if(dem%2!=0)
									h="OFF_BT";
								//trungthu
//								if(rsca.record(k,h)=="True")
//									ATT.Add(0);
							}
							dem++;							
						}
					}
				}
				if(rsdata.rows<=tg && tcqd==0) // tinh qua dem
				{
					if((count%2)==1 || cadem==1) // qua dem
					{	
						int d=0,dd=dem;
						while(d<Ca.Count)
						{
							int m1=IsN(Ca[d]+"");
							int m2;
							if(d+1<Ca.Count)
								m2=IsN(Ca[d+1]+"");
							else
								m2=IsN(Ca[d]+"");
							if(m2!=0 && m2<m1 )
							{
								d++;
								dd=d;
								break;
							}
							d++;
						}
						if(d==dd && d!=Ca.Count)
						{							
							sql="Select CRD_TM,DAT_TM from FILC01A where EMP_ID=N'"+EMP_ID
								+"' and CRD_DT='"+d1.AddDays(1).ToString("yyyy/MM/dd")+"' ORDER BY CRD_TM";
							rsdata=new Func.RecordSet(sql,con);
							if (rsdata.rows<=0)
								break;
							while (dem<dd)
							{
								if(dem<rsca.rows)
								{
									int k=((int)(dem/2));
									string h="ONN_BT";
									if(dem%2!=0)
										h="OFF_BT";
									//trungthu
//									if(rsca.record(k,h)=="True")										
//										ATT.Add(0);
								}								
								dem++;		
							}
							tg=0;
							tcqd=1;

						}
					}
				}
			}
			string values="",Insert="";
			Insert="Insert Into ["+table+"](EMP_ID,ATT_DT,DEP_ID,EMP_I1,SHI_ID,NIG_TM,"
				+"ONN_01,OFF_01,ONN_02,OFF_02,ONN_03,OFF_03,ONN_04,OFF_04,ONN_05,OFF_05,"
				+"ONN_06,OFF_06,OFF_07,ONN_07,OFF_08,ONN_08,ONN_09,OFF_09,ONN_10,OFF_10"
				+") Values";

			values="N'"+EMP_ID+"',"
				+"'"+d1.ToString("yyyy/MM/dd")+"',N'"+DEP_ID+"',N'"+EMP_I1+"',"
				+"N'"+SHI_ID+"','"+NIG_TM+"'";				
			for(int i=1;i<=10;i++)
			{			
				if((i*2)-2>=ATT.Count)					
					values+=",0";
				else
					values+=","+ATT[(i*2)-2];	
				if((i*2)-1>=ATT.Count)					
					values+=",0";
				else
					values+=","+ATT[(i*2)-1];
			}
			sql=Insert + "("+values+")";
//			SqlConnection conat=new SqlConnection(PublicFunction.C_con.ConnectionString);
//			conat.Open();
			try
			{
				PublicFunction.SQL_Execute(sql,con);	
			}
			catch(SqlException ex)
			{
				err.Text+= ex.Message;
			}
			//			sql="update ["+table+"] set EMP_I1=N'"+EMP_I1+"' where EMP_ID=N'"+EMP_ID+"' and ATT_DT='"+d1.ToString("yyyy/MM/dd")+"'";
			//			PublicFunction.SQL_Execute(sql,con);	
			TaAttendance tm=new TaAttendance(EMP_ID,d1.ToString("yyyy/MM/dd"),con,Ca,ATT,SHI_ID,rsca,Set,rsTypeShift);					
			tm.tb=table;
			tm.NIG_TM=NIG_TM;
			//tm.rsType=rsType;
			tm.UpdateSql();
		}

		#endregion		
		private double TangQuaDem(string EMP_ID,string DAT_TM,int tcqd,SqlConnection con,double t1,double NIG_TM,ArrayList att)
		{
			if(tcqd>0)
			{
				string sql="Update FILC01A set YSD_BT=1 where EMP_ID=N'"+EMP_ID+"' and DAT_TM=N'"+DAT_TM+"'";
				PublicFunction.SQL_Execute(sql,con);
				//				if(NIG_TM==-1)
				//					return t1;
				//				else
				//					return NIG_TM;
				if(NIG_TM==0)
					return att.Count ;
				else
					return NIG_TM; //0; Thu sua cho ca dem quet the hon 2 lan
			}
			return 0;
		}
		
		#region Func
		public  int IsN(Object st1)
		{		
			try
			{ 
				string st=st1+""; 
				if (st+""=="")
					return 0;			
				return Int32.Parse(st=st.Replace(",",""));
			}
			catch(Exception){return 0;}
		}	
		public  Double IsD(Object st1)
		{		
			try
			{ 
				string st=st1+""; 
				if (st+""=="")
					return 0;			
				return Double.Parse(st=st.Replace(",",""));
			}
			catch(Exception){return 0;}
		}	
		#endregion
	}
}
