namespace BracketPairing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var bracketPair = new BracketPair();
            string[] inputs = { "<>", "><", "<<>", "\"\"", "<abc...xyz>" };

            foreach (var input in inputs)
            {
                var result = bracketPair.HasBracketMatches(input);
                Console.WriteLine(result);
            }

            Console.ReadLine();
        }
    }
}