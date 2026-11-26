create database Biblioteka;

create table Books (
id_ksiazki INT identity(1,1) PRIMARY KEY,
tytul VARCHAR(50) NOT NULL,
autor VARCHAR(50) NOT NULL,
);

insert into Books
values
('Pan Tadeusz', 'Adam Mickiewicz'),
('Lalka', 'Bolesław Brus'),
('Wiedźmin', 'Andrzej Sapkowski'),
('Gra o tron', 'George R. R. Martin'),
('Harry Potter', 'J. K. Rowling'),
('Władca Pierścieni', 'J. R. R. Tolkien'),
('Król w żółci', 'nieznany');

create table Members (
id_czlonka int identity(1,1) primary key,
imie varchar(50) not null,
nazwisko varchar(50) not null
);

insert into Members values
('Dawid', 'Kupis'),
('Adam', 'Szmit'),
('Adrian', 'Mazur'),
('Aleksander', 'Kardaś'),
('Bartosz', 'Rudecki'),
('Jan', 'Nowak'),
('Andrzej', 'Poczytalny'),
('Michał', 'Wątły');

create table Loans (
id_wypozyczenia int identity(1,1) primary key,
id_ksiazki int,
id_czlonka int,
data_wypozyczenia date not null,
data_zwrotu date default null,
constraint fk_id_ksiazki
foreign key (id_ksiazki)
references Books(id_ksiazki)
on delete cascade
on update cascade,
constraint fk_id_czlonka
foreign key (id_czlonka)
references Members(id_czlonka)
on delete cascade
on update cascade
);

insert into Loans values
(2, 6, '2026-11-11', NULL),
(1, 3, '2026-11-19', '2026-11-22'),
(4, 2, '2026-10-10', '2026-10-27'),
(3, 5, '2026-11-24', NULL),
(6, 1, '2026-11-16', NULL),
(5, 4, '2026-11-01', '2026-11-23'),
(1, 2, '2026-10-10', '2026-10-12');
