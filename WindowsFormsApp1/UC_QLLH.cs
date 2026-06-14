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
            if (string.IsNullOrEmpty(txtMaSV.Text.Trim()) || string.IsNullOrEmpty(txtHoTen.Text.Trim()))
            {
                MessageBox.Show("Vui lòng điền đầy đủ Mã SV và Họ Tên!", "Thông báo");
                return;
            }

            var checkExist = db.SinhViens.SingleOrDefault(s => s.MaSV == txtMaSV.Text.Trim());
            if (checkExist != null)
            {
                MessageBox.Show("Mã sinh viên này đã tồn tại trong hệ thống!", "Trùng mã");
                return;
            }

            try
            {
                SinhVien sv = new SinhVien();
                sv.MaSV = txtMaSV.Text.Trim();
                sv.HoTen = txtHoTen.Text.Trim();
                sv.GioiTinh = cboGioiTinh.Text;
                sv.NgaySinh = dtpNgaySinh.Value;
                sv.MaLop = cboLop.SelectedValue.ToString();

                db.SinhViens.InsertOnSubmit(sv);
                db.SubmitChanges();

                MessageBox.Show("Thêm sinh viên mới thành công!", "Thành công");
                LoadData();
                btnLamMoi_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm sinh viên: " + ex.Message, "Lỗi");
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaSV.Text.Trim()))
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần sửa đổi thông tin!", "Thông báo");
                return;
            }

            try
            {
                string maSV = txtMaSV.Text.Trim();
                SinhVien sv = db.SinhViens.SingleOrDefault(s => s.MaSV == maSV);

                if (sv != null)
                {
                    sv.HoTen = txtHoTen.Text.Trim();
                    sv.GioiTinh = cboGioiTinh.Text;
                    sv.NgaySinh = dtpNgaySinh.Value;
                    sv.MaLop = cboLop.SelectedValue.ToString();

                    db.SubmitChanges();
                    MessageBox.Show("Cập nhật thông tin sinh viên thành công!", "Thành công");
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy sinh viên tương ứng để chỉnh sửa (Không được sửa Mã SV)!", "Lỗi");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật dữ liệu: " + ex.Message, "Lỗi");
            }

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