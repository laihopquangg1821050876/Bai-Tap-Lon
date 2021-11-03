namespace BaiTapLon.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_DonHang : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.KhachHangs", "MaDH", c => c.String());
            AddColumn("dbo.KhachHangs", "Ngay", c => c.String());
            AddColumn("dbo.KhachHangs", "MaNV", c => c.String());
            AddColumn("dbo.KhachHangs", "Discriminator", c => c.String(nullable: false, maxLength: 128));
        }
        
        public override void Down()
        {
            DropColumn("dbo.KhachHangs", "Discriminator");
            DropColumn("dbo.KhachHangs", "MaNV");
            DropColumn("dbo.KhachHangs", "Ngay");
            DropColumn("dbo.KhachHangs", "MaDH");
        }
    }
}
