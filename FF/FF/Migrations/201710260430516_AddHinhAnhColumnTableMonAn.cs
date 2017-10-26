namespace FF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddHinhAnhColumnTableMonAn : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MonAns", "HinhAnh", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.MonAns", "HinhAnh");
        }
    }
}
