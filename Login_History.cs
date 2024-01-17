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
    class Login_History
    {
        public static SqlConnection Getdbcon()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["cm"].ConnectionString);
            return con;
        }

        public string convertstring(string sql)
        {
            try
            {
                string sconsultant;
                SqlConnection con = Login_History.Getdbcon();
                DataTable ctable = new DataTable();
                SqlDataAdapter cad = new SqlDataAdapter(sql, con);
                cad.Fill(ctable);
                foreach (DataRow row in ctable.Rows)
                {
                    sconsultant = Convert.ToString(row[0]);
                    return sconsultant;
                }
            }
            catch
            {
                throw;
            }
            return "0";
        }

        public void Execute(string sql)
        {
            try
            {
                SqlConnection con = Login_History.Getdbcon();
                DataTable ctable = new DataTable();
                //int sconsultant;
                SqlDataAdapter cad = new SqlDataAdapter(sql, con);
                cad.Fill(ctable);
            }
            catch
            {
                throw;
            }
        }
    }
}
