using System.ComponentModel;

namespace Backend;

public class CommissionEmployee : Employee
{

    //Fields
    private float _commissionPercentage;
    private decimal _sales;
   
    //Constructors

    public CommissionEmployee(int id, string firsName, string lastName, Date bornDate, Date hireDate, bool isActive, float v, int v1) : base(id, firsName, lastName, bornDate, hireDate,isActive)
    {
        CommissionPercentage = _commissionPercentage;
        Sales = _sales;

    }

    // Properties
    public float CommissionPercentage
    {
        get => _commissionPercentage;
        set => _commissionPercentage = ValidateCommissionPercentage(value);
    }

    

    public decimal Sales
    {
        get => _sales;
        set => _sales = ValidateSales(value);

    }
    public override string ToString()
    {
        return $"{Id}\t{FirstName} {LastName}\n\t" +
            $"Born date.....: {BornDate,20}\n\t" +
            $"Hire date.....: {HireDate,20}\n\t" +
            $"Salary........: {GetValueToPay(),20:c2}";
    }
    //Public methods
    public override decimal GetValueToPay() => _sales * (decimal)_commissionPercentage;


   //Private methods
    private float ValidateCommissionPercentage(float commissionPercentage)
    {
      if (commissionPercentage < 0 || commissionPercentage > 0.3)
        {
        throw new Exception($"The commission percentage: {commissionPercentage:P2}, is not valide.");
        }
      return commissionPercentage;
    }
    private decimal ValidateSales(decimal sales)
      {
        if (sales < 0 )
        {
           throw new Exception($"The sales: {sales:C2}, is not valid.");

        }
        return sales;

 }
}