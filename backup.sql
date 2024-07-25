USE [pharmacy]
GO
/****** Object:  Table [dbo].[beauty]    Script Date: 2024/7/25 上午 10:01:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[beauty](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[photo] [varbinary](max) NULL,
	[name] [nvarchar](max) NULL,
	[price] [int] NULL,
	[qty] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[cart]    Script Date: 2024/7/25 上午 10:01:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cart](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[photo] [varbinary](max) NULL,
	[name] [nvarchar](max) NULL,
	[qty] [int] NULL,
	[price] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[category]    Script Date: 2024/7/25 上午 10:01:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[category](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[category] [nvarchar](max) NULL,
	[baby] [nvarchar](max) NULL,
	[beauty] [nvarchar](max) NULL,
	[medicine] [nvarchar](max) NULL,
 CONSTRAINT [PK_category] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[customers]    Script Date: 2024/7/25 上午 10:01:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[customers](
	[c_id] [int] IDENTITY(1,1) NOT NULL,
	[photo] [varbinary](max) NULL,
	[name] [varchar](max) NULL,
	[password] [varchar](max) NULL,
	[phone] [varchar](max) NULL,
	[email] [varchar](max) NULL,
	[address] [varchar](max) NULL,
	[createdate] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[c_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[diapers]    Script Date: 2024/7/25 上午 10:01:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[diapers](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[photo] [varbinary](max) NULL,
	[name] [varchar](255) NULL,
	[price] [int] NULL,
	[qty] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[employee]    Script Date: 2024/7/25 上午 10:01:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[employee](
	[e_id] [int] IDENTITY(1,1) NOT NULL,
	[photo] [varbinary](max) NULL,
	[name] [nvarchar](max) NULL,
	[password] [nvarchar](max) NULL,
	[phone] [nvarchar](max) NULL,
	[email] [nvarchar](max) NULL,
 CONSTRAINT [PK_employee] PRIMARY KEY CLUSTERED 
(
	[e_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[milks]    Script Date: 2024/7/25 上午 10:01:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[milks](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[photo] [varbinary](max) NULL,
	[name] [varchar](255) NULL,
	[price] [int] NULL,
	[qty] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[perfume]    Script Date: 2024/7/25 上午 10:01:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[perfume](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[photo] [varbinary](max) NULL,
	[name] [nvarchar](max) NULL,
	[price] [int] NULL,
	[qty] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[beauty] ON 

INSERT [dbo].[beauty] ([photo], [name], [price], [qty]) SELECT  BulkColumn, N'SK-II神仙水', 3500, 20 FROM 
    OPENROWSET(BULK N'D:\資策會課程\Project\PharmacyShop\assets\SK2.jpg', SINGLE_BLOB) AS Image;
INSERT [dbo].[beauty] ([photo], [name], [price], [qty]) SELECT  BulkColumn, N'雅詩蘭黛特潤修護精華', 4500, 20 FROM 
    OPENROWSET(BULK N'D:\資策會課程\Project\PharmacyShop\assets\雅詩蘭黛.jpg', SINGLE_BLOB) AS Image;
INSERT [dbo].[beauty] ([photo], [name], [price], [qty]) SELECT  BulkColumn, N'倩碧三步驟潔膚液', 4800, 20 FROM 
    OPENROWSET(BULK N'D:\資策會課程\Project\PharmacyShop\assets\倩碧.jpg', SINGLE_BLOB) AS Image;
INSERT [dbo].[beauty] ([photo], [name], [price], [qty]) SELECT  BulkColumn, N'蘭蔻小黑瓶精華', 3850, 20 FROM 
    OPENROWSET(BULK N'D:\資策會課程\Project\PharmacyShop\assets\蘭蔻.jpg', SINGLE_BLOB) AS Image;
INSERT [dbo].[beauty] ([photo], [name], [price], [qty]) SELECT  BulkColumn, N'資生堂紅妍肌活露', 5700, 20 FROM 
    OPENROWSET(BULK N'D:\資策會課程\Project\PharmacyShop\assets\資生堂肌紅.jpg', SINGLE_BLOB) AS Image;
INSERT [dbo].[beauty] ([photo], [name], [price], [qty]) SELECT  BulkColumn, N'DIOR生命之源奢華金萃2024依肯珍釀版', 112000, 20 FROM 
    OPENROWSET(BULK N'D:\資策會課程\Project\PharmacyShop\assets\dior金萃.jpg', SINGLE_BLOB) AS Image;
SET IDENTITY_INSERT [dbo].[beauty] OFF
GO
SET IDENTITY_INSERT [dbo].[customers] ON 

INSERT [dbo].[customers] ([name], [password], [phone], [email], [address], [createdate]) VALUES (N'Alice', N'password123', N'0912345678', N'alice@gmail.com', N'台北市中正區忠孝東路101號', NULL)
INSERT [dbo].[customers] ([name], [password], [phone], [email], [address], [createdate]) VALUES (N'Bob', N'securePass456', N'0922345678', N'bob@gmail.com', N'新北市板橋區信義路102號', NULL)
INSERT [dbo].[customers] ([name], [password], [phone], [email], [address], [createdate]) VALUES (N'Cathy', N'uniquePass789', N'0932345678', N'cathy@gmail.com', N'台中市西屯區台灣大道103號', NULL)
INSERT [dbo].[customers] ([name], [password], [phone], [email], [address], [createdate]) VALUES (N'David', N'randomPass321', N'0942345678', N'david@gmail.com', N'台南市中西區中正路104號', NULL)
INSERT [dbo].[customers] ([name], [password], [phone], [email], [address], [createdate]) VALUES (N'Eve', N'myPass654', N'0952345678', N'eve@gmail.com', N'高雄市苓雅區三多路105號', NULL)
INSERT [dbo].[customers] ([name], [password], [phone], [email], [address], [createdate]) VALUES (N'Frank', N'password998', N'0962345678', N'frank@gmail.com', N'桃園市中壢區中山路106號', NULL)
INSERT [dbo].[customers] ([name], [password], [phone], [email], [address], [createdate]) VALUES (N'Grace', N'secure555', N'0972345678', N'grace@gmail.com', N'台北市信義區市民大道107號', NULL)
INSERT [dbo].[customers] ([name], [password], [phone], [email], [address], [createdate]) VALUES (N'Hank', N'uniquePass666', N'0982345678', N'hank@gmail.com', N'新北市永和區中和路108號', NULL)
INSERT [dbo].[customers] ([name], [password], [phone], [email], [address], [createdate]) VALUES (N'Ivy', N'secure123', N'0912345679', N'ivy@gmail.com', N'新竹市東區光復路109號', NULL)
INSERT [dbo].[customers] ([name], [password], [phone], [email], [address], [createdate]) VALUES (N'Jack', N'random654', N'0922345679', N'jack@gmail.com', N'台南市東區東門路110號', NULL)
INSERT [dbo].[customers] ([name], [password], [phone], [email], [address], [createdate]) VALUES (N'Kate', N'pass4321', N'0932345679', N'kate@gmail.com', N'台中市北區進化路111號', NULL)
INSERT [dbo].[customers] ([name], [password], [phone], [email], [address], [createdate]) VALUES (N'Leo', N'myPass432', N'0942345679', N'leo@gmail.com', N'高雄市左營區自由路112號', NULL)
INSERT [dbo].[customers] ([name], [password], [phone], [email], [address], [createdate]) VALUES (N'Mia', N'securePass555', N'0952345679', N'mia@gmail.com', N'基隆市仁愛區忠一路113號', NULL)
INSERT [dbo].[customers] ([name], [password], [phone], [email], [address], [createdate]) VALUES (N'Nina', N'unique321', N'0962345679', N'nina@gmail.com', N'彰化市中山路114號', NULL)
INSERT [dbo].[customers] ([name], [password], [phone], [email], [address], [createdate]) VALUES (N'Oscar', N'random888', N'0972345679', N'oscar@gmail.com', N'嘉義市西區民生北路115號', NULL)
INSERT [dbo].[customers] ([name], [password], [phone], [email], [address], [createdate]) VALUES (N'Paul', N'myPass789', N'0982345679', N'paul@gmail.com', N'台中市南區復興路116號', NULL)
INSERT [dbo].[customers] ([name], [password], [phone], [email], [address], [createdate]) VALUES (N'Queen', N'secure222', N'0912345680', N'queen@gmail.com', N'新北市三重區重新路117號', NULL)
INSERT [dbo].[customers] ([name], [password], [phone], [email], [address], [createdate]) VALUES (N'Rose', N'uniquePass999', N'0922345680', N'rose@gmail.com', N'新竹市北區中正路118號', NULL)
INSERT [dbo].[customers] ([name], [password], [phone], [email], [address], [createdate]) VALUES (N'Sam', N'random777', N'0932345680', N'sam@gmail.com', N'台北市大安區敦化南路119號', NULL)
INSERT [dbo].[customers] ([name], [password], [phone], [email], [address], [createdate]) VALUES (20, N'Tina', N'myPass111', N'0942345680', N'tina@gmail.com', N'台南市南區健康路120號', NULL)
INSERT [dbo].[customers] ([name], [password], [phone], [email], [address], [createdate]) VALUES (21, N'Uma', N'securePass888', N'0952345680', N'uma@gmail.com', N'新北市新店區北新路121號', NULL)
INSERT [dbo].[customers] ([name], [password], [phone], [email], [address], [createdate]) VALUES (22, N'Victor', N'unique333', N'0962345680', N'victor@gmail.com', N'台中市東區東光路122號', NULL)
INSERT [dbo].[customers] ([name], [password], [phone], [email], [address], [createdate]) VALUES (23, N'Wendy', N'random999', N'0972345680', N'wendy@gmail.com', N'高雄市三民區建國路123號', NULL)
INSERT [dbo].[customers] ([name], [password], [phone], [email], [address], [createdate]) VALUES (24, N'Xander', N'myPass222', N'0982345680', N'xander@gmail.com', N'桃園市大溪區大溪路124號', NULL)
INSERT [dbo].[customers] ([name], [password], [phone], [email], [address], [createdate]) VALUES (25, N'Yvonne', N'securePass444', N'0912345681', N'yvonne@gmail.com', N'新竹縣竹北市自強南路125號', NULL)
INSERT [dbo].[customers] ([name], [password], [phone], [email], [address], [createdate]) VALUES (26, N'Zack', N'unique111', N'0922345681', N'zack@gmail.com', N'台北市松山區復興北路126號', NULL)
INSERT [dbo].[customers] ([name], [password], [phone], [email], [address], [createdate]) VALUES (27, N'Amy', N'random555', N'0932345681', N'amy@gmail.com', N'新北市中和區景平路127號', NULL)
INSERT [dbo].[customers] ([name], [password], [phone], [email], [address], [createdate]) VALUES (28, N'Brian', N'myPass666', N'0942345681', N'brian@gmail.com', N'台中市西屯區河南路128號', NULL)
INSERT [dbo].[customers] ([name], [password], [phone], [email], [address], [createdate]) VALUES (29, N'Clara', N'secure111', N'0952345681', N'clara@gmail.com', N'台南市北區文賢路129號', NULL)
INSERT [dbo].[customers] ([name], [password], [phone], [email], [address], [createdate]) VALUES (30, N'Dennis', N'uniquePass555', N'0962345681', N'dennis@gmail.com', N'高雄市鼓山區九如路130號', NULL)
INSERT [dbo].[customers] ([name], [password], [phone], [email], [address], [createdate]) VALUES (31, N'Elaine', N'random444', N'0972345681', N'elaine@gmail.com', N'桃園市蘆竹區南竹路131號', NULL)
INSERT [dbo].[customers] ([name], [password], [phone], [email], [address], [createdate]) VALUES (32, N'Frank', N'myPass333', N'0982345681', N'frank2@gmail.com', N'台北市文山區木新路132號', NULL)
INSERT [dbo].[customers] ([name], [password], [phone], [email], [address], [createdate]) VALUES (33, N'Gina', N'secure777', N'0912345682', N'gina@gmail.com', N'新北市汐止區忠孝東路133號', NULL)
INSERT [dbo].[customers] ([name], [password], [phone], [email], [address], [createdate]) VALUES (34, N'Henry', N'unique222', N'0922345682', N'henry@gmail.com', N'嘉義縣民雄鄉中山路134號', NULL)
INSERT [dbo].[customers] ([name], [password], [phone], [email], [address], [createdate]) VALUES (35, N'Isabel', N'random111', N'0932345682', N'isabel@gmail.com', N'基隆市中山區中和路135號', NULL)
INSERT [dbo].[customers] ([name], [password], [phone], [email], [address], [createdate]) VALUES (36, N'John', N'myPass888', N'0942345682', N'john@gmail.com', N'台中市北屯區太原路136號', NULL)
INSERT [dbo].[customers] ([name], [password], [phone], [email], [address], [createdate]) VALUES (37, N'Karen', N'securePass999', N'0952345682', N'karen@gmail.com', N'台南市安南區安中路137號', NULL)
INSERT [dbo].[customers] ([name], [password], [phone], [email], [address], [createdate]) VALUES (38, N'Leo', N'unique444', N'0962345682', N'leo2@gmail.com', N'高雄市前鎮區瑞隆路138號', NULL)
INSERT [dbo].[customers] ([name], [password], [phone], [email], [address], [createdate]) VALUES (39, N'Maria', N'random222', N'0972345682', N'maria@gmail.com', N'桃園市八德區和平路139號', NULL)
INSERT [dbo].[customers] ([name], [password], [phone], [email], [address], [createdate]) VALUES (40, N'Nathan', N'myPass555', N'0982345682', N'nathan@gmail.com', N'台北市士林區中山北路140號', NULL)
INSERT [dbo].[customers] ([name], [password], [phone], [email], [address], [createdate]) VALUES (41, N'Olivia', N'securePass111', N'0912345683', N'olivia@gmail.com', N'新北市淡水區民生路141號', NULL)
INSERT [dbo].[customers] ([name], [password], [phone], [email], [address], [createdate]) VALUES (42, N'Peter', N'unique777', N'0922345683', N'peter@gmail.com', N'新竹市香山區竹光路142號', NULL)
INSERT [dbo].[customers] ([name], [password], [phone], [email], [address], [createdate]) VALUES (43, N'Quincy', N'random333', N'0932345683', N'quincy@gmail.com', N'台中市大里區光明路143號', NULL)
INSERT [dbo].[customers] ([name], [password], [phone], [email], [address], [createdate]) VALUES (44, N'Rachel', N'myPass999', N'0942345683', N'rachel@gmail.com', N'台南市永康區中正路144號', NULL)
INSERT [dbo].[customers] ([name], [password], [phone], [email], [address], [createdate]) VALUES (45, N'Steve', N'securePass333', N'0952345683', N'steve@gmail.com', N'高雄市鳳山區五甲路145號', NULL)
INSERT [dbo].[customers] ([name], [password], [phone], [email], [address], [createdate]) VALUES (46, N'Tom', N'unique888', N'0962345683', N'tom@gmail.com', N'桃園市中壢區福德路146號', NULL)
INSERT [dbo].[customers] ([name], [password], [phone], [email], [address], [createdate]) VALUES (47, N'Una', N'random666', N'0972345683', N'una@gmail.com', N'台北市內湖區民權東路147號', NULL)
INSERT [dbo].[customers] ([photo], [name], [password], [phone], [email], [address]) SELECT BulkColumn, N'Dudu', N'123456', N'0982345683', N'dudu@gmail.com', N'高雄市左營區華夏路路1478號' FROM 
    OPENROWSET(BULK N'D:\photoA\_com.apple.Pasteboard.0IjSoo.jpg', SINGLE_BLOB) AS Image;
SET IDENTITY_INSERT [dbo].[customers] OFF
GO
SET IDENTITY_INSERT [dbo].[diapers] ON 

INSERT [dbo].[diapers] ([photo], [name], [price], [qty]) SELECT  BulkColumn, N'幫寶適一級幫', 350, 20 FROM 
    OPENROWSET(BULK N'D:\資策會課程\Project\PharmacyShop\assets\Pampers.jpg', SINGLE_BLOB) AS Image;
INSERT [dbo].[diapers] ([photo], [name], [price], [qty]) SELECT  BulkColumn, N'妙而舒金緻柔點', 320, 20 FROM 
    OPENROWSET(BULK N'D:\資策會課程\Project\PharmacyShop\assets\妙而舒金緻.jpg', SINGLE_BLOB) AS Image;
INSERT [dbo].[diapers] ([photo], [name], [price], [qty]) SELECT  BulkColumn, N'大王天使尿布', 380, 20 FROM 
    OPENROWSET(BULK N'D:\資策會課程\Project\PharmacyShop\assets\大王天使.jpg', SINGLE_BLOB) AS Image;
INSERT [dbo].[diapers] ([photo], [name], [price], [qty]) SELECT  BulkColumn, N'麗貝樂', 310, 20 FROM 
    OPENROWSET(BULK N'D:\資策會課程\Project\PharmacyShop\assets\麗貝樂.jpg', SINGLE_BLOB) AS Image;
INSERT [dbo].[diapers] ([photo], [name], [price], [qty]) SELECT  BulkColumn, N'滿意寶寶日本白金', 380, 20 FROM 
    OPENROWSET(BULK N'D:\資策會課程\Project\PharmacyShop\assets\MamyPoko.jpg', SINGLE_BLOB) AS Image;
SET IDENTITY_INSERT [dbo].[diapers] OFF
GO
SET IDENTITY_INSERT [dbo].[employee] ON 

INSERT [dbo].[employee] ([e_id], [name], [password], [phone], [email]) VALUES (1, N'John', N'password123', N'0912345678', N'john.doe@example.com')
INSERT [dbo].[employee] ([e_id], [name], [password], [phone], [email]) VALUES (2, N'Jane', N'securePass456', N'0922345678', N'jane.smith@example.com')
INSERT [dbo].[employee] ([e_id], [name], [password], [phone], [email]) VALUES (3, N'Alice', N'uniquePass789', N'0932345678', N'alice.johnson@example.com')
INSERT [dbo].[employee] ([e_id], [name], [password], [phone], [email]) VALUES (4, N'Bob', N'randomPass321', N'0942345678', N'bob.brown@example.com')
INSERT [dbo].[employee] ([e_id], [name], [password], [phone], [email]) VALUES (5, N'Carol', N'myPass654', N'0952345678', N'carol.white@example.com')
SET IDENTITY_INSERT [dbo].[employee] OFF
GO
SET IDENTITY_INSERT [dbo].[milks] ON 

INSERT [dbo].[milks] ([photo], [name], [price], [qty]) SELECT  BulkColumn, N'雪印', 780, 20 FROM 
    OPENROWSET(BULK N'D:\資策會課程\Project\PharmacyShop\assets\雪印T3.jpg', SINGLE_BLOB) AS Image;
INSERT [dbo].[milks] ([photo], [name], [price], [qty]) SELECT  BulkColumn, N'雅培親護', 980, 20 FROM 
    OPENROWSET(BULK N'D:\資策會課程\Project\PharmacyShop\assets\亞培.jpg', SINGLE_BLOB) AS Image;
INSERT [dbo].[milks] ([photo], [name], [price], [qty]) SELECT  BulkColumn, N'惠氏S-26', 870, 20 FROM 
    OPENROWSET(BULK N'D:\資策會課程\Project\PharmacyShop\assets\S26金愛兒樂.png', SINGLE_BLOB) AS Image;
INSERT [dbo].[milks] ([photo], [name], [price], [qty]) SELECT  BulkColumn, N'雀巢能恩', 970, 20 FROM 
    OPENROWSET(BULK N'D:\資策會課程\Project\PharmacyShop\assets\雀巢能恩水解.jpg', SINGLE_BLOB) AS Image;
INSERT [dbo].[milks] ([photo], [name], [price], [qty]) SELECT  BulkColumn, N'Meji明治', 820, 20 FROM 
    OPENROWSET(BULK N'D:\資策會課程\Project\PharmacyShop\assets\明治.png', SINGLE_BLOB) AS Image;
SET IDENTITY_INSERT [dbo].[milks] OFF
GO
SET IDENTITY_INSERT [dbo].[perfume] ON 

INSERT [dbo].[perfume] ([photo], [name], [price], [qty]) SELECT  BulkColumn, N'香奈兒COMETE幸運星辰', 14600, 20 FROM 
    OPENROWSET(BULK N'D:\資策會課程\Project\PharmacyShop\assets\香奈兒星辰.jpg', SINGLE_BLOB) AS Image;
INSERT [dbo].[perfume] ([photo], [name], [price], [qty]) SELECT  BulkColumn, N'MISS DIOR花漾迪奧', 3850, 20 FROM 
    OPENROWSET(BULK N'D:\資策會課程\Project\PharmacyShop\assets\DIOR奧迪花樣.jpg', SINGLE_BLOB) AS Image;
INSERT [dbo].[perfume] ([photo], [name], [price], [qty]) SELECT  BulkColumn, N'Gucci Bloom', 3800, 20 FROM 
    OPENROWSET(BULK N'D:\資策會課程\Project\PharmacyShop\assets\GUCCI.jpg', SINGLE_BLOB) AS Image;
INSERT [dbo].[perfume] ([photo], [name], [price], [qty]) SELECT  BulkColumn, N'Twilly Hermes淡香精', 6100, 20 FROM 
    OPENROWSET(BULK N'D:\資策會課程\Project\PharmacyShop\assets\愛馬仕.jpg', SINGLE_BLOB) AS Image;
INSERT [dbo].[perfume] ([photo], [name], [price], [qty]) SELECT  BulkColumn, N'Yves Saint Laurent Black Opium', 4000, 20 FROM 
    OPENROWSET(BULK N'D:\資策會課程\Project\PharmacyShop\assets\YSL.jpg', SINGLE_BLOB) AS Image;
SET IDENTITY_INSERT [dbo].[perfume] OFF
GO
