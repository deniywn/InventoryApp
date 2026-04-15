# Inventory Management System

Aplikasi inventory sederhana berbasis Windows Forms .NET 9,
Entity Framework Core, dan SQL Server 2022.

## Fitur
- Manajemen Produk (CRUD + search + low stock alert)
- Manajemen Kategori (CRUD)
- Transaksi stok masuk / keluar / penyesuaian
- Laporan low stock dan ringkasan

## Teknologi
- .NET 9.0 Windows Forms
- Entity Framework Core 9.0.14
- SQL Server 2022
- Arsitektur MVC + Repository Pattern

## Cara Menjalankan
1. Clone repository ini
2. Buka InventoryApp.sln di Visual Studio 2022
3. Pastikan SQL Server 2022 berjalan
4. Update connection string di appsettings.json
5. Tekan F5 — database dibuat otomatis

## Struktur Project
    Controllers/   logika bisnis dan validasi
    Data/          DbContext EF Core
    Forms/         semua Windows Forms UI
    Migrations/    migration database auto-generated
    Models/        class domain
    Repositories/  akses database lewat interface