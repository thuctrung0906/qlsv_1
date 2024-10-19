using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DUONGTRUNGTHUC_QLSV
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            string email = textBoxEmail.Text;
            string password = textBoxPassword.Text;

            // Kiểm tra nếu email hoặc mật khẩu trống
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ email và mật khẩu.", "Lỗi đăng ký", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra xem tài khoản đã tồn tại chưa
            var existingUser = UserDatabase.Users.FirstOrDefault(u => u.Email == email);
            if (existingUser != null)
            {
                MessageBox.Show("Email đã được sử dụng. Vui lòng chọn email khác.", "Lỗi đăng ký", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Thêm tài khoản vào danh sách
            UserDatabase.Users.Add(new UserDatabase.User { Email = email, Password = password });
            MessageBox.Show("Đăng ký thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close(); // Đóng form đăng ký sau khi thành công
        }
    }
}


