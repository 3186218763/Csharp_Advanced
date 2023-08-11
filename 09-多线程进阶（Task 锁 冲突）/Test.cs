namespace _09_多线程进阶_Task_锁_冲突_;

public class Test
{
    public void Fun()
    {
        for (int i = 0; i < 10000; i++)
        {
            Console.WriteLine("A");
        }
    }

    /// <summary>
    /// 假设是一个下载任务
    /// </summary>
    public void Download()
    {
        Console.WriteLine("Downlading...");
        Thread.Sleep(2000);
    }

    public void Alert(Task t)
    {
        Console.WriteLine("下载完成");
    }
}