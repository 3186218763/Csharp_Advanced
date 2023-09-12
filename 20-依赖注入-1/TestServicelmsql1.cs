namespace _20_依赖注入_1;

public class TestServicelmsql1 :ITestService
{
    public string Name { get; set; }
    public void SayHi()
    {
        Console.WriteLine($"HI,I'm{Name}");
    }
}