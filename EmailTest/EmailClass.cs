using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EmailTest
{
    public class EmailClass
    {
        public string regexValues =
                    @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                    @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-0-9a-z]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$";

        public string IsEmailValid(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                throw new Exception(nameof(email));

            try
            {
                // Normalize the domain
                email = Regex.Replace(email, @"(@)(.+)$", DomainMapper,
                                      RegexOptions.None, TimeSpan.FromMilliseconds(200));

                // Examines the domain part of the email and normalizes it.
                string DomainMapper(Match match)
                {
                    // Use IdnMapping class to convert Unicode domain names.
                    var idn = new IdnMapping();

                    // Pull out and process domain name (throws ArgumentException on invalid)
                    var domainName = idn.GetAscii(match.Groups[2].Value);

                    return match.Groups[1].Value + domainName;
                }
            }
            catch (RegexMatchTimeoutException e)
            {
                throw new RegexMatchTimeoutException(nameof(e));
            }
            catch (ArgumentException e)
            {
                throw new ArgumentException(nameof(e));

            }
            try
            {
                var reegexx = Regex.IsMatch(email, regexValues,
                    RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));

                if (reegexx == true)
                {
                    return email;
                }
                return email = null;

            }
            catch (RegexMatchTimeoutException e)
            {
                throw new RegexMatchTimeoutException(nameof(e));

            }
        }
    }
}
