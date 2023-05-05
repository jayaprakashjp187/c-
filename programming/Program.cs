namespace programming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Human jp = new Human();
            Console.WriteLine("please enter your name");
            jp.name = Console.ReadLine();
            Console.WriteLine("please enter your height");
            jp.height = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("please enter your phoneNumber");
            jp.phoneNumber = Convert.ToInt64(Console.ReadLine());

            jp.HumanDetails();
        }
    }
}