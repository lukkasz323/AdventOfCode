namespace AoC_2022;

public abstract class Day
{
    public string PuzzleInput { get; private set; } = "";
    public int Solution1 { get; protected set; }
    public int Solution2 { get; protected set; }

    protected abstract void Run();

    public string GetPuzzleInput()
    {
        int dayIndex = int.Parse(GetType().Name[3..]);
        try
        {
            using StreamReader text = File.OpenText(@$"PuzzleInputs\{dayIndex}.txt");
            return text.ReadToEnd();
        }
        catch (FileNotFoundException)
        {
            return "";
        }
    }

    public void Start()
    {
        PuzzleInput = GetPuzzleInput();
        if (PuzzleInput != "")
        {
            Run();

            Console.WriteLine($"Part 1: {Solution1}");
            Console.WriteLine($"Part 2: {Solution2}");
        }
        else
        {
            Console.WriteLine("Puzzle input not found!");
        }
    }
}
