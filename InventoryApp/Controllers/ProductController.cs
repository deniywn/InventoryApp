using InventoryApp.Models;
using InventoryApp.Repositories.Interfaces;

namespace InventoryApp.Controllers;

public class ProductController
{
    // Controller bicara lewat Interface, bukan implementasi langsung
    // Ini yang memungkinkan ganti Repository tanpa ubah Controller
    private readonly IProductRepository _productRepo;
    private readonly ICategoryRepository _categoryRepo;

    public ProductController(IProductRepository productRepo,ICategoryRepository categoryRepo)
    {
        _productRepo = productRepo;
        _categoryRepo = categoryRepo;
    }

    // ── READ ────────────────────────────────────────────────────

    public IEnumerable<Product> GetAll() => _productRepo.GetAll();

    public Product? GetById(int id) => _productRepo.GetById(id);

    public IEnumerable<Product> Search(string keyword) => _productRepo.Search(keyword);

    public IEnumerable<Product> GetLowStock() => _productRepo.GetLowStock();

    // Dipakai Form untuk mengisi dropdown pilihan kategori
    public IEnumerable<Category> GetAllCategories() => _categoryRepo.GetAll();

    // ── CREATE ──────────────────────────────────────────────────

    // Mengembalikan (bool, string) — berhasil atau tidak + pesannya
    public (bool Success, string Message) Create(Product product)
    {
        // Validasi 1: nama wajib diisi
        if (string.IsNullOrWhiteSpace(product.Name))
            return (false, "Nama produk wajib diisi.");

        // Validasi 2: SKU wajib diisi
        if (string.IsNullOrWhiteSpace(product.SKU))
            return (false, "SKU wajib diisi.");

        // Validasi 3: SKU tidak boleh duplikat
        if (_productRepo.IsSKUExists(product.SKU))
            return (false, $"SKU '{product.SKU}' sudah digunakan produk lain.");

        // Validasi 4: harga tidak boleh negatif
        if (product.Price < 0)
            return (false, "Harga tidak boleh negatif.");

        // Validasi 5: stok tidak boleh negatif
        if (product.Stock < 0)
            return (false, "Stok tidak boleh negatif.");

        // Validasi 6: kategori wajib dipilih
        if (product.CategoryId <= 0)
            return (false, "Kategori wajib dipilih.");

        try
        {
            _productRepo.Add(product);
            return (true, $"Produk '{product.Name}' berhasil ditambahkan.");
        }
        catch (Exception ex)
        {
            return (false, $"Gagal menyimpan: {ex.Message}");
        }
    }

    // ── UPDATE ──────────────────────────────────────────────────

    public (bool Success, string Message) Update(Product product)
    {
        if (string.IsNullOrWhiteSpace(product.Name))
            return (false, "Nama produk wajib diisi.");

        if (string.IsNullOrWhiteSpace(product.SKU))
            return (false, "SKU wajib diisi.");

        // excludeId: abaikan produk ini sendiri saat cek duplikat SKU
        if (_productRepo.IsSKUExists(product.SKU, product.Id))
            return (false, $"SKU '{product.SKU}' sudah digunakan produk lain.");

        if (product.Price < 0)
            return (false, "Harga tidak boleh negatif.");

        if (product.CategoryId <= 0)
            return (false, "Kategori wajib dipilih.");

        try
        {
            _productRepo.Update(product);
            return (true, $"Produk '{product.Name}' berhasil diperbarui.");
        }
        catch (Exception ex)
        {
            return (false, $"Gagal memperbarui: {ex.Message}");
        }
    }

    // ── DELETE ──────────────────────────────────────────────────
    public (bool Success, string Message) Delete(int id)
    {
        // Cek dulu apakah produk ada
        var product = _productRepo.GetById(id);
        if (product == null)
            return (false, "Produk tidak ditemukan.");

        try
        {
            _productRepo.Delete(id);
            return (true, $"Produk '{product.Name}' berhasil dihapus.");
        }
        catch (Exception ex)
        {
            // Contoh: produk tidak bisa dihapus karena masih ada transaksi
            return (false, $"Gagal menghapus: {ex.Message}");
        }
    }



}