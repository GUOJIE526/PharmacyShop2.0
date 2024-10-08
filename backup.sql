USE [master]
GO
/****** Object:  Database [pharmacy]    Script Date: 2024/8/13 下午 07:43:52 ******/
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
/****** Object:  Table [dbo].[baby]    Script Date: 2024/8/13 下午 07:43:52 ******/
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
/****** Object:  Table [dbo].[beauty]    Script Date: 2024/8/13 下午 07:43:52 ******/
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
/****** Object:  Table [dbo].[customer]    Script Date: 2024/8/13 下午 07:43:52 ******/
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
/****** Object:  Table [dbo].[employee]    Script Date: 2024/8/13 下午 07:43:52 ******/
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
/****** Object:  Table [dbo].[finishitem]    Script Date: 2024/8/13 下午 07:43:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[finishitem](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](max) NULL,
	[price] [int] NULL,
	[qty] [int] NULL,
	[cust_id] [int] NULL,
	[order_date] [date] NULL,
	[finish_date] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[historycart]    Script Date: 2024/8/13 下午 07:43:52 ******/
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
/****** Object:  Table [dbo].[medicine]    Script Date: 2024/8/13 下午 07:43:52 ******/
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
/****** Object:  Table [dbo].[orditem]    Script Date: 2024/8/13 下午 07:43:52 ******/
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

INSERT [dbo].[baby] ([id], [name], [price], [qty], [photo]) VALUES (1, N'幫寶適一級幫', 350, 47, N'Pampers.png')
INSERT [dbo].[baby] ([id], [name], [price], [qty], [photo]) VALUES (2, N'妙而舒金緻柔點', 320, 30, N'妙而舒金緻.png')
INSERT [dbo].[baby] ([id], [name], [price], [qty], [photo]) VALUES (3, N'大王天使尿布', 380, 49, N'大王天使.png')
INSERT [dbo].[baby] ([id], [name], [price], [qty], [photo]) VALUES (4, N'麗貝樂', 310, 35, N'麗貝樂.png')
INSERT [dbo].[baby] ([id], [name], [price], [qty], [photo]) VALUES (5, N'滿意寶寶日本白金', 380, 29, N'MamyPoko.png')
INSERT [dbo].[baby] ([id], [name], [price], [qty], [photo]) VALUES (6, N'【Wyeth惠氏】S-26 金幼兒樂', 699, 20, N'S26金愛兒樂.png')
INSERT [dbo].[baby] ([id], [name], [price], [qty], [photo]) VALUES (7, N'【SNOW雪印】金T3PLUS成長營養配方', 725, 50, N'雪印T3.png')
INSERT [dbo].[baby] ([id], [name], [price], [qty], [photo]) VALUES (8, N'【亞培】心美力 HM.O幼兒成長配方', 1299, 23, N'亞培.png')
INSERT [dbo].[baby] ([id], [name], [price], [qty], [photo]) VALUES (9, N'【雀巢】能恩HA3', 789, 13, N'雀巢能恩水解.png')
INSERT [dbo].[baby] ([id], [name], [price], [qty], [photo]) VALUES (10, N'【Meiji 明治】金選1-3歲成長配方食品', 695, 27, N'明治.png')
SET IDENTITY_INSERT [dbo].[baby] OFF
GO
SET IDENTITY_INSERT [dbo].[beauty] ON 

INSERT [dbo].[beauty] ([id], [name], [price], [qty], [photo]) VALUES (1, N'SK-II 神仙水', 3500, 24, N'SK2.png')
INSERT [dbo].[beauty] ([id], [name], [price], [qty], [photo]) VALUES (2, N'雅詩蘭黛特潤精修精華', 4500, 28, N'雅詩蘭黛.png')
INSERT [dbo].[beauty] ([id], [name], [price], [qty], [photo]) VALUES (3, N'倩碧三步驟潔膚液', 4800, 28, N'倩碧.png')
INSERT [dbo].[beauty] ([id], [name], [price], [qty], [photo]) VALUES (4, N'蘭蔻小黑瓶精華', 3850, 45, N'蘭蔻.png')
INSERT [dbo].[beauty] ([id], [name], [price], [qty], [photo]) VALUES (5, N'資生堂紅顏肌活露', 5700, 27, N'資生堂肌紅.png')
INSERT [dbo].[beauty] ([id], [name], [price], [qty], [photo]) VALUES (6, N'DIOR生命之源奢華金萃2024珍鑲版', 112000, 21, N'dior金萃.png')
INSERT [dbo].[beauty] ([id], [name], [price], [qty], [photo]) VALUES (8, N'香奈兒COMETE幸運星辰', 14600, 33, N'香奈兒星辰.png')
INSERT [dbo].[beauty] ([id], [name], [price], [qty], [photo]) VALUES (9, N'MISS DIOR花漾迪奧', 3850, 23, N'DIOR奧迪花樣.png')
INSERT [dbo].[beauty] ([id], [name], [price], [qty], [photo]) VALUES (10, N'Gucci Bloom', 3800, 21, N'GUCCI.png')
INSERT [dbo].[beauty] ([id], [name], [price], [qty], [photo]) VALUES (11, N'Twilly Hermes淡香精', 6100, 24, N'愛馬仕.png')
INSERT [dbo].[beauty] ([id], [name], [price], [qty], [photo]) VALUES (12, N'Yves Saint Laurent Black Opium', 4000, 31, N'YSL.png')
SET IDENTITY_INSERT [dbo].[beauty] OFF
GO
SET IDENTITY_INSERT [dbo].[customer] ON 

