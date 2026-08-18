
namespace Backend;

    public class SalaryEmployee : Employee
    {
    // Fields
    private decimal _salary;

    //Constructors
    public SalaryEmployee(int id, string firsName, string lastName, Date bornDate, Date hireDate, bool isActive,decimal salary)
        : base(id, firsName, lastName, bornDate, hireDate,isActive)
    {
        Salary = salary;
    }
    //Properties
    public decimal Salary
    {
        get => _salary;
        set => _salary = ValidateSalary(value);
    }
    public override string ToString()
    {
        return $"{base.ToString()}\n\tSalary.........:  {GetValueToPay(),20:c2}";
    }


    public override decimal GetValueToPay()
    {
        return Salary;
    }

    //Private methods
    private decimal ValidateSalary(decimal salary)
    {
        if (salary < 2000000)
        {
            throw new Exception($"The salary: {salary:c2}, is less than the minimum.");

        }
        return salary;
    }
   }

