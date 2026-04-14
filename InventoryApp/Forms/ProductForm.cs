using InventoryApp.Controllers;
using InventoryApp.Models;

namespace InventoryApp.Forms;

public partial class ProductForm : Form
{
    private readonly ProductController _controller;

    public ProductForm(ProductController controller)
    {
        InitializeComponent();
        _controller = controller;
    }

    // ── Load ────────────────────────────────────────────────────

    private void ProductForm_Load(object sender, EventArgs e)
    {
        SetupGrid();
        MuatData();
    }

    // ── Setup kolom DataGridView ─────────────────────────────────

    private void SetupGrid()
    {
        dgvProducts.AutoGenerateColumns = false;
        dgvProducts.Columns.Clear();

        // Tambah kolom satu per satu — kita tentukan sendiri apa yang tampil
        dgvProducts.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "colId",
            HeaderText = "ID",
            DataPropertyName = "Id",
            Width = 50
        });
        dgvProducts.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "colSKU",
            HeaderText = "SKU",
            DataPropertyName = "SKU",
            Width = 110
        });
        dgvProducts.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "colNama",
            HeaderText = "Nama Produk",
            DataPropertyName = "Nama",
            AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        });
        dgvProducts.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "colKategori",
            HeaderText = "Kategori",
            DataPropertyName = "Kategori",
            Width = 130
        });
        dgvProducts.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "colHarga",
            HeaderText = "Harga",
            DataPropertyName = "Harga",
            Width = 120,
            DefaultCellStyle = new DataGridViewCellStyle
            {
                Format = "N0",         // format angka tanpa desimal
                Alignment = DataGridViewContentAlignment.MiddleRight
            }
        });
        dgvProducts.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "colStok",
            HeaderText = "Stok",
            DataPropertyName = "Stok",
            Width = 70,
            DefaultCellStyle = new DataGridViewCellStyle
            {
                Alignment = DataGridViewContentAlignment.MiddleCenter
            }
        });
        dgvProducts.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "colMinStok",
            HeaderText = "Min Stok",
            DataPropertyName = "MinStok",
            Width = 80,
            DefaultCellStyle = new DataGridViewCellStyle
            {
                Alignment = DataGridViewContentAlignment.MiddleCenter
            }
        });
    }

    // ── Muat / refresh data ──────────────────────────────────────

    private void MuatData(string keyword = "")
    {
        var produk = string.IsNullOrEmpty(keyword)
            ? _controller.GetAll()
            : _controller.Search(keyword);

        // Buat anonymous object — hanya kolom yang diperlukan
        // Nama property harus cocok dengan DataPropertyName di SetupGrid()
        var tampil = produk.Select(p => new
        {
            p.Id,
            p.SKU,
            Nama = p.Name,
            Kategori = p.Category?.Name ?? "-",
            Harga = p.Price,
            Stok = p.Stock,
            MinStok = p.MinStock
        }).ToList();

        dgvProducts.DataSource = tampil;
        lblStatus.Text = $"{tampil.Count} produk ditemukan.";

        // Highlight baris yang stoknya rendah dengan warna merah
        // Cara lebih aman — akses nilai dari anonymous object langsung Bukan lewat nama kolom grid
        for (int i = 0; i < tampil.Count; i++)
        {
            if (tampil[i].Stok <= tampil[i].MinStok)
            {
                dgvProducts.Rows[i].DefaultCellStyle.ForeColor = Color.Red;
                dgvProducts.Rows[i].DefaultCellStyle.BackColor = Color.MistyRose;
            }
        }
    }

    // ── Helper: ambil Id produk yang dipilih di grid ─────────────

    private int? AmbilIdTerpilih()
    {
        if (dgvProducts.CurrentRow == null) return null;
        return Convert.ToInt32(dgvProducts.CurrentRow.Cells["colId"].Value);
    }

    // ── Event: tombol Tambah ────────────────────────────────────

    private void btnTambah_Click(object sender, EventArgs e)
    {
        // Buka ProductDetailForm dalam mode Tambah (produk = null)
        using var form = new ProductDetailForm(_controller, null);
        if (form.ShowDialog() == DialogResult.OK)
        {
            MuatData(txtCari.Text);   // refresh data setelah tambah
            lblStatus.Text = "Produk baru berhasil ditambahkan.";
        }
    }

    // ── Event: tombol Edit ──────────────────────────────────────

    private void btnEdit_Click(object sender, EventArgs e)
    {
        var id = AmbilIdTerpilih();
        if (id == null)
        {
            MessageBox.Show("Pilih produk yang ingin diedit.",
                "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        var produk = _controller.GetById(id.Value);
        if (produk == null) return;

        // Buka ProductDetailForm dalam mode Edit (produk terisi)
        using var form = new ProductDetailForm(_controller, produk);
        if (form.ShowDialog() == DialogResult.OK)
        {
            MuatData(txtCari.Text);
            lblStatus.Text = "Produk berhasil diperbarui.";
        }
    }

    // ── Event: tombol Hapus ─────────────────────────────────────

    private void btnHapus_Click(object sender, EventArgs e)
    {
        var id = AmbilIdTerpilih();
        if (id == null)
        {
            MessageBox.Show("Pilih produk yang ingin dihapus.",
                "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        var nama = dgvProducts.CurrentRow!
            .Cells["colNama"].Value?.ToString();

        var konfirmasi = MessageBox.Show(
            $"Hapus produk '{nama}'?\nTindakan ini tidak bisa dibatalkan.",
            "Konfirmasi Hapus",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

        if (konfirmasi != DialogResult.Yes) return;

        var (berhasil, pesan) = _controller.Delete(id.Value);

        MessageBox.Show(pesan, berhasil ? "Berhasil" : "Gagal",
            MessageBoxButtons.OK,
            berhasil ? MessageBoxIcon.Information : MessageBoxIcon.Error);

        if (berhasil) MuatData(txtCari.Text);
    }

    // ── Event: tombol Refresh ───────────────────────────────────

    private void btnRefresh_Click(object sender, EventArgs e)
    {
        txtCari.Text = "";
        MuatData();
        lblStatus.Text = "Data diperbarui.";
    }

    // ── Event: search real-time ──────────────────────────────────

    private void txtCari_TextChanged(object sender, EventArgs e)
    {
        MuatData(txtCari.Text.Trim());
    }
}