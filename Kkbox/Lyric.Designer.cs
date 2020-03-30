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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lyric));
            this.lblLyric = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblLyric
            // 
            this.lblLyric.AutoSize = true;
            this.lblLyric.BackColor = System.Drawing.Color.Transparent;
            this.lblLyric.Font = new System.Drawing.Font("MISTER_CHAN", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLyric.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(216)))));
            this.lblLyric.Location = new System.Drawing.Point(0, 0);
            this.lblLyric.Name = "lblLyric";
            this.lblLyric.Size = new System.Drawing.Size(1181, 67);
            this.lblLyric.TabIndex = 0;
            this.lblLyric.Text = "啟動無限音樂，創造你的獨特音樂體驗！";
            this.lblLyric.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLyric.SizeChanged += new System.EventHandler(this.LblLyric_SizeChanged);
            // 
            // Lyric
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(175)))), ((int)(((byte)(217)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblLyric);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Lyric";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(175)))), ((int)(((byte)(217)))));
            this.Load += new System.EventHandler(this.Lyric_Load);
            this.Resize += new System.EventHandler(this.Lyric_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblLyric;
    }
}