using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Take_Away.BL
{
    class CS_Purchases
    {
        DataAccessLayer DAL = new DataAccessLayer();

        #region ///////////////BillBuy////////////////////////////

        //BillBuy_View
        public DataTable BillBuy_View()
        {
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("BillBuy_View", null);
            return Dt;
        }
        //BillBuy_Add
        public void BillBuy_Add(int Bill_ID, 
                                int SupplierID, 
                                int EmployID, 
                                DateTime Time, 
                                DateTime Date,
                                decimal BillTotal, 
                                char RegisterBill, 
                                char PaymentStatus)
        {
            SqlParameter[] param = new SqlParameter[8];

            param[0] = new SqlParameter("@Bill_ID", SqlDbType.Int);
            param[0].Value = Bill_ID;

            param[1] = new SqlParameter("@SupplierID", SqlDbType.Int);
            param[1].Value = SupplierID;

            param[2] = new SqlParameter("@EmployID", SqlDbType.Int);
            param[2].Value = EmployID;

            param[3] = new SqlParameter("@Time", SqlDbType.Time, 7);
            param[3].Value = Time;

            param[4] = new SqlParameter("@Date", SqlDbType.Date);
            param[4].Value = Date;

            param[5] = new SqlParameter("@BillTotal", SqlDbType.Money);
            param[5].Value = BillTotal;

            param[6] = new SqlParameter("@RegisterBill", SqlDbType.Char);
            param[6].Value = RegisterBill;

            param[7] = new SqlParameter("@PaymentStatus", SqlDbType.Char);
            param[7].Value = PaymentStatus;

            DAL.ExecuteCommand("BillBuy_Add", param);
        }
        //BillBuy_Edit
        public void BillBuy_Edit(int SequentialID, 
                                 int Bill_ID, 
                                 int SupplierID, 
                                 int EmployID, 
                                 DateTime Time, 
                                 DateTime Date,
                                 decimal BillTotal, 
                                 char RegisterBill, 
                                 char PaymentStatus)
        {
            SqlParameter[] param = new SqlParameter[9];

            param[0] = new SqlParameter("@SequentialID", SqlDbType.Int);
            param[0].Value = SequentialID;

            param[1] = new SqlParameter("@Bill_ID", SqlDbType.Int);
            param[1].Value = Bill_ID;

            param[2] = new SqlParameter("@SupplierID", SqlDbType.Int);
            param[2].Value = SupplierID;

            param[3] = new SqlParameter("@EmployID", SqlDbType.Int);
            param[3].Value = EmployID;

            param[4] = new SqlParameter("@Time", SqlDbType.Time, 7);
            param[4].Value = Time;

            param[5] = new SqlParameter("@Date", SqlDbType.Date);
            param[5].Value = Date;

            param[6] = new SqlParameter("@BillTotal", SqlDbType.Money);
            param[6].Value = BillTotal;

            param[7] = new SqlParameter("@RegisterBill", SqlDbType.Char);
            param[7].Value = RegisterBill;

            param[8] = new SqlParameter("@PaymentStatus", SqlDbType.Char);
            param[8].Value = PaymentStatus;

            DAL.ExecuteCommand("BillBuy_Edit", param);
        }
        //BillBuy_Search
        public DataTable BillBuy_Search(string txtSEARCH)
        {
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@txtSEARCH", SqlDbType.NVarChar, 150);
            param[0].Value = txtSEARCH;

            Dt = DAL.SelectData("BillBuy_Search", param);
            return Dt;
        }
        #endregion

        #region///////////DetailsBillBuy/////////////////////////

        //DetailsBillBuy_Single_View()
        public DataTable DetailsBillBuy_Single_View()
        {
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("DetailsBillBuy_Single_View", null);
            return Dt;
        }
        //DetailsBillBuy_Add
        public void DetailsBillBuy_Add(int Bill_ID, 
                                       int ProductID, 
                                       int Quantity, 
                                       int UnitID, 
                                       decimal BillPrice,
                                       int Discount)
        {
            SqlParameter[] param = new SqlParameter[6];

            param[0] = new SqlParameter("@Bill_ID", SqlDbType.Int);
            param[0].Value = Bill_ID;

            param[1] = new SqlParameter("@ProductID", SqlDbType.Int);
            param[1].Value = ProductID;

            param[2] = new SqlParameter("@Quantity", SqlDbType.Int);
            param[2].Value = Quantity;

            param[3] = new SqlParameter("@UnitID", SqlDbType.Int);
            param[3].Value = UnitID;

            param[4] = new SqlParameter("@BillPrice ", SqlDbType.Money);
            param[4].Value = BillPrice;

            param[5] = new SqlParameter("@Discount", SqlDbType.Int);
            param[5].Value = Discount;

            DAL.ExecuteCommand("DetailsBillBuy_Add", param);
        }
        //DetailsBillBuy_Edit
        public void DetailsBillBuy_Edit(int SequentialID, 
                                        int Bill_ID, 
                                        int ProductID, 
                                        int Quantity, 
                                        int UnitID,
                                        decimal BillPrice,
                                        int Discount)
        {
            SqlParameter[] param = new SqlParameter[7];

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

            param[5] = new SqlParameter("@BillPrice ", SqlDbType.Money);
            param[5].Value = BillPrice;

            param[6] = new SqlParameter("@Discount", SqlDbType.Int);
            param[6].Value = Discount;

            DAL.ExecuteCommand("DetailsBillBuy_Edit", param);
        }
        #endregion

        #region///////////PaymentDetailsBuy//////////////////////

        //PaymentDetailsBuy_View
        public DataTable PaymentDetailsBuy_View()
        {
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("PaymentDetailsBuy_View", null);
            return Dt;
        }
        //PaymentDetailsBuy_Add
        public void PaymentDetailsBuy_Add(int Bill_ID, int PaymentStyleNum, decimal Amount)

        {

            SqlParameter[] param = new SqlParameter[3];

            param[0] = new SqlParameter("@Bill_ID", SqlDbType.Int);
            param[0].Value = Bill_ID;

            param[1] = new SqlParameter("@PaymentStyleNum ", SqlDbType.Int);
            param[1].Value = PaymentStyleNum;

            param[2] = new SqlParameter("@Amount", SqlDbType.Money);
            param[2].Value = Amount;

            DAL.ExecuteCommand("PaymentDetailsBuy_Add", param);
        }
        //PaymentDetailsBuy_Edit
        public void PaymentDetailsBuy_Edit(int SequentialID, int Bill_ID, int PaymentStyleNum, decimal Amount)
        {
            SqlParameter[] param = new SqlParameter[4];

            param[0] = new SqlParameter("@SequentialID", SqlDbType.Int);
            param[0].Value = SequentialID;

            param[1] = new SqlParameter("@Bill_ID", SqlDbType.Int);
            param[1].Value = Bill_ID;

            param[2] = new SqlParameter("@PaymentStyleNum ", SqlDbType.Int);
            param[2].Value = PaymentStyleNum;

            param[3] = new SqlParameter("@Amount", SqlDbType.Money);
            param[3].Value = Amount;

            DAL.ExecuteCommand("PaymentDetailsBuy_Edit", param);

        }
        #endregion
    }
}
