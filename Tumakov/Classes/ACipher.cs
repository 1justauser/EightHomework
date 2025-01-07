namespace Tumakov
{
    internal sealed class ACipher : ICipher
    {
        #region Cipher Methods
        static public string encode(string input)
        {
            string newString = string.Empty;
            for (int i = 0; i < input.Length; i++)
            {
                newString = newString + ApplyCypheringAType(input[i]);
            }
            return newString;
        }
        static public string decode(string input)
        {
            string newString = string.Empty;
            for (int i = 0; i < input.Length; i++)
            {
                newString = newString + ApplyCypheringAType(input[i], -1);
            }
            return newString;
        }
        static private char ApplyCypheringAType(char currentChar, int shift = 1)
        {
            int charIndex = (int)currentChar;
            if ((int)'Z' >= charIndex && (int)'A' <= charIndex)
            {
                charIndex = (((charIndex + shift - (int)'A' + 26) % 26) + (int)'A');
            }
            else if ((int)'z' >= charIndex && (int)'a' <= charIndex)
            {
                charIndex = (((charIndex + shift - (int)'a' + 26) % 26) + (int)'a');
            }
            else if ((int)'Я' >= charIndex && (int)'А' <= charIndex)
            {
                charIndex = (((charIndex + shift - (int)'А' + 32) % 32) + (int)'А');
            }
            else if ((int)'я' >= charIndex && (int)'а' <= charIndex)
            {
                charIndex = (((charIndex + shift - (int)'а' + 32) % 32) + (int)'а');
            }
            return (char)charIndex;
        }
        #endregion
    }
}
