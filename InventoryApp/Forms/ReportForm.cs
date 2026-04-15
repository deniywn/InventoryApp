using InventoryApp.Controllers;

namespace InventoryApp.Forms;

public partial class ReportForm : Form
{
    private readonly ProductController _productController;
    private readonly CategoryController _categoryController;
    private readonly TransactionController _transactionController;

    public ReportForm(
        ProductController productController,
        CategoryController categoryController,
        TransactionController transactionController)
    {
        InitializeComponent();
        _productController = productController;
        _categoryController = categoryController;
        _transactionController = transactionController;
    }

    private void ReportForm_Load(object sender, EventArgs e)
    {
        SetupGridLowStock();
        MuatLowStock();
        MuatRingkasan();
    }

    private void SetupGridLowStock()
    {
        dgvLowStock.AutoGenerateColumns = false;
        dgvLowStock.Columns.Clear();

        dgvLowStock.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "colSKU",
            HeaderText = "SKU",
            DataPropertyName = "SKU",
            Width = 110
        });
        dgvLowStock.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "colNama",
            HeaderText = "Nama Produk",
            DataPropertyName = "Nama",
            AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        });
        dgvLowStock.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "colKategori",
            HeaderText = "Kategori",
            DataPropertyName = "Kategori",
            Width = 130
        });
        dgvLowStock.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "colStok",
            HeaderText = "Stok Saat Ini",
            DataPropertyName = "Stok",
            Width = 110,
            DefaultCellStyle = new DataGridViewCellStyle
            {
                Alignment = DataGridViewContentAlignment.MiddleCenter,
                ForeColor = Color.Red,
                Font = new Font("Segoe UI", 9, FontStyle.Bold)
            }
        });
        dgvLowStock.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "colMinStok",
            HeaderText = "Min Stok",
            DataPropertyName = "MinStok",
            Width = 90,
            DefaultCellStyle = new DataGridViewCellStyle
            {
                Alignment = DataGridViewContentAlignment.MiddleCenter
            }
        });
        dgvLowStock.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "colKurang",
            HeaderText = "Kekurangan",
            DataPropertyName = "Kekurangan",
            Width = 100,
            DefaultCellStyle = new DataGridViewCellStyle
            {
                Alignment = DataGridViewContentAlignment.MiddleCenter,
                ForeColor = Color.DarkRed,
                Font = new Font("Segoe UI", 9, FontStyle.Bold)
            }
        });
    }

    private void MuatLowStock()
    {
        var produkLowStock = _productController.GetLowStock();

        var tampil = produkLowStock.Select(p => new
        {
            p.SKU,
            Nama = p.Name,
            Kategori = p.Category?.Name ?? "-",
            Stok = p.Stock,
            MinStok = p.MinStock,
            Kekurangan = p.MinStock - p.Stock
        }).ToList();

        dgvLowStock.DataSource = tampil;

        for (int i = 0; i < tampil.Count; i++)
            dgvLowStock.Rows[i].DefaultCellStyle.BackColor = Color.MistyRose;

        lblStatus.Text = $"{tampil.Count} produk membutuhkan restock.";
    }

    private void MuatRingkasan()
    {
        var totalProduk = _productController.GetAll().Count();
        var totalKategori = _categoryController.GetAll().Count();
        var totalTransaksi = _transactionController.GetAll().Count();
        var totalLowStock = _productController.GetLowStock().Count();

        lblTotalProduk.Text = $"Total Produk     : {totalProduk} produk";
        lblTotalKategori.Text = $"Total Kategori   : {totalKategori} kategori";
        lblTotalTransaksi.Text = $"Total Transaksi  : {totalTransaksi} transaksi";
        lblTotalLowStock.Text = $"Perlu Restock    : {totalLowStock} produk";

        lblTotalLowStock.ForeColor = totalLowStock > 0
            ? Color.Red : Color.Green;
    }
}