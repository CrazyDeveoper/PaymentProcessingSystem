using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentProcessingSystem
{
    public class PhysicalProduct : ProductDetails
    {
        public override void GeneratePackingSlip()
        {

            ActionStatus.Add("Packing slip generated for shipping.");
            Console.WriteLine("Generating packing slip for shipping.");
        }

        public void AddAgentCommission()
        {
            ActionStatus.Add("Added commission payment to the agent.");
            Console.WriteLine("Addig commission payment to the agent.");
        }

    }
    class Book : PhysicalProduct
    {
        public Book(string name)
        {
            ProductName = name != "" ? name : "N/A";
            ActionStatus = new List<string>();
            base.GeneratePackingSlip();
            base.AddAgentCommission();
            GeneratePackingSlip();
        }
        public override void GeneratePackingSlip()
        {
            ActionStatus.Add("Created a duplicate packing slip for the royalty department.");
            Console.WriteLine("Creating a duplicate packing slip for the royalty department.");
        }
    }
}
