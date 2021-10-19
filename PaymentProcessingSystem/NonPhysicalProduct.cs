using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentProcessingSystem
{
    public class NonPhysicalProduct : ProductDetails
    {
        public override void GeneratePackingSlip()
        {
            Console.WriteLine("Generating packing slip for nonphysical product");
            ActionStatus.Add("Packing slip generated for shipping.");
           
        }

        public void SendMail()
        {
            Console.WriteLine("Sending mail to owner.");
            ActionStatus.Add("Mail sent to owner.");
        
        }
    }

    class Video : NonPhysicalProduct
    {
        public Video(string videoName)
        {

            ActionStatus = new List<string>();
            ProductName = videoName != "" ? videoName : "N/A";
            GeneratePackingSlip();
        }
        public override void GeneratePackingSlip()
        {
            base.GeneratePackingSlip();
            if (ProductName.ToLower().Equals("learning to ski"))
            {
                ActionStatus.Add("'First Aid' video added to the packing slip.");
                Console.WriteLine("Adding 'First Aid' video  to the packing slip.");
            }
        }
    }

    class Membership : NonPhysicalProduct
    {
        public Membership(string name)
        {
            ProductName = name != "" ? name : "N/A";
            ActionStatus = new List<string>();
            base.GeneratePackingSlip();
            ActionStatus.Add("Membership activated.");
            Console.WriteLine("Activating membership.");
            base.SendMail();
        }
    }
    class Upgrade : NonPhysicalProduct
    {
        public Upgrade(string name)
        {
            ProductName = name != "" ? name : "N/A";
            ActionStatus = new List<string>();
            base.GeneratePackingSlip();
            ActionStatus.Add("Membership upgraded.");
            Console.WriteLine("Upgrading membership.");
            base.SendMail();
        }
    }

}
