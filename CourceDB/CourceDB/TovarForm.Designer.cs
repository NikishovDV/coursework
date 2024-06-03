namespace CourceDB
{
    partial class TovarForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TovarForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColDel = new System.Windows.Forms.DataGridViewButtonColumn();
            this.buttonSale = new System.Windows.Forms.Button();
            this.buttonAddTovar = new System.Windows.Forms.Button();
            this.buttonAddFabric = new System.Windows.Forms.Button();
            this.buttonAddColor = new System.Windows.Forms.Button();
            this.buttonAddMaterial = new System.Windows.Forms.Button();
            this.buttonAddName = new System.Windows.Forms.Button();
            this.buttonAddBrand = new System.Windows.Forms.Button();
            this.buttonAddStaff = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBoxCart = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCart)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColId,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.ColEdit,
            this.ColDel});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(1863, 769);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // ColId
            // 
            this.ColId.DataPropertyName = "ID";
            this.ColId.Frozen = true;
            this.ColId.HeaderText = "№";
            this.ColId.MinimumWidth = 6;
            this.ColId.Name = "ColId";
            this.ColId.Width = 30;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Name";
            this.Column2.Frozen = true;
            this.Column2.HeaderText = "Название";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Size";
            this.Column3.Frozen = true;
            this.Column3.HeaderText = "Размер";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 70;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Brand";
            this.Column4.Frozen = true;
            this.Column4.HeaderText = "Бренд";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Sole";
            this.Column5.Frozen = true;
            this.Column5.HeaderText = "Высота подошвы";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 80;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Material";
            this.Column6.Frozen = true;
            this.Column6.HeaderText = "Материал";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "Color";
            this.Column7.Frozen = true;
            this.Column7.HeaderText = "Цвет";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 125;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "Guarantee";
            this.Column8.Frozen = true;
            this.Column8.HeaderText = "Гарантия";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.Width = 80;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "Fabricator";
            this.Column9.Frozen = true;
            this.Column9.HeaderText = "Производитель";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.Width = 125;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "Price";
            this.Column10.Frozen = true;
            this.Column10.HeaderText = "Цена";
            this.Column10.MinimumWidth = 6;
            this.Column10.Name = "Column10";
            this.Column10.Width = 60;
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "Amount";
            this.Column11.Frozen = true;
            this.Column11.HeaderText = "Количество в магазине";
            this.Column11.MinimumWidth = 6;
            this.Column11.Name = "Column11";
            this.Column11.Width = 125;
            // 
            // ColEdit
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.ColEdit.DefaultCellStyle = dataGridViewCellStyle1;
            this.ColEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ColEdit.Frozen = true;
            this.ColEdit.HeaderText = "";
            this.ColEdit.MinimumWidth = 6;
            this.ColEdit.Name = "ColEdit";
            this.ColEdit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColEdit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColEdit.Text = "Изменить";
            this.ColEdit.UseColumnTextForButtonValue = true;
            this.ColEdit.Width = 125;
            // 
            // ColDel
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.ColDel.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ColDel.Frozen = true;
            this.ColDel.HeaderText = "";
            this.ColDel.MinimumWidth = 6;
            this.ColDel.Name = "ColDel";
            this.ColDel.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColDel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColDel.Text = "Удалить";
            this.ColDel.UseColumnTextForButtonValue = true;
            this.ColDel.Width = 125;
            // 
            // buttonSale
            // 
            this.buttonSale.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonSale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.buttonSale.Location = new System.Drawing.Point(355, 861);
            this.buttonSale.Name = "buttonSale";
            this.buttonSale.Size = new System.Drawing.Size(189, 39);
            this.buttonSale.TabIndex = 21;
            this.buttonSale.Text = "Все продажи";
            this.buttonSale.UseVisualStyleBackColor = false;
            this.buttonSale.Click += new System.EventHandler(this.buttonSale_Click);
            // 
            // buttonAddTovar
            // 
            this.buttonAddTovar.BackColor = System.Drawing.Color.Tan;
            this.buttonAddTovar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddTovar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.buttonAddTovar.Location = new System.Drawing.Point(16, 861);
            this.buttonAddTovar.Name = "buttonAddTovar";
            this.buttonAddTovar.Size = new System.Drawing.Size(189, 39);
            this.buttonAddTovar.TabIndex = 23;
            this.buttonAddTovar.Text = "Добавить товар";
            this.buttonAddTovar.UseVisualStyleBackColor = false;
            this.buttonAddTovar.Click += new System.EventHandler(this.buttonAddTovar_Click);
            // 
            // buttonAddFabric
            // 
            this.buttonAddFabric.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddFabric.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.buttonAddFabric.Location = new System.Drawing.Point(633, 861);
            this.buttonAddFabric.Name = "buttonAddFabric";
            this.buttonAddFabric.Size = new System.Drawing.Size(184, 39);
            this.buttonAddFabric.TabIndex = 24;
            this.buttonAddFabric.Text = "Производителя";
            this.buttonAddFabric.UseVisualStyleBackColor = true;
            this.buttonAddFabric.Click += new System.EventHandler(this.buttonAddFabric_Click);
            // 
            // buttonAddColor
            // 
            this.buttonAddColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.buttonAddColor.Location = new System.Drawing.Point(633, 906);
            this.buttonAddColor.Name = "buttonAddColor";
            this.buttonAddColor.Size = new System.Drawing.Size(184, 39);
            this.buttonAddColor.TabIndex = 25;
            this.buttonAddColor.Text = "Цвет";
            this.buttonAddColor.UseVisualStyleBackColor = true;
            this.buttonAddColor.Click += new System.EventHandler(this.buttonAddColor_Click);
            // 
            // buttonAddMaterial
            // 
            this.buttonAddMaterial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.buttonAddMaterial.Location = new System.Drawing.Point(823, 861);
            this.buttonAddMaterial.Name = "buttonAddMaterial";
            this.buttonAddMaterial.Size = new System.Drawing.Size(184, 39);
            this.buttonAddMaterial.TabIndex = 26;
            this.buttonAddMaterial.Text = "Материл";
            this.buttonAddMaterial.UseVisualStyleBackColor = true;
            this.buttonAddMaterial.Click += new System.EventHandler(this.buttonAddMaterial_Click);
            // 
            // buttonAddName
            // 
            this.buttonAddName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.buttonAddName.Location = new System.Drawing.Point(823, 906);
            this.buttonAddName.Name = "buttonAddName";
            this.buttonAddName.Size = new System.Drawing.Size(184, 39);
            this.buttonAddName.TabIndex = 27;
            this.buttonAddName.Text = "Тип";
            this.buttonAddName.UseVisualStyleBackColor = true;
            this.buttonAddName.Click += new System.EventHandler(this.buttonAddName_Click);
            // 
            // buttonAddBrand
            // 
            this.buttonAddBrand.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.buttonAddBrand.Location = new System.Drawing.Point(1013, 906);
            this.buttonAddBrand.Name = "buttonAddBrand";
            this.buttonAddBrand.Size = new System.Drawing.Size(184, 39);
            this.buttonAddBrand.TabIndex = 28;
            this.buttonAddBrand.Text = "Бренд";
            this.buttonAddBrand.UseVisualStyleBackColor = true;
            this.buttonAddBrand.Click += new System.EventHandler(this.buttonAddBrand_Click);
            // 
            // buttonAddStaff
            // 
            this.buttonAddStaff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.buttonAddStaff.Location = new System.Drawing.Point(1013, 861);
            this.buttonAddStaff.Name = "buttonAddStaff";
            this.buttonAddStaff.Size = new System.Drawing.Size(184, 39);
            this.buttonAddStaff.TabIndex = 29;
            this.buttonAddStaff.Text = "Сотрудника";
            this.buttonAddStaff.UseVisualStyleBackColor = true;
            this.buttonAddStaff.Click += new System.EventHandler(this.buttonAddStaff_Click);
            // 
            // Label1
            // 
            this.Label1.AutoEllipsis = true;
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label1.Location = new System.Drawing.Point(628, 824);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(98, 25);
            this.Label1.TabIndex = 37;
            this.Label1.Text = "Создать";
            // 
            // label2
            // 
            this.label2.AutoEllipsis = true;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(11, 824);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 25);
            this.label2.TabIndex = 39;
            this.label2.Text = "Поступление товара";
            // 
            // label3
            // 
            this.label3.AutoEllipsis = true;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(350, 824);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 25);
            this.label3.TabIndex = 40;
            this.label3.Text = "Статистика";
            // 
            // pictureBoxCart
            // 
            this.pictureBoxCart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxCart.Image = global::CourceDB.Properties.Resources.cart;
            this.pictureBoxCart.Location = new System.Drawing.Point(1589, 861);
            this.pictureBoxCart.Name = "pictureBoxCart";
            this.pictureBoxCart.Size = new System.Drawing.Size(114, 102);
            this.pictureBoxCart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCart.TabIndex = 22;
            this.pictureBoxCart.TabStop = false;
            this.pictureBoxCart.Click += new System.EventHandler(this.pictureBoxCart_Click);
            // 
            // label4
            // 
            this.label4.AutoEllipsis = true;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(1584, 824);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 25);
            this.label4.TabIndex = 41;
            this.label4.Text = "Корзина";
            // 
            // TovarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.buttonAddStaff);
            this.Controls.Add(this.buttonAddBrand);
            this.Controls.Add(this.buttonAddName);
            this.Controls.Add(this.buttonAddMaterial);
            this.Controls.Add(this.buttonAddColor);
            this.Controls.Add(this.buttonAddFabric);
            this.Controls.Add(this.buttonAddTovar);
            this.Controls.Add(this.pictureBoxCart);
            this.Controls.Add(this.buttonSale);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TovarForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Товары";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TovarForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewButtonColumn ColEdit;
        private System.Windows.Forms.DataGridViewButtonColumn ColDel;
        private System.Windows.Forms.Button buttonSale;
        private System.Windows.Forms.PictureBox pictureBoxCart;
        private System.Windows.Forms.Button buttonAddTovar;
        private System.Windows.Forms.Button buttonAddFabric;
        private System.Windows.Forms.Button buttonAddColor;
        private System.Windows.Forms.Button buttonAddMaterial;
        private System.Windows.Forms.Button buttonAddName;
        private System.Windows.Forms.Button buttonAddBrand;
        private System.Windows.Forms.Button buttonAddStaff;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Label label4;
    }
}