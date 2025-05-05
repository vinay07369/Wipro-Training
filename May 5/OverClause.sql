SELECT 
	Name,
	Department,
	Salary,
	AVG(Salary) OVER() AS AverageSalary  -- Calculates average over all rows
FROM Employees;