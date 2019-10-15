using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Take_Away.BL
{
    class CS_Categories
    {
        DataAccessLayer DAL = new DataAccessLayer();

        #region/////////////Categories/////////////////////////////

        //Categories_View
        public DataTable Categories_View()
        {
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("Categories_View", null);
            return Dt;
        }

        //Categories_View_Image
        public DataTable Categories_View_Image(int CategoryID)
        {
            DataTable dt = new DataTable();

            SqlParameter[] pram = new SqlParameter[1];

            pram[0] = new SqlParameter("@CategoryID", SqlDbType.Int);
            pram[0].Value = CategoryID;

            dt = DAL.SelectData("Categories_View_Image", pram);
            DAL.Close();
            return dt;
        }

        //Categories_Add()
        public void Categories_Add(string CategoryName, byte[] CategoryImage, char CategoryType)
        {
            SqlParameter[] param = new SqlParameter[3];

            param[0] = new SqlParameter("@CategoryName", SqlDbType.NVarChar, 55);
            param[0].Value = CategoryName;

            param[1] = new SqlParameter("@CategoryImage", SqlDbType.Image);
            param[1].Value = CategoryImage;

            param[2] = new SqlParameter("@CategoryType", SqlDbType.Char,1);
            param[2].Value = CategoryType;

            DAL.ExecuteCommand("Categories_Add", param);
        }
        
        //Categories_Edit()
        public void Categories_Edit(int CategoryID, string CategoryName, char CategoryType)
        {
            SqlParameter[] param = new SqlParameter[3];

            param[0] = new SqlParameter("@CategoryID", SqlDbType.Int);
            param[0].Value = CategoryID;

            param[1] = new SqlParameter("@CategoryName", SqlDbType.NVarChar, 25);
            param[1].Value = CategoryName;

            param[2] = new SqlParameter("@CategoryType ", SqlDbType.Char,1);
            param[2].Value = CategoryType;

            DAL.ExecuteCommand("Categories_Edit", param);
        }

        //Categories_Search()
        public DataTable Categories_Search(string txtSEARCH)
        {
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@txtSEARCH", SqlDbType.NVarChar, 150);
            param[0].Value = txtSEARCH;

            Dt = DAL.SelectData("Categories_Search", param);
            return Dt;
        }

        #endregion
    }
}
