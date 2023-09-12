using Microsoft.Extensions.DependencyInjection;

namespace _20_依赖注入_1
{
    internal class Program
    {


        static void Main(string[] args)
        {
            ServiceCollection services = new ServiceCollection();
            services.AddScoped<ITestService, TestServicelmsql1>();
            //services.AddScoped(typeof(ITestService), typeof(TestServicelmsql1));
            //services.AddSingleton(typeof(ITestService), new TestServicelmsql1()));
            using (ServiceProvider sp = services.BuildServiceProvider())
            {
                ITestService ts1 = sp.GetService<ITestService>();//这里的泛型必须是AddScoped<ITestService,的
                ITestService ts2 = sp.GetRequiredService<ITestService>();//GetService如果没有取得对象，返回null，GetRequiredService没有对象返回异常
                ts1.Name = "tom";
                ts1.SayHi();
            }
        }

        static void Test1(string[] args)
        {

            ServiceCollection services = new ServiceCollection();
            //services.AddTransient<TestServicelmsql1>();//Transient的使用要谨慎
            //services.AddSingleton<TestServicelmsql1>();//若类无状态，使用这个
            services.AddScoped<TestServicelmsql1>();//若类有状态，使用这个
            #region 普通使用
            /*
            using var serviceProvider = services.BuildServiceProvider();
            //serviceProvider==服务定位器
            var testService = serviceProvider.GetService<TestServicelmsql1>();
            testService.Name = "Tom";
            testService.SayHi();
            */
            #endregion

            #region 生命周期
            using (var sp = services.BuildServiceProvider())
            {
                using (IServiceScope scope1 = sp.CreateScope())
                {
                    var t = scope1.ServiceProvider.GetService<TestServicelmsql1>();
                    t.Name = "dd";
                    t.SayHi();
                }
            }
            

            #endregion


        }
    }
}
