SELECT 
	Name,
	Department,
	Salary,
	RANK() OVER(ORDER BY Salary DESC) AS RankBySalary
FROM Employees;