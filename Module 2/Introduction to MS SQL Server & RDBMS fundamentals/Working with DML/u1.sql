UPDATE dbo.demoAddress
SET AddressLine2 = 'N/A'
WHERE AddressLine2 IS NULL;
