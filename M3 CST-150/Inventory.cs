/*
 * Branden M
 * 06.04.22
 * Milestone 3
 * CST-150
 * Prof. Mark Smithers
 * Grand Canyon University
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M3_CST_150
{
    public class Inventory
    {
        // Build the foundation for the Array List to hold the item name, cost and supply.
        string Name;
        double Cost;
        int itemAmount;


        // Utilizing the structure into the call for the Array List.
        public Inventory(string n, double c, int iA)
        {
            Name = n;
            Cost = c;
            itemAmount = iA;
        }

        // This will set the format for the Inventory Array.
        public override string ToString()
        {
            return
              String.Format("{0,-10}, Cost: {1,6:C}, Item Amount: {2}", Name, Cost, itemAmount);
        }
    }
}
