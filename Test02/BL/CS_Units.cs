using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Take_Away.BL
{
    class CS_Units
    {
        DataAccessLayer DAL = new DataAccessLayer();

        #region///////////////////Units///////////////////////////////////

        //Units_Viwe
        public DataTable Units_Viwe()
        {
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("Units_Viwe", null);
            return Dt;
        }
        //Units_Add()
        public void Units_Add(string UnitName)
        {
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@UnitName", SqlDbType.NVarChar,25);
            param[0].Value = UnitName;

            DAL.ExecuteCommand("Units_Add", param);
        }
        //Units_Edit()
        public void Units_Edit(int UnitID,string UnitName)
        {
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@UnitID", SqlDbType.Int);
            param[0].Value = UnitID;

            param[1] = new SqlParameter("@UnitName", SqlDbType.NVarChar,25);
            param[1].Value = UnitName;

            DAL.ExecuteCommand("Units_Edit", param);

        }
        
        #endregion
    }
}
