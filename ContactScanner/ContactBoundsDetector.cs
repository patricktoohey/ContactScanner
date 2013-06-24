namespace ContactScanner
{
    using System.Collections;

    public class ContactBoundsDetector
    {
        public int NextBoundary(ArrayList contactInfo)
        {
            var addressScanner = new TokenScannerContactAddress();

            int line = 1;

            foreach(string contactLine in contactInfo)
            {
                if (addressScanner.IsAddress(contactLine))
                {
                    return line;
                }

                line++;
            }

            return line;
        }
    }
}