USE master
GO

IF(EXISTS(SELECT 1 FROM master.sys.databases WHERE name = 'GestaoMercearia'))
ALTER DATABASE GestaoMercearia SET  SINGLE_USER WITH ROLLBACK IMMEDIATE
GO

IF(EXISTS(SELECT 1 FROM master.sys.databases WHERE name = 'GestaoMercearia'))
DROP DATABASE GestaoMercearia
GO

IF(NOT EXISTS(SELECT 1 FROM master.sys.databases WHERE name = 'GestaoMercearia'))
CREATE DATABASE GestaoMercearia
GO

USE GestaoMercearia
GO
CREATE TABLE [dbo].[Categoria](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Categoria] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 15/04/2024 12:11:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cliente](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](150) NULL,
	[Cpf] [varchar](20) NULL,
	[Endereco] [varchar](150) NULL,
	[CEP] [varchar](25) NULL,
	[Email] [varchar](150) NULL,
	[Telefone] [varchar](15) NULL,
 CONSTRAINT [PK_Cliente] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Compra]    Script Date: 15/04/2024 12:11:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Compra](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[DataCompra] [date] NULL,
	[ValorTotal] [float] NULL,
	[FornecedorId] [int] NOT NULL,
	[FormaPagamentoId] [int] NOT NULL,
 CONSTRAINT [PK_Compra] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Estoque]    Script Date: 15/04/2024 12:11:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Estoque](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[DataDeEntrada] [date] NULL,
	[DataDeSaida] [date] NULL,
	[EstoqueMinimo] [int] NULL,
	[EstoqueMaximo] [int] NULL,
	[QuantidadeEmEstoque] [int] NULL,
	[IdProduto] [int] NULL,
 CONSTRAINT [PK_Estoque] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FormaPagamento]    Script Date: 15/04/2024 12:11:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FormaPagamento](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Tipo] [varchar](100) NOT NULL,
	[Descricao] [varchar](100) NULL,
	[Troco] [bit] NOT NULL,
 CONSTRAINT [PK_FormaPagamento] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Fornecedor]    Script Date: 15/04/2024 12:11:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Fornecedor](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](150) NULL,
	[Email] [varchar](150) NULL,
	[Telefone] [varchar](50) NULL,
	[Endereco] [varchar](50) NULL,
	[CEP] [varchar](25) NULL,
 CONSTRAINT [PK_Fornecedor] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Funcionario]    Script Date: 15/04/2024 12:11:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Funcionario](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](150) NULL,
	[Telefone] [varchar](15) NULL,
	[Ativo] [bit] NULL,
	[Profissao] [varchar](150) NULL,
	[Salario] [float] NULL,
 CONSTRAINT [PK_Funcionario] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GrupoUsuario]    Script Date: 15/04/2024 12:11:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GrupoUsuario](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[NomeGrupo] [varchar](150) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ItemCompra]    Script Date: 15/04/2024 12:11:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ItemCompra](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Quantidade] [int] NOT NULL,
	[ValorUnitario] [float] NOT NULL,
	[Subtotal] [float] NOT NULL,
	[IdCompra] [int] NOT NULL,
	[IdProduto] [int] NOT NULL,
 CONSTRAINT [PK_ItemCompra] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ItemVenda]    Script Date: 15/04/2024 12:11:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ItemVenda](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdProduto] [int] NOT NULL,
	[IdVenda] [int] NOT NULL,
	[Quantidade] [int] NOT NULL,
	[ValorUnitario] [float] NOT NULL,
	[CustoProduto] [float] NULL,
	[Subtotal] [float] NULL,
 CONSTRAINT [PK_ItemVenda_1] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Marca]    Script Date: 15/04/2024 12:11:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Marca](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Marca] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Permissao]    Script Date: 15/04/2024 12:11:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Permissao](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Descricao] [varchar](250) NULL,
 CONSTRAINT [PK__Permissa__3214EC075A5A3F69] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PermissaoGrupoUsuario]    Script Date: 15/04/2024 12:11:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PermissaoGrupoUsuario](
	[IdPermissao] [int] NOT NULL,
	[IdGrupoUsuario] [int] NOT NULL,
 CONSTRAINT [PK_PermissaoGrupoUsuario] PRIMARY KEY CLUSTERED 
(
	[IdPermissao] ASC,
	[IdGrupoUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Produto]    Script Date: 15/04/2024 12:11:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Produto](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](150) NULL,
	[Descricao] [varchar](50) NULL,
	[CodigoDeBarra] [varchar](50) NULL,
	[Preco] [float] NULL,
	[Quantidade] [int] NULL,
	[Custo] [float] NULL,
	[IdMarca] [int] NOT NULL,
	[IdCategoria] [int] NOT NULL,
	[IdFornecedor] [int] NULL,
 CONSTRAINT [PK__Produto__3214EC07F3AC594A] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Senha]    Script Date: 15/04/2024 12:11:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Senha](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdCliente] [int] NOT NULL,
 CONSTRAINT [PK_Senha] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 15/04/2024 12:11:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](150) NULL,
	[NomeUsuario] [varchar](50) NULL,
	[Email] [varchar](150) NULL,
	[CPF] [varchar](15) NULL,
	[Ativo] [bit] NULL,
	[Senha] [varchar](50) NULL,
	[DataCadastro] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UsuarioGrupoUsuario]    Script Date: 15/04/2024 12:11:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UsuarioGrupoUsuario](
	[IdUsuario] [int] NOT NULL,
	[IdGrupoUsuario] [int] NOT NULL,
 CONSTRAINT [PK_UsuarioGrupoUsuario] PRIMARY KEY CLUSTERED 
(
	[IdUsuario] ASC,
	[IdGrupoUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Venda]    Script Date: 15/04/2024 12:11:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Venda](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdUsuario] [int] NULL,
	[IdCliente] [int] NULL,
	[IdFormaPagamento] [int] NULL,
	[DataVenda] [datetime] NULL,
	[Total] [float] NULL,
 CONSTRAINT [PK_Venda] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Usuario] ADD  DEFAULT (getdate()) FOR [DataCadastro]
