using DTO_qlks;
using System.Data;
using System.Security.Cryptography;
using System.Text;

namespace BUS_qlks
{
    public class Class1
    {
        DAL_qlks.Class1 dalnv = new DAL_qlks.Class1();
        public string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();

                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2")); // "x2" để chuyển đổi byte thành chuỗi hex
                }

                return builder.ToString();
            }
        }

        public bool dangnhap(DTO_nhanvien dtonv)
        {
            return dalnv.dangnhap(dtonv);
        }

        public bool checkemail(string email)
        {
            return dalnv.checkemail(email);
        }

        public bool updatematkhau(string email,string matkhau)
        {
            matkhau = HashPassword(matkhau);
            return dalnv.updatematkhau(email,matkhau);
        }
        public DataTable danhsachnhanvien()
        {
            return dalnv.danhsachnhanvien();
        }

        public DataTable timnhanvien(string tennv)
        {
            return dalnv.timnhanvien(tennv);
        }
        public bool ThemNhanVien(DTO_nhanvien dtonv)
        {
            dtonv.Matkhau = HashPassword(dtonv.Matkhau);
            return dalnv.ThemNhanVien(dtonv);
        }

        public bool SuaNhanvien(DTO_nhanvien dtonv)
        {
            return dalnv.SuaNhanVien(dtonv);
        }

        public bool XoaNhanVien(string maNhanVien)
        {
            return dalnv.XoaNhanVien(maNhanVien);
        }
        


        //mk ramdom
        public string getPassword()
        {
            Random r = new Random();
            StringBuilder builder = new StringBuilder();
            builder.Append(randomString(4, true));
            builder.Append(r.Next(1000, 9999));
            builder.Append(randomString(2, false));
            return builder.ToString();

        }
        private string randomString(int size, bool lowerCase)
        {
            StringBuilder builder = new StringBuilder();
            Random r = new Random();
            char ch;
            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * r.NextDouble() + 65)));
                builder.Append(ch);
            }
            if (lowerCase)
            {
                return builder.ToString().ToUpper();

            }
            else return builder.ToString().ToLower();
        }

        public DataTable thongtinnhanvien(string email)
        {
            return dalnv.thongtinnhanvien(email);
        }
        public string TimMaNhanVienTheoEmail(string email)
        {
            return dalnv.TimMaNhanVienTheoEmail(email);
        }
    }
}