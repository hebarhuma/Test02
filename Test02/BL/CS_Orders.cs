using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Take_Away.BL
{
    class CS_Orders
    {
        DataAccessLayer DAL = new DataAccessLayer();

        #region///////////////////Orders///////////////////////////////////

        //Orders_View
        public DataTable Orders_View()
        {
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("Orders_View", null);
            return Dt;
        }
        //Orders_Add()
        public void Orders_Add(int OrderID,
                               int MarketerID,
                               int Bill_ID,
                               string phone,
                               int AreaNum)
        {
            SqlParameter[] param = new SqlParameter[5];

            param[0] = new SqlParameter("@OrderID", SqlDbType.Int);
            param[0].Value = OrderID;

            param[1] = new SqlParameter("@MarketerID", SqlDbType.Int);
            param[1].Value = MarketerID;

            param[2] = new SqlParameter("@Bill_ID", SqlDbType.Int);
            param[2].Value = Bill_ID;

            param[3] = new SqlParameter("@phone", SqlDbType.NVarChar,12);
            param[3].Value = phone;

            param[4] = new SqlParameter("@AreaNum", SqlDbType.Int);
            param[4].Value = AreaNum;

            DAL.ExecuteCommand("Orders_Add", param);


        }
        //Orders_Edit()
        public void Orders_Edit(int OrderID, 
                                int MarketerID, 
                                int Bill_ID, 
                                string phone, 
                                int AreaNum)
        {
            SqlParameter[] param = new SqlParameter[5];

            param[0] = new SqlParameter("@OrderID", SqlDbType.Int);
            param[0].Value = OrderID;

            param[1] = new SqlParameter("@MarketerID", SqlDbType.Int);
            param[1].Value = MarketerID;

            param[2] = new SqlParameter("@Bill_ID", SqlDbType.Int);
            param[2].Value = Bill_ID;

            param[3] = new SqlParameter("@phone", SqlDbType.NVarChar,12);
            param[3].Value = phone;

            param[4] = new SqlParameter("@AreaNum", SqlDbType.Int);
            param[4].Value = AreaNum;

            DAL.ExecuteCommand("Orders_Edit", param);

        }
        //Orders_Search()
        public DataTable Orders_Search(string txtSEARCH)
        {
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@txtSEARCH", SqlDbType.NVarChar, 150);
            param[0].Value = txtSEARCH;

            Dt = DAL.SelectData("Orders_Search", param);
            return Dt;
        }
        #endregion
    }
}
