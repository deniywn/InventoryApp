using InventoryApp.Models;

namespace InventoryApp.Repositories.Interfaces;

public interface IProductRepository
{
    IEnumerable<Product> GetAll();
    Product? GetById(int id);
    void Add(Product product);
    void Update(Product product);
    void Delete(int id);
    IEnumerable<Product> Search(string keyword);
    IEnumerable<Product> GetLowStock();
    bool IsSKUExists(string sku, int excludeId = 0);
}