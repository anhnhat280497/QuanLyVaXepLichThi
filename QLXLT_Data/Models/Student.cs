using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLXLT_Data.Models
{
    public class Student: Person
    {
        public Student()
        {
            CreditClasses = new HashSet<CreditClass>();
        }
        public int ClassId { get; set; }

        [ForeignKey("ClassId"), Display(AutoGenerateField = false)]
        public virtual Class Class { get; set; }

        [Display(AutoGenerateField = false)]
        public virtual ICollection<CreditClass> CreditClasses { set; get; }
    }
}
