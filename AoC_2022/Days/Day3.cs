namespace AoC_2022.Days;

public class Day3 : Day
{
    private static int GetItemPriority(char item)
    {
        int priority = 0;

        if (item >= 'a' && 'z' >= item)
        {
            priority = item - 96;
        }
        else if (item >= 'A' && 'Z' >= item)
        {
            priority = item - 38;
        }
        else
        {
            priority = 0;
        }

        return priority;
    }

    protected override void Solve()
    {
        // Part 1
        int prioritiesSum = 0;

		foreach (string line in PuzzleInput.Where(x => x != ""))
		{
            List<char> firstHalf = line.Take(line.Length / 2).ToList();
            List<char> secondHalf = line.Skip(line.Length / 2).ToList();

            char item = firstHalf.Intersect(secondHalf).First();
            prioritiesSum += GetItemPriority(item);
		}

        Solution1 = prioritiesSum;

        // Part 2
        var elfGroup = new List<string>();
        prioritiesSum = 0;

        foreach (string line in PuzzleInput)
        {
            elfGroup.Add(line);

            if (elfGroup.Count == 3)
            {
                char item = elfGroup[0].Intersect(elfGroup[1]).Intersect(elfGroup[2]).First();
                prioritiesSum += GetItemPriority(item);

                elfGroup = new();
            }
        }

        Solution2 = prioritiesSum;
    }
}
