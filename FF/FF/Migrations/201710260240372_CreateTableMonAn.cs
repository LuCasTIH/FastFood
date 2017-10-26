namespace FF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTableMonAn : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MonAns",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TenMon = c.String(nullable: false),
                        DonGia = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.MonAns");
        }
    }
}