INSERT [dbo].[customer] ([id], [name], [password], [phone], [email], [address], [createdate], [updatetime], [lv]) VALUES (1, N'guojie', N'8877', N'09563807788', N'gg@gmail.com', N'高雄市前金區中正四路211號25樓', CAST(N'2024-07-27' AS Date), CAST(N'2024-08-07' AS Date), 1)
INSERT [dbo].[customer] ([id], [name], [password], [phone], [email], [address], [createdate], [updatetime], [lv]) VALUES (2, N'Eidth', N'7788', N'0912345678', N'ee@gmail.com', N'高雄市仁武區永新6街7788號', CAST(N'2024-07-30' AS Date), NULL, 1)
INSERT [dbo].[customer] ([id], [name], [password], [phone], [email], [address], [createdate], [updatetime], [lv]) VALUES (6, N'James', N'2873', N'0956287999', N'james@gmail.com', N'台北市大安區某某路41號', CAST(N'2024-07-05' AS Date), NULL, 1)
INSERT [dbo].[customer] ([id], [name], [password], [phone], [email], [address], [createdate], [updatetime], [lv]) VALUES (8, N'Robert', N'1688', N'0918432549', N'robert@gmail.com', N'台中市西屯區某某路99號', CAST(N'2024-10-11' AS Date), CAST(N'2024-08-04' AS Date), 1)
INSERT [dbo].[customer] ([id], [name], [password], [phone], [email], [address], [createdate], [updatetime], [lv]) VALUES (9, N'Michael', N'5690', N'0967242780', N'michael@gmail.com', N'高雄市苓雅區某某路47號', CAST(N'2024-05-20' AS Date), NULL, 1)
INSERT [dbo].[customer] ([id], [name], [password], [phone], [email], [address], [createdate], [updatetime], [lv]) VALUES (10, N'William', N'66666', N'0958892529', N'william@gmail.com', N'台南市中西區某某路82號', CAST(N'2024-02-28' AS Date), CAST(N'2024-08-06' AS Date), 1)
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
INSERT [dbo].[customer] ([id], [name], [password], [phone], [email], [address], [createdate], [updatetime], [lv]) VALUES (24, N'Edward', N'9274', N'0931847525', N'edward@gmail.com', N'台南市南區某某路73', CAST(N'2024-10-11' AS Date), NULL, 0)
INSERT [dbo].[customer] ([id], [name], [password], [phone], [email], [address], [createdate], [updatetime], [lv]) VALUES (29, N'GG', N'654321', N'0956123456', N'gg@gmail.com', N'高雄市左營區華夏路8888號', CAST(N'2024-08-04' AS Date), CAST(N'2024-08-13' AS Date), 1)
INSERT [dbo].[customer] ([id], [name], [password], [phone], [email], [address], [createdate], [updatetime], [lv]) VALUES (1029, N'Jacob', N'1234', N'0956380786', N'gg@gmail.com', N'台北市士林區格致路1444號', NULL, CAST(N'2024-08-06' AS Date), 3)
INSERT [dbo].[customer] ([id], [name], [password], [phone], [email], [address], [createdate], [updatetime], [lv]) VALUES (1030, N'Alice', N'1234', N'0987654321', N'alice@example.com', N'台北市大安區忠孝東路', NULL, CAST(N'2024-08-07' AS Date), 3)
SET IDENTITY_INSERT [dbo].[customer] OFF
GO
SET IDENTITY_INSERT [dbo].[employee] ON 

INSERT [dbo].[employee] ([id], [name], [password], [phone], [email], [address], [createdate], [updatetime], [lv]) VALUES (1, N'admin', N'admin', N'0988168168', N'admin@gmail.com', N'高雄市鼓山區美術東二路168號', NULL, NULL, 1)
INSERT [dbo].[employee] ([id], [name], [password], [phone], [email], [address], [createdate], [updatetime], [lv]) VALUES (4, N'Bob', N'2222', N'0912345678', N'bob@example.com', N'台中市西屯區台灣大道', CAST(N'2024-08-06' AS Date), NULL, 3)
INSERT [dbo].[employee] ([id], [name], [password], [phone], [email], [address], [createdate], [updatetime], [lv]) VALUES (5, N'Charlie', N'3333', N'0935123456', N'charlie@example.com', N'高雄市左營區博愛路', CAST(N'2024-08-06' AS Date), NULL, 3)
INSERT [dbo].[employee] ([id], [name], [password], [phone], [email], [address], [createdate], [updatetime], [lv]) VALUES (6, N'David', N'4444', N'0978123456', N'david@example.com', N'新北市板橋區文化路', CAST(N'2024-08-06' AS Date), NULL, 3)
INSERT [dbo].[employee] ([id], [name], [password], [phone], [email], [address], [createdate], [updatetime], [lv]) VALUES (7, N'Eve', N'5555', N'0965123456', N'eve@example.com', N'桃園市中壢區中正路', CAST(N'2024-08-06' AS Date), NULL, 3)
SET IDENTITY_INSERT [dbo].[employee] OFF
GO
SET IDENTITY_INSERT [dbo].[finishitem] ON 

