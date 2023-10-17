
using System.Windows.Documents;

namespace CoffeShop.Model
{
    public class Customer
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public bool IsDeveloper { get; set; }
    }
}
