SELECT
        Managers.TownName AS Town,
        COUNT(Managers.managerId) AS [NUMBER OF managers]
FROM (SELECT DISTINCT
        e.EmployeeID AS managerId,
        t.Name AS TownName
FROM Employees e
JOIN Employees m
        ON e.EmployeeID = m.ManagerID
JOIN Addresses a
        ON a.AddressID = e.AddressID
JOIN Towns t
        ON t.TownID = a.TownID) AS Managers
GROUP BY Managers.TownName