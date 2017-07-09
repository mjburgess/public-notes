namespace MediaLibraryApp {
    partial class ArtistsForm {
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
            this.lstArtists = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lstProductions = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstArtists
            // 
            this.lstArtists.FormattingEnabled = true;
            this.lstArtists.Location = new System.Drawing.Point(30, 42);
            this.lstArtists.Name = "lstArtists";
            this.lstArtists.Size = new System.Drawing.Size(153, 186);
            this.lstArtists.TabIndex = 0;
            this.lstArtists.SelectedIndexChanged += new System.EventHandler(this.lstArtists_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Artists";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(257, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Productions";
            // 
            // lstProductions
            // 
            this.lstProductions.FormattingEnabled = true;
            this.lstProductions.Location = new System.Drawing.Point(238, 42);
            this.lstProductions.Name = "lstProductions";
            this.lstProductions.Size = new System.Drawing.Size(172, 186);
            this.lstProductions.TabIndex = 3;
            // 
            // ArtistsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 303);
            this.Controls.Add(this.lstProductions);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstArtists);
            this.Name = "ArtistsForm";
            this.Text = "ArtistsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstArtists;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstProductions;
    }
}