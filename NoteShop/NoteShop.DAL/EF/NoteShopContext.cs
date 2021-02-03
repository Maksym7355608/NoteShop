using Microsoft.EntityFrameworkCore;
using NoteShop.Models;

namespace NoteShop.DAL.EF
{
    public class NoteShopContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Notebook> Notebooks { get; set; }
        public DbSet<Diary> Diaries { get; set; }
        public DbSet<Pen> Pens { get; set; }
        public DbSet<Pencil> Pencils { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Likes> Likes { get; set; }
        public DbSet<Cart> Carts { get; set; }

        static NoteShopContext() { }

        public NoteShopContext(DbContextOptions options) : base(options)
        {
            Database.EnsureCreated();

            DbContextOptionsBuilder dbContextOptions = new DbContextOptionsBuilder(options);
            dbContextOptions.EnableSensitiveDataLogging();
        }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>().ToTable("Products");

            modelBuilder.Entity<Notebook>().ToTable("Notebooks");

            modelBuilder.Entity<Diary>().ToTable("Diaries");

            modelBuilder.Entity<Pen>().ToTable("Pens");

            modelBuilder.Entity<Pencil>().ToTable("Pencils");


            modelBuilder.Entity<Product>().HasData(new Product[]
            {
                new Product() { Id = 16, Name = "Notebook Poligraphist 12", Price = 1, Count = 100, Type = ProductType.Notebook },
                new Product() { Id = 1, Name = "Notebook Poligraphist 18", Price = 1.25f, Count = 190, Type = ProductType.Notebook },
                new Product() { Id = 2, Name = "Notebook Poligraphist 24", Price = 3.5f, Count = 220, Type = ProductType.Notebook },
                new Product() { Id = 3, Name = "Notebook Poligraphist 12", Price = 1.2f, Count = 310, Type = ProductType.Notebook },
                new Product() { Id = 4, Name = "Notebook 1st September 48", Price = 15, Count = 70, Type = ProductType.Notebook },
                new Product() { Id = 5, Name = "Notebook 1st September 18", Price = 2.25f, Count = 80, Type = ProductType.Notebook },
                new Product() { Id = 6, Name = "Notebook 1st September 12", Price = 1.2f, Count = 150, Type = ProductType.Notebook },
                new Product() { Id = 7, Name = "Diary Ranok", Price = 35, Count = 50, Type = ProductType.Diary },
                new Product() { Id = 8, Name = "Diary Rozumniy", Price = 50, Count = 27, Type = ProductType.Diary },
                new Product() { Id = 9, Name = "Diary Elite", Price = 70, Count = 10, Type = ProductType.Diary },
                new Product() { Id = 10, Name = "Pen Pilot", Price = 1, Count = 100, Type = ProductType.Pen },
                new Product() { Id = 11, Name = "Pen MaxWriter", Price = 4, Count = 70, Type = ProductType.Pen },
                new Product() { Id = 12, Name = "Pen BIG", Price = 5, Count = 40, Type = ProductType.Pen },
                new Product() { Id = 13, Name = "Pen cells 10km", Price = 10, Count = 60, Type = ProductType.Pen },
                new Product() { Id = 14, Name = "Pencil LowMarco", Price = 2, Count = 170, Type = ProductType.Pencil },
                new Product() { Id = 15, Name = "Pencil Marco", Price = 4, Count = 200, Type = ProductType.Pencil }
            });

            //modelBuilder.Entity<Paper>().HasData(new Paper[]
            // {
            //    new Paper() { Id = 10, ProductId = 16, PageCount = 12, Size = Format.A5 },
            //    new Paper() { Id = 1, ProductId = 1, PageCount = 18, Size = Format.A5 },
            //    new Paper() { Id = 2, ProductId = 2, PageCount = 24, Size = Format.A5 },
            //    new Paper() { Id = 3, ProductId = 3, PageCount = 12, Size = Format.A5 },
            //    new Paper() { Id = 4, ProductId = 4, PageCount = 48, Size = Format.A4 },
            //    new Paper() { Id = 5, ProductId = 5, PageCount = 18, Size = Format.A5 },
            //    new Paper() { Id = 6, ProductId = 6, PageCount = 12, Size = Format.A4 },
            //    new Paper() { Id = 7, ProductId = 7, PageCount = 48, Size = Format.A6 },
            //    new Paper() { Id = 8, ProductId = 8, PageCount = 60, Size = Format.A5 },
            //    new Paper() { Id = 9, ProductId = 9, PageCount = 144, Size = Format.A6 },
            // });

            //modelBuilder.Entity<WritingTool>().HasData(new WritingTool[]
            //{
            //    new WritingTool() { Id = 6, ProductId = 10, RodColor = Color.Blue },
            //    new WritingTool() { Id = 1, ProductId = 11, RodColor = Color.Black },
            //    new WritingTool() { Id = 2, ProductId = 12, RodColor = Color.Blue },
            //    new WritingTool() { Id = 3, ProductId = 13, RodColor = Color.Red },
            //    new WritingTool() { Id = 4, ProductId = 14, RodColor = Color.Black },
            //    new WritingTool() { Id = 5, ProductId = 15, RodColor = Color.Black },
            //});

            //modelBuilder.Entity<Notebook>().HasData(new Notebook[]
            //{
            //    new Notebook() { Id = 7, ProductId = 16, NoteType = Markup.Inline, Coloration = "natural" },
            //    new Notebook() { Id = 1, ProductId = 1, NoteType = Markup.Oblique, Coloration = "natural" },
            //    new Notebook() { Id = 2, ProductId = 2, NoteType = Markup.Oblique, Coloration = "kitty" },
            //    new Notebook() { Id = 3, ProductId = 3, NoteType = Markup.Inline, Coloration = "yanny" },
            //    new Notebook() { Id = 4, ProductId = 4, NoteType = Markup.Squared, Coloration = "dogs" },
            //    new Notebook() { Id = 5, ProductId = 5, NoteType = Markup.Squared, Coloration = "cars" },
            //    new Notebook() { Id = 6, ProductId = 6, NoteType = Markup.Squared, Coloration = "cats" },
            //});

            //modelBuilder.Entity<Diary>().HasData(new Diary[]
            //{
            //    new Diary() { Id = 3, ProductId = 7, Cover = Cover.Soft },
            //    new Diary() { Id = 1, ProductId = 8, Cover = Cover.Hard },
            //    new Diary() { Id = 2, ProductId = 9, Cover = Cover.Leather }
            //});

            //modelBuilder.Entity<Pen>().HasData(new Pen[]
            //{
            //    new Pen() { Id = 4, ProductId = 10, Thickness = 0.5f },
            //    new Pen() { Id = 1, ProductId = 11, Thickness = 0.7f },
            //    new Pen() { Id = 2, ProductId = 12, Thickness = 0.5f },
            //    new Pen() { Id = 3, ProductId = 13, Thickness = 0.8f }
            //});

            modelBuilder.Entity<Pencil>().HasData(new Pencil[]
            {
                new Pencil() { ProductId = 14, Roughness = Hardness.H },
                new Pencil() { ProductId = 15, Roughness = Hardness.F }
            });

            //this.SaveChanges();
        }
    }
}
