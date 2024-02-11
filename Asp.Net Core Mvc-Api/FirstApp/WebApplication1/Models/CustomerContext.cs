using System.Collections.Generic;

namespace FirstApp.Models
{
    public static class CustomerContext
    {
        public static List<Customer> Customers = new()
        {
            new Customer { Id=1, firstName = "Yusuf", lastName = "Kara", age = 23 },
            new Customer { Id=2, firstName = "Vahap", lastName = "Kara", age = 23 },
        };
    }
}
