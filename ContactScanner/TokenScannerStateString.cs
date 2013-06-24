namespace ContactScanner
{
    #region

    using System;

    #endregion

    public class TokenScannerStateString
    {
        public bool IsStateString(string token)
        {
            if (Enum.IsDefined(typeof(StateAbbreviation), token))
            {
                return true;
            }

            return false;
        }
    }
}