using Magazine.Models;

namespace Magazine.intrfaces;

public interface ICargoServicee
{
    void AddCustomer(Customer customer);
    void AddCourier(Courier courier);
    void CreateOrder(CargoOrder cargoOrder);
    void CompleteOrder(int id);
}
