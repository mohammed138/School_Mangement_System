using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Data.Entities
{
    public class ApplicationUser: IdentityUser
    {
        [Display(Name="رقم الهاتف")]

        public string PhoneNo { get; set; }

        [Display(Name = " الاسم كامل")]
        public string FullName { get; set; }

        [Display(Name = " الاسم كامل")]
        public bool? IsEnabled { get; set; }
    }
}
