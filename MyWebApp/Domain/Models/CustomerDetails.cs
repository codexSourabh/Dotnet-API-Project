using System;
using System.Collections.Generic;

namespace MyWebApp.Domain.Models
{
    public partial class CustomerDetails
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public long CustomerContact { get; set; }
        public string CustomerAddress { get; set; }
    }
}
