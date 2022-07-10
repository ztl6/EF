using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SchoolManger.Models.School
{
    public class SchoolEditModel
    {
        [Required(ErrorMessage = "{0}不能为空")]
        [Display(Name = "序号")]
        public int Id { get; set; }

        [Required(ErrorMessage = "{0}不能为空")]
        [Display(Name = "身份名称")]
        public string Posts { get; set; }
    }
}