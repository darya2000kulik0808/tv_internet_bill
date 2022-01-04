using System;
using System.ComponentModel.DataAnnotations;

namespace Services
{
    public class Service
    {
       protected Service() { }
   
        public Service(int ID_SERVICE, string Name_Service, string Description_Service , decimal Price_Service, int Period_Payment, decimal Price_Connection)
        {
            ID_service = ID_SERVICE;
            Name_service  = Name_Service;
            Description_service = Description_Service;           
            Period_payment = Period_Payment;
            Price_service = Price_Service;
           Price_connection  = Price_Connection ;
        }
        [Key]
        public int ID_service { get; set; }
        public string Name_service { get; set; }
        public string Description_service { get; set; }
        public decimal Price_service { get; set; }
        public int Period_payment { get; set; }
        public decimal Price_connection { get; set; }
    }
}
