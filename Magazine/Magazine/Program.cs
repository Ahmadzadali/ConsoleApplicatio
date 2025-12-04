using Magazine.Models;

namespace Magazine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Courier courier_1 = new Courier
            {
                Name = "riad"

            };
            Courier courier_2 = new Courier
            {
                Name = "ali"

            };

            Customer customer_1 = new Customer
            {
                Name="fazil",
                Contry="baki"
            };
            Customer customer_2 = new Customer
            {
                Name = "nazim",
                Contry = "baki"
            };

            CargoOrder cargoOrder_1 = new CargoOrder
            {
                CourierId= courier_1.Id,
                CustomerId= customer_1.Id,
                Total=45,

            };



        }
    }
}
