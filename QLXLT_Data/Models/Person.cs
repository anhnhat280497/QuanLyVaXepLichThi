using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLXLT_Data.Models
{
    public class Person
    {
        [Key, Display(AutoGenerateField = false)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PersonId { get; set; }
        [Column(TypeName = "NVARCHAR"), MaxLength(256)]
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [Index(IsUnique = true), Required, MaxLength(256)]
        public string PersonCode { get; set; }
        public byte[] Image { get; set; }
    }
}
