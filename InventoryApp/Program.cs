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
            //Application.Run(new Form1());

            // Sementara: tampilkan pesan untuk verifikasi tahap 1
            // Form utama akan ditambahkan di Tahap 6
            MessageBox.Show(
                "Tahap 1 berhasil! Proyek berjalan dengan baik.",
                "Verifikasi",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
    }
}