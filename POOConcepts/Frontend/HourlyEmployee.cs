using Backend;

internal class HourlyEmployee : IPay
{
    private int v1;
    private string v2;
    private string v3;
    private Date date1;
    private Date date2;
    private bool v4;
    private int v5;
    private float v6;

    public HourlyEmployee()
    {
    }

    public HourlyEmployee(int v1, string v2, string v3, Date date1, Date date2, bool v4, int v5, float v6)
    {
        this.v1 = v1;
        this.v2 = v2;
        this.v3 = v3;
        this.date1 = date1;
        this.date2 = date2;
        this.v4 = v4;
        this.v5 = v5;
        this.v6 = v6;
    }
}