namespace ContactScanner
{
    public class TokenScannerContactAddress
    {
        TokenScannerStateString stateScanner = new TokenScannerStateString();

        public bool IsAddress(string contactLine)
        {
            
            string[] tokens = contactLine.Split(' ');
            if (this.HasStateToken(tokens) && this.HasZipCode(tokens))
            {
                return true;
            }

            return false;
        }

        private bool HasStateToken(string[] tokens)
        {
            foreach (string token in tokens)
            {
                if (stateScanner.IsStateString(token))
                {
                    return true;
                }
            }

            return false;
        }

        private bool HasZipCode(string[] tokens)
        {
            TokenScannerZipCode zipScanner = new TokenScannerZipCode();

            foreach (string token in tokens)
            {
                if (zipScanner.IsZipCode(token))
                {
                    return true;
                }
            }

            return false;
        }
    }
}