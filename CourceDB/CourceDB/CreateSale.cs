using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CourceDB
{
    public partial class CreateSale : Form
    {
        List<Tovar> tovars;
        Client client;

        public CreateSale(List<Tovar> _tovars, Client _client)
        {
            InitializeComponent();
            tovars = _tovars;
            long sum = 0;
            foreach (Tovar tovar in tovars)
            {
                sum += tovar.Price * tovar.Amount;
            }
            textBox1.Text = sum.ToString();
            client = _client;

            // Заполнение comboBox1 сотрудниками из базы данных
            LoadStaffComboBox();
        }

        private void LoadStaffComboBox()
        {
            // Получаем список всех сотрудников
            List<Staff> staffs = DB.GetAllStaff();

            // Устанавливаем список сотрудников в качестве источника данных для comboBox1
            comboBox1.DataSource = staffs;
            comboBox1.DisplayMember = "FullName"; // Предполагается, что у класса Staff есть свойство FullName
            comboBox1.ValueMember = "Surname"; // Предполагается, что у класса Staff есть свойство Id
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Проверяем, равно ли значение textBox1 нулю
            if (textBox1.Text == "0")
            {
                MessageBox.Show("Невозможно оформить продажу, так как сумма равна нулю.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Получаем выбранный сотрудник из ComboBox
            Staff selectedStaff = comboBox1.SelectedItem as Staff;

            if (selectedStaff == null)
            {
                MessageBox.Show("Выберите сотрудника из списка.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Добавляем продажи для каждого товара
            foreach (Tovar tovar in tovars)
            {
                DB.AddSale(new Sale(-1, tovar, tovar.Price, tovar.Amount, selectedStaff, DateTime.Now));
            }

            // Удаляем товары из корзины клиента
            DB.DeleteCart(client.Login);

            MessageBox.Show("Продажи успешно оформлены", "", MessageBoxButtons.OK);
            Close();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
