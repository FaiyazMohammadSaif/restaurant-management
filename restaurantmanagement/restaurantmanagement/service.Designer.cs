namespace restaurantmanagement
{
    partial class service
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(service));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.serviceBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.restaurantdbDataSet6 = new restaurantmanagement.restaurantdbDataSet6();
            this.serviceBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.restaurantdbDataSet4 = new restaurantmanagement.restaurantdbDataSet4();
            this.button2 = new System.Windows.Forms.Button();
            this.restaurantdbDataSet2 = new restaurantmanagement.restaurantdbDataSet2();
            this.serviceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.serviceTableAdapter = new restaurantmanagement.restaurantdbDataSet2TableAdapters.serviceTableAdapter();
            this.restaurantdbDataSet3 = new restaurantmanagement.restaurantdbDataSet3();
            this.serviceBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.serviceTableAdapter1 = new restaurantmanagement.restaurantdbDataSet3TableAdapters.serviceTableAdapter();
            this.serviceTableAdapter2 = new restaurantmanagement.restaurantdbDataSet4TableAdapters.serviceTableAdapter();
            this.restaurantdbDataSet5 = new restaurantmanagement.restaurantdbDataSet5();
            this.serviceBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.serviceTableAdapter3 = new restaurantmanagement.restaurantdbDataSet5TableAdapters.serviceTableAdapter();
            this.serviceTableAdapter4 = new restaurantmanagement.restaurantdbDataSet6TableAdapters.serviceTableAdapter();
            this.button3 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantdbDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantdbDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantdbDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantdbDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantdbDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Table no";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(53, 108);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(138, 26);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Employee no";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(57, 223);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(134, 26);
            this.textBox2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(62, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Date";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(290, 431);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 27);
            this.button1.TabIndex = 6;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.Location = new System.Drawing.Point(224, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(443, 268);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // serviceBindingSource4
            // 
            this.serviceBindingSource4.DataMember = "service";
            this.serviceBindingSource4.DataSource = this.restaurantdbDataSet6;
            // 
            // restaurantdbDataSet6
            // 
            this.restaurantdbDataSet6.DataSetName = "restaurantdbDataSet6";
            this.restaurantdbDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // serviceBindingSource2
            // 
            this.serviceBindingSource2.DataMember = "service";
            this.serviceBindingSource2.DataSource = this.restaurantdbDataSet4;
            // 
            // restaurantdbDataSet4
            // 
            this.restaurantdbDataSet4.DataSetName = "restaurantdbDataSet4";
            this.restaurantdbDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(57, 508);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "BACK";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // restaurantdbDataSet2
            // 
            this.restaurantdbDataSet2.DataSetName = "restaurantdbDataSet2";
            this.restaurantdbDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // serviceBindingSource
            // 
            this.serviceBindingSource.DataMember = "service";
            this.serviceBindingSource.DataSource = this.restaurantdbDataSet2;
            // 
            // serviceTableAdapter
            // 
            this.serviceTableAdapter.ClearBeforeFill = true;
            // 
            // restaurantdbDataSet3
            // 
            this.restaurantdbDataSet3.DataSetName = "restaurantdbDataSet3";
            this.restaurantdbDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // serviceBindingSource1
            // 
            this.serviceBindingSource1.DataMember = "service";
            this.serviceBindingSource1.DataSource = this.restaurantdbDataSet3;
            // 
            // serviceTableAdapter1
            // 
            this.serviceTableAdapter1.ClearBeforeFill = true;
            // 
            // serviceTableAdapter2
            // 
            this.serviceTableAdapter2.ClearBeforeFill = true;
            // 
            // restaurantdbDataSet5
            // 
            this.restaurantdbDataSet5.DataSetName = "restaurantdbDataSet5";
            this.restaurantdbDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // serviceBindingSource3
            // 
            this.serviceBindingSource3.DataMember = "service";
            this.serviceBindingSource3.DataSource = this.restaurantdbDataSet5;
            // 
            // serviceTableAdapter3
            // 
            this.serviceTableAdapter3.ClearBeforeFill = true;
            // 
            // serviceTableAdapter4
            // 
            this.serviceTableAdapter4.ClearBeforeFill = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(290, 480);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(148, 28);
            this.button3.TabIndex = 11;
            this.button3.Text = "Refresh";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(57, 327);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(127, 20);
            this.dateTimePicker1.TabIndex = 12;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // service
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(699, 572);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "service";
            this.Text = "service";
            this.Load += new System.EventHandler(this.service_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantdbDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantdbDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantdbDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantdbDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantdbDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private restaurantdbDataSet2 restaurantdbDataSet2;
        private System.Windows.Forms.BindingSource serviceBindingSource;
        private restaurantdbDataSet2TableAdapters.serviceTableAdapter serviceTableAdapter;
        private restaurantdbDataSet3 restaurantdbDataSet3;
        private System.Windows.Forms.BindingSource serviceBindingSource1;
        private restaurantdbDataSet3TableAdapters.serviceTableAdapter serviceTableAdapter1;
        private restaurantdbDataSet4 restaurantdbDataSet4;
        private System.Windows.Forms.BindingSource serviceBindingSource2;
        private restaurantdbDataSet4TableAdapters.serviceTableAdapter serviceTableAdapter2;
        private restaurantdbDataSet5 restaurantdbDataSet5;
        private System.Windows.Forms.BindingSource serviceBindingSource3;
        private restaurantdbDataSet5TableAdapters.serviceTableAdapter serviceTableAdapter3;
        private restaurantdbDataSet6 restaurantdbDataSet6;
        private System.Windows.Forms.BindingSource serviceBindingSource4;
        private restaurantdbDataSet6TableAdapters.serviceTableAdapter serviceTableAdapter4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}