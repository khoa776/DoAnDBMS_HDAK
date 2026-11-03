
USE DB_DoAnDBMS;
GO

CREATE OR ALTER FUNCTION dbo.fn_GiaiPTBac2
(
    @a FLOAT,
    @b FLOAT,
    @c FLOAT
)
RETURNS NVARCHAR(500)
AS
BEGIN
    DECLARE @delta FLOAT;
    DECLARE @x1 FLOAT;
    DECLARE @x2 FLOAT;
    DECLARE @ketqua NVARCHAR(500);

    -- Kiem tra tham so 
    IF @a IS NULL OR @b IS NULL OR @c IS NULL
        RETURN N'Vui lòng nhập đủ 3 hệ số';

    -- Truong hop a = 0
    IF @a = 0
    BEGIN
        IF @b = 0
        BEGIN
            IF @c = 0
                SET @ketqua = N'Phương trình có vô số nghiệm';
            ELSE
                SET @ketqua = N'Phương trình vô nghiệm';
        END
        ELSE
        BEGIN
            SET @x1 = -@c / @b;

            SET @ketqua = N'Phương trình bậc nhất: x = '
                + CAST(@x1 AS NVARCHAR(50));
        END
    END
    ELSE
    BEGIN
        -- Tinh Delta
        SET @delta = @b * @b - 4 * @a * @c;

        IF @delta < 0
            SET @ketqua = N'Phương trình vô nghiệm';

        ELSE IF @delta = 0
        BEGIN
            SET @x1 = -@b / (2 * @a);

            SET @ketqua = N'Phương trình có nghiệm kép: x = '
                + CAST(@x1 AS NVARCHAR(50));
        END
        ELSE
        BEGIN
            SET @x1 = (-@b + SQRT(@delta)) / (2 * @a);
            SET @x2 = (-@b - SQRT(@delta)) / (2 * @a);

            SET @ketqua = N'Phương trình có 2 nghiệm phân biệt: '
                + N'x1 = ' + CAST(@x1 AS NVARCHAR(50))
                + N'; x2 = ' + CAST(@x2 AS NVARCHAR(50));
        END
    END

    RETURN @ketqua;
END;
GO
