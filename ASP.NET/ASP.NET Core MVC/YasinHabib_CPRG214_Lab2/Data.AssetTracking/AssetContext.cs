using Domain.AssetTracking;
using Microsoft.EntityFrameworkCore;
using System;

namespace Data.AssetTracking
{
    public class AssetContext : DbContext
    {
        public AssetContext() : base() { }
        public DbSet<Asset> Assets { get; set; }
        public DbSet<AssetType> AssetTypes { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Connection string
            optionsBuilder.UseSqlServer(@"Server = localhost\SQLEXPRESS;
                                        Database=AssetTracking;
                                        Trusted_Connection=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //seed data created here
            modelBuilder.Entity<AssetType>().HasData(
            new AssetType { Id = 1, Name = "Computer manufacturers" },
            new AssetType { Id = 2, Name = "Monitors" },
            new AssetType { Id = 3, Name = "Phone" }
            );
            modelBuilder.Entity<Asset>().HasData(
            new Asset
            {
                Id = 1,
                TagNumber = "34A8",
                AssetTypeId = 2,
                Manufacturer = "Acer",
                Model = "446DSF68E4F",
                Description = "4gb Ram, 1tb HD, Inten Core i5",
                SerialNumber = "SSN-D68F4EW"
            },
            new Asset
            {
                Id = 2,
                TagNumber = "894W",
                AssetTypeId = 1,
                Manufacturer = "HP",
                Model = "SF5E7F5E",
                Description = "18inch Ultra HD monitor",
                SerialNumber = "SSN-F4D8S6"
            },
            new Asset
            {
                Id = 3,
                TagNumber = "6D6A",
                AssetTypeId = 3,
                Manufacturer = "Cisco",
                Model = "D4S6A84W",
                Description = "Just a phone...",
                SerialNumber = "SSN-SD6EF4"
            });          
        }
    }//End of AssetContext
}//End of namespace
