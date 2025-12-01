create database dbClinica;

use dbClinica;

create table tbUnidade(
IdUnidade int primary key auto_increment,
NomeU varchar(70) not null,
Endereco varchar(70) not null
);

create table tbPlano(
IdPlano int primary key auto_increment,
Nome varchar(70) not null, 
Valor decimal(6,2) not null,
Tipo char(1) not null
);

create table tbPaciente (
Carteirinha char(9) primary key,
Cpf char(11) unique not null,
Nome varchar(70) not null,
DataNasci date not null,
Email varchar(70) not null,
Senha varchar(20) not null,
Telefone char(11) not null,
Sexo char(1) not null,
IdPlano int,
foreign key (IdPlano) references tbPlano(IdPlano)
);

create table tbUnidade_Plano(
IdUnidade int,
IdPlano int,
primary key (IdUnidade, IdPlano),
foreign key (IdUnidade) references tbUnidade(IdUnidade),
foreign key (IdPlano) references tbPlano(IdPlano)
);

create table tbMedico (
Crm varchar(10) primary key,
Nome varchar(70) not null,
Telefone char(11) not null,
Email varchar(70) not null,
Senha varchar(20) not null,
Especialidade varchar(45)
);

create table tbUnidade_Medico(
IdUnidade int,
Crm varchar(10),
primary key (IdUnidade, Crm),
foreign key (IdUnidade) references tbUnidade(IdUnidade),
foreign key (Crm) references tbMedico(Crm)
);


create table tbAgenda (
IdAgenda int primary key auto_increment,
DataH datetime not null,
StatusA varchar(10) not null,
Crm varchar(10), 
constraint Agenda_Medico
foreign key (Crm) 
references tbMedico (Crm),
Carteirinha char(9), 
constraint Agenda_Paciente
foreign key (Carteirinha) 
references tbPaciente (Carteirinha) 
);

create table tbConsulta (
IdConsulta int primary key auto_increment,
StatusC varchar(10) not null,
Carteirinha char(9),
constraint Consulta_Paciente
foreign key (Carteirinha) 
references tbPaciente(Carteirinha),
IdAgenda int, 
constraint Consulta_Agenda 
foreign key (IdAgenda) 
references tbAgenda(IdAgenda),
Crm varchar(10),
constraint Consulta_Medico
foreign key (Crm) 
references tbMedico(Crm),
IdUnidade int,
constraint Consulta_Unidade
foreign key (IdUnidade) 
references tbUnidade (IdUnidade)
);

create table tbProntuario (
IdProntuario int primary key auto_increment,
Exame varchar(20) not null,
Receita text null,
Descricao text not null,
Resultado text not null,
IdConsulta int,
constraint Prontuario_Consulta
foreign key (IdConsulta) 
references tbConsulta(IdConsulta)
);

insert into tbPlano (Nome, Valor, Tipo)
		values ('Sorria+ Essencial', 39.90, 'A'),
			   ('Sorria+ Plus', 69.90, 'B'),
			   ('Sorria+ Premium', 119.90, 'C');

insert into tbUnidade ( NomeU, Endereco)
		values ('Sorria+ Osasco', 'Av. dos Autonomistas, 1540 – Centro, Osasco – SP'),
			   ('Sorria+ Pinheiros', 'Rua Teodoro Sampaio, 987 – Pinheiros, São Paulo – SP'),
			   ('Sorria+ Vila Mariana', 'Rua Domingos de Morais, 2201 – Vila Mariana, São Paulo – SP'),
			   ('Sorria+ Tatuapé', 'Rua Tuiuti, 586 – Tatuapé, São Paulo – SP'),
			   ('Sorria+ Santo Amaro', 'Av. Santo Amaro, 4500 – Santo Amaro, São Paulo – SP');

delimiter $$
create procedure insertTbUni_Plano (
    vNomeU varchar(70),
	vNomeP varchar(70)
)
begin
	declare vPlanoId int;
	declare vUniId int;

	select IdPlano into vPlanoId from tbPlano where Nome = vNomeP;
	select IdUnidade into vUniId from tbUnidade where NomeU = vNomeU;

	insert into tbUnidade_Plano (IdUnidade, IdPlano)
						 values (vUniId, vPlanoId);

end; 
$$

call insertTbUni_Plano ('Sorria+ Osasco', 'Sorria+ Essencial');
call insertTbUni_Plano ('Sorria+ Pinheiros', 'Sorria+ Essencial');
call insertTbUni_Plano ('Sorria+ Osasco', 'Sorria+ Plus');
call insertTbUni_Plano ('Sorria+ Pinheiros', 'Sorria+ Plus');
call insertTbUni_Plano ('Sorria+ Vila Mariana', 'Sorria+ Plus');
call insertTbUni_Plano ('Sorria+ Osasco', 'Sorria+ Premium');
call insertTbUni_Plano ('Sorria+ Pinheiros', 'Sorria+ Premium');
call insertTbUni_Plano ('Sorria+ Vila Mariana', 'Sorria+ Premium');
call insertTbUni_Plano ('Sorria+ Tatuapé', 'Sorria+ Premium');
call insertTbUni_Plano ('Sorria+ Santo Amaro', 'Sorria+ Premium');

select * from tbPaciente;
select * from tbMedico;
select * from tbUnidade_Plano;
select * from tbUnidade_Medico;



