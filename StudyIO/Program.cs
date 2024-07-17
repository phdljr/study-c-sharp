using System;
using System.Net.Sockets;
using System.Net;

// 부모 클래스
public class Animal
{
    // 가상 메서드
    public virtual void MakeSound()
    {
        Console.WriteLine("Animal makes a sound");
    }

    static public void Test()
    {
        Console.WriteLine("Animal");
    }
}

// 자식 클래스
public class Dog : Animal
{
    // 부모 클래스의 가상 메서드를 오버라이드
    public override void MakeSound()
    {
        Console.WriteLine("Dog barks");
    }

    new static public void Test()
    {
        Console.WriteLine("Dog");
    }
}

class Program
{
    static void Main(string[] args)
    {
        var socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        socket.Connect(new IPEndPoint(IPAddress.Loopback, 11000));
        socket.Send(System.Text.Encoding.UTF8.GetBytes("Hello!"));
        Thread.Sleep(3000);
        socket.Close();
    }
}