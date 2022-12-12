namespace AoC_2022.Days;

public class Day1 : Day
{
    private List<int> GetElfs()
    {
        var elfs = new List<int>();
        int calories = 0;
        string[] split = PuzzleInput.Split("\r\n");
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

    protected override void Run()
    {
        List<int> elfs = GetElfs();

        Solution1 = elfs.Max();
        Solution2 = elfs.OrderDescending().Take(3).Sum();
    }
}
