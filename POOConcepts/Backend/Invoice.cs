namespace Backend;

public class Invoice : IPay
{
    // Constructors
    public Invoice(int id, string description, decimal price, float quantity)
    {
        Id = id;
        Description = description;
        Price = price;
        Quantity = quantity;
    }

    // Properties
    public int Id { get; set; }

    public string Description { get; set; } = null!;

    public decimal Price { get; set; }

    public float Quantity { get; set; }

    // Public Methods
    public decimal GetValueToPay() => Price * (decimal)Quantity;

    public override string ToString() => $"{Id}\t{Description}\n\t" +
            $"Quantity.......: {Quantity,20:N2}\n\t" +
            $"Price..........: {Price,20:C2}\n\t" +
            $"Value..........: {GetValueToPay(),20:C2}";
}