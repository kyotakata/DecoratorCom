namespace DecoratorCom
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.XORCheckBox = new System.Windows.Forms.CheckBox();
            this.ZipCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(22, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(305, 47);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(22, 130);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(214, 56);
            this.button1.TabIndex = 1;
            this.button1.Text = "measure";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 41;
            this.listBox1.Location = new System.Drawing.Point(22, 236);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(357, 209);
            this.listBox1.TabIndex = 2;
            // 
            // XORCheckBox
            // 
            this.XORCheckBox.AutoSize = true;
            this.XORCheckBox.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.XORCheckBox.Location = new System.Drawing.Point(365, 30);
            this.XORCheckBox.Name = "XORCheckBox";
            this.XORCheckBox.Size = new System.Drawing.Size(130, 45);
            this.XORCheckBox.TabIndex = 3;
            this.XORCheckBox.Text = "暗号化";
            this.XORCheckBox.UseVisualStyleBackColor = true;
            // 
            // ZipCheckBox
            // 
            this.ZipCheckBox.AutoSize = true;
            this.ZipCheckBox.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ZipCheckBox.Location = new System.Drawing.Point(365, 94);
            this.ZipCheckBox.Name = "ZipCheckBox";
            this.ZipCheckBox.Size = new System.Drawing.Size(100, 45);
            this.ZipCheckBox.TabIndex = 4;
            this.ZipCheckBox.Text = "圧縮";
            this.ZipCheckBox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 488);
            this.Controls.Add(this.ZipCheckBox);
            this.Controls.Add(this.XORCheckBox);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox1;
        private Button button1;
        private ListBox listBox1;
        private CheckBox XORCheckBox;
        private CheckBox ZipCheckBox;
    }
}