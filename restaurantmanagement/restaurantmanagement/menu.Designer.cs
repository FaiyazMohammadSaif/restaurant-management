namespace restaurantmanagement
{
    partial class menu
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.restaurantdbDataSet1 = new restaurantmanagement.restaurantdbDataSet1();
            this.button1 = new System.Windows.Forms.Button();
            this.menuTableAdapter = new restaurantmanagement.restaurantdbDataSet1TableAdapters.menuTableAdapter();
            this.restaurantdbDataSet8 = new restaurantmanagement.restaurantdbDataSet8();
            this.menuBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.menuTableAdapter1 = new restaurantmanagement.restaurantdbDataSet8TableAdapters.menuTableAdapter();
            this.restaurantdbDataSet9 = new restaurantmanagement.restaurantdbDataSet9();
            this.menuBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.menuTableAdapter2 = new restaurantmanagement.restaurantdbDataSet9TableAdapters.menuTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.restaurantdbDataSet10 = new restaurantmanagement.restaurantdbDataSet10();
            this.menuTableAdapter3 = new restaurantmanagement.restaurantdbDataSet10TableAdapters.menuTableAdapter();
            this.restaurantdbDataSet16 = new restaurantmanagement.restaurantdbDataSet16();
            this.menuBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.menuTableAdapter4 = new restaurantmanagement.restaurantdbDataSet16TableAdapters.menuTableAdapter();
            this.foodIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foodNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.catagoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.menuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantdbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantdbDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantdbDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantdbDataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantdbDataSet16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuBindingSource4)).BeginInit();
            this.SuspendLayout();
            // 
            // menuBindingSource
            // 
            this.menuBindingSource.DataMember = "menu";
            this.menuBindingSource.DataSource = this.restaurantdbDataSet1;
            // 
            // restaurantdbDataSet1
            // 
            this.restaurantdbDataSet1.DataSetName = "restaurantdbDataSet1";
            this.restaurantdbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 537);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "BACK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuTableAdapter
            // 
            this.menuTableAdapter.ClearBeforeFill = true;
            // 
            // restaurantdbDataSet8
            // 
            this.restaurantdbDataSet8.DataSetName = "restaurantdbDataSet8";
            this.restaurantdbDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // menuBindingSource1
            // 
            this.menuBindingSource1.DataMember = "menu";
            this.menuBindingSource1.DataSource = this.restaurantdbDataSet8;
            // 
            // menuTableAdapter1
            // 
            this.menuTableAdapter1.ClearBeforeFill = true;
            // 
            // restaurantdbDataSet9
            // 
            this.restaurantdbDataSet9.DataSetName = "restaurantdbDataSet9";
            this.restaurantdbDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // menuBindingSource2
            // 
            this.menuBindingSource2.DataMember = "menu";
            this.menuBindingSource2.DataSource = this.restaurantdbDataSet9;
            // 
            // menuTableAdapter2
            // 
            this.menuTableAdapter2.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.foodIdDataGridViewTextBoxColumn,
            this.foodNameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.catagoryDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.menuBindingSource4;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.Location = new System.Drawing.Point(-2, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("MS Outlook", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(704, 517);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // menuBindingSource3
            // 
            this.menuBindingSource3.DataMember = "menu";
            this.menuBindingSource3.DataSource = this.restaurantdbDataSet10;
            // 
            // restaurantdbDataSet10
            // 
            this.restaurantdbDataSet10.DataSetName = "restaurantdbDataSet10";
            this.restaurantdbDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // menuTableAdapter3
            // 
            this.menuTableAdapter3.ClearBeforeFill = true;
            // 
            // restaurantdbDataSet16
            // 
            this.restaurantdbDataSet16.DataSetName = "restaurantdbDataSet16";
            this.restaurantdbDataSet16.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // menuBindingSource4
            // 
            this.menuBindingSource4.DataMember = "menu";
            this.menuBindingSource4.DataSource = this.restaurantdbDataSet16;
            // 
            // menuTableAdapter4
            // 
            this.menuTableAdapter4.ClearBeforeFill = true;
            // 
            // foodIdDataGridViewTextBoxColumn
            // 
            this.foodIdDataGridViewTextBoxColumn.DataPropertyName = "FoodId";
            this.foodIdDataGridViewTextBoxColumn.HeaderText = "FoodId";
            this.foodIdDataGridViewTextBoxColumn.Name = "foodIdDataGridViewTextBoxColumn";
            // 
            // foodNameDataGridViewTextBoxColumn
            // 
            this.foodNameDataGridViewTextBoxColumn.DataPropertyName = "FoodName";
            this.foodNameDataGridViewTextBoxColumn.HeaderText = "FoodName";
            this.foodNameDataGridViewTextBoxColumn.Name = "foodNameDataGridViewTextBoxColumn";
            this.foodNameDataGridViewTextBoxColumn.Width = 250;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.Width = 170;
            // 
            // catagoryDataGridViewTextBoxColumn
            // 
            this.catagoryDataGridViewTextBoxColumn.DataPropertyName = "Catagory";
            this.catagoryDataGridViewTextBoxColumn.HeaderText = "Catagory";
            this.catagoryDataGridViewTextBoxColumn.Name = "catagoryDataGridViewTextBoxColumn";
            this.catagoryDataGridViewTextBoxColumn.Width = 150;
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(699, 572);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.DoubleBuffered = true;
            this.Name = "menu";
            this.Text = "menu";
            this.Load += new System.EventHandler(this.menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.menuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantdbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantdbDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantdbDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantdbDataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantdbDataSet16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuBindingSource4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private restaurantdbDataSet1 restaurantdbDataSet1;
        private System.Windows.Forms.BindingSource menuBindingSource;
        private restaurantdbDataSet1TableAdapters.menuTableAdapter menuTableAdapter;
        private restaurantdbDataSet8 restaurantdbDataSet8;
        private System.Windows.Forms.BindingSource menuBindingSource1;
        private restaurantdbDataSet8TableAdapters.menuTableAdapter menuTableAdapter1;
        private restaurantdbDataSet9 restaurantdbDataSet9;
        private System.Windows.Forms.BindingSource menuBindingSource2;
        private restaurantdbDataSet9TableAdapters.menuTableAdapter menuTableAdapter2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private restaurantdbDataSet10 restaurantdbDataSet10;
        private System.Windows.Forms.BindingSource menuBindingSource3;
        private restaurantdbDataSet10TableAdapters.menuTableAdapter menuTableAdapter3;
        private restaurantdbDataSet16 restaurantdbDataSet16;
        private System.Windows.Forms.BindingSource menuBindingSource4;
        private restaurantdbDataSet16TableAdapters.menuTableAdapter menuTableAdapter4;
        private System.Windows.Forms.DataGridViewTextBoxColumn foodIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn foodNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn catagoryDataGridViewTextBoxColumn;
    }
}