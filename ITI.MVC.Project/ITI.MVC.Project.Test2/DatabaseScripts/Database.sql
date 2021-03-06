USE [ITI.MVC.Project.Test2]
GO
SET IDENTITY_INSERT [dbo].[Brands] ON 

INSERT [dbo].[Brands] ([Id], [Name]) VALUES (1, N'addidas')
INSERT [dbo].[Brands] ([Id], [Name]) VALUES (2, N'Nike')
INSERT [dbo].[Brands] ([Id], [Name]) VALUES (3, N'samsung')
INSERT [dbo].[Brands] ([Id], [Name]) VALUES (4, N'Appo')
INSERT [dbo].[Brands] ([Id], [Name]) VALUES (5, N'Gucci')
INSERT [dbo].[Brands] ([Id], [Name]) VALUES (6, N'Zara')
INSERT [dbo].[Brands] ([Id], [Name]) VALUES (7, N'Apple')
SET IDENTITY_INSERT [dbo].[Brands] OFF
SET IDENTITY_INSERT [dbo].[Categories] ON 

INSERT [dbo].[Categories] ([Id], [Name]) VALUES (1, N'Electronics')
INSERT [dbo].[Categories] ([Id], [Name]) VALUES (2, N'Accessories')
INSERT [dbo].[Categories] ([Id], [Name]) VALUES (3, N'Health & Beauty')
INSERT [dbo].[Categories] ([Id], [Name]) VALUES (4, N'Computers & IT')
INSERT [dbo].[Categories] ([Id], [Name]) VALUES (5, N'Home, Kitchen and Tools')
INSERT [dbo].[Categories] ([Id], [Name]) VALUES (6, N'Fashion')
INSERT [dbo].[Categories] ([Id], [Name]) VALUES (7, N'Sports & Fitness')
INSERT [dbo].[Categories] ([Id], [Name]) VALUES (8, N'Books & Games')
INSERT [dbo].[Categories] ([Id], [Name]) VALUES (9, N'Others')
SET IDENTITY_INSERT [dbo].[Categories] OFF
SET IDENTITY_INSERT [dbo].[Subcategories] ON 

