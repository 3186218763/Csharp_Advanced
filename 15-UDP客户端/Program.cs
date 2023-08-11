using System.Net;
using System.Net.Sockets;
using System.Text;

Socket udpClient = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

byte[] data = Encoding.UTF8.GetBytes("udp客户端上线了");

IPAddress ipAddress = new IPAddress(new byte[] { 172, 26, 240, 1 });
IPEndPoint ipEndPoint = new IPEndPoint(ipAddress, 7788);

udpClient.SendTo(data, ipEndPoint);
Console.WriteLine("发送成功");
udpClient.Close();