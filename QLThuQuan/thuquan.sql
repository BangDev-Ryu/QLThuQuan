CREATE TABLE `thanh_vien` (
  `id` int PRIMARY KEY AUTO_INCREMENT,
  `username` varchar(255),
  `password` varchar(255),
  `fullname` varchar(255),
  `khoa` varchar(255),
  `nganh` varchar(255),
  `trang_thai` varchar(255),
  `is_exist` tinyint
);

CREATE TABLE `thiet_bi` (
  `id` int PRIMARY KEY AUTO_INCREMENT,
  `name` varchar(255),
  `loai` varchar(255),
  `trang_thai` varchar(255),
  `is_exist` tinyint
);

CREATE TABLE `phieu_muon` (
  `id` int PRIMARY KEY AUTO_INCREMENT,
  `id_thiet_bi` int,
  `id_thanh_vien` int,
  `trang_thai` varchar(255),
  `loai` varchar(255),
  `ngay_muon` datetime,
  `ngay_han_tra` datetime,
  `is_exist` tinyint
);

CREATE TABLE `phieu_phat` (
  `id` int PRIMARY KEY AUTO_INCREMENT,
  `id_thanh_vien` int,
  `hinh_thuc_xu_ly` varchar(255),
  `tien_boi_thuong` int,
  `ngay_phat` datetime,
  `ngay_het_han` datetime,
  `ly_do` varchar(255),
  `trang_thai` varchar(255),
  `is_exist` tinyint
);

CREATE TABLE `luot_vao` (
  `id` int PRIMARY KEY AUTO_INCREMENT,
  `id_thanh_vien` int,
  `ngay_vao` datetime
);

ALTER TABLE `phieu_muon` ADD FOREIGN KEY (`id_thiet_bi`) REFERENCES `thiet_bi` (`id`);

ALTER TABLE `luot_vao` ADD FOREIGN KEY (`id_thanh_vien`) REFERENCES `thanh_vien` (`id`);

ALTER TABLE `phieu_phat` ADD FOREIGN KEY (`id_thanh_vien`) REFERENCES `thanh_vien` (`id`);

ALTER TABLE `phieu_muon` ADD FOREIGN KEY (`id_thanh_vien`) REFERENCES `thanh_vien` (`id`);
