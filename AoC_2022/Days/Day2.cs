using System.ComponentModel;

namespace AoC_2022.Days;

public class Day2 : Day
{
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
        int yourScore = 0;

        foreach ((char, char) round in rounds)
        {
            Choice opponentChoice = charToChoice[round.Item1];
            Choice yourChoice = charToChoice[round.Item2];

            // Passive reward
            yourScore += 3 + choiceValues[yourChoice];

            // Lose 
            if (choiceBeatings[opponentChoice] == yourChoice)
            {
                yourScore -= 3; 
            }

            // Win
            if (choiceBeatings[yourChoice] == opponentChoice)
            {
                yourScore += 3; 
            }
        }

        Solution1 = yourScore;

        // Part 2
        yourScore = 0;

        foreach ((char, char) round in rounds)
        {
            Choice opponentChoice = charToChoice[round.Item1];
            char order = round.Item2;
            Choice yourChoice = order switch
            {
                'Y' => opponentChoice,                                  // draw
                'X' => choiceBeatings[opponentChoice],                  // lose
                'Z' => choiceBeatings[choiceBeatings[opponentChoice]],  // win
                _ => throw new NotImplementedException(),
            };

            // Passive reward
            yourScore += 3 + choiceValues[yourChoice];

            // Lose 
            if (choiceBeatings[opponentChoice] == yourChoice)
            {
                yourScore -= 3;
            }

            // Win
            if (choiceBeatings[yourChoice] == opponentChoice)
            {
                yourScore += 3;
            }
        }

        Solution2 = yourScore;
    }

    enum Choice
    {
        Rock,
        Paper,
        Scissors,
    }
}
