﻿CREATE TABLE [dbo].[Account](
	[Username] [nvarchar](10) NOT NULL,
	[Password] [nvarchar](10) NULL,
	[Describe] [nvarchar](250) NULL,
 CONSTRAINT [PK_Account] PRIMARY KEY CLUSTERED 
(
	[Username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


