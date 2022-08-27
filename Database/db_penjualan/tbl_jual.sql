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

--
-- Indexes for dumped tables
--

--
-- Indeks untuk tabel `tbl_jual`
--
ALTER TABLE `tbl_jual`
  ADD PRIMARY KEY (`nojual`),
  ADD KEY `FK_tbl_jual_tbl_pelanggan` (`kodepelanggan`);

--
-- Ketidakleluasaan untuk tabel pelimpahan (Dumped Tables)
--

--
-- Ketidakleluasaan untuk tabel `tbl_jual`
--
ALTER TABLE `tbl_jual`
  ADD CONSTRAINT `FK_tbl_jual_tbl_pelanggan` FOREIGN KEY (`kodepelanggan`) REFERENCES `tbl_pelanggan` (`kodepelanggan`) ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