INSERT [dbo].[Subcategories] ([Id], [Name], [Fk_category]) VALUES (1, N'Tvs', 1)
INSERT [dbo].[Subcategories] ([Id], [Name], [Fk_category]) VALUES (2, N'Mobiles & Tablets', 1)
INSERT [dbo].[Subcategories] ([Id], [Name], [Fk_category]) VALUES (3, N'Cameras', 1)
INSERT [dbo].[Subcategories] ([Id], [Name], [Fk_category]) VALUES (5, N'Watches', 2)
INSERT [dbo].[Subcategories] ([Id], [Name], [Fk_category]) VALUES (7, N'Jewellery', 2)
INSERT [dbo].[Subcategories] ([Id], [Name], [Fk_category]) VALUES (8, N'Makeup', 3)
INSERT [dbo].[Subcategories] ([Id], [Name], [Fk_category]) VALUES (9, N'Hair Electronics', 3)
INSERT [dbo].[Subcategories] ([Id], [Name], [Fk_category]) VALUES (10, N'Labtops', 4)
INSERT [dbo].[Subcategories] ([Id], [Name], [Fk_category]) VALUES (11, N'USB', 4)
INSERT [dbo].[Subcategories] ([Id], [Name], [Fk_category]) VALUES (12, N'Scanners', 4)
INSERT [dbo].[Subcategories] ([Id], [Name], [Fk_category]) VALUES (13, N'Printers', 4)
INSERT [dbo].[Subcategories] ([Id], [Name], [Fk_category]) VALUES (14, N'Kitchen Appliances', 5)
INSERT [dbo].[Subcategories] ([Id], [Name], [Fk_category]) VALUES (15, N'TableTop Accessories', 5)
INSERT [dbo].[Subcategories] ([Id], [Name], [Fk_category]) VALUES (16, N'Eyewear', 6)
INSERT [dbo].[Subcategories] ([Id], [Name], [Fk_category]) VALUES (17, N'Men Clothes', 6)
INSERT [dbo].[Subcategories] ([Id], [Name], [Fk_category]) VALUES (18, N'Women Clothes', 6)
INSERT [dbo].[Subcategories] ([Id], [Name], [Fk_category]) VALUES (19, N'Sneakers', 6)
INSERT [dbo].[Subcategories] ([Id], [Name], [Fk_category]) VALUES (20, N'Bags', 6)
INSERT [dbo].[Subcategories] ([Id], [Name], [Fk_category]) VALUES (21, N'Gym equipments', 7)
INSERT [dbo].[Subcategories] ([Id], [Name], [Fk_category]) VALUES (22, N'Footballs', 7)
INSERT [dbo].[Subcategories] ([Id], [Name], [Fk_category]) VALUES (23, N'Racket Sports', 7)
INSERT [dbo].[Subcategories] ([Id], [Name], [Fk_category]) VALUES (24, N'Video Games', 8)
INSERT [dbo].[Subcategories] ([Id], [Name], [Fk_category]) VALUES (25, N'Toys', 8)
INSERT [dbo].[Subcategories] ([Id], [Name], [Fk_category]) VALUES (26, N'Others', 1)
INSERT [dbo].[Subcategories] ([Id], [Name], [Fk_category]) VALUES (27, N'Others', 2)
INSERT [dbo].[Subcategories] ([Id], [Name], [Fk_category]) VALUES (28, N'Others', 3)
INSERT [dbo].[Subcategories] ([Id], [Name], [Fk_category]) VALUES (29, N'Others', 4)
INSERT [dbo].[Subcategories] ([Id], [Name], [Fk_category]) VALUES (30, N'Others', 5)
INSERT [dbo].[Subcategories] ([Id], [Name], [Fk_category]) VALUES (31, N'Others', 6)
INSERT [dbo].[Subcategories] ([Id], [Name], [Fk_category]) VALUES (32, N'Others', 7)
INSERT [dbo].[Subcategories] ([Id], [Name], [Fk_category]) VALUES (33, N'Others', 8)
INSERT [dbo].[Subcategories] ([Id], [Name], [Fk_category]) VALUES (34, N'Others', 9)
SET IDENTITY_INSERT [dbo].[Subcategories] OFF
SET IDENTITY_INSERT [dbo].[Sellers] ON 

INSERT [dbo].[Sellers] ([Id], [FirstName], [Location], [StoreName], [IdFrontPath], [IdBackPath], [City], [PhoneNumber], [Status], [FK_User]) VALUES (5, N'mohamed', N'Roxy', N'3omda', N'~/Images/t.PNG', N'~/Images/t.PNG', N'cairo', N'01002666163', N'Confirmed', N'af1aa365-14b2-4a75-86bc-7bab4de3817a')
INSERT [dbo].[Sellers] ([Id], [FirstName], [Location], [StoreName], [IdFrontPath], [IdBackPath], [City], [PhoneNumber], [Status], [FK_User]) VALUES (6, N'asmaa', N'zaiton', N'bershka', N'~/Content/t.png', N'~/Content/t.png', N'Cairo', N'01002666163', N'Confirmed', N'c5b41c14-3d9b-4b0e-8dfa-dbb1c5d1b52a')
SET IDENTITY_INSERT [dbo].[Sellers] OFF
SET IDENTITY_INSERT [dbo].[Products] ON 

