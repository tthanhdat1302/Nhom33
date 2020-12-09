﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DoAn2.Models
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Mail;

    public partial class UserKH
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public UserKH()
        {
            this.Comments = new HashSet<Comment>();
        }
    
        public int ID { get; set; }
        public string TaiKhoan { get; set; }
        public string PassWord { get; set; }
        public string ConfirmPassword { get; set; }
        public string Ten { get; set; }
        public string DiaChi { get; set; }
        public string Email { get; set; }
        public string DienThoai { get; set; }
        public string TinhThanh { get; set; }
        public string QuanHuyen { get; set; }
        public Nullable<System.DateTime> NgayTao { get; set; }
        public Nullable<System.DateTime> NgayCapNhat { get; set; }
        public Nullable<bool> TrangThai { get; set; }
        public string Hinh { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Comment> Comments { get; set; }
        public void SendEmail()
        {
            using (MailMessage mail = new MailMessage())
            {
                mail.From = new MailAddress("tthanhdat1302@gmail.com");
                mail.To.Add(Email);
                mail.Subject = "Đăng ký thành công!";
                mail.Body = "Chúc mừng bạn đã đăng ký tài khoản thành công...Vui lòng không trả lời tin nhắn này!";
                mail.IsBodyHtml = true;

                using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                {
                    smtp.Credentials = new NetworkCredential("tthanhdat1302@gmail.com", "dat130299");
                    smtp.EnableSsl = true;
                    smtp.Send(mail);
                }
            }


        }
    }
}