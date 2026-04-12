using InventoryApp.Data;
using InventoryApp.Models;
using InventoryApp.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace InventoryApp.Repositories;

public class TransactionRepository : ITransactionRepository
{
    private readonly InventoryDbContext _context;

    public TransactionRepository(InventoryDbContext context)
    {
        _context = context;
    }

    public IEnumerable<Transaction> GetAll()
    {
        return _context.Transactions
            .Include(t => t.Product)
            .OrderByDescending(t => t.TransactionDate)
            .ToList();
    }

    public IEnumerable<Transaction> GetByProductId(int productId)
    {
        return _context.Transactions
            .Include(t => t.Product)
            .Where(t => t.ProductId == productId)
            .OrderByDescending(t => t.TransactionDate)
            .ToList();
    }

    public void Add(Transaction transaction)
    {
        var product = _context.Products.Find(transaction.ProductId)
            ?? throw new InvalidOperationException("Produk tidak ditemukan.");

        // Update stok sesuai tipe transaksi
        product.Stock = transaction.Type switch
        {
            TransactionType.IN => product.Stock + transaction.Quantity,
            TransactionType.OUT => product.Stock - transaction.Quantity,
            TransactionType.ADJUSTMENT => transaction.Quantity,
            _ => product.Stock
        };

        if (product.Stock < 0)
            throw new InvalidOperationException(
                $"Stok tidak mencukupi. Stok tersedia: {product.Stock + transaction.Quantity}");

        product.UpdatedAt = DateTime.Now;
        _context.Transactions.Add(transaction);
        _context.SaveChanges(); // simpan transaksi + update stok sekaligus
    }
}