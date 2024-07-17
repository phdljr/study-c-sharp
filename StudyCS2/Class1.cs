using System;
using System.Net;
using System.Net.Sockets;
using System.Collections;
using System.Collections.Generic;

public class Reactor
{
    private List<Socket> _sockets = new List<Socket>();
    private Dictionary<Socket, Action<Socket>> _handlers = new Dictionary<Socket, Action<Socket>>();

    public void RegisterHandler(Socket socket, Action<Socket> handler)
    {
        _sockets.Add(socket);
        _handlers[socket] = handler;
    }

    public void Run()
    {
        while (true)
        {
            var readList = new ArrayList(_sockets);
            var writeList = new ArrayList();
            var errorList = new ArrayList(_sockets);

            Socket.Select(readList, writeList, errorList, 10000000);
            Console.WriteLine("select");

            foreach (Socket socket in readList)
            {
                if (_handlers.TryGetValue(socket, out var handler))
                {
                    handler(socket);
                }
            }

            foreach (Socket socket in errorList)
            {
                _sockets.Remove(socket);
                _handlers.Remove(socket);
                socket.Close();
            }
        }
    }
}

public class Program
{
    public static void Main()
    {
        Reactor reactor = new Reactor();

        // 서버 소켓 설정
        Socket serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        serverSocket.Bind(new IPEndPoint(IPAddress.Any, 11000));
        serverSocket.Listen(10);

        reactor.RegisterHandler(serverSocket, (socket) =>
        {
            Socket clientSocket = socket.Accept();
            Console.WriteLine("Client connected.");
            reactor.RegisterHandler(clientSocket, HandleClient);
        });

        reactor.Run();
    }

    private static void HandleClient(Socket clientSocket)
    {
        byte[] buffer = new byte[1024];
        int bytesRead = clientSocket.Receive(buffer);

        if (bytesRead > 0)
        {
            string receivedText = System.Text.Encoding.UTF8.GetString(buffer, 0, bytesRead);
            Console.WriteLine("Received: " + receivedText);
            clientSocket.Send(System.Text.Encoding.UTF8.GetBytes("Echo: " + receivedText));
        }
        else
        {
            clientSocket.Close();
        }
    }
}