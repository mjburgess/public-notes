namespace WindowsFormsApplication1
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
            this.chkUseQueryExpression = new System.Windows.Forms.CheckBox();
            this.btnFindByDuration = new System.Windows.Forms.Button();
            this.btnFBTOrderByDuration = new System.Windows.Forms.Button();
            this.btnFBTOrderByDesc = new System.Windows.Forms.Button();
            this.btnFindByTitle = new System.Windows.Forms.Button();
            this.btnFindByType = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chkUseQueryExpression
            // 
            this.chkUseQueryExpression.AutoSize = true;
            this.chkUseQueryExpression.Location = new System.Drawing.Point(127, 88);
            this.chkUseQueryExpression.Name = "chkUseQueryExpression";
            this.chkUseQueryExpression.Size = new System.Drawing.Size(130, 17);
            this.chkUseQueryExpression.TabIndex = 16;
            this.chkUseQueryExpression.Text = "Use Query Expression";
            this.chkUseQueryExpression.UseVisualStyleBackColor = true;
            // 
            // btnFindByDuration
            // 
            this.btnFindByDuration.Location = new System.Drawing.Point(22, 82);
            this.btnFindByDuration.Name = "btnFindByDuration";
            this.btnFindByDuration.Size = new System.Drawing.Size(96, 23);
            this.btnFindByDuration.TabIndex = 13;
            this.btnFindByDuration.Text = "Find by Duration";
            this.btnFindByDuration.UseVisualStyleBackColor = true;
            // 
            // btnFBTOrderByDuration
            // 
            this.btnFBTOrderByDuration.Location = new System.Drawing.Point(127, 24);
            this.btnFBTOrderByDuration.Name = "btnFBTOrderByDuration";
            this.btnFBTOrderByDuration.Size = new System.Drawing.Size(125, 23);
            this.btnFBTOrderByDuration.TabIndex = 14;
            this.btnFBTOrderByDuration.Text = "FBT order by duration";
            this.btnFBTOrderByDuration.UseVisualStyleBackColor = true;
            // 
            // btnFBTOrderByDesc
            // 
            this.btnFBTOrderByDesc.Location = new System.Drawing.Point(127, 53);
            this.btnFBTOrderByDesc.Name = "btnFBTOrderByDesc";
            this.btnFBTOrderByDesc.Size = new System.Drawing.Size(110, 23);
            this.btnFBTOrderByDesc.TabIndex = 15;
            this.btnFBTOrderByDesc.Text = "FBT orderby desc";
            this.btnFBTOrderByDesc.UseVisualStyleBackColor = true;
            // 
            // btnFindByTitle
            // 
            this.btnFindByTitle.Location = new System.Drawing.Point(22, 24);
            this.btnFindByTitle.Name = "btnFindByTitle";
            this.btnFindByTitle.Size = new System.Drawing.Size(99, 23);
            this.btnFindByTitle.TabIndex = 11;
            this.btnFindByTitle.Text = "Find by Title (fbt)";
            this.btnFindByTitle.UseVisualStyleBackColor = true;
            // 
            // btnFindByType
            // 
            this.btnFindByType.Location = new System.Drawing.Point(22, 53);
            this.btnFindByType.Name = "btnFindByType";
            this.btnFindByType.Size = new System.Drawing.Size(86, 23);
            this.btnFindByType.TabIndex = 12;
            this.btnFindByType.Text = "Find by Type";
            this.btnFindByType.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 123);
            this.Controls.Add(this.chkUseQueryExpression);
            this.Controls.Add(this.btnFindByDuration);
            this.Controls.Add(this.btnFBTOrderByDuration);
            this.Controls.Add(this.btnFBTOrderByDesc);
            this.Controls.Add(this.btnFindByTitle);
            this.Controls.Add(this.btnFindByType);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkUseQueryExpression;
        private System.Windows.Forms.Button btnFindByDuration;
        private System.Windows.Forms.Button btnFBTOrderByDuration;
        private System.Windows.Forms.Button btnFBTOrderByDesc;
        private System.Windows.Forms.Button btnFindByTitle;
        private System.Windows.Forms.Button btnFindByType;
    }
}

