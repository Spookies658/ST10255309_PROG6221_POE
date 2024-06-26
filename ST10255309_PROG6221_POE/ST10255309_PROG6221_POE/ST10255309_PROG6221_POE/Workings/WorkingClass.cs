﻿using System;
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
     * simplilearn. 2024. Introduction to List in C#. [Online]. Available at: https://www.simplilearn.com/tutorials/asp-dot-net-tutorial/c-sharp-list. [Accessed 30 May 2024].
     * tutorialspoint.2020. C# Linq SUM() Method. [Online]. Available at: https://www.tutorialspoint.com/chash-linq-sum-method. [Accessed 30 May 2024].
     * learnMicrosft.2024. List<T>.RemoveAt(Int32) Method. [Online]. Available at: https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1.removeat?view=net-8.0 [Accessed 30 May 2024]
     */
    public class WorkingClass
    {
        
        //Creating arraylists and initializing them
        public List<string> recipeName = new List<string>();
        public List<string> ingredientName = new List<string>();
        public List<double> ingredientQuantity = new List<double>();
        public List<string> measurementUnit = new List<string>();
        public List<string> stepDescription = new List<string>();
        public List<double> calories = new List<double>();
        public List<string> group = new List<string>();

        
        private string name;
        private int ingredientNumber;
        private string nameOfIngredient;
        private string quantity;
        private int stepsNumber;
        private string description;
        private string selection;
        private string changeBack;
        private string del;
        
        public void userRecp()
        {
            NamesOfRecipe();
            NumberOfIngredients();
            IngredientPropertiesName();
            IngredientPropertiesMeasurement();
            QuantityIngredients();
            CaptureCalories();
            FoodGroup();
            OrderSteps();
            StepDescription();
            Views();
            ScalingFactor();
        }

        public void Search()
        {
            usrSearch(recipeName);
        }

        public void Gone()
        {
            DeleteRecipe();
        }

        //------------------------------------------------Start of Methods-------------------------------------------------------
       
        //Method to prompt user for the name of the recipe and store it in the array.
        private string NamesOfRecipe()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Please enter the name of the recipe: ");
            Console.ResetColor();
            name = Console.ReadLine();
            if (!string.IsNullOrEmpty(name))
            {
                recipeName.Add(name);
            }
            else {      
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid input, please try again");
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
            Console.WriteLine("Please enter the number of ingredients: ");
            Console.ResetColor();
            try
            {
                ingredientNumber = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid input, please enter a valid integer");
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
                Console.WriteLine($"Please enter the name of the ingredient {i + 1}: ");
                Console.ResetColor();
                nameOfIngredient = Console.ReadLine();
                if(nameOfIngredient != null)
                {
                   ingredientName.Add(nameOfIngredient);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid input, please try again");
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
                Console.WriteLine($"Please enter the measurement unit of the ingredient {i + 1}: ");
                Console.ResetColor();
                quantity = Console.ReadLine();
                if (quantity != null)
                {
                    measurementUnit.Add(quantity);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid input, please try again");
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
                Console.WriteLine($"Please enter the quantity of the ingredient: {i + 1}");
                Console.ResetColor();
                try
                {
                    ingredientQuantity.Add(Convert.ToDouble(Console.ReadLine()));
                }
                catch (Exception e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid input, please enter a valid integer");
                    Console.ResetColor();
                    QuantityIngredients();
                }
            }
        }

        //-----------------------------------------------------------------------------------------------------------------------

        private void CaptureCalories()
        {
            for (int i = 0; i < ingredientNumber; i++) { 
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Please enter the number of calories for ingredient {i + 1}: ");
                Console.ResetColor();
                while (true)
                {
                    try
                    {
                        calories.Add(Convert.ToDouble(Console.ReadLine()));
                        break;
                    }
                    catch (Exception e)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid input, please enter a valid integer");
                        Console.ResetColor();
                        CaptureCalories();
                    }
                }
                  
            }
            
        }


        //-----------------------------------------------------------------------------------------------------------------------

        //Method to prompt user for the food group of the ingredients and store it in the array.
        private void FoodGroup()
        {
            for (int i = 0; i < ingredientNumber; i++)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Please select the food group for ingredient {i + 1}: \n1. Starch\n2. Veg/Fruit\n3. Poultry\n4. Dairy\n5. Liquids");
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
                    Console.WriteLine("Invalid input, please try again");
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
            Console.WriteLine("Please enter the number of steps: ");
            Console.ResetColor();
            try
            {
               stepsNumber = Convert.ToInt32(Console.ReadLine());
            }catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid input, please enter a valid integer");
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
               Console.WriteLine($"Please enter the description of the step {i + 1}: ");
               Console.ResetColor();
               description= Console.ReadLine();
               if(description != null)
               {
                   stepDescription.Add(Console.ReadLine());
               }
               else
               {
                   Console.ForegroundColor = ConsoleColor.Red;
                   Console.WriteLine("Invalid input, please try again");
                   Console.ResetColor();
                   StepDescription();
               }
           }
        }

        //-----------------------------------------------------------------------------------------------------------------------

        //Method to display the recipe to the user.
        private void Views()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            foreach (var recipe in recipeName)
            {
                Console.WriteLine("Recipe Name: " + recipe);
            }
            foreach (var ingredient in ingredientName)
            {
                Console.WriteLine("Ingredient Name: " + ingredient);
            }
            foreach (var quantity in ingredientQuantity)
            {
                Console.WriteLine("Ingredient Quantity: " + quantity);
            }
            foreach (var unit in measurementUnit)
            {
                Console.WriteLine("Measurement Unit: " + unit);
            }
            foreach (var calory in calories)
            {
                Console.WriteLine("Ingredient Calories: " + calory);
                  
            }
            Console.WriteLine("Total Calories: " + calories.Sum());
                if (calories.Sum() > 500)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("This recipe is high in calories");
                    Console.ResetColor();
                }else if(calories.Sum() < 200)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("This recipe is low in calories");
                    Console.ResetColor();
                }else if(calories.Sum() > 200 && calories.Sum() < 500)
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("This recipe is moderate in calories");
                    Console.ResetColor();
                }
            foreach (var group in group)
            {
                Console.WriteLine("Food Group: " + group);
            }
            foreach (var step in stepDescription)
            {
                Console.WriteLine("Step Description: " + step);
            }
            Console.ResetColor();
        }

        //-----------------------------------------------------------------------------------------------------------------------

        //Method to prompt user if they would like to scale the recipe and by how much from the arraylist.
        private void ScalingFactor()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nIf you wish to scale or not, select one of the following options: \n 1. Scale by half\n 2. Scale by 2 times\n 3. Scale by 3 times\n 4. Not required\n");                    
            Console.ResetColor();
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
                Console.WriteLine("Invalid input, please try again");
                Console.ResetColor();
                ScalingFactor();
            }
            

            //-----------------------------------------------------------------------------------------------------------------------

            //Method to prompt the user if they wish to scale the recipe back to its original state.
            if (selection == "1" || selection == "2" || selection == "3")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nWould you like to scale the recipe back to its original state? y/n");
                Console.ResetColor();
                changeBack = Console.ReadLine();
                if (selection == "1" || selection == "2" || selection == "3")
                {
                    Console.WriteLine("Would you like to scale the recipe back to its original state? y/n");
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
                    Console.WriteLine("\nYour recipe will remain scaled\n");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid input, please try again");
                    Console.ResetColor();
                    Console.WriteLine("Would you like to scale the recipe back to its original state? y/n");
                    changeBack = Console.ReadLine();
                }
            }
            
        }
       
        //---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        //Method to display the recipe names in alphabetical order and allow the user to view their selected recipe.
        private void usrSearch(List<string> recipeName)
        {
            Console.WriteLine("Number of recipes: " + recipeName.Count);

            if (recipeName.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("No recipes found");
                Console.ResetColor();
                return;
            }

            recipeName.Sort();
            
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Please select a recipe from the list below: ");
            Console.ResetColor();
            foreach (var recipe in recipeName)
            {
                Console.WriteLine("Recipe Name: " + recipe);
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Please select a recipe to view: ");
            Console.ResetColor();
            string view = Console.ReadLine();
            if (recipeName.Contains(view))
            {
                foreach(var recipe in recipeName)
                {
                    if (recipe == view)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Recipe found");
                        Console.ResetColor();
                        Console.WriteLine("Recipe Name: " + recipe);
                        Console.WriteLine("Ingredients: ");
                        foreach (var ingredient in ingredientName)
                        {
                            Console.WriteLine("Ingredient Name: " + ingredient);
                        }
                        foreach (var quantity in ingredientQuantity)
                        {
                            Console.WriteLine("Ingredient Quantity: " + quantity);
                        }
                        foreach (var unit in measurementUnit)
                        {
                            Console.WriteLine("Measurement Unit: " + unit);
                        }
                        foreach (var calorie in calories)
                        {
                            Console.WriteLine("Calories: " + calorie);   
                        }
                            Console.WriteLine("Total calories: " + calories.Sum());
                            if (calories.Sum() > 500)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("This recipe is high in calories");
                                Console.ResetColor();
                            }
                            else if (calories.Sum() < 200)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("This recipe is low in calories");
                                Console.ResetColor();
                            }
                            else if (calories.Sum() > 200 && calories.Sum() < 500)
                            {
                                Console.ForegroundColor = ConsoleColor.Magenta;
                                Console.WriteLine("This recipe is moderate in calories");
                                Console.ResetColor();
                            }
                        foreach (var group in group)
                        {
                            Console.WriteLine("Food Group: " + group);
                        }
                        foreach (var step in stepDescription)
                        {
                            Console.WriteLine("Step Description: " + step);
                        }
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Recipe not found");
                        Console.ResetColor();
                        usrSearch(recipeName);
                    }
                }
            }
            
        }

        //-----------------------------------------------------------------------------------------------------------------------

        // Method to prompt the user if they want to delete their recipe or not.
       private void DeleteRecipe()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Would you like to delete the recipe? y/n");
            Console.ResetColor();
            del = Console.ReadLine();
            if (del == "y")
            {
                for (int i = 0; i < recipeName.Count; i++)
                {
                    recipeName.RemoveAt(i);
                    ingredientName.RemoveAt(i);
                    ingredientQuantity.RemoveAt(i);
                    measurementUnit.RemoveAt(i);
                    stepDescription.RemoveAt(i);
                    calories.RemoveAt(i);
                    group.RemoveAt(i);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Recipe deleted");
                    Console.ResetColor();
                }
            }
            else if (del == "n")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Recipe will not be deleted");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid input, please try again");
                Console.ResetColor();
                DeleteRecipe();
            }
        }

        //---------------------------------------------End of methods---------------------------------------------------------------

    }
}
//----------------------------------------------------End of File-------------------------------------------------------------------