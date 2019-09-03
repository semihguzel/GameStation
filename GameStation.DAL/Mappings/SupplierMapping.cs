using GameStation.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStation.DAL.Mappings
{
    public class SupplierMapping : IEntityTypeConfiguration<Supplier>
    {
        public void Configure(EntityTypeBuilder<Supplier> builder)
        {
            builder.ToTable("Suppliers");
            builder.HasKey(x => x.SupplierID);
            builder.Property(x => x.CompanyName).IsRequired().HasMaxLength(50);
            builder.Property(x => x.ContactName).HasMaxLength(50);
            builder.Property(x => x.ContactTitle).HasMaxLength(50);
            builder.Property(x => x.Address).HasMaxLength(150);
            builder.Property(x => x.Mobile).HasMaxLength(20);
            builder.Property(x => x.Phone).HasMaxLength(20);
            builder.Property(x => x.Fax).HasMaxLength(20);
            builder.Property(x => x.Email).HasMaxLength(50);
            builder.Property(x => x.City).HasMaxLength(50);
            builder.Property(x => x.Country).HasMaxLength(50);

            builder.HasMany(x => x.Products).WithOne(x => x.Supplier).HasForeignKey(x => x.SupplierID).IsRequired();

            //Seed
            builder.HasData
            (
            #region Steam Games
                new Supplier
                {
                    //Rimworld
                    CompanyName = "Ludeon Studios",
                    ContactName = "Tynan Sylvester",
                    ContactTitle = "Founder"
                },
                new Supplier
                {
                    //Bannerlord
                    CompanyName = "TaleWorlds",
                    ContactName = "Armağan Yavuz",
                    ContactTitle = "Founder"
                },
                new Supplier
                {
                    //GTA V
                    CompanyName = "Rockstar Games",
                    ContactName = "Terry Donovan",
                    ContactTitle = "Founder"
                },
                new Supplier
                {
                    //Crusader Kings 2, Europe Universalis 4, Hearts Of Iron 4
                    CompanyName = "Paradox Interactive",
                    ContactName = "Henrik Fâhraeus",
                    ContactTitle = "Director"
                },
                new Supplier
                {
                    //Fallout,Skyrim
                    CompanyName = "Bethesda Softworks",
                    ContactName = "Christopher Weaver",
                    ContactTitle = "Founder"
                },
                new Supplier
                {
                    //CSGO, Half-Life
                    CompanyName = "Valve",
                    ContactName = "Gabe Newell",
                    ContactTitle = "Founder"
                },
                #endregion
            #region Origin Games
                new Supplier
                {
                    //The Sims 4,Battlefield,Fifa, A Way Out, Dead Space 3,Command & Conquer: Red Alert 3
                    CompanyName = "Electronic Arts",
                    ContactName = "Trip Hawkins",
                    ContactTitle = "Founder"
                },
                new Supplier
                {
                    //Mass Effect, Dragon Age 2 Origins
                    CompanyName = "Bioware",
                    ContactName = "Ray Muzyka",
                    ContactTitle = "Founder"
                },
                new Supplier
                {
                    //Doom
                    CompanyName = "id Software LLC",
                    ContactName = "Adrian Carmack",
                    ContactTitle = "Founder"
                },
                new Supplier
                {
                    //Crysis 3
                    CompanyName = "Crytek",
                    ContactName = "Cevat Yerli",
                    ContactTitle = "Founder"
                }


                #endregion
            );
        }
    }
}
