namespace AoC_2022;

public abstract class Day
{
    public List<string> PuzzleInput { get; private set; } = new();
    public int Solution1 { get; protected set; }
    public int Solution2 { get; protected set; }

    protected abstract void Solve();

    public List<string> GetPuzzleInput()
    {
        int dayIndex = int.Parse(GetType().Name[3..]);
        try
        {
            using StreamReader text = File.OpenText(@$"PuzzleInputs\{dayIndex}.txt");

            return text.ReadToEnd().Split("\r\n").ToList();
        }
        catch (FileNotFoundException)
        {
            return new();
        }
    }

    public void Start()
    {
        PuzzleInput = GetPuzzleInput();
        if (PuzzleInput.Count != 0)
        {
            Solve();

            Console.WriteLine($"Part 1: {Solution1}");
            Console.WriteLine($"Part 2: {Solution2}");
        }
        else
        {
            Console.WriteLine("Puzzle input not found!");
        }
    }
}
