use master
if db_id('qLSanBay') IS NOT NULL
	drop database qlSanBay;

create database qlSanBay;
go
use qlSanBay;
go
CREATE TABLE KhachHang (
  IdKhachHang INT IDENTITY(1,1) PRIMARY KEY,
  HoTen VARCHAR(30),
  CMND VARCHAR(30),
  MatKhau VARCHAR(30)
);

INSERT INTO KhachHang
Values
('Tran Van Dung',  1231, 333560),
('Ha Van Duc',  1232, 33356),
('Nguyen Tien Dung',  1233, 333562),
('Nguyen Tien Luat',  1234, 333563),
('Ha Dang Khoa',  1235, 333564),
('Ho Viet Khang',  1236, 333565),
('Tien Dung',  1237, 333566),
('Ho Van Nhan',  1238, 333567),
('Trinh Dung',  1239, 333568),
('Nguyen Van Tai',  1230, 3335)


CREATE TABLE ChuyenBay (
  IdChuyenBay INT PRIMARY KEY,
  NoiKhoiHanh VARCHAR(30),
  NoiHaCanh VARCHAR(30),
  TGKhoiHanh DATETIME,
  TGDen DATETIME,
  GiaVe DECIMAL(10, 2),
  TongChoNgoi INT,
  IdChuyenBayKhuHoi INT NULL,
  FOREIGN KEY(IdChuyenBayKhuHoi) REFERENCES ChuyenBay(IdChuyenBay),
  KhuHoi BIT
);


insert into ChuyenBay
values
(0, '', '', '01-01-1900', '01-01-1900',0, 0, NULL, 0),
(110, 'SG', 'HN', '05-30-2024 15:00:00:000', '05-30-2024 18:00:00:000',1000000, 50, NULL, 0),
(111, 'SG', 'HN', '05-30-2024 15:00:00:000', '05-30-2024 18:00:00:000',1000000, 50, NULL, 0),
(112, 'SG', 'HN', '05-30-2024 15:00:00:000', '05-30-2024 18:00:00:000',1000000, 50, NULL, 0),
(113, 'SG', 'HN', '05-30-2024 15:00:00:000', '05-30-2024 18:00:00:000',1000000, 50, NULL, 0),
(114, 'SG', 'HN', '05-20-2024 10:00:00:000', '05-20-2024 13:00:00:000',1000000, 50, NULL, 0),
(115, 'SG', 'HN', '05-20-2024 10:00:00:000', '05-20-2024 13:00:00:000',1000000, 50, NULL, 0),
(116, 'SG', 'HN', '05-20-2024 10:00:00:000', '05-20-2024 13:00:00:000',1000000, 50, NULL, 0),
(117, 'SG', 'HN', '05-20-2024 10:00:00:000', '05-20-2024 13:00:00:000',1000000, 50, NULL, 0),
(118, 'SG', 'HN', '05-20-2024 10:00:00:000', '05-20-2024 13:00:00:000',1000000, 50, NULL, 0),
(119, 'SG', 'HN', '05-15-2024 08:00:00:000', '05-15-2024 11:00:00:000',1000000, 50, NULL, 0),
(120, 'SG', 'HN', '05-15-2024 08:00:00:000', '05-15-2024 11:00:00:000',1000000, 50, NULL, 0),
(121, 'SG', 'HN', '05-15-2024 08:00:00:000', '05-15-2024 11:00:00:000',1000000, 50, NULL, 0),
(122, 'SG', 'HN', '05-15-2024 08:00:00:000', '05-15-2024 11:00:00:000',1000000, 50, NULL, 0),
(123, 'SG', 'HN', '05-05-2024 23:00:00:000', '05-05-2024 02:00:00:000',1000000, 50, NULL, 0),
(124, 'SG', 'HN', '05-05-2024 23:00:00:000', '05-05-2024 02:00:00:000',1000000, 50, NULL, 0),
(125, 'SG', 'HN', '05-05-2024 23:00:00:000', '05-05-2024 02:00:00:000',1000000, 50, NULL, 0),
(126, 'SG', 'HN', '05-05-2024 23:00:00:000', '05-05-2024 02:00:00:000',1000000, 50, NULL, 0),
(127, 'SG', 'HN', '05-05-2024 23:00:00:000', '05-05-2024 02:00:00:000',1000000, 50, NULL, 0),