INSERT [dbo].[finishitem] ([id], [name], [price], [qty], [cust_id], [order_date], [finish_date]) VALUES (1, N'麗貝樂', 775, 3, 2, CAST(N'2024-08-04' AS Date), CAST(N'2024-08-04' AS Date))
INSERT [dbo].[finishitem] ([id], [name], [price], [qty], [cust_id], [order_date], [finish_date]) VALUES (2, N'麗貝樂', 775, 3, 2, CAST(N'2024-08-04' AS Date), CAST(N'2024-08-04' AS Date))
INSERT [dbo].[finishitem] ([id], [name], [price], [qty], [cust_id], [order_date], [finish_date]) VALUES (3, N'蘭蔻小黑瓶精華', 3850, 1, 2, CAST(N'2024-08-04' AS Date), CAST(N'2024-08-04' AS Date))
INSERT [dbo].[finishitem] ([id], [name], [price], [qty], [cust_id], [order_date], [finish_date]) VALUES (4, N'醫療成人美型口罩 山櫻紅', 129, 1, 2, CAST(N'2024-08-04' AS Date), CAST(N'2024-08-04' AS Date))
INSERT [dbo].[finishitem] ([id], [name], [price], [qty], [cust_id], [order_date], [finish_date]) VALUES (5, N'麗貝樂', 775, 3, 1, CAST(N'2024-08-04' AS Date), CAST(N'2024-08-04' AS Date))
INSERT [dbo].[finishitem] ([id], [name], [price], [qty], [cust_id], [order_date], [finish_date]) VALUES (9, N'蘭蔻小黑瓶精華', 3850, 1, 2, CAST(N'2024-08-04' AS Date), CAST(N'2024-08-04' AS Date))
INSERT [dbo].[finishitem] ([id], [name], [price], [qty], [cust_id], [order_date], [finish_date]) VALUES (10, N'MISS DIOR花漾迪奧', 3850, 1, 2, CAST(N'2024-08-04' AS Date), CAST(N'2024-08-04' AS Date))
INSERT [dbo].[finishitem] ([id], [name], [price], [qty], [cust_id], [order_date], [finish_date]) VALUES (11, N'醫療成人美型口罩 山櫻紅', 129, 1, 2, CAST(N'2024-08-04' AS Date), CAST(N'2024-08-04' AS Date))
INSERT [dbo].[finishitem] ([id], [name], [price], [qty], [cust_id], [order_date], [finish_date]) VALUES (12, N'滿意寶寶日本白金', 380, 1, 2, CAST(N'2024-08-04' AS Date), CAST(N'2024-08-04' AS Date))
INSERT [dbo].[finishitem] ([id], [name], [price], [qty], [cust_id], [order_date], [finish_date]) VALUES (13, N'醫療成人美型口罩 山櫻紅', 129, 1, 2, CAST(N'2024-08-04' AS Date), CAST(N'2024-08-04' AS Date))
INSERT [dbo].[finishitem] ([id], [name], [price], [qty], [cust_id], [order_date], [finish_date]) VALUES (14, N'【小林製藥】嬰兒用退熱貼片', 150, 1, 2, CAST(N'2024-08-04' AS Date), CAST(N'2024-08-04' AS Date))
INSERT [dbo].[finishitem] ([id], [name], [price], [qty], [cust_id], [order_date], [finish_date]) VALUES (15, N'蘭蔻小黑瓶精華', 3850, 2, 2, CAST(N'2024-08-04' AS Date), CAST(N'2024-08-04' AS Date))
INSERT [dbo].[finishitem] ([id], [name], [price], [qty], [cust_id], [order_date], [finish_date]) VALUES (1002, N'75%清潔用酒精', 8000, 10, 2, CAST(N'2024-08-04' AS Date), CAST(N'2024-08-04' AS Date))
INSERT [dbo].[finishitem] ([id], [name], [price], [qty], [cust_id], [order_date], [finish_date]) VALUES (1003, N'兒童用濕紙巾', 1125, 30, 8, CAST(N'2024-08-04' AS Date), CAST(N'2024-08-04' AS Date))
INSERT [dbo].[finishitem] ([id], [name], [price], [qty], [cust_id], [order_date], [finish_date]) VALUES (1004, N'【Okamoto岡本】 002 Hydro水感勁薄', 1476, 6, 8, CAST(N'2024-08-04' AS Date), CAST(N'2024-08-04' AS Date))
INSERT [dbo].[finishitem] ([id], [name], [price], [qty], [cust_id], [order_date], [finish_date]) VALUES (1005, N'倩碧三步驟潔膚液', 12000, 3, 8, CAST(N'2024-08-04' AS Date), CAST(N'2024-08-04' AS Date))
INSERT [dbo].[finishitem] ([id], [name], [price], [qty], [cust_id], [order_date], [finish_date]) VALUES (2002, N'Gucci Bloom', 3800, 1, 2, CAST(N'2024-08-04' AS Date), CAST(N'2024-08-05' AS Date))
INSERT [dbo].[finishitem] ([id], [name], [price], [qty], [cust_id], [order_date], [finish_date]) VALUES (2003, N'倩碧三步驟潔膚液', 4800, 1, 2, CAST(N'2024-08-04' AS Date), CAST(N'2024-08-05' AS Date))
INSERT [dbo].[finishitem] ([id], [name], [price], [qty], [cust_id], [order_date], [finish_date]) VALUES (2004, N'Yves Saint Laurent Black Opium', 4000, 1, 2, CAST(N'2024-08-04' AS Date), CAST(N'2024-08-05' AS Date))
INSERT [dbo].[finishitem] ([id], [name], [price], [qty], [cust_id], [order_date], [finish_date]) VALUES (2005, N'【Lovita愛維他】胺基酸螯合鋅', 680, 1, 2, CAST(N'2024-08-04' AS Date), CAST(N'2024-08-05' AS Date))
INSERT [dbo].[finishitem] ([id], [name], [price], [qty], [cust_id], [order_date], [finish_date]) VALUES (2006, N'【Okamoto岡本】 002 Hydro水感勁薄', 369, 1, 2, CAST(N'2024-08-04' AS Date), CAST(N'2024-08-05' AS Date))
INSERT [dbo].[finishitem] ([id], [name], [price], [qty], [cust_id], [order_date], [finish_date]) VALUES (2007, N'【小林製藥】嬰兒用退熱貼片', 150, 1, 2, CAST(N'2024-08-04' AS Date), CAST(N'2024-08-05' AS Date))
INSERT [dbo].[finishitem] ([id], [name], [price], [qty], [cust_id], [order_date], [finish_date]) VALUES (2008, N'善存', 729, 1, 2, CAST(N'2024-08-04' AS Date), CAST(N'2024-08-05' AS Date))
INSERT [dbo].[finishitem] ([id], [name], [price], [qty], [cust_id], [order_date], [finish_date]) VALUES (2009, N'倩碧三步驟潔膚液', 7200, 2, 6, CAST(N'2024-08-04' AS Date), CAST(N'2024-08-05' AS Date))
INSERT [dbo].[finishitem] ([id], [name], [price], [qty], [cust_id], [order_date], [finish_date]) VALUES (2010, N'Gucci Bloom', 3800, 1, 6, CAST(N'2024-08-04' AS Date), CAST(N'2024-08-05' AS Date))
INSERT [dbo].[finishitem] ([id], [name], [price], [qty], [cust_id], [order_date], [finish_date]) VALUES (2012, N'Twilly Hermes淡香精', 6100, 1, 6, CAST(N'2024-08-04' AS Date), CAST(N'2024-08-05' AS Date))
INSERT [dbo].[finishitem] ([id], [name], [price], [qty], [cust_id], [order_date], [finish_date]) VALUES (2013, N'Yves Saint Laurent Black Opium', 4000, 1, 6, CAST(N'2024-08-04' AS Date), CAST(N'2024-08-05' AS Date))
INSERT [dbo].[finishitem] ([id], [name], [price], [qty], [cust_id], [order_date], [finish_date]) VALUES (2014, N'【Okamoto岡本】 002 Hydro水感勁薄', 369, 1, 6, CAST(N'2024-08-04' AS Date), CAST(N'2024-08-05' AS Date))
INSERT [dbo].[finishitem] ([id], [name], [price], [qty], [cust_id], [order_date], [finish_date]) VALUES (2015, N'寶寶Hi-Q藻油DHA粉狀食品', 1200, 1, 8, CAST(N'2024-08-04' AS Date), CAST(N'2024-08-05' AS Date))
INSERT [dbo].[finishitem] ([id], [name], [price], [qty], [cust_id], [order_date], [finish_date]) VALUES (2016, N'【小林製藥】嬰兒用退熱貼片', 150, 1, 8, CAST(N'2024-08-04' AS Date), CAST(N'2024-08-05' AS Date))
INSERT [dbo].[finishitem] ([id], [name], [price], [qty], [cust_id], [order_date], [finish_date]) VALUES (2018, N'DIOR生命之源奢華金萃2024珍鑲版', 112000, 1, 8, CAST(N'2024-08-04' AS Date), CAST(N'2024-08-05' AS Date))
INSERT [dbo].[finishitem] ([id], [name], [price], [qty], [cust_id], [order_date], [finish_date]) VALUES (2019, N'SK-II 神仙水', 3500, 1, 8, CAST(N'2024-08-04' AS Date), CAST(N'2024-08-05' AS Date))
INSERT [dbo].[finishitem] ([id], [name], [price], [qty], [cust_id], [order_date], [finish_date]) VALUES (2020, N'DIOR生命之源奢華金萃2024珍鑲版', 168000, 2, 2, CAST(N'2024-08-04' AS Date), CAST(N'2024-08-05' AS Date))
INSERT [dbo].[finishitem] ([id], [name], [price], [qty], [cust_id], [order_date], [finish_date]) VALUES (2021, N'【SNOW雪印】金T3PLUS成長營養配方', 725, 1, 29, CAST(N'2024-08-04' AS Date), CAST(N'2024-08-05' AS Date))
INSERT [dbo].[finishitem] ([id], [name], [price], [qty], [cust_id], [order_date], [finish_date]) VALUES (2022, N'【雀巢】能恩HA3', 3156, 5, 29, CAST(N'2024-08-04' AS Date), CAST(N'2024-08-05' AS Date))
INSERT [dbo].[finishitem] ([id], [name], [price], [qty], [cust_id], [order_date], [finish_date]) VALUES (2024, N'醫療成人美型口罩 山櫻紅', 516, 5, 29, CAST(N'2024-08-04' AS Date), CAST(N'2024-08-05' AS Date))
INSERT [dbo].[finishitem] ([id], [name], [price], [qty], [cust_id], [order_date], [finish_date]) VALUES (2025, N'DIOR生命之源奢華金萃2024珍鑲版', 112000, 1, 29, CAST(N'2024-08-04' AS Date), CAST(N'2024-08-05' AS Date))
INSERT [dbo].[finishitem] ([id], [name], [price], [qty], [cust_id], [order_date], [finish_date]) VALUES (2026, N'Yves Saint Laurent Black Opium', 4000, 1, 29, CAST(N'2024-08-04' AS Date), CAST(N'2024-08-05' AS Date))
INSERT [dbo].[finishitem] ([id], [name], [price], [qty], [cust_id], [order_date], [finish_date]) VALUES (2027, N'【Wyeth惠氏】S-26 金幼兒樂', 699, 1, 12, CAST(N'2024-08-05' AS Date), CAST(N'2024-08-05' AS Date))
INSERT [dbo].[finishitem] ([id], [name], [price], [qty], [cust_id], [order_date], [finish_date]) VALUES (2028, N'【亞培】心美力 HM.O幼兒成長配方', 1299, 1, 12, CAST(N'2024-08-05' AS Date), CAST(N'2024-08-05' AS Date))
INSERT [dbo].[finishitem] ([id], [name], [price], [qty], [cust_id], [order_date], [finish_date]) VALUES (2029, N'DIOR生命之源奢華金萃2024珍鑲版', 112000, 1, 12, CAST(N'2024-08-05' AS Date), CAST(N'2024-08-05' AS Date))
INSERT [dbo].[finishitem] ([id], [name], [price], [qty], [cust_id], [order_date], [finish_date]) VALUES (2030, N'寶寶Hi-Q藻油DHA粉狀食品', 1200, 1, 12, CAST(N'2024-08-05' AS Date), CAST(N'2024-08-05' AS Date))
INSERT [dbo].[finishitem] ([id], [name], [price], [qty], [cust_id], [order_date], [finish_date]) VALUES (2031, N'【Okamoto岡本】 002 Hydro水感勁薄', 369, 1, 13, CAST(N'2024-08-05' AS Date), CAST(N'2024-08-05' AS Date))
INSERT [dbo].[finishitem] ([id], [name], [price], [qty], [cust_id], [order_date], [finish_date]) VALUES (2032, N'Nexcare 克淋濕防水透氣繃', 60, 1, 13, CAST(N'2024-08-05' AS Date), CAST(N'2024-08-05' AS Date))
INSERT [dbo].[finishitem] ([id], [name], [price], [qty], [cust_id], [order_date], [finish_date]) VALUES (2033, N'75%清潔用酒精', 479, 1, 13, CAST(N'2024-08-05' AS Date), CAST(N'2024-08-05' AS Date))
INSERT [dbo].[finishitem] ([id], [name], [price], [qty], [cust_id], [order_date], [finish_date]) VALUES (2034, N'【小林製藥】嬰兒用退熱貼片', 150, 1, 13, CAST(N'2024-08-05' AS Date), CAST(N'2024-08-05' AS Date))
INSERT [dbo].[finishitem] ([id], [name], [price], [qty], [cust_id], [order_date], [finish_date]) VALUES (2035, N'【Lovita愛維他】胺基酸螯合鋅', 680, 1, 13, CAST(N'2024-08-05' AS Date), CAST(N'2024-08-05' AS Date))
INSERT [dbo].[finishitem] ([id], [name], [price], [qty], [cust_id], [order_date], [finish_date]) VALUES (2036, N'【雀巢】能恩HA3', 789, 1, 13, CAST(N'2024-08-05' AS Date), CAST(N'2024-08-05' AS Date))
INSERT [dbo].[finishitem] ([id], [name], [price], [qty], [cust_id], [order_date], [finish_date]) VALUES (2037, N'滿意寶寶日本白金', 380, 1, 13, CAST(N'2024-08-05' AS Date), CAST(N'2024-08-05' AS Date))
INSERT [dbo].[finishitem] ([id], [name], [price], [qty], [cust_id], [order_date], [finish_date]) VALUES (2038, N'雅詩蘭黛特潤精修精華', 4500, 1, 13, CAST(N'2024-08-05' AS Date), CAST(N'2024-08-05' AS Date))
INSERT [dbo].[finishitem] ([id], [name], [price], [qty], [cust_id], [order_date], [finish_date]) VALUES (2039, N'蘭蔻小黑瓶精華', 3850, 1, 13, CAST(N'2024-08-05' AS Date), CAST(N'2024-08-05' AS Date))
INSERT [dbo].[finishitem] ([id], [name], [price], [qty], [cust_id], [order_date], [finish_date]) VALUES (2040, N'Gucci Bloom', 3800, 1, 13, CAST(N'2024-08-05' AS Date), CAST(N'2024-08-05' AS Date))
INSERT [dbo].[finishitem] ([id], [name], [price], [qty], [cust_id], [order_date], [finish_date]) VALUES (2041, N'DIOR生命之源奢華金萃2024珍鑲版', 112000, 1, 13, CAST(N'2024-08-05' AS Date), CAST(N'2024-08-05' AS Date))
INSERT [dbo].[finishitem] ([id], [name], [price], [qty], [cust_id], [order_date], [finish_date]) VALUES (2042, N'倩碧三步驟潔膚液', 4800, 1, 13, CAST(N'2024-08-05' AS Date), CAST(N'2024-08-05' AS Date))
INSERT [dbo].[finishitem] ([id], [name], [price], [qty], [cust_id], [order_date], [finish_date]) VALUES (2043, N'幫寶適一級幫', 350, 3, 10, CAST(N'2024-08-06' AS Date), CAST(N'2024-08-06' AS Date))
INSERT [dbo].[finishitem] ([id], [name], [price], [qty], [cust_id], [order_date], [finish_date]) VALUES (2044, N'大王天使尿布', 380, 1, 10, CAST(N'2024-08-06' AS Date), CAST(N'2024-08-06' AS Date))
INSERT [dbo].[finishitem] ([id], [name], [price], [qty], [cust_id], [order_date], [finish_date]) VALUES (2045, N'【Meiji 明治】金選1-3歲成長配方食品', 695, 1, 10, CAST(N'2024-08-06' AS Date), CAST(N'2024-08-06' AS Date))
INSERT [dbo].[finishitem] ([id], [name], [price], [qty], [cust_id], [order_date], [finish_date]) VALUES (2046, N'資生堂紅顏肌活露', 5700, 1, 10, CAST(N'2024-08-06' AS Date), CAST(N'2024-08-06' AS Date))
INSERT [dbo].[finishitem] ([id], [name], [price], [qty], [cust_id], [order_date], [finish_date]) VALUES (2047, N'Gucci Bloom', 3800, 1, 10, CAST(N'2024-08-06' AS Date), CAST(N'2024-08-06' AS Date))
INSERT [dbo].[finishitem] ([id], [name], [price], [qty], [cust_id], [order_date], [finish_date]) VALUES (2048, N'寶寶Hi-Q藻油DHA粉狀食品', 1200, 1, 10, CAST(N'2024-08-06' AS Date), CAST(N'2024-08-06' AS Date))
INSERT [dbo].[finishitem] ([id], [name], [price], [qty], [cust_id], [order_date], [finish_date]) VALUES (2049, N'【Okamoto岡本】 002 Hydro水感勁薄', 369, 1, 10, CAST(N'2024-08-06' AS Date), CAST(N'2024-08-06' AS Date))
INSERT [dbo].[finishitem] ([id], [name], [price], [qty], [cust_id], [order_date], [finish_date]) VALUES (2050, N'【Okamoto岡本】 002 Hydro水感勁薄', 554, 2, 1, CAST(N'2024-08-07' AS Date), CAST(N'2024-08-07' AS Date))
INSERT [dbo].[finishitem] ([id], [name], [price], [qty], [cust_id], [order_date], [finish_date]) VALUES (2051, N'【Lovita愛維他】胺基酸螯合鋅', 2720, 5, 1, CAST(N'2024-08-07' AS Date), CAST(N'2024-08-07' AS Date))
INSERT [dbo].[finishitem] ([id], [name], [price], [qty], [cust_id], [order_date], [finish_date]) VALUES (2052, N'倩碧三步驟潔膚液', 36000, 10, 1, CAST(N'2024-08-07' AS Date), CAST(N'2024-08-07' AS Date))
INSERT [dbo].[finishitem] ([id], [name], [price], [qty], [cust_id], [order_date], [finish_date]) VALUES (2053, N'【SNOW雪印】金T3PLUS成長營養配方', 10875, 20, 1, CAST(N'2024-08-07' AS Date), CAST(N'2024-08-07' AS Date))
INSERT [dbo].[finishitem] ([id], [name], [price], [qty], [cust_id], [order_date], [finish_date]) VALUES (2054, N'幫寶適一級幫', 5250, 20, 1, CAST(N'2024-08-07' AS Date), CAST(N'2024-08-07' AS Date))
SET IDENTITY_INSERT [dbo].[finishitem] OFF
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
INSERT [dbo].[historycart] ([id], [name], [qty], [price], [cust_id], [buydate]) VALUES (1063, N'蘭蔻小黑瓶精華', 1, 3850, 2, CAST(N'2024-08-04' AS Date))
INSERT [dbo].[historycart] ([id], [name], [qty], [price], [cust_id], [buydate]) VALUES (1064, N'MISS DIOR花漾迪奧', 1, 3850, 2, CAST(N'2024-08-04' AS Date))
INSERT [dbo].[historycart] ([id], [name], [qty], [price], [cust_id], [buydate]) VALUES (1065, N'醫療成人美型口罩 山櫻紅', 1, 129, 2, CAST(N'2024-08-04' AS Date))
INSERT [dbo].[historycart] ([id], [name], [qty], [price], [cust_id], [buydate]) VALUES (1066, N'滿意寶寶日本白金', 1, 380, 2, CAST(N'2024-08-04' AS Date))
INSERT [dbo].[historycart] ([id], [name], [qty], [price], [cust_id], [buydate]) VALUES (1067, N'醫療成人美型口罩 山櫻紅', 1, 129, 2, CAST(N'2024-08-04' AS Date))
INSERT [dbo].[historycart] ([id], [name], [qty], [price], [cust_id], [buydate]) VALUES (1068, N'【小林製藥】嬰兒用退熱貼片', 1, 150, 2, CAST(N'2024-08-04' AS Date))
INSERT [dbo].[historycart] ([id], [name], [qty], [price], [cust_id], [buydate]) VALUES (1069, N'75%清潔用酒精', 1, 479, 2, CAST(N'2024-08-04' AS Date))
INSERT [dbo].[historycart] ([id], [name], [qty], [price], [cust_id], [buydate]) VALUES (1070, N'善存', 1, 729, 2, CAST(N'2024-08-04' AS Date))
INSERT [dbo].[historycart] ([id], [name], [qty], [price], [cust_id], [buydate]) VALUES (1071, N'蘭蔻小黑瓶精華', 1, 3850, 2, CAST(N'2024-08-04' AS Date))
INSERT [dbo].[historycart] ([id], [name], [qty], [price], [cust_id], [buydate]) VALUES (1072, N'Gucci Bloom', 1, 3800, 2, CAST(N'2024-08-04' AS Date))
INSERT [dbo].[historycart] ([id], [name], [qty], [price], [cust_id], [buydate]) VALUES (1073, N'倩碧三步驟潔膚液', 1, 4800, 2, CAST(N'2024-08-04' AS Date))
INSERT [dbo].[historycart] ([id], [name], [qty], [price], [cust_id], [buydate]) VALUES (1074, N'Yves Saint Laurent Black Opium', 1, 4000, 2, CAST(N'2024-08-04' AS Date))
INSERT [dbo].[historycart] ([id], [name], [qty], [price], [cust_id], [buydate]) VALUES (1075, N'【Lovita愛維他】胺基酸螯合鋅', 1, 680, 2, CAST(N'2024-08-04' AS Date))
INSERT [dbo].[historycart] ([id], [name], [qty], [price], [cust_id], [buydate]) VALUES (1076, N'75%清潔用酒精', 1, 479, 2, CAST(N'2024-08-04' AS Date))
INSERT [dbo].[historycart] ([id], [name], [qty], [price], [cust_id], [buydate]) VALUES (1077, N'【Okamoto岡本】 002 Hydro水感勁薄', 1, 369, 2, CAST(N'2024-08-04' AS Date))
INSERT [dbo].[historycart] ([id], [name], [qty], [price], [cust_id], [buydate]) VALUES (1078, N'【小林製藥】嬰兒用退熱貼片', 1, 150, 2, CAST(N'2024-08-04' AS Date))
INSERT [dbo].[historycart] ([id], [name], [qty], [price], [cust_id], [buydate]) VALUES (1079, N'善存', 1, 729, 2, CAST(N'2024-08-04' AS Date))
INSERT [dbo].[historycart] ([id], [name], [qty], [price], [cust_id], [buydate]) VALUES (2062, N'75%清潔用酒精', 20, 7185, 2, CAST(N'2024-08-04' AS Date))
INSERT [dbo].[historycart] ([id], [name], [qty], [price], [cust_id], [buydate]) VALUES (2063, N'倩碧三步驟潔膚液', 2, 7200, 6, CAST(N'2024-08-04' AS Date))
INSERT [dbo].[historycart] ([id], [name], [qty], [price], [cust_id], [buydate]) VALUES (2064, N'Gucci Bloom', 1, 3800, 6, CAST(N'2024-08-04' AS Date))
INSERT [dbo].[historycart] ([id], [name], [qty], [price], [cust_id], [buydate]) VALUES (2065, N'Twilly Hermes淡香精', 1, 6100, 6, CAST(N'2024-08-04' AS Date))
INSERT [dbo].[historycart] ([id], [name], [qty], [price], [cust_id], [buydate]) VALUES (2066, N'Yves Saint Laurent Black Opium', 1, 4000, 6, CAST(N'2024-08-04' AS Date))
INSERT [dbo].[historycart] ([id], [name], [qty], [price], [cust_id], [buydate]) VALUES (2067, N'【Okamoto岡本】 002 Hydro水感勁薄', 1, 369, 6, CAST(N'2024-08-04' AS Date))
INSERT [dbo].[historycart] ([id], [name], [qty], [price], [cust_id], [buydate]) VALUES (2068, N'寶寶Hi-Q藻油DHA粉狀食品', 1, 1200, 8, CAST(N'2024-08-04' AS Date))
INSERT [dbo].[historycart] ([id], [name], [qty], [price], [cust_id], [buydate]) VALUES (2069, N'【小林製藥】嬰兒用退熱貼片', 1, 150, 8, CAST(N'2024-08-04' AS Date))
INSERT [dbo].[historycart] ([id], [name], [qty], [price], [cust_id], [buydate]) VALUES (2070, N'DIOR生命之源奢華金萃2024珍鑲版', 1, 112000, 8, CAST(N'2024-08-04' AS Date))
INSERT [dbo].[historycart] ([id], [name], [qty], [price], [cust_id], [buydate]) VALUES (2071, N'SK-II 神仙水', 1, 3500, 8, CAST(N'2024-08-04' AS Date))
INSERT [dbo].[historycart] ([id], [name], [qty], [price], [cust_id], [buydate]) VALUES (2072, N'雅詩蘭黛特潤精修精華', 1, 4500, 8, CAST(N'2024-08-04' AS Date))
INSERT [dbo].[historycart] ([id], [name], [qty], [price], [cust_id], [buydate]) VALUES (2073, N'倩碧三步驟潔膚液', 3, 12000, 8, CAST(N'2024-08-04' AS Date))
INSERT [dbo].[historycart] ([id], [name], [qty], [price], [cust_id], [buydate]) VALUES (2074, N'【Okamoto岡本】 002 Hydro水感勁薄', 5, 1476, 8, CAST(N'2024-08-04' AS Date))
INSERT [dbo].[historycart] ([id], [name], [qty], [price], [cust_id], [buydate]) VALUES (2075, N'兒童用濕紙巾', 30, 1125, 8, CAST(N'2024-08-04' AS Date))
INSERT [dbo].[historycart] ([id], [name], [qty], [price], [cust_id], [buydate]) VALUES (2076, N'DIOR生命之源奢華金萃2024珍鑲版', 2, 168000, 2, CAST(N'2024-08-04' AS Date))
INSERT [dbo].[historycart] ([id], [name], [qty], [price], [cust_id], [buydate]) VALUES (2077, N'【SNOW雪印】金T3PLUS成長營養配方', 1, 725, 29, CAST(N'2024-08-04' AS Date))
INSERT [dbo].[historycart] ([id], [name], [qty], [price], [cust_id], [buydate]) VALUES (2078, N'【雀巢】能恩HA3', 5, 3156, 29, CAST(N'2024-08-04' AS Date))
INSERT [dbo].[historycart] ([id], [name], [qty], [price], [cust_id], [buydate]) VALUES (2079, N'DIOR生命之源奢華金萃2024珍鑲版', 1, 112000, 29, CAST(N'2024-08-04' AS Date))
INSERT [dbo].[historycart] ([id], [name], [qty], [price], [cust_id], [buydate]) VALUES (2080, N'Yves Saint Laurent Black Opium', 1, 4000, 29, CAST(N'2024-08-04' AS Date))
INSERT [dbo].[historycart] ([id], [name], [qty], [price], [cust_id], [buydate]) VALUES (2081, N'醫療成人美型口罩 山櫻紅', 5, 516, 29, CAST(N'2024-08-04' AS Date))
INSERT [dbo].[historycart] ([id], [name], [qty], [price], [cust_id], [buydate]) VALUES (3062, N'【Wyeth惠氏】S-26 金幼兒樂', 1, 699, 12, CAST(N'2024-08-05' AS Date))
INSERT [dbo].[historycart] ([id], [name], [qty], [price], [cust_id], [buydate]) VALUES (3063, N'【亞培】心美力 HM.O幼兒成長配方', 1, 1299, 12, CAST(N'2024-08-05' AS Date))
INSERT [dbo].[historycart] ([id], [name], [qty], [price], [cust_id], [buydate]) VALUES (3064, N'DIOR生命之源奢華金萃2024珍鑲版', 1, 112000, 12, CAST(N'2024-08-05' AS Date))
INSERT [dbo].[historycart] ([id], [name], [qty], [price], [cust_id], [buydate]) VALUES (3065, N'寶寶Hi-Q藻油DHA粉狀食品', 1, 1200, 12, CAST(N'2024-08-05' AS Date))
INSERT [dbo].[historycart] ([id], [name], [qty], [price], [cust_id], [buydate]) VALUES (3066, N'【Okamoto岡本】 002 Hydro水感勁薄', 1, 369, 13, CAST(N'2024-08-05' AS Date))
INSERT [dbo].[historycart] ([id], [name], [qty], [price], [cust_id], [buydate]) VALUES (3067, N'Nexcare 克淋濕防水透氣繃', 1, 60, 13, CAST(N'2024-08-05' AS Date))
INSERT [dbo].[historycart] ([id], [name], [qty], [price], [cust_id], [buydate]) VALUES (3068, N'75%清潔用酒精', 1, 479, 13, CAST(N'2024-08-05' AS Date))
INSERT [dbo].[historycart] ([id], [name], [qty], [price], [cust_id], [buydate]) VALUES (3069, N'【小林製藥】嬰兒用退熱貼片', 1, 150, 13, CAST(N'2024-08-05' AS Date))
INSERT [dbo].[historycart] ([id], [name], [qty], [price], [cust_id], [buydate]) VALUES (3070, N'【Lovita愛維他】胺基酸螯合鋅', 1, 680, 13, CAST(N'2024-08-05' AS Date))
INSERT [dbo].[historycart] ([id], [name], [qty], [price], [cust_id], [buydate]) VALUES (3071, N'蘭蔻小黑瓶精華', 1, 3850, 13, CAST(N'2024-08-05' AS Date))
INSERT [dbo].[historycart] ([id], [name], [qty], [price], [cust_id], [buydate]) VALUES (3072, N'DIOR生命之源奢華金萃2024珍鑲版', 1, 112000, 13, CAST(N'2024-08-05' AS Date))
INSERT [dbo].[historycart] ([id], [name], [qty], [price], [cust_id], [buydate]) VALUES (3073, N'雅詩蘭黛特潤精修精華', 1, 4500, 13, CAST(N'2024-08-05' AS Date))
INSERT [dbo].[historycart] ([id], [name], [qty], [price], [cust_id], [buydate]) VALUES (3074, N'Gucci Bloom', 1, 3800, 13, CAST(N'2024-08-05' AS Date))
INSERT [dbo].[historycart] ([id], [name], [qty], [price], [cust_id], [buydate]) VALUES (3075, N'倩碧三步驟潔膚液', 1, 4800, 13, CAST(N'2024-08-05' AS Date))
INSERT [dbo].[historycart] ([id], [name], [qty], [price], [cust_id], [buydate]) VALUES (3076, N'滿意寶寶日本白金', 1, 380, 13, CAST(N'2024-08-05' AS Date))
INSERT [dbo].[historycart] ([id], [name], [qty], [price], [cust_id], [buydate]) VALUES (3077, N'【雀巢】能恩HA3', 1, 789, 13, CAST(N'2024-08-05' AS Date))
INSERT [dbo].[historycart] ([id], [name], [qty], [price], [cust_id], [buydate]) VALUES (3078, N'幫寶適一級幫', 1, 350, 10, CAST(N'2024-08-06' AS Date))
INSERT [dbo].[historycart] ([id], [name], [qty], [price], [cust_id], [buydate]) VALUES (3079, N'大王天使尿布', 1, 380, 10, CAST(N'2024-08-06' AS Date))
INSERT [dbo].[historycart] ([id], [name], [qty], [price], [cust_id], [buydate]) VALUES (3080, N'【Meiji 明治】金選1-3歲成長配方食品', 1, 695, 10, CAST(N'2024-08-06' AS Date))
INSERT [dbo].[historycart] ([id], [name], [qty], [price], [cust_id], [buydate]) VALUES (3081, N'資生堂紅顏肌活露', 1, 5700, 10, CAST(N'2024-08-06' AS Date))
INSERT [dbo].[historycart] ([id], [name], [qty], [price], [cust_id], [buydate]) VALUES (3082, N'Gucci Bloom', 1, 3800, 10, CAST(N'2024-08-06' AS Date))
INSERT [dbo].[historycart] ([id], [name], [qty], [price], [cust_id], [buydate]) VALUES (3083, N'寶寶Hi-Q藻油DHA粉狀食品', 1, 1200, 10, CAST(N'2024-08-06' AS Date))
INSERT [dbo].[historycart] ([id], [name], [qty], [price], [cust_id], [buydate]) VALUES (3084, N'【Okamoto岡本】 002 Hydro水感勁薄', 1, 369, 10, CAST(N'2024-08-06' AS Date))
INSERT [dbo].[historycart] ([id], [name], [qty], [price], [cust_id], [buydate]) VALUES (3085, N'幫寶適一級幫', 20, 5250, 1, CAST(N'2024-08-07' AS Date))
INSERT [dbo].[historycart] ([id], [name], [qty], [price], [cust_id], [buydate]) VALUES (3086, N'【SNOW雪印】金T3PLUS成長營養配方', 20, 10875, 1, CAST(N'2024-08-07' AS Date))
INSERT [dbo].[historycart] ([id], [name], [qty], [price], [cust_id], [buydate]) VALUES (3087, N'倩碧三步驟潔膚液', 10, 36000, 1, CAST(N'2024-08-07' AS Date))
INSERT [dbo].[historycart] ([id], [name], [qty], [price], [cust_id], [buydate]) VALUES (3088, N'【Lovita愛維他】胺基酸螯合鋅', 5, 2720, 1, CAST(N'2024-08-07' AS Date))
INSERT [dbo].[historycart] ([id], [name], [qty], [price], [cust_id], [buydate]) VALUES (3089, N'【Okamoto岡本】 002 Hydro水感勁薄', 2, 554, 1, CAST(N'2024-08-07' AS Date))
INSERT [dbo].[historycart] ([id], [name], [qty], [price], [cust_id], [buydate]) VALUES (3090, N'幫寶適一級幫', 3, 875, 29, CAST(N'2024-08-13' AS Date))
INSERT [dbo].[historycart] ([id], [name], [qty], [price], [cust_id], [buydate]) VALUES (3091, N'【雀巢】能恩HA3', 10, 5918, 29, CAST(N'2024-08-13' AS Date))
INSERT [dbo].[historycart] ([id], [name], [qty], [price], [cust_id], [buydate]) VALUES (3092, N'香奈兒COMETE幸運星辰', 2, 21900, 29, CAST(N'2024-08-13' AS Date))
GO
INSERT [dbo].[historycart] ([id], [name], [qty], [price], [cust_id], [buydate]) VALUES (3093, N'DIOR生命之源奢華金萃2024珍鑲版', 2, 168000, 29, CAST(N'2024-08-13' AS Date))
INSERT [dbo].[historycart] ([id], [name], [qty], [price], [cust_id], [buydate]) VALUES (3094, N'【Lovita愛維他】胺基酸螯合鋅', 3, 1700, 29, CAST(N'2024-08-13' AS Date))
INSERT [dbo].[historycart] ([id], [name], [qty], [price], [cust_id], [buydate]) VALUES (3095, N'【Okamoto岡本】 002 Hydro水感勁薄', 1, 369, 29, CAST(N'2024-08-13' AS Date))
SET IDENTITY_INSERT [dbo].[historycart] OFF
GO
SET IDENTITY_INSERT [dbo].[medicine] ON 

