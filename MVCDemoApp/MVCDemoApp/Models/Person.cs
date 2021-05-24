using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCDemoApp.Models
{
    public class Person
    {
        [Required(ErrorMessage = "Name is compulsory field")]
        [StringLength(10, ErrorMessage = "Maximum Name length is 10 character")]
        public string Name { get; set; }

        [Required(ErrorMessage = "mobileno is compulsory field")]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid phone number")]
        public int mobileno { get; set; }

        [Required(ErrorMessage = "Email-id is compulsory field")]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$",ErrorMessage = "E-mail is not valid")]
        public string Emailid { get; set; }

        [Required(ErrorMessage = "list is compulsory field")]
        public string WillAttend { get; set; }
    }
}
