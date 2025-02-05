USE [QL_KHOHANG]
GO
/****** Object:  Table [dbo].[CHITIETPHIEUDAT]    Script Date: 16/06/2021 5:50:40 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHITIETPHIEUDAT](
	[ID_PD] [int] NOT NULL,
	[ID_SP] [int] NOT NULL,
	[SOLUONG] [int] NULL,
	[THANHTIEN] [float] NULL,
 CONSTRAINT [PK_CTPD] PRIMARY KEY CLUSTERED 
(
	[ID_PD] ASC,
	[ID_SP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CHITIETPHIEUNHAP]    Script Date: 16/06/2021 5:50:40 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHITIETPHIEUNHAP](
	[ID_PN] [int] NOT NULL,
	[ID_PD] [int] NULL,
	[ID_SP] [int] NOT NULL,
	[SOLUONG] [int] NULL,
	[DONGIANHAP] [float] NULL,
	[DONGIABAN] [float] NULL,
	[HANSD] [date] NULL,
	[THANHTIEN] [float] NULL,
 CONSTRAINT [PK_CTPN] PRIMARY KEY CLUSTERED 
(
	[ID_PN] ASC,
	[ID_SP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CHITIETPHIEUXUAT]    Script Date: 16/06/2021 5:50:40 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHITIETPHIEUXUAT](
	[ID_PX] [int] NOT NULL,
	[ID_SP] [int] NOT NULL,
	[SOLUONG] [int] NULL,
	[DONGIA] [float] NULL,
	[THANHTIEN] [float] NULL,
 CONSTRAINT [PK_CTHD2] PRIMARY KEY CLUSTERED 
(
	[ID_PX] ASC,
	[ID_SP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CHITIETYCXUATHANG]    Script Date: 16/06/2021 5:50:40 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHITIETYCXUATHANG](
	[ID_YCXH] [int] NOT NULL,
	[ID_SP] [int] NOT NULL,
	[SOLUONG] [int] NULL,
	[DONGIA] [float] NULL,
	[THANHTIEN] [float] NULL,
 CONSTRAINT [PK_CTYCXH] PRIMARY KEY CLUSTERED 
(
	[ID_YCXH] ASC,
	[ID_SP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CHITTIETCHUYENHANG]    Script Date: 16/06/2021 5:50:40 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHITTIETCHUYENHANG](
	[ID_PC] [int] NOT NULL,
	[ID_SP] [int] NOT NULL,
	[SOLUONG] [int] NULL,
 CONSTRAINT [PK_CT_CH] PRIMARY KEY CLUSTERED 
(
	[ID_PC] ASC,
	[ID_SP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DANHMUCSANPHAM]    Script Date: 16/06/2021 5:50:40 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DANHMUCSANPHAM](
	[ID_NCC] [int] NOT NULL,
	[ID_SP] [int] NOT NULL,
	[GIABAN] [int] NOT NULL,
 CONSTRAINT [PK_DMSP] PRIMARY KEY CLUSTERED 
(
	[ID_NCC] ASC,
	[ID_SP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LOAISANPHAM]    Script Date: 16/06/2021 5:50:40 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOAISANPHAM](
	[ID_LSP] [int] IDENTITY(1,1) NOT NULL,
	[TENLOAISANPHAM] [nvarchar](100) NULL,
 CONSTRAINT [PK_LOAISP] PRIMARY KEY CLUSTERED 
(
	[ID_LSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[MANHINH]    Script Date: 16/06/2021 5:50:40 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MANHINH](
	[ID_MANHINH] [int] IDENTITY(1,1) NOT NULL,
	[TENMANHINH] [varchar](50) NULL,
 CONSTRAINT [PK_MANHINH] PRIMARY KEY CLUSTERED 
(
	[ID_MANHINH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NGUOIDUNG]    Script Date: 16/06/2021 5:50:40 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NGUOIDUNG](
	[ID_KHO] [int] NOT NULL,
	[ID_DN] [varchar](10) NOT NULL,
	[MATKHAU] [varchar](50) NULL,
	[TEN] [nvarchar](50) NULL,
	[SDT] [varchar](10) NULL,
	[DIACHI] [nvarchar](100) NULL,
	[GIOITINH] [nvarchar](10) NULL,
	[NGAYSINH] [date] NULL,
	[TINHTRANG] [bit] NULL,
	[HINH] [nvarchar](50) NULL,
 CONSTRAINT [PK_NGUOIDUNG] PRIMARY KEY CLUSTERED 
(
	[ID_DN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NGUOIDUNGNHOMNGUOIDUNG]    Script Date: 16/06/2021 5:50:40 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NGUOIDUNGNHOMNGUOIDUNG](
	[ID_NHOM] [varchar](10) NOT NULL,
	[ID_DN] [varchar](10) NOT NULL,
	[GHICHU] [nvarchar](50) NULL,
 CONSTRAINT [PK_NNND] PRIMARY KEY CLUSTERED 
(
	[ID_NHOM] ASC,
	[ID_DN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NHACUNGCAP]    Script Date: 16/06/2021 5:50:40 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NHACUNGCAP](
	[ID_NCC] [int] IDENTITY(1,1) NOT NULL,
	[TENNCC] [nvarchar](50) NULL,
	[DIACHI] [nvarchar](100) NULL,
	[SDT] [varchar](10) NULL,
 CONSTRAINT [PK_NCC] PRIMARY KEY CLUSTERED 
(
	[ID_NCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NHOMNGUOIDUNG]    Script Date: 16/06/2021 5:50:40 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NHOMNGUOIDUNG](
	[ID_NHOM] [varchar](10) NOT NULL,
	[TENNHOM] [nvarchar](50) NULL,
 CONSTRAINT [PK_NND] PRIMARY KEY CLUSTERED 
(
	[ID_NHOM] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PHANQUYEN]    Script Date: 16/06/2021 5:50:40 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PHANQUYEN](
	[ID_NHOM] [varchar](10) NOT NULL,
	[ID_MANHINH] [int] NOT NULL,
	[GHICHU] [varchar](20) NULL,
	[COQUYEN] [bit] NULL,
 CONSTRAINT [PK_PHANQUYEN] PRIMARY KEY CLUSTERED 
(
	[ID_NHOM] ASC,
	[ID_MANHINH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PHIEUDAT]    Script Date: 16/06/2021 5:50:40 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PHIEUDAT](
	[ID_PD] [int] IDENTITY(1,1) NOT NULL,
	[ID_NCC] [int] NULL,
	[ID_DN] [varchar](10) NULL,
	[NGAYLAP] [date] NULL,
	[TONGTIEN] [float] NULL,
	[TINHTRANG] [bit] NULL,
 CONSTRAINT [PK_PD] PRIMARY KEY CLUSTERED 
(
	[ID_PD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PHIEUNHAP]    Script Date: 16/06/2021 5:50:40 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PHIEUNHAP](
	[ID_PN] [int] IDENTITY(1,1) NOT NULL,
	[ID_NCC] [int] NULL,
	[ID_DN] [varchar](10) NULL,
	[NGAYLAP] [date] NULL,
	[TONGTIEN] [float] NULL,
 CONSTRAINT [PK_PN] PRIMARY KEY CLUSTERED 
(
	[ID_PN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PHIEUXUAT]    Script Date: 16/06/2021 5:50:40 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PHIEUXUAT](
	[ID_PX] [int] IDENTITY(1,1) NOT NULL,
	[ID_YCXH] [int] NULL,
	[ID_DN] [varchar](10) NULL,
	[NGAYLAP] [date] NULL,
	[TONGTIEN] [float] NULL,
 CONSTRAINT [PK_PX1] PRIMARY KEY CLUSTERED 
(
	[ID_PX] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SANPHAM]    Script Date: 16/06/2021 5:50:40 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SANPHAM](
	[ID_SP] [int] IDENTITY(1,1) NOT NULL,
	[TENSP] [nvarchar](100) NULL,
	[DVT] [nvarchar](10) NULL,
	[ID_LSP] [int] NULL,
	[SOLUONG] [int] NULL,
	[DONGIA] [float] NULL,
	[HINHANH] [nvarchar](100) NULL,
 CONSTRAINT [PK_SP] PRIMARY KEY CLUSTERED 
(
	[ID_SP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[THONGTINKHO]    Script Date: 16/06/2021 5:50:40 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[THONGTINKHO](
	[ID_KHO] [int] IDENTITY(1,1) NOT NULL,
	[DIACHI] [nvarchar](200) NULL,
	[TINHTRANG] [nvarchar](30) NULL,
	[SLNV] [int] NULL,
 CONSTRAINT [PK_TTKHO] PRIMARY KEY CLUSTERED 
(
	[ID_KHO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[YEUCAUCHUYENHANG]    Script Date: 16/06/2021 5:50:40 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[YEUCAUCHUYENHANG](
	[ID_PC] [int] IDENTITY(1,1) NOT NULL,
	[ID_KHO] [int] NOT NULL,
	[ID_DN] [varchar](10) NOT NULL,
	[NGAYLAP] [date] NULL,
	[TINHTRANG] [nvarchar](50) NULL,
 CONSTRAINT [PK_YCCH] PRIMARY KEY CLUSTERED 
(
	[ID_PC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[YEUCAUXUATHANG]    Script Date: 16/06/2021 5:50:40 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[YEUCAUXUATHANG](
	[ID_YCXH] [int] IDENTITY(1,1) NOT NULL,
	[ID_DN] [varchar](10) NULL,
	[NGAYLAP] [date] NULL,
	[TONGTIEN] [float] NULL,
 CONSTRAINT [PK_PN_YCXH] PRIMARY KEY CLUSTERED 
(
	[ID_YCXH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[CHITIETPHIEUDAT]  WITH CHECK ADD  CONSTRAINT [FK_CTPD_PN] FOREIGN KEY([ID_PD])
REFERENCES [dbo].[PHIEUDAT] ([ID_PD])
GO
ALTER TABLE [dbo].[CHITIETPHIEUDAT] CHECK CONSTRAINT [FK_CTPD_PN]
GO
ALTER TABLE [dbo].[CHITIETPHIEUDAT]  WITH CHECK ADD  CONSTRAINT [FK_CTPD_SP] FOREIGN KEY([ID_SP])
REFERENCES [dbo].[SANPHAM] ([ID_SP])
GO
ALTER TABLE [dbo].[CHITIETPHIEUDAT] CHECK CONSTRAINT [FK_CTPD_SP]
GO
ALTER TABLE [dbo].[CHITIETPHIEUNHAP]  WITH CHECK ADD  CONSTRAINT [FK_CTPN_PD] FOREIGN KEY([ID_PD])
REFERENCES [dbo].[PHIEUDAT] ([ID_PD])
GO
ALTER TABLE [dbo].[CHITIETPHIEUNHAP] CHECK CONSTRAINT [FK_CTPN_PD]
GO
ALTER TABLE [dbo].[CHITIETPHIEUNHAP]  WITH CHECK ADD  CONSTRAINT [FK_CTPN_PN] FOREIGN KEY([ID_PN])
REFERENCES [dbo].[PHIEUNHAP] ([ID_PN])
GO
ALTER TABLE [dbo].[CHITIETPHIEUNHAP] CHECK CONSTRAINT [FK_CTPN_PN]
GO
ALTER TABLE [dbo].[CHITIETPHIEUXUAT]  WITH CHECK ADD  CONSTRAINT [FK_CTHD_HD2] FOREIGN KEY([ID_PX])
REFERENCES [dbo].[PHIEUXUAT] ([ID_PX])
GO
ALTER TABLE [dbo].[CHITIETPHIEUXUAT] CHECK CONSTRAINT [FK_CTHD_HD2]
GO
ALTER TABLE [dbo].[CHITIETPHIEUXUAT]  WITH CHECK ADD  CONSTRAINT [FK_CTHD_SP2] FOREIGN KEY([ID_SP])
REFERENCES [dbo].[SANPHAM] ([ID_SP])
GO
ALTER TABLE [dbo].[CHITIETPHIEUXUAT] CHECK CONSTRAINT [FK_CTHD_SP2]
GO
ALTER TABLE [dbo].[CHITIETYCXUATHANG]  WITH CHECK ADD  CONSTRAINT [FK_CTHD_HD1] FOREIGN KEY([ID_YCXH])
REFERENCES [dbo].[YEUCAUXUATHANG] ([ID_YCXH])
GO
ALTER TABLE [dbo].[CHITIETYCXUATHANG] CHECK CONSTRAINT [FK_CTHD_HD1]
GO
ALTER TABLE [dbo].[CHITIETYCXUATHANG]  WITH CHECK ADD  CONSTRAINT [FK_CTHD_SP1] FOREIGN KEY([ID_SP])
REFERENCES [dbo].[SANPHAM] ([ID_SP])
GO
ALTER TABLE [dbo].[CHITIETYCXUATHANG] CHECK CONSTRAINT [FK_CTHD_SP1]
GO
ALTER TABLE [dbo].[CHITTIETCHUYENHANG]  WITH CHECK ADD  CONSTRAINT [FK_CTHD_HD] FOREIGN KEY([ID_PC])
REFERENCES [dbo].[YEUCAUCHUYENHANG] ([ID_PC])
GO
ALTER TABLE [dbo].[CHITTIETCHUYENHANG] CHECK CONSTRAINT [FK_CTHD_HD]
GO
ALTER TABLE [dbo].[CHITTIETCHUYENHANG]  WITH CHECK ADD  CONSTRAINT [FK_CTHD_SP] FOREIGN KEY([ID_SP])
REFERENCES [dbo].[SANPHAM] ([ID_SP])
GO
ALTER TABLE [dbo].[CHITTIETCHUYENHANG] CHECK CONSTRAINT [FK_CTHD_SP]
GO
ALTER TABLE [dbo].[DANHMUCSANPHAM]  WITH CHECK ADD  CONSTRAINT [FK_DMSP_NCC] FOREIGN KEY([ID_NCC])
REFERENCES [dbo].[NHACUNGCAP] ([ID_NCC])
GO
ALTER TABLE [dbo].[DANHMUCSANPHAM] CHECK CONSTRAINT [FK_DMSP_NCC]
GO
ALTER TABLE [dbo].[DANHMUCSANPHAM]  WITH CHECK ADD  CONSTRAINT [FK_DMSP_SP] FOREIGN KEY([ID_SP])
REFERENCES [dbo].[SANPHAM] ([ID_SP])
GO
ALTER TABLE [dbo].[DANHMUCSANPHAM] CHECK CONSTRAINT [FK_DMSP_SP]
GO
ALTER TABLE [dbo].[NGUOIDUNG]  WITH CHECK ADD  CONSTRAINT [FK_KHO_ND] FOREIGN KEY([ID_KHO])
REFERENCES [dbo].[THONGTINKHO] ([ID_KHO])
GO
ALTER TABLE [dbo].[NGUOIDUNG] CHECK CONSTRAINT [FK_KHO_ND]
GO
ALTER TABLE [dbo].[NGUOIDUNGNHOMNGUOIDUNG]  WITH CHECK ADD  CONSTRAINT [FK_NNND_ND] FOREIGN KEY([ID_DN])
REFERENCES [dbo].[NGUOIDUNG] ([ID_DN])
GO
ALTER TABLE [dbo].[NGUOIDUNGNHOMNGUOIDUNG] CHECK CONSTRAINT [FK_NNND_ND]
GO
ALTER TABLE [dbo].[NGUOIDUNGNHOMNGUOIDUNG]  WITH CHECK ADD  CONSTRAINT [FK_NNND_NND] FOREIGN KEY([ID_NHOM])
REFERENCES [dbo].[NHOMNGUOIDUNG] ([ID_NHOM])
GO
ALTER TABLE [dbo].[NGUOIDUNGNHOMNGUOIDUNG] CHECK CONSTRAINT [FK_NNND_NND]
GO
ALTER TABLE [dbo].[PHANQUYEN]  WITH CHECK ADD  CONSTRAINT [FK_PQ_MH] FOREIGN KEY([ID_MANHINH])
REFERENCES [dbo].[MANHINH] ([ID_MANHINH])
GO
ALTER TABLE [dbo].[PHANQUYEN] CHECK CONSTRAINT [FK_PQ_MH]
GO
ALTER TABLE [dbo].[PHANQUYEN]  WITH CHECK ADD  CONSTRAINT [FK_PQ_NNDA] FOREIGN KEY([ID_NHOM])
REFERENCES [dbo].[NHOMNGUOIDUNG] ([ID_NHOM])
GO
ALTER TABLE [dbo].[PHANQUYEN] CHECK CONSTRAINT [FK_PQ_NNDA]
GO
ALTER TABLE [dbo].[PHIEUDAT]  WITH CHECK ADD  CONSTRAINT [FK_PD_NCC] FOREIGN KEY([ID_NCC])
REFERENCES [dbo].[NHACUNGCAP] ([ID_NCC])
GO
ALTER TABLE [dbo].[PHIEUDAT] CHECK CONSTRAINT [FK_PD_NCC]
GO
ALTER TABLE [dbo].[PHIEUDAT]  WITH CHECK ADD  CONSTRAINT [FK_PD_ND] FOREIGN KEY([ID_DN])
REFERENCES [dbo].[NGUOIDUNG] ([ID_DN])
GO
ALTER TABLE [dbo].[PHIEUDAT] CHECK CONSTRAINT [FK_PD_ND]
GO
ALTER TABLE [dbo].[PHIEUNHAP]  WITH CHECK ADD  CONSTRAINT [FK_PN_NCC] FOREIGN KEY([ID_NCC])
REFERENCES [dbo].[NHACUNGCAP] ([ID_NCC])
GO
ALTER TABLE [dbo].[PHIEUNHAP] CHECK CONSTRAINT [FK_PN_NCC]
GO
ALTER TABLE [dbo].[PHIEUNHAP]  WITH CHECK ADD  CONSTRAINT [FK_PN_ND] FOREIGN KEY([ID_DN])
REFERENCES [dbo].[NGUOIDUNG] ([ID_DN])
GO
ALTER TABLE [dbo].[PHIEUNHAP] CHECK CONSTRAINT [FK_PN_ND]
GO
ALTER TABLE [dbo].[PHIEUXUAT]  WITH CHECK ADD  CONSTRAINT [FK_PN_ND1] FOREIGN KEY([ID_DN])
REFERENCES [dbo].[NGUOIDUNG] ([ID_DN])
GO
ALTER TABLE [dbo].[PHIEUXUAT] CHECK CONSTRAINT [FK_PN_ND1]
GO
ALTER TABLE [dbo].[PHIEUXUAT]  WITH CHECK ADD  CONSTRAINT [FK_PN_YCXH1] FOREIGN KEY([ID_YCXH])
REFERENCES [dbo].[YEUCAUXUATHANG] ([ID_YCXH])
GO
ALTER TABLE [dbo].[PHIEUXUAT] CHECK CONSTRAINT [FK_PN_YCXH1]
GO
ALTER TABLE [dbo].[SANPHAM]  WITH CHECK ADD  CONSTRAINT [FK_SP_LOAI] FOREIGN KEY([ID_LSP])
REFERENCES [dbo].[LOAISANPHAM] ([ID_LSP])
GO
ALTER TABLE [dbo].[SANPHAM] CHECK CONSTRAINT [FK_SP_LOAI]
GO
ALTER TABLE [dbo].[YEUCAUXUATHANG]  WITH CHECK ADD  CONSTRAINT [FK_YCXH_ND] FOREIGN KEY([ID_DN])
REFERENCES [dbo].[NGUOIDUNG] ([ID_DN])
GO
ALTER TABLE [dbo].[YEUCAUXUATHANG] CHECK CONSTRAINT [FK_YCXH_ND]
GO
