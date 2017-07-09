namespace MediaLibraryApp
{
    partial class MainForm
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.artistOrDirectorLabel = new System.Windows.Forms.Label();
            this.ratingLabel = new System.Windows.Forms.Label();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.artistOrDirectorTextBox = new System.Windows.Forms.TextBox();
            this.currentItemDetailsLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ratingTextBox = new System.Windows.Forms.TextBox();
            this.coverImagePictureBox = new System.Windows.Forms.PictureBox();
            this.navigationLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.moveFirstButton = new System.Windows.Forms.Button();
            this.movePreviousButton = new System.Windows.Forms.Button();
            this.moveNextButton = new System.Windows.Forms.Button();
            this.moveLastButton = new System.Windows.Forms.Button();
            this.navigationGroupBox = new System.Windows.Forms.GroupBox();
            this.currentItemDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOpenLibrary = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.currentItemDetailsLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coverImagePictureBox)).BeginInit();
            this.navigationLayoutPanel.SuspendLayout();
            this.navigationGroupBox.SuspendLayout();
            this.currentItemDetailsGroupBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(3, 6);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(30, 13);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Title:";
            // 
            // artistOrDirectorLabel
            // 
            this.artistOrDirectorLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.artistOrDirectorLabel.AutoSize = true;
            this.artistOrDirectorLabel.Location = new System.Drawing.Point(3, 31);
            this.artistOrDirectorLabel.Name = "artistOrDirectorLabel";
            this.artistOrDirectorLabel.Size = new System.Drawing.Size(33, 13);
            this.artistOrDirectorLabel.TabIndex = 2;
            this.artistOrDirectorLabel.Text = "Artist:";
            // 
            // ratingLabel
            // 
            this.ratingLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ratingLabel.AutoSize = true;
            this.ratingLabel.Location = new System.Drawing.Point(3, 56);
            this.ratingLabel.Name = "ratingLabel";
            this.ratingLabel.Size = new System.Drawing.Size(41, 13);
            this.ratingLabel.TabIndex = 8;
            this.ratingLabel.Text = "Rating:";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.titleTextBox.Location = new System.Drawing.Point(50, 3);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(120, 20);
            this.titleTextBox.TabIndex = 1;
            // 
            // artistOrDirectorTextBox
            // 
            this.artistOrDirectorTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.artistOrDirectorTextBox.Location = new System.Drawing.Point(50, 28);
            this.artistOrDirectorTextBox.Name = "artistOrDirectorTextBox";
            this.artistOrDirectorTextBox.Size = new System.Drawing.Size(120, 20);
            this.artistOrDirectorTextBox.TabIndex = 3;
            // 
            // currentItemDetailsLayoutPanel
            // 
            this.currentItemDetailsLayoutPanel.ColumnCount = 3;
            this.currentItemDetailsLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.currentItemDetailsLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.currentItemDetailsLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.currentItemDetailsLayoutPanel.Controls.Add(this.titleLabel, 0, 0);
            this.currentItemDetailsLayoutPanel.Controls.Add(this.titleTextBox, 1, 0);
            this.currentItemDetailsLayoutPanel.Controls.Add(this.ratingLabel, 0, 2);
            this.currentItemDetailsLayoutPanel.Controls.Add(this.artistOrDirectorLabel, 0, 1);
            this.currentItemDetailsLayoutPanel.Controls.Add(this.artistOrDirectorTextBox, 1, 1);
            this.currentItemDetailsLayoutPanel.Controls.Add(this.ratingTextBox, 1, 2);
            this.currentItemDetailsLayoutPanel.Controls.Add(this.coverImagePictureBox, 3, 0);
            this.currentItemDetailsLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.currentItemDetailsLayoutPanel.Location = new System.Drawing.Point(3, 16);
            this.currentItemDetailsLayoutPanel.Margin = new System.Windows.Forms.Padding(10);
            this.currentItemDetailsLayoutPanel.Name = "currentItemDetailsLayoutPanel";
            this.currentItemDetailsLayoutPanel.RowCount = 5;
            this.currentItemDetailsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.currentItemDetailsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.currentItemDetailsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.currentItemDetailsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.currentItemDetailsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.currentItemDetailsLayoutPanel.Size = new System.Drawing.Size(424, 254);
            this.currentItemDetailsLayoutPanel.TabIndex = 0;
            // 
            // ratingTextBox
            // 
            this.ratingTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ratingTextBox.Location = new System.Drawing.Point(50, 53);
            this.ratingTextBox.Name = "ratingTextBox";
            this.ratingTextBox.Size = new System.Drawing.Size(120, 20);
            this.ratingTextBox.TabIndex = 9;
            // 
            // coverImagePictureBox
            // 
            this.coverImagePictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.coverImagePictureBox.Location = new System.Drawing.Point(176, 3);
            this.coverImagePictureBox.Name = "coverImagePictureBox";
            this.currentItemDetailsLayoutPanel.SetRowSpan(this.coverImagePictureBox, 5);
            this.coverImagePictureBox.Size = new System.Drawing.Size(245, 248);
            this.coverImagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.coverImagePictureBox.TabIndex = 10;
            this.coverImagePictureBox.TabStop = false;
            // 
            // navigationLayoutPanel
            // 
            this.navigationLayoutPanel.ColumnCount = 4;
            this.navigationLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.navigationLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.navigationLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.navigationLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.navigationLayoutPanel.Controls.Add(this.moveFirstButton, 0, 0);
            this.navigationLayoutPanel.Controls.Add(this.movePreviousButton, 1, 0);
            this.navigationLayoutPanel.Controls.Add(this.moveNextButton, 2, 0);
            this.navigationLayoutPanel.Controls.Add(this.moveLastButton, 3, 0);
            this.navigationLayoutPanel.Location = new System.Drawing.Point(12, 19);
            this.navigationLayoutPanel.Name = "navigationLayoutPanel";
            this.navigationLayoutPanel.RowCount = 1;
            this.navigationLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.navigationLayoutPanel.Size = new System.Drawing.Size(353, 35);
            this.navigationLayoutPanel.TabIndex = 0;
            // 
            // moveFirstButton
            // 
            this.moveFirstButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.moveFirstButton.Location = new System.Drawing.Point(14, 6);
            this.moveFirstButton.Name = "moveFirstButton";
            this.moveFirstButton.Size = new System.Drawing.Size(60, 23);
            this.moveFirstButton.TabIndex = 0;
            this.moveFirstButton.Text = "First";
            this.moveFirstButton.UseVisualStyleBackColor = true;
            // 
            // movePreviousButton
            // 
            this.movePreviousButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.movePreviousButton.Location = new System.Drawing.Point(102, 6);
            this.movePreviousButton.Name = "movePreviousButton";
            this.movePreviousButton.Size = new System.Drawing.Size(60, 23);
            this.movePreviousButton.TabIndex = 1;
            this.movePreviousButton.Text = "Previous";
            this.movePreviousButton.UseVisualStyleBackColor = true;
            // 
            // moveNextButton
            // 
            this.moveNextButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.moveNextButton.Location = new System.Drawing.Point(190, 6);
            this.moveNextButton.Name = "moveNextButton";
            this.moveNextButton.Size = new System.Drawing.Size(60, 23);
            this.moveNextButton.TabIndex = 2;
            this.moveNextButton.Text = "Next";
            this.moveNextButton.UseVisualStyleBackColor = true;
            // 
            // moveLastButton
            // 
            this.moveLastButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.moveLastButton.Location = new System.Drawing.Point(278, 6);
            this.moveLastButton.Name = "moveLastButton";
            this.moveLastButton.Size = new System.Drawing.Size(60, 23);
            this.moveLastButton.TabIndex = 3;
            this.moveLastButton.Text = "Last";
            this.moveLastButton.UseVisualStyleBackColor = true;
            // 
            // navigationGroupBox
            // 
            this.navigationGroupBox.Controls.Add(this.navigationLayoutPanel);
            this.navigationGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.navigationGroupBox.Location = new System.Drawing.Point(0, 24);
            this.navigationGroupBox.Name = "navigationGroupBox";
            this.navigationGroupBox.Size = new System.Drawing.Size(908, 68);
            this.navigationGroupBox.TabIndex = 20;
            this.navigationGroupBox.TabStop = false;
            this.navigationGroupBox.Text = "Navigation";
            // 
            // currentItemDetailsGroupBox
            // 
            this.currentItemDetailsGroupBox.Controls.Add(this.currentItemDetailsLayoutPanel);
            this.currentItemDetailsGroupBox.Location = new System.Drawing.Point(12, 98);
            this.currentItemDetailsGroupBox.Name = "currentItemDetailsGroupBox";
            this.currentItemDetailsGroupBox.Size = new System.Drawing.Size(430, 273);
            this.currentItemDetailsGroupBox.TabIndex = 0;
            this.currentItemDetailsGroupBox.TabStop = false;
            this.currentItemDetailsGroupBox.Text = "Current Item Details";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(908, 24);
            this.menuStrip1.TabIndex = 24;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOpenLibrary});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // mnuOpenLibrary
            // 
            this.mnuOpenLibrary.Name = "mnuOpenLibrary";
            this.mnuOpenLibrary.Size = new System.Drawing.Size(142, 22);
            this.mnuOpenLibrary.Text = "Open Library";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 605);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(908, 22);
            this.statusStrip1.TabIndex = 25;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 627);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.currentItemDetailsGroupBox);
            this.Controls.Add(this.navigationGroupBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Media Library";
            this.currentItemDetailsLayoutPanel.ResumeLayout(false);
            this.currentItemDetailsLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coverImagePictureBox)).EndInit();
            this.navigationLayoutPanel.ResumeLayout(false);
            this.navigationGroupBox.ResumeLayout(false);
            this.currentItemDetailsGroupBox.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label artistOrDirectorLabel;
        private System.Windows.Forms.Label ratingLabel;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox artistOrDirectorTextBox;
        private System.Windows.Forms.TableLayoutPanel currentItemDetailsLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel navigationLayoutPanel;
        private System.Windows.Forms.Button moveFirstButton;
        private System.Windows.Forms.Button movePreviousButton;
        private System.Windows.Forms.Button moveNextButton;
        private System.Windows.Forms.Button moveLastButton;
        private System.Windows.Forms.TextBox ratingTextBox;
        private System.Windows.Forms.PictureBox coverImagePictureBox;
        private System.Windows.Forms.GroupBox navigationGroupBox;
        private System.Windows.Forms.GroupBox currentItemDetailsGroupBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuOpenLibrary;
        private System.Windows.Forms.StatusStrip statusStrip1;
    }
}

