using InventoryApp.Controllers;
using InventoryApp.Models;

namespace InventoryApp.Forms;

public partial class TransactionForm : Form
{
    private readonly TransactionController _controller;

    public TransactionForm(TransactionController controller)
    {
        InitializeComponent();
        _controller = controller;
    }

    private void TransactionForm_Load(object sender, EventArgs e)
    {
        SetupGrid();
        IsiFilterProduk();
        MuatData();
    }

    private void SetupGrid()
    {
        dgvTransactions.AutoGenerateColumns = false;
        dgvTransactions.Columns.Clear();
        dgvTransactions.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "colId",
            HeaderText = "ID",
            DataPropertyName = "Id",
            Width = 50
        });
        dgvTransactions.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "colTanggal",
            HeaderText = "Tanggal",
            DataPropertyName = "Tanggal",
            Width = 140
        });
        dgvTransactions.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "colProduk",
            HeaderText = "Produk",
            DataPropertyName = "Produk",
            AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        });
        dgvTransactions.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "colTipe",
            HeaderText = "Tipe",
            DataPropertyName = "Tipe",
            Width = 100
        });
        dgvTransactions.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "colJumlah",
            HeaderText = "Jumlah",
            DataPropertyName = "Jumlah",
            Width = 80,
            DefaultCellStyle = new DataGridViewCellStyle
            { Alignment = DataGridViewContentAlignment.MiddleRight }
        });
        dgvTransactions.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "colHarga",
            HeaderText = "Harga Satuan",
            DataPropertyName = "Harga",
            Width = 120,
            DefaultCellStyle = new DataGridViewCellStyle
            {
                Format = "N0",
                Alignment = DataGridViewContentAlignment.MiddleRight
            }
        });
        dgvTransactions.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "colCatatan",
            HeaderText = "Catatan",
            DataPropertyName = "Catatan",
            Width = 180
        });
    }

    private void IsiFilterProduk()
    {
        var produkList = _controller.GetAllProducts().ToList();

        // Buat semua item dalam tipe anonymous yang SAMA
        // termasuk item "Semua Produk" di posisi pertama
        var items = produkList
            .Select(p => new { Id = p.Id, Name = p.Name })
            .ToList<object>();

        // Sisipkan item "Semua Produk" di posisi pertama
        items.Insert(0, new { Id = 0, Name = "-- Semua Produk --" });

        cboFilterProduk.ComboBox.DataSource = null;
        cboFilterProduk.ComboBox.DataSource = items;
        cboFilterProduk.ComboBox.DisplayMember = "Name";
        cboFilterProduk.ComboBox.ValueMember = "Id";
        cboFilterProduk.ComboBox.SelectedIndex = 0;
    }

    private void MuatData(int productId = 0)
    {
        var data = productId > 0
            ? _controller.GetByProductId(productId)
            : _controller.GetAll();

        var tampil = data.Select(t => new
        {
            t.Id,
            Tanggal = t.TransactionDate.ToString("dd/MM/yyyy HH:mm"),
            Produk = t.Product?.Name ?? "-",
            Tipe = t.Type.ToString(),
            Jumlah = t.Quantity,
            Harga = t.UnitPrice,
            Catatan = t.Notes ?? ""
        }).ToList();

        dgvTransactions.DataSource = tampil;
        lblStatus.Text = $"{tampil.Count} transaksi ditemukan.";

        // Warna baris berdasarkan tipe transaksi
        for (int i = 0; i < tampil.Count; i++)
        {
            dgvTransactions.Rows[i].DefaultCellStyle.BackColor =
                tampil[i].Tipe switch
                {
                    "IN" => Color.Honeydew,
                    "OUT" => Color.MistyRose,
                    "ADJUSTMENT" => Color.LightYellow,
                    _ => Color.White
                };
        }
    }

    private void btnTambah_Click(object sender, EventArgs e)
    {
        using var form = new TransactionDetailForm(_controller);
        if (form.ShowDialog() == DialogResult.OK)
        {
            // PERBAIKAN: akses lewat .ComboBox
            var selectedId = cboFilterProduk.ComboBox.SelectedValue is int id
                && id > 0 ? id : 0;
            MuatData(selectedId);
            lblStatus.Text = "Transaksi berhasil disimpan.";
        }
    }

    private void btnSemuaProduk_Click(object sender, EventArgs e)
    {
        cboFilterProduk.ComboBox.SelectedIndex = 0;
        MuatData();
    }

    private void cboFilterProduk_SelectedIndexChanged(
        object sender, EventArgs e)
    {
        // PERBAIKAN: akses lewat .ComboBox
        if (cboFilterProduk.ComboBox.SelectedValue is int id)
            MuatData(id > 0 ? id : 0);
    }
}