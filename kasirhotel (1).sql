-- phpMyAdmin SQL Dump
-- version 4.9.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Apr 14, 2020 at 07:44 PM
-- Server version: 10.4.10-MariaDB
-- PHP Version: 7.1.33

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `kasirhotel`
--

-- --------------------------------------------------------

--
-- Table structure for table `reservation`
--

CREATE TABLE `reservation` (
  `id` int(11) NOT NULL,
  `name` varchar(50) NOT NULL,
  `phone` varchar(50) NOT NULL,
  `address` varchar(100) NOT NULL,
  `room` varchar(50) NOT NULL,
  `checkin` datetime NOT NULL,
  `checkout` datetime NOT NULL,
  `deposit` int(11) NOT NULL,
  `price` int(11) DEFAULT 0,
  `status` varchar(11) NOT NULL DEFAULT 'booked'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `reservation`
--

INSERT INTO `reservation` (`id`, `name`, `phone`, `address`, `room`, `checkin`, `checkout`, `deposit`, `price`, `status`) VALUES
(1, 'I Putu Aris Sanjaya', '087762804369', 'Jalan Batu Bidak Residence', '01', '2019-12-28 20:28:41', '2019-12-30 20:28:41', 1000000, 1000000, 'finished'),
(4, 'anak baru', '082377232', 'di rumah', '01', '2019-12-28 22:13:34', '2019-12-31 22:13:34', 1500000, 0, 'booked'),
(5, 'room 2', '023023232', 'oke', '02', '2019-12-28 22:52:07', '2019-12-29 22:52:07', 500000, 0, 'booked'),
(6, 'room 4', '023023232', 'oke', '04', '2019-12-28 22:52:07', '2019-12-29 22:52:07', 500000, 0, 'booked'),
(7, 'room 5', '023023232', 'oke', '05', '2019-12-28 22:52:07', '2019-12-29 22:52:07', 500000, 0, 'booked'),
(8, 'room 6', '08232732323', 'oke', '06', '2019-12-28 22:57:01', '2019-12-30 22:57:01', 1000000, 0, 'booked'),
(9, 'room 7', '082347237432', 'dimana', '07', '2019-12-28 23:01:15', '2019-12-31 23:01:15', 1500000, 0, 'booked'),
(10, 'room 8', '0823882323232', 'disana kayaknya', '08', '2019-12-28 23:02:23', '2019-12-29 23:02:23', 500000, 0, 'booked'),
(11, 'room 9', '08283742374', 'di rumah', '09', '2019-12-28 23:03:48', '2019-12-29 23:03:48', 0, 500000, 'finished'),
(12, 'room 10', '08238928392', 'di atas tanah', '10', '2019-12-28 23:04:47', '2020-01-01 23:04:47', 2000000, 0, 'booked'),
(13, 'room 11', '02372387283', 'di dididii', '11', '2019-12-28 23:05:47', '2019-12-29 23:05:47', 0, 500000, 'finished'),
(14, 'room 12', '08213273744', 'di situ', '12', '2019-12-28 23:07:17', '2019-12-29 23:07:17', 0, 500000, 'finished'),
(15, 'room 13', '0823747327423', 'besok yaa', '13', '2019-12-29 23:21:28', '2019-12-30 23:21:28', 500000, 0, 'booked'),
(16, 'room 14', '0823462342', 'di atas kasur', '14', '2019-12-28 23:51:18', '2019-12-29 23:51:18', 500000, 0, 'booked'),
(17, 'room 15', '02834827384', 'disisniii', '15', '2019-12-29 23:51:39', '2019-12-30 23:51:39', 500000, 0, 'booked'),
(18, 'room 16', '09182371827', 'oke siap', '16', '2019-12-30 23:52:15', '2020-01-01 23:52:15', 1000000, 0, 'booked'),
(19, 'room 17', '08723472323', 'dimana yaa', '17', '2019-12-28 23:52:34', '2019-12-29 23:52:34', 500000, 500000, 'finished'),
(20, 'room 18', '083273234234', 'kelas ding', '18', '2019-12-28 23:52:55', '2020-01-03 23:52:55', 3000000, 0, 'booked'),
(21, 'room 19', '086723674623', 'disiapappapp', '20', '2019-12-28 23:58:31', '2019-12-30 23:58:31', 500000, 1000000, 'finished'),
(22, 'room 20', '0182371273', 'werawerwef', '20', '2020-01-01 23:58:55', '2020-01-02 23:58:55', 500000, 0, 'booked'),
(23, 'last input', '08111818181', '@home', '03', '2019-12-30 01:02:33', '2020-01-03 01:02:33', 2500000, 2000000, 'finished'),
(24, 'danu', '0871717171711', 'stikom', '11', '2020-01-07 12:03:02', '2020-01-11 12:03:02', 500000, 2000000, 'finished');

-- --------------------------------------------------------

--
-- Table structure for table `room`
--

CREATE TABLE `room` (
  `no` int(11) NOT NULL,
  `room` varchar(11) NOT NULL,
  `id_rsv` varchar(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `room`
--

INSERT INTO `room` (`no`, `room`, `id_rsv`) VALUES
(1, '01', '4'),
(2, '02', '5'),
(3, '03', ''),
(4, '04', '6'),
(5, '05', '7'),
(6, '06', '8'),
(7, '07', '9'),
(8, '08', '10'),
(9, '09', ''),
(10, '10', '12'),
(11, '11', ''),
(12, '12', ''),
(13, '13', '15'),
(14, '14', '16'),
(15, '15', '17'),
(16, '16', '18'),
(17, '17', ''),
(18, '18', '20'),
(19, '19', ''),
(20, '20', '21');

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `id` int(11) NOT NULL,
  `username` varchar(50) NOT NULL,
  `password` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`id`, `username`, `password`) VALUES
(1, 'admin', 'admin'),
(2, 'supervisor', 'iamsuper'),
(3, 'manager', 'ok');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `reservation`
--
ALTER TABLE `reservation`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `room`
--
ALTER TABLE `room`
  ADD PRIMARY KEY (`no`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `reservation`
--
ALTER TABLE `reservation`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=25;

--
-- AUTO_INCREMENT for table `room`
--
ALTER TABLE `room`
  MODIFY `no` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=21;

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
