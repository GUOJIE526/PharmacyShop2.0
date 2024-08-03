USE [master]
GO
/****** Object:  Database [pharmacy]    Script Date: 2024/8/4 上午 01:24:10 ******/
CREATE DATABASE [pharmacy]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'pharmacy', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\pharmacy.mdf' , SIZE = 73728KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'pharmacy_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\pharmacy_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [pharmacy] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [pharmacy].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [pharmacy] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [pharmacy] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [pharmacy] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [pharmacy] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [pharmacy] SET ARITHABORT OFF 
GO
ALTER DATABASE [pharmacy] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [pharmacy] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [pharmacy] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [pharmacy] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [pharmacy] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [pharmacy] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [pharmacy] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [pharmacy] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [pharmacy] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [pharmacy] SET  DISABLE_BROKER 
GO
ALTER DATABASE [pharmacy] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [pharmacy] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [pharmacy] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [pharmacy] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [pharmacy] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [pharmacy] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [pharmacy] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [pharmacy] SET RECOVERY FULL 
GO
ALTER DATABASE [pharmacy] SET  MULTI_USER 
GO
ALTER DATABASE [pharmacy] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [pharmacy] SET DB_CHAINING OFF 
GO
ALTER DATABASE [pharmacy] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [pharmacy] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [pharmacy] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [pharmacy] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'pharmacy', N'ON'
GO
ALTER DATABASE [pharmacy] SET QUERY_STORE = ON
GO
ALTER DATABASE [pharmacy] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [pharmacy]
GO
/****** Object:  Table [dbo].[baby]    Script Date: 2024/8/4 上午 01:24:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[baby](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](max) NULL,
	[price] [int] NULL,
	[qty] [int] NULL,
	[photo] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[beauty]    Script Date: 2024/8/4 上午 01:24:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[beauty](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](max) NULL,
	[price] [int] NULL,
	[qty] [int] NULL,
	[photo] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[customer]    Script Date: 2024/8/4 上午 01:24:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[customer](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](max) NULL,
	[password] [nvarchar](max) NULL,
	[phone] [nvarchar](max) NULL,
	[email] [nvarchar](max) NULL,
	[address] [nvarchar](max) NULL,
	[createdate] [date] NULL,
	[updatetime] [date] NULL,
	[lv] [int] NULL,
 CONSTRAINT [PK__customer__3213E83F7B83266D] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[employee]    Script Date: 2024/8/4 上午 01:24:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[employee](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](max) NULL,
	[password] [nvarchar](max) NULL,
	[phone] [nvarchar](max) NULL,
	[email] [nvarchar](max) NULL,
	[address] [nvarchar](max) NULL,
	[createdate] [date] NULL,
	[updatetime] [date] NULL,
	[lv] [int] NULL,
 CONSTRAINT [PK__employee__3213E83F1C70904F] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[historycart]    Script Date: 2024/8/4 上午 01:24:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[historycart](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](max) NULL,
	[qty] [int] NULL,
	[price] [int] NULL,
	[cust_id] [int] NULL,
	[buydate] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[medicine]    Script Date: 2024/8/4 上午 01:24:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[medicine](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](max) NULL,
	[price] [int] NULL,
	[qty] [int] NULL,
	[photo] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[orditem]    Script Date: 2024/8/4 上午 01:24:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[orditem](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](max) NULL,
	[price] [int] NULL,
	[qty] [int] NULL,
	[cust_id] [int] NULL,
	[order_date] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[baby] ON 

INSERT [dbo].[baby] ([id], [name], [price], [qty], [photo]) VALUES (1, N'幫寶適一級幫', 350, 30, N'Pampers.png')
INSERT [dbo].[baby] ([id], [name], [price], [qty], [photo]) VALUES (2, N'妙而舒金緻柔點', 320, 30, N'妙而舒金緻.png')
INSERT [dbo].[baby] ([id], [name], [price], [qty], [photo]) VALUES (3, N'大王天使尿布', 380, 50, N'大王天使.png')
INSERT [dbo].[baby] ([id], [name], [price], [qty], [photo]) VALUES (4, N'麗貝樂', 310, 36, N'麗貝樂.png')
INSERT [dbo].[baby] ([id], [name], [price], [qty], [photo]) VALUES (5, N'滿意寶寶日本白金', 380, 20, N'MamyPoko.png')
INSERT [dbo].[baby] ([id], [name], [price], [qty], [photo]) VALUES (6, N'【Wyeth惠氏】S-26 金幼兒樂', 699, 22, N'S26金愛兒樂.png')
INSERT [dbo].[baby] ([id], [name], [price], [qty], [photo]) VALUES (7, N'【SNOW雪印】金T3PLUS成長營養配方', 725, 25, N'雪印T3.png')
INSERT [dbo].[baby] ([id], [name], [price], [qty], [photo]) VALUES (8, N'【亞培】心美力 HM.O幼兒成長配方', 1299, 25, N'亞培.png')
INSERT [dbo].[baby] ([id], [name], [price], [qty], [photo]) VALUES (9, N'【雀巢】能恩HA3', 789, 30, N'雀巢能恩水解.png')
INSERT [dbo].[baby] ([id], [name], [price], [qty], [photo]) VALUES (10, N'【Meiji 明治】金選1-3歲成長配方食品', 695, 33, N'明治.png')
SET IDENTITY_INSERT [dbo].[baby] OFF
GO
SET IDENTITY_INSERT [dbo].[beauty] ON 

INSERT [dbo].[beauty] ([id], [name], [price], [qty], [photo]) VALUES (1, N'SK-II 神仙水', 3500, 25, N'SK2.png')
INSERT [dbo].[beauty] ([id], [name], [price], [qty], [photo]) VALUES (2, N'雅詩蘭黛特潤精修精華', 4500, 30, N'雅詩蘭黛.png')
INSERT [dbo].[beauty] ([id], [name], [price], [qty], [photo]) VALUES (3, N'倩碧三步驟潔膚液', 4800, 23, N'倩碧.png')
INSERT [dbo].[beauty] ([id], [name], [price], [qty], [photo]) VALUES (4, N'蘭蔻小黑瓶精華', 3850, 50, N'蘭蔻.png')
INSERT [dbo].[beauty] ([id], [name], [price], [qty], [photo]) VALUES (5, N'資生堂紅顏肌活露', 5700, 29, N'資生堂肌紅.png')
INSERT [dbo].[beauty] ([id], [name], [price], [qty], [photo]) VALUES (6, N'DIOR生命之源奢華金萃2024珍鑲版', 112000, 30, N'dior金萃.png')
INSERT [dbo].[beauty] ([id], [name], [price], [qty], [photo]) VALUES (8, N'香奈兒COMETE幸運星辰', 14600, 35, N'香奈兒星辰.png')
INSERT [dbo].[beauty] ([id], [name], [price], [qty], [photo]) VALUES (9, N'MISS DIOR花漾迪奧', 3850, 25, N'DIOR奧迪花樣.png')
INSERT [dbo].[beauty] ([id], [name], [price], [qty], [photo]) VALUES (10, N'Gucci Bloom', 3800, 25, N'GUCCI.png')
INSERT [dbo].[beauty] ([id], [name], [price], [qty], [photo]) VALUES (11, N'Twilly Hermes淡香精', 6100, 25, N'愛馬仕.png')
INSERT [dbo].[beauty] ([id], [name], [price], [qty], [photo]) VALUES (12, N'Yves Saint Laurent Black Opium', 4000, 35, N'YSL.png')
SET IDENTITY_INSERT [dbo].[beauty] OFF
GO
SET IDENTITY_INSERT [dbo].[customer] ON 

INSERT [dbo].[customer] ([id], [name], [password], [phone], [email], [address], [createdate], [updatetime], [lv]) VALUES (1, N'gg', N'7788', N'09563807788', N'gg@gmail.com', N'高雄市前金區中正四路211號25樓', CAST(N'2024-07-27' AS Date), CAST(N'2024-08-02' AS Date), 1)
INSERT [dbo].[customer] ([id], [name], [password], [phone], [email], [address], [createdate], [updatetime], [lv]) VALUES (2, N'Eidth', N'7788', N'0912345678', N'ee@gmail.com', N'高雄市仁武區永新6街7788號', CAST(N'2024-07-30' AS Date), NULL, 1)
INSERT [dbo].[customer] ([id], [name], [password], [phone], [email], [address], [createdate], [updatetime], [lv]) VALUES (6, N'James', N'2873', N'0956287999', N'james@gmail.com', N'台北市大安區某某路41號', CAST(N'2024-07-05' AS Date), NULL, 1)
INSERT [dbo].[customer] ([id], [name], [password], [phone], [email], [address], [createdate], [updatetime], [lv]) VALUES (8, N'Robert', N'8599', N'0918432549', N'robert@gmail.com', N'台中市西屯區某某路99號', CAST(N'2024-10-11' AS Date), NULL, 1)
INSERT [dbo].[customer] ([id], [name], [password], [phone], [email], [address], [createdate], [updatetime], [lv]) VALUES (9, N'Michael', N'5690', N'0967242780', N'michael@gmail.com', N'高雄市苓雅區某某路47號', CAST(N'2024-05-20' AS Date), NULL, 1)
INSERT [dbo].[customer] ([id], [name], [password], [phone], [email], [address], [createdate], [updatetime], [lv]) VALUES (10, N'William', N'7972', N'0958892529', N'william@gmail.com', N'台南市中西區某某路82號', CAST(N'2024-02-28' AS Date), NULL, 1)
INSERT [dbo].[customer] ([id], [name], [password], [phone], [email], [address], [createdate], [updatetime], [lv]) VALUES (11, N'David', N'6249', N'0987245139', N'david@gmail.com', N'新竹市東區某某路66號', CAST(N'2024-06-14' AS Date), NULL, 1)
INSERT [dbo].[customer] ([id], [name], [password], [phone], [email], [address], [createdate], [updatetime], [lv]) VALUES (12, N'Richard', N'9485', N'0952489576', N'richard@gmail.com', N'桃園市中壢區某某路53號', CAST(N'2024-11-23' AS Date), NULL, 1)
INSERT [dbo].[customer] ([id], [name], [password], [phone], [email], [address], [createdate], [updatetime], [lv]) VALUES (13, N'Charles', N'4729', N'0917248571', N'charles@gmail.com', N'台北市信義區某某路12號', CAST(N'2024-04-09' AS Date), NULL, 1)
INSERT [dbo].[customer] ([id], [name], [password], [phone], [email], [address], [createdate], [updatetime], [lv]) VALUES (14, N'Joseph', N'3561', N'0912948576', N'joseph@gmail.com', N'新北市新店區某某路95號', CAST(N'2024-07-01' AS Date), NULL, 1)
INSERT [dbo].[customer] ([id], [name], [password], [phone], [email], [address], [createdate], [updatetime], [lv]) VALUES (15, N'Thomas', N'6148', N'0964847581', N'thomas@gmail.com', N'台中市北區某某路38號', CAST(N'2024-08-20' AS Date), NULL, 1)
INSERT [dbo].[customer] ([id], [name], [password], [phone], [email], [address], [createdate], [updatetime], [lv]) VALUES (16, N'Christopher', N'4721', N'0972847521', N'christopher@gmail.com', N'高雄市左營區某某路13號', CAST(N'2024-12-15' AS Date), NULL, 1)
INSERT [dbo].[customer] ([id], [name], [password], [phone], [email], [address], [createdate], [updatetime], [lv]) VALUES (17, N'Daniel', N'8347', N'0987248573', N'daniel@gmail.com', N'台南市東區某某路75號', CAST(N'2024-03-22' AS Date), NULL, 1)
INSERT [dbo].[customer] ([id], [name], [password], [phone], [email], [address], [createdate], [updatetime], [lv]) VALUES (18, N'Paul', N'9572', N'0972847510', N'paul@gmail.com', N'新竹市北區某某路41號', CAST(N'2024-01-13' AS Date), NULL, 1)
INSERT [dbo].[customer] ([id], [name], [password], [phone], [email], [address], [createdate], [updatetime], [lv]) VALUES (22, N'Kenneth', N'4729', N'0951847523', N'kenneth@gmail.com', N'台中市南區某某路14號', CAST(N'2024-02-28' AS Date), NULL, 1)
INSERT [dbo].[customer] ([id], [name], [password], [phone], [email], [address], [createdate], [updatetime], [lv]) VALUES (23, N'Steven', N'6217', N'0911847524', N'steven@gmail.com', N'高雄市鳳山區某某路95號', CAST(N'2024-07-17' AS Date), NULL, 1)
INSERT [dbo].[customer] ([id], [name], [password], [phone], [email], [address], [createdate], [updatetime], [lv]) VALUES (24, N'Edward', N'9274', N'0931847525', N'edward@gmail.com', N'台南市南區某某路73', CAST(N'2024-10-11' AS Date), NULL, 1)
SET IDENTITY_INSERT [dbo].[customer] OFF
GO
SET IDENTITY_INSERT [dbo].[employee] ON 

INSERT [dbo].[employee] ([id], [name], [password], [phone], [email], [address], [createdate], [updatetime], [lv]) VALUES (1, N'admin', N'admin', NULL, NULL, NULL, NULL, NULL, 1)
SET IDENTITY_INSERT [dbo].[employee] OFF
GO
SET IDENTITY_INSERT [dbo].[historycart] ON 

INSERT [dbo].[historycart] ([id], [name], [qty], [price], [cust_id], [buydate]) VALUES (1024, N'Nexcare 克淋濕防水透氣繃', 2, 90, 1, CAST(N'2024-07-29' AS Date))
INSERT [dbo].[historycart] ([id], [name], [qty], [price], [cust_id], [buydate]) VALUES (1025, N'海藻成人鈣加強錠2.0', 3, 2250, 1, CAST(N'2024-07-29' AS Date))
INSERT [dbo].[historycart] ([id], [name], [qty], [price], [cust_id], [buydate]) VALUES (1026, N'【Wyeth惠氏】S-26 金幼兒樂', 3, 1748, 1, CAST(N'2024-07-29' AS Date))
INSERT [dbo].[historycart] ([id], [name], [qty], [price], [cust_id], [buydate]) VALUES (1027, N'大王天使尿布', 3, 950, 1, CAST(N'2024-07-29' AS Date))
INSERT [dbo].[historycart] ([id], [name], [qty], [price], [cust_id], [buydate]) VALUES (1028, N'【Okamoto岡本】 002 Hydro水感勁薄', 3, 923, 1, CAST(N'2024-07-29' AS Date))
INSERT [dbo].[historycart] ([id], [name], [qty], [price], [cust_id], [buydate]) VALUES (1029, N'【雀巢】能恩HA3', 5, 3156, 1, CAST(N'2024-07-30' AS Date))
INSERT [dbo].[historycart] ([id], [name], [qty], [price], [cust_id], [buydate]) VALUES (1030, N'SK-II 神仙水', 2, 5250, 2, CAST(N'2024-07-30' AS Date))
INSERT [dbo].[historycart] ([id], [name], [qty], [price], [cust_id], [buydate]) VALUES (1031, N'雅詩蘭黛特潤精修精華', 2, 6750, 2, CAST(N'2024-07-30' AS Date))
INSERT [dbo].[historycart] ([id], [name], [qty], [price], [cust_id], [buydate]) VALUES (1032, N'倩碧三步驟潔膚液', 2, 7200, 2, CAST(N'2024-07-30' AS Date))
INSERT [dbo].[historycart] ([id], [name], [qty], [price], [cust_id], [buydate]) VALUES (1033, N'蘭蔻小黑瓶精華', 2, 5775, 2, CAST(N'2024-07-30' AS Date))
INSERT [dbo].[historycart] ([id], [name], [qty], [price], [cust_id], [buydate]) VALUES (1034, N'資生堂紅顏肌活露', 2, 8550, 2, CAST(N'2024-07-30' AS Date))
INSERT [dbo].[historycart] ([id], [name], [qty], [price], [cust_id], [buydate]) VALUES (1035, N'DIOR生命之源奢華金萃2024珍鑲版', 2, 168000, 2, CAST(N'2024-07-30' AS Date))
INSERT [dbo].[historycart] ([id], [name], [qty], [price], [cust_id], [buydate]) VALUES (1036, N'大王天使尿布', 3, 950, 1, CAST(N'2024-07-30' AS Date))
INSERT [dbo].[historycart] ([id], [name], [qty], [price], [cust_id], [buydate]) VALUES (1037, N'【Wyeth惠氏】S-26 金幼兒樂', 2, 1049, 1, CAST(N'2024-08-02' AS Date))
INSERT [dbo].[historycart] ([id], [name], [qty], [price], [cust_id], [buydate]) VALUES (1038, N'麗貝樂', 2, 465, 1, CAST(N'2024-08-02' AS Date))
INSERT [dbo].[historycart] ([id], [name], [qty], [price], [cust_id], [buydate]) VALUES (1046, N'【Lovita愛維他】胺基酸螯合鋅', 3, 1700, 11, CAST(N'2024-08-03' AS Date))
INSERT [dbo].[historycart] ([id], [name], [qty], [price], [cust_id], [buydate]) VALUES (1047, N'寶寶Hi-Q藻油DHA粉狀食品', 1, 1200, 11, CAST(N'2024-08-03' AS Date))
INSERT [dbo].[historycart] ([id], [name], [qty], [price], [cust_id], [buydate]) VALUES (1048, N'【Wyeth惠氏】S-26 金幼兒樂', 1, 699, 11, CAST(N'2024-08-03' AS Date))
INSERT [dbo].[historycart] ([id], [name], [qty], [price], [cust_id], [buydate]) VALUES (1049, N'【Meiji 明治】金選1-3歲成長配方食品', 1, 695, 11, CAST(N'2024-08-03' AS Date))
INSERT [dbo].[historycart] ([id], [name], [qty], [price], [cust_id], [buydate]) VALUES (1050, N'幫寶適一級幫', 5, 1400, 1, CAST(N'2024-08-03' AS Date))
INSERT [dbo].[historycart] ([id], [name], [qty], [price], [cust_id], [buydate]) VALUES (1051, N'妙而舒金緻柔點', 5, 1280, 1, CAST(N'2024-08-03' AS Date))
INSERT [dbo].[historycart] ([id], [name], [qty], [price], [cust_id], [buydate]) VALUES (1052, N'【雀巢】能恩HA3', 5, 3156, 1, CAST(N'2024-08-03' AS Date))
INSERT [dbo].[historycart] ([id], [name], [qty], [price], [cust_id], [buydate]) VALUES (1053, N'【Lovita愛維他】胺基酸螯合鋅', 1, 680, 1, CAST(N'2024-08-03' AS Date))
INSERT [dbo].[historycart] ([id], [name], [qty], [price], [cust_id], [buydate]) VALUES (1054, N'【Okamoto岡本】 002 Hydro水感勁薄', 2, 554, 1, CAST(N'2024-08-03' AS Date))
INSERT [dbo].[historycart] ([id], [name], [qty], [price], [cust_id], [buydate]) VALUES (1055, N'DIOR生命之源奢華金萃2024珍鑲版', 2, 168000, 1, CAST(N'2024-08-03' AS Date))
INSERT [dbo].[historycart] ([id], [name], [qty], [price], [cust_id], [buydate]) VALUES (1056, N'蘭蔻小黑瓶精華', 1, 3850, 1, CAST(N'2024-08-03' AS Date))
INSERT [dbo].[historycart] ([id], [name], [qty], [price], [cust_id], [buydate]) VALUES (1057, N'資生堂紅顏肌活露', 1, 5700, 1, CAST(N'2024-08-03' AS Date))
INSERT [dbo].[historycart] ([id], [name], [qty], [price], [cust_id], [buydate]) VALUES (1058, N'幼兒濕紙巾', 5, 200, 1, CAST(N'2024-08-03' AS Date))
INSERT [dbo].[historycart] ([id], [name], [qty], [price], [cust_id], [buydate]) VALUES (1059, N'資生堂紅顏肌活露', 1, 5700, 1, CAST(N'2024-08-04' AS Date))
INSERT [dbo].[historycart] ([id], [name], [qty], [price], [cust_id], [buydate]) VALUES (1060, N'麗貝樂', 1, 310, 1, CAST(N'2024-08-04' AS Date))
INSERT [dbo].[historycart] ([id], [name], [qty], [price], [cust_id], [buydate]) VALUES (1061, N'麗貝樂', 3, 775, 2, CAST(N'2024-08-04' AS Date))
SET IDENTITY_INSERT [dbo].[historycart] OFF
GO
SET IDENTITY_INSERT [dbo].[medicine] ON 

INSERT [dbo].[medicine] ([id], [name], [price], [qty], [photo]) VALUES (1, N'善存', 729, 40, N'善存.png')
INSERT [dbo].[medicine] ([id], [name], [price], [qty], [photo]) VALUES (2, N'【Lovita愛維他】胺基酸螯合鋅', 680, 30, N'胺基酸螯合鋅.png')
INSERT [dbo].[medicine] ([id], [name], [price], [qty], [photo]) VALUES (3, N'海藻成人鈣加強錠3.0', 900, 35, N'海藻成人鈣.png')
INSERT [dbo].[medicine] ([id], [name], [price], [qty], [photo]) VALUES (4, N'寶寶Hi-Q藻油DHA粉狀食品', 1200, 50, N'寶寶Hi-Q藻油.png')
INSERT [dbo].[medicine] ([id], [name], [price], [qty], [photo]) VALUES (5, N'【好立善】EUREYE葉黃素複方軟膠囊', 239, 40, N'葉黃素.png')
INSERT [dbo].[medicine] ([id], [name], [price], [qty], [photo]) VALUES (6, N'醫療成人美型口罩 山櫻紅', 129, 35, N'口罩.png')
INSERT [dbo].[medicine] ([id], [name], [price], [qty], [photo]) VALUES (7, N'75%清潔用酒精', 479, 25, N'酒精.png')
INSERT [dbo].[medicine] ([id], [name], [price], [qty], [photo]) VALUES (8, N'【Okamoto岡本】 002 Hydro水感勁薄', 369, 40, N'岡本.png')
INSERT [dbo].[medicine] ([id], [name], [price], [qty], [photo]) VALUES (9, N'【小林製藥】嬰兒用退熱貼片', 150, 40, N'退熱貼.png')
INSERT [dbo].[medicine] ([id], [name], [price], [qty], [photo]) VALUES (10, N'Nexcare 克淋濕防水透氣繃', 60, 33, N'ok蹦.png')
SET IDENTITY_INSERT [dbo].[medicine] OFF
GO
SET IDENTITY_INSERT [dbo].[orditem] ON 

INSERT [dbo].[orditem] ([id], [name], [price], [qty], [cust_id], [order_date]) VALUES (1, N'麗貝樂', 775, 3, 2, CAST(N'2024-08-04' AS Date))
SET IDENTITY_INSERT [dbo].[orditem] OFF
GO
ALTER TABLE [dbo].[historycart]  WITH CHECK ADD  CONSTRAINT [FK_customer_historycart] FOREIGN KEY([cust_id])
REFERENCES [dbo].[customer] ([id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[historycart] CHECK CONSTRAINT [FK_customer_historycart]
GO
ALTER TABLE [dbo].[orditem]  WITH CHECK ADD FOREIGN KEY([cust_id])
REFERENCES [dbo].[customer] ([id])
ON DELETE CASCADE
GO
USE [master]
GO
ALTER DATABASE [pharmacy] SET  READ_WRITE 
GO
