using System;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {          
            Console.WriteLine("insert maxim");
            string max = Console.ReadLine();
            int maxInt = Int32.Parse(max);
            Problem1 tryEvent = new Problem1(maxInt);
            tryEvent.MaxCountReached += c_MaxCountReached;
            tryEvent.Show();
            while (true)
            {

                Console.WriteLine("Add");
                var value = 0;
                int.TryParse(Console.ReadLine(), out value);
                tryEvent.Plus(value);
                tryEvent.Show();
            }
        }
        static void c_MaxCountReached(object sender, EventArgs e)
        {
            Console.WriteLine("The maxcount was reached.");
            Environment.Exit(0);
        }

    }
}
