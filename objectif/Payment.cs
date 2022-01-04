using System;
using System.ComponentModel.DataAnnotations;

namespace Paymentss
{
    public class Payment
    {
        public Payment() { }
        public Payment(int ID_PAYMENT, int ID_Client, int ID_PAY_method, decimal PRICE , bool ACCEPTED, DateTime DATETIME_PAYMENT)
        {
           ID_payment  = ID_PAYMENT;
           ID_client   =ID_Client;
           ID_Payment_method  = ID_PAY_method; 
           Price_to_pay  = PRICE;
          Accepted   = ACCEPTED;
           Date_Time_payment  = DATETIME_PAYMENT;
        }
        [Key]
        public int ID_payment { get; set; }
        public int  ID_client{ get; set; }
        public int  ID_Payment_method{ get; set; }
        public decimal Price_to_pay{ get; set; }  
        public bool  Accepted{ get; set; }
        public DateTime  Date_Time_payment{ get; set; }
    }

    public class Methods_pay
    {
        protected Methods_pay() { }
        public Methods_pay(int ID_METHOD, string NAME_METHOD)
        {
            ID_method = ID_METHOD;
            Name_method = NAME_METHOD;
        }
        [Key]
        public int ID_method { get; set; }
        public string Name_method{ get; set; }
    }
}
