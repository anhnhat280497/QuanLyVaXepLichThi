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

        public virtual ICollection<TestScheduleDetail> TestScheduleDetails { set; get; }
    }
}
