using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class UC_QLLH : UserControl
    {
        dbDataContext db = new dbDataContext();
        public UC_QLLH()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void cboLop_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void UC_QLLH_Load(object sender, EventArgs e)
        {
            List<LopHoc> dslh = db.LopHocs.ToList();
            dgvLopHoc.DataSource = dslh;
        }

    }
}
