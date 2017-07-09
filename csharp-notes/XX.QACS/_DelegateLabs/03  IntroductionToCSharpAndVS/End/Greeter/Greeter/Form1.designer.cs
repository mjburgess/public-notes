namespace Greeter
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
            this.buttonGreet = new System.Windows.Forms.Button();
            this.buttonDate = new System.Windows.Forms.Button();
            this.textboxDate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonGreet
            // 
            this.buttonGreet.Location = new System.Drawing.Point(29, 34);
            this.buttonGreet.Name = "buttonGreet";
            this.buttonGreet.Size = new System.Drawing.Size(93, 29);
            this.buttonGreet.TabIndex = 0;
            this.buttonGreet.Text = "Greet";
            this.buttonGreet.UseVisualStyleBackColor = true;
            this.buttonGreet.Click += new System.EventHandler(this.buttonGreet_Click);
            // 
            // buttonDate
            // 
            this.buttonDate.Location = new System.Drawing.Point(29, 89);
            this.buttonDate.Name = "buttonDate";
            this.buttonDate.Size = new System.Drawing.Size(92, 26);
            this.buttonDate.TabIndex = 1;
            this.buttonDate.Text = "Get date";
            this.buttonDate.UseVisualStyleBackColor = true;
            this.buttonDate.Click += new System.EventHandler(this.buttonDate_Click);
            // 
            // textboxDate
            // 
            this.textboxDate.Location = new System.Drawing.Point(148, 93);
            this.textboxDate.Name = "textboxDate";
            this.textboxDate.Size = new System.Drawing.Size(138, 20);
            this.textboxDate.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 261);
            this.Controls.Add(this.textboxDate);
            this.Controls.Add(this.buttonDate);
            this.Controls.Add(this.buttonGreet);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Greeter";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGreet;
        private System.Windows.Forms.Button buttonDate;
        private System.Windows.Forms.TextBox textboxDate;
    }
}

