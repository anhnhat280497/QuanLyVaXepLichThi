using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLXLT_Data.Models
{
    public class CreditClassGroup
    {
        public CreditClassGroup()
        {
            Students = new HashSet<Student>();
        }

        [Key, Display(AutoGenerateField = false)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CreditClassGroupId { get; set; }

        public int CreditClassId { get; set; }
        [ForeignKey("CreditClassId"), Display(AutoGenerateField = false)]
        public virtual CreditClass CreditClass { get; set; }
        public virtual ICollection<Student> Students { set; get; }
    }
}
