using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test02
{
    public partial class FR_Nationalities : Form
    {
        public FR_Nationalities()
        {
            InitializeComponent();
        }
        //اضاءة حقل الجنسية
        private void Txt_Nationality_Enter(object sender, EventArgs e)
        {
            rect_Nationality.BorderColor = Color.Orange;
        }

        private void Txt_Nationality_Leave(object sender, EventArgs e)
        {
            rect_Nationality.BorderColor = Color.Gainsboro;
        }
    }
}
