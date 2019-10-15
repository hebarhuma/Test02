using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Take_Away.BL
{
    class CS_PaymentStyle
    {
        DataAccessLayer DAL = new DataAccessLayer();

        #region///////////////////PaymentStyles/////////////////////////////////

        //PaymentStyles_View
        public DataTable PaymentStyles_View()
        {
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("PaymentStyles_View", null);
            return Dt;
        }

        //PaymentStyles_Add
        public void PaymentStyles_Add(string PaymentType, decimal Ratio)
        {
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@PaymentType", SqlDbType.NVarChar, 15);
            param[0].Value = PaymentType;

            param[1] = new SqlParameter("@Ratio", SqlDbType.Float);
            param[1].Value = Ratio;

            DAL.ExecuteCommand("PaymentStyles_Add", param);
        }

        //PaymentStyles_Edit
        public void PaymentStyles_Edit(int PaymentStyleNum, string PaymentType, decimal Ratio)
        {
            SqlParameter[] param = new SqlParameter[3];

            param[0] = new SqlParameter("@PaymentStyleNum", SqlDbType.Int);
            param[0].Value = PaymentStyleNum;

            param[1] = new SqlParameter("@PaymentType", SqlDbType.NVarChar, 15);
            param[1].Value = PaymentType;

            param[2] = new SqlParameter("@Ratio", SqlDbType.Float);
            param[2].Value = Ratio;

            DAL.ExecuteCommand("PaymentStyles_Edit", param);
        }

        //PaymentStyles_Search
        public DataTable PaymentStyles_Search(string txtSEARCH)
        {
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@txtSEARCH", SqlDbType.NVarChar, 150);
            param[0].Value = txtSEARCH;

            Dt = DAL.SelectData("PaymentStyles_Search", param);
            return Dt;
        }
        #endregion
    }
}
