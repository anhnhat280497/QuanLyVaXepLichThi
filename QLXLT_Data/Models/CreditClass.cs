using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLXLT_Data.Models
{
    public class CreditClass
    {
        public CreditClass()
        {
            Students = new HashSet<Student>();
            CreditClassGroups = new HashSet<CreditClassGroup>();
        }

        [Key, Display(AutoGenerateField = false)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CreditClassId { get; set; }

        public int SubjectId { get; set; }
        [ForeignKey("SubjectId"), Display(AutoGenerateField = false)]
        public virtual Subject Subject { get; set; }

        public bool IsActive { get; set; }

        public int TeacherId { get; set; }

        [ForeignKey("TeacherId"), Display(AutoGenerateField = false)]
        public virtual Teacher Teacher { get; set; }

        [Display(AutoGenerateField = false)]
        public virtual ICollection<Student> Students { set; get; }
        [Display(AutoGenerateField = false)]
        public virtual ICollection<CreditClassGroup> CreditClassGroups { set; get; }
    } 
}
