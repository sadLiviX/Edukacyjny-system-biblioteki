using System;
namespace Biblioteka
{
    class Book
    {
        static void Main(string[] args)
        {
            Ksiazka ksiazka1 = new Ksiazka();
            Ksiazka ksiazka2 = new Ksiazka();

            ksiazka1.tytul = "Pan Tadeusz";
            ksiazka1.autor = "Adam Mickiewicz";
            ksiazka1.status = true;
            ksiazka1.id = 1;

            ksiazka2.tytul = "Lalka";
            ksiazka2.autor = "Bolesław Prus";
            ksiazka2.status = false;
            ksiazka2.id = 2;

            Console.WriteLine("""
            Witaj w systemie naszej biblioteki! 
            1. Chce wyświetlić listę wszystkich książek. 
            2. Chcę wypożyczyć książkę. 
            3. Chce oddać książkę. 
            4. Wyjście. 
            """);

            Console.WriteLine("Wybierz opcje: ");
            int input = int.Parse(Console.ReadLine());

            switch (input)
            {
                case 1:
                    ksiazka1.WypiszInfo(ksiazka1.tytul, ksiazka1.autor, ksiazka1.status);
                    ksiazka2.WypiszInfo(ksiazka2.tytul, ksiazka2.autor, ksiazka2.status);
                    break;
                case 2:
                    ksiazka1.WypiszId(ksiazka1.id, ksiazka1.tytul);
                    ksiazka2.WypiszId(ksiazka2.id, ksiazka2.tytul);

                    Console.WriteLine("Wpisz ID ksiązki którą chcesz wypożyczyć: ");
                    int input2 = int.Parse(Console.ReadLine());
                    if (input2 == 1)
                    {
                        ksiazka1.Borrow(ksiazka1.id, ksiazka1.status);
                    }
                    else if (input2 == 2)
                    {
                        ksiazka2.Borrow(ksiazka2.id, ksiazka2.status);        
                    }
                    else
                    {
                        return;            
                    }
                    break;
                case 3:
                    ksiazka1.WypiszId(ksiazka1.id, ksiazka1.tytul);
                    ksiazka2.WypiszId(ksiazka2.id, ksiazka2.tytul);

                    Console.WriteLine("Wpisz ID książki którą chcesz oddać: ");
                    int input3 = int.Parse(Console.ReadLine());
                    if (input3 == 1)
                    {
                        ksiazka1.Return(ksiazka1.id, ksiazka1.status);
                    }
                    else if (input3 == 2)
                    {
                        ksiazka2.Return(ksiazka1.id, ksiazka2.status);
                    }
                    else
                    {
                        break;
                    }
                    break;
                case 4:
                    break;
            }

        }
    }
    class Ksiazka
    {
        public string tytul;
        public string autor;
        public bool status;
        public int id;

        public void WypiszInfo(string tyl, string aut, bool stat)
        {
            Console.WriteLine($"Książka o tytule: {tyl} \nnapisana przez autora: {aut} \nczy jest możliwa do wypożyczenia: {stat}\n");
        }

        public void WypiszId(int id, string tyl)
        {
            Console.WriteLine($"ID: {id} \nTytuł: {tyl}");
        }

        public void Borrow(int id, bool stat)
        {
            bool status = false;
            Console.WriteLine($"Książka o ID: {id}, została wypożyczona!");
        }

        public void Return(int id, bool stat)
        {
            bool status = true;
            Console.WriteLine($"Książka o ID: {id}, została zwrócona! Dziękujemy.");
        }
    }
}