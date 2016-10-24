namespace SklepInternetowy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Kategoria",
                c => new
                    {
                        KategoriaId = c.Int(nullable: false, identity: true),
                        NazwaKategorii = c.String(nullable: false, maxLength: 100),
                        OpisKategorii = c.String(nullable: false),
                        NazwaPlikuIkony = c.String(),
                    })
                .PrimaryKey(t => t.KategoriaId);
            
            CreateTable(
                "dbo.Kurs",
                c => new
                    {
                        KursId = c.Int(nullable: false, identity: true),
                        KategoriaId = c.Int(nullable: false),
                        NazwaKursu = c.String(nullable: false, maxLength: 100),
                        AutorKusrsu = c.String(nullable: false, maxLength: 100),
                        DataDodania = c.DateTime(nullable: false),
                        NazwaPlikuObrazka = c.String(maxLength: 100),
                        OpisKursu = c.String(),
                        CenaKursu = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Bestseller = c.Boolean(nullable: false),
                        Ukryty = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.KursId)
                .ForeignKey("dbo.Kategoria", t => t.KategoriaId, cascadeDelete: true)
                .Index(t => t.KategoriaId);
            
            CreateTable(
                "dbo.PozycjaZamowienia",
                c => new
                    {
                        PozycjaZamowieniaId = c.Int(nullable: false, identity: true),
                        ZamowieniaId = c.Int(nullable: false),
                        KursId = c.Int(nullable: false),
                        Ilosc = c.Int(nullable: false),
                        CenaZakupu = c.Decimal(nullable: false, precision: 18, scale: 2),
                        zamowienie_ZamowienieId = c.Int(),
                    })
                .PrimaryKey(t => t.PozycjaZamowieniaId)
                .ForeignKey("dbo.Kurs", t => t.KursId, cascadeDelete: true)
                .ForeignKey("dbo.Zamowienie", t => t.zamowienie_ZamowienieId)
                .Index(t => t.KursId)
                .Index(t => t.zamowienie_ZamowienieId);
            
            CreateTable(
                "dbo.Zamowienie",
                c => new
                    {
                        ZamowienieId = c.Int(nullable: false, identity: true),
                        Imie = c.String(nullable: false, maxLength: 50),
                        Nazwisko = c.String(nullable: false, maxLength: 50),
                        Ulica = c.String(nullable: false, maxLength: 50),
                        Miasto = c.String(nullable: false, maxLength: 50),
                        KodPocztowy = c.String(nullable: false, maxLength: 6),
                        Telefon = c.String(),
                        Email = c.String(),
                        Komentarz = c.String(),
                        DataDodania = c.DateTime(nullable: false),
                        StanZamowienia = c.Int(nullable: false),
                        WartoscZamowienia = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.ZamowienieId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PozycjaZamowienia", "zamowienie_ZamowienieId", "dbo.Zamowienie");
            DropForeignKey("dbo.PozycjaZamowienia", "KursId", "dbo.Kurs");
            DropForeignKey("dbo.Kurs", "KategoriaId", "dbo.Kategoria");
            DropIndex("dbo.PozycjaZamowienia", new[] { "zamowienie_ZamowienieId" });
            DropIndex("dbo.PozycjaZamowienia", new[] { "KursId" });
            DropIndex("dbo.Kurs", new[] { "KategoriaId" });
            DropTable("dbo.Zamowienie");
            DropTable("dbo.PozycjaZamowienia");
            DropTable("dbo.Kurs");
            DropTable("dbo.Kategoria");
        }
    }
}
