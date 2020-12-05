/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [idCli]
      ,[nomCli]
      ,[apeCli]
      ,[dniCli]
      ,[dirCli]
      ,[telCli]
      ,[fechaNac]
  FROM [dbobodegas].[dbo].[tblCliente]

  select * from tblCliente