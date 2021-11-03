namespace BaiTapLon.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_ChiTietDonHang : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.KhachHangs", "MaHang", c => c.String());
            AddColumn("dbo.KhachHangs", "DonGia", c => c.String());
            AddColumn("dbo.KhachHangs", "SoLuong", c => c.String());
            AddColumn("dbo.KhachHangs", "ThanhTien", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.KhachHangs", "ThanhTien");
            DropColumn("dbo.KhachHangs", "SoLuong");
            DropColumn("dbo.KhachHangs", "DonGia");
            DropColumn("dbo.KhachHangs", "MaHang");
        }
    }
}
