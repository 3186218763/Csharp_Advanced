


using System.Net;
using System.Net.Sockets;
using System.Text;

#region 客户端

Socket tepClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
//设置IP 和 port 
IPAddress ipAddress = new IPAddress(new byte[] { 172, 26, 240, 1 });
IPEndPoint inEndPoint = new IPEndPoint(ipAddress, 7788);
tepClient.Connect(inEndPoint);
Console.WriteLine("链接上服务端了");

//发送消息给服务端
string message = "我上线了";
tepClient.Send(Encoding.UTF8.GetBytes(message));//把string转换为Byte数组(二进制):这里UTF8的方法，也可以是其他方法

tepClient.Close();
#endregion

