using MinCal.Models;
using System.Diagnostics;

namespace UnitTest
{
    public class Tests
    {
        BankCharges B { get; set; } = null;
        [SetUp]
        public void Setup()
        {
            B = new BankCharges();
        }


        [Test]
        public void MonthServFeeTest()
        {

            double exp_res = 11.68, act_res, a = 500;
            int b = 21;

            act_res = B.MonthServFee(a, b);

            Assert.AreEqual(exp_res, act_res);

            Assert.That(act_res, Is.TypeOf<double>());

        }
    }
}