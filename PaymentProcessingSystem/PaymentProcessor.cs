using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentProcessingSystem
{
    public class PaymentProcessor
    {
        public static ProductDetails UserInputToProductType(string[] input)
        {
            ProductTypes type;
            try
            {
                type = (ProductTypes)Enum.Parse(typeof(ProductTypes), input[0], ignoreCase: true);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception Caught :" + e.Message.ToString());
                type = ProductTypes.Other;
            }
            string name = input.Length > 1 ? string.Join(' ', input, 1, input.Length - 1) : string.Empty;
            ProductDetails productDetails = new ProductDetails();
            productDetails.ProductName = name;
            productDetails.ActionStatus = "Packing slip generated for shipping.";


            return productDetails;
        }
    }
    public enum ProductTypes
    {
        Video,
        Membership,
        Upgrade,
        Book,
        Other
    }
}
