namespace BracketPairing.Test
{
    [TestClass]
    public class BracketPairTests
    {
        [TestMethod]
        public void HasBracketMatches_LeftThenRight_ReturnsTrue()
        {
            var bracketPair = new BracketPair();

            var leftRight = bracketPair.HasBracketMatches("<>");

            Assert.IsTrue(leftRight);
        }

        [TestMethod]
        public void HasBracketMatches_RightThenLeft_ReturnsFalse()
        {
            var bracketPair = new BracketPair();
            var rightLeft = bracketPair.HasBracketMatches("><");
            Assert.IsFalse(rightLeft);
        }

        [TestMethod]
        public void HasBracketMatches_OddCount_ReturnsFalse()
        {
            var bracketPair = new BracketPair();
            var oddCount = bracketPair.HasBracketMatches("<<>");
            Assert.IsFalse(oddCount);
        }

        [TestMethod]
        public void HasBracketMatches_NoBrackets_ReturnsTrue()
        {
            var bracketPair = new BracketPair();
            var noBrackets = bracketPair.HasBracketMatches("\"\"");
            Assert.IsTrue(noBrackets);
        }

        [TestMethod]
        public void HasBracketMatches_LeftSandwichRight_ReturnsTrue()
        {
            var bracketPair = new BracketPair();
            var leftSandwichRight = bracketPair.HasBracketMatches("<abc...xyz>");
            Assert.IsTrue(leftSandwichRight);
        }
    }
}