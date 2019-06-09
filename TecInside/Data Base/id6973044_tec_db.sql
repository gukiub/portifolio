-- phpMyAdmin SQL Dump
-- version 4.7.7
-- https://www.phpmyadmin.net/
--
-- Host: localhost
-- Generation Time: 26-Nov-2018 às 00:29
-- Versão do servidor: 10.1.31-MariaDB
-- PHP Version: 7.0.26

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `id6973044_tec_db`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `chamados`
--

CREATE TABLE `chamados` (
  `id_chamado` int(5) NOT NULL,
  `status` varchar(10) COLLATE utf8_unicode_ci NOT NULL,
  `dthora` datetime NOT NULL,
  `tipificacao` varchar(80) COLLATE utf8_unicode_ci NOT NULL,
  `id_cliente` int(5) DEFAULT NULL,
  `id_fun` int(5) DEFAULT NULL,
  `stat_tipo` int(4) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- --------------------------------------------------------

--
-- Estrutura da tabela `cliente`
--

CREATE TABLE `cliente` (
  `id_cliente` int(5) NOT NULL,
  `nome` varchar(30) COLLATE utf8_unicode_ci NOT NULL,
  `cpf` int(11) NOT NULL,
  `email` varchar(30) COLLATE utf8_unicode_ci NOT NULL,
  `senha` varchar(30) COLLATE utf8_unicode_ci NOT NULL,
  `uf` char(2) COLLATE utf8_unicode_ci NOT NULL,
  `cidade` char(15) COLLATE utf8_unicode_ci NOT NULL,
  `telefone` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- --------------------------------------------------------

--
-- Estrutura da tabela `funcionario`
--

CREATE TABLE `funcionario` (
  `id_fun` int(5) NOT NULL,
  `nome` varchar(30) COLLATE utf8_unicode_ci NOT NULL,
  `email` varchar(30) COLLATE utf8_unicode_ci NOT NULL,
  `senha` varchar(30) COLLATE utf8_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- --------------------------------------------------------

--
-- Estrutura da tabela `stat`
--

CREATE TABLE `stat` (
  `problema_clie` varchar(80) COLLATE utf8_unicode_ci NOT NULL,
  `stat_tipo` int(4) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `chamados`
--
ALTER TABLE `chamados`
  ADD PRIMARY KEY (`id_chamado`),
  ADD KEY `id_cliente` (`id_cliente`),
  ADD KEY `id_fun` (`id_fun`),
  ADD KEY `stat_tipo` (`stat_tipo`);

--
-- Indexes for table `cliente`
--
ALTER TABLE `cliente`
  ADD PRIMARY KEY (`id_cliente`);

--
-- Indexes for table `funcionario`
--
ALTER TABLE `funcionario`
  ADD PRIMARY KEY (`id_fun`);

--
-- Indexes for table `stat`
--
ALTER TABLE `stat`
  ADD PRIMARY KEY (`stat_tipo`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `chamados`
--
ALTER TABLE `chamados`
  MODIFY `id_chamado` int(5) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `cliente`
--
ALTER TABLE `cliente`
  MODIFY `id_cliente` int(5) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `funcionario`
--
ALTER TABLE `funcionario`
  MODIFY `id_fun` int(5) NOT NULL AUTO_INCREMENT;

--
-- Constraints for dumped tables
--

--
-- Limitadores para a tabela `chamados`
--
ALTER TABLE `chamados`
  ADD CONSTRAINT `chamados_ibfk_1` FOREIGN KEY (`id_cliente`) REFERENCES `cliente` (`id_cliente`),
  ADD CONSTRAINT `chamados_ibfk_2` FOREIGN KEY (`id_fun`) REFERENCES `funcionario` (`id_fun`),
  ADD CONSTRAINT `chamados_ibfk_3` FOREIGN KEY (`stat_tipo`) REFERENCES `stat` (`stat_tipo`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
