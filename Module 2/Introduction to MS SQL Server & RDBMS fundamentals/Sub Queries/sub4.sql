SELECT DISTINCT Color
FROM Production.Product
WHERE Color IS NOT NULL
  AND Color NOT IN (
    SELECT Color
    FROM Production.ProductColor
    WHERE Color IS NOT NULL
);
