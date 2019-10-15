using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Take_Away.BL
{
    class CS_Establishment
    {
        DataAccessLayer DAL = new DataAccessLayer();

        #region///////////////////Establishment////////////////////////////

        //Establishment_View
        public DataTable Establishment_View()
        {
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("Establishment_View", null);
            return Dt;
        }

        //Establishment_View_Imge
        public DataTable Establishment_View_Imge(int ID)
        {
            DataTable dt = new DataTable();
            SqlParameter[] pram = new SqlParameter[1];
            pram[0] = new SqlParameter("@ID", SqlDbType.Int);
            pram[0].Value = ID;
            dt = DAL.SelectData("Establishment_View_Imge", pram);
            DAL.Close();
            return dt;
        }

        //Establishment_Add()
        public void Establishment_Add(string ShopName,
                                       string Branch,
                                       string Address,
                                       byte[] Logo, 
                                       string Phone,
                                       string Email, 
                                       string WepSite, 
                                       int TaxFileNum,
                                       int TreasuryID,
                                       int AccountNum)
        {
            SqlParameter[] param = new SqlParameter[10];

            param[0] = new SqlParameter("@ShopName", SqlDbType.NVarChar,150);
            param[0].Value = ShopName;

            param[1] = new SqlParameter("@Branch", SqlDbType.NVarChar,70);
            param[1].Value = Branch;

            param[2] = new SqlParameter("@Address", SqlDbType.NVarChar,70);
            param[2].Value = Address;

            param[3] = new SqlParameter("@Logo", SqlDbType.Image);
            param[3].Value = Logo;

            param[4] = new SqlParameter("@Phone", SqlDbType.NVarChar,12);
            param[4].Value = Phone;

            param[5] = new SqlParameter("@Email", SqlDbType.NVarChar,100);
            param[5].Value = Email;

            param[6] = new SqlParameter("@WepSite", SqlDbType.NVarChar, 150);
            param[6].Value = WepSite;

            param[7] = new SqlParameter("@TaxFileNum", SqlDbType.Int);
            param[7].Value = TaxFileNum;

            param[8] = new SqlParameter("@TreasuryID", SqlDbType.Int);
            param[8].Value = TreasuryID;

            param[9] = new SqlParameter("@AccountNum", SqlDbType.Int);
            param[9].Value = AccountNum;

            DAL.ExecuteCommand("Establishment_Add", param);
        }

        //Establishment_Edit()
        public void Establishment_Edit(int ID,
                                       string ShopName,
                                       string Branch,
                                       string Address,
                                       byte[] Logo,
                                       int Phone,
                                       string Email,
                                       string WepSite,
                                       int TaxFileNum,
                                       int TreasuryID,
                                       int AccountNum)
        {
            SqlParameter[] param = new SqlParameter[11];

            param[0] = new SqlParameter("@ID", SqlDbType.Int);
            param[0].Value = ID;

            param[1] = new SqlParameter("@ShopName", SqlDbType.NVarChar, 150);
            param[1].Value = ShopName;

            param[2] = new SqlParameter("@Branch", SqlDbType.NVarChar, 70);
            param[2].Value = Branch;

            param[3] = new SqlParameter("@Address", SqlDbType.NVarChar, 70);
            param[3].Value = Address;

            param[4] = new SqlParameter("@Logo", SqlDbType.Image);
            param[4].Value = Logo;

            param[5] = new SqlParameter("@Phone", SqlDbType.Int);
            param[5].Value = Phone;

            param[6] = new SqlParameter("@Email", SqlDbType.NVarChar, 100);
            param[6].Value = Email;

            param[7] = new SqlParameter("@WepSite", SqlDbType.NVarChar, 150);
            param[7].Value = WepSite;

            param[8] = new SqlParameter("@TaxFileNum", SqlDbType.Int);
            param[8].Value = TaxFileNum;

            param[9] = new SqlParameter("@TreasuryID", SqlDbType.Int);
            param[9].Value = TreasuryID;

            param[10] = new SqlParameter("@AccountNum", SqlDbType.Int);
            param[10].Value = AccountNum;

            DAL.ExecuteCommand("Establishment_Update", param);
        }
        #endregion

        #region///////////////////Tables///////////////////////////////////

        //Tables_View
        public DataTable Tables_View()
        {
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("Tables_View", null);
            return Dt;
        }
        //Tables_Add()
        public void Tables_Add(int Num_chairs,char TableStatus)
        {
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@Num_chairs", SqlDbType.Int);
            param[0].Value = Num_chairs;

            param[1] = new SqlParameter("@TableStatus", SqlDbType.Char,1);
            param[1].Value = TableStatus;

            DAL.ExecuteCommand("Tables_Add", param);
        }
        //Tables_Edit()
        public void Tables_Edit(int Table_ID, int Num_chairs, char TableStatus)
        {
            SqlParameter[] param = new SqlParameter[3];

            param[0] = new SqlParameter("@Table_ID", SqlDbType.Int);
            param[0].Value = Table_ID;

            param[1] = new SqlParameter("@Num_chairs", SqlDbType.Int);
            param[1].Value = Num_chairs;

            param[2] = new SqlParameter("@TableStatus", SqlDbType.Char, 1);
            param[2].Value = TableStatus;

            DAL.ExecuteCommand("Tables_Edit", param);
        }
        #endregion
    }
}
