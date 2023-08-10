

namespace _07_线程基础
{
    internal class Program
    {
        #region Test方法
        static void Test()
        {
            Console.WriteLine("Test Started");

            Console.WriteLine("Test Running");
            Thread.Sleep(3000);
            Console.WriteLine($"当前线程ID:{Thread.CurrentThread.ManagedThreadId}");

            Console.WriteLine("Test Completed");
        }
        #endregion

        /// <summary>
        /// 没有太大用处
        /// </summary>
        #region 异步委托
        delegate void TestDelegate();
        #endregion


        static void Main(string[] args)
        {
            /*调用异步委托(不推荐使用)
            TestDelegate testDelegate = Test;
            testDelegate.BeginInvoke(null, null);
            Console.WriteLine("Main Completed");
            */

            #region 线程的使用
            Thread MyThread1 = new Thread(Test);//放入线程方法
            MyThread1.Start();
            

            #endregion


        }
    }

}

