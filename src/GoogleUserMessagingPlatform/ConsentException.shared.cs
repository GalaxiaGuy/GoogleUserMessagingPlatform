using System;

namespace Google.UserMessagingPlatform
{
    public partial class ConsentException : Exception
    {
        protected ConsentException(string message) : base(message)
        {
        }

        internal static ConsentException UnknownError = new ConsentException("An unknown error occurred.");
    }
}
