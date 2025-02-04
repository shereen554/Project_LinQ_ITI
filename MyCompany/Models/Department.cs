using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCompany.Models
{
    public class Department
    {
        [Key]

        public int Dnum { get; set; }
        [StringLength(50)]
        public string Dname { get; set; }


        [ForeignKey("MGRSSNNavigation")]

        public int? MGRSSN { get; set; }

        [Column("MGRStart Date", TypeName = "datetime")]
        public DateTime? MGRStart_Date { get; set; }

        [InverseProperty("DnoNavigation")]
        public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();

      //  [InverseProperty("Departments")]
        public virtual Employee? MGRSSNNavigation { get; set; }

        [InverseProperty("DnumNavigation")]
        public virtual ICollection<Project> Projects { get; set; } = new List<Project>();
    }
}
