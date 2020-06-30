ALTER DATABASE [$(DatabaseName)]
    ADD FILE (NAME = [VehicleDatabase], FILENAME = 'F:\Databases\VehicleDatabase.mdf', SIZE = 3072 KB, FILEGROWTH = 1024 KB) TO FILEGROUP [PRIMARY];



