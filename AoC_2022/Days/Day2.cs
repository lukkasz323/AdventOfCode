using System.ComponentModel;

namespace AoC_2022.Days;

public class Day2 : Day
{
    private static int AddScore(
        Choice opponentChoice,
        Choice yourChoice,
        Dictionary<Choice, Choice> choiceBeatings,
        Dictionary<Choice, int> choiceValues)
    {
        int roundScore = 0;

        // Passive reward
        roundScore += 3 + choiceValues[yourChoice];

        // Lose 
        if (choiceBeatings[opponentChoice] == yourChoice)
        {
            roundScore -= 3;
        }

        // Win
        if (choiceBeatings[yourChoice] == opponentChoice)
        {
            roundScore += 3;
        }

        return roundScore;
    }

    private List<(char, char)>? GetListOfRounds()
    {
        var rounds = new List<(char opponent, char you)>();

        foreach (string line in PuzzleInput.Split("\r\n"))
        {
            if (line.Length == 0) continue;
            if (line.Length != 3) return null;

            rounds.Add((line[0], line[2]));
        }

        return rounds;
    }

    protected override void Run()
    {
        List<(char, char)>? rounds = GetListOfRounds();
        if (rounds == null) return;

        var charToChoice = new Dictionary<char, Choice>()
        {
            ['A'] = Choice.Rock,
            ['B'] = Choice.Paper,
            ['C'] = Choice.Scissors,
            ['X'] = Choice.Rock,
            ['Y'] = Choice.Paper,
            ['Z'] = Choice.Scissors,
    };
        var choiceBeatings = new Dictionary<Choice, Choice>()
        {
            [Choice.Rock] = Choice.Scissors,
            [Choice.Paper] = Choice.Rock,
            [Choice.Scissors] = Choice.Paper,

        };
        var choiceValues = new Dictionary<Choice, int>()
        {
            [Choice.Rock] = 1,
            [Choice.Paper] = 2,
            [Choice.Scissors] = 3,
        };

        // Part 1
        int totalScore = 0;

        foreach ((char, char) round in rounds)
        {
            Choice opponentChoice = charToChoice[round.Item1];
            Choice yourChoice = charToChoice[round.Item2];

            totalScore += AddScore(opponentChoice, yourChoice, choiceBeatings, choiceValues);
        }

        Solution1 = totalScore;

        // Part 2
        totalScore = 0;

        foreach ((char, char) round in rounds)
        {
            Choice opponentChoice = charToChoice[round.Item1];
            char order = round.Item2;
            Choice yourChoice = order switch
            {
                'Y' => opponentChoice,                                  // Draw
                'X' => choiceBeatings[opponentChoice],                  // Lose
                'Z' => choiceBeatings[choiceBeatings[opponentChoice]],  // Win
                _ => throw new NotImplementedException(),
            };

            totalScore += AddScore(opponentChoice, yourChoice, choiceBeatings, choiceValues);
        }

        Solution2 = totalScore;
    }

    enum Choice
    {
        Rock,
        Paper,
        Scissors,
    }
}
