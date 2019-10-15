using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace QLXLT_Data.Models
{
    public class Teacher : Person
    {
        public Teacher()
        {
            Subjects = new HashSet<Subject>();
            Classes = new HashSet<Class>();
        }
        [Display(AutoGenerateField = false)]
        public virtual ICollection<Subject> Subjects { set; get; }
        [Display(AutoGenerateField = false)]
        public virtual ICollection<Class> Classes { set; get; }
    }
}