INSERT [dbo].[Products] ([Id], [Name], [Price], [Image], [Date], [Color], [Quantity], [Offer], [Shipping], [Status], [FK_Subcategory], [FK_Brand], [FK_seller], [KeyWord]) VALUES (7, N'BackBag Gucci', 500, N'~/Content/BackBag beej.jpg', N'452', N'Brown', 2, 20, 1, N'Confirmed', 20, 5, 5, N'Gucci Fashion Bags')
INSERT [dbo].[Products] ([Id], [Name], [Price], [Image], [Date], [Color], [Quantity], [Offer], [Shipping], [Status], [FK_Subcategory], [FK_Brand], [FK_seller], [KeyWord]) VALUES (11, N'Dress Wool Gray', 450, N'~/Content/Dress Gray.jpg', N'52', N'Gray', 1, 0, 0, N'Confirmed', 18, 6, 5, N'Zara Fashin Women Clothes')
INSERT [dbo].[Products] ([Id], [Name], [Price], [Image], [Date], [Color], [Quantity], [Offer], [Shipping], [Status], [FK_Subcategory], [FK_Brand], [FK_seller], [KeyWord]) VALUES (12, N'Iphone 11 Pro', 7000, N'~/Content/iphone 11 Pro.jpg', N'fdc', N'Black', 1, 10, 1, N'Confirmed', 2, 7, 5, N'Apple Mobiles & Tablets Electronics')
INSERT [dbo].[Products] ([Id], [Name], [Price], [Image], [Date], [Color], [Quantity], [Offer], [Shipping], [Status], [FK_Subcategory], [FK_Brand], [FK_seller], [KeyWord]) VALUES (13, N'Watch For Women ', 2000, N'~/Content/watch women.jpg', N'flk', N'Pink', 1, 15, 0, N'Confirmed', 5, 5, 5, N'Gucci Watches Accessories')
INSERT [dbo].[Products] ([Id], [Name], [Price], [Image], [Date], [Color], [Quantity], [Offer], [Shipping], [Status], [FK_Subcategory], [FK_Brand], [FK_seller], [KeyWord]) VALUES (16, N'T-Shirt Basic', 200, N'~/Content/Tshirt white.jpg', N'fjj', N'White', 2, 0, 0, N'Confirmed', 18, 6, 5, N'Zara Fashion Women Clothes')
SET IDENTITY_INSERT [dbo].[Products] OFF
INSERT [dbo].[AspNetUsers] ([Id], [FirstName], [LastName], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'233f9cdf-4b96-4f47-90d3-c487e5f6d408', N'fathy', N'ahmed', N'Fathy@gmail.com', 0, N'AJh/4ZRt9d6X/BEIpoqwKtU/ORDhv8fEQUgTtrphl1y6haX9bmIeRkOOQ3ehGkoVkQ==', N'6bf72fd5-2ea7-404c-ae16-eca25798a30c', NULL, 0, 0, NULL, 1, 0, N'Fathy@gmail.com')
INSERT [dbo].[AspNetUsers] ([Id], [FirstName], [LastName], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'6d8734f6-1120-444d-8a1c-cd99da74f373', N'yasser', N'abdel-wahab', N'yasser@gmail.com', 0, N'ACI14g04YIY1afYEAFijnhDIV7BFArgN/vOjKBOKO++wCU5jsMZf/KYJ5gUOSYmRmw==', N'892020e9-e0a6-4018-b3db-f02b534d4bb3', NULL, 0, 0, NULL, 1, 0, N'yasser@gmail.com')
INSERT [dbo].[AspNetUsers] ([Id], [FirstName], [LastName], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'af1aa365-14b2-4a75-86bc-7bab4de3817a', N'mohamed', N'Ahmed', N'Ahmed@gmail.com', 0, N'AJlVE3xrGkUDLdEGXC7MiBHG1BccWusIAAQY3/+dPRUl79/0QXvo5eyQEFxauHGoxQ==', N'101c560f-861f-4035-9953-7027ace134fa', NULL, 0, 0, NULL, 1, 0, N'Ahmed@gmail.com')
INSERT [dbo].[AspNetUsers] ([Id], [FirstName], [LastName], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'c5b41c14-3d9b-4b0e-8dfa-dbb1c5d1b52a', N'asmaa', N'essam', N'Asmaa@gmail.com', 0, N'ACsvDChbiXe/LQNtCfchAM5KE5xjc9qeHX5iRCUicFqeclESD40xO3kDNge4NITVSw==', N'297cf640-54dd-49ab-9a79-c998f168015d', NULL, 0, 0, NULL, 1, 0, N'Asmaa@gmail.com')
INSERT [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'a678ee8c-81b0-41ab-9a42-a502c6bcac68', N'Admin')
INSERT [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'dcccdcab-9b28-41d0-b6b0-159dc63218c8', N'Buyer')
INSERT [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'99e12a1f-2d29-4d0e-bd0a-c26c66d3fe03', N'NormalUser')
INSERT [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'861255b1-3be0-45e3-9ae8-6ba87dfc8fd5', N'Seller')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'af1aa365-14b2-4a75-86bc-7bab4de3817a', N'a678ee8c-81b0-41ab-9a42-a502c6bcac68')
