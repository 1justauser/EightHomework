namespace Tumakov
{
    internal sealed class BCipher : ICipher
    {
        #region Cipher Methods
        static public string encode(string input)
        {
            string newString = string.Empty;
            for (int i = 0; i < input.Length; i++)
            {
                newString = newString + ApplyCypheringBType(input[i]);
            }
            return newString;
        }
        static public string decode(string input)
        {
            string newString = string.Empty;
            for (int i = 0; i < input.Length; i++)
            {
                newString = newString + ApplyCypheringBType(input[i]);
            }
            return newString;
        }
        static public char ApplyCypheringBType(char currentChar)
        {
            //32 = Я
            //1 = А
            //2 = Б
            //|
            //V
            //32 - 32 = (char)('A' - 1)
            //32 - 1 = Ю 
            //32 - 2 = Э 11111
            //alphabetIndex = (int)(currentChar - 'A' + 1)
            //currentChar -> (char)((32 - alphabetIndex) + 'A' - 1)
            int charIndex = (int)currentChar;
            if ((int)'Z' >= charIndex && (int)'A' - 1 <= charIndex)
            {
                int alphabetIndex = (int)(currentChar - 'A' + 1);
                charIndex = (int)((26 - alphabetIndex) + 'A' - 1);
            }
            else if ((int)'z' >= charIndex && (int)'a' - 1 <= charIndex)
            {
                int alphabetIndex = (int)(currentChar - 'a' + 1);
                charIndex = (int)((26 - alphabetIndex) + 'a' - 1);
            }
            else if ((int)'Я' >= charIndex && (int)'А' - 1 <= charIndex)
            {
                int alphabetIndex = (int)(currentChar - 'А' + 1);
                charIndex = (int)((32 - alphabetIndex) + 'А' - 1);
            }
            else if ((int)'я' >= charIndex && (int)'а' - 1 <= charIndex)
            {
                int alphabetIndex = (int)(currentChar - 'а' + 1);
                charIndex = (int)((32 - alphabetIndex) + 'а' - 1);
            }
            return (char)charIndex;
        }
        #endregion
    }
}
