namespace AdventOfCode;

public sealed class Day01 : BaseDay
{
    private readonly string _input;

    public Day01()
    {
        _input = File.ReadAllText(InputFilePath);
    }

    public override ValueTask<string> Solve_1()
    {
        int floor = 0;
        foreach (char c in _input)
        {
            if (c == '(')
                floor++;
            else
                floor--;
        }

        return new ValueTask<string>(floor.ToString());
    }

    public override ValueTask<string> Solve_2()
    {
        int floor = 0;
        int idx = 1;
        foreach (char c in _input)
        {
            if (c == '(')
                floor++;
            else
                floor--;

            if (floor == -1)
                return new ValueTask<string>(idx.ToString());
            
            idx++;
        }

        throw new Exception();
    }
}
