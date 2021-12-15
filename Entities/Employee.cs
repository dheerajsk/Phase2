using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Entities
{
    public class Employee : BaseEntity
    {

        [Required]
        [Display(Name="EmployeeName")]
        public string Name { get; set; }

        public string Dept { get; set; }
    }
}
