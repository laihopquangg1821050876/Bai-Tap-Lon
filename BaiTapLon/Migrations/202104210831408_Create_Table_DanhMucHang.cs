namespace BaiTapLon.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_DanhMucHang : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DanhMucHangs",
                c => new
                    {
                        MaHang = c.String(nullable: false, maxLength: 128),
                        TenHang = c.String(),
                        DonViTinh = c.String(),
                        SoLuong = c.String(),
                    })
                .PrimaryKey(t => t.MaHang);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.DanhMucHangs");
        }
    }
}
