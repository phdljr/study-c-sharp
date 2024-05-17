using System.IO;
using System.Net.Sockets;
using System.Text;

namespace MyProgram
{

    public class Program
    {
        static void Main()
        {
            // (1) IP 주소와 포트를 지정하고 TCP 연결 
            TcpClient tc = new TcpClient("127.0.0.1", 7000);
            //TcpClient tc = new TcpClient("localhost", 7000);

            NetworkStream stream = null!;
            string msg;
            while ((msg = Console.ReadLine()!) != "exit")
            {
                byte[] buff = Encoding.ASCII.GetBytes(msg);

                // (2) NetworkStream을 얻어옴 
                stream = tc.GetStream();

                // (3) 스트림에 바이트 데이타 전송
                stream.Write(buff, 0, buff.Length);

                // (4) 스트림으로부터 바이트 데이타 읽기
                byte[] outbuf = new byte[1024];
                int nbytes = stream.Read(outbuf, 0, outbuf.Length);
                string output = Encoding.ASCII.GetString(outbuf, 0, nbytes);

                Console.WriteLine($"{nbytes} bytes: {output}");
            }
            // (5) 스트림과 TcpClient 객체 닫기
            stream.Close();
            tc.Close();
        }
    }
}