using System;
using System.Configuration;
using System.Linq;

namespace OpenClosed_v3.Validators
{
    public static class SignValidator
    {
        static string[] operations = ((System.Collections.Specialized.NameValueCollection)ConfigurationManager.GetSection("Operations")).AllKeys;

        public static bool Validate(string input)
        {
            return operations.Contains(input);
        }
    }
}
