-- phpMyAdmin SQL Dump
-- version 5.2.2
-- https://www.phpmyadmin.net/
--
-- Máy chủ: localhost
-- Thời gian đã tạo: Th5 02, 2025 lúc 04:24 AM
-- Phiên bản máy phục vụ: 10.4.32-MariaDB
-- Phiên bản PHP: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Cơ sở dữ liệu: `thuquan`
--

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `ct_phieu_muon`
--

CREATE TABLE `ct_phieu_muon` (
  `id_phieu_muon` int(11) NOT NULL,
  `id_thiet_bi` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `luot_vao`
--

CREATE TABLE `luot_vao` (
  `id` int(11) NOT NULL,
  `id_thanh_vien` int(11) DEFAULT NULL,
  `ngay_vao` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `phieu_muon`
--

CREATE TABLE `phieu_muon` (
  `id` int(11) NOT NULL,
  `id_thanh_vien` int(11) DEFAULT NULL,
  `trang_thai` varchar(255) DEFAULT NULL,
  `loai` varchar(255) DEFAULT NULL,
  `ngay_muon` datetime DEFAULT NULL,
  `is_exist` tinyint(4) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `phieu_phat`
--

CREATE TABLE `phieu_phat` (
  `id` int(11) NOT NULL,
  `id_thanh_vien` int(11) DEFAULT NULL,
  `hinh_thuc_xu_ly` varchar(255) DEFAULT NULL,
  `tien_boi_thuong` int(11) DEFAULT NULL,
  `trang_thai` varchar(255) DEFAULT NULL,
  `is_exist` tinyint(4) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `thanh_vien`
--

CREATE TABLE `thanh_vien` (
  `id` int(11) NOT NULL,
  `username` varchar(255) DEFAULT NULL,
  `password` varchar(255) DEFAULT NULL,
  `fullname` varchar(255) DEFAULT NULL,
  `khoa` varchar(255) DEFAULT NULL,
  `nganh` varchar(255) DEFAULT NULL,
  `trang_thai` varchar(255) DEFAULT NULL,
  `is_exist` tinyint(4) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Đang đổ dữ liệu cho bảng `thanh_vien`
--

INSERT INTO `thanh_vien` (`id`, `username`, `password`, `fullname`, `khoa`, `nganh`, `trang_thai`, `is_exist`) VALUES
(1, 'client', '123123', 'client', 'cntt', 'ktpm', 'Hoạt động', 1),
(2, 'bang', '123123', 'bang', 'cntt', 'httt', 'Hoạt động', 1),
(3, 'test', '123456', 'test', 'hehe', 'huhu', 'Hoạt động', 0),
(4, 'thanhvien4', '444444', 'tv4', '444', '44', 'Hoạt động', 1);

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `thiet_bi`
--

CREATE TABLE `thiet_bi` (
  `id` int(11) NOT NULL,
  `name` varchar(255) DEFAULT NULL,
  `loai` varchar(255) DEFAULT NULL,
  `is_exist` tinyint(4) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Chỉ mục cho các bảng đã đổ
--

--
-- Chỉ mục cho bảng `ct_phieu_muon`
--
ALTER TABLE `ct_phieu_muon`
  ADD PRIMARY KEY (`id_phieu_muon`,`id_thiet_bi`),
  ADD KEY `id_thiet_bi` (`id_thiet_bi`);

--
-- Chỉ mục cho bảng `luot_vao`
--
ALTER TABLE `luot_vao`
  ADD PRIMARY KEY (`id`),
  ADD KEY `id_thanh_vien` (`id_thanh_vien`);

--
-- Chỉ mục cho bảng `phieu_muon`
--
ALTER TABLE `phieu_muon`
  ADD PRIMARY KEY (`id`),
  ADD KEY `id_thanh_vien` (`id_thanh_vien`);

--
-- Chỉ mục cho bảng `phieu_phat`
--
ALTER TABLE `phieu_phat`
  ADD PRIMARY KEY (`id`),
  ADD KEY `id_thanh_vien` (`id_thanh_vien`);

--
-- Chỉ mục cho bảng `thanh_vien`
--
ALTER TABLE `thanh_vien`
  ADD PRIMARY KEY (`id`);

--
-- Chỉ mục cho bảng `thiet_bi`
--
ALTER TABLE `thiet_bi`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT cho các bảng đã đổ
--

--
-- AUTO_INCREMENT cho bảng `luot_vao`
--
ALTER TABLE `luot_vao`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT cho bảng `phieu_muon`
--
ALTER TABLE `phieu_muon`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT cho bảng `phieu_phat`
--
ALTER TABLE `phieu_phat`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT cho bảng `thanh_vien`
--
ALTER TABLE `thanh_vien`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT cho bảng `thiet_bi`
--
ALTER TABLE `thiet_bi`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- Ràng buộc đối với các bảng kết xuất
--

--
-- Ràng buộc cho bảng `ct_phieu_muon`
--
ALTER TABLE `ct_phieu_muon`
  ADD CONSTRAINT `ct_phieu_muon_ibfk_1` FOREIGN KEY (`id_phieu_muon`) REFERENCES `phieu_muon` (`id`),
  ADD CONSTRAINT `ct_phieu_muon_ibfk_2` FOREIGN KEY (`id_thiet_bi`) REFERENCES `thiet_bi` (`id`);

--
-- Ràng buộc cho bảng `luot_vao`
--
ALTER TABLE `luot_vao`
  ADD CONSTRAINT `luot_vao_ibfk_1` FOREIGN KEY (`id_thanh_vien`) REFERENCES `thanh_vien` (`id`);

--
-- Ràng buộc cho bảng `phieu_muon`
--
ALTER TABLE `phieu_muon`
  ADD CONSTRAINT `phieu_muon_ibfk_1` FOREIGN KEY (`id_thanh_vien`) REFERENCES `thanh_vien` (`id`);

--
-- Ràng buộc cho bảng `phieu_phat`
--
ALTER TABLE `phieu_phat`
  ADD CONSTRAINT `phieu_phat_ibfk_1` FOREIGN KEY (`id_thanh_vien`) REFERENCES `thanh_vien` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
