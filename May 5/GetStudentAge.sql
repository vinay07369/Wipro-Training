-- 2. Get Age of Each Student

SELECT FirstName, DATEDIFF(YEAR, DOB, GETDATE()) AS Age 
FROM Students;