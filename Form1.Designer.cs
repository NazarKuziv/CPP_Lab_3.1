namespace CPP_Lab_3._1
{
    partial class Form1
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
            this.Message_tBox = new System.Windows.Forms.TextBox();
            this.Send_button = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Message_tBox
            // 
            this.Message_tBox.Location = new System.Drawing.Point(12, 12);
            this.Message_tBox.Multiline = true;
            this.Message_tBox.Name = "Message_tBox";
            this.Message_tBox.Size = new System.Drawing.Size(560, 135);
            this.Message_tBox.TabIndex = 0;
            // 
            // Send_button
            // 
            this.Send_button.Location = new System.Drawing.Point(442, 153);
            this.Send_button.Name = "Send_button";
            this.Send_button.Size = new System.Drawing.Size(130, 28);
            this.Send_button.TabIndex = 1;
            this.Send_button.Text = "Надіслати";
            this.Send_button.UseVisualStyleBackColor = true;
            this.Send_button.Click += new System.EventHandler(this.Send_button_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(13, 192);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(51, 20);
            this.label.TabIndex = 2;
            this.label.Text = "Мітка";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 261);
            this.Controls.Add(this.label);
            this.Controls.Add(this.Send_button);
            this.Controls.Add(this.Message_tBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Клієнт";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Message_tBox;
        private System.Windows.Forms.Button Send_button;
        private System.Windows.Forms.Label label;
    }
}

