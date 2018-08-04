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
	/// Summary description for TaAttendance.
	/// </summary>	
	public class TaAttendance
	{
		public ArrayList Ca;
		public ArrayList ATT;
		public string SHI_ID,EMP_ID,ATT_DT,NOT_DR,NOT_D1;
		public double LEA_H1;
		public string LEA_I1;
		public string NOT_DD;
		public double LEA_H2;
		public string LEA_I2;
		public double LEA_H3;
		public double OTR_HR;
		public string LEA_I3;
		public double NIG_TM;
		public string tb;
		public Func.RecordSet rsca;
		public Func.RecordSet rsTypeShift;
		public Func.RecordSet SetTA;		
		public ArrayList Name;
		public ArrayList Data;
		public SqlConnection con;
		public double LAT_MN=0;
		public int LAT_TM=0;
		public double EAR_MN=0;
		public int EAR_TM=0;

		public double LEA_OUT=0;
		public double ABS_MN=0;
		public int ABS_TM=0;

		public double ATT_MAX=0;
		public double NIG_MAX=0;
		
		public string ToDayDT;
		public DateTime ToDayDTTime=DateTime.Now;
		public Func.RecordSet thaisan;
		public double giothaisan=0,CON_MAN=0;
		public Boolean Vacate=false;
		public TextBox err;
		

		public TaAttendance(string EMP_ID,string ATT_DT,SqlConnection con,ArrayList Ca,ArrayList ATT,string SHI_ID,Func.RecordSet rsca,Func.RecordSet SetTA,Func.RecordSet rsTypeShift)
		{
			this.EMP_ID=EMP_ID;
			this.ATT_DT=ATT_DT;
			this.con=con;
			this.Ca=Ca;
			this.ATT=ATT;
			this.SHI_ID=SHI_ID;
			this.rsca=rsca;
			this.SetTA=SetTA;
			this.rsTypeShift=rsTypeShift;
			ToDayDT=T_String.GetDate(con).ToString("yyyy/MM/dd");			

			NOT_DR="";
			this.Data=new ArrayList();
			this.Name=new ArrayList();			
			double tam=0;
			for(int i=0;i<rsTypeShift.rows;i++)
			{
				Name.Add(rsTypeShift.record(i,0));
				Data.Add(tam);
			}
			string sql="Select * from FILC09A where EMP_ID=N'"+EMP_ID+"' and '"+ATT_DT+"' between MAN_ST and "
				+ " MAN_ED";//>='"+ATT_DT+"'";
			thaisan =new Func.RecordSet (sql,con);
			if(thaisan.rows>0)
			{
				giothaisan=100;
				CON_MAN=IsD(thaisan.record(0,"CON_HR"));
			}
			string  TIM_02=T_String.GetDataFromSQL("TIM_02","FILC02A","SHI_ID=N'"+SHI_ID+"'",con);
			if(TIM_02=="True")
			{
				ArrayList ATT1=new ArrayList();
				for(int i=0;i<ATT.Count;i++)
				{
					if(IsD(ATT[i]+"")!=0)
						ATT1.Add(ATT[i]);
				}				
				if(ATT1.Count>2)
				{
					this.ATT=new ArrayList();
					this.ATT.Add(ATT1[0]);
					this.ATT.Add(ATT1[ATT1.Count-1]);
				}
			}
		}

		public void Add(string FName,double hr)
		{
			int i=Name.IndexOf(FName);
			Data[i]=T_String.CongTG(IsN(Data[i]+""),hr) ;
		}

		public double GetData(string FName)
		{
			int i=Name.IndexOf(FName);
			return IsN(Data[i]+"");
		}

		public void UpdateSql()
		{			
			Boolean A= RoundTime();
			Get_ATT_HR();	
			string sql1="";
			string sql="Select *,LEA_NM from FILC04A a,FILA15A b where a.LEA_ID=b.LEA_ID and EMP_ID=N'"
				+EMP_ID+"' and STR_DT<='"+ATT_DT+"' and END_DT>='"+ATT_DT+"'";
			Func.RecordSet phep=new Func.RecordSet(sql,con);
			sql="Select * from FILC05A where EMP_ID=N'"
				+EMP_ID+"' and STR_DT<='"+ATT_DT+"' and END_DT>='"+ATT_DT+"'";
			Func.RecordSet OutTrip=new Func.RecordSet(sql,con);
			GetPhep(phep);
			GetOutTrip(OutTrip);
			Round();
			GetNote();
			double ADD_H1=T_String.IsNullTo00(T_String.GetDataFromSQL("ADD_H1","FILC02A","SHI_ID=N'"+SHI_ID+"'",con));
			double ADD_H2=T_String.IsNullTo00(T_String.GetDataFromSQL("ADD_H2","FILC02A","SHI_ID=N'"+SHI_ID+"'",con));
			double CON_H1=T_String.IsNullTo00(T_String.GetDataFromSQL("CON_H1","FILC02A","SHI_ID=N'"+SHI_ID+"'",con));
			double CON_H2=T_String.IsNullTo00(T_String.GetDataFromSQL("CON_H2","FILC02A","SHI_ID=N'"+SHI_ID+"'",con));
			// Cong them gio cong

			//

			if(NOT_DD+""!="")
				NOT_DR=NOT_DD+"; "+NOT_DR;
			if(thaisan.rows>0)
			{
				NOT_DR="Maternity;"+NOT_DR;
//				LAT_MN=0;
//				LAT_TM=0;
//				EAR_MN=0;
//				EAR_TM=0;
			}
			
//			if(tb=="FILC06A")
//				sql="Update FILC06A set ";
//			else
//				sql="Update FILC06B set ";
			sql="Update ["+tb+"] set ";
			double WRK_HR=0;
			for(int i=0;i<Name.Count;i++)
			{				
				if(Name[i]+""=="ATT_HR")
				{
					if(ATT_MAX>0)
					{
						if(ADD_H1>0 && (Double)Data[i]>CON_H1)
						{
							ATT_MAX=T_String.CongTG(ATT_MAX,ADD_H1);
							if((Double)Data[i]>0)
								Data[i]=T_String.CongTG(ADD_H1,(Double)Data[i]);
						}
						WRK_HR=T_String.CongTG(WRK_HR,(Double)Data[i] );//T_String.IsNullTo00(Data[i]+""));
						int tam=(int)T_String.CongTG(T_String.IsNullTo0(Data[i]+""),OTR_HR);
						if(sql1!="") sql1+=",";
						sql1+="ATT_DY="+  T_String.DT_HourMinConvertToHour(tam)/ T_String.DT_HourMinConvertToHour((int) ATT_MAX); 
					}
					else
					{
						if(sql1!="") sql1+=",";
						sql1+="ATT_DY=0";
					}
				}
				else
				{
					if(Name[i]+""=="NIG_HR" && (Double)Data[i]>CON_H2 )			
					{
						if( NIG_MAX>0)
						{
							if(ADD_H2>0)
							{
								NIG_MAX=T_String.CongTG(NIG_MAX,ADD_H2);
								if((Double)Data[i]>0)
									Data[i]=T_String.CongTG(ADD_H2,(Double)Data[i]);
							}
							WRK_HR=T_String.CongTG(WRK_HR,(Double)Data[i]);
							int tam=(int)T_String.CongTG(T_String.IsNullTo0(Data[i]+""),OTR_HR);
							if(sql1!="") sql1+=",";
							sql1+="NIG_DY="+  T_String.DT_HourMinConvertToHour(tam)/T_String.DT_HourMinConvertToHour((int)NIG_MAX); 						
						}
						else
						{
							if(sql1!="") sql1+=",";
							sql1+="NIG_DY=0";
						}
					}
				}
				if(sql1!="") sql1+=",";
				sql1+=Name[i]+"="+Data[i];	
			}
			sql=sql+sql1;
			if(ABS_TM>0 || LAT_MN>=IsD(SetTA.record(0,"ASB_MN")))
			{
				double max=T_String.CongTG(ATT_MAX,NIG_MAX);
				ABS_MN=T_String.TruTG(max,WRK_HR);
				ABS_MN=T_String.TruTG(ABS_MN,LEA_H1);
				ABS_MN=T_String.TruTG(ABS_MN,LEA_H2);
				ABS_MN=T_String.TruTG(ABS_MN,LEA_H3);
				ABS_MN=T_String.TruTG(ABS_MN,OTR_HR);
				if(ABS_TM==0)
				{
					NOT_DR+="Absent"+";";
					ABS_TM++;
					NOT_DR=NOT_DR.Replace("Late;","");
					LAT_MN=0;
					LAT_TM=0;
				}
			}
			sql+=",NOT_DR=N'"+NOT_DR+"'";			
			sql+=",NOT_D1=N'"+NOT_D1+"'";
			sql+=",LAT_MN=N'"+LAT_MN+"'";
			sql+=",LAT_TM=N'"+LAT_TM+"'";
			sql+=",EAR_MN=N'"+EAR_MN+"'";
			sql+=",EAR_TM=N'"+EAR_TM+"'";
			sql+=",ABS_MN=N'"+ABS_MN+"'";
			sql+=",ABS_TM=N'"+ABS_TM+"'";
			sql+=",OTR_HR="+OTR_HR.ToString("#0")+"";			

			sql+=",LEA_H1="+LEA_H1.ToString("#0")+"";
			sql+=",LEA_I1=N'"+LEA_I1+"'";
			sql+=",LEA_H2="+LEA_H2.ToString("#0")+"";
			sql+=",LEA_I2=N'"+LEA_I2+"'";
			sql+=",LEA_H3="+LEA_H3.ToString("#0")+"";
			sql+=",LEA_I3=N'"+LEA_I3+"'";
//			if(A)
//				for(int i=1;i<=10;i++)
//				{			
//					if((i*2)-2>=ATT.Count)					
//						break;
//					else
//						sql+=",ONN_"+i.ToString("00")+"="+ATT[(i*2)-2];	
//					if((i*2)-1>=ATT.Count)					
//						break;
//					else
//						sql+=",OFF_"+i.ToString("00")+"="+ATT[(i*2)-1];
//				}
	
			sql+=" where EMP_ID=N'"+EMP_ID+"' and ATT_DT='"+ATT_DT+"'";			
			try
			{
				PublicFunction.SQL_Execute(sql,con);
			
			}catch(SqlException ex)
			{
				if(err!=null)
					err.Text+= ex.Message;
				else
					MessageBox.Show(ex.Message);
			}
//			if((NOT_DR+"").IndexOf("Absent")>=0 && PublicFunction.absent>0)
//				AbsentToVacate();					
		}

		public static void AbsentToVacate(string EMP_ID,string ATT_DT,SqlConnection con,string table)
		{
			if (PublicFunction.absent<=0)
				return;
			int vat=0;
			DateTime dt=DateTime.Parse(ATT_DT);
			DateTime dtmin=DateTime.Parse(ATT_DT),dtmax=DateTime.Parse(ATT_DT);
			while(true)
			{				
				string sql="select EMP_ID,NOT_DR,SHI_ID from ["+table+"] where EMP_ID=N'"+EMP_ID+"' and ATT_DT='"+dt.ToString("yyyy/MM/dd")+"'";					
				Func.RecordSet rs=new Func.RecordSet(sql,con);				
				if(rs.rows>0  )
				{			
					if( (rs.record(0,"NOT_DR")+"").IndexOf("Absent")>=0 )
					{
						vat++;
						dtmin=dt;
					}
					else
					{
						if(rs.record(0,"SHI_ID")!="00")
							break;
					}
				}
				else
				{						
					sql="select EMP_ID,NOT_DR,SHI_ID  from FILC06A where EMP_ID=N'"+EMP_ID+"' and ATT_DT='"+dt.ToString("yyyy/MM/dd")+"'";					
					rs=new Func.RecordSet(sql,con);
					if(rs.rows>0 )
					{
						if( (rs.record(0,"NOT_DR")+"").IndexOf("Absent")>=0 )
						{
							vat++;
							dtmin=dt;
						}
						else
						{
							if(rs.rows>0 && rs.record(0,"SHI_ID")!="00")						
								break;
						}
					}	
					else
						break;
				}
				if(vat>=PublicFunction.absent)
				{
					dtmin=dt;
					break;
				}
				dt=dt.AddDays(-1);
			}
			dt=DateTime.Parse(ATT_DT).AddDays(1);
			while(true)
			{
				if(vat>=PublicFunction.absent)
				{
					dtmax=dt;
					break;
				}
				string sql="select EMP_ID,NOT_DR,SHI_ID  from ["+table+"] where EMP_ID=N'"+EMP_ID+"' and ATT_DT='"+dt.ToString("yyyy/MM/dd")+"'";					
				Func.RecordSet rs=new Func.RecordSet(sql,con);				
				if(rs.rows>0  )
				{			
					if( (rs.record(0,"NOT_DR")+"").IndexOf("Absent")>=0 )
					{
						vat++;
						dtmax=dt;
					}
					else
					{
						if(rs.record(0,"SHI_ID")!="00")
							break;
					}
				}
				else
				{						
					sql="select EMP_ID,NOT_DR,SHI_ID  from FILC06A where EMP_ID=N'"+EMP_ID+"' and ATT_DT='"+dt.ToString("yyyy/MM/dd")+"'";					
					rs=new Func.RecordSet(sql,con);
					if(rs.rows>0 )
					{
						if( (rs.record(0,"NOT_DR")+"").IndexOf("Absent")>=0 )
						{
							vat++;
							dtmax=dt;
						}
						else
						{
							if(rs.rows>0 && rs.record(0,"SHI_ID")!="00")						
								break;
						}
					}	
					else
						break;
				}
				dt=dt.AddDays(1);
			}
			if(vat>=PublicFunction.absent)
			{
				string sql="Select EMP_ID from FILC10A where EMP_ID=N'"+EMP_ID+"' and ( (FRM_DT  between '"+
					dtmin.ToString("yyyy/MM/dd")+"' and '"+dtmax.ToString("yyyy/MM/dd")+"') or "
					+" (TOO_DT  between '"+ dtmin.ToString("yyyy/MM/dd")+"' and '"
					+dtmax.ToString("yyyy/MM/dd")+"'))" ;
				Func.RecordSet rs=new Func.RecordSet(sql,con);
				if(rs.rows<=0)
				{
					sql="Select MAX(SEQ_NO) from FILC10A";
					Func.RecordSet rs1=new Func.RecordSet(sql,con);
					if(rs1.rows<=0)
						sql="0";
					else
						sql=(T_String.IsNullTo0(rs1.record(0,0))+1)+"";
					sql="Insert Into FILC10A(SEQ_NO,EMP_ID,SEQ_DT,FRM_DT,TOO_DT) values("+sql+",";
					sql+="N'"+EMP_ID+"','"+ATT_DT+"','"+dtmin.ToString("yyyy/MM/dd")+"','"+
						dtmax.ToString("yyyy/MM/dd")+"')";
					try
					{
						PublicFunction.SQL_Execute(sql,con);						
					}
					catch(SqlException ex)
					{
						MessageBox.Show(ex.Message);
					}
				}
			}
		}

		public Boolean CheckPhep(double t1,Func.RecordSet phep,double max)
		{
			
			//			double t=t1;
			//			if(t>=2400)
			//			{
			//				t=T_String.TruTG(t1,2400.0);
			//			}			
			//				
			//			for(int i=0;i<phep.rows;i++)
			//			{
			//				double STR_TM=IsN(phep.record(i,"STR_TM")); // gio vao
			//				double END_TM=IsN(phep.record(i,"END_TM"));	// gio ra
			//				if(STR_TM<=t && END_TM>=t)
			//				{					
			//					return true;
			//				}
			//			}
			//			return false;
			double t=t1;
			
			for(int i=0;i<phep.rows;i++)
			{
				double c1=IsN(phep.record(i,"STR_TM")); // gio vao
				double c2=IsN(phep.record(i,"END_TM"));	// gio ra	
				if(c2<c1)
					c2=T_String.CongTG(c2,2400.0);
				else
				{
					if((t1>=2400 ) && (t1>c1 && t1>c2))
					{
						c1=T_String.CongTG(c1,2400.0);				
						c2=T_String.CongTG(c2,2400.0);
					}
				}
				if(max>0)
				{
					if(max>t)//early
					{
						if(c1<=t && c2>=t && c2>=max )
						{					
							return true;
						}
					}
					else//late
					{
						if(c1<=t && c2>=t && c1<=max )
						{					
							return true;
						}
					}
				}
				else
				{
					if(c1<=t && c2>=t )
					{					
						return true;
					}
				}
			}
			return false;
				
		}

		public void GetPhep(Func.RecordSet phep)
		{
			for(int i=0;i<phep.rows;i++)
			{			
				if(LEA_I1+""=="")
				{
					LEA_I1=phep.record(i,"LEA_ID");	
					LEA_H1=T_String.DT_HourConvertToHourMin(IsD(phep.record(i,"HOU_DY")));	
				}
				else
				{
					if(LEA_I2+""=="")
					{
						LEA_I2=phep.record(i,"LEA_ID");	
						LEA_H2=T_String.DT_HourConvertToHourMin(IsD(phep.record(i,"HOU_DY")));	
					}
					else
					{
						LEA_I3=phep.record(i,"LEA_ID");	
						LEA_H3=T_String.DT_HourConvertToHourMin(IsD(phep.record(i,"HOU_DY")));
					}
				}
				NOT_DR+=phep.record(i,"LEA_NM")+";";
			}
		}
		public void GetOutTrip(Func.RecordSet OutTrip)
		{
			if(OutTrip.rows >0)
				NOT_DR="OutTrip;"+NOT_DR;
			OTR_HR=0;
			for(int i=0;i<OutTrip.rows;i++)
			{				
				OTR_HR=T_String.CongTG(T_String.DT_HourConvertToHourMin(IsD(OutTrip.record(i,"HOU_TT"))),OTR_HR);				
			}			
		}
		
		
		public void GetNote()
		{			
			
			if(rsca.rows<=0 || rsca.record(0,"SHI_ID")=="00")
				return;
			double cc=IsN(rsca.record(0,"ONN_TM"));
			if(T_String.IsNullTo00(ToDayDTTime.ToString("yyyyMMddHHmm"))
				<T_String.IsNullTo00( DateTime.Parse(ATT_DT).ToString("yyyyMMdd")+cc.ToString("0000")))
				return;
			double ONN_MN=IsD(SetTA.record(0,"ONN_MN"));
			double OFF_MN=IsD(SetTA.record(0,"OFF_MN"));
			double ABS_MN=IsD(SetTA.record(0,"ASB_MN"));
			int index=-1;
			string sql="Select *,LEA_NM from FILC04A a,FILA15A b where a.LEA_ID=b.LEA_ID and EMP_ID=N'"
				+EMP_ID+"' and STR_DT<='"+ATT_DT+"' and END_DT>='"+ATT_DT+"'";
			Func.RecordSet phep=new Func.RecordSet(sql,con);
			sql="Select * from FILC05A where EMP_ID=N'"
				+EMP_ID+"' and STR_DT<='"+ATT_DT+"' and END_DT>='"+ATT_DT+"'";
			Func.RecordSet OutTrip=new Func.RecordSet(sql,con);
//			GetPhep(phep);
//			GetOutTrip(OutTrip);
			if(phep.rows>0 && phep.record(0,"DAY_BT")+""=="True" )
			{								
				return;
			}		
			LEA_OUT=T_String.CongTG(OTR_HR,LEA_OUT);
			LEA_OUT=T_String.CongTG(OTR_HR,LEA_H1);
			LEA_OUT=T_String.CongTG(OTR_HR,LEA_H2);
			LEA_OUT=T_String.CongTG(OTR_HR,LEA_H3);

			Double tt=T_String.CongTG(ATT_MAX,NIG_MAX);
			if(LEA_OUT>=tt && tt>0)
				return;
			if( NOT_DR.IndexOf("Abnormal")>=0)
				return;
			double m=0,max=0,min=0,m1=0;//m1 so lan quet the , m= la thoi gian quet the truoc do
		
			Boolean QD2=false;
			double c=0;
			for(int i=0;i<rsca.rows;i++)
			{
				
				double c1=IsN(rsca.record(i,"ONN_TM")); // gio vao
				double c2=IsN(rsca.record(i,"OFF_TM"));	// gio ra				
				if(c1<c)// qua dem
				{
					QD2=true;
					break;
				}
				if(c2<c1) // qua dem
				{					
					QD2=true;
					break;
				}				
				c=c2;
			}			

			Boolean QD=false;
			for(int j=0;j<ATT.Count;j++)  // thoi gian quet the
			{				
				double t1=IsN(ATT[j]+"");	
				// thu edit
				double t1Af=0;
				double t1Bf=0;
				if(j<ATT.Count-1)
					t1Af=IsN(ATT[j+1]+"");
				if(j>0)
					t1Bf=IsN(ATT[j-1]+"");
				//end thu
				if(t1!=0)
				{
					if(j>=NIG_TM-1 && NIG_TM>0 && QD2==true)
						t1=t1+2400;
					
					if(t1>max)
					{						
						max=t1;
					}
//					else											
//						max=t1+2400;					
					m=t1;	
					m1=j;
					if(min==0)
						min=t1;
				}				
				c=0;
				QD=false;
				for(int i=0;i<rsca.rows;i++)  // chay theo ca
				{				
//					if(((i+1)*2)-1>=ATT.Count)
//					{
//						break;					
//					}
					double c01=-1;
					if(i>=1)
						c01=IsN(rsca.record(i-1,"OFF_TM")); // gio vao
					double c1=IsN(rsca.record(i,"ONN_TM")); // gio vao
					double c2=IsN(rsca.record(i,"OFF_TM"));	// gio ra
					double  giothaisanIN=IsN(rsca.record(i,"MAN_IN"));
					double  giothaisanOU=IsN(rsca.record(i,"MAN_OU"));	
					// Thu them set gio TS ve som
					if(thaisan.rows>0)
					{
						if(giothaisanIN>0) c1=giothaisanIN;
						if(giothaisanOU>0) c2=giothaisanOU;
					}
					//end
					if(c1<c)// qua dem
					{
						QD=true;
					}
					if(c2<c1) // qua dem
					{
						c2=c2+2400;
						QD=true;
					}
					else
					{
						if(QD)
						{
							c2=c2+2400;
							c1=c2+2400;
						}
					}
					c=c2;
//					thu edit ts
//					if(giothaisan>0)
//					{
//						c1=T_String.CongTG(c1,giothaisanIN);
//						c2=T_String.TruTG(c2,giothaisanOU);
//					}

					if(rsca.record(i,"LAT_BT")+""=="True" ||(rsca.record(i,"TYP_ID")=="ATT_HR" || rsca.record(i,"TYP_ID")=="NIG_HR"))
					{
						if(j%2==0 && t1<c1)// Late
						{							
							break;
						}
						if((j%2==0 && t1<c2 && t1>c1)  ||  (min!=0 && t1==min)) // Late  | (min!=0 && t1==min) | gio vao dau tien
						{
							// bo tinh absent truoc, sau khi tinh tre, som xong moi set absent
//							if((T_String.CongTG(c1,ABS_MN))<=t1 && ABS_MN!=0 )
//							{
//								if(phep.rows>0 || OutTrip.rows>0)
//								{
//									if(phep.rows>0 && phep.record(0,"DAY_BT")+""=="True")
//									{								
//										return;
//									}
//									else
//									{
//										if(!CheckPhep(t1,phep,0) && !(CheckPhep(c1,phep,0) && (min!=0 && t1==min)) )
//										{
//											if(!CheckPhep(t1,OutTrip,0)  && !(CheckPhep(c1,OutTrip,0) && (min!=0 && t1==min)))
//											{
//												NOT_DR+="Absent"+";";
//												//GetPhep(phep);
//												NOT_D1+=j.ToString("00");
//												ABS_TM++;
//												return;
//											}
//										}
//									}
//								}
//								else								
//								{
//									NOT_DR+="Absent"+";";
//									//GetPhep(phep);
//									NOT_D1+=j.ToString("00");
//									ABS_TM++;
//									return;
//								}
//							}
							if(T_String.CongTG(c1,ONN_MN)<=t1 )						
							{
//								// thu them && t1Bf>c1	
//								if(t1Bf>c1)
//									break;
//								// end thu
								if(!CheckPhep(t1,phep,c1)) //&&  (min!=0 && t1==min) ) //!CheckPhep(c1,phep,0)
								{
									if(!CheckPhep(t1,OutTrip,0)  && !CheckPhep(c1,OutTrip,0))
									{
										Double LT=GetHourAndPhep(c1,t1,phep);
										if(t1>c2)
											LT=GetHourAndPhep(c1,c2,phep);
										else
											if(j>0 && t1Bf>c1)// Thu sua 20130417
												LT=GetHourAndPhep(t1Bf,t1,phep);
											else
												LT=GetHourAndPhep(c1,t1,phep);
										if(LT>0)
										{
											Note("Late"+";");
											NOT_D1+=j.ToString("00");
											LAT_MN= T_String.CongTG(LT,LAT_MN);
											LAT_TM++;
										}
									}
								}
							}
//							break;
						}
						if(j%2==1 && t1>c1 && t1<c2) // early   cu Tan doi
						//if(j%2==1 && t1<c2 && ((t1>c01 && t1<c1 && c01>0 && t1==maxmax) || (t1>c1)) ) // early moi Tan doi
						{
//							if(t1<c1)
//								t1=c1;
							if(T_String.CongTG(t1,OFF_MN)<=c2 ) 
							{
//								//thu them && t1Af<c2
//								if(t1Af<c2)
//									break;
//								// end thu
								if(!CheckPhep(t1,phep,c2))
								{
									if(!CheckPhep(t1,OutTrip,0))
									{
										if(j<ATT.Count-1 && t1Af<c2) // Thu sua 20130417
											break;
										index=i;		
										Double EA=GetHourAndPhep(t1,c2,phep);
										if(EA>0)
										{
											Note("Early"+";");
											NOT_D1+=j.ToString("00");											
											EAR_MN= T_String.CongTG(EA,EAR_MN);
											EAR_TM++;
										}
									}
								}
							}
							break;
						}
					}									
				}				
			}
			if(m==0) // neu ko quet the gi het
			{
				double t1;
				if(ATT.Count==0)
					t1=0;
				else
					t1=IsN(ATT[0]+"");
				if(phep.record(0,"DAY_BT")+""=="True")
				{								
					return;
				}			
				else // ko quet the
				{
					if(phep.rows<=0 && OutTrip.rows<=0)
					{
						NOT_DR+="Absent"+";";
						//GetPhep(phep);
						ABS_TM++;
						return;
					}
					Boolean QD1=false;
					c=0;
					for(int i=0;i<rsca.rows;i++)
					{							
						double c1=IsN(rsca.record(i,"ONN_TM")); // gio vao
						double c2=IsN(rsca.record(i,"OFF_TM"));	// gio ra
						double  giothaisanIN=IsN(rsca.record(i,"MAN_IN"));
						double  giothaisanOU=IsN(rsca.record(i,"MAN_OU"));		
						// Thu them set gio TS ve som
						if(thaisan.rows>0)
						{
							if(giothaisanIN>0) c1=giothaisanIN;
							if(giothaisanOU>0) c2=giothaisanOU;
						}
						if(c1<c)// qua dem
						{
							QD1=true;
						}
						if(c2<c1) // qua dem
						{
							c2=c2+2400;
							QD1=true;
						}
						else
						{
							if(QD1)
							{
								c2=c2+2400;
								c1=c2+2400;
							}
						}
						c=c2;					
//						if(thaisan.rows>0)
//						{
//							c1=T_String.CongTG(c1,giothaisanIN);
//							c2=T_String.TruTG(c2,giothaisanOU);
//						}
						
						if(rsca.record(i,"LAT_BT")+""=="True" ||(rsca.record(i,"TYP_ID")=="ATT_HR" || rsca.record(i,"TYP_ID")=="NIG_HR"))
						{								
							if(phep.rows>0 || OutTrip.rows>0)
							{								
								if(!CheckPhep(c1,phep,0))
								{
									if(!CheckPhep(c1,OutTrip,0))
									{
										NOT_DR+="Absent"+";";	
										//GetPhep(phep);
										ABS_TM++;
										NOT_D1="00";
										return;
									}
								}
								if(!CheckPhep(c2,phep,0))
								{
									if(!CheckPhep(c2,OutTrip,0))
									{
										NOT_DR+="Absent"+";";
										//GetPhep(phep);
										ABS_TM++;
										NOT_D1="00";
										return;
									}
								}								
							}									
						}									
					}				
				
				}
			}
			else // co quet the kiem tra xem co phai chuyen du lieu ngay hien tai ko
			{
				if(ATT_DT!=ToDayDT)
				{
					double gio=0;
					QD=false;
					double c0=IsN(rsca.record(0, "ONN_TM")); // gio vao dau tien cua ca
					for(int i=rsca.rows-1;i>=0;i--)
					{
						if(rsca.record(i,"LAT_BT")+""=="True" ||(rsca.record(i,"TYP_ID")=="ATT_HR" || rsca.record(i,"TYP_ID")=="NIG_HR"))
						{
							double c1=IsN(rsca.record(i,"ONN_TM")); // gio vao
							double c2=IsN(rsca.record(i,"OFF_TM"));	// gio ra		
							double  giothaisanIN=IsN(rsca.record(i,"MAN_IN"));
							double  giothaisanOU=IsN(rsca.record(i,"MAN_OU"));		
							// Thu them set gio TS ve som
							if(thaisan.rows>0)
							{
								if(giothaisanIN>0) c1=giothaisanIN;
								if(giothaisanOU>0) c2=giothaisanOU;
							}
//							if(QD)
//							{
//								if(c1>c2)
//								{
//									c2=c2+2400;
//									QD=true;
//								}
//								else
//								{
//									c2=c2+2400;
//									c1=c1+2400;
//								}
//							}
							// Thu sua ngay 28/06/14
							if(c1<c0)
							{
								c1=c1+2400;
								c2=c2+2400;
							}
							if(c1>c0 && c1>c2)
								c2=c2+2400;
							//end thu
							
							if(index+1<=i)
							{
								double max11=0;
								if(max<c1)
									max11=c1;
								else
									max11=max;

								if(T_String.CongTG(max11,OFF_MN)<=c2 ) // max la gio quet the sau cung
								{
									if(!CheckPhep(max11,phep,c2))
									{
										if(!CheckPhep(max11,OutTrip,0))
										{
											Double v1=0,v2=c2;
											if(max11>=c1)
											{
												v1=max11;										
											}
											else
											{
												v1=c1;
											}
											
											Double EA=GetHourAndPhep(v1,v2,phep);																						
											if(EA>0 )
											{
												Note("Early"+";");
												//NOT_D1+=i.ToString("00");
												EAR_MN= T_String.CongTG(EA,EAR_MN);
												EAR_TM++;
											}											
										}
									}
								}
								//								Note("Early"+";");
								//								NOT_D1+=m1.ToString("00");
								//								return;
								//return;
							}
							else
							{
								if(index+1>i)
									return;
//								if(max<c1)
//								{
//									gio=gio+T_String.TruTG(c2,c1);
//								}
							}							
						}
					}
				}
			}
		}

		public Double Lay_gio_phep(double v1,double v2,Func.RecordSet phep)
		{
			
			double t=0,t1=0,t2=0;
			if(t>=2400)
			{
				t=T_String.TruTG(t1,2400.0);
			}			
				
			for(int i=0;i<phep.rows;i++)
			{
				double p1=IsN(phep.record(i,"STR_TM")); // gio vao
				double p2=IsN(phep.record(i,"END_TM"));	// gio ra
				if(p1<=v1 && p2>=v1) // v1 nam giua
				{		
					t1=v1;
					if(p2>=v2) // v2 cung nam giua
						t2=v2;
					t=T_String.TruTG(t2,t1);
					return t;
				}
				if(p1<=v2 && p2>=v2) // v2 nam giua
				{
					t1=p1;					
					t2=v2;
					t=T_String.TruTG(t2,t1);
					return t;
				}
				if( (v1<=p1 && v2>=p1) && (v1<=p2 && v2>=p2) )
				{					
					t=T_String.TruTG(p2,p1);
					return t;
				}
			}
			return 0;
		}
		public void Note(string st)
		{
//			if(thaisan.rows<=0)
//			{
				if(NOT_DR.IndexOf(st)<0)
					NOT_DR+=st;
//			}
		}

		private Double maxmax=0;
		public void Get_ATT_HR()
		{	
			double ONN_MN=IsD(SetTA.record(0,"ONN_MN"));
			double OFF_MN=IsD(SetTA.record(0,"OFF_MN"));
			string ONN_BT=SetTA.record(0,"ONN_BT");
			string OFF_BT=SetTA.record(0,"OFF_BT");

			string sql="Select *,LEA_NM from FILC04A a,FILA15A b where a.LEA_ID=b.LEA_ID and EMP_ID=N'"
				+EMP_ID+"' and STR_DT<='"+ATT_DT+"' and END_DT>='"+ATT_DT+"'";
			Func.RecordSet phep=new Func.RecordSet(sql,con);

			Boolean QD=false;
			double c=0;
			for(int i=0;i<rsca.rows;i++)
			{
				
				double c1=IsN(rsca.record(i,"ONN_TM")); // gio vao
				double c2=IsN(rsca.record(i,"OFF_TM"));	// gio ra					
				double MAX_HR1=IsD(rsca.record(i,"WRK_HR"));	// gio cong		
			
					
				if(c1<c)// qua dem
				{
					QD=true;
				}
				if(c2<c1) // qua dem
				{
					c2=c2+2400;
					QD=true;
				}
				else
				{
					if(QD)
					{
						c2=c2+2400;
						c1=c1+2400;
					}
				}
				c=c2;
				if(rsca.record(i,"TYP_ID")=="ATT_HR")
				{
					if(MAX_HR1>0 && MAX_HR1<T_String.TruTG(c2,c1))
						ATT_MAX=T_String.CongTG(ATT_MAX,MAX_HR1);
					else
						ATT_MAX=T_String.CongTG(ATT_MAX,T_String.TruTG(c2,c1));
				}
				if(rsca.record(i,"TYP_ID")=="NIG_HR")
				{
					if(MAX_HR1>0 && MAX_HR1<T_String.TruTG(c2,c1))
						NIG_MAX=T_String.CongTG(NIG_MAX,MAX_HR1);
					else
						NIG_MAX=T_String.CongTG(NIG_MAX,T_String.TruTG(c2,c1));
				}
			}
			
			if(ATT.Count<=0)
				return;
		

			ArrayList AT=new ArrayList();
			int dem=0;
			for(int i=0;i<ATT.Count;i++)
			{
				if(IsN(ATT[i]+"")!=0)
				{
					double st=IsD(ATT[i]+"");
					if(i>=NIG_TM-1 && NIG_TM>0 && QD==true)
						st=st+2400;
					dem++;
					AT.Add(st);
					if(st>maxmax)
						maxmax=st;
				}
			}

			if(dem%2==1)
			{
				if(ATT_DT!=ToDayDT)
					NOT_DR="Abnormal;";
				return ;			
			}
			
			QD=false;
			c=0;
			for(int i=0;i<rsca.rows;i++)
			{
				//				
//				if(((i+1)*2)-1>=ATT.Count)
//					return ;
				double c1=IsN(rsca.record(i,"ONN_TM")); // gio vao
				double c2=IsN(rsca.record(i,"OFF_TM"));	// gio ra
				double  giothaisanIN=IsN(rsca.record(i,"MAN_IN"));
				double  giothaisanOU=IsN(rsca.record(i,"MAN_OU"));			
				int j=AT.Count-1;
				// Thu them set gio TS ve som
				if(giothaisan>0)
				{
					if(giothaisanIN>0) c1=giothaisanIN;
					if(giothaisanOU>0) c2=giothaisanOU;
				}
				//end
				if(c1<c)// qua dem
				{
					QD=true;
				}
				if(c2<c1) // qua dem
				{
					c2=c2+2400;
					QD=true;
				}
				else
				{
					if(QD)
					{
						c2=c2+2400;
						c1=c1+2400;
					}
				}
				c=c2;
				while (j>=0)
				{	
					double t2=IsN(AT[j]+"");
					j--;
					double t1=IsN(AT[j]+"");
					j--;	
					
					double a1,a2,a;
					if(t2>c1)
					{
						if(t1>c1)
						{
							if(ONN_BT=="True" &&  T_String.TruTG(t1,c1)< ONN_MN )
							{								
								a1=c1;
							}
							else
								a1=t1;
						}
						else
							a1=c1;

						if(t2>c2)					
							a2=c2;					
						else
						{
							if(OFF_BT=="True" && T_String.TruTG(c2,t2)< OFF_MN )
							{
								a2=c2;
							}
							else							
								a2=t2;
						}
						if(a2>a1)
						{
							a=GetHourAndPhep_ATT(a1,a2,phep);//T_String.TruTG(a2,a1);
							double MAX_HR=IsD(rsca.record(i,"WRK_HR"));	// gio cong
							double MIN_ST=IsD(rsca.record(i,"MIN_ST"));	// MIN_ST
							if(MIN_ST==0 || MIN_ST<=a) // lam tren bao nhieu phut moi tinh
							{
								if(MAX_HR<a && MAX_HR>0)   // thoi gian lam viec toi da
									Add(rsca.record(i,"TYP_ID"),MAX_HR);							
								else
									Add(rsca.record(i,"TYP_ID"),a);
							}					
						}	
					}
				}				
			}
		}
		public void Round()
		{
			if(SetTA.record(0,"ROU_NO")!="True")
			{
				for(int i=0;i<Data.Count;i++)
				{					
					int SEQ=IsN(PublicFunction.S_Left(rsTypeShift.record(i,"ROU_DR"),2));
					int ROU=IsN(PublicFunction.S_Right(rsTypeShift.record(i,"ROU_DR"),2));
					if(SEQ!=0)
						Data[i]=Round(IsD(Data[i]+""),SEQ,ROU);				
				}
			}
			if(thaisan.rows>0 )// thai san
			{
				int index=Name.IndexOf("ATT_HR");
				Double hr=T_String.IsNullTo00(Data[index]+"");
				Double hr1=T_String.IsNullTo00(thaisan.record(0,"WRK_OT")+"");
				Double gp=0;
//				gp=T_String.CongTG(LEA_H1,LEA_H2); bo di, kg cong phep vao gio lam thai san
//				gp=T_String.CongTG(gp,LEA_H3);
				gp=T_String.CongTG(gp,OTR_HR);
				if(hr>0)
				{
					if(CON_MAN==0 || T_String.CongTG(hr,gp)>=CON_MAN)
					{
						hr=hr+100;
						hr1=T_String.IsNullTo00(thaisan.record(0,"WRK_OT")+"");
						hr1=T_String.TruTG(hr1,gp);
						if(hr>hr1 && hr1>0)
						{
							Data[index]=hr1;
							hr=hr-hr1;
							index=Name.IndexOf("OTT_HR");
							Data[index]=T_String.IsNullTo00(Data[index]+"")+hr;
						}
						else
						{
							Data[index]=hr;
						}
					}
					else
						giothaisan=0;
				}
				else
				{
					index=Name.IndexOf("NIG_HR");
					hr=T_String.IsNullTo00(Data[index]+"");
					if(CON_MAN==0 || T_String.CongTG(hr,gp)>=CON_MAN)
					{					
						if(hr>0)
						{
							hr=hr+100;
							hr1=T_String.IsNullTo00(thaisan.record(0,"WRK_OT")+"");
							hr1=T_String.TruTG(hr1,gp);
							if(hr>hr1 && hr1>0)
							{
								Data[index]=hr1;
								hr=hr-hr1;
								index=Name.IndexOf("NIG_OT");
								Data[index]=T_String.IsNullTo00(Data[index]+"")+hr;
							}
							else
							{
								Data[index]=hr;
							}
						}
					}
					else
						giothaisan=0;
				}

				if( thaisan.record(0,"OTT_BT")+""!="True")
				{
					for(int i=0;i<Data.Count;i++)
					{					
						if(Name[i]+""!="ATT_HR" && Name[i]+""!="NIG_HR")
							Data[i]=0;		
						else
						{
							if(Name[i]+""=="ATT_HR")
							{
								if( IsD( Data[i])>ATT_MAX)
									 Data[i]=ATT_MAX;
							}
							else
								if( IsD( Data[i])>NIG_MAX)
									 Data[i]=NIG_MAX;
						}
					}
				}
//				else
//				{
					
//				}
			}
			
		}

		public Boolean RoundTime()
		{
			Boolean A=false;
//			if(SetTA.record(0,"ROU_NO")!="True")
//			{
				int dem=0;
				for(int j=0;j<ATT.Count;j++)
				{				
					double t1=IsN(ATT[j]+"");										
					if(t1!=0)
						dem++;
					for(int i=0;i<rsca.rows;i++)
					{									
						double c1=IsN(rsca.record(i,"ONN_TM")); // gio vao
						double c2=IsN(rsca.record(i,"OFF_TM"));	// gio ra
						double c3=c2;
						int SEQ=IsN(PublicFunction.S_Left(rsca.record(i,"ONN_RD"),2));
						int ROU=IsN(PublicFunction.S_Right(rsca.record(i,"ONN_RD"),2));
						int SEQ1=IsN(PublicFunction.S_Left(rsca.record(i,"OFF_RD"),2));
						int ROU1=IsN(PublicFunction.S_Right(rsca.record(i,"OFF_RD"),2));
//						if(i+1<rsca.rows)
//							c3=IsN(rsca.record(i+1,"OFF_TM"));	// gio ra
						if(dem%2==1) //gio vao
						{
							if(t1<c1 )
							{	
//								if((SEQ!=0))
//								{
//									A=true;
//									ATT[j]=Round(t1,SEQ,ROU);
//								}
								break;
							}
							if(t1>c1 && t1<c2)
							{		
								if((SEQ!=0))
								{
//									A=true;
									if(T_String.TruTG(t1,c1)<=ROU)
										ATT[j] = T_String.TruTG(t1, ROU); //ATT[j]=Round(t1,SEQ,-ROU);
								}
								break;
							}
						}
						if(dem%2==0) //gio ra
						{
							if(t1<c2 )
							{	
								if((SEQ1!=0))
								{
//									A=true;
									if (T_String.TruTG(c2,t1)<=ROU1)
										 ATT[j] = T_String.CongTG(t1, ROU1); //ATT[j]=Round(t1,SEQ1,ROU1);
								}
								break;
							}
//							if(t1>c2 && t1<c3)
//							{	
//								if((SEQ1!=0))
//								{
//									A=true;
//									ATT[j]=Round(t1,SEQ1,ROU1);
//								}
//								break;
//							}
						}
					}
				}
//			}
			return A;
		}

		public double Round(double data,int SEQ,int ROU)
		{	
			
			double gio=IsD(PublicFunction.S_Left(PublicFunction.S_Right("00"+data+"",4),2));
			double phut=IsD(PublicFunction.S_Right("00"+data+"",2));		
			if(phut==0)
				return data;				
			int tm1=0,tm=0;		
			for(int i=1;i<=SEQ;i++)
			{
				tm=(int)((60/SEQ)*i);
				tm1=(int)tm-ROU;
				if(phut<=tm && phut >=tm1)
				{
					if(tm==60)
					{
						tm=0;
						gio++;
					}
					return  IsD(gio+""+tm.ToString("00"));
				}
				tm=(int)((60/SEQ)*(i-1));
				if(phut<tm1 && phut >tm)
				{
					if(tm==60)
					{
						tm=0;
						gio++;
					}
					return IsD(gio+""+tm.ToString("00")) ;		
				}
			}
			return data;	
		}
		public double GetHourAndPhep(double t3,double t4,Func.RecordSet phep)
		{
			double t1=t3,t2=t4;			
			if(PublicFunction.CUS_ID=="9"  )
				return T_String.TruTG(t2,t1);
//tam thoi bo, Trung Thu
			for(int i=0;i<phep.rows;i++)
			{
				double c1=IsN(phep.record(i,"STR_TM")); // gio vao
				double c2=IsN(phep.record(i,"END_TM"));	// gio ra	
				if(c2<c1)
					c2=T_String.CongTG(c2,2400.0);
				else
				{
					if((t1>=2400 || t2>=2400) && (t1>c1 && t1>c2))
					{
						c1=T_String.CongTG(c1,2400.0);				
						c2=T_String.CongTG(c2,2400.0);
					}
				}
				

				double a1=t1,a2=t2;
				if(t1>c1 && t1<c2)
				{
					a1=c2;
				}
				if(t2>c1 && t2<c2)
				{
					a2=c1;
				}
				if(a1>a2)
					return 0;
				
//				//if(t1<=c1 && t2>=c2) // luanrem /// luan lam the nay khuend sua lai ngay  05-01-2016
//				if(t1<=c1 && t2<=c2)
//					return T_String.CongTG(T_String.TruTG(c1,t1),T_String.TruTG(t2,c2));
//				//luan rem
//				//return T_String.TruTG(a2,a1);
				if(t1<=c1 && t2>=c2)
					return T_String.CongTG(T_String.TruTG(c1,t1),T_String.TruTG(t2,c2));
				return T_String.TruTG(a2,a1);
			}
//end
			return T_String.TruTG(t2,t1);
		}
		public double GetHourAndPhep_ATT(double t3,double t4,Func.RecordSet phep)
		{
			double t1=t3,t2=t4;			
			if(PublicFunction.CUS_ID=="9"  )
				return T_String.TruTG(t2,t1);
			//tam thoi bo, Trung Thu
//			for(int i=0;i<phep.rows;i++)
//			{
//				double c1=IsN(phep.record(i,"STR_TM")); // gio vao
//				double c2=IsN(phep.record(i,"END_TM"));	// gio ra	
//				if(c2<c1)
//					c2=T_String.CongTG(c2,2400.0);
//				else
//				{
//					if((t1>=2400 || t2>=2400) && (t1>c1 && t1>c2))
//					{
//						c1=T_String.CongTG(c1,2400.0);				
//						c2=T_String.CongTG(c2,2400.0);
//					}
//				}
//				
//
//				double a1=t1,a2=t2;
//				if(t1>c1 && t1<c2)
//				{
//					a1=c2;
//				}
//				if(t2>c1 && t2<c2)
//				{
//					a2=c1;
//				}
//				if(a1>a2)
//					return 0;
//				if(t1<=c1 && t2>=c2)
//					return T_String.CongTG(T_String.TruTG(c1,t1),T_String.TruTG(t2,c2));
//				return T_String.TruTG(a2,a1);
//			}
			//end
			return T_String.TruTG(t2,t1);
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
