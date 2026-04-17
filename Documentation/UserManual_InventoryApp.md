# Panduan Pengguna (User Manual)
## Inventory Management System v1.0

---

| Field | Detail |
|---|---|
| **Dokumen** | User Manual / Panduan Pengguna |
| **Versi** | 1.0.0 |
| **Tanggal** | April 2026 |
| **Ditujukan untuk** | Pengguna akhir aplikasi (staff administrasi, pemilik usaha) |

---

## Daftar Isi

1. Pengenalan Aplikasi
2. Memulai Aplikasi
3. Navigasi Menu Utama
4. Mengelola Kategori
5. Mengelola Produk
6. Mencatat Transaksi Stok
7. Melihat Laporan
8. Pertanyaan Umum (FAQ)

---

## 1. Pengenalan Aplikasi

**Inventory Management System (IMS)** adalah aplikasi desktop untuk mencatat dan
memantau stok barang secara mudah dan akurat.

Dengan aplikasi ini kamu dapat:

- Mengelola **daftar produk** beserta kategori, harga, dan jumlah stok
- Mencatat **pergerakan stok**: barang masuk, barang keluar, dan koreksi stok
- Mendapat **peringatan otomatis** ketika stok suatu produk hampir habis
- Melihat **laporan ringkas** kondisi inventaris secara keseluruhan

---

## 2. Memulai Aplikasi

### 2.1 Menjalankan Aplikasi

1. Buka folder instalasi aplikasi
2. Double-klik file **InventoryApp.exe**
3. Tunggu beberapa detik — jendela utama aplikasi akan terbuka

### 2.2 Tampilan Awal

Saat pertama kali dibuka, aplikasi menampilkan jendela utama dengan:

- **Menu bar** di bagian atas: Products | Categories | Transactions | Reports
- **Area konten** di tengah (kosong saat pertama buka)
- **Status bar** di bagian bawah: menampilkan pesan status aplikasi

### 2.3 Urutan Penggunaan yang Disarankan

Untuk pengguna baru, ikuti urutan ini:

```
Langkah 1 → Tambah Kategori terlebih dahulu
Langkah 2 → Tambah Produk (membutuhkan kategori yang sudah ada)
Langkah 3 → Catat Transaksi stok masuk (IN) untuk produk baru
Langkah 4 → Gunakan Transactions untuk catat keluar masuk stok harian
Langkah 5 → Pantau Reports secara berkala
```


---

## 3. Navigasi Menu Utama

Menu bar di bagian atas jendela berisi 4 menu utama:

| Menu | Fungsi |
|---|---|
| **Products** | Kelola daftar produk (tambah, edit, hapus, cari) |
| **Categories** | Kelola kategori produk |
| **Transactions** | Catat stok masuk, keluar, dan penyesuaian |
| **Reports** | Lihat laporan low stock dan ringkasan inventaris |

Klik nama menu untuk membuka halamannya.

---

## 4. Mengelola Kategori

Kategori digunakan untuk mengelompokkan produk. Contoh: Elektronik, Peralatan, Alat Tulis.

> **Penting:** Buat kategori sebelum menambahkan produk karena setiap produk wajib
> memiliki kategori.

### 4.1 Membuka Halaman Kategori

Klik menu **Categories** di menu bar.

Halaman Categories menampilkan:
- **Toolbar** di atas: tombol Tambah, Edit, Hapus, Refresh, dan kotak Cari
- **Tabel** di tengah: daftar semua kategori
- **Status bar** di bawah: jumlah kategori yang ditampilkan

### 4.2 Menambah Kategori Baru

1. Klik tombol **Tambah** di toolbar
2. Dialog "Tambah Kategori" terbuka
3. Isi kolom **Nama Kategori** (wajib diisi)
4. Isi kolom **Deskripsi** (boleh dikosongkan)
5. Klik **Simpan**

Jika berhasil, kategori baru langsung muncul di tabel.

> **Catatan:** Nama kategori tidak boleh sama dengan kategori yang sudah ada.
> Jika duplikat, akan muncul pesan peringatan.

### 4.3 Mengedit Kategori

1. Klik baris kategori yang ingin diedit di tabel
2. Klik tombol **Edit** di toolbar
3. Dialog edit terbuka dengan data kategori yang sudah terisi
4. Ubah data yang perlu diubah
5. Klik **Simpan**

### 4.4 Menghapus Kategori

1. Klik baris kategori yang ingin dihapus
2. Klik tombol **Hapus**
3. Muncul dialog konfirmasi — klik **Ya** untuk lanjutkan

> **Perhatian:** Kategori yang masih memiliki produk **tidak bisa dihapus**.
> Pindahkan atau hapus semua produk di kategori tersebut terlebih dahulu.

### 4.5 Mencari Kategori

Ketik kata kunci di kotak **Cari** di toolbar. Tabel akan langsung memfilter
hasil sesuai kata kunci yang diketik.


---

## 5. Mengelola Produk

### 5.1 Membuka Halaman Produk

Klik menu **Products** di menu bar.

Halaman Products menampilkan tabel dengan kolom:

