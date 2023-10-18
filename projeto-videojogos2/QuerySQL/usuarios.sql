CREATE TABLE Usuarios (
    ID INT PRIMARY KEY IDENTITY(1,1), -- Um ID único para cada usuário
    NomeUsuario VARCHAR(50) NOT NULL, -- Nome de usuário (não pode ser nulo)
    Senha VARCHAR(100) NOT NULL -- Senha (não pode ser nula)
);