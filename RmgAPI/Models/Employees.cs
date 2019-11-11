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
        public int? Id { get; set; }

        [Required(ErrorMessage = "Employee Name is Required")]
        public string EmployeeName { get; set; }

        [Required(ErrorMessage = "Current Project is Required")]
        public string CurrentProject { get; set; }

        // Current Project can be: BENCH, TRAINING, OR EY/ DELTA Etc.

        [Required(ErrorMessage = "Email is Required")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Contact Number is Required")]
        public string ContactNumber { get; set; }

        [Required(ErrorMessage = "Experience is Required")]
        public int? Experience { get; set; }

        [Required(ErrorMessage = "Technology is Required")]
        public string Technology { get; set; }

        [Required(ErrorMessage = "Start Date is Required")]
        public DateTime? StartDate { get; set; }

        [ForeignKey("ListOfRequests")]
        public int? RequestID { get; set; }

    }
}
