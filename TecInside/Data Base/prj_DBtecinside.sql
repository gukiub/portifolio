CREATE TABLE cliente ( 
	id_cliente 	 INT(5) PRIMARY KEY AUTO_INCREMENT,
    nome         VARCHAR(30)
         NOT NULL,
    cpf          int(11)
        NOT NULL,
    email        VARCHAR(30)
         NOT NULL,
    senha        VARCHAR(30)
        NOT NULL,
    uf           CHAR(2)
        NOT NULL,
    cidade       CHAR(15)
        NOT NULL,
    telefone     int(11)
        NOT NULL
);

CREATE TABLE funcionario (
    id_fun   int(5)
         PRIMARY KEY AUTO_INCREMENT,
    nome     VARCHAR(30)
         NOT NULL,
    email    VARCHAR(30)
        NOT NULL,
    senha    VARCHAR(30)
         NOT NULL
);

CREATE TABLE stat (
    problema_clie   VARCHAR(80)
         NOT NULL,
    stat_tipo       int(4)
        PRIMARY KEY
);


CREATE TABLE chamados (
    id_chamado    int(5)
         PRIMARY KEY AUTO_INCREMENT,
    status        VARCHAR(10)
        NOT NULL,
    dthora        DATETIME
        NOT NULL,
    tipificacao   VARCHAR(80)
         NOT NULL,
    id_cliente int(5),
    id_fun int(5),
    stat_tipo int(4)
);

alter table chamados
add foreign key (id_cliente)
references cliente(id_cliente);

alter table chamados
add foreign key (id_fun)
references funcionario(id_fun);

alter table chamados
add foreign key (stat_tipo)
references stat(stat_tipo);

