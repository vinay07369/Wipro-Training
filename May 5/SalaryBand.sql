--8. Categorize employees by salary

SELECT Name, Salary,
	CASE 
		WHEN Salary>=70000 THEN 'High'
		WHEN Salary>=60000 THEN 'MEDIUM'
		ELSE 'LOW'
	END AS SalaryBand
FROM Employees;