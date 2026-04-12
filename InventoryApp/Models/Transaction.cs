using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryApp.Models;

// Enum: tipe data dengan pilihan nilai yang sudah ditentukan
// Lebih aman dari string — compiler akan error kalau salah tulis
public enum TransactionType
{
    IN = 1,          // barang masuk (pembelian/penerimaan)
    OUT = 2,         // barang keluar (penjualan/pengeluaran)
    ADJUSTMENT = 3   // penyesuaian stok manual (misalnya koreksi)
}

public class Transaction
{
    public int Id { get; set; }

    //1. Foreign Key ke tabel Products
    public int ProductId { get; set; }

    //2. Pakai enum — bukan int biasa, bukan string
    public TransactionType Type { get; set; }

    //3.  Jumlah barang yang masuk/keluar (selalu positif)
    public int Quantity { get; set; }

    //4. Harga satuan pada saat transaksi (harga bisa berubah seiring waktu)
    [Column(TypeName = "decimal(18,2)")]
    public decimal UnitPrice { get; set; }
    [MaxLength(500)]
    public string? Notes { get; set; }
    public DateTime TransactionDate { get; set; } = DateTime.Now;

    //5. Navigation property ke Product
    public Product? Product { get; set; }
}
