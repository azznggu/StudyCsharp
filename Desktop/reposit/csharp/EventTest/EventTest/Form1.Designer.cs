namespace EventTest
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
            this.textBox_write = new System.Windows.Forms.TextBox();
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_write
            // 
            this.textBox_write.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_write.Location = new System.Drawing.Point(12, 45);
            this.textBox_write.Multiline = true;
            this.textBox_write.Name = "textBox_write";
            this.textBox_write.Size = new System.Drawing.Size(317, 159);
            this.textBox_write.TabIndex = 0;
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(12, 227);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(75, 23);
            this.btn_start.TabIndex = 1;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(113, 227);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 23);
            this.btn_clear.TabIndex = 2;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 262);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.textBox_write);
            this.Name = "Form1";
            this.Text = "TestForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_write;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_clear;
    }
}