INSERT [dbo].[medicine] ([id], [name], [price], [qty], [photo]) VALUES (1, N'善存', 729, 38, N'善存.png')
INSERT [dbo].[medicine] ([id], [name], [price], [qty], [photo]) VALUES (2, N'【Lovita愛維他】胺基酸螯合鋅', 680, 20, N'胺基酸螯合鋅.png')
INSERT [dbo].[medicine] ([id], [name], [price], [qty], [photo]) VALUES (3, N'海藻成人鈣加強錠3.0', 900, 35, N'海藻成人鈣.png')
INSERT [dbo].[medicine] ([id], [name], [price], [qty], [photo]) VALUES (4, N'寶寶Hi-Q藻油DHA粉狀食品', 1200, 47, N'寶寶Hi-Q藻油.png')
INSERT [dbo].[medicine] ([id], [name], [price], [qty], [photo]) VALUES (5, N'【好立善】EUREYE葉黃素複方軟膠囊', 239, 40, N'葉黃素.png')
INSERT [dbo].[medicine] ([id], [name], [price], [qty], [photo]) VALUES (6, N'醫療成人美型口罩 山櫻紅', 129, 27, N'口罩.png')
INSERT [dbo].[medicine] ([id], [name], [price], [qty], [photo]) VALUES (7, N'75%清潔用酒精', 479, 48, N'酒精.png')
INSERT [dbo].[medicine] ([id], [name], [price], [qty], [photo]) VALUES (8, N'【Okamoto岡本】 002 Hydro水感勁薄', 369, 27, N'岡本.png')
INSERT [dbo].[medicine] ([id], [name], [price], [qty], [photo]) VALUES (9, N'【小林製藥】嬰兒用退熱貼片', 150, 36, N'退熱貼.png')
INSERT [dbo].[medicine] ([id], [name], [price], [qty], [photo]) VALUES (10, N'Nexcare 克淋濕防水透氣繃', 60, 31, N'ok蹦.png')
INSERT [dbo].[medicine] ([id], [name], [price], [qty], [photo]) VALUES (11, N'桂格雞精', 900, 50, N'雞精.png')
SET IDENTITY_INSERT [dbo].[medicine] OFF
GO
SET IDENTITY_INSERT [dbo].[orditem] ON 

