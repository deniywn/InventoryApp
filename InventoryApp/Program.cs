using InventoryApp.Controllers;
using InventoryApp.Data;
using InventoryApp.Forms;
using InventoryApp.Models;
using InventoryApp.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace InventoryApp;

static class Program
{
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();

        // ── 1. Baca connection string dari appsettings.json ──
        var config = new ConfigurationBuilder()
            .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
            .AddJsonFile("appsettings.json", optional: false)
            .Build();

        var connectionString =
            config.GetConnectionString("DefaultConnection")!;

        // ── 2. Buat DbContext ────────────────────────────────
        var options = new DbContextOptionsBuilder<InventoryDbContext>()
            .UseSqlServer(connectionString)
            .Options;

        var context = new InventoryDbContext(options);

        // ── 3. Jalankan migration otomatis ───────────────────
        // Database dibuat/diperbarui otomatis setiap kali app dijalankan
        context.Database.Migrate();

        // ── 4. Buat semua Repository ─────────────────────────
        var productRepo = new ProductRepository(context);
        var categoryRepo = new CategoryRepository(context);
        var transactionRepo = new TransactionRepository(context);

        // ── 5. Buat semua Controller ─────────────────────────
        var productCtrl = new ProductController(productRepo, categoryRepo);
        var categoryCtrl = new CategoryController(categoryRepo);
        var transactionCtrl = new TransactionController(transactionRepo, productRepo);

        // ── 6. Buat MainForm dan inject Controller ───────────
        var mainForm = new MainForm(productCtrl, categoryCtrl, transactionCtrl);

        // ── 7. Jalankan aplikasi ─────────────────────────────
        Application.Run(mainForm);

        // Tutup DbContext saat aplikasi ditutup
        context.Dispose();
    }
}