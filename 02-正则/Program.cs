using System.Text.RegularExpressions;

//正则表达式(Regular Expression)是一种文本模式，包括普通字符（例如，a 到 z 之间的字母）和特殊字符（称为"元字符"），可以用来描述和匹配字符串的特定模式。
//正则表达式是一种用于模式匹配和搜索文本的工具。
//正则表达式提供了一种灵活且强大的方式来查找、替换、验证和提取文本数据
//正则表达式可以通过ChatGPT来查询格式
bool Answer = Regex.IsMatch("sssss", @"^\d");


Console.WriteLine(Answer);