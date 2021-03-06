USE [jxsysDB]
GO
/****** Object:  Table [dbo].[dsd]    Script Date: 2019/5/14 19:01:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dsd](
	[OrderID] [nchar](10) NOT NULL,
	[fixID] [nchar](10) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T_Bom]    Script Date: 2019/5/14 19:01:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T_Bom](
	[bomid] [int] IDENTITY(1,1) NOT NULL,
	[BomName] [varchar](255) NULL,
	[BomSize] [varchar](255) NULL,
	[Unitquantity] [int] NULL,
	[BomUnit] [varchar](255) NULL,
	[Bomfrom] [varchar](255) NULL,
	[proid] [varchar](50) NULL,
	[Bili] [varchar](50) NULL,
	[Stock] [int] NULL,
	[Materialid] [varchar](50) NULL,
 CONSTRAINT [PK_T_Bom] PRIMARY KEY CLUSTERED 
(
	[bomid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T_customer]    Script Date: 2019/5/14 19:01:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T_customer](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[CusID] [nvarchar](255) NOT NULL,
	[CusShort] [nvarchar](255) NOT NULL,
	[CusName] [nvarchar](255) NOT NULL,
	[CusTelephone] [nvarchar](255) NOT NULL,
	[CusFax] [nvarchar](255) NULL,
	[CusAdress] [nvarchar](255) NOT NULL,
	[CusPerson] [nvarchar](255) NULL,
	[CusBank] [nvarchar](255) NULL,
	[CusAccount] [nvarchar](255) NULL,
	[CusMemo] [nvarchar](255) NULL,
 CONSTRAINT [PK_T_customer] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[CusID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T_DeliveryOut]    Script Date: 2019/5/14 19:01:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T_DeliveryOut](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[DeliveryId] [varchar](50) NOT NULL,
	[DeliveryPerson] [varchar](50) NULL,
	[DeliveryInDate] [date] NULL,
	[DeliveryDate] [date] NULL,
	[DeliveryMemo] [varchar](50) NULL,
	[DeliveryQuantity] [int] NULL,
	[DeliveryOutQuantity] [int] NULL,
	[CarPerson] [varchar](50) NULL,
	[zhuananid] [int] NULL,
 CONSTRAINT [PK_T_DeliveryOut] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T_FixBox1]    Script Date: 2019/5/14 19:01:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T_FixBox1](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[CusId] [nvarchar](255) NOT NULL,
	[ProductName] [nvarchar](255) NULL,
	[TypeId] [nvarchar](255) NULL,
	[ProductType] [nvarchar](255) NULL,
	[MaterialId] [varchar](50) NULL,
	[MaterialName] [varchar](50) NULL,
	[PLength] [decimal](18, 2) NULL,
	[Pwide] [decimal](18, 2) NULL,
	[Pheight] [decimal](18, 2) NULL,
	[unit] [nvarchar](255) NULL,
	[quantity] [nvarchar](255) NULL,
	[price] [nvarchar](255) NULL,
	[Memo] [nvarchar](255) NULL,
	[Yingshua] [nvarchar](255) NOT NULL,
	[Zhanjiao] [nvarchar](255) NOT NULL,
	[Dading] [nvarchar](255) NOT NULL,
 CONSTRAINT [PK_T_FixBox] PRIMARY KEY CLUSTERED 
(
	[id] ASC,
	[CusId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T_FixPair1]    Script Date: 2019/5/14 19:01:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T_FixPair1](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[CusId] [nvarchar](255) NOT NULL,
	[fittingName] [nvarchar](255) NOT NULL,
	[TypeID] [float] NOT NULL,
	[Type] [nvarchar](255) NULL,
	[materialID] [varchar](50) NOT NULL,
	[materialName] [varchar](50) NULL,
	[Flength] [decimal](18, 2) NOT NULL,
	[Fwide] [decimal](18, 2) NOT NULL,
	[Fheight] [decimal](18, 2) NULL,
	[unit] [nvarchar](255) NOT NULL,
	[quantity] [nvarchar](255) NULL,
	[price] [nvarchar](255) NULL,
	[yingshua] [varchar](50) NULL,
	[zhanjiao] [varchar](50) NULL,
	[dading] [varchar](50) NULL,
	[FatherId] [nchar](10) NULL,
	[memo] [varchar](255) NULL,
 CONSTRAINT [PK_T_FixPair] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T_fixpro]    Script Date: 2019/5/14 19:01:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T_fixpro](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[CusId] [nvarchar](255) NOT NULL,
	[ProductName] [nvarchar](255) NOT NULL,
	[TypeId] [nvarchar](255) NOT NULL,
	[ProductType] [nvarchar](255) NOT NULL,
	[MaterialId] [varchar](50) NOT NULL,
	[MaterialName] [varchar](50) NOT NULL,
	[PLength] [float] NOT NULL,
	[Pwide] [float] NOT NULL,
	[Pheight] [float] NOT NULL,
	[unit] [nvarchar](255) NOT NULL,
	[quantity] [nvarchar](255) NOT NULL,
	[price] [decimal](18, 2) NOT NULL,
	[Memo] [nvarchar](255) NULL,
	[Yingshua] [nvarchar](255) NULL,
	[Zhanjiao] [nvarchar](255) NULL,
	[Dading] [nvarchar](255) NULL,
	[fatherid] [nvarchar](255) NULL,
	[Stock] [int] NULL,
 CONSTRAINT [PK_T_fixpro] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T_ManuOrder]    Script Date: 2019/5/14 19:01:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T_ManuOrder](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[ManuID] [varchar](50) NOT NULL,
	[ManuPerson] [varchar](50) NULL,
	[MaterialSize] [varchar](255) NULL,
	[AllMaterialQuantity] [varchar](50) NULL,
	[Saleid] [varchar](255) NULL,
	[ZhuanAnId] [varchar](50) NULL,
 CONSTRAINT [PK_T_ManuOrder] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T_material]    Script Date: 2019/5/14 19:01:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T_material](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[materialId] [nvarchar](255) NOT NULL,
	[materialName] [varchar](50) NULL,
	[MaterialType] [nvarchar](255) NULL,
 CONSTRAINT [PK_T_material] PRIMARY KEY CLUSTERED 
(
	[materialId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [UQ__T_materi__99B653FCBD15DF2D] UNIQUE NONCLUSTERED 
(
	[materialId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T_MaterialIn]    Script Date: 2019/5/14 19:01:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T_MaterialIn](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[MatInId] [varchar](50) NULL,
	[MatInPerson] [varchar](50) NULL,
	[MatInDate] [date] NULL,
	[MatInMemo] [varchar](255) NULL,
	[Supid] [varchar](50) NULL,
	[MatDate] [date] NULL,
	[PurId] [int] NULL,
	[MatQuantity] [int] NULL,
	[MatinQuantity] [int] NULL,
 CONSTRAINT [PK_T_MaterialIn] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T_MaterialStock]    Script Date: 2019/5/14 19:01:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T_MaterialStock](
	[Bomid] [int] NULL,
	[MaterialStockQuantity] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T_Member]    Script Date: 2019/5/14 19:01:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T_Member](
	[jobNo] [varchar](50) NOT NULL,
	[jobName] [varchar](50) NOT NULL,
 CONSTRAINT [PK_T_Member] PRIMARY KEY CLUSTERED 
(
	[jobNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T_Morder]    Script Date: 2019/5/14 19:01:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T_Morder](
	[MorserId] [int] NOT NULL,
	[ProductName] [varchar](50) NOT NULL,
	[ProductType] [varchar](50) NOT NULL,
	[ProdutSize] [varchar](50) NOT NULL,
	[OrderNumber] [varchar](50) NOT NULL,
	[OrderPrice] [varchar](50) NOT NULL,
	[OrderAmount] [varchar](50) NOT NULL,
	[MaterialNumber] [varchar](50) NOT NULL,
	[OrderNeed] [varchar](50) NOT NULL,
	[OrderDate] [datetime] NOT NULL,
	[DeliveryDate] [datetime] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T_OrderSale]    Script Date: 2019/5/14 19:01:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T_OrderSale](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[number] [int] NOT NULL,
	[orderid] [varchar](255) NOT NULL,
	[ProId] [varchar](255) NOT NULL,
	[Cusid] [varchar](255) NOT NULL,
	[quantity] [varchar](255) NOT NULL,
	[Amount] [decimal](18, 2) NULL,
	[indate] [date] NOT NULL,
	[orderperson] [varchar](255) NOT NULL,
	[orderdate] [date] NOT NULL,
	[status] [varchar](255) NOT NULL,
	[checkperson] [varchar](255) NULL,
	[checktime] [date] NULL,
	[deliverytime] [date] NOT NULL,
	[memo] [varchar](255) NULL,
 CONSTRAINT [PK_T_OrderSale] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T_product]    Script Date: 2019/5/14 19:01:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T_product](
	[ProductId] [varchar](50) NOT NULL,
	[ProductName] [varchar](50) NOT NULL,
	[ProsuctType] [varchar](50) NOT NULL,
	[MaterialId] [varchar](50) NOT NULL,
	[MarerialName] [varchar](50) NOT NULL,
	[ProductSize] [varchar](50) NOT NULL,
	[ProductPrice] [float] NOT NULL,
 CONSTRAINT [PK_T_product] PRIMARY KEY CLUSTERED 
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T_ProductIn]    Script Date: 2019/5/14 19:01:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T_ProductIn](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[ProInId] [varchar](50) NOT NULL,
	[ProInPerson] [varchar](50) NULL,
	[ProIndate] [date] NULL,
	[ProInMemo] [varchar](255) NULL,
	[ProDate] [date] NULL,
	[ProInQuantity] [int] NULL,
	[ProQuantity] [int] NULL,
	[Cusid] [varchar](50) NULL,
	[zhuananID] [int] NULL,
 CONSTRAINT [PK_T_ProductIn] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T_ProductType]    Script Date: 2019/5/14 19:01:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T_ProductType](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[TypeName] [varchar](50) NOT NULL,
	[ProductDouble] [varchar](50) NULL,
	[ProductDing] [varchar](50) NULL,
	[Price] [varchar](50) NULL,
	[ProductLength] [varchar](50) NULL,
	[ProductWeight] [varchar](50) NULL,
 CONSTRAINT [PK_T_ProductType] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T_ProStock]    Script Date: 2019/5/14 19:01:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T_ProStock](
	[Pid] [int] NULL,
	[ProStockQuantity] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T_PurchaseOrder]    Script Date: 2019/5/14 19:01:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T_PurchaseOrder](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[PurchaseId] [varchar](50) NULL,
	[Supid] [varchar](50) NULL,
	[Bomid] [varchar](50) NULL,
	[PurchaseQuantity] [int] NULL,
	[PurchaseDate] [date] NULL,
	[DeliveryDate] [date] NULL,
	[PurchasePerson] [varchar](50) NULL,
	[memo] [varchar](255) NULL,
	[ZhuanAnId] [varchar](50) NULL,
	[price] [decimal](18, 2) NULL,
	[MatQuantity] [int] NULL,
 CONSTRAINT [PK_T_PurchaseOrder] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T_SaleOrder2]    Script Date: 2019/5/14 19:01:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T_SaleOrder2](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[number] [varchar](50) NOT NULL,
	[orderid] [varchar](50) NULL,
	[BoxId] [nvarchar](255) NULL,
	[quantity] [varchar](50) NULL,
	[indate] [datetime] NULL,
	[orderperson] [nchar](10) NULL,
	[orderdata] [datetime] NULL,
	[status] [varchar](50) NULL,
	[checkperson] [varchar](50) NULL,
	[checktime] [datetime] NULL,
	[deliverytime] [datetime] NULL,
	[memo] [varchar](255) NULL,
 CONSTRAINT [PK_T_SaleOrder] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[orderid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T_supplier]    Script Date: 2019/5/14 19:01:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T_supplier](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[SupId] [varchar](50) NOT NULL,
	[SupShort] [varchar](50) NULL,
	[SupName] [varchar](50) NOT NULL,
	[SupTelephone] [varchar](50) NOT NULL,
	[SupFax] [varchar](50) NULL,
	[SupAdress] [varchar](50) NOT NULL,
	[SupPerson] [varchar](50) NOT NULL,
 CONSTRAINT [pk_T_supplier] PRIMARY KEY NONCLUSTERED 
(
	[id] ASC,
	[SupId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[SupId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[SupId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T_SupplierPrice]    Script Date: 2019/5/14 19:01:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T_SupplierPrice](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[SupId] [varchar](50) NOT NULL,
	[MaterialId] [varchar](50) NOT NULL,
	[SupShort] [nvarchar](255) NULL,
	[MaterialName] [varchar](225) NULL,
	[MaterialType] [nvarchar](255) NOT NULL,
	[Materialprice] [float] NOT NULL,
 CONSTRAINT [PK_T_SupplierPrice] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T_user]    Script Date: 2019/5/14 19:01:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T_user](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[username] [varchar](50) NOT NULL,
	[password] [varchar](50) NOT NULL,
	[iden] [char](10) NULL,
 CONSTRAINT [PK_T_user] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[testclient]    Script Date: 2019/5/14 19:01:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[testclient](
	[id] [nchar](10) NULL,
	[kehu] [nchar](10) NULL,
	[name] [nchar](10) NULL,
	[yongQuantity] [nchar](10) NULL,
	[cunliao] [nchar](10) NULL,
	[fenpei] [nchar](10) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[testD]    Script Date: 2019/5/14 19:01:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[testD](
	[deliveryid] [nchar](10) NULL,
	[time] [date] NULL,
	[zhuananid] [int] NULL,
	[cus] [varchar](50) NULL,
	[productName] [varchar](50) NULL,
	[type] [varchar](50) NULL,
	[materialname] [varchar](50) NULL,
	[length] [varchar](50) NULL,
	[wide] [varchar](50) NULL,
	[height] [varchar](50) NULL,
	[unit] [varchar](50) NULL,
	[quantity] [varchar](50) NULL,
	[unitprice] [float] NULL,
	[price] [float] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[testPur]    Script Date: 2019/5/14 19:01:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[testPur](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[PID] [varchar](50) NULL,
	[supShort] [varchar](50) NULL,
	[MaterialName] [varchar](50) NULL,
	[size] [varchar](50) NULL,
	[unitp] [float] NULL,
	[price] [float] NULL,
	[quantity] [int] NULL,
	[deliverydate] [date] NULL,
	[Purchasedate] [date] NULL,
	[Cusid] [varchar](50) NULL,
	[memo] [varchar](50) NULL,
	[jinliao] [varchar](50) NULL,
	[weijin] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[T_ALLsale]    Script Date: 2019/5/14 19:01:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[T_ALLsale]
AS
SELECT  dbo.T_OrderSale.id, dbo.T_OrderSale.number, dbo.T_OrderSale.orderid, dbo.T_OrderSale.Cusid, dbo.T_fixpro.id AS Pid, 
                   dbo.T_fixpro.ProductName, dbo.T_fixpro.TypeId, dbo.T_fixpro.ProductType, dbo.T_fixpro.MaterialId, 
                   dbo.T_fixpro.MaterialName, dbo.T_fixpro.PLength, dbo.T_fixpro.Pwide, dbo.T_fixpro.Pheight, dbo.T_fixpro.unit, 
                   dbo.T_OrderSale.quantity AS OrderQuantity, dbo.T_fixpro.price, dbo.T_OrderSale.Amount, dbo.T_fixpro.Memo, 
                   dbo.T_fixpro.Yingshua, dbo.T_fixpro.Zhanjiao, dbo.T_fixpro.Dading, dbo.T_fixpro.fatherid, dbo.T_fixpro.quantity, 
                   dbo.T_OrderSale.indate, dbo.T_OrderSale.orderperson, dbo.T_OrderSale.orderdate, dbo.T_OrderSale.status, 
                   dbo.T_OrderSale.checkperson, dbo.T_OrderSale.checktime, dbo.T_OrderSale.deliverytime, 
                   dbo.T_OrderSale.memo AS OrderMemo
FROM      dbo.T_fixpro RIGHT OUTER JOIN
                   dbo.T_OrderSale ON dbo.T_fixpro.id = dbo.T_OrderSale.ProId
GO
/****** Object:  View [dbo].[T_allS]    Script Date: 2019/5/14 19:01:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[T_allS]
AS
SELECT  dbo.T_ALLsale.id, dbo.T_ALLsale.number, dbo.T_ALLsale.orderid, dbo.T_customer.ID AS Cid, dbo.T_ALLsale.Cusid, 
                   dbo.T_customer.CusShort, dbo.T_ALLsale.Pid, dbo.T_ALLsale.ProductName, dbo.T_ALLsale.TypeId, 
                   dbo.T_ALLsale.ProductType, dbo.T_ALLsale.MaterialId, dbo.T_ALLsale.MaterialName, dbo.T_ALLsale.PLength, 
                   dbo.T_ALLsale.Pwide, dbo.T_ALLsale.Pheight, dbo.T_ALLsale.unit, dbo.T_ALLsale.quantity, dbo.T_ALLsale.price, 
                   dbo.T_ALLsale.Memo, dbo.T_ALLsale.Yingshua, dbo.T_ALLsale.Zhanjiao, dbo.T_ALLsale.Dading, dbo.T_ALLsale.fatherid, 
                   dbo.T_ALLsale.OrderQuantity, dbo.T_ALLsale.indate, dbo.T_ALLsale.orderperson, dbo.T_ALLsale.orderdate, 
                   dbo.T_ALLsale.status, dbo.T_ALLsale.checkperson, dbo.T_ALLsale.checktime, dbo.T_ALLsale.deliverytime, 
                   dbo.T_ALLsale.OrderMemo
FROM      dbo.T_customer INNER JOIN
                   dbo.T_ALLsale ON dbo.T_customer.CusID = dbo.T_ALLsale.Cusid
GO
/****** Object:  View [dbo].[T_manu]    Script Date: 2019/5/14 19:01:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[T_manu]
AS
SELECT  dbo.T_ManuOrder.id, dbo.T_ManuOrder.ManuID, dbo.T_ManuOrder.ManuPerson, dbo.T_ManuOrder.MaterialSize, 
                   dbo.T_allS.id AS ZhuanAnID, dbo.T_allS.number, dbo.T_allS.orderid, dbo.T_allS.Cid, dbo.T_allS.CusShort, dbo.T_allS.Cusid, 
                   dbo.T_allS.Pid, dbo.T_allS.ProductName, dbo.T_allS.TypeId, dbo.T_allS.ProductType, dbo.T_allS.MaterialId, 
                   dbo.T_allS.MaterialName, dbo.T_allS.PLength, dbo.T_allS.Pwide, dbo.T_allS.Pheight, dbo.T_allS.unit, dbo.T_allS.quantity, 
                   dbo.T_allS.price, dbo.T_ManuOrder.AllMaterialQuantity, dbo.T_allS.Memo, dbo.T_allS.Yingshua, dbo.T_allS.Zhanjiao, 
                   dbo.T_allS.Dading, dbo.T_allS.OrderQuantity, dbo.T_allS.indate, dbo.T_allS.deliverytime, dbo.T_allS.orderdate, 
                   dbo.T_allS.OrderMemo, dbo.T_allS.status
FROM      dbo.T_ManuOrder RIGHT OUTER JOIN
                   dbo.T_allS ON dbo.T_ManuOrder.ZhuanAnId = dbo.T_allS.id
GO
/****** Object:  View [dbo].[T_ManuS]    Script Date: 2019/5/14 19:01:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[T_ManuS]
AS
SELECT  dbo.T_manu.id, dbo.T_manu.ManuID, dbo.T_manu.ManuPerson, dbo.T_Bom.bomid, dbo.T_Bom.BomName, 
                   dbo.T_Bom.BomSize, dbo.T_Bom.Unitquantity, dbo.T_manu.AllMaterialQuantity, dbo.T_manu.ZhuanAnID, 
                   dbo.T_manu.number, dbo.T_manu.orderid, dbo.T_manu.CusShort, dbo.T_manu.Cusid, dbo.T_manu.Pid, 
                   dbo.T_manu.ProductName, dbo.T_manu.MaterialName, dbo.T_manu.PLength, dbo.T_manu.Pwide, dbo.T_manu.Pheight, 
                   dbo.T_manu.unit, dbo.T_manu.Memo, dbo.T_manu.OrderQuantity, dbo.T_manu.deliverytime, dbo.T_manu.orderdate, 
                   dbo.T_manu.OrderMemo, dbo.T_manu.ProductType, dbo.T_manu.Cid, dbo.T_Bom.Stock, dbo.T_manu.MaterialId
FROM      dbo.T_manu LEFT OUTER JOIN
                   dbo.T_Bom ON dbo.T_manu.Pid = dbo.T_Bom.proid
GO
/****** Object:  View [dbo].[T_pur]    Script Date: 2019/5/14 19:01:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[T_pur]
AS
SELECT  dbo.T_PurchaseOrder.id, dbo.T_PurchaseOrder.PurchaseId, dbo.T_ManuS.bomid, dbo.T_ManuS.ZhuanAnID, 
                   dbo.T_ManuS.CusShort, dbo.T_ManuS.ProductName, dbo.T_ManuS.MaterialName, dbo.T_ManuS.BomSize, 
                   dbo.T_PurchaseOrder.Supid, dbo.T_ManuS.AllMaterialQuantity, dbo.T_ManuS.Stock AS MatStock, 
                   dbo.T_PurchaseOrder.PurchaseQuantity, dbo.T_ManuS.ManuID, dbo.T_PurchaseOrder.PurchaseDate, 
                   dbo.T_PurchaseOrder.DeliveryDate, dbo.T_PurchaseOrder.PurchasePerson, dbo.T_PurchaseOrder.memo, 
                   dbo.T_ManuS.MaterialId, dbo.T_PurchaseOrder.price
FROM      dbo.T_ManuS FULL OUTER JOIN
                   dbo.T_PurchaseOrder ON dbo.T_ManuS.ZhuanAnID = dbo.T_PurchaseOrder.ZhuanAnId
GO
/****** Object:  View [dbo].[T_MatBOM]    Script Date: 2019/5/14 19:01:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[T_MatBOM]
AS
SELECT  dbo.T_Bom.bomid, dbo.T_Bom.BomName, dbo.T_Bom.BomSize, dbo.T_Bom.BomUnit, dbo.T_Bom.Materialid, 
                   dbo.T_material.materialName
FROM      dbo.T_Bom LEFT OUTER JOIN
                   dbo.T_material ON dbo.T_Bom.Materialid = dbo.T_material.materialId
GO
/****** Object:  View [dbo].[T_BomPrice]    Script Date: 2019/5/14 19:01:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[T_BomPrice]
AS
SELECT  dbo.T_MatBOM.bomid, dbo.T_MatBOM.BomName, dbo.T_MatBOM.BomSize, dbo.T_MatBOM.BomUnit, 
                   dbo.T_MatBOM.Materialid, dbo.T_MatBOM.materialName, dbo.T_SupplierPrice.Materialprice, dbo.T_SupplierPrice.SupId, 
                   dbo.T_SupplierPrice.SupShort, dbo.T_SupplierPrice.id
FROM      dbo.T_MatBOM LEFT OUTER JOIN
                   dbo.T_SupplierPrice ON dbo.T_MatBOM.Materialid = dbo.T_SupplierPrice.MaterialId
GO
/****** Object:  View [dbo].[T_purprice]    Script Date: 2019/5/14 19:01:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[T_purprice]
AS
SELECT  dbo.T_pur.id, dbo.T_pur.PurchaseId, dbo.T_pur.bomid, dbo.T_BomPrice.SupShort, dbo.T_BomPrice.SupId, 
                   dbo.T_BomPrice.Materialprice, dbo.T_BomPrice.id AS zizeng, dbo.T_pur.MaterialName, dbo.T_pur.BomSize, 
                   dbo.T_pur.PurchaseQuantity, dbo.T_pur.DeliveryDate, dbo.T_pur.ZhuanAnID, dbo.T_pur.CusShort, 
                   dbo.T_pur.ProductName, dbo.T_pur.AllMaterialQuantity, dbo.T_pur.MatStock
FROM      dbo.T_BomPrice FULL OUTER JOIN
                   dbo.T_pur ON dbo.T_BomPrice.bomid = dbo.T_pur.bomid
GO
/****** Object:  View [dbo].[T_SupPur]    Script Date: 2019/5/14 19:01:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[T_SupPur]
AS
SELECT  dbo.T_pur.id, dbo.T_pur.PurchaseId, dbo.T_pur.bomid, dbo.T_pur.ZhuanAnID, dbo.T_pur.CusShort, 
                   dbo.T_pur.ProductName, dbo.T_pur.MaterialName, dbo.T_pur.BomSize, dbo.T_pur.Supid, dbo.T_supplier.SupShort, 
                   dbo.T_pur.AllMaterialQuantity, dbo.T_pur.MatStock, dbo.T_pur.PurchaseQuantity, dbo.T_pur.ManuID, 
                   dbo.T_pur.PurchaseDate, dbo.T_pur.DeliveryDate, dbo.T_pur.PurchasePerson, dbo.T_pur.memo, dbo.T_pur.MaterialId, 
                   dbo.T_pur.price
FROM      dbo.T_pur LEFT OUTER JOIN
                   dbo.T_supplier ON dbo.T_pur.Supid = dbo.T_supplier.SupId
GO
/****** Object:  View [dbo].[T_MatIn]    Script Date: 2019/5/14 19:01:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[T_MatIn]
AS
SELECT  dbo.T_MaterialIn.id, dbo.T_MaterialIn.MatInId, dbo.T_pur.ZhuanAnID, dbo.T_pur.id AS Purid, dbo.T_pur.PurchaseId, 
                   dbo.T_pur.MaterialName, dbo.T_pur.Supid, dbo.T_pur.BomSize, dbo.T_pur.PurchaseQuantity, dbo.T_pur.DeliveryDate, 
                   dbo.T_pur.PurchaseDate, dbo.T_MaterialIn.MatQuantity, dbo.T_pur.price, dbo.T_MaterialIn.MatDate, 
                   dbo.T_MaterialIn.MatinQuantity
FROM      dbo.T_pur FULL OUTER JOIN
                   dbo.T_MaterialIn ON dbo.T_pur.id = dbo.T_MaterialIn.PurId
GO
/****** Object:  View [dbo].[T_MatIn2]    Script Date: 2019/5/14 19:01:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[T_MatIn2]
AS
SELECT  dbo.T_MatIn.id, dbo.T_MatIn.MatInId, dbo.T_MatIn.Purid, dbo.T_MatIn.PurchaseId, dbo.T_MatIn.MaterialName, 
                   dbo.T_MatIn.Supid, dbo.T_supplier.SupShort, dbo.T_MatIn.BomSize, dbo.T_MatIn.PurchaseQuantity, 
                   dbo.T_MatIn.DeliveryDate, dbo.T_MatIn.PurchaseDate, dbo.T_MatIn.MatQuantity, dbo.T_MatIn.ZhuanAnID, 
                   dbo.T_MatIn.price, dbo.T_MatIn.MatDate, dbo.T_MatIn.MatinQuantity
FROM      dbo.T_supplier FULL OUTER JOIN
                   dbo.T_MatIn ON dbo.T_supplier.SupId = dbo.T_MatIn.Supid
GO
/****** Object:  View [dbo].[T_Matin3]    Script Date: 2019/5/14 19:01:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[T_Matin3]
AS
SELECT  dbo.T_MatIn2.MatInId, dbo.T_MatIn2.Purid, dbo.T_MatIn2.id AS MatinUid, dbo.T_MatIn2.PurchaseId, dbo.T_pur.ZhuanAnID, 
                   dbo.T_pur.CusShort, dbo.T_pur.ProductName, dbo.T_pur.PurchaseQuantity, dbo.T_MatIn2.MatQuantity
FROM      dbo.T_pur FULL OUTER JOIN
                   dbo.T_MatIn2 ON dbo.T_pur.id = dbo.T_MatIn2.Purid
GO
/****** Object:  View [dbo].[Mau2]    Script Date: 2019/5/14 19:01:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Mau2]
AS
SELECT  dbo.T_ManuOrder.id, dbo.T_ManuOrder.ManuID, dbo.T_ManuOrder.ManuPerson, dbo.T_ManuOrder.MaterialSize, 
                   dbo.T_allS.id AS Expr1, dbo.T_allS.number, dbo.T_allS.orderid, dbo.T_allS.Cid, dbo.T_allS.CusShort, dbo.T_allS.Cusid, 
                   dbo.T_allS.Pid, dbo.T_allS.ProductName, dbo.T_allS.TypeId, dbo.T_allS.ProductType, dbo.T_allS.MaterialId, 
                   dbo.T_allS.MaterialName, dbo.T_allS.PLength, dbo.T_allS.Pwide, dbo.T_allS.Pheight, dbo.T_allS.unit, dbo.T_allS.quantity, 
                   dbo.T_allS.price, dbo.T_ManuOrder.AllMaterialQuantity, dbo.T_allS.Memo, dbo.T_allS.Yingshua, dbo.T_allS.Zhanjiao, 
                   dbo.T_allS.Dading, dbo.T_allS.OrderQuantity, dbo.T_allS.indate, dbo.T_allS.deliverytime, dbo.T_allS.orderdate, 
                   dbo.T_allS.OrderMemo
FROM      dbo.T_ManuOrder RIGHT OUTER JOIN
                   dbo.T_allS ON dbo.T_ManuOrder.ZhuanAnId = dbo.T_allS.id
GO
/****** Object:  View [dbo].[T_proIn]    Script Date: 2019/5/14 19:01:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[T_proIn]
AS
SELECT  dbo.T_ProductIn.id, dbo.T_ProductIn.ProInId, dbo.T_allS.id AS zhuananid, dbo.T_allS.CusShort, dbo.T_allS.ProductName, 
                   dbo.T_allS.ProductType, dbo.T_allS.PLength, dbo.T_allS.Pwide, dbo.T_allS.Pheight, dbo.T_allS.unit, 
                   dbo.T_allS.MaterialName, dbo.T_allS.OrderQuantity, dbo.T_ProductIn.ProInQuantity, dbo.T_ProductIn.ProQuantity, 
                   dbo.T_ProductIn.ProIndate
FROM      dbo.T_ProductIn FULL OUTER JOIN
                   dbo.T_allS ON dbo.T_ProductIn.zhuananID = dbo.T_allS.id
GO
/****** Object:  View [dbo].[T_DelOut]    Script Date: 2019/5/14 19:01:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[T_DelOut]
AS
SELECT  dbo.T_DeliveryOut.id, dbo.T_DeliveryOut.DeliveryId, dbo.T_allS.id AS Zhuananid, dbo.T_allS.orderid, dbo.T_allS.CusShort, 
                   dbo.T_allS.ProductName, dbo.T_allS.ProductType, dbo.T_allS.MaterialName, dbo.T_allS.PLength, dbo.T_allS.Pwide, 
                   dbo.T_allS.Pheight, dbo.T_allS.unit, dbo.T_DeliveryOut.DeliveryInDate, dbo.T_allS.OrderQuantity, 
                   dbo.T_DeliveryOut.DeliveryQuantity, dbo.T_DeliveryOut.DeliveryOutQuantity, dbo.T_allS.deliverytime, dbo.T_allS.price, 
                   dbo.T_DeliveryOut.CarPerson
FROM      dbo.T_DeliveryOut FULL OUTER JOIN
                   dbo.T_allS ON dbo.T_DeliveryOut.zhuananid = dbo.T_allS.id
GO
/****** Object:  View [dbo].[testp]    Script Date: 2019/5/14 19:01:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[testp]
AS
SELECT  dbo.T_ALLsale.id, dbo.T_ALLsale.number, dbo.T_ALLsale.orderid, dbo.T_customer.ID AS Cid, dbo.T_ALLsale.Cusid, 
                   dbo.T_customer.CusShort, dbo.T_ALLsale.Pid, dbo.T_ALLsale.ProductName, dbo.T_ALLsale.TypeId, 
                   dbo.T_ALLsale.ProductType, dbo.T_ALLsale.MaterialId, dbo.T_ALLsale.MaterialName, dbo.T_ALLsale.PLength, 
                   dbo.T_ALLsale.Pwide, dbo.T_ALLsale.Pheight, dbo.T_ALLsale.unit, dbo.T_ALLsale.quantity, dbo.T_ALLsale.price, 
                   dbo.T_ALLsale.Memo AS yisong, dbo.T_ALLsale.Yingshua, dbo.T_ALLsale.Zhanjiao, dbo.T_ALLsale.Dading, 
                   dbo.T_ALLsale.fatherid, dbo.T_ALLsale.OrderQuantity, dbo.T_ALLsale.indate, dbo.T_ALLsale.orderperson, 
                   dbo.T_ALLsale.orderdate, dbo.T_ALLsale.status, dbo.T_ALLsale.checkperson, dbo.T_ALLsale.checktime, 
                   dbo.T_ALLsale.deliverytime, dbo.T_ALLsale.OrderMemo AS weisong
FROM      dbo.T_customer INNER JOIN
                   dbo.T_ALLsale ON dbo.T_customer.CusID = dbo.T_ALLsale.Cusid
GO
/****** Object:  View [dbo].[T_allproduct]    Script Date: 2019/5/14 19:01:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[T_allproduct]
AS
SELECT  dbo.T_FixBox.id AS boxID, dbo.T_FixBox.CusId AS BoxCusid, dbo.T_FixBox.ProductName AS BoxProductName, 
                   dbo.T_FixBox.TypeId AS BoxTypeid, dbo.T_FixBox.ProductType AS Boxproducttype, 
                   dbo.T_FixBox.MaterialId AS BoxmateriID, dbo.T_FixBox.MaterialName AS BoxMaterialName, 
                   dbo.T_FixBox.PLength AS BoxPlength, dbo.T_FixBox.Pwide AS BoxPwide, dbo.T_FixBox.Pheight AS BoxPheight, 
                   dbo.T_FixBox.unit AS Boxunit, dbo.T_FixBox.quantity AS Boxquantity, dbo.T_FixBox.price AS Boxprice, 
                   dbo.T_FixBox.Memo AS BoxMemo, dbo.T_FixBox.Yingshua AS BoxYinghua, dbo.T_FixBox.Zhanjiao AS Boxzhanjiao, 
                   dbo.T_FixBox.Dading AS BoxDading, dbo.T_FixPair.fittingName, dbo.T_FixPair.TypeID AS pairTypeid, dbo.T_FixPair.Type, 
                   dbo.T_FixPair.materialID AS paimaterialid, dbo.T_FixPair.materialName AS paiMaterialName, dbo.T_FixPair.Flength, 
                   dbo.T_FixPair.Fwide, dbo.T_FixPair.Fheight, dbo.T_FixPair.unit AS pairunit, dbo.T_FixPair.quantity AS pairQuantity, 
                   dbo.T_FixPair.price AS Pairprice, dbo.T_FixPair.yingshua AS PairYingshua, dbo.T_FixPair.zhanjiao AS PairZhanjiao, 
                   dbo.T_FixPair.dading AS PairDading, dbo.T_FixPair.FatherId AS PairFatherid, dbo.T_FixPair.memo AS pairMemo
FROM      dbo.T_FixBox LEFT OUTER JOIN
                   dbo.T_FixPair ON dbo.T_FixBox.id = dbo.T_FixPair.FatherId
GO
/****** Object:  View [dbo].[T_bomall]    Script Date: 2019/5/14 19:01:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[T_bomall]
AS
SELECT  dbo.T_fixpro.id, dbo.T_fixpro.ProductName, dbo.T_fixpro.PLength, dbo.T_fixpro.Pwide, dbo.T_fixpro.Pheight, 
                   dbo.T_fixpro.quantity, dbo.T_Bom.BomName, dbo.T_Bom.bomid, dbo.T_Bom.BomSize, dbo.T_Bom.Unitquantity, 
                   dbo.T_Bom.BomUnit, dbo.T_Bom.Bomfrom, dbo.T_Bom.Bili
FROM      dbo.T_fixpro LEFT OUTER JOIN
                   dbo.T_Bom ON dbo.T_fixpro.id = dbo.T_Bom.proid
GO
/****** Object:  View [dbo].[T_MatStock]    Script Date: 2019/5/14 19:01:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[T_MatStock]
AS
SELECT  dbo.T_Bom.bomid, dbo.T_Bom.BomName, dbo.T_Bom.BomSize, dbo.T_MaterialStock.MaterialStockQuantity
FROM      dbo.T_Bom LEFT OUTER JOIN
                   dbo.T_MaterialStock ON dbo.T_Bom.bomid = dbo.T_MaterialStock.Bomid
GO
/****** Object:  View [dbo].[T_ProductStock]    Script Date: 2019/5/14 19:01:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[T_ProductStock]
AS
SELECT  dbo.T_fixpro.id, dbo.T_fixpro.ProductName, dbo.T_fixpro.PLength, dbo.T_fixpro.Pwide, dbo.T_fixpro.Pheight, 
                   dbo.T_ProStock.ProStockQuantity
FROM      dbo.T_fixpro LEFT OUTER JOIN
                   dbo.T_ProStock ON dbo.T_fixpro.id = dbo.T_ProStock.Pid
GO
ALTER TABLE [dbo].[T_Bom] ADD  CONSTRAINT [DF_T_Bom_Stock]  DEFAULT ((0)) FOR [Stock]
GO
ALTER TABLE [dbo].[T_DeliveryOut] ADD  CONSTRAINT [DF_T_DeliveryOut_DeliveryQuantity]  DEFAULT ((0)) FOR [DeliveryQuantity]
GO
ALTER TABLE [dbo].[T_DeliveryOut] ADD  CONSTRAINT [DF_T_DeliveryOut_DeliveryOutQuantity]  DEFAULT ((0)) FOR [DeliveryOutQuantity]
GO
ALTER TABLE [dbo].[T_FixBox1] ADD  CONSTRAINT [DF__T_FixBox__Yingsh__05D8E0BE]  DEFAULT (N'false') FOR [Yingshua]
GO
ALTER TABLE [dbo].[T_FixBox1] ADD  CONSTRAINT [DF_T_FixBox_Zhanjiao]  DEFAULT (N'false') FOR [Zhanjiao]
GO
ALTER TABLE [dbo].[T_FixBox1] ADD  CONSTRAINT [DF_T_FixBox_Dading]  DEFAULT (N'false') FOR [Dading]
GO
ALTER TABLE [dbo].[T_FixPair1] ADD  CONSTRAINT [DF_T_FixPair_yingshua]  DEFAULT ('false') FOR [yingshua]
GO
ALTER TABLE [dbo].[T_FixPair1] ADD  CONSTRAINT [DF_T_FixPair_zhanjiao]  DEFAULT ('false') FOR [zhanjiao]
GO
ALTER TABLE [dbo].[T_FixPair1] ADD  CONSTRAINT [DF_T_FixPair_dading]  DEFAULT ('false') FOR [dading]
GO
ALTER TABLE [dbo].[T_fixpro] ADD  CONSTRAINT [DF_T_fixpro_Pheight]  DEFAULT ((0)) FOR [Pheight]
GO
ALTER TABLE [dbo].[T_fixpro] ADD  CONSTRAINT [DF_T_fixpro_Yingshua]  DEFAULT (N'false') FOR [Yingshua]
GO
ALTER TABLE [dbo].[T_fixpro] ADD  CONSTRAINT [DF_T_fixpro_Zhanjiao]  DEFAULT (N'false') FOR [Zhanjiao]
GO
ALTER TABLE [dbo].[T_fixpro] ADD  CONSTRAINT [DF_T_fixpro_Dading]  DEFAULT (N'false') FOR [Dading]
GO
ALTER TABLE [dbo].[T_fixpro] ADD  CONSTRAINT [DF_T_fixpro_Stock]  DEFAULT ((0)) FOR [Stock]
GO
ALTER TABLE [dbo].[T_MaterialIn] ADD  CONSTRAINT [DF_T_MaterialIn_MatQuantity]  DEFAULT ((0)) FOR [MatQuantity]
GO
ALTER TABLE [dbo].[T_OrderSale] ADD  CONSTRAINT [DF_T_OrderSale_status]  DEFAULT ('待审') FOR [status]
GO
ALTER TABLE [dbo].[T_ProductIn] ADD  CONSTRAINT [DF_T_ProductIn_ProInQuantity]  DEFAULT ((0)) FOR [ProInQuantity]
GO
ALTER TABLE [dbo].[T_ProductIn] ADD  CONSTRAINT [DF_T_ProductIn_ProQuantity]  DEFAULT ((0)) FOR [ProQuantity]
GO
ALTER TABLE [dbo].[T_PurchaseOrder] ADD  CONSTRAINT [DF_T_PurchaseOrder_MatQuantity]  DEFAULT ((0)) FOR [MatQuantity]
GO
ALTER TABLE [dbo].[T_SaleOrder2] ADD  CONSTRAINT [DF_T_SaleOrder_number]  DEFAULT ((1)) FOR [number]
GO
ALTER TABLE [dbo].[T_SaleOrder2] ADD  CONSTRAINT [DF_T_SaleOrder_status]  DEFAULT ('待审') FOR [status]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "T_ManuOrder"
            Begin Extent = 
               Top = 7
               Left = 48
               Bottom = 170
               Right = 284
            End
            DisplayFlags = 280
            TopColumn = 3
         End
         Begin Table = "T_allS"
            Begin Extent = 
               Top = 7
               Left = 332
               Bottom = 170
               Right = 532
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1176
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1356
         SortOrder = 1416
         GroupBy = 1350
         Filter = 1356
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Mau2'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Mau2'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[44] 4[38] 2[3] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "T_FixBox"
            Begin Extent = 
               Top = 7
               Left = 48
               Bottom = 170
               Right = 246
            End
            DisplayFlags = 280
            TopColumn = 5
         End
         Begin Table = "T_FixPair"
            Begin Extent = 
               Top = 7
               Left = 294
               Bottom = 170
               Right = 491
            End
            DisplayFlags = 280
            TopColumn = 12
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1176
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1356
         SortOrder = 1416
         GroupBy = 1350
         Filter = 1356
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'T_allproduct'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'T_allproduct'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "T_customer"
            Begin Extent = 
               Top = 7
               Left = 48
               Bottom = 170
               Right = 247
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "T_ALLsale"
            Begin Extent = 
               Top = 7
               Left = 295
               Bottom = 170
               Right = 495
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'T_allS'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'T_allS'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "T_fixpro"
            Begin Extent = 
               Top = 7
               Left = 48
               Bottom = 170
               Right = 246
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "T_OrderSale"
            Begin Extent = 
               Top = 7
               Left = 294
               Bottom = 170
               Right = 482
            End
            DisplayFlags = 280
            TopColumn = 5
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1176
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1356
         SortOrder = 1416
         GroupBy = 1350
         Filter = 1356
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'T_ALLsale'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'T_ALLsale'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "T_fixpro"
            Begin Extent = 
               Top = 7
               Left = 48
               Bottom = 170
               Right = 246
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "T_Bom"
            Begin Extent = 
               Top = 7
               Left = 294
               Bottom = 170
               Right = 479
            End
            DisplayFlags = 280
            TopColumn = 5
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1176
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1356
         SortOrder = 1416
         GroupBy = 1350
         Filter = 1356
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'T_bomall'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'T_bomall'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "T_MatBOM"
            Begin Extent = 
               Top = 39
               Left = 53
               Bottom = 202
               Right = 250
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "T_SupplierPrice"
            Begin Extent = 
               Top = 38
               Left = 294
               Bottom = 201
               Right = 492
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'T_BomPrice'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'T_BomPrice'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "T_DeliveryOut"
            Begin Extent = 
               Top = 19
               Left = 365
               Bottom = 182
               Right = 608
            End
            DisplayFlags = 280
            TopColumn = 6
         End
         Begin Table = "T_allS"
            Begin Extent = 
               Top = 10
               Left = 78
               Bottom = 173
               Right = 278
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1176
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1356
         SortOrder = 1416
         GroupBy = 1350
         Filter = 1356
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'T_DelOut'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'T_DelOut'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[42] 4[15] 2[25] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = -840
         Left = 0
      End
      Begin Tables = 
         Begin Table = "T_ManuOrder"
            Begin Extent = 
               Top = 7
               Left = 48
               Bottom = 170
               Right = 239
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "T_allS"
            Begin Extent = 
               Top = 7
               Left = 287
               Bottom = 170
               Right = 487
            End
            DisplayFlags = 280
            TopColumn = 27
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 2148
         Alias = 1980
         Table = 1176
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1356
         SortOrder = 1416
         GroupBy = 1350
         Filter = 1356
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'T_manu'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'T_manu'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "T_manu"
            Begin Extent = 
               Top = 7
               Left = 48
               Bottom = 170
               Right = 265
            End
            DisplayFlags = 280
            TopColumn = 13
         End
         Begin Table = "T_Bom"
            Begin Extent = 
               Top = 7
               Left = 313
               Bottom = 170
               Right = 498
            End
            DisplayFlags = 280
            TopColumn = 5
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1176
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1356
         SortOrder = 1416
         GroupBy = 1350
         Filter = 1356
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'T_ManuS'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'T_ManuS'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "T_Bom"
            Begin Extent = 
               Top = 7
               Left = 48
               Bottom = 170
               Right = 233
            End
            DisplayFlags = 280
            TopColumn = 6
         End
         Begin Table = "T_material"
            Begin Extent = 
               Top = 7
               Left = 281
               Bottom = 170
               Right = 478
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1176
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1356
         SortOrder = 1416
         GroupBy = 1350
         Filter = 1356
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'T_MatBOM'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'T_MatBOM'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "T_pur"
            Begin Extent = 
               Top = 7
               Left = 48
               Bottom = 170
               Right = 284
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "T_MaterialIn"
            Begin Extent = 
               Top = 7
               Left = 332
               Bottom = 170
               Right = 519
            End
            DisplayFlags = 280
            TopColumn = 6
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1176
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1356
         SortOrder = 1416
         GroupBy = 1350
         Filter = 1356
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'T_MatIn'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'T_MatIn'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "T_supplier"
            Begin Extent = 
               Top = 7
               Left = 48
               Bottom = 170
               Right = 249
            End
            DisplayFlags = 280
            TopColumn = 4
         End
         Begin Table = "T_MatIn"
            Begin Extent = 
               Top = 7
               Left = 297
               Bottom = 170
               Right = 519
            End
            DisplayFlags = 280
            TopColumn = 2
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1176
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1356
         SortOrder = 1416
         GroupBy = 1350
         Filter = 1356
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'T_MatIn2'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'T_MatIn2'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "T_pur"
            Begin Extent = 
               Top = 7
               Left = 48
               Bottom = 170
               Right = 284
            End
            DisplayFlags = 280
            TopColumn = 2
         End
         Begin Table = "T_MatIn2"
            Begin Extent = 
               Top = 7
               Left = 332
               Bottom = 170
               Right = 554
            End
            DisplayFlags = 280
            TopColumn = 2
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1176
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1356
         SortOrder = 1416
         GroupBy = 1350
         Filter = 1356
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'T_Matin3'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'T_Matin3'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "T_Bom"
            Begin Extent = 
               Top = 7
               Left = 48
               Bottom = 170
               Right = 233
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "T_MaterialStock"
            Begin Extent = 
               Top = 7
               Left = 281
               Bottom = 126
               Right = 539
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'T_MatStock'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'T_MatStock'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "T_fixpro"
            Begin Extent = 
               Top = 58
               Left = 156
               Bottom = 221
               Right = 354
            End
            DisplayFlags = 280
            TopColumn = 13
         End
         Begin Table = "T_ProStock"
            Begin Extent = 
               Top = 50
               Left = 486
               Bottom = 191
               Right = 680
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1176
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1356
         SortOrder = 1416
         GroupBy = 1350
         Filter = 1356
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'T_ProductStock'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'T_ProductStock'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "T_ProductIn"
            Begin Extent = 
               Top = 46
               Left = 309
               Bottom = 207
               Right = 503
            End
            DisplayFlags = 280
            TopColumn = 2
         End
         Begin Table = "T_allS"
            Begin Extent = 
               Top = 28
               Left = 68
               Bottom = 191
               Right = 268
            End
            DisplayFlags = 280
            TopColumn = 15
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1176
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1356
         SortOrder = 1416
         GroupBy = 1350
         Filter = 1356
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'T_proIn'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'T_proIn'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[33] 4[33] 2[24] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "T_ManuS"
            Begin Extent = 
               Top = 7
               Left = 318
               Bottom = 170
               Right = 554
            End
            DisplayFlags = 280
            TopColumn = 10
         End
         Begin Table = "T_PurchaseOrder"
            Begin Extent = 
               Top = 7
               Left = 48
               Bottom = 170
               Right = 270
            End
            DisplayFlags = 280
            TopColumn = 7
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1176
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1356
         SortOrder = 1416
         GroupBy = 1350
         Filter = 1356
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'T_pur'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'T_pur'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "T_BomPrice"
            Begin Extent = 
               Top = 7
               Left = 48
               Bottom = 170
               Right = 245
            End
            DisplayFlags = 280
            TopColumn = 6
         End
         Begin Table = "T_pur"
            Begin Extent = 
               Top = 7
               Left = 293
               Bottom = 170
               Right = 529
            End
            DisplayFlags = 280
            TopColumn = 14
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 2088
         Alias = 900
         Table = 1176
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1356
         SortOrder = 1416
         GroupBy = 1350
         Filter = 1356
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'T_purprice'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'T_purprice'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[20] 4[41] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "T_pur"
            Begin Extent = 
               Top = 7
               Left = 48
               Bottom = 170
               Right = 284
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "T_supplier"
            Begin Extent = 
               Top = 7
               Left = 332
               Bottom = 170
               Right = 533
            End
            DisplayFlags = 280
            TopColumn = 1
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1176
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1356
         SortOrder = 1416
         GroupBy = 1350
         Filter = 1356
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'T_SupPur'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'T_SupPur'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "T_customer"
            Begin Extent = 
               Top = 7
               Left = 48
               Bottom = 170
               Right = 247
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "T_ALLsale"
            Begin Extent = 
               Top = 7
               Left = 295
               Bottom = 170
               Right = 495
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1176
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1356
         SortOrder = 1416
         GroupBy = 1350
         Filter = 1356
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'testp'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'testp'
GO
