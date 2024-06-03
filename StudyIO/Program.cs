using System;

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
        Dog dog = new Dog();
        dog.MakeSound(); // Dog barks
        Dog.Test();

        Animal animal = dog;
        animal.MakeSound(); // Animal makes a sound
    }
}