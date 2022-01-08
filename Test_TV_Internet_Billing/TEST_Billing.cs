using NUnit.Framework;
using tv_internet_billing;
using System;
using System.Collections.Generic;
using DB_TV_Internet_Billing;
using Clients_n_ServieListsForTest;
using Services;
using Clients;

namespace Test_TV_Internet_Billing
{
    public class Tests
    {
        int itog, days_left, balance, current_sum, add_sum, day_pay;
        Decrease_Unlimited unlim = new Decrease_Unlimited();
        Decrease_Limited lim = new Decrease_Limited();
        List<Client> clients;
        List<Service> services;
        int compare_result;
        int[] arr_equal;

        [SetUp]
        public void Setup()
        {
            current_sum = 123;
            add_sum = 4738;
            day_pay = 22;

            Clients_n_Service_Lists cs_lists = new Clients_n_Service_Lists();

            clients = cs_lists.GetClients();
            services = cs_lists.GetServices();
            compare_result = 0;

            arr_equal = new int[6] { 470, 550, 890, 320, 350, 150 };
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
        public void TEST_Decreasing()
        {

            foreach (Client client in clients)
            {
                compare_result = DateTime.Compare(DateTime.Now.Date, client.Time_balance.Date);

                foreach (Service service in services)
                {
                    if (client.ID_service == service.ID_service && service.limit == false)
                    {
                        client.Balance = unlim.decreasing(Decimal.ToInt32(client.Balance), Decimal.ToInt32(service.Price_service),
                                                          client.Limits, Decimal.ToInt32(service.Price_for_limit), compare_result);
                        Assert.AreEqual(arr_equal[client.ID_client-1], client.Balance);
                    }
                    else if (client.ID_service == service.ID_service && service.limit == true)
                    {
                        client.Balance = lim.decreasing(Decimal.ToInt32(client.Balance), Decimal.ToInt32(service.Price_service),
                                                          client.Limits, Decimal.ToInt32(service.Price_for_limit), compare_result);
                        Assert.AreEqual(arr_equal[client.ID_client - 1], client.Balance);
                    }
                }
            }
        }
    }
}