(129, 'HN', 'SG', '04-30-2024 15:00:00:000', '04-30-2024 18:00:00:000',1000000, 50, 110, 1),
(130, 'HN', 'SG', '04-30-2024 15:00:00:000', '04-30-2024 18:00:00:000',1000000, 50, 111, 1),
(131, 'HN', 'SG', '04-30-2024 15:00:00:000', '04-30-2024 18:00:00:000',1000000, 50, 112, 1),
(132, 'HN', 'SG', '04-30-2024 15:00:00:000', '04-30-2024 18:00:00:000',1000000, 50, 113, 1),
(133, 'HN', 'SG', '04-20-2024 10:00:00:000', '04-20-2024 13:00:00:000',1000000, 50, 114, 1),
(134, 'HN', 'SG', '04-20-2024 10:00:00:000', '04-20-2024 13:00:00:000',1000000, 50, 115, 1),
(135, 'HN', 'SG', '04-20-2024 10:00:00:000', '04-20-2024 13:00:00:000',1000000, 50, 116, 1),
(136, 'HN', 'SG', '04-20-2024 10:00:00:000', '04-20-2024 13:00:00:000',1000000, 50, 117, 1),
(137, 'HN', 'SG', '04-20-2024 10:00:00:000', '04-20-2024 13:00:00:000',1000000, 50, 118, 1),
(138, 'HN', 'SG', '04-15-2024 08:00:00:000', '04-15-2024 11:00:00:000',1000000, 50, 119, 1),
(139, 'HN', 'SG', '04-15-2024 08:00:00:000', '04-15-2024 11:00:00:000',1000000, 50, 120, 1),
(140, 'HN', 'SG', '04-15-2024 08:00:00:000', '04-15-2024 11:00:00:000',1000000, 50, 121, 1),
(141, 'HN', 'SG', '04-05-2024 23:00:00:000', '04-05-2024 02:00:00:000',1000000, 50, 122, 1),
(142, 'HN', 'SG', '04-15-2024 08:00:00:000', '04-15-2024 11:00:00:000',1000000, 50, 123, 1),
(143, 'HN', 'SG', '04-05-2024 23:00:00:000', '04-05-2024 02:00:00:000',1000000, 50, 124, 1),
(144, 'HN', 'SG', '04-05-2024 23:00:00:000', '04-05-2024 02:00:00:000',1000000, 50, 125, 1),
(145, 'HN', 'SG', '04-05-2024 23:00:00:000', '04-05-2024 02:00:00:000',1000000, 50, 126, 1),
(146, 'HN', 'SG', '04-05-2024 23:00:00:000', '04-05-2024 02:00:00:000',1000000, 50, 127, 1),

(229, 'HN', 'SG', '04-30-2024 15:00:00:000', '04-30-2024 18:00:00:000',1000000, 50, NULL, 0),
(230, 'HN', 'SG', '04-30-2024 15:00:00:000', '04-30-2024 18:00:00:000',1000000, 50, NULL, 0),
(231, 'HN', 'SG', '04-30-2024 15:00:00:000', '04-30-2024 18:00:00:000',1000000, 50, NULL, 0),
(232, 'HN', 'SG', '04-30-2024 15:00:00:000', '04-30-2024 18:00:00:000',1000000, 50, NULL, 0),
(233, 'HN', 'SG', '04-20-2024 10:00:00:000', '04-20-2024 13:00:00:000',1000000, 50, NULL, 0),
(234, 'HN', 'SG', '04-20-2024 10:00:00:000', '04-20-2024 13:00:00:000',1000000, 50, NULL, 0),
(235, 'HN', 'SG', '04-20-2024 10:00:00:000', '04-20-2024 13:00:00:000',1000000, 50, NULL, 0),
(236, 'HN', 'SG', '04-20-2024 10:00:00:000', '04-20-2024 13:00:00:000',1000000, 50, NULL, 0),
(237, 'HN', 'SG', '04-20-2024 10:00:00:000', '04-20-2024 13:00:00:000',1000000, 50, NULL, 0),
(238, 'HN', 'SG', '04-15-2024 08:00:00:000', '04-15-2024 11:00:00:000',1000000, 50, NULL, 0),
(239, 'HN', 'SG', '04-15-2024 08:00:00:000', '04-15-2024 11:00:00:000',1000000, 50, NULL, 0),
(240, 'HN', 'SG', '04-15-2024 08:00:00:000', '04-15-2024 11:00:00:000',1000000, 50, NULL, 0),
(241, 'HN', 'SG', '04-05-2024 23:00:00:000', '04-05-2024 02:00:00:000',1000000, 50, NULL, 0),
(242, 'HN', 'SG', '04-15-2024 08:00:00:000', '04-15-2024 11:00:00:000',1000000, 50, NULL, 0),
(243, 'HN', 'SG', '04-05-2024 23:00:00:000', '04-05-2024 02:00:00:000',1000000, 50, NULL, 0),
(244, 'HN', 'SG', '04-05-2024 23:00:00:000', '04-05-2024 02:00:00:000',1000000, 50, NULL, 0),
(245, 'HN', 'SG', '04-05-2024 23:00:00:000', '04-05-2024 02:00:00:000',1000000, 50, NULL, 0),
(246, 'HN', 'SG', '04-05-2024 23:00:00:000', '04-05-2024 02:00:00:000',1000000, 50, NULL, 0)




