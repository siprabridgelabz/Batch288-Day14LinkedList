using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProblem
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Linked List Program");
            LinkedListData listData = new LinkedListData();

            while (true)
            {
                Console.WriteLine("*****************************");
                Console.WriteLine("1-Insertion");
                Console.WriteLine("2-Removing First Element");
                Console.WriteLine("Choose the above options ");
                int option = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("*****************************");
                switch (option)
                {
                    case 1:
                        listData.Add(56);
                        listData.Add(30);
                        listData.Add(70);
                        listData.Display();
                        Console.WriteLine("*****************************");
                        break;
                    case 2:

                        listData.FirstRemove();
                        listData.Display();
                        Console.WriteLine("*****************************");
                        break;

                }




            }


        }
    }
}
