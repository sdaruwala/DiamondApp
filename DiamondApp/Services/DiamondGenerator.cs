using DiamondApp.Contracts;
using System.Text;

namespace DiamondApp.Services
{
    public class DiamondGenerator : IDiamondGenerator
    {
        public string[] GenerateDiamond(char midpoint)
        {
            if (!char.IsLetter(midpoint))
            {
                throw new ArgumentException("Midpoint must be a letter.");
            }

            midpoint = char.ToUpper(midpoint);
            int n = midpoint - 'A'; // Number of rows above and below the midpoint
            var diamond = new List<string>();

            // Upper part (including midpoint)
            for (int i = 0; i <= n; i++)
            {
                diamond.Add(GenerateRow(i, n));
            }

            // Lower part (excluding midpoint)
            for (int i = n - 1; i >= 0; i--)
            {
                diamond.Add(GenerateRow(i, n));
            }

            return [.. diamond];
        }

        private static string GenerateRow(int row, int n)
        {
            char letter = (char)('A' + row);
            int outerSpaces = n - row;
            int innerSpaces = 2 * row - 1;

            var rowBuilder = new StringBuilder();
            rowBuilder.Append(new string(' ', outerSpaces));
            rowBuilder.Append(letter);

            if (row > 0)
            {
                rowBuilder.Append(new string(' ', innerSpaces));
                rowBuilder.Append(letter);
            }

            return rowBuilder.ToString();
        }
    }
    
}
