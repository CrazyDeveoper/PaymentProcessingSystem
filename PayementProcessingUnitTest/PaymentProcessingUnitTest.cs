using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentProcessingSystem;

namespace PayementProcessingUnitTest
{
    [TestClass]
    public class PaymentProcessingUnitTest
    {

        [TestMethod]
        public void Test_NonPhysicalProduct_Video()
        {
            //input will be 1. Product Type =video,membership,upgrade , 2. Product name which is nullable
            // 
            var result = PaymentProcessor.UserInputToProductType(new string[] { "video", "Learning to Ski" });
            Assert.AreEqual("Learning to Ski", result.ProductName);
            Assert.AreEqual("Packing slip generated for shipping.", result.ActionStatus[0]);
            Assert.AreEqual("'First Aid' video added to the packing slip.", result.ActionStatus[1]);

            Assert.AreEqual(2, result.ActionStatus.Count);
        }
        [TestMethod]
        public void Test_NonPhysicalProduct_VideoWithoutName()
        {
            var result = PaymentProcessor.UserInputToProductType(new string[] { "video", "" });
            Assert.AreEqual("N/A", result.ProductName);
            Assert.AreEqual("Packing slip generated for shipping.", result.ActionStatus[0]);
            Assert.AreEqual(1, result.ActionStatus.Count);
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
        [TestMethod]
        public void Test_GeneratePackingSlipForBookWithBookName()
        {

            var result = PaymentProcessor.UserInputToProductType(new string[] { "Book", "TDD Approach" });
            Assert.AreEqual("TDD Approach", result.ProductName);
            Assert.AreEqual("Packing slip generated for shipping.", result.ActionStatus[0]);
            Assert.AreEqual("Added commission payment to the agent.", result.ActionStatus[1]);
            Assert.AreEqual("Created a duplicate packing slip for the royalty department.", result.ActionStatus[2]);
            Assert.AreEqual(3, result.ActionStatus.Count);
        }

        [TestMethod]
        public void Test_Membership_Activate_Upgrade()
        {
            var result = PaymentProcessor.UserInputToProductType(new string[] { "Membership", "" });
            Assert.AreEqual("N/A", result.ProductName);
            Assert.AreEqual("Packing slip generated for shipping.", result.ActionStatus[0]);
            Assert.AreEqual("Membership activated.", result.ActionStatus[1]);
            Assert.AreEqual("Mail sent to owner.", result.ActionStatus[2]);
            Assert.AreEqual(3, result.ActionStatus.Count);

            var result2 = PaymentProcessor.UserInputToProductType(new string[] { "Upgrade", "" });
            Assert.AreEqual("N/A", result.ProductName);
            Assert.AreEqual("Packing slip generated for shipping.", result2.ActionStatus[0]);
            Assert.AreEqual("Membership upgraded.", result2.ActionStatus[1]);
            Assert.AreEqual("Mail sent to owner.", result2.ActionStatus[2]);
            Assert.AreEqual(3, result2.ActionStatus.Count);
        }
    }
}
