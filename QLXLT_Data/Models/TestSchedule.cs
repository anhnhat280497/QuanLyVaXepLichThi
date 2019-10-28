using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLXLT_Data.Models
{
    public class TestSchedule
    {
        public TestSchedule()
        {
            TestScheduleDetails = new HashSet<TestScheduleDetail>();
        }
        [Key, Display(AutoGenerateField = false)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TestScheduleId { get; set; }

        public int Semester { get; set; }
        public string SchoolYear { get; set; }
        public DateTime StartDay { get; set; }
        public DateTime EndDay { get; set; }

        public virtual ICollection<TestScheduleDetail> TestScheduleDetails { set; get; }
    }
}
