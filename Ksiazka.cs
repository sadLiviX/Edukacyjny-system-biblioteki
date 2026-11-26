namespace Biblioteka
{
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

        public static void Wypisz(List<Ksiazka> ksiazki)
        {
            foreach(var ksiazka in ksiazki)
            {
                Console.WriteLine($"{ksiazka.id}: Tytuł {ksiazka.tytul}, Autor: {ksiazka.autor}, Czy można wypożyczyć: {ksiazka.status}");
            }
        }


    }
}