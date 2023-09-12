namespace _19_LINQ_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] nums = new int[]{ 10, 2, 3, 4, 5, 9, 7, 8, 9, 10, 11, 12, 13, 14, };

            /*
            //Single:有且只有一个条满足的元素，否则抛出异常
            //SingleOrDefault,最多只有一个元素满足，否则返回默认值
            var result1 = nums.Single(a=>a>10);
            var result2 = nums.SingleOrDefault(a => a > 10);
            Console.WriteLine(result1);
            Console.WriteLine(result2);

            //First:至少有一个元素满足，返回第一个，否则抛出异常
            //FirstOrDefault,返回第一个或者默认值
            var result3 = nums.First(a => a > 10);
            var result4 = nums.FirstOrDefault(a => a > 10);
            Console.WriteLine(result3);
            Console.WriteLine(result4);
            */

            //Order排序
            //list.OrderBy(a=>a.Age)对list类中的Age属性进行正序排序

            //Skip, Take:跳过几个对象，取得几个对象
            
        }
    }
}
