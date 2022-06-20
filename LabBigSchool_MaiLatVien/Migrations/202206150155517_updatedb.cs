namespace LabBigSchool_MaiLatVien.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedb : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Courses", "DataTime");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Courses", "DataTime", c => c.DateTime(nullable: false));
        }
    }
}
