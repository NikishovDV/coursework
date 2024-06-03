using System;
using System.Data;
using System.Windows.Forms;

namespace CourceDB
{
    public partial class AddStaffForm : Form
    {
        public string StaffSurname { get; private set; }
        public string StaffName { get; private set; }
        public long StaffPhone { get; private set; }
        public string StaffPosition { get; private set; }

        public AddStaffForm()
        {
            InitializeComponent();
            LoadStaff();
        }

        private void LoadStaff()
        {
            DataTable staffTable = DB.GetAllStaffDT();
            dataGridViewStaff.DataSource = staffTable;
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddStaffForm));
            this.textBoxStaffSurname = new System.Windows.Forms.TextBox();
            this.labelStaffSurname = new System.Windows.Forms.Label();
            this.textBoxStaffName = new System.Windows.Forms.TextBox();
            this.labelStaffName = new System.Windows.Forms.Label();
            this.textBoxStaffPhone = new System.Windows.Forms.TextBox();
            this.labelStaffPhone = new System.Windows.Forms.Label();
            this.textBoxStaffPosition = new System.Windows.Forms.TextBox();
            this.labelStaffPosition = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.dataGridViewStaff = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStaff)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxStaffSurname
            // 
            this.textBoxStaffSurname.Location = new System.Drawing.Point(12, 32);
            this.textBoxStaffSurname.Name = "textBoxStaffSurname";
            this.textBoxStaffSurname.Size = new System.Drawing.Size(520, 22);
            this.textBoxStaffSurname.TabIndex = 0;
            // 
            // labelStaffSurname
            // 
            this.labelStaffSurname.AutoSize = true;
            this.labelStaffSurname.Location = new System.Drawing.Point(12, 9);
            this.labelStaffSurname.Name = "labelStaffSurname";
            this.labelStaffSurname.Size = new System.Drawing.Size(69, 16);
            this.labelStaffSurname.TabIndex = 1;
            this.labelStaffSurname.Text = "Фамилия:";
            // 
            // textBoxStaffName
            // 
            this.textBoxStaffName.Location = new System.Drawing.Point(12, 81);
            this.textBoxStaffName.Name = "textBoxStaffName";
            this.textBoxStaffName.Size = new System.Drawing.Size(520, 22);
            this.textBoxStaffName.TabIndex = 2;
            // 
            // labelStaffName
            // 
            this.labelStaffName.AutoSize = true;
            this.labelStaffName.Location = new System.Drawing.Point(12, 58);
            this.labelStaffName.Name = "labelStaffName";
            this.labelStaffName.Size = new System.Drawing.Size(36, 16);
            this.labelStaffName.TabIndex = 3;
            this.labelStaffName.Text = "Имя:";
            // 
            // textBoxStaffPhone
            // 
            this.textBoxStaffPhone.Location = new System.Drawing.Point(12, 135);
            this.textBoxStaffPhone.Name = "textBoxStaffPhone";
            this.textBoxStaffPhone.Size = new System.Drawing.Size(520, 22);
            this.textBoxStaffPhone.TabIndex = 4;
            // 
            // labelStaffPhone
            // 
            this.labelStaffPhone.AutoSize = true;
            this.labelStaffPhone.Location = new System.Drawing.Point(12, 110);
            this.labelStaffPhone.Name = "labelStaffPhone";
            this.labelStaffPhone.Size = new System.Drawing.Size(70, 16);
            this.labelStaffPhone.TabIndex = 5;
            this.labelStaffPhone.Text = "Телефон:";
            // 
            // textBoxStaffPosition
            // 
            this.textBoxStaffPosition.Location = new System.Drawing.Point(12, 190);
            this.textBoxStaffPosition.Name = "textBoxStaffPosition";
            this.textBoxStaffPosition.Size = new System.Drawing.Size(520, 22);
            this.textBoxStaffPosition.TabIndex = 6;
            // 
            // labelStaffPosition
            // 
            this.labelStaffPosition.AutoSize = true;
            this.labelStaffPosition.Location = new System.Drawing.Point(12, 165);
            this.labelStaffPosition.Name = "labelStaffPosition";
            this.labelStaffPosition.Size = new System.Drawing.Size(81, 16);
            this.labelStaffPosition.TabIndex = 7;
            this.labelStaffPosition.Text = "Должность:";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdd.Location = new System.Drawing.Point(450, 226);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(82, 23);
            this.buttonAdd.TabIndex = 8;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCancel.Location = new System.Drawing.Point(369, 226);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 9;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // dataGridViewStaff
            // 
            this.dataGridViewStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStaff.Location = new System.Drawing.Point(12, 264);
            this.dataGridViewStaff.Name = "dataGridViewStaff";
            this.dataGridViewStaff.RowHeadersWidth = 51;
            this.dataGridViewStaff.Size = new System.Drawing.Size(895, 266);
            this.dataGridViewStaff.TabIndex = 10;
            // 
            // AddStaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 542);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelStaffPosition);
            this.Controls.Add(this.textBoxStaffPosition);
            this.Controls.Add(this.labelStaffPhone);
            this.Controls.Add(this.textBoxStaffPhone);
            this.Controls.Add(this.labelStaffName);
            this.Controls.Add(this.textBoxStaffName);
            this.Controls.Add(this.labelStaffSurname);
            this.Controls.Add(this.textBoxStaffSurname);
            this.Controls.Add(this.dataGridViewStaff);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddStaffForm";
            this.Text = "Добавить сотрудника";
            this.Load += new System.EventHandler(this.AddStaffForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStaff)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            this.StaffSurname = textBoxStaffSurname.Text;
            this.StaffName = textBoxStaffName.Text;
            if (!long.TryParse(textBoxStaffPhone.Text, out long phone))
            {
                MessageBox.Show("Некорректный номер телефона.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this.StaffPhone = phone;
            this.StaffPosition = textBoxStaffPosition.Text;

            if (string.IsNullOrEmpty(this.StaffSurname) || string.IsNullOrEmpty(this.StaffName) || string.IsNullOrEmpty(this.StaffPosition))
            {
                MessageBox.Show("Фамилия, имя и должность не могут быть пустыми.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private TextBox textBoxStaffSurname;
        private Label labelStaffSurname;
        private TextBox textBoxStaffName;
        private Label labelStaffName;
        private TextBox textBoxStaffPhone;
        private Label labelStaffPhone;
        private TextBox textBoxStaffPosition;
        private Label labelStaffPosition;
        private Button buttonAdd;
        private Button buttonCancel;
        private DataGridView dataGridViewStaff;

        private void AddStaffForm_Load(object sender, EventArgs e)
        {

        }
    }
}
