using InventoryApp.Data;
using InventoryApp.Models;
using InventoryApp.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace InventoryApp.Repositories;

public class CategoryRepository : ICategoryRepository
{
    private readonly InventoryDbContext _context;

    public CategoryRepository(InventoryDbContext context)
    {
        _context = context;
    }

    public IEnumerable<Category> GetAll()
        => _context.Categories.OrderBy(c => c.Name).ToList();

    public Category? GetById(int id)
        => _context.Categories.Find(id);

    public void Add(Category category)
    {
        _context.Categories.Add(category);
        _context.SaveChanges();
    }

    public void Update(Category category)
    {
        var tracked = _context.ChangeTracker.Entries<Category>()
            .FirstOrDefault(e => e.Entity.Id == category.Id);
        if (tracked != null)
            tracked.State = EntityState.Detached;

        _context.Categories.Update(category);
        _context.SaveChanges();
    }

    public void Delete(int id)
    {
        var tracked = _context.ChangeTracker.Entries<Category>()
            .FirstOrDefault(e => e.Entity.Id == id);
        if (tracked != null)
            tracked.State = EntityState.Detached;


        var cat = _context.Categories.Find(id)
            ?? throw new InvalidOperationException("Kategori tidak ditemukan.");
        _context.Categories.Remove(cat);
        _context.SaveChanges();
    }

    public bool IsNameExists(string name, int excludeId = 0)
        => _context.Categories.Any(c => c.Name == name && c.Id != excludeId);
}