namespace _20_依赖注入_1;

public class TestServicelmsql2:ITestService
{
    public string Name { get; set; }
    public void SayHi()
    {
        Console.WriteLine($"你好,我是{Name}");
    }
}