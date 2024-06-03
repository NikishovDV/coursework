using System;
using System.Windows.Forms;

namespace CourceDB
{
    public partial class AddMaterialForm : Form
    {
        public string MaterialName { get; private set; }
        public string MaterialDescription { get; private set; }

        public AddMaterialForm()
        {
            InitializeComponent();
            dataGridViewMaterials.DataSource = DB.GetMaterials();
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddMaterialForm));
            this.textBoxMaterialName = new System.Windows.Forms.TextBox();
            this.labelMaterialName = new System.Windows.Forms.Label();
            this.textBoxMaterialDescription = new System.Windows.Forms.TextBox();
            this.labelMaterialDescription = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.dataGridViewMaterials = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMaterials)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxMaterialName
            // 
            this.textBoxMaterialName.Location = new System.Drawing.Point(16, 37);
            this.textBoxMaterialName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMaterialName.Name = "textBoxMaterialName";
            this.textBoxMaterialName.Size = new System.Drawing.Size(414, 22);
            this.textBoxMaterialName.TabIndex = 0;
            // 
            // labelMaterialName
            // 
            this.labelMaterialName.AutoSize = true;
            this.labelMaterialName.Location = new System.Drawing.Point(16, 11);
            this.labelMaterialName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMaterialName.Name = "labelMaterialName";
            this.labelMaterialName.Size = new System.Drawing.Size(111, 16);
            this.labelMaterialName.TabIndex = 1;
            this.labelMaterialName.Text = "Имя материала:";
            // 
            // textBoxMaterialDescription
            // 
            this.textBoxMaterialDescription.Location = new System.Drawing.Point(16, 92);
            this.textBoxMaterialDescription.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMaterialDescription.Name = "textBoxMaterialDescription";
            this.textBoxMaterialDescription.Size = new System.Drawing.Size(414, 22);
            this.textBoxMaterialDescription.TabIndex = 2;
            // 
            // labelMaterialDescription
            // 
            this.labelMaterialDescription.AutoSize = true;
            this.labelMaterialDescription.Location = new System.Drawing.Point(16, 66);
            this.labelMaterialDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMaterialDescription.Name = "labelMaterialDescription";
            this.labelMaterialDescription.Size = new System.Drawing.Size(75, 16);
            this.labelMaterialDescription.TabIndex = 3;
            this.labelMaterialDescription.Text = "Описание:";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdd.Location = new System.Drawing.Point(330, 136);
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
            this.buttonCancel.Location = new System.Drawing.Point(222, 136);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(100, 28);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // dataGridViewMaterials
            // 
            this.dataGridViewMaterials.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMaterials.Location = new System.Drawing.Point(16, 185);
            this.dataGridViewMaterials.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewMaterials.Name = "dataGridViewMaterials";
            this.dataGridViewMaterials.RowHeadersWidth = 51;
            this.dataGridViewMaterials.Size = new System.Drawing.Size(778, 263);
            this.dataGridViewMaterials.TabIndex = 6;
            // 
            // AddMaterialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 461);
            this.Controls.Add(this.dataGridViewMaterials);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelMaterialDescription);
            this.Controls.Add(this.textBoxMaterialDescription);
            this.Controls.Add(this.labelMaterialName);
            this.Controls.Add(this.textBoxMaterialName);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "AddMaterialForm";
            this.Text = "Добавить материал";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMaterials)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            this.MaterialName = textBoxMaterialName.Text;
            this.MaterialDescription = textBoxMaterialDescription.Text;

            if (string.IsNullOrEmpty(this.MaterialName) || string.IsNullOrEmpty(this.MaterialDescription))
            {
                MessageBox.Show("Имя материала и описание не могут быть пустыми.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private TextBox textBoxMaterialName;
        private Label labelMaterialName;
        private TextBox textBoxMaterialDescription;
        private Label labelMaterialDescription;
        private Button buttonAdd;
        private Button buttonCancel;
        private DataGridView dataGridViewMaterials;
    }


}


