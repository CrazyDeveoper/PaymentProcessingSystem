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
            ProductDetails productDetails;
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

            switch (type)
            {

                case ProductTypes.Video:
                    {
                        productDetails = new Video(name);
                        break;
                    }
                case ProductTypes.Book:
                    {
                        productDetails = new Book(name);
                        break;
                    }
                case ProductTypes.Membership:
                    {
                        productDetails = new Membership(name);
                        break;
                    }
                case ProductTypes.Upgrade:
                    {
                        productDetails = new Upgrade(name);
                        break;
                    }
                case ProductTypes.Other:
                default:
                    {
                        productDetails = null;
                        Console.WriteLine("Nothing to handle in defult case.");
                        break;
                    }
                  
                    
            }

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
