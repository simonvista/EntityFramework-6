namespace Code1st.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Projects",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Duration = c.Int(nullable: false),
                        Fees = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        StudentId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        BirthDate = c.DateTime(nullable: false),
                        IsBonsfied = c.Boolean(nullable: false),
                        ContactNo = c.String(),
                        Project_Id = c.Int(),
                    })
                .PrimaryKey(t => t.StudentId)
                .ForeignKey("dbo.Projects", t => t.Project_Id)
                .Index(t => t.Project_Id);
            
            CreateTable(
                "dbo.Subjects",
                c => new
                    {
                        SubjectId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Marks = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SubjectId);
            
            CreateTable(
                "dbo.SubjectProjects",
                c => new
                    {
                        Subject_SubjectId = c.Int(nullable: false),
                        Project_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Subject_SubjectId, t.Project_Id })
                .ForeignKey("dbo.Subjects", t => t.Subject_SubjectId, cascadeDelete: true)
                .ForeignKey("dbo.Projects", t => t.Project_Id, cascadeDelete: true)
                .Index(t => t.Subject_SubjectId)
                .Index(t => t.Project_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SubjectProjects", "Project_Id", "dbo.Projects");
            DropForeignKey("dbo.SubjectProjects", "Subject_SubjectId", "dbo.Subjects");
            DropForeignKey("dbo.Students", "Project_Id", "dbo.Projects");
            DropIndex("dbo.SubjectProjects", new[] { "Project_Id" });
            DropIndex("dbo.SubjectProjects", new[] { "Subject_SubjectId" });
            DropIndex("dbo.Students", new[] { "Project_Id" });
            DropTable("dbo.SubjectProjects");
            DropTable("dbo.Subjects");
            DropTable("dbo.Students");
            DropTable("dbo.Projects");
        }
    }
}
