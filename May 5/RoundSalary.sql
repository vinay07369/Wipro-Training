-- 3. Round Off Salary to nearest 1000

SELECT Name, ROUND(Salary, -3) AS RoundSalary
FROM Employees;