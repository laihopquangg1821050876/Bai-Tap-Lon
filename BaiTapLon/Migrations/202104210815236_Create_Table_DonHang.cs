namespace BaiTapLon.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_DonHang : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Donhangs", "MaDH", c => c.String());
            AddColumn("dbo.Donhangs", "Ngay", c => c.String());
            AddColumn("dbo.Donhangs", "MaNV", c => c.String());
            AddColumn("dbo.Donhangs", "TenSP", c => c.String());
            AddColumn("dbo.Donhangs", "GiaSP", c => c.String());
            AddColumn("dbo.Donhangs", "Discriminator", c => c.String(nullable: false, maxLength: 128));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Donhangs", "Discriminator");
            DropColumn("dbo.Donhangs", "MaNV");
            DropColumn("dbo.Donhangs", "Ngay");
            DropColumn("dbo.Donhangs", "MaDH");
            DropColumn("dbo.Donhangs", "TenSP");
            DropColumn("dbo.Donhangs", "GiaSP");
        }
    }
}
