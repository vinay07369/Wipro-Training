--6. Highest Salary in Each Department

SELECT Department, MAX(Salary) AS HighestSalary
FROM Employees
GROUP BY Department;