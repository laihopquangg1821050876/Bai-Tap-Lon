namespace BaiTapLon.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Alter_Column_SoDT : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.KhachHangs", "SoDT", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.KhachHangs", "SoDT");
        }
    }
}
