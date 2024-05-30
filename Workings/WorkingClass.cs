using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ST10255309_PROG6221_POE.Workings
{

    /*Ethan Smyth
     *ST10255309
     *Group2
     * References
     * w3schools.2024. C# Try and Catch. [ONLINE] Available at: https://www.w3schools.com/cs/cs_exceptions.php. [Accessed 17 May 2024].
     * codeacademy. 2023. .Clear. [ONLINE] Available at: https://www.codecademy.com/resources/docs/c-sharp/arrays/clear. [Accessed 17 May 2024].
     * Troeleson, A. Japikse, P. 2022. Pro C# 10 with .Net 6 Foundational Principals and Practices in Programming. Chamsbersburg, PA, USA.
     * w3schools. 2024. C# The if else statement. [ONLINE] Available at: https://www.w3schools.com/cs/cs_conditions_elseif.php. [Accessed 17 May 2024].
     * geeksforgeeks. 2023. C# List Class. [ONLINE] Available at: https://www.geeksforgeeks.org/c-sharp-list-class/. [Accessed 23 May 2024].
     * geeksforgeeks. 2019. C# | How to change Foreground Color of Text in Console. [Online] Acailable at: https://www.geeksforgeeks.org/c-sharp-how-to-change-foreground-color-of-text-in-console/. [Accessed 23 May 2024].
     * oreilly. 2024. Checking for null. [ONLINE] Available at:https://www.oreilly.com/library/view/c-71-and/9781788398077/daa9b00f-274a-4554-8287-4c303e9d2de3.xhtml#:~:text=If%20you%20are%20trying%20to,howManyLetters%20%3D%20authorName%3F. [Accessed 23 May 2024].
     * code4noobz. 2024. C# Multiply all elements in a list. [Online] Available at: https://code.4noobz.net/multiply-all-elements-from-a-list/ [Accessed 24 May 2024].
     * geeksforgeeks. 2021. C# | Delegates. [Online]. Available at: https://www.geeksforgeeks.org/c-sharp-delegates/, [Accessed 30 May 2024].
    */
    internal class WorkingClass
    {
        
        //Creating arraylists and initializing them
        List<string> recipeName = new List<string>();
        List<string> ingredientName = new List<string>();
        List<double> ingredientQuantity = new List<double>();
        List<string> measurementUnit = new List<string>();
        List<string> stepDescription = new List<string>();
        List<double> calories = new List<double>();
        List<string> group = new List<string>();

        private delegate double InputCalories();
        private string name;
        private int ingredientNumber;
        private string nameOfIngredient;
        private string quantity;
        private int stepsNumber;
        private string description;
        private string selection;
        private string changeBack;
        private string choice;
        
        public void userRecp()
        {
            NamesOfRecipe();
            NumberOfIngredients();
            IngredientPropertiesName();
            IngredientPropertiesMeasurement();
            QuantityIngredients();
            Calories(CaptureCalories);
            FoodGroup();
            OrderSteps();
            StepDescription();
            Views();
            ScalingFactor();
        }

        public void ClearRecipe()
        {
            Clear();
        }

        public void Search()
        {
            usrSearch();
        }

        //------------------------------------------------Start of Methods-------------------------------------------------------
       
        //Method to prompt user for the name of the recipe and store it in the array.
        private string NamesOfRecipe()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Please enter the name of the recipe: ", Console.ForegroundColor);
            Console.ResetColor();
            name = Console.ReadLine();
            if (name != null)
            {
                recipeName.Add(name);
            }
            else {      
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid input, please try again", Console.ForegroundColor);
                Console.ResetColor();
                NamesOfRecipe();
            }
           return name;
        }

        //-----------------------------------------------------------------------------------------------------------------------

        //Method to prompt user for the number of ingredients and store it in the array.
        private int NumberOfIngredients()
        { 
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Please enter the number of ingredients: ", Console.ForegroundColor);
            Console.ResetColor();
            try
            {
                ingredientNumber = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid input, please enter a valid integer", Console.ForegroundColor);
                Console.ResetColor();
                NumberOfIngredients();
            }
            return ingredientNumber;
        }

        //-----------------------------------------------------------------------------------------------------------------------

        //Method to prompt user for the ingredient name and measurement unit of the number of ingredients they entered and store them in the array.
        private void IngredientPropertiesName()
        {
            for (int i = 0; i < ingredientNumber; i++)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Please enter the name of the ingredient {i + 1}: ", Console.ForegroundColor);
                Console.ResetColor();
                nameOfIngredient = Console.ReadLine();
                if(nameOfIngredient != null)
                {
                   ingredientName.Add(nameOfIngredient);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid input, please try again", Console.ForegroundColor);
                    Console.ResetColor();
                    IngredientPropertiesName();
                }
            }
        }

        //-----------------------------------------------------------------------------------------------------------------------

        //Method to prompt user for the measurement unit of the ingredients and store it in the array.
        private void IngredientPropertiesMeasurement()
        {
            for (int i = 0; i < ingredientNumber; i++)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Please enter the measurement unit of the ingredient {i + 1}: ", Console.ForegroundColor);
                Console.ResetColor();
                quantity = Console.ReadLine();
                if (quantity != null)
                {
                    measurementUnit.Add(quantity);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid input, please try again", Console.ForegroundColor);
                    Console.ResetColor();
                    IngredientPropertiesMeasurement();
                }
            }
        }

        //-----------------------------------------------------------------------------------------------------------------------

        //Method to prompt user for the quantity of the ingredients and store it in the array.
        private void QuantityIngredients()
        {

            for (int i = 0; i < ingredientNumber; i++)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Please enter the quantity of the ingredient: {i + 1}", Console.ForegroundColor);
                Console.ResetColor();
                try
                {
                    ingredientQuantity.Add(Convert.ToDouble(Console.ReadLine()));
                }
                catch (Exception e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid input, please enter a valid integer", Console.ForegroundColor);
                    Console.ResetColor();
                    QuantityIngredients();
                }
            }
        }

        //-----------------------------------------------------------------------------------------------------------------------

        private double CaptureCalories()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Please enter the calories of the ingredient: ", Console.ForegroundColor);
            Console.ResetColor();
            double calory;
            while (true)
            {
                try
                {
                    calory = Convert.ToDouble(Console.ReadLine());
                    break;
                }
                catch (Exception e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid input, please enter a valid integer", Console.ForegroundColor);
                    Console.ResetColor();
                    CaptureCalories();
                }

            }
            return calory;
        }

        private void Calories(InputCalories inputCalories)
        {
            for (int i = 0; i < ingredientNumber; i++)
            {
                    calories.Add(inputCalories());
            }
        }

        //-----------------------------------------------------------------------------------------------------------------------

        //Method to prompt user for the food group of the ingredients and store it in the array.
        private void FoodGroup()
        {
            for (int i = 0; i < ingredientNumber; i++)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Please select the food group for ingredient {i + 1}: \n1. Starch\n2. Veg/Fruit\n3. Poultry\n4. Dairy\n5. Liquids", Console.ForegroundColor);
                Console.ResetColor();
                string option = Console.ReadLine();
                if (option == "1")
                {
                    group.Add("Starch");
                }
                else if (option == "2")
                {
                    group.Add("Veg/Fruit");
                }
                else if (option == "3")
                {
                    group.Add("Poultry");
                }
                else if (option == "4")
                {
                    group.Add("Dairy");
                }
                else if (option == "5")
                {
                    group.Add("Liquids");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid input, please try again", Console.ForegroundColor);
                    Console.ResetColor();
                    FoodGroup();
                }
                
            }
        }

        //-----------------------------------------------------------------------------------------------------------------------

        //Method to prompt user for the number of steps and store it in the array.
        private int OrderSteps()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Please enter the number of steps: ", Console.ForegroundColor);
            Console.ResetColor();
            try
            {
               stepsNumber = Convert.ToInt32(Console.ReadLine());
            }catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid input, please enter a valid integer", Console.ForegroundColor);
                Console.ResetColor();
                OrderSteps();
            }
            
            return stepsNumber;
        }

        //-----------------------------------------------------------------------------------------------------------------------

        //Method to prompt user for the description of the steps and store it in the array.
        private void StepDescription()
        {
           for(int i = 0; i < stepsNumber; i++)
           {
               Console.ForegroundColor = ConsoleColor.Yellow;
               Console.WriteLine("Please enter the description of the step: ", Console.ForegroundColor);
               Console.ResetColor();
               description= Console.ReadLine();
               if(description != null)
               {
                   stepDescription.Add(Console.ReadLine());
               }
               else
               {
                   Console.ForegroundColor = ConsoleColor.Red;
                   Console.WriteLine("Invalid input, please try again", Console.ForegroundColor);
                   Console.ResetColor();
                   StepDescription();
               }
           }
        }

        //-----------------------------------------------------------------------------------------------------------------------

        //Method to display the recipe, ingredients and steps to the user.
        private void Views()
        {
            for (int i = 0; i < recipeName.Count; i++)
            {
                Console.WriteLine("Recipe Name: " + recipeName[i]);
            }
            for (int i = 0; i < ingredientName.Count; i++)
            {
                Console.WriteLine("Ingredients: " + ingredientName[i]);
            }
            for (int i = 0; i < measurementUnit.Count; i++)
            {
                Console.WriteLine("Measurement Unit: " + measurementUnit[i]);
            }
            for (int i = 0; i < ingredientQuantity.Count; i++)
            {
                Console.WriteLine("Quantity: " + ingredientQuantity[i]);
            }
            for (int i = 0; i < calories.Count; i++)
            {
                Console.WriteLine("Calories: " + calories[i]);
            }
            for (int i = 0; i < group.Count; i++)
            {
                Console.WriteLine("Food Group: " + group[i]);
            }
            for (int i = 0; i < stepDescription.Count; i++)
            {
                Console.WriteLine("Steps: " + stepDescription[i]); 
            }
            
        }

        //-----------------------------------------------------------------------------------------------------------------------

        //Method to prompt user if they would like to scale the recipe and by how much from the arraylist.
        private void ScalingFactor()
        {
            Console.WriteLine("\nIf you wish to scale or not, select one of the following options: \n" +
                              "1. Scale by half\n" +
                              "2. Scale by 2 times\n" +
                              "3. Scale by 3 times\n" +
                              "4. Not required\n");
            selection = Console.ReadLine();
            if (selection == "1")
            {
                ingredientQuantity = ingredientQuantity.Select(x => x / 2).ToList();
            }
            else if (selection == "2")
            {
                ingredientQuantity = ingredientQuantity.Select(x => x * 2).ToList();
            }
            else if (selection == "3")
            {
               ingredientQuantity = ingredientQuantity.Select(x => x * 3).ToList();
            }
            else if (selection == "4")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("No changes made\n", Console.ForegroundColor);
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid input, please try again", Console.ForegroundColor);
                Console.ResetColor();
                ScalingFactor();
            }
            Views();

            //-----------------------------------------------------------------------------------------------------------------------

            //Method to prompt the user if they wish to scale the recipe back to its original state.
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nWould you like to scale the recipe back to its original state? y/n", Console.ForegroundColor);
            Console.ResetColor();
            changeBack = Console.ReadLine();
            if (selection == "1" || selection == "2" || selection == "3")
            {
                Console.WriteLine("Would you like to scale the recipe back to its original state? y/n", Console.ForegroundColor);
                Console.ResetColor();
                changeBack = Console.ReadLine();
                if (changeBack == "y")
                {
                    if (selection == "1")
                    {
                        ingredientQuantity = ingredientQuantity.Select(x => x * 2).ToList();
                    }
                    else if (selection == "2")
                    {
                        ingredientQuantity = ingredientQuantity.Select(x => x / 2).ToList();
                    }
                    else if (selection == "3")
                    {
                        ingredientQuantity = ingredientQuantity.Select(x => x / 3).ToList();
                    }
                }
            }
            else if (changeBack == "n")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nYour recipe will remain scaled", Console.ForegroundColor);
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid input, please try again", Console.ForegroundColor);
                Console.ResetColor();
                Console.WriteLine("Would you like to scale the recipe back to its original state? y/n");
                changeBack = Console.ReadLine();
            }
            Views();
        }
       
        //-----------------------------------------------------------------------------------------------------------------------
        
        // Method to prompt the user if they want to delete their recipe or not.
        private void Clear()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Would you like to delete your recipe? y/n", Console.ForegroundColor);
            Console.ResetColor();
            choice = Console.ReadLine();
            if (choice == "y")
            {
                recipeName.Clear();
                ingredientName.Clear();
                ingredientQuantity.Clear();
                measurementUnit.Clear();
                stepDescription.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Recipe cleared\n", Console.ForegroundColor);
                Console.ResetColor();
            }
            else if (choice == "n")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Your recipe has not been deleted\n", Console.ForegroundColor);
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid input, please try again", Console.ForegroundColor);
                Console.ResetColor();
            }
        }

        //---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        //Method to display the recipe names in alphabetical order and allow the user to view their selected recipe.
        private void usrSearch()
        {
            
            for (int i = 0; i < recipeName.Count; i++)
            {
                recipeName.Sort();
                Console.WriteLine($"Recipe {i + 1}: " + recipeName[i]);
            }

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Please enter the name of the recipe you would like to search for: ", Console.ForegroundColor);
            Console.ResetColor();
            string search = Console.ReadLine();
            for(int i = 0; i < recipeName.Count; i++)
            {
                if (recipeName[i] == search)
                {
                    Console.WriteLine("Recipe Name: " + recipeName[i]);
                    Console.WriteLine("Ingredients: " + ingredientName[i]);
                    Console.WriteLine("Measurement Unit: " + measurementUnit[i]);
                    Console.WriteLine("Quantity: " + ingredientQuantity[i]);
                    Console.WriteLine("Calories: " + calories[i]);
                    if (calories[i] > 300)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("This recipe contains more than 300 calories", Console.ForegroundColor);
                        Console.ResetColor();
                    }
                    Console.WriteLine("Food Group: " + group[i]);
                    Console.WriteLine("Steps: " + stepDescription[i]);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Recipe not found", Console.ForegroundColor);
                    Console.ResetColor();
                }
            }
        }
   
        //---------------------------------------------End of methods---------------------------------------------------------------

    }
}
//----------------------------------------------------End of File-------------------------------------------------------------------