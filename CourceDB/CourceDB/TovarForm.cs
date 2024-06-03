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
    public partial class TovarForm : Form
    {
        private Client client;

        public TovarForm(Client _client)
        {
            InitializeComponent();
            this.Activated += new EventHandler(TovarForm_Activated);
            Display();
            client=_client;
            ColDel.Visible = client == null;
            Label1.Visible = client == null;
            label2.Visible = client == null;
            label3.Visible = client == null;
            buttonAddTovar.Visible = client == null;
            buttonSale.Visible = client == null;
            buttonAddFabric.Visible = client == null;
            buttonAddColor.Visible = client == null;
            buttonAddMaterial.Visible = client == null;
            buttonAddName.Visible = client == null;
            buttonAddStaff.Visible = client == null;
            buttonAddBrand.Visible = client == null;
            if (client != null)
            {
                ColEdit.Text = "Добавить в корзину";
                ColEdit.Width = 125;
                dataGridView1.Width = dataGridView1.Width - 75;
            }
            else
            {
                label4.Visible = false;
                pictureBoxCart.Visible = false;
            }
        }

        public void Display()
        {
            DB.DisplayTovars(dataGridView1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            SaleForm saleForm= new SaleForm();
            saleForm.ShowDialog();
            Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Hide();
            CartForm cartForm = new CartForm(client);
            cartForm.ShowDialog();
            Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            AddTovar addTovar = new AddTovar(null, this);
            addTovar.ShowDialog();
            Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //DB.DisplaySaleByTovar(dataGridView2, Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[2].Value));

            // Код добавления в корзину и тд.
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                if (senderGrid.Columns[e.ColumnIndex].Name == "ColDel")
                {
                    // Получаем значения ячеек ColId, Column2 и Column4 из выбранной строки
                    var cellValueId = dataGridView1.Rows[e.RowIndex].Cells["ColId"].Value;
                    var cellValueName = dataGridView1.Rows[e.RowIndex].Cells["Column2"].Value;
                    var cellValueAdditional = dataGridView1.Rows[e.RowIndex].Cells["Column4"].Value;

                    if (cellValueId != null && cellValueName != null && cellValueAdditional != null)
                    {
                        int tovarId = Convert.ToInt32(cellValueId);
                        string tovarName = cellValueName.ToString();
                        string additionalInfo = cellValueAdditional.ToString();

                        // Запрос пользователю на подтверждение удаления
                        DialogResult result = MessageBox.Show(
                            $"Вы действительно хотите удалить товар '{tovarName} {additionalInfo}'?",
                            "Подтверждение удаления",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning);

                        if (result == DialogResult.Yes)
                        {
                            DB.DeleteTovar(tovarId);
                            // Обновление DataGridView после удаления (если требуется)
                            DB.DisplayTovars(dataGridView1);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Не удалось получить значение ColId, Column2 или Column4.");
                    }
                }

                else if (senderGrid.Columns[e.ColumnIndex].Name == "ColEdit" && ((System.Windows.Forms.DataGridViewButtonColumn)senderGrid.Columns[e.ColumnIndex]).Text == "Изменить")
                {
                    
                }

                else if (senderGrid.Columns[e.ColumnIndex].Name == "ColEdit" && ((System.Windows.Forms.DataGridViewButtonColumn)senderGrid.Columns[e.ColumnIndex]).Text == "Добавить в корзину")
                {
                    // Получаем значения ячеек для создания объекта Cart
                    var cellValueId = dataGridView1.Rows[e.RowIndex].Cells["ColId"].Value;
                    var clientLogin = client.Login; // Замените на фактический логин клиента

                    if (cellValueId != null)
                    {
                        int tovarId = Convert.ToInt32(cellValueId);
                        DB.AddCart(tovarId, clientLogin);
                    }
                    else
                    {
                        MessageBox.Show("Не удалось получить значение ColId для добавления в корзину.");
                    }
                }
            }
        }

        private void pictureBoxCart_Click(object sender, EventArgs e)
        {
            Hide();
            CartForm cartForm = new CartForm(client);
            cartForm.ShowDialog();
            Show();
        }

        private void buttonSale_Click(object sender, EventArgs e)
        {
            Hide();
            SaleForm saleForm = new SaleForm();
            saleForm.ShowDialog();
            Show();
        }

        private void buttonAddTovar_Click(object sender, EventArgs e)
        {
            Hide();
            AddTovar addTovar = new AddTovar(null, this);
            addTovar.ShowDialog();
            Show();
        }

        private void TovarForm_Load(object sender, EventArgs e)
        {
            DB.DisplayTovars(dataGridView1);
        }

        private void buttonAddFabric_Click(object sender, EventArgs e)
        {
            using (AddFabricatorForm form = new AddFabricatorForm())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    string fabricatorName = form.FabricatorName;
                    try
                    {
                        DB.AddFabricator(fabricatorName);
                        MessageBox.Show("Производитель успешно добавлен.", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка при добавлении производителя:\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void TovarForm_Activated(object sender, EventArgs e)
        {
            // Вызов метода для отображения товаров
            DB.DisplayTovars(dataGridView1);
        }

        private void buttonAddBrand_Click(object sender, EventArgs e)
        {
            using (AddBrandForm addBrandForm = new AddBrandForm())
            {
                if (addBrandForm.ShowDialog() == DialogResult.OK)
                {
                    string brandName = addBrandForm.BrandName;
                    string brandAddress = addBrandForm.BrandAddress;
                    try
                    {
                        DB.AddBrand(brandName, brandAddress);
                        MessageBox.Show("Бренд успешно добавлен.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка при добавлении бренда:\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void buttonAddMaterial_Click(object sender, EventArgs e)
        {
            using (AddMaterialForm addMaterialForm = new AddMaterialForm())
            {
                if (addMaterialForm.ShowDialog() == DialogResult.OK)
                {
                    string materialName = addMaterialForm.MaterialName;
                    string materialDescription = addMaterialForm.MaterialDescription;
                    DB.AddMaterial(materialName, materialDescription);
                }
            }
        }

        private void buttonAddStaff_Click(object sender, EventArgs e)
        {
            using (AddStaffForm addStaffForm = new AddStaffForm())
            {
                if (addStaffForm.ShowDialog() == DialogResult.OK)
                {
                    string staffSurname = addStaffForm.StaffSurname;
                    string staffName = addStaffForm.StaffName;
                    long staffPhone = addStaffForm.StaffPhone;
                    string staffPosition = addStaffForm.StaffPosition;
                    DB.AddStaff(staffSurname, staffName, staffPhone, staffPosition);
                }
            }
        }

        private void buttonAddColor_Click(object sender, EventArgs e)
        {
            using (AddColorForm addColorForm = new AddColorForm())
            {
                if (addColorForm.ShowDialog() == DialogResult.OK)
                {
                    string colorName = addColorForm.ColorName;
                    string hexKod = addColorForm.HexKod;

                    // Сохранение цвета в базу данных
                    DB.AddColor(colorName, hexKod);
                }
            }
        }

        private void buttonAddName_Click(object sender, EventArgs e)
        {
            using (AddNameForm addNameForm = new AddNameForm())
            {
                if (addNameForm.ShowDialog() == DialogResult.OK)
                {
                    string name = addNameForm.NameValue;

                    // Сохранение имени в базу данных
                    DB.AddName(name);
                }
            }
        }
    }
}
