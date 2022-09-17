using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Data.Entities
{
    public class Decisions : BaseClass
    {
        public int Id { get; set; }

        [Display(Name = " السماح للمعلمين للإضافة   ")] 
        public bool? AllowToCreatMarks { get; set; }

        [Display(Name = " السماح للمعلمين بالتعديل     ")] 
        public bool? AllowToUpdatedMarks { get; set; }


        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy}")]
        [Display(Name = " السماح من تاريخ   ")]
        public DateTime? CreatedAllowedFrom { get; set; }


        
        [DataType(DataType.Date)] 
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy}")]
        [Display(Name = " السماح إلى تاريخ   ")]
        public DateTime? CreatedAllowedTo { get; set; }
 
        [DataType(DataType.Date)] 
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy}")]
        [Display(Name = " السماح من تاريخ   ")]
        public DateTime? UpdatedAllowedFrom { get; set; }


         
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy}")]
        [Display(Name = " السماح إلى تاريخ   ")]
        public DateTime? UpdatedAllowedTo { get; set; }


    }
}
