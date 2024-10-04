using DiamondApp.Contracts;

public class MainApp
{
    private readonly IDiamondGenerator _generator;
    private readonly IDiamondPrinter _printer;

    public MainApp(IDiamondGenerator generator, IDiamondPrinter printer)
    {
        _generator = generator;
        _printer = printer;
    }

    public void Run(string[] args)
    {
        ArgumentNullException.ThrowIfNull(args);
        
        Console.WriteLine("Please enter a single letter to generate the diamond:");
        
        string input = Console.ReadLine();

        // Validate the input
        if (string.IsNullOrEmpty(input) || input.Length != 1 || !char.IsLetter(input[0]))
        {
            Console.WriteLine("Invalid input. Please provide a single letter.");
            return;
        }

        // Generate the diamond
        char midpoint = input[0];
        var diamond = _generator.GenerateDiamond(midpoint);

        // Print the diamond
        _printer.PrintDiamond(diamond);
    }
}