GO
ALTER TABLE [dbo].[Compra]  WITH CHECK ADD  CONSTRAINT [FK_Compra_FormaPagamento] FOREIGN KEY([FormaPagamentoId])
REFERENCES [dbo].[FormaPagamento] ([Id])
GO
ALTER TABLE [dbo].[Compra] CHECK CONSTRAINT [FK_Compra_FormaPagamento]
GO
ALTER TABLE [dbo].[Compra]  WITH CHECK ADD  CONSTRAINT [FK_Compra_Fornecedor] FOREIGN KEY([FornecedorId])
REFERENCES [dbo].[Fornecedor] ([Id])
GO
ALTER TABLE [dbo].[Compra] CHECK CONSTRAINT [FK_Compra_Fornecedor]
GO
ALTER TABLE [dbo].[Estoque]  WITH CHECK ADD  CONSTRAINT [FK_Estoque_Produto] FOREIGN KEY([IdProduto])
REFERENCES [dbo].[Produto] ([Id])
GO
ALTER TABLE [dbo].[Estoque] CHECK CONSTRAINT [FK_Estoque_Produto]
GO
ALTER TABLE [dbo].[ItemCompra]  WITH CHECK ADD  CONSTRAINT [FK_ItemCompra_Compra] FOREIGN KEY([IdCompra])
REFERENCES [dbo].[Compra] ([Id])
GO
ALTER TABLE [dbo].[ItemCompra] CHECK CONSTRAINT [FK_ItemCompra_Compra]
GO
ALTER TABLE [dbo].[ItemCompra]  WITH CHECK ADD  CONSTRAINT [FK_ItemCompra_Produto] FOREIGN KEY([IdProduto])
REFERENCES [dbo].[Produto] ([Id])
GO
ALTER TABLE [dbo].[ItemCompra] CHECK CONSTRAINT [FK_ItemCompra_Produto]
GO
ALTER TABLE [dbo].[ItemVenda]  WITH CHECK ADD  CONSTRAINT [FK_ItemVenda_Produto1] FOREIGN KEY([IdProduto])
REFERENCES [dbo].[Produto] ([Id])
GO
ALTER TABLE [dbo].[ItemVenda] CHECK CONSTRAINT [FK_ItemVenda_Produto1]
GO
ALTER TABLE [dbo].[ItemVenda]  WITH CHECK ADD  CONSTRAINT [FK_ItemVenda_Venda1] FOREIGN KEY([IdVenda])
REFERENCES [dbo].[Venda] ([Id])
GO
ALTER TABLE [dbo].[ItemVenda] CHECK CONSTRAINT [FK_ItemVenda_Venda1]
GO
ALTER TABLE [dbo].[Produto]  WITH CHECK ADD  CONSTRAINT [FK_Produto_Categoria] FOREIGN KEY([IdCategoria])
REFERENCES [dbo].[Categoria] ([Id])
GO
ALTER TABLE [dbo].[Produto] CHECK CONSTRAINT [FK_Produto_Categoria]
GO
ALTER TABLE [dbo].[Produto]  WITH CHECK ADD  CONSTRAINT [FK_Produto_Fornecedor] FOREIGN KEY([IdFornecedor])
REFERENCES [dbo].[Fornecedor] ([Id])
GO
ALTER TABLE [dbo].[Produto] CHECK CONSTRAINT [FK_Produto_Fornecedor]
GO
ALTER TABLE [dbo].[Produto]  WITH CHECK ADD  CONSTRAINT [FK_Produto_Marca] FOREIGN KEY([IdMarca])
REFERENCES [dbo].[Marca] ([Id])
GO
ALTER TABLE [dbo].[Produto] CHECK CONSTRAINT [FK_Produto_Marca]
GO
ALTER TABLE [dbo].[Senha]  WITH CHECK ADD  CONSTRAINT [FK_Senha_Cliente] FOREIGN KEY([IdCliente])
REFERENCES [dbo].[Cliente] ([Id])
GO
ALTER TABLE [dbo].[Senha] CHECK CONSTRAINT [FK_Senha_Cliente]
GO
ALTER TABLE [dbo].[Venda]  WITH CHECK ADD  CONSTRAINT [FK_Venda_Cliente] FOREIGN KEY([IdCliente])
REFERENCES [dbo].[Cliente] ([Id])
GO
ALTER TABLE [dbo].[Venda] CHECK CONSTRAINT [FK_Venda_Cliente]
GO
ALTER TABLE [dbo].[Venda]  WITH CHECK ADD  CONSTRAINT [FK_Venda_FormaPagamento] FOREIGN KEY([IdFormaPagamento])
REFERENCES [dbo].[FormaPagamento] ([Id])
GO
ALTER TABLE [dbo].[Venda] CHECK CONSTRAINT [FK_Venda_FormaPagamento]
GO
ALTER TABLE [dbo].[Venda]  WITH CHECK ADD  CONSTRAINT [FK_Venda_Usuario] FOREIGN KEY([IdUsuario])
REFERENCES [dbo].[Usuario] ([Id])
GO
ALTER TABLE [dbo].[Venda] CHECK CONSTRAINT [FK_Venda_Usuario]
GO
USE [master]
GO
ALTER DATABASE [GestaoMercearia] SET  READ_WRITE 
GO
USE GestaoMercearia
IF(NOT EXISTS(SELECT 1 FROM Permissao WHERE Id = 1))INSERT INTO Permissao(Descricao)VALUES('Visualizar usuário')
IF(NOT EXISTS(SELECT 1 FROM Permissao WHERE Id = 2))INSERT INTO Permissao(Descricao)VALUES('Cadastrar usuário')
IF(NOT EXISTS(SELECT 1 FROM Permissao WHERE Id = 3))INSERT INTO Permissao(Descricao)VALUES('Alterar usuário')
IF(NOT EXISTS(SELECT 1 FROM Permissao WHERE Id = 4))INSERT INTO Permissao(Descricao)VALUES('Excluir usuário')
IF(NOT EXISTS(SELECT 1 FROM Permissao WHERE Id = 5))INSERT INTO Permissao(Descricao)VALUES('Visualizar grupo de usuário')
IF(NOT EXISTS(SELECT 1 FROM Permissao WHERE Id = 6))INSERT INTO Permissao(Descricao)VALUES('Cadastrar grupo de usuário')
IF(NOT EXISTS(SELECT 1 FROM Permissao WHERE Id = 7))INSERT INTO Permissao(Descricao)VALUES('Alterar grupo de usuário')
IF(NOT EXISTS(SELECT 1 FROM Permissao WHERE Id = 8))INSERT INTO Permissao(Descricao)VALUES('Excluir grupo de usuário')
IF(NOT EXISTS(SELECT 1 FROM Permissao WHERE Id = 9))INSERT INTO Permissao(Descricao)VALUES('Adicionar permissão a um grupo de usuário')
IF(NOT EXISTS(SELECT 1 FROM Permissao WHERE Id = 10))INSERT INTO Permissao(Descricao)VALUES('Adicionar grupo de usuário a um usuário')
IF(NOT EXISTS(SELECT 1 FROM Permissao WHERE Id = 11))INSERT INTO Permissao(Descricao)VALUES('Visualizar produto')
IF(NOT EXISTS(SELECT 1 FROM Permissao WHERE Id = 12))INSERT INTO Permissao(Descricao)VALUES('Cadastrar produto')
IF(NOT EXISTS(SELECT 1 FROM Permissao WHERE Id = 13))INSERT INTO Permissao(Descricao)VALUES('Alterar produto')
IF(NOT EXISTS(SELECT 1 FROM Permissao WHERE Id = 14))INSERT INTO Permissao(Descricao)VALUES('Excluir produto')

