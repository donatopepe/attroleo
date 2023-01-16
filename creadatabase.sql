EXEC sp_configure filestream_access_level, 2
RECONFIGURE
GO
CREATE DATABASE dbAttrOleo
ON PRIMARY
(Name = dbAttrOleo,
FILENAME = 'C:\databases\dbAttrOleo\FTDB.mdf'),
FILEGROUP FTFG CONTAINS FILESTREAM
(NAME = dbAttrOleoFS,
FILENAME='C:\FileStreamData\dbAttrOleo_FS')
LOG ON
(Name = dbAttrOleoLog,
FILENAME = 'C:\databases\dbAttrOleo\FTDBLog.ldf')
WITH FILESTREAM (NON_TRANSACTED_ACCESS = FULL,
DIRECTORY_NAME = N'dbAttrOleo');
GO
