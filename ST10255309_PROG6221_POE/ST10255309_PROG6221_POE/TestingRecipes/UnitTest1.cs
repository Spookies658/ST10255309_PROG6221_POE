using Microsoft.VisualStudio.TestTools.UnitTesting;
using ST10255309_PROG6221_POE.Workings;
using System;

namespace TestingRecipes
{
    /*Ethan Smyth
    *ST10255309
    *Group2
    Troeleson, A. Japikse, P. 2022. Pro C# 10 with .Net 6 Foundational Principals and Practices in Programming. Chamsbersburg, PA, USA.
    */

    [TestClass]
    public class WorkingClassTest
    {
        WorkingClass working = new WorkingClass();
        
        //Unit Test for the Calorie Calculation
        [TestMethod]
        public void TestCalorieCalculation_isMoreThan300()
        {
            
            var input = 301;
            var result = working.Equals("Contains more than 300 calories");

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void AddCalories_toRecipe()
        {
            var input = 200;

            var expected = working.Equals(input);

            Assert.IsTrue(expected);
        }

        [TestMethod]
        public void TestTotal_CalorieCalculation()
        {
            int input = 100;
            int input2 = 100;
            int expected = 200;
            
            Assert.AreEqual(expected, input + input2);
        }
    }
}
