using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Take_Away.BL
{
    class CS_Supplier
    {
        DataAccessLayer DAL = new DataAccessLayer();

        #region ///////////////////Suppliers///////////////////////////////

        //Supplier_View
        public DataTable Supplier_View()
        {
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("Supplier_View", null);
            return Dt;
        }
        //Supplier_Add()
        public void Supplier_Add(string SupplierName, 
                                 string Company, 
                                 string Address)
        {
            SqlParameter[] param = new SqlParameter[3];

            param[0] = new SqlParameter("@SupplierName", SqlDbType.NVarChar,65);
            param[0].Value = SupplierName;

            param[1] = new SqlParameter("@Company ", SqlDbType.NVarChar,50);
            param[1].Value = Company;

            param[2] = new SqlParameter("@Address", SqlDbType.NVarChar,50);
            param[2].Value = Address;

            DAL.ExecuteCommand("Supplier_Add", param);


        }
        //Supplier_Edit()
        public void Supplier_Edit(int SupplierID, 
                                  string SupplierName, 
                                  string Company,
                                  string Address)
        {
            SqlParameter[] param = new SqlParameter[4];

            param[0] = new SqlParameter("@SupplierID", SqlDbType.Int);
            param[0].Value = SupplierID;

            param[1] = new SqlParameter("@SupplierName", SqlDbType.NVarChar, 65);
            param[1].Value = SupplierName;

            param[2] = new SqlParameter("@Company ", SqlDbType.NVarChar, 50);
            param[2].Value = Company;

            param[3] = new SqlParameter("@Address", SqlDbType.NVarChar, 50);
            param[3].Value = Address;

            DAL.ExecuteCommand("Supplier_Edit", param);

        }
        //Supplier_Search()
        public DataTable Supplier_Search(string txtSEARCH)
        {
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@txtSEARCH", SqlDbType.NVarChar, 150);
            param[0].Value = txtSEARCH;

            Dt = DAL.SelectData("Supplier_Search", param);
            return Dt;
        }
        #endregion

        #region ////////////////SupplierPhoneNum///////////////////////////

        //SupplierPhoneNum_View
        public DataTable SupplierPhoneNum_View(int SupplierID)
        {
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@SupplierID", SqlDbType.Int);
            param[0].Value = SupplierID;

            Dt = DAL.SelectData("SupplierPhoneNum_View", param);
            return Dt;
        }
        //SupplierPhoneNum_Add()
        public void SupplierPhoneNum_Add(int SupplierID,
                                 string Phone1,
                                 string Phone2,
                                 string Phone3)
        {
            SqlParameter[] param = new SqlParameter[4];

            param[0] = new SqlParameter("@SupplierID", SqlDbType.Int);
            param[0].Value = SupplierID;

            param[1] = new SqlParameter("@Phone1 ", SqlDbType.NVarChar, 12);
            param[1].Value = Phone1;

            param[2] = new SqlParameter("@Phone2 ", SqlDbType.NVarChar, 12);
            param[2].Value = Phone2;

            param[3] = new SqlParameter("@Phone3 ", SqlDbType.NVarChar, 12);
            param[3].Value = Phone3;

            DAL.ExecuteCommand("SupplierPhoneNum_Add", param);


        }
        //SupplierPhoneNum_Edit()
        public void SupplierPhoneNum_Edit(int SupplierID,
                                 string Phone1,
                                 string Phone2,
                                 string Phone3)
        {
            SqlParameter[] param = new SqlParameter[4];

            param[0] = new SqlParameter("@SupplierID", SqlDbType.Int);
            param[0].Value = SupplierID;

            param[1] = new SqlParameter("@Phone1 ", SqlDbType.NVarChar, 12);
            param[1].Value = Phone1;

            param[2] = new SqlParameter("@Phone2 ", SqlDbType.NVarChar, 12);
            param[2].Value = Phone2;

            param[3] = new SqlParameter("@Phone3 ", SqlDbType.NVarChar, 12);
            param[3].Value = Phone3;

            DAL.ExecuteCommand("SupplierPhoneNum_Edit", param);

        }
        #endregion

        #region///////////////////SupplierPayments////////////////////////

        //SupplierPayments_View()
        public DataTable SupplierPayments_View()
        {
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("SupplierPayments_View", null);
            return Dt;
        }
        //SupplierPayments_Add()
        public void SupplierPayments_Add(int EmployID, 
                                         int Bill_ID, 
                                         DateTime date, 
                                         decimal PaidUp,
                                         decimal Rest)
        {
            SqlParameter[] param = new SqlParameter[5];

            param[0] = new SqlParameter("@EmployID", SqlDbType.Int);
            param[0].Value = EmployID;

            param[1] = new SqlParameter("@Bill_ID ", SqlDbType.Int);
            param[1].Value = Bill_ID;

            param[2] = new SqlParameter("@date ", SqlDbType.Date);
            param[2].Value = date;

            param[3] = new SqlParameter("@PaidUp", SqlDbType.Money);
            param[3].Value = PaidUp;

            param[4] = new SqlParameter("@Rest ", SqlDbType.Money);
            param[4].Value = Rest;

            DAL.ExecuteCommand("SupplierPayments_Add", param);
        }
        //SupplierPayments_Edit()
        public void SupplierPayments_Edit(int PaidID, 
                                          int EmployID, 
                                          int Bill_ID, 
                                          DateTime date, 
                                          decimal PaidUp, 
                                          decimal Rest)
        {
            SqlParameter[] param = new SqlParameter[6];

            param[0] = new SqlParameter("@PaidID ", SqlDbType.Int);
            param[0].Value = PaidID;

            param[1] = new SqlParameter("@EmployID", SqlDbType.Int);
            param[1].Value = EmployID;

            param[2] = new SqlParameter("@Bill_ID ", SqlDbType.Int);
            param[2].Value = Bill_ID;

            param[3] = new SqlParameter("@date ", SqlDbType.Date);
            param[3].Value = date;

            param[4] = new SqlParameter("@PaidUp", SqlDbType.Money);
            param[4].Value = PaidUp;

            param[5] = new SqlParameter("@Rest ", SqlDbType.Money);
            param[5].Value = Rest;

            DAL.ExecuteCommand("SupplierPayments_Edit", param);

        }
        //SupplierPayments_Search()
        public DataTable SupplierPayments_Search(string txtSEARCH)
        {
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@txtSEARCH", SqlDbType.NVarChar, 150);
            param[0].Value = txtSEARCH;

            Dt = DAL.SelectData("SupplierPayments_Search", param);
            return Dt;
        }
        #endregion
    }
}
