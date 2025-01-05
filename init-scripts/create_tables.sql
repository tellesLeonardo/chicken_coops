-- Criação do banco de dados
-- Não há a cláusula "IF NOT EXISTS" para banco no PostgreSQL
-- Você pode verificar se o banco existe antes de criá-lo, como mostrei antes

-- Criação do banco de dados
CREATE DATABASE galinheiroDB;

-- Conectar ao banco galinheiroDB (isso seria feito manualmente após o banco ser criado)

-- Tabela de Status das Galinhas
CREATE TABLE IF NOT EXISTS chicken_status (
    id SERIAL PRIMARY KEY,
    chick VARCHAR(50),
    rebreeder_1 VARCHAR(50),
    rebreeder_2 VARCHAR(50),
    pre_laying VARCHAR(50),
    production VARCHAR(50)
);

-- Tabela de Galpões (Shed)
CREATE TABLE IF NOT EXISTS shed (
    id SERIAL PRIMARY KEY,
    location VARCHAR(255),
    postcode VARCHAR(100),
    current_chickens_count INT,
    max_chickens_capacity INT
);

-- Tabela de Galinhas (Chickens)
CREATE TABLE IF NOT EXISTS chickens (
    id SERIAL PRIMARY KEY,
    birth_date DATE,
    name VARCHAR(100),
    photo VARCHAR(255),
    vaccinated BOOLEAN,
    status_id INT,
    FOREIGN KEY (status_id) REFERENCES chicken_status(id)
);

-- Tabela de Ovos (Eggs)
CREATE TABLE IF NOT EXISTS eggs (
    id SERIAL PRIMARY KEY,
    quantity INT,
    date DATE,
    chicken_id INT,
    FOREIGN KEY (chicken_id) REFERENCES chickens(id)
);

-- Tabela de Rações (Feeds)
CREATE TABLE IF NOT EXISTS feeds (
    id SERIAL PRIMARY KEY,
    feed_type VARCHAR(100),
    quantity_kg INT,
    purchase_date DATE,
    shed_id INT,
    FOREIGN KEY (shed_id) REFERENCES shed(id)
);
