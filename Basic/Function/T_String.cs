using System;
using System.Drawing;

namespace Basic.Function
{
	/// <summary>
	/// Summary description for String.
	/// </summary>
	public class T_String
	{	
		public T_String()
		{
			//
			// TODO: Add constructor logic here
			//
		}
		public static string DEP_ID(Object tag)
		{
			return "(Select DEP_ID  from SYS_SECURITY_DEP"+
					" where MNU_ID="+tag+" and ALL_BT=1 and USER_ID=N'"+PublicFunction.A_UserID+"')";
		}
		public static int IsNullTo0(string st)
		{		
			try
			{ 
				if (st==null || st=="")
					return 0;			
				return Int32.Parse(st=st.Replace(",",""));
			}
			catch(Exception){return 0;}
		}		
		public static Double IsNullTo00(string st)
		{
			try
			{ 
				if (st==null || st=="")
					return 0;			
				return Double.Parse(st=st.Replace(",",""));
			}
			catch(Exception){return 0;}
		}	
		

		public static string Left(string st,string find)
		{
			return st.Remove(st.IndexOf(find,0,st.Length),st.Length-st.IndexOf(find,0,st.Length));
		}

		public static string MaxLenght(int n)
		{
			string st="";			
			for (int i=0;i<n;i++)
			{
				st+="&";
			}
			return st;
		}
		
		public static int  GetMax(string FieldName,string from)
		{
			return T_String.IsNullTo0(GetDataFromSQL(FieldName,from))+1;							
		}

		public static int GetMax(string FieldName,string from,string where)
		{
			return T_String.IsNullTo0(GetDataFromSQL(FieldName,from,where))+1;							
		}

		public static Double GetMax0(string FieldName,string from)
		{
			return T_String.IsNullTo00(GetDataFromSQL(FieldName,from))+1;							
		}

		public static Double GetMax0(string FieldName,string from,string where)
		{
			return T_String.IsNullTo00(GetDataFromSQL(FieldName,from,where))+1;							
		}

		public static string GetDataFromSQL(string FieldName,string from,string where)
		{
			return GetDataFromSQL(FieldName,from,where,PublicFunction.C_con);
		}

		public static string GetDataFromSQL(string FieldName,string from)
		{
			return GetDataFromSQL(FieldName,from,"",PublicFunction.C_con);
		}				

		public static string GetDataFromSQL(string FieldName,string from,System.Data.SqlClient.SqlConnection con)
		{
			return GetDataFromSQL(FieldName,from,"",con);
		}

		public static string GetDataFromSQL(string FieldName,string from,string where,System.Data.SqlClient.SqlConnection con)
		{
			string sql="";
			sql="select " + FieldName + " from " + from;
			if (where !="")
			{				
				sql=sql + " where " + where;
			}
			Func.RecordSet rs=new Func.RecordSet(sql,con);
			if (rs.rows>0)
				return rs.record(0,0);
			else 
				return null;
		}
		public static Boolean CheckColumnInTable(string colname, string stable)
		{
			string ssql;
			Boolean check=false;
			ssql = "SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('dbo."+stable +"')";
			Func.RecordSet rsMs = new Func.RecordSet(ssql, PublicFunction.C_con);           
			for (int i = 0; i < rsMs.rows; i++)
			{
				if (rsMs.record(i, "name") == colname)
					check = true;
			}
			return check;
		}

		public static string  sqlsql(string sql)
		{
			if (sql==null) return sql;
			return sql.Replace("'","''");
		}
		public static string  sqlsql(object sql)
		{
			return (string)(sql+"").Replace("'","''");
		}

		public static DateTime GetDate(System.Data.SqlClient.SqlConnection con)
		{
			Func.RecordSet rs=new Func.RecordSet("Select GetDate()",con);
			if (rs.rows>0)
				return DateTime.Parse(rs.record(0,0));
			else 
				return DateTime.Now;
		}	
	
		public static DateTime GetDate()
		{
			Func.RecordSet rs=new Func.RecordSet("Select GetDate()",PublicFunction.C_con);
			if (rs.rows>0)
				return DateTime.Parse(rs.record(0,0));
			else 
				return DateTime.Now;
		}
		
