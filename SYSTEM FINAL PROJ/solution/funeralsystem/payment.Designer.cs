namespace funeralsystem
{
    partial class payment
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
            payment_clearbtn = new Button();
            payment_updatebtn = new Button();
            payment_totalpayment = new TextBox();
            label5 = new Label();
            payment_item = new TextBox();
            label4 = new Label();
            payment_fullname = new TextBox();
            label3 = new Label();
            payment_clientid = new TextBox();
            label2 = new Label();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(payment_clearbtn);
            panel1.Controls.Add(payment_updatebtn);
            panel1.Controls.Add(payment_totalpayment);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(payment_item);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(payment_fullname);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(payment_clientid);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(29, 20);
            panel1.Name = "panel1";
            panel1.Size = new Size(249, 528);
            panel1.TabIndex = 0;
            // 
            // payment_clearbtn
            // 
            payment_clearbtn.BackColor = Color.FromArgb(33, 8, 97);
            payment_clearbtn.Cursor = Cursors.Hand;
            payment_clearbtn.FlatAppearance.CheckedBackColor = Color.FromArgb(72, 8, 138);
            payment_clearbtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(72, 8, 138);
            payment_clearbtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(72, 8, 138);
            payment_clearbtn.FlatStyle = FlatStyle.Flat;
            payment_clearbtn.Font = new Font("Arial Rounded MT Bold", 9.75F);
            payment_clearbtn.ForeColor = Color.White;
            payment_clearbtn.Location = new Point(138, 344);
            payment_clearbtn.Name = "payment_clearbtn";
            payment_clearbtn.Size = new Size(90, 34);
            payment_clearbtn.TabIndex = 16;
            payment_clearbtn.Text = "Clear";
            payment_clearbtn.UseVisualStyleBackColor = false;
            payment_clearbtn.Click += payment_clearbtn_Click;
            // 
            // payment_updatebtn
            // 
            payment_updatebtn.BackColor = Color.FromArgb(33, 8, 97);
            payment_updatebtn.Cursor = Cursors.Hand;
            payment_updatebtn.FlatAppearance.CheckedBackColor = Color.FromArgb(72, 8, 138);
            payment_updatebtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(72, 8, 138);
            payment_updatebtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(72, 8, 138);
            payment_updatebtn.FlatStyle = FlatStyle.Flat;
            payment_updatebtn.Font = new Font("Arial Rounded MT Bold", 9.75F);
            payment_updatebtn.ForeColor = Color.White;
            payment_updatebtn.Location = new Point(25, 344);
            payment_updatebtn.Name = "payment_updatebtn";
            payment_updatebtn.Size = new Size(90, 34);
            payment_updatebtn.TabIndex = 14;
            payment_updatebtn.Text = "Update";
            payment_updatebtn.UseVisualStyleBackColor = false;
            payment_updatebtn.Click += payment_updatebtn_Click;
            // 
            // payment_totalpayment
            // 
            payment_totalpayment.Font = new Font("Microsoft Sans Serif", 9.75F);
            payment_totalpayment.Location = new Point(25, 281);
            payment_totalpayment.Name = "payment_totalpayment";
            payment_totalpayment.Size = new Size(203, 22);
            payment_totalpayment.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(25, 262);
            label5.Name = "label5";
            label5.Size = new Size(94, 16);
            label5.TabIndex = 6;
            label5.Text = "Total payment:";
            // 
            // payment_item
            // 
            payment_item.Font = new Font("Microsoft Sans Serif", 9.75F);
            payment_item.Location = new Point(25, 215);
            payment_item.Name = "payment_item";
            payment_item.Size = new Size(203, 22);
            payment_item.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(25, 196);
            label4.Name = "label4";
            label4.Size = new Size(38, 16);
            label4.TabIndex = 4;
            label4.Text = "Item:";
            label4.Click += label4_Click;
            // 
            // payment_fullname
            // 
            payment_fullname.Font = new Font("Microsoft Sans Serif", 9.75F);
            payment_fullname.Location = new Point(25, 143);
            payment_fullname.Name = "payment_fullname";
            payment_fullname.Size = new Size(203, 22);
            payment_fullname.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(25, 124);
            label3.Name = "label3";
            label3.Size = new Size(69, 16);
            label3.TabIndex = 2;
            label3.Text = "Full Name:";
            // 
            // payment_clientid
            // 
            payment_clientid.Font = new Font("Microsoft Sans Serif", 9.75F);
            payment_clientid.Location = new Point(25, 75);
            payment_clientid.Name = "payment_clientid";
            payment_clientid.Size = new Size(203, 22);
            payment_clientid.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(25, 56);
            label2.Name = "label2";
            label2.Size = new Size(63, 16);
            label2.TabIndex = 0;
            label2.Text = "Client  ID ";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(306, 20);
            panel2.Name = "panel2";
            panel2.Size = new Size(546, 528);
            panel2.TabIndex = 1;
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
            dataGridView1.Location = new Point(26, 75);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(492, 430);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(26, 27);
            label1.Name = "label1";
            label1.Size = new Size(64, 23);
            label1.TabIndex = 0;
            label1.Text = "Clients";
            label1.Click += label1_Click;
            // 
            // payment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "payment";
            Size = new Size(876, 563);
            Load += payment_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private TextBox payment_item;
        private Label label4;
        private TextBox payment_fullname;
        private Label label3;
        private TextBox payment_clientid;
        private Label label2;
        private TextBox payment_totalpayment;
        private Label label5;
        private Button payment_clearbtn;
        private Button button4;
        private Button payment_updatebtn;
        private Button button2;
        private DataGridView dataGridView1;
    }
}
