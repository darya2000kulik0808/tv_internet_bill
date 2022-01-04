using NUnit.Framework;
using tv_internet_billing;
using System;
using DB_TV_Internet_Billing;

namespace Test_TV_Internet_Billing
{
    public class Tests
    {
        int itog, days_left, balance, current_sum, add_sum, day_pay;
       
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
        public void TEST_decrease_Client_BALANCE()
        {
            Assert.AreEqual(101, TV_Internet_Billing.decrease_Client_BALANCE(current_sum, day_pay, DateTime.Now, DateTime.Parse("2022-01-05")));
            Assert.AreEqual(123, TV_Internet_Billing.decrease_Client_BALANCE(current_sum, day_pay, DateTime.Now, DateTime.Parse("2022-01-02")));
            Assert.AreEqual(123, TV_Internet_Billing.decrease_Client_BALANCE(current_sum, day_pay, DateTime.Now, DateTime.Parse("2022-01-03")));

        }

    }
}