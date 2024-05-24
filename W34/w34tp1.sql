-- phpMyAdmin SQL Dump
-- version 4.8.5
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Generation Time: Apr 19, 2023 at 10:15 PM
-- Server version: 5.7.26
-- PHP Version: 7.3.5

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `w34tp1`
--

-- --------------------------------------------------------

--
-- Table structure for table `produits`
--

DROP TABLE IF EXISTS `produits`;
CREATE TABLE IF NOT EXISTS `produits` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `code` varchar(10) NOT NULL,
  `titre` varchar(250) NOT NULL,
  `description` text NOT NULL,
  `prix` double(9,2) NOT NULL,
  `image` varchar(255) NOT NULL DEFAULT 'https://fakeimg.pl/200x200',
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=12 DEFAULT CHARSET=utf8;

--
-- Dumping data for table `produits`
--

INSERT INTO `produits` (`id`, `code`, `titre`, `description`, `prix`, `image`) VALUES
(1, 'P01', 'T-Shirt en coton', 'T-Shirt en coton confortable et durable', 25.00, 'https://images.unsplash.com/photo-1581655353564-df123a1eb820?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=687&q=80'),
(2, 'P02', 'Casque d\'écoute Bluetooth', 'Casque d\'écoute Bluetooth de qualité supérieur avec annulation active de bruit.', 149.99, 'https://images.unsplash.com/photo-1620360642994-974f7fd8e9b4?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1332&q=80'),
(3, 'P03', 'Montre connectée', 'Montre connectée moderne avec suivi de la santé et de la condition physique.', 300.00, 'https://images.unsplash.com/photo-1575311373937-040b8e1fd5b6?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=888&q=80'),
(4, 'P04', 'Ordinateur portable', 'Ordinateur portable performant et léger pour une utilisation quotidienne.', 749.99, 'https://images.unsplash.com/photo-1498050108023-c5249f4df085?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1172&q=80'),
(5, 'P05', 'Appareil photo numérique', 'Appareil photo numérique avec fonctionnalités avancées pour les photographes professionnels.', 1000.00, 'https://images.unsplash.com/photo-1502920917128-1aa500764cbd?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1170&q=80'),
(6, 'P06', 'Vélo de montagne', 'Vélo de montagne robuste et performant pour les aventures en plein air.', 1500.00, 'https://images.unsplash.com/photo-1608531428470-4471739c4359?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1127&q=80'),
(7, 'P07', 'Téléviseur intelligent', 'Téléviseur intelligent de haute qualité avec fonctionnalités de streaming.', 600.00, 'https://images.unsplash.com/photo-1601944177325-f8867652837f?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1177&q=80'),
(8, 'P08', 'Aspirateur robot', 'Aspirateur robot intelligent avec navigation autonome et programmation.', 399.00, 'https://images.unsplash.com/photo-1590164409291-450e859ccb87?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1074&q=80'),
(9, 'P09', 'Drone', 'Drone professionnel avec caméra haute résolution et fonctionnalités de vol automatisé.', 800.00, 'https://images.unsplash.com/photo-1504890195358-94a018166410?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1178&q=80'),
(10, 'P10', 'Enceinte(speaker) Bluetooth', 'Enceinte Bluetooth portable avec son de qualité supérieure.', 50.00, 'https://images.unsplash.com/photo-1529359744902-86b2ab9edaea?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1170&q=80'),
(11, '123', 'tests', 'gfdgdfgdf', 432.00, 'test');

-- --------------------------------------------------------

--
-- Table structure for table `utilisateurs`
--

DROP TABLE IF EXISTS `utilisateurs`;
CREATE TABLE IF NOT EXISTS `utilisateurs` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `unom` varchar(25) NOT NULL,
  `umdp` varchar(255) NOT NULL,
  `email` varchar(255) NOT NULL,
  `level` int(11) NOT NULL DEFAULT '1',
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;

--
-- Dumping data for table `utilisateurs`
--

INSERT INTO `utilisateurs` (`id`, `unom`, `umdp`, `email`, `level`) VALUES
(1, 'John', '123', 'john@john.com', 5),
(2, 'Admin', 'admin', 'admin@admin.com', 1),
(3, 'Jane', '456', 'jane@jane.com', 5),
(4, 'Mod', 'mod', 'mod@mod.com', 2);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
