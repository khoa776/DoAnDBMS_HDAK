
USE DB_DoAnDBMS;
GO

CREATE OR ALTER FUNCTION dbo.fn_Fibonacci(@n INT)
RETURNS NVARCHAR(MAX)
AS
BEGIN
    DECLARE @a BIGINT = 0;
    DECLARE @b BIGINT = 1;
    DECLARE @c BIGINT;
    DECLARE @i INT = 0;
    DECLARE @ketqua NVARCHAR(MAX) = N'';

    IF @n IS NULL OR @n < 1 OR @n > 92
        RETURN N'Số lượng phần tử phải từ 1 đến 92';

    WHILE @i < @n
    BEGIN
        SET @ketqua = @ketqua +
            CASE WHEN @i = 0 THEN N'' ELSE N', ' END
            + CAST(@a AS NVARCHAR(30));

        SET @i = @i + 1;

        IF @i < @n
        BEGIN
            SET @c = @a + @b;
            SET @a = @b;
            SET @b = @c;
        END
    END

    RETURN @ketqua;
END;
GO
