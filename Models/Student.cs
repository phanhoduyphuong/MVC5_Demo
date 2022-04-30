using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCDemo.Models
{
    public class Student
    {
        [Display(Name="Mã số")]
        [Required(ErrorMessage ="Phải nhập {0}")]
        public string Id { get; set; }
        [Display(Name = "Họ tên")]
        [Required(ErrorMessage ="Phải nhập {0}")]
        [StringLength(100,ErrorMessage ="Giới hạn {1} ký tự")]
        public string Name { get; set; }
        [Display(Name = "Địa chỉ")]
        [StringLength(150,ErrorMessage ="Giới hạn {1} ký tự")]
        public string Address { get; set; }
    }
}