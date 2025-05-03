-- Test SQL Script with various table definitions
-- Simple CREATE TABLE
CREATE TABLE users (
    id INT PRIMARY KEY,
    username VARCHAR(50) NOT NULL,
    email VARCHAR(100) UNIQUE,
    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP
);

-- CREATE TABLE with IF NOT EXISTS
CREATE TABLE IF NOT EXISTS products (
    product_id INT AUTO_INCREMENT PRIMARY KEY,
    name VARCHAR(100) NOT NULL,
    price DECIMAL(10, 2),
    description TEXT
);

-- CREATE TABLE with quoted name
CREATE TABLE "order_items" (
    order_id INT,
    product_id INT,
    quantity INT,
    price DECIMAL(10, 2),
    PRIMARY KEY (order_id, product_id)
);

-- CREATE TABLE with backticks
CREATE TABLE `orders` (
    id INT PRIMARY KEY,
    user_id INT,
    total_amount DECIMAL(10, 2),
    status VARCHAR(20),
    FOREIGN KEY (user_id) REFERENCES users(id)
);

-- CREATE TABLE with square brackets
CREATE TABLE [categories] (
    id INT PRIMARY KEY,
    name VARCHAR(50) NOT NULL,
    parent_id INT NULL
);

-- CREATE TEMPORARY TABLE
CREATE TEMPORARY TABLE temp_stats (
    date DATE,
    visits INT,
    conversions INT
);

/* 
Multi-line comment with a fake table
CREATE TABLE fake_table (
    id INT
);
*/

-- Commented table
-- CREATE TABLE another_fake_table (id INT);

-- Table with schema
CREATE TABLE public.audit_logs (
    id SERIAL PRIMARY KEY,
    action VARCHAR(50),
    table_name VARCHAR(50),
    record_id INT,
    user_id INT,
    timestamp TIMESTAMP DEFAULT CURRENT_TIMESTAMP
); 