CREATE TABLE GheNgoi(
  IdGheChuyenBay INT IDENTITY(10,1) PRIMARY KEY,
  IdChuyenBay INT,
  MaGhe VARCHAR(30),
  TinhTrangDat nvarchar(30),
  CONSTRAINT IDCB_GB_CB_IDCB FOREIGN KEY (IdChuyenBay) REFERENCES ChuyenBay (IdChuyenBay),
  LoaiGhe nvarchar(30)
);



INSERT INTO GheNgoi
Values
(129, 'A00', '0', 'Thuong Gia'),
(129, 'A01', '0', 'Thuong Gia'),
(129, 'A02', '0', 'Thuong Gia'),
(129, 'A03', '0', 'Thuong Gia'),
(129, 'A04', '0', 'Thuong Gia'),
(129, 'A05', '0', 'Pho Thong'),
(129, 'A06', '0', 'Pho Thong'),
(129, 'A07', '0', 'Pho Thong'),
(129, 'A08', '0', 'Pho Thong'),
(129, 'A09', '0', 'Pho Thong'),
(130, 'A00', '0', 'Tiet Kiem'),
(130, 'A01', '0', 'Tiet Kiem'),
(130, 'A02', '0', 'Tiet Kiem'),
(130, 'A03', '0', 'Tiet Kiem'),
(130, 'A04', '0', 'Tiet Kiem'),
(130, 'A05', '0', 'Tiet Kiem'),
(130, 'A06', '0', 'Tiet Kiem'),
(130, 'A07', '0', 'Tiet Kiem'),
(130, 'A08', '0', 'Tiet Kiem'),
(130, 'A09', '0', 'Tiet Kiem'),
(131, 'A00', '0', 'Thuong Gia'),
(131, 'A01', '0', 'Thuong Gia'),
(131, 'A02', '0', 'Thuong Gia'),
(131, 'A03', '0', 'Thuong Gia'),
(131, 'A04', '0', 'Thuong Gia'),
(131, 'A05', '0', 'Pho Thong'),
(131, 'A06', '0', 'Pho Thong'),
(131, 'A07', '0', 'Pho Thong'),
(131, 'A08', '0', 'Pho Thong'),
(131, 'A09', '0', 'Pho Thong'),
(132, 'A00', '0', 'Tiet Kiem'),
(132, 'A01', '0', 'Tiet Kiem'),
(132, 'A02', '0', 'Tiet Kiem'),
(132, 'A03', '0', 'Tiet Kiem'),
(132, 'A04', '0', 'Tiet Kiem'),
(132, 'A05', '0', 'Tiet Kiem'),
(132, 'A06', '0', 'Tiet Kiem'),
(132, 'A07', '0', 'Tiet Kiem'),
(132, 'A08', '0', 'Tiet Kiem'),
(132, 'A09', '0', 'Tiet Kiem'),
(133, 'A00', '0', 'Thuong Gia'),
(133, 'A01', '0', 'Thuong Gia'),
(133, 'A02', '0', 'Thuong Gia'),
(133, 'A03', '0', 'Thuong Gia'),
(133, 'A04', '0', 'Thuong Gia'),
(133, 'A05', '0', 'Pho Thong'),
(133, 'A06', '0', 'Pho Thong'),
(133, 'A07', '0', 'Pho Thong'),
(133, 'A08', '0', 'Pho Thong'),
(133, 'A09', '0', 'Pho Thong'),
(134, 'A00', '0', 'Tiet Kiem'),
(134, 'A01', '0', 'Tiet Kiem'),
(134, 'A02', '0', 'Tiet Kiem'),
(134, 'A03', '0', 'Tiet Kiem'),
(134, 'A04', '0', 'Tiet Kiem'),
(134, 'A05', '0', 'Tiet Kiem'),
(134, 'A06', '0', 'Tiet Kiem'),
(134, 'A07', '0', 'Tiet Kiem'),
(134, 'A08', '0', 'Tiet Kiem'),
(134, 'A09', '0', 'Tiet Kiem'),
(135, 'A00', '0', 'Thuong Gia'),
(135, 'A01', '0', 'Thuong Gia'),
(135, 'A02', '0', 'Thuong Gia'),
(135, 'A03', '0', 'Thuong Gia'),
(135, 'A04', '0', 'Thuong Gia'),
(135, 'A05', '0', 'Pho Thong'),
(135, 'A06', '0', 'Pho Thong'),
(135, 'A07', '0', 'Pho Thong'),
(135, 'A08', '0', 'Pho Thong'),
(135, 'A09', '0', 'Pho Thong'),
(136, 'A00', '0', 'Tiet Kiem'),
(136, 'A01', '0', 'Tiet Kiem'),
(136, 'A02', '0', 'Tiet Kiem'),
(136, 'A03', '0', 'Tiet Kiem'),
(136, 'A04', '0', 'Tiet Kiem'),
(136, 'A05', '0', 'Tiet Kiem'),
(136, 'A06', '0', 'Tiet Kiem'),
(136, 'A07', '0', 'Tiet Kiem'),
(136, 'A08', '0', 'Tiet Kiem'),
(136, 'A09', '0', 'Tiet Kiem'),
(137, 'A00', '0', 'Thuong Gia'),
(137, 'A01', '0', 'Thuong Gia'),
(137, 'A02', '0', 'Thuong Gia'),
(137, 'A03', '0', 'Thuong Gia'),
(137, 'A04', '0', 'Thuong Gia'),
(137, 'A05', '0', 'Pho Thong'),
(137, 'A06', '0', 'Pho Thong'),
(137, 'A07', '0', 'Pho Thong'),
(137, 'A08', '0', 'Pho Thong'),
(137, 'A09', '0', 'Pho Thong'),
(138, 'A00', '0', 'Tiet Kiem'),
(138, 'A01', '0', 'Tiet Kiem'),
(138, 'A02', '0', 'Tiet Kiem'),
(138, 'A03', '0', 'Tiet Kiem'),
(138, 'A04', '0', 'Tiet Kiem'),
(138, 'A05', '0', 'Tiet Kiem'),
(138, 'A06', '0', 'Tiet Kiem'),
(138, 'A07', '0', 'Tiet Kiem'),
(138, 'A08', '0', 'Tiet Kiem'),
(138, 'A09', '0', 'Tiet Kiem'),
(139, 'A00', '0', 'Thuong Gia'),
(139, 'A01', '0', 'Thuong Gia'),
(139, 'A02', '0', 'Thuong Gia'),
(139, 'A03', '0', 'Thuong Gia'),
(139, 'A04', '0', 'Thuong Gia'),
(139, 'A05', '0', 'Pho Thong'),
(139, 'A06', '0', 'Pho Thong'),
(139, 'A07', '0', 'Pho Thong'),
(139, 'A08', '0', 'Pho Thong'),
(139, 'A09', '0', 'Pho Thong'),
(140, 'A00', '0', 'Tiet Kiem'),
(140, 'A01', '0', 'Tiet Kiem'),
(140, 'A02', '0', 'Tiet Kiem'),
(140, 'A03', '0', 'Tiet Kiem'),
(140, 'A04', '0', 'Tiet Kiem'),
(140, 'A05', '0', 'Tiet Kiem'),
(140, 'A06', '0', 'Tiet Kiem'),
(140, 'A07', '0', 'Tiet Kiem'),
(140, 'A08', '0', 'Tiet Kiem'),
(140, 'A09', '0', 'Tiet Kiem'),
(141, 'A00', '0', 'Thuong Gia'),
(141, 'A01', '0', 'Thuong Gia'),
(141, 'A02', '0', 'Thuong Gia'),
(141, 'A03', '0', 'Thuong Gia'),
(141, 'A04', '0', 'Thuong Gia'),
(141, 'A05', '0', 'Pho Thong'),
(141, 'A06', '0', 'Pho Thong'),
(141, 'A07', '0', 'Pho Thong'),
(141, 'A08', '0', 'Pho Thong'),
(141, 'A09', '0', 'Pho Thong'),
(142, 'A00', '0', 'Tiet Kiem'),
(142, 'A01', '0', 'Tiet Kiem'),
(142, 'A02', '0', 'Tiet Kiem'),
(142, 'A03', '0', 'Tiet Kiem'),
(142, 'A04', '0', 'Tiet Kiem'),
(142, 'A05', '0', 'Tiet Kiem'),
(142, 'A06', '0', 'Tiet Kiem'),
(142, 'A07', '0', 'Tiet Kiem'),
(142, 'A08', '0', 'Tiet Kiem'),
(142, 'A09', '0', 'Tiet Kiem'),
(143, 'A00', '0', 'Thuong Gia'),
(143, 'A01', '0', 'Thuong Gia'),
(143, 'A02', '0', 'Thuong Gia'),
(143, 'A03', '0', 'Thuong Gia'),
(143, 'A04', '0', 'Thuong Gia'),
(143, 'A05', '0', 'Pho Thong'),
(143, 'A06', '0', 'Pho Thong'),
(143, 'A07', '0', 'Pho Thong'),
(143, 'A08', '0', 'Pho Thong'),
(143, 'A09', '0', 'Pho Thong'),
(144, 'A00', '0', 'Tiet Kiem'),
(144, 'A01', '0', 'Tiet Kiem'),
(144, 'A02', '0', 'Tiet Kiem'),
(144, 'A03', '0', 'Tiet Kiem'),
(144, 'A04', '0', 'Tiet Kiem'),
(144, 'A05', '0', 'Tiet Kiem'),
(144, 'A06', '0', 'Tiet Kiem'),
(144, 'A07', '0', 'Tiet Kiem'),
(144, 'A08', '0', 'Tiet Kiem'),
(144, 'A09', '0', 'Tiet Kiem'),
(145, 'A00', '0', 'Thuong Gia'),
(145, 'A01', '0', 'Thuong Gia'),
(145, 'A02', '0', 'Thuong Gia'),
(145, 'A03', '0', 'Thuong Gia'),
(145, 'A04', '0', 'Thuong Gia'),
(145, 'A05', '0', 'Pho Thong'),
(145, 'A06', '0', 'Pho Thong'),
(145, 'A07', '0', 'Pho Thong'),
(145, 'A08', '0', 'Pho Thong'),
(145, 'A09', '0', 'Pho Thong'),
(146, 'A00', '0', 'Tiet Kiem'),
(146, 'A01', '0', 'Tiet Kiem'),
(146, 'A02', '0', 'Tiet Kiem'),
(146, 'A03', '0', 'Tiet Kiem'),
(146, 'A04', '0', 'Tiet Kiem'),
(146, 'A05', '0', 'Tiet Kiem'),
(146, 'A06', '0', 'Tiet Kiem'),
(146, 'A07', '0', 'Tiet Kiem'),
(146, 'A08', '0', 'Tiet Kiem'),
(146, 'A09', '0', 'Tiet Kiem'),
(110, 'A00', '0', 'Thuong Gia'),
(110, 'A01', '0', 'Thuong Gia'),
(110, 'A02', '0', 'Thuong Gia'),
(110, 'A03', '0', 'Thuong Gia'),
(110, 'A04', '0', 'Thuong Gia'),
(110, 'A05', '0', 'Pho Thong'),
(110, 'A06', '0', 'Pho Thong'),
(110, 'A07', '0', 'Pho Thong'),
(110, 'A08', '0', 'Pho Thong'),
(110, 'A09', '0', 'Pho Thong'),
(111, 'A00', '0', 'Tiet Kiem'),
(111, 'A01', '0', 'Tiet Kiem'),
(111, 'A02', '0', 'Tiet Kiem'),
(111, 'A03', '0', 'Tiet Kiem'),
(111, 'A04', '0', 'Tiet Kiem'),
(111, 'A05', '0', 'Tiet Kiem'),
(111, 'A06', '0', 'Tiet Kiem'),
(111, 'A07', '0', 'Tiet Kiem'),
(111, 'A08', '0', 'Tiet Kiem'),
(111, 'A09', '0', 'Tiet Kiem'),
(112, 'A00', '0', 'Thuong Gia'),
(112, 'A01', '0', 'Thuong Gia'),
(112, 'A02', '0', 'Thuong Gia'),
(112, 'A03', '0', 'Thuong Gia'),
(112, 'A04', '0', 'Thuong Gia'),
(112, 'A05', '0', 'Pho Thong'),
(112, 'A06', '0', 'Pho Thong'),
(112, 'A07', '0', 'Pho Thong'),
(112, 'A08', '0', 'Pho Thong'),
(112, 'A09', '0', 'Pho Thong'),
(113, 'A00', '0', 'Tiet Kiem'),
(113, 'A01', '0', 'Tiet Kiem'),
(113, 'A02', '0', 'Tiet Kiem'),
(113, 'A03', '0', 'Tiet Kiem'),
(113, 'A04', '0', 'Tiet Kiem'),
(113, 'A05', '0', 'Tiet Kiem'),
(113, 'A06', '0', 'Tiet Kiem'),
(113, 'A07', '0', 'Tiet Kiem'),
(113, 'A08', '0', 'Tiet Kiem'),
(113, 'A09', '0', 'Tiet Kiem'),
(114, 'A00', '0', 'Thuong Gia'),
(114, 'A01', '0', 'Thuong Gia'),
(114, 'A02', '0', 'Thuong Gia'),
(114, 'A03', '0', 'Thuong Gia'),
(114, 'A04', '0', 'Thuong Gia'),
(114, 'A05', '0', 'Pho Thong'),
(114, 'A06', '0', 'Pho Thong'),
(114, 'A07', '0', 'Pho Thong'),
(114, 'A08', '0', 'Pho Thong'),
(114, 'A09', '0', 'Pho Thong'),
(115, 'A00', '0', 'Tiet Kiem'),
(115, 'A01', '0', 'Tiet Kiem'),
(115, 'A02', '0', 'Tiet Kiem'),
(115, 'A03', '0', 'Tiet Kiem'),
(115, 'A04', '0', 'Tiet Kiem'),
(115, 'A05', '0', 'Tiet Kiem'),
(115, 'A06', '0', 'Tiet Kiem'),
(115, 'A07', '0', 'Tiet Kiem'),
(115, 'A08', '0', 'Tiet Kiem'),
(115, 'A09', '0', 'Tiet Kiem'),
(116, 'A00', '0', 'Thuong Gia'),
(116, 'A01', '0', 'Thuong Gia'),
(116, 'A02', '0', 'Thuong Gia'),
(116, 'A03', '0', 'Thuong Gia'),
(116, 'A04', '0', 'Thuong Gia'),
(116, 'A05', '0', 'Pho Thong'),
(116, 'A06', '0', 'Pho Thong'),
(116, 'A07', '0', 'Pho Thong'),
(116, 'A08', '0', 'Pho Thong'),
(116, 'A09', '0', 'Pho Thong'),
(117, 'A00', '0', 'Tiet Kiem'),
(117, 'A01', '0', 'Tiet Kiem'),
(117, 'A02', '0', 'Tiet Kiem'),
(117, 'A03', '0', 'Tiet Kiem'),
(117, 'A04', '0', 'Tiet Kiem'),
(117, 'A05', '0', 'Tiet Kiem'),
(117, 'A06', '0', 'Tiet Kiem'),
(117, 'A07', '0', 'Tiet Kiem'),
(117, 'A08', '0', 'Tiet Kiem'),
(117, 'A09', '0', 'Tiet Kiem'),
(118, 'A00', '0', 'Thuong Gia'),
(118, 'A01', '0', 'Thuong Gia'),
(118, 'A02', '0', 'Thuong Gia'),
(118, 'A03', '0', 'Thuong Gia'),
(118, 'A04', '0', 'Thuong Gia'),
(118, 'A05', '0', 'Pho Thong'),
(118, 'A06', '0', 'Pho Thong'),
(118, 'A07', '0', 'Pho Thong'),
(118, 'A08', '0', 'Pho Thong'),
(118, 'A09', '0', 'Pho Thong'),
(119, 'A00', '0', 'Tiet Kiem'),
(119, 'A01', '0', 'Tiet Kiem'),
(119, 'A02', '0', 'Tiet Kiem'),
(119, 'A03', '0', 'Tiet Kiem'),
(119, 'A04', '0', 'Tiet Kiem'),
(119, 'A05', '0', 'Tiet Kiem'),
(119, 'A06', '0', 'Tiet Kiem'),
(119, 'A07', '0', 'Tiet Kiem'),
(119, 'A08', '0', 'Tiet Kiem'),
(119, 'A09', '0', 'Tiet Kiem'),
(120, 'A00', '0', 'Thuong Gia'),
(120, 'A01', '0', 'Thuong Gia'),
(120, 'A02', '0', 'Thuong Gia'),
(120, 'A03', '0', 'Thuong Gia'),
(120, 'A04', '0', 'Thuong Gia'),
(120, 'A05', '0', 'Pho Thong'),
(120, 'A06', '0', 'Pho Thong'),
(120, 'A07', '0', 'Pho Thong'),
(120, 'A08', '0', 'Pho Thong'),
(120, 'A09', '0', 'Pho Thong'),
(121, 'A00', '0', 'Tiet Kiem'),
(121, 'A01', '0', 'Tiet Kiem'),
(121, 'A02', '0', 'Tiet Kiem'),
(121, 'A03', '0', 'Tiet Kiem'),
(121, 'A04', '0', 'Tiet Kiem'),
(121, 'A05', '0', 'Tiet Kiem'),
(121, 'A06', '0', 'Tiet Kiem'),
(121, 'A07', '0', 'Tiet Kiem'),
(121, 'A08', '0', 'Tiet Kiem'),
(121, 'A09', '0', 'Tiet Kiem'),
(122, 'A00', '0', 'Thuong Gia'),
(122, 'A01', '0', 'Thuong Gia'),
(122, 'A02', '0', 'Thuong Gia'),
(122, 'A03', '0', 'Thuong Gia'),
(122, 'A04', '0', 'Thuong Gia'),
(122, 'A05', '0', 'Pho Thong'),
(122, 'A06', '0', 'Pho Thong'),
(122, 'A07', '0', 'Pho Thong'),
(122, 'A08', '0', 'Pho Thong'),
(122, 'A09', '0', 'Pho Thong'),
(123, 'A00', '0', 'Tiet Kiem'),
(123, 'A01', '0', 'Tiet Kiem'),
(123, 'A02', '0', 'Tiet Kiem'),
(123, 'A03', '0', 'Tiet Kiem'),
(123, 'A04', '0', 'Tiet Kiem'),
(123, 'A05', '0', 'Tiet Kiem'),
(123, 'A06', '0', 'Tiet Kiem'),
(123, 'A07', '0', 'Tiet Kiem'),
(123, 'A08', '0', 'Tiet Kiem'),
(123, 'A09', '0', 'Tiet Kiem'),
(124, 'A00', '0', 'Thuong Gia'),
(124, 'A01', '0', 'Thuong Gia'),
(124, 'A02', '0', 'Thuong Gia'),
(124, 'A03', '0', 'Thuong Gia'),
(124, 'A04', '0', 'Thuong Gia'),
(124, 'A05', '0', 'Pho Thong'),
(124, 'A06', '0', 'Pho Thong'),
(124, 'A07', '0', 'Pho Thong'),
(124, 'A08', '0', 'Pho Thong'),
(124, 'A09', '0', 'Pho Thong'),
(125, 'A00', '0', 'Tiet Kiem'),
(125, 'A01', '0', 'Tiet Kiem'),
(125, 'A02', '0', 'Tiet Kiem'),
(125, 'A03', '0', 'Tiet Kiem'),
(125, 'A04', '0', 'Tiet Kiem'),
(125, 'A05', '0', 'Tiet Kiem'),
(125, 'A06', '0', 'Tiet Kiem'),
(125, 'A07', '0', 'Tiet Kiem'),
(125, 'A08', '0', 'Tiet Kiem'),
(125, 'A09', '0', 'Tiet Kiem'),
(126, 'A00', '0', 'Thuong Gia'),
(126, 'A01', '0', 'Thuong Gia'),
(126, 'A02', '0', 'Thuong Gia'),
(126, 'A03', '0', 'Thuong Gia'),
(126, 'A04', '0', 'Thuong Gia'),
(126, 'A05', '0', 'Pho Thong'),
(126, 'A06', '0', 'Pho Thong'),
(126, 'A07', '0', 'Pho Thong'),
(126, 'A08', '0', 'Pho Thong'),
(126, 'A09', '0', 'Pho Thong'),
(127, 'A00', '0', 'Tiet Kiem'),
(127, 'A01', '0', 'Tiet Kiem'),
(127, 'A02', '0', 'Tiet Kiem'),
(127, 'A03', '0', 'Tiet Kiem'),
(127, 'A04', '0', 'Tiet Kiem'),
(127, 'A05', '0', 'Tiet Kiem'),
(127, 'A06', '0', 'Tiet Kiem'),
(127, 'A07', '0', 'Tiet Kiem'),
(127, 'A08', '0', 'Tiet Kiem'),
(127, 'A09', '0', 'Tiet Kiem')


