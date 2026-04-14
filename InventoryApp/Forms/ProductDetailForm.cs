using InventoryApp.Controllers;
using InventoryApp.Models;
using System.Windows.Forms;

namespace InventoryApp.Forms;

public partial class ProductDetailForm : Form
{
    private readonly ProductController _controller;
    private readonly Product? _produkEdit;  // null = mode Tambah
    private readonly bool _modeEdit;

    // Constructor: produk = null artinya mode Tambah
    //              produk = data artinya mode Edit
    public ProductDetailForm(ProductController controller, Product? produk)
    {
        InitializeComponent();
        _controller = controller;
        _produkEdit = produk;
        _modeEdit = produk != null;
        Text = _modeEdit ? "Edit Produk" : "Tambah Produk";
    }

    // ── Load ────────────────────────────────────────────────────

    private void ProductDetailForm_Load(object sender, EventArgs e)
    {
        IsiDropdownKategori();

        // Kalau mode Edit, isi semua field dengan data produk
        if (_modeEdit && _produkEdit != null)
        {
            txtNama.Text = _produkEdit.Name;
            txtSKU.Text = _produkEdit.SKU;
            txtDeskripsi.Text = _produkEdit.Description ?? "";
            nudHarga.Value = _produkEdit.Price;
            nudStok.Value = _produkEdit.Stock;
            nudMinStok.Value = _produkEdit.MinStock;

            // Set pilihan ComboBox ke kategori produk ini
            cboKategori.SelectedValue = _produkEdit.CategoryId;
        }
    }

    // ── Isi dropdown kategori ────────────────────────────────────

    private void IsiDropdownKategori()
    {
        var kategori = _controller.GetAllCategories().ToList();
        cboKategori.DataSource = kategori;
        cboKategori.DisplayMember = "Name";   // yang ditampilkan ke user
        cboKategori.ValueMember = "Id";     // nilai yang disimpan
        cboKategori.SelectedIndex = -1;       // tidak ada yang terpilih awal
    }

    // ── Event: klik Simpan ───────────────────────────────────────

    private void btnSimpan_Click(object sender, EventArgs e)
    {
        // Hentikan DialogResult.OK yang otomatis dari tombol
        // sampai validasi lulus
        DialogResult = DialogResult.None;

        if (!ValidasiInput()) return;

        // Buat object Product dari isian form
        var produk = new Product
        {
            Id = _modeEdit ? _produkEdit!.Id : 0,
            Name = txtNama.Text.Trim(),
            SKU = txtSKU.Text.Trim().ToUpper(),
            Description = txtDeskripsi.Text.Trim(),
            Price = nudHarga.Value,
            Stock = (int)nudStok.Value,
            MinStock = (int)nudMinStok.Value,
            CategoryId = (int)(cboKategori.SelectedValue ?? 0)
        };

        // Kirim ke Controller
        var (berhasil, pesan) = _modeEdit
            ? _controller.Update(produk)
            : _controller.Create(produk);

        if (berhasil)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
        else
        {
            MessageBox.Show(pesan, "Validasi Gagal",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }

    // ── Validasi input dengan ErrorProvider ─────────────────────

    private bool ValidasiInput()
    {
        errorProvider1.Clear();   // hapus semua tanda error sebelumnya
        bool valid = true;

        if (string.IsNullOrWhiteSpace(txtNama.Text))
        {
            errorProvider1.SetError(txtNama, "Nama produk wajib diisi.");
            valid = false;
        }

        if (string.IsNullOrWhiteSpace(txtSKU.Text))
        {
            errorProvider1.SetError(txtSKU, "SKU wajib diisi.");
            valid = false;
        }

        if (cboKategori.SelectedIndex < 0)
        {
            errorProvider1.SetError(cboKategori, "Pilih kategori.");
            valid = false;
        }

        if (nudHarga.Value <= 0)
        {
            errorProvider1.SetError(nudHarga, "Harga harus lebih dari 0.");
            valid = false;
        }

        return valid;
    }
}