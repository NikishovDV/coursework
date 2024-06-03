using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourceDB
{
    public partial class CartForm : Form
    {
        Client client;
        public CartForm(Client _client)
        {
            InitializeComponent();
            client = _client;
            DB.DisplayCart(dataGridView1, client);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Tovar> tovars = new List<Tovar>();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                try
                {
                    if (Convert.ToInt32(row.Cells[0].Value) < 1)
                    {
                        throw new Exception();
                    }
                } 
                catch (Exception ex)
                {
                    row.Cells[0].Value = 1;
                }
                tovars.Add(new Tovar(Convert.ToInt32(row.Cells[1].Value), null, Convert.ToInt32(row.Cells[4].Value), null, -1, null, null, -1, null, Convert.ToInt32(row.Cells[5].Value), Convert.ToInt32(row.Cells[0].Value)));
            }
            CreateSale createSale = new CreateSale(tovars, client);
            createSale.ShowDialog();
            Close();
        }

        private void CartForm_Shown(object sender, EventArgs e)
        {
            Dictionary<int, int> ids = new Dictionary<int, int>();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (ids.ContainsKey(Convert.ToInt32(row.Cells[1].Value)))
                {
                    int a = Convert.ToInt32(dataGridView1.Rows[ids[Convert.ToInt32(row.Cells[1].Value)]].Cells[0].Value);
                    dataGridView1.Rows[ids[Convert.ToInt32(row.Cells[1].Value)]].Cells[0].Value = a + 1;
                }
                else
                {
                    ids.Add(Convert.ToInt32(row.Cells[1].Value), row.Index);
                }
                row.Cells[0].Value = 1;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CartForm_Load(object sender, EventArgs e)
        {

        }
    }
}
