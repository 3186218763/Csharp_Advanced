
namespace _03_委托
{
    internal class Program
    {
        delegate double DoubleOpDelegate(double x);
        private static void Main()
        {
            //委托一个方法给一个变量，这个变量可以是一个数组集合
            DoubleOpDelegate[] opDelegates = { MathOp.MultiplayByTwo, MathOp.Square };
            foreach (var VARIABLE in opDelegates)
            {
                //Console.WriteLine(VARIABLE(3));
            }

            //系统提供的Action : 必须指向没有返回值的方法
            static void Text(int x){}
            Action<int> textAction = Text;//<参数类型>

            //系统提供的Func: 必须指向有返回值的方法
            static string Text1(int x)
            {
                return $"hhh{x}";
            }
            Func<int, string> textFunc = Text1;//<先参数类型, 再返回类型>

            //多播委托
            //使用多播委托就可以按照顺序调用多个方法，多播委托只能得到调用的最后一个方
            //法的结果，一般我们把多播委托的返回类型声明为void
            //多播委托包含一个逐个调用的委托集合，如果通过委托调用的其中一个方法抛出异常，整个迭代就会停止。
            static void Test1(){ Console.WriteLine("Test1");}
            static void Test2(){Console.WriteLine("Test2");}
            Action myAction = Test1;
            myAction += Test2;
            Delegate[] myDelegateList = myAction.GetInvocationList();//获取myAction的委托list
            foreach (Delegate @delegate in myDelegateList)
            {
                @delegate.DynamicInvoke();
            }


            //匿名方法

            //一般形式
            Func<int, int, int> plusFunc = delegate(int a, int b)
            {
                return a + b;
            };
            Console.WriteLine(plusFunc(1,2));
            //Lambda形式
            //Func<int, int, int> plusFunc2 = (a, b) => {return a + b;};//如果只有一行，可简化为下面
            Func<int, int, int> plusFunc2 = (a, b) => a + b;
            Console.WriteLine(plusFunc2(1,2));
        }
    }
}
