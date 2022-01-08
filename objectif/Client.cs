using System;
using System.ComponentModel.DataAnnotations;

namespace Clients
{
    public class Client
    {
        public Client() { }
        public Client(int ID_CLIENT, string Name_Client, DateTime Client_Birthday, string E_Mail, 
                      decimal Client_Balance, int ID_SERVICE, DateTime Time_Balance, string Client_Login, 
                      string Client_Pass, int limits)
        {
            ID_client = ID_CLIENT;
            Name_client = Name_Client;
            Birthday = Client_Birthday;
            E_mail = E_Mail;
            Balance = Client_Balance;
            ID_service = ID_SERVICE;
            Time_balance = Time_Balance;
            Client_login = Client_Login;
            Client_password = Client_Pass;
            Limits = limits;
        }

        [Key]
        public int ID_client { get; set; }
        public string Name_client { get; set; }
        public DateTime Birthday { get; set; }
        public string E_mail { get; set; }
        public decimal Balance { get; set; }
        public int ID_service { get; set; }
        public DateTime Time_balance { get; set; }
        public string Client_login { get; set; }
        public string Client_password { get; set; }
        public int Limits { get; set; }
    }
}
