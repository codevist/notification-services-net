using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace notification_services_net
{
    public class CSaleProduct
    {
        public int ProductId { get; set; }
        public int ProductCategory { get; set; }
        public string ProductDescription { get; set; }
        public double BasePrice { get; set; }
        public double BaseUnitPrice { get; set; }
        public int Unit { get; set; }
    }
}