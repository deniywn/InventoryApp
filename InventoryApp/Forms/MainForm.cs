using InventoryApp.Controllers;

namespace InventoryApp.Forms;

public partial class MainForm : Form
{
    //1. first
    //1.1 Controller disimpan sebagai field agar bisa dipakai oleh semua event handler di form ini
    private readonly ProductController _productController;
    private readonly CategoryController _categoryController;
    private readonly TransactionController _transactionController;

    //1.2 Constructor: menerima semua controller dari Program.cs
    public MainForm( ProductController productController,CategoryController categoryController,TransactionController transactionController)
    {
        InitializeComponent(); // wajib ada — inisialisasi komponen Designer

        _productController = productController;
        _categoryController = categoryController;
        _transactionController = transactionController;
    }

    //1.3 Event: form pertama kali dibuka
    private void MainForm_Load(object sender, EventArgs e)
    {
        SetStatus("Selamat datang di Inventory Management System.");
    }

    //2── Event handler menu ──────────────────────────────────────

    //2.1 Klik menu "Products
    private void productsToolStripMenuItem_Click(object sender, EventArgs e)
    {
        SetStatus("Halaman Products");

        // Buka ProductForm dan inject controller yang sudah ada
        var form = new ProductForm(_productController);
        form.MdiParent = null;  // buka sebagai jendela terpisah
        form.ShowDialog(this);  // "this" = MainForm sebagai parent

        SetStatus("Siap.");
    }

    //2.2 Klik menu "Categories"
    private void categoriesToolStripMenuItem_Click(object sender, EventArgs e)
    {
        SetStatus("Halaman Categories");
        var form = new CategoryForm(_categoryController);
        form.ShowDialog(this);
        SetStatus("Siap.");
    }
    //2.3 Klik menu "Transactions"
    private void transactionsToolStripMenuItem_Click(object sender, EventArgs e)
    {
        SetStatus("Halaman Transactions");
        var form = new TransactionForm(_transactionController);
        form.ShowDialog(this);
        SetStatus("Siap.");
    }

    //3── Helper method ───────────────────────────────────────────

    //Menampilkan pesan di status bar bawah
    public void SetStatus(string message)
    {
        lblStatus.Text = message;
    }
}