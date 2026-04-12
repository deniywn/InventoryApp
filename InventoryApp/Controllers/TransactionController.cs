using InventoryApp.Models;
using InventoryApp.Repositories.Interfaces;

namespace InventoryApp.Controllers;

public class TransactionController
{
    private readonly ITransactionRepository _transRepo;
    private readonly IProductRepository _productRepo;

    public TransactionController(
        ITransactionRepository transRepo,
        IProductRepository productRepo)
    {
        _transRepo = transRepo;
        _productRepo = productRepo;
    }

    public IEnumerable<Transaction> GetAll()
        => _transRepo.GetAll();

    public IEnumerable<Transaction> GetByProductId(int productId)
        => _transRepo.GetByProductId(productId);

    // Dipakai Form untuk mengisi dropdown pilihan produk
    public IEnumerable<Product> GetAllProducts()
        => _productRepo.GetAll();

    public (bool Success, string Message) Create(Transaction transaction)
    {
        // Validasi: produk harus dipilih
        if (transaction.ProductId <= 0)
            return (false, "Produk wajib dipilih.");

        // Validasi: jumlah harus lebih dari 0
        if (transaction.Quantity <= 0)
            return (false, "Jumlah transaksi harus lebih dari 0.");

        // Validasi khusus OUT: cek stok mencukupi
        if (transaction.Type == TransactionType.OUT)
        {
            var product = _productRepo.GetById(transaction.ProductId);
            if (product == null)
                return (false, "Produk tidak ditemukan.");

            if (transaction.Quantity > product.Stock)
                return (false,
                    $"Stok tidak mencukupi. " +
                    $"Stok tersedia: {product.Stock}, " +
                    $"diminta: {transaction.Quantity}.");
        }

        try
        {
            _transRepo.Add(transaction);
            return (true, "Transaksi berhasil disimpan.");
        }
        catch (Exception ex)
        {
            return (false, $"Gagal menyimpan transaksi: {ex.Message}");
        }
    }
}