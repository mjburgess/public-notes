namespace WindowsFormsApplication1 {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.mediaControlsGroupBox = new System.Windows.Forms.GroupBox();
            this.mediaPlayerLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.playMediaItemButton = new System.Windows.Forms.Button();
            this.pauseMediaItemButton = new System.Windows.Forms.Button();
            this.stopMediaItemButton = new System.Windows.Forms.Button();
            this.durationDisplayLabel = new System.Windows.Forms.Label();
            this.durationLabel = new System.Windows.Forms.Label();
            this.mediaControlsGroupBox.SuspendLayout();
            this.mediaPlayerLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mediaControlsGroupBox
            // 
            this.mediaControlsGroupBox.Controls.Add(this.mediaPlayerLayoutPanel);
            this.mediaControlsGroupBox.Location = new System.Drawing.Point(532, 200);
            this.mediaControlsGroupBox.Name = "mediaControlsGroupBox";
            this.mediaControlsGroupBox.Size = new System.Drawing.Size(355, 151);
            this.mediaControlsGroupBox.TabIndex = 1;
            this.mediaControlsGroupBox.TabStop = false;
            this.mediaControlsGroupBox.Text = "Media Controls";
            // 
            // mediaPlayerLayoutPanel
            // 
            this.mediaPlayerLayoutPanel.ColumnCount = 4;
            this.mediaPlayerLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.mediaPlayerLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.mediaPlayerLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.mediaPlayerLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.mediaPlayerLayoutPanel.Controls.Add(this.playMediaItemButton, 0, 0);
            this.mediaPlayerLayoutPanel.Controls.Add(this.pauseMediaItemButton, 1, 0);
            this.mediaPlayerLayoutPanel.Controls.Add(this.stopMediaItemButton, 2, 0);
            this.mediaPlayerLayoutPanel.Controls.Add(this.durationDisplayLabel, 2, 1);
            this.mediaPlayerLayoutPanel.Controls.Add(this.durationLabel, 1, 1);
            this.mediaPlayerLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mediaPlayerLayoutPanel.Location = new System.Drawing.Point(3, 16);
            this.mediaPlayerLayoutPanel.Name = "mediaPlayerLayoutPanel";
            this.mediaPlayerLayoutPanel.RowCount = 3;
            this.mediaPlayerLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.mediaPlayerLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.mediaPlayerLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.mediaPlayerLayoutPanel.Size = new System.Drawing.Size(349, 132);
            this.mediaPlayerLayoutPanel.TabIndex = 15;
            // 
            // playMediaItemButton
            // 
            this.playMediaItemButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.playMediaItemButton.Location = new System.Drawing.Point(6, 10);
            this.playMediaItemButton.Name = "playMediaItemButton";
            this.playMediaItemButton.Size = new System.Drawing.Size(75, 23);
            this.playMediaItemButton.TabIndex = 0;
            this.playMediaItemButton.Text = "Play";
            this.playMediaItemButton.UseVisualStyleBackColor = true;
            // 
            // pauseMediaItemButton
            // 
            this.pauseMediaItemButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pauseMediaItemButton.Location = new System.Drawing.Point(93, 10);
            this.pauseMediaItemButton.Name = "pauseMediaItemButton";
            this.pauseMediaItemButton.Size = new System.Drawing.Size(75, 23);
            this.pauseMediaItemButton.TabIndex = 1;
            this.pauseMediaItemButton.Text = "Pause";
            this.pauseMediaItemButton.UseVisualStyleBackColor = true;
            // 
            // stopMediaItemButton
            // 
            this.stopMediaItemButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.stopMediaItemButton.Location = new System.Drawing.Point(180, 10);
            this.stopMediaItemButton.Name = "stopMediaItemButton";
            this.stopMediaItemButton.Size = new System.Drawing.Size(75, 23);
            this.stopMediaItemButton.TabIndex = 2;
            this.stopMediaItemButton.Text = "Stop";
            this.stopMediaItemButton.UseVisualStyleBackColor = true;
            // 
            // durationDisplayLabel
            // 
            this.durationDisplayLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.durationDisplayLabel.AutoSize = true;
            this.durationDisplayLabel.Location = new System.Drawing.Point(193, 59);
            this.durationDisplayLabel.Name = "durationDisplayLabel";
            this.durationDisplayLabel.Size = new System.Drawing.Size(49, 13);
            this.durationDisplayLabel.TabIndex = 4;
            this.durationDisplayLabel.Text = "00:00:00";
            // 
            // durationLabel
            // 
            this.durationLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.durationLabel.AutoSize = true;
            this.durationLabel.Location = new System.Drawing.Point(105, 59);
            this.durationLabel.Name = "durationLabel";
            this.durationLabel.Size = new System.Drawing.Size(50, 13);
            this.durationLabel.TabIndex = 3;
            this.durationLabel.Text = "Duration:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 503);
            this.Controls.Add(this.mediaControlsGroupBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.mediaControlsGroupBox.ResumeLayout(false);
            this.mediaPlayerLayoutPanel.ResumeLayout(false);
            this.mediaPlayerLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox mediaControlsGroupBox;
        private System.Windows.Forms.TableLayoutPanel mediaPlayerLayoutPanel;
        private System.Windows.Forms.Button playMediaItemButton;
        private System.Windows.Forms.Button pauseMediaItemButton;
        private System.Windows.Forms.Button stopMediaItemButton;
        private System.Windows.Forms.Label durationDisplayLabel;
        private System.Windows.Forms.Label durationLabel;
    }
}

