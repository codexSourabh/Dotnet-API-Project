using MyWebApp.DataAccess.Repository;
using MyWebApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebApp.DataAccess.Services
{
    public class DAO : IDAO
    {
        CustomerDatabaseContext dbContext = new CustomerDatabaseContext();
        public void AddCustomer(CustomerDetails customerDetails)
        {
            dbContext.CustomerDetails.Add(customerDetails);
            dbContext.SaveChanges();
        }
    }
}
