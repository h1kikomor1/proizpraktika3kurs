
namespace WindowsFormsApp1
{
    partial class sign_in
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.sign_in_button = new System.Windows.Forms.Button();
            this.kod_textBox = new System.Windows.Forms.TextBox();
            this.kod_label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // sign_in_button
            // 
            this.sign_in_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sign_in_button.Location = new System.Drawing.Point(305, 285);
            this.sign_in_button.Name = "sign_in_button";
            this.sign_in_button.Size = new System.Drawing.Size(155, 43);
            this.sign_in_button.TabIndex = 0;
            this.sign_in_button.Text = "Войти";
            this.sign_in_button.UseVisualStyleBackColor = true;
            this.sign_in_button.Click += new System.EventHandler(this.sign_in_button_Click);
            // 
            // kod_textBox
            // 
            this.kod_textBox.Location = new System.Drawing.Point(250, 222);
            this.kod_textBox.Multiline = true;
            this.kod_textBox.Name = "kod_textBox";
            this.kod_textBox.Size = new System.Drawing.Size(295, 32);
            this.kod_textBox.TabIndex = 1;
            // 
            // kod_label
            // 
            this.kod_label.AutoSize = true;
            this.kod_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kod_label.Location = new System.Drawing.Point(193, 234);
            this.kod_label.Name = "kod_label";
            this.kod_label.Size = new System.Drawing.Size(42, 20);
            this.kod_label.TabIndex = 3;
            this.kod_label.Text = "Код";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(300, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Авторизация";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(164, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(423, 39);
            this.label1.TabIndex = 6;
            this.label1.Text = "Терминал общего отдела";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.User1;
            this.pictureBox1.Location = new System.Drawing.Point(27, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 141);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // sign_in
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 375);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.kod_label);
            this.Controls.Add(this.kod_textBox);
            this.Controls.Add(this.sign_in_button);
            this.Name = "sign_in";
            this.Text = "Авторизация";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sign_in_button;
        private System.Windows.Forms.TextBox kod_textBox;
        private System.Windows.Forms.Label kod_label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

