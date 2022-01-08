using System;
using System.Collections.Generic;
using System.IO;
using ServiceListSource;
using Services;

namespace ServiceFromFile
{
    public class FromFile : IServiceSource
    {
        public List<Service> GetServices()
        {
            List<Service> list = new List<Service>();

            StreamReader rdr = new StreamReader("ServiceList.csv");
            String all = rdr.ReadToEnd();
            String[] arr = all.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
           
            foreach (string s in arr)
            {
                String[] arr1 = s.Split(new string[] { ";" }, StringSplitOptions.RemoveEmptyEntries);
                int ID_SERVICE = Int32.Parse(arr1[0]);
                string Name_Service = arr1[1];
                string Description_Service = arr1[2];
                decimal Price_Service = Decimal.Parse(arr1[3]);
                int Period_Payment = Int32.Parse(arr1[4]); 
                decimal Price_Connection = Decimal.Parse(arr1[5]);
                decimal Price_for_limit = Decimal.Parse(arr1[6]);
                bool limit = Convert.ToBoolean(arr1[7]);
                list.Add(new Service(ID_SERVICE, Name_Service, Description_Service, Price_Service, Period_Payment, Price_Connection, Price_for_limit, limit));
            }
            return list;
        }
    }
}
