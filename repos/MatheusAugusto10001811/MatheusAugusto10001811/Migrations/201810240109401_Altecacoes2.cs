namespace MatheusAugusto10001811.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Altecacoes2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Categorias", "Produto_ID", "dbo.Produtoes");
            DropIndex("dbo.Categorias", new[] { "Produto_ID" });
            DropColumn("dbo.Produtoes", "CategoriaID");
            RenameColumn(table: "dbo.Produtoes", name: "Produto_ID", newName: "CategoriaID");
            CreateIndex("dbo.Produtoes", "CategoriaID");
            AddForeignKey("dbo.Produtoes", "CategoriaID", "dbo.Categorias", "CategoriaID", cascadeDelete: true);
            DropColumn("dbo.Categorias", "Produto_ID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Categorias", "Produto_ID", c => c.Int());
            DropForeignKey("dbo.Produtoes", "CategoriaID", "dbo.Categorias");
            DropIndex("dbo.Produtoes", new[] { "CategoriaID" });
            RenameColumn(table: "dbo.Produtoes", name: "CategoriaID", newName: "Produto_ID");
            AddColumn("dbo.Produtoes", "CategoriaID", c => c.Int(nullable: false));
            CreateIndex("dbo.Categorias", "Produto_ID");
            AddForeignKey("dbo.Categorias", "Produto_ID", "dbo.Produtoes", "ID");
        }
    }
}
