using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCompany.Models
{
    [PrimaryKey(nameof(ESSn),nameof(Pno))]
    public class Works_For
    {
        public int ESSn { get; set; }

        public int Pno { get; set; }

        [ForeignKey("ESSn")]
        [InverseProperty("Works_fors")]
        public virtual Employee ESSnNavigation { get; set; }

        [ForeignKey("Pno")]
        [InverseProperty("Works_fors")]
        public virtual Project PnoNavigation { get; set; }
    }
}
