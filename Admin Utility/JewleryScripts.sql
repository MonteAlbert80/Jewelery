-- DBWScript v4.1
-- Database: D:\Dev\ASP\Jewelery\Admin Utility\Jewelry2.accdb

CREATE TABLE [cart] (
	[id] NVARCHAR(50),
	[qty] INTEGER NOT NULL DEFAULT 0,
	[price] INTEGER NOT NULL DEFAULT 0,
	[name] NVARCHAR(50),
	[discount] INTEGER NOT NULL DEFAULT 0,
	CONSTRAINT [cart$id] PRIMARY KEY ([id])
);
GO

CREATE TABLE [category] (
	[name] NVARCHAR(50),
	CONSTRAINT [category$name] PRIMARY KEY ([name])
);
GO

CREATE TABLE [customer] (
	[name] NVARCHAR(50) NOT NULL,
	[last_name] NVARCHAR(50) NOT NULL,
	[address] NVARCHAR(50) NOT NULL,
	[city] NVARCHAR(50) NOT NULL,
	[country] NVARCHAR(50) NOT NULL,
	[pcode] NVARCHAR(7) NOT NULL,
	[email] NVARCHAR(50) NOT NULL,
	[id] NVARCHAR(50) NOT NULL,
	[pwd] NVARCHAR(50) NOT NULL,
	[subscribe] INTEGER NOT NULL DEFAULT 0,
	CONSTRAINT [customer$id] PRIMARY KEY ([id])
);
GO

CREATE TABLE [ditem] (
	[code] NVARCHAR(50) NOT NULL,
	[quantity] INTEGER NOT NULL DEFAULT 0,
	[name] NVARCHAR(50) NOT NULL,
	[price] INTEGER NOT NULL DEFAULT 0,
	[discount] INTEGER NOT NULL DEFAULT 0,
	[category] NVARCHAR(50) NOT NULL,
	[description] NVARCHAR(50) NOT NULL,
	[image_path] NVARCHAR(50) NOT NULL,
	[main] INTEGER NOT NULL DEFAULT 0,
	CONSTRAINT [ditem$code] PRIMARY KEY ([code])
);
GO

CREATE TABLE [item] (
	[code] NVARCHAR(50) NOT NULL,
	[quantity] INTEGER NOT NULL DEFAULT 0,
	[name] NVARCHAR(50) NOT NULL,
	[price] INTEGER NOT NULL DEFAULT 0,
	[discount] INTEGER NOT NULL DEFAULT 0,
	[category] NVARCHAR(50) NOT NULL,
	[description] NVARCHAR(255) NOT NULL,
	[image_path] NVARCHAR(50),
	[main] INTEGER NOT NULL DEFAULT 0,
	CONSTRAINT [item$code] PRIMARY KEY ([code])
);
GO

CREATE TABLE [item_in_order] (
	[number] NVARCHAR(50) NOT NULL,
	[item_code] NVARCHAR(50) NOT NULL,
	[quantity] INTEGER NOT NULL DEFAULT 0,
	[price] INTEGER NOT NULL DEFAULT 0,
	[discount] INTEGER NOT NULL DEFAULT 0,
	CONSTRAINT [item_in_order$number] PRIMARY KEY ([number])
);
GO

CREATE TABLE [material_info] (
	[material_name] NVARCHAR(50) NOT NULL,
	[weight] INTEGER NOT NULL DEFAULT 0,
	[item_code] NVARCHAR(50) NOT NULL,
	[Price] INTEGER NOT NULL DEFAULT 0,
	CONSTRAINT [material_info$item_code] PRIMARY KEY ([item_code])
);
GO

CREATE TABLE [order_info] (
	[number] NVARCHAR(50) NOT NULL,
	[user_id] NVARCHAR(50) NOT NULL,
	[date] DATETIME NOT NULL,
	[del_date] DATETIME NOT NULL,
	[status] NVARCHAR(50) NOT NULL,
	[price] INTEGER NOT NULL DEFAULT 0,
	[dis_price] INTEGER NOT NULL DEFAULT 0,
	[ccard] NVARCHAR(50) NOT NULL,
	CONSTRAINT [order_info$number] PRIMARY KEY ([number])
);
GO

