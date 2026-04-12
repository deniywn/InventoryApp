using InventoryApp.Controllers;
using InventoryApp.Data;
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

        var config = new ConfigurationBuilder()
            .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
            .AddJsonFile("appsettings.json", optional: false)
            .Build();

        var options = new DbContextOptionsBuilder<InventoryDbContext>()
            .UseSqlServer(config.GetConnectionString("DefaultConnection"))
            .Options;

        using var context = new InventoryDbContext(options);

        var productRepo = new ProductRepository(context);
        var categoryRepo = new CategoryRepository(context);
        var controller = new ProductController(productRepo, categoryRepo);

        // ── TEST 1: tambah produk valid ──────────────────────
        var produkBaru = new Product
        {
            Name = "Laptop Test",
            SKU = "LPT-001",
            Price = 8500000,
            Stock = 10,
            MinStock = 2,
            CategoryId = 1   // kategori Elektronik dari seed data
        };

        var hasil1 = controller.Create(produkBaru);
        MessageBox.Show(
            $"Test 1 — Tambah produk valid:\n\n" +
            $"Berhasil : {hasil1.Success}\n" +
            $"Pesan    : {hasil1.Message}",
            "Verifikasi Controller",
            MessageBoxButtons.OK,
            hasil1.Success ? MessageBoxIcon.Information : MessageBoxIcon.Error);

        // ── TEST 2: tambah produk dengan nama kosong ─────────
        var produkKosong = new Product
        {
            Name = "",   // sengaja kosong — harus ditolak
            SKU = "XXX",
            Price = 100,
            CategoryId = 1
        };

        var hasil2 = controller.Create(produkKosong);
        MessageBox.Show(
            $"Test 2 — Nama produk kosong (harus ditolak):\n\n" +
            $"Berhasil : {hasil2.Success}\n" +
            $"Pesan    : {hasil2.Message}",
            "Verifikasi Controller",
            MessageBoxButtons.OK,
            hasil2.Success ? MessageBoxIcon.Information : MessageBoxIcon.Error);
    }
}