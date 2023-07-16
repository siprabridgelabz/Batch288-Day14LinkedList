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
            while (true)
            {
                Console.WriteLine("1-Insert data in linked list");
                Console.WriteLine("2-Insert data at perticular element");
                Console.WriteLine("3-Remove first element");
                Console.WriteLine("4- Remove last element");
                Console.WriteLine("5- Search element");
                Console.WriteLine("choose any above option");
                int option = Convert.ToInt32(Console.ReadLine());
                LinkedListData linkesListDemo = new LinkedListData();

                switch (option)
                {
                    case 1:
                        Console.WriteLine("######## data in Linked list #######");
                        linkesListDemo.InsertData(56);
                        linkesListDemo.InsertData(30);
                        linkesListDemo.InsertData(70);
                        linkesListDemo.Display();
                        break;
                    case 2:
                        Console.WriteLine("#####Insert at perticular position ####");
                        linkesListDemo.InsertData(56);
                        //linkesListDemo.InsertData(30);
                        linkesListDemo.InsertData(70);
                        linkesListDemo.InsertAtPerticularPosition(1, 30);
                        break;
                    case 3:
                        Console.WriteLine("######### remove first element ######");
                        linkesListDemo.InsertData(56);
                        linkesListDemo.InsertData(30);
                        linkesListDemo.InsertData(70);
                        linkesListDemo.RemoveFirstElement();
                        linkesListDemo.Display();
                        break;
                    case 4:
                        Console.WriteLine("##### remove last element######");
                        linkesListDemo.InsertData(56);
                        linkesListDemo.InsertData(30);
                        linkesListDemo.InsertData(70);
                        linkesListDemo.RemoveLastElement();
                        linkesListDemo.Display();
                        break;
                    case 5:
                        Console.WriteLine("###### Search Eleement######");
                        linkesListDemo.SearchElement(56);
                        linkesListDemo.Display();
                        break;
                    case 6:
                        linkesListDemo.size();
                        break;
                    default:
                        Console.WriteLine("Invalide option");
                        break;

                }
            }
        }

    }

}
    

