using Shared;

var answer = string.Empty;
var options = new List<string> { "s", "n" };

do
{
    var weigth = ConsoleExtension.GetFloat("Peso de la Mercancía.....: ");
    var value = ConsoleExtension.GetDecimal("Valor de la mercancía.....: ");
    var isMonday;

    do
    {
        isMonday = ConsoleExtension.GetValidOptions("¿Deseas continuar [S]í, [N]o.......: ", options)!;
    } while (!options.Any(x => x.Equals(isMonday, StringComparison.CurrentCultureIgnoreCase)));
    
        var payMethods = new List<string> { "e", "t" };
        string payMethod;

    do
    { 

        payMethod = ConsoleExtension.GetValidOptions("Tipo de pago [E]fectivo [T]arjeta ", options);
    } while (!options.Any(x => x.Equals(isMonday, StringComparison.CurrentCultureIgnoreCase)));

    var fare = CalculateFare(weigth);
    var discount = CalculateDiscount(fare, value);
    decimal promotion = 0;
    if (discount == 0)
    {
        promotion = CalculatePromotion(fare, isMonday, payMethod, value);
    }

    do
    {
        answer = ConsoleExtension.GetValidOptions("¿Deseas continuar [S]í, [N]o?: ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));
} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));

decimal CalculatePromotion(decimal fare, string isMonday, string payMethond, decimsl value)

{
    if (isMonday.ToLower() == "s" && payMethod.ToLOwer() == "t")
    {
        return fare * 0.5;
    }
    if (payMethod.ToLower() == "e" && value > 1000000m
        {
        return fare *0.4;
    }
    return 0; 
}

decimal CalculateDiscount(decimal fare, decimal value)
{
    if (value >= 300000m && value <= 600000m)
    {
        return fare * 0.1m;
    }
    if (value > 600000m && value <= 1000000m)
    { 
        return fare * 0.2m; 
    }

    if (value >= 1000000)
    {
        return fare * 0.3m;
    }
    return  0;
}

object CalculateFare(float weigth)
{
    if (weigth <= 100)
    {
        return 20000m;
    }
    if (weigth <= 150)
    {
        return 25000m;
    }
    if (weigth <= 200)
    {
        return 30000m;
    }
    int aditional = ((int)weigth - 200) / 10; 
    return 35000m + aditional * 2000m;
  }
}

Console.WriteLine("Gamer Over.");