using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EMB_ERM_Sub_Sytem_Laboratory_Unit
{
    class FileLog
    {
        public static SqlConnection Getcon()
        {
            SqlConnection c = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString);
            return c;
        }

        public string constring(string sql)
        {
            try
            {
                string scon;
                SqlConnection con = FileLog.Getcon();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                da.Fill(dt);
                foreach (DataRow row in dt.Rows)
                {
                    scon = Convert.ToString(row[0]);
                    return scon;
                }
            }
            catch
            {

                throw;
            }
            return "0";
        }

        public void Log(string sql)
        {
            try
            {
                SqlConnection con = FileLog.Getcon();
                DataTable dt = new DataTable();
                //int cons;
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                da.Fill(dt);
            }
            catch
            {
                throw;
            }
        }
    }
}

