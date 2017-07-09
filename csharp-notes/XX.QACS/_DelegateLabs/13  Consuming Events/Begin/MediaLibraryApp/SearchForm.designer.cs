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
            this.chkUseQueryExpression = new System.Windows.Forms.CheckBox();
            this.btnFindByDuration = new System.Windows.Forms.Button();
            this.btnFBTOrderByDuration = new System.Windows.Forms.Button();
            this.btnFBTOrderByDesc = new System.Windows.Forms.Button();
            this.btnFindByTitle = new System.Windows.Forms.Button();
            this.btnFindByType = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Location = new System.Drawing.Point(10, 15);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(64, 13);
            this.searchLabel.TabIndex = 0;
            this.searchLabel.Text = "Search text:";
            // 
            // searchStringTextBox
            // 
            this.searchStringTextBox.Location = new System.Drawing.Point(80, 12);
            this.searchStringTextBox.Name = "searchStringTextBox";
            this.searchStringTextBox.Size = new System.Drawing.Size(260, 20);
            this.searchStringTextBox.TabIndex = 1;
            // 
            // allItemsListBox
            // 
            this.allItemsListBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.allItemsListBox.FormattingEnabled = true;
            this.allItemsListBox.Location = new System.Drawing.Point(0, 153);
            this.allItemsListBox.Name = "allItemsListBox";
            this.allItemsListBox.Size = new System.Drawing.Size(361, 108);
            this.allItemsListBox.TabIndex = 11;
            // 
            // btnForEach
            // 
            this.btnForEach.Location = new System.Drawing.Point(13, 47);
            this.btnForEach.Name = "btnForEach";
            this.btnForEach.Size = new System.Drawing.Size(105, 23);
            this.btnForEach.TabIndex = 2;
            this.btnForEach.Text = "Find by For Each";
            this.btnForEach.UseVisualStyleBackColor = true;
            this.btnForEach.Click += new System.EventHandler(this.btnForEach_Click);
            // 
            // btnDelegate
            // 
            this.btnDelegate.Location = new System.Drawing.Point(13, 76);
            this.btnDelegate.Name = "btnDelegate";
            this.btnDelegate.Size = new System.Drawing.Size(105, 23);
            this.btnDelegate.TabIndex = 3;
            this.btnDelegate.Text = "Find by Delegate";
            this.btnDelegate.UseVisualStyleBackColor = true;
            this.btnDelegate.Click += new System.EventHandler(this.btnDelegate_Click);
            // 
            // btnLambda
            // 
            this.btnLambda.Location = new System.Drawing.Point(13, 105);
            this.btnLambda.Name = "btnLambda";
            this.btnLambda.Size = new System.Drawing.Size(105, 23);
            this.btnLambda.TabIndex = 4;
            this.btnLambda.Text = "Find by Lambda";
            this.btnLambda.UseVisualStyleBackColor = true;
            this.btnLambda.Click += new System.EventHandler(this.btnLambda_Click);
            // 
            // chkUseQueryExpression
            // 
            this.chkUseQueryExpression.AutoSize = true;
            this.chkUseQueryExpression.Location = new System.Drawing.Point(229, 111);
            this.chkUseQueryExpression.Name = "chkUseQueryExpression";
            this.chkUseQueryExpression.Size = new System.Drawing.Size(130, 17);
            this.chkUseQueryExpression.TabIndex = 22;
            this.chkUseQueryExpression.Text = "Use Query Expression";
            this.chkUseQueryExpression.UseVisualStyleBackColor = true;
            // 
            // btnFindByDuration
            // 
            this.btnFindByDuration.Location = new System.Drawing.Point(124, 105);
            this.btnFindByDuration.Name = "btnFindByDuration";
            this.btnFindByDuration.Size = new System.Drawing.Size(96, 23);
            this.btnFindByDuration.TabIndex = 19;
            this.btnFindByDuration.Text = "Find by Duration";
            this.btnFindByDuration.UseVisualStyleBackColor = true;
            this.btnFindByDuration.Click += new System.EventHandler(this.btnFindByDuration_Click);
            // 
            // btnFBTOrderByDuration
            // 
            this.btnFBTOrderByDuration.Location = new System.Drawing.Point(229, 47);
            this.btnFBTOrderByDuration.Name = "btnFBTOrderByDuration";
            this.btnFBTOrderByDuration.Size = new System.Drawing.Size(125, 23);
            this.btnFBTOrderByDuration.TabIndex = 20;
            this.btnFBTOrderByDuration.Text = "FBT order by duration";
            this.btnFBTOrderByDuration.UseVisualStyleBackColor = true;
            this.btnFBTOrderByDuration.Click += new System.EventHandler(this.btnFBTOrderByDuration_Click);
            // 
            // btnFBTOrderByDesc
            // 
            this.btnFBTOrderByDesc.Location = new System.Drawing.Point(229, 76);
            this.btnFBTOrderByDesc.Name = "btnFBTOrderByDesc";
            this.btnFBTOrderByDesc.Size = new System.Drawing.Size(110, 23);
            this.btnFBTOrderByDesc.TabIndex = 21;
            this.btnFBTOrderByDesc.Text = "FBT orderby desc";
            this.btnFBTOrderByDesc.UseVisualStyleBackColor = true;
            this.btnFBTOrderByDesc.Click += new System.EventHandler(this.btnFBTOrderByDesc_Click);
            // 
            // btnFindByTitle
            // 
            this.btnFindByTitle.Location = new System.Drawing.Point(124, 47);
            this.btnFindByTitle.Name = "btnFindByTitle";
            this.btnFindByTitle.Size = new System.Drawing.Size(99, 23);
            this.btnFindByTitle.TabIndex = 17;
            this.btnFindByTitle.Text = "Find by Title (fbt)";
            this.btnFindByTitle.UseVisualStyleBackColor = true;
            this.btnFindByTitle.Click += new System.EventHandler(this.btnFindByTitle_Click);
            // 
            // btnFindByType
            // 
            this.btnFindByType.Location = new System.Drawing.Point(124, 76);
            this.btnFindByType.Name = "btnFindByType";
            this.btnFindByType.Size = new System.Drawing.Size(86, 23);
            this.btnFindByType.TabIndex = 18;
            this.btnFindByType.Text = "Find by Type";
            this.btnFindByType.UseVisualStyleBackColor = true;
            this.btnFindByType.Click += new System.EventHandler(this.btnFindByType_Click);
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 261);
            this.Controls.Add(this.chkUseQueryExpression);
            this.Controls.Add(this.btnFindByDuration);
            this.Controls.Add(this.btnFBTOrderByDuration);
            this.Controls.Add(this.btnFBTOrderByDesc);
            this.Controls.Add(this.btnFindByTitle);
            this.Controls.Add(this.btnFindByType);
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
        private System.Windows.Forms.CheckBox chkUseQueryExpression;
        private System.Windows.Forms.Button btnFindByDuration;
        private System.Windows.Forms.Button btnFBTOrderByDuration;
        private System.Windows.Forms.Button btnFBTOrderByDesc;
        private System.Windows.Forms.Button btnFindByTitle;
        private System.Windows.Forms.Button btnFindByType;
    }
}