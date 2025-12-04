namespace Magazine.Models;

public class Courier
{
    private static int _count;
    public int Id { get; set; }

    public string Name { get; set; }

    public bool IsAvailable { get; set; } = true;
    public Courier()
    {
        _count++;
        Id = _count;
    }
}
