namespace StudyCS2
{
    internal class Test
    {
        private int a;
        private int b;

        public Test(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public static Test operator + (Test t1, Test t2) 
        { 
            return new Test(t1.a + t2.a, t1.b + t2.b);
        }

        public static Test operator - (Test t1, Test t2)
        {
            return new Test(t1.a - t2.a, t1.b - t2.b);
        }

        public static Test operator * (Test t1, Test t2)
        {
            return new Test(t1.a * t2.a, t1.b * t2.b);
        }

        public static Test operator / (Test t1, Test t2)
        {
            return new Test(t1.a / t2.a, t1.b / t2.b);
        }

        public override string ToString()
        {
            return string.Format($"a:{a}, b:{b}");
        }

        class Person
        {
            public string name;
            public int age;

            public Person(string name, int age)
            {
                this.name = name;
                this.age = age;
            }

            //명시적 형변환 오버로딩
            public static explicit operator Person(int age)
            {
                return new Person("아무개", age);
            }

            //묵시적 형변환 오버로딩
            public static explicit operator string(Person person)
            {
                return "제 이름은 " + person.name + "입니다";
            }
        }
    }
}
