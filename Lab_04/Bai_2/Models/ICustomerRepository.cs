using Lab4_Bai2.Models;
using System.Collections.Generic;

namespace Lab4_Bai2.Interfaces
{
    public interface ICustomerRepository
    {
        IList<Customer> GetCustomers();
        Customer GetCustomer(string customerId);
        void AddCustomer(Customer customer);
        void UpdateCustomer(Customer customer);
        void DeleteCustomer(Customer cus);
        IList<Customer> SearchCustomer(string name);
    }
}
