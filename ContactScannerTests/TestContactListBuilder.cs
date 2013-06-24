namespace ContactScannerTests
{
    #region

    using System.Collections;

    using ContactScanner;

    using NUnit.Framework;

    #endregion

    [TestFixture]
    internal class TestContactListBuilder
    {
        [Test]
        public void TestCountFromFullRegistry2()
        {
            ArrayList contactInfo = new ArrayList();
            contactInfo.Add("George Jefferson");
            contactInfo.Add("Dr. Of Funk");
            contactInfo.Add("School of Hard Knocks");
            contactInfo.Add("Okabojie, IA 32232");
            contactInfo.Add("Spongebob Squarepants");
            contactInfo.Add("Pineapple Under Sea");

            var list = new ContactListBuilder(contactInfo);

            Assert.That(list.Contacts.Count, Is.EqualTo(2));
        }

        [Test]
        public void TestOnePageSample()
        {
            ArrayList contactInfo = new ArrayList();
            contactInfo.Add("Christer Aakeroy");
            contactInfo.Add("Dept of Chemistry");
            contactInfo.Add("Kansas State University");
            contactInfo.Add("Willard Hall");
            contactInfo.Add("Manhattan KS 66506");
            contactInfo.Add("Ruben Abagyan");
            contactInfo.Add("School of Pharmacy & Pharmaceutical");
            contactInfo.Add("Sciences");
            contactInfo.Add("Univ of California San Diego");
            contactInfo.Add("9500 Gilman Dr 0747");
            contactInfo.Add("La Jolla CA 92093-0747");
            contactInfo.Add("Khalil Abboud");
            contactInfo.Add("Dept of Chemistry");
            contactInfo.Add("Univ of Florida");
            contactInfo.Add("P O Box 117200");
            contactInfo.Add("Gainesville FL 32611-7200");
            contactInfo.Add("Sheric S Abdei-Meguid");
            contactInfo.Add("236 Autumn Dr");
            contactInfo.Add("Exton PA 19341");
            contactInfo.Add("A.M. Abeykoon");
            contactInfo.Add("Condensed Matter Physics & Materials");
            contactInfo.Add("Science Dept");
            contactInfo.Add("Brookhaven National Lab");
            contactInfo.Add("PO Box 366");
            contactInfo.Add("Upton NY 11973");
            contactInfo.Add("Heba Abourahma");
            contactInfo.Add("Dept Of Chemistry");
            contactInfo.Add("The College of New Jersey");
            contactInfo.Add("PO Box 7718");
            contactInfo.Add("Ewing NY 08628");
            contactInfo.Add("Aniruddha Achari");
            contactInfo.Add("103 Madistone Ln");
            contactInfo.Add("Madison AL 35758");
            contactInfo.Add("Justin Acheson");
            contactInfo.Add("Biochemistry");
            contactInfo.Add("Univ of Wisconsin Madison");
            contactInfo.Add("433 Babcock Dr Rm 123");
            contactInfo.Add("Madison WI 53703");
            contactInfo.Add("Souray Adak");
            contactInfo.Add("Lujan Neutron Scattering Center");
            contactInfo.Add("Los Alamos NM 87545");
            contactInfo.Add("Paul Adams");
            contactInfo.Add("Physical Biosciences");
            contactInfo.Add("Lawrence Berkeley Lab");
            contactInfo.Add("1 Cyclotron Rd Bldg 64R0121");
            contactInfo.Add("Berkeley CA 94720");
            contactInfo.Add("Pavel Afonine");
            contactInfo.Add("Physical Biosciences Div");
            contactInfo.Add("Lawrence Berkely National Lab");
            contactInfo.Add("One Cyclotron Rd MS 64R0121");
            contactInfo.Add("Berkeley CA 94720");
            contactInfo.Add("David A Agard");
            
            var list = new ContactListBuilder(contactInfo);

            Assert.That(list.Contacts.Count, Is.EqualTo(12));
        }

        [Test]
        public void TestOnePageSampleDetails()
        {
            ArrayList contactInfo = new ArrayList();
            contactInfo.Add("Christer Aakeroy");
            contactInfo.Add("Dept of Chemistry");
            contactInfo.Add("Kansas State University");
            contactInfo.Add("Willard Hall");
            contactInfo.Add("Manhattan KS 66506");
            contactInfo.Add("Ruben Abagyan");
            contactInfo.Add("School of Pharmacy & Pharmaceutical");
            contactInfo.Add("Sciences");
            contactInfo.Add("Univ of California San Diego");
            contactInfo.Add("9500 Gilman Dr 0747");
            contactInfo.Add("La Jolla CA 92093-0747");
            contactInfo.Add("Khalil Abboud");
            contactInfo.Add("Dept of Chemistry");
            contactInfo.Add("Univ of Florida");
            contactInfo.Add("P O Box 117200");
            contactInfo.Add("Gainesville FL 32611-7200");
            contactInfo.Add("Sherin S Abdei-Meguid");
            contactInfo.Add("236 Autumn Dr");
            contactInfo.Add("Exton PA 19341");
            contactInfo.Add("A.M. Abeykoon");
            contactInfo.Add("Condensed Matter Physics & Materials");
            contactInfo.Add("Science Dept");
            contactInfo.Add("Brookhaven National Lab");
            contactInfo.Add("PO Box 366");
            contactInfo.Add("Upton NY 11973");
            contactInfo.Add("Heba Abourahma");
            contactInfo.Add("Dept Of Chemistry");
            contactInfo.Add("The College of New Jersey");
            contactInfo.Add("PO Box 7718");
            contactInfo.Add("Ewing NJ 08628");
            contactInfo.Add("Aniruddha Achari");
            contactInfo.Add("103 Maidstone Ln");
            contactInfo.Add("Madison AL 35758");
            contactInfo.Add("Justin Acheson");
            contactInfo.Add("Biochemistry");
            contactInfo.Add("Univ of Wisconsin Madison");
            contactInfo.Add("433 Babcock Dr Rm123");
            contactInfo.Add("Madison WI 53703");
            contactInfo.Add("Souray Adak");
            contactInfo.Add("Lujan Neutron Scattering Center");
            contactInfo.Add("Los Alamos National Lab");
            contactInfo.Add("MS H805 LANSCE-LC");
            contactInfo.Add("Los Alamos NM 87545");
            contactInfo.Add("Paul Adams");
            contactInfo.Add("Physical Biosciences");
            contactInfo.Add("Lawrence Berkeley Lab");
            contactInfo.Add("1 Cyclotron Rd Bldg 64R0121");
            contactInfo.Add("Berkeley CA 94720");
            contactInfo.Add("Pavel Afonine");
            contactInfo.Add("Physical Biosciences Div");
            contactInfo.Add("Lawrence Berkely National Lab");
            contactInfo.Add("One Cyclotron Rd MS 64R0121");
            contactInfo.Add("Berkeley CA 94720");
            contactInfo.Add("David A Agard");

            var list = new ContactListBuilder(contactInfo);
            
            Contact contactOne = list.Contacts[0] as Contact;
            Assert.That(contactOne.Name, Is.EqualTo("Christer Aakeroy"));
            Assert.That(contactOne.StreetAddress, Is.EqualTo("Willard Hall"));
            Assert.That(contactOne.CityStateZip, Is.EqualTo("Manhattan KS 66506"));

            Contact contactTwo = list.Contacts[1] as Contact;
            Assert.That(contactTwo.Name, Is.EqualTo("Ruben Abagyan"));
            Assert.That(contactTwo.StreetAddress, Is.EqualTo("9500 Gilman Dr 0747"));
            Assert.That(contactTwo.CityStateZip, Is.EqualTo("La Jolla CA 92093-0747"));

            Contact contactThree = list.Contacts[2] as Contact;
            Assert.That(contactThree.Name, Is.EqualTo("Khalil Abboud"));
            Assert.That(contactThree.StreetAddress, Is.EqualTo("P O Box 117200"));
            Assert.That(contactThree.CityStateZip, Is.EqualTo("Gainesville FL 32611-7200"));

            Contact contactFour = list.Contacts[3] as Contact;
            Assert.That(contactFour.Name, Is.EqualTo("Sherin S Abdei-Meguid"));
            Assert.That(contactFour.StreetAddress, Is.EqualTo("236 Autumn Dr"));
            Assert.That(contactFour.CityStateZip, Is.EqualTo("Exton PA 19341"));

            Contact contactFive = list.Contacts[4] as Contact;
            Assert.That(contactFive.Name, Is.EqualTo("A.M. Abeykoon"));
            Assert.That(contactFive.StreetAddress, Is.EqualTo("PO Box 366"));
            Assert.That(contactFive.CityStateZip, Is.EqualTo("Upton NY 11973"));

            Contact contactSix = list.Contacts[5] as Contact;
            Assert.That(contactSix.Name, Is.EqualTo("Heba Abourahma"));
            Assert.That(contactSix.StreetAddress, Is.EqualTo("PO Box 7718"));
            Assert.That(contactSix.CityStateZip, Is.EqualTo("Ewing NJ 08628"));

            Contact contactSeven = list.Contacts[6] as Contact;
            Assert.That(contactSeven.Name, Is.EqualTo("Aniruddha Achari"));
            Assert.That(contactSeven.StreetAddress, Is.EqualTo("103 Maidstone Ln"));
            Assert.That(contactSeven.CityStateZip, Is.EqualTo("Madison AL 35758"));

            Contact contactEight = list.Contacts[7] as Contact;
            Assert.That(contactEight.Name, Is.EqualTo("Justin Acheson"));
            Assert.That(contactEight.StreetAddress, Is.EqualTo("433 Babcock Dr Rm123"));
            Assert.That(contactEight.CityStateZip, Is.EqualTo("Madison WI 53703"));

            Contact contactNine = list.Contacts[8] as Contact;
            Assert.That(contactNine.Name, Is.EqualTo("Souray Adak"));
            Assert.That(contactNine.StreetAddress, Is.EqualTo("MS H805 LANSCE-LC"));
            Assert.That(contactNine.CityStateZip, Is.EqualTo("Los Alamos NM 87545"));

            Contact contactTen = list.Contacts[9] as Contact;
            Assert.That(contactTen.Name, Is.EqualTo("Paul Adams"));
            Assert.That(contactTen.StreetAddress, Is.EqualTo("1 Cyclotron Rd Bldg 64R0121"));
            Assert.That(contactTen.CityStateZip, Is.EqualTo("Berkeley CA 94720"));
            
            Contact contactEleven = list.Contacts[10] as Contact;
            Assert.That(contactEleven.Name, Is.EqualTo("Pavel Afonine"));
            Assert.That(contactEleven.StreetAddress, Is.EqualTo("One Cyclotron Rd MS 64R0121"));
            Assert.That(contactEleven.CityStateZip, Is.EqualTo("Berkeley CA 94720"));

        }
    }
}