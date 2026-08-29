
namespace Backend;

public class BaseCommissionEmployee : CommissionEmployee
{
    // Fields
    private decimal _salary;

    // Constructors
    public BaseCommissionEmployee(int id, string firstName, string lastName, Date bornDate, Date hireDate, bool isActive, float commissionPercentage, decimal sales,
        decimal salary) : base(id, firstName, lastName, bornDate, hireDate, isActive, commissionPercentage, sales)
    {
        Salary = salary;
    }

    // Properties
    public decimal Salary
    {
        get => _salary;
        set => _salary = ValidateSalary(value);
    }

    // Public Methods
    public override decimal GetValueToPay() => base.GetValueToPay() + Salary;

    public override string ToString() => $"{base.ToString()}\n\t" +
            $"Base salary....: {Salary,20:C2}";

    // Private Methods
    private decimal ValidateSalary(decimal salary)
    {
        if (salary < 500000)
        {
            throw new Exception($"The salary base: {salary:C2}, is less than the $500,000.00.");
        }
        return salary;
    }
}
