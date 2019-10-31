using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RmgAPI.Models
{
    public class Employees
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Employee Name is Required")]
        public string EmployeeName { get; set; }

        [Required(ErrorMessage = "Current Project is Required")]
        public string CurrentProject { get; set; }

        [Required(ErrorMessage = "Email is Required")]
        public String Email { get; set; }

        [Required(ErrorMessage = "Contact Number is Required")]
        public string ContactNumber { get; set; }
        [Required(ErrorMessage = "Experience is Required")]
        public string Experience { get; set; }
        public string Technology { get; set; }
        public string src { get; set; }

        [ForeignKey("Account")]
        public int AccountID { get; set; }

        
    }
}
