namespace MongoDbOrder
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            txtId = new TextBox();
            btnList = new Button();
            dataGridView1 = new DataGridView();
            txtCustomer = new TextBox();
            label2 = new Label();
            txtDistrict = new TextBox();
            label3 = new Label();
            txtCity = new TextBox();
            label4 = new Label();
            txtTotalPrice = new TextBox();
            label5 = new Label();
            btnCreate = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnGetById = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(40, 9);
            label1.Name = "label1";
            label1.Size = new Size(89, 25);
            label1.TabIndex = 0;
            label1.Text = "Sipariş Id";
            // 
            // txtId
            // 
            txtId.Font = new Font("Segoe UI", 11F);
            txtId.Location = new Point(135, 9);
            txtId.Name = "txtId";
            txtId.Size = new Size(125, 32);
            txtId.TabIndex = 1;
            // 
            // btnList
            // 
            btnList.Font = new Font("Segoe UI", 11F);
            btnList.Location = new Point(290, 12);
            btnList.Name = "btnList";
            btnList.Size = new Size(94, 29);
            btnList.TabIndex = 2;
            btnList.Text = "Listele";
            btnList.UseVisualStyleBackColor = true;
            btnList.Click += btnList_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 199);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(776, 239);
            dataGridView1.TabIndex = 3;
            // 
            // txtCustomer
            // 
            txtCustomer.Font = new Font("Segoe UI", 11F);
            txtCustomer.Location = new Point(135, 47);
            txtCustomer.Name = "txtCustomer";
            txtCustomer.Size = new Size(125, 32);
            txtCustomer.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(53, 47);
            label2.Name = "label2";
            label2.Size = new Size(76, 25);
            label2.TabIndex = 4;
            label2.Text = "Müşteri";
            // 
            // txtDistrict
            // 
            txtDistrict.Font = new Font("Segoe UI", 11F);
            txtDistrict.Location = new Point(135, 85);
            txtDistrict.Name = "txtDistrict";
            txtDistrict.Size = new Size(125, 32);
            txtDistrict.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(88, 85);
            label3.Name = "label3";
            label3.Size = new Size(41, 25);
            label3.TabIndex = 6;
            label3.Text = "İlçe";
            // 
            // txtCity
            // 
            txtCity.Font = new Font("Segoe UI", 11F);
            txtCity.Location = new Point(135, 123);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(125, 32);
            txtCity.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F);
            label4.Location = new Point(74, 123);
            label4.Name = "label4";
            label4.Size = new Size(55, 25);
            label4.TabIndex = 8;
            label4.Text = "Şehir";
            // 
            // txtTotalPrice
            // 
            txtTotalPrice.Font = new Font("Segoe UI", 11F);
            txtTotalPrice.Location = new Point(135, 161);
            txtTotalPrice.Name = "txtTotalPrice";
            txtTotalPrice.Size = new Size(125, 32);
            txtTotalPrice.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F);
            label5.Location = new Point(12, 161);
            label5.Name = "label5";
            label5.Size = new Size(117, 25);
            label5.TabIndex = 10;
            label5.Text = "Toplam Fiyat";
            // 
            // btnCreate
            // 
            btnCreate.Font = new Font("Segoe UI", 11F);
            btnCreate.Location = new Point(290, 49);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(94, 29);
            btnCreate.TabIndex = 12;
            btnCreate.Text = "Ekle";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 11F);
            btnDelete.Location = new Point(290, 86);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "Sil";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 11F);
            btnUpdate.Location = new Point(290, 123);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 14;
            btnUpdate.Text = "Güncelle";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnGetById
            // 
            btnGetById.Font = new Font("Segoe UI", 11F);
            btnGetById.Location = new Point(290, 160);
            btnGetById.Name = "btnGetById";
            btnGetById.Size = new Size(94, 29);
            btnGetById.TabIndex = 15;
            btnGetById.Text = "Getir";
            btnGetById.UseVisualStyleBackColor = true;
            btnGetById.Click += btnGetById_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(417, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(371, 181);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(btnGetById);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnCreate);
            Controls.Add(txtTotalPrice);
            Controls.Add(label5);
            Controls.Add(txtCity);
            Controls.Add(label4);
            Controls.Add(txtDistrict);
            Controls.Add(label3);
            Controls.Add(txtCustomer);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(btnList);
            Controls.Add(txtId);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Siparis Yonetimi";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtId;
        private Button btnList;
        private DataGridView dataGridView1;
        private TextBox txtCustomer;
        private Label label2;
        private TextBox txtDistrict;
        private Label label3;
        private TextBox txtCity;
        private Label label4;
        private TextBox txtTotalPrice;
        private Label label5;
        private Button btnCreate;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnGetById;
        private PictureBox pictureBox1;
    }
}
