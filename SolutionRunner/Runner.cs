using PuzzleSolution.Days;

class Runner
{
    static void Main(string[] args)
    {
        var puzzleInput = "";
        var day = new One();
        var solution = day.GetSolution(puzzleInput);

        Console.WriteLine(solution);
    }
}
