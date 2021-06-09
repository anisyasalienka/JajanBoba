-- phpMyAdmin SQL Dump
-- version 5.0.3
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Waktu pembuatan: 09 Jun 2021 pada 09.56
-- Versi server: 10.4.14-MariaDB
-- Versi PHP: 7.4.11

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db_aplikasijajan`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `tb_datapesanan`
--

CREATE TABLE `tb_datapesanan` (
  `Id` int(11) NOT NULL,
  `Nama` varchar(100) NOT NULL,
  `Pesanan` varchar(150) NOT NULL,
  `Harga` int(11) NOT NULL,
  `Tanggal` datetime NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `tb_datapesanan`
--

INSERT INTO `tb_datapesanan` (`Id`, `Nama`, `Pesanan`, `Harga`, `Tanggal`) VALUES
(1, 'Anisya', 'Matcha with Grass Jelly Big Size', 20000, '2021-06-08 20:34:15'),
(2, 'Diva', 'Matcha with Grass Jelly Big Size', 20000, '2021-06-08 20:58:36'),
(3, 'Diyah', 'Matcha with Grass Jelly Small Size', 18000, '2021-06-08 20:59:31'),
(4, 'Dhani', 'Thaitea with Pudding Regular Size', 19000, '2021-06-08 21:45:18'),
(5, 'Bara', 'Matcha with Grass Jelly Big Size', 20000, '2021-06-08 21:45:56'),
(6, 'Diaz', 'Matcha with Grass Jelly Regular Size', 19000, '2021-06-08 21:46:57'),
(7, 'Mawar', 'Thaitea with Pudding Regular Size', 19000, '2021-06-08 21:50:15'),
(8, 'Anisa', 'Matcha with Grass Jelly Big Size', 20000, '2021-06-08 21:54:58'),
(9, 'Rama', 'Matcha with Grass Jelly Big Size', 20000, '2021-06-08 23:02:12'),
(10, 'Karin', 'Matcha with Grass Jelly Small Size', 18000, '2021-06-08 23:35:20'),
(11, 'Kevin', 'Milktea with Pearl Small Size', 19000, '2021-06-08 23:50:06'),
(12, 'Ulfa', 'Matcha with Grass Jelly Regular Size', 19000, '2021-06-08 23:50:47'),
(13, 'Yanto', 'Thaitea with Pudding Big Size', 20000, '2021-06-09 00:55:05'),
(14, 'Yanto', 'Milktea with Pearl Big Size', 21000, '2021-06-09 01:03:37');

-- --------------------------------------------------------

--
-- Struktur dari tabel `tb_login`
--

CREATE TABLE `tb_login` (
  `Id_user` int(11) NOT NULL,
  `username` varchar(50) NOT NULL,
  `password` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `tb_login`
--

INSERT INTO `tb_login` (`Id_user`, `username`, `password`) VALUES
(1, 'admin1', 'admin1'),
(2, 'admin2', 'admin2');

-- --------------------------------------------------------

--
-- Struktur dari tabel `tb_menu`
--

CREATE TABLE `tb_menu` (
  `id_menu` int(11) NOT NULL,
  `menu_name` varchar(50) NOT NULL,
  `drink_size` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `tb_menu`
--

INSERT INTO `tb_menu` (`id_menu`, `menu_name`, `drink_size`) VALUES
(1, 'Milktea with Pearl', 'Big Size'),
(2, 'Thaitea with Pudding', 'Big Size'),
(3, 'Matcha with Grass Jelly', 'Big Size'),
(4, 'Milktea with Pearl', 'Regular Size'),
(5, 'Thaitea with Pudding', 'Regular Size'),
(6, 'Matcha with Grass Jelly', 'Regular Size'),
(7, 'Milktea with Pearl', 'Small Size'),
(8, 'Thaitea with Pudding', 'Small Size'),
(9, 'Matcha with Grass Jelly', 'Small Size');

--
-- Indexes for dumped tables
--

--
-- Indeks untuk tabel `tb_datapesanan`
--
ALTER TABLE `tb_datapesanan`
  ADD PRIMARY KEY (`Id`);

--
-- Indeks untuk tabel `tb_login`
--
ALTER TABLE `tb_login`
  ADD PRIMARY KEY (`Id_user`);

--
-- Indeks untuk tabel `tb_menu`
--
ALTER TABLE `tb_menu`
  ADD PRIMARY KEY (`id_menu`);

--
-- AUTO_INCREMENT untuk tabel yang dibuang
--

--
-- AUTO_INCREMENT untuk tabel `tb_datapesanan`
--
ALTER TABLE `tb_datapesanan`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;

--
-- AUTO_INCREMENT untuk tabel `tb_login`
--
ALTER TABLE `tb_login`
  MODIFY `Id_user` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT untuk tabel `tb_menu`
--
ALTER TABLE `tb_menu`
  MODIFY `id_menu` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
