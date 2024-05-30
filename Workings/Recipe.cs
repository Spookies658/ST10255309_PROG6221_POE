using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ST10255309_PROG6221_POE.Workings
{
    /*Ethan Smyth
    *ST10255309
    *Group2
    Troeleson, A. Japikse, P. 2022. Pro C# 10 with .Net 6 Foundational Principals and Practices in Programming. Chamsbersburg, PA, USA.
    */
    internal class Recipe
    {

        WorkingClass workings = new WorkingClass();
        string option;

        //A method to display a menu popup to the user
        public void Menu()
        {
            Console.WriteLine("Please select an option from the menu below: \n\n1. Create Recipe\n2. Display\n3. Exit");
            option = Console.ReadLine();
            if (option == "1")
            {
                Create();
            }
            else if (option == "2")
            {
                Display();
            }
            else if (option == "3")
            {
                Exit();
                
            }
            else if (option == "4")
            {
                
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid input, please try again");
                Console.ResetColor();
                Menu();
            }
        }

        //userRecap is called from the WorkingClass so that the user can create a recipe
        private void Create()
        {
           
            workings.userRecp();
            Menu();
        }

        //usrSearch is called from WorkingClass so that the user can search for a recipe
        private void Display()
        {
           
            workings.Search();
            Menu();
        }


        //ClearRecipe is called from the WorkingClass so that the user can delete a recipe
        private void Delete()
        {
            
            workings.ClearRecipe();
            Menu();
        }

       
        //Method to exit the application
        private void Exit()
        {
            Console.WriteLine("Thank you for using the Recipe Application");
            System.Environment.Exit(0);
        }
    }
}
