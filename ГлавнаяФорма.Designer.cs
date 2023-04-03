
namespace WindowsFormsApp1
{
    partial class ГлавнаяФорма
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
            this.private_button = new System.Windows.Forms.Button();
            this.group_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // private_button
            // 
            this.private_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.private_button.Location = new System.Drawing.Point(68, 146);
            this.private_button.Name = "private_button";
            this.private_button.Size = new System.Drawing.Size(185, 193);
            this.private_button.TabIndex = 0;
            this.private_button.Text = "Личное посещение";
            this.private_button.UseVisualStyleBackColor = true;
            this.private_button.Click += new System.EventHandler(this.private_button_Click);
            // 
            // group_button
            // 
            this.group_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.group_button.Location = new System.Drawing.Point(372, 146);
            this.group_button.Name = "group_button";
            this.group_button.Size = new System.Drawing.Size(185, 193);
            this.group_button.TabIndex = 1;
            this.group_button.Text = "Групповое посещение";
            this.group_button.UseVisualStyleBackColor = true;
            this.group_button.Click += new System.EventHandler(this.group_button_Click);
            // 
            // ГлавнаяФорма
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 432);
            this.Controls.Add(this.group_button);
            this.Controls.Add(this.private_button);
            this.Name = "ГлавнаяФорма";
            this.Text = "ГлавнаяФорма";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button private_button;
        private System.Windows.Forms.Button group_button;
    }
}