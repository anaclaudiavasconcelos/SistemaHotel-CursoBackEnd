CREATE table fornecedor(
Id INT Identity(1,1) PRIMARY KEY,
Nome NVARCHAR(50),
Endereco NVARCHAR(100),
Telefone NVARCHAR(25),
);
GO


CREATE table cargo(
Id INT Identity(1,1) PRIMARY KEY,
NomeDoCargo NVARCHAR(50),
);
GO

CREATE table servico(
Id INT Identity(1,1) PRIMARY KEY,
NomeServico NVARCHAR(50),
ValorServico DECIMAL(10,2)
);
GO

CREATE table funcionario(
Id INT Identity(1,1) PRIMARY KEY,
Nome NVARCHAR(50),
Endereco NVARCHAR(100),
Telefone NVARCHAR(25),
Cpf NVARCHAR(15),
Cargo NVARCHAR(50)
);
GO

CREATE table pessoa(
Id INT Identity(1,1) PRIMARY KEY,
Nome NVARCHAR(50),
Usuario NVARCHAR(100),
Telefone NVARCHAR(25),
Cargo NVARCHAR(15),
Senha NVARCHAR(50)
);
GO