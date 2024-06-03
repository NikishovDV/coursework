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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

            this.textBox2.AutoSize = false;
            this.textBox2.Size = new Size(this.textBox2.Size.Width, 35);
        }

        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text == "admin")
            {
                textBox2.Visible = true;
                pictureBox2.Visible = true;
            }
            else
            {
                textBox2.Visible = false;
                pictureBox2.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text == "admin")
            {
                if (textBox2.Text == "123")
                {
                    Hide();
                    TovarForm tovarForm = new TovarForm(null);
                    tovarForm.ShowDialog();
                    Show();
                }
                else
                {
                    MessageBox.Show("Неверный пароль");
                }
            }
            else
            {
                Client client = DB.SelectClientByLogin(maskedTextBox1.Text);
                if (client == null)
                {
                    DB.AddClient(new Client(0, maskedTextBox1.Text));
                    client = DB.SelectClientByLogin(maskedTextBox1.Text);
                }
                Hide();
                TovarForm tovarForm = new TovarForm(client);
                tovarForm.ShowDialog();
                Show();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
