using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ST10255309_PROG6221_POE.Workings
{
    internal class WorkingClass
    {
        
        private string recipeName;
        private string[] ingredientName;
        private double[] ingredientQuantity;
        private string[] measurementUnit;
        private string[] stepDescription;

        

        private int ingredientNumber;
        private int stepsNumber;
        private string selection;
        private string changeBack;
        private string choice;
        

        public void userRecp()
        {
            NamesOfRecipe();
            NumberOfIngredients();
            IngredientProperties();
            QuantityIngredients();
            OrderSteps();
            StepDescription();
            Views();
            ScalingFactor();
        }

        public void ClearRecipe()
        {
            Clear();
        }

       
        //Method to prompt user for the name of the recipe and store it in the array.
        private string NamesOfRecipe()
        {
            Console.WriteLine("Please enter the name of the recipe: ");
            recipeName = Console.ReadLine();
            return recipeName;
        }

        //Method to prompt user for the number of ingredients and store it in the array.
        private int NumberOfIngredients()
        { 
            Console.WriteLine("Please enter the number of ingredients: ");
            try
            {
                ingredientNumber = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("Invalid input, please enter a valid integer");
                NumberOfIngredients();
            }
            return ingredientNumber;
        }

        //Method to prompt user for the properties of the number of ingredients they entered and store them in the array.
        private void IngredientProperties()
        {
            ingredientName = new string [ingredientNumber];
            
            measurementUnit = new string[ingredientNumber];

            for (int i = 0; i < ingredientNumber; i++)
            {
                Console.WriteLine("Please enter the name of the ingredient: ");
                ingredientName[i] = Console.ReadLine();

                Console.WriteLine("Please enter the unit of measurement: ");
                measurementUnit[i] = Console.ReadLine();
            }
        }

        private void QuantityIngredients()
        {

            ingredientQuantity = new double[ingredientNumber];

            for (int i = 0; i < ingredientNumber; i++)
            {
                Console.WriteLine("Please enter the quantity of the ingredient: ");

                try
                {
                    ingredientQuantity[i] = Convert.ToDouble(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine("Invalid input, please enter a valid number");
                }
            }
        }

        //Method to prompt user for the number of steps and store it in the array.
        private int OrderSteps()
        {
            Console.WriteLine("Please enter the number of steps: ");
            try
            {
               stepsNumber = Convert.ToInt32(Console.ReadLine());
            }catch (Exception e)
            {
                Console.WriteLine("Invalid input, please enter a valid integer");
                OrderSteps();
            }
            
            return stepsNumber;
        }

        //Method to prompt user for the description of the steps and store it in the array.
        private void StepDescription()
        {
            stepDescription = new string[stepsNumber];

            for (int i = 0; i < stepsNumber; i++)
            {
                Console.WriteLine("Please enter the description of the step: ");
                stepDescription[i] = Console.ReadLine();
            }
        }

        //Method to display the recipe, ingredients and steps to the user.
        private void Views()
        {
            
            Console.WriteLine("\n\nRecipe name: " + recipeName);
            Console.WriteLine("Ingredients: ");
            for (int i = 0; i < ingredientNumber; i++)
            {
                Console.WriteLine(ingredientName[i] + " " + ingredientQuantity[i] + " " + measurementUnit[i]);
            }
            Console.WriteLine("Steps: ");
            for (int i = 0; i < stepsNumber; i++)
            {
                Console.WriteLine(stepDescription[i]);
            }
        }

        //Method to prompt user if they would like to scale the recipe and by how much.
        private void ScalingFactor()
        {
            Console.WriteLine("\nIf Scaling is required select one of the following:\n " +
                              "1. Scale by half\n" +
                              "2. Scale by 2 times\n" + 
                              "3.Scale by 3 times\n" + 
                              "4. Not required\n");
            selection = Console.ReadLine();
            if(selection == "1")
            {
                for (int i = 0; i < ingredientNumber; i++)
                {
                    ingredientQuantity[i] *= 0.5; 
                }
            }
            else if(selection == "2")
            {
                for (int i = 0; i < ingredientNumber; i++)
                {
                    ingredientQuantity[i] *= 2;
                }
            }
            else if(selection == "3")
            {
                for (int i = 0; i < ingredientNumber; i++)
                {
                    ingredientQuantity[i] *= 3;
                }
            }
            else if(selection == "4")
            {
                Console.WriteLine("No Scaling required\n");
            }
            else
            {
                Console.WriteLine("Invalid input, please try again\n");   
            }

            Views();

            //Method to prompt user if they would like to revert back to their original recipe.

            Console.WriteLine("Would you like to revert back to your original recipe? y/n");
            changeBack = Console.ReadLine();
            if (changeBack == "y")
            {
                if (selection == "1")
                {
                    for (int i = 0; i < ingredientNumber; i++)
                    {
                        ingredientQuantity[i] *= 2;
                    }
                }
                else if (selection == "2")
                {
                    for (int i = 0; i < ingredientNumber; i++)
                    {
                        ingredientQuantity[i] *= 0.5;
                    }
                }
                else if (selection == "3")
                {
                    for (int i = 0; i < ingredientNumber; i++)
                    {
                        ingredientQuantity[i] /= 3;
                    }
                }
                Views();
            } else if (selection == "n")
              {
                    Console.WriteLine("No additional changes made\n");
              }else
               {
                    Console.WriteLine("Invalid input, please try again");
               }
                
        }

        

        private void Clear()
        {
            Console.WriteLine("Would you like to clear the recipe? y/n");
            choice = Console.ReadLine();
            if (choice == "y")
            {
                recipeName = null;
                ingredientName = null;
                ingredientQuantity = null;
                measurementUnit = null;
                stepDescription = null;
                Console.WriteLine("Recipe cleared\n");
            }
            else if (choice == "n")
            {
                Console.WriteLine("Your recipe has not been deleted\n");  
            }
            else
            {
                Console.WriteLine("Invalid input, please try again");
            }
        }
   

    }
}
