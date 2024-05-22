using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10255309_PROG6221_POE.Workings
{
    /*
    *Ethan Smyth
    *ST10255309
    *Group2
    *Troeleson, A. Japikse, P. 2022. Pro C# 10 with .Net 6 Foundational Principals and Practices in Programming. Chamsbersburg, PA, USA.
    */
    internal class Ingredients
    {

        private string name;
        private int ingredient;
        private string ingredientName;
        private double ingredientQuantity;
        private string measurementUnit;
        private int numberSteps;
        private string stepDescription;

        //Creating getters and setters for the user input
        public Ingredients(string name, int ingredient, string ingredientName, double ingredientQuantity, string measurementUnit, int numberSteps, string stepDescription)
        {
            this.name = name;
            this.ingredient = ingredient;
            this.ingredientName = ingredientName;
            this.ingredientQuantity = ingredientQuantity;
            this.measurementUnit = measurementUnit;
            this.numberSteps = numberSteps;
            this.stepDescription = stepDescription;
        }

        public string getName()
        {
            return name;
        }

        public int getIngredient()
        {
            return ingredient;
        }

        public string getIngredientName()
        {
            return ingredientName;
        }

        public double getIngredientQuantity()
        {
            return ingredientQuantity;
        }

        public string getMeasurementUnit()
        {
            return measurementUnit;
        }

        public int getNumberSteps()
        {
            return numberSteps;
        }

        public string getStepDescription()
        {
            return stepDescription;
        }
        public void setName(string name)
        {
            this.name = name;
        }

        public void setIngredient(int ingredient)
        {
            this.ingredient = ingredient;
        }

        public void setIngredientName(string ingredientName)
        {
            this.ingredientName = ingredientName;
        }

        public void setIngredientQuantity(double ingredientQuantity)
        {
            this.ingredientQuantity = ingredientQuantity;
        }

        public void setMeasurementUnit(string measurementUnit)
        {
            this.measurementUnit = measurementUnit;
        }

        public void setNumberSteps(int numberSteps)
        {
            this.numberSteps = numberSteps;
        }

        public void setStepDescription(string stepDescription)
        {
            this.stepDescription = stepDescription;
        }
    }
}
