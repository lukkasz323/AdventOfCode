namespace AoC_2022;

public abstract class Day
{
    protected abstract void Run(string puzzleInput);

    public string GetPuzzleInput()
    {
        int dayIndex = int.Parse(GetType().Name[3..]);
        using StreamReader text = File.OpenText(@$"PuzzleInputs\{dayIndex}.txt");
        return text.ReadToEnd();
    }

    public void Start()
    {
        try
        {
            string puzzleInput = GetPuzzleInput();
            Run(puzzleInput);
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("Puzzle input not found!");
        }
    }
}
