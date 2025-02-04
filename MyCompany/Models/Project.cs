using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCompany.Models
{
    public class Project
    {
        [Key]
        public int PNum { get; set; }
        [StringLength(50)]
        public string Pname { get; set; }


        [StringLength(50)]
        public string Plocation { get; set; }

        public int? Dnum { get; set; }

        [ForeignKey("Dnum")]
        [InverseProperty("Projects")]
        public virtual Department DnumNavigation { get; set; }

        [InverseProperty("PnoNavigation")]
        public virtual ICollection<Works_For> Works_fors { get; set; } = new List<Works_For>();
    }
}
