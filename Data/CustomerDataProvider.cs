using CoffeShop.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CoffeShop.Data
{
    public interface ICustomerDataProvider
    {
        Task<IEnumerable<Customer>?> GetAllAsync();
    }
    public class CustomerDataProvider : ICustomerDataProvider
    {
        public async Task<IEnumerable<Customer>?> GetAllAsync()
        {
            await Task.Delay(2000);
            return new List<Customer>
            {
                new Customer { Id = 1, FirstName = "Jill", LastName = "Developer", IsDeveloper= true},
                new Customer { Id = 2, FirstName = "Alex", LastName = "Rider"},
                new Customer { Id = 3, FirstName = "Bon", LastName = "Modjo", IsDeveloper= true},
                new Customer { Id = 4, FirstName = "Anna", LastName = "Ehnaton"},
                new Customer { Id = 5, FirstName = "Elsta", LastName = "Robertini"},
                new Customer { Id = 6, FirstName = "John", LastName = "Microsoft"}
            };
        } 
    }
}
