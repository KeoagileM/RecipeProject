using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    internal class Class1
    {
        private String recipeName;
        private String[] recipe;
        private String[] ingredients;
        private double[] measurements;
        private int[] qty;

        public Class1(string recipeName, string[] recipe, string[] ingredients, double[] measurements, int[] qty)
        {
            this.recipeName = recipeName;
            this.recipe = recipe;
            this.ingredients = ingredients;
            this.measurements = measurements;
            this.qty = qty;
        }

        public String getRecipeName()
        {
            return recipeName;
        }

        public String[] getRecipe()
        {
            return recipe;
        }
        public String[] getIngredients()
        {
            return ingredients;
        }
        public double[] getMeasurements()
        {
            return measurements;
        }

        public String setRecipeName(String recipeName)
        {
            this.recipeName = recipeName;
            return recipeName;
        }
        public String[] setRecipe(String[] recipe)
        {
            this.recipe = recipe;

            return this.recipe;
        }

        public String[] setIngredients(String[] ingredients)
        {
           this.ingredients = ingredients;
            return this.ingredients;
        }

        public double[] setMeasurements(double[] measurements)
        {
            this.measurements = measurements;

            return this.measurements;
        }


    }
}
