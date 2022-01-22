int broj = 27;
do
{
    Console.WriteLine(broj);
    if (broj % 2 == 0)
        broj /= 2;
    else
        broj = broj * 3 + 1;
} while (broj > 1);
Console.WriteLine(broj);

/*bool izlaz = false;
do
{
    StampajMeni();
    Console.Write("Izbor? ");
    string izb = Console.ReadLine();
    switch (izb)
    {
        case "1":
            break;

        case "2":
            break;

        case "3":
            Console.WriteLine("Vozdra");
            izlaz = true;
            break;

        default:
            Console.WriteLine("Jok :/");
            break;
    }
    Console.ReadKey();
    Console.Clear();
} while (!izlaz);

void StampajMeni()
{
    Console.WriteLine("*********************");
    Console.WriteLine("~~1. Unos osobe~~");
    Console.WriteLine("~~2. Prikaz osoba~~");
    Console.WriteLine("~~3. Izlaz~~");
    Console.WriteLine("*********************");
}*/