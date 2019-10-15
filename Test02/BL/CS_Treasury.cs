using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Take_Away.BL
{
    class CS_Treasury
    {
        DataAccessLayer DAL = new DataAccessLayer();

        #region///////////////////Treasury///////////////////////////////////

        //Treasury_View
        public DataTable Treasury_View()
        {
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("Treasury_View", null);
            return Dt;
        }
        //Treasury_Add()
        public void Treasury_Add(string Treasury,
                                 decimal Balance,
                                 string Description,
                                 DateTime Date)
        {
            SqlParameter[] param = new SqlParameter[4];

            param[0] = new SqlParameter("@Treasury", SqlDbType.NVarChar,80);
            param[0].Value = Treasury;

            param[1] = new SqlParameter("@Balance", SqlDbType.Money);
            param[1].Value = Balance;

            param[2] = new SqlParameter("@Description", SqlDbType.NVarChar,70);
            param[2].Value = Description;

            param[3] = new SqlParameter("@Date", SqlDbType.Date);
            param[3].Value = Date;

            DAL.ExecuteCommand("Treasury_Add", param);


        }
        //Treasury_Edit()
        public void Treasury_Edit(int TreasuryID,
                                 string Treasury,
                                 decimal Balance,
                                 string Description,
                                 DateTime Date)
        {
            SqlParameter[] param = new SqlParameter[5];

            param[0] = new SqlParameter("@TreasuryID", SqlDbType.Int);
            param[0].Value = TreasuryID;

            param[1] = new SqlParameter("@Treasury", SqlDbType.NVarChar, 80);
            param[1].Value = Treasury;

            param[2] = new SqlParameter("@Balance", SqlDbType.Money);
            param[2].Value = Balance;

            param[3] = new SqlParameter("@Description", SqlDbType.NVarChar, 70);
            param[3].Value = Description;

            param[4] = new SqlParameter("@Date", SqlDbType.Date);
            param[4].Value = Date;

            DAL.ExecuteCommand("Treasury_Update", param);
        }
        #endregion
    }
}
