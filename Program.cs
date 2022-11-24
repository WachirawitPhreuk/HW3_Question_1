class Program
{
    static void Main(string[] args)
    {
        CircularLinkedList<char> garland = new CircularLinkedList<char>();
        while(true) {
            char n = char.Parse(Console.ReadLine());
            
            if(n != 'J' && n != 'G' && n != 'O' && n != 'R' ) {
                break;
            }

            garland.Add(n);
        }
        garland.printListGarland();
    }
}