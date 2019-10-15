using QLXLT_Data.Models;
using System.Data.Entity;

namespace QLXLT_Data.Data
{
    public class XLTContext : DbContext
    {
        #region properties
        public DbSet<Class> Class { get; set; }
        public DbSet<CreditClass> CreditClass { get; set; }
        public DbSet<Person> Person { get; set; }
        public DbSet<Student> Student { get; set; }
        public DbSet<Room> Room { get; set; }
        public DbSet<Subject> Subject { get; set; }
        public DbSet<Teacher> Teacher { get; set; }
        public DbSet<TestSchedule> TestSchedule { get; set; }
        public DbSet<TestScheduleDetail> TestScheduleDetail { get; set; }
        #endregion

        /// <summary>
        /// constructor
        /// </summary>
        public XLTContext() : base("name=XLTConnection")
        {
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false;
        }
    }
}
