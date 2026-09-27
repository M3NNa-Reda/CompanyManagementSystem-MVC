using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Demo.DAL.Models
{
    public class Employee : ModelBase
    {

        [Required(ErrorMessage ="Name Is Required!!")]
        [MaxLength(50,ErrorMessage ="Max Length of Name is 50 Chars")]
        [MinLength(5,ErrorMessage ="Min Length of Name is 5 Chars")]
        public string Name { get; set; }

        [Range(22,30)]
        public int? Age { get; set; }
        [RegularExpression(@"^[0-9]{1,3}-[a-zA-Z]{5,10}-[a-zA-Z]{4,10}-[a-zA-Z]{5,10}$",
            ErrorMessage ="Address must be like 123-Streat-City-Country")]
        public string Address { get; set; }

        [DataType(DataType.Currency)]
        public decimal Salary { get; set; }
        [Display(Name = "Is Avtive")]
        public bool IsActive { get; set; }

        [EmailAddress]
        public string Email { get; set; }
        [Phone]
        [Display(Name = "Phone Number")]

        public string PhoneNumber { get; set; }
        [Display(Name = "Hire Date")]
        public DateTime HireDate  { get; set; }
        public bool IsDeleted { get; set; } //soft delete
        public DateTime CreationDate { get; set; }
        public int? DepartmentId { get; set; }
        public Department? Department { get; set; }
        
    }
}
