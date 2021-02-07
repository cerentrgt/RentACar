Create Database OtoKiralama on primary

(Name=OtoKiralama_Data,
FILENAME='C:\OtoKiralamaData.mdf',
SIZE=8MB,
MAXSIZE=UNLIMITED,
FILEGROWTH=10%)

LOG ON (NAME=OtoKiralama_Log,
FILENAME='C:\OtoKiralamaLog.ldf',
SIZE=8MB,
MAXSIZE=UNLIMITED,
FILEGROWTH=10%)
