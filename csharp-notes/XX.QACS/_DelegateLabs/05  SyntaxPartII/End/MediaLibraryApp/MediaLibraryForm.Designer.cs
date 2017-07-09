namespace MediaLibraryApp
{
    partial class MediaLibraryForm
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
            this.btnAddMedia = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtArtist = new System.Windows.Forms.TextBox();
            this.cboMediaType = new System.Windows.Forms.ComboBox();
            this.lstItems = new System.Windows.Forms.ListBox();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboRating = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddMedia
            // 
            this.btnAddMedia.Location = new System.Drawing.Point(289, 36);
            this.btnAddMedia.Name = "btnAddMedia";
            this.btnAddMedia.Size = new System.Drawing.Size(113, 23);
            this.btnAddMedia.TabIndex = 10;
            this.btnAddMedia.Text = "Create Media Item";
            this.btnAddMedia.UseVisualStyleBackColor = true;
            this.btnAddMedia.Click += new System.EventHandler(this.btnAddMedia_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Artist:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Type:";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(86, 13);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(121, 20);
            this.txtTitle.TabIndex = 1;
            // 
            // txtArtist
            // 
            this.txtArtist.Location = new System.Drawing.Point(86, 39);
            this.txtArtist.Name = "txtArtist";
            this.txtArtist.Size = new System.Drawing.Size(121, 20);
            this.txtArtist.TabIndex = 3;
            // 
            // cboMediaType
            // 
            this.cboMediaType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMediaType.FormattingEnabled = true;
            this.cboMediaType.Items.AddRange(new object[] {
            "Song",
            "Movie"});
            this.cboMediaType.Location = new System.Drawing.Point(86, 92);
            this.cboMediaType.Name = "cboMediaType";
            this.cboMediaType.Size = new System.Drawing.Size(121, 21);
            this.cboMediaType.TabIndex = 7;
            // 
            // lstItems
            // 
            this.lstItems.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lstItems.FormattingEnabled = true;
            this.lstItems.Location = new System.Drawing.Point(0, 184);
            this.lstItems.Name = "lstItems";
            this.lstItems.Size = new System.Drawing.Size(417, 121);
            this.lstItems.TabIndex = 12;
            // 
            // txtDuration
            // 
            this.txtDuration.Location = new System.Drawing.Point(86, 65);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(121, 20);
            this.txtDuration.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Duration:";
            // 
            // cboRating
            // 
            this.cboRating.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRating.FormattingEnabled = true;
            this.cboRating.Items.AddRange(new object[] {
            "[select a rating]",
            "Rubbish",
            "SoSo",
            "Mediocre",
            "Good",
            "Fantastic"});
            this.cboRating.Location = new System.Drawing.Point(86, 121);
            this.cboRating.Name = "cboRating";
            this.cboRating.Size = new System.Drawing.Size(121, 21);
            this.cboRating.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Rating:";
            // 
            // MediaLibraryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 305);
            this.Controls.Add(this.txtDuration);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cboRating);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lstItems);
            this.Controls.Add(this.cboMediaType);
            this.Controls.Add(this.txtArtist);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddMedia);
            this.Name = "MediaLibraryForm";
            this.Text = "Media Library";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddMedia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtArtist;
        private System.Windows.Forms.ComboBox cboMediaType;
        private System.Windows.Forms.ListBox lstItems;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboRating;
        private System.Windows.Forms.Label label4;
    }
}

