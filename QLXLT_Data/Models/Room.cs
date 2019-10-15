using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLXLT_Data.Models
{
    public class Room
    {
        [Key, Display(AutoGenerateField = false)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RoomId { get; set; }

        [Index(IsUnique = true), Required, MaxLength(256)]
        public string Name { get; set; }
        public int Seats { get; set; }
    }
}
