using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace AoC_2022.Days;

public class Day5 : Day
{
    protected override void Solve()
    {
        int seperationLineIndex = PuzzleInput.IndexOf("");

        List<Stack<char>> cargo1 = GetCargoFromInput(seperationLineIndex);
        List<Stack<char>> cargo2 = GetCargoFromInput(seperationLineIndex);

        List<Procedure> procedures = GetProceduresFromInput(seperationLineIndex);

        RunProceduresOnCargo_Part1(cargo1, procedures);
        RunProceduresOnCargo_Part2(cargo2, procedures);

        Solution1 = GetSolution(cargo1);
        Solution2 = GetSolution(cargo2);
    }

    private List<Stack<char>> GetCargoFromInput(int seperationLineIndex)
    {
        List<string> inputCargo = PuzzleInput.GetRange(0, seperationLineIndex - 1);

        var cargo = new List<Stack<char>>();

        int crateStacksCount = PuzzleInput[inputCargo.Count].Count(x => x != ' ');

        for (int i = 0; i < crateStacksCount; i++)
        {
            var crateStack = new Stack<char>();
            for (int j = 0; j < inputCargo.Count; j++)
            {
                char crate = PuzzleInput[inputCargo.Count - 1 - j][1 + (i * 4)];
                if (crate != ' ')
                {
                    crateStack.Push(crate);
                }
            }
            cargo.Add(crateStack);
        }

        return cargo;
    }

    private List<Procedure> GetProceduresFromInput(int seperationLineIndex)
    {
        List<string> inputProcedures = PuzzleInput.GetRange(seperationLineIndex + 1, PuzzleInput.Count - (seperationLineIndex + 1));

        var procedures = new List<Procedure>();

        foreach (string line in inputProcedures)
        {
            string[] split = line.Split(' ');
            procedures.Add(new Procedure(int.Parse(split[1]), int.Parse(split[3]), int.Parse(split[5])));
        }

        return procedures;
    }

    private static void RunProceduresOnCargo_Part1(List<Stack<char>> cargo, List<Procedure> procedures)
    {
        foreach (Procedure procedure in procedures)
        {
            for (int i = 0; i < procedure.Quantity; i++)
            {
                char crate = cargo[procedure.From - 1].Pop();
                cargo[procedure.To - 1].Push(crate);
            }
        }
    }

    private static void RunProceduresOnCargo_Part2(List<Stack<char>> cargo, List<Procedure> procedures)
    {
        var crane = new Stack<char>();

        foreach (Procedure procedure in procedures)
        {
            for (int i = 0; i < procedure.Quantity; i++)
            {
                char crate = cargo[procedure.From - 1].Pop();
                crane.Push(crate);
            }
            for (int i = 0; i < procedure.Quantity; i++)
            {
                char crate = crane.Pop();
                cargo[procedure.To - 1].Push(crate);
            }
        }
    }

    private static string GetSolution(List<Stack<char>> cargo)
    {
        var solution1 = new StringBuilder();

        foreach (Stack<char> crateStack in cargo)
        {
            solution1.Append(crateStack.First());
        }

        return solution1.ToString();
    }

    public readonly record struct Procedure(int Quantity, int From, int To);
}