CREATE TABLE DatCho (
  IdDatCho INT IDENTITY(1,1),
  IdKhachHang INT,
  LoaiVe VARCHAR(30),
  IdGheChuyenBay INT UNIQUE,
  PRIMARY KEY(IdDatCho),

  FOREIGN KEY (IdKhachHang) REFERENCES KhachHang (IdKhachHang),
  CONSTRAINT FK_DC_CB FOREIGN KEY (IdGheChuyenBay) REFERENCES DatCho (IdGheChuyenBay),
  FOREIGN KEY (IdGheChuyenBay) REFERENCES GheNgoi(IdGheChuyenBay)
);

--select * from GheNgoi

Go
CREATE TRIGGER ThayDoiTrrangThaiDat ON DatCho AFTER INSERT
AS
BEGIN
	UPDATE GheNgoi
	SET GheNgoi.TinhTrangDat = 1
	WHERE GheNgoi.IdGheChuyenBay IN(
		SELECT inserted.IdGheChuyenBay FROM inserted
	)
END;


go
select * from KhachHang
select * from GheNgoi


CREATE TABLE GiaoDich (
  MaGiaoDich INT IDENTITY(1,1) PRIMARY KEY,
  IdDatCho INT,
  NgayGiaoDich DATETIME,
  IdKhachHang INT,
  SoTaiKhoan VARCHAR(30),
  MatKhau VARCHAR(30),
  FOREIGN KEY (IdDatCho) REFERENCES DatCho (IdDatCho),
);
select * from GiaoDich

