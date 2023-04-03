namespace Lab6_b2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class del : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.BookManergers", "CatagolyID", "dbo.Catagolies");
            DropIndex("dbo.BookManergers", new[] { "CatagolyID" });
            DropTable("dbo.Catagolies");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Catagolies",
                c => new
                    {
                        CatagolyID = c.Int(nullable: false, identity: true),
                        CatagolyName = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.CatagolyID);
            
            CreateIndex("dbo.BookManergers", "CatagolyID");
            AddForeignKey("dbo.BookManergers", "CatagolyID", "dbo.Catagolies", "CatagolyID", cascadeDelete: true);
        }
    }
}
