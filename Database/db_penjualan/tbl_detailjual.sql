-- phpMyAdmin SQL Dump
-- version 5.1.0
-- https://www.phpmyadmin.net/
--
-- Host: localhost:3306
-- Waktu pembuatan: 29 Sep 2021 pada 14.17
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

--
-- Indexes for dumped tables
--

--
-- Indeks untuk tabel `tbl_detailjual`
--
ALTER TABLE `tbl_detailjual`
  ADD KEY `FK_tbl_detailjual_tbl_barang` (`kodebarang`),
  ADD KEY `FK_tbl_detailjual_tbl_jual` (`nojual`);

--
-- Ketidakleluasaan untuk tabel pelimpahan (Dumped Tables)
--

--
-- Ketidakleluasaan untuk tabel `tbl_detailjual`
--
ALTER TABLE `tbl_detailjual`
  ADD CONSTRAINT `FK_tbl_detailjual_tbl_barang` FOREIGN KEY (`kodebarang`) REFERENCES `tbl_barang` (`kodebarang`) ON DELETE SET NULL ON UPDATE CASCADE,
  ADD CONSTRAINT `FK_tbl_detailjual_tbl_jual` FOREIGN KEY (`nojual`) REFERENCES `tbl_jual` (`nojual`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
