using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("=== MENU ===");
            Console.WriteLine("1. Prosty kalkulator");
            Console.WriteLine("2. Konwerter temperatur (C <-> F)");
            Console.WriteLine("3. Średnia ocen ucznia");
            Console.WriteLine("0. Wyjście");
            Console.Write("Wybierz opcję: ");

            string? choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Kalkulator();
                    break;
                case "2":
                    KonwerterTemperatury();
                    break;
                case "3":
                    ObliczSredniaOcen();
                    break;
                case "0":
                    return;
                default:
                    Console.WriteLine("Niepoprawny wybór.");
                    Console.ReadLine();
                    break;
            }
        }
    }

    static double WczytajLiczbe()
    {
        while(true)
        {
            if (double.TryParse(Console.ReadLine(), out double liczba))
            {
                return liczba;
            } else
            {
                Console.Write("Błąd, wpisz prawidłową liczbę: ");
            }
        }
    }

    static void Pauza()
    {
        Console.WriteLine("Wciśnij Enter, aby wrócić do menu...");
        Console.ReadLine();
    }

    static void Kalkulator()
    {
        Console.WriteLine("=== KALKULATOR ===");
        Console.WriteLine("Podaj pierwszą liczbę:");
        double a = WczytajLiczbe();
        Console.WriteLine("Podaj drugą liczbę:");
        double b = WczytajLiczbe();
        Console.WriteLine("Wybierz operację (+, -, * lub /): ");
        
        string? operacja = Console.ReadLine();
        
        if (operacja == "+")
        {
            Console.WriteLine($"Wynik:  {a + b}");
        } else if (operacja == "-") {
            Console.WriteLine($"Wynik:  {a - b}");
        } else if (operacja == "*") {
            Console.WriteLine($"Wynik:  {a * b}");
        } else if (operacja == "/") {
            if (b == 0)
            {
                Console.WriteLine("Nie można dzielić przez 0!");
                Pauza();
                return;
            }
            Console.WriteLine($"Wynik: {a / b}");
        } else
        {
            Console.WriteLine("Nie obługuję takiej operacji!");
            Pauza();
            return;
        }
        Pauza();
    }

    static void KonwerterTemperatury()
    {
        
    }
    static void ObliczSredniaOcen()
    {
        
    }
}
    
        
