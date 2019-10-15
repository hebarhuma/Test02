using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Take_Away.BL
{
    class CS_Store
    {
        DataAccessLayer DAL = new DataAccessLayer();
        
        #region////////////////// Stores ////////////////////
        
        //Store_View()
        public DataTable Store_View()
        {
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("Store_View", null);
            return Dt;
        }
        //Store_Add
        public void Store_Add(string StoreName, string StoreAddress)
        {
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@StoreName", SqlDbType.NVarChar, 35);
            param[0].Value = StoreName;

            param[1] = new SqlParameter("@StoreAddress", SqlDbType.NVarChar, 50);
            param[1].Value = StoreAddress;

            DAL.ExecuteCommand("Store_Add", param);
        }
        //Store_Edit
        public void Store_Edit(int StoreID, string StoreName, string StoreAddress)
        {
            SqlParameter[] param = new SqlParameter[3];

            param[0] = new SqlParameter("@StoreID", SqlDbType.Int);
            param[0].Value = StoreID;

            param[1] = new SqlParameter("@StoreName", SqlDbType.NVarChar, 35);
            param[1].Value = StoreName;

            param[2] = new SqlParameter("@StoreAddress", SqlDbType.NVarChar, 50);
            param[2].Value = StoreAddress;

            DAL.ExecuteCommand("Store_Edit", param);
        }

        #endregion

        #region//////////////ProcurementProduct//////////////

        //ProcurementProducts_View()
        public DataTable ProcurementProducts_View()
        {
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("ProcurementProducts_View", null);
            return Dt;
        }
        //ProcurementProducts_View_Imge
        public DataTable ProcurementProducts_View_Imge(int ProductID)
        {
            DataTable dt = new DataTable();

            SqlParameter[] pram = new SqlParameter[1];

            pram[0] = new SqlParameter("@ProductID", SqlDbType.Int);
            pram[0].Value = ProductID;

            dt = DAL.SelectData("ProcurementProducts_View_Imge", pram);
            DAL.Close();
            return dt;
        }
        //ProcurementProducts_Add()
        public void ProcurementProducts_Add(string ProductBarcode, 
                                            string ProductName,
                                            byte[] ProductImage, 
                                            int CategoryID, 
                                            int UnitID, 
                                            decimal ProductPrice, 
                                            DateTime ExpirationDate, 
                                            int Quantity, 
                                            int highestRate, 
                                            int Minimum, 
                                            int StoreID, 
                                            char Status, 
                                            char InLounge)
        {
            SqlParameter[] param = new SqlParameter[13];

            param[0] = new SqlParameter("@ProductBarcode", SqlDbType.NVarChar, 50);
            param[0].Value = ProductBarcode;

            param[1] = new SqlParameter("@ProductName", SqlDbType.NVarChar, 50);
            param[1].Value = ProductName;

            param[2] = new SqlParameter("@ProductImage", SqlDbType.Image);
            param[2].Value = ProductImage;

            param[3] = new SqlParameter("@CategoryID", SqlDbType.Int);
            param[3].Value = CategoryID;

            param[4] = new SqlParameter("@UnitID", SqlDbType.Int);
            param[4].Value = UnitID;

            param[5] = new SqlParameter("@ProductPrice", SqlDbType.Money);
            param[5].Value = ProductPrice;

            param[6] = new SqlParameter("@ExpirationDate", SqlDbType.Date);
            param[6].Value = ExpirationDate;

            param[7] = new SqlParameter("@Quantity", SqlDbType.Int);
            param[7].Value = Quantity;

            param[8] = new SqlParameter("@highestRate", SqlDbType.Int);
            param[8].Value = highestRate;

            param[9] = new SqlParameter("@Minimum", SqlDbType.Int);
            param[9].Value = Minimum;

            param[10] = new SqlParameter("@StoreID", SqlDbType.Int);
            param[10].Value = StoreID;

            param[11] = new SqlParameter("@Status", SqlDbType.Char);
            param[11].Value = Status;

            param[12] = new SqlParameter("@InLounge", SqlDbType.Char);
            param[12].Value = InLounge;

            DAL.ExecuteCommand("ProcurementProducts_Add", param);
        }

        //ProcurementProducts_Edit()
        public void ProcurementProducts_Edit(int ProductID, 
                                             string ProductBarcode, 
                                             string ProductName, 
                                             byte[] ProductImage, 
                                             int CategoryID, 
                                             int UnitID, 
                                             decimal ProductPrice, 
                                             DateTime ExpirationDate, 
                                             int Quantity, 
                                             int highestRate, 
                                             int Minimum, 
                                             int StoreID, 
                                             char Status, 
                                             char InLounge)
        {
            SqlParameter[] param = new SqlParameter[14];

            param[0] = new SqlParameter("@ProductID", SqlDbType.Int);
            param[0].Value = ProductID;

            param[1] = new SqlParameter("@ProductBarcode", SqlDbType.NVarChar, 50);
            param[1].Value = ProductBarcode;

            param[2] = new SqlParameter("@ProductName", SqlDbType.NVarChar, 50);
            param[2].Value = ProductName;

            param[3] = new SqlParameter("@ProductImage", SqlDbType.Image);
            param[3].Value = ProductImage;

            param[4] = new SqlParameter("@CategoryID", SqlDbType.Int);
            param[4].Value = CategoryID;

            param[5] = new SqlParameter("@UnitID", SqlDbType.Int);
            param[5].Value = UnitID;

            param[6] = new SqlParameter("@ProductPrice", SqlDbType.Money);
            param[6].Value = ProductPrice;

            param[7] = new SqlParameter("@ExpirationDate", SqlDbType.Date);
            param[7].Value = ExpirationDate;

            param[8] = new SqlParameter("@Quantity", SqlDbType.Int);
            param[8].Value = Quantity;

            param[9] = new SqlParameter("@highestRate", SqlDbType.Int);
            param[9].Value = highestRate;

            param[10] = new SqlParameter("@Minimum", SqlDbType.Int);
            param[10].Value = Minimum;

            param[11] = new SqlParameter("@StoreID", SqlDbType.Int);
            param[11].Value = StoreID;

            param[12] = new SqlParameter("@Status", SqlDbType.Char);
            param[12].Value = Status;

            param[13] = new SqlParameter("@InLounge", SqlDbType.Char);
            param[13].Value = InLounge;

            DAL.ExecuteCommand("ProcurementProducts_Edit", param);

        }
        //ProcurementProducts_Search()
        public DataTable ProcurementProducts_Search(string txtSEARCH)
        {
            DataTable Dt = new DataTable();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@txtSEARCH", SqlDbType.NVarChar, 150);
            param[0].Value = txtSEARCH;

            Dt = DAL.SelectData("ProcurementProducts_Search", param);
            return Dt;
        }

        #endregion

        #region/////////////ReturnBuy////////////////////////

        //ReturnPurchases_Viw()
        public DataTable ReturnPurchases_Viw()
        {
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("ReturnPurchases_Viw", null);
            return Dt;
        }
        //ReturnPurchases_Single_Viw()
        public DataTable ReturnPurchases_Single_Viw(int Bill_ID)
        {
            DataTable Dt = new DataTable();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@Bill_ID", SqlDbType.Int);
            param[0].Value = Bill_ID;

            Dt = DAL.SelectData("ReturnPurchases_Single_Viw", param);
            return Dt;
        }
        //ReturnPurchases_Add()
        public void ReturnPurchases_Add(int Bill_ID, 
                                        int ProductID, 
                                        int Quantity, 
                                        int UnitID, 
                                        int EmployID,
                                        DateTime Date, 
                                        DateTime Time, 
                                        string Note)
        {
            SqlParameter[] param = new SqlParameter[8];

            param[0] = new SqlParameter("@Bill_ID", SqlDbType.Int);
            param[0].Value = Bill_ID;

            param[1] = new SqlParameter("@ProductID", SqlDbType.Int);
            param[1].Value = ProductID;

            param[2] = new SqlParameter("@Quantity", SqlDbType.Int);
            param[2].Value = Quantity;

            param[3] = new SqlParameter("@UnitID", SqlDbType.Int);
            param[3].Value = UnitID;

            param[4] = new SqlParameter("@EmployID", SqlDbType.Int);
            param[4].Value = EmployID;

            param[5] = new SqlParameter("@Date", SqlDbType.Date);
            param[5].Value = Date;

            param[6] = new SqlParameter("@Time", SqlDbType.Time, 7);
            param[6].Value = Time;

            param[7] = new SqlParameter("@Note", SqlDbType.NVarChar, 60);
            param[7].Value = Note;

            DAL.ExecuteCommand("ReturnPurchases_Add", param);
        }
        //ReturnPurchases_Edit()
        public void ReturnPurchases_Edit(int SequentialID, 
                                         int Bill_ID, 
                                         int ProductID, 
                                         int Quantity, 
                                         int UnitID, 
                                         int EmployID,
                                         DateTime Date, 
                                         DateTime Time, 
                                         string Note)
        {
            SqlParameter[] param = new SqlParameter[9];
            param[0] = new SqlParameter("@SequentialID", SqlDbType.Int);
            param[0].Value = SequentialID;

            param[1] = new SqlParameter("@Bill_ID", SqlDbType.Int);
            param[1].Value = Bill_ID;

            param[2] = new SqlParameter("@ProductID", SqlDbType.Int);
            param[2].Value = ProductID;

            param[3] = new SqlParameter("@Quantity", SqlDbType.Int);
            param[3].Value = Quantity;

            param[4] = new SqlParameter("@UnitID", SqlDbType.Int);
            param[4].Value = UnitID;

            param[5] = new SqlParameter("@EmployID", SqlDbType.Int);
            param[5].Value = EmployID;

            param[6] = new SqlParameter("@Date", SqlDbType.Date);
            param[6].Value = Date;

            param[7] = new SqlParameter("@Time", SqlDbType.Time, 7);
            param[7].Value = Time;

            param[8] = new SqlParameter("@Note", SqlDbType.NVarChar, 60);
            param[8].Value = Note;

            DAL.ExecuteCommand("ReturnPurchases_Edit", param);
        }
        //ReturnPurchases_Search()
        public DataTable ReturnPurchases_Search(string txtSEARCH)
        {
            DataTable Dt = new DataTable();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@txtSEARCH", SqlDbType.NVarChar, 150);
            param[0].Value = txtSEARCH;

            Dt = DAL.SelectData("ReturnPurchases_Search", param);
            return Dt;
        }

        #endregion

        #region//////////////////Damaged/////////////////////
        //Damaged_View()
        public DataTable Damaged_View()
        {
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("Damaged_View", null);
            return Dt;
        }
        //Damaged_Add()
        public void Damaged_Add(int ProductID, 
                                int DamagedQuantity, 
                                decimal Cost, 
                                int StoreID,
                                DateTime Date, 
                                string Note, 
                                int UnitID)
        {
            SqlParameter[] param = new SqlParameter[7];

            param[0] = new SqlParameter("@ProductID", SqlDbType.Int);
            param[0].Value = ProductID;

            param[1] = new SqlParameter("@DamagedQuantity", SqlDbType.Int);
            param[1].Value = DamagedQuantity;

            param[2] = new SqlParameter("@Cost", SqlDbType.Money);
            param[2].Value = Cost;

            param[3] = new SqlParameter("@StoreID", SqlDbType.Int);
            param[3].Value = StoreID;

            param[4] = new SqlParameter("@Date", SqlDbType.Date);
            param[4].Value = Date;

            param[5] = new SqlParameter("@Note", SqlDbType.NVarChar, 50);
            param[5].Value = Note;

            param[6] = new SqlParameter("@UnitID", SqlDbType.Int);
            param[6].Value = UnitID;
            DAL.ExecuteCommand("Damaged_Add", param);
        }
        //Damaged_Edit()
        public void Damaged_Edit(int SequentialID, 
                                 int ProductID, 
                                 int DamagedQuantity, 
                                 decimal Cost, 
                                 int StoreID,
                                 DateTime Date, 
                                 string Note, 
                                 int UnitID)
        {
            SqlParameter[] param = new SqlParameter[8];

            param[0] = new SqlParameter("@SequentialID", SqlDbType.Int);
            param[0].Value = SequentialID;

            param[1] = new SqlParameter("@ProductID", SqlDbType.Int);
            param[1].Value = ProductID;

            param[2] = new SqlParameter("@DamagedQuantity", SqlDbType.Int);
            param[2].Value = DamagedQuantity;

            param[3] = new SqlParameter("@Cost", SqlDbType.Money);
            param[3].Value = Cost;

            param[4] = new SqlParameter("@StoreID", SqlDbType.Int);
            param[4].Value = StoreID;

            param[5] = new SqlParameter("@Date", SqlDbType.Date);
            param[5].Value = Date;

            param[6] = new SqlParameter("@Note", SqlDbType.NVarChar, 50);
            param[6].Value = Note;

            param[7] = new SqlParameter("@UnitID", SqlDbType.Int);
            param[7].Value = UnitID;
            DAL.ExecuteCommand("Damaged_Edit", param);
        }
        //Damaged_Search()
        public DataTable Damaged_Search(string txtSEARCH)
        {
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@txtSEARCH", SqlDbType.NVarChar, 150);
            param[0].Value = txtSEARCH;

            Dt = DAL.SelectData("Damaged_Search", param);
            return Dt;
        }
        #endregion

        #region//////////////////Deficiencies////////////////
        //Deficiencies_View
        public DataTable Deficiencies_View()
        {
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("Deficiencies_View", null);
            return Dt;
        }
        //Deficiencies_Add
        public void Deficiencies_Add(DateTime date, int EmployID, string Note)
        {
            SqlParameter[] param = new SqlParameter[3];

            param[0] = new SqlParameter("@date", SqlDbType.Date);
            param[0].Value = date;

            param[1] = new SqlParameter("@EmployID", SqlDbType.Int);
            param[1].Value = EmployID;

            param[2] = new SqlParameter("@Note", SqlDbType.NVarChar, 50);
            param[2].Value = Note;

            DAL.ExecuteCommand("Deficiencies_Add", param);
        }
        //Deficiencies_Edit
        public void Deficiencies_Edit(int OrderID, DateTime date, int EmployID, string Note)
        {
            SqlParameter[] param = new SqlParameter[4];

            param[0] = new SqlParameter("@OrderID", SqlDbType.Int);
            param[0].Value = OrderID;

            param[1] = new SqlParameter("@date", SqlDbType.Date);
            param[1].Value = date;

            param[2] = new SqlParameter("@EmployID", SqlDbType.Int);
            param[2].Value = EmployID;

            param[3] = new SqlParameter("@Note", SqlDbType.NVarChar, 50);
            param[3].Value = Note;

            DAL.ExecuteCommand("Deficiencies_Edit", param);
        }
        //Deficiencies_Search
        public DataTable Deficiencies_Search(string txtSEARCH)
        {
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@txtSEARCH", SqlDbType.NVarChar, 150);
            param[0].Value = txtSEARCH;

            Dt = DAL.SelectData("Deficiencies_Search", param);
            return Dt;
        }
        #endregion

        #region///////////////DetailsDeficiencies////////////////
        //DetailsDeficiencies_Single_View
        public DataTable DetailsDeficiencies_Single_View(int OrderID)
        {
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@OrderID", SqlDbType.Int);
            param[0].Value = OrderID;

            Dt = DAL.SelectData("DetailsDeficiencies_Single_View", param);
            return Dt;
        }
        //DetailsDeficiencies_Add
        public void DetailsDeficiencies_Add(int OrderID,
                                            int ProductID,
                                            int Quantity,
                                            int UnitID)
        {
            SqlParameter[] param = new SqlParameter[4];

            param[0] = new SqlParameter("@OrderID", SqlDbType.Int);
            param[0].Value = OrderID;

            param[1] = new SqlParameter("@ProductID", SqlDbType.Int);
            param[1].Value = ProductID;

            param[2] = new SqlParameter("@Quantity", SqlDbType.Int);
            param[2].Value = Quantity;

            param[3] = new SqlParameter("@UnitID", SqlDbType.Int);
            param[3].Value = UnitID;

            DAL.ExecuteCommand("DetailsDeficiencies_Add", param);
        }
        //DetailsDeficiencies_Edit
        public void DetailsDeficiencies_Edit(int SequentialID,
                                             int OrderID,
                                             int ProductID,
                                             int Quantity,
                                             int UnitID)
        {
            SqlParameter[] param = new SqlParameter[5];

            param[0] = new SqlParameter("@SequentialID", SqlDbType.Int);
            param[0].Value = SequentialID;

            param[1] = new SqlParameter("@OrderID", SqlDbType.Int);
            param[1].Value = OrderID;

            param[2] = new SqlParameter("@ProductID", SqlDbType.Int);
            param[2].Value = ProductID;

            param[3] = new SqlParameter("@Quantity", SqlDbType.Int);
            param[3].Value = Quantity;

            param[4] = new SqlParameter("@UnitID", SqlDbType.Int);
            param[4].Value = UnitID;

            DAL.ExecuteCommand("DetailsDeficiencies_Edit", param);
        }
        #endregion
    }
}
