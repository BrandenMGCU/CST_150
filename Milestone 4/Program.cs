/*
 * Branden M
 * 06.04.22
 * Milestone 4
 * CST-150
 * Prof. Mark Smithers
 * Grand Canyon University
 */
using System;
using System.Collections;
using System.Drawing;
using System.Linq;

namespace Milestone_4
{
    public class Program
    {
        public class InventoryShoppingList
        {
            public static void Main()
            {
                /*
                 * Some format of a "login system". Only for testing purposes!
                 */
                void SystemLogin()
                {
                    Console.WriteLine("Before we begin, we will need you to login!");
                    // Asking for the username.
                    Console.WriteLine();
                    Console.WriteLine("What is the username?");
                    Console.WriteLine("Type: admin");
                    string username = Console.ReadLine();

                    // Asking for the password.
                    Console.WriteLine("What is the password?");
                    Console.WriteLine("Type: password");
                    string password = Console.ReadLine();
                    Console.WriteLine("\n");

                    // If the username and password are correct then the store will open.
                    if (username == "admin")
                    {
                        Console.WriteLine("CORRECT!");
                        if (password == "password")
                            Console.WriteLine("CORRECT!");
                        Console.ForegroundColor = ConsoleColor.Green;
                        {
                            Console.WriteLine("Welcome admin!");
                            Console.Clear();
                            Console.WriteLine("Welcome to the Digital Store!" + "\n");
                            Console.ForegroundColor= ConsoleColor.White;
                            return;
                        }
                    }

                    // If the username and password are not correct then the store won't open.
                    if (username != "admin" || password != "password")
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("WRONG!!!");
                        Console.WriteLine("The username is: admin");
                        Console.WriteLine("The password is: password");
                    }

                    // Call the login function to try again!
                    SystemLogin();
                    Console.ForegroundColor = ConsoleColor.White;
                }






                // Call the login function before being able to access the store!
                SystemLogin();

                ArrayList shoppingItems = new ArrayList();

                // Thi will add the items into the Array.
                shoppingItems.Add(new Inventory("Item 1", 5.95, 3));
                shoppingItems.Add(new Inventory("Item 2", 8.29, 2));
                shoppingItems.Add(new Inventory("Item 3", 3.50, 4));
                shoppingItems.Add(new Inventory("Item 4", 19.88, 8));

                // Here to show the user the current Array List.
                Console.WriteLine("Here is the current inventory list:");

                // The list of items in the Array.
                foreach (Inventory i in shoppingItems)
                {
                    Console.WriteLine(" " + i);
                    
                }

                AddItem();


                // This is here to add a space in between.
                Console.WriteLine();

                /*
                 * Adding an item to the Array List from the user.
                 * There is the option to say yes or no and so far is
                 * programmed to handle each response. 
                 */

