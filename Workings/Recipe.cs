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

        string option;

        //A method to display a menu popup to the user
        public void Menu()
        {
            Console.WriteLine("Please select an option from the menu below: \n\n1. Create Recipe\n2. Delete Recipe\n3. Exit");
            option = Console.ReadLine();
            if (option == "1")
            {
                Create();
            }
            else if (option == "2")
            {
                Delete();
            }
            else if (option == "3")
            {
                Exit();
            }
            else
            {
                Console.WriteLine("Invalid input, please try again");
                Menu();
            }
        }

        //userRecap is called from the WorkingClass so that the user can create a recipe
        private void Create()
        {
            WorkingClass workings = new WorkingClass();
            workings.userRecp();
            Menu();
        }

        //ClearRecipe is called from the WorkingClass so that the user can delete a recipe
        private void Delete()
        {
            WorkingClass workings = new WorkingClass();
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
