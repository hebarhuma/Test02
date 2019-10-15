using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Take_Away.BL
{
    class CS_Users
    {
        DataAccessLayer DAL = new DataAccessLayer();

        #region//////////////////Users///////////////////////////////////

        //User_View()
        public DataTable User_View()
        {
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("User_View", null);
            return Dt;
        }
        //User_Add()
        public void User_Add(string UserName,
                             string PSW, 
                             int EmployID,
                             char Account_status)
        {
            SqlParameter[] param = new SqlParameter[4];

            param[0] = new SqlParameter("@UserName", SqlDbType.NVarChar, 50);
            param[0].Value = UserName;

            param[1] = new SqlParameter("@PSW", SqlDbType.NVarChar,12);
            param[1].Value = PSW;

            param[2] = new SqlParameter("@EmployID", SqlDbType.Int);
            param[2].Value = EmployID;

            param[3] = new SqlParameter("@Account_status", SqlDbType.Char);
            param[3].Value = Account_status;

            DAL.ExecuteCommand("User_Add", param);
        }
        //User_Edit()
        public void User_Edit(string UserName, 
                              string PSW, 
                              int EmployID, 
                              char Account_status)
        {
            SqlParameter[] param = new SqlParameter[4];

            param[0] = new SqlParameter("@UserName", SqlDbType.NVarChar, 50);
            param[0].Value = UserName;

            param[1] = new SqlParameter("@PSW", SqlDbType.NVarChar, 12);
            param[1].Value = PSW;

            param[2] = new SqlParameter("@EmployID", SqlDbType.Int);
            param[2].Value = EmployID;

            param[3] = new SqlParameter("@Account_status", SqlDbType.Char);
            param[3].Value = Account_status;

            DAL.ExecuteCommand("User_Edit", param);

        }
        //User_Search()
        public DataTable User_Search(string txtSEARCH)
        {
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@txtSEARCH", SqlDbType.NVarChar, 150);
            param[0].Value = txtSEARCH;

            Dt = DAL.SelectData("User_Search", param);
            return Dt;
        }
        #endregion

        #region //////////////////Validity////////////////////////////////

        //Validity_View()
        public DataTable Validity_View()
        {
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("Validity_View", null);
            return Dt;
        }
        //Validity_Add()
        public void Validity_Add(string Validity)
        {
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@Validity", SqlDbType.NVarChar, 80);
            param[0].Value = Validity;

            DAL.ExecuteCommand("Validity_Add", param);
        }
        //Validity_Edit()
        public void Validity_Edit(int ValidityNum, string Validity)
        {
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@ValidityNum", SqlDbType.Int);
            param[0].Value = ValidityNum;

            param[1] = new SqlParameter("@Validity", SqlDbType.NVarChar, 80);
            param[1].Value = Validity;

            DAL.ExecuteCommand("Validity_Edit", param);

        }
        //Validity_search()
        public DataTable Validity_search(string txtSEARCH)
        {
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@txtSEARCH", SqlDbType.NVarChar, 150);
            param[0].Value = txtSEARCH;

            Dt = DAL.SelectData("Validity_search", param);
            return Dt;
        }
        #endregion

        #region//////////////////User_Validity///////////////////////////

        //UsersValidity_View()
        public DataTable UsersValidity_View()
        {
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("UsersValidity_View", null);
            return Dt;
        }
        //UsersValidity_Add()
        public void UsersValidity_Add(string UserName,
                                        int Validity,
                                        char Status)
        {
            SqlParameter[] param = new SqlParameter[3];

            param[0] = new SqlParameter("@UserName", SqlDbType.NVarChar, 50);
            param[0].Value = UserName;

            param[1] = new SqlParameter("@Validity", SqlDbType.Int);
            param[1].Value = Validity;

            param[2] = new SqlParameter("@Status", SqlDbType.Char,1);
            param[2].Value = Status;

            DAL.ExecuteCommand("UsersValidity_Add", param);
        }
        //UsersValidity_Edit()
        public void UsersValidity_Edit(string UserName, 
                                       int Validity, 
                                       char Status)
        {
            SqlParameter[] param = new SqlParameter[3];

            param[0] = new SqlParameter("@UserName", SqlDbType.NVarChar, 50);
            param[0].Value = UserName;

            param[1] = new SqlParameter("@Validity", SqlDbType.Int);
            param[1].Value = Validity;

            param[2] = new SqlParameter("@Status", SqlDbType.Char, 1);
            param[2].Value = Status;

            DAL.ExecuteCommand("UsersValidity_Edit", param);

        }
        //UsersValidity_Search()
        public DataTable UsersValidity_Search(string txtSEARCH)
        {
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@txtSEARCH", SqlDbType.NVarChar, 150);
            param[0].Value = txtSEARCH;

            Dt = DAL.SelectData("UsersValidity_Search", param);
            return Dt;
        }
        #endregion
    }
}
