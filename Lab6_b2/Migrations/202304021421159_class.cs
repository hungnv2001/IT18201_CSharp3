namespace Lab6_b2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _class : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Catagolies",
                c => new
                    {
                        CatagolyID = c.Int(nullable: false, identity: true),
                        CatagolyName = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.CatagolyID);
            
            AddColumn("dbo.BookManergers", "CatagolyID", c => c.Int(nullable: false));
            CreateIndex("dbo.BookManergers", "CatagolyID");
            AddForeignKey("dbo.BookManergers", "CatagolyID", "dbo.Catagolies", "CatagolyID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.BookManergers", "CatagolyID", "dbo.Catagolies");
            DropIndex("dbo.BookManergers", new[] { "CatagolyID" });
            DropColumn("dbo.BookManergers", "CatagolyID");
            DropTable("dbo.Catagolies");
        }
    }
}
