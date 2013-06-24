namespace ContactScanner
{
    #region

    using System;
    using System.Text.RegularExpressions;

    #endregion

    public class TokenScannerZipCode
    {
        public bool IsZipCode(string token)
        {
            string pattern = "^\\d{5}(?:[-\\s]\\d{4})?$";
            Match match = Regex.Match(token, pattern);
            if (match.Success)
            {
                return true;
            }

            return false;
        }
    }
}