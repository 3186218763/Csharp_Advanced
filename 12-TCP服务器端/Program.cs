using System.Net;
using System.Net.Sockets;
using System.Text;

#region 服务端

//                             使用IPv4                   使用Stream类型       通信协议       
Socket tcpServer = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);


//设置IP 和 port 并绑定
IPAddress ipAddress = new IPAddress(new byte[] { 172, 26, 240, 1 });
IPEndPoint inEndPoint = new IPEndPoint(ipAddress, 7788);
tcpServer.Bind(inEndPoint);//绑定

tcpServer.Listen(100);//最多允许100个连接

Console.WriteLine("服务启动");
Socket client = tcpServer.Accept();//开始监听，返回链接上的Socket
Console.WriteLine("有一个服务端链接了");

//接收数据
byte[] data = new byte[1024];
int Length = client.Receive(data);
string message =  Encoding.UTF8.GetString(data, 0, Length);
Console.WriteLine($"接受到客户端的消息: {message}");

#endregion