INSERT [dbo].[orditem] ([id], [name], [price], [qty], [cust_id], [order_date]) VALUES (2031, N'幫寶適一級幫', 875, 3, 29, CAST(N'2024-08-13' AS Date))
INSERT [dbo].[orditem] ([id], [name], [price], [qty], [cust_id], [order_date]) VALUES (2032, N'【雀巢】能恩HA3', 5918, 10, 29, CAST(N'2024-08-13' AS Date))
INSERT [dbo].[orditem] ([id], [name], [price], [qty], [cust_id], [order_date]) VALUES (2033, N'香奈兒COMETE幸運星辰', 21900, 2, 29, CAST(N'2024-08-13' AS Date))
INSERT [dbo].[orditem] ([id], [name], [price], [qty], [cust_id], [order_date]) VALUES (2034, N'DIOR生命之源奢華金萃2024珍鑲版', 168000, 2, 29, CAST(N'2024-08-13' AS Date))
INSERT [dbo].[orditem] ([id], [name], [price], [qty], [cust_id], [order_date]) VALUES (2035, N'【Lovita愛維他】胺基酸螯合鋅', 1700, 3, 29, CAST(N'2024-08-13' AS Date))
INSERT [dbo].[orditem] ([id], [name], [price], [qty], [cust_id], [order_date]) VALUES (2036, N'【Okamoto岡本】 002 Hydro水感勁薄', 369, 1, 29, CAST(N'2024-08-13' AS Date))
SET IDENTITY_INSERT [dbo].[orditem] OFF
GO
ALTER TABLE [dbo].[finishitem]  WITH CHECK ADD FOREIGN KEY([cust_id])
REFERENCES [dbo].[customer] ([id])
ON DELETE CASCADE
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