CREATE TABLE QuanTri(
	MaNV int IDENTITY(1,1) primary key,
	TenNV nvarchar(30),
	TaiKhoan nvarchar(30),
	MatKhau nvarchar(30)
);

INSERT INTO QuanTri
values
('Khoa', 'admin', 'admin')
select * from QuanTri

CREATE TABLE QuanTri_ChuyenBay(
	IdQuanTri int IDENTITY(1,1),
	MaNV int,
	IdChuyenBay int,
	primary key(MaNV, IdChuyenBay),
	foreign key(MaNV) references QuanTri(MaNV),
	foreign key(IdChuyenBay) references ChuyenBay(IdChuyenBay)
);

INSERT INTO QuanTri_ChuyenBay
values
(1, 110),
(1, 111),
(1, 112),
(1, 113),
(1, 114),
(1, 115),
(1, 116),
(1, 117),
(1, 118),
(1, 119),
(1, 120),
(1, 121),
(1, 122),
(1, 123),
(1, 124),
(1, 125),
(1, 126),
(1, 127),
(1, 129),
(1, 130),
(1, 131),
(1, 132),
(1, 133),
(1, 134),
(1, 135),
(1, 136),
(1, 137),
(1, 138),
(1, 139),
(1, 140),
(1, 141),
(1, 142),
(1, 143),
(1, 144),
(1, 145),
(1, 146),
(1, 229),
(1, 230),
(1, 231),
(1, 232),
(1, 233),
(1, 234),
(1, 235),
(1, 236),
(1, 237),
(1, 238),
(1, 239),
(1, 240),
(1, 241),
(1, 242),
(1, 243),
(1, 244),
(1, 245),
(1, 246)



