using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLXLT_Data.Models
{
    public class Subject
    {
        public Subject()
        {
            Classes = new HashSet<Class>();
        }
        [Key, Display(AutoGenerateField = false)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SubjectId { get; set; }
        [Column(TypeName = "NVARCHAR"), MinLength(3), MaxLength(256)]
        public string Name { get; set; }
        public int TestTime { get; set; }

        [Index(IsUnique = true), Required, MaxLength(256)]
        public string SubjectCode { get; set; }

        [Display(AutoGenerateField = false)]
        public virtual ICollection<Class> Classes { set; get; }

    }
}
