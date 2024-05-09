Console.WriteLine("Sprawdzamy czy podana przez Ciebie liczba jest parzysta lub nieparzysta");
Console.WriteLine("Podaj dowolną liczbę: ");



while (true)
{
    var number = AddNumber();

    if (number % 2 == 0)
    {
        Console.WriteLine("Liczba jest parzysta.");
    }
    else
    {
        Console.WriteLine("Liczba jest nieparzysta");
    }

    Console.WriteLine("\nPodaj następną liczbę: \n\tJeżeli chcesz zakończyć naciśnij 'q'");
}


static int AddNumber()
{
    while (true)
    {
        var val = Console.ReadLine();
        if (val.ToUpper() == "Q")
        {
            Environment.Exit(0);
        }

        if (!int.TryParse(val, out int number))
        {
            Console.WriteLine("Podano nieprawidłową wartość. Spróbuj ponownie - podaj dowolną liczbę: ");
            continue;

        }
        return number;
    }
}
