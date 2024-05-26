    CREATE TABLE V_Slots (
        s_id        INT           IDENTITY (1, 1) NOT NULL,
        s_loc      VARCHAR (225) NULL,
        s_Availability INT           NULL
    );

    INSERT INTO V_Slots (s_loc, s_Availability)
VALUES
    ('A01', 1),
    ('A02', 1),
    ('A03', 1),
    ('A04', 1),
    ('A05', 1),
    ('A06', 1),
    ('A07', 1),
    ('A08', 1),
    ('A09', 1),
    ('A10', 1),
    ('A11', 1),
    ('A12', 1),
    ('A13', 1),
    ('A14', 1),
    ('A15', 1),
    ('A16', 1),
    ('A17', 1),
    ('A18', 1),
    ('A19', 1),
    ('A20', 1),
    ('A21', 1),
    ('A22', 1),
    ('A23', 1),
    ('A24', 1),
    ('A25', 1),
    ('A26', 1),
    ('A27', 1),
    ('A28', 1),
    ('A29', 1),
    ('A30', 1),
    ('A31', 1),
    ('A32', 1),
    ('A33', 1),
    ('A34', 1),
    ('A35', 1),
    ('A36', 1);



    create table Transactions(
    [admin_id]         INT          NULL,
    [v_id]             INT          NOT NULL,
    [s_id]             INT          NOT NULL,
    parkInDateTime     VARCHAR (50) NULL,
    parkOutDateTime    VARCHAR (50) NULL,
    [hours]            FLOAT (53)   NULL,
    [amount]           FLOAT (53)   NULL,
    
    
    )