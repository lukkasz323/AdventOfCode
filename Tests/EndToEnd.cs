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
}