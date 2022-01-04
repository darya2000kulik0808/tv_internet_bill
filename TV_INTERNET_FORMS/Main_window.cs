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
using tv_internet_billing;
using Clients;
using Services;



namespace TV_INTERNET_FORMS
{
    public partial class Main_window : Form
    {
        DB_TV_Internet_Billinig DataSet;

        public Main_window()
        {
            InitializeComponent();
            DataSet = new DB_TV_Internet_Billinig();
        }
        private void btn_Service_show_Click(object sender, EventArgs e)
        {
            DGV_lists.Rows.Clear();
            DGV_lists.ColumnCount = 6;
            DGV_lists.Columns[0].Name = "Идентификатор услуги";
            DGV_lists.Columns[1].Name = "Название услуги";
            DGV_lists.Columns[2].Name = "Описание услуги";
            DGV_lists.Columns[3].Name = "Цена услуги (в рублях)";
            DGV_lists.Columns[4].Name = "Период взимания оплаты (в днях)";
            DGV_lists.Columns[5].Name = "Цена подключения услуги (в рублях)";
            foreach (Service t in DataSet.GetServices())
            {
                try
                {
                    string[] row = new string[] { t.ID_service.ToString(), t.Name_service.ToString(),
                                                  t.Description_service.ToString(), t.Price_service.ToString(),
                                                  t.Period_payment.ToString(), t.Price_connection.ToString()};
                    DGV_lists.Rows.Add(row);
                }
                catch
                {
                }
            }
        }

        private void btn_Client_show_Click(object sender, EventArgs e)
        {
            DGV_lists.Rows.Clear();
            DGV_lists.ColumnCount = 6;
            DGV_lists.Columns[0].Name = "Идентификатор клиента";
            DGV_lists.Columns[1].Name = "Имя клиента";
            DGV_lists.Columns[2].Name = "День рождения";
            DGV_lists.Columns[3].Name = "Адрес электронной почты";
            DGV_lists.Columns[4].Name = "Баланс (в рублях)";
            DGV_lists.Columns[5].Name = "Идентификатор услуги";
            foreach (Client t in DataSet.GetClients())
            {
                try
                {
                    string[] row = new string[] { t.ID_client.ToString(), t.Name_client.ToString(),
                                                  t.Birthday.ToString(), t.E_mail.ToString(),
                                                  t.Balance.ToString(), t.ID_service.ToString()};
                    DGV_lists.Rows.Add(row);
                }
                catch
                {
                }
            }
        }
    }

}