namespace Code1st.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addTeacherToDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Teachers",
                c => new
                    {
                        TeacherId = c.Int(nullable: false, identity: true),
                        TeacherName = c.String(),
                        Contact = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.TeacherId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Teachers");
        }
    }
}