CREATE TABLE [owner] (
	[owner_id] NVARCHAR(50) NOT NULL,
	[pwd] NVARCHAR(50) NOT NULL,
	[total_items] INTEGER DEFAULT 0,
	[add] NVARCHAR(50) NOT NULL,
	[email] NVARCHAR(50) NOT NULL,
	CONSTRAINT [owner$owner_id] PRIMARY KEY ([owner_id])
);
GO

CREATE TABLE [post] (
	[number] INTEGER,
	[id] NVARCHAR(50) NOT NULL,
	[name] NVARCHAR(50) NOT NULL,
	[email] NVARCHAR(50) NOT NULL,
	[description] NVARCHAR(50) NOT NULL,
	CONSTRAINT [post$number] PRIMARY KEY ([number])
);
GO

CREATE TABLE [rlink] (
	[name] NVARCHAR(50) NOT NULL,
	[link] NVARCHAR(50) NOT NULL,
	CONSTRAINT [rlink$name] PRIMARY KEY ([name])
);
GO

CREATE INDEX [cart$id2]
	ON [cart] ([id]);
GO

CREATE INDEX [customer$id2]
	ON [customer] ([id]);
GO

CREATE INDEX [customer$pcode]
	ON [customer] ([pcode]);
GO

CREATE INDEX [ditem$code2]
	ON [ditem] ([code]);
GO

CREATE INDEX [item$code2]
	ON [item] ([code]);
GO

CREATE INDEX [item_in_order$item_code]
	ON [item_in_order] ([item_code]);
GO

CREATE INDEX [material_info$item_code2]
	ON [material_info] ([item_code]);
GO

CREATE INDEX [order_info$user_id]
	ON [order_info] ([user_id]);
GO

CREATE INDEX [owner$owner_id2]
	ON [owner] ([owner_id]);
GO

CREATE INDEX [post$id]
	ON [post] ([id]);
GO

CREATE INDEX [post$number2]
	ON [post] ([number]);
GO

INSERT INTO [cart] ([id], [qty], [price], [name], [discount]) VALUES (N'18', 1, 1250, N'Blue Necklace', 5);
GO

INSERT INTO [cart] ([id], [qty], [price], [name], [discount]) VALUES (N'28', 1, 20000, N'Gold Necklace', 5);
GO

INSERT INTO [cart] ([id], [qty], [price], [name], [discount]) VALUES (N'4', 3, 2000, N'Multi-Heart Pendant', 0);
GO

INSERT INTO [category] ([name]) VALUES (N'Bindiya');
GO

INSERT INTO [category] ([name]) VALUES (N'Bracelet');
GO

INSERT INTO [category] ([name]) VALUES (N'Diamonds');
GO

INSERT INTO [category] ([name]) VALUES (N'Earing');
GO

INSERT INTO [category] ([name]) VALUES (N'Necklace');
GO

INSERT INTO [category] ([name]) VALUES (N'Pendant');
GO

INSERT INTO [category] ([name]) VALUES (N'Tie Pin');
GO

INSERT INTO [customer] ([name], [last_name], [address], [city], [country], [pcode], [email], [id], [pwd], [subscribe]) VALUES (N'Muddassir', N'Abbas', N'232/2 Manekji Street Garden East', N'Karachi', N'Pakistan', N'7455', N'madabbas@gerrys.net', N'mudabbas', N'asdfg', 1);
GO

INSERT INTO [customer] ([name], [last_name], [address], [city], [country], [pcode], [email], [id], [pwd], [subscribe]) VALUES (N'Muddassir', N'Abbas', N'606 Rosedale Ave', N'Windsor', N'Ontario', N'7445', N'muddassirch@yahoo.com', N'muddassirch', N'iqtabas', 0);
GO

INSERT INTO [customer] ([name], [last_name], [address], [city], [country], [pcode], [email], [id], [pwd], [subscribe]) VALUES (N'Sarika', N'a', N'40 a latif cloth market saleh muhammad', N'b', N'a', N'23', N'a@b.com', N's', N'abcd', 1);
GO

