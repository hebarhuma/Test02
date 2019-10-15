using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Take_Away
{
    class DataAccessLayer
    {
        SqlConnection sqlconnection; 
        public DataAccessLayer()
        {
            sqlconnection = new SqlConnection(@"server=.;database=SystemTakeawayDB; integrated security=true");
        }
        public void Open()
        {
            if(sqlconnection.State != ConnectionState.Open)
            sqlconnection.Open();
        }
        public void Close()
        {
            if (sqlconnection.State == ConnectionState.Open)
                sqlconnection.Close();
        }
        public DataTable SelectData(string stored_procesure, SqlParameter[] param)
        {
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = stored_procesure;
            sqlcmd.Connection = sqlconnection;

            if (param != null)
            {
                    sqlcmd.Parameters.Add(param);
            }
            sqlconnection.Open();
            SqlDataAdapter da = new SqlDataAdapter(sqlcmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            sqlconnection.Close();
            return dt;
        }
        public void ExecuteCommand(string stored_procesure, SqlParameter[] param)
        {
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = stored_procesure;
            sqlcmd.Connection = sqlconnection;
            if (param != null)
            {
                sqlcmd.Parameters.AddRange(param);
            }
            sqlconnection.Open();
            sqlcmd.ExecuteNonQuery();
            sqlconnection.Close();
        }
    }
}
