namespace BracketPairing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var bracketPair = new BracketPair();
            var result = bracketPair.HasBracketMatches("<abc...xyz>");
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}