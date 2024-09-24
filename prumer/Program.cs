class Program
{
    static void Main()
    {
        Console.WriteLine("Kolik čísel chceš zadat?");
        int pocetCisel;
        while (!int.TryParse(Console.ReadLine(), out pocetCisel) || pocetCisel == 0)
        {
            Console.WriteLine("Zadejte číslo mezi 0-100");
            Console.WriteLine("Kolik čísel chceš zadat");
        }
        List<int> cisla = new List<int>();
        int rozsahMin = 1, rozsahMax = 100;
        for (int i = 0; i < pocetCisel; i++)
        {
            while (true)
            {
                Console.WriteLine($"Zadej číslo {i + 1} nebo ´Konec´ pro ukončení");
                string vstup = Console.ReadLine();

                if (vstup.ToLower() == "konec")
                {
                    Console.WriteLine("Zadávání bylo ukončeno");
                    break;
                }

                int cislo;
                if (int.TryParse(vstup, out cislo))
                {
                    if (cislo > rozsahMin && cislo <= rozsahMax)
                    {
                        cisla.Add(cislo);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Zadej platné číslo");
                    }
                }
            }

            if (cisla.Count > 0)
            {
                double prumer = cisla.Average();
                Console.WriteLine($"Zadal jsi {cisla.Count} platných čísel");
                Console.WriteLine($"Průměr zadaných čísel je: {prumer:F2}");
            }
            else
            {
                Console.WriteLine("Nezadal jsi žádný platný čísla");
            }
        }
    }
}