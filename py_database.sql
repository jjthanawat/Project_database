-- phpMyAdmin SQL Dump
-- version 4.9.1
-- https://www.phpmyadmin.net/
--
-- Host: localhost
-- Generation Time: Apr 27, 2020 at 06:54 AM
-- Server version: 8.0.17
-- PHP Version: 7.3.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `py_database`
--

-- --------------------------------------------------------

--
-- Table structure for table `customers`
--

CREATE TABLE `customers` (
  `CustomerID` int(11) NOT NULL,
  `CustomerName` varchar(100) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  `Gender` enum('M','F') CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  `CustomerType` enum('Member','VIP','Other') CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  `CustomerTelNo` varchar(100) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  `customers_points` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `customers`
--

INSERT INTO `customers` (`CustomerID`, `CustomerName`, `Gender`, `CustomerType`, `CustomerTelNo`, `customers_points`) VALUES
(10, '33333333333', '', 'Member', '', 0),
(11, '33333333333', 'M', 'Member', 'ชาย', 0),
(12, 'admin_j', 'M', 'VIP', '0000', 176);

-- --------------------------------------------------------

--
-- Table structure for table `products`
--

CREATE TABLE `products` (
  `ProductID` int(11) NOT NULL,
  `ProductName` varchar(100) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  `Price` float NOT NULL,
  `ProductDetail` text CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `products`
--

INSERT INTO `products` (`ProductID`, `ProductName`, `Price`, `ProductDetail`) VALUES
(8, 'แบล็คคอฟฟี่น้ำผึ้งมะนาว ', 65, ''),
(9, 'คาปูชิโน', 40, ''),
(10, 'ลาเต้', 40, ''),
(11, 'มอคค่า', 45, ''),
(12, 'ไวท์ ช็อก', 50, '');

-- --------------------------------------------------------

--
-- Table structure for table `sales`
--

CREATE TABLE `sales` (
  `SaleID` int(11) NOT NULL,
  `SaleDateTime` datetime NOT NULL,
  `CustomerID` int(11) NOT NULL,
  `StaffID` int(11) NOT NULL,
  `GrandTotal` float NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `sales`
--

INSERT INTO `sales` (`SaleID`, `SaleDateTime`, `CustomerID`, `StaffID`, `GrandTotal`) VALUES
(16, '0000-00-00 00:00:00', 12, 0, 2),
(17, '0000-00-00 00:00:00', 0, 0, 0),
(18, '2020-04-21 16:18:35', 12, 1, 2),
(19, '2020-04-21 16:19:18', 12, 1, 2),
(20, '2020-04-21 16:20:06', 12, 1, 2),
(21, '2020-04-21 16:28:30', 1, 0, 2),
(22, '2020-04-21 16:35:15', 1, 0, 4),
(23, '2020-04-21 16:37:37', 1, 0, 3),
(24, '2020-04-21 16:37:43', 1, 0, 3),
(25, '2020-04-21 16:39:39', 1, 0, 2),
(26, '2020-04-21 16:54:55', 1, 1, 4),
(27, '2020-04-21 16:54:58', 1, 1, 4),
(28, '2020-04-21 16:55:30', 1, 1, 3),
(29, '2020-04-21 16:58:09', 1, 1, 3),
(30, '2020-04-21 17:01:28', 1, 1, 3),
(31, '2020-04-21 17:03:05', 12, 1, 32),
(32, '2020-04-22 09:16:43', 1, 1, 7),
(33, '2020-04-22 15:28:45', 1, 1, 4),
(34, '2020-04-22 15:30:32', 1, 1, 2),
(35, '2020-04-22 17:09:46', 1, 1, 3),
(36, '2020-04-24 12:48:41', 1, 1, 3),
(37, '2020-04-25 10:17:34', 12, 1, 44),
(38, '2020-04-25 10:18:04', 12, 1, 2),
(39, '2020-04-26 20:02:02', 1, 1, 4),
(40, '2020-04-26 20:03:45', 1, 1, 1),
(41, '2020-04-26 20:03:57', 1, 1, 1),
(42, '2020-04-26 20:04:02', 1, 1, 3),
(43, '2020-04-26 20:04:07', 1, 1, 4),
(44, '2020-04-27 12:57:39', 1, 1, 2),
(45, '2020-04-27 13:06:52', 1, 1, 2);

-- --------------------------------------------------------

--
-- Table structure for table `sale_details`
--

CREATE TABLE `sale_details` (
  `SaleDetailID` int(11) NOT NULL,
  `SaleID` int(11) NOT NULL,
  `ProductID` int(11) NOT NULL,
  `Price` float NOT NULL,
  `Quantity` int(11) NOT NULL,
  `Amount` float NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `sale_details`
--

INSERT INTO `sale_details` (`SaleDetailID`, `SaleID`, `ProductID`, `Price`, `Quantity`, `Amount`) VALUES
(3, 16, 7, 60, 1, 1),
(4, 16, 11, 45, 1, 1),
(5, 18, 6, 50, 1, 1),
(6, 18, 9, 40, 1, 1),
(7, 18, 6, 50, 1, 1),
(8, 18, 9, 40, 1, 1),
(9, 18, 9, 40, 1, 1),
(10, 18, 6, 50, 1, 1),
(11, 4, 7, 60, 1, 1),
(12, 4, 7, 60, 1, 1),
(13, 22, 6, 50, 1, 1),
(14, 22, 6, 50, 1, 1),
(15, 22, 6, 50, 1, 1),
(16, 22, 6, 50, 1, 1),
(17, 23, 6, 50, 1, 1),
(18, 23, 6, 50, 1, 1),
(19, 23, 6, 50, 1, 1),
(20, 23, 6, 50, 1, 1),
(21, 23, 6, 50, 1, 1),
(22, 23, 6, 50, 1, 1),
(23, 4, 7, 60, 1, 1),
(24, 4, 7, 60, 1, 1),
(25, 26, 6, 50, 1, 1),
(26, 26, 6, 50, 1, 1),
(27, 26, 6, 50, 1, 1),
(28, 26, 6, 50, 1, 1),
(29, 26, 6, 50, 1, 1),
(30, 26, 6, 50, 1, 1),
(31, 26, 6, 50, 1, 1),
(32, 26, 6, 50, 1, 1),
(33, 8, 6, 50, 1, 1),
(34, 8, 6, 50, 1, 1),
(35, 8, 6, 50, 1, 1),
(36, 8, 6, 50, 1, 1),
(37, 8, 6, 50, 1, 1),
(38, 8, 6, 50, 1, 1),
(39, 8, 7, 60, 1, 1),
(40, 8, 7, 60, 1, 1),
(41, 8, 7, 60, 1, 1),
(42, 31, 6, 50, 1, 1),
(43, 31, 6, 50, 1, 1),
(44, 31, 6, 50, 1, 1),
(45, 31, 6, 50, 1, 1),
(46, 31, 6, 50, 1, 1),
(47, 31, 6, 50, 1, 1),
(48, 31, 6, 50, 1, 1),
(49, 31, 6, 50, 1, 1),
(50, 31, 6, 50, 1, 1),
(51, 31, 6, 50, 1, 1),
(52, 31, 6, 50, 1, 1),
(53, 31, 6, 50, 1, 1),
(54, 31, 6, 50, 1, 1),
(55, 31, 6, 50, 1, 1),
(56, 31, 6, 50, 1, 1),
(57, 31, 6, 50, 1, 1),
(58, 31, 6, 50, 1, 1),
(59, 31, 6, 50, 1, 1),
(60, 31, 6, 50, 1, 1),
(61, 31, 6, 50, 1, 1),
(62, 31, 6, 50, 1, 1),
(63, 31, 6, 50, 1, 1),
(64, 31, 6, 50, 1, 1),
(65, 31, 6, 50, 1, 1),
(66, 31, 6, 50, 1, 1),
(67, 31, 6, 50, 1, 1),
(68, 31, 6, 50, 1, 1),
(69, 31, 6, 50, 1, 1),
(70, 31, 6, 50, 1, 1),
(71, 31, 6, 50, 1, 1),
(72, 31, 6, 50, 1, 1),
(73, 31, 6, 50, 1, 1),
(74, 32, 6, 50, 1, 1),
(75, 32, 7, 60, 1, 1),
(76, 32, 8, 65, 1, 1),
(77, 32, 9, 40, 1, 1),
(78, 32, 10, 40, 1, 1),
(79, 32, 11, 45, 1, 1),
(80, 32, 12, 50, 1, 1),
(81, 26, 6, 50, 1, 1),
(82, 26, 6, 50, 1, 1),
(83, 26, 6, 50, 1, 1),
(84, 26, 6, 50, 1, 1),
(85, 6, 6, 50, 1, 1),
(86, 6, 6, 50, 1, 1),
(87, 8, 6, 50, 1, 1),
(88, 8, 8, 65, 1, 1),
(89, 8, 10, 40, 1, 1),
(90, 8, 6, 50, 1, 1),
(91, 8, 9, 40, 1, 1),
(92, 8, 7, 60, 1, 1),
(93, 37, 7, 60, 1, 1),
(94, 37, 7, 60, 1, 1),
(95, 37, 7, 60, 1, 1),
(96, 37, 7, 60, 1, 1),
(97, 37, 7, 60, 1, 1),
(98, 37, 7, 60, 1, 1),
(99, 37, 7, 60, 1, 1),
(100, 37, 7, 60, 1, 1),
(101, 37, 7, 60, 1, 1),
(102, 37, 7, 60, 1, 1),
(103, 37, 7, 60, 1, 1),
(104, 37, 7, 60, 1, 1),
(105, 37, 7, 60, 1, 1),
(106, 37, 7, 60, 1, 1),
(107, 37, 7, 60, 1, 1),
(108, 37, 7, 60, 1, 1),
(109, 37, 7, 60, 1, 1),
(110, 37, 7, 60, 1, 1),
(111, 37, 7, 60, 1, 1),
(112, 37, 7, 60, 1, 1),
(113, 37, 7, 60, 1, 1),
(114, 37, 7, 60, 1, 1),
(115, 37, 7, 60, 1, 1),
(116, 37, 7, 60, 1, 1),
(117, 37, 7, 60, 1, 1),
(118, 37, 7, 60, 1, 1),
(119, 37, 7, 60, 1, 1),
(120, 37, 7, 60, 1, 1),
(121, 37, 7, 60, 1, 1),
(122, 37, 7, 60, 1, 1),
(123, 37, 7, 60, 1, 1),
(124, 37, 7, 60, 1, 1),
(125, 37, 7, 60, 1, 1),
(126, 37, 7, 60, 1, 1),
(127, 37, 7, 60, 1, 1),
(128, 37, 7, 60, 1, 1),
(129, 37, 7, 60, 1, 1),
(130, 37, 7, 60, 1, 1),
(131, 37, 7, 60, 1, 1),
(132, 37, 7, 60, 1, 1),
(133, 37, 7, 60, 1, 1),
(134, 37, 7, 60, 1, 1),
(135, 37, 7, 60, 1, 1),
(136, 37, 7, 60, 1, 1),
(137, 18, 6, 50, 1, 1),
(138, 18, 6, 50, 1, 1),
(139, 26, 6, 50, 1, 1),
(140, 26, 7, 60, 1, 1),
(141, 26, 8, 65, 1, 1),
(142, 26, 9, 40, 1, 1),
(143, 40, 6, 50, 1, 1),
(144, 40, 6, 50, 1, 1),
(145, 28, 6, 50, 1, 1),
(146, 28, 9, 40, 1, 1),
(147, 28, 9, 40, 1, 1),
(148, 26, 6, 50, 1, 1),
(149, 26, 9, 40, 1, 1),
(150, 26, 9, 40, 1, 1),
(151, 26, 6, 50, 1, 1),
(152, 34, 6, 50, 1, 1),
(153, 34, 6, 50, 1, 1),
(154, 34, 6, 50, 1, 1),
(155, 34, 8, 65, 1, 1);

-- --------------------------------------------------------

--
-- Table structure for table `staffs`
--

CREATE TABLE `staffs` (
  `StaffID` int(11) NOT NULL,
  `StaffCode` varchar(20) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  `StaffName` varchar(100) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  `Gender` enum('M','F') CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  `StaffPassword` varchar(100) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  `StaffLevel` enum('Staff','Manager','Admin') CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `staffs`
--

INSERT INTO `staffs` (`StaffID`, `StaffCode`, `StaffName`, `Gender`, `StaffPassword`, `StaffLevel`) VALUES
(1, 'admin_j', 'admin_j', 'M', '0000', 'Admin');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `customers`
--
ALTER TABLE `customers`
  ADD PRIMARY KEY (`CustomerID`);

--
-- Indexes for table `products`
--
ALTER TABLE `products`
  ADD PRIMARY KEY (`ProductID`);

--
-- Indexes for table `sales`
--
ALTER TABLE `sales`
  ADD PRIMARY KEY (`SaleID`);

--
-- Indexes for table `sale_details`
--
ALTER TABLE `sale_details`
  ADD PRIMARY KEY (`SaleDetailID`);

--
-- Indexes for table `staffs`
--
ALTER TABLE `staffs`
  ADD PRIMARY KEY (`StaffID`),
  ADD UNIQUE KEY `StaffCode` (`StaffCode`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `customers`
--
ALTER TABLE `customers`
  MODIFY `CustomerID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;

--
-- AUTO_INCREMENT for table `products`
--
ALTER TABLE `products`
  MODIFY `ProductID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=22;

--
-- AUTO_INCREMENT for table `sales`
--
ALTER TABLE `sales`
  MODIFY `SaleID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=46;

--
-- AUTO_INCREMENT for table `sale_details`
--
ALTER TABLE `sale_details`
  MODIFY `SaleDetailID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=156;

--
-- AUTO_INCREMENT for table `staffs`
--
ALTER TABLE `staffs`
  MODIFY `StaffID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
