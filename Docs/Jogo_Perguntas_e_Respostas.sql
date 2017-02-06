-- Criar banco de dados
create database db_PerguntasERespostas

-- Usar banco de dados
use db_PerguntasERespostas

-- Criar tabela tb_Jogador
create table tb_Jogador(
	id int identity primary key,
	nome varchar(100) not null
)

-- Seleciona tudo da tabela tb_Jogador
select * from tb_Jogador

-- Seleciona tudo da tabela tb_Perguntas
select * from tb_Perguntas

--Insere valor dentro da tabela tb_Jogador na coluna nome
insert into tb_Jogador(nome) values('Amanda')
insert into tb_Jogador(nome) values('Fernanda')

-- Criar tabela tb_Perguntas com as seguintes colunas, id, pergunta, resposta_correta, data
create table tb_Perguntas(
	id		int identity primary key,
	pergunta			varchar(max),
	resposta_correta	varchar (max),
	id_jogador					int ,
	data datetime default getdate()
)

-- Insere os valores dentro da tabela tb_Jogador nas colunas pergunta, reposta_correta
insert into tb_Perguntas (pergunta, resposta_correta) values ('1) O software tem por objetivo em uma apresentação?','O software deve simplificar a apresentação em vez de complicá-la.' )

-- Deleta o id 17 da tabela tb_Jogador
delete from tb_Jogador where id = 17

-- Insere dentro da tabela tb_Jogador o valor Ramón
insert into tb_Jogador (nome) values ('Ramón')

-- Apaga todos registros da tabela tb_Jogador
delete from tb_Jogador

-- Zera toda tabela e começa o id do 1
truncate table tb_Jogador

-- Adicionar a columa id_jogador dentro da tabela depois que ela já foi criada
alter table tb_Perguntas add id_jogador int

-- Excluir a columa id_jogador adicionada por engano na tabela tb_Perguntas
alter table tb_Jogador drop column id_jogador


-- Fazer "junção" das tabelas tb_Jogador com a tb_Perguntas "onde" tb_Jogador.id = tb_Perguntas.id_jogador
select * from tb_Jogador join tb_Perguntas on tb_Jogador.id = tb_Perguntas.id_jogador

-- Identifica o ultimo insert feito em qualquer tabela
select  @@IDENTITY

-- Site para entender alguns conceitos
--http://www.devmedia.com.br/conhecendo-os-metodos-executenonquery-executereader-e-executescalar-da-ado-net/27579




