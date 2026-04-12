using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryApp.Models;

public class Product
{
    public int Id { get; set; }

    [Required]
    [MaxLength(150)]
    public string Name { get; set; } = string.Empty;

    // SKU = Stock Keeping Unit: kode unik tiap produk
    [Required]
    [MaxLength(50)]
    public string SKU { get; set; } = string.Empty;

    [MaxLength(500)]
    public string? Description { get; set; }
    // decimal(18,2) = angka dengan 18 digit total, 2 di belakang koma
    // Ini tipe standar untuk menyimpan uang/harga di database
    [Column(TypeName = "decimal(18,2)")]
    public decimal Price { get; set; }

    // Jumlah stok saat ini
    public int Stock { get; set; }

    // Batas minimum stok — kalau Stock <= MinStock, produk dianggap "low stock"
    public int MinStock { get; set; } = 5;

    // Foreign Key: menunjuk ke Id di tabel Categories
    public int CategoryId { get; set; }

    // Waktu dibuat dan terakhir diubah — berguna untuk audit
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;

    // Navigation properties
    // Category? = nullable: mungkin belum di-load oleh EF Core
    public Category? Category { get; set; }

    // Satu produk bisa punya banyak transaksi
    public ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();
}