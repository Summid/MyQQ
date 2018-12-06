using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyQQ
{
    public partial class frm_Register : Form
    {
        public frm_Register()
        {
            InitializeComponent();
        }

        private void frm_Register_Load(object sender, EventArgs e)
        {
            cboxStar.SelectedIndex = cboxBloodType.SelectedIndex = 0; //设置星座和血型的默认选项
        }
    }
}
