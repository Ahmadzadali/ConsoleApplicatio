namespace Magazine;

public class Customer
{
    private static int _count;
    public int Id { get; set; }

    public string Name { get; set; }

    public string Contry { get; set; }
    public Customer()
    {
        _count++;
        Id = _count;
    }
    

}
