CREATE TABLE [dbo].[Role] (
    [role_id]   INT           IDENTITY (1, 1) NOT NULL,
    [role_name] VARCHAR (MAX) NULL,
    PRIMARY KEY CLUSTERED ([role_id] ASC)
);

CREATE TABLE [dbo].[User] (
    [user_id]           INT           IDENTITY (1, 1) NOT NULL,
    [role_id]           INT           NOT NULL,
    [user_username]     VARCHAR (MAX) NULL,
    [user_password]     VARCHAR (MAX) NULL,
    [user_name]         VARCHAR (MAX) NULL,
    [user_gender]       VARCHAR (MAX) NULL,
    [user_phone_number] VARCHAR (MAX) NULL,
    [user_address]      VARCHAR (MAX) NULL,
    PRIMARY KEY CLUSTERED ([user_id] ASC),
    FOREIGN KEY ([role_id]) REFERENCES [dbo].[Role] ([role_id])
);

CREATE TABLE [dbo].[Medicine] (
    [medicine_id]    INT           IDENTITY (1, 1) NOT NULL,
    [medicine_name]  VARCHAR (MAX) NULL,
    [medicine_desc]  VARCHAR (MAX) NULL,
    [medicine_stock] INT           NULL,
    [medicine_price] INT           NULL,
    PRIMARY KEY CLUSTERED ([medicine_id] ASC)
);

CREATE TABLE [dbo].[Cart] (
    [user_id]     INT NOT NULL,
    [medicine_id] INT NOT NULL,
    [quantity]    INT NULL,
    FOREIGN KEY ([medicine_id]) REFERENCES [dbo].[Medicine] ([medicine_id]),
    FOREIGN KEY ([user_id]) REFERENCES [dbo].[User] ([user_id]),
    CONSTRAINT [PK_Cart] PRIMARY KEY CLUSTERED ([user_id] ASC, [medicine_id] ASC)
);

CREATE TABLE [dbo].[HeaderTransaction] (
    [transaction_id]   INT           IDENTITY (1, 1) NOT NULL,
    [user_id]          INT           NULL,
    [transaction_date] VARCHAR (MAX) NULL,
    PRIMARY KEY CLUSTERED ([transaction_id] ASC),
    FOREIGN KEY ([user_id]) REFERENCES [dbo].[User] ([user_id])
);

CREATE TABLE [dbo].[DetailTransaction] (
    [transaction_id] INT NOT NULL,
    [medicine_id]    INT NOT NULL,
    [quantity]       INT NULL,
    FOREIGN KEY ([medicine_id]) REFERENCES [dbo].[Medicine] ([medicine_id]),
    FOREIGN KEY ([transaction_id]) REFERENCES [dbo].[HeaderTransaction] ([transaction_id]),
    CONSTRAINT [PK_DetailTransaction] PRIMARY KEY CLUSTERED ([transaction_id] ASC, [medicine_id] ASC)
);