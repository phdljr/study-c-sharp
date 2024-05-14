namespace StudyCS
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, };
            var evenNumbers = from num in numbers
                              where num % 2 == 0
                              select num;

            foreach (var number in evenNumbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
