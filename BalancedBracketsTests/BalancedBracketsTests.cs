using Microsoft.VisualStudio.TestTools.UnitTesting;
using BalancedBracketsNS;

namespace BalancedBracketsTests
{
    [TestClass]
    public class BalancedBracketsTests
    {
        // TODO: Add tests to this file.

        [TestMethod]
        public void EmptyTest()
        {
            Assert.AreEqual(true, true);
        }
        [TestMethod]
        public void BalanceBracket_ShouldReturnTrue_IfCorrectBrackets()
        {
           
            string booCheck = "Hello [world] !";
            bool Actual = BalancedBrackets.HasBalancedBrackets(booCheck);
            bool expected = true;

           
            Assert.AreEqual(Actual, expected);
        }
        [TestMethod]
        public void BalanceBracket_ShouldReturnFalse_IfIncorrectBrackets()
        {
            string booCheck = "Hi[![Hello][";
            bool Actual = BalancedBrackets.HasBalancedBrackets(booCheck);
            bool expected = false;

            Assert.AreEqual(Actual, expected);
        }

        [TestMethod]
        public void BalanceBracket_ShouldReturnTrue_IfBracketsInsideBrackets()
        {
            string booCheck = "Hi[![Hello]]";
            bool Actual = BalancedBrackets.HasBalancedBrackets(booCheck);
            bool expected = true;

            Assert.AreEqual(Actual, expected);
        }

        [TestMethod]
        public void OnlyBracketsReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[]"));
        }

        [TestMethod]
        public void BalanceBracket_ShouldReturnTrue_IfNumbersInsideBrackets()
        {
            string booCheck = "Hi[6363555]";
            bool Actual = BalancedBrackets.HasBalancedBrackets(booCheck);
            bool expected = true;

            Assert.AreEqual(Actual, expected);
        }
        [TestMethod]
        public void BalanceBracket_ShouldReturnTrue_IfTextOnlyInsideBrackets()
        {
            string booCheck = "[Hello!]";
            bool Actual = BalancedBrackets.HasBalancedBrackets(booCheck);
            bool expected = true;

            Assert.AreEqual(Actual, expected);
        }

        [TestMethod]
        public void BalanceBracket_ShouldReturnTrue_IfTextOnlyOutsideBrackets()
        {
            string booCheck = "Hi[]";
            bool Actual = BalancedBrackets.HasBalancedBrackets(booCheck);
            bool expected = true;

            Assert.AreEqual(Actual, expected);
        }
        [TestMethod]
        public void BalanceBracket_ShouldReturnTrue_IfEmptyString()
        {
            string booCheck = "";
            bool Actual = BalancedBrackets.HasBalancedBrackets(booCheck);
            bool expected = true;

            Assert.AreEqual(Actual, expected);
        }
        [TestMethod]
        public void BalanceBracket_ShouldReturnFalse_IfOnlyOpeningBracket()
        {
            string booCheck = "[";
            bool Actual = BalancedBrackets.HasBalancedBrackets(booCheck);
            bool expected = false;

            Assert.AreEqual(Actual, expected);
        }
        [TestMethod]
        public void BalanceBracket_ShouldReturnFalse_IfOppositeDirections()
        {
            string booCheck = " ] [ ";
            bool Actual = BalancedBrackets.HasBalancedBrackets(booCheck);
            bool expected = false;

            Assert.AreEqual(Actual, expected);
        }

        [TestMethod]
        public void BalanceBracket_ShouldReturnFalse_IfTextAndOppositeDirections()
        {
            string booCheck = "Hi ] I want fo[od";
            bool Actual = BalancedBrackets.HasBalancedBrackets(booCheck);
            bool expected = false;

            Assert.AreEqual(Actual, expected);
        }

        [TestMethod]        public void BalanceBracketGivenTextWithBracketsShouldReturnFalse()        {            string testString = "[LaunchCode[";            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets(testString));        }


    }
}
