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
    public partial class Register_window : Form
    {
        DB_TV_Internet_Billinig DataSet;
        public Register_window()
        {
            InitializeComponent();
            DataSet = new DB_TV_Internet_Billinig();
        }

        private void btn_register_new_client_Click(object sender, EventArgs e)
        {
            DialogResult results;
            Client clients = DataSet.Clients.Where(i => (i.Client_login == tb_login.Text) && (i.Client_password == tb_pass.Text)).FirstOrDefault();
            if (clients != null)
                results = MessageBox.Show("Client with such login name and password already exists! Change login and password!",
                    "Login and password match!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                DataSet.add_new_client(tb_name_client_new.Text, dtp_birthday_new.Value, tb_e_mail_new.Text, 
                    Convert.ToInt32(dgv_services_list_to_choose.CurrentRow.Cells[0].Value.ToString()), tb_login.Text, tb_pass.Text);
                results = MessageBox.Show("You have been added to our dataase as a client! Now you can sign in with your login and password to manage your account.",
                    "Added!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (results == DialogResult.OK)
                {
                    SIGN_IN_WINDOW sign = new SIGN_IN_WINDOW();
                    sign.Show();
                    this.Close();
                }
            }
        }

        private void Register_window_Load(object sender, EventArgs e)
        {
            dgv_services_list_to_choose.Rows.Clear();
            dgv_services_list_to_choose.ColumnCount = 6;
            dgv_services_list_to_choose.Columns[0].Name = "Идентификатор услуги";
            dgv_services_list_to_choose.Columns[1].Name = "Название услуги";
            dgv_services_list_to_choose.Columns[2].Name = "Описание услуги";
            dgv_services_list_to_choose.Columns[3].Name = "Цена услуги (в рублях)";
            dgv_services_list_to_choose.Columns[4].Name = "Период взимания оплаты (в днях)";
            dgv_services_list_to_choose.Columns[5].Name = "Цена подключения услуги (в рублях)";
            foreach (Service t in DataSet.GetServices())
            {
                try
                {
                    string[] row = new string[] { t.ID_service.ToString(), t.Name_service.ToString(),
                                                  t.Description_service.ToString(), t.Price_service.ToString(),
                                                  t.Period_payment.ToString(), t.Price_connection.ToString()};
                    dgv_services_list_to_choose.Rows.Add(row);
                }
                catch
                {
                }
            }
        }

        private void dgv_services_list_to_choose_Click(object sender, EventArgs e)
        {
           tb_selected_service.Text = dgv_services_list_to_choose.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
