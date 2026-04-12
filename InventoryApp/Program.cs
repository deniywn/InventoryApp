using InventoryApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace InventoryApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            //I
            // Baca connection string dari appsettings.json
            var config = new ConfigurationBuilder()
                        .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                        .AddJsonFile("appsettings.json", optional: false)
                        .Build();

            var connectionString = config.GetConnectionString("DefaultConnection");

            //II
            // Setup DbContext
            var optionsBuilder = new DbContextOptionsBuilder<InventoryDbContext>();
            optionsBuilder.UseSqlServer(connectionString);

            // III Test koneksi: ambil jumlah kategori dari database
            using var context  = new InventoryDbContext(optionsBuilder.Options);
            var jumlahKategori = context.Categories.Count();

            MessageBox.Show(
                $"Koneksi database berhasil!\n" +
                $"Jumlah kategori di database: {jumlahKategori}",
                "Verifikasi Tahap 3",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
    }
}