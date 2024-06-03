using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CourceDB
{
    public partial class AddTovar : Form
    {
        Tovar tovar;
        TovarForm tovarForm;
        Dictionary<string, Name> names;
        Dictionary<string, Brand> brands;
        Dictionary<string, Material> materials;
        Dictionary<string, Color> colors;
        Dictionary<string, Fabricator> fabricators;
        public AddTovar(Tovar _tovar, TovarForm _tovarForm)
        {
            InitializeComponent();
            names = DB.SelectAllNames();
            brands = DB.SelectAllBrand();
            materials = DB.SelectAllMaterial();
            colors = DB.SelectAllColor();
            fabricators = DB.SelectAllFabricator();
            tovar = _tovar;
            tovarForm = _tovarForm;
        }

        private void AddTovar_Load(object sender, EventArgs e)
        {
            foreach (Name name in names.Values)
            {
                comboBox1.Items.Add(name.Naming);
            }
            foreach (Brand brand in brands.Values)
            {
                comboBox2.Items.Add(brand.Brandname);
            }
            foreach (Material material in materials.Values)
            {
                comboBox3.Items.Add(material.Materialname);
            }
            foreach (Color color in colors.Values)
            {
                comboBox4.Items.Add(color.Colorname);
            }
            foreach (Fabricator fabricator in fabricators.Values)
            {
                comboBox5.Items.Add(fabricator.Fabricatorname);
            }

            if (tovar != null)
            {
                comboBox1.Text = tovar.Name.Naming;
                comboBox2.Text = tovar.Brand.Brandname;
                comboBox3.Text = tovar.Material.Materialname;
                comboBox4.Text = tovar.Color.Colorname;
                comboBox5.Text = tovar.Fabricator.Fabricatorname;
                textBox1.Text = tovar.Size.ToString();
                textBox2.Text = tovar.Sole_height.ToString();
                textBox3.Text = tovar.Guarantee.ToString();
                textBox4.Text = tovar.Price.ToString();
                textBox5.Text = tovar.Amount.ToString();
            }
        }
        private void Num_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Delete) || e.KeyChar == '.')
            {
                e.Handled = true;
                return;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "" || comboBox2.Text == "" || comboBox3.Text == "" || comboBox4.Text == "" || comboBox5.Text == "" || textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "") 
            {
                MessageBox.Show("Все поля должны быть заполнены", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Convert.ToInt32(textBox1.Text) < 34 || Convert.ToInt32(textBox1.Text) > 50)
            {
                MessageBox.Show("Размер не может быть меньше 34 и больше 50", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Convert.ToInt32(textBox2.Text) > 15 )
            {
                MessageBox.Show("Высота подошвы не может быть больше 15 см", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Convert.ToInt32(textBox3.Text) > 7)
            {
                MessageBox.Show("Гарантия не может быть больше 7 лет", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Convert.ToInt32(textBox4.Text) == 0 )
            {
                MessageBox.Show("Цена не может быть равной нулю", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Convert.ToInt32(textBox5.Text) == 0)
            {
                MessageBox.Show("Измените значение количества в магазине", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Tovar _tovar = new Tovar(-1, names[comboBox1.Text], Convert.ToInt32(textBox1.Text), brands[comboBox2.Text], (float) Convert.ToDouble(textBox2.Text), materials[comboBox3.Text], colors[comboBox4.Text], Convert.ToInt32(textBox3.Text), fabricators[comboBox5.Text], Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox5.Text));


            if (tovar == null)
            {
                DB.AddTovar(_tovar);
            }
            else
            {
                tovar.Name = _tovar.Name;
                tovar.Size = _tovar.Size;
                tovar.Brand = _tovar.Brand;
                tovar.Sole_height = _tovar.Sole_height;
                tovar.Material = _tovar.Material;
                tovar.Color = _tovar.Color;
                tovar.Guarantee = _tovar.Guarantee;
                tovar.Fabricator = _tovar.Fabricator;
                tovar.Price = _tovar.Price;
                tovar.Amount = _tovar.Amount;
                DB.UpdateTovar(tovar);
            }
            tovarForm.Display();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
