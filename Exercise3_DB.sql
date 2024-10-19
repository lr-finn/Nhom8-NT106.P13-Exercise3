CREATE DATABASE Exercise3

USE [Exercise3]

CREATE TABLE [dbo].[USERS](
	UserID varchar(50) PRIMARY KEY,
	FullName nvarchar(40) NOT NULL,
	Birthday smalldatetime NOT NULL,
	UserName nvarchar(40) NOT NULL,
	HashedPass nvarchar(64) NOT NULL,
	Email nvarchar(40) NOT NULL,
)
