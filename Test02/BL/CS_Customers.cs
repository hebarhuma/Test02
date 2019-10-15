using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Take_Away.BL
{
    class CS_Customers
    {
        DataAccessLayer DAL = new DataAccessLayer();

        #region/////////////Customer Type/////////////////////////////

        //CustomerType_View()
        public DataTable CustomerType_View()
        {
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("CustomerType_View", null);
            return Dt;
        }
        //CustomerType_Add()
        public void CustomerType_Add(string CustomerType)
        {
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@CustomerType", SqlDbType.NVarChar,50);
            param[0].Value = CustomerType;

            DAL.ExecuteCommand("CustomerType_Add", param);
        }
        //CustomerType_Edit()
        public void CustomerType_Edit(int ID,string CustomerType)
        {
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@ID", SqlDbType.Int);
            param[0].Value = ID;

            param[1] = new SqlParameter("@CustomerType", SqlDbType.NVarChar, 50);
            param[1].Value = CustomerType;

            DAL.ExecuteCommand("CustomerType_Edit", param);
        }
        //CustomerType_Search()
        public DataTable CustomerType_Search(string txtSEARCH)
        {
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@txtSEARCH", SqlDbType.NVarChar, 150);
            param[0].Value = txtSEARCH;

            Dt = DAL.SelectData("CustomerType_Search", param);
            return Dt;
        }
        #endregion

        #region/////////////Customers/////////////////////////////////

        //Customers_View()
        public DataTable Customers_View()
        {
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("Customers_View", null);
            return Dt;
        }
        //Customers_Add()
        public void Customers_Add(string CustomerName, string CustomerPhone, string CustomerAddress)
        {
            SqlParameter[] param = new SqlParameter[3];

            param[0] = new SqlParameter("@CustomerName", SqlDbType.NVarChar,70);
            param[0].Value = CustomerName;

            param[1] = new SqlParameter("@CustomerPhone ", SqlDbType.NVarChar,12);
            param[1].Value = CustomerPhone;

            param[2] = new SqlParameter("@CustomerAddress", SqlDbType.NVarChar, 50);
            param[2].Value = CustomerAddress;

            DAL.ExecuteCommand("Customers_Add", param);


        }
        //Customers_Edit()
        public void Customers_Edit(int CustomerID, string CustomerName, string CustomerPhone, string CustomerAddress)
        { 
            SqlParameter[] param = new SqlParameter[4];

            param[0] = new SqlParameter("@CustomerID ", SqlDbType.Int);
            param[0].Value = CustomerID;

            param[1] = new SqlParameter("@CustomerName", SqlDbType.NVarChar, 70);
            param[1].Value = CustomerName;

            param[2] = new SqlParameter("@CustomerPhone ", SqlDbType.NVarChar,12);
            param[2].Value = CustomerPhone;

            param[3] = new SqlParameter("@CustomerAddress", SqlDbType.NVarChar, 50);
            param[3].Value = CustomerAddress;

            DAL.ExecuteCommand("Customers_Edit", param);

        }
        //Customers_Search()
        public DataTable Customers_Search(string txtSEARCH)
        {
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@txtSEARCH", SqlDbType.NVarChar, 150);
            param[0].Value = txtSEARCH;

            Dt = DAL.SelectData("Customers_Search", param);
            return Dt;
        }
        #endregion

        #region/////////////Customers Debts///////////////////////////

        //CustomersDebts_View()
        public DataTable CustomersDebts_View()
        {
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("CustomersDebts_View", null);
            return Dt;
        }
        //CustomersDebts_Add()
        public void CustomersDebts_Add( int Bill_ID,decimal PaidUp, decimal Rest,char StateDebt)
        {
            SqlParameter[] param = new SqlParameter[4];

            param[0] = new SqlParameter("@Bill_ID ", SqlDbType.Int);
            param[0].Value = Bill_ID;

            param[1] = new SqlParameter("@PaidUp", SqlDbType.Money);
            param[1].Value = PaidUp;

            param[2] = new SqlParameter("@Rest ", SqlDbType.Money);
            param[2].Value = Rest;

            param[3] = new SqlParameter("@StateDebt ", SqlDbType.Char,1);
            param[3].Value = StateDebt;

            DAL.ExecuteCommand("CustomersDebts_Add", param);
        }
        //CustomersDebts_Edit()
        public void CustomersDebts_Edit(int SequentialID, int Bill_ID, decimal PaidUp, decimal Rest, char StateDebt)
        {
            SqlParameter[] param = new SqlParameter[5];

            param[0] = new SqlParameter("@SequentialID ", SqlDbType.Int);
            param[0].Value = SequentialID;

            param[1] = new SqlParameter("@Bill_ID ", SqlDbType.Int);
            param[1].Value = Bill_ID;

            param[2] = new SqlParameter("@PaidUp", SqlDbType.Money);
            param[2].Value = PaidUp;

            param[3] = new SqlParameter("@Rest ", SqlDbType.Money);
            param[3].Value = Rest;

            param[4] = new SqlParameter("@StateDebt ", SqlDbType.Char, 1);
            param[4].Value = StateDebt;

            DAL.ExecuteCommand("CustomersDebts_Edit", param);
        }
        //CustomersDebts_Search()
        public DataTable CustomersDebts_Search(string txtSEARCH)
        {
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@txtSEARCH", SqlDbType.NVarChar, 150);
            param[0].Value = txtSEARCH;

            Dt = DAL.SelectData("CustomersDebts_Search", param);
            return Dt;
        }
        #endregion

        #region/////////////Customer Account//////////////////////////

        //CustomerAccount_View()
        public DataTable CustomerAccount_View()
        {
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("CustomerAccount_View", null);
            return Dt;
        }
        //CustomerAccount_Add()
        public void CustomerAccount_Add(int CustomerID,
                                        string PSW,
                                        decimal DebtCeiling,
                                        decimal Balance,
                                        char AccountStatus,
                                        int EmployID,
                                        int Points,
                                        DateTime Date)
        {
            SqlParameter[] param = new SqlParameter[8];

            param[0] = new SqlParameter("@CustomerID ", SqlDbType.Int);
            param[0].Value = CustomerID;

            param[1] = new SqlParameter("@PSW", SqlDbType.NVarChar,12);
            param[1].Value = PSW;

            param[2] = new SqlParameter("@DebtCeiling ", SqlDbType.Money);
            param[2].Value = DebtCeiling;

            param[3] = new SqlParameter("@Balance ", SqlDbType.Money);
            param[3].Value = Balance;

            param[4] = new SqlParameter("@AccountStatus ", SqlDbType.Char,1);
            param[4].Value = AccountStatus;

            param[5] = new SqlParameter("@EmployID ", SqlDbType.Int);
            param[5].Value = EmployID;

            param[6] = new SqlParameter("@Points ", SqlDbType.Int);
            param[6].Value = Points;

            param[7] = new SqlParameter("@Date ", SqlDbType.Date);
            param[7].Value = Date;

            DAL.ExecuteCommand("CustomersDebts_Add", param);
        }
        //CustomerAccount_Edit()
        public void CustomerAccount_Edit(int CustomerID, 
                                         string PSW, 
                                         decimal DebtCeiling,
                                         decimal Balance, 
                                         char AccountStatus, 
                                         int EmployID,
                                         int Points, 
                                         DateTime Date)
        {
            SqlParameter[] param = new SqlParameter[8];

            param[0] = new SqlParameter("@CustomerID ", SqlDbType.Int);
            param[0].Value = CustomerID;

            param[1] = new SqlParameter("@PSW", SqlDbType.NVarChar, 12);
            param[1].Value = PSW;

            param[2] = new SqlParameter("@DebtCeiling ", SqlDbType.Money);
            param[2].Value = DebtCeiling;

            param[3] = new SqlParameter("@Balance ", SqlDbType.Money);
            param[3].Value = Balance;

            param[4] = new SqlParameter("@AccountStatus ", SqlDbType.Char, 1);
            param[4].Value = AccountStatus;

            param[5] = new SqlParameter("@EmployID ", SqlDbType.Int);
            param[5].Value = EmployID;

            param[6] = new SqlParameter("@Points ", SqlDbType.Int);
            param[6].Value = Points;

            param[7] = new SqlParameter("@Date ", SqlDbType.Date);
            param[7].Value = Date;

            DAL.ExecuteCommand("CustomerAccount_Edit", param);
        }
        //CustomerAccount_Search()
        public DataTable CustomerAccount_Search(string txtSEARCH)
        {
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@txtSEARCH", SqlDbType.NVarChar, 150);
            param[0].Value = txtSEARCH;

            Dt = DAL.SelectData("CustomerAccount_Search", param);
            return Dt;
        }
        #endregion

        #region/////////////Payments Customer/////////////////////////

        //PaymentsCustomer_View()
        public DataTable PaymentsCustomer_View()
        {
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("PaymentsCustomer_View", null);
            return Dt;
        }
        //PaymentsCustomer_Add()
        public void PaymentsCustomer_Add(int CustomerID, 
                                         int EmployID,
                                         string Operation,
                                         decimal Amount,
                                         DateTime Date,
                                         string Notes)
        {
            SqlParameter[] param = new SqlParameter[5];

            param[0] = new SqlParameter("@CustomerID", SqlDbType.Int);
            param[0].Value = CustomerID;

            param[1] = new SqlParameter("@EmployID", SqlDbType.Int);
            param[1].Value = EmployID;

            param[2] = new SqlParameter("@Operation ", SqlDbType.NVarChar,50);
            param[2].Value = Operation;

            param[3] = new SqlParameter("@Amount ", SqlDbType.Money);
            param[3].Value = Amount;

            param[4] = new SqlParameter("@Date", SqlDbType.Date);
            param[4].Value = Date;

            param[5] = new SqlParameter("@Notes ", SqlDbType.NVarChar,70);
            param[5].Value = Notes;

            DAL.ExecuteCommand("PaymentsCustomer_Add", param);
        }
        //PaymentsCustomer_Editt()
        public void PaymentsCustomer_Edit(int CustomerID, 
                                          int EmployID, 
                                          string Operation, 
                                          decimal Amount, 
                                          DateTime Date, 
                                          string Notes)
        {
            SqlParameter[] param = new SqlParameter[5];

            param[0] = new SqlParameter("@CustomerID", SqlDbType.Int);
            param[0].Value = CustomerID;

            param[1] = new SqlParameter("@EmployID", SqlDbType.Int);
            param[1].Value = EmployID;

            param[2] = new SqlParameter("@Operation ", SqlDbType.NVarChar, 50);
            param[2].Value = Operation;

            param[3] = new SqlParameter("@Amount ", SqlDbType.Money);
            param[3].Value = Amount;

            param[4] = new SqlParameter("@Date", SqlDbType.Date);
            param[4].Value = Date;

            param[5] = new SqlParameter("@Notes ", SqlDbType.NVarChar, 70);
            param[5].Value = Notes;

            DAL.ExecuteCommand("PaymentsCustomer_Edit", param);
        }
        //PaymentsCustomer_Search()
        public DataTable PaymentsCustomer_Search(string txtSEARCH)
        {
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@txtSEARCH", SqlDbType.NVarChar, 150);
            param[0].Value = txtSEARCH;

            Dt = DAL.SelectData("PaymentsCustomer_Search", param);
            return Dt;
        }
        #endregion
    }
}
