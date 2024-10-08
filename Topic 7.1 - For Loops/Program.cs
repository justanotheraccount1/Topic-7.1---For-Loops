namespace Topic_7._1___For_Loops
{
    internal class Program
    {
        static void Main(string[] args)
            
        {
            int num, numStart, numEnd, numBy;


            //Console.WriteLine("Type a message, and I'll display it five times.");
            //Console.WriteLine("Message: ");
            //String message = Console.ReadLine();
            //for (int i = 2; i <= 10; i = i + 2)
            //{
            //    Console.WriteLine(i + ". " + message);
            //}
            //Console.ReadLine();


            //Console.WriteLine("Type a number for me to count to...");
            //Console.WriteLine(": ");
            //int.TryParse(Console.ReadLine(), out num);
            //for (int i = 1; i <= num; i = i + 1)
            //{
            //    Console.Write(i + ".\t  ");
            //}
            //Console.ReadLine();




            Console.WriteLine("Count From:");
            int.TryParse(Console.ReadLine(), out numStart);
            Console.WriteLine("Count To:");
            int.TryParse(Console.ReadLine(), out numEnd);
            Console.WriteLine("Count By:");
            int.TryParse(Console.ReadLine(), out numBy);
            for (int i = numStart; i <= numEnd; i = i + numBy)
            {
                Console.Write(i + ".\t");
            }
            Console.ReadLine();
        }
    }
}
