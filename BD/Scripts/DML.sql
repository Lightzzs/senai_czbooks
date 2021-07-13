USE CZBooks_;

INSERT INTO TiposUsuarios( Descricao )
VALUES					 ('Administrador'),
						 ('Autor'),
						 ('Cliente')

INSERT INTO	Usuarios (IdTipoUsuario, Email, Senha, Nome)
VALUES				 (1, 'adm@adm.com', 'adm123', 'adm'),
					 (1, 'marcos@gmail.com', 'marcos123', 'marcos'),
					 (1, 'joao@gmail.com', 'joao123', 'joao'),
					 (2, 'joanne@gmail.com', 'joanne123', 'joanne'),
					 (2, 'jeff@gmail.com', 'jeff123', 'jeff'),
					 (2, 'arthur@gmail.com', 'arthur123', 'arthur'),
					 (2, 'jody@gmail.com', 'jody123', 'jody'),
					 (2, 'anne@gmail.com', 'anne123', 'anne'),
					 (3, 'gabriel@gmail.com', 'gabriel123', 'gabriel'),
					 (3, 'fernanda@gmail.com', 'fernanda123', 'fernanda'),
					 (3, 'sandra@gmail.com', 'sandra123', 'sandra'),
					 (3, 'vitoria@gmail.com', 'vitoria123', 'vitoria'),
					 (3, 'gustavo@gmail.com', 'gustavo123', 'gustavo')

INSERT INTO	Autores (IdUsuario, Nome)
VALUES				(4, 'Joanne Rowling'),
					(5, 'Jeff Kinney'),
					(6, 'Arthur Conan Doyle'),
					(7, 'Jody Houser'),
					(8, 'Anne Frank')

INSERT INTO Livrarias (Nome, Endereco)
VALUES				  ('Saraiva','Alameda Barão de Limeira, 539 - Santa Cecilia, São Paulo - SP, 01202-001')

INSERT INTO Categorias (Descricao)
VALUES				   ('Fantasia')

INSERT INTO Livros (IdAutor, IdUsuario, IdCategoria, IdLivraria, Titulo, Sinopse, DataPublicacao, Preco)
VALUES			   (1, 4, 1, 1, 'Harry Potter e a Pedra Filosofal', 'Harry Potter e a Pedra Filosofal é o primeiro dos sete livros da série de fantasia Harry Potter', '26/07/1997', '25,90'),
				   (2, 5, 1, 1, 'Diário de um Banana', 'Diary of a Wimpy Kid é uma série de livros do gênero Ficção Científica', '1/04/2007', '25,00'),
				   (3, 6, 1, 1, 'As Memórias de Sherlock Holmes', 'The Memoirs of Sherlock Holmes é uma coletânea de onze contos de histórias do detetive Sherlock Holmes', '10/11/1893', '11,89'),
				   (4, 7, 1, 1, 'Stranger Things O Outro Lado', 'O silêncio, o escuro, o frio - o Mundo Invertido, um sítio até então só visto em delírios psíquicos e em pesadelos', '26/09/2018', '54,90'),
				   (5, 8, 1, 1, 'Diário de Anne Frank', 'O Diário de Anne Frank é um livro escrito por Anne Frank entre 12 de junho de 1942 e 1.º de agosto de 1944 durante a Segunda Guerra Mundial', '25/06/1947', '20,00')
			