| Kolom | Keterangan |
|---|---|
| ID | Nomor urut produk di database |
| SKU | Kode unik produk |
| Nama Produk | Nama lengkap produk |
| Kategori | Kategori produk |
| Harga | Harga produk dalam Rupiah |
| Stok | Jumlah stok saat ini |
| Min Stok | Batas minimum stok |

> **Perhatian stok rendah:** Baris yang berwarna merah menandakan produk tersebut
> memiliki stok yang sama dengan atau di bawah batas minimum (Min Stok).
> Produk ini perlu segera di-restock.

### 5.2 Menambah Produk Baru

1. Klik tombol **Tambah** di toolbar
2. Dialog "Tambah Produk" terbuka
3. Isi semua field yang bertanda bintang (*) — field ini wajib diisi:

| Field | Keterangan | Contoh |
|---|---|---|
| Nama Produk * | Nama lengkap produk | Laptop Asus VivoBook 14 |
| SKU * | Kode unik produk, huruf kapital | LPT-001 |
| Kategori * | Pilih dari dropdown | Elektronik |
| Harga * | Harga dalam angka, tanpa titik atau koma | 8500000 |
| Stok | Jumlah stok awal | 10 |
| Min Stok | Batas minimum sebelum alert | 3 |
| Deskripsi | Keterangan tambahan (opsional) | Laptop 14 inch RAM 8GB |

4. Klik **Simpan**

### 5.3 Mengedit Produk

1. Klik baris produk yang ingin diedit
2. Klik tombol **Edit**
3. Ubah data yang diperlukan
4. Klik **Simpan**

> **Catatan:** Mengubah nilai Stok melalui form Edit tidak mencatat riwayat perubahan.
> Untuk perubahan stok yang perlu dicatat (keluar/masuk barang), gunakan menu
> **Transactions** bukan Edit Produk.

### 5.4 Menghapus Produk

1. Klik baris produk yang ingin dihapus
2. Klik tombol **Hapus**
3. Baca konfirmasi yang muncul dengan teliti
4. Klik **Ya** untuk melanjutkan penghapusan

> **Perhatian:** Produk yang dihapus akan menghapus seluruh riwayat transaksinya juga.
> Pastikan kamu yakin sebelum menghapus.

### 5.5 Mencari Produk

Ketik nama produk atau SKU di kotak **Cari** di toolbar.
Tabel akan langsung memfilter hasil secara real-time.


---

## 6. Mencatat Transaksi Stok

Setiap perubahan stok — baik masuk, keluar, maupun koreksi — harus dicatat sebagai
transaksi. Dengan cara ini semua riwayat pergerakan stok tersimpan secara lengkap.

### 6.1 Membuka Halaman Transaksi

Klik menu **Transactions** di menu bar.

Halaman Transactions menampilkan tabel transaksi dengan warna berbeda per tipe:

| Warna baris | Tipe transaksi | Artinya |
|---|---|---|
| Hijau muda | IN | Stok masuk / barang diterima |
| Merah muda | OUT | Stok keluar / barang dikeluarkan |
| Kuning muda | ADJUSTMENT | Koreksi stok secara langsung |

### 6.2 Tiga Tipe Transaksi

**IN — Stok Masuk**
Digunakan saat menerima barang baru, restock dari supplier, atau pembelian.
Stok produk akan **bertambah** sejumlah Jumlah yang diisi.

Contoh: Stok Laptop = 10, tambah transaksi IN Jumlah = 5 → Stok menjadi 15.

---

**OUT — Stok Keluar**
Digunakan saat barang keluar: terjual, dipakai, atau didistribusikan.
Stok produk akan **berkurang** sejumlah Jumlah yang diisi.

Contoh: Stok Laptop = 15, tambah transaksi OUT Jumlah = 3 → Stok menjadi 12.

> **Perhatian:** Transaksi OUT tidak bisa melebihi stok yang tersedia.
> Jika Jumlah melebihi stok, akan muncul pesan error dan transaksi tidak tersimpan.

---

**ADJUSTMENT — Koreksi Stok**
Digunakan saat stock opname atau koreksi kesalahan pencatatan sebelumnya.
Stok produk akan **langsung diganti** ke nilai Jumlah yang diisi.

Contoh: Stok tercatat 12, hasil hitung fisik = 20, buat ADJUSTMENT Jumlah = 20
→ Stok langsung menjadi 20 (bukan 12 + 20 = 32).

### 6.3 Mencatat Transaksi Baru

1. Klik tombol **Tambah Transaksi** di toolbar
2. Dialog "Transaksi Baru" terbuka
3. Isi form:

| Field | Keterangan |
|---|---|
| Produk * | Pilih produk dari dropdown |
| Tipe * | Pilih: IN / OUT / ADJUSTMENT |
| Jumlah * | Angka lebih dari 0 |
| Harga Satuan | Harga per unit saat transaksi (boleh 0) |
| Catatan | Keterangan tambahan (opsional) |

4. Klik **Simpan**

Setelah tersimpan, stok produk otomatis terupdate sesuai tipe transaksi.

