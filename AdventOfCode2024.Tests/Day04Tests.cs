using Xunit;
using Xunit.Abstractions;
using AdventOfCode2024;

namespace AdventOfCode2024.Tests;

public class Day04Tests
{
    [Fact]
    public void TestExample1()
    {
        var filePath = @"C:\GitHub\AdventOfCode2024\InputDocuments\day4_test_data.txt";
        var day = new Day04();
        var sum = day.Part1(filePath);
        System.Diagnostics.Debug.WriteLine($"The sum is {sum}");
    }

    [Fact]
    public void TestPart1()
    {
        var filePath = @"C:\GitHub\AdventOfCode2024\InputDocuments\day4_input.txt";
        var day = new Day04();
        var sum = day.Part1(filePath);
        System.Diagnostics.Debug.WriteLine($"The sum is {sum}");
    }

    [Fact]
    public void TestExample2()
    {
        var filePath = @"C:\GitHub\AdventOfCode2024\InputDocuments\day4_test_data.txt";
        var day = new Day04();
        var sum = day.Part2(filePath);
        System.Diagnostics.Debug.WriteLine($"The sum is {sum}");
    }

    [Fact]
    public void TestPart2()
    {
        var filePath = @"C:\GitHub\AdventOfCode2024\InputDocuments\day4_input.txt";
        var day = new Day04();
        var sum = day.Part2(filePath);
        System.Diagnostics.Debug.WriteLine($"The sum is {sum}");
    }
}
