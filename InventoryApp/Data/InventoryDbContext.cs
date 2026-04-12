using InventoryApp.Models;
using Microsoft.EntityFrameworkCore;

namespace InventoryApp.Data;

public class InventoryDbContext : DbContext
{
    //I
    // DbSet = representasi tabel di database
    // Nama property (Products, Categories, Transactions)
    // akan menjadi nama tabel di SQL Server
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Transaction> Transactions { get; set; }

    //II
    // Constructor: dipakai saat aplikasi berjalan normal
    // DbContextOptions berisi connection string dari appsettings.json
    public InventoryDbContext(DbContextOptions<InventoryDbContext> options) : base(options) { }


    // III
    // Constructor kosong: dipakai HANYA saat migration dijalankan di terminal (design-time). Biarkan isinya kosong.
    public InventoryDbContext() { }

    // IV
    // OnConfiguring: dipakai saat migration di terminal Karena terminal tidak membaca appsettings.json,
    // connection string ditulis langsung di sini
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        {
            optionsBuilder.UseSqlServer(
                "Server=localhost;Database=InventoryDB;" +
                "Trusted_Connection=True;" +
                "TrustServerCertificate=True;");
        }

    }

    // V   
    // OnModelCreating: tempat aturan-aturan tambahan yang tidak bisa diekspresikan lewat Data Annotations
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //A. SKU harus unik — tidak boleh ada 2 produk dengan SKU sama
        modelBuilder.Entity<Product>()
            .HasIndex(p => p.SKU)
            .IsUnique();
        
        //B. Nama kategori harus unik 
        modelBuilder.Entity<Category>()
            .HasIndex(c => c.Name)
            .IsUnique();

        //C. Relasi Product-Category: satu Category bisa punya banyak Product, tapi satu Product hanya boleh punya satu Category
        modelBuilder.Entity<Product>()
            .HasOne(p => p.Category)
            .WithMany(c => c.Products)
            .HasForeignKey(p => p.CategoryId)
            .OnDelete(DeleteBehavior.Restrict);

        //D. Relasi Transaction-Product: satu Product bisa punya banyak Transaction, tapi satu Transaction hanya boleh punya satu Product
        modelBuilder.Entity<Transaction>()
            .HasOne(t => t.Product)
            .WithMany(p => p.Transactions)
            .HasForeignKey(t => t.ProductId)
            .OnDelete(DeleteBehavior.Restrict);

        //E. data seeding: isi tabel Category dengan data awal (misalnya kategori-kategori umum)
        modelBuilder.Entity<Category>().HasData(
            new Category
            {
                Id = 1,
                Name = "Elektronik",
                Description = "Produk elektronik"
            },
            new Category
            {
                Id = 2,
                Name = "Peralatan",
                Description = "Peralatan kantor dan rumah"
            }
        );


    }

}