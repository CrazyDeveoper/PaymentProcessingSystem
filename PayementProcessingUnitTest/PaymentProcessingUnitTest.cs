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
            Assert.AreEqual("Packing slip generated for shipping.", result.ActionStatus[0]);
            Assert.AreEqual(2, result.ActionStatus);
        }
        public void Test_NonPhysicalProduct_VideoWithoutName()
        {
            //input will be 1. Product Type =video,membership,upgrade , 2. Product name which is nullable
            // 
            var result = PaymentProcessor.UserInputToProductType(new string[] { "video", "" });
            Assert.AreEqual("N/A", result.ProductName);
            Assert.AreEqual("Packing slip generated for shipping.", result.ActionStatus[0]);
            Assert.AreEqual(2, result.ActionStatus);
        }

        [TestMethod]
        public void Test_GeneratePackingSlipForBook()
        {

            var result = PaymentProcessor.UserInputToProductType(new string[] { "Book", "" });
            Assert.AreEqual("N/A", result.ProductName);
            Assert.AreEqual("Packing slip generated for shipping.", result.ActionStatus[0]);
            Assert.AreEqual("Added commission payment to the agent.", result.ActionStatus[1]);
            Assert.AreEqual("Created a duplicate packing slip for the royalty department.", result.ActionStatus[2]);
            Assert.AreEqual(3, result.ActionStatus.Count);
        }

    }
}
