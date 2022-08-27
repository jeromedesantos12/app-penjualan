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
-- Indeks untuk tabel `tbl_pelanggan`
--
ALTER TABLE `tbl_pelanggan`
  ADD PRIMARY KEY (`kodepelanggan`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
