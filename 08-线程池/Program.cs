

using _08_线程池;
Test test = new Test();

for (int i = 0; i < 10; i++)
{
    //因为由线程池启动的线程都是后台线程，所以需要Main线程休息一下，防止后台线程被Main提前终止
    Thread.Sleep(5000);
    ThreadPool.QueueUserWorkItem(test.Fun);
}
