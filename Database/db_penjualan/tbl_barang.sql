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

--
-- Indexes for dumped tables
--

--
-- Indeks untuk tabel `tbl_barang`
--
ALTER TABLE `tbl_barang`
  ADD PRIMARY KEY (`kodebarang`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
