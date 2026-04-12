using InventoryApp.Models;

namespace InventoryApp.Repositories.Interfaces;

public interface ITransactionRepository
{
    IEnumerable<Transaction> GetAll();
    IEnumerable<Transaction> GetByProductId(int productId);
    void Add(Transaction transaction);
    // Tidak ada Update/Delete — transaksi bersifat permanen
}