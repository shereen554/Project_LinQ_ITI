using Azure.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCompany.Models
{
    public class Employee
    {
        [MinLength(7)]
        public string UserName { get; set; }
        [MinLength(7)]

        public string Passowrd {  get; set; }
        [StringLength(50)]
        public string Name { get; set; }

        [Key]
        public int SSN { get; set; }
        public DateTime? BirthDate { get; set; }

        [StringLength(50)]
        public string Address { get; set; }

        [StringLength(1)]
        public Char Gender { get; set; }
        public string Email { get; set; }   
        public string Phone { get; set; }

        public int? Salary { get; set; }
        public string Role { get; set; }

        public int? Superssn { get; set; }
        [ForeignKey("DnoNavigation")]

        public int? Dno { get; set; }

        [InverseProperty("MGRSSNNavigation")]
        public virtual Department Departments { get; set; }

       // [ForeignKey("Dno")]
        //[InverseProperty("Employees")]
        public virtual Department? DnoNavigation { get; set; }

        [InverseProperty("SuperssnNavigation")]
        public virtual ICollection<Employee> InverseSuperssnNavigation { get; set; } = new List<Employee>();

        [ForeignKey("Superssn")]
        [InverseProperty("InverseSuperssnNavigation")]
        public virtual Employee SuperssnNavigation { get; set; }

        [InverseProperty("ESSnNavigation")]
        public virtual ICollection<Works_For> Works_fors { get; set; } = new List<Works_For>();


    }
}
