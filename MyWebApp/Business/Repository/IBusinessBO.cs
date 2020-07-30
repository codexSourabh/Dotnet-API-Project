using MyWebApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebApp.Business.Repository
{
    public interface IBusinessBO
    {
        void AddCustomer(CustomerDetails customerDetails);
    }
}
