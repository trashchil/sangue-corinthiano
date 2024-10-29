-- phpMyAdmin SQL Dump
-- version 5.0.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 01-Jul-2022 às 22:11
-- Versão do servidor: 10.4.17-MariaDB
-- versão do PHP: 8.0.0

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `sangue corinthiano`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_doadores`
--

CREATE TABLE `tb_doadores` (
  `id_codigo` int(100) NOT NULL,
  `email` varchar(50) NOT NULL,
  `nome` varchar(50) NOT NULL,
  `idade` int(100) NOT NULL,
  `endereco` varchar(100) NOT NULL,
  `bairro` varchar(20) NOT NULL,
  `cep` varchar(10) NOT NULL,
  `celular` varchar(20) NOT NULL,
  `rg` varchar(15) NOT NULL,
  `cpf` varchar(15) NOT NULL,
  `tipo_sanguineo` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_recptores`
--

CREATE TABLE `tb_recptores` (
  `id_codigo` int(100) NOT NULL,
  `email` varchar(50) NOT NULL,
  `nome` varchar(50) NOT NULL,
  `idade` varchar(100) NOT NULL,
  `endereco` varchar(100) NOT NULL,
  `bairro` varchar(20) NOT NULL,
  `cep` varchar(10) NOT NULL,
  `celular` varchar(20) NOT NULL,
  `rg` varchar(15) NOT NULL,
  `cpf` varchar(15) NOT NULL,
  `tipo_sanguineo` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Índices para tabelas despejadas
--

--
-- Índices para tabela `tb_doadores`
--
ALTER TABLE `tb_doadores`
  ADD PRIMARY KEY (`id_codigo`),
  ADD UNIQUE KEY `cpf` (`cpf`),
  ADD UNIQUE KEY `rg` (`rg`);

--
-- Índices para tabela `tb_recptores`
--
ALTER TABLE `tb_recptores`
  ADD PRIMARY KEY (`id_codigo`),
  ADD UNIQUE KEY `rg` (`rg`),
  ADD UNIQUE KEY `cpf` (`cpf`);

--
-- AUTO_INCREMENT de tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `tb_doadores`
--
ALTER TABLE `tb_doadores`
  MODIFY `id_codigo` int(100) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de tabela `tb_recptores`
--
ALTER TABLE `tb_recptores`
  MODIFY `id_codigo` int(100) NOT NULL AUTO_INCREMENT;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
