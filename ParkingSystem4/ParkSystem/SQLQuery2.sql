CREATE TABLE Parkin (
    id           INT          IDENTITY (1, 1) NOT NULL,
    plateNumber  VARCHAR (50) NOT NULL,
    vType   VARCHAR (50) NOT NULL,
    vBrand       VARCHAR (50) NOT NULL,
    parkedDate   DATE         NULL,
    parkedinHour TIME         NULL,
    parkedSlot   VARCHAR (50) NOT NULL,

);
ALTER TABLE Parkin
ADD vStatus VARCHAR(50) NULL;
