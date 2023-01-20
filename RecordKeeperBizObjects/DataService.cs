using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CPUFramework;


namespace RecordKeeperBizObjects
{
    public static class DataService
    {
        
   
        public static DataTable GetUSGovRecordSummary()
        {
            string sql = "SELECT num = COUNT(*), Tabledesc = 'Parties' from Party UNION SELECT num = COUNT(*), Tabledesc = 'President' from president UNION SELECT num = COUNT(*), Tabledesc = 'Executive order' from ExecutiveOrder";
            return CPUFramework.SQLUtility.GetDataTable(DataUtility.ConnectionString, sql);
        }
        public static DataTable GetPartyList(bool IncludeBlank = false)
        {
            SqlCommand cmd = SQLUtility.GetSQLCommand(DataUtility.ConnectionString, "PartyGet");
            cmd.Parameters["@All"].Value = 1;
            cmd.Parameters["@IncludeBlank"].Value=IncludeBlank;

            return SQLUtility.GetDataTable(cmd, (DataUtility.ConnectionString));
        }
        public static DataTable GetPresidentList()
        {
            SqlCommand cmd = SQLUtility.GetSQLCommand(DataUtility.ConnectionString, "PresidentGet");
            
            cmd.Parameters["@All"].Value = 1;


            return SQLUtility.GetDataTable(cmd, (DataUtility.ConnectionString));
        }
        public static DataTable GetPresidentDetail(int id)
        {

            SqlCommand cmd = SQLUtility.GetSQLCommand(DataUtility.ConnectionString, "PresidentGet");
            cmd.Parameters["@PresidentId"].Value = id;
            

            //get SQLCommand  for presidentget from SQLUtility
            //set param of the SQLCommand
            //pass the cmd back into SQLUtilility adnd get command

            return SQLUtility.GetDataTable(cmd, (DataUtility.ConnectionString));
        }

        public static DataTable GetExecutiveOrdersForPresident(int presidentid)
        {
            SqlCommand cmd = SQLUtility.GetSQLCommand(DataUtility.ConnectionString, "ExecutiveOrderGet");
            cmd.Parameters["@PresidentId"].Value = presidentid;
            return SQLUtility.GetDataTable(cmd, (DataUtility.ConnectionString));
        }
        public static DataTable GetPresidentWithRawSQL(int num)
        {
            DataTable dt = SQLUtility.GetDataTable(DataUtility.ConnectionString, "select * from president where num = 13");
            return dt; 
        }
    }
}