INSERT INTO [customer] ([name], [last_name], [address], [city], [country], [pcode], [email], [id], [pwd], [subscribe]) VALUES (N'sarika', N'subhash', N'abcd', N'khi', N'pk', N'75000', N'abcd@yahoo.com', N'sarika', N'subhash', 1);
GO

INSERT INTO [customer] ([name], [last_name], [address], [city], [country], [pcode], [email], [id], [pwd], [subscribe]) VALUES (N'sarika', N'subhash', N'cvvv', N'khi', N'pk', N'12345', N'a@b.com', N'sarikay', N'subhash', 1);
GO

INSERT INTO [customer] ([name], [last_name], [address], [city], [country], [pcode], [email], [id], [pwd], [subscribe]) VALUES (N'yamin', N'moosa', N'abc', N'khi', N'pk', N'75300', N'yaminmoosa@yahoo.com', N'yamin', N'musa', 1);
GO

INSERT INTO [item] ([code], [quantity], [name], [price], [discount], [category], [description], [image_path], [main]) VALUES (N'1', 0, N'Heart Shaped Pandent', 5000, 5, N'Pendant', N'Silver,  very beautiful , heart shaped ....your gf will fall in love with it', N'p1.jpeg', 0);
GO

INSERT INTO [item] ([code], [quantity], [name], [price], [discount], [category], [description], [image_path], [main]) VALUES (N'10', 500, N'Blue-Pearls Earings', 350, 5, N'Earing', N'contains Blue Pearls.', N'ear3.gif', 0);
GO

INSERT INTO [item] ([code], [quantity], [name], [price], [discount], [category], [description], [image_path], [main]) VALUES (N'11', 1000, N'Red Flower Earings', 200, 5, N'Earing', N'Plastic Earings but durable', N'ear5.gif', 0);
GO

INSERT INTO [item] ([code], [quantity], [name], [price], [discount], [category], [description], [image_path], [main]) VALUES (N'12', 350, N'Sports Earings', 125, 5, N'Earing', N'Casual Earings for all occassions', N'ear6.gif', 0);
GO

INSERT INTO [item] ([code], [quantity], [name], [price], [discount], [category], [description], [image_path], [main]) VALUES (N'13', 200, N'Green Stone Earings', 2500, 5, N'Earing', N'Beautiful Earings containing Green Stone and white Pearls.', N'ear7.jpeg', 0);
GO

INSERT INTO [item] ([code], [quantity], [name], [price], [discount], [category], [description], [image_path], [main]) VALUES (N'14', 100, N'Green-Diamond Earing', 3000, 5, N'Earing', N'Contains Green Stone and Diamonds pieces. ', N'ear8.jpeg', 0);
GO

INSERT INTO [item] ([code], [quantity], [name], [price], [discount], [category], [description], [image_path], [main]) VALUES (N'15', 120, N'Red Stone Earing', 1000, 5, N'Earing', N'Red Stone Earing-for Casual and formal occassions', N'ear9.jpeg', 0);
GO

INSERT INTO [item] ([code], [quantity], [name], [price], [discount], [category], [description], [image_path], [main]) VALUES (N'16', 200, N'Blue Earings', 2500, 5, N'Earing', N'Contains Blue Stone plus White Pearls', N'ear10.jpeg', 0);
GO

INSERT INTO [item] ([code], [quantity], [name], [price], [discount], [category], [description], [image_path], [main]) VALUES (N'17', 100, N'Simple Locket', 500, 5, N'Necklace', N'Contains purple pearls.', N'neck1.gif', 0);
GO

INSERT INTO [item] ([code], [quantity], [name], [price], [discount], [category], [description], [image_path], [main]) VALUES (N'18', 240, N'Blue Necklace', 1250, 5, N'Necklace', N'Extremely beautiful, combination of Blue stones and Gold.', N'neck3.gif', 1);
GO

INSERT INTO [item] ([code], [quantity], [name], [price], [discount], [category], [description], [image_path], [main]) VALUES (N'19', 100, N'Green Pearl Necklace', 1000, 5, N'Necklace', N'have Green Stone , less expensive', N'neck4.gif', 0);
GO

