namespace AoC_2022.Days;

public class Day6 : Day
{
    protected override void Solve()
    {
        string datastream = PuzzleInput[0];

        Solution1 = FindMarker(datastream, 4);
        Solution2 = FindMarker(datastream, 14);
    }

    private static int FindMarker(string datastream, int requiredMarkerLength) 
    {
        var marker = new List<char>();

        for (int i = 0; i < datastream.Length; i++)
        {
            char ch = datastream[i];

            if (marker.Contains(ch))
            {
                marker.RemoveRange(0, marker.IndexOf(ch) + 1);
            }
            marker.Add(ch);
            if (marker.Count == requiredMarkerLength)
            {
                return i + 1;
            }
        }

        throw new InvalidOperationException($"The marker was not found.");
    }
}
