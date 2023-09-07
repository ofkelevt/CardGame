namespace CardGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Card c = new Card(1, 1);
            Card c1 = new Card(2, 2);
            Card c3= new Card(3, 3);    
            Card c4= new Card(4, 4);
            Console.WriteLine(c);
            Console.WriteLine(c1);
            Console.WriteLine(c3);
            Console.WriteLine(c4);
            string name = Console.ReadLine();
            if (name == null)
            name = Console.ReadLine();
            Player player = new Player(name);

        }
    }
}