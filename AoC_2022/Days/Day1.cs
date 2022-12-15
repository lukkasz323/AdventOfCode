namespace AoC_2022.Days;

public class Day1 : Day
{
    private List<int> GetElves()
    {
        var elves = new List<int>();
        int calories = 0;
        foreach (string line in PuzzleInput.Split("\r\n"))
        {
            if (line != "")
            {
                calories += int.Parse(line);
            }
            else
            {
                elves.Add(calories);
                calories = 0;
            }
        }

        return elves;
    }

    protected override void Solve()
    {
        List<int> elfs = GetElves();

        Solution1 = elfs.Max();
        Solution2 = elfs.OrderDescending().Take(3).Sum();
    }
}
