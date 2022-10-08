-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Aug 03, 2022 at 06:29 PM
-- Server version: 10.4.21-MariaDB
-- PHP Version: 8.0.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `data`
--

-- --------------------------------------------------------

--
-- Table structure for table `customer`
--

CREATE TABLE `customer` (
  `name` varchar(100) NOT NULL,
  `username` varchar(100) NOT NULL,
  `email` varchar(100) NOT NULL,
  `contact` varchar(100) NOT NULL,
  `gender` varchar(10) NOT NULL,
  `password` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `customer`
--

INSERT INTO `customer` (`name`, `username`, `email`, `contact`, `gender`, `password`) VALUES
('', '', '', '', '', ''),
('', '', '', '', '', ''),
('', '', '', '', '', ''),
('', '', '', '', '', ''),
('Emam Hossain', 'emam12', 'emam.tamim@gmail.com', '01880000000', 'Male', '#Emam@000#');

-- --------------------------------------------------------

--
-- Table structure for table `hotels`
--

CREATE TABLE `hotels` (
  `name` varchar(100) NOT NULL,
  `city` varchar(100) NOT NULL,
  `location` varchar(100) NOT NULL,
  `room` varchar(100) NOT NULL,
  `bed` varchar(10) NOT NULL,
  `cost` varchar(100) NOT NULL,
  `user` varchar(100) NOT NULL,
  `status` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `hotels`
--

INSERT INTO `hotels` (`name`, `city`, `location`, `room`, `bed`, `cost`, `user`, `status`) VALUES
('Dhaka Regency', 'Dhaka', 'Nikunjo-2,Khilkhet', '101', '2', '5000', 'emam12', 'Booked'),
('Dhaka Regency', 'Dhaka', 'Nikunjo-2,Khilkhet', '102', '2', '5000', '', 'Booked'),
('Peninsula', 'Chittagong', 'GEC', '201', '1', '6000', 'emam12', 'Booked'),
('Peninsula', 'Chittagong', 'GEC', '502', '1', '5000', 'emam12', '');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