INSERT INTO [item] ([code], [quantity], [name], [price], [discount], [category], [description], [image_path], [main]) VALUES (N'2', 1000, N'Dolmin Pendant', 1000, 10, N'Pendant', N'silver, heart shaped containing Dolphin.', N'p2.jpeg', 0);
GO

INSERT INTO [item] ([code], [quantity], [name], [price], [discount], [category], [description], [image_path], [main]) VALUES (N'20', 200, N'Black Stone Necklace', 1250, 5, N'Necklace', N'contains Black Stones,and Green Pearls.', N'neck5.gif', 0);
GO

INSERT INTO [item] ([code], [quantity], [name], [price], [discount], [category], [description], [image_path], [main]) VALUES (N'21', 1000, N'Everyday Necklace', 2000, 10, N'Necklace', N'Best for casual wear.', N'neck6.gif', 0);
GO

INSERT INTO [item] ([code], [quantity], [name], [price], [discount], [category], [description], [image_path], [main]) VALUES (N'22', 125, N'Star Necklace', 1500, 10, N'Necklace', N'Star shaped diamond.', N'neck7.gif', 0);
GO

INSERT INTO [item] ([code], [quantity], [name], [price], [discount], [category], [description], [image_path], [main]) VALUES (N'23', 2000, N'Silver-Heart Pendant', 2500, 5, N'Pendant', N'Silver Pendant in Heart Shape.', N'p5.jpeg', 0);
GO

INSERT INTO [item] ([code], [quantity], [name], [price], [discount], [category], [description], [image_path], [main]) VALUES (N'24', 500, N'Silver-Bi-Hearted Pendant', 1250, 5, N'Pendant', N'Beautiful design,silver metal at low price', N'p6.jpeg', 0);
GO

INSERT INTO [item] ([code], [quantity], [name], [price], [discount], [category], [description], [image_path], [main]) VALUES (N'25', 100, N'Green Tie Pin', 250, 5, N'Tie Pin', N'Green Stone pierced in the middle.', N'tie1.jpeg', 0);
GO

INSERT INTO [item] ([code], [quantity], [name], [price], [discount], [category], [description], [image_path], [main]) VALUES (N'26', 200, N'Gold-Blue Tie Pin', 350, 5, N'Tie Pin', N'Contains a Blue Stone,while the Pin itself is of Gold.', N'tie2.jpeg', 0);
GO

INSERT INTO [item] ([code], [quantity], [name], [price], [discount], [category], [description], [image_path], [main]) VALUES (N'27', 100, N'Silver-Navy Blue Tie Pin', 300, 10, N'Tie Pin', N'Navy Blue Stone with Silver Pin.', N'tie3.jpeg', 0);
GO

