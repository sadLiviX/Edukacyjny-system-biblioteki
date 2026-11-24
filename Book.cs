using System;
namespace Biblioteka
{
    class Book
    {
        static void Main(string[] args)
        {
            bool running = true;

            var ksiazki = new List<Ksiazka>
            {
                new Ksiazka(1, "Pan Tadeusz", "Adam Mickiewicz", true),
                new Ksiazka(2, "Lalka", "Bolesław Prus", false),
                new Ksiazka(3, "Wiedźmin", "Andrzej Sapkowski", false),
                new Ksiazka(4, "Gra o tron", "George R. R. Martin", true),
                new Ksiazka(5, "Harry Potter", "J. K. Rowling", true),
                new Ksiazka(6, "Władca Pierścieni", "J. R. R. Tolkien", false)

            };

            while(running){
            Console.WriteLine("""
            Witaj w systemie naszej biblioteki! 
            1. Chce wyświetlić listę wszystkich książek. 
            2. Chcę wypożyczyć książkę. 
            3. Chce oddać książkę. 
            4. Wyjście. 
            """);

            Console.WriteLine("Wybierz opcje: ");
            string? input_string = Console.ReadLine();
            if(int.TryParse(input_string, out int input_int)){
            switch (input_int)
            {
                case 1:
                    foreach (var ksiazka in ksiazki)
                        {
                            Console.WriteLine($"{ksiazka.id}: Tytuł: {ksiazka.tytul}, Autor: {ksiazka.autor}, Czy można wypożyczyć: {ksiazka.status}");
                        }

                    Console.WriteLine("Aby powrócić do głównego menu kliknij enter");
                    ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                    break;
                case 2:
                   foreach (var ksiazka in ksiazki)
                        {
                            Console.WriteLine($"{ksiazka.id}: Tytuł {ksiazka.tytul}, Czy można wypożyczyć: {ksiazka.status}");
                        }
                    Console.WriteLine("Wpisz numer ksiązki którą chcesz wypożyczyć: ");
                    string? pozycja_borrow = Console.ReadLine();
                    if(int.TryParse(pozycja_borrow, out int pozycja_borrow_int)){
                    foreach (var ksiazka in ksiazki){
                    if (pozycja_borrow_int == ksiazka.id)
                    {
                        try
                        {
                            ksiazka.Borrow();
                      
                        }
                        catch(InvalidOperationException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                    }
                    }
                    else
                        {
                            Console.WriteLine("Podano niedozwolony znak!");
                            break;
                        }
                    break;
                case 3:
                   foreach (var ksiazka in ksiazki)
                        {
                            Console.WriteLine($"{ksiazka.id}: Tytuł {ksiazka.tytul}, Czy można wypożyczyć: {ksiazka.status}");
                        }
                    Console.WriteLine("Wpisz numer książki którą chcesz oddać: ");
                    string? pozycja_return_string = Console.ReadLine();
                    if(int.TryParse(pozycja_return_string, out int pozycja_return_int)){
                    foreach (var ksiazka in ksiazki){
                    if (pozycja_return_int == ksiazka.id)
                    {
                        try
                            {
                                ksiazka.Return();
                            }
                        catch(InvalidOperationException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                    }
                    break;
                    }
                    else
                            {
                                Console.WriteLine("Podano niedozwolony znak!");
                                break;
                            }
                case 4:
                running = false;
                    break;
            }
            }
            else
                {
                    Console.WriteLine("Podano niedozwolony znak!");
                }

        }
    }
    }
    class Ksiazka
    {
        public int id;
        public string tytul;
        public string autor;
        public bool status;
        public Ksiazka(int Id, string Tytul, string Autor, bool Status) {id = Id; tytul = Tytul; autor = Autor; status = Status; }

        public void Borrow()
        {
            if (status)
            {
            Console.WriteLine($"Książka o ID: {id}, została wypożyczona!\n");
            status = false;
            }
            else
            {
                throw(new InvalidOperationException("Tej książki nie można wypożyczyć, ponieważ jest już wypożyczona!\n"));
            }
        }

        public void Return()
        {
            if (!status)
            {
            Console.WriteLine($"Książka o ID: {id}, została zwrócona! Dziękujemy.\n");
            status = true;
            }
            else
            {
                throw (new InvalidOperationException("Tej książki nie można oddać, ponieważ nie jest wypożyczona!\n"));
            }
        }
    }
}