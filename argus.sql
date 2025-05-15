-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Apr 01, 2025 at 05:07 PM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `argus`
--

-- --------------------------------------------------------

--
-- Table structure for table `accounts`
--

CREATE TABLE `accounts` (
  `USERID` int(5) NOT NULL,
  `FIRSTNAME` varchar(20) NOT NULL,
  `LASTNAME` varchar(25) NOT NULL,
  `EMAIL` varchar(50) NOT NULL,
  `CONTACTNO` bigint(11) NOT NULL,
  `TELEPHONE` varchar(12) NOT NULL,
  `PASSWORD` varchar(35) NOT NULL,
  `REGION` varchar(50) NOT NULL,
  `CITY` varchar(50) NOT NULL,
  `ISADMIN` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `accounts`
--

INSERT INTO `accounts` (`USERID`, `FIRSTNAME`, `LASTNAME`, `EMAIL`, `CONTACTNO`, `TELEPHONE`, `PASSWORD`, `REGION`, `CITY`, `ISADMIN`) VALUES
(1, 'Emil Czander', 'Pura', 'emilczander7@gmail.com', 90000000000, 'N/A', 'cOMv0dTqZ+9o5zY2onxNNw==', 'NCR – National Capital Region', 'Quezon City', 1),
(2, 'Geriss', 'Lafuente', 'kalbo@gmail.com', 12789361293, 'N/A', 'XMIMgPGHn05jVxAlkplqgA==', 'BARMM – Bangsamoro Autonomous Region in Muslim Min', 'Sulu', 0),
(13, '111111111111', '111111111111', '111111111111@gmail.com', 11111111111, 'N/A', '2f/J9b+oUOpa3YkqJ0N7jQ==', 'Region X – Northern Mindanao', 'Cagayan de Oro', 0),
(14, '11111111111', '11111111111', '11111111@gmail.com', 11111111111, 'N/A', 'MG+MxVhhrv+gnxE4gKyAfA==', 'Region XIII – Caraga', 'Agusan del Norte', 0),
(15, 'aaaaaa', 'vvvvv', 'aa@gmail.com', 11111111111, 'N/A', 'MG+MxVhhrv+gnxE4gKyAfA==', 'Region X – Northern Mindanao', 'Misamis Oriental', 0),
(16, 'abc', 'def', 'abc@gmail.com', 11111111111, 'N/A', 'MG+MxVhhrv+gnxE4gKyAfA==', 'Region X – Northern Mindanao', 'Bukidnon', 0),
(17, 'Geriss', 'Lafuente', 'geriss@gmail.com', 9942823725, 'N/A', 'DTeAK9OCtzEBr0lV8snBcA==', 'Region XIII – Caraga', 'Agusan del Norte', 0);

-- --------------------------------------------------------

--
-- Table structure for table `inventory`
--

CREATE TABLE `inventory` (
  `PID` varchar(8) NOT NULL,
  `PNAME` varchar(50) NOT NULL,
  `ITEMPRICE` double(10,2) NOT NULL,
  `QTY` int(3) NOT NULL,
  `EXPIRY_DATE` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `inventory`
--

INSERT INTO `inventory` (`PID`, `PNAME`, `ITEMPRICE`, `QTY`, `EXPIRY_DATE`) VALUES
('2TH10F1S', 'COKE', 99.00, 51, '2057-07-28'),
('IM7LHTIZ', 'CHIPPY', 99.00, 53, '2025-04-04'),
('JCIR29FR', 'NOVA CHIPS', 99.00, 59, '2026-03-26'),
('W3XYYA8V', 'C2BLUE', 99.00, 61, '2025-04-24');

-- --------------------------------------------------------

--
-- Table structure for table `inventory_logs`
--

CREATE TABLE `inventory_logs` (
  `DATETIME` date NOT NULL,
  `PID` varchar(8) NOT NULL,
  `LOG` text NOT NULL,
  `FUNCTION` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `inventory_logs`
--

INSERT INTO `inventory_logs` (`DATETIME`, `PID`, `LOG`, `FUNCTION`) VALUES
('2024-12-07', 'F6D4H9PO', 'ITEM BLACK AND WHITE OVERSIZED BLOUSE HAS BEEN ADDED', 'INSERT'),
('2024-12-07', '0WYIW4GJ', 'ITEM *GRAY STAR Y2K BAGGY JEANS* HAS BEEN ADDED', 'INSERT'),
('2024-12-07', '9S4KQQET', 'ITEM *KHAKI SWEATPANTS* HAS BEEN UPDATED', 'UPDATE'),
('2024-12-07', 'YA9KGWK6', 'ITEM *-1* HAS BEEN DELETED', 'DELETE'),
('2024-12-07', 'BBBB1111', 'ITEM *BLACK_CARGO_SHORTS* HAS BEEN DELETED', 'DELETE'),
('2024-12-07', '5UPF4JT9', 'ITEM *RED CARDIGAN* HAS BEEN ADDED', 'INSERT'),
('2024-12-07', 'DW2O2KX9', 'ITEM *BLACK AND PINK GRAPHIC TSHIRT* HAS BEEN ADDED', 'INSERT'),
('2024-12-07', 'HD4P0F8P', 'ITEM WHITE BLOUSE HAS BEEN \r\n    DELETED', 'DELETE'),
('2024-12-08', 'GJIPGC8P', 'ITEM *GRAY SNEAKERS* HAS BEEN DELETED', 'DELETE'),
('2024-12-08', 'T4ORJE0W', 'ITEM BLACK BAGGY CARGOS HAS BEEN ADDED', 'INSERT'),
('2024-12-08', 'T4ORJE0W', 'ITEM *BLACK BAGGY CARGOS* HAS BEEN UPDATED', 'UPDATE'),
('2024-12-10', 'DW2O2KX9', 'ITEM *BLACK AND PINK GRAPHIC TSHIRT* HAS BEEN UPDATED', 'UPDATE'),
('2024-12-10', 'DW2O2KX9', 'ITEM *BLACK AND PINK GRAPHIC TSHIRT* HAS BEEN UPDATED', 'UPDATE'),
('2024-12-10', 'DW2O2KX9', 'ITEM *BLACK AND PINK GRAPHIC TSHIRT* HAS BEEN UPDATED', 'UPDATE'),
('2024-12-10', 'DW2O2KX9', 'ITEM *BLACK AND PINK GRAPHIC TSHIRT* HAS BEEN UPDATED', 'UPDATE'),
('2024-12-10', '5UPF4JT9', 'ITEM *RED CARDIGAN* HAS BEEN UPDATED', 'UPDATE'),
('2024-12-10', '5UPF4JT9', 'ITEM *RED CARDIGAN* HAS BEEN UPDATED', 'UPDATE'),
('2024-12-10', 'F01QO0CZ', 'ITEM *GRAY SWEATPANTS* HAS BEEN UPDATED', 'UPDATE'),
('2024-12-10', '5UPF4JT9', 'ITEM *RED CARDIGAN* HAS BEEN UPDATED', 'UPDATE'),
('2024-12-10', '5UPF4JT9', 'ITEM *RED CARDIGAN* HAS BEEN UPDATED', 'UPDATE'),
('2024-12-10', '5UPF4JT9', 'ITEM *RED CARDIGAN* HAS BEEN UPDATED', 'UPDATE'),
('2025-03-25', '5UPF4JT9', 'ITEM *RED CARDIGAN* HAS BEEN DELETED', 'DELETE'),
('2025-03-25', '9S4KQQET', 'ITEM *KHAKI SWEATPANTS* HAS BEEN DELETED', 'DELETE'),
('2025-03-25', 'DW2O2KX9', 'ITEM *BLACK AND PINK GRAPHIC TSHIRT* HAS BEEN DELETED', 'DELETE'),
('2025-03-25', 'F01QO0CZ', 'ITEM *GRAY SWEATPANTS* HAS BEEN DELETED', 'DELETE'),
('2025-03-25', 'F6D4H9PO', 'ITEM *BLACK AND WHITE OVERSIZED BLOUSE* HAS BEEN DELETED', 'DELETE'),
('2025-03-25', 'T4ORJE0W', 'ITEM *BLACK BAGGY CARGOS* HAS BEEN DELETED', 'DELETE');

-- --------------------------------------------------------

--
-- Table structure for table `item_transaction`
--

CREATE TABLE `item_transaction` (
  `TID` varchar(7) NOT NULL,
  `PID` varchar(8) NOT NULL,
  `ITEM` varchar(50) NOT NULL,
  `PRICE` decimal(6,2) NOT NULL,
  `DISC` char(7) NOT NULL,
  `TBILL` double(10,2) NOT NULL,
  `DATE` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `item_transaction`
--

INSERT INTO `item_transaction` (`TID`, `PID`, `ITEM`, `PRICE`, `DISC`, `TBILL`, `DATE`) VALUES
('', '', '', 0.00, '', 0.00, '0000-00-00'),
('TRX0001', 'PROD001', 'Red Cardigan', 655.25, '', 0.00, '2024-12-09'),
('TRX0002', 'PROD002', 'Khaki Sweatpants', 950.25, '', 0.00, '2024-12-08'),
('TRX0003', 'PROD003', 'Black and Pink Graphic T-Shirt', 987.55, '', 0.00, '2024-12-07'),
('TRX0004', 'PROD004', 'Gray Sweatpants', 4500.50, '', 0.00, '2024-12-06'),
('TRX0005', 'PROD005', 'Black Baggy Cargos', 654.00, '', 0.00, '2024-12-05'),
('TRX0006', 'PROD006', 'White Oversized Hoodie', 1200.99, '', 0.00, '2024-12-09'),
('TRX0007', 'PROD007', 'Navy Blue Jeans', 899.00, '', 0.00, '2024-12-08'),
('TRX0008', 'PROD008', 'Olive Green Jacket', 1500.75, '', 0.00, '2024-12-07'),
('TRX0009', 'PROD009', 'Black Leather Boots', 2500.00, '', 0.00, '2024-12-06'),
('TRX0010', 'PROD010', 'White Cotton Shirt', 350.50, '', 0.00, '2024-12-05');

-- --------------------------------------------------------

--
-- Table structure for table `pos_cart`
--

CREATE TABLE `pos_cart` (
  `TRANSACTIONID` varchar(7) NOT NULL,
  `PID` varchar(8) NOT NULL,
  `pname` varchar(150) NOT NULL,
  `quantity` int(3) NOT NULL,
  `price` decimal(4,2) NOT NULL,
  `total` decimal(6,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `accounts`
--
ALTER TABLE `accounts`
  ADD PRIMARY KEY (`USERID`);

--
-- Indexes for table `inventory`
--
ALTER TABLE `inventory`
  ADD PRIMARY KEY (`PID`);

--
-- Indexes for table `item_transaction`
--
ALTER TABLE `item_transaction`
  ADD PRIMARY KEY (`TID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `accounts`
--
ALTER TABLE `accounts`
  MODIFY `USERID` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=18;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
