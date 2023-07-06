
namespace CekilisApp
{
    partial class WinnerMac
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
            this.WinnerLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // WinnerLabel
            // 
            this.WinnerLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WinnerLabel.Font = new System.Drawing.Font("Comic Sans MS", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WinnerLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.WinnerLabel.Image = global::CekilisApp.Properties.Resources._257286556_4591474524233906_4503648656769794985_n;
            this.WinnerLabel.Location = new System.Drawing.Point(0, 0);
            this.WinnerLabel.Name = "WinnerLabel";
            this.WinnerLabel.Size = new System.Drawing.Size(800, 450);
            this.WinnerLabel.TabIndex = 0;
            this.WinnerLabel.Text = "Kazanan";
            this.WinnerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WinnerMac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.WinnerLabel);
            this.Name = "WinnerMac";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label WinnerLabel;
    }
}