namespace funeralsystem
{
    partial class addClient
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            panel2 = new Panel();
            Addclient_servicetype = new ComboBox();
            label6 = new Label();
            addclient_import = new Button();
            addclient_clear = new Button();
            addclient_delete = new Button();
            addclient_update = new Button();
            addclient_add = new Button();
            addclient_picture = new PictureBox();
            addclien_item = new ComboBox();
            Item = new Label();
            addclient_gender = new ComboBox();
            label5 = new Label();
            addclient_phonenumber = new TextBox();
            label4 = new Label();
            addclient_fullname = new TextBox();
            label3 = new Label();
            addclient_id = new TextBox();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)addclient_picture).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(13, 13);
            panel1.Name = "panel1";
            panel1.Size = new Size(852, 251);
            panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(33, 11, 97);
            dataGridViewCellStyle1.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(51, 81);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(751, 148);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(51, 42);
            label1.Name = "label1";
            label1.Size = new Size(113, 23);
            label1.TabIndex = 0;
            label1.Text = "Client's Data";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.Controls.Add(Addclient_servicetype);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(addclient_import);
            panel2.Controls.Add(addclient_clear);
            panel2.Controls.Add(addclient_delete);
            panel2.Controls.Add(addclient_update);
            panel2.Controls.Add(addclient_add);
            panel2.Controls.Add(addclient_picture);
            panel2.Controls.Add(addclien_item);
            panel2.Controls.Add(Item);
            panel2.Controls.Add(addclient_gender);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(addclient_phonenumber);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(addclient_fullname);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(addclient_id);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(13, 292);
            panel2.Name = "panel2";
            panel2.Size = new Size(852, 232);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // Addclient_servicetype
            // 
            Addclient_servicetype.Font = new Font("Microsoft Sans Serif", 9.75F);
            Addclient_servicetype.FormattingEnabled = true;
            Addclient_servicetype.Items.AddRange(new object[] { "Burial", "Cremation", "Etc." });
            Addclient_servicetype.Location = new Point(447, 117);
            Addclient_servicetype.Name = "Addclient_servicetype";
            Addclient_servicetype.Size = new Size(173, 24);
            Addclient_servicetype.TabIndex = 18;
            Addclient_servicetype.SelectedIndexChanged += Addclient_servicetype_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(353, 117);
            label6.Name = "label6";
            label6.Size = new Size(88, 16);
            label6.TabIndex = 17;
            label6.Text = "Service Type";
            // 
            // addclient_import
            // 
            addclient_import.BackColor = Color.FromArgb(33, 8, 97);
            addclient_import.Cursor = Cursors.Hand;
            addclient_import.FlatAppearance.CheckedBackColor = Color.FromArgb(72, 8, 138);
            addclient_import.FlatAppearance.MouseDownBackColor = Color.FromArgb(72, 8, 138);
            addclient_import.FlatAppearance.MouseOverBackColor = Color.FromArgb(72, 8, 138);
            addclient_import.FlatStyle = FlatStyle.Flat;
            addclient_import.Font = new Font("Arial Rounded MT Bold", 9.75F);
            addclient_import.ForeColor = Color.White;
            addclient_import.Location = new Point(735, 134);
            addclient_import.Name = "addclient_import";
            addclient_import.Size = new Size(87, 23);
            addclient_import.TabIndex = 16;
            addclient_import.Text = "Import";
            addclient_import.UseVisualStyleBackColor = false;
            addclient_import.Click += addclient_import_Click;
            // 
            // addclient_clear
            // 
            addclient_clear.BackColor = Color.FromArgb(33, 8, 97);
            addclient_clear.Cursor = Cursors.Hand;
            addclient_clear.FlatAppearance.CheckedBackColor = Color.FromArgb(72, 8, 138);
            addclient_clear.FlatAppearance.MouseDownBackColor = Color.FromArgb(72, 8, 138);
            addclient_clear.FlatAppearance.MouseOverBackColor = Color.FromArgb(72, 8, 138);
            addclient_clear.FlatStyle = FlatStyle.Flat;
            addclient_clear.Font = new Font("Arial Rounded MT Bold", 9.75F);
            addclient_clear.ForeColor = Color.White;
            addclient_clear.Location = new Point(602, 171);
            addclient_clear.Name = "addclient_clear";
            addclient_clear.Size = new Size(92, 31);
            addclient_clear.TabIndex = 15;
            addclient_clear.Text = "Clear";
            addclient_clear.UseVisualStyleBackColor = false;
            addclient_clear.Click += addclient_clear_Click;
            // 
            // addclient_delete
            // 
            addclient_delete.BackColor = Color.FromArgb(33, 8, 97);
            addclient_delete.Cursor = Cursors.Hand;
            addclient_delete.FlatAppearance.CheckedBackColor = Color.FromArgb(72, 8, 138);
            addclient_delete.FlatAppearance.MouseDownBackColor = Color.FromArgb(72, 8, 138);
            addclient_delete.FlatAppearance.MouseOverBackColor = Color.FromArgb(72, 8, 138);
            addclient_delete.FlatStyle = FlatStyle.Flat;
            addclient_delete.Font = new Font("Arial Rounded MT Bold", 9.75F);
            addclient_delete.ForeColor = Color.White;
            addclient_delete.Location = new Point(480, 171);
            addclient_delete.Name = "addclient_delete";
            addclient_delete.Size = new Size(97, 31);
            addclient_delete.TabIndex = 14;
            addclient_delete.Text = "Delete";
            addclient_delete.UseVisualStyleBackColor = false;
            addclient_delete.Click += button5_Click;
            // 
            // addclient_update
            // 
            addclient_update.BackColor = Color.FromArgb(33, 8, 97);
            addclient_update.Cursor = Cursors.Hand;
            addclient_update.FlatAppearance.CheckedBackColor = Color.FromArgb(72, 8, 138);
            addclient_update.FlatAppearance.MouseDownBackColor = Color.FromArgb(72, 8, 138);
            addclient_update.FlatAppearance.MouseOverBackColor = Color.FromArgb(72, 8, 138);
            addclient_update.FlatStyle = FlatStyle.Flat;
            addclient_update.Font = new Font("Arial Rounded MT Bold", 9.75F);
            addclient_update.ForeColor = Color.White;
            addclient_update.Location = new Point(362, 171);
            addclient_update.Name = "addclient_update";
            addclient_update.Size = new Size(92, 31);
            addclient_update.TabIndex = 13;
            addclient_update.Text = "Update";
            addclient_update.UseVisualStyleBackColor = false;
            addclient_update.Click += addclient_update_Click;
            // 
            // addclient_add
            // 
            addclient_add.BackColor = Color.FromArgb(33, 8, 97);
            addclient_add.Cursor = Cursors.Hand;
            addclient_add.FlatAppearance.CheckedBackColor = Color.FromArgb(72, 8, 138);
            addclient_add.FlatAppearance.MouseDownBackColor = Color.FromArgb(72, 8, 138);
            addclient_add.FlatAppearance.MouseOverBackColor = Color.FromArgb(72, 8, 138);
            addclient_add.FlatStyle = FlatStyle.Flat;
            addclient_add.Font = new Font("Arial Rounded MT Bold", 9.75F);
            addclient_add.ForeColor = Color.White;
            addclient_add.Location = new Point(237, 171);
            addclient_add.Name = "addclient_add";
            addclient_add.Size = new Size(97, 31);
            addclient_add.TabIndex = 12;
            addclient_add.Text = "Add";
            addclient_add.UseVisualStyleBackColor = false;
            addclient_add.Click += addclient_add_Click;
            // 
            // addclient_picture
            // 
            addclient_picture.BackColor = SystemColors.ButtonShadow;
            addclient_picture.BorderStyle = BorderStyle.FixedSingle;
            addclient_picture.Location = new Point(735, 37);
            addclient_picture.Name = "addclient_picture";
            addclient_picture.Size = new Size(87, 101);
            addclient_picture.TabIndex = 10;
            addclient_picture.TabStop = false;
            // 
            // addclien_item
            // 
            addclien_item.Font = new Font("Microsoft Sans Serif", 9.75F);
            addclien_item.FormattingEnabled = true;
            addclien_item.Items.AddRange(new object[] { "Traditional coffin", "Cardboard coffin", "Wicker coffin", "Bamboo coffin", "Eco coffin", "Wooden casket", "Metal casket" });
            addclien_item.Location = new Point(447, 75);
            addclien_item.Name = "addclien_item";
            addclien_item.Size = new Size(173, 24);
            addclien_item.TabIndex = 9;
            // 
            // Item
            // 
            Item.AutoSize = true;
            Item.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Item.Location = new Point(397, 77);
            Item.Name = "Item";
            Item.Size = new Size(35, 16);
            Item.TabIndex = 8;
            Item.Text = "Item:";
            // 
            // addclient_gender
            // 
            addclient_gender.Font = new Font("Microsoft Sans Serif", 9.75F);
            addclient_gender.FormattingEnabled = true;
            addclient_gender.Items.AddRange(new object[] { "Male", "Female", "Others" });
            addclient_gender.Location = new Point(149, 115);
            addclient_gender.Name = "addclient_gender";
            addclient_gender.Size = new Size(173, 24);
            addclient_gender.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(89, 117);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 6;
            label5.Text = "Gender:";
            label5.Click += label5_Click;
            // 
            // addclient_phonenumber
            // 
            addclient_phonenumber.Font = new Font("Microsoft Sans Serif", 9.75F);
            addclient_phonenumber.Location = new Point(447, 35);
            addclient_phonenumber.Name = "addclient_phonenumber";
            addclient_phonenumber.Size = new Size(173, 22);
            addclient_phonenumber.TabIndex = 5;
            addclient_phonenumber.TextChanged += addclient_phonenumber_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(347, 43);
            label4.Name = "label4";
            label4.Size = new Size(94, 15);
            label4.TabIndex = 4;
            label4.Text = "Phone Number:";
            label4.Click += label4_Click;
            // 
            // addclient_fullname
            // 
            addclient_fullname.Font = new Font("Microsoft Sans Serif", 9.75F);
            addclient_fullname.Location = new Point(149, 75);
            addclient_fullname.Name = "addclient_fullname";
            addclient_fullname.Size = new Size(173, 22);
            addclient_fullname.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(78, 77);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 2;
            label3.Text = "Fullname:";
            label3.Click += label3_Click;
            // 
            // addclient_id
            // 
            addclient_id.Font = new Font("Microsoft Sans Serif", 9.75F);
            addclient_id.Location = new Point(149, 35);
            addclient_id.Name = "addclient_id";
            addclient_id.Size = new Size(173, 22);
            addclient_id.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(75, 37);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 0;
            label2.Text = "Client's ID:";
            label2.Click += label2_Click;
            // 
            // addClient
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "addClient";
            Size = new Size(876, 563);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)addclient_picture).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private DataGridView dataGridView1;
        private TextBox addclient_fullname;
        private Label label3;
        private TextBox addclient_id;
        private Label label2;
        private Label label5;
        private TextBox addclient_phonenumber;
        private Label label4;
        private ComboBox addclient_gender;
        private PictureBox addclient_picture;
        private ComboBox addclien_item;
        private Label Item;
        private Button addclient_clear;
        private Button addclient_delete;
        private Button addclient_update;
        private Button addclient_add;
        private Button addclient_import;
        private Label label6;
        private ComboBox Addclient_servicetype;
    }
}
