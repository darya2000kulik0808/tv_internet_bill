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
using Clients;
using Services;
using tv_internet_billing;

namespace TV_INTERNET_FORMS
{
    public partial class Clients_Profile : Form
    {
        DB_TV_Internet_Billinig DataSet;
        int client_Id;
        //int service_Id;
        public Clients_Profile(int client_id)
        {
            InitializeComponent();
            DataSet = new DB_TV_Internet_Billinig();
            client_Id = client_id - 1;
        }

        private void Clients_Profile_Load(object sender, EventArgs e)
        {
            List<Service> service = DataSet.GetServices();
            List<Client> client = DataSet.GetClients();

            Client client1 = DataSet.Clients.Where(i => i.ID_client == client_Id + 1).FirstOrDefault();

            lb_name_client.Text = client1.Name_client;
            label_birthday_fill_in.Text = client1.Birthday.ToString("d");
            label_email_fill_in.Text = client1.E_mail;
            label_balane_fill_in.Text = client1.Balance.ToString();
            label_time_condition_current.Text = client1.Time_balance.ToString("d");

            IEnumerable<Service> service_Id = from serv in service where client1.ID_service == serv.ID_service select serv;

            foreach (Service member in service_Id)
            {
                int price_month = Decimal.ToInt32(member.Price_service) * 30;
                lb_name_service.Text = member.Name_service;
                richTB_description_text.Text = member.Description_service;
                lb_connetion_price.Text = member.Price_connection.ToString();
                lb_price_service.Text = member.Price_service.ToString();

                if (client1.Balance <= 0)
                {
                    label_days.Text = "Service has been disconnected. Top up your balance to connect service.";
                    label_days_left_fill_in.Visible = false;
                    label_days_d.Visible = false;
                }
                else
                {
                    label_days.Text = "Service will be disconnected in ";
                    label_days_left_fill_in.Visible = true;
                    label_days_d.Visible = true;
                    label_days_left_fill_in.Text = TV_Internet_Billing.Calculate_daysLeft(Decimal.ToInt32(client1.Balance), Decimal.ToInt32(member.Price_service)).ToString();

                }
                label_monthly.Text = price_month.ToString();
                if (client1.Balance < member.Price_service)
                {
                    label_not_enough.Visible = true;
                }
                else label_not_enough.Visible = false;
            }
        }

        private void btn_service_change_Click(object sender, EventArgs e)
        {
            Service_Change change = new Service_Change(client_Id);
            change.Show();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            Clients_Profile restart = new Clients_Profile(client_Id + 1);
            restart.Show();
            this.Close();
        }

        private void btn_top_up_Click(object sender, EventArgs e)
        {
            TOP_UP_payment top_up = new TOP_UP_payment(client_Id + 1);
            //this.Close();
            top_up.Show();
        }
    }
}
