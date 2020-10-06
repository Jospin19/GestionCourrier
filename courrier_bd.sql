-- phpMyAdmin SQL Dump
-- version 4.7.7
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jun 30, 2018 at 09:06 AM
-- Server version: 10.1.30-MariaDB
-- PHP Version: 7.2.2

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `courrier_bd`
--

-- --------------------------------------------------------

--
-- Table structure for table `admins`
--

CREATE TABLE `admins` (
  `id_admin` int(11) NOT NULL,
  `login_admin` varchar(100) DEFAULT NULL,
  `passwd_admin` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `courriers`
--

CREATE TABLE `courriers` (
  `id_cour` int(11) NOT NULL,
  `reference_cour` varchar(45) DEFAULT NULL,
  `libelle_cour` varchar(100) DEFAULT NULL,
  `contenu` mediumtext,
  `type_cour` varchar(25) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `courriers`
--

INSERT INTO `courriers` (`id_cour`, `reference_cour`, `libelle_cour`, `contenu`, `type_cour`) VALUES
(1, 'ref234567', 'Bonjour', 'Bonjour le monde', 'Interne'),
(2, 'ref345278', 'Bonsoir', 'Bonsoir a tous', 'I'),
(5, 'ref1234567', 'test', 'Bonsoir', ''),
(7, 'ref2222225', 'Test', 'Derniers test', 'C'),
(8, 'ref3333333', 'Lettre au rep', 'Bonjour le rep', 'I'),
(9, 'ref123654', 'Bonjour', 'test', 'Entrant'),
(10, 'ref552266', 'test', 'Bonjour', 'Sortant'),
(12, 'ref44558866', 'test', 'test', 'Entrant'),
(21, 'ref445566', 'test', 'test', 'Interne'),
(23, 'ref5555555', 'Lettre au rep', 'Je veux voir le rep', 'Interne');

-- --------------------------------------------------------

--
-- Table structure for table `courriers_expediteurs`
--

CREATE TABLE `courriers_expediteurs` (
  `courriers_id_cour` int(11) NOT NULL,
  `expediteurs_id_exp` int(11) NOT NULL,
  `date_expedition` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Stand-in structure for view `enregistrements`
-- (See below for the actual view)
--
CREATE TABLE `enregistrements` (
`reference_cour` varchar(45)
,`libelle_cour` varchar(100)
,`type_cour` varchar(25)
,`nom_exp` varchar(100)
,`prenom_exp` varchar(100)
,`date_enregistrement` datetime
);

-- --------------------------------------------------------

--
-- Table structure for table `expediteurs`
--

CREATE TABLE `expediteurs` (
  `id_exp` int(11) NOT NULL,
  `nom_exp` varchar(100) DEFAULT NULL,
  `prenom_exp` varchar(100) DEFAULT NULL,
  `tel_exp` varchar(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `expediteurs`
--

INSERT INTO `expediteurs` (`id_exp`, `nom_exp`, `prenom_exp`, `tel_exp`) VALUES
(1, '', 'Hugues', '677889900'),
(2, '', 'EKEME', '677889900'),
(7, 'Charlie', 'jospin', '55677889'),
(8, 'Charlie', 'Leticia', '677889900'),
(9, 'Hugo', 'Jospin', '688552266'),
(10, 'Leti', 'Charlie', '699885522'),
(12, 'nsso', 'ekeme', '6995533'),
(21, 'nsso', 'nsso', '699889988'),
(23, 'Jospin', 'Hugues', '677889900');

-- --------------------------------------------------------

--
-- Table structure for table `secretaires`
--

CREATE TABLE `secretaires` (
  `id_sec` int(11) NOT NULL,
  `nom_sec` varchar(100) DEFAULT NULL,
  `prenom_sec` varchar(100) DEFAULT NULL,
  `email_sec` varchar(100) DEFAULT NULL,
  `tel` varchar(11) DEFAULT NULL,
  `login` varchar(100) NOT NULL,
  `password` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `secretaires`
--

INSERT INTO `secretaires` (`id_sec`, `nom_sec`, `prenom_sec`, `email_sec`, `tel`, `login`, `password`) VALUES
(1, 'leticia', 'leti', 'leticia@gmail.com', '677889900', 'leticia', 'leticia');

-- --------------------------------------------------------

--
-- Table structure for table `secretaires_courriers`
--

CREATE TABLE `secretaires_courriers` (
  `secretaires_id_sec` int(11) NOT NULL,
  `courriers_id_cour` int(11) NOT NULL,
  `date_enregistrement` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Structure for view `enregistrements`
--
DROP TABLE IF EXISTS `enregistrements`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `enregistrements`  AS  select `courriers`.`reference_cour` AS `reference_cour`,`courriers`.`libelle_cour` AS `libelle_cour`,`courriers`.`type_cour` AS `type_cour`,`expediteurs`.`nom_exp` AS `nom_exp`,`expediteurs`.`prenom_exp` AS `prenom_exp`,`secretaires_courriers`.`date_enregistrement` AS `date_enregistrement` from ((`courriers` join `expediteurs`) join `secretaires_courriers`) ;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `admins`
--
ALTER TABLE `admins`
  ADD PRIMARY KEY (`id_admin`);

--
-- Indexes for table `courriers`
--
ALTER TABLE `courriers`
  ADD PRIMARY KEY (`id_cour`);

--
-- Indexes for table `courriers_expediteurs`
--
ALTER TABLE `courriers_expediteurs`
  ADD PRIMARY KEY (`courriers_id_cour`,`expediteurs_id_exp`),
  ADD KEY `fk_courriers_has_expediteurs_expediteurs1_idx` (`expediteurs_id_exp`),
  ADD KEY `fk_courriers_has_expediteurs_courriers1_idx` (`courriers_id_cour`);

--
-- Indexes for table `expediteurs`
--
ALTER TABLE `expediteurs`
  ADD PRIMARY KEY (`id_exp`);

--
-- Indexes for table `secretaires`
--
ALTER TABLE `secretaires`
  ADD PRIMARY KEY (`id_sec`);

--
-- Indexes for table `secretaires_courriers`
--
ALTER TABLE `secretaires_courriers`
  ADD PRIMARY KEY (`secretaires_id_sec`,`courriers_id_cour`),
  ADD KEY `fk_secretaires_has_courriers_courriers1_idx` (`courriers_id_cour`),
  ADD KEY `fk_secretaires_has_courriers_secretaires_idx` (`secretaires_id_sec`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `admins`
--
ALTER TABLE `admins`
  MODIFY `id_admin` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `courriers`
--
ALTER TABLE `courriers`
  MODIFY `id_cour` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=24;

--
-- AUTO_INCREMENT for table `expediteurs`
--
ALTER TABLE `expediteurs`
  MODIFY `id_exp` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=24;

--
-- AUTO_INCREMENT for table `secretaires`
--
ALTER TABLE `secretaires`
  MODIFY `id_sec` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `courriers_expediteurs`
--
ALTER TABLE `courriers_expediteurs`
  ADD CONSTRAINT `fk_courriers_has_expediteurs_courriers1` FOREIGN KEY (`courriers_id_cour`) REFERENCES `courriers` (`id_cour`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_courriers_has_expediteurs_expediteurs1` FOREIGN KEY (`expediteurs_id_exp`) REFERENCES `expediteurs` (`id_exp`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `secretaires_courriers`
--
ALTER TABLE `secretaires_courriers`
  ADD CONSTRAINT `fk_secretaires_has_courriers_courriers1` FOREIGN KEY (`courriers_id_cour`) REFERENCES `courriers` (`id_cour`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_secretaires_has_courriers_secretaires` FOREIGN KEY (`secretaires_id_sec`) REFERENCES `secretaires` (`id_sec`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
