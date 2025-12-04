using Magazine.Models.Enums;

namespace Magazine.Models;

public class CargoOrder
{
    private static int _count;
    public int Id { get; set; }
    public int CustomerId { get; set; }
    public int CourierId { get; set; }
    public int Total  { get; set; }
    public DateTime Createdat { get; set; }
    public OrderStatus UpdateStatus {  get; set; }
    public CargoOrder()
    {
        _count++;
        Id = _count;
    }
}
