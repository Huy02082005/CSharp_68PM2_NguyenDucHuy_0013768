using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class UC_QLSV : UserControl
    {
        dbDataContext db = new dbDataContext();

        public UC_QLSV()
        {
            InitializeComponent();
        }

        private void UC_QLSV_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadDSLH4CBX();
        }

        public void LoadData()
        {
            try
            {
                db = new dbDataContext();
                var dssv = from sv in db.SinhViens
                           select new
                           {
                               MaSV = sv.MaSV,
                               HoTen = sv.HoTen,
                               NgaySinh = sv.NgaySinh,
                               GioiTinh = sv.GioiTinh,
                               MaLop = sv.MaLop
                           };
                dgvSinhVien.DataSource = dssv.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu sinh viên: " + ex.Message);
            }
        }

        public void LoadDSLH4CBX()
        {
            try
            {
                List<LopHoc> dslh = db.LopHocs.ToList();
                cboLop.DataSource = dslh;
                cboLop.DisplayMember = "TenLop";
                cboLop.ValueMember = "MaLop";
            }
            catch { }
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

        private void ThucHienTimKiem()
        {
            
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            ThucHienTimKiem();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            ThucHienTimKiem();
        }

        private void dgvSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvSinhVien.Rows[e.RowIndex];
                txtMaSV.Text = row.Cells["MaSV"].Value?.ToString();
                txtHoTen.Text = row.Cells["HoTen"].Value?.ToString();

                if (row.Cells["NgaySinh"].Value != null)
                    dtpNgaySinh.Value = Convert.ToDateTime(row.Cells["NgaySinh"].Value);

                cboGioiTinh.Text = row.Cells["GioiTinh"].Value?.ToString();
                cboLop.SelectedValue = row.Cells["MaLop"].Value?.ToString();
            }
        }
    }
}