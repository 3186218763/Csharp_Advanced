using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String类
{
    /// <summary>
    /// 扩展String类:创建一个静态类，并在该类中定义扩展方法来实现的。
    /// </summary>
    public static class StringExtension
    {
        // 扩展方法：将字符串倒转
        public static string Reverse(this string str)
        {
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        // 扩展方法：检查字符串是否是回文
        public static bool IsPalindrome(this string str)
        {
            string reversedStr = str.Reverse();
            return str.Equals(reversedStr, StringComparison.OrdinalIgnoreCase);
        }
    }
}
