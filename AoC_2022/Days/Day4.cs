namespace AoC_2022.Days;

public class Day4 : Day
{
    protected override void Solve()
    {
        int pairsFullyOverlapping = 0;
        int pairsOverlapping = 0;

        foreach (string line in PuzzleInput.Where(x => x != ""))
		{
            string[] elfPair = line.Split(',');
            int[] range1 = Array.ConvertAll(elfPair[0].Split('-'), int.Parse);
            int[] range2 = Array.ConvertAll(elfPair[1].Split('-'), int.Parse);
            List<int> sectors1 = Enumerable.Range(range1[0], range1[1] - range1[0] + 1).ToList();
            List<int> sectors2 = Enumerable.Range(range2[0], range2[1] - range2[0] + 1).ToList();

            // Part 1
            if (!sectors1.Except(sectors2).Any() || !sectors2.Except(sectors1).Any())
            {
                pairsFullyOverlapping += 1;
            }

            // Part 2
            if (sectors1.Intersect(sectors2).Any() || sectors2.Intersect(sectors1).Any())
            {
                pairsOverlapping += 1;
            }
        }

        Solution1 = pairsFullyOverlapping;
        Solution2 = pairsOverlapping;
    }
}
