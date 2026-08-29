using Backend;


try
{
    //var date1 = new Date();
    //var date2 = new Date(2028, 2, 29);
    //var date3 = new Date(2026, 12, 3);
    //Console.WriteLine(date1);
    //Console.WriteLine(date2);
    //Console.WriteLine(date3);

    var employee1 = new SalaryEmployee(1010, "Marta", "Lopez", new Date(1976, 1, 13), new Date(2020, 11, 20), true, 2100000);
    var employee2 = new CommissionEmployee(2020, "Sandra", "Cardona", new Date(2000, 12, 3), new Date(2020, 11, 30), true, 0.03f, 800000000);
    var employee3 = new CommissionEmployee(3030, "Hector", "Pulido", new Date(2000, 12, 3), new Date(2020, 11, 30), true, 0.03f, 26000000);
    var employee4 = new HourlyEmployee(4040, "Victor", "Maldonado", new Date(2000, 12, 3), new Date(2020, 11, 30), true, 25000, 113.5f);
    var employee5 = new HourlyEmployee(5050, "Dora", "Ruiz", new Date(2000, 12, 3), new Date(2020, 11, 30), true, 67000, 81);
    var employee6 = new BaseCommissionEmployee(6060, "Lucia", "Cardenas", new Date(2000, 12, 3), new Date(2020, 11, 30), true, 0.0125f, 80000000, 600000);
    var invoice1 = new Invoice(10001, "Computador Portatil HP5200", 4800000, 5);
    var invoice2 = new Invoice(10002, "Sillas escritorio", 1230000, 8);

    var expenses = new List<IPay> { employee1, employee2, employee3, employee4, employee5, employee6, invoice1, invoice2 };
    decimal total = 0;
    foreach (var expense in expenses)
    {
        Console.WriteLine("----------------------------------------------------");
        Console.WriteLine(expense);
        total += expense.GetValueToPay();
    }
    Console.WriteLine("=============================================");
    Console.WriteLine($"TOTAL..................: {total,20:C2}");
    Console.WriteLine("=============================================");

}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}


