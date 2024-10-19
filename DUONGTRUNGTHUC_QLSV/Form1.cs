namespace DUONGTRUNGTHUC_QLSV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = textBox1.Text;
            string password = textBox2.Text;

            // Kiểm tra xem tài khoản có tồn tại trong danh sách hay không
            var user = UserDatabase.Users.FirstOrDefault(u => u.Email == email && u.Password == password);

            if (user != null) // Nếu tài khoản đúng
            {
                QLSV for1 = new QLSV();
                for1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            // Bạn có thể tạo một số tài khoản mẫu ở đây nếu muốn
        }

        private void buttonRegister_Click_1(object sender, EventArgs e)
        {
            Form2 registerForm = new Form2();
            registerForm.ShowDialog();
        }
    }
}
