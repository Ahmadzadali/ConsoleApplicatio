using System.Net.WebSockets;
using System.Threading.Channels;
using Magazine.intrfaces;
using Magazine.Models;
using Magazine.Models.Enums;

namespace Magazine.Services;

public  class ICargoService:ICargoServicee
{
    private readonly List<Customer> Customers = new();
    private readonly List<Courier> Couriers = new();
    public readonly List<CargoOrder> cargoOrders = new List<CargoOrder>();


    public void AddCustomer(Customer customer)
    {
        Customers.Add(customer);
    }

    public void AddCourier(Courier  courier)
    {
        Couriers.Add(courier);
    }
    
    public void CreateOrder(CargoOrder cargoOrder)
    {

        var customer = Customers.FirstOrDefault(x => x.Id == cargoOrder.CustomerId);
        if (customer == null)
            throw new Exception("bele bir costour yoxdur");

        var courier = Couriers.FirstOrDefault(x => x.Id == cargoOrder.CourierId);
        if (courier == null)
            throw new Exception("bele bir couryer yoxdur");

        if (!courier.IsAvailable)
        {
            Console.WriteLine("hal hazirda kuryer doludur");
        }

        courier.IsAvailable = false;

        cargoOrders.Add(cargoOrder);

        Console.WriteLine("sifarisi yaratdiq");

    }
    
    public void CompleteOrder(int id)
    {
        var order = cargoOrders.FirstOrDefault(x => x.Id == id);
        if (order == null)
            throw new Exception("bele bir order yoxdur");

        order.UpdateStatus(OrderStatus.Delivered);

        var courier = Couriers.First(x => x.Id == order.CourierId);
        courier.IsAvailable = true;

        Console.WriteLine("order tamamlandi");


    }
}
