using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DB_TV_Internet_Billing;
using Paymentss;

namespace TV_INTERNET_FORMS
{
    public partial class my_payments_window : Form
    {
        DB_TV_Internet_Billinig Data;
        int client_ID;
        public my_payments_window(int client_Id)
        {
            InitializeComponent();
            Data = new DB_TV_Internet_Billinig();
            client_ID = client_Id;
        }

        private void my_payments_window_Load(object sender, EventArgs e)
        {
            string accept;
            datagv_my_payments.Rows.Clear();
            datagv_my_payments.ColumnCount = 6;
            datagv_my_payments.Columns[0].Name = "Идентификатор оплаты";
            datagv_my_payments.Columns[1].Name = "Идентификатор клиента";
            datagv_my_payments.Columns[2].Name = "Способ оплаты";
            datagv_my_payments.Columns[3].Name = "Сумма платежа";
            datagv_my_payments.Columns[4].Name = "Одобрен";
            datagv_my_payments.Columns[5].Name = "Время совершения платежа";

            var result = from pay in Data.Payments 
                         join method in Data.Methods_Pay on pay.ID_Payment_method equals method.ID_method 
                         select new {ID = pay.ID_payment, ID_C = pay.ID_client, 
                                       METHOD = method.Name_method, PRICE = pay.Price_to_pay, 
                                       ACCEPT = pay.Accepted, DATE = pay.Date_Time_payment};

            foreach (var t in result)
            {
                if (t.ID_C == client_ID)
                {
                    try
                    {
                        if (t.ACCEPT == true) accept = "Одобрен";
                        else accept = "Отклонён";
                        string[] row = new string[] { t.ID.ToString(), t.ID_C.ToString(),
                                                  t.METHOD.ToString(), t.PRICE.ToString(),
                                                  accept, t.DATE.ToString()};
                        datagv_my_payments.Rows.Add(row);
                    }
                    catch
                    {
                    }
                }
            }
            datagv_my_payments.Columns[0].Visible = false;
            datagv_my_payments.Columns[1].Visible = false;

        }
    }
}
