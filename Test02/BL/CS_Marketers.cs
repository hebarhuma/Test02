using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Take_Away.BL
{
    class CS_Marketers
    {
        DataAccessLayer DAL = new DataAccessLayer();

        #region///////////////////Areass///////////////////////////////////

        //Areas_View
        public DataTable Areas_View()
        {
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("Areas_View", null);
            return Dt;
        }
        //Areas_Add()
        public void Areas_Add(string AreaName, decimal AreaPrice)
        {
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@AreaName", SqlDbType.NVarChar, 30);
            param[0].Value = AreaName;

            param[1] = new SqlParameter("@AreaPrice", SqlDbType.Money);
            param[1].Value = AreaPrice;

            DAL.ExecuteCommand("Areas_Add", param);


        }
        //Areas_Edit()
        public void Areas_Edit(int AreaNum, string AreaName, decimal AreaPrice)
        {
            SqlParameter[] param = new SqlParameter[3];

            param[0] = new SqlParameter("@AreaNum", SqlDbType.Int);
            param[0].Value = AreaNum;

            param[1] = new SqlParameter("@AreaName", SqlDbType.NVarChar, 30);
            param[1].Value = AreaName;

            param[2] = new SqlParameter("@AreaPrice", SqlDbType.Money);
            param[2].Value = AreaPrice;

            DAL.ExecuteCommand("Areas_Edit", param);
        }
        //Areas_Search()
        public DataTable Areas_Search(string txtSEARCH)
        {
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@txtSEARCH", SqlDbType.NVarChar, 150);
            param[0].Value = txtSEARCH;

            Dt = DAL.SelectData("Areas_Search", param);
            return Dt;
        }
        #endregion

        #region////////////////////Marketers///////////////////////////////

        //Marketers_View
        public DataTable Marketer_View()
        {
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("Marketer_View", null);
            return Dt;
        }
        //Marketer_Add()
        public void Marketers_Add(string MarketerName,string MarketerAddress, string MarketerPhone,char status)
        {
            SqlParameter[] param = new SqlParameter[4];

            param[0] = new SqlParameter("@MarketerName", SqlDbType.NVarChar, 50);
            param[0].Value = MarketerName;

            param[1] = new SqlParameter("@MarketerAddress", SqlDbType.NVarChar, 50);
            param[1].Value = MarketerAddress;

            param[2] = new SqlParameter("@MarketerPhone", SqlDbType.NVarChar,12);
            param[2].Value = MarketerPhone;

            param[3] = new SqlParameter("@status", SqlDbType.Char,1);
            param[3].Value = status;

            DAL.ExecuteCommand("Marketers_Add", param);
        }
        //Marketer_Edit()
        public void Marketers_Edit(int MarketerID,string MarketerName, string MarketerAddress, string MarketerPhone, char status)
        {
            SqlParameter[] param = new SqlParameter[5];

            param[0] = new SqlParameter("@MarketerID", SqlDbType.Int);
            param[0].Value = MarketerID;

            param[1] = new SqlParameter("@MarketerName", SqlDbType.NVarChar, 50);
            param[1].Value = MarketerName;

            param[2] = new SqlParameter("@MarketerAddress", SqlDbType.NVarChar, 50);
            param[2].Value = MarketerAddress;

            param[3] = new SqlParameter("@MarketerPhone", SqlDbType.NVarChar,12);
            param[3].Value = MarketerPhone;

            param[4] = new SqlParameter("@status", SqlDbType.Char, 1);
            param[4].Value = status;

            DAL.ExecuteCommand("Marketers_Edit", param);

        }
        //Marketer_Search()
        public DataTable Marketer_Search(string txtSEARCH)
        {
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@txtSEARCH", SqlDbType.NVarChar, 150);
            param[0].Value = txtSEARCH;

            Dt = DAL.SelectData("Marketer_Search", param);
            return Dt;
        }
        #endregion
    }
}
