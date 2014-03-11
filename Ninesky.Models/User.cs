using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Ninesky.Models
{
    public class User
    {
        [Key]
        public int UserID { get; set; }


        [Required(ErrorMessage = "必填")]
        [StringLength(20, MinimumLength = 4, ErrorMessage = "{1}到{0}个字符")]
        [Display(Name = "用户名")]
        public String UserName { get; set; }

        [Required(ErrorMessage = "必填")]
        [Display(Name = "用户组ID")]
        public int GroupID { get; set; }

        [Required(ErrorMessage = "必填")]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "{1}到{0}个字符")]
        [Display(Name = "显示名")]
        public string DisplayName { get; set; }

        [Required(ErrorMessage = "必填")]
        [Display(Name = "密码")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "必填")]
        [Display(Name = "邮箱")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        public int Status { get; set; }
        public DateTime RegistrationTime { get; set; }
        public DateTime LoginTime { get; set; }
        public DateTime LoginIP { get; set; }

        public virtual UserGroup Group { get; set; }


    }
}
