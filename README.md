Jest to prosty system biblioteki z bazą danych. Projekt powstaje w celach edukacyjnych ćwicząc C# i SQL.

W projekcie jest używana technologia SQL Server (Express) 25, SSMS 22, oraz Dotnet 11.0.

Na ten moment jest to konsolowa aplikacja na liście oraz baza danych, które docelowo będą ze sobą połączone.

Aby uruchomić aplikacje: 
1) pobrać zawartość repozytorium
2) wypakować zawartość pliku .zip
3) otworzyć w środowisku programistycznym, np. Visual Studio Code z zainstalowanym rozszerzeniem C#
4) wybrać folder projektu
5) otworzyć terminal
6) wpisać komendę "dotnet run".

Aby postawić bazę danych:
1) mieć zainstalowany SQL Server 25
2) zainstalować oraz uruchomić narzędzie SSMS 22
3) otworzyć nowe zapytanie
4) przekleić zawartość pliku "1", który tworzy całą bazę, tabele oraz dodaje do nich testowe rekody, znajdującego się w folderze "sql"
5) wykonać zapytanie
6) sprawdzić czy się udało zapytaniem np. "SELECT * FROM Books"

Zapytania znajdujące się w pliku "zapytania" w folderze "sql" dowodzą ćwiczeń wykonywanych na bazie danych, w których utrwalałem polecenia w SQL takie jak: JOIN-y, GROUP BY z HAVING oraz wyszukiwanie rekordów bez pary.

Baza składa się z trzech tabel: "Books", "Members" i "Loans". W tabeli "Books" znajdują się wszystkie książki jakie posiada biblioteka. Tabela "Members" zawiera informacje o członkach biblioteki. 
Tabela "Loans" przechowuje informacje odnośnie każdego wypożyczenia, posiada ona również relacje z tabelami "Books" - poprzez pole "id_ksiazki" oraz "Members" - poprzez pole "id_czlonka". 

