

using System.Net;
using System.Net.Sockets;
using System.Text;

//包的形式
Socket udpServer = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
//设置IP 和 port 并绑定
IPAddress ipAddress = new IPAddress(new byte[] { 172, 26, 240, 1 });
IPEndPoint ipEndPoint = new IPEndPoint(ipAddress, 7788);
udpServer.Bind(ipEndPoint);

IPEndPoint ipEnd = new IPEndPoint(IPAddress.Any, 0);
EndPoint ep = ipEnd as EndPoint;

byte[] data = new byte[1024];
Console.WriteLine("服务启动");
int Length =  udpServer.ReceiveFrom(data,ref ep);


Console.WriteLine($"接受的数据为{Encoding.UTF8.GetString(data, 0, Length)}");
udpServer.Close();
Console.WriteLine("服务结束");


