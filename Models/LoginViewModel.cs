using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCDemo.Models
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name="Tên Đăng Nhập")]
        public string Username { get; set; }
        [Display(Name = "Mật Khẩu")]
        [Required]
        public string Password { get; set; }
    }
}