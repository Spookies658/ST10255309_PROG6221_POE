using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10255309_PROG6221_POE.Workings
{
    internal class Ingredients
    {

        private int ingredient;
        private string ingredientName;
        private double ingredientQuantity;
        private string measurementUnit;

        //Creating getters and setters for the user input
        public Ingredients(int ingredient, string ingredientName, double ingredientQuantity, string measurementUnit)
        {
            this.ingredient = ingredient;
            this.ingredientName = ingredientName;
            this.ingredientQuantity = ingredientQuantity;
            this.measurementUnit = measurementUnit;
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
    }
}
