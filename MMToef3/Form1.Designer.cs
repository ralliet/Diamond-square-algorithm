namespace MMToef3 {
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
            this.comboBox_landschappen = new System.Windows.Forms.ComboBox();
            this.pictureBox_fractaal = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_fractaal)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox_landschappen
            // 
            this.comboBox_landschappen.FormattingEnabled = true;
            this.comboBox_landschappen.Location = new System.Drawing.Point(25, 12);
            this.comboBox_landschappen.Name = "comboBox_landschappen";
            this.comboBox_landschappen.Size = new System.Drawing.Size(317, 21);
            this.comboBox_landschappen.TabIndex = 0;
            this.comboBox_landschappen.SelectedIndexChanged += new System.EventHandler(this.comboBox_landschappen_SelectedIndexChanged);
            // 
            // pictureBox_fractaal
            // 
            this.pictureBox_fractaal.Location = new System.Drawing.Point(25, 39);
            this.pictureBox_fractaal.Name = "pictureBox_fractaal";
            this.pictureBox_fractaal.Size = new System.Drawing.Size(512, 512);
            this.pictureBox_fractaal.TabIndex = 1;
            this.pictureBox_fractaal.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 582);
            this.Controls.Add(this.pictureBox_fractaal);
            this.Controls.Add(this.comboBox_landschappen);
            this.Name = "Form1";
            this.Text = "Fractale landschappen";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_fractaal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_landschappen;
        public System.Windows.Forms.PictureBox pictureBox_fractaal;
    }
}

