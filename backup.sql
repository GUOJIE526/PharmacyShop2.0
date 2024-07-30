USE [pharmacy]
GO
/****** Object:  Table [dbo].[beauty]    Script Date: 2024/7/29 下午 11:14:48 ******/
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
/****** Object:  Table [dbo].[customer]    Script Date: 2024/7/29 下午 11:14:48 ******/
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
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[diaper]    Script Date: 2024/7/29 下午 11:14:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[diaper](
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
/****** Object:  Table [dbo].[employee]    Script Date: 2024/7/29 下午 11:14:48 ******/
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
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[historycart]    Script Date: 2024/7/29 下午 11:14:48 ******/
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
/****** Object:  Table [dbo].[medicine]    Script Date: 2024/7/29 下午 11:14:48 ******/
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
/****** Object:  Table [dbo].[milk]    Script Date: 2024/7/29 下午 11:14:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[milk](
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
/****** Object:  Table [dbo].[mm]    Script Date: 2024/7/29 下午 11:14:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[mm](
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
/****** Object:  Table [dbo].[perfume]    Script Date: 2024/7/29 下午 11:14:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[perfume](
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
/****** Object:  Table [dbo].[prodimg]    Script Date: 2024/7/29 下午 11:14:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[prodimg](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](max) NULL,
	[photo] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[beauty] ON 

INSERT [dbo].[beauty] ([id], [name], [price], [qty], [photo]) VALUES (1, N'SK-II 神仙水', 3500, 25, N'D:\資策會課程\Project\PharmacyShop\assets\SK2.jpg')
INSERT [dbo].[beauty] ([id], [name], [price], [qty], [photo]) VALUES (2, N'雅詩蘭黛特潤精修精華', 4500, 25, N'D:\資策會課程\Project\PharmacyShop\assets\雅詩蘭黛.jpg')
INSERT [dbo].[beauty] ([id], [name], [price], [qty], [photo]) VALUES (3, N'倩碧三步驟潔膚液', 4800, 25, N'D:\資策會課程\Project\PharmacyShop\assets\倩碧.jpg')
INSERT [dbo].[beauty] ([id], [name], [price], [qty], [photo]) VALUES (4, N'蘭蔻小黑瓶精華', 3850, 25, N'D:\資策會課程\Project\PharmacyShop\assets\蘭蔻.jpg')
INSERT [dbo].[beauty] ([id], [name], [price], [qty], [photo]) VALUES (5, N'資生堂紅顏肌活露', 5700, 25, N'D:\資策會課程\Project\PharmacyShop\assets\資生堂肌紅.jpg')
INSERT [dbo].[beauty] ([id], [name], [price], [qty], [photo]) VALUES (6, N'DIOR生命之源奢華金萃2024珍鑲版', 112000, 25, N'D:\資策會課程\Project\PharmacyShop\assets\dior金萃.jpg')
SET IDENTITY_INSERT [dbo].[beauty] OFF
GO
SET IDENTITY_INSERT [dbo].[customer] ON 

INSERT [dbo].[customer] ([id], [name], [password], [phone], [email], [address], [createdate]) VALUES (1, N'Dudu', N'123456', N'0956380789', N'dd@gmail.com', N'高雄市前金區中正四路211號8樓之1', CAST(N'2024-07-27' AS Date))
SET IDENTITY_INSERT [dbo].[customer] OFF
GO
SET IDENTITY_INSERT [dbo].[diaper] ON 

INSERT [dbo].[diaper] ([id], [name], [price], [qty], [photo]) VALUES (1, N'幫寶適一級幫', 350, 35, N'D:\資策會課程\Project\PharmacyShop\assets\Pampers.jpg')
INSERT [dbo].[diaper] ([id], [name], [price], [qty], [photo]) VALUES (2, N'妙而舒金緻柔點', 320, 25, N'D:\資策會課程\Project\PharmacyShop\assets\妙而舒金緻.jpg')
INSERT [dbo].[diaper] ([id], [name], [price], [qty], [photo]) VALUES (3, N'大王天使尿布', 380, 22, N'D:\資策會課程\Project\PharmacyShop\assets\大王天使.jpg')
INSERT [dbo].[diaper] ([id], [name], [price], [qty], [photo]) VALUES (4, N'麗貝樂', 310, 25, N'D:\資策會課程\Project\PharmacyShop\assets\麗貝樂.jpg')
INSERT [dbo].[diaper] ([id], [name], [price], [qty], [photo]) VALUES (5, N'滿意寶寶日本白金', 380, 35, N'D:\資策會課程\Project\PharmacyShop\assets\MamyPoko.jpg')
SET IDENTITY_INSERT [dbo].[diaper] OFF
GO
SET IDENTITY_INSERT [dbo].[employee] ON 

INSERT [dbo].[employee] ([id], [name], [password], [phone], [email], [address], [createdate]) VALUES (1, N'admin', N'admin', NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[employee] OFF
GO
SET IDENTITY_INSERT [dbo].[historycart] ON 

INSERT [dbo].[historycart] ([id], [name], [qty], [price], [cust_id], [buydate]) VALUES (1024, N'Nexcare 克淋濕防水透氣繃', 2, 90, 1, CAST(N'2024-07-29' AS Date))
INSERT [dbo].[historycart] ([id], [name], [qty], [price], [cust_id], [buydate]) VALUES (1025, N'海藻成人鈣加強錠2.0', 3, 2250, 1, CAST(N'2024-07-29' AS Date))
INSERT [dbo].[historycart] ([id], [name], [qty], [price], [cust_id], [buydate]) VALUES (1026, N'【Wyeth惠氏】S-26 金幼兒樂', 3, 1748, 1, CAST(N'2024-07-29' AS Date))
INSERT [dbo].[historycart] ([id], [name], [qty], [price], [cust_id], [buydate]) VALUES (1027, N'大王天使尿布', 3, 950, 1, CAST(N'2024-07-29' AS Date))
INSERT [dbo].[historycart] ([id], [name], [qty], [price], [cust_id], [buydate]) VALUES (1028, N'【Okamoto岡本】 002 Hydro水感勁薄', 3, 923, 1, CAST(N'2024-07-29' AS Date))
SET IDENTITY_INSERT [dbo].[historycart] OFF
GO
SET IDENTITY_INSERT [dbo].[medicine] ON 

INSERT [dbo].[medicine] ([id], [name], [price], [qty], [photo]) VALUES (1, N'善存', 729, 35, N'D:\資策會課程\Project\PharmacyShop\assets\善存.jpg')
INSERT [dbo].[medicine] ([id], [name], [price], [qty], [photo]) VALUES (2, N'【Lovita愛維他】胺基酸螯合鋅', 680, 25, N'D:\資策會課程\Project\PharmacyShop\assets\【Lovita愛維他】胺基酸螯合鋅.jpg')
INSERT [dbo].[medicine] ([id], [name], [price], [qty], [photo]) VALUES (3, N'海藻成人鈣加強錠2.0', 900, 22, N'D:\資策會課程\Project\PharmacyShop\assets\常春藤_海藻成人鈣.jpg')
INSERT [dbo].[medicine] ([id], [name], [price], [qty], [photo]) VALUES (4, N'寶寶Hi-Q藻油DHA粉狀食品', 1200, 25, N'D:\資策會課程\Project\PharmacyShop\assets\【孕哺兒】寶寶Hi-Q藻油DHA粉狀食品.jpg')
INSERT [dbo].[medicine] ([id], [name], [price], [qty], [photo]) VALUES (5, N'【好立善】EUREYE葉黃素複方軟膠囊', 239, 35, N'D:\資策會課程\Project\PharmacyShop\assets\葉黃素.jpg')
SET IDENTITY_INSERT [dbo].[medicine] OFF
GO
SET IDENTITY_INSERT [dbo].[milk] ON 

INSERT [dbo].[milk] ([id], [name], [price], [qty], [photo]) VALUES (1, N'【Wyeth惠氏】S-26 金幼兒樂', 699, 32, N'D:\資策會課程\Project\PharmacyShop\assets\S26金愛兒樂.jpg')
INSERT [dbo].[milk] ([id], [name], [price], [qty], [photo]) VALUES (2, N'【SNOW雪印】金T3PLUS成長營養配方', 725, 25, N'D:\資策會課程\Project\PharmacyShop\assets\雪印T3.jpg')
INSERT [dbo].[milk] ([id], [name], [price], [qty], [photo]) VALUES (3, N'【亞培】心美力 HM.O幼兒成長配方', 1299, 25, N'D:\資策會課程\Project\PharmacyShop\assets\亞培.jpg')
INSERT [dbo].[milk] ([id], [name], [price], [qty], [photo]) VALUES (4, N'【雀巢】能恩HA3', 789, 25, N'D:\資策會課程\Project\PharmacyShop\assets\雀巢能恩水解.jpg')
INSERT [dbo].[milk] ([id], [name], [price], [qty], [photo]) VALUES (5, N'【Meiji 明治】金選1-3歲成長配方食品', 695, 35, N'D:\資策會課程\Project\PharmacyShop\assets\明治.jpg')
SET IDENTITY_INSERT [dbo].[milk] OFF
GO
SET IDENTITY_INSERT [dbo].[mm] ON 

INSERT [dbo].[mm] ([id], [name], [price], [qty], [photo]) VALUES (1, N'醫療成人美型口罩 山櫻紅', 129, 35, N'D:\資策會課程\Project\PharmacyShop\assets\口罩.jpg')
INSERT [dbo].[mm] ([id], [name], [price], [qty], [photo]) VALUES (2, N'75%清潔用酒精', 479, 25, N'D:\資策會課程\Project\PharmacyShop\assets\酒精.jpg')
INSERT [dbo].[mm] ([id], [name], [price], [qty], [photo]) VALUES (3, N'【Okamoto岡本】 002 Hydro水感勁薄', 369, 22, N'D:\資策會課程\Project\PharmacyShop\assets\岡本.jpg')
INSERT [dbo].[mm] ([id], [name], [price], [qty], [photo]) VALUES (4, N'【小林製藥】嬰兒用退熱貼片', 150, 25, N'D:\資策會課程\Project\PharmacyShop\assets\退熱貼.png')
INSERT [dbo].[mm] ([id], [name], [price], [qty], [photo]) VALUES (5, N'Nexcare 克淋濕防水透氣繃', 60, 33, N'D:\資策會課程\Project\PharmacyShop\assets\ok蹦.jpg')
SET IDENTITY_INSERT [dbo].[mm] OFF
GO
SET IDENTITY_INSERT [dbo].[perfume] ON 

INSERT [dbo].[perfume] ([id], [name], [price], [qty], [photo]) VALUES (1, N'香奈兒COMETE幸運星辰', 14600, 35, N'D:\資策會課程\Project\PharmacyShop\assets\香奈兒星辰.jpg')
INSERT [dbo].[perfume] ([id], [name], [price], [qty], [photo]) VALUES (2, N'MISS DIOR花漾迪奧', 3850, 25, N'D:\資策會課程\Project\PharmacyShop\assets\DIOR奧迪花樣.jpg')
INSERT [dbo].[perfume] ([id], [name], [price], [qty], [photo]) VALUES (3, N'Gucci Bloom', 3800, 25, N'D:\資策會課程\Project\PharmacyShop\assets\GUCCI.jpg')
INSERT [dbo].[perfume] ([id], [name], [price], [qty], [photo]) VALUES (4, N'Twilly Hermes淡香精', 6100, 25, N'D:\資策會課程\Project\PharmacyShop\assets\愛馬仕.png')
INSERT [dbo].[perfume] ([id], [name], [price], [qty], [photo]) VALUES (5, N'Yves Saint Laurent Black Opium', 4000, 35, N'D:\資策會課程\Project\PharmacyShop\assets\YSL.jpg')
SET IDENTITY_INSERT [dbo].[perfume] OFF
GO
SET IDENTITY_INSERT [dbo].[prodimg] ON 

INSERT [dbo].[prodimg] ([id], [name], [photo]) VALUES (1, N'香奈兒COMETE幸運星辰', N'D:\資策會課程\Project\PharmacyShop\assets\香奈兒星辰.jpg')
INSERT [dbo].[prodimg] ([id], [name], [photo]) VALUES (2, N'MISS DIOR花漾迪奧', N'D:\資策會課程\Project\PharmacyShop\assets\DIOR奧迪花樣.jpg')
INSERT [dbo].[prodimg] ([id], [name], [photo]) VALUES (3, N'Gucci Bloom', N'D:\資策會課程\Project\PharmacyShop\assets\GUCCI.jpg')
INSERT [dbo].[prodimg] ([id], [name], [photo]) VALUES (4, N'Twilly Hermes淡香精', N'D:\資策會課程\Project\PharmacyShop\assets\愛馬仕.jpg')
INSERT [dbo].[prodimg] ([id], [name], [photo]) VALUES (5, N'Yves Saint Laurent Black Opium', N'D:\資策會課程\Project\PharmacyShop\assets\YSL.jpg')
SET IDENTITY_INSERT [dbo].[prodimg] OFF
GO
ALTER TABLE [dbo].[historycart]  WITH CHECK ADD  CONSTRAINT [FK_customer_historycart] FOREIGN KEY([cust_id])
REFERENCES [dbo].[customer] ([id])
GO
ALTER TABLE [dbo].[historycart] CHECK CONSTRAINT [FK_customer_historycart]
GO
