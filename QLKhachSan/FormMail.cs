using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKhachSan
{
    public partial class FormMail : Form
    {
        public FormMail(string email, string matkhau, bool isMatkhau = false)
        {
            InitializeComponent();
            this.email = email;
            this.matkhau = matkhau;
            this.isMatkhau = isMatkhau;
        }

        private string email;
        private string matkhau;
        private bool isMatkhau;

        public void SendMail()
        {
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            NetworkCredential cred = new NetworkCredential("toannguyen0251@gmail.com", "olik tgqv sjiv yzcr");
            MailMessage mailMessage = new MailMessage();
            mailMessage.From = new MailAddress("toannguyen0251@gmail.com");
            mailMessage.To.Add(email);
            if (isMatkhau)
            {
                mailMessage.Subject = "Bạn đã sử dụng tính năng quên mật khẩu";
                mailMessage.Body = "Mật khẩu mới là " + matkhau;
            }
            else
            {
                mailMessage.Subject = "Thông tin đăng nhập!";
                mailMessage.Body = "Mật khẩu của bạn là " + matkhau;
            }

            smtp.Credentials = cred;

            smtp.EnableSsl = true;

            smtp.Send(mailMessage);
            pictureBox1.Invoke(new Action(() => Close()));
        }

        private void FormMail_Load(object sender, EventArgs e)
        {
            Thread r = new Thread(SendMail);
            r.IsBackground = true;
            r.Start();
        }
    }
}
