using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnluCo.ExtensionMethods.Odev
{

    public static class StringExtensions
    {
        private static List<bool> valids = new List<bool>();

        public static bool isValidPassword(this string str, bool isUppercase = false, bool isLowercase = false, bool _isDigit = false, bool _isSymbol = false, bool _isLenghtValid = false)
        {
            isUpper(str, isUppercase);
            isLower(str, isLowercase);
            isDigit(str, _isDigit);
            isSymbol(str, _isSymbol);
            isLenghtValid(str, _isLenghtValid);



            //burası değişmeyecek.Herhangi bir kural eklendiğinde gerekli method yukarıda çağırılıp valids(bool) listesine eklenecek
            bool result = valids.All(x => x == true);
            return result;
        }
        private static void isUpper(string str, bool isUppercase)
        {
            valids.Add(str.Any(Char.IsUpper) == isUppercase);
        }
        private static void isLower(string str, bool isLowercase)
        {
            valids.Add(str.Any(Char.IsLower) == isLowercase);
        }
        private static void isDigit(string str, bool isdigit)
        {
            valids.Add(str.Any(Char.IsDigit) == isdigit);
        }
        private static void isSymbol(string str, bool _isSymbol)
        {
            valids.Add(str.All(Char.IsLetterOrDigit) == _isSymbol);
        }
        private static void isLenghtValid(string str, bool _isLenghtValid)
        {
            valids.Add((str.Length >= 6) == _isLenghtValid);
        }
    }
}
