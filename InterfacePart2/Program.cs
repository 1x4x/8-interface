namespace InterfacePart2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyProgram myprogram = new MyProgram();

            IFirst first = myprogram;
            ISecond second = myprogram;

            first.Run();
            int result = second.Run();

            Console.WriteLine("Returvärde: " + result);
        }
    }
}
