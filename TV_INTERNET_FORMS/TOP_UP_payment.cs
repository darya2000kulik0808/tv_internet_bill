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
using Paymentss;
using tv_internet_billing;
using Mail;

namespace TV_INTERNET_FORMS
{
    public partial class TOP_UP_payment : Form
    {
        DB_TV_Internet_Billinig dataSet;
        int Client_id;
        SendingMail email;
        public TOP_UP_payment(int client_id)
        {
            InitializeComponent();
            dataSet = new DB_TV_Internet_Billinig();
            Client_id = client_id;
            email = new SendingMail();
        }

        private void btn_pay_Click(object sender, EventArgs e)
        {
            Decimal price = 0;
            if (comboBox_method_pay.SelectedIndex == 0 || comboBox_method_pay.SelectedIndex == 5 || comboBox_method_pay.SelectedIndex == 1)
            {
                price = Decimal.Parse(num_amountC.Value.ToString());
            }
            else
            {
                if (comboBox_method_pay.SelectedIndex == 2 || comboBox_method_pay.SelectedIndex == 3 || comboBox_method_pay.SelectedIndex == 4)
                {
                    price = Decimal.Parse(num_amountT.Value.ToString());
                }
            }

            if(CB_mail.Checked)
            {
                List<Methods_pay> method = dataSet.Methods_Pay.ToList();

                foreach (var m in method)
                    if((comboBox_method_pay.SelectedIndex + 1) == m.ID_method)
                    email.SendEMail(tb_mail_send.Text, Decimal.ToInt32(price), m.Name_method);

            }

            dataSet.add_new_payment_record(Client_id, comboBox_method_pay.SelectedIndex +1, price, true, DateTime.Now);
            DialogResult results = MessageBox.Show("The balance has been successfully replenished!", "Top Up!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (results == DialogResult.OK)
            {
                this.Close();
            }

        }

        private void TOP_UP_payment_Load(object sender, EventArgs e)
        {
            tb_mail_send.Visible = false;
            label.Visible = false;
            comboBox_method_pay.DataSource = dataSet.Methods_Pay.ToList();
            comboBox_method_pay.ValueMember = "ID_method";
            comboBox_method_pay.DisplayMember = "Name_method";
        }

        private void comboBox_method_pay_SelectedIndexChanged(object sender, EventArgs e)
        {
           if (comboBox_method_pay.SelectedIndex == 0 || comboBox_method_pay.SelectedIndex == 5 || comboBox_method_pay.SelectedIndex == 1)
            {
                panel_card.Enabled = true;
                panel_telephone.Enabled = false;
            }
            else
            {
                if (comboBox_method_pay.SelectedIndex == 2|| comboBox_method_pay.SelectedIndex == 3 || comboBox_method_pay.SelectedIndex == 4)
                {
                    panel_card.Enabled = false;
                    panel_telephone.Enabled = true;
                }
            }
        }

        private void CB_mail_CheckedChanged(object sender, EventArgs e)
        {
            if (CB_mail.Checked)
            {
                tb_mail_send.Visible = true;
                label.Visible = true;
            }
            else
            {
                tb_mail_send.Visible = false;
                label.Visible = false;
            }
        }
    }
}