IF(NOT EXISTS(SELECT 1 FROM Permissao WHERE Id = 15))INSERT INTO Permissao(Descricao)VALUES('Visualizar funcionário')
IF(NOT EXISTS(SELECT 1 FROM Permissao WHERE Id = 16))INSERT INTO Permissao(Descricao)VALUES('Cadastrar funcionário')
IF(NOT EXISTS(SELECT 1 FROM Permissao WHERE Id = 17))INSERT INTO Permissao(Descricao)VALUES('Alterar funcionário')
IF(NOT EXISTS(SELECT 1 FROM Permissao WHERE Id = 18))INSERT INTO Permissao(Descricao)VALUES('Excluir funcionário')

IF(NOT EXISTS(SELECT 1 FROM Permissao WHERE Id = 19))INSERT INTO Permissao(Descricao)VALUES('Visualizar estoque')
IF(NOT EXISTS(SELECT 1 FROM Permissao WHERE Id = 20))INSERT INTO Permissao(Descricao)VALUES('Cadastrar estoque')
IF(NOT EXISTS(SELECT 1 FROM Permissao WHERE Id = 21))INSERT INTO Permissao(Descricao)VALUES('Alterar estoque')
IF(NOT EXISTS(SELECT 1 FROM Permissao WHERE Id = 22))INSERT INTO Permissao(Descricao)VALUES('Excluir estoque')

