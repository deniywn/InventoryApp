using InventoryApp.Controllers;
using InventoryApp.Models;
using System.Windows.Forms;

namespace InventoryApp.Forms;

public partial class TransactionDetailForm : Form
{
    private readonly TransactionController _controller;

    public TransactionDetailForm(TransactionController controller)
    {
        InitializeComponent();
        _controller = controller;
    }

    private void TransactionDetailForm_Load(object sender, EventArgs e)
    {
        IsiDropdownProduk();
        IsiDropdownTipe();
    }

    private void IsiDropdownProduk()
    {
        var produkList = _controller.GetAllProducts().ToList();
        cboProduk.DataSource = produkList;
        cboProduk.DisplayMember = "Name";
        cboProduk.ValueMember = "Id";
        cboProduk.SelectedIndex = -1;
    }

    private void IsiDropdownTipe()
    {
        // Isi ComboBox tipe dari enum TransactionType
        cboTipe.DataSource = Enum.GetValues(typeof(TransactionType))
            .Cast<TransactionType>()
            .Select(t => new { Value = t, Display = t.ToString() })
            .ToList();
        cboTipe.DisplayMember = "Display";
        cboTipe.ValueMember = "Value";
        cboTipe.SelectedIndex = 0; // default: IN
    }

    private void btnSimpan_Click(object sender, EventArgs e)
    {
        DialogResult = DialogResult.None;
        if (!ValidasiInput()) return;

        var transaksi = new Transaction
        {
            ProductId = (int)(cboProduk.SelectedValue ?? 0),
            Type = (TransactionType)(cboTipe.SelectedValue
                              ?? TransactionType.IN),
            Quantity = (int)nudJumlah.Value,
            UnitPrice = nudHarga.Value,
            Notes = txtCatatan.Text.Trim(),
            TransactionDate = DateTime.Now
        };

        var (berhasil, pesan) = _controller.Create(transaksi);

        if (berhasil)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
        else
        {
            MessageBox.Show(pesan, "Gagal",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }

    private bool ValidasiInput()
    {
        errorProvider1.Clear();
        bool valid = true;

        if (cboProduk.SelectedIndex < 0)
        {
            errorProvider1.SetError(cboProduk, "Pilih produk.");
            valid = false;
        }
        if (nudJumlah.Value <= 0)
        {
            errorProvider1.SetError(nudJumlah,
                "Jumlah harus lebih dari 0.");
            valid = false;
        }
        return valid;
    }
}