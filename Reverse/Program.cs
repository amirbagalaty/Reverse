using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace AmirReversed
{
    class program
    {
        static void Main(string[] args)
        {
            LinkedList<string> superhero = new LinkedList<string>(); ;

            LinkedListNode<string> spiderman = superhero.AddFirst("tom holland");

            superhero.AddLast("Tobey Maguire");
            superhero.AddAfter(spiderman, "Garfield");
            superhero.AddBefore(spiderman, "Jake Johnson");
            superhero.AddLast("Drake Bell");
            Console.WriteLine("The linked List Before Reversing: \n ");
            foreach (var item in superhero)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine("The linked List After Reversing: \n ");
            foreach (var item in superhero.Reverse())
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.ReadKey();
        }

    }
}
