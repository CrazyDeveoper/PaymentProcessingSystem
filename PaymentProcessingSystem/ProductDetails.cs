using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentProcessingSystem
{
    //base properties and methods for product
    public abstract class ProductDetails
    {
        public string ProductName { get; set; }
        public List<string> ActionStatus { get; set; }
        public abstract void GeneratePackingSlip();
    }
}
