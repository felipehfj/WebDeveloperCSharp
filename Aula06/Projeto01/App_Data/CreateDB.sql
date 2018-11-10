CREATE TABLE Categoria(
	CategoriaId		INTEGER			IDENTITY(1,1),
	Nome			NVARCHAR(50)	NOT NULL,
	PRIMARY KEY(CategoriaId)
);

GO

CREATE TABLE Produto(
	ProdutoId		INTEGER			IDENTITY(1,1),
	Nome			NVARCHAR(50)	NOT NULL,
	Preco			DECIMAL(18,2)	NOT NULL,
	Quantidade		INTEGER			NOT NULL,
	CategoriaId		INTEGER			NOT NULL,
	PRIMARY KEY(ProdutoId),
	FOREIGN KEY(CategoriaId) REFERENCES Categoria(CategoriaId)
);

GO