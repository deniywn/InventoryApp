using InventoryApp.Data;
using InventoryApp.Repositories;
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
            ApplicationConfiguration.Initialize();
            MessageBox.Show("Tahap 4 selesai. Siap lanjut ke Tahap 5.",
                "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}