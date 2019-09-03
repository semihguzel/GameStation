using GameStation.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStation.DAL.Mappings
{
    public class ProductMapping : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Products");
            builder.HasKey(x => x.ProductID);
            builder.Property(x => x.Name).IsRequired().HasMaxLength(100);
            builder.Property(x => x.QuantityPerUnit).HasMaxLength(50);
            builder.Property(x => x.UnitPrice).IsRequired().HasColumnType("money");
            builder.Property(x => x.OldPrice).HasColumnType("money");
            builder.Property(x => x.UnitWeight).HasMaxLength(30);
            builder.Property(x => x.Size).HasMaxLength(30);
            builder.Property(x => x.ImageUrl).IsRequired().HasMaxLength(500);
            builder.Property(x => x.AltText).IsRequired().HasMaxLength(200);
            builder.Property(x => x.ShortDescription).IsRequired().HasMaxLength(500);
            builder.Property(x => x.LongDescription).IsRequired().HasMaxLength(1500);
            builder.Property(x => x.Picture1).HasMaxLength(500);
            builder.Property(x => x.Picture2).HasMaxLength(500);
            builder.Property(x => x.Picture3).HasMaxLength(500);
            builder.Property(x => x.Picture4).HasMaxLength(500);
            builder.Property(x => x.Notes).HasMaxLength(250);

            builder.HasMany(x => x.OrderDetails).WithOne(x => x.Product).HasForeignKey(x => x.ProductID).IsRequired();
            builder.HasMany(x => x.RecentlyViews).WithOne(x => x.Product).HasForeignKey(x => x.ProductID).IsRequired();
            builder.HasMany(x => x.Reviews).WithOne(x => x.Product).HasForeignKey(x => x.ProductID).IsRequired();
            builder.HasMany(x => x.WishLists).WithOne(x => x.Product).HasForeignKey(x => x.ProductID).IsRequired();

            //Seed
            #region Steam Games
            builder.HasData
            (
                new Product
                {
                    ProductID = 1,
                    SupplierID = 1,
                    Name = "RimWorld",
                    CategoryID = 4,
                    UnitPrice = 50,
                    Discount = 0,
                    ImageUrl = Tools.PicturesDirectory + "/Pictures/ProductPictures/Steam/rimworld_logo.png",
                    AltText = "Rimworld",
                    ShortDescription = "RimWorld is a top-down construction and management simulation video game by Montreal-based developer Ludeon Studios. Originally called Eclipse Colony, it was initially released as a Kickstarter crowdfunding project in early access for Microsoft Windows, macOS, and Linux in November 2013, and was officially released on October 17, 2018.",
                    LongDescription = "The futuristic plot originally revolved around three characters being stranded on a planet located in the frontiers of known space (a 'rim world'), where their space liner crashed. The game is set in a universe where faster-than-light travel and superluminal communication are, so far, impossible, making large galactic empires inherently unfeasible. With its release on Steam the game came with the addition, among other things, of a scenario editor, allowing users to choose and modify different starting plots, with different numbers of characters, starting items and map effects available; however, the location of these plots still remained the same, that is, still on a 'rim world'"
                },
                new Product
                {
                    ProductID = 2,
                    SupplierID = 2,
                    Name = "Bannerlord",
                    CategoryID = 1,
                    UnitPrice = 160,
                    Discount = 0,
                    ImageUrl = Tools.PicturesDirectory + "/Pictures/ProductPictures/Steam/bannerlord_logo.png",
                    ShortDescription = "Mount & Blade II: Bannerlord, Orta Çağ temalı bir rol yapma oyunu olan Mount & Blade serisinin bir oyunudur. Oyun, Türk firması TaleWorlds tarafından geliştiştirilmektedir. Oyun Steam'de Ekim 2016'da çıkmıştır. Fakat oyun için bir indirme imkanı sunulmamıştır. Gamescom 2019'da oyunun erken erişim tarihi verilmiş. Ayrıca bu çıkış tarihi Mount & Blade:Warband'ın 10. yılına denk gelmiş olacak.",
                    LongDescription = "27 Eylül 2012'de bir Türk şirketi olan TaleWords tarafından duyurulmuştur. Oyunun Grafikleri daha iyi gölgeleme ve daha yüksek detaylı modellerle önceki oyun olan Mount & Blade: Warband'a göre belirgin bir şekilde daha iyi hâle getirilmiştir. Karakter animasyonları hareket yakalama (motion capture) teknolojisi kullanılarak oluşturulmuş ve yüz animasyonları da canlandırılan duygularla iyileştirilerek güncelleneceği söylendi.",
                    AltText = "Mount & Blade II: Bannerlord"
                }
            );
            #endregion

        }
    }
}
