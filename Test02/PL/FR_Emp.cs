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
    public partial class FR_Emp : Form
    {
        public FR_Emp()
        {
            InitializeComponent();
            //تكبير الفورم على دقة الشاشة
            System.Drawing.Rectangle rect = Screen.GetWorkingArea(this);
            this.MaximizedBounds = Screen.GetWorkingArea(this);
            this.WindowState = FormWindowState.Maximized;

            //عرض البيانات 
            //DGV_Emp.DataSource = دالة العرض
        }


        private void FR_Emp_Load(object sender, EventArgs e)
        {
            
            DataTable table = new DataTable();
            table.Columns.Add("ID", typeof(int));
            table.Rows.Add(1);
            DGV_Emp.DataSource = table;
            //زر التعديل
            DataGridViewButtonColumn btn_DGV_Emp_Edit = new DataGridViewButtonColumn();
            btn_DGV_Emp_Edit.Tag = false;
            btn_DGV_Emp_Edit.HeaderText = "تعديل";
            btn_DGV_Emp_Edit.Name = "btn_DGV_Emp_Edit";
            btn_DGV_Emp_Edit.FlatStyle = FlatStyle.Flat;
            btn_DGV_Emp_Edit.Width = 50;
            //btn.FlatStyle = BorderStyle.None;

            DGV_Emp.Columns.Add(btn_DGV_Emp_Edit);
            //زر بيانات الراتب
            DataGridViewButtonColumn btn_DGV_Emp_Salary = new DataGridViewButtonColumn();
            btn_DGV_Emp_Salary.Tag = false;
            btn_DGV_Emp_Salary.HeaderText = "الراتب";
            btn_DGV_Emp_Salary.Name = "btn_DGV_Emp_Salary";
            btn_DGV_Emp_Salary.FlatStyle = FlatStyle.Flat;
            btn_DGV_Emp_Salary.Width = 50;
            
            DGV_Emp.Columns.Add(btn_DGV_Emp_Salary);
            //زر الحساب المالي
            DataGridViewButtonColumn btn_DGV_Emp_Acconut = new DataGridViewButtonColumn();
            btn_DGV_Emp_Acconut.Tag = false;
            btn_DGV_Emp_Acconut.HeaderText = "الحساب";
            btn_DGV_Emp_Acconut.Name = "btn_DGV_Emp_Acconut";
            btn_DGV_Emp_Acconut.FlatStyle = FlatStyle.Flat;
            btn_DGV_Emp_Acconut.Width = 50;

            DGV_Emp.Columns.Add(btn_DGV_Emp_Acconut);
            //زر الارشفة
            DataGridViewImageColumn img_DGV_Emp_Arch = new DataGridViewImageColumn();
            img_DGV_Emp_Arch.Tag = false;
            img_DGV_Emp_Arch.HeaderText = "أرشفة";
            img_DGV_Emp_Arch.Name = "img_DGV_Emp_Arch";
            img_DGV_Emp_Arch.Width = 50;
            img_DGV_Emp_Arch.Image = Properties.Resources.icons8_archive_folder_15;

            DGV_Emp.Columns.Add(img_DGV_Emp_Arch);
        }

        private void DGV_Emp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //تعديل
            if (DGV_Emp.Columns[e.ColumnIndex].Name == "btn_DGV_Emp_Edit")
            {
                //دالة التعديل

                Image img = Properties.Resources.edit1;

            }
            //الرتيب
            if(DGV_Emp.Columns[e.ColumnIndex].Name == "btn_DGV_Emp_Salary")
            {
                //استدعاء فورم بيانات الراتب الفرعية
                FR_Info_Salary infoSalr = new FR_Info_Salary();
                infoSalr.ShowDialog();
                
            }
            //الحساب
            if (DGV_Emp.Columns[e.ColumnIndex].Name == "btn_DGV_Emp_Acconut")
            {
                //استدعاء فورم الحساب
                MessageBox.Show("dd");
            }

        }


        //إضاءة حقل الاسم عند دخول و مغادرة مربع النص
        private void Txt_EmployName_Enter(object sender, EventArgs e)
        {
            rect_EmployName.BorderColor = Color.Orange;
        }

        private void Txt_EmployName_Leave(object sender, EventArgs e)
        {
            rect_EmployName.BorderColor = Color.Gainsboro;
        }
        //إضاعة حقل نوع الوظيفة
        private void Com_JobID_MouseClick(object sender, MouseEventArgs e)
        {
            rect_JobID.BorderColor = Color.Orange;
        }
        private void Com_JobID_Leave(object sender, EventArgs e)
        {
            rect_JobID.BorderColor = Color.Gainsboro;
        }
        //إضاءة حقل تاريخ الالتحاق
        private void Date_DirectlyDate_MouseEnter(object sender, EventArgs e)
        {
            rect_DirectlyDate.BorderColor = Color.Orange;
        }

        private void Date_DirectlyDate_Leave(object sender, EventArgs e)
        {
            rect_DirectlyDate.BorderColor = Color.Gainsboro;
        }

        //إضاءة حقل الجنس
        private void Rad_Gender_m_Enter(object sender, EventArgs e)
        {
            rect_Gender.BorderColor = Color.Orange;
        }

        private void Rad_tab1_Gender_f_Enter(object sender, EventArgs e)
        {
            rect_Gender.BorderColor = Color.Orange;
        }

        private void Rad_Gender_m_Leave(object sender, EventArgs e)
        {
            rect_Gender.BorderColor = Color.Gainsboro;
        }

        private void Rad_tab1_Gender_f_Leave(object sender, EventArgs e)
        {
            rect_Gender.BorderColor = Color.Gainsboro;
        }
        //إضاءة حقل العنوان
        private void Txt_EmployAddress_Enter(object sender, EventArgs e)
        {
            rect_EmployAddress.BorderColor = Color.Orange;
        }

        private void Txt_EmployAddress_Leave(object sender, EventArgs e)
        {
            rect_EmployAddress.BorderColor = Color.Gainsboro;
        }
        //اضاءة حقل الجنسية
        private void Com_NationalityID_MouseClick(object sender, MouseEventArgs e)
        {
            rect_NationalityID.BorderColor = Color.Orange;
        }

        private void Com_NationalityID_Leave(object sender, EventArgs e)
        {
            rect_NationalityID.BorderColor = Color.Gainsboro;
        }
        //اضاءة حقل الهاتف
        private void Txt_EmployPhone_Enter(object sender, EventArgs e)
        {
            rect_EmployPhone.BorderColor = Color.Orange;
        }

        private void Txt_EmployPhone_Leave(object sender, EventArgs e)
        {
            rect_EmployPhone.BorderColor = Color.Gainsboro;
        }

        private void Rad_AccountStatusON_Enter(object sender, EventArgs e)
        {
            rect_AccountStatus.BorderColor = Color.Orange;
        }

        private void Rad_tab1_AccountStatusOFF_Enter(object sender, EventArgs e)
        {
            rect_AccountStatus.BorderColor = Color.Orange;
        }

        private void Rad_AccountStatusON_Leave(object sender, EventArgs e)
        {
            rect_AccountStatus.BorderColor = Color.Gainsboro;
        }

        private void Rad_tab1_AccountStatusOFF_Leave(object sender, EventArgs e)
        {
            rect_AccountStatus.BorderColor = Color.Gainsboro;
        }
        //زر الاشعار
        private void Btn_Notice_Click(object sender, EventArgs e)
        {
            Image my_Notice = new Bitmap(@"D:\icon\Notice.png");
            btn_Emp_Notice.BackgroundImage = my_Notice;

        }
        //زر السابق
        private void Btn_Emp_Prev_Click(object sender, EventArgs e)
        {

        }
        //زر السابق
        private void Btn_Emp_Next_Click(object sender, EventArgs e)
        {

        }
        //عرض شاشة الجنسيات
        private void Btn_MoreNationalities_Click(object sender, EventArgs e)
        {
            FR_Nationalities Nationalitie = new FR_Nationalities();
            Nationalitie.ShowDialog();
        }
        //عرض شاشة الوظائف
        private void Btn_MoreJobs_Click(object sender, EventArgs e)
        {
            FR__Jobs jobs = new FR__Jobs();
            jobs.ShowDialog();
        }

        private void Btn_Salary_Click(object sender, EventArgs e)
        {
            FR_Salaries Salaries = new FR_Salaries();
            Salaries.ShowDialog();
            this.Hide();
        }

        private void Btn_Archives_Click(object sender, EventArgs e)
        {
            FR_Archives archives = new FR_Archives();
            archives.ShowDialog();
            this.Hide();
        }

        private void DGV_Emp_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex <0)
            {
                return;
            }
                if (e.ColumnIndex == 1)
            {
                //دالة التعديل
                e.Paint(e.CellBounds,DataGridViewPaintParts.All);
                var w = Properties.Resources.icons8_edit_15.Width;
                var h = Properties.Resources.icons8_edit_15.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width-w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;
                e.Graphics.DrawImage(Properties.Resources.icons8_edit_15, new Rectangle(x,y,w,h));
                e.Handled = true;
               


            }
            //الراتب
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
            //الحساب
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

        private void DGV_Emp_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            

        }

        private void Btn_Emp_Add_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("سيتم إضافة بيانات للمنظومة", "إضافة", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //دالة الاضافة
                MessageBox.Show("تم عملية عملية الإضافة بنجاح", "إضافة");
            }
            else MessageBox.Show("تم إلغاء عملية الإضافة", "إلغاء الإضافة");
        }
    }
}
