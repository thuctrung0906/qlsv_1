using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DUONGTRUNGTHUC_QLSV
{
    public static class UserDatabase
    {
        public static List<User> Users = new List<User>(); // Lưu danh sách tài khoản đã đăng ký

        public class User
        {
            public string Email { get; set; }
            public string Password { get; set; }
        }
    }
}
