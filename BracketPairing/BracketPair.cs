namespace BracketPairing
{
    public class BracketPair
    {
        public bool HasBracketMatches(string input)
        {
            var bracketCounter = 0;
            var index = 0;

            while (bracketCounter >= 0 && index < input.Length)
            {
                if (input[index] == '<')
                    bracketCounter++;
                else if (input[index] == '>')
                    bracketCounter--;

                index++;
            }

            return bracketCounter == 0;
        }
    }
}
