SELECT COUNT(*) as [Employees with Manager]
FROM Employees e
WHERE e.ManagerID IS NOT NULL