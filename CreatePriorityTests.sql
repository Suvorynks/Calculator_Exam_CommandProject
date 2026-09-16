CREATE TABLE PriorityTests (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Operator NVARCHAR(5),
    ExpectedPriority INT
);

INSERT INTO PriorityTests (Operator, ExpectedPriority) VALUES 
('(', 0),
(')', 0),
('+', 1),
('-', 1),
('*', 2),
('/', 2);