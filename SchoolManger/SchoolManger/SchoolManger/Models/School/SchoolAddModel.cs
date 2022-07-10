using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SchoolManger.Models.School
{
    public class SchoolAddModel
    {
        [Required(ErrorMessage = "{0}不能为空")]
        [Remote("IsExits", "School", ErrorMessage = "{0}已存在")]
        [Display(Name = "身份名称")]
        public string posts { get; set; }
    }
}