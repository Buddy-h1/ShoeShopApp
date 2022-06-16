-- phpMyAdmin SQL Dump
-- version 5.0.4
-- https://www.phpmyadmin.net/
--
-- Хост: remotemysql.com
-- Время создания: Июн 16 2022 г., 09:38
-- Версия сервера: 8.0.13-4
-- Версия PHP: 7.3.33-1+ubuntu18.04.1+deb.sury.org+1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- База данных: `fhPLGLQp7U`
--

-- --------------------------------------------------------

--
-- Структура таблицы `chek`
--

CREATE TABLE `chek` (
  `id` int(11) NOT NULL,
  `date` date NOT NULL,
  `stoimost` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `chek`
--

INSERT INTO `chek` (`id`, `date`, `stoimost`) VALUES
(62, '2022-01-14', 3000),
(63, '2022-01-14', 10100),
(64, '2022-01-14', 10000),
(65, '2022-01-15', 7000),
(66, '2022-01-15', 6000),
(67, '2022-01-15', 9300),
(68, '2022-01-15', 12000),
(69, '2022-01-16', 3000),
(70, '2022-01-16', 8000),
(71, '2022-01-16', 6000),
(72, '2022-01-16', 11500),
(73, '2022-01-16', 9300),
(74, '2022-01-16', 9300),
(75, '2022-01-16', 3000),
(76, '2022-01-16', 2100),
(77, '2022-01-17', 6250),
(78, '2022-01-17', 3000),
(79, '2022-01-17', 7000),
(80, '2022-01-17', 4980),
(81, '2022-01-17', 8000),
(82, '2022-01-17', 7000),
(83, '2022-01-17', 12000),
(84, '2022-01-18', 10000),
(85, '2022-01-18', 9000),
(86, '2022-01-18', 8000),
(87, '2022-01-19', 9300),
(88, '2022-01-19', 7800),
(89, '2022-01-19', 4500),
(90, '2022-01-19', 9000),
(91, '2022-01-20', 2100),
(92, '2022-01-20', 9000),
(93, '2022-01-21', 13000),
(94, '2022-01-21', 10000),
(95, '2022-01-21', 4500),
(96, '2022-01-21', 8000),
(97, '2022-01-22', 9200),
(98, '2022-01-22', 3700),
(99, '2022-01-22', 9000),
(100, '2022-01-22', 4500),
(101, '2022-01-23', 8000),
(102, '2022-01-23', 2100),
(103, '2022-01-23', 2100),
(104, '2022-01-23', 2100),
(105, '2022-01-23', 9300),
(106, '2022-01-23', 6000),
(107, '2022-01-24', 9000),
(108, '2022-01-24', 9000),
(109, '2022-01-24', 9300),
(110, '2022-01-24', 9000),
(111, '2022-01-24', 3000),
(112, '2022-01-25', 10000),
(113, '2022-01-25', 7000),
(114, '2022-01-25', 11000),
(115, '2022-01-25', 3700),
(116, '2022-01-25', 4500),
(117, '2022-01-26', 9000),
(118, '2022-01-26', 3000),
(119, '2022-01-26', 3000),
(120, '2022-01-26', 9000),
(121, '2022-01-26', 3000),
(122, '2022-01-26', 3000),
(123, '2022-01-27', 10000),
(124, '2022-01-27', 7000),
(125, '2022-01-28', 9300),
(126, '2022-01-28', 9000),
(127, '2022-01-28', 3000),
(128, '2022-01-28', 6250),
(129, '2022-01-28', 3700),
(130, '2022-01-28', 9000),
(131, '2022-01-28', 4900),
(132, '2022-01-28', 4900),
(133, '2022-01-29', 4500),
(134, '2022-01-29', 3000),
(135, '2022-01-29', 3000),
(136, '2022-01-30', 7000),
(137, '2022-01-30', 9000),
(138, '2022-01-30', 8000),
(139, '2022-01-30', 2100),
(140, '2022-01-31', 7000),
(141, '2022-01-31', 3700),
(142, '2022-01-31', 8000),
(143, '2022-01-31', 2100),
(144, '2022-01-31', 19000),
(145, '2022-02-01', 9300),
(146, '2022-02-01', 9300),
(147, '2022-02-01', 9300),
(148, '2022-02-01', 12000),
(149, '2022-02-01', 14000),
(150, '2022-02-02', 8000),
(151, '2022-02-02', 9000),
(152, '2022-02-02', 16000),
(153, '2022-02-02', 20000),
(154, '2022-02-03', 4500),
(155, '2022-02-03', 7000),
(156, '2022-02-03', 3000),
(157, '2022-02-03', 3700),
(158, '2022-02-03', 18000),
(159, '2022-02-03', 17000),
(160, '2022-02-04', 9300),
(161, '2022-02-04', 9300),
(162, '2022-02-04', 4500),
(163, '2022-02-04', 9000),
(164, '2022-02-04', 22000),
(165, '2022-02-04', 13000),
(166, '2022-02-05', 9000),
(167, '2022-02-05', 3000),
(168, '2022-02-05', 3700),
(169, '2022-02-05', 6000),
(170, '2022-02-05', 22000),
(171, '2022-02-05', 12000),
(172, '2022-02-05', 2100),
(173, '2022-02-06', 4980),
(174, '2022-02-06', 8000),
(175, '2022-02-07', 12000),
(176, '2022-02-07', 9000),
(177, '2022-02-08', 9300),
(178, '2022-02-08', 20000),
(179, '2022-02-10', 7000),
(180, '2022-02-10', 6000),
(181, '2022-02-10', 6000),
(182, '2022-02-11', 4500),
(183, '2022-02-11', 13000),
(184, '2022-02-12', 18000),
(185, '2022-02-12', 9000),
(186, '2022-02-12', 2100),
(187, '2022-02-12', 4500),
(188, '2022-02-13', 20000),
(189, '2022-02-13', 12000),
(190, '2022-02-13', 9000),
(191, '2022-02-14', 9000),
(192, '2022-02-14', 9000),
(193, '2022-02-14', 3000),
(194, '2022-02-14', 13000),
(195, '2022-02-15', 6000),
(196, '2022-02-15', 9000),
(197, '2022-02-16', 18000),
(198, '2022-02-16', 9000),
(199, '2022-02-16', 9000),
(200, '2022-02-16', 4500),
(201, '2022-02-16', 20000),
(202, '2022-02-17', 2100),
(203, '2022-02-17', 12000),
(204, '2022-02-17', 9300),
(205, '2022-02-17', 18000),
(206, '2022-02-18', 9000),
(207, '2022-02-18', 9000),
(208, '2022-02-18', 3700),
(209, '2022-02-19', 10000),
(210, '2022-02-19', 9000),
(211, '2022-02-19', 9000),
(212, '2022-02-19', 10000),
(213, '2022-02-20', 7000),
(214, '2022-02-20', 4500),
(215, '2022-02-20', 4900),
(216, '2022-02-20', 6000),
(217, '2022-02-20', 16000),
(218, '2022-02-21', 9000),
(219, '2022-02-21', 9000),
(220, '2022-02-21', 12000),
(221, '2022-02-21', 6000),
(222, '2022-02-22', 9300),
(223, '2022-02-22', 6000),
(224, '2022-02-23', 9300),
(225, '2022-02-23', 10000),
(226, '2022-02-23', 7000),
(227, '2022-02-23', 16000),
(228, '2022-02-23', 6000),
(229, '2022-02-24', 9300),
(230, '2022-02-24', 9300),
(231, '2022-02-24', 12000),
(232, '2022-02-24', 16000),
(233, '2022-02-26', 7000),
(234, '2022-02-26', 10000),
(235, '2022-02-26', 8000),
(236, '2022-02-26', 3000),
(237, '2022-02-27', 7000),
(238, '2022-02-27', 14000),
(239, '2022-02-28', 18000),
(240, '2022-02-28', 9000),
(241, '2022-02-28', 9000),
(242, '2022-02-28', 2100),
(243, '2022-03-01', 7000),
(244, '2022-03-01', 3000),
(245, '2022-03-01', 3700),
(246, '2022-03-02', 10000),
(247, '2022-03-02', 7000),
(248, '2022-03-02', 8000),
(249, '2022-03-03', 3000),
(250, '2022-03-03', 9800),
(251, '2022-03-03', 3700),
(252, '2022-03-03', 9000),
(253, '2022-03-03', 9000),
(254, '2022-03-04', 4500),
(255, '2022-03-04', 2100),
(256, '2022-03-04', 2100),
(257, '2022-03-04', 9500),
(258, '2022-03-04', 6250);

-- --------------------------------------------------------

--
-- Структура таблицы `chek_obuv`
--

CREATE TABLE `chek_obuv` (
  `id` int(11) NOT NULL,
  `chek_id` int(11) NOT NULL,
  `obuv_id` int(11) NOT NULL,
  `kolichestvo` int(10) UNSIGNED NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `chek_obuv`
--

INSERT INTO `chek_obuv` (`id`, `chek_id`, `obuv_id`, `kolichestvo`) VALUES
(66, 62, 3, 1),
(67, 63, 6, 1),
(68, 63, 9, 1),
(69, 64, 25, 1),
(70, 65, 27, 1),
(71, 66, 20, 1),
(72, 67, 34, 1),
(73, 68, 42, 1),
(74, 68, 43, 1),
(75, 69, 48, 1),
(76, 70, 11, 1),
(77, 71, 21, 1),
(78, 72, 39, 1),
(79, 73, 35, 1),
(80, 74, 32, 1),
(81, 75, 2, 1),
(82, 76, 8, 1),
(83, 77, 44, 1),
(84, 78, 46, 1),
(85, 79, 38, 1),
(86, 79, 37, 1),
(87, 80, 5, 1),
(88, 81, 9, 1),
(89, 82, 28, 1),
(90, 83, 41, 1),
(91, 84, 24, 1),
(92, 85, 15, 1),
(93, 86, 11, 1),
(94, 87, 31, 1),
(95, 88, 12, 1),
(96, 89, 16, 1),
(97, 90, 14, 1),
(98, 91, 7, 1),
(99, 92, 26, 1),
(100, 93, 30, 1),
(101, 93, 29, 1),
(102, 94, 25, 1),
(103, 95, 16, 1),
(104, 96, 10, 1),
(105, 97, 34, 1),
(106, 98, 36, 1),
(107, 99, 1, 1),
(108, 100, 4, 1),
(109, 101, 13, 1),
(110, 102, 8, 1),
(111, 103, 6, 1),
(112, 104, 6, 1),
(113, 105, 35, 1),
(114, 106, 44, 1),
(115, 107, 34, 1),
(116, 108, 32, 1),
(117, 109, 31, 1),
(118, 110, 24, 1),
(119, 111, 3, 1),
(120, 112, 23, 1),
(121, 113, 28, 1),
(122, 114, 41, 1),
(123, 115, 36, 1),
(124, 116, 17, 1),
(125, 117, 1, 1),
(126, 118, 2, 1),
(127, 119, 47, 1),
(128, 120, 35, 1),
(129, 121, 49, 1),
(130, 122, 50, 1),
(131, 123, 26, 1),
(132, 124, 30, 1),
(133, 125, 33, 1),
(134, 126, 15, 1),
(135, 127, 47, 1),
(136, 128, 45, 1),
(137, 129, 36, 1),
(138, 130, 17, 2),
(139, 131, 5, 1),
(140, 132, 5, 1),
(141, 133, 16, 1),
(142, 134, 48, 1),
(143, 135, 48, 1),
(144, 136, 27, 1),
(145, 137, 14, 1),
(146, 138, 10, 1),
(147, 139, 7, 1),
(148, 140, 27, 1),
(149, 141, 37, 1),
(150, 142, 10, 1),
(151, 143, 6, 1),
(152, 144, 23, 2),
(153, 145, 35, 1),
(154, 146, 34, 1),
(155, 147, 33, 1),
(156, 148, 39, 1),
(157, 149, 29, 2),
(158, 150, 11, 1),
(159, 151, 14, 1),
(160, 152, 9, 2),
(161, 153, 26, 2),
(162, 154, 5, 1),
(163, 155, 27, 1),
(164, 156, 49, 1),
(165, 157, 37, 1),
(166, 158, 33, 2),
(167, 159, 15, 2),
(168, 160, 31, 1),
(169, 161, 34, 1),
(170, 162, 4, 1),
(171, 163, 15, 1),
(172, 164, 39, 2),
(173, 165, 28, 2),
(174, 166, 13, 1),
(175, 167, 2, 1),
(176, 168, 38, 1),
(177, 169, 38, 2),
(178, 170, 40, 2),
(179, 171, 44, 2),
(180, 172, 6, 1),
(181, 173, 4, 1),
(182, 174, 11, 1),
(183, 175, 20, 2),
(184, 176, 19, 2),
(185, 177, 34, 1),
(186, 178, 23, 2),
(187, 179, 27, 1),
(188, 180, 22, 1),
(189, 181, 20, 1),
(190, 182, 18, 1),
(191, 183, 29, 2),
(192, 184, 35, 2),
(193, 185, 15, 1),
(194, 186, 8, 1),
(195, 187, 4, 1),
(196, 188, 25, 2),
(197, 189, 21, 2),
(198, 190, 1, 1),
(199, 191, 16, 2),
(200, 192, 34, 1),
(201, 193, 50, 1),
(202, 194, 30, 2),
(203, 195, 22, 1),
(204, 196, 13, 1),
(205, 197, 32, 2),
(206, 198, 1, 1),
(207, 199, 15, 1),
(208, 200, 16, 1),
(209, 201, 26, 2),
(210, 202, 6, 1),
(211, 203, 21, 2),
(212, 204, 35, 1),
(213, 205, 31, 2),
(214, 206, 14, 1),
(215, 207, 15, 1),
(216, 208, 36, 1),
(217, 209, 24, 1),
(218, 210, 14, 1),
(219, 211, 1, 1),
(220, 212, 24, 1),
(221, 213, 29, 1),
(222, 214, 19, 1),
(223, 215, 5, 1),
(224, 216, 37, 2),
(225, 217, 12, 2),
(226, 218, 19, 2),
(227, 219, 13, 1),
(228, 220, 43, 2),
(229, 221, 21, 1),
(230, 222, 32, 1),
(231, 223, 22, 1),
(232, 224, 35, 1),
(233, 225, 4, 2),
(234, 226, 27, 1),
(235, 227, 11, 2),
(236, 228, 21, 1),
(237, 229, 33, 1),
(238, 230, 34, 1),
(239, 231, 42, 2),
(240, 232, 10, 2),
(241, 233, 27, 1),
(242, 234, 24, 1),
(243, 235, 11, 1),
(244, 236, 2, 1),
(245, 237, 29, 1),
(246, 238, 30, 2),
(247, 239, 34, 2),
(248, 240, 18, 2),
(249, 241, 13, 1),
(250, 242, 7, 1),
(251, 243, 27, 1),
(252, 244, 50, 1),
(253, 245, 36, 1),
(254, 246, 23, 1),
(255, 247, 27, 1),
(256, 248, 12, 1),
(257, 249, 3, 1),
(258, 250, 23, 1),
(259, 251, 37, 1),
(260, 252, 33, 1),
(261, 253, 1, 1),
(262, 254, 19, 1),
(263, 255, 6, 1),
(264, 256, 8, 1),
(265, 257, 25, 1),
(266, 258, 43, 1);

-- --------------------------------------------------------

--
-- Структура таблицы `obuv`
--

CREATE TABLE `obuv` (
  `id` int(11) NOT NULL,
  `naimenovanie` varchar(100) NOT NULL,
  `pol` varchar(7) NOT NULL,
  `kategoriya` varchar(50) NOT NULL,
  `razmer` varchar(10) NOT NULL,
  `kolichestvo` int(10) UNSIGNED NOT NULL,
  `cena_prodazhi` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `obuv`
--

INSERT INTO `obuv` (`id`, `naimenovanie`, `pol`, `kategoriya`, `razmer`, `kolichestvo`, `cena_prodazhi`) VALUES
(1, 'Goodzone', 'Женский', 'Сапоги', '39', 3, 9000),
(2, 'AOWEI', 'Мужской', 'Полубатинки', '42', 3, 3000),
(3, 'AOWEI', 'Мужской', 'Полубатинки', '43', 3, 3000),
(4, 'EMU Australia', 'Женский', 'Ботфорты', '39', 2, 4980),
(5, 'EMU Australia', 'Женский', 'Ботфорты', '36', 4, 4980),
(6, 'TimeJump', 'Мужской', 'Полубатинки', '42', 3, 2100),
(7, 'TimeJump', 'Мужской', 'Полубатинки', '41', 3, 2100),
(8, 'TimeJump', 'Мужской', 'Полубатинки', '43', 3, 2100),
(9, 'Jack Wolfskin Nevada Texapore Mid W', 'Женский', 'Полусапоги', '38', 3, 8000),
(10, 'Jack Wolfskin Nevada Texapore Mid W', 'Женский', 'Полусапоги', '37', 2, 8000),
(11, 'Jack Wolfskin Nevada Texapore Mid W', 'Женский', 'Полусапоги', '39', 2, 8000),
(12, 'Jack Wolfskin Nevada Texapore Mid W', 'Женский', 'Полусапоги', '36', 2, 8000),
(13, 'Columbia Vitesse Leather', 'Мужской', 'Полуботинки', '40', 2, 9000),
(14, 'Columbia Vitesse Leather', 'Мужской', 'Полуботинки', '41', 3, 9000),
(15, 'Columbia Vitesse Leather', 'Мужской', 'Полуботинки', '42', 2, 9000),
(16, 'Northland Flink', 'Мужской', 'Полуботинки', '40', 3, 4500),
(17, 'Northland Flink', 'Мужской', 'Полуботинки', '41', 2, 4500),
(18, 'Northland Flink', 'Мужской', 'Полуботинки', '42', 1, 4500),
(19, 'Northland Flink', 'Мужской', 'Полуботинки', '43', 3, 4500),
(20, 'Demix Exponenta 2 TF', 'Мужской', 'Бутсы', '40', 4, 6000),
(21, 'Demix Exponenta 2 TF', 'Мужской', 'Бутсы', '42', 3, 6000),
(22, 'Demix Exponenta 2 TF', 'Мужской', 'Бутсы', '41', 3, 6000),
(23, 'Nobbaro', 'Женский', 'Дутики', '38', 3, 10000),
(24, 'Nobbaro', 'Женский', 'Дутики', '37', 2, 10000),
(25, 'Nobbaro', 'Женский', 'Дутики', '36', 3, 10000),
(26, 'Nobbaro', 'Женский', 'Дутики', '35', 4, 10000),
(27, 'Potapkin', 'Женский', 'Ботфорты', '37', 1, 7000),
(28, 'Potapkin', 'Женский', 'Ботфорты', '38', 3, 7000),
(29, 'Potapkin', 'Женский', 'Ботфорты', '39', 1, 7000),
(30, 'Potapkin', 'Женский', 'Ботфорты', '40', 2, 7000),
(31, 'ELKLAND', 'Мужской', 'Ботинки', '41', 2, 9300),
(32, 'ELKLAND', 'Мужской', 'Ботинки', '42', 2, 9300),
(33, 'ELKLAND', 'Мужской', 'Ботинки', '43', 1, 9300),
(34, 'ELKLAND', 'Мужской', 'Ботинки', '44', 2, 9300),
(35, 'ELKLAND', 'Мужской', 'Ботинки', '45', 2, 9300),
(36, 'EVA', 'Женский', 'Кеды', '36', 2, 3700),
(37, 'EVA', 'Женский', 'Кеды', '37', 1, 3700),
(38, 'EVA', 'Женский', 'Кеды', '38', 2, 3700),
(39, 'DECATHLON', 'Женский', 'Сапоги', '37', 2, 12000),
(40, 'DECATHLON', 'Женский', 'Сапоги', '38', 2, 12000),
(41, 'DECATHLON', 'Женский', 'Сапоги', '39', 3, 12000),
(42, 'Outventure', 'Мужской', 'Полуботинки', '39', 3, 6250),
(43, 'Outventure', 'Мужской', 'Полуботинки', '40', 2, 6250),
(44, 'Outventure', 'Мужской', 'Полуботинки', '41', 3, 6250),
(45, 'Outventure', 'Мужской', 'Полуботинки', '42', 3, 6250),
(46, 'EVA', 'Женский', 'Кроссовки', '38', 3, 3000),
(47, 'EVA', 'Женский', 'Кроссовки', '39', 3, 3000),
(48, 'EVA', 'Женский', 'Кроссовки', '40', 3, 3000),
(49, 'EVA', 'Женский', 'Кроссовки', '41', 3, 3000),
(50, 'EVA', 'Женский', 'Кроссовки', '42', 1, 3000);

-- --------------------------------------------------------

--
-- Структура таблицы `postavka`
--

CREATE TABLE `postavka` (
  `id` int(11) NOT NULL,
  `postavshchik_id` int(11) NOT NULL,
  `date` date NOT NULL,
  `stoimost` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `postavka`
--

INSERT INTO `postavka` (`id`, `postavshchik_id`, `date`, `stoimost`) VALUES
(53, 2, '2022-01-11', 45430),
(54, 3, '2022-01-11', 99650),
(55, 3, '2022-01-12', 35460),
(56, 4, '2022-01-12', 35890),
(57, 5, '2022-01-12', 45780),
(58, 6, '2022-01-13', 54670),
(59, 8, '2022-01-13', 35980),
(60, 10, '2022-01-13', 25460),
(61, 5, '2022-01-20', 45670),
(62, 15, '2022-01-25', 35500),
(63, 14, '2022-01-25', 40670),
(64, 13, '2022-01-25', 34230),
(65, 3, '2022-01-30', 20800),
(66, 4, '2022-01-30', 29670),
(67, 8, '2022-01-30', 15600),
(68, 17, '2022-02-02', 24600),
(69, 22, '2022-02-02', 19500),
(70, 31, '2022-02-02', 24300),
(71, 27, '2022-02-09', 11300),
(72, 25, '2022-02-09', 19500),
(73, 6, '2022-02-09', 14600),
(74, 22, '2022-02-09', 14900),
(75, 2, '2022-02-09', 17800),
(76, 24, '2022-02-15', 13600),
(77, 45, '2022-02-15', 14200),
(78, 51, '2022-02-15', 12300),
(79, 38, '2022-02-15', 12900),
(80, 2, '2022-02-18', 10500),
(81, 3, '2022-02-18', 7000),
(82, 28, '2022-02-18', 14700),
(83, 19, '2022-02-19', 17500),
(84, 16, '2022-02-19', 14000),
(85, 47, '2022-02-19', 6000),
(86, 8, '2022-02-22', 6500),
(87, 9, '2022-02-22', 25300),
(88, 10, '2022-02-22', 13500),
(89, 21, '2022-02-24', 14600),
(90, 22, '2022-02-24', 20400),
(91, 24, '2022-02-24', 19430),
(92, 2, '2022-02-25', 7000),
(93, 15, '2022-02-25', 5000),
(94, 27, '2022-02-25', 21000),
(95, 33, '2022-02-25', 12980),
(96, 51, '2022-02-25', 13400),
(97, 28, '2022-02-26', 15000),
(98, 18, '2022-02-26', 14000),
(99, 50, '2022-02-26', 12500),
(100, 17, '2022-03-02', 7600),
(101, 27, '2022-03-02', 20000),
(102, 5, '2022-03-02', 23400);

-- --------------------------------------------------------

--
-- Структура таблицы `postavka_obuv`
--

CREATE TABLE `postavka_obuv` (
  `id` int(11) NOT NULL,
  `postavka_id` int(11) NOT NULL,
  `obuv_id` int(11) NOT NULL,
  `kolichestvo` int(10) UNSIGNED NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `postavka_obuv`
--

INSERT INTO `postavka_obuv` (`id`, `postavka_id`, `obuv_id`, `kolichestvo`) VALUES
(208, 53, 1, 4),
(209, 53, 2, 4),
(210, 53, 3, 4),
(211, 53, 4, 4),
(212, 53, 5, 4),
(213, 53, 6, 4),
(214, 54, 7, 4),
(215, 54, 8, 4),
(216, 54, 9, 3),
(217, 54, 10, 3),
(218, 54, 11, 3),
(219, 54, 12, 3),
(220, 54, 13, 3),
(221, 54, 14, 3),
(222, 54, 15, 3),
(223, 55, 16, 3),
(224, 55, 17, 3),
(225, 55, 18, 3),
(226, 55, 19, 3),
(227, 55, 20, 2),
(228, 56, 21, 2),
(229, 56, 22, 2),
(230, 56, 23, 2),
(231, 56, 24, 2),
(232, 56, 25, 1),
(233, 56, 26, 1),
(234, 57, 27, 2),
(235, 57, 28, 2),
(236, 57, 29, 2),
(237, 57, 30, 2),
(238, 57, 31, 2),
(239, 57, 32, 2),
(240, 57, 33, 2),
(241, 58, 34, 4),
(242, 58, 35, 4),
(243, 58, 36, 4),
(244, 58, 37, 4),
(245, 58, 38, 4),
(246, 58, 39, 2),
(247, 59, 40, 1),
(248, 59, 41, 1),
(249, 59, 42, 2),
(250, 59, 43, 2),
(251, 59, 44, 2),
(252, 59, 45, 2),
(253, 60, 46, 4),
(254, 60, 47, 4),
(255, 60, 48, 4),
(256, 60, 49, 4),
(257, 60, 50, 4),
(258, 61, 25, 3),
(259, 61, 41, 3),
(260, 61, 11, 2),
(261, 61, 9, 2),
(262, 62, 26, 2),
(263, 62, 31, 2),
(264, 62, 32, 2),
(265, 62, 44, 2),
(266, 63, 24, 2),
(267, 63, 27, 2),
(268, 63, 28, 2),
(269, 63, 29, 2),
(270, 63, 30, 2),
(271, 64, 34, 2),
(272, 64, 39, 2),
(273, 64, 42, 2),
(274, 64, 43, 2),
(275, 64, 21, 2),
(276, 65, 16, 2),
(277, 65, 17, 2),
(278, 65, 20, 2),
(279, 65, 23, 2),
(280, 66, 26, 2),
(281, 66, 33, 2),
(282, 66, 6, 2),
(283, 66, 5, 2),
(284, 67, 48, 2),
(285, 67, 45, 2),
(286, 67, 40, 2),
(287, 68, 10, 2),
(288, 68, 14, 2),
(289, 68, 15, 2),
(290, 69, 27, 2),
(291, 69, 23, 2),
(292, 69, 29, 2),
(293, 70, 35, 2),
(294, 70, 36, 2),
(295, 70, 39, 1),
(296, 70, 44, 1),
(297, 71, 6, 1),
(298, 71, 4, 1),
(299, 71, 2, 1),
(300, 71, 1, 2),
(301, 72, 9, 1),
(302, 72, 11, 1),
(303, 72, 13, 1),
(304, 72, 15, 2),
(305, 73, 19, 1),
(306, 73, 20, 1),
(307, 73, 23, 1),
(308, 73, 26, 1),
(309, 74, 28, 1),
(310, 74, 31, 1),
(311, 74, 33, 1),
(312, 74, 34, 1),
(313, 74, 37, 1),
(314, 75, 38, 1),
(315, 75, 39, 1),
(316, 75, 40, 1),
(317, 75, 44, 1),
(318, 75, 47, 1),
(319, 76, 8, 1),
(320, 76, 4, 1),
(321, 76, 15, 1),
(322, 76, 14, 1),
(323, 76, 13, 1),
(324, 77, 15, 1),
(325, 77, 16, 2),
(326, 77, 19, 1),
(327, 77, 20, 1),
(328, 77, 21, 1),
(329, 78, 25, 1),
(330, 78, 27, 1),
(331, 78, 28, 1),
(332, 78, 30, 1),
(333, 79, 34, 1),
(334, 79, 35, 1),
(335, 79, 30, 1),
(336, 79, 29, 1),
(337, 80, 1, 1),
(338, 80, 2, 1),
(339, 80, 3, 1),
(340, 80, 4, 1),
(341, 80, 5, 1),
(342, 81, 6, 1),
(343, 81, 7, 1),
(344, 81, 8, 1),
(345, 81, 9, 1),
(346, 82, 16, 1),
(347, 82, 15, 1),
(348, 82, 14, 1),
(349, 82, 13, 1),
(350, 83, 26, 1),
(351, 83, 31, 1),
(352, 83, 32, 1),
(353, 84, 35, 2),
(354, 84, 38, 1),
(355, 84, 42, 1),
(356, 84, 43, 1),
(357, 84, 44, 1),
(358, 85, 21, 1),
(359, 85, 22, 1),
(360, 85, 16, 1),
(361, 86, 1, 1),
(362, 86, 5, 1),
(363, 86, 6, 1),
(364, 87, 10, 2),
(365, 87, 11, 2),
(366, 87, 12, 2),
(367, 87, 13, 1),
(368, 88, 19, 1),
(369, 88, 21, 1),
(370, 88, 22, 1),
(371, 88, 23, 1),
(372, 89, 4, 1),
(373, 89, 11, 1),
(374, 89, 12, 1),
(375, 89, 14, 1),
(376, 90, 19, 1),
(377, 90, 21, 1),
(378, 90, 22, 1),
(379, 90, 23, 1),
(380, 91, 29, 1),
(381, 91, 32, 1),
(382, 91, 33, 1),
(383, 91, 34, 1),
(384, 92, 1, 1),
(385, 92, 2, 1),
(386, 92, 3, 1),
(387, 93, 5, 1),
(388, 93, 6, 1),
(389, 93, 7, 1),
(390, 93, 8, 1),
(391, 94, 24, 1),
(392, 94, 25, 1),
(393, 94, 26, 1),
(394, 94, 27, 1),
(395, 94, 28, 1),
(396, 95, 37, 1),
(397, 95, 36, 1),
(398, 95, 35, 1),
(399, 95, 34, 1),
(400, 96, 37, 1),
(401, 96, 33, 1),
(402, 96, 32, 1),
(403, 96, 31, 1),
(404, 97, 41, 1),
(405, 97, 42, 1),
(406, 97, 43, 1),
(407, 97, 49, 1),
(408, 98, 21, 1),
(409, 98, 24, 1),
(410, 98, 25, 1),
(411, 98, 26, 1),
(412, 99, 22, 1),
(413, 99, 21, 1),
(414, 99, 20, 1),
(415, 99, 19, 1),
(416, 100, 18, 1),
(417, 100, 19, 1),
(418, 100, 20, 1),
(419, 101, 24, 1),
(420, 101, 25, 1),
(421, 101, 26, 1),
(422, 101, 23, 1),
(423, 102, 30, 2),
(424, 102, 27, 2),
(425, 102, 34, 2);

-- --------------------------------------------------------

--
-- Структура таблицы `postavshchik`
--

CREATE TABLE `postavshchik` (
  `id` int(11) NOT NULL,
  `nazvanie` varchar(100) NOT NULL,
  `adres` varchar(100) NOT NULL,
  `rukovodstvo` varchar(100) NOT NULL,
  `nomer_telefona` varchar(12) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `postavshchik`
--

INSERT INTO `postavshchik` (`id`, `nazvanie`, `adres`, `rukovodstvo`, `nomer_telefona`) VALUES
(2, 'Noods', 'Москва, Перовское шоссе, 43', 'Белозёров Исак Юрьевич', '89042341234'),
(3, 'Мега7', 'Видное, наб. 1905 года, 75', 'Панфилов Артем Христофорович', '89062342345'),
(4, 'Millioner', 'Павловский Посад, пл. Косиора, 90', 'Поляков Флор Дмитриевич', '89041295834'),
(5, 'ShoeRuCom', 'Балашиха, ул. Сталина, 98', 'Агафонов Федор Донатович', '89103458268'),
(6, '37 Shoes Group', 'Сергиев Посад, спуск Чехова, 78', 'Беляков Митрофан Феликсович', '89048738275'),
(7, 'Vitalishop', 'Москва, пл. Балканская, 04', 'Абрамов Донат Иринеевич', '89118467479'),
(8, 'GoaBayTrading', 'Красногорск, ул. Балканская, 24', 'Харитонов Велор Оскарович', '89124824724'),
(9, 'TovatMoscow', 'Истра, бульвар Гагарина, 90', 'Тетерин Тимур Иринеевич', '89219838472'),
(10, 'Rowshen', 'Клин, пр. Будапештсткая, 90', 'Кудрявцев Герасим Русланович', '89951234235'),
(11, 'Malanga', 'Луховицы, пер. Ладыгина, 31', 'Сергеев Людвиг Максимович', '89004325652'),
(12, 'Sezon UA', 'Луховицы, шоссе 1905 года, 93', 'Корнилов Герасим Авксентьевич', '89523456343'),
(13, 'Vesto Italiano', 'Видное, бульвар Ладыгина, 92', 'Калинин Мечеслав Евсеевич', '89042345234'),
(14, 'Овчина Торг', 'Клин, шоссе Гоголя, 83', 'Кононов Александр Ярославович', '89995235468'),
(15, 'Happywear', 'Шатура, въезд 1905 года, 14', 'Кудряшов Максимилиан Всеволодович', '89991236543'),
(16, 'Фурнитур-ВУ', 'Можайск, наб. Балканская, 86', 'Герасимов Аким Онисимович', '89024235345'),
(17, 'OH KIKI Collection', 'Дмитров, въезд Ломоносова, 31', 'Ситников Арсений Петрович', '89024325661'),
(18, 'International TexTrade', 'Солнечногорск, пр. Космонавтов, 76', 'Блинов Осип Якунович', '89999754823'),
(19, 'Gaede Shoes', 'Клин, пр. Бухарестская, 22', 'Шарапов Виктор Тимофеевич', '89043945628'),
(20, 'СпецОптОрг', 'Сергиев Посад, спуск Косиора, 77', 'Беляков Аввакум Валерьянович', '89912456283'),
(21, 'shoes_by_kopyloff', 'Павловский Посад, пр. Ломоносова, 85', 'Гордеев Антон Донатович', '89214576283'),
(22, 'Clean Feet', 'Орехово-Зуево, ул. Косиора, 62', 'Некрасов Степан Николаевич', '89195829523'),
(23, 'Gino Figini', 'Кашира, въезд Домодедовская, 17', 'Николаев Максимилиан Леонидович', '82826785343'),
(24, 'ComfortMAxShoes', 'Подольск, шоссе Домодедовская, 69', 'Фёдоров Натан Борисович', '89114872569'),
(25, 'ООО \"Север\"', 'Раменское, въезд Косиора, 39', 'Герасимов Василий Федосеевич', '89391399302'),
(26, 'Ted Waker shoes', 'Щёлково, ул. Гоголя, 39', 'Чернов Платон Робертович', '89044305430'),
(27, 'Aksoy White Line', 'Шатура, бульвар Ладыгина, 92', 'Белов Людвиг Авдеевич', '9042304023'),
(28, 'АО РПТ', 'Москва, въезд 1905 года, 87', 'Потапов Карл Лукьянович', '89952305023'),
(29, 'Sarwary International Sales', 'Видное, наб. Балканская, 55', 'Сысоев Болеслав Степанович', '89092340230'),
(30, 'ИП Мамедова', 'Талдом, шоссе 1905 года, 74', 'Дроздов Елисей Семёнович', '89047426523'),
(31, 'Vodiy Shoes', 'Видное, пр. Будапештсткая, 05', 'Елисеев Тарас Пётрович', '89041348172'),
(32, 'NikaStyle', 'Луховицы, ул. Славы, 13', 'Михайлов Елисей Анатольевич', '89991364521'),
(33, 'TICA', 'Луховицы, шоссе Ломоносова, 20', 'Баранов Эльдар Лукьевич', '89994231456'),
(34, 'Эко-Дрим', 'Балашиха, наб. Ленина, 67', 'Панов Савелий Даниилович', '89911263423'),
(35, 'Умный текстиль', 'Ногинск, въезд Балканская, 76', 'Логинов Дональд Дмитрьевич', '89210543523'),
(36, 'Мидлэнд', 'Егорьевск, шоссе Косиора, 52', 'Савельев Николай Рудольфович', '89215423056'),
(37, 'Davnik', 'Дорохово, спуск 1905 года, 93', 'Захаров Афанасий Макарович', '89314527362'),
(38, 'Slippers', 'Сергиев Посад, въезд 1905 года, 91', 'Назаров Агафон Онисимович', '89991346124'),
(39, 'Pati', 'Люберцы, наб. Гагарина, 59', 'Калинин Абрам Павлович', '89992173523'),
(40, 'Fashion life', 'Ступино, наб. 1905 года, 19', 'Кузьмин Ибрагил Игнатьевич', '89272052363'),
(41, 'Стиль-Классик', 'Серебряные Пруды, пл. Ломоносова, 35', 'Ершов Демьян Мэлсович', '89372412013'),
(42, 'Quality Development', 'Озёры, бульвар Сталина, 90', 'Наумов Трофим Васильевич', '89501304102'),
(43, 'Shagovita', 'Ногинск, пл. Ломоносова, 92', 'Федотов Геннадий Иринеевич', '9501341234'),
(44, 'Khafizon', 'Люберцы, спуск Будапештсткая, 60', 'Назаров Никифор Давидович', '89522304023'),
(45, 'My_boots', 'Воскресенск, шоссе 1905 года, 39', 'Медведев Арсений Яковлевич', '89912420234'),
(46, 'Menshopekb', 'Лотошино, пл. Чехова, 70', 'Волков Игнатий Юлианович', '89822342342'),
(47, 'Спец-Гост', 'Подольск, въезд Космонавтов, 25', 'Евсеев Никифор Ефимович', '89024320520'),
(48, 'Gremmy Shoes', 'Можайск, наб. 1905 года, 36', 'Смирнов Оскар Антонинович', '89022342303'),
(49, 'Inblu Shop', 'Дорохово, пл. Бухарестская, 56', 'Комаров Виссарион Дмитрьевич', '89023325430'),
(50, 'Vera Victoria Vito', 'Люберцы, шоссе Гоголя, 19', 'Гришин Артем Владленович', '89048235726'),
(51, 'Обувашка', 'Балашиха, въезд Чехова, 39', 'Самсонов Федор Евсеевич', '89371239035');

--
-- Индексы сохранённых таблиц
--

--
-- Индексы таблицы `chek`
--
ALTER TABLE `chek`
  ADD PRIMARY KEY (`id`);

--
-- Индексы таблицы `chek_obuv`
--
ALTER TABLE `chek_obuv`
  ADD PRIMARY KEY (`id`),
  ADD KEY `obuv_id` (`obuv_id`),
  ADD KEY `chek_id` (`chek_id`);

--
-- Индексы таблицы `obuv`
--
ALTER TABLE `obuv`
  ADD PRIMARY KEY (`id`);

--
-- Индексы таблицы `postavka`
--
ALTER TABLE `postavka`
  ADD PRIMARY KEY (`id`),
  ADD KEY `postavshchik_id` (`postavshchik_id`);

--
-- Индексы таблицы `postavka_obuv`
--
ALTER TABLE `postavka_obuv`
  ADD PRIMARY KEY (`id`),
  ADD KEY `postavka_id` (`postavka_id`),
  ADD KEY `obuv_id` (`obuv_id`);

--
-- Индексы таблицы `postavshchik`
--
ALTER TABLE `postavshchik`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT для сохранённых таблиц
--

--
-- AUTO_INCREMENT для таблицы `chek`
--
ALTER TABLE `chek`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=259;

--
-- AUTO_INCREMENT для таблицы `chek_obuv`
--
ALTER TABLE `chek_obuv`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=267;

--
-- AUTO_INCREMENT для таблицы `obuv`
--
ALTER TABLE `obuv`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=51;

--
-- AUTO_INCREMENT для таблицы `postavka`
--
ALTER TABLE `postavka`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=103;

--
-- AUTO_INCREMENT для таблицы `postavka_obuv`
--
ALTER TABLE `postavka_obuv`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=426;

--
-- AUTO_INCREMENT для таблицы `postavshchik`
--
ALTER TABLE `postavshchik`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=53;

--
-- Ограничения внешнего ключа сохраненных таблиц
--

--
-- Ограничения внешнего ключа таблицы `chek_obuv`
--
ALTER TABLE `chek_obuv`
  ADD CONSTRAINT `chek_obuv_ibfk_1` FOREIGN KEY (`obuv_id`) REFERENCES `obuv` (`id`) ON DELETE RESTRICT ON UPDATE RESTRICT,
  ADD CONSTRAINT `chek_obuv_ibfk_2` FOREIGN KEY (`chek_id`) REFERENCES `chek` (`id`) ON DELETE RESTRICT ON UPDATE RESTRICT;

--
-- Ограничения внешнего ключа таблицы `postavka`
--
ALTER TABLE `postavka`
  ADD CONSTRAINT `postavka_ibfk_1` FOREIGN KEY (`postavshchik_id`) REFERENCES `postavshchik` (`id`) ON DELETE RESTRICT ON UPDATE RESTRICT;

--
-- Ограничения внешнего ключа таблицы `postavka_obuv`
--
ALTER TABLE `postavka_obuv`
  ADD CONSTRAINT `postavka_obuv_ibfk_1` FOREIGN KEY (`postavka_id`) REFERENCES `postavka` (`id`) ON DELETE RESTRICT ON UPDATE RESTRICT,
  ADD CONSTRAINT `postavka_obuv_ibfk_2` FOREIGN KEY (`obuv_id`) REFERENCES `obuv` (`id`) ON DELETE RESTRICT ON UPDATE RESTRICT;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
