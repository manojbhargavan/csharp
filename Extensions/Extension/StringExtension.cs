using System;
namespace Extension
{
    public static class StringExtension
    {
        public static string GetFormattedName(this string firstName, string lastName)
        {
            return $"{lastName}, {firstName}".ToUpper();
        }

        public static string GetFormattedName(this string fullName)
        {
            string[] name = fullName.Split(',');
            if(name.Length != 2) throw new ArgumentException("Name must be of the format \"firstname, lastname\"");
            return $"{name[1].Trim()}, {name[0].Trim()}".ToUpper();
        }
    }
}