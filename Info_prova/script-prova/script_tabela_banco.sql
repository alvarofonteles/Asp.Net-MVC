--create database db_info;

--use db_info;

create table categoria (
id_categoria integer identity not null,
ds_categoria varchar(50),
constraint pk_categoria primary key (id_categoria)
);

create table produto (
id_produto integer identity not null,
ds_produto varchar(80),
valor decimal(15,2),
id_categoria integer not null,
constraint pk_produto primary key (id_produto),
constraint fk_cat_prod foreign key (id_categoria) references categoria (id_categoria )
);

CREATE TABLE tb_pessoa 
(
	id_pessoa int IDENTITY(1, 1) NOT NULL, 
	nome varchar(200) NOT NULL, 
	telefone varchar(30), 
	email varchar(200), 
	CONSTRAINT pk_tb_pessoa PRIMARY KEY (id_pessoa)
);

CREATE TABLE tb_usuario 
(
	usuario varchar(50) NOT NULL UNIQUE, 
	senha varchar(50) NOT NULL, 
	id_pessoa int NOT NULL, 
	CONSTRAINT pk_tb_usuario PRIMARY KEY (id_pessoa),
	CONSTRAINT fk_tb_usuario FOREIGN KEY (id_pessoa) REFERENCES tb_pessoa (id_pessoa)
);

CREATE TABLE tb_pessoa_juridica 
(
	cnpj varchar(30) NOT NULL UNIQUE, 
	inscricao varchar(30) NOT NULL UNIQUE, 
	razao_social varchar(200) NOT NULL, 
	id_pessoa int NOT NULL, 
	CONSTRAINT pk_tb_pessoa_juridica PRIMARY KEY (id_pessoa),
	CONSTRAINT fk_tb_pessoa_juridica FOREIGN KEY (id_pessoa) REFERENCES tb_pessoa (id_pessoa)
);

CREATE TABLE tb_pessoa_fisica 
(
	cpf varchar(20) NOT NULL UNIQUE, 
	rg varchar(20) NOT NULL UNIQUE, 
	data_nascimento date, 
	pai varchar(200), 
	mae varchar(200), 
	id_pessoa int NOT NULL, 
	PRIMARY KEY (id_pessoa),
	CONSTRAINT fk_tb_pessoa_fisica FOREIGN KEY (id_pessoa) REFERENCES tb_pessoa (id_pessoa)
);

create table tb_venda
(
	id_venda int identity(1,1) not null,
	valor decimal(15,2),
	desconto decimal(15,2),
	valor_pago decimal(15,2),
	id_pessoa int,
	constraint pk_venda primary key(id_venda),
	constraint fk_venda_pessoa foreign key (id_pessoa)
		references tb_pessoa (id_pessoa)
);

CREATE TABLE tb_status_pagamento 
(
	id_status int IDENTITY NOT NULL, 
	status varchar(50) NOT NULL, 
	CONSTRAINT pk_status_pag PRIMARY KEY (id_status)
);

create table tb_itens_venda
(
	quantidade int not null,
	id_produto int not null,
	id_venda int not null,
	valor decimal(15,2) not null,
	id_item int identity(1,1) not null,
	constraint pk_itens_venda primary key (id_item),
	constraint fk_itens_produto foreign key (id_produto)
		references produto (id_produto),
	constraint fk_itens_vendas foreign key (id_venda) 
		references tb_venda (id_venda)
);

CREATE TABLE tb_contas_receber 
(
	id_conta int IDENTITY(1, 1) NOT NULL, 
	data_compra date NOT NULL, 
	data_vencimento date NOT NULL, 
	data_pagamento date, 
	id_venda int NOT NULL, 
	id_status int NOT NULL, 
	CONSTRAINT pk_contas_receber PRIMARY KEY (id_conta),
	CONSTRAINT fk_t_cont_rec_tb_vendas FOREIGN KEY (id_venda) REFERENCES tb_venda (id_venda),
	CONSTRAINT fk_t_cont_rec_tb_stat_pag FOREIGN KEY (id_status) REFERENCES tb_status_pagamento (id_status)
);