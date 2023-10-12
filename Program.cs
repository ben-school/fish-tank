namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the length:");
            int length = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter the depth:");
            int depth = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter the height:");
            int height = Int32.Parse(Console.ReadLine());

            Console.Clear();

            Console.WriteLine($"Length: {length}\nDepth: {depth}\nHeight: {height}\n\n\nVolume: {(length * depth * height) / 1000}L");
        }
    }
}
