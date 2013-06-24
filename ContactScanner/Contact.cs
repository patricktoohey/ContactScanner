namespace ContactScanner
{
    #region

    using System.Collections;

    #endregion

    public class Contact
    {
        private ArrayList contactLines = new ArrayList();

        public Contact(ArrayList contactLines)
        {
            this.contactLines = contactLines;
        }

        private Contact() {}

        public ArrayList RawDetails
        {
            get { return this.contactLines; }
        }

        public string Name
        {
            get
            {
                return contactLines[0] as string;
            }
        }

        public string StreetAddress
        {
            get
            {
                return contactLines[contactLines.Count - 2] as string;
            }
        }

        public string CityStateZip
        {
            get
            {
                return contactLines[contactLines.Count - 1] as string;
            }
        }

    }
}