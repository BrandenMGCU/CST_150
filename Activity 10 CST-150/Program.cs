/* Branden M
 * 05.30.22
 * Activity 10
 * CST-150 
 * Prof. Mark Smithers
 * Grand Canyon University
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Corrected by Branden M. */

/* Namespace needs to be changed to function with this project */

// Original Code - namespace CST117_IC08_console

namespace Activity_10_CST_150
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //make some sets
            /* No Changes */
            Set A = new Set();
            Set B = new Set();

            //put some stuff in the sets
            /* No Changes.*/ 
            Random r = new Random();

            /* No Changes. */
            for (int i = 0; i < 10; i++)
            {
                A.addElement(r.Next(4));
                B.addElement(r.Next(12));
            }

            //display each set and the union

            /* Adding a line for a bit more context and clarification */
            Console.WriteLine("Here are the given sets:");

            Console.WriteLine("A: " + A);

            Console.WriteLine("B: " + B);


            /* Error, A.union(B) shows just Set A.
             * 
             * Original Code - Console.WriteLine("A union B: " + A.union(B));
             */
            
            Console.WriteLine("A union B: " + A.union(A,B));

            /* Adding a space for context and clarity */
            Console.WriteLine();


            //display original sets (should be unchanged)
            Console.WriteLine("After union operation");
            Console.WriteLine("A: " + A);
            Console.WriteLine("B: " + B);

        }
    }
}