                void AddItem()
                {
                    Console.WriteLine("Would you like to add an item?");
                    string option = Console.ReadLine();
                    Console.WriteLine();

                    // If the user selects yes, then the user can create their own item.

                    if (option == "no" || option == "No")
                    {
                        Console.WriteLine("I'm advising you to say 'yes' and add an item!");
                        AddItem();

                    }

                    if (option == "yes" || option == "Yes")
                    {
                        // User can name the item.
                        Console.WriteLine("What is the name of the item?");
                        string itemname = Console.ReadLine();
                        Console.WriteLine();

                        // User can set the cost of the item.
                        Console.WriteLine("What is the cost of the item?");
                        double itemcost = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine();

                        // User can tell the inventory amount of the item.
                        Console.WriteLine("How many of these items do you have?");
                        int itemcount = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();

                        // The item will then be added to the ArrayList.
                        shoppingItems.Add(new Inventory(itemname, itemcost, itemcount));

                        // This is here to provide space in-between content.
                        Console.WriteLine();

                        // Shows the NEW updated list with the item they added.
                        Console.WriteLine("Here is the updated inventory list:");

                        // Current new Array List.
                        foreach (Inventory i in shoppingItems)
                        {
                            Console.WriteLine("   " + i);
                        }

                        Console.WriteLine("Would you like to add another item?");
                        string anotherItem = Console.ReadLine();
                        if (anotherItem == "yes" || anotherItem == "Yes")
                        {
                            AddItem();
                        }

                        if (anotherItem == "no" || anotherItem == "No")
                        {
                            Console.WriteLine();
                            Console.WriteLine("Moving forward to the Deletion option!");
                            Delete();

                        }
                        // END OF THE YES OPTION. 

                        /*
                         * The start of the user saying no.
                         * If the user says no, then it will just
                         * display the current ArrayList.
                         */
                        if (option == "no" || option == "No")
                        {
                            foreach (Inventory i in shoppingItems)
                            {
                                Console.WriteLine("   " + i);
                            }
                        }
                        /* END OF THE NO OPTION */



                        // This is here to create a line of space.
                        Console.WriteLine();


                        void Delete()
                        {
                            /*
                             * This is the start of the deletion.
                             * The user can input either yes or no.
                             */
                            Console.WriteLine("Would you like to delete that last added item?");
                            string userDelete = Console.ReadLine();
                            Console.WriteLine();

                            /* If the user selects yes, then the item you added to the
                             * ArrayList will then be deleted, which in the next function
                             * can be added back.
                             */
                            if (userDelete == "yes" || userDelete == "Yes")
                            {
                                // Removing the last item in the ArrayList.
                                shoppingItems.RemoveAt(shoppingItems.Count - 1);
                                Console.WriteLine("The last item you added has been deleted from the list.");

                            }

                            /*
                             * If the user selects no, then the current ArrayList will be shown.
                             */
                            if (userDelete != "no" || userDelete == "No")
                            {
                                foreach (Inventory i in shoppingItems)
                                {
                                    Console.WriteLine("   " + i);
                                }
                                Console.WriteLine("Would you like to restock or add and item?");
                                string userDelete2 = Console.ReadLine();

                                if (userDelete2 == "restock" || userDelete2 =="Restock")
                                {
                                    Restock();
                                }

                                if (userDelete2 == "add" || userDelete2 == "Add" || userDelete2 == "ADD")
                                {
                                    AddItem();
                                }
                                
                            }

                            /*
                             * The start of the undo / re-add function of getting the deleted
                             * item back into the Array List.
                             */
                            void Restock()
                            {
                                Console.WriteLine();
                                Console.WriteLine("Would you like to restock that deleted item?");
                                string userUndo = Console.ReadLine();
                                Console.WriteLine();

                                // If yes, then the item will be added back.
                                if (userUndo == "yes" || userUndo == "Yes")
                                {

                                    shoppingItems.Add(new Inventory(itemname, itemcost, itemcount));
                                    Console.WriteLine("Here is the list after the correction of your last item.");
                                    foreach (Inventory i in shoppingItems)
                                    {
                                        Console.WriteLine("   " + i);
                                        Console.WriteLine();
                                    }

                                    Console.WriteLine("Would you like to go back or continue?");
                                    string userRestock = Console.ReadLine();

                                    if (userRestock == "go back" || userRestock == "Go Back")
                                    {
                                        Delete();
                                    }

                                    if (userRestock == "continue" || userRestock == "Continue")
                                    {
                                        Search();
                                    }
                                }

                                // If no then the current list will be shown.
                                if (userUndo == "no" || userUndo == "No")
                                {
                                    foreach (Inventory i in shoppingItems)
                                    {
                                        Console.WriteLine("   " + i);
                                    }
                                    Console.WriteLine("Would you like to quit or go back?");
                                    string userchoice1 = Console.ReadLine();

                                    if (userchoice1 == "go back" || userchoice1 == "Go Back")
                                    {
                                        Delete();
                                    }

                                    if (userchoice1 == "continue" || userchoice1 == "Continue")
                                    {
                                        Search();
                                    }
                                        
                                }


                                // The start of the search function. 
                                Console.WriteLine();
                                

                                /* Call to the search funtion that will then allow for the user
                                 * to search through the Array List.
                                 */
                                void Search()
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("Please enter the information below!");
                                    string search = Console.ReadLine();
                                    Console.WriteLine();

                                    bool found = true;

                                    if (search.Contains(itemname))
                                    {
                                        found = true;
                                        Console.WriteLine("Your search for: " + search + " was found!");
                                        Console.WriteLine((itemname, (int)itemcost, itemcount));
                                    }

                                    if (search.Contains(Convert.ToString(itemcount)))
                                    {
                                        Console.WriteLine("Your search for: " + search + " was found!");
                                        Console.WriteLine((itemname, (int)itemcost, itemcount));
                                    }

                                    // If the item is not in the Array List, it will tell the user.
                                    else if (!search.Contains(itemname) || !search.Equals(itemname))
                                    {
                                        found = false;
                                        Console.WriteLine(found + " Your searched term was not found!");
                                        return;
                                    }
                                    
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}

