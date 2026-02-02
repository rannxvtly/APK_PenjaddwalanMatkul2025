/*
 Navicat Premium Dump SQL

 Source Server         : DBkiran
 Source Server Type    : MySQL
 Source Server Version : 80030 (8.0.30)
 Source Host           : localhost:3306
 Source Schema         : uasdb04009

 Target Server Type    : MySQL
 Target Server Version : 80030 (8.0.30)
 File Encoding         : 65001

 Date: 02/02/2026 16:10:07
*/

SET NAMES utf8mb4;
SET FOREIGN_KEY_CHECKS = 0;

-- ----------------------------
-- Table structure for tbl_dosen
-- ----------------------------
DROP TABLE IF EXISTS `tbl_dosen`;
CREATE TABLE `tbl_dosen`  (
  `Kd_Dosen` varchar(6) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `Kd_Prodi` varchar(5) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `Nidn_Dosen` varchar(10) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL,
  `Nm_Dosen` varchar(120) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL,
  `Jk_Dosen` varchar(10) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL,
  `Nohp_Dosen` varchar(15) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL,
  `Email_Dosen` varchar(120) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL,
  PRIMARY KEY (`Kd_Dosen`) USING BTREE,
  INDEX `fk_dosen_prodi`(`Kd_Prodi` ASC) USING BTREE,
  CONSTRAINT `fk_dosen_prodi` FOREIGN KEY (`Kd_Prodi`) REFERENCES `tbl_prodi` (`Kd_Prodi`) ON DELETE RESTRICT ON UPDATE CASCADE
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of tbl_dosen
-- ----------------------------
INSERT INTO `tbl_dosen` VALUES ('130001', 'PR002', '0023126504', 'Afzeri', 'Laki-Laki', '081210000001', 'nama@pei.ac.id');
INSERT INTO `tbl_dosen` VALUES ('130003', 'PR003', '0329016701', 'Syafrizal', 'Laki-Laki', '081210000002', 'nama2@pei.ac.id');
INSERT INTO `tbl_dosen` VALUES ('130004', 'PR003', '0402017903', 'Ade Irvan Tauvana', 'Laki-Laki', '081210000003', 'nama3@pei.ac.id');
INSERT INTO `tbl_dosen` VALUES ('130007', 'PR002', '0427065901', 'Janizal', 'Laki-Laki', '081210000004', 'nama4@pei.ac.id');
INSERT INTO `tbl_dosen` VALUES ('130012', 'PR002', '0328116407', 'Slamet Riyadi', 'Laki-Laki', '081210000005', 'nama5@pei.ac.id');
INSERT INTO `tbl_dosen` VALUES ('130023', 'PR003', '0415097102', 'Widodo', 'Laki-Laki', '081210000006', 'nama6@pei.ac.id');
INSERT INTO `tbl_dosen` VALUES ('130026', 'PR002', '0410067608', 'Deni Kurnia', 'Laki-Laki', '081210000007', 'nama7@pei.ac.id');
INSERT INTO `tbl_dosen` VALUES ('130040', 'PR002', '0403115901', 'Adolf Asih Supriyanto', 'Laki-Laki', '081210000008', 'nama8@pei.ac.id');
INSERT INTO `tbl_dosen` VALUES ('130045', 'PR003', '0314117003', 'Fatkur Rachmanu', 'Laki-Laki', '081210000009', 'nama9@pei.ac.id');
INSERT INTO `tbl_dosen` VALUES ('130046', 'PR002', '0427128203', 'Feri Siswoyo Hadisantoso', 'Laki-Laki', '081210000010', 'nama10@pei.ac.id');
INSERT INTO `tbl_dosen` VALUES ('130059', 'PR003', '0411077904', 'Lukman Nulhakim', 'Laki-Laki', '081210000011', 'nama11@pei.ac.id');
INSERT INTO `tbl_dosen` VALUES ('130060', 'PR002', '0407047801', 'Emmanuel Agung Nugroho', 'Laki-Laki', '081210000012', 'nama12@pei.ac.id');
INSERT INTO `tbl_dosen` VALUES ('130073', 'PR004', '0708098901', 'MUHAMMAD NUGRAHA', 'Laki-Laki', '081210000013', 'muhammad.nugraha@pei.ac.id');
INSERT INTO `tbl_dosen` VALUES ('130074', 'PR004', '0417078409', 'PURWANDITO TULUS ASMORO', 'Laki-Laki', '081210000014', 'nama14@pei.ac.id');
INSERT INTO `tbl_dosen` VALUES ('130077', 'PR004', '0412128205', 'MUSAWARMAN', 'LAKI-LAKI', '081210000015', 'musawarman@gmail.com');
INSERT INTO `tbl_dosen` VALUES ('130082', 'PR003', '0403107203', 'Mokhamad Is Subekti', 'Laki-Laki', '081210000016', 'nama16@pei.ac.id');
INSERT INTO `tbl_dosen` VALUES ('130083', 'PR004', '0430068902', 'REHITA HASIAN BATUBARA', 'Perempuan', '081210000017', 'nama17@pei.ac.id');
INSERT INTO `tbl_dosen` VALUES ('130090', 'PR004', '0406107803', 'HALIMIL FATHI', 'Laki-Laki', '081210000018', 'halimil.fathi@pei.ac.id');
INSERT INTO `tbl_dosen` VALUES ('130092', 'PR004', '0408048302', 'DANI USMAN', 'Laki-Laki', '081210000019', 'nama19@pei.ac.id');
INSERT INTO `tbl_dosen` VALUES ('130093', 'PR004', '1005128601', 'HETI MULYANI', 'Perempuan', '081210000020', 'nama20@pei.ac.id');
INSERT INTO `tbl_dosen` VALUES ('130094', 'PR004', '0', 'YUDA MUHAMMAD HAMDANI', 'Laki-Laki', '081210000021', 'nama21@pei.ac.id');
INSERT INTO `tbl_dosen` VALUES ('130096', 'PR004', '0', 'WIDYA ANDAYANI, M. PD', 'Perempuan', '081210000022', 'nama22@pei.ac.id');
INSERT INTO `tbl_dosen` VALUES ('130099', 'PR004', '1017088502', 'RICAK AGUS SETIAWAN', 'Laki-Laki', '081210000023', 'nama23@pei.ac.id');
INSERT INTO `tbl_dosen` VALUES ('130119', 'PR004', '0', 'Sukrina Herman, M.Kom', 'Perempuan', '081210000024', 'nama24@pei.ac.id');
INSERT INTO `tbl_dosen` VALUES ('139999', 'PR004', '123123', 'DIETA', 'PEREMPUAN', '081210000025', 'dieta@gmail.com');
INSERT INTO `tbl_dosen` VALUES ('140001', 'PR005', '1010340', 'Kirana', 'PEREMPUAN', '08553728', 'kirana@gmail.com');
INSERT INTO `tbl_dosen` VALUES ('140002', 'PR004', '34327', 'laras', 'PEREMPUAN', '0866756', 'laras@gmail.com');

-- ----------------------------
-- Table structure for tbl_hari
-- ----------------------------
DROP TABLE IF EXISTS `tbl_hari`;
CREATE TABLE `tbl_hari`  (
  `Id_Hari` varchar(5) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `Nm_Hari` varchar(25) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL,
  PRIMARY KEY (`Id_Hari`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of tbl_hari
-- ----------------------------
INSERT INTO `tbl_hari` VALUES ('HR001', 'SENIN');
INSERT INTO `tbl_hari` VALUES ('HR002', 'SELASA');
INSERT INTO `tbl_hari` VALUES ('HR003', 'RABU');
INSERT INTO `tbl_hari` VALUES ('HR004', 'KAMIS');
INSERT INTO `tbl_hari` VALUES ('HR005', 'Sabtu');

-- ----------------------------
-- Table structure for tbl_jadwal_matkul
-- ----------------------------
DROP TABLE IF EXISTS `tbl_jadwal_matkul`;
CREATE TABLE `tbl_jadwal_matkul`  (
  `KdPengampu` varchar(7) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `Id_Hari` varchar(5) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `JamAwal` time NOT NULL,
  `JamAkhir` time NULL DEFAULT NULL,
  `Kd_Ruangan` varchar(5) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  PRIMARY KEY (`KdPengampu`, `Id_Hari`, `JamAwal`) USING BTREE,
  INDEX `fk_jadwal_hari`(`Id_Hari` ASC) USING BTREE,
  INDEX `fk_jadwal_ruangan`(`Kd_Ruangan` ASC) USING BTREE,
  CONSTRAINT `fk_jadwal_hari` FOREIGN KEY (`Id_Hari`) REFERENCES `tbl_hari` (`Id_Hari`) ON DELETE RESTRICT ON UPDATE CASCADE,
  CONSTRAINT `fk_jadwal_ruangan` FOREIGN KEY (`Kd_Ruangan`) REFERENCES `tbl_ruangkelas` (`Kd_Ruangan`) ON DELETE RESTRICT ON UPDATE CASCADE
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of tbl_jadwal_matkul
-- ----------------------------
INSERT INTO `tbl_jadwal_matkul` VALUES ('PMK0001', 'HR001', '08:00:00', '10:00:00', 'R0002');
INSERT INTO `tbl_jadwal_matkul` VALUES ('PMK0002', 'HR002', '10:00:00', '11:00:00', 'R0003');
INSERT INTO `tbl_jadwal_matkul` VALUES ('PMK0003', 'HR002', '13:00:00', '17:10:00', 'R0003');
INSERT INTO `tbl_jadwal_matkul` VALUES ('PMK0004', 'HR003', '08:00:00', '17:00:00', 'R0003');
INSERT INTO `tbl_jadwal_matkul` VALUES ('PMK0006', 'HR001', '10:30:00', '11:45:00', 'R0001');
INSERT INTO `tbl_jadwal_matkul` VALUES ('PMK0007', 'HR004', '08:00:00', '17:10:00', 'R0002');
INSERT INTO `tbl_jadwal_matkul` VALUES ('PMK0008', 'HR001', '08:00:00', '14:20:00', 'R0002');
INSERT INTO `tbl_jadwal_matkul` VALUES ('PMK0009', 'HR003', '08:00:00', '17:10:00', 'R0004');
INSERT INTO `tbl_jadwal_matkul` VALUES ('PMK0010', 'HR002', '08:00:00', '17:10:00', 'R0004');
INSERT INTO `tbl_jadwal_matkul` VALUES ('PMK0011', 'HR001', '08:00:00', '09:40:00', 'R0004');
INSERT INTO `tbl_jadwal_matkul` VALUES ('PMK0012', 'HR003', '11:20:00', '12:10:00', 'R0001');
INSERT INTO `tbl_jadwal_matkul` VALUES ('PMK0013', 'HR002', '08:00:00', '08:50:00', 'R0002');
INSERT INTO `tbl_jadwal_matkul` VALUES ('PMK0014', 'HR002', '08:50:00', '15:30:00', 'R0002');
INSERT INTO `tbl_jadwal_matkul` VALUES ('PMK0015', 'HR004', '08:00:00', '14:40:00', 'R0004');
INSERT INTO `tbl_jadwal_matkul` VALUES ('PMK0016', 'HR004', '09:40:00', '10:30:00', 'R0003');
INSERT INTO `tbl_jadwal_matkul` VALUES ('PMK0017', 'HR004', '10:30:00', '15:10:00', 'R0003');
INSERT INTO `tbl_jadwal_matkul` VALUES ('PMK0018', 'HR001', '09:40:00', '16:30:00', 'R0003');
INSERT INTO `tbl_jadwal_matkul` VALUES ('PMK0019', 'HR005', '08:50:00', '15:30:00', 'R0003');
INSERT INTO `tbl_jadwal_matkul` VALUES ('PMK0020', 'HR002', '08:00:00', '09:40:00', 'R0001');
INSERT INTO `tbl_jadwal_matkul` VALUES ('PMK0021', 'HR004', '08:00:00', '09:40:00', 'R0003');
INSERT INTO `tbl_jadwal_matkul` VALUES ('PMK0022', 'HR003', '08:00:00', '09:40:00', 'R0001');
INSERT INTO `tbl_jadwal_matkul` VALUES ('PMK0023', 'HR002', '09:40:00', '11:20:00', 'R0001');
INSERT INTO `tbl_jadwal_matkul` VALUES ('PMK0024', 'HR001', '10:30:00', '15:10:00', 'R0004');
INSERT INTO `tbl_jadwal_matkul` VALUES ('PMK0025', 'HR001', '09:40:00', '10:30:00', 'R0004');
INSERT INTO `tbl_jadwal_matkul` VALUES ('PMK0026', 'HR003', '08:00:00', '08:50:00', 'R0002');
INSERT INTO `tbl_jadwal_matkul` VALUES ('PMK0027', 'HR003', '08:50:00', '15:30:00', 'R0002');
INSERT INTO `tbl_jadwal_matkul` VALUES ('PMK0028', 'HR005', '09:40:00', '16:30:00', 'R0002');
INSERT INTO `tbl_jadwal_matkul` VALUES ('PMK0029', 'HR005', '08:50:00', '09:40:00', 'R0002');
INSERT INTO `tbl_jadwal_matkul` VALUES ('PMK0030', 'HR003', '09:40:00', '11:20:00', 'R0001');
INSERT INTO `tbl_jadwal_matkul` VALUES ('PMK0031', 'HR001', '08:00:00', '09:40:00', 'R0001');

-- ----------------------------
-- Table structure for tbl_matakuliah
-- ----------------------------
DROP TABLE IF EXISTS `tbl_matakuliah`;
CREATE TABLE `tbl_matakuliah`  (
  `Kd_Matakuliah` varchar(7) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `Kd_Prodi` varchar(5) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `Nm_Matakuliah` varchar(120) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL,
  `Sks_Matakuliah` int NULL DEFAULT NULL,
  `Teori_Matakuliah` int NULL DEFAULT NULL,
  `Praktek_Matakuliah` int NULL DEFAULT NULL,
  `Semester_Matakuliah` int NULL DEFAULT NULL,
  PRIMARY KEY (`Kd_Matakuliah`) USING BTREE,
  INDEX `fk_matakuliah_prodi`(`Kd_Prodi` ASC) USING BTREE,
  CONSTRAINT `fk_matakuliah_prodi` FOREIGN KEY (`Kd_Prodi`) REFERENCES `tbl_prodi` (`Kd_Prodi`) ON DELETE RESTRICT ON UPDATE CASCADE
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of tbl_matakuliah
-- ----------------------------
INSERT INTO `tbl_matakuliah` VALUES ('MK008', 'PR004', 'Fikih', 2, 2, 0, 3);
INSERT INTO `tbl_matakuliah` VALUES ('MK208', 'PR004', 'Diskrit', 3, 2, 1, 2);
INSERT INTO `tbl_matakuliah` VALUES ('MKK101', 'PR004', 'Pengantar Manufaktur Tekstil', 1, 1, 0, 4);
INSERT INTO `tbl_matakuliah` VALUES ('MKU101', 'PR004', 'Pancasila', 5, 2, 3, 1);
INSERT INTO `tbl_matakuliah` VALUES ('MKU102', 'PR004', 'Kewarganegaraan', 2, 2, 0, 1);
INSERT INTO `tbl_matakuliah` VALUES ('MKU103', 'PR004', 'Bahasa Indonesia', 2, 2, 0, 4);
INSERT INTO `tbl_matakuliah` VALUES ('MKU104', 'PR004', 'Agama', 2, 2, 0, 3);
INSERT INTO `tbl_matakuliah` VALUES ('TRPL101', 'PR004', 'Aljabar Linear', 2, 2, 0, 1);
INSERT INTO `tbl_matakuliah` VALUES ('TRPL102', 'PR004', 'Bahasa Inggris 1', 2, 2, 0, 1);
INSERT INTO `tbl_matakuliah` VALUES ('TRPL103', 'PR004', 'Pengantar UI/UX', 1, 1, 0, 1);
INSERT INTO `tbl_matakuliah` VALUES ('TRPL104', 'PR004', 'Praktikum UI/UX', 2, 0, 2, 1);
INSERT INTO `tbl_matakuliah` VALUES ('TRPL105', 'PR004', 'Pemrograman Dasar', 1, 1, 0, 1);
INSERT INTO `tbl_matakuliah` VALUES ('TRPL106', 'PR004', 'Praktikum Pemrograman Dasar', 2, 0, 2, 1);
INSERT INTO `tbl_matakuliah` VALUES ('TRPL107', 'PR004', 'Workshop Perangkat Lunak Aplikasi', 3, 0, 3, 1);
INSERT INTO `tbl_matakuliah` VALUES ('TRPL108', 'PR004', 'Workshop Sistem Operasi', 2, 0, 2, 1);
INSERT INTO `tbl_matakuliah` VALUES ('TRPL201', 'PR004', 'Bahasa Inggris 2', 2, 2, 0, 2);
INSERT INTO `tbl_matakuliah` VALUES ('TRPL202', 'PR004', 'Kalkulus', 2, 2, 0, 2);
INSERT INTO `tbl_matakuliah` VALUES ('TRPL203', 'PR004', 'Komunikasi Data dan Jaringan Komputer', 1, 1, 0, 2);
INSERT INTO `tbl_matakuliah` VALUES ('TRPL204', 'PR004', 'Pengantar Rekayasa Perangkat Lunak', 2, 2, 0, 2);
INSERT INTO `tbl_matakuliah` VALUES ('TRPL205', 'PR004', 'Praktikum Komunikasi Data dan Jaringan Komputer', 2, 0, 2, 2);
INSERT INTO `tbl_matakuliah` VALUES ('TRPL206', 'PR004', 'Praktikum Sistem Basis Data', 2, 0, 2, 2);
INSERT INTO `tbl_matakuliah` VALUES ('TRPL207', 'PR004', 'Praktikum Struktur Data dan Algoritma', 2, 0, 2, 2);
INSERT INTO `tbl_matakuliah` VALUES ('TRPL208', 'PR004', 'Sistem Basis Data', 1, 1, 0, 2);
INSERT INTO `tbl_matakuliah` VALUES ('TRPL209', 'PR004', 'Struktur Data dan Algoritma', 1, 1, 0, 2);
INSERT INTO `tbl_matakuliah` VALUES ('TRPL210', 'PR004', 'Teknik Presentasi', 2, 2, 0, 2);
INSERT INTO `tbl_matakuliah` VALUES ('TRPL211', 'PR004', 'Workshop Pemrograman Web 1', 3, 0, 3, 2);
INSERT INTO `tbl_matakuliah` VALUES ('TRPL301', 'PR004', 'Analisis & Desain Perangkat Lunak', 1, 1, 0, 3);
INSERT INTO `tbl_matakuliah` VALUES ('TRPL302', 'PR004', 'Bahasa Inggris 3', 2, 2, 0, 3);
INSERT INTO `tbl_matakuliah` VALUES ('TRPL303', 'PR004', 'Teori Dasar Keamanan Komputer', 2, 2, 0, 3);
INSERT INTO `tbl_matakuliah` VALUES ('TRPL304', 'PR004', 'Matematika Diskrit', 2, 2, 0, 3);
INSERT INTO `tbl_matakuliah` VALUES ('TRPL305', 'PR004', 'Pemrograman Berorientasi Objek', 1, 1, 0, 3);
INSERT INTO `tbl_matakuliah` VALUES ('TRPL306', 'PR004', 'Praktikum Analisis & Desain Perangkat Lunak', 2, 0, 2, 3);
INSERT INTO `tbl_matakuliah` VALUES ('TRPL307', 'PR004', 'Praktikum Dasar Keamanan Komputer', 1, 0, 1, 3);
INSERT INTO `tbl_matakuliah` VALUES ('TRPL308', 'PR004', 'Praktikum Pemrograman Berorientasi Objek', 2, 0, 2, 3);
INSERT INTO `tbl_matakuliah` VALUES ('TRPL309', 'PR004', 'Workshop Pemrograman Visual', 2, 0, 2, 3);
INSERT INTO `tbl_matakuliah` VALUES ('TRPL310', 'PR004', 'Workshop Pemrograman Web 2', 3, 0, 3, 3);
INSERT INTO `tbl_matakuliah` VALUES ('TRPL401', 'PR004', 'Bahasa Inggris 4', 2, 2, 0, 4);
INSERT INTO `tbl_matakuliah` VALUES ('TRPL402', 'PR004', 'Etika Profesi', 2, 2, 0, 4);
INSERT INTO `tbl_matakuliah` VALUES ('TRPL403', 'PR004', 'Workshop Cloud Computing', 2, 0, 2, 4);
INSERT INTO `tbl_matakuliah` VALUES ('TRPL404', 'PR004', 'Workshop Keamanan Basis Data', 2, 0, 2, 4);
INSERT INTO `tbl_matakuliah` VALUES ('TRPL405', 'PR004', 'Workshop Pemrograman Android 1', 3, 0, 3, 4);
INSERT INTO `tbl_matakuliah` VALUES ('TRPL406', 'PR004', 'Workshop Pemrograman Web 3', 3, 0, 3, 4);
INSERT INTO `tbl_matakuliah` VALUES ('TRPL501', 'PR004', 'Bahasa Inggris 5', 2, 2, 0, 5);
INSERT INTO `tbl_matakuliah` VALUES ('TRPL502', 'PR004', 'Metodologi Penelitian', 2, 2, 0, 5);
INSERT INTO `tbl_matakuliah` VALUES ('TRPL503', 'PR004', 'Manajemen Kearsipan', 2, 2, 0, 5);
INSERT INTO `tbl_matakuliah` VALUES ('TRPL504', 'PR004', 'Pengujian Perangkat Lunak', 2, 2, 0, 5);
INSERT INTO `tbl_matakuliah` VALUES ('TRPL505', 'PR004', 'Projek Manufaktur Tekstil', 1, 0, 1, 5);
INSERT INTO `tbl_matakuliah` VALUES ('TRPL506', 'PR004', 'Statistik', 3, 3, 0, 5);
INSERT INTO `tbl_matakuliah` VALUES ('TRPL507', 'PR004', 'Workshop Keamanan Perangkat Lunak', 2, 0, 2, 5);
INSERT INTO `tbl_matakuliah` VALUES ('TRPL508', 'PR004', 'Workshop Pemrograman Android 2', 3, 0, 3, 5);
INSERT INTO `tbl_matakuliah` VALUES ('TRPL509', 'PR004', 'Workshop Pemrograman Web 4', 3, 0, 3, 5);
INSERT INTO `tbl_matakuliah` VALUES ('TRPL601', 'PR004', 'Data Mining', 1, 1, 0, 6);
INSERT INTO `tbl_matakuliah` VALUES ('TRPL602', 'PR004', 'Enterprise Resource Planning', 1, 1, 0, 6);
INSERT INTO `tbl_matakuliah` VALUES ('TRPL603', 'PR004', 'Praktikum Data Mining', 2, 0, 2, 6);
INSERT INTO `tbl_matakuliah` VALUES ('TRPL604', 'PR004', 'Praktikum Enterprise Resource Planning', 2, 0, 2, 6);
INSERT INTO `tbl_matakuliah` VALUES ('TRPL605', 'PR004', 'Tugas Akhir 1', 4, 0, 4, 6);
INSERT INTO `tbl_matakuliah` VALUES ('TRPL606', 'PR004', 'Workshop Pemrograman IOS', 2, 0, 2, 6);
INSERT INTO `tbl_matakuliah` VALUES ('TRPL607', 'PR004', 'Workshop Sistem Terdistribusi', 2, 0, 2, 6);
INSERT INTO `tbl_matakuliah` VALUES ('TRPL701', 'PR004', 'Manajemen Proyek', 4, 1, 4, 7);
INSERT INTO `tbl_matakuliah` VALUES ('TRPL702', 'PR004', 'Technopreuneur', 2, 2, 0, 7);
INSERT INTO `tbl_matakuliah` VALUES ('TRPL703', 'PR004', 'Tugas Akhir 2', 8, 0, 8, 7);
INSERT INTO `tbl_matakuliah` VALUES ('TRPL801', 'PR004', 'Internship / Magang Industri', 20, 0, 20, 8);

-- ----------------------------
-- Table structure for tbl_pengampu_matakuliah
-- ----------------------------
DROP TABLE IF EXISTS `tbl_pengampu_matakuliah`;
CREATE TABLE `tbl_pengampu_matakuliah`  (
  `KdPengampu` varchar(7) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `Kd_Dosen` varchar(6) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL,
  `Kd_Matakuliah` varchar(7) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL,
  `Nama_Kelas` varchar(60) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL,
  `Tahun_Akademik` varchar(11) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL,
  PRIMARY KEY (`KdPengampu`) USING BTREE,
  INDEX `fk_pengampu_dosen`(`Kd_Dosen` ASC) USING BTREE,
  INDEX `fk_pengampu_matakuliah`(`Kd_Matakuliah` ASC) USING BTREE,
  CONSTRAINT `fk_pengampu_dosen` FOREIGN KEY (`Kd_Dosen`) REFERENCES `tbl_dosen` (`Kd_Dosen`) ON DELETE RESTRICT ON UPDATE CASCADE,
  CONSTRAINT `fk_pengampu_matakuliah` FOREIGN KEY (`Kd_Matakuliah`) REFERENCES `tbl_matakuliah` (`Kd_Matakuliah`) ON DELETE RESTRICT ON UPDATE CASCADE
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of tbl_pengampu_matakuliah
-- ----------------------------
INSERT INTO `tbl_pengampu_matakuliah` VALUES ('PMK0001', '130090', 'TRPL108', 'Reguler', '2023/2024');
INSERT INTO `tbl_pengampu_matakuliah` VALUES ('PMK0002', '130090', 'TRPL303', 'Reguler', '2023/2024');
INSERT INTO `tbl_pengampu_matakuliah` VALUES ('PMK0003', '130090', 'TRPL307', 'Reguler', '2023/2024');
INSERT INTO `tbl_pengampu_matakuliah` VALUES ('PMK0004', '130090', 'TRPL309', 'Reguler', '2023/2024');
INSERT INTO `tbl_pengampu_matakuliah` VALUES ('PMK0005', '130090', 'TRPL503', 'Reguler', '2023/2024');
INSERT INTO `tbl_pengampu_matakuliah` VALUES ('PMK0006', '130090', 'TRPL507', 'Reguler', '2023/2024');
INSERT INTO `tbl_pengampu_matakuliah` VALUES ('PMK0007', '130077', 'TRPL405', 'Reguler', '2024/2025');
INSERT INTO `tbl_pengampu_matakuliah` VALUES ('PMK0008', '130077', 'TRPL606', 'Reguler', '2024/2025');
INSERT INTO `tbl_pengampu_matakuliah` VALUES ('PMK0009', '130073', 'TRPL211', 'Reguler', '2024/2025');
INSERT INTO `tbl_pengampu_matakuliah` VALUES ('PMK0010', '130073', 'TRPL406', 'Reguler', '2024/2025');
INSERT INTO `tbl_pengampu_matakuliah` VALUES ('PMK0011', '130099', 'TRPL204', 'Reguler', '2024/2025');
INSERT INTO `tbl_pengampu_matakuliah` VALUES ('PMK0012', '130099', 'MKK101', 'Reguler', '2024/2025');
INSERT INTO `tbl_pengampu_matakuliah` VALUES ('PMK0013', '130099', 'TRPL602', 'Reguler', '2024/2025');
INSERT INTO `tbl_pengampu_matakuliah` VALUES ('PMK0014', '130099', 'TRPL604', 'Reguler', '2024/2025');
INSERT INTO `tbl_pengampu_matakuliah` VALUES ('PMK0015', '130099', 'TRPL607', 'Reguler', '2024/2025');
INSERT INTO `tbl_pengampu_matakuliah` VALUES ('PMK0016', '130090', 'TRPL203', 'Reguler', '2024/2025');
INSERT INTO `tbl_pengampu_matakuliah` VALUES ('PMK0017', '130090', 'TRPL205', 'Reguler', '2024/2025');
INSERT INTO `tbl_pengampu_matakuliah` VALUES ('PMK0018', '130090', 'TRPL403', 'Reguler', '2024/2025');
INSERT INTO `tbl_pengampu_matakuliah` VALUES ('PMK0019', '130090', 'TRPL404', 'Reguler', '2024/2025');
INSERT INTO `tbl_pengampu_matakuliah` VALUES ('PMK0020', '130096', 'TRPL201', 'Reguler', '2024/2025');
INSERT INTO `tbl_pengampu_matakuliah` VALUES ('PMK0021', '130096', 'TRPL210', 'Reguler', '2024/2025');
INSERT INTO `tbl_pengampu_matakuliah` VALUES ('PMK0022', '130096', 'TRPL401', 'Reguler', '2024/2025');
INSERT INTO `tbl_pengampu_matakuliah` VALUES ('PMK0023', '130093', 'TRPL202', 'Reguler', '2024/2025');
INSERT INTO `tbl_pengampu_matakuliah` VALUES ('PMK0024', '130093', 'TRPL207', 'Reguler', '2024/2025');
INSERT INTO `tbl_pengampu_matakuliah` VALUES ('PMK0025', '130093', 'TRPL209', 'Reguler', '2024/2025');
INSERT INTO `tbl_pengampu_matakuliah` VALUES ('PMK0026', '130093', 'TRPL601', 'Reguler', '2024/2025');
INSERT INTO `tbl_pengampu_matakuliah` VALUES ('PMK0027', '130093', 'TRPL603', 'Reguler', '2024/2025');
INSERT INTO `tbl_pengampu_matakuliah` VALUES ('PMK0028', '130119', 'TRPL206', 'Reguler', '2022/2023');
INSERT INTO `tbl_pengampu_matakuliah` VALUES ('PMK0029', '130119', 'TRPL208', 'Reguler', '2022/2023');
INSERT INTO `tbl_pengampu_matakuliah` VALUES ('PMK0030', '130119', 'MKU103', 'Reguler', '2024/2025');
INSERT INTO `tbl_pengampu_matakuliah` VALUES ('PMK0031', '130119', 'TRPL402', 'Reguler', '2024/2025');
INSERT INTO `tbl_pengampu_matakuliah` VALUES ('PMK0032', '130099', 'MKK101', 'Reguler', '2024/2025');
INSERT INTO `tbl_pengampu_matakuliah` VALUES ('PMK0034', '130119', 'TRPL206', 'Reguler', '2024/2025');

-- ----------------------------
-- Table structure for tbl_prodi
-- ----------------------------
DROP TABLE IF EXISTS `tbl_prodi`;
CREATE TABLE `tbl_prodi`  (
  `Kd_Prodi` varchar(5) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `Nm_Prodi` varchar(120) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  PRIMARY KEY (`Kd_Prodi`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of tbl_prodi
-- ----------------------------
INSERT INTO `tbl_prodi` VALUES ('PR001', 'TEKNOLOGI LISTRIK (D3)');
INSERT INTO `tbl_prodi` VALUES ('PR002', 'TEKNOLOGI MEKATRONIKA (D3)');
INSERT INTO `tbl_prodi` VALUES ('PR003', 'TEKNOLOGI REKAYASA MANUFACTUR (D4)');
INSERT INTO `tbl_prodi` VALUES ('PR004', 'TEKNOLOGI REKAYASA PERANGKAT LUNAK (D4)');
INSERT INTO `tbl_prodi` VALUES ('PR005', 'TEKNOLOGI REKAYASA MEKATRONIKA (D4)');

-- ----------------------------
-- Table structure for tbl_ruangkelas
-- ----------------------------
DROP TABLE IF EXISTS `tbl_ruangkelas`;
CREATE TABLE `tbl_ruangkelas`  (
  `Kd_Ruangan` varchar(5) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `Nm_Ruangan` varchar(120) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL,
  `Jml_Kapasitas` int NULL DEFAULT NULL,
  PRIMARY KEY (`Kd_Ruangan`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of tbl_ruangkelas
-- ----------------------------
INSERT INTO `tbl_ruangkelas` VALUES ('R0001', 'RUANG KELAS B5', 30);
INSERT INTO `tbl_ruangkelas` VALUES ('R0002', 'RUANG KELAS B7-LAB KOMPUTER', 30);
INSERT INTO `tbl_ruangkelas` VALUES ('R0003', 'RUANG KELAS B8-LAB KOMPUTER', 30);
INSERT INTO `tbl_ruangkelas` VALUES ('R0004', 'RUANG KELAS B4-LAB KOMPUTER', 30);

-- ----------------------------
-- Table structure for tbl_user
-- ----------------------------
DROP TABLE IF EXISTS `tbl_user`;
CREATE TABLE `tbl_user`  (
  `Id_User` char(3) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `Nm_User` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `Pass_User` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `Level_User` enum('Administrator','Mahasiswa') CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  PRIMARY KEY (`Id_User`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of tbl_user
-- ----------------------------
INSERT INTO `tbl_user` VALUES ('001', 'Kirana', '@123', 'Administrator');
INSERT INTO `tbl_user` VALUES ('002', 'Larasati', '@123', 'Mahasiswa');

-- ----------------------------
-- View structure for v_dosen
-- ----------------------------
DROP VIEW IF EXISTS `v_dosen`;
CREATE ALGORITHM = UNDEFINED SQL SECURITY DEFINER VIEW `v_dosen` AS select `tbl_dosen`.`Kd_Dosen` AS `Kd_Dosen`,`tbl_dosen`.`Nidn_Dosen` AS `Nidn_Dosen`,`tbl_dosen`.`Nm_Dosen` AS `Nm_Dosen`,`tbl_dosen`.`Jk_Dosen` AS `Jk_Dosen`,`tbl_dosen`.`Nohp_Dosen` AS `Nohp_Dosen`,`tbl_dosen`.`Email_Dosen` AS `Email_Dosen`,`tbl_prodi`.`Kd_Prodi` AS `Kd_Prodi`,`tbl_prodi`.`Nm_Prodi` AS `Nm_Prodi` from (`tbl_dosen` join `tbl_prodi` on((`tbl_dosen`.`Kd_Prodi` = `tbl_prodi`.`Kd_Prodi`)));

-- ----------------------------
-- View structure for v_dosen_pengampu
-- ----------------------------
DROP VIEW IF EXISTS `v_dosen_pengampu`;
CREATE ALGORITHM = UNDEFINED SQL SECURITY DEFINER VIEW `v_dosen_pengampu` AS select `tbl_pengampu_matakuliah`.`KdPengampu` AS `KdPengampu`,`tbl_pengampu_matakuliah`.`Tahun_Akademik` AS `Tahun_Akademik`,`tbl_pengampu_matakuliah`.`Nama_Kelas` AS `Nama_Kelas`,`tbl_dosen`.`Kd_Dosen` AS `Kd_Dosen`,`tbl_dosen`.`Nidn_Dosen` AS `Nidn_Dosen`,`tbl_dosen`.`Nm_Dosen` AS `Nm_Dosen`,`tbl_matakuliah`.`Kd_Matakuliah` AS `Kd_Matakuliah`,`tbl_matakuliah`.`Nm_Matakuliah` AS `Nm_Matakuliah`,`tbl_matakuliah`.`Semester_Matakuliah` AS `Semester_Matakuliah`,`tbl_prodi`.`Kd_Prodi` AS `Kd_Prodi`,`tbl_prodi`.`Nm_Prodi` AS `Nm_Prodi`,(case when ((`tbl_matakuliah`.`Semester_Matakuliah` % 2) = 1) then 'Ganjil' else 'Genap' end) AS `Status_Semester` from (((`tbl_pengampu_matakuliah` join `tbl_dosen` on((`tbl_pengampu_matakuliah`.`Kd_Dosen` = `tbl_dosen`.`Kd_Dosen`))) join `tbl_matakuliah` on((`tbl_pengampu_matakuliah`.`Kd_Matakuliah` = `tbl_matakuliah`.`Kd_Matakuliah`))) join `tbl_prodi` on((`tbl_matakuliah`.`Kd_Prodi` = `tbl_prodi`.`Kd_Prodi`)));

-- ----------------------------
-- View structure for v_matakuliah_semester
-- ----------------------------
DROP VIEW IF EXISTS `v_matakuliah_semester`;
CREATE ALGORITHM = UNDEFINED SQL SECURITY DEFINER VIEW `v_matakuliah_semester` AS select `tbl_matakuliah`.`Kd_Matakuliah` AS `Kd_Matakuliah`,`tbl_matakuliah`.`Nm_Matakuliah` AS `Nm_Matakuliah`,`tbl_matakuliah`.`Praktek_Matakuliah` AS `Praktek_Matakuliah`,`tbl_matakuliah`.`Semester_Matakuliah` AS `Semester_Matakuliah`,`tbl_matakuliah`.`Sks_Matakuliah` AS `Sks_Matakuliah`,`tbl_matakuliah`.`Teori_Matakuliah` AS `Teori_Matakuliah`,`tbl_prodi`.`Kd_Prodi` AS `Kd_Prodi`,`tbl_prodi`.`Nm_Prodi` AS `Nm_Prodi`,cast((case when ((`tbl_matakuliah`.`Semester_Matakuliah` % 2) = 1) then 'Ganjil' else 'Genap' end) as char charset utf8mb4) AS `Status_Semester` from (`tbl_matakuliah` join `tbl_prodi` on((`tbl_matakuliah`.`Kd_Prodi` = `tbl_prodi`.`Kd_Prodi`)));

-- ----------------------------
-- View structure for v_penjadwalan_matakuliah
-- ----------------------------
DROP VIEW IF EXISTS `v_penjadwalan_matakuliah`;
CREATE ALGORITHM = UNDEFINED SQL SECURITY DEFINER VIEW `v_penjadwalan_matakuliah` AS select `tbl_pengampu_matakuliah`.`Tahun_Akademik` AS `Tahun_Akademik`,`tbl_pengampu_matakuliah`.`Nama_Kelas` AS `Nama_Kelas`,`tbl_dosen`.`Kd_Dosen` AS `Kd_Dosen`,`tbl_dosen`.`Nm_Dosen` AS `Nm_Dosen`,`tbl_matakuliah`.`Kd_Matakuliah` AS `Kd_Matakuliah`,`tbl_matakuliah`.`Nm_Matakuliah` AS `Nm_Matakuliah`,`tbl_matakuliah`.`Semester_Matakuliah` AS `Semester_Matakuliah`,`tbl_prodi`.`Kd_Prodi` AS `Kd_Prodi`,`tbl_prodi`.`Nm_Prodi` AS `Nm_Prodi`,`tbl_hari`.`Id_Hari` AS `Id_Hari`,`tbl_hari`.`Nm_Hari` AS `Nm_Hari`,`tbl_jadwal_matkul`.`JamAwal` AS `JamAwal`,`tbl_jadwal_matkul`.`JamAkhir` AS `JamAkhir`,`tbl_ruangkelas`.`Kd_Ruangan` AS `Kd_Ruangan`,`tbl_ruangkelas`.`Nm_Ruangan` AS `Nm_Ruangan`,(case when ((`tbl_matakuliah`.`Semester_Matakuliah` % 2) = 1) then 'Ganjil' else 'Genap' end) AS `Status_Semester` from ((((((`tbl_jadwal_matkul` join `tbl_pengampu_matakuliah` on((`tbl_jadwal_matkul`.`KdPengampu` = `tbl_pengampu_matakuliah`.`KdPengampu`))) join `tbl_dosen` on((`tbl_pengampu_matakuliah`.`Kd_Dosen` = `tbl_dosen`.`Kd_Dosen`))) join `tbl_matakuliah` on((`tbl_pengampu_matakuliah`.`Kd_Matakuliah` = `tbl_matakuliah`.`Kd_Matakuliah`))) join `tbl_prodi` on((`tbl_matakuliah`.`Kd_Prodi` = `tbl_prodi`.`Kd_Prodi`))) join `tbl_hari` on((`tbl_jadwal_matkul`.`Id_Hari` = `tbl_hari`.`Id_Hari`))) join `tbl_ruangkelas` on((`tbl_jadwal_matkul`.`Kd_Ruangan` = `tbl_ruangkelas`.`Kd_Ruangan`)));

SET FOREIGN_KEY_CHECKS = 1;
