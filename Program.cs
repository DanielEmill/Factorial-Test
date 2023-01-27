namespace factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<int> ints = Enumerable.Range(1, 3);
            int factorial = ints.Aggregate((f, s) => f * s);
            Console.WriteLine(factorial);
        }

    }
}