using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentProcessingSystem;

namespace PayementProcessingUnitTest
{
    [TestClass]
    public class PaymentProcessingUnitTest
    {
        [TestMethod]
        public void Test_PhysicalProduct()
        { 
        }
        [TestMethod]
        public void Test_NonPhysicalProduct_Video()
        {
            //input will be 1. Product Type =video,membership,upgrade , 2. Product name which is nullable
            // 
            var result = PaymentProcessor.UserInputToProductType(new string[] { "video", "Learning to Ski" });
            Assert.AreEqual("Learning to Ski", result.ProductName);
            Assert.AreEqual("Packing slip generated for shipping.", result.ActionStatus);
       
        }

        

    }
}
