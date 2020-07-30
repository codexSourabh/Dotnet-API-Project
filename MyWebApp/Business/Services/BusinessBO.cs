using MyWebApp.Business.Repository;
using MyWebApp.DataAccess.Repository;
using MyWebApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebApp.Business.Services
{
    public class BusinessBO : IBusinessBO
    {
        private readonly IDAO _dataAccess;
        public BusinessBO(IDAO dataAccess)
        {
            _dataAccess = dataAccess;
        }
        public void AddCustomer(CustomerDetails customerDetails)
        {
            _dataAccess.AddCustomer(customerDetails);
        }
    }
}
