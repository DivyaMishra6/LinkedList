namespace LinkedList
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to LinkedList Program");

            Console.WriteLine("**********************************");
            List list = new List();
            list.Add(56);
            list.Add(30);
            list.Add(70);
            list.Display();
        }
    }
}