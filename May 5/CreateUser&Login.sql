CREATE USER test_user FOR LOGIN test_login;

-- First, ensure the login exists.If not:

CREATE LOGIN test_login WITH PASSWORD = 'StrongP@ss123';