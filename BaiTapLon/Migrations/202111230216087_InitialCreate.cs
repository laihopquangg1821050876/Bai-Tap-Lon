namespace BaiTapLon.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Accounts",
                c => new
                    {
                        UserName = c.String(nullable: false, maxLength: 128),
                        PassWord = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.UserName);
            
            CreateTable(
                "dbo.ChiTietDonHangs",
                c => new
                    {
                        ChiTietDonHangID = c.Int(nullable: false, identity: true),
                        DonHangID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ChiTietDonHangID);
            
            CreateTable(
                "dbo.DanhMucHangs",
                c => new
                    {
                        MaHang = c.String(nullable: false, maxLength: 128),
                        TenHang = c.String(),
                        DonViTinh = c.String(),
                        SoLuong = c.String(),
                        GiaSP = c.String(),
                    })
                .PrimaryKey(t => t.MaHang);
            
            CreateTable(
                "dbo.DonHangs",
                c => new
                    {
                        DonHangID = c.Int(nullable: false, identity: true),
                        MaKH = c.String(),
                        CreateDate = c.DateTime(nullable: false),
                        MaNV = c.String(),
                    })
                .PrimaryKey(t => t.DonHangID);
            
            CreateTable(
                "dbo.KhachHangs",
                c => new
                    {
                        MaKH = c.String(nullable: false, maxLength: 128),
                        TenKH = c.String(),
                        DiachiKH = c.String(),
                    })
                .PrimaryKey(t => t.MaKH);
            
            CreateTable(
                "dbo.NhanViens",
                c => new
                    {
                        MaNV = c.String(nullable: false, maxLength: 128),
                        TenNV = c.String(),
                        SoDienThoai = c.String(),
                        DiaChi = c.String(),
                    })
                .PrimaryKey(t => t.MaNV);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.NhanViens");
            DropTable("dbo.KhachHangs");
            DropTable("dbo.DonHangs");
            DropTable("dbo.DanhMucHangs");
            DropTable("dbo.ChiTietDonHangs");
            DropTable("dbo.Accounts");
        }
    }
}
