


using System.Reflection;
using _05_反射;

Type type = typeof(Myclass);
Console.WriteLine(type.Name);
Console.WriteLine(type.Namespace);
Console.WriteLine(type.Assembly); //Assembly是配置的意思

//获取类的成员(只public的)
FieldInfo[] fields = type.GetFields();
foreach (FieldInfo field in fields)
{
    Console.WriteLine(field.Name); 
}

//获取类的属性(get,set的，同时只public的)
PropertyInfo[]  properties = type.GetProperties();
foreach (PropertyInfo property in properties)
{
    Console.WriteLine(property.Name);
}

//获取类的方法(只有public)
MethodInfo[]  methods = type.GetMethods();
foreach (MethodInfo method in methods)
{
    Console.WriteLine(method.Name);
}