-- phpMyAdmin SQL Dump
-- version 4.9.3
-- https://www.phpmyadmin.net/
--
-- Host: studmysql01.fhict.local
-- Gegenereerd op: 09 jun 2022 om 10:06
-- Serverversie: 5.7.26-log
-- PHP-versie: 7.4.23

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `dbi479450`
--

-- --------------------------------------------------------

--
-- Tabelstructuur voor tabel `ds_account`
--

CREATE TABLE `ds_account` (
  `AccountID` int(11) NOT NULL,
  `FirstName` varchar(100) NOT NULL,
  `LastName` varchar(100) NOT NULL,
  `Email` varchar(200) NOT NULL,
  `BirthDate` datetime NOT NULL,
  `gender` char(2) NOT NULL,
  `address` varchar(200) NOT NULL,
  `town` varchar(100) NOT NULL,
  `password` varchar(250) NOT NULL,
  `keyword` varchar(250) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Gegevens worden geëxporteerd voor tabel `ds_account`
--

INSERT INTO `ds_account` (`AccountID`, `FirstName`, `LastName`, `Email`, `BirthDate`, `gender`, `address`, `town`, `password`, `keyword`) VALUES
(1, 'LoginTest', 'User', 'test@test.nl', '1999-04-01 00:00:00', 'M', 'Address 5', 'town', '1wv73e1jsTgfZZtoQ5fNGn6p2yGXtBat+zzH5Mgv3qg=', 'E0qXR479SuoTJf392GayJw=='),
(2, 'Felly', 'User', 'test2@test.nl', '2022-05-22 10:34:45', 'F', 'Address 5', 'town', 'YhNprLPn7GXahzNHfwW7VneEHx9I1Gp7Fc1DkDJGLrw=', '5SMivQoPBjtJo2REWcwHZw=='),
(3, 'Fry', 'User', 'test2@test.nl', '2022-05-22 10:34:45', 'F', 'Address 5', 'town', 'okuX/rAKXMdL/T/U2FrbBgeZMwXk0OhVVMde8dUlKGY=', 'Fp+IBMANYGOIZxySn0CtVA=='),
(8, 'F', 'User', 'test3@test.nl', '0001-01-01 00:00:00', 'F', 'Address 5', 'town', '1wv73e1jsTgfZZtoQ5fNGn6p2yGXtBat+zzH5Mgv3qg=', 'E0qXR479SuoTJf392GayJw=='),
(17, 'quinn', 'weird', '2quien@2.nl', '2022-05-22 15:23:00', 'O', 'weirdStreet', 'detour', '', ''),
(18, 'Steve', 'Lobs', 'steve@mail.com', '2022-05-30 09:48:47', 'M', 'AppleStreet 3', 'AppleHQ', 'belonnyPassword', 'password'),
(19, 'bo', 'Asley', 'asley@mark.be', '2022-05-11 09:48:47', 'F', 'qety 1', 'qwerty', 'AsleysPassword', 'Bo'),
(20, 'Iscal', 'Newtons', 'newton@gravity.gov', '2000-03-01 00:00:00', 'M', 'engenderer 7', 'xeryvier', 'GravityIsCool', 'AppleTree'),
(21, 'Emily', 'Straus', 'straus@vogel.au', '1998-01-01 00:00:00', 'F', 'desertstreet 67', 'sydney', 'FastBird', 'Austalia'),
(22, 'SingUp', 'User', 'test@test.nl', '1999-04-01 00:00:00', 'M', 'Address 5', 'town', '1wv73e1jsTgfZZtoQ5fNGn6p2yGXtBat+zzH5Mgv3qg=', 'E0qXR479SuoTJf392GayJw==');

-- --------------------------------------------------------

--
-- Tabelstructuur voor tabel `ds_company`
--

CREATE TABLE `ds_company` (
  `CompanyID` int(4) NOT NULL,
  `CompanyName` varchar(200) NOT NULL,
  `CompanyLocation` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Gegevens worden geëxporteerd voor tabel `ds_company`
--

INSERT INTO `ds_company` (`CompanyID`, `CompanyName`, `CompanyLocation`) VALUES
(1, 'DualSync', 'Somewhere');

-- --------------------------------------------------------

--
-- Tabelstructuur voor tabel `ds_match`
--

CREATE TABLE `ds_match` (
  `TournamentID` int(11) NOT NULL,
  `Player1` int(11) NOT NULL,
  `Player2` int(11) NOT NULL,
  `Score1` int(3) DEFAULT NULL,
  `Score2` int(3) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Gegevens worden geëxporteerd voor tabel `ds_match`
--

INSERT INTO `ds_match` (`TournamentID`, `Player1`, `Player2`, `Score1`, `Score2`) VALUES
(1, 17, 18, 21, 10),
(1, 17, 1, 23, 21),
(1, 17, 19, 21, 18),
(1, 17, 21, 16, 21),
(1, 17, 20, 27, 25),
(1, 18, 1, 25, 23),
(1, 18, 19, 28, 26),
(1, 18, 21, 23, 21),
(1, 18, 20, 21, 19),
(1, 1, 19, 21, 8),
(1, 1, 21, 0, 21),
(1, 1, 20, 25, 23),
(1, 19, 21, 6, 21),
(1, 19, 20, 30, 28),
(1, 21, 20, 10, 21);

-- --------------------------------------------------------

--
-- Tabelstructuur voor tabel `ds_player`
--

CREATE TABLE `ds_player` (
  `AccountID` int(11) NOT NULL,
  `TeamName` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Gegevens worden geëxporteerd voor tabel `ds_player`
--

INSERT INTO `ds_player` (`AccountID`, `TeamName`) VALUES
(1, 'BennyBob'),
(8, 'bestTeam'),
(17, 'quinsterr'),
(18, 'Menwer'),
(19, 'bobo'),
(20, 'Appletree Gang'),
(21, 'Emily Watson'),
(22, 'Singer');

-- --------------------------------------------------------

--
-- Tabelstructuur voor tabel `ds_signup`
--

CREATE TABLE `ds_signup` (
  `tournamentID` int(11) NOT NULL,
  `PlayerID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Gegevens worden geëxporteerd voor tabel `ds_signup`
--

INSERT INTO `ds_signup` (`tournamentID`, `PlayerID`) VALUES
(1, 1),
(1, 17),
(1, 18),
(1, 19),
(1, 20),
(1, 21);

-- --------------------------------------------------------

--
-- Tabelstructuur voor tabel `ds_sport`
--

CREATE TABLE `ds_sport` (
  `sportID` int(11) NOT NULL,
  `SportName` varchar(50) NOT NULL,
  `winCondition1` varchar(20) DEFAULT NULL,
  `winCondition2` varchar(20) DEFAULT NULL,
  `winCondition3` varchar(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Gegevens worden geëxporteerd voor tabel `ds_sport`
--

INSERT INTO `ds_sport` (`sportID`, `SportName`, `winCondition1`, `winCondition2`, `winCondition3`) VALUES
(1, 'Badminton', '19-21', '20-22', '31'),
(2, 'Basketball', '0-1', NULL, NULL);

-- --------------------------------------------------------

--
-- Tabelstructuur voor tabel `ds_staff`
--

CREATE TABLE `ds_staff` (
  `AccountID` int(11) NOT NULL,
  `CompanyID` int(4) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Gegevens worden geëxporteerd voor tabel `ds_staff`
--

INSERT INTO `ds_staff` (`AccountID`, `CompanyID`) VALUES
(8, 1),
(17, 1);

-- --------------------------------------------------------

--
-- Tabelstructuur voor tabel `ds_tournament`
--

CREATE TABLE `ds_tournament` (
  `tournamentID` int(11) NOT NULL,
  `sportID` int(11) NOT NULL,
  `tournamentName` varchar(100) NOT NULL,
  `tournamentDescription` text,
  `minPlayer` int(3) NOT NULL,
  `maxPlayer` int(3) NOT NULL,
  `startDate` date NOT NULL,
  `endDate` date NOT NULL,
  `status` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Gegevens worden geëxporteerd voor tabel `ds_tournament`
--

INSERT INTO `ds_tournament` (`tournamentID`, `sportID`, `tournamentName`, `tournamentDescription`, `minPlayer`, `maxPlayer`, `startDate`, `endDate`, `status`) VALUES
(1, 1, 'Tournament', 'tournament', 5, 6, '2022-06-03', '2022-06-05', 'On going'),
(2, 2, 'Second', 'second', 15, 20, '2022-06-25', '2022-06-26', 'Available');

--
-- Indexen voor geëxporteerde tabellen
--

--
-- Indexen voor tabel `ds_account`
--
ALTER TABLE `ds_account`
  ADD PRIMARY KEY (`AccountID`);

--
-- Indexen voor tabel `ds_company`
--
ALTER TABLE `ds_company`
  ADD PRIMARY KEY (`CompanyID`);

--
-- Indexen voor tabel `ds_match`
--
ALTER TABLE `ds_match`
  ADD KEY `TournamentID` (`TournamentID`,`Player1`,`Player2`),
  ADD KEY `Player1` (`Player1`),
  ADD KEY `Player2` (`Player2`);

--
-- Indexen voor tabel `ds_player`
--
ALTER TABLE `ds_player`
  ADD PRIMARY KEY (`AccountID`),
  ADD KEY `AccountID` (`AccountID`);

--
-- Indexen voor tabel `ds_signup`
--
ALTER TABLE `ds_signup`
  ADD PRIMARY KEY (`tournamentID`,`PlayerID`),
  ADD KEY `tournamentID` (`tournamentID`,`PlayerID`),
  ADD KEY `PlayerID` (`PlayerID`);

--
-- Indexen voor tabel `ds_sport`
--
ALTER TABLE `ds_sport`
  ADD PRIMARY KEY (`sportID`);

--
-- Indexen voor tabel `ds_staff`
--
ALTER TABLE `ds_staff`
  ADD PRIMARY KEY (`AccountID`),
  ADD KEY `AccountID` (`AccountID`),
  ADD KEY `CompanyID` (`CompanyID`);

--
-- Indexen voor tabel `ds_tournament`
--
ALTER TABLE `ds_tournament`
  ADD PRIMARY KEY (`tournamentID`),
  ADD KEY `sportID` (`sportID`);

--
-- AUTO_INCREMENT voor geëxporteerde tabellen
--

--
-- AUTO_INCREMENT voor een tabel `ds_account`
--
ALTER TABLE `ds_account`
  MODIFY `AccountID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=23;

--
-- AUTO_INCREMENT voor een tabel `ds_company`
--
ALTER TABLE `ds_company`
  MODIFY `CompanyID` int(4) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT voor een tabel `ds_sport`
--
ALTER TABLE `ds_sport`
  MODIFY `sportID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT voor een tabel `ds_tournament`
--
ALTER TABLE `ds_tournament`
  MODIFY `tournamentID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- Beperkingen voor geëxporteerde tabellen
--

--
-- Beperkingen voor tabel `ds_match`
--
ALTER TABLE `ds_match`
  ADD CONSTRAINT `ds_match_ibfk_1` FOREIGN KEY (`Player1`) REFERENCES `ds_player` (`AccountID`),
  ADD CONSTRAINT `ds_match_ibfk_2` FOREIGN KEY (`Player2`) REFERENCES `ds_player` (`AccountID`),
  ADD CONSTRAINT `ds_match_ibfk_3` FOREIGN KEY (`TournamentID`) REFERENCES `ds_tournament` (`tournamentID`);

--
-- Beperkingen voor tabel `ds_player`
--
ALTER TABLE `ds_player`
  ADD CONSTRAINT `ds_player_ibfk_1` FOREIGN KEY (`AccountID`) REFERENCES `ds_account` (`AccountID`);

--
-- Beperkingen voor tabel `ds_signup`
--
ALTER TABLE `ds_signup`
  ADD CONSTRAINT `ds_signup_ibfk_1` FOREIGN KEY (`PlayerID`) REFERENCES `ds_player` (`AccountID`),
  ADD CONSTRAINT `ds_signup_ibfk_2` FOREIGN KEY (`tournamentID`) REFERENCES `ds_tournament` (`tournamentID`);

--
-- Beperkingen voor tabel `ds_staff`
--
ALTER TABLE `ds_staff`
  ADD CONSTRAINT `ds_staff_ibfk_1` FOREIGN KEY (`AccountID`) REFERENCES `ds_account` (`AccountID`),
  ADD CONSTRAINT `ds_staff_ibfk_2` FOREIGN KEY (`CompanyID`) REFERENCES `ds_company` (`CompanyID`);

--
-- Beperkingen voor tabel `ds_tournament`
--
ALTER TABLE `ds_tournament`
  ADD CONSTRAINT `ds_tournament_ibfk_1` FOREIGN KEY (`sportID`) REFERENCES `ds_sport` (`sportID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
