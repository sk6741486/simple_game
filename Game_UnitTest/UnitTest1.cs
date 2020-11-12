using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using simple_game;
namespace Game_UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        Class_Game Class_obj = new Class_Game();

        [TestMethod]
        public void Test_spin1()
        {
            int spin_unit_data = Class_obj.spin();
            Assert.AreNotEqual(0, spin_unit_data);
        }

        [TestMethod]
        public void Test_spin2()
        {
            int spin_unit_data = Class_obj.spin();
            Assert.AreNotEqual(7, spin_unit_data);
        }

    }
}
