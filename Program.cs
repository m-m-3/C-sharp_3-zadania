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
        Console.Clear();
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
            Console.WriteLine("Nie obsługuję takiej operacji!");
            Pauza();
            return;
        }
        Pauza();
    }

    static void KonwerterTemperatury()
    {
        Console.Clear();
        Console.WriteLine("=== KONWERTER (C <-> F) ===");
        Console.WriteLine("Jaką temperaturę chcesz skonwertować (C/F)?");
        string konwersjaZ = (Console.ReadLine() ?? "").Trim().ToUpper();
        
        if (konwersjaZ != "C" && konwersjaZ != "F")
        {
            Console.WriteLine("Nie obsługuję takiej operacji!");
            Pauza();
            return;
        }
                
        Console.WriteLine("Podaj temperaturę:");
        double temperatura = WczytajLiczbe();

        if (konwersjaZ == "C")
        {
            Console.WriteLine($"{temperatura}°C = {(temperatura * 1.8) + 32.0}°F");
        } else 
        {
            Console.WriteLine($"{temperatura}°F = {(temperatura - 32.0) / 1.8}°C");
        }

        Pauza();
    }
    static void ObliczSredniaOcen()
    {
        Console.Clear();
        Console.WriteLine("=== OBLICZ ŚREDNIĄ OCEN ===");
        Console.WriteLine("Ile ocen ma uczeń?");
        int liczbaOcen = (int) WczytajLiczbe();
        
        if (liczbaOcen <= 0)
        {
            Console.WriteLine("Uczeń nie ma ocen!");
            Pauza();
            return;
        }

        double suma = 0;

        for (int i = 1; i <= liczbaOcen; i++)
        {
            Console.Write($"Podaj ocenę nr {i}: ");
            double ocena = WczytajLiczbe();

            while (ocena < 1 || ocena > 6)
            {
                Console.Write($"Nieprawidłowa ocena, podaj ponownie: ");
                ocena = WczytajLiczbe();
            }

            suma += ocena;
        }

        double srednia = suma / liczbaOcen;
                
        Console.WriteLine($"Średnia ucznia to: {srednia:f2}");
        if (srednia >= 3.0)
        {
            Console.WriteLine("Uczeń zdał.");
        } else
        {
            Console.WriteLine("Uczeń nie zdał.");
        }
        Pauza();
    }
}