using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Take_Away.BL
{
    class CS_Expenses
    {
        DataAccessLayer DAL = new DataAccessLayer();

        #region///////////////////Items_Expenses////////////////////////////

        //ItemsExpenses_View()
        public DataTable ItemsExpenses_View()
        {
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("ItemsExpenses_View", null);
            return Dt;
        }
        //ItemsExpenses_Add()
        public void ItemsExpenses_Add(string ItemName, string Note)
        {
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@ItemName", SqlDbType.NVarChar,50);
            param[0].Value = ItemName;

            param[1] = new SqlParameter("@Note ", SqlDbType.NVarChar,70);
            param[1].Value = Note;

            DAL.ExecuteCommand("ItemsExpenses_Add", param);
        }
        //ItemsExpenses_Edit()
        public void ItemsExpenses_Edit(int ItemID, string ItemName, string Note)
        {
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@ItemID", SqlDbType.Int);
            param[0].Value = ItemID;

            param[1] = new SqlParameter("@ItemName", SqlDbType.NVarChar, 50);
            param[1].Value = ItemName;

            param[2] = new SqlParameter("@Note ", SqlDbType.NVarChar, 70);
            param[2].Value = Note;

            DAL.ExecuteCommand("ItemsExpenses_Edit", param);

        }
        #endregion

        #region///////////////////Expenses//////////////////////////////////

        //Expenses_View()
        public DataTable Expenses_View()
        {
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("Expenses_View", null);
            return Dt;
        }
        //Expenses_Add()
        public void Expenses_Add(DateTime date,
                                 string Description,
                                 decimal Amount,
                                 int ItemID,
                                 string ExchangeType)
        {
            SqlParameter[] param = new SqlParameter[5];

            param[0] = new SqlParameter("@date", SqlDbType.Date);
            param[0].Value = date;

            param[1] = new SqlParameter("@Description ", SqlDbType.NVarChar, 70);
            param[1].Value = Description;

            param[2] = new SqlParameter("@Amount ", SqlDbType.Money);
            param[2].Value = Amount;

            param[3] = new SqlParameter("@ItemID", SqlDbType.Int);
            param[3].Value = ItemID;

            param[4] = new SqlParameter("@ExchangeType ", SqlDbType.NVarChar,50);
            param[4].Value = ExchangeType;

            DAL.ExecuteCommand("Expenses_Add", param);


        }
        //Expenses_Edit()
        public void Expenses_Edit(int SequentialID, 
                                  DateTime date, 
                                  string Description, 
                                  decimal Amount, 
                                  int ItemID, 
                                  string ExchangeType)
        {
            SqlParameter[] param = new SqlParameter[6];

            param[0] = new SqlParameter("@SequentialID", SqlDbType.Int);
            param[0].Value = SequentialID;

            param[1] = new SqlParameter("@date", SqlDbType.Date);
            param[1].Value = date;

            param[2] = new SqlParameter("@Description ", SqlDbType.NVarChar, 70);
            param[2].Value = Description;

            param[3] = new SqlParameter("@Amount ", SqlDbType.Money);
            param[3].Value = Amount;

            param[4] = new SqlParameter("@ItemID", SqlDbType.Int);
            param[4].Value = ItemID;

            param[5] = new SqlParameter("@ExchangeType ", SqlDbType.NVarChar, 50);
            param[5].Value = ExchangeType;

            DAL.ExecuteCommand("Expenses_Update", param);

        }
        //Expenses_Search()
        public DataTable Expenses_Search(string txtSEARCH)
        {
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@txtSEARCH", SqlDbType.NVarChar, 150);
            param[0].Value = txtSEARCH;

            Dt = DAL.SelectData("Expenses_Search", param);
            return Dt;
        }
        #endregion
    }
}
