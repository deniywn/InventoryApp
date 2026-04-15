using InventoryApp.Controllers;
using InventoryApp.Models;

namespace InventoryApp.Forms;

public partial class CategoryDetailForm : Form
{
    private readonly CategoryController _controller;
    private readonly Category? _kategoriEdit;
    private readonly bool _modeEdit;

    public CategoryDetailForm(CategoryController controller,
        Category? kategori)
    {
        InitializeComponent();
        _controller = controller;
        _kategoriEdit = kategori;
        _modeEdit = kategori != null;
        Text = _modeEdit ? "Edit Kategori" : "Tambah Kategori";
    }

    private void CategoryDetailForm_Load(object sender, EventArgs e)
    {
        if (_modeEdit && _kategoriEdit != null)
        {
            txtNama.Text = _kategoriEdit.Name;
            txtDeskripsi.Text = _kategoriEdit.Description ?? "";
        }
    }

    private void btnSimpan_Click(object sender, EventArgs e)
    {
        DialogResult = DialogResult.None;
        if (!ValidasiInput()) return;

        var kategori = new Category
        {
            Id = _modeEdit ? _kategoriEdit!.Id : 0,
            Name = txtNama.Text.Trim(),
            Description = txtDeskripsi.Text.Trim()
        };

        var (berhasil, pesan) = _modeEdit
            ? _controller.Update(kategori)
            : _controller.Create(kategori);

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

    private bool ValidasiInput()
    {
        errorProvider1.Clear();
        bool valid = true;

        if (string.IsNullOrWhiteSpace(txtNama.Text))
        {
            errorProvider1.SetError(txtNama,
                "Nama kategori wajib diisi.");
            valid = false;
        }
        return valid;
    }
}