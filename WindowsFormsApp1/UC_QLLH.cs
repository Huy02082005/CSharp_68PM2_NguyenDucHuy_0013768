using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class UC_QLLH : UserControl
    {
        dbDataContext db = new dbDataContext();

        public UC_QLLH()
        {
            InitializeComponent();
        }

        private void UC_QLLH_Load(object sender, EventArgs e)
        {
            LoadDataLop();
        }

        private void LoadDataLop()
        {
            var dslh = from lh in db.LopHocs
                       select new
                       {
                           MaLop = lh.MaLop,
                           TenLop = lh.TenLop,
                           GhiChu = lh.GhiChu 
                       };
            dgvLopHoc.DataSource = dslh.ToList();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            
        }

        private void dgvLopHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void groupBox1_Enter(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void label6_Click(object sender, EventArgs e) { }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}