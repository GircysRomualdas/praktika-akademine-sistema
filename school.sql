-- phpMyAdmin SQL Dump
-- version 4.6.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 05, 2021 at 09:05 PM
-- Server version: 5.7.14
-- PHP Version: 5.6.25

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `school`
--

-- --------------------------------------------------------

--
-- Table structure for table `course`
--

CREATE TABLE `course` (
  `idCourse` int(11) NOT NULL,
  `Name` varchar(45) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `course`
--

INSERT INTO `course` (`idCourse`, `Name`) VALUES
(8, 'semPI1'),
(9, 'semPI2'),
(10, 'semPI3'),
(11, 'semIS1'),
(12, 'semIS2'),
(13, 'semIS3');

-- --------------------------------------------------------

--
-- Table structure for table `grade`
--

CREATE TABLE `grade` (
  `idgrade` int(11) NOT NULL,
  `grade` varchar(45) DEFAULT NULL,
  `type` varchar(45) DEFAULT NULL,
  `subject_idsubject` int(11) NOT NULL,
  `student_idstudent` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `grade`
--

INSERT INTO `grade` (`idgrade`, `grade`, `type`, `subject_idsubject`, `student_idstudent`) VALUES
(46, '9', 'k', 8, 10),
(47, '7', 'e', 8, 10),
(48, '6', 't', 8, 10),
(49, '4', 'ee', 8, 10);

-- --------------------------------------------------------

--
-- Table structure for table `group`
--

CREATE TABLE `group` (
  `idgroup` int(11) NOT NULL,
  `name` varchar(45) DEFAULT NULL,
  `course_idCourse` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `group`
--

INSERT INTO `group` (`idgroup`, `name`, `course_idCourse`) VALUES
(6, 'PI20A', 8),
(7, 'PI20B', 8),
(12, 'IS19', 12),
(11, 'PI20C', 12),
(13, 'PO18', 13),
(14, 'UI17', 13),
(15, 'OI21C', 9),
(16, 'TU19D', 9);

-- --------------------------------------------------------

--
-- Table structure for table `profesor`
--

CREATE TABLE `profesor` (
  `idprofesor` int(11) NOT NULL,
  `name` varchar(45) DEFAULT NULL,
  `surname` varchar(45) DEFAULT NULL,
  `username` varchar(45) DEFAULT NULL,
  `password` varchar(45) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `profesor`
--

INSERT INTO `profesor` (`idprofesor`, `name`, `surname`, `username`, `password`) VALUES
(16, 'Tomas', 'Katin', 'Tomas', 'Katin'),
(23, 'Vaidas', 'Jonaitis', 'Vaidas', 'Jonaitis');

-- --------------------------------------------------------

--
-- Table structure for table `student`
--

CREATE TABLE `student` (
  `idstudent` int(11) NOT NULL,
  `name` varchar(45) DEFAULT NULL,
  `surname` varchar(45) DEFAULT NULL,
  `username` varchar(45) DEFAULT NULL,
  `password` varchar(45) DEFAULT NULL,
  `group_idgroup` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `student`
--

INSERT INTO `student` (`idstudent`, `name`, `surname`, `username`, `password`, `group_idgroup`) VALUES
(6, 'Romas', 'Gircys', 'Romas', 'Gircys', 6),
(9, 'Vaidas', 'Gricys', 'Vaidas', 'Gricys', 7),
(10, 'Jonas', 'Jonaitis', 'Jonas', 'Jonaitis', 12),
(11, 'Petras', 'Petraitis', 'Petras', 'Petraitis', 11),
(12, 'Matas', 'Mataitis', 'Matas', 'Mataitis', 15),
(13, 'Liudas', 'Liudaitis', 'Liudas', 'Liudaitis', 16),
(14, 'Rudis', 'Rudaitis', 'Rudis', 'Rudaitis', 12),
(15, 'Davidas', 'Davidaitis', 'Davidas', 'Davidaitis', 12);

-- --------------------------------------------------------

--
-- Table structure for table `subject`
--

CREATE TABLE `subject` (
  `idsubject` int(11) NOT NULL,
  `name` varchar(45) DEFAULT NULL,
  `course_idCourse` int(11) NOT NULL,
  `profesor_idprofesor` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `subject`
--

INSERT INTO `subject` (`idsubject`, `name`, `course_idCourse`, `profesor_idprofesor`) VALUES
(8, 'Matematika', 12, 16),
(7, 'Anglu', 9, 16),
(9, 'Biologija', 10, 23),
(10, 'Anglu2', 12, 23),
(11, 'Anglu3', 12, 16);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `course`
--
ALTER TABLE `course`
  ADD PRIMARY KEY (`idCourse`),
  ADD UNIQUE KEY `Name_UNIQUE` (`Name`);

--
-- Indexes for table `grade`
--
ALTER TABLE `grade`
  ADD PRIMARY KEY (`idgrade`),
  ADD KEY `fk_grade_subject1_idx` (`subject_idsubject`),
  ADD KEY `fk_grade_student1_idx` (`student_idstudent`);

--
-- Indexes for table `group`
--
ALTER TABLE `group`
  ADD PRIMARY KEY (`idgroup`),
  ADD UNIQUE KEY `name_UNIQUE` (`name`),
  ADD KEY `fk_group_course1_idx` (`course_idCourse`);

--
-- Indexes for table `profesor`
--
ALTER TABLE `profesor`
  ADD PRIMARY KEY (`idprofesor`),
  ADD UNIQUE KEY `username_UNIQUE` (`username`);

--
-- Indexes for table `student`
--
ALTER TABLE `student`
  ADD PRIMARY KEY (`idstudent`),
  ADD UNIQUE KEY `username_UNIQUE` (`username`),
  ADD KEY `fk_student_group1_idx` (`group_idgroup`);

--
-- Indexes for table `subject`
--
ALTER TABLE `subject`
  ADD PRIMARY KEY (`idsubject`),
  ADD UNIQUE KEY `name_UNIQUE` (`name`),
  ADD KEY `fk_subject_course_idx` (`course_idCourse`),
  ADD KEY `fk_subject_profesor1_idx1` (`profesor_idprofesor`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `course`
--
ALTER TABLE `course`
  MODIFY `idCourse` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;
--
-- AUTO_INCREMENT for table `grade`
--
ALTER TABLE `grade`
  MODIFY `idgrade` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=50;
--
-- AUTO_INCREMENT for table `group`
--
ALTER TABLE `group`
  MODIFY `idgroup` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=17;
--
-- AUTO_INCREMENT for table `profesor`
--
ALTER TABLE `profesor`
  MODIFY `idprofesor` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=25;
--
-- AUTO_INCREMENT for table `student`
--
ALTER TABLE `student`
  MODIFY `idstudent` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;
--
-- AUTO_INCREMENT for table `subject`
--
ALTER TABLE `subject`
  MODIFY `idsubject` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