INSERT INTO [item] ([code], [quantity], [name], [price], [discount], [category], [description], [image_path], [main]) VALUES (N'28', 50, N'Gold Necklace', 20000, 5, N'Necklace', N'22 carat Gold ,Sun Design Necklace.
', N'neck8.jpeg', 0);
GO

INSERT INTO [item] ([code], [quantity], [name], [price], [discount], [category], [description], [image_path], [main]) VALUES (N'29', 20, N'Pearl-Diamond Necklace', 25000, 10, N'Necklace', N'Contains Pearls and Diamonds, expensive but worth also.', N'neck9.jpeg', 0);
GO

INSERT INTO [item] ([code], [quantity], [name], [price], [discount], [category], [description], [image_path], [main]) VALUES (N'3', 100, N'Blue-Dolphin Pendant', 1200, 5, N'Pendant', N'heart shaped, containing Blue Stone.', N'p3.jpeg', 0);
GO

INSERT INTO [item] ([code], [quantity], [name], [price], [discount], [category], [description], [image_path], [main]) VALUES (N'30', 15, N'Pearl Necklace', 15000, 5, N'Necklace', N'Contains Pearls and Gold.', N'neck10.jpeg', 0);
GO

INSERT INTO [item] ([code], [quantity], [name], [price], [discount], [category], [description], [image_path], [main]) VALUES (N'31', 25, N'Green-Silver Bindiya', 1500, 10, N'Bindiya', N'Silver Bindiya with Green Pearls and Diamonds.', N'bin1.jpeg', 0);
GO

INSERT INTO [item] ([code], [quantity], [name], [price], [discount], [category], [description], [image_path], [main]) VALUES (N'32', 20, N'Indian Diamonds', 20000, 10, N'Diamonds', N'Pure, Round', N'dim1.jpeg', 0);
GO

INSERT INTO [item] ([code], [quantity], [name], [price], [discount], [category], [description], [image_path], [main]) VALUES (N'4', 50, N'Multi-Heart Pendant', 2000, 0, N'Pendant', N'Silver, multiple hearts connected in chain', N'p4.jpeg', 1);
GO

INSERT INTO [item] ([code], [quantity], [name], [price], [discount], [category], [description], [image_path], [main]) VALUES (N'5', 1000, N'Heart Shaped Bracelet', 800, 5, N'Bracelet', N'Heart shaped Bracelet,cute but cheap', N'brac1.jpeg', 0);
GO

INSERT INTO [item] ([code], [quantity], [name], [price], [discount], [category], [description], [image_path], [main]) VALUES (N'6', 3000, N'Heart Shaped-Gold Bracelet', 1500, 5, N'Bracelet', N'Heart shaped but contains Gold as joints', N'brac2.jpeg', 0);
GO

INSERT INTO [item] ([code], [quantity], [name], [price], [discount], [category], [description], [image_path], [main]) VALUES (N'7', 100, N'Gold Bracelet', 1100, 5, N'Bracelet', N'Gold 24 karat with red pearls', N'brac3.gif', 1);
GO

INSERT INTO [item] ([code], [quantity], [name], [price], [discount], [category], [description], [image_path], [main]) VALUES (N'8', 200, N'heart-earings', 250, 2, N'Earing', N'Heart shaped, non-gold Earings', N'ear1.jpeg', 0);
GO

INSERT INTO [item] ([code], [quantity], [name], [price], [discount], [category], [description], [image_path], [main]) VALUES (N'9', 600, N'Green-Pearls Earing', 200, 5, N'Earing', N'Contains green pearls, cheap but best as a gift.', N'ear2.gif', 0);
GO

INSERT INTO [item_in_order] ([number], [item_code], [quantity], [price], [discount]) VALUES (N'1', N'1', 1, 100000, 10);
GO

INSERT INTO [item_in_order] ([number], [item_code], [quantity], [price], [discount]) VALUES (N'2', N'1', 1, 100000, 10);
GO

INSERT INTO [item_in_order] ([number], [item_code], [quantity], [price], [discount]) VALUES (N'3', N'2', 1, 20000, 5);
GO

INSERT INTO [order_info] ([number], [user_id], [date], [del_date], [status], [price], [dis_price], [ccard]) VALUES (N'1', N'muddassir', '20010121 00:00:00', '20010221 00:00:00', N'Just-Received', 100000, 90000, N'123-234-2345');
GO

INSERT INTO [order_info] ([number], [user_id], [date], [del_date], [status], [price], [dis_price], [ccard]) VALUES (N'2', N'sarika', '20010121 00:00:00', '20010221 00:00:00', N'In-Process', 100000, 90000, N'123-456-7890');
GO

INSERT INTO [order_info] ([number], [user_id], [date], [del_date], [status], [price], [dis_price], [ccard]) VALUES (N'3', N'yamin', '20010122 00:00:00', '20010222 00:00:00', N'Delivered', 20000, 19000, N'123-234-2345');
GO

INSERT INTO [owner] ([owner_id], [pwd], [total_items], [add], [email]) VALUES (N'muddassir', N'abc', 32, N'(c) SSH', N'm@mma.com');
GO

INSERT INTO [post] ([number], [id], [name], [email], [description]) VALUES (3, N'sarika', N'Sarika', N'S@y.com', N'Bracelet');
GO

INSERT INTO [post] ([number], [id], [name], [email], [description]) VALUES (4, N'muddassir', N'Muddassir', N'm@mma.com', N'Bracelet');
GO

INSERT INTO [post] ([number], [id], [name], [email], [description]) VALUES (5, N'yamin', N'Umer', N'y@e.com', N'Bindiya');
GO

INSERT INTO [rlink] ([name], [link]) VALUES (N'EJ', N'ej.com');
GO

