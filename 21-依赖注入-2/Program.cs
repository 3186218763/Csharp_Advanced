using Microsoft.Extensions.DependencyInjection;

namespace _21_依赖注入_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ServiceCollection services = new ServiceCollection();
            //设置依赖
            services.AddScoped<Controller>();
            services.AddScoped<ILog, LogImp1>();
            services.AddScoped<IStorage, StorageImp1>();
            services.AddScoped<IConfig, Configimp1>();

            using (var sp = services.BuildServiceProvider())
            {
                var c = sp.GetRequiredService<Controller>();
                c.Test();
            }

        }


        class Controller
        {
            private readonly ILog log;
            private readonly IStorage storage;
            public Controller(ILog log, IStorage storage)
            {
                this.log = log;
                this.storage = storage;
            }

            public void Test()
            {
                log.Log("开始上传");
                this.storage.Save("content内容","01.txt");
                log.Log("上传完成");
            }
        }

        interface ILog
        {
            public void Log(string message);
        }

        class LogImp1 : ILog
        {
            public void Log(string message)
            {
                Console.WriteLine($"日志: {message}");
            }
        }


    }

    interface IConfig
    {
        public string GetValue(string name);
    }

    class Configimp1 : IConfig
    {
        public string GetValue(string name)
        {
            return "hello";
        }
    }

    interface IStorage
    {
        public void Save(string content, string name);
    }

    class StorageImp1 : IStorage
    {
        private readonly IConfig config;

        public StorageImp1(IConfig config)
        {
            this.config = config;
        }
        public void Save(string content, string name)
        {
            string server = config.GetValue("server");
            Console.WriteLine($"向服务器{server}的文件名为{name}上传");
        }
    }
}
