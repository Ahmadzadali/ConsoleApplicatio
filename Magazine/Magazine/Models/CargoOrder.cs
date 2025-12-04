using Magazine.Models.Enums;

namespace Magazine.Models;

public class CargoOrder
{
    private static int _count;
    public int Id { get; set; }
    public int CustomerId { get; set; }
    public int CourierId { get; set; }
    public int Total  { get; set; }
<<<<<<< refs/remotes/origin/riad2
    public DateTime Createdat { get; set; }
    public OrderStatus UpdateStatus {  get; set; }
=======
    public DateTime Createdat { get; set; }= DateTime.Now;
    public OrderStatus _UpdateStatus {  get; set; }=OrderStatus.Created;
>>>>>>> local
    public CargoOrder()
    {
        _count++;
        Id = _count;
    }
<<<<<<< refs/remotes/origin/riad2
=======


    public void UpdateStatus(OrderStatus status)
    {
        if (_UpdateStatus == OrderStatus.Cancelled || _UpdateStatus==OrderStatus.Delivered)
        {
            Console.WriteLine("Sifaris legv olunub ve ya tamamlanib");
        }
        _UpdateStatus = status;
        if (status == OrderStatus.Delivered)
        {
            Console.WriteLine("sifaris tamamlanib");
        }
        if (status == OrderStatus.Cancelled)
        {
            Console.WriteLine("sifaris levg olunub");
        }
        else
        {
            Console.WriteLine($"sifaris update olundu: {status}");
        }
    }


>>>>>>> local
}
