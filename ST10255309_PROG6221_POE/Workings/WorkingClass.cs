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
        
        string recipeName;
        string[] ingredientName;
        double[] ingredientQuantity;
        string[] measurementUnit;
        int[] numberSteps;
        string[] stepDescription;


        private int ingredientNumber;
        private string nameIngredient;
        private double quantityIngredient;
        private string unitMeasurement;
        private int stepsNumber;
        private string descriptionStep;
        private string selection;
        private string recipeChoice;



        public void userRecp()
        {
            NamesOfRecipe();
            NumberOfIngredients();
            IngredientProperties();
            OrderSteps();
            StepDescription();
            Views();
            ScalingFactor();
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
            ingredientNumber = Convert.ToInt32(Console.ReadLine());
            return ingredientNumber;
        }

        //Method to prompt user for the properties of the number of ingredients they entered and store them in the array.
        private void IngredientProperties()
        {
            ingredientName = new string[ingredientNumber];
            ingredientQuantity = new double[ingredientNumber];
            measurementUnit = new string[ingredientNumber];
            for (int i = 0; i < ingredientNumber; i++)
            {
                Console.WriteLine("Please enter the name of the ingredient: ");

                ingredientName[i] = Console.ReadLine();
                
                
                Console.WriteLine("Please enter the quantity of the ingredient: ");
                ingredientQuantity[i] = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Please enter the unit of measurement: ");
                measurementUnit[i] = Console.ReadLine();
            }
        }

        //Method to prompt user for the number of steps and store it in the array.
        private int OrderSteps()
        {
            Console.WriteLine("Please enter the number of steps: ");
            stepsNumber = Convert.ToInt32(Console.ReadLine());
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

    }
}
