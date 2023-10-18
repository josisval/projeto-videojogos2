CREATE TABLE Pedidos (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Data DATE,
    Estado VARCHAR(255),
    Produto VARCHAR(255),
    Quantidade INT,
    ValorUnitario DECIMAL(10, 2),
    NomeComprador VARCHAR(255),
    FormadePagamento VARCHAR(255),
    ValorTotal DECIMAL(10, 2)
);