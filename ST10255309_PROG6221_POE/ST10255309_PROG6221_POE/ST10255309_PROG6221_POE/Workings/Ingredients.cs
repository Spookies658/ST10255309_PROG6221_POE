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

        //Creating the variables for the user input

        private string recipeName;
        private int ingredient;
        private string ingredientName;
        private double ingredientQuantity;
        private string measurementUnit;
        private int numberSteps;
        private string stepDescription;
        private double calories;
        private string group;
        private double quantity;

        //Creating getters and setters for the user input

        public Ingredients(string recipeName, string ingredientName, string measurementUnit, double quantity, double calories, string group, string stepDescription)
        {
            this.recipeName = recipeName;
            this.ingredientName = ingredientName;
            this.measurementUnit = measurementUnit;
            this.quantity = quantity;
            this.calories = calories;
            this.group = group;
            this.stepDescription = stepDescription;
        }

        public string getrecipeName()
        {
            return recipeName;
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

        public double getCalories()
        {
            return calories;
        }

        public string getGroup()
        {
            return group;
        }
        public void setrecipeName(string recipeName)
        {
            this.recipeName = recipeName;
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

        public void setCalories(double calories)
        {
            this.calories = calories;
        }

        public void setGroup(string group)
        {
            this.group = group;
        }
    }
}
