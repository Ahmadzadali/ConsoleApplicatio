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
    public OrderStatus _UpdateStatus {  get; set; }
    public CargoOrder()
    {
        _count++;
        Id = _count;
    }


    public void UpdateStatus(OrderStatus status)
    {
        if (status == OrderStatus.Cancelled)
        {
            Console.WriteLine("Sifaris legv olunub.");
        }
        if (status == OrderStatus.Delivered)
        {
            Console.WriteLine("Sifaris Tamamlanb");
        }
        else
        {
            _UpdateStatus = status;
            Console.WriteLine("Status deyisildi.");
        }
    }


}
