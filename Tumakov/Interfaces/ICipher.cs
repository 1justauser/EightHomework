namespace Tumakov
{
    internal interface ICipher
    {
        static abstract string encode(string input);
        static abstract string decode(string input);
    }
}
