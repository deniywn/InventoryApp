using InventoryApp.Data;
using InventoryApp.Models;
using InventoryApp.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace InventoryApp.Repositories;

public class ProductRepository : IProductRepository
{
    private readonly InventoryDbContext _context;

    public ProductRepository(InventoryDbContext context)
    {
        _context = context;
    }

    public IEnumerable<Product> GetAll()
    {
        return _context.Products
            .Include(p => p.Category)
            .OrderBy(p => p.Name)
            .ToList();
    }

    public Product? GetById(int id)
    {
        return _context.Products
            .Include(p => p.Category)
            .FirstOrDefault(p => p.Id == id);
    }

    public void Add(Product product)
    {
        product.CreatedAt = DateTime.Now;
        product.UpdatedAt = DateTime.Now;
        _context.Products.Add(product);
        _context.SaveChanges();
    }

    public void Update(Product product)
    {
        product.UpdatedAt = DateTime.Now;
        _context.Products.Update(product);
        _context.SaveChanges();
    }

    public void Delete(int id)
    {
        var product = _context.Products.Find(id);
        if (product == null)
            throw new InvalidOperationException(
                $"Produk Id {id} tidak ditemukan.");
        _context.Products.Remove(product);
        _context.SaveChanges();
    }

    public IEnumerable<Product> Search(string keyword)
    {
        return _context.Products
            .Include(p => p.Category)
            .Where(p => p.Name.Contains(keyword)
                     || p.SKU.Contains(keyword))
            .OrderBy(p => p.Name)
            .ToList();
    }

    public IEnumerable<Product> GetLowStock()
    {
        return _context.Products
            .Include(p => p.Category)
            .Where(p => p.Stock <= p.MinStock)
            .OrderBy(p => p.Stock)
            .ToList();
    }

    public bool IsSKUExists(string sku, int excludeId = 0)
    {
        return _context.Products
            .Any(p => p.SKU == sku && p.Id != excludeId);
    }
}