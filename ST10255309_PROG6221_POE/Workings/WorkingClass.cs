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

      
        public void userRecp()
        {
            NamesOfRecipe();
            NumberOfIngredients();
            IngredientProperties();
            OrderSteps();
            StepDescription();
        }


        public string NamesOfRecipe()
        {
            Console.WriteLine("Please enter the name of the recipe: ");
            recipeName = Console.ReadLine();
            name.Add(recipeName);
            return recipeName;
        } 

        public int NumberOfIngredients()
        {
            Console.WriteLine("Please enter the number of ingredients: ");
            ingredientNumber = Convert.ToInt32(Console.ReadLine());
            ingredient.Add(ingredientNumber);
            return ingredientNumber;
        }

        public void IngredientProperties()
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

       public int OrderSteps()
        {
            Console.WriteLine("Please enter the number of steps: ");
            stepsNumber = Convert.ToInt32(Console.ReadLine());
            numberSteps.Add(stepsNumber);
            return stepsNumber;
        }

        public void StepDescription()
        {
            for (int i = 0; i < stepsNumber; i++)
            {
                Console.WriteLine("Please enter the description of the step: ");
                descriptionStep = Console.ReadLine();
                stepDescription.Add(descriptionStep);
            }
        }

       

    }
}
