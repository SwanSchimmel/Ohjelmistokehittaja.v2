-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Хост: 127.0.0.1
-- Время создания: Май 21 2026 г., 17:26
-- Версия сервера: 10.4.32-MariaDB
-- Версия PHP: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- База данных: `pizza_db`

INSERT INTO `pizzas` (`pizza_name`, `base_price`) VALUES
('Pepperoni', 8),
('Hawaii', 8),
('BBQ Chicken', 8),
('Vegetarian', 7);
--

-- --------------------------------------------------------

--
-- Структура таблицы `customers`
--

CREATE TABLE `customers` (
  `customer_id` int(11) NOT NULL,
  `first_name` varchar(100) NOT NULL,
  `last_name` varchar(100) NOT NULL,
  `address` varchar(255) NOT NULL,
  `phone` varchar(50) DEFAULT NULL,
  `email` varchar(150) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Дамп данных таблицы `customers`
--

INSERT INTO `customers` (`customer_id`, `first_name`, `last_name`, `address`, `phone`, `email`) VALUES
(1, 'First Name', 'Last Name', 'Address', '', ''),
(2, 'First Name', 'Last Name', 'Address', '', ''),
(3, 'First Name', 'Last Name', 'Address', '', ''),
(4, 'цуа', 'Last ц', 'Addressцуауц', '', ''),
(5, 'First Name', 'Last Name', 'Address', '', ''),
(6, 'First Name', 'Last Name', 'Address', '', ''),
(7, 'First Name', 'Last Name', 'Address', '', ''),
(8, 'First Name', 'Last Name', 'Address', '', ''),
(9, 'llnl', 'ijpij', 'jopjjö', '', ''),
(10, 'First Name', 'Last Name', 'Address', '', ''),
(11, 'First Name', 'Last Name', 'Address', '', ''),
(12, 'First Name', 'Last Name', 'Address', '', ''),
(13, 'First Name', 'Last Name', 'Address', '', ''),
(14, 'First Name', 'Last Name', 'Address', '', ''),
(15, 'First Name', 'Last Name', 'Address', '', ''),
(16, 'First Name', 'Last Name', 'Address', '', ''),
(17, 'First Name', 'Last Name', 'Address', '', ''),
(18, 'First Name', 'Last Name', 'Address', '', '');

-- --------------------------------------------------------

--
-- Структура таблицы `orders`
--

CREATE TABLE `orders` (
  `order_id` int(11) NOT NULL,
  `customer_id` int(11) NOT NULL,
  `total_price` double NOT NULL,
  `payment_method` varchar(50) NOT NULL,
  `order_date` datetime NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Дамп данных таблицы `orders`
--

INSERT INTO `orders` (`order_id`, `customer_id`, `total_price`, `payment_method`, `order_date`) VALUES
(1, 1, 11.5, '', '2026-05-21 02:26:47'),
(2, 2, 0, '', '2026-05-21 02:27:00'),
(3, 3, 57.5, '', '2026-05-21 02:38:35'),
(4, 4, 108, 'Card', '2026-05-21 02:39:43'),
(5, 5, 10, '', '2026-05-21 02:51:39'),
(6, 6, 12, '', '2026-05-21 04:36:46'),
(7, 7, 11.5, '', '2026-05-21 04:59:05'),
(8, 8, 11.5, '', '2026-05-21 05:10:37'),
(9, 9, 11.5, '', '2026-05-21 15:01:47'),
(10, 10, 8, '', '2026-05-21 15:30:18'),
(11, 11, 8, '', '2026-05-21 16:48:20'),
(12, 12, 10, '', '2026-05-21 16:49:57'),
(13, 13, 10, '', '2026-05-21 17:57:42'),
(14, 14, 12, '', '2026-05-21 18:05:09'),
(15, 15, 12, '', '2026-05-21 18:15:19'),
(16, 16, 13.5, '', '2026-05-21 18:19:09'),
(17, 17, 262.5, '', '2026-05-21 18:20:10'),
(18, 18, 11.5, '', '2026-05-21 18:23:00');

-- --------------------------------------------------------

--
-- Структура таблицы `order_items`
--

CREATE TABLE `order_items` (
  `item_id` int(11) NOT NULL,
  `order_id` int(11) NOT NULL,
  `pizza_name` varchar(100) NOT NULL,
  `pizza_size` varchar(50) NOT NULL,
  `toppings` text NOT NULL,
  `quantity` int(11) NOT NULL,
  `item_price` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Дамп данных таблицы `order_items`
--

INSERT INTO `order_items` (`item_id`, `order_id`, `pizza_name`, `pizza_size`, `toppings`, `quantity`, `item_price`) VALUES
(1, 1, 'Hawaii', 'Medium', 'Mushrooms', 1, 11.5),
(2, 3, 'Pepperoni', 'Medium', 'Mushrooms', 5, 57.5),
(3, 4, 'Hawaii', 'Large', 'Mushrooms', 8, 108),
(4, 5, 'Chicken', 'Medium', '', 1, 10),
(5, 6, 'Chicken', 'Large', '', 1, 12),
(6, 7, 'Hawaii', 'Medium', 'Mushrooms', 1, 11.5),
(7, 8, 'Hawaii', 'Medium', 'Extra Cheese', 1, 11.5),
(8, 9, 'Chicken', 'Medium', 'Extra Cheese', 1, 11.5),
(9, 10, 'Hawaii', 'Small', '', 1, 8),
(10, 11, 'Chicken', 'Small', '', 1, 8),
(11, 12, 'Chicken', 'Medium', '', 1, 10),
(12, 13, 'Hawaii', 'Medium', '', 1, 10),
(13, 14, 'Pepperoni', 'Large', '', 1, 12),
(14, 15, 'Chicken', 'Large', '', 1, 12),
(15, 16, 'Hawaii', 'Large', 'Extra Cheese', 1, 13.5),
(16, 17, 'Hawaii', 'Medium', '', 1, 10),
(17, 17, 'Hawaii', 'Medium', '', 5, 50),
(18, 17, 'Chicken', 'Large', 'Mushrooms', 5, 67.5),
(19, 17, 'Pepperoni', 'Large', 'Mushrooms,Olives', 9, 135),
(20, 18, 'Chicken', 'Medium', 'Mushrooms', 1, 11.5);

-- --------------------------------------------------------

--
-- Структура таблицы `pizzas`
--

CREATE TABLE `pizzas` (
  `pizza_id` int(11) NOT NULL,
  `pizza_name` varchar(100) NOT NULL,
  `base_price` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Индексы сохранённых таблиц
--

--
-- Индексы таблицы `customers`
--
ALTER TABLE `customers`
  ADD PRIMARY KEY (`customer_id`);

--
-- Индексы таблицы `orders`
--
ALTER TABLE `orders`
  ADD PRIMARY KEY (`order_id`),
  ADD KEY `fk_orders_customer` (`customer_id`);

--
-- Индексы таблицы `order_items`
--
ALTER TABLE `order_items`
  ADD PRIMARY KEY (`item_id`),
  ADD KEY `fk_order_items_order` (`order_id`);

--
-- Индексы таблицы `pizzas`
--
ALTER TABLE `pizzas`
  ADD PRIMARY KEY (`pizza_id`);

--
-- AUTO_INCREMENT для сохранённых таблиц
--

--
-- AUTO_INCREMENT для таблицы `customers`
--
ALTER TABLE `customers`
  MODIFY `customer_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=19;

--
-- AUTO_INCREMENT для таблицы `orders`
--
ALTER TABLE `orders`
  MODIFY `order_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=19;

--
-- AUTO_INCREMENT для таблицы `order_items`
--
ALTER TABLE `order_items`
  MODIFY `item_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=21;

--
-- AUTO_INCREMENT для таблицы `pizzas`
--
ALTER TABLE `pizzas`
  MODIFY `pizza_id` int(11) NOT NULL AUTO_INCREMENT;

--
-- Ограничения внешнего ключа сохраненных таблиц
--

--
-- Ограничения внешнего ключа таблицы `orders`
--
ALTER TABLE `orders`
  ADD CONSTRAINT `fk_orders_customer` FOREIGN KEY (`customer_id`) REFERENCES `customers` (`customer_id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Ограничения внешнего ключа таблицы `order_items`
--
ALTER TABLE `order_items`
  ADD CONSTRAINT `fk_order_items_order` FOREIGN KEY (`order_id`) REFERENCES `orders` (`order_id`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
