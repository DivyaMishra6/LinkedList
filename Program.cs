namespace LinkedList
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to LinkedList Program");

            Console.WriteLine("**********************************");

            Console.WriteLine("Welcome to Linkedlist problem!");
            Console.WriteLine("**********************************");
            List list = new List();
            list.Add(56);
            Console.WriteLine("Node with data 56 is First Created");
            Console.WriteLine(" ");
            list.Add(70);
            Console.WriteLine("Finally Append 70 to 30");
            Console.WriteLine(" ");
            list.Insertion(2, 30);
            Console.WriteLine("Finally insert 30 in between 56 and 70:");
            Console.WriteLine(" ");
            Console.WriteLine("LinkedList Sequence:");
            list.Display();
        }
    }
}