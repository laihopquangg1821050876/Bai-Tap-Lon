namespace BaiTapLon.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_NhanViens : DbMigration
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
                        DonHangID = c.String(nullable: false, maxLength: 128),
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
                        SoDT = c.String(nullable: false),
                        DiaChi = c.String(),
                    })
                .PrimaryKey(t => t.MaNV);
            
            CreateTable(
                "dbo.PhieuNhap",
                c => new
                    {
                        MaNV = c.String(nullable: false, maxLength: 128),
                        TenNV = c.String(),
                        DonHangID = c.String(maxLength: 128),
                        TenHang = c.String(),
                        Soluong = c.Int(nullable: false),
                        thanhtien = c.String(),
                        Ngaytao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.MaNV)
                .ForeignKey("dbo.DonHangs", t => t.DonHangID)
                .Index(t => t.DonHangID);
            
            CreateTable(
                "dbo.phieuxuat",
                c => new
                    {
                        MaNV = c.String(nullable: false, maxLength: 128),
                        TenNV = c.String(),
                        DonHangID = c.String(maxLength: 128),
                        TenHang = c.String(),
                        Soluong = c.Int(nullable: false),
                        thanhtien = c.String(),
                        Ngaytao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.MaNV)
                .ForeignKey("dbo.DonHangs", t => t.DonHangID)
                .Index(t => t.DonHangID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.phieuxuat", "DonHangID", "dbo.DonHangs");
            DropForeignKey("dbo.PhieuNhap", "DonHangID", "dbo.DonHangs");
            DropIndex("dbo.phieuxuat", new[] { "DonHangID" });
            DropIndex("dbo.PhieuNhap", new[] { "DonHangID" });
            DropTable("dbo.phieuxuat");
            DropTable("dbo.PhieuNhap");
            DropTable("dbo.NhanViens");
            DropTable("dbo.KhachHangs");
            DropTable("dbo.DonHangs");
            DropTable("dbo.DanhMucHangs");
            DropTable("dbo.Accounts");
        }
    }
}
