CREATE TABLE Funcionario
(
	FuncionarioId	integer			PRIMARY KEY,
	Nome			nvarchar(50)	NOT NULL,
	Salario			decimal(18)		NOT NULL,
	DataAdmissao	datetime		NOT NULL
);
