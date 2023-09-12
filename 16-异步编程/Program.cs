using Microsoft.VisualBasic;

namespace _16_异步编程
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            #region 普通使用异步方法
            /*
            string filename = @"F:\a\01.txt";
            await File.WriteAllTextAsync(filename, "hello");
            string s = await File.ReadAllTextAsync(filename);
            Console.WriteLine(s);
            */
            #endregion

            //int length = await DownloadHtmlAsync("https://learn.microsoft.com/zh-cn/dotnet/csharp/language-reference/statements/using", @"F:\a\01.txt");
            //await Test_await();

            //Console.WriteLine($"之前{Thread.CurrentThread.ManagedThreadId}");
            //await Test_Thred();
            //Console.WriteLine($"之后{Thread.CurrentThread.ManagedThreadId}");

            CancellationTokenSource cts = new CancellationTokenSource();
            cts.CancelAfter(5000);
            await Test_CancellationToken(@"https://learn.microsoft.com/zh-cn/dotnet/csharp/language-reference/statements/using", 100, cts.Token);
        }

        /// <summary>
        /// 如何异步方法
        /// </summary>
        /// <param name="url"></param>
        /// <param name="filename"></param>
        /// <returns></returns>
        static async Task<int> DownloadHtmlAsync(string url, string filename)
        {
            using var httpClient = new HttpClient();
            var html = await httpClient.GetStringAsync(url);
            //如果想要异步线程休息，不能使用Thread.Sleep(),而是下面
            await Task.Delay(3000);
            await File.WriteAllTextAsync(filename, html);
            return html.Length;


        }
        /// <summary>
        /// 测试await:await调用的等待期间，
        /// .NET会把当前的线程返回给线程池
        /// 等异步方法调用执行完毕后，
        /// 框架会从线程池再取出来一个
        /// 线程执行后续的代码。
        /// </summary>
        /// <returns></returns>
        static async Task Test_await()
        {
            Console.WriteLine($"之前{Thread.CurrentThread.ManagedThreadId}");
            string str = "XXXXXX";
            await File.WriteAllTextAsync(@"F:\a\01.txt", str);
            Console.WriteLine($"之后{Thread.CurrentThread.ManagedThreadId}");
        }
        /// <summary>
        /// 异步方法不是多线程，异步不会自动切换线程
        /// </summary>
        /// <returns></returns>
        static void Test_Thred()
        {
            Console.WriteLine("任务执行");
        }

        /// <summary>
        /// 异步方法可以不写async,当此方法内容不复杂，需要直接返回Task<>时，这样可以提高线程的效率
        /// </summary>
        /// <returns></returns>
        static Task<string> Test_NoAsync()
        {
            return File.ReadAllTextAsync(@"F:\a\01.txt");
        }
        /// <summary>
        /// 有时需要提前终止任务，比如：
        /// 请求超时、用户取消请求
        /// 很多异步方法都有CancellationToken参数，
        /// 用于获得提前终止执行的信号
        /// </summary>
        /// <returns></returns>
        static async Task Test_CancellationToken(string url, int n, CancellationToken cancellationToken)
        {
            using var httpClient = new HttpClient();
            for (int i = 0; i < n; i++)
            {

                var html = await httpClient.GetStringAsync(url, cancellationToken);
                Console.WriteLine($"{DateAndTime.Now}:{html}");
                /*
                if (cancellationToken.IsCancellationRequested)
                {
                    Console.WriteLine("请求被取消");
                    break;
                }
                */
                //cancellationToken.ThrowIfCancellationRequested();
                
            }
        }

        /// <summary>
        /// Task.WhenAll的使用,等待参数中所有的异步方法执行完，在进行后面的操作
        /// </summary>
        /// <returns></returns>
        static async Task Test_WhenAll()
        {
            Task<string> t1 = File.ReadAllTextAsync("path1");
            Task<string> t2 = File.ReadAllTextAsync("path2");
            Task<string> t3 = File.ReadAllTextAsync("path3");
            
            string[] strs = await Task.WhenAll(t1, t2, t3);

            foreach (string s in strs)
            {
                Console.WriteLine(s);
            }
        }
    }
}