select * from ChuyenBay

go
CREATE TRIGGER Delete_ChuyenBay on  ChuyenBay instead of delete
AS
--select * from GheNgoi
BEGIN
	UPDATE GheNgoi
	SET TinhTrangDat = 'Huy chuyen bay ' + CONVERT(nvarchar(30), GheNgoi.IdChuyenBay)
	WHERE IdChuyenBay in(
		SELECT IdChuyenBay FROM deleted
	)
	UPDATE GheNgoi
	SET IdChuyenBay = 0
	WHERE IdChuyenBay in(
		SELECT IdChuyenBay FROM deleted
	)

	UPDATE GheNgoi
	SET TinhTrangDat = 'Huy chuyen bay ' + CONVERT(nvarchar(30), GheNgoi.IdChuyenBay)
	WHERE IdChuyenBay in(
		SELECT IdChuyenBayKhuHoi FROM deleted
	)
	UPDATE GheNgoi
	SET IdChuyenBay = 0
	WHERE IdChuyenBay in(
		SELECT IdChuyenBayKhuHoi FROM deleted
	)

	UPDATE GheNgoi
	SET TinhTrangDat = 'Huy chuyen bay ' + CONVERT(nvarchar(30), GheNgoi.IdChuyenBay)
	WHERE IdChuyenBay in(
		SELECT ChuyenBay.IdChuyenBay from deleted
		join ChuyenBay on(ChuyenBay.IdChuyenBayKhuHoi = deleted.IdChuyenBay)
	)
	UPDATE GheNgoi
	SET IdChuyenBay = 0
	WHERE IdChuyenBay in(
		SELECT ChuyenBay.IdChuyenBay from deleted
		join ChuyenBay on(ChuyenBay.IdChuyenBayKhuHoi = deleted.IdChuyenBay)
	)


	--QuanTri_ChuyenBay
	DELETE FROM QuanTri_ChuyenBay
	WHERE IdChuyenBay in(
		select IdChuyenBay from deleted
	)
	DELETE FROM QuanTri_ChuyenBay
	WHERE IdChuyenBay in(
		select IdChuyenBayKhuHoi from deleted
	)
	DELETE FROM QuanTri_ChuyenBay
	WHERE IdChuyenBay in(
		SELECT ChuyenBay.IdChuyenBay from deleted
		join ChuyenBay on(ChuyenBay.IdChuyenBayKhuHoi = deleted.IdChuyenBay)
	)

	--Delete from ChuyenBay where IdChuyenBay = 112
--select * from ChuyenBay WHERE IdChuyenBay = 112
--select * from GheNgoi WHERE IdChuyenBay = 0


	--ChuyenBay
	/*UPDATE ChuyenBay
	SET IdChuyenBayKhuHoi = NULL
	WHERE IdChuyenBay in(
		select IdChuyenBay from deleted
	)*/
	DELETE FROM ChuyenBay 
	WHERE IdChuyenBayKhuHoi in(
		select IdChuyenBay from deleted
	)
	
	DELETE FROM ChuyenBay
	WHERE IdChuyenBay in(
		select IdChuyenBay from deleted
	)
	DELETE FROM ChuyenBay
	WHERE IdChuyenBay in(
		select IdChuyenBayKhuHoi from deleted
	)

	
	
	
END;
go

