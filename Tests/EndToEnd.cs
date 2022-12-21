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
        
        day.Start();

        Assert.That((day.Solution1, day.Solution2), Is.EqualTo((70374, 204610)));
    }

    [Test]
    public void Day2()
    {
        var day = new Day2();

        day.Start();

        Assert.That((day.Solution1, day.Solution2), Is.EqualTo((11603, 12725)));
    }

    [Test]
    public void Day3()
    {
        var day = new Day3();

        day.Start();

        Assert.That((day.Solution1, day.Solution2), Is.EqualTo((8176, 2689)));
    }

    [Test]
    public void Day4()
    {
        var day = new Day4();

        day.Start();

        Assert.That((day.Solution1, day.Solution2), Is.EqualTo((515, 883)));
    }
}