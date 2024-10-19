using System;

namespace DUONGTRUNGTHUC_QLSV
{
    internal class SinhVien
    {
        public string MASV { get; set; }   // Mã sinh viên
        public string Ten { get; set; }     // Tên sinh viên
        public DateTime NamSinh { get; set; } // Ngày sinh
        public string GioiTinh { get; set; } // Giới tính: "Nam" hoặc "Nữ"
        public string Nganh { get; set; }    // Ngành học
        public string Lop { get; set; }      // Lớp học
    }
}
