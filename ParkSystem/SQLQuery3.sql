CREATE TABLE admin (
    id           INT  PRIMARY KEY    IDENTITY (1, 1),
    username     VARCHAR (50) NOT NULL,
    password    VARCHAR (50) NOT NULL,
    date_created DATE         NULL,
);

CREATE TABLE parkin
(
    id INT IDENTITY(1,1) NOT NULL,
    plateNumber VARCHAR(50) UNIQUE NOT NULL,
    vType VARCHAR(50) NOT NULL,
    vBrand VARCHAR(50) NOT NULL,
    parkedDate DATE NULL,
    parkedinHour TIME NULL,
    parkedSlot VARCHAR(50) UNIQUE NOT NULL
)

ALTER TABLE parkin
ALTER COLUMN plateNumber VARCHAR(50) NOT NULL;
