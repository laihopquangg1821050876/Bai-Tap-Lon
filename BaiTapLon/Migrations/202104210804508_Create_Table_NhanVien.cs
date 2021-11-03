namespace BaiTapLon.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_NhanVien : DbMigration
    {
        public override void Up()
        {
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
        }
    }
}
