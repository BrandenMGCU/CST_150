/* Branden M
 * 05.30.22
 * Activity 10
 * CST-150 
 * Prof. Mark Smithers
 * Grand Canyon University
 */

using System;

/* Corrected by Branden M. */

namespace Activity_10_CST_150
{
    public class Set
{
        private List<int> elements;

        public Set()
        {
            elements = new List<int>();
        }
        public bool addElement(int val)
        {
            if (containsElement(val)) return false;
            else
            {
                elements.Add(val);
                return true;
            }
        }


        private bool containsElement(int val)
        {
            for (int i = 0; i < elements.Count; i++)
            {
                if (val == elements[i])
                    return true;
                /* Instead of else return false, return false was sufficent. */
                 // Original Code - else return false;
            }
            return false;
        }

        public override string ToString()
        {
            string str = "";
            foreach (int i in elements)
            {
                str += i + " ";
            }
            return str;
        }

        public void clearSet()
        {
            elements.Clear();
        }

        /* Add both Set A and B to keep it simple. 
         * Create a unified Set to then add both Sets into the elements.
         Change rhs to be both Set A and B now.*/


        /*The original problem was:
         * public Set union(Set rhs) { 
            for (int i = 0; i < rhs.elements.Count; i++) {
             this.addElement(rhs.elements[i]);
            }
            return rhs;
        }*/

        /* Restructured union function. */
        public Set union(Set A, Set B)
        {
            Set unionSet = new Set();
            for (int i = 0; i < A.elements.Count; i++)
            {
                unionSet.addElement(A.elements[i]);
            }

            for (int i = 0; i < B.elements.Count; i++)
            {
                unionSet.addElement(B.elements[i]);
            }
            return unionSet;
        }

    }
}
