namespace Filmes_DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class inicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Diretor",
                c => new
                    {
                        DiretorId = c.Guid(nullable: false),
                        Nome = c.String(nullable: false, maxLength: 50, unicode: false),
                        Pais = c.String(nullable: false, maxLength: 50, unicode: false),
                        Nacimento = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.DiretorId);
            
            CreateTable(
                "dbo.Filme",
                c => new
                    {
                        FilmeId = c.Guid(nullable: false),
                        Titulo = c.String(nullable: false, maxLength: 50, unicode: false),
                        Descricao = c.String(nullable: false, maxLength: 200, unicode: false),
                        DiretorId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.FilmeId)
                .ForeignKey("dbo.Diretor", t => t.DiretorId)
                .Index(t => t.DiretorId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Filme", "DiretorId", "dbo.Diretor");
            DropIndex("dbo.Filme", new[] { "DiretorId" });
            DropTable("dbo.Filme");
            DropTable("dbo.Diretor");
        }
    }
}
