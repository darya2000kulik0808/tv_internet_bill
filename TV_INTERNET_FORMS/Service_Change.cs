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
using ServiceListSource;

namespace TV_INTERNET_FORMS
{
    public partial class Service_Change : Form
    {
        IServiceSource Data;
        DB_TV_Internet_Billinig DataSet;
        int id;
        public Service_Change(IServiceSource data, int client_id)
        {
            InitializeComponent();
            Data = data;
            id = client_id;
            DataSet = new DB_TV_Internet_Billinig();
        }

        private void DGV_Change_service_DoubleClick(object sender, EventArgs e)
        { 
            
            DialogResult result = MessageBox.Show("You are going to change service you are currently using. Are you sure you want to change it?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                //if (Int32.Parse(DGV_Change_service.CurrentRow.Cells[0].Value.ToString(), out int id))
                DataSet.change_service_for_client(Convert.ToInt32(DGV_Change_service.CurrentRow.Cells[0].Value.ToString()), id);
                DialogResult results = MessageBox.Show("Your chages are saved!", "Changed!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        private void Service_Change_Load(object sender, EventArgs e)
        {
            DGV_Change_service.Rows.Clear();
            DGV_Change_service.ColumnCount = 6;
            DGV_Change_service.Columns[0].Name = "Идентификатор услуги";
            DGV_Change_service.Columns[1].Name = "Название услуги";
            DGV_Change_service.Columns[2].Name = "Описание услуги";
            DGV_Change_service.Columns[3].Name = "Цена услуги (в рублях)";
            DGV_Change_service.Columns[4].Name = "Период взимания оплаты (в днях)";
            DGV_Change_service.Columns[5].Name = "Цена подключения услуги (в рублях)";
            foreach (Service t in Data.GetServices())
            {
                try
                {
                    string[] row = new string[] { t.ID_service.ToString(), t.Name_service.ToString(),
                                                  t.Description_service.ToString(), t.Price_service.ToString(),
                                                  t.Period_payment.ToString(), t.Price_connection.ToString()};
                    DGV_Change_service.Rows.Add(row);
                }
                catch
                {
                }
            }
        }
    }
}
