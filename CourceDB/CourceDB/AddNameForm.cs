using System;
using System.Data;
using System.Windows.Forms;

namespace CourceDB
{
    public partial class AddNameForm : Form
    {
        public string NameValue { get; private set; }

        public AddNameForm()
        {
            InitializeComponent();
            LoadNames();
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNameForm));
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.dataGridViewNames = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNames)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(12, 30);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(378, 22);
            this.textBoxName.TabIndex = 0;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(12, 9);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(36, 16);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Имя:";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdd.Location = new System.Drawing.Point(315, 58);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCancel.Location = new System.Drawing.Point(234, 58);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // dataGridViewNames
            // 
            this.dataGridViewNames.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNames.Location = new System.Drawing.Point(12, 100);
            this.dataGridViewNames.Name = "dataGridViewNames";
            this.dataGridViewNames.RowHeadersWidth = 51;
            this.dataGridViewNames.Size = new System.Drawing.Size(823, 357);
            this.dataGridViewNames.TabIndex = 4;
            // 
            // AddNameForm
            // 
            this.ClientSize = new System.Drawing.Size(847, 469);
            this.Controls.Add(this.dataGridViewNames);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxName);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddNameForm";
            this.Text = "Добавить имя";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNames)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            // Check if the text box is not empty
            if (string.IsNullOrWhiteSpace(textBoxName.Text))
            {
                MessageBox.Show("Имя не может быть пустым.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Get the name from the text box
            NameValue = textBoxName.Text;

            // Save the name to the database
            DB.AddName(NameValue);

            // Refresh the DataGridView to show the new name
            LoadNames();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void LoadNames()
        {
            DataTable namesTable = DB.GetAllNames();
            dataGridViewNames.DataSource = namesTable;
        }

        private TextBox textBoxName;
        private Label labelName;
        private Button buttonAdd;
        private Button buttonCancel;
        private DataGridView dataGridViewNames;
    }
}

