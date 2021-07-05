using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    
    class Program
    {
        
    
        static void Main(string[] args)
        {

            
            Console.WriteLine("First queue contains : ");
            Queue<int> p = new Queue<int>(5);
           
            Console.WriteLine("Enter five diferent integeres : ");
            p.Enqueue(Convert.ToInt32(Console.ReadLine()));
            p.Enqueue(Convert.ToInt32(Console.ReadLine()));
            p.Enqueue(Convert.ToInt32(Console.ReadLine()));
            p.Enqueue(Convert.ToInt32(Console.ReadLine()));
            p.Enqueue(Convert.ToInt32(Console.ReadLine()));

            foreach (int a in p)
                Console.WriteLine("Element  "+a);
            Console.WriteLine("======================");
            Console.WriteLine("Second Queue contains : ");
            Queue<int> q = new Queue<int>(5);
            q.Enqueue(Convert.ToInt32(Console.ReadLine()));
            q.Enqueue(Convert.ToInt32(Console.ReadLine()));
            q.Enqueue(Convert.ToInt32(Console.ReadLine()));
            q.Enqueue(Convert.ToInt32(Console.ReadLine()));
            q.Enqueue(Convert.ToInt32(Console.ReadLine()));

            foreach (int b in q)
                Console.WriteLine("Element  " +b);
            Console.WriteLine("================");
            Console.WriteLine("Copying the first Queue, Press Enter to continue ... ");
            Console.ReadKey();

            List<int> clonedList = new List<int>(p);
            Console.WriteLine(String.Join(",", p));
            

        }
    }
}
