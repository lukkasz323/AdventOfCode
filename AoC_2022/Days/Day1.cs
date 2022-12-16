namespace AoC_2022.Days;

public class Day1 : Day
{
    private List<int> GetElves()
    {
        var elves = new List<int>();
        int calories = 0;
        foreach (string line in PuzzleInput)
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
        List<int> elves = GetElves();

        Solution1 = elves.Max();
        Solution2 = elves.OrderDescending().Take(3).Sum();
    }
}
