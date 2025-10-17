-- Step 1: Make a copy of the table
SELECT * INTO dbo.demoAddress_backup
FROM dbo.demoAddress;

-- Step 2: Safely delete rows
DELETE FROM dbo.demoAddress
WHERE AddressLine2 IS NULL;
