using MyWebApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebApp.DataAccess.Repository
{
    public interface IDAO
    {
        void AddCustomer(CustomerDetails customerDetails);
    }
}
