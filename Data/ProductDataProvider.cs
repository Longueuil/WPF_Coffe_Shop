using CoffeShop.Model;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CoffeShop.Data
{
    public interface IProductDataProvider
    {
        Task<IEnumerable<Product>?> GetAllAsync();
    }
    public class ProductDataProvider : IProductDataProvider
    {
        public async Task<IEnumerable<Product>?> GetAllAsync()
        {
            await Task.Delay(2000);
            return new List<Product>
            {
               new Product{Name = "Capucino",Description="Espresso with milk and mili foam"},
               new Product{Name = "Doppio",Description="Double espresso"},
               new Product{Name = "Espresso",Description="Pure coffe to keep you awake"},
               new Product{Name = "Latte",Description="Cappucino with more stremed milk"},
               new Product{Name = "Mocha",Description="Espresso with hot chocolat and milk foam"}
            };
        }
    }
}
