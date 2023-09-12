
int[] nums = new int[] { 3, 5, 1515, 111, 11, 2, 6, 555 };

//使用LINQ中Where方法，找出数组中大于10的数
var results = nums.Where(a=>a>10);
foreach (int i in results)
{
    Console.WriteLine(i);
}

//使用LINQ中的Count方法，找出满足对象的个数
var resultCount = nums.Count(a=>a>10);
Console.WriteLine(resultCount);