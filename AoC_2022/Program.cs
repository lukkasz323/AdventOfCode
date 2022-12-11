using AoC_2022.Days;

namespace AoC_2022;

public class Program
{
    private static void Main(string[] args)
    {
        const string Title = "Advent of Code 2022";
        const string Author = "lukkasz323";

        Console.WriteLine($"\n   {Title} - {Author}\n");

        List<Day> days = CreateListOfDays();
        if (args.Length == 1 && int.TryParse(args[0], out int dayIndex) && dayIndex > 0 && dayIndex <= days.Count)
        {
            RunDayInContainer(days, dayIndex);
        }   
        else
        {
            for (int i = 0; i < days.Count; i++)
            {
                RunDayInContainer(days, i + 1);
            }
        }
    }

    private static void RunDayInContainer(List<Day> days, int dayIndex)
    {
        Console.WriteLine($"---[Day {dayIndex}]---");
        days[dayIndex - 1].Start();
        Console.WriteLine($"--------------\n");
    }

    private static List<Day> CreateListOfDays() => new() {
        new Day1(),
        new Day2(),
        new Day3(),
        new Day4(),
        new Day5(),
        new Day6(),
        new Day7(),
        new Day8(),
        new Day9(),
        new Day10(),
        new Day11(),
        new Day12(),
        new Day13(),
        new Day14(),
        new Day15(),
        new Day16(),
        new Day17(),
        new Day18(),
        new Day19(),
        new Day20(),
        new Day21(),
        new Day22(),
        new Day23(),
        new Day24(),
        new Day25()
    };
}