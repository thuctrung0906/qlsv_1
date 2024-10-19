using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DUONGTRUNGTHUC_QLSV
{
    public partial class QLSV : Form
    {
        List<SinhVien> lstSV; // Danh sách sinh viên
        BindingSource bs = new BindingSource(); // BindingSource để liên kết với DataGridView

        public QLSV()
        {
            InitializeComponent();
        }

        private void QLSV_Load(object sender, EventArgs e)
        {
            lstSV = new List<SinhVien>(); // Khởi tạo danh sách sinh viên
            bs.DataSource = lstSV; // Liên kết BindingSource với danh sách sinh viên
            dataGridView1.DataSource = bs; // Liên kết DataGridView với BindingSource

            dataGridView1.AutoGenerateColumns = true; // Cho phép tự động tạo cột

            // Đổi tên cột sau khi DataGridView tự động tạo cột
            dataGridView1.Columns["MASV"].HeaderText = "Mã SV"; // Đổi tên cột MASV
            dataGridView1.Columns["Ten"].HeaderText = "Tên Sinh Viên"; // Đổi tên cột Ten
            dataGridView1.Columns["NamSinh"].HeaderText = "Năm Sinh"; // Đổi tên cột NamSinh
            dataGridView1.Columns["GioiTinh"].HeaderText = "Giới Tính"; // Đổi tên cột GioiTinh
            dataGridView1.Columns["Nganh"].HeaderText = "Ngành"; // Đổi tên cột Nganh
            dataGridView1.Columns["Lop"].HeaderText = "Lớp"; // Đổi tên cột Lop

            // Đăng ký sự kiện SelectionChanged để hiển thị thông tin sinh viên lên các trường nhập liệu
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
        }


        private void button1_Click(object sender, EventArgs e) // Thêm
        {
            if (ValidateInput()) // Kiểm tra đầu vào hợp lệ trước khi thêm
            {
                SinhVien sv = new SinhVien
                {
                    MASV = textBox1.Text,
                    Ten = textBox3.Text,
                    NamSinh = dateTimePicker1.Value,
                    GioiTinh = radioButton1.Checked ? "Nam" : "Nữ",
                    Nganh = comboBox1.SelectedItem?.ToString(),
                    Lop = comboBox2.SelectedItem?.ToString()
                };

                lstSV.Add(sv); // Thêm sinh viên vào danh sách
                bs.ResetBindings(false); // Cập nhật DataGridView

                ClearForm(); // Xóa các trường nhập liệu
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e) // Sửa
        {
            int idx = dataGridView1.CurrentRow.Index; // Lấy chỉ số hàng hiện tại
            if (idx >= 0)
            {
                // Cập nhật thông tin sinh viên
                lstSV[idx].MASV = textBox1.Text;
                lstSV[idx].Ten = textBox3.Text;
                lstSV[idx].NamSinh = dateTimePicker1.Value;
                lstSV[idx].GioiTinh = radioButton1.Checked ? "Nam" : "Nữ";
                lstSV[idx].Nganh = comboBox1.SelectedItem?.ToString();
                lstSV[idx].Lop = comboBox2.SelectedItem?.ToString();
                bs.ResetBindings(false); // Cập nhật DataGridView
            }
        }

        private void button3_Click(object sender, EventArgs e) // Xóa
        {
            int idx = dataGridView1.CurrentRow.Index; // Lấy chỉ số hàng hiện tại
            if (idx >= 0)
            {
                lstSV.RemoveAt(idx); // Xóa sinh viên khỏi danh sách
                bs.ResetBindings(false); // Cập nhật DataGridView
            }
        }

        private void button4_Click(object sender, EventArgs e) // Thoát
        {
            this.Close(); // Đóng form
        }

        private bool ValidateInput()
        {
            // Kiểm tra nếu các trường nhập liệu không để trống
            return !string.IsNullOrWhiteSpace(textBox1.Text) &&
                   !string.IsNullOrWhiteSpace(textBox3.Text) &&
                   comboBox1.SelectedIndex != -1 &&
                   comboBox2.SelectedIndex != -1;
        }

        private void ClearForm()
        {
            textBox1.Clear(); // Xóa mã sinh viên
            textBox3.Clear(); // Xóa tên sinh viên
            dateTimePicker1.Value = DateTime.Now; // Đặt lại ngày sinh
            radioButton1.Checked = true; // Đặt giới tính mặc định
            comboBox1.SelectedIndex = -1; // Đặt lại comboBox ngành
            comboBox2.SelectedIndex = -1; // Đặt lại comboBox lớp
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null && dataGridView1.CurrentRow.Index >= 0)
            {
                int idx = dataGridView1.CurrentRow.Index; // Lấy chỉ số hàng hiện tại
                var sv = lstSV[idx]; // Lấy sinh viên từ danh sách

                // Hiển thị thông tin sinh viên lên các trường nhập liệu
                textBox1.Text = sv.MASV;
                textBox3.Text = sv.Ten;

                // Kiểm tra nếu ngày sinh hợp lệ
                if (sv.NamSinh >= dateTimePicker1.MinDate && sv.NamSinh <= dateTimePicker1.MaxDate)
                {
                    dateTimePicker1.Value = sv.NamSinh;
                }
                else
                {
                    // Đặt giá trị mặc định nếu ngày sinh không hợp lệ
                    dateTimePicker1.Value = DateTime.Now;
                }

                // Kiểm tra giới tính
                if (sv.GioiTinh == "Nam")
                {
                    radioButton1.Checked = true;
                }
                else
                {
                    radioButton2.Checked = true;
                }

                // Hiển thị thông tin ngành và lớp
                comboBox1.SelectedItem = sv.Nganh;
                comboBox2.SelectedItem = sv.Lop;
            }
        }


        // Lớp SinhVien để lưu thông tin sinh viên
        public class SinhVien
        {
            public string MASV { get; set; } // Mã sinh viên
            public string Ten { get; set; } // Tên sinh viên
            public DateTime NamSinh { get; set; } // Năm sinh
            public string GioiTinh { get; set; } // Giới tính
            public string Nganh { get; set; } // Ngành học
            public string Lop { get; set; } // Lớp
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Khi nhấp vào ô trong DataGridView, bạn có thể lấy dữ liệu từ ô đó
            if (e.RowIndex >= 0) // Kiểm tra chỉ số hàng hợp lệ
            {
                var sinhVien = lstSV[e.RowIndex]; // Lấy sinh viên từ danh sách
                MessageBox.Show($"Mã SV: {sinhVien.MASV}\nTên: {sinhVien.Ten}\nGiới tính: {sinhVien.GioiTinh}", "Thông tin sinh viên", MessageBoxButtons.OK);
            }
        }
    }
}
