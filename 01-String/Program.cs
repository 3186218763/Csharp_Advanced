using System.Text;
using String类;



//使用扩展的String类
string name = "aja";
Console.WriteLine(name.IsPalindrome());


//使用StringBuilder类
//它用于在内存中创建和操作字符串，特别是当你需要频繁修改字符串内容时。
//与普通的字符串操作（如字符串拼接）相比，使用 StringBuilder 可以提
//供更高的性能和效率。
StringBuilder sb = new StringBuilder(10000);

for (int i = 0; i < 10000; i++)
{
    sb.Append(i.ToString());
    sb.Append(", ");
}

string result = sb.ToString();
Console.WriteLine(result);




