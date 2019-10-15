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
    public partial class FR__Jobs : Form
    {
        public FR__Jobs()
        {
            InitializeComponent();
        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Txt_JobType_TextChanged(object sender, EventArgs e)
        {

        }
        //اضاءة حقل نوع الوظيفة
        private void Txt_JobType_Enter(object sender, EventArgs e)
        {
            rect_JobType.BorderColor = Color.Orange;
        }

        private void Txt_JobType_Leave(object sender, EventArgs e)
        {
            rect_JobType.BorderColor = Color.Gainsboro;
        }
        //اضاءة حقل الراتب
        private void Txt_JobSalary_Enter(object sender, EventArgs e)
        {
            rect_JobSalary.BorderColor = Color.Orange;
        }

        private void Txt_JobSalary_Leave(object sender, EventArgs e)
        {
            rect_JobSalary.BorderColor = Color.Gainsboro;
        }
        //حقل ساعات العمل
        private void Txt_JobHours_Enter(object sender, EventArgs e)
        {
            rect_JobHours.BorderColor = Color.Orange;
        }

        private void Txt_JobHours_Leave(object sender, EventArgs e)
        {
            rect_JobHours.BorderColor = Color.Gainsboro;
        }
        
        //اضاءة حقل فترة العمل
        private void Rad_jobTime_AM_Enter(object sender, EventArgs e)
        {
            rect_jobTime.BorderColor = Color.Orange;
        }

        private void Rad_jobTime_AM_Leave(object sender, EventArgs e)
        {
            rect_jobTime.BorderColor = Color.Gainsboro;
        }

        private void Rad_jobTime_PM_Enter(object sender, EventArgs e)
        {
            rect_jobTime.BorderColor = Color.Orange;
        }

        private void Rad_jobTime_PM_Leave(object sender, EventArgs e)
        {
            rect_jobTime.BorderColor = Color.Gainsboro;
        }
    }
}
