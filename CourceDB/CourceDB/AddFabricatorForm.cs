using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourceDB
{
    public partial class AddFabricatorForm : Form
    {
        public string FabricatorName { get; private set; }

        public AddFabricatorForm()
        {
            InitializeComponent();
            LoadFabricators();
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddFabricatorForm));
            this.textBoxFabricatorName = new System.Windows.Forms.TextBox();
            this.labelFabricatorName = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.dataGridViewFabricators = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFabricators)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxFabricatorName
            // 
            this.textBoxFabricatorName.Location = new System.Drawing.Point(16, 37);
            this.textBoxFabricatorName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxFabricatorName.Name = "textBoxFabricatorName";
            this.textBoxFabricatorName.Size = new System.Drawing.Size(383, 22);
            this.textBoxFabricatorName.TabIndex = 0;
            // 
            // labelFabricatorName
            // 
            this.labelFabricatorName.AutoSize = true;
            this.labelFabricatorName.Location = new System.Drawing.Point(16, 11);
            this.labelFabricatorName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFabricatorName.Name = "labelFabricatorName";
            this.labelFabricatorName.Size = new System.Drawing.Size(141, 16);
            this.labelFabricatorName.TabIndex = 1;
            this.labelFabricatorName.Text = "Имя производителя:";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdd.Location = new System.Drawing.Point(299, 69);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(100, 28);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCancel.Location = new System.Drawing.Point(191, 69);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(100, 28);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // dataGridViewFabricators
            // 
            this.dataGridViewFabricators.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFabricators.Location = new System.Drawing.Point(16, 118);
            this.dataGridViewFabricators.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewFabricators.Name = "dataGridViewFabricators";
            this.dataGridViewFabricators.RowHeadersWidth = 51;
            this.dataGridViewFabricators.Size = new System.Drawing.Size(820, 286);
            this.dataGridViewFabricators.TabIndex = 4;
            // 
            // AddFabricatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 417);
            this.Controls.Add(this.dataGridViewFabricators);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelFabricatorName);
            this.Controls.Add(this.textBoxFabricatorName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "AddFabricatorForm";
            this.Text = "Добавить производителя";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFabricators)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            this.FabricatorName = textBoxFabricatorName.Text;
            if (string.IsNullOrEmpty(this.FabricatorName))
            {
                MessageBox.Show("Имя производителя не может быть пустым.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                DB.AddFabricator(this.FabricatorName);
                MessageBox.Show("Производитель успешно добавлен.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadFabricators();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при добавлении производителя:\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void LoadFabricators()
        {
            // Загрузка данных производителей из базы данных и отображение в dataGridView
            DataTable dt = DB.GetFabricators();
            dataGridViewFabricators.DataSource = dt;
        }

        private TextBox textBoxFabricatorName;
        private Label labelFabricatorName;
        private Button buttonAdd;
        private Button buttonCancel;
        private DataGridView dataGridViewFabricators;
    }
}
