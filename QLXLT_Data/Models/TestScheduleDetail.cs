using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLXLT_Data.Models
{
    public class TestScheduleDetail
    {
        public TestScheduleDetail()
        {
        }

        [Key, Display(AutoGenerateField = false)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TestScheduleDetailId { get; set; }

        public DateTime TestDay { get; set; }
        public int StartTime { get; set; }

        public int TestScheduleId { get; set; }
        [ForeignKey("TestScheduleId"), Display(AutoGenerateField = false)]
        public virtual TestSchedule TestSchedule { get; set; }

        public int CrediClassId { get; set; }
        [ForeignKey("CrediClassId"), Display(AutoGenerateField = false)]
        public virtual CreditClass CreditClass { get; set; }

        public int SubjectId { get; set; }
        [ForeignKey("SubjectId"), Display(AutoGenerateField = false)]
        public virtual Subject Subject { get; set; }

        public int RoomId { get; set; }
        [ForeignKey("RoomId"), Display(AutoGenerateField = false)]
        public virtual Room Room { get; set; }

        public int TeacherId { get; set; }
        [ForeignKey("TeacherId"), Display(AutoGenerateField = false)]
        public virtual Teacher Teacher { get; set; }
    }
}
