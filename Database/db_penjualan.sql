-- phpMyAdmin SQL Dump
-- version 5.1.0
-- https://www.phpmyadmin.net/
--
-- Host: localhost:3306
-- Waktu pembuatan: 29 Sep 2021 pada 14.16
-- Versi server: 5.7.24
-- Versi PHP: 7.2.19

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db_penjualan`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbl_admin`
--

CREATE TABLE `tbl_admin` (
  `kodeadmin` varchar(6) NOT NULL,
  `namaadmin` varchar(30) NOT NULL,
  `passwordadmin` varchar(10) NOT NULL,
  `leveladmin` varchar(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `tbl_admin`
--

INSERT INTO `tbl_admin` (`kodeadmin`, `namaadmin`, `passwordadmin`, `leveladmin`) VALUES
('ADM001', 'Jeremy Santoso', '123', 'ADMIN'),
('ADM002', 'Marta Yovita', '123', 'MARKETING'),
('ADM003', 'Jeffry Winata', '123', 'OPERATIONAL'),
('ADM004', 'Muliaty Surianata', '123', 'ACCOUNTING');

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbl_barang`
--

CREATE TABLE `tbl_barang` (
  `kodebarang` varchar(6) NOT NULL,
  `namabarang` varchar(30) NOT NULL,
  `hargabarang` int(7) NOT NULL,
  `jumlahbarang` int(2) NOT NULL,
  `satuanbarang` varchar(3) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `tbl_barang`
--

INSERT INTO `tbl_barang` (`kodebarang`, `namabarang`, `hargabarang`, `jumlahbarang`, `satuanbarang`) VALUES
('BRG001', 'Maltodextrine', 700000, 7, 'SAK'),
('BRG002', 'Dextrose', 550000, 8, 'SAK'),
('BRG003', 'Non Diary Creamer', 1400000, 8, 'SAK'),
('BRG004', 'Sucralose', 2250000, 10, 'SAK'),
('BRG005', 'Corn Starch', 450000, 10, 'SAK'),
('BRG006', 'Aspartame', 7500000, 10, 'SAK'),
('BRG007', 'Citric Acid', 600000, 10, 'SAK'),
('BRG008', 'Ascorbid Acid', 3500000, 10, 'SAK'),
('BRG009', 'Marine Colagen', 9250000, 10, 'SAK'),
('BRG010', 'Skim Milk', 3400000, 10, 'SAK');

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbl_detailjual`
--

CREATE TABLE `tbl_detailjual` (
  `nojual` varchar(10) NOT NULL,
  `kodebarang` varchar(6) DEFAULT NULL,
  `namabarang` varchar(30) NOT NULL,
  `satuanbarang` varchar(3) NOT NULL,
  `hargajual` int(7) NOT NULL,
  `jumlahjual` int(2) NOT NULL,
  `subtotal` bigint(20) NOT NULL,
  `ppn` bigint(20) NOT NULL,
  `total` bigint(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `tbl_detailjual`
--

INSERT INTO `tbl_detailjual` (`nojual`, `kodebarang`, `namabarang`, `satuanbarang`, `hargajual`, `jumlahjual`, `subtotal`, `ppn`, `total`) VALUES
('J210927001', 'BRG001', 'Maltodextrine', 'SAK', 700000, 1, 700000, 70000, 770000),
('J210927001', 'BRG002', 'Dextrose', 'SAK', 550000, 1, 550000, 55000, 605000),
('J210928002', 'BRG002', 'Dextrose', 'SAK', 550000, 1, 550000, 55000, 605000),
('J210928002', 'BRG003', 'Non Diary Creamer', 'SAK', 1400000, 2, 2800000, 280000, 3080000),
('J210929003', 'BRG001', 'Maltodextrine', 'SAK', 700000, 2, 1400000, 140000, 1540000);

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbl_do`
--

CREATE TABLE `tbl_do` (
  `nojual` varchar(10) NOT NULL,
  `kodeadmin` varchar(6) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `tbl_do`
--

INSERT INTO `tbl_do` (`nojual`, `kodeadmin`) VALUES
('J210927001', 'ADM003'),
('J210928002', 'ADM003'),
('J210929003', 'ADM003');

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbl_invoice`
--

CREATE TABLE `tbl_invoice` (
  `nojual` varchar(10) NOT NULL,
  `kodeadmin` varchar(6) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `tbl_invoice`
--

INSERT INTO `tbl_invoice` (`nojual`, `kodeadmin`) VALUES
('J210927001', 'ADM004'),
('J210928002', 'ADM004'),
('J210929003', 'ADM004');

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbl_jual`
--

CREATE TABLE `tbl_jual` (
  `nojual` varchar(10) NOT NULL,
  `tgljual` date NOT NULL,
  `jamjual` time NOT NULL,
  `itemjual` bigint(20) NOT NULL,
  `subtotaljual` bigint(20) NOT NULL,
  `ppnjual` bigint(20) NOT NULL,
  `totaljual` bigint(20) NOT NULL,
  `nopo` varchar(11) NOT NULL,
  `tglpo` date NOT NULL,
  `tgltempo` date NOT NULL,
  `nodo` varchar(11) NOT NULL,
  `noinvoice` varchar(11) NOT NULL,
  `kodepelanggan` varchar(6) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `tbl_jual`
--

INSERT INTO `tbl_jual` (`nojual`, `tgljual`, `jamjual`, `itemjual`, `subtotaljual`, `ppnjual`, `totaljual`, `nopo`, `tglpo`, `tgltempo`, `nodo`, `noinvoice`, `kodepelanggan`) VALUES
('J210927001', '2021-09-27', '19:15:41', 2, 1250000, 125000, 1375000, 'PO-001', '2021-09-29', '2021-09-29', 'DO210927001', 'IN210927001', 'PLG001'),
('J210928002', '2021-09-28', '19:15:57', 3, 3350000, 335000, 3685000, 'PO-002', '2021-09-29', '2021-09-29', 'DO210928002', 'IN210928002', 'PLG002'),
('J210929003', '2021-09-29', '19:16:42', 2, 1400000, 140000, 1540000, 'PO-003', '2021-09-29', '2021-09-29', 'DO210929003', 'IN210929003', 'PLG002');

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbl_laporan`
--

CREATE TABLE `tbl_laporan` (
  `nojual` varchar(10) NOT NULL,
  `kodeadmin` varchar(6) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `tbl_laporan`
--

INSERT INTO `tbl_laporan` (`nojual`, `kodeadmin`) VALUES
('J210927001', 'ADM002'),
('J210928002', 'ADM002'),
('J210929003', 'ADM002');

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbl_pelanggan`
--

CREATE TABLE `tbl_pelanggan` (
  `kodepelanggan` varchar(6) NOT NULL,
  `namapelanggan` varchar(30) NOT NULL,
  `alamatpelanggan` varchar(100) NOT NULL,
  `telppelanggan` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `tbl_pelanggan`
--

INSERT INTO `tbl_pelanggan` (`kodepelanggan`, `namapelanggan`, `alamatpelanggan`, `telppelanggan`) VALUES
('PLG001', 'PT. Cahaya Tirta Aromma', 'Kajen, Lemahduwur, Kec. Adiwerna, Tegal, Jawa Tengah.', '02156784456'),
('PLG002', 'PT. Indojaya Megafood', 'Jl. Raden Patah Raya No.111, RT.001/RW.008, Parung Serab, Kec. Ciledug, Kota Tangerang, Banten.', '02139708088'),
('PLG003', 'PT. Jakarta Powder Supply', 'Jl. Raden Patah Raya No.111, RT.001/RW.008, Parung Serab, Kec. Ciledug, Kota Tangerang, Banten.', '02127561120'),
('PLG004', 'PT. Kaneka Food Indonesia', 'Margakaya, Kec. Telukjambe Bar., Kabupaten Karawang, Jawa Barat.', '02129569340'),
('PLG005', 'PT. Joyful Snack Indonesia', 'Jl. Raya Pemda No.73, RT.03/RW.14, Pasir Jambu, Kec. Sukaraja, Bogor, Jawa Barat.', '081297351368');

--
-- Indexes for dumped tables
--

--
-- Indeks untuk tabel `tbl_admin`
--
ALTER TABLE `tbl_admin`
  ADD PRIMARY KEY (`kodeadmin`);

--
-- Indeks untuk tabel `tbl_barang`
--
ALTER TABLE `tbl_barang`
  ADD PRIMARY KEY (`kodebarang`);

--
-- Indeks untuk tabel `tbl_detailjual`
--
ALTER TABLE `tbl_detailjual`
  ADD KEY `FK_tbl_detailjual_tbl_barang` (`kodebarang`),
  ADD KEY `FK_tbl_detailjual_tbl_jual` (`nojual`);

--
-- Indeks untuk tabel `tbl_do`
--
ALTER TABLE `tbl_do`
  ADD KEY `FK_tbl_do_tbl_admin` (`kodeadmin`),
  ADD KEY `FK_tbl_do_tbl_jual` (`nojual`);

--
-- Indeks untuk tabel `tbl_invoice`
--
ALTER TABLE `tbl_invoice`
  ADD KEY `FK_tbl_invoice_tbl_admin` (`kodeadmin`),
  ADD KEY `FK_tbl_invoice_tbl_jual` (`nojual`);

--
-- Indeks untuk tabel `tbl_jual`
--
ALTER TABLE `tbl_jual`
  ADD PRIMARY KEY (`nojual`),
  ADD KEY `FK_tbl_jual_tbl_pelanggan` (`kodepelanggan`);

--
-- Indeks untuk tabel `tbl_laporan`
--
ALTER TABLE `tbl_laporan`
  ADD KEY `FK_tbl_laporan_tbl_admin` (`kodeadmin`),
  ADD KEY `FK_tbl_laporan_tbl_jual` (`nojual`);

--
-- Indeks untuk tabel `tbl_pelanggan`
--
ALTER TABLE `tbl_pelanggan`
  ADD PRIMARY KEY (`kodepelanggan`);

--
-- Ketidakleluasaan untuk tabel pelimpahan (Dumped Tables)
--

--
-- Ketidakleluasaan untuk tabel `tbl_detailjual`
--
ALTER TABLE `tbl_detailjual`
  ADD CONSTRAINT `FK_tbl_detailjual_tbl_barang` FOREIGN KEY (`kodebarang`) REFERENCES `tbl_barang` (`kodebarang`) ON DELETE SET NULL ON UPDATE CASCADE,
  ADD CONSTRAINT `FK_tbl_detailjual_tbl_jual` FOREIGN KEY (`nojual`) REFERENCES `tbl_jual` (`nojual`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Ketidakleluasaan untuk tabel `tbl_do`
--
ALTER TABLE `tbl_do`
  ADD CONSTRAINT `FK_tbl_do_tbl_admin` FOREIGN KEY (`kodeadmin`) REFERENCES `tbl_admin` (`kodeadmin`) ON UPDATE CASCADE,
  ADD CONSTRAINT `FK_tbl_do_tbl_jual` FOREIGN KEY (`nojual`) REFERENCES `tbl_jual` (`nojual`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Ketidakleluasaan untuk tabel `tbl_invoice`
--
ALTER TABLE `tbl_invoice`
  ADD CONSTRAINT `FK_tbl_invoice_tbl_admin` FOREIGN KEY (`kodeadmin`) REFERENCES `tbl_admin` (`kodeadmin`) ON UPDATE CASCADE,
  ADD CONSTRAINT `FK_tbl_invoice_tbl_jual` FOREIGN KEY (`nojual`) REFERENCES `tbl_jual` (`nojual`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Ketidakleluasaan untuk tabel `tbl_jual`
--
ALTER TABLE `tbl_jual`
  ADD CONSTRAINT `FK_tbl_jual_tbl_pelanggan` FOREIGN KEY (`kodepelanggan`) REFERENCES `tbl_pelanggan` (`kodepelanggan`) ON UPDATE CASCADE;

--
-- Ketidakleluasaan untuk tabel `tbl_laporan`
--
ALTER TABLE `tbl_laporan`
  ADD CONSTRAINT `FK_tbl_laporan_tbl_admin` FOREIGN KEY (`kodeadmin`) REFERENCES `tbl_admin` (`kodeadmin`) ON UPDATE CASCADE,
  ADD CONSTRAINT `FK_tbl_laporan_tbl_jual` FOREIGN KEY (`nojual`) REFERENCES `tbl_jual` (`nojual`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
