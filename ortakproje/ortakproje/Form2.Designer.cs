namespace ortakproje
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
            label3 = new Label();
            comboBox2 = new ComboBox();
            label1 = new Label();
            comboBox1 = new ComboBox();
            button1 = new Button();
            numericUpDown1 = new NumericUpDown();
            label2 = new Label();
            groupBox2 = new GroupBox();
            label4 = new Label();
            button3 = new Button();
            button2 = new Button();
            listBox1 = new ListBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(numericUpDown1);
            groupBox1.Location = new Point(149, 63);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(362, 245);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ürün Listesi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 130);
            label3.Name = "label3";
            label3.Size = new Size(91, 20);
            label3.TabIndex = 6;
            label3.Text = "Ürün fiyatı =";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(22, 87);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(300, 28);
            comboBox2.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(110, 130);
            label1.Name = "label1";
            label1.Size = new Size(17, 20);
            label1.TabIndex = 4;
            label1.Text = "0";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(22, 43);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(300, 28);
            comboBox1.TabIndex = 3;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(159, 173);
            button1.Name = "button1";
            button1.Size = new Size(163, 29);
            button1.TabIndex = 2;
            button1.Text = "Sepete Ekle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(22, 175);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(50, 27);
            numericUpDown1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(158, 430);
            label2.Name = "label2";
            label2.Size = new Size(17, 20);
            label2.TabIndex = 6;
            label2.Text = "0";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(listBox1);
            groupBox2.Location = new Point(677, 63);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(291, 477);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Sepet";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(38, 430);
            label4.Name = "label4";
            label4.Size = new Size(103, 20);
            label4.TabIndex = 7;
            label4.Text = "Sepet Tutarı =";
            // 
            // button3
            // 
            button3.Location = new Point(25, 368);
            button3.Name = "button3";
            button3.Size = new Size(245, 29);
            button3.TabIndex = 2;
            button3.Text = "Sil";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(25, 333);
            button2.Name = "button2";
            button2.Size = new Size(245, 29);
            button2.TabIndex = 1;
            button2.Text = "Siparişi Onayla";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(25, 43);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(247, 284);
            listBox1.TabIndex = 0;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1022, 552);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form2";
            Text = "Ürünler ve Sepet";
            Load += Form2_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button button1;
        private NumericUpDown numericUpDown1;
        private GroupBox groupBox2;
        private Button button2;
        private ListBox listBox1;
        private Button button3;
        private ComboBox comboBox1;
        private Label label1;
        private ComboBox comboBox2;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}