IF(NOT EXISTS(SELECT 1 FROM Permissao WHERE Id = 23))INSERT INTO Permissao(Descricao)VALUES('Visualizar fornecedor')
IF(NOT EXISTS(SELECT 1 FROM Permissao WHERE Id = 24))INSERT INTO Permissao(Descricao)VALUES('Cadastrar fornecedor')
IF(NOT EXISTS(SELECT 1 FROM Permissao WHERE Id = 25))INSERT INTO Permissao(Descricao)VALUES('Alterar fornecedor')
IF(NOT EXISTS(SELECT 1 FROM Permissao WHERE Id = 26))INSERT INTO Permissao(Descricao)VALUES('Excluir fornecedor')

IF(NOT EXISTS(SELECT 1 FROM Permissao WHERE Id = 27))INSERT INTO Permissao(Descricao)VALUES('Visualizar categoria')
IF(NOT EXISTS(SELECT 1 FROM Permissao WHERE Id = 28))INSERT INTO Permissao(Descricao)VALUES('Cadastrar categoria')
IF(NOT EXISTS(SELECT 1 FROM Permissao WHERE Id = 29))INSERT INTO Permissao(Descricao)VALUES('Alterar categoria')
IF(NOT EXISTS(SELECT 1 FROM Permissao WHERE Id = 30))INSERT INTO Permissao(Descricao)VALUES('Excluir categoria')

