namespace VariablesAndLoops
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
            this.userNameLabel = new System.Windows.Forms.Label();
            this.repeatCountLabel = new System.Windows.Forms.Label();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.repeatCountTextBox = new System.Windows.Forms.TextBox();
            this.initialiseVariablesButton = new System.Windows.Forms.Button();
            this.sayHelloButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Location = new System.Drawing.Point(12, 19);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(61, 13);
            this.userNameLabel.TabIndex = 0;
            this.userNameLabel.Text = "User name:";
            // 
            // repeatCountLabel
            // 
            this.repeatCountLabel.AutoSize = true;
            this.repeatCountLabel.Location = new System.Drawing.Point(12, 51);
            this.repeatCountLabel.Name = "repeatCountLabel";
            this.repeatCountLabel.Size = new System.Drawing.Size(75, 13);
            this.repeatCountLabel.TabIndex = 1;
            this.repeatCountLabel.Text = "Repeat count:";
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Location = new System.Drawing.Point(86, 16);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(137, 20);
            this.userNameTextBox.TabIndex = 2;
            // 
            // repeatCountTextBox
            // 
            this.repeatCountTextBox.Location = new System.Drawing.Point(86, 48);
            this.repeatCountTextBox.Name = "repeatCountTextBox";
            this.repeatCountTextBox.Size = new System.Drawing.Size(137, 20);
            this.repeatCountTextBox.TabIndex = 3;
            // 
            // initialiseVariablesButton
            // 
            this.initialiseVariablesButton.Location = new System.Drawing.Point(15, 83);
            this.initialiseVariablesButton.Name = "initialiseVariablesButton";
            this.initialiseVariablesButton.Size = new System.Drawing.Size(107, 23);
            this.initialiseVariablesButton.TabIndex = 4;
            this.initialiseVariablesButton.Text = "Set up variables";
            this.initialiseVariablesButton.UseVisualStyleBackColor = true;
            // 
            // sayHelloButton
            // 
            this.sayHelloButton.Location = new System.Drawing.Point(148, 83);
            this.sayHelloButton.Name = "sayHelloButton";
            this.sayHelloButton.Size = new System.Drawing.Size(75, 23);
            this.sayHelloButton.TabIndex = 5;
            this.sayHelloButton.Text = "Say Hello";
            this.sayHelloButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 127);
            this.Controls.Add(this.sayHelloButton);
            this.Controls.Add(this.initialiseVariablesButton);
            this.Controls.Add(this.repeatCountTextBox);
            this.Controls.Add(this.userNameTextBox);
            this.Controls.Add(this.repeatCountLabel);
            this.Controls.Add(this.userNameLabel);
            this.Name = "Form1";
            this.Text = "Say Hello";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Label repeatCountLabel;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.TextBox repeatCountTextBox;
        private System.Windows.Forms.Button initialiseVariablesButton;
        private System.Windows.Forms.Button sayHelloButton;
    }
}

