using System.Net;
using System.Net.Sockets;

namespace FileShare_system.SenderOrServerSide
{
    public static class SenderSide
    {
        private class severTCP
        {
        }

        public static void Main(string[] args)
        {
            ExecuteServer();
        }

        private static void establishConnection()
        {
            IPEndPoint ep = new IPEndPoint(IPAddress.Loopback, 1234); // Address
            TcpListener listener = new TcpListener(ep); // Instantiate the object
            listener.Start();// Start listening...
        }

        private static void ExecuteServer()
        {
            establishConnection();
        }
    }
}