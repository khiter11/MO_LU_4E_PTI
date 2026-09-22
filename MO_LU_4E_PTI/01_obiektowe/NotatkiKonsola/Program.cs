using System;

namespace NotatkiKonsola
{
    /// <summary>
    /// Nazwa klasy: Notatka
    /// Opis: Klasa reprezentująca pojedynczą notatkę z tytułem, treścią, unikalnym identyfikatorem oraz licznikiem obiektów.
    /// Pola: licznik (static int), identyfikator (int), tytuł (string), treść (string).
    /// Metody: WyswietlNotatke(), WyswietlDiagnostyke().
    /// Autor: [Twoje Imię i Nazwisko / Numer z dziennika]
    /// </summary>
    public class Notatka
    {
        // Pola klasy (zgodnie z wymaganiami dotyczącymi widoczności)
        private static int licznik = 0;
        private int identyfikator;
        protected string tytul;
        protected string tresc;

        /// <summary>
        /// Konstruktor inicjalizujący nową notatkę podanym tytułem i treścią.
        /// </summary>
        /// <param name="tytul">Tytuł notatki</param>
        /// <param name="tresc">Treść notatki</param>
        public Notatka(string tytul, string tresc)
        {
            licznik++;
            this.identyfikator = licznik;
            this.tytul = tytul;
            this.tresc = tresc;
        }

        /// <summary>
        /// Wyświetla tytuł i treść notatki w czytelnej formie.
        /// </summary>
        public void WyswietlNotatke()
        {
            Console.WriteLine($"=== NOTATKA (ID: {identyfikator}) ===");
            Console.WriteLine($"Tytuł: {tytul}");
            Console.WriteLine($"Treść: {tresc}");
            Console.WriteLine(new string('-', 30));
        }

        /// <summary>
        /// Metoda diagnostyczna wypisująca wszystkie pola obiektu rozdzielone średnikami.
        /// </summary>
        public void WyswietlDiagnostyke()
        {
            // Zapisujemy stan pól: Licznik ogólny, ID obiektu, Tytuł, Treść
            Console.WriteLine($"[DIAGNOSTYKA] Licznik: {licznik}; Identyfikator: {identyfikator}; Tytuł: {tytul}; Treść: {tresc}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- URUCHOMIENIE TESTÓW KLASY NOTATKA ---\n");

            // Tworzenie pierwszego obiektu
            Notatka notatka1 = new Notatka("Plan dnia", "1. Nauka C#\n2. Spacer\n3. Zakupy");

            // Tworzenie drugiego obiektu
            Notatka notatka2 = new Notatka("Zakupy", "Mleko, chleb, jajka, owoce");

            // Testowanie metod dla pierwszego obiektu
            notatka1.WyswietlNotatke();
            notatka1.WyswietlDiagnostyke();

            Console.WriteLine();

            // Testowanie metod dla drugiego obiektu
            notatka2.WyswietlNotatke();
            notatka2.WyswietlDiagnostyke();

            // Oczekiwanie na klawisz, aby konsola nie zamknęła się od razu po uruchomieniu
            Console.WriteLine("\nNaciśnij dowolny klawisz, aby zakończyć...");
            Console.ReadKey();
        }
    }
}