### 6.4 Filter Transaksi per Produk

Untuk melihat riwayat transaksi satu produk tertentu:

1. Klik dropdown **Filter Produk** di toolbar
2. Pilih nama produk yang ingin dilihat
3. Tabel akan menampilkan hanya transaksi produk tersebut

Untuk kembali melihat semua transaksi, klik tombol **Semua Produk**.

> **Catatan penting:** Transaksi yang sudah tersimpan **tidak bisa diedit atau dihapus**.
> Ini disengaja untuk menjaga keakuratan riwayat stok.
> Jika ada kesalahan input, buat transaksi koreksi baru.


---

## 7. Melihat Laporan

### 7.1 Membuka Halaman Laporan

Klik menu **Reports** di menu bar. Halaman laporan terbuka dengan dua tab.

---

### 7.2 Tab Low Stock — Produk Perlu Restock

Tab ini menampilkan daftar produk yang stoknya sudah mencapai atau di bawah
batas minimum (Min Stok).

Kolom yang ditampilkan:

| Kolom | Keterangan |
|---|---|
| SKU | Kode produk |
| Nama Produk | Nama produk |
| Kategori | Kategori produk |
| Stok Saat Ini | Jumlah stok yang tersisa (ditampilkan merah) |
| Min Stok | Batas minimum yang ditetapkan |
| Kekurangan | Selisih: Min Stok dikurangi Stok Saat Ini |

Kolom **Kekurangan** menunjukkan berapa unit yang perlu dibeli agar stok
kembali ke batas minimum.

Contoh: Stok Saat Ini = 2, Min Stok = 5 → Kekurangan = 3 unit.

---

### 7.3 Tab Ringkasan — Statistik Inventaris

Tab ini menampilkan angka ringkasan keseluruhan inventaris:

| Informasi | Keterangan |
|---|---|
| Total Produk | Jumlah semua produk yang terdaftar |
| Total Kategori | Jumlah kategori yang ada |
| Total Transaksi | Jumlah seluruh transaksi yang pernah dicatat |
| Perlu Restock | Jumlah produk yang stoknya di bawah minimum |

Baris **Perlu Restock** ditampilkan berwarna **merah** jika ada produk yang
perlu restock, atau **hijau** jika semua stok dalam kondisi aman.

---

## 8. Pertanyaan Umum (FAQ)

**Q: Mengapa nama kategori tidak bisa sama?**
A: Nama kategori harus unik agar tidak membingungkan saat memilih kategori produk.
   Jika ingin membuat kategori serupa, tambahkan keterangan pembeda di namanya,
   misalnya "Elektronik Kantor" dan "Elektronik Rumah".

---

**Q: Bagaimana cara memperbaiki stok yang salah input?**
A: Buat transaksi **ADJUSTMENT** dengan nilai stok yang benar.
   Contoh: stok tercatat 50 tapi seharusnya 35, buat ADJUSTMENT dengan Jumlah = 35.
   Jangan gunakan Edit Produk untuk mengubah stok karena tidak ada riwayat yang tercatat.

---

**Q: Mengapa transaksi tidak bisa dihapus?**
A: Transaksi adalah catatan historis yang permanen — seperti nota pembelian.
   Menghapus transaksi lama bisa membuat riwayat stok tidak akurat.
   Jika ada kesalahan, buat transaksi koreksi baru.

---

**Q: Apa yang terjadi jika saya menghapus produk?**
A: Seluruh riwayat transaksi produk tersebut juga akan ikut terhapus.
   Pastikan kamu sudah tidak memerlukan riwayat transaksinya sebelum menghapus produk.

---

**Q: Mengapa ada produk dengan baris berwarna merah di halaman Products?**
A: Baris merah menandakan produk tersebut stoknya sudah mencapai atau di bawah
   batas minimum (Min Stok). Ini adalah peringatan bahwa produk perlu segera di-restock.
   Tambahkan transaksi IN untuk produk tersebut.

---

**Q: Berapa nilai yang harus diisi di field Harga Satuan saat transaksi?**
A: Isi dengan harga per unit pada saat transaksi terjadi.
   Untuk transaksi masuk (IN): isi harga beli dari supplier.
   Untuk transaksi keluar (OUT): isi harga jual ke pembeli.
   Field ini boleh diisi 0 jika tidak relevan atau tidak diketahui.

---

**Q: Aplikasi tiba-tiba tidak bisa dibuka, apa yang harus dilakukan?**
A: Periksa hal-hal berikut secara berurutan:
   1. Pastikan SQL Server sedang berjalan (cek di Windows Services)
   2. Pastikan file appsettings.json ada di folder yang sama dengan InventoryApp.exe
   3. Pastikan isi appsettings.json tidak berubah (nama server masih benar)
   4. Hubungi teknisi atau kontak support jika masalah berlanjut

---

## 9. Kontak Support

Jika mengalami masalah yang tidak tercantum di panduan ini, hubungi:

```
Nama    : Deni Yuniawan
Email   : deniywn19@gmail.com
Telepon : 
```

---

*Panduan Pengguna Inventory Management System v1.0 — April 2026*
