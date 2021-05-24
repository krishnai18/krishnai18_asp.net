using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCDemoApp.Models
{
    public class Employee
    {
        [Required (ErrorMessage = "EmpId is compulsory field")]
        [RegularExpression(@"[0-9]{4}",ErrorMessage = "Enter four digit EmpId")]
        public int? EmpId { get; set; }

        [Required(ErrorMessage = "EmpName is compulsory field")]
        [StringLength(10, ErrorMessage = "Maximum EmpName length is 10 character")]
        public string EmpName { get; set; }

        [Required(ErrorMessage = "Salary is compulsory field")]
        public double? Salary { get; set; }



    }
}
