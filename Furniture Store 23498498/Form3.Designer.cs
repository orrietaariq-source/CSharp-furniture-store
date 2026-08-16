namespace _23498498
{
    partial class Form3
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
            panel1 = new Panel();
            label1 = new Label();
            label6 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label7 = new Label();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            panel2 = new Panel();
            label5 = new Label();
            panel3 = new Panel();
            txtPhone = new TextBox();
            txtID = new TextBox();
            txtEmail = new TextBox();
            txtName = new TextBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            btnValidate = new Button();
            btnClear = new Button();
            panel5 = new Panel();
            label12 = new Label();
            grpInvoice = new GroupBox();
            txtInvoice = new TextBox();
            menuStrip1 = new MenuStrip();
            homeToolStripMenuItem = new ToolStripMenuItem();
            catalogueToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            label13 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            grpInvoice.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label7);
            panel1.ForeColor = SystemColors.ControlText;
            panel1.Location = new Point(0, 27);
            panel1.Name = "panel1";
            panel1.Size = new Size(981, 94);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkGreen;
            label1.Location = new Point(477, 17);
            label1.Name = "label1";
            label1.Size = new Size(288, 23);
            label1.TabIndex = 12;
            label1.Text = "CUSTOMER DETAILS AND INVOICE";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe Script", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.DarkGreen;
            label6.Location = new Point(201, 17);
            label6.Name = "label6";
            label6.Size = new Size(283, 61);
            label6.TabIndex = 11;
            label6.Text = "Couch Potato";
            label6.Click += label6_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.invoicecouch2;
            pictureBox2.Location = new Point(771, -2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(210, 96);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 16;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.invoicecouch1;
            pictureBox1.Location = new Point(0, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(195, 91);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(500, 40);
            label7.Name = "label7";
            label7.Size = new Size(236, 34);
            label7.TabIndex = 14;
            label7.Text = "Please capture your details below to \r\n              generate your invoice";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.DarkGreen;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(15, 133);
            label3.Name = "label3";
            label3.Size = new Size(151, 20);
            label3.TabIndex = 8;
            label3.Text = "CUSTOMER DETAILS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.DarkGreen;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(174, 20);
            label2.TabIndex = 9;
            label2.Text = "INVOICE PREVIEW         ";
            label2.Click += label2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.DarkGreen;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(15, 359);
            label4.Name = "label4";
            label4.Size = new Size(166, 20);
            label4.TabIndex = 10;
            label4.Text = "INSTRUCTIONS            ";
            label4.Click += label4_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Controls.Add(label5);
            panel2.Location = new Point(15, 382);
            panel2.Name = "panel2";
            panel2.Size = new Size(327, 212);
            panel2.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.WhiteSmoke;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(3, 11);
            label5.Name = "label5";
            label5.Size = new Size(303, 180);
            label5.TabIndex = 0;
            label5.Text = "✓ All fields are required\r\n\r\n✓ Enter a valid email address\r\n\r\n✓ Telephone number must contain 10 digits\r\n\r\n✓ ID number must contain 13 digits\r\n\r\n✓ ID number validated using Luhn algorithm";
            // 
            // panel3
            // 
            panel3.BackColor = Color.WhiteSmoke;
            panel3.Controls.Add(txtPhone);
            panel3.Controls.Add(txtID);
            panel3.Controls.Add(txtEmail);
            panel3.Controls.Add(txtName);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label8);
            panel3.Location = new Point(15, 156);
            panel3.Name = "panel3";
            panel3.Size = new Size(327, 187);
            panel3.TabIndex = 12;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(147, 97);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(125, 27);
            txtPhone.TabIndex = 7;
            // 
            // txtID
            // 
            txtID.Location = new Point(147, 142);
            txtID.Name = "txtID";
            txtID.Size = new Size(125, 27);
            txtID.TabIndex = 6;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(147, 58);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(125, 27);
            txtEmail.TabIndex = 5;
            // 
            // txtName
            // 
            txtName.Location = new Point(147, 16);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 4;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(17, 142);
            label11.Name = "label11";
            label11.Size = new Size(85, 20);
            label11.TabIndex = 3;
            label11.Text = "ID Number:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(17, 100);
            label10.Name = "label10";
            label10.Size = new Size(121, 20);
            label10.TabIndex = 2;
            label10.Text = "Contact Number:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(17, 58);
            label9.Name = "label9";
            label9.Size = new Size(106, 20);
            label9.TabIndex = 1;
            label9.Text = "Email Address:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(17, 19);
            label8.Name = "label8";
            label8.Size = new Size(79, 20);
            label8.TabIndex = 0;
            label8.Text = "Full Name:";
            // 
            // btnValidate
            // 
            btnValidate.BackColor = Color.DarkGreen;
            btnValidate.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnValidate.ForeColor = Color.White;
            btnValidate.Location = new Point(12, 609);
            btnValidate.Name = "btnValidate";
            btnValidate.Size = new Size(200, 56);
            btnValidate.TabIndex = 14;
            btnValidate.Text = "VALIDATE AND GENERATE INVOICE";
            btnValidate.UseVisualStyleBackColor = false;
            btnValidate.Click += btnValidate_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.White;
            btnClear.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.Black;
            btnClear.Location = new Point(244, 609);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(98, 56);
            btnClear.TabIndex = 15;
            btnClear.Text = "CLEAR";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.DarkGreen;
            panel5.Controls.Add(label13);
            panel5.Controls.Add(label12);
            panel5.Location = new Point(1, 687);
            panel5.Name = "panel5";
            panel5.Size = new Size(980, 37);
            panel5.TabIndex = 16;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.WhiteSmoke;
            label12.Location = new Point(11, 11);
            label12.Name = "label12";
            label12.Size = new Size(454, 17);
            label12.TabIndex = 0;
            label12.Text = "! Your information is secure and will only be used to process your order.";
            // 
            // grpInvoice
            // 
            grpInvoice.Controls.Add(txtInvoice);
            grpInvoice.Controls.Add(label2);
            grpInvoice.Location = new Point(364, 133);
            grpInvoice.Name = "grpInvoice";
            grpInvoice.Size = new Size(593, 541);
            grpInvoice.TabIndex = 17;
            grpInvoice.TabStop = false;
            grpInvoice.Text = "INVOICE PREVIEW";
            // 
            // txtInvoice
            // 
            txtInvoice.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtInvoice.Location = new Point(25, 26);
            txtInvoice.Multiline = true;
            txtInvoice.Name = "txtInvoice";
            txtInvoice.ReadOnly = true;
            txtInvoice.ScrollBars = ScrollBars.Vertical;
            txtInvoice.Size = new Size(548, 492);
            txtInvoice.TabIndex = 10;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { homeToolStripMenuItem, catalogueToolStripMenuItem, aboutToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(981, 28);
            menuStrip1.TabIndex = 18;
            menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            homeToolStripMenuItem.Size = new Size(64, 24);
            homeToolStripMenuItem.Text = "Home";
            homeToolStripMenuItem.Click += homeToolStripMenuItem_Click;
            // 
            // catalogueToolStripMenuItem
            // 
            catalogueToolStripMenuItem.Name = "catalogueToolStripMenuItem";
            catalogueToolStripMenuItem.Size = new Size(91, 24);
            catalogueToolStripMenuItem.Text = "Catalogue";
            catalogueToolStripMenuItem.Click += catalogueToolStripMenuItem_Click;
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(64, 24);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.DarkGreen;
            label13.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.White;
            label13.Location = new Point(831, 11);
            label13.Name = "label13";
            label13.Size = new Size(137, 17);
            label13.TabIndex = 19;
            label13.Text = "-- MT Orrie 23498498";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FloralWhite;
            ClientSize = new Size(981, 723);
            Controls.Add(grpInvoice);
            Controls.Add(panel5);
            Controls.Add(btnClear);
            Controls.Add(btnValidate);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Couch Potato - Customer Details & Invoice";
            Load += Form3_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            grpInvoice.ResumeLayout(false);
            grpInvoice.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label6;
        private Label label1;
        private Label label7;
        private Label label3;
        private Label label2;
        private Label label4;
        private Panel panel2;
        private Panel panel3;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private TextBox txtPhone;
        private TextBox txtID;
        private TextBox txtEmail;
        private TextBox txtName;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Button btnValidate;
        private Button btnClear;
        private Panel panel5;
        private Label label5;
        private GroupBox grpInvoice;
        private TextBox txtInvoice;
        private Label label12;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem homeToolStripMenuItem;
        private ToolStripMenuItem catalogueToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private Label label13;
    }
}