using System;
using System.ComponentModel.DataAnnotations;

namespace Services
{
    public class Service
    {
       public Service() { }
   
        public Service(int ID_SERVICE, string Name_Service, string Description_Service , 
                       decimal Price_Service, int Period_Payment, decimal Price_Connection,
                       decimal PRICE_for_limit, bool Limit )
        {
            ID_service = ID_SERVICE;
            Name_service  = Name_Service;
            Description_service = Description_Service;           
            Period_payment = Period_Payment;
            Price_service = Price_Service;
            Price_connection  = Price_Connection ;
            Price_for_limit = PRICE_for_limit;
            limit = Limit;
        }
        [Key]
        public int ID_service { get; set; }
        public string Name_service { get; set; }
        public string Description_service { get; set; }
        public decimal Price_service { get; set; }
        public int Period_payment { get; set; }
        public decimal Price_connection { get; set; }
        public decimal Price_for_limit { get; set; }
        public bool limit { get; set; }
    }
}
