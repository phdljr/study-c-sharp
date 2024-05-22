public class Test
{
    // 델리게이트 선언
    public delegate void MyDelegate(int num);

    // 위에서 선언한 델리게이트를 멤버 필드로서 사용
    private MyDelegate myEvent;
    public event MyDelegate MyEvent
    {
        add { MyEvent += value; }
        remove { MyEvent -= value; }
    }

    public Test()
    {
        MyEvent += Print1;
        MyEvent += Print2;
        MyEvent -= Print1;
        // event 속성이기 때문에 = 연산자 사용 못함
        //MyEvent = Print2;
    }

    public void Print1(int num)
    {
        Console.WriteLine(num + " good");
    }

    public void Print2(int num)
    {
        Console.WriteLine(num + " nice");
    }

    public void OnTest()
    {
        myEvent(10);
    }
}

public class Program
{
    static void Main(string[] args)
    {
        Test test = new Test();
        test.OnTest();
        //event는 외부에서 호출 못함
        //test.MyEvent();
    }
}