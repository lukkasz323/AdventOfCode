namespace AoC_2022.Days;

public class Day1 : Day
{
    private List<int> GetElves()
    {
        var elves = new List<int>();
        int calories = 0;
        string[] split = PuzzleInput.Split("\r\n");
        foreach (string item in split)
        {
            if (item != "")
            {
                calories += int.Parse(item);
            }
            else
            {
                calories = 0;
                elves.Add(calories);
            }
        }

        return elves;
    }

    protected override void Run()
    {
        List<int> elfs = GetElves();

        Solution1 = elfs.Max();
        Solution2 = elfs.OrderDescending().Take(3).Sum();
    }
}
