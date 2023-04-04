using System.Linq;

namespace LinkedListsProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> linkedList = new LinkedList<string>();

            linkedList.AddLast("January");
            linkedList.AddLast("February");
            linkedList.AddLast("March");
            linkedList.AddLast("April");
            linkedList.AddLast("May");
            linkedList.AddLast("June");
            linkedList.AddLast("July");
            linkedList.AddLast("August");
            linkedList.AddLast("September");
            linkedList.AddLast("October");
            linkedList.AddLast("November");
            linkedList.AddLast("December");
            //end
            DisplayLinkedListNode(linkedList);
            Console.WriteLine("------------");
            //start new operation
            linkedList.Remove(linkedList.First);
            //end 

            DisplayLinkedListNode(linkedList);
            Console.WriteLine("------------first remove Jan");

            linkedList.Remove(linkedList.First);

            DisplayLinkedListNode(linkedList);
            Console.WriteLine("------------Value string to Remove fun");
            
            linkedList.Remove("June");

            DisplayLinkedListNode(linkedList);
            Console.WriteLine("------------");

            bool isContains = linkedList.Contains("June");


            Console.WriteLine($"Is node value contains linkedlist: {isContains}");
            Console.WriteLine("------------");
            LinkedListNode<string> node = linkedList.Find("Mays");
            //Console.WriteLine(node.Value);

            
            if (isContains)
            {
                Console.WriteLine($"Node exist");
            }
            else
            {
                if (node != null)
                {
                    linkedList.AddAfter(node, "June");
                }
                else
                {
                    Console.WriteLine("Node value not be in linkedlist");
                }
            }

            DisplayLinkedListNode(linkedList);
            Console.WriteLine("------------");
        }

        static void DisplayLinkedListNode(LinkedList<string> parmList)
        {
            foreach (string node in parmList)
            {
                Console.WriteLine(node);
            }
        }
    }
}