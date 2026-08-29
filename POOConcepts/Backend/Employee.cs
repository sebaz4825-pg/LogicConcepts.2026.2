namespace Backend;
public abstract class Employee :IPay 
{
    //Contructors
    protected Employee(int id,string firsName, string lastName, Date bornDate, Date hireDate,bool isActive)
    {
        Id = id;
        FirstName = firsName;
        LastName = lastName;
        BornDate = bornDate;
        HireDate = hireDate;
        IsaActive = isActive;
    }

    // Properties
    public int Id { get; set; } 
    public  string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public bool IsaActive { get; set; }
    public  Date BornDate { get; set; } = null!;
    public Date HireDate { get; set; } = null!;

    // public Methods
    public abstract decimal GetValueToPay();
    public override string ToString() => $"{Id}\t{FirstName} {LastName}\n\t" +
            $"Born date.....:   {BornDate,20}\n\t" +
            $"Hire date.....:   {HireDate,20}\n\t";
           
     


}
