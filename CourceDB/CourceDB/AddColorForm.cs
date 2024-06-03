using System;
using System.Data;
using System.Windows.Forms;

namespace CourceDB
{
    public partial class AddColorForm : Form
    {
        public string ColorName { get; private set; }
        public string HexKod { get; private set; }

        public AddColorForm()
        {
            InitializeComponent();
            LoadColors();
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddColorForm));
            this.textBoxColorName = new System.Windows.Forms.TextBox();
            this.labelColorName = new System.Windows.Forms.Label();
            this.textBoxHexKod = new System.Windows.Forms.TextBox();
            this.labelHexKod = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.dataGridViewColors = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewColors)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxColorName
            // 
            this.textBoxColorName.Location = new System.Drawing.Point(12, 30);
            this.textBoxColorName.Name = "textBoxColorName";
            this.textBoxColorName.Size = new System.Drawing.Size(393, 22);
            this.textBoxColorName.TabIndex = 0;
            // 
            // labelColorName
            // 
            this.labelColorName.AutoSize = true;
            this.labelColorName.Location = new System.Drawing.Point(12, 9);
            this.labelColorName.Name = "labelColorName";
            this.labelColorName.Size = new System.Drawing.Size(118, 16);
            this.labelColorName.TabIndex = 1;
            this.labelColorName.Text = "Название цвета:";
            // 
            // textBoxHexKod
            // 
            this.textBoxHexKod.Location = new System.Drawing.Point(12, 75);
            this.textBoxHexKod.Name = "textBoxHexKod";
            this.textBoxHexKod.Size = new System.Drawing.Size(393, 22);
            this.textBoxHexKod.TabIndex = 4;
            // 
            // labelHexKod
            // 
            this.labelHexKod.AutoSize = true;
            this.labelHexKod.Location = new System.Drawing.Point(12, 54);
            this.labelHexKod.Name = "labelHexKod";
            this.labelHexKod.Size = new System.Drawing.Size(60, 16);
            this.labelHexKod.TabIndex = 5;
            this.labelHexKod.Text = "Hex код:";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdd.Location = new System.Drawing.Point(330, 111);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 6;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCancel.Location = new System.Drawing.Point(249, 111);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // dataGridViewColors
            // 
            this.dataGridViewColors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewColors.Location = new System.Drawing.Point(12, 154);
            this.dataGridViewColors.Name = "dataGridViewColors";
            this.dataGridViewColors.RowHeadersWidth = 51;
            this.dataGridViewColors.Size = new System.Drawing.Size(831, 283);
            this.dataGridViewColors.TabIndex = 8;
            // 
            // AddColorForm
            // 
            this.ClientSize = new System.Drawing.Size(855, 449);
            this.Controls.Add(this.dataGridViewColors);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelHexKod);
            this.Controls.Add(this.textBoxHexKod);
            this.Controls.Add(this.labelColorName);
            this.Controls.Add(this.textBoxColorName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddColorForm";
            this.Text = "Добавить цвет";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewColors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            this.ColorName = textBoxColorName.Text;
            this.HexKod = textBoxHexKod.Text;

            if (string.IsNullOrEmpty(this.ColorName) || string.IsNullOrEmpty(this.HexKod))
            {
                MessageBox.Show("Название цвета и Hex код не могут быть пустыми.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DB.AddColor(this.ColorName, this.HexKod);
            LoadColors(); // Reload colors after adding a new one
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void LoadColors()
        {
            DataTable colors = DB.GetAllColors();
            dataGridViewColors.DataSource = colors;
        }

        private TextBox textBoxColorName;
        private Label labelColorName;
        private TextBox textBoxHexKod;
        private Label labelHexKod;
        private Button buttonAdd;
        private Button buttonCancel;
        private DataGridView dataGridViewColors;
    }
}
