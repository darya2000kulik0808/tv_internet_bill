using System;
using System.Collections.Generic;
using Clients;
using ServiceListSource;
using Services;

namespace Clients_n_ServieListsForTest
{
    public class Clients_n_Service_Lists : IClient_List, IServiceSource
    {
        public List<Service> GetServices()
        {
            List<Service> service = new List<Service>();

            service.Add(new Service()
            {
                ID_service = 1,
                Name_service = "Услуга 1",
                Description_service = "Описание 1",
                Period_payment = 1,
                Price_service = 50,
                Price_connection = 500,
                Price_for_limit = 0,
                limit = false
        });
            service.Add(new Service()
            {
                ID_service = 2,
                Name_service = "Услуга 2",
                Description_service = "Описание 2",
                Period_payment = 1,
                Price_service = 30,
                Price_connection = 500,
                Price_for_limit = 0,
                limit = false
            });
            service.Add(new Service()
            {
                ID_service = 3,
                Name_service = "Услуга 3",
                Description_service = "Описание 3",
                Period_payment = 1,
                Price_service = 80,
                Price_connection = 500,
                Price_for_limit = 0,
                limit = false

            });
            service.Add(new Service()
            {
                ID_service = 4,
                Name_service = "Услуга 4",
                Description_service = "Описание 4",
                Period_payment = 1,
                Price_service = 10,
                Price_connection = 500,
                Price_for_limit = 0,
                limit = false
            });
            service.Add(new Service()
            {
                ID_service = 5,
                Name_service = "Услуга 5",
                Description_service = "Описание 4",
                Period_payment = 1,
                Price_service = 50,
                Price_connection = 500,
                Price_for_limit = 10,
                limit = true
            });
            service.Add(new Service()
            {
                ID_service = 6,
                Name_service = "Услуга 6",
                Description_service = "Описание 6",
                Period_payment = 1,
                Price_service = 60,
                Price_connection = 500,
                Price_for_limit = 5,
                limit = true
            });
            return service;
        }
        public List<Client> GetClients()
        {
            List<Client> client = new List<Client>();
            client.Add(new Client()
            {
                ID_client = 1,
                Name_client = "Имя 1",
                Birthday = DateTime.Parse("1989-09-01"),
                E_mail = "1name@mail.ru",
                Balance = 500,
                ID_service = 2,
                Time_balance = DateTime.Parse("2022-01-06"),
                Client_login = "login1",
                Client_password = "pass1",
                Limits = 0
            });
            client.Add(new Client()
            {
                ID_client = 2,
                Name_client = "Имя 2",
                Birthday = DateTime.Parse("1989-09-02"),
                E_mail = "2name@mail.ru",
                Balance = 600,
                ID_service = 1,
                Time_balance = DateTime.Parse("2022-01-06"),
                Client_login = "login2",
                Client_password = "pass2",
                Limits = 0
            });
            client.Add(new Client()
            {
                ID_client = 3,
                Name_client = "Имя 3",
                Birthday = DateTime.Parse("1989-09-03"),
                E_mail = "3name@mail.ru",
                Balance = 900,
                ID_service = 4,
                Time_balance = DateTime.Parse("2022-01-06"),
                Client_login = "login3",
                Client_password = "pass3",
                Limits = 0
            });
            client.Add(new Client()
            {
                ID_client = 4,
                Name_client = "Имя 4",
                Birthday = DateTime.Parse("1989-09-04"),
                E_mail = "4name@mail.ru",
                Balance = 400,
                ID_service = 3,
                Time_balance = DateTime.Parse("2022-01-06"),
                Client_login = "login4",
                Client_password = "pass4",
                Limits = 0
            });
            client.Add(new Client()
            {
                ID_client = 5,
                Name_client = "Имя 5",
                Birthday = DateTime.Parse("1989-09-05"),
                E_mail = "5name@mail.ru",
                Balance = 600,
                ID_service = 6,
                Time_balance = DateTime.Parse("2022-01-06"),
                Client_login = "login5",
                Client_password = "pass5",
                Limits = 50
            });
            client.Add(new Client()
            {
                ID_client = 6,
                Name_client = "Имя 6",
                Birthday = DateTime.Parse("1989-09-06"),
                E_mail = "6name@mail.ru",
                Balance = 300,
                ID_service = 5,
                Time_balance = DateTime.Parse("2022-01-06"),
                Client_login = "login6",
                Client_password = "pass6",
                Limits = 15
            });
            return client;
        }
    }
}

