using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using Microsoft.EntityFrameworkCore;
using Services;
using Clients;
using Paymentss;
using tv_internet_billing;
using ServiceListSource;
using DecreasingBalance;
using Clients_n_ServieListsForTest;

namespace DB_TV_Internet_Billing
{

    public class DB_TV_Internet_Billinig : DbContext, IServiceSource, IClient_List
    {
        public DbSet<Service> Services { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Methods_pay> Methods_Pay { get; set; }
        public DB_TV_Internet_Billinig()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Data Source=DESKTOP-K5CR1SR;Initial Catalog=DB_TV_Internet_Billing;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        #region Getting Data from DataBase
        public List<Service> GetServices()
        {
            return Services.ToList<Service>();
        }
        public List<Client> GetClients()
        {
            return Clients.ToList<Client>();
        }
        
        public List<Payment> GetPayments()
        {
            return Payments.ToList<Payment>();
        }
        public List<Methods_pay> GetMethodsPay()
        {
            return Methods_Pay.ToList<Methods_pay>();
        }
        #endregion

        public void change_service_for_client(int service_id, int client_id)
        {
            DB_TV_Internet_Billinig data = new DB_TV_Internet_Billinig();

            Client clients = data.Clients.Where(i => i.ID_client == client_id+1).FirstOrDefault();           
            clients.ID_service = service_id;
            
            data.SaveChanges();
        }

        public void increase_balance(int id_client, int  add_sum)
        {
            DB_TV_Internet_Billinig data = new DB_TV_Internet_Billinig();
           
            Client clients = data.Clients.Where(i => i.ID_client == id_client ).FirstOrDefault();
            int BALANCE = Decimal.ToInt32(clients.Balance);
                clients.Balance= TV_Internet_Billing.increase_Client_BALANCE(BALANCE, add_sum);

            data.SaveChanges();
        }

        public void decrease_balance( DateTime curr_date)
        {
            DB_TV_Internet_Billinig data = new DB_TV_Internet_Billinig();
            Decrease_Limited lim = new Decrease_Limited();
            Decrease_Unlimited unlim = new Decrease_Unlimited();

            List<Client> clients = data.GetClients();
            List<Service> services = data.GetServices();

            foreach (Client client in clients)
            {
                foreach (Service service in services)
                {
                    if (client.ID_service == service.ID_service && service.limit == false)
                    {
                        client.Balance = unlim.decrease_Client_BALANCE(client.ID_client);
                        client.Time_balance = curr_date;
                    }
                    else if(client.ID_service == service.ID_service && service.limit == true)
                    {
                        client.Balance = lim.decrease_Client_BALANCE(client.ID_client);
                        client.Time_balance = curr_date;
                    }
                }
            }

            data.Clients.UpdateRange(clients);
            data.SaveChanges();
  
        }

        public void add_new_payment_record(int ID_Client, int ID_Payment_Method, decimal Price_to_Pay, bool Accepted, DateTime Date_Time_payment)
        {
            DB_TV_Internet_Billinig data = new DB_TV_Internet_Billinig();
            increase_balance(ID_Client, Decimal.ToInt32(Price_to_Pay));

            Payment pay = new Payment { ID_client = ID_Client, ID_Payment_method = ID_Payment_Method, Price_to_pay = Price_to_Pay, Accepted =Accepted, Date_Time_payment =Date_Time_payment};
            data.Payments.Add(pay);
            data.SaveChanges();
        }

        public void add_new_client(string Name_Client, DateTime Client_Birthday, string E_Mail, int Service_id, string Client_Login, string Client_Pass)
        {
            DB_TV_Internet_Billinig data = new DB_TV_Internet_Billinig();

            Client client = new Client { 
                Name_client = Name_Client, Birthday = Client_Birthday, E_mail = E_Mail , ID_service = Service_id, 
                Time_balance = DateTime.Now, Client_login =Client_Login, Client_password = Client_Pass};
            data.Clients.Add(client);
            data.SaveChanges();
        }
    }


    public class Decrease_Unlimited : IDecreasingBalance
    {
        public int decrease_Client_BALANCE(int client_id)
        {
            DB_TV_Internet_Billinig db = new DB_TV_Internet_Billinig();

            Clients_n_Service_Lists cs_lists = new Clients_n_Service_Lists();

            List<Client> client = cs_lists.GetClients();
            List<Service> service = cs_lists.GetServices();

            DateTime current_date = DateTime.Now;
            DateTime date_base = DateTime.Now;
            int balance = 0;
            int day_pay = 0;

            foreach (Client mem in client)
            {
                foreach (Service s in service)
                {
                    if (mem.ID_client == client_id && mem.ID_service == s.ID_service)
                    {
                        date_base = mem.Time_balance;
                        balance = Decimal.ToInt32(mem.Balance);
                        day_pay = Decimal.ToInt32(s.Price_service);
                    }
                }
            }

            int compare_result = DateTime.Compare(current_date.Date, date_base.Date);
            if (compare_result > 0 && balance != 0)
            {
                balance -= day_pay;
                return balance;
            }
            else return balance;
        }

    }

    public class Decrease_Limited : IDecreasingBalance
    {
        public int decrease_Client_BALANCE(int client_id)
        {
            DB_TV_Internet_Billinig db = new DB_TV_Internet_Billinig();

            Clients_n_Service_Lists cs_lists = new Clients_n_Service_Lists();

            List<Client> client = cs_lists.GetClients();
            List<Service> service = cs_lists.GetServices();

            DateTime current_date = DateTime.Now;
            DateTime date_base = DateTime.Now;
            int balance = 0;
            int limits_client = 0;
            int price_limit = 0;

            foreach (Client mem in client)
            {
                foreach (Service s in service)
                {
                    if (mem.ID_client == client_id && mem.ID_service == s.ID_service)
                    {
                        date_base = mem.Time_balance;
                        balance = Decimal.ToInt32(mem.Balance);
                        limits_client = mem.Limits;
                        price_limit = Decimal.ToInt32(s.Price_for_limit);
                    }
                }
            }

            int compare_result = DateTime.Compare(current_date.Date, date_base.Date);
            if (compare_result > 0 && balance != 0)
            {
                balance = balance - (limits_client*price_limit);
                return balance;
            }
            else return balance;
        }
    }
}
