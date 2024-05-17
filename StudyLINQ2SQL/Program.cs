namespace MyProgram
{

    public class Program
    {
        static void Main()
        {
            int[] numbers = [0,1,2,3,4,5];

            var numQuery = from num in numbers
                           where num % 2 == 0
                           orderby num descending
                           select num;

            var numQuery2 = numbers.Where(num => num % 2 == 0).OrderBy(num => -num);

            foreach (int i in numQuery2)
            {
                Console.Write("{0, 5}", i);
            }
        }
    }
}