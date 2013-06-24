namespace ContactScannerTests
{
    #region

    using ContactScanner;

    using NUnit.Framework;

    #endregion

    [TestFixture]
    public class TestTokenScannerStateString
    {
        [Test]
        public void TestTokenNewYork()
        {
            var stateScanner = new TokenScannerStateString();

            Assert.That(stateScanner.IsStateString("NY"), Is.True);
        }

        [Test]
        public void TestTokenNewYorkLowerFail()
        {
            var stateScanner = new TokenScannerStateString();

            Assert.That(stateScanner.IsStateString("ny"), Is.False);
        }

        [Test]
        public void TestTokenOhio()
        {
            var stateScanner = new TokenScannerStateString();

            Assert.That(stateScanner.IsStateString("OH"), Is.True);
        }

        [Test]
        public void TestTokenOhioLowerFail()
        {
            var stateScanner = new TokenScannerStateString();

            Assert.That(stateScanner.IsStateString("oh"), Is.False);
        }
    }
}