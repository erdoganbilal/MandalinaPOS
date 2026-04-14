namespace MandalinaPOS.Entities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Reset : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tblCariHareketler",
                c => new
                    {
                        Kimlik = c.Int(nullable: false, identity: true),
                        BelgeNo = c.String(maxLength: 20, unicode: false),
                        Unvan = c.String(maxLength: 255, unicode: false),
                        Tutar = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Odenen = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Kalan = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Not = c.String(),
                        Tarihi = c.DateTime(nullable: false),
                        SonIslemTarihi = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Kimlik);
            
            CreateTable(
                "dbo.tblGruplar",
                c => new
                    {
                        Kimlik = c.Int(nullable: false, identity: true),
                        GrupAd = c.String(maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.Kimlik);
            
            CreateTable(
                "dbo.tblKullaniciHareketleri",
                c => new
                    {
                        Kimlik = c.Int(nullable: false, identity: true),
                        KullaniciKimlik = c.Int(nullable: false),
                        Aciklama = c.String(maxLength: 300, unicode: false),
                        Tarih = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Kimlik);
            
            CreateTable(
                "dbo.tblKullanicilar",
                c => new
                    {
                        Kimlik = c.Int(nullable: false, identity: true),
                        AdSoyad = c.String(maxLength: 50, unicode: false),
                        Telefon = c.String(maxLength: 15, unicode: false),
                        Adres = c.String(maxLength: 255, unicode: false),
                        Eposta = c.String(maxLength: 150, unicode: false),
                        Gorevi = c.String(maxLength: 50, unicode: false),
                        KullaniciAdi = c.String(maxLength: 20, unicode: false),
                        Parola = c.String(maxLength: 20, unicode: false),
                        HatirlatmaSorusu = c.String(maxLength: 255, unicode: false),
                        Cevap = c.String(maxLength: 50, unicode: false),
                        Tarih = c.DateTime(nullable: false),
                        Durumu = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Kimlik);
            
            CreateTable(
                "dbo.tblKullaniciRoller",
                c => new
                    {
                        Kimlik = c.Int(nullable: false, identity: true),
                        KullaniciKimlik = c.Int(nullable: false),
                        FormName = c.String(maxLength: 50, unicode: false),
                        ControlName = c.String(maxLength: 50, unicode: false),
                        ControlCaption = c.String(maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.Kimlik);
            
            CreateTable(
                "dbo.tblMarkalar",
                c => new
                    {
                        Kimlik = c.Int(nullable: false, identity: true),
                        Marka = c.String(maxLength: 50, unicode: false),
                        MarkaBilgi = c.String(maxLength: 255, unicode: false),
                    })
                .PrimaryKey(t => t.Kimlik);
            
            CreateTable(
                "dbo.tblOdemeHareketleri",
                c => new
                    {
                        Kimlik = c.Int(nullable: false, identity: true),
                        CHKimlik = c.Int(nullable: false),
                        OdemeTuru = c.String(maxLength: 50, unicode: false),
                        Odenen = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Aciklama = c.String(maxLength: 255, unicode: false),
                        Tarihi = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Kimlik);
            
            CreateTable(
                "dbo.tblUrunHareketleri",
                c => new
                    {
                        Kimlik = c.Int(nullable: false, identity: true),
                        CHKimlik = c.Int(nullable: false),
                        UrunKimlik = c.Int(nullable: false),
                        Barkodu = c.String(maxLength: 20, unicode: false),
                        Miktar = c.Int(nullable: false),
                        BFiyat = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Cinsi = c.String(),
                        Tarihi = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Kimlik);
            
            CreateTable(
                "dbo.tblUrunler",
                c => new
                    {
                        Kimlik = c.Int(nullable: false, identity: true),
                        MarkaKimlik = c.Int(nullable: false),
                        GrupKimlik = c.Int(nullable: false),
                        Barkodu = c.String(maxLength: 20, unicode: false),
                        Cinsi = c.String(),
                        Birim = c.String(maxLength: 2, unicode: false),
                        AFiyat = c.Decimal(nullable: false, precision: 18, scale: 2),
                        SFiyat = c.Decimal(nullable: false, precision: 18, scale: 2),
                        FZaman = c.DateTime(nullable: false),
                        HZaman = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Kimlik);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.tblUrunler");
            DropTable("dbo.tblUrunHareketleri");
            DropTable("dbo.tblOdemeHareketleri");
            DropTable("dbo.tblMarkalar");
            DropTable("dbo.tblKullaniciRoller");
            DropTable("dbo.tblKullanicilar");
            DropTable("dbo.tblKullaniciHareketleri");
            DropTable("dbo.tblGruplar");
            DropTable("dbo.tblCariHareketler");
        }
    }
}
