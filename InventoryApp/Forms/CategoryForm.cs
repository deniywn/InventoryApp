using InventoryApp.Controllers;
using InventoryApp.Models;

namespace InventoryApp.Forms;

public partial class CategoryForm : Form
{
    private readonly CategoryController _controller;

    public CategoryForm(CategoryController controller)
    {
        InitializeComponent();
        _controller = controller;
    }

    private void CategoryForm_Load(object sender, EventArgs e)
    {
        SetupGrid();
        MuatData();
    }

    private void SetupGrid()
    {
        dgvCategories.AutoGenerateColumns = false;
        dgvCategories.Columns.Clear();
        dgvCategories.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "colId",
            HeaderText = "ID",
            DataPropertyName = "Id",
            Width = 50
        });
        dgvCategories.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "colNama",
            HeaderText = "Nama Kategori",
            DataPropertyName = "Nama",
            AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        });
        dgvCategories.Columns.Add(new DataGridViewTextBoxColumn
        {
            Name = "colDeskripsi",
            HeaderText = "Deskripsi",
            DataPropertyName = "Deskripsi",
            Width = 300
        });
    }

    private void MuatData(string keyword = "")
    {
        var data = _controller.GetAll();

        // Filter manual kalau ada keyword
        if (!string.IsNullOrEmpty(keyword))
            data = data.Where(c =>
                c.Name.Contains(keyword,
                    StringComparison.OrdinalIgnoreCase));

        var tampil = data.Select(c => new
        {
            c.Id,
            Nama = c.Name,
            Deskripsi = c.Description ?? "-"
        }).ToList();

        dgvCategories.DataSource = tampil;
        lblStatus.Text = $"{tampil.Count} kategori ditemukan.";
    }

    private int? AmbilIdTerpilih()
    {
        if (dgvCategories.CurrentRow == null) return null;
        return Convert.ToInt32(
            dgvCategories.CurrentRow.Cells["colId"].Value);
    }

    private void btnTambah_Click(object sender, EventArgs e)
    {
        using var form = new CategoryDetailForm(_controller, null);
        if (form.ShowDialog() == DialogResult.OK)
        {
            MuatData(txtCari.Text);
            lblStatus.Text = "Kategori baru berhasil ditambahkan.";
        }
    }

    private void btnEdit_Click(object sender, EventArgs e)
    {
        var id = AmbilIdTerpilih();
        if (id == null)
        {
            MessageBox.Show("Pilih kategori yang ingin diedit.",
                "Perhatian", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            return;
        }
        var kategori = _controller.GetById(id.Value);
        if (kategori == null) return;

        using var form = new CategoryDetailForm(_controller, kategori);
        if (form.ShowDialog() == DialogResult.OK)
        {
            MuatData(txtCari.Text);
            lblStatus.Text = "Kategori berhasil diperbarui.";
        }
    }

    private void btnHapus_Click(object sender, EventArgs e)
    {
        var id = AmbilIdTerpilih();
        if (id == null)
        {
            MessageBox.Show("Pilih kategori yang ingin dihapus.",
                "Perhatian", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            return;
        }

        var nama = dgvCategories.CurrentRow!
            .Cells["colNama"].Value?.ToString();
        var konfirmasi = MessageBox.Show(
            $"Hapus kategori '{nama}'?\n" +
            "Tidak bisa dihapus jika masih ada produk di kategori ini.",
            "Konfirmasi Hapus",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

        if (konfirmasi != DialogResult.Yes) return;

        var (berhasil, pesan) = _controller.Delete(id.Value);
        MessageBox.Show(pesan,
            berhasil ? "Berhasil" : "Gagal",
            MessageBoxButtons.OK,
            berhasil ? MessageBoxIcon.Information : MessageBoxIcon.Error);

        if (berhasil) MuatData(txtCari.Text);
    }

    private void btnRefresh_Click(object sender, EventArgs e)
    {
        txtCari.Text = "";
        MuatData();
        lblStatus.Text = "Data diperbarui.";
    }

    private void txtCari_TextChanged(object sender, EventArgs e)
        => MuatData(txtCari.Text.Trim());
}