		public static string TrimS(string st)
		{
			if (st!="" && st!=null)
				return st.Trim();
			return st;
		}
		public static string GetWhereString(string sql,string F,string txt1,string txt2)
		{
			if(txt1!="")
			{				
				if (sql!="")
					sql+=" and ";
				if(txt2!="")
				{
					sql += "("+F+" between N'"+txt1+"' and N'"+txt2+"') ";
				}
				else
				{
					sql += "("+F+"=N'"+txt1+"')";
				}				
			}
			return sql;					
		}
		public static string GetWhereDate(string sql,string F,string txt1,string txt2)
		{
			if(txt1!="")
			{				
				if (sql!="")
					sql+=" and ";
				if(txt2!="")
				{
					sql += "("+F+" between '"+DateTime.Parse(txt1).ToString("yyyy/MM/dd ")+"00:00' and '"+DateTime.Parse(txt2).ToString("yyyy/MM/dd")+" 23:59') ";
				}
				else
				{
					sql += "("+F+"='"+DateTime.Parse(txt1).ToString("yyyy/MM/dd")+"')";
				}				
			}
			return sql;					
		}

		public static Boolean CompareDate(DateTime dt1,DateTime dt2)
		{
			return (T_String.IsNullTo0(dt1.ToString("yyyyMMdd"))>=T_String.IsNullTo0(dt2.ToString("yyyyMMdd")))	;	
		}

		public static Double DT_HourMinConvertToHour(int tam)
		{
			if(tam==0)
				return 0;
			//return T_String.IsNullTo00((tam/100)+"."+(((double)tam-((tam/100)*100))/60));
			return T_String.IsNullTo00((tam/100)+(((double)tam-((tam/100)*100))/60)+"");
		}

		public static int DT_HourConvertToHourMin(Double tam)
		{
			int gio=(int)(tam);
			int phut=(int)Math.Round(((tam-gio)*60),0);
			return (gio*100)+phut;
		}

		public static int DT_GetDays(DateTime dt1,DateTime dt2)
		{
			int tam=0;
			DateTime d1=dt1;
			DateTime d2=dt2;
			while (T_String.IsNullTo0(d1.ToString("yyyyMMdd"))<=T_String.IsNullTo0(d2.ToString("yyyyMMdd")))
			{
				tam++;
				d1=d1.AddDays(1);
			}
			return tam;
		}

		public static int DT_GetDays(DateTime dt1,DateTime dt2,string EMP_ID)
		{
			int tam=0;
			DateTime d1=dt1;
			DateTime d2=dt2;
			while (T_String.IsNullTo0(d1.ToString("yyyyMMdd"))<=T_String.IsNullTo0(d2.ToString("yyyyMMdd")))
			{		
				string sql="EMP_ID=N'"+EMP_ID+"' and YYY_MM=N'"+d1.ToString("yyyyMM")+"'";
				if(GetDataFromSQL("DAY_"+d1.ToString("dd"),"FILC03A",sql)!="00" && d1.DayOfWeek!=DayOfWeek.Sunday)
					tam++;
				d1=d1.AddDays(1);
			}
			return tam;
		}

		public static double CongTG(double t1,double t2)
		{			
			int g1=Math.Abs(IsNullTo0(PublicFunction.S_Left(t1+"",((string)(t1+"")).Length-2)));
			int g2=Math.Abs(IsNullTo0(PublicFunction.S_Left(t2+"",((string)(t2+"")).Length-2)));
			int f1=Math.Abs(IsNullTo0(PublicFunction.S_Right("00"+t1+"",2)));
			int f2=Math.Abs(IsNullTo0(PublicFunction.S_Right("00"+t2+"",2)));
		
			TimeSpan tm1=new TimeSpan(g1,f1,0);	
			TimeSpan tm2=new TimeSpan(g2,f2,0);
			if(t1<0)
				tm1=tm1.Negate();
			if(t2<0)
				tm2=tm2.Negate();
			tm1=tm1.Add(tm2);
	
			string st= (((Math.Abs(tm1.Days)*24)+ Math.Abs(tm1.Hours)).ToString("00"))+""+ Math.Abs(tm1.Minutes).ToString("00");
			if(tm1.TotalMilliseconds<0)			
				return IsNullTo00("-"+st);	
			return IsNullTo00(st);	
		}

		public static double TruTG(double t1,double t2)
		{
			return CongTG(t1,t2*(-1));
		}			
	}
}
