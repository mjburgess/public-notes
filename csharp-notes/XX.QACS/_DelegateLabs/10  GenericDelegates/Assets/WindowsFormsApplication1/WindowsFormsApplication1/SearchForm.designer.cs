namespace MediaLibraryApp
{
    partial class SearchForm
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
            this.searchLabel = new System.Windows.Forms.Label();
            this.searchStringTextBox = new System.Windows.Forms.TextBox();
            this.allItemsListBox = new System.Windows.Forms.ListBox();
            this.btnForEach = new System.Windows.Forms.Button();
            this.btnDelegate = new System.Windows.Forms.Button();
            this.btnLambda = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Location = new System.Drawing.Point(10, 15);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(64, 13);
            this.searchLabel.TabIndex = 3;
            this.searchLabel.Text = "Search text:";
            // 
            // searchStringTextBox
            // 
            this.searchStringTextBox.Location = new System.Drawing.Point(80, 12);
            this.searchStringTextBox.Name = "searchStringTextBox";
            this.searchStringTextBox.Size = new System.Drawing.Size(260, 20);
            this.searchStringTextBox.TabIndex = 2;
            // 
            // allItemsListBox
            // 
            this.allItemsListBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.allItemsListBox.FormattingEnabled = true;
            this.allItemsListBox.Location = new System.Drawing.Point(0, 153);
            this.allItemsListBox.Name = "allItemsListBox";
            this.allItemsListBox.Size = new System.Drawing.Size(361, 108);
            this.allItemsListBox.TabIndex = 24;
            // 
            // btnForEach
            // 
            this.btnForEach.Location = new System.Drawing.Point(13, 47);
            this.btnForEach.Name = "btnForEach";
            this.btnForEach.Size = new System.Drawing.Size(105, 23);
            this.btnForEach.TabIndex = 25;
            this.btnForEach.Text = "Find by For Each";
            this.btnForEach.UseVisualStyleBackColor = true;
            // 
            // btnDelegate
            // 
            this.btnDelegate.Location = new System.Drawing.Point(13, 76);
            this.btnDelegate.Name = "btnDelegate";
            this.btnDelegate.Size = new System.Drawing.Size(105, 23);
            this.btnDelegate.TabIndex = 26;
            this.btnDelegate.Text = "Find by Delegate";
            this.btnDelegate.UseVisualStyleBackColor = true;
            // 
            // btnLambda
            // 
            this.btnLambda.Location = new System.Drawing.Point(13, 105);
            this.btnLambda.Name = "btnLambda";
            this.btnLambda.Size = new System.Drawing.Size(105, 23);
            this.btnLambda.TabIndex = 27;
            this.btnLambda.Text = "Find by Lambda";
            this.btnLambda.UseVisualStyleBackColor = true;
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 261);
            this.Controls.Add(this.btnLambda);
            this.Controls.Add(this.btnDelegate);
            this.Controls.Add(this.btnForEach);
            this.Controls.Add(this.allItemsListBox);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.searchStringTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "SearchForm";
            this.ShowInTaskbar = false;
            this.Text = "Search Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.TextBox searchStringTextBox;
        private System.Windows.Forms.ListBox allItemsListBox;
        private System.Windows.Forms.Button btnForEach;
        private System.Windows.Forms.Button btnDelegate;
        private System.Windows.Forms.Button btnLambda;
    }
}