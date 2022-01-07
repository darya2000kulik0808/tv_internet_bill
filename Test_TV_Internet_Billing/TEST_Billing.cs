using NUnit.Framework;
using tv_internet_billing;
using System;
using DB_TV_Internet_Billing;
using Clients_n_ServieListsForTest;

namespace Test_TV_Internet_Billing
{
    public class Tests
    {
        int itog, days_left, balance, current_sum, add_sum, day_pay;
        Decrease_Unlimited unlim = new Decrease_Unlimited();
        Decrease_Limited lim = new Decrease_Limited();
        [SetUp]
        public void Setup()
        {
            current_sum = 123;
            add_sum = 4738;
            day_pay = 22;
        }

        [Test]
        public void TEST_daysLeft()
        {
           Assert.AreEqual(45, TV_Internet_Billing.Calculate_daysLeft(1000, day_pay));
            Assert.AreEqual(7, TV_Internet_Billing.Calculate_daysLeft(157, day_pay));
            Assert.AreEqual(720, TV_Internet_Billing.Calculate_daysLeft(15853, day_pay));
            Assert.AreEqual(0, TV_Internet_Billing.Calculate_daysLeft(0, day_pay));
            Assert.AreEqual(0, TV_Internet_Billing.Calculate_daysLeft(156, 0));
        }


        [Test]
        public void TEST_increase_Client_BALANCE()
        {

            Assert.AreEqual(4861, TV_Internet_Billing.increase_Client_BALANCE(current_sum, add_sum));
        }

        [Test]
        public void TEST_Unlimited_decrease_Client_BALANCE()
        {
            Assert.AreEqual(470, unlim.decrease_Client_BALANCE(1));
            Assert.AreEqual(550, unlim.decrease_Client_BALANCE(2));
            Assert.AreEqual(890, unlim.decrease_Client_BALANCE(3));
            Assert.AreEqual(320, unlim.decrease_Client_BALANCE(4));
        }

        [Test]
        public void TEST_Limited_decrease_Client_BALANCE()
        {
            Assert.AreEqual(350, lim.decrease_Client_BALANCE(5));
            Assert.AreEqual(150, lim.decrease_Client_BALANCE(6));

        }
    }
}