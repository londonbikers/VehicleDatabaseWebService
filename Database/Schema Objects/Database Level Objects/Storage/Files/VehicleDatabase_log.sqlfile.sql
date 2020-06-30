ALTER DATABASE [$(DatabaseName)]
    ADD LOG FILE (NAME = [VehicleDatabase_log], FILENAME = 'F:\Databases\VehicleDatabase.ldf', SIZE = 1024 KB, MAXSIZE = 2097152 MB, FILEGROWTH = 10 %);



