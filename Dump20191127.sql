-- MySQL dump 10.13  Distrib 8.0.15, for Win64 (x86_64)
--
-- Host: localhost    Database: qlpk
-- ------------------------------------------------------
-- Server version	8.0.15

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
 SET NAMES utf8 ;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `adnroid`
--

DROP TABLE IF EXISTS `adnroid`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `adnroid` (
  `id` char(45) NOT NULL,
  `chap` varchar(45) DEFAULT NULL,
  `pos` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `adnroid`
--

LOCK TABLES `adnroid` WRITE;
/*!40000 ALTER TABLE `adnroid` DISABLE KEYS */;
INSERT INTO `adnroid` VALUES ('456','1',12),('456','1',12),('456','3',12),('456','4',12);
/*!40000 ALTER TABLE `adnroid` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `benh`
--

DROP TABLE IF EXISTS `benh`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `benh` (
  `MaLB` char(10) NOT NULL,
  `TenLoaiBenh` varchar(50) DEFAULT NULL,
  `TrieuChung` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`MaLB`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `benh`
--

LOCK TABLES `benh` WRITE;
/*!40000 ALTER TABLE `benh` DISABLE KEYS */;
INSERT INTO `benh` VALUES ('B001','Viêm Họng','Đau họng, ho, rát cổ họng'),('B002','Viêm Xoan','Chảy dịch mũi, hắt hơi, nghẹt mũi'),('B003','Ngáy ban đêm','Mất ngủ, ngủ không ngon, mơ nhiều'),('B004','Nấm tai','Ngứa sâu trong tai, cảm giác sưng đầy trong tai'),('B005','Viêm dây thanh','Mất tiếng, nói nhanh mệt, không thể nói lớn');
/*!40000 ALTER TABLE `benh` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `benhnhan`
--

DROP TABLE IF EXISTS `benhnhan`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `benhnhan` (
  `MaBN` char(10) NOT NULL,
  `HoTen` varchar(50) DEFAULT NULL,
  `NgaySinh` date DEFAULT NULL,
  `GioiTinh` varchar(10) DEFAULT NULL,
  `DiaChi` varchar(50) DEFAULT NULL,
  `SDT` char(15) DEFAULT NULL,
  PRIMARY KEY (`MaBN`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `benhnhan`
--

LOCK TABLES `benhnhan` WRITE;
/*!40000 ALTER TABLE `benhnhan` DISABLE KEYS */;
INSERT INTO `benhnhan` VALUES ('BN001','Nguyễn Văn Tý','2002-04-04','Nam','Thanh Hóa','071821842'),('BN002','Nguyễn Văn A','1890-05-02','Nam','Quảng Quải','096145185'),('BN003','Ngô Bá Khá','1994-09-02','Nam','Quảng Ninh','076149136'),('BN004','Nguyễn Thị Thùy Dương','1999-07-22','Nữ','Cần Đước, Long An','07517583');
/*!40000 ALTER TABLE `benhnhan` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `cachdung`
--

DROP TABLE IF EXISTS `cachdung`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `cachdung` (
  `MaCD` char(10) NOT NULL,
  `CachDung` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`MaCD`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cachdung`
--

LOCK TABLES `cachdung` WRITE;
/*!40000 ALTER TABLE `cachdung` DISABLE KEYS */;
INSERT INTO `cachdung` VALUES ('CD001','Uống trước ăn'),('CD002','Ngày 3 cử'),('CD003','Uống sau ăn'),('CD004','Ngậm đến khi tan hết');
/*!40000 ALTER TABLE `cachdung` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `donthuoc`
--

DROP TABLE IF EXISTS `donthuoc`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `donthuoc` (
  `MaPK` char(10) NOT NULL,
  `MaThuoc` char(10) NOT NULL,
  `SoLuong` int(11) DEFAULT NULL,
  `MaCD` char(10) DEFAULT NULL,
  PRIMARY KEY (`MaPK`,`MaThuoc`),
  KEY `thuoc_idx` (`MaThuoc`),
  KEY `fk_cachdung_idx` (`MaCD`),
  KEY `fk_pk_idx` (`MaPK`),
  CONSTRAINT `fk_cachdung` FOREIGN KEY (`MaCD`) REFERENCES `cachdung` (`MaCD`),
  CONSTRAINT `fk_pk` FOREIGN KEY (`MaPK`) REFERENCES `phieukham` (`MaPK`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `donthuoc`
--

LOCK TABLES `donthuoc` WRITE;
/*!40000 ALTER TABLE `donthuoc` DISABLE KEYS */;
INSERT INTO `donthuoc` VALUES ('PK001','T001',14,'CD001'),('PK001','T002',5,'CD004'),('PK001','T003',12,'CD002'),('PK001','T004',17,'CD003');
/*!40000 ALTER TABLE `donthuoc` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `donvitinh`
--

DROP TABLE IF EXISTS `donvitinh`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `donvitinh` (
  `MaDV` char(10) NOT NULL,
  `TenDonVi` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`MaDV`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `donvitinh`
--

LOCK TABLES `donvitinh` WRITE;
/*!40000 ALTER TABLE `donvitinh` DISABLE KEYS */;
INSERT INTO `donvitinh` VALUES ('DV001','Viên'),('DV002','Chai');
/*!40000 ALTER TABLE `donvitinh` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `hoadon`
--

DROP TABLE IF EXISTS `hoadon`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `hoadon` (
  `MaHD` char(10) NOT NULL,
  `MaPK` char(10) DEFAULT NULL,
  `NgayLap` date DEFAULT NULL,
  `TienThuoc` int(11) DEFAULT NULL,
  `TongTien` int(11) DEFAULT NULL,
  PRIMARY KEY (`MaHD`),
  KEY `fk_hd_pk_idx` (`MaPK`),
  CONSTRAINT `fk_hd_pk` FOREIGN KEY (`MaPK`) REFERENCES `phieukham` (`MaPK`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `hoadon`
--

LOCK TABLES `hoadon` WRITE;
/*!40000 ALTER TABLE `hoadon` DISABLE KEYS */;
INSERT INTO `hoadon` VALUES ('HD001','Pk001','2019-07-03',944000,974000);
/*!40000 ALTER TABLE `hoadon` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `lichsudangnhap`
--

DROP TABLE IF EXISTS `lichsudangnhap`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `lichsudangnhap` (
  `MaUS` char(10) NOT NULL,
  `ThoiGianDN` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `lichsudangnhap`
--

LOCK TABLES `lichsudangnhap` WRITE;
/*!40000 ALTER TABLE `lichsudangnhap` DISABLE KEYS */;
INSERT INTO `lichsudangnhap` VALUES ('US001','2019-07-02 20:31:26'),('US002','2019-07-04 02:47:16'),('US001','2019-07-04 07:54:22'),('US001','2019-07-04 08:02:13'),('US001','2019-07-04 08:33:57'),('US001','2019-07-04 11:28:01'),('US001','2019-07-28 18:05:34'),('US001','2019-07-28 18:06:59'),('US001','2019-10-08 10:08:15'),('US001','2019-11-26 12:54:30');
/*!40000 ALTER TABLE `lichsudangnhap` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `nhanvien`
--

DROP TABLE IF EXISTS `nhanvien`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `nhanvien` (
  `MaNV` char(10) NOT NULL,
  `HoTen` varchar(50) DEFAULT NULL,
  `GioiTinh` varchar(10) DEFAULT NULL,
  `NgaySinh` date DEFAULT NULL,
  `DiaChi` varchar(50) DEFAULT NULL,
  `SDT` char(15) DEFAULT NULL,
  `ChucVu` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`MaNV`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `nhanvien`
--

LOCK TABLES `nhanvien` WRITE;
/*!40000 ALTER TABLE `nhanvien` DISABLE KEYS */;
INSERT INTO `nhanvien` VALUES ('NV001','Trần Hữu Lộc','Nam','1999-05-21','Ấp 2, Long Định, Cần Đước, Long  An','0971244421','Giám Đốc'),('NV002','Bùi Tiến Thành Long','Nam','2019-07-02','Linh Trung, Thủ Đức','0981878486','Y Tá'),('NV003','Nguyễn Trọng Khanh','Nam','1998-12-21','Long An','098765797','Bác Sỹ'),('NV004','Lê Minh Tuấn','Nam','1997-06-23','Q6, Tp Hồ Chí Minh','098765877','Bác Sỹ'),('NV005','Nguyễn Văn Minh','Nữ','1999-07-02','Thuận An, Bình Dương','098123434','Nhà Thuốc');
/*!40000 ALTER TABLE `nhanvien` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `phieukham`
--

DROP TABLE IF EXISTS `phieukham`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `phieukham` (
  `MaPK` char(10) NOT NULL,
  `MaBN` char(10) DEFAULT NULL,
  `MaNV` char(10) DEFAULT NULL,
  `MaLB` char(10) DEFAULT NULL,
  `NgayKham` date DEFAULT NULL,
  PRIMARY KEY (`MaPK`),
  KEY `fk_pk_nv_idx` (`MaNV`),
  KEY `fk_pk_bn_idx` (`MaBN`),
  KEY `fk_pk_lb_idx` (`MaLB`),
  CONSTRAINT `fk_pk_bn` FOREIGN KEY (`MaBN`) REFERENCES `benhnhan` (`MaBN`),
  CONSTRAINT `fk_pk_lb` FOREIGN KEY (`MaLB`) REFERENCES `benh` (`MaLB`),
  CONSTRAINT `fk_pk_nv` FOREIGN KEY (`MaNV`) REFERENCES `nhanvien` (`MaNV`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `phieukham`
--

LOCK TABLES `phieukham` WRITE;
/*!40000 ALTER TABLE `phieukham` DISABLE KEYS */;
INSERT INTO `phieukham` VALUES ('PK001','BN003','NV001','B003','2019-07-03'),('PK002','BN001','NV004','B003','2019-07-04'),('PK003','BN002','NV005','B005','2019-07-04');
/*!40000 ALTER TABLE `phieukham` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `quyenhan`
--

DROP TABLE IF EXISTS `quyenhan`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `quyenhan` (
  `MaQH` char(10) NOT NULL,
  `TenQuyenHan` varchar(50) DEFAULT NULL,
  `NoiDung` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`MaQH`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `quyenhan`
--

LOCK TABLES `quyenhan` WRITE;
/*!40000 ALTER TABLE `quyenhan` DISABLE KEYS */;
INSERT INTO `quyenhan` VALUES ('QH001','Admin','Full'),('QH002','Nhân Viên','Chức năng trong bệnh viện');
/*!40000 ALTER TABLE `quyenhan` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `thamso`
--

DROP TABLE IF EXISTS `thamso`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `thamso` (
  `MaTS` char(10) NOT NULL,
  `TenThamSo` varchar(50) DEFAULT NULL,
  `GiaTri` int(11) DEFAULT NULL,
  PRIMARY KEY (`MaTS`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `thamso`
--

LOCK TABLES `thamso` WRITE;
/*!40000 ALTER TABLE `thamso` DISABLE KEYS */;
INSERT INTO `thamso` VALUES ('TS001','Tiền Khám',30000),('TS002','Số Bệnh Nhân Tối Đa',40);
/*!40000 ALTER TABLE `thamso` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `thuoc`
--

DROP TABLE IF EXISTS `thuoc`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `thuoc` (
  `MaThuoc` char(10) NOT NULL,
  `TenThuoc` varchar(50) DEFAULT NULL,
  `MaDV` char(10) DEFAULT NULL,
  `NSX` date DEFAULT NULL,
  `HSD` date DEFAULT NULL,
  `DonGia` int(11) DEFAULT NULL,
  PRIMARY KEY (`MaThuoc`),
  KEY `fk_thuoc_dv_idx` (`MaDV`),
  CONSTRAINT `fk_thuoc_dv` FOREIGN KEY (`MaDV`) REFERENCES `donvitinh` (`MaDV`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `thuoc`
--

LOCK TABLES `thuoc` WRITE;
/*!40000 ALTER TABLE `thuoc` DISABLE KEYS */;
INSERT INTO `thuoc` VALUES ('T001','Panadon','DV001','2018-07-02','2019-07-02',2000),('T002','Kháng Sinh','DV002','2018-02-04','2019-02-04',20000),('T003','Paracetamol','DV001','2018-07-02','2019-07-02',17000),('T004','Thuốc Tê','DV002','2018-07-02','2019-07-02',36000);
/*!40000 ALTER TABLE `thuoc` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `users`
--

DROP TABLE IF EXISTS `users`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `users` (
  `MaUS` char(10) NOT NULL,
  `TaiKhoan` char(45) DEFAULT NULL,
  `MatKhau` char(45) DEFAULT NULL,
  `MaNV` char(10) DEFAULT NULL,
  `MaQH` char(10) DEFAULT NULL,
  PRIMARY KEY (`MaUS`),
  KEY `fk_us_nv_idx` (`MaNV`),
  KEY `fk_us_qh_idx` (`MaQH`),
  CONSTRAINT `fk_us_nv` FOREIGN KEY (`MaNV`) REFERENCES `nhanvien` (`MaNV`) ON UPDATE RESTRICT,
  CONSTRAINT `fk_us_qh` FOREIGN KEY (`MaQH`) REFERENCES `quyenhan` (`MaQH`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `users`
--

LOCK TABLES `users` WRITE;
/*!40000 ALTER TABLE `users` DISABLE KEYS */;
INSERT INTO `users` VALUES ('US001','admin','admin','NV001','QH001'),('US002','thuantran','123456','NV005','QH002');
/*!40000 ALTER TABLE `users` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2019-11-27 23:04:35
