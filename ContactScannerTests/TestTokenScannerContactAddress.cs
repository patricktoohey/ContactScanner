namespace ContactScannerTests
{
    #region

    using ContactScanner;

    using NUnit.Framework;

    #endregion

    [TestFixture]
    public class TestTokenScannerContactAddress
    {
        [Test]
        public void TestDetectAddressToken()
        {
            var tokenScanner = new TokenScannerContactAddress();

            string contactLine = "Ithaca, NY 14850";
            Assert.That(tokenScanner.IsAddress(contactLine), Is.True);
        }

        [Test]
        public void TestDetectNonAddressToken()
        {
            var tokenScanner = new TokenScannerContactAddress();

            string contactLine = "George Jefferson";
            Assert.That(tokenScanner.IsAddress(contactLine), Is.False);
        }

        [Test]
        public void TestDetectAddressTokenCalifornia()
        {
            var tokenScanner = new TokenScannerContactAddress();

            string contactLine = "Beverly Hills, CA 90210";
            Assert.That(tokenScanner.IsAddress(contactLine), Is.True);
        }
    }
}