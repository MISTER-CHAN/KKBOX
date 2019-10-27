namespace Kkbox
{
    partial class Lyric
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
            this.lblLyric = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblLyric
            // 
            this.lblLyric.AutoSize = true;
            this.lblLyric.BackColor = System.Drawing.Color.Transparent;
            this.lblLyric.Font = new System.Drawing.Font("MISTER_CHAN", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLyric.ForeColor = System.Drawing.Color.Aqua;
            this.lblLyric.Location = new System.Drawing.Point(0, 0);
            this.lblLyric.Name = "lblLyric";
            this.lblLyric.Size = new System.Drawing.Size(241, 67);
            this.lblLyric.TabIndex = 0;
            this.lblLyric.Text = "label1";
            this.lblLyric.SizeChanged += new System.EventHandler(this.lblLyric_SizeChanged);
            this.lblLyric.DoubleClick += new System.EventHandler(this.lblLyric_DoubleClick);
            // 
            // Lyric
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblLyric);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Lyric";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Load += new System.EventHandler(this.Lyric_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblLyric;
    }
}