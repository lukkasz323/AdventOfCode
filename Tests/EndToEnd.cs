using AoC_2022;
using AoC_2022.Days;

namespace Tests;

public class EndToEnd
{
    [SetUp]
    public void Setup() 
    {

    }

    [Test]
    public void Day1()
    {
        var day = new Day1();
        
        day.Run();

        Assert.That((day.Solution1, day.Solution2), Is.EqualTo((70374, 204610)));
    }

    [Test]
    public void Day2()
    {
        var day = new Day2();

        day.Run();

        Assert.That((day.Solution1, day.Solution2), Is.EqualTo((11603, 12725)));
    }

    [Test]
    public void Day3()
    {
        var day = new Day3();

        day.Run();

        Assert.That((day.Solution1, day.Solution2), Is.EqualTo((8176, 2689)));
    }

    [Test]
    public void Day4()
    {
        var day = new Day4();

        day.Run();

        Assert.That((day.Solution1, day.Solution2), Is.EqualTo((515, 883)));
    }

    [Test]
    public void Day5()
    {
        var day = new Day5();

        day.Run();

        Assert.That((day.Solution1, day.Solution2), Is.EqualTo(("CVCWCRTVQ", "CNSCZWLVT")));
    }

    [Test]
    public void Day6()
    {
        var day = new Day6();

        day.Run();

        Assert.That((day.Solution1, day.Solution2), Is.EqualTo((1578, 2178)));
    }
}