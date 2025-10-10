create database dbClinica;

use dbClinica;

create table tbUnidade(
IdUnidade int primary key,
NomeU varchar(70) not null,
Endereco varchar(70) not null
);

create table tbPlano(
IdPlano int primary key,
Nome varchar(70) not null, 
Valor decimal(6,2) not null,
Tipo char(1) not null
);


create table Unidade_Plano(
IdUnidade int,
IdPlano int,
primary key (IdUnidade, IdPlano),
foreign key (IdUnidade) references tbUnidade(IdUnidade),
foreign key (IdPlano) references tbPlano(IdPlano)
);

create table tbEspecialidade(
IdEspecialidade int primary key,
NomeE varchar(25) not null
);

create table tbMedico (
Crm varchar(10) primary key,
Nome varchar(70) not null,
Telefone char(11) not null,
Email varchar(70) not null,
Senha varchar(20) not null,
IdEspecialidade int,
constraint Medico_Especialidade 
foreign key (IdEspecialidade) 
references tbEspecialidade(IdEspecialidade)
);

create table Unidade_Medico(
IdUnidade int,
Crm varchar(10),
primary key (IdUnidade, Crm),
foreign key (IdUnidade) references tbUnidade(IdUnidade),
foreign key (Crm) references tbMedico(Crm)
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

create table tbAgenda (
IdAgenda int primary key,
DataH datetime not null,
StatusA varchar(10) not null,
Crm varchar(10), 
constraint Agenda_Medico
foreign key (Crm) 
references tbMedico (Crm)
 
);

create table tbConsulta (
IdConsulta int primary key,
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
IdProntuario int primary key,
Exame varchar(20) not null,
Receita text not null,
Descricao text not null,
Resultado text not null,
IdConsulta int,
constraint Prontuario_Consulta
foreign key (IdConsulta) 
references tbConsulta(IdConsulta)
);

