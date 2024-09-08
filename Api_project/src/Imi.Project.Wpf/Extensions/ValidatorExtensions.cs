using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Imi.Project.Wpf.Extensions
{
    public static class ValidatorExtensions
    {
        public static bool IsValidEmailAddress(this string s)
        {
            Regex regex = new Regex(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$");
            return regex.IsMatch(s);
        }

        public static bool IsValidInput(this string s)
        {
            return s.Length >= 6;

        }
        public static bool IsSameInput(this string s, string t)
        {
            return s.ToUpper().Equals(t.ToUpper());

        }
        public static bool IsValidDateInput(this DateTime s)
        {
            return s < DateTime.Today;

        }

    }
}
