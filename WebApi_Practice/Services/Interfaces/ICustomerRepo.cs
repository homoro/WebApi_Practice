using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi_Practice.Models;

namespace WebApi_Practice.Services
{
    public interface ICustomerRepo
    {
        IEnumerable<Customer> GetAll();
        Task<Customer> Add(Customer customer);
        Task<Customer> Find(int id);
        Task<Customer> Update(Customer customer);
        Task<Customer> Remove(int id);
        Task<bool> IsExist(int id);
        Task<int> CountCustomer();
    }
}
