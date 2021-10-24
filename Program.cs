using System;
using System.Collections.Generic;

namespace Assessment2_Redo
{
    class Program
    {
        static void Main(string[] args)
        {

            bool goAgain = true;
            while (goAgain == true)
            {

                List<string> foodList = new List<string>();

                //string[] foodList = { "Broccoli", "Tomatoes", "Zucchini" };

                foodList.Add("broccoli");
                foodList.Add("tomatoes");
                foodList.Add("zucchini");


                Console.WriteLine("Hello! Welcome to the farm stand manager. What would you like to do?");
                Console.WriteLine();
                Console.WriteLine("Enter 1 for add items");
                Console.WriteLine("Enter 2 for remove an item");
                Console.WriteLine("Enter 3 for view inventory");
                int menuChoice = int.Parse(Console.ReadLine());



                //add in items to list using the # of items they would like to add
                if (menuChoice == 1)

                {
                    Console.WriteLine("You want to add items. How many would like to add?");
                    int addNum = int.Parse(Console.ReadLine());
                    for (int i = 0; i < addNum; i++)
                    {
                        Console.Write("Enter item: ");
                        foodList.Add(Console.ReadLine());
                        Console.WriteLine("Items added.");
                    }


                }


                //remove items from list
                else if (menuChoice == 2)
                {
                    bool removeAnother = true;
                    while (removeAnother)
                    {
                        Console.WriteLine("You want to remove items. What would you like to remove?: ");
                        string removeFood = Console.ReadLine().ToLower();
                        bool isRemoved = foodList.Remove(removeFood);
                        if (isRemoved)
                        {
                            Console.WriteLine("Item was removed: " + removeFood);
                        }
                        else
                        {
                            Console.WriteLine("Unsuccessful removal");
                        }

                        //remove another item


                        {
                            Console.WriteLine("Would you like to remove another item?: y/n");
                            string removeAnotherChoice = Console.ReadLine().ToLower();

                            if (removeAnotherChoice == "n")
                            {
                                removeAnother = false;
                            }
                            else if (removeAnotherChoice == "y")
                            {
                                removeAnother = true;
                            }

                            else
                            {

                                Console.WriteLine("Invalid Choice. Please enter y or n.");
                                Console.ReadLine().ToLower();
                            }
                        }
                    }
                }
                //view list
                else if (menuChoice == 3)

                    foreach (string food in foodList)
                    {
                        Console.WriteLine(food);
                    }


                else if (menuChoice != 1 && menuChoice != 2 && menuChoice != 3)
                {
                    Console.WriteLine("You have entered and invalid choice.");
                    Console.WriteLine("Please enter 1 for add items, enter 2 for remove an item or enter 3 for view inventory: ");
                }



                Console.WriteLine("Would you like to return to the menu?: y/n");
                string returnToMenu = Console.ReadLine().ToLower();

                if (returnToMenu == "n")
                {
                    goAgain = false;

                    Console.WriteLine("Thanks!");
                }

                else if (returnToMenu == "y")
                {
                    goAgain = true;
                    //loop to top
                }

                //add errror handling for y/n exceptions
                else if (returnToMenu != "y" || returnToMenu !="n")
                {
                    Console.WriteLine("Invalid choice. Please enter y or n: ");
                    Console.ReadLine().ToLower();
                }

            }
           
          
        }

    }
}
