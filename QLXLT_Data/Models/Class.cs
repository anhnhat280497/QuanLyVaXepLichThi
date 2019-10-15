using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLXLT_Data.Models
{
    public class Class
    {
        public Class()
        {
            Students = new HashSet<Student>();
            //Subjects = new HashSet<Subject>();
            //Teachers = new HashSet<Teacher>();
        }

        [Key, Display(AutoGenerateField = false)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ClassId { get; set; }
        [Column(TypeName = "NVARCHAR"), MinLength(3), MaxLength(256)]
        public string Name { get; set; }

        [Index(IsUnique = true), Required, MaxLength(256)]
        public string ClassCode { get; set; }
        [Display(AutoGenerateField = false)]
        public virtual ICollection<Student> Students { set; get; }
        //[Display(AutoGenerateField = false)]
        //public virtual ICollection<Subject> Subjects { set; get; }
        //[Display(AutoGenerateField = false)]
        //public virtual ICollection<Teacher> Teachers { set; get; }
    }
}
