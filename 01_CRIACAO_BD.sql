create database Senatur_Tarde

use Senatur_Tarde

create table Pacotes (
IdPacote     int primary key identity,
NomePacote   varchar(255),
Descricao    varchar(3000),
DataIda      date,
DataVolta    date,
Valor        decimal,
Ativo        bit,
NomeCidade   varchar(255));

create table TipoUsuario(
IdTipoUsuario int primary key identity,
Titulo        varchar(255));

create table Usuarios (
IdUsuario int primary key identity,
Email varchar(255),
Senha varchar(255),
IdTipoUsuario int foreign key references TipoUsuario(IdTipoUsuario));

truncate table Usuarios



