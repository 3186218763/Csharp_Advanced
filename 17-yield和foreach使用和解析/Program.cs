
using _17_yield和foreach使用和解析;

#region foreach的使用

MyCollection<int> numbers = new MyCollection<int>();
numbers.Add(1);
numbers.Add(2);
numbers.Add(3);
foreach (int i in numbers)
{
    Console.WriteLine(i);
}

#endregion

#region yield的使用
/*
 *遍历大型数据集：当你需要处理大量数据但不希望一次性加载全部数据时，yield 可以按需加载数据。
实现延迟加载：你可以在需要数据时才加载它们，以提高性能。
生成无限序列：你可以创建生成无限序列的迭代器，只要需要的话就可以一直获取元素。
请注意，yield 关键字只能在方法中使用，用于创建返回 IEnumerable<T> 或 IEnumerator<T> 接口的迭代器方法。这个方法可以通过 foreach 循环或 LINQ 查询来使用，使代码更加高效和可读。
 */


/*
 *
 * 在这个示例中，numbers.Test_yield() 方法是一个迭代器，它返回一个 IEnumerable<int>。
 * 使用 yield return 语句，它逐个生成数字 1 到 3，并在每次生成时暂停执行，将生成的值传递给调用者。
 * 这样，你可以在 foreach 循环中按需访问生成的数字，而不需要将它们全部存储在内存中。
 */


foreach (int i in numbers.Test_yield())
{
    Console.WriteLine(i);
    
}
#endregion