-- phpMyAdmin SQL Dump
-- version 4.8.5
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Waktu pembuatan: 26 Des 2019 pada 09.23
-- Versi server: 10.1.38-MariaDB
-- Versi PHP: 7.1.27

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `rekamedis`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `diagnosa`
--

CREATE TABLE `diagnosa` (
  `no_rmedis` int(15) DEFAULT NULL,
  `kd_dokter` int(15) DEFAULT NULL,
  `diagnosa` varchar(70) DEFAULT NULL,
  `tidakan` varchar(100) DEFAULT NULL,
  `biaya` int(20) DEFAULT NULL,
  `resep` varchar(50) DEFAULT NULL,
  `tgl_diagnosa` date DEFAULT NULL,
  `ket_bayar` varchar(30) DEFAULT NULL,
  `ket_obat` varchar(30) DEFAULT NULL,
  `no_pembayaran` int(11) DEFAULT NULL,
  `kd_poli` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Struktur dari tabel `dokter`
--

CREATE TABLE `dokter` (
  `kd_dokter` int(11) DEFAULT NULL,
  `nama_dokter` varchar(50) DEFAULT NULL,
  `jenis_kelamin` varchar(20) DEFAULT NULL,
  `alamat` varchar(50) DEFAULT NULL,
  `jabatan` varchar(50) DEFAULT NULL,
  `kd_poli` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Struktur dari tabel `obat`
--

CREATE TABLE `obat` (
  `kd_obat` int(11) NOT NULL,
  `nama_obat` varchar(50) DEFAULT NULL,
  `satuan` varchar(30) DEFAULT NULL,
  `jumlah` int(11) DEFAULT NULL,
  `terpakai` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Struktur dari tabel `pasien`
--

CREATE TABLE `pasien` (
  `no_rmedis` int(11) NOT NULL,
  `tgl_daftar` date DEFAULT NULL,
  `nama_depan` varchar(30) DEFAULT NULL,
  `nama_lengkap` varchar(50) DEFAULT NULL,
  `no_id` int(16) DEFAULT NULL,
  `jenis_kelamin` varchar(20) DEFAULT NULL,
  `pendidikan` varchar(50) DEFAULT NULL,
  `agama` varchar(30) DEFAULT NULL,
  `tempat_lahir` varchar(30) NOT NULL,
  `tgl_lahir` date DEFAULT NULL,
  `usia` int(20) NOT NULL,
  `alamat` varchar(80) DEFAULT NULL,
  `rt` varchar(10) DEFAULT NULL,
  `rw` varchar(10) DEFAULT NULL,
  `kelurahan` varchar(15) DEFAULT NULL,
  `provinsi` varchar(15) DEFAULT NULL,
  `kabupaten` varchar(15) DEFAULT NULL,
  `kecamatan` varchar(15) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `pasien`
--

INSERT INTO `pasien` (`no_rmedis`, `tgl_daftar`, `nama_depan`, `nama_lengkap`, `no_id`, `jenis_kelamin`, `pendidikan`, `agama`, `tempat_lahir`, `tgl_lahir`, `usia`, `alamat`, `rt`, `rw`, `kelurahan`, `provinsi`, `kabupaten`, `kecamatan`) VALUES
(123, '2019-12-19', '', '', 0, '', '', '', '', '2019-12-26', 0, '', '', '', '', '', '', ''),
(1230, '2019-12-11', 'A', 'AK', 1246, 'Laki - laki', '', '', '', '2018-12-26', 1, 'asdfghj', '1', '1', 'dfghj', 'xcvbnm', 'dfghj', 'qwertyu'),
(1231, '2019-12-11', 'A', 'AK', 1246, 'Laki - laki', '', '', '', '2018-12-26', 1, 'asdfghj', '1', '1', 'dfghj', 'xcvbnm', 'dfghj', 'qwertyu'),
(1232, '2019-12-11', 'A', 'AK', 1246, 'Laki - laki', '', '', '', '2018-12-26', 1, 'asdfghj', '1', '1', 'dfghj', 'xcvbnm', 'dfghj', 'qwertyu'),
(1234, '2019-12-11', 'A', 'AK', 1246, 'Laki - laki', '', '', '', '2018-12-26', 1, 'asdfghj', '1', '1', 'dfghj', 'xcvbnm', 'dfghj', 'qwertyu'),
(1237, '2019-12-11', 'A', 'AK', 1246, 'Laki - laki', '', '', '', '2018-12-26', 1, 'asdfghj', '1', '1', 'dfghj', 'xcvbnm', 'dfghj', 'qwertyu'),
(1239, '2019-12-11', 'A', 'AK', 1246, 'Laki - laki', '', '', '', '2018-12-26', 1, 'asdfghj', '1', '1', 'dfghj', 'xcvbnm', 'dfghj', 'qwertyu'),
(1254, '2019-12-11', 'A', 'AK', 1246, 'Laki - laki', '', '', '', '2018-12-26', 1, 'asdfghj', '1', '1', 'dfghj', 'xcvbnm', 'dfghj', 'qwertyu'),
(1266, '2019-12-11', 'A', 'AK', 1246, 'Laki - laki', '', '', '', '2018-12-26', 1, 'asdfghj', '1', '1', 'dfghj', 'xcvbnm', 'dfghj', 'qwertyu'),
(1268, '2019-12-11', 'A', 'AK', 1246, 'Laki - laki', '', '', '', '2018-12-26', 1, 'asdfghj', '1', '1', 'dfghj', 'xcvbnm', 'dfghj', 'qwertyu'),
(1297, '2019-12-11', 'A', 'AK', 1246, 'Laki - laki', '', '', '', '2018-12-26', 1, 'asdfghj', '1', '1', 'dfghj', 'xcvbnm', 'dfghj', 'qwertyu'),
(12243, '2019-12-11', 'A', 'AK', 1246, 'Laki - laki', '', '', '', '2018-12-26', 1, 'asdfghj', '1', '1', 'dfghj', 'xcvbnm', 'dfghj', 'qwertyu'),
(12468, '2019-12-19', 'Novie', 'Novie N', 1234567890, 'Perempuan', 'Diploma 3 (D3)', 'Islam', 'qwerty', '2000-12-26', 19, 'asdfghjkl', '2', '4', 'adfjl', 'qwertyuiop', 'asdfghjkl', 'zxcvbnm'),
(123408, '2019-12-11', 'A', 'AK', 1246, 'Laki - laki', '', '', '', '2018-12-26', 1, 'asdfghj', '1', '1', 'dfghj', 'xcvbnm', 'dfghj', 'qwertyu'),
(123409, '2019-12-11', 'A', 'AK', 1246, 'Laki - laki', '', '', '', '2018-12-26', 1, 'asdfghj', '1', '1', 'dfghj', 'xcvbnm', 'dfghj', 'qwertyu'),
(123412, '2019-12-11', 'A', 'AK', 1246, 'Laki - laki', '', '', '', '2018-12-26', 1, 'asdfghj', '1', '1', 'dfghj', 'xcvbnm', 'dfghj', 'qwertyu'),
(123424, '2019-12-11', 'A', 'AK', 1246, 'Laki - laki', '', '', '', '2018-12-26', 1, 'asdfghj', '1', '1', 'dfghj', 'xcvbnm', 'dfghj', 'qwertyu'),
(123490, '2019-12-11', 'A', 'AK', 1246, 'Laki - laki', '', '', '', '2018-12-26', 1, 'asdfghj', '1', '1', 'dfghj', 'xcvbnm', 'dfghj', 'qwertyu'),
(123567, '2019-12-11', 'A', 'AK', 1246, 'Laki - laki', '', '', '', '2018-12-26', 1, 'asdfghj', '1', '1', 'dfghj', 'xcvbnm', 'dfghj', 'qwertyu'),
(1234143, '2019-12-11', 'A', 'AK', 1246, 'Laki - laki', '', '', '', '2018-12-26', 1, 'asdfghj', '1', '1', 'dfghj', 'xcvbnm', 'dfghj', 'qwertyu'),
(1234543, '2019-12-11', 'A', 'AK', 1246, 'Laki - laki', '', '', '', '2018-12-26', 1, 'asdfghj', '1', '1', 'dfghj', 'xcvbnm', 'dfghj', 'qwertyu'),
(12340987, '2019-12-11', 'A', 'AK', 1246, 'Laki - laki', '', '', '', '2018-12-26', 1, 'asdfghj', '1', '1', 'dfghj', 'xcvbnm', 'dfghj', 'qwertyu'),
(1234345678, '2019-12-11', 'A', 'AK', 1246, 'Laki - laki', '', '', '', '2018-12-26', 1, 'asdfghj', '1', '1', 'dfghj', 'xcvbnm', 'dfghj', 'qwertyu');

-- --------------------------------------------------------

--
-- Struktur dari tabel `pembayaran`
--

CREATE TABLE `pembayaran` (
  `no_pembayaran` int(11) NOT NULL,
  `no_rmedis` int(11) DEFAULT NULL,
  `keterangan` varchar(50) DEFAULT NULL,
  `bayar` int(20) DEFAULT NULL,
  `tgl_bayar` date DEFAULT NULL,
  `no_kartu` int(11) DEFAULT NULL,
  `tidakan` varchar(30) DEFAULT NULL,
  `jenis_bayar` varchar(30) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Struktur dari tabel `pengguna`
--

CREATE TABLE `pengguna` (
  `id_user` int(20) NOT NULL,
  `nama_user` varchar(50) DEFAULT NULL,
  `jabatan` varchar(40) DEFAULT NULL,
  `sandi` varchar(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `pengguna`
--

INSERT INTO `pengguna` (`id_user`, `nama_user`, `jabatan`, `sandi`) VALUES
(101010, 'Rizqi ', 'SUPER ADMIN', 'admin'),
(101020, 'Reza K', 'POLI LANSIA', 'lansia'),
(101030, 'Ali', 'POLI REMAJA', 'remaja'),
(101040, 'Agus', 'POLI GIGI', 'gigi'),
(101050, 'Asep', 'POLI BALITA', 'balita'),
(101060, 'Susi', 'Admin Poli Umum', 'umum'),
(101070, 'Susan', 'Admin Poli KIA', 'ibuhamil'),
(101080, 'kiki', 'Super Admin', 'kiki');

-- --------------------------------------------------------

--
-- Struktur dari tabel `poliklinik`
--

CREATE TABLE `poliklinik` (
  `kd_poli` int(11) NOT NULL,
  `nm_poli` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Struktur dari tabel `racik_obat`
--

CREATE TABLE `racik_obat` (
  `no_rmedis` int(11) DEFAULT NULL,
  `resep` varchar(50) DEFAULT NULL,
  `kd_obat` int(11) DEFAULT NULL,
  `keterangan` varchar(50) DEFAULT NULL,
  `dipakai` varchar(50) DEFAULT NULL,
  `tgl_racik` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Struktur dari tabel `regpasien`
--

CREATE TABLE `regpasien` (
  `no_rmedis` int(15) DEFAULT NULL,
  `tgl_daftar` date DEFAULT NULL,
  `kd_poli` int(11) DEFAULT NULL,
  `sistem_bayar` varchar(20) DEFAULT NULL,
  `keterangan` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Struktur dari tabel `tarif_tindakan`
--

CREATE TABLE `tarif_tindakan` (
  `kd_tindakan` int(11) NOT NULL,
  `nama_tidakan` varchar(50) DEFAULT NULL,
  `tarif` int(20) DEFAULT NULL,
  `kd_poli` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Indexes for dumped tables
--

--
-- Indeks untuk tabel `diagnosa`
--
ALTER TABLE `diagnosa`
  ADD KEY `no_rmedis` (`no_rmedis`),
  ADD KEY `kd_poli` (`kd_poli`),
  ADD KEY `no_pembayaran` (`no_pembayaran`);

--
-- Indeks untuk tabel `dokter`
--
ALTER TABLE `dokter`
  ADD KEY `kd_poli` (`kd_poli`);

--
-- Indeks untuk tabel `obat`
--
ALTER TABLE `obat`
  ADD PRIMARY KEY (`kd_obat`);

--
-- Indeks untuk tabel `pasien`
--
ALTER TABLE `pasien`
  ADD PRIMARY KEY (`no_rmedis`);

--
-- Indeks untuk tabel `pembayaran`
--
ALTER TABLE `pembayaran`
  ADD PRIMARY KEY (`no_pembayaran`),
  ADD KEY `no_rmedis` (`no_rmedis`);

--
-- Indeks untuk tabel `pengguna`
--
ALTER TABLE `pengguna`
  ADD PRIMARY KEY (`id_user`);

--
-- Indeks untuk tabel `poliklinik`
--
ALTER TABLE `poliklinik`
  ADD PRIMARY KEY (`kd_poli`);

--
-- Indeks untuk tabel `racik_obat`
--
ALTER TABLE `racik_obat`
  ADD KEY `no_rmedis` (`no_rmedis`),
  ADD KEY `kd_obat` (`kd_obat`);

--
-- Indeks untuk tabel `regpasien`
--
ALTER TABLE `regpasien`
  ADD KEY `no_rmedis` (`no_rmedis`),
  ADD KEY `kd_poli` (`kd_poli`);

--
-- Indeks untuk tabel `tarif_tindakan`
--
ALTER TABLE `tarif_tindakan`
  ADD PRIMARY KEY (`kd_tindakan`),
  ADD KEY `kd_poli` (`kd_poli`);

--
-- Ketidakleluasaan untuk tabel pelimpahan (Dumped Tables)
--

--
-- Ketidakleluasaan untuk tabel `diagnosa`
--
ALTER TABLE `diagnosa`
  ADD CONSTRAINT `diagnosa_ibfk_1` FOREIGN KEY (`no_pembayaran`) REFERENCES `pembayaran` (`no_pembayaran`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `diagnosa_ibfk_2` FOREIGN KEY (`no_rmedis`) REFERENCES `pasien` (`no_rmedis`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `diagnosa_ibfk_3` FOREIGN KEY (`kd_poli`) REFERENCES `poliklinik` (`kd_poli`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Ketidakleluasaan untuk tabel `dokter`
--
ALTER TABLE `dokter`
  ADD CONSTRAINT `dokter_ibfk_1` FOREIGN KEY (`kd_poli`) REFERENCES `poliklinik` (`kd_poli`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Ketidakleluasaan untuk tabel `pembayaran`
--
ALTER TABLE `pembayaran`
  ADD CONSTRAINT `pembayaran_ibfk_1` FOREIGN KEY (`no_rmedis`) REFERENCES `pasien` (`no_rmedis`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Ketidakleluasaan untuk tabel `racik_obat`
--
ALTER TABLE `racik_obat`
  ADD CONSTRAINT `racik_obat_ibfk_1` FOREIGN KEY (`no_rmedis`) REFERENCES `pasien` (`no_rmedis`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `racik_obat_ibfk_2` FOREIGN KEY (`kd_obat`) REFERENCES `obat` (`kd_obat`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Ketidakleluasaan untuk tabel `regpasien`
--
ALTER TABLE `regpasien`
  ADD CONSTRAINT `regpasien_ibfk_1` FOREIGN KEY (`no_rmedis`) REFERENCES `pasien` (`no_rmedis`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `regpasien_ibfk_2` FOREIGN KEY (`kd_poli`) REFERENCES `poliklinik` (`kd_poli`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Ketidakleluasaan untuk tabel `tarif_tindakan`
--
ALTER TABLE `tarif_tindakan`
  ADD CONSTRAINT `tarif_tindakan_ibfk_1` FOREIGN KEY (`kd_poli`) REFERENCES `poliklinik` (`kd_poli`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
