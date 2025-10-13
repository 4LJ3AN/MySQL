-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Oct 13, 2025 at 01:56 PM
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
-- Database: `oopdb`
--

-- --------------------------------------------------------

--
-- Table structure for table `attendance`
--

CREATE TABLE `attendance` (
  `attendanceid` int(11) NOT NULL,
  `employeeid` varchar(255) NOT NULL,
  `date` date NOT NULL,
  `timein` datetime NOT NULL,
  `timeout` datetime NOT NULL,
  `totalhours` decimal(5,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `employees`
--

CREATE TABLE `employees` (
  `id` varchar(55) NOT NULL,
  `position` enum('Cashier','Stock Clerk','Department Manager','Custodian','Food Preparation Worker','Shopping Cart Attendant','Pharmacist','Front-End Manager','Produce Clerk','Meat and Seafood Clerk','Bakery Clerk') NOT NULL,
  `salary` decimal(10,2) NOT NULL,
  `fname` varchar(55) NOT NULL,
  `mname` varchar(55) DEFAULT NULL,
  `lname` varchar(55) NOT NULL,
  `bday` date NOT NULL,
  `gender` enum('Male','Female','I prefer not to say') NOT NULL,
  `contact` varchar(10) NOT NULL,
  `email` varchar(55) NOT NULL,
  `address` varchar(55) NOT NULL,
  `suffix` enum('Jr.','Sr.','II','III','IV','V','VI','VII','VIII','IX','X') DEFAULT NULL,
  `age` int(11) NOT NULL,
  `cstatus` enum('Single','Married','Widowed','Divorced') NOT NULL,
  `hourlyrate` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `employees`
--

INSERT INTO `employees` (`id`, `position`, `salary`, `fname`, `mname`, `lname`, `bday`, `gender`, `contact`, `email`, `address`, `suffix`, `age`, `cstatus`, `hourlyrate`) VALUES
('EM-0003', 'Pharmacist', 19000.00, 'Christian Angelo', 'Baloloy', 'Javier', '2005-11-27', 'I prefer not to say', '9158290121', 'octupussies1@gmail.com', '#2917 Bahay Ng Nigga Brgy 174 King Inamo St. Camarines ', NULL, 19, 'Married', 0),
('EM-0004', 'Department Manager', 15000.00, 'Aljean Mark', 'Agunos', 'Angeles', '2006-07-14', 'Male', '9382528152', 'aljeanangeles14@gmail.com', 'Phase 2 Package 3 Block 75 Lot Excess B.S.C.C.', NULL, 19, 'Single', 0),
('EM-0005', 'Bakery Clerk', 9000.00, 'Gian Carlo', 'Bengosta', 'Dela Torre', '2005-12-05', 'Male', '9278963306', 'galitsabisaya@gmail.com', '4775 Lanzones Street', NULL, 19, 'Married', 0),
('EM-0006', 'Shopping Cart Attendant', 1500.00, 'Karl Maverick', 'Bendo', 'Anonuevo', '2005-11-30', 'Male', '9434634679', 'galitsabayot@gmail.com', 'Somewhere In Kiko', NULL, 19, 'Single', 0),
('EM-0007', 'Stock Clerk', 78000.00, 'Sana', NULL, 'Minatozaki', '1996-12-29', 'Female', '9746745447', 'gfnialjean@gmail.com', 'Somewhere In Japan', NULL, 28, 'Married', 0),
('EM-0008', 'Cashier', 69.00, 'Kesh', NULL, 'Wednesday', '2003-11-13', 'Female', '9989134089', 'keshiw@outlook.com', 'Caloocan City Metro Manila', NULL, 21, 'Divorced', 0),
('EM-0009', 'Stock Clerk', 99999999.99, 'Goody', NULL, 'Adams', '1995-11-01', 'Female', '9991929399', 'goodygold@gmail.com', 'Nevermore Hhhhreirierjiejire Wednesday Addams', 'Sr.', 29, 'Widowed', 0);

-- --------------------------------------------------------

--
-- Table structure for table `payroll`
--

CREATE TABLE `payroll` (
  `payrollid` int(11) NOT NULL,
  `employeeid` varchar(255) NOT NULL,
  `periodstart` date NOT NULL,
  `periodend` date NOT NULL,
  `totalhours` decimal(8,2) NOT NULL,
  `hourlyrate` decimal(8,2) NOT NULL,
  `grosspay` decimal(10,2) NOT NULL,
  `deductions` decimal(10,2) NOT NULL,
  `netpay` decimal(10,2) NOT NULL,
  `timegenerated` datetime NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `attendance`
--
ALTER TABLE `attendance`
  ADD PRIMARY KEY (`attendanceid`),
  ADD UNIQUE KEY `1timein` (`employeeid`,`date`) USING BTREE,
  ADD KEY `employeeid` (`employeeid`) USING BTREE;

--
-- Indexes for table `employees`
--
ALTER TABLE `employees`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `payroll`
--
ALTER TABLE `payroll`
  ADD PRIMARY KEY (`payrollid`),
  ADD KEY `employeeidfk` (`employeeid`);

--
-- Constraints for dumped tables
--

--
-- Constraints for table `attendance`
--
ALTER TABLE `attendance`
  ADD CONSTRAINT `attendance_ibfk_1` FOREIGN KEY (`employeeid`) REFERENCES `employees` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `payroll`
--
ALTER TABLE `payroll`
  ADD CONSTRAINT `payroll_ibfk_1` FOREIGN KEY (`employeeid`) REFERENCES `employees` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
