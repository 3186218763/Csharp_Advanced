namespace _08_线程池;

public class Test
{
    public void Fun(object state)
    {
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"Fun启动了{Thread.CurrentThread.ManagedThreadId}");
            Thread.Sleep( 100 );
        }
        
    }
}