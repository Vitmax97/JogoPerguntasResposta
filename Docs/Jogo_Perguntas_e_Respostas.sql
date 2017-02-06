create database db_PerguntasERespostas --Cria um database--

use db_PerguntasERespostas --começa a usar o database--

create table tb_Jogador(              --Começo de criar uma tabela--
	id int identity primary key,
	nome varchar(100) not null
)                                     --Término da criação da tabela--

truncate table tb_Jogador --Reseta o ID da tabela--

select * from tb_Jogador --Seleciona tudo da tabela--

delete from tb_Jogador where id = 9 --Deleta o ID 9 da tabela--

insert into tb_Jogador(nome) values('Ramón')--Insere o nome na tabela--

-------------------------------------------------------------------------------

create table tb_Perguntas (                --Começo da criação da tabela--
id_Perguntas int identity primary key,
pergunta varchar(max),
resposta_correta varchar(max),
data datetime default getdate()

)											--Término da criação da tabela--

select * from tb_Perguntas

insert into tb_Perguntas(pergunta, resposta_correta) --Insere na tabela tb_Perguntas as variáveis pergunta e resposta_correta--
values ('Qual é a cor do cavalo branco de napoleão?', 'Branco') --Insere na tabela a pergunta e a resposta correta--

delete from tb_Jogador --Deleta os nomes da tabela--

alter table tb_Perguntas add id_jogador int
