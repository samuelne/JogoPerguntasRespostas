-- Criar banco de dados
create database db_PerguntasERespostas

-- Usar banco de dados
use db_PerguntasERespostas

-- Criar tabela tb_Jogador
create table tb_Jogador(
	id int identity primary key,
	nome varchar(100) not null
)

-- Seleciona tudo da tabela
select * from tb_Jogador

--Insere dentro da tabela tb_Jogador
insert into tb_Jogador(nome) values('Amanda')
insert into tb_Jogador(nome) values('Fernanda')

--Criar tabela tb_Perguntas
create table tb_Perguntas(
	id		int identity primary key,
	pergunta			varchar(max),
	resposta_correta	varchar (max),
	data datetime default getdate()
)

--Insere dentro da tabela tb_Jogador
insert into tb_Perguntas (pergunta, resposta_correta) values ('1) O software tem por objetivo em uma apresentação?','O software deve simplificar a apresentação em vez de complicá-la.' )

delete from tb_Jogador where id = 17

--Insere dentro da tabela tb_Jogador
insert into tb_Jogador (nome) values ('Ramón')

--Apaga registros da tabela
delete from tb_Jogador

--Zera toda tabela e começa o id
truncate table tb_Jogador

