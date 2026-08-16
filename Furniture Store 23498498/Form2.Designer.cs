namespace _23498498
{
    partial class Form2
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
            groupBox1 = new GroupBox();
            radioButton4 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            label1 = new Label();
            checkedListBox1 = new CheckedListBox();
            comboBox1 = new ComboBox();
            monthCalendar1 = new MonthCalendar();
            btnCalc = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            txtTotal = new TextBox();
            label2 = new Label();
            menuStrip1 = new MenuStrip();
            homeToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton4);
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(357, 235);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(245, 160);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Delivery Options";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.ForeColor = Color.Black;
            radioButton4.Location = new Point(19, 122);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(206, 27);
            radioButton4.TabIndex = 3;
            radioButton4.TabStop = true;
            radioButton4.Text = "Express Delivery - R300";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.ForeColor = Color.Black;
            radioButton3.Location = new Point(19, 92);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(216, 27);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.Text = "Regional Delivery - R500";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.ForeColor = Color.Black;
            radioButton2.Location = new Point(19, 62);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(189, 27);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Local Delivery - R150";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.ForeColor = Color.Black;
            radioButton1.Location = new Point(19, 32);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(161, 27);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Store Pickup - R0";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(331, 116);
            label1.Name = "label1";
            label1.Size = new Size(328, 46);
            label1.TabIndex = 1;
            label1.Text = "Choose your furniture, delivery option, \r\n         payment method and date:";
            // 
            // checkedListBox1
            // 
            checkedListBox1.CheckOnClick = true;
            checkedListBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "Oak Coffee Table - R900", "Vintage Desk - R1500", "Bookshelf Unit - R800", "Dining Chair - R550", "Fabric Sofa - R2200", "TV Stand - R700", "Rustic Bed Frame - R2000", "Side Table - R500", "Mirror Console - R1100", "Patio Bench - R1200", "Chest of Drawers - R1850" });
            checkedListBox1.Location = new Point(86, 261);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(225, 279);
            checkedListBox1.TabIndex = 2;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Cash", "Credit Card", "EFT", "PayPal" });
            comboBox1.Location = new Point(355, 444);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(245, 28);
            comboBox1.TabIndex = 3;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            monthCalendar1.Location = new Point(642, 261);
            monthCalendar1.MaxSelectionCount = 1;
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 4;
            monthCalendar1.DateChanged += monthCalendar1_DateChanged;
            // 
            // btnCalc
            // 
            btnCalc.BackColor = Color.DarkGreen;
            btnCalc.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalc.ForeColor = Color.White;
            btnCalc.Location = new Point(355, 497);
            btnCalc.Name = "btnCalc";
            btnCalc.Size = new Size(245, 44);
            btnCalc.TabIndex = 5;
            btnCalc.Text = "CALCULATE TOTAL";
            btnCalc.UseVisualStyleBackColor = false;
            btnCalc.Click += btnCalc_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.DarkGreen;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(86, 235);
            label3.Name = "label3";
            label3.Size = new Size(225, 23);
            label3.TabIndex = 7;
            label3.Text = "SELECT FURNITURE            ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.DarkGreen;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(355, 418);
            label4.Name = "label4";
            label4.Size = new Size(247, 23);
            label4.TabIndex = 8;
            label4.Text = "PAYMENT METHOD                ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.DarkGreen;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(643, 235);
            label5.Name = "label5";
            label5.Size = new Size(263, 23);
            label5.TabIndex = 9;
            label5.Text = "SELECT DELIVERY DATE             ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.DarkGreen;
            label6.Location = new Point(273, 48);
            label6.Name = "label6";
            label6.Size = new Size(442, 50);
            label6.TabIndex = 10;
            label6.Text = "Couch Potato Catalogue";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.DarkGreen;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(816, 7);
            label7.Name = "label7";
            label7.Size = new Size(163, 20);
            label7.TabIndex = 11;
            label7.Text = "-- MT Orrie 23498498";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.DarkGreen;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(3, 7);
            label8.Name = "label8";
            label8.Size = new Size(552, 20);
            label8.TabIndex = 12;
            label8.Text = "Thank you for supporting sustainable living and choosing pre-loved furniture.";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(3, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(240, 181);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.cataloguecouch;
            pictureBox2.Location = new Point(746, 27);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(236, 181);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 14;
            pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkGreen;
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label8);
            panel1.ForeColor = Color.DarkGreen;
            panel1.Location = new Point(0, 567);
            panel1.Name = "panel1";
            panel1.Size = new Size(982, 36);
            panel1.TabIndex = 15;
            // 
            // txtTotal
            // 
            txtTotal.BackColor = Color.White;
            txtTotal.Enabled = false;
            txtTotal.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTotal.ForeColor = Color.DarkGreen;
            txtTotal.Location = new Point(643, 497);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(262, 43);
            txtTotal.TabIndex = 16;
            txtTotal.Text = "Total: R0";
            txtTotal.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Impact", 52.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkOliveGreen;
            label2.Location = new Point(198, 211);
            label2.Name = "label2";
            label2.Size = new Size(0, 106);
            label2.TabIndex = 17;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { homeToolStripMenuItem, aboutToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(982, 28);
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
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(64, 24);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FloralWhite;
            ClientSize = new Size(982, 603);
            Controls.Add(label2);
            Controls.Add(txtTotal);
            Controls.Add(panel1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnCalc);
            Controls.Add(monthCalendar1);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(checkedListBox1);
            Controls.Add(menuStrip1);
            ForeColor = Color.FloralWhite;
            MainMenuStrip = menuStrip1;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Couch Potato - Catalogue";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label label1;
        private CheckedListBox checkedListBox1;
        private ComboBox comboBox1;
        private MonthCalendar monthCalendar1;
        private Button btnCalc;
        private RadioButton radioButton4;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Panel panel1;
        private TextBox txtTotal;
        private Label label2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem homeToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
    }
}