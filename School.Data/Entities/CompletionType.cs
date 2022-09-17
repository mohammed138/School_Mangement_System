using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Data.Entities
{
    public class CompletionType
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
