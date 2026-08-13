using Shared;

do
{

    var a = ConsoleExtension.GetInt("Ingrese primer número: ");
    var b = ConsoleExtension.GetInt("Ingrese segundo número: ");
    if (b % a == 0)
    {
        Console.WriteLine($"{a} es Múltiplo {b}");
    }
    else
    {
        Console.WriteLine($"{a} no es Múltiplo {b}");
    }

} while (true);