using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test02.PL
{
    public partial class FR_Debt : Form
    {
        public FR_Debt()
        {
            InitializeComponent();
            //عرض البيانات 
            //DGV_Debt.DataSource = 

            //تكبير الفورم على دقة الشاشة
            System.Drawing.Rectangle rect = Screen.GetWorkingArea(this);
            this.MaximizedBounds = Screen.GetWorkingArea(this);
            this.WindowState = FormWindowState.Maximized;
        }
     
        //صرف رواتب
        private void Btn_Pay_Salary_Click(object sender, EventArgs e)
        {
            FR_Salaries Salaries = new FR_Salaries();
            Salaries.ShowDialog();
            this.Hide();
        }

        private void Txt_Bill_ID_Enter(object sender, EventArgs e)
        {
            rect_Bill_ID.BorderColor = Color.Orange;
        }

        private void Txt_Bill_ID_Leave(object sender, EventArgs e)
        {
            rect_Bill_ID.BorderColor = Color.Gainsboro;
        }

        private void Txt_PaidUp_Enter(object sender, EventArgs e)
        {
            rect_PaidUp.BorderColor = Color.Orange;
        }

        private void Txt_PaidUp_Leave(object sender, EventArgs e)
        {
            rect_PaidUp.BorderColor = Color.Gainsboro;
        }

        private void Txt_Rest_Enter(object sender, EventArgs e)
        {
            rect_Rest.BorderColor = Color.Orange;
        }

        private void Txt_Rest_Leave(object sender, EventArgs e)
        {
            rect_Rest.BorderColor = Color.Gainsboro;
        }

        private void Rad_StateDebtON_Click(object sender, EventArgs e)
        {

        }

        private void Rad_StateDebtON_Enter(object sender, EventArgs e)
        {
            rect_StateDebt.BorderColor = Color.Orange;
        }

        private void Rad_StateDebtON_Leave(object sender, EventArgs e)
        {
            rect_StateDebt.BorderColor = Color.Gainsboro;
        }

        private void Rad_StateDebtOFF_Enter(object sender, EventArgs e)
        {
            rect_StateDebt.BorderColor = Color.Orange;
        }

        private void Rad_StateDebtOFF_Leave(object sender, EventArgs e)
        {
            rect_StateDebt.BorderColor = Color.Gainsboro;
        }

        private void FR_Debt_Load(object sender, EventArgs e)
        {

        }
    }
}
