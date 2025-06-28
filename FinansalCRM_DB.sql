CREATE TABLE [dbo].[BankProcesses](
	[BankProcessId] [int] IDENTITY(1,1) NOT NULL,
	[Description] [nvarchar](250) NULL,
	[ProcessDate] [date] NULL,
	[ProcessType] [nvarchar](50) NULL,
	[Amount] [decimal](18, 2) NULL,
	[BankId] [int] NULL,
 CONSTRAINT [PK_BankProcesses] PRIMARY KEY CLUSTERED 
(
	[BankProcessId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[BankProcesses]  WITH CHECK ADD  CONSTRAINT [FK_BankProcesses_Banks] FOREIGN KEY([BankId])
REFERENCES [dbo].[Banks] ([BankId])
GO

ALTER TABLE [dbo].[BankProcesses] CHECK CONSTRAINT [FK_BankProcesses_Banks]
GO

ALTER TABLE [dbo].[BankProcesses]  WITH CHECK ADD  CONSTRAINT [FK_BankProcesses_Banks1] FOREIGN KEY([BankId])
REFERENCES [dbo].[Banks] ([BankId])
GO

ALTER TABLE [dbo].[BankProcesses] CHECK CONSTRAINT [FK_BankProcesses_Banks1]
GO


----------------------------------------------------------------------------------------------------

CREATE TABLE [dbo].[Banks](
	[BankId] [int] IDENTITY(1,1) NOT NULL,
	[BankAccountNumber] [nvarchar](50) NULL,
	[BankTitle] [nvarchar](50) NULL,
	[BankBalance] [decimal](18, 2) NULL,
 CONSTRAINT [PK_Banks] PRIMARY KEY CLUSTERED 
(
	[BankId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

----------------------------------------------------------------------------------------------------

CREATE TABLE [dbo].[Bills](
	[BillId] [int] IDENTITY(1,1) NOT NULL,
	[BillTitle] [nvarchar](50) NULL,
	[BillAmount] [decimal](18, 2) NULL,
	[BillPeriod] [nvarchar](50) NULL,
 CONSTRAINT [PK_Bills] PRIMARY KEY CLUSTERED 
(
	[BillId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

----------------------------------------------------------------------------------------------------

CREATE TABLE [dbo].[Categories](
	[CategoryId] [int] IDENTITY(1,1) NOT NULL,
	[CategoryName] [nvarchar](50) NULL,
 CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED 
(
	[CategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

----------------------------------------------------------------------------------------------------

CREATE TABLE [dbo].[Spendings](
	[SpendingId] [int] IDENTITY(1,1) NOT NULL,
	[SpendingTitle] [nvarchar](250) NULL,
	[SpendingAmount] [decimal](18, 2) NULL,
	[SpendingDate] [date] NULL,
	[CategoryId] [int] NULL,
 CONSTRAINT [PK_Spendings] PRIMARY KEY CLUSTERED 
(
	[SpendingId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Spendings]  WITH CHECK ADD  CONSTRAINT [FK_Spendings_Categories] FOREIGN KEY([CategoryId])
REFERENCES [dbo].[Categories] ([CategoryId])
GO

ALTER TABLE [dbo].[Spendings] CHECK CONSTRAINT [FK_Spendings_Categories]
GO

----------------------------------------------------------------------------------------------------

CREATE TABLE [dbo].[Users](
	[UserId] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nvarchar](50) NULL,
	[Password] [nvarchar](50) NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


