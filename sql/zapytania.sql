use Biblioteka;

select Loans.id_wypozyczenia, Books.tytul, Members.nazwisko 
from Loans
inner join Books on Loans.id_ksiazki = Books.id_ksiazki
inner join Members on Loans.id_czlonka = Members.id_czlonka;

select Loans.id_wypozyczenia, Books.tytul, Members.nazwisko 
from Loans
inner join Books on Loans.id_ksiazki = Books.id_ksiazki
inner join Members on Loans.id_czlonka = Members.id_czlonka
where Loans.data_zwrotu is NULL; 

select Members.nazwisko, count(*) as liczba_wypozyczen
from Members
join Loans on Members.id_czlonka = Loans.id_czlonka
where Members.id_czlonka = Loans.id_czlonka
group by Members.nazwisko;

select Members.nazwisko, count(*) as liczba_wypozyczen
from Members
join Loans on Members.id_czlonka = Loans.id_czlonka
where Members.id_czlonka = Loans.id_czlonka
group by Members.nazwisko
having count(*) > 1; 

select Books.tytul
from Books
left join Loans on Books.id_ksiazki = Loans.id_ksiazki
where Loans.id_ksiazki is  NULL;


select Members.id_czlonka, Members.imie, Members.nazwisko
from Members
left join Loans on Members.id_czlonka = Loans.id_czlonka
where Loans.id_czlonka is  NULL;






