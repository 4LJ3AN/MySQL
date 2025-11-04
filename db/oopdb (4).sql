-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Nov 04, 2025 at 04:42 PM
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
-- Table structure for table `admins`
--

CREATE TABLE `admins` (
  `admin_id` varchar(5) NOT NULL,
  `username` varchar(50) NOT NULL,
  `password` varchar(255) NOT NULL,
  `full_name` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `admins`
--

INSERT INTO `admins` (`admin_id`, `username`, `password`, `full_name`) VALUES
('AD-01', 'admin', 'password123', 'System Administrator');

-- --------------------------------------------------------

--
-- Table structure for table `attendance`
--

CREATE TABLE `attendance` (
  `attendanceid` int(11) NOT NULL,
  `employeeid` varchar(255) NOT NULL,
  `date` date NOT NULL,
  `timein` datetime NOT NULL,
  `timeout` datetime DEFAULT NULL,
  `totalhours` decimal(5,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `attendance`
--

INSERT INTO `attendance` (`attendanceid`, `employeeid`, `date`, `timein`, `timeout`, `totalhours`) VALUES
(2, 'EM-0003', '2025-10-30', '2025-10-30 16:52:58', NULL, NULL),
(3, 'EM-0004', '2025-10-30', '2025-10-30 17:13:48', '2025-10-30 17:41:50', 0.47),
(5, 'EM-0004', '2025-11-03', '2025-11-03 13:07:32', '2025-11-03 17:38:02', 4.51),
(6, 'EM-0003', '2025-11-03', '2025-11-03 13:39:19', NULL, NULL),
(7, 'EM-0004', '2025-11-04', '2025-11-04 07:52:04', '2025-11-04 17:52:04', 10.00),
(8, 'EM-0004', '2025-09-15', '2025-09-15 08:00:00', '2025-09-15 17:00:00', 8.00),
(9, 'EM-0004', '2025-09-16', '2025-09-16 08:10:00', '2025-09-16 17:15:00', 8.10),
(10, 'EM-0004', '2025-09-17', '2025-09-17 08:05:00', '2025-09-17 18:00:00', 9.00),
(11, 'EM-0004', '2025-09-18', '2025-09-18 08:00:00', '2025-09-18 17:00:00', 8.00),
(12, 'EM-0004', '2025-09-19', '2025-09-19 08:00:00', '2025-09-19 19:00:00', 10.00),
(13, 'EM-0004', '2025-09-22', '2025-09-22 08:05:00', '2025-09-22 17:05:00', 8.00),
(14, 'EM-0004', '2025-09-23', '2025-09-23 08:00:00', '2025-09-23 17:30:00', 8.50),
(15, 'EM-0004', '2025-09-24', '2025-09-24 08:00:00', '2025-09-24 18:00:00', 9.00),
(16, 'EM-0004', '2025-09-25', '2025-09-25 08:10:00', '2025-09-25 17:10:00', 8.00),
(17, 'EM-0004', '2025-09-26', '2025-09-26 08:00:00', '2025-09-26 19:00:00', 10.00),
(18, 'EM-0004', '2025-09-29', '2025-09-29 08:00:00', '2025-09-29 17:00:00', 8.00),
(19, 'EM-0004', '2025-09-30', '2025-09-30 08:00:00', '2025-09-30 17:45:00', 8.75),
(20, 'EM-0004', '2025-10-01', '2025-10-01 08:00:00', '2025-10-01 17:00:00', 8.00),
(21, 'EM-0004', '2025-10-02', '2025-10-02 08:15:00', '2025-10-02 17:15:00', 8.00),
(22, 'EM-0004', '2025-10-03', '2025-10-03 08:00:00', '2025-10-03 19:00:00', 10.00),
(23, 'EM-0004', '2025-10-06', '2025-10-06 08:00:00', '2025-10-06 17:00:00', 8.00),
(24, 'EM-0004', '2025-10-07', '2025-10-07 08:00:00', '2025-10-07 17:30:00', 8.50),
(25, 'EM-0004', '2025-10-08', '2025-10-08 08:00:00', '2025-10-08 17:00:00', 8.00),
(26, 'EM-0004', '2025-10-09', '2025-10-09 08:10:00', '2025-10-09 17:15:00', 8.00),
(27, 'EM-0004', '2025-10-10', '2025-10-10 08:00:00', '2025-10-10 18:00:00', 9.00),
(28, 'EM-0004', '2025-10-13', '2025-10-13 08:00:00', '2025-10-13 17:00:00', 8.00),
(29, 'EM-0004', '2025-10-14', '2025-10-14 08:00:00', '2025-10-14 19:00:00', 10.00),
(30, 'EM-0004', '2025-10-15', '2025-10-15 08:00:00', '2025-10-15 17:00:00', 8.00),
(80, 'EM-0005', '2025-10-15', '2025-10-15 08:00:00', '2025-10-15 17:00:00', 9.00),
(81, 'EM-0005', '2025-10-16', '2025-10-16 08:15:00', '2025-10-16 17:15:00', 9.00),
(82, 'EM-0005', '2025-10-17', '2025-10-17 08:00:00', '2025-10-17 17:00:00', 9.00),
(83, 'EM-0005', '2025-10-18', '2025-10-18 08:30:00', '2025-10-18 16:30:00', 8.00),
(84, 'EM-0005', '2025-10-20', '2025-10-20 08:00:00', '2025-10-20 17:00:00', 9.00),
(85, 'EM-0005', '2025-10-21', '2025-10-21 08:00:00', '2025-10-21 18:00:00', 10.00),
(86, 'EM-0005', '2025-10-22', '2025-10-22 08:15:00', '2025-10-22 17:15:00', 9.00),
(87, 'EM-0005', '2025-10-23', '2025-10-23 08:00:00', '2025-10-23 17:00:00', 9.00),
(88, 'EM-0005', '2025-10-25', '2025-10-25 08:00:00', '2025-10-25 17:30:00', 9.50),
(89, 'EM-0005', '2025-10-27', '2025-10-27 08:00:00', '2025-10-27 17:00:00', 9.00),
(90, 'EM-0005', '2025-10-28', '2025-10-28 08:30:00', '2025-10-28 17:30:00', 9.00),
(91, 'EM-0005', '2025-10-29', '2025-10-29 08:00:00', '2025-10-29 19:00:00', 11.00),
(92, 'EM-0005', '2025-10-30', '2025-10-30 08:00:00', '2025-10-30 17:00:00', 9.00),
(93, 'EM-0005', '2025-10-31', '2025-10-31 08:15:00', '2025-10-31 17:15:00', 9.00),
(94, 'EM-0005', '2025-11-01', '2025-11-01 08:30:00', '2025-11-01 16:30:00', 8.00),
(95, 'EM-0005', '2025-11-03', '2025-11-03 08:00:00', '2025-11-03 17:00:00', 9.00),
(96, 'EM-0005', '2025-11-04', '2025-11-04 08:00:00', '2025-11-04 18:30:00', 10.50),
(97, 'EM-0005', '2025-11-05', '2025-11-05 08:15:00', '2025-11-05 17:15:00', 9.00),
(98, 'EM-0005', '2025-11-06', '2025-11-06 08:00:00', '2025-11-06 17:00:00', 9.00),
(99, 'EM-0005', '2025-11-07', '2025-11-07 08:00:00', '2025-11-07 19:00:00', 11.00),
(100, 'EM-0005', '2025-11-08', '2025-11-08 08:30:00', '2025-11-08 16:30:00', 8.00),
(101, 'EM-0005', '2025-11-10', '2025-11-10 08:00:00', '2025-11-10 17:00:00', 9.00),
(102, 'EM-0005', '2025-11-11', '2025-11-11 08:00:00', '2025-11-11 17:00:00', 9.00),
(103, 'EM-0005', '2025-11-12', '2025-11-12 08:15:00', '2025-11-12 17:15:00', 9.00),
(104, 'EM-0005', '2025-11-13', '2025-11-13 08:00:00', '2025-11-13 18:00:00', 10.00),
(105, 'EM-0005', '2025-11-14', '2025-11-14 08:00:00', '2025-11-14 17:00:00', 9.00);

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
  `hourlyrate` decimal(10,2) NOT NULL,
  `password` varchar(55) NOT NULL,
  `deleted` tinyint(1) NOT NULL DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `employees`
--

INSERT INTO `employees` (`id`, `position`, `salary`, `fname`, `mname`, `lname`, `bday`, `gender`, `contact`, `email`, `address`, `suffix`, `age`, `cstatus`, `hourlyrate`, `password`, `deleted`) VALUES
('EM-0003', 'Pharmacist', 19000.00, 'Christian Angelo', 'Baloloy', 'Javier', '2005-11-27', 'I prefer not to say', '9158290121', 'octupussies1@gmail.com', '#2917 Bahay Ng Nigga Brgy 174 King Inamo St. Camarines ', NULL, 19, 'Married', 200.00, '12345678', 0),
('EM-0004', 'Department Manager', 15000.00, 'Aljean Mark', 'Agunos', 'Angeles', '2006-07-14', 'I prefer not to say', '9123423213', 'aljeanangeles14@gmail.com', 'Phase 2 Package 3 Block 75 Lot Excess B.S.C.C.', NULL, 19, 'Divorced', 150.00, 'shabusagilid', 0),
('EM-0005', 'Bakery Clerk', 9000.00, 'Gian Carlo', 'Bengosta', 'Dela Torre', '2005-12-05', 'Male', '9278963306', 'galitsabisaya@gmail.com', '4775 Lanzones Street', NULL, 19, 'Married', 105.00, '12345678', 0),
('EM-0006', 'Shopping Cart Attendant', 1500.00, 'Karl Maverick', 'Bendo', 'Anonuevo', '2005-11-30', 'Male', '9434634679', 'galitsabayot@gmail.com', 'Somewhere In Kiko', NULL, 19, 'Single', 80.00, '12345678', 0),
('EM-0007', 'Stock Clerk', 78000.00, 'Sana', NULL, 'Minatozaki', '1996-12-29', 'Female', '9746745447', 'gfnialjean@gmail.com', 'Somewhere In Japan', NULL, 28, 'Married', 95.00, '12345678', 0),
('EM-0008', 'Cashier', 69.00, 'Kesh', NULL, 'Wednesday', '2003-11-13', 'Female', '9989134089', 'keshiw@outlook.com', 'Caloocan City Metro Manila', NULL, 21, 'Divorced', 100.00, '12345678', 0),
('EM-0009', 'Stock Clerk', 99999999.99, 'Goody', NULL, 'Adams', '1995-11-01', 'Female', '9991929399', 'goodygold@gmail.com', 'Nevermore Hhhhreirierjiejire Wednesday Addams', 'Sr.', 29, 'Widowed', 95.00, '12345678', 0);

-- --------------------------------------------------------

--
-- Table structure for table `payslips`
--

CREATE TABLE `payslips` (
  `payslip_id` int(11) NOT NULL,
  `employeeid` varchar(255) NOT NULL,
  `gross_pay` decimal(10,2) NOT NULL,
  `net_pay` decimal(10,2) NOT NULL,
  `generated_on` datetime DEFAULT current_timestamp(),
  `period_start` date NOT NULL,
  `period_end` date NOT NULL,
  `basic_hours` decimal(10,2) NOT NULL,
  `ot_hours` decimal(10,2) NOT NULL,
  `income_tax` decimal(10,2) NOT NULL,
  `sss` decimal(10,2) NOT NULL,
  `pagibig` decimal(10,2) NOT NULL,
  `total_deductions` decimal(10,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `payslips`
--

INSERT INTO `payslips` (`payslip_id`, `employeeid`, `gross_pay`, `net_pay`, `generated_on`, `period_start`, `period_end`, `basic_hours`, `ot_hours`, `income_tax`, `sss`, `pagibig`, `total_deductions`) VALUES
(1, 'EM-0004', 28809.38, 25064.16, '2025-11-04 15:18:27', '2025-09-15', '2025-10-14', 176.00, 12.85, 2880.94, 576.19, 288.09, 3745.22),
(2, 'EM-0003', 1200.00, 1044.00, '2025-11-04 19:46:22', '2024-09-15', '2024-10-14', 6.00, 0.00, 120.00, 24.00, 12.00, 156.00),
(3, 'EM-0004', 2251.50, 1958.80, '2025-11-04 19:46:22', '2024-09-15', '2024-10-14', 12.51, 2.00, 225.15, 45.03, 22.52, 292.70),
(5, 'EM-0006', 0.00, 0.00, '2025-11-04 19:46:22', '2024-09-15', '2024-10-14', 0.00, 0.00, 0.00, 0.00, 0.00, 0.00),
(6, 'EM-0007', 0.00, 0.00, '2025-11-04 19:46:22', '2024-09-15', '2024-10-14', 0.00, 0.00, 0.00, 0.00, 0.00, 0.00),
(7, 'EM-0008', 0.00, 0.00, '2025-11-04 19:46:22', '2024-09-15', '2024-10-14', 0.00, 0.00, 0.00, 0.00, 0.00, 0.00),
(8, 'EM-0009', 0.00, 0.00, '2025-11-04 19:46:22', '2024-09-15', '2024-10-14', 0.00, 0.00, 0.00, 0.00, 0.00, 0.00),
(16, 'EM-0003', 2400.00, 2088.00, '2025-11-04 20:12:12', '2025-10-15', '2025-11-14', 12.00, 0.00, 240.00, 48.00, 24.00, 312.00),
(17, 'EM-0004', 3522.00, 3064.14, '2025-11-04 20:12:12', '2025-10-15', '2025-11-14', 20.98, 2.00, 352.20, 70.44, 35.22, 457.86),
(19, 'EM-0006', 0.00, 0.00, '2025-11-04 20:12:12', '2025-10-15', '2025-11-14', 0.00, 0.00, 0.00, 0.00, 0.00, 0.00),
(20, 'EM-0007', 0.00, 0.00, '2025-11-04 20:12:12', '2025-10-15', '2025-11-14', 0.00, 0.00, 0.00, 0.00, 0.00, 0.00),
(21, 'EM-0008', 0.00, 0.00, '2025-11-04 20:12:12', '2025-10-15', '2025-11-14', 0.00, 0.00, 0.00, 0.00, 0.00, 0.00),
(22, 'EM-0009', 0.00, 0.00, '2025-11-04 20:12:12', '2025-10-15', '2025-11-14', 0.00, 0.00, 0.00, 0.00, 0.00, 0.00),
(25, 'EM-0005', 25908.75, 22540.61, '2025-11-04 20:38:55', '2025-10-15', '2025-11-14', 208.00, 31.00, 2590.88, 518.18, 259.09, 3368.14);

-- --------------------------------------------------------

--
-- Table structure for table `position_rates`
--

CREATE TABLE `position_rates` (
  `position` enum('Cashier','Stock Clerk','Department Manager','Custodian','Food Preparation Worker','Shopping Cart Attendant','Pharmacist','Front-End Manager','Produce Clerk','Meat and Seafood Clerk','Bakery Clerk') NOT NULL,
  `hourly_rate` decimal(8,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `position_rates`
--

INSERT INTO `position_rates` (`position`, `hourly_rate`) VALUES
('Cashier', 100.00),
('Stock Clerk', 95.00),
('Department Manager', 150.00),
('Custodian', 85.00),
('Food Preparation Worker', 90.00),
('Shopping Cart Attendant', 80.00),
('Pharmacist', 200.00),
('Front-End Manager', 160.00),
('Produce Clerk', 100.00),
('Meat and Seafood Clerk', 110.00),
('Bakery Clerk', 105.00);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `admins`
--
ALTER TABLE `admins`
  ADD PRIMARY KEY (`admin_id`),
  ADD UNIQUE KEY `username` (`username`);

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
-- Indexes for table `payslips`
--
ALTER TABLE `payslips`
  ADD PRIMARY KEY (`payslip_id`),
  ADD KEY `employeeid` (`employeeid`);

--
-- Indexes for table `position_rates`
--
ALTER TABLE `position_rates`
  ADD PRIMARY KEY (`position`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `attendance`
--
ALTER TABLE `attendance`
  MODIFY `attendanceid` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=106;

--
-- AUTO_INCREMENT for table `payslips`
--
ALTER TABLE `payslips`
  MODIFY `payslip_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=26;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `attendance`
--
ALTER TABLE `attendance`
  ADD CONSTRAINT `attendance_ibfk_1` FOREIGN KEY (`employeeid`) REFERENCES `employees` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `payslips`
--
ALTER TABLE `payslips`
  ADD CONSTRAINT `payslips_ibfk_1` FOREIGN KEY (`employeeid`) REFERENCES `employees` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
