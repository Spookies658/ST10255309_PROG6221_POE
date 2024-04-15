using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10255309_PROG6221_POE.Workings
{
    internal class WorkingClass
    {
        ArrayList name = new ArrayList();
        ArrayList ingredient = new ArrayList();
        ArrayList ingredientName = new ArrayList();
        ArrayList ingredientQuantity = new ArrayList();
        ArrayList measurementUnit = new ArrayList();
        ArrayList numberSteps = new ArrayList();
        ArrayList stepDescription = new ArrayList();

        private string recipeName;
        private int ingredientNumber;
        private string nameIngredient;
        private double quantityIngredient;
        private string unitMeasurement;
        private int stepsNumber;
        private string descriptionStep;
        private string selection;



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
            name.Add(recipeName);
            return recipeName;
        }

        //Method to prompt user for the number of ingredients and store it in the array.
        private int NumberOfIngredients()
        { 
            Console.WriteLine("Please enter the number of ingredients: ");
            ingredientNumber = Convert.ToInt32(Console.ReadLine());
            ingredient.Add(ingredientNumber);
            return ingredientNumber;
        }

        //Method to prompt user for the properties of the number of ingredients they entered and store them in the array.
        private void IngredientProperties()
        {
            
            for (int i = 0; i < ingredientNumber; i++)
            {
                Console.WriteLine("Please enter the name of the ingredient: ");
                nameIngredient = Console.ReadLine();
                ingredientName.Add(nameIngredient);

                Console.WriteLine("Please enter the quantity of the ingredient: ");
                quantityIngredient = Convert.ToDouble(Console.ReadLine());
                ingredientQuantity.Add(quantityIngredient);

                Console.WriteLine("Please enter the unit of measurement: ");
                unitMeasurement = Console.ReadLine();
                measurementUnit.Add(unitMeasurement);
            }
        }

        //Method to prompt user for the number of steps and store it in the array.
        private int OrderSteps()
        {
            Console.WriteLine("Please enter the number of steps: ");
            stepsNumber = Convert.ToInt32(Console.ReadLine());
            numberSteps.Add(stepsNumber);
            return stepsNumber;
        }

        //Method to prompt user for the description of the steps and store it in the array.
        private void StepDescription()
        {
            for (int i = 0; i < stepsNumber; i++)
            {
                Console.WriteLine("Please enter the description of the step: ");
                descriptionStep = Console.ReadLine();
                stepDescription.Add(descriptionStep);
            }
        }

        //Method to display the recipe, ingredients and steps to the user.
        private void Views()
        {
            
            Console.WriteLine("\n\nRecipe: " + name[0]);
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
                    ingredientQuantity[i] = Convert.ToDouble(ingredientQuantity[i]) * 0.5;
                    Console.WriteLine("Name: " + name[0] + "\n" +
                                      "Ingredients: " + ingredientName[i] + " " + ingredientQuantity[i] + " " + measurementUnit[i] + "\n" +
                                      "Steps: " + "\n" +
                                      stepDescription[i] + "\n");
                }
            }
            else if(selection == "2")
            {
                for (int i = 0; i < ingredientNumber; i++)
                {
                    ingredientQuantity[i] = Convert.ToDouble(ingredientQuantity[i]) * 2;
                    Console.WriteLine("Name: " + name[0] + "\n" +
                                      "Ingredients: " + ingredientName[i] + " " + ingredientQuantity[i] + " " + measurementUnit[i] + "\n" +
                                      "Steps: " + "\n" +
                                      stepDescription[i] + "\n");
                }
            }
            else if(selection == "3")
            {
                for (int i = 0; i < ingredientNumber; i++)
                {
                    ingredientQuantity[i] = Convert.ToDouble(ingredientQuantity[i]) * 3;
                    Console.WriteLine("Name: " + name[0] + "\n" +
                                      "Ingredients: " + ingredientName[i] + " " + ingredientQuantity[i] + " " + measurementUnit[i] + "\n" +
                                      "Steps: " + "\n" +
                                      stepDescription[i] + "\n");
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


        }
    }
}
