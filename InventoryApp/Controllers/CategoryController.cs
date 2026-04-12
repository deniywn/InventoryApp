using InventoryApp.Models;
using InventoryApp.Repositories.Interfaces;

namespace InventoryApp.Controllers;

public class CategoryController
{
    private readonly ICategoryRepository _repo;

    public CategoryController(ICategoryRepository repo)
    {
        _repo = repo;
    }

    public IEnumerable<Category> GetAll()
        => _repo.GetAll();

    public Category? GetById(int id)
        => _repo.GetById(id);

    public (bool Success, string Message) Create(Category category)
    {
        if (string.IsNullOrWhiteSpace(category.Name))
            return (false, "Nama kategori wajib diisi.");

        if (_repo.IsNameExists(category.Name))
            return (false, $"Kategori '{category.Name}' sudah ada.");

        try
        {
            _repo.Add(category);
            return (true, $"Kategori '{category.Name}' berhasil ditambahkan.");
        }
        catch (Exception ex)
        {
            return (false, $"Gagal menyimpan: {ex.Message}");
        }
    }

    public (bool Success, string Message) Update(Category category)
    {
        if (string.IsNullOrWhiteSpace(category.Name))
            return (false, "Nama kategori wajib diisi.");

        if (_repo.IsNameExists(category.Name, category.Id))
            return (false, $"Kategori '{category.Name}' sudah ada.");

        try
        {
            _repo.Update(category);
            return (true, $"Kategori '{category.Name}' berhasil diperbarui.");
        }
        catch (Exception ex)
        {
            return (false, $"Gagal memperbarui: {ex.Message}");
        }
    }

    public (bool Success, string Message) Delete(int id)
    {
        var category = _repo.GetById(id);
        if (category == null)
            return (false, "Kategori tidak ditemukan.");

        try
        {
            _repo.Delete(id);
            return (true, $"Kategori '{category.Name}' berhasil dihapus.");
        }
        catch (Exception ex)
        {
            // Terjadi kalau masih ada produk di kategori ini (Restrict)
            return (false,
                $"Kategori tidak bisa dihapus karena masih memiliki produk. " +
                $"Pindahkan produk terlebih dahulu.");
        }
    }
}