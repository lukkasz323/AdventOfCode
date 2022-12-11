namespace AoC_2022.Days;

public class Day1 : Day
{
    private static List<int> GetElfs(string puzzleInput)
    {
        var elfs = new List<int>();
        int calories = 0;
        string[] split = puzzleInput.Split("\r\n");
        foreach (string item in split)
        {
            if (item == "")
            {
                elfs.Add(calories);
                calories = 0;
            }
            else
            {
                calories += int.Parse(item);
            }
        }

        return elfs;
    }

    protected override void Run(string puzzleInput)
    {
        List<int> elfs = GetElfs(puzzleInput);
        int bestElf = elfs.Max();

        Console.WriteLine($"Solution: {bestElf}");
    }
}
