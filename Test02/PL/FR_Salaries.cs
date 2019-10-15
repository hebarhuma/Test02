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
    public partial class FR_Salaries : Form
    {
        public FR_Salaries()
        {
            InitializeComponent();

            //تكبير الفورم على دقة الشاشة
            System.Drawing.Rectangle rect = Screen.GetWorkingArea(this);
            this.MaximizedBounds = Screen.GetWorkingArea(this);
            this.WindowState = FormWindowState.Maximized;

        }

        private void Txt_EmployID_Enter(object sender, EventArgs e)
        {
            rect_EmployID.BorderColor = Color.Orange;
        }

        private void Txt_EmployID_Leave(object sender, EventArgs e)
        {
            rect_EmployID.BorderColor = Color.Gainsboro;
        }

        private void Com_SalaryType_MouseClick(object sender, MouseEventArgs e)
        {
            rect_SalaryType.BorderColor = Color.Orange;
        }

        private void Com_SalaryType_Leave(object sender, EventArgs e)
        {
            rect_SalaryType.BorderColor = Color.Gainsboro;
        }

        private void Txt_SalaryValue_Leave(object sender, EventArgs e)
        {
            rect_SalaryValue.BorderColor = Color.Orange;
        }

        private void Txt_SalaryValue_Enter(object sender, EventArgs e)
        {
            rect_SalaryValue.BorderColor = Color.Gainsboro;
        }

        private void Date_ReceivedDate_MouseEnter(object sender, EventArgs e)
        {
            rect_ReceivedDate.BorderColor = Color.Orange;
        }

        private void Date_ReceivedDate_Leave(object sender, EventArgs e)
        {
            rect_ReceivedDate.BorderColor = Color.Gainsboro;
        }

        private void Txt_SalaryRest_Leave(object sender, EventArgs e)
        {
            rect_SalaryRest.BorderColor = Color.Gainsboro;
        }

        private void Txt_SalaryRest_Enter(object sender, EventArgs e)
        {
            rect_SalaryRest.BorderColor = Color.Orange;
        }

        private void Txt_AdvancePayment_Enter(object sender, EventArgs e)
        {
            rect_AdvancePayment.BorderColor = Color.Orange;
        }

        private void Txt_AdvancePayment_Leave(object sender, EventArgs e)
        {
            rect_AdvancePayment.BorderColor = Color.Gainsboro;
        }

        private void Txt_Note_Enter(object sender, EventArgs e)
        {
            rect_Note.BorderColor = Color.Orange;
        }

        private void Txt_Note_Leave(object sender, EventArgs e)
        {
            rect_Note.BorderColor = Color.Gainsboro;
        }
        //السلف اليومية
  
        //الديون
        private void Btn_Debt_Click(object sender, EventArgs e)
        {
            FR_Debt Debt = new FR_Debt();
            Debt.ShowDialog();
            this.Hide();
        }

        private void FR_Salaries_Load(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            table.Columns.Add("ID", typeof(int));
            table.Rows.Add(1);
            DGV_Salary.DataSource = table;
            //زر التعديل
            DataGridViewButtonColumn btn_DGV_Salary_Expend_Money= new DataGridViewButtonColumn();
            btn_DGV_Salary_Expend_Money.Tag = false;
            btn_DGV_Salary_Expend_Money.HeaderText = "صرف راتب";
            btn_DGV_Salary_Expend_Money.Name = "btn_DGV_Salary_Expend_Money";
            btn_DGV_Salary_Expend_Money.FlatStyle = FlatStyle.Flat;
            btn_DGV_Salary_Expend_Money.Width = 50;
            //btn.FlatStyle = BorderStyle.None;

            DGV_Salary.Columns.Add(btn_DGV_Salary_Expend_Money);
            //زر بيانات الراتب
            DataGridViewButtonColumn btn_DGV_Salary_Advance = new DataGridViewButtonColumn();
            btn_DGV_Salary_Advance.Tag = false;
            btn_DGV_Salary_Advance.HeaderText = "السلف";
            btn_DGV_Salary_Advance.Name = "btn_DGV_Salary_Advance";
            btn_DGV_Salary_Advance.FlatStyle = FlatStyle.Flat;
            btn_DGV_Salary_Advance.Width = 50;

            DGV_Salary.Columns.Add(btn_DGV_Salary_Advance);
            //زر الحساب المالي
            DataGridViewButtonColumn btn_DGV_Salary_Plucked = new DataGridViewButtonColumn();
            btn_DGV_Salary_Plucked.Tag = false;
            btn_DGV_Salary_Plucked.HeaderText = "السحب";
            btn_DGV_Salary_Plucked.Name = "btn_DGV_Salary_Plucked";
            btn_DGV_Salary_Plucked.FlatStyle = FlatStyle.Flat;
            btn_DGV_Salary_Plucked.Width = 50;

            DGV_Salary.Columns.Add(btn_DGV_Salary_Plucked);
            


        }

        private void DGV_Salary_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DGV_Salary.Columns[e.ColumnIndex].Name == "btn_DGV_Salary_Expend_Money")
            {
                FR_Expend_Money fR_Expend_Money = new FR_Expend_Money();
                fR_Expend_Money.ShowDialog();

            }
            if (DGV_Salary.Columns[e.ColumnIndex].Name == "btn_DGV_Salary_Advance")
            {
                //اعتماد الراتب
                FR_Advance fR_Advance = new FR_Advance();
                fR_Advance.ShowDialog();
            }
            if (DGV_Salary.Columns[e.ColumnIndex].Name == "btn_DGV_Salary_Plucked")
            {
                //اعتماد الراتب
                FR_Plucked fR_Plucked = new FR_Plucked();
                fR_Plucked.ShowDialog();
            }
        }

        private void Btn_SalaryType_more_Click(object sender, EventArgs e)
        {
            FR_TypeSalary typeSalr = new FR_TypeSalary();
            typeSalr.ShowDialog();
        }

        private void Btn_Emp_Pros_Click(object sender, EventArgs e)
        {
            FR_Emp emp = new FR_Emp();
            emp.ShowDialog();
            this.Hide();
        }

        private void Btn_Archives_Click(object sender, EventArgs e)
        {
            FR_Archives archives = new FR_Archives();
            archives.ShowDialog();
            this.Hide();
        }

        private void DGV_Salary_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            if (e.ColumnIndex == 1)
            {
                //صرف الراتب
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var w = Properties.Resources.icons8_edit_15.Width;
                var h = Properties.Resources.icons8_edit_15.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;
                e.Graphics.DrawImage(Properties.Resources.icons8_edit_15, new Rectangle(x, y, w, h));
                e.Handled = true;



            }
            //السلف
            if (e.ColumnIndex == 2)
            {
                //دالة التعديل
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var w = Properties.Resources.icons8_payroll_15.Width;
                var h = Properties.Resources.icons8_payroll_15.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;
                e.Graphics.DrawImage(Properties.Resources.icons8_payroll_15, new Rectangle(x, y, w, h));
                e.Handled = true;

            }
            //السحب
            if (e.ColumnIndex == 3)
            {
                //دالة التعديل
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var w = Properties.Resources.icons8_bank_cards_15.Width;
                var h = Properties.Resources.icons8_bank_cards_15.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;
                e.Graphics.DrawImage(Properties.Resources.icons8_bank_cards_15, new Rectangle(x, y, w, h));
                e.Handled = true;

            }
        }
    }
}
