namespace QLXLT_Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Classes",
                c => new
                    {
                        ClassId = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 256),
                        ClassCode = c.String(nullable: false, maxLength: 256),
                        Subject_SubjectId = c.Int(),
                        Teacher_PersonId = c.Int(),
                    })
                .PrimaryKey(t => t.ClassId)
                .ForeignKey("dbo.Subjects", t => t.Subject_SubjectId)
                .ForeignKey("dbo.People", t => t.Teacher_PersonId)
                .Index(t => t.ClassCode, unique: true)
                .Index(t => t.Subject_SubjectId)
                .Index(t => t.Teacher_PersonId);
            
            CreateTable(
                "dbo.People",
                c => new
                    {
                        PersonId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(maxLength: 256),
                        LastName = c.String(),
                        PersonCode = c.String(nullable: false, maxLength: 256),
                        Image = c.Binary(),
                        ClassId = c.Int(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.PersonId)
                .ForeignKey("dbo.Classes", t => t.ClassId, cascadeDelete: true)
                .Index(t => t.PersonCode, unique: true)
                .Index(t => t.ClassId);
            
            CreateTable(
                "dbo.CreditClasses",
                c => new
                    {
                        CreditClassId = c.Int(nullable: false, identity: true),
                        SubjectId = c.Int(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        TeacherId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CreditClassId)
                .ForeignKey("dbo.Subjects", t => t.SubjectId, cascadeDelete: true)
                .ForeignKey("dbo.People", t => t.TeacherId, cascadeDelete: true)
                .Index(t => t.SubjectId)
                .Index(t => t.TeacherId);
            
            CreateTable(
                "dbo.Subjects",
                c => new
                    {
                        SubjectId = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 256),
                        TestTime = c.Int(nullable: false),
                        SubjectCode = c.String(nullable: false, maxLength: 256),
                        Teacher_PersonId = c.Int(),
                    })
                .PrimaryKey(t => t.SubjectId)
                .ForeignKey("dbo.People", t => t.Teacher_PersonId)
                .Index(t => t.SubjectCode, unique: true)
                .Index(t => t.Teacher_PersonId);
            
            CreateTable(
                "dbo.Rooms",
                c => new
                    {
                        RoomId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 256),
                        Seats = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.RoomId)
                .Index(t => t.Name, unique: true);
            
            CreateTable(
                "dbo.TestSchedules",
                c => new
                    {
                        TestScheduleId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.TestScheduleId);
            
            CreateTable(
                "dbo.TestScheduleDetails",
                c => new
                    {
                        TestScheduleDetailId = c.Int(nullable: false, identity: true),
                        TestDay = c.DateTime(nullable: false),
                        StartTime = c.Int(nullable: false),
                        TestScheduleId = c.Int(nullable: false),
                        CrediClassId = c.Int(nullable: false),
                        SubjectId = c.Int(nullable: false),
                        RoomId = c.Int(nullable: false),
                        TeacherId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TestScheduleDetailId)
                .ForeignKey("dbo.CreditClasses", t => t.CrediClassId, cascadeDelete: false)
                .ForeignKey("dbo.Rooms", t => t.RoomId, cascadeDelete: false)
                .ForeignKey("dbo.Subjects", t => t.SubjectId, cascadeDelete: false)
                .ForeignKey("dbo.People", t => t.TeacherId, cascadeDelete: false)
                .ForeignKey("dbo.TestSchedules", t => t.TestScheduleId, cascadeDelete: false)
                .Index(t => t.TestScheduleId)
                .Index(t => t.CrediClassId)
                .Index(t => t.SubjectId)
                .Index(t => t.RoomId)
                .Index(t => t.TeacherId);
            
            CreateTable(
                "dbo.CreditClassStudents",
                c => new
                    {
                        CreditClass_CreditClassId = c.Int(nullable: false),
                        Student_PersonId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.CreditClass_CreditClassId, t.Student_PersonId })
                .ForeignKey("dbo.CreditClasses", t => t.CreditClass_CreditClassId, cascadeDelete: false)
                .ForeignKey("dbo.People", t => t.Student_PersonId, cascadeDelete: false)
                .Index(t => t.CreditClass_CreditClassId)
                .Index(t => t.Student_PersonId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TestScheduleDetails", "TestScheduleId", "dbo.TestSchedules");
            DropForeignKey("dbo.TestScheduleDetails", "TeacherId", "dbo.People");
            DropForeignKey("dbo.TestScheduleDetails", "SubjectId", "dbo.Subjects");
            DropForeignKey("dbo.TestScheduleDetails", "RoomId", "dbo.Rooms");
            DropForeignKey("dbo.TestScheduleDetails", "CrediClassId", "dbo.CreditClasses");
            DropForeignKey("dbo.CreditClasses", "TeacherId", "dbo.People");
            DropForeignKey("dbo.Subjects", "Teacher_PersonId", "dbo.People");
            DropForeignKey("dbo.Classes", "Teacher_PersonId", "dbo.People");
            DropForeignKey("dbo.CreditClasses", "SubjectId", "dbo.Subjects");
            DropForeignKey("dbo.Classes", "Subject_SubjectId", "dbo.Subjects");
            DropForeignKey("dbo.CreditClassStudents", "Student_PersonId", "dbo.People");
            DropForeignKey("dbo.CreditClassStudents", "CreditClass_CreditClassId", "dbo.CreditClasses");
            DropForeignKey("dbo.People", "ClassId", "dbo.Classes");
            DropIndex("dbo.CreditClassStudents", new[] { "Student_PersonId" });
            DropIndex("dbo.CreditClassStudents", new[] { "CreditClass_CreditClassId" });
            DropIndex("dbo.TestScheduleDetails", new[] { "TeacherId" });
            DropIndex("dbo.TestScheduleDetails", new[] { "RoomId" });
            DropIndex("dbo.TestScheduleDetails", new[] { "SubjectId" });
            DropIndex("dbo.TestScheduleDetails", new[] { "CrediClassId" });
            DropIndex("dbo.TestScheduleDetails", new[] { "TestScheduleId" });
            DropIndex("dbo.Rooms", new[] { "Name" });
            DropIndex("dbo.Subjects", new[] { "Teacher_PersonId" });
            DropIndex("dbo.Subjects", new[] { "SubjectCode" });
            DropIndex("dbo.CreditClasses", new[] { "TeacherId" });
            DropIndex("dbo.CreditClasses", new[] { "SubjectId" });
            DropIndex("dbo.People", new[] { "ClassId" });
            DropIndex("dbo.People", new[] { "PersonCode" });
            DropIndex("dbo.Classes", new[] { "Teacher_PersonId" });
            DropIndex("dbo.Classes", new[] { "Subject_SubjectId" });
            DropIndex("dbo.Classes", new[] { "ClassCode" });
            DropTable("dbo.CreditClassStudents");
            DropTable("dbo.TestScheduleDetails");
            DropTable("dbo.TestSchedules");
            DropTable("dbo.Rooms");
            DropTable("dbo.Subjects");
            DropTable("dbo.CreditClasses");
            DropTable("dbo.People");
            DropTable("dbo.Classes");
        }
    }
}