IF(NOT EXISTS(SELECT 1 FROM Permissao WHERE Id = 31))INSERT INTO Permissao(Descricao)VALUES('Visualizar marca')
IF(NOT EXISTS(SELECT 1 FROM Permissao WHERE Id = 32))INSERT INTO Permissao(Descricao)VALUES('Cadastrar marca')
IF(NOT EXISTS(SELECT 1 FROM Permissao WHERE Id = 33))INSERT INTO Permissao(Descricao)VALUES('Alterar marca')
IF(NOT EXISTS(SELECT 1 FROM Permissao WHERE Id = 34))INSERT INTO Permissao(Descricao)VALUES('Excluir marca')

IF(NOT EXISTS(SELECT 1 FROM Permissao WHERE Id = 35))INSERT INTO Permissao(Descricao)VALUES('Visualizar forma de pagamento')
IF(NOT EXISTS(SELECT 1 FROM Permissao WHERE Id = 36))INSERT INTO Permissao(Descricao)VALUES('Cadastrar forma de pagamento')
IF(NOT EXISTS(SELECT 1 FROM Permissao WHERE Id = 37))INSERT INTO Permissao(Descricao)VALUES('Alterar forma de pagamento')
IF(NOT EXISTS(SELECT 1 FROM Permissao WHERE Id = 38))INSERT INTO Permissao(Descricao)VALUES('Excluir forma de pagamento')

IF(NOT EXISTS(SELECT 1 FROM Permissao WHERE Id = 39))INSERT INTO Permissao(Descricao)VALUES('Visualizar cliente')
IF(NOT EXISTS(SELECT 1 FROM Permissao WHERE Id = 40))INSERT INTO Permissao(Descricao)VALUES('Cadastrar cliente')
IF(NOT EXISTS(SELECT 1 FROM Permissao WHERE Id = 41))INSERT INTO Permissao(Descricao)VALUES('Alterar cliente')
IF(NOT EXISTS(SELECT 1 FROM Permissao WHERE Id = 42))INSERT INTO Permissao(Descricao)VALUES('Excluir cliente')

IF(NOT EXISTS(SELECT 1 FROM Permissao WHERE Id = 43))INSERT INTO Permissao(Descricao)VALUES('Visualizar venda')
IF(NOT EXISTS(SELECT 1 FROM Permissao WHERE Id = 44))INSERT INTO Permissao(Descricao)VALUES('Cadastrar venda')
IF(NOT EXISTS(SELECT 1 FROM Permissao WHERE Id = 45))INSERT INTO Permissao(Descricao)VALUES('Alterar venda')
IF(NOT EXISTS(SELECT 1 FROM Permissao WHERE Id = 46))INSERT INTO Permissao(Descricao)VALUES('Excluir venda')

IF(NOT EXISTS(SELECT 1 FROM Permissao WHERE Id = 47))INSERT INTO Permissao(Descricao)VALUES('Visualizar Permissões')
IF(NOT EXISTS(SELECT 1 FROM Permissao WHERE Id = 48))INSERT INTO Permissao(Descricao)VALUES('Visualizar Estatistica')
GO

IF(NOT EXISTS(SELECT 1 FROM Usuario WHERE NomeUsuario = 'Adm'))INSERT INTO Usuario(Nome, NomeUsuario, Senha, Ativo)VALUES('Administrador da Silva', 'Adm', '123', 1)
IF(NOT EXISTS(SELECT 1 FROM Usuario WHERE NomeUsuario = 'Geno'))INSERT INTO Usuario(Nome, NomeUsuario, Senha, Ativo)VALUES('Genoveva', 'Geno', '123', 1)
IF(NOT EXISTS(SELECT 1 FROM Usuario WHERE NomeUsuario = 'Dag'))INSERT INTO Usuario(Nome, NomeUsuario, Senha, Ativo)VALUES('Dagorlina', 'Dag', '123', 1)
GO

INSERT INTO GrupoUsuario(NomeGrupo)VALUES('Administrador')
INSERT INTO GrupoUsuario(NomeGrupo)VALUES('Operador de caixa')

GO

