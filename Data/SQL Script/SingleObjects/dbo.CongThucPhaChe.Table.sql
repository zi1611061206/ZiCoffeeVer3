USE [QLCF]
GO
/****** Object:  Table [dbo].[CongThucPhaChe]    Script Date: 11/5/2020 3:57:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CongThucPhaChe](
	[MaDichVu] [int] NOT NULL,
	[MaNguyenLieu] [int] NOT NULL,
	[SoLuongPha] [float] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaDichVu] ASC,
	[MaNguyenLieu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[CongThucPhaChe] ADD  DEFAULT ((0)) FOR [SoLuongPha]
GO
ALTER TABLE [dbo].[CongThucPhaChe]  WITH CHECK ADD FOREIGN KEY([MaDichVu])
REFERENCES [dbo].[DichVu] ([MaDichVu])
GO
ALTER TABLE [dbo].[CongThucPhaChe]  WITH CHECK ADD FOREIGN KEY([MaNguyenLieu])
REFERENCES [dbo].[NguyenLieu] ([MaNguyenLieu])
GO
