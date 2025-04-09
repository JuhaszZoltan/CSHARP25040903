-- CREATE DATABASE peopledb;
-- USE peopledb;

CREATE TABLE people (
  id INT PRIMARY KEY IDENTITY,
  name VARCHAR(60) NOT NULL,
  birth DATE NULL,
  sex BIT);

INSERT INTO people VALUES
('Juhász Zoltán', '1990-07-11', 1),
('Viz Elek', '1989-05-30', 1),
('Para Zita', '1993-07-17', 0),
('Végh Béla', '2004-01-02', 1);