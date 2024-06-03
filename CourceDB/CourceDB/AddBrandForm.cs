using System;
using System.Windows.Forms;

namespace CourceDB
{
    public partial class AddBrandForm : Form
    {
        public string BrandName { get; private set; }
        public string BrandAddress { get; private set; }

        public AddBrandForm()
        {
            InitializeComponent();
            LoadBrands();
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBrandForm));
            this.textBoxBrandName = new System.Windows.Forms.TextBox();
            this.labelBrandName = new System.Windows.Forms.Label();
            this.textBoxBrandAddress = new System.Windows.Forms.TextBox();
            this.labelBrandAddress = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.dataGridViewBrands = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBrands)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxBrandName
            // 
            this.textBoxBrandName.Location = new System.Drawing.Point(16, 37);
            this.textBoxBrandName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxBrandName.Name = "textBoxBrandName";
            this.textBoxBrandName.Size = new System.Drawing.Size(428, 22);
            this.textBoxBrandName.TabIndex = 0;
            // 
            // labelBrandName
            // 
            this.labelBrandName.AutoSize = true;
            this.labelBrandName.Location = new System.Drawing.Point(16, 11);
            this.labelBrandName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBrandName.Name = "labelBrandName";
            this.labelBrandName.Size = new System.Drawing.Size(87, 16);
            this.labelBrandName.TabIndex = 1;
            this.labelBrandName.Text = "Имя бренда:";
            // 
            // textBoxBrandAddress
            // 
            this.textBoxBrandAddress.Location = new System.Drawing.Point(16, 92);
            this.textBoxBrandAddress.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxBrandAddress.Name = "textBoxBrandAddress";
            this.textBoxBrandAddress.Size = new System.Drawing.Size(428, 22);
            this.textBoxBrandAddress.TabIndex = 2;
            // 
            // labelBrandAddress
            // 
            this.labelBrandAddress.AutoSize = true;
            this.labelBrandAddress.Location = new System.Drawing.Point(16, 66);
            this.labelBrandAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBrandAddress.Name = "labelBrandAddress";
            this.labelBrandAddress.Size = new System.Drawing.Size(50, 16);
            this.labelBrandAddress.TabIndex = 3;
            this.labelBrandAddress.Text = "Адрес:";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdd.Location = new System.Drawing.Point(344, 136);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(100, 28);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCancel.Location = new System.Drawing.Point(236, 136);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(100, 28);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // dataGridViewBrands
            // 
            this.dataGridViewBrands.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBrands.Location = new System.Drawing.Point(16, 185);
            this.dataGridViewBrands.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewBrands.Name = "dataGridViewBrands";
            this.dataGridViewBrands.RowHeadersWidth = 51;
            this.dataGridViewBrands.Size = new System.Drawing.Size(837, 310);
            this.dataGridViewBrands.TabIndex = 6;
            // 
            // AddBrandForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 508);
            this.Controls.Add(this.dataGridViewBrands);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelBrandAddress);
            this.Controls.Add(this.textBoxBrandAddress);
            this.Controls.Add(this.labelBrandName);
            this.Controls.Add(this.textBoxBrandName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "AddBrandForm";
            this.Text = "Добавить бренд";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBrands)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            this.BrandName = textBoxBrandName.Text;
            this.BrandAddress = textBoxBrandAddress.Text;

            if (string.IsNullOrEmpty(this.BrandName) || string.IsNullOrEmpty(this.BrandAddress))
            {
                MessageBox.Show("Имя бренда и адрес не могут быть пустыми.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void AddBrandForm_Activated(object sender, EventArgs e)
        {
            LoadBrands();
        }

        private void LoadBrands()
        {
            dataGridViewBrands.DataSource = DB.GetBrands();
        }

        private TextBox textBoxBrandName;
        private Label labelBrandName;
        private TextBox textBoxBrandAddress;
        private Label labelBrandAddress;
        private Button buttonAdd;
        private Button buttonCancel;
        private DataGridView dataGridViewBrands;
    }
}
