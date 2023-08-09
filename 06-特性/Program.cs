//只有当下面这个IS_DEBUG宏被调用的时候，下面的[Conditional("IS_DEBUG")]标记的方法可以被调用
#define IS_DEBUG

using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace _06_特性
{
    internal class Program
    {
        [Obsolete("这个方法被弃用了")] //特性：弃用
        static void Test()
        {
            Console.WriteLine("Test");
        }

        [Conditional("IS_DEBUG")] //特性：条件判断（根据宏来判断）
        static void ShowMessage(string message)
        {
            Console.WriteLine(message);

        }

                                            //获取调用方法的行数                    //获取调用方法的路径                      //获取调用方法所在的函数名
        [DebuggerStepThrough]//特性：调试使直接略过这个方法（但是不影响方法的执行，只影响调试）
        static void Message(string message, [CallerLineNumber] int LineNumber = 0, [CallerFilePath] string filepath = "", [CallerMemberName]string memberName = "")
        {
            Console.WriteLine($"message:          {message}");
            Console.WriteLine($"调用的行数为：      {LineNumber}");
            Console.WriteLine($"调用方法的路径为：   {filepath}");
            Console.WriteLine($"调用方法所在的函数名：{memberName}");
        }
        static void Main(string[] args)
        {
            /*
            //Test();
            ShowMessage("before");
            Console.WriteLine("doing");
            ShowMessage("after");
            */
            Message("Hello");
        }
    }
}

