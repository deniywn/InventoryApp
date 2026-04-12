using System.ComponentModel.DataAnnotations;

namespace InventoryApp.Models;

public class Category
{
    //1 Primary key — EF Core otomatis tahu "Id" = primary key
    public int Id { get; set; }

    //2 [Required]    = tidak boleh null/kosong | // [MaxLength]   = batas panjang karakter
    [Required]
    [MaxLength(100)]
    public string Name { get; set; } = string.Empty;
    [MaxLength(500)]
    public string? Description { get; set; }

    //3 Navigation property: satu Category punya banyak Product | ICollection<T> = tipe koleksi generik 
    public ICollection<Product> Products { get; set; } = new List<Product>();
}