INSERT INTO UsuarioGrupoUsuario VALUES(1, 1)
INSERT INTO UsuarioGrupoUsuario VALUES(2, 2)
GO

INSERT INTO PermissaoGrupoUsuario (IdGrupoUsuario, IdPermissao)
(SELECT 1 as IdGrupoUsuario, Permissao.Id FROM Permissao
LEFT JOIN PermissaoGrupoUsuario ON Permissao.Id = PermissaoGrupoUsuario.IdPermissao AND PermissaoGrupoUsuario.IdGrupoUsuario = 1
WHERE PermissaoGrupoUsuario.IdGrupoUsuario IS NULL)

GO
INSERT INTO PermissaoGrupoUsuario (IdGrupoUsuario, IdPermissao)VALUES(2, 1)
INSERT INTO PermissaoGrupoUsuario (IdGrupoUsuario, IdPermissao)VALUES(2, 2)
INSERT INTO PermissaoGrupoUsuario (IdGrupoUsuario, IdPermissao)VALUES(2, 3)
INSERT INTO PermissaoGrupoUsuario (IdGrupoUsuario, IdPermissao)VALUES(2, 11)
INSERT INTO PermissaoGrupoUsuario (IdGrupoUsuario, IdPermissao)VALUES(2, 35)
INSERT INTO PermissaoGrupoUsuario (IdGrupoUsuario, IdPermissao)VALUES(2, 39)
INSERT INTO PermissaoGrupoUsuario (IdGrupoUsuario, IdPermissao)VALUES(2, 43)
INSERT INTO PermissaoGrupoUsuario (IdGrupoUsuario, IdPermissao)VALUES(2, 44)
GO
INSERT INTO Fornecedor (Nome, Email, Telefone, Endereco, CEP) VALUES ('Alimentos LTDA', 'Altda@gmail.com', '639993542317', 'Rua X, Avenida Filadélfia', '887234-875')
INSERT INTO Fornecedor (Nome, Email, Telefone, Endereco, CEP) VALUES ('Bebidas LTDA', 'Bltda@gmail.com', '61981856954', 'Rua Z, Avenida Filadélfia', '66690-690')
INSERT INTO Fornecedor (Nome, Email, Telefone, Endereco, CEP) VALUES ('Mundo do Iogurte', 'Iogworld@gmail.com', '61981856954', 'Rua A, Jardim Esmeralda', '75690-690')
GO
Insert Into Categoria(Nome) VALUES ('Alimentos')
Insert Into Categoria(Nome) VALUES ('Bebidas')
Insert Into Categoria(Nome) VALUES ('Gelados')
GO
Insert Into Marca(Nome) VALUES ('Nestle')
Insert Into Marca(Nome) VALUES ('Coca-Cola')
Insert Into Marca(Nome) VALUES ('Friaca')
GO
Insert into Produto(Nome, Descricao, CodigoDeBarra, Preco, Quantidade, Custo, IdMarca, IdCategoria, IdFornecedor) Values ('Barra de Cereal', '50g', 'ABCDEF', 6.50, 50, 4.25, 1, 1, 1)
Insert into Produto(Nome, Descricao, CodigoDeBarra, Preco, Quantidade, Custo, IdMarca, IdCategoria, IdFornecedor) Values ('Refrigerante de Cola', '600ML', 'XXXZZZ', 9.50, 75, 7.50, 2, 2, 2)
Insert into Produto(Nome, Descricao, CodigoDeBarra, Preco, Quantidade, Custo, IdMarca, IdCategoria, IdFornecedor) Values ('Sorvete', 'Sabor Chocolate', 'AAAEEE', 12.25, 20, 10, 3, 3, 3)
GO
Insert Into FormaPagamento(Tipo, Descricao, Troco) VALUES ('Dinheiro', 'Uma forma de pagamento física, com cédulas e moedas', 1)
Insert Into FormaPagamento(Tipo, Descricao, Troco) VALUES ('Cartão de Débito', 'Uma forma de pagamento que usa moeda virtual de conta bancária, de débito instantâneo', 0)
Insert Into FormaPagamento(Tipo, Descricao, Troco) VALUES ('Pix', 'Uma forma de pagamento eletrônico que permite transferência monetária instantânea', 0)

