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
    public partial class FR_Archives : Form
    {
        public FR_Archives()
        {
            InitializeComponent();
        }

        private void Btn_Archives_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Salary_Click(object sender, EventArgs e)
        {
            FR_Salaries Salaries = new FR_Salaries();
            Salaries.ShowDialog();
            this.Hide();
        }

        private void Btn_Emp_Pros_Click(object sender, EventArgs e)
        {
            FR_Emp emp = new FR_Emp();
            emp.ShowDialog();
            this.Hide();
        }
    }
}
