using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Russian_Roulette_Assignment;
namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        Game Obj_game = new Game(); // Declare the object of the game class
        [TestMethod]
        public void RandomNumberPositive() //Postive test case to test the value of the REsult variable between 0 to 7
        {
            Obj_game.spinchamber();
            Assert.IsTrue(Obj_game.Result < 7 && Obj_game.Result > 0);
        }

        //Test case to check the negative test case where we test that result variable value should not be greater than 7
        [TestMethod]
        public void RandomNumberNegative()
        {
            Obj_game.spinchamber();
            Assert.IsFalse(Obj_game.Result > 7 );
        }
    }
}
