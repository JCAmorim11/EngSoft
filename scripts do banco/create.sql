-- SCRIPT DE CRIAÇÃO DO BANCO
USE [master]

-- COMANDO QUE DERRUBA O BANCO
IF  EXISTS (
SELECT name 
FROM sys.databases 
WHERE name = 'padariaBD')
DROP DATABASE padariaBD
GO
-- COMANDO QUE DERRUBA O BANCO
USE master
GO
--COMANDO DE CRIAÇÃO DE BANCO DE DADOS: CREATE DATABASE
--Criação do Banco de Dados da padaria
--Mudem o filename de ambos se quiserem testar em casa.
CREATE DATABASE padariaBD ON 
(	
	NAME = padariaBD_db, --nome lógico
	FILENAME = "C:\Users\DELL\Documents\Projekt_engsoft\banco\padariaBD.mdf", --nome físico
	SIZE = 5 Mb, --tamanho
	MAXSIZE = 10 Mb, --tamanho máximo
	FILEGROWTH = 1 Mb --taxa de crescimento
) 
LOG ON -- criação do log, continuação do create database
( 
	NAME = padariaBD_log, 
	FILENAME = "C:\Users\DELL\Documents\Projekt_engsoft\banco\padariaBD.ldf",
	SIZE = 1 Mb,
	MAXSIZE = 5 Mb,
	FILEGROWTH = 1 Mb
)
GO
--use padariaBD
--go
CREATE TABLE padariaBD.dbo.Produtos
()
create table padariaBD.dbo.Fornecedores()
create table padariaBD.dbo.Usuario()
create table padariaBD.dbo.