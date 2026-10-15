using System;

namespace ARPF.Cadenas
{
    public class StringManipulator
    {
        public string ReverseString(string input)
        {
            if (input == null)
            {
                throw new ArgumentNullException(nameof(input), "La cadena no puede ser nula.");
            }

            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        public string RemoveSpaces(string input)
        {
            if (input == null)
            {
                throw new ArgumentNullException(nameof(input), "La cadena no puede ser nula.");
            }

            return input.Replace(" ", "");
        }
    }
}
