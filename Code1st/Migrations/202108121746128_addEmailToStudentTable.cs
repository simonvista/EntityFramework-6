namespace Code1st.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addEmailToStudentTable : DbMigration
    {
        public override void Up()
        {
            //AddColumn("dbo.Students", "Email", c => c.String());
            AddColumn("dbo.Students", "Email", c => c.String(defaultValue:"test@test.com"));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Students", "Email");
        }
    }
}
