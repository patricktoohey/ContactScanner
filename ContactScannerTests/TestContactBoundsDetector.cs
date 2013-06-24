namespace ContactScannerTests
{
    using System.Collections;

    using ContactScanner;

    using NUnit.Framework;

    [TestFixture]
    public class TestContactBoundsDetector
    {
        [Test]
        public void TestFindAddressIndex()
        {
            ArrayList contactInfo = new ArrayList();
            contactInfo.Add("George Jefferson");
            contactInfo.Add("Dr. Of Funk");
            contactInfo.Add("School of Hard Knocks");
            contactInfo.Add("Okabojie, IA 32232");
            contactInfo.Add("Spongebob Squarepants");
            contactInfo.Add("Pineapple Under Sea");

            var boundaryLimits = new ContactBoundsDetector();
            int contactBoundary = boundaryLimits.NextBoundary(contactInfo);

            Assert.That(contactBoundary, Is.EqualTo(4));
        }
    }
}
