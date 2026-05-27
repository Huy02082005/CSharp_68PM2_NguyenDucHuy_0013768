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
            List<SinhVien> dssv = db.SinhViens.ToList();
            dgvSinhVien.DataSource = dssv;
        }

        public void LoadDSLH4CBX()
        {
            List<LopHoc> dslh = db.LopHocs.ToList();
            cboLop.DataSource = dslh;
            cboLop.DisplayMember = "TenLop";
            cboLop.ValueMember = "MaLop";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            SinhVien sv = new SinhVien();
            sv.MaSV = txtMaSV.Text;
            sv.HoTen = txtHoTen.Text;
            sv.GioiTinh = cboGioiTinh.Text;
            sv.NgaySinh = DateTime.Parse(dtpNgaySinh.Text);
            sv.MaLop = cboLop.SelectedValue.ToString();
            try
            {
                db.SinhViens.InsertOnSubmit(sv);
                db.SubmitChanges();
                LoadData();
                MessageBox.Show("Thêm sinh viên thành công!");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);

            }
        }
    }
}

