namespace junproresponsi_497708
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
            pictureBox1 = new PictureBox();
            lblNama = new Label();
            lblDepartemen = new Label();
            tbNama = new TextBox();
            btnInsert = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            dgvData = new DataGridView();
            cbDepartemen = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(49, 39);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(61, 69);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblNama
            // 
            lblNama.AutoSize = true;
            lblNama.Location = new Point(49, 137);
            lblNama.Name = "lblNama";
            lblNama.Size = new Size(99, 15);
            lblNama.TabIndex = 1;
            lblNama.Text = "Nama Karyawan :";
            // 
            // lblDepartemen
            // 
            lblDepartemen.AutoSize = true;
            lblDepartemen.Location = new Point(49, 177);
            lblDepartemen.Name = "lblDepartemen";
            lblDepartemen.Size = new Size(91, 15);
            lblDepartemen.TabIndex = 2;
            lblDepartemen.Text = "Dep. Karyawan :";
            // 
            // tbNama
            // 
            tbNama.Location = new Point(154, 134);
            tbNama.Name = "tbNama";
            tbNama.Size = new Size(200, 23);
            tbNama.TabIndex = 3;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(49, 214);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(75, 35);
            btnInsert.TabIndex = 5;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(431, 214);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 35);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(242, 214);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 35);
            btnEdit.TabIndex = 7;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // dgvData
            // 
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Location = new Point(47, 273);
            dgvData.Name = "dgvData";
            dgvData.Size = new Size(459, 150);
            dgvData.TabIndex = 9;
            dgvData.CellContentClick += dgvData_CellContentClick;
            // 
            // cbDepartemen
            // 
            cbDepartemen.FormattingEnabled = true;
            cbDepartemen.Items.AddRange(new object[] { "HR", "ENG", "DEV", "PM", "FIN" });
            cbDepartemen.Location = new Point(154, 177);
            cbDepartemen.Name = "cbDepartemen";
            cbDepartemen.Size = new Size(200, 23);
            cbDepartemen.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(559, 470);
            Controls.Add(cbDepartemen);
            Controls.Add(dgvData);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Controls.Add(btnInsert);
            Controls.Add(tbNama);
            Controls.Add(lblDepartemen);
            Controls.Add(lblNama);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblNama;
        private Label lblDepartemen;
        private TextBox tbNama;
        private Button btnInsert;
        private Button btnDelete;
        private Button btnEdit;
        private DataGridView dgvData;
        private ComboBox cbDepartemen;
    }
}
