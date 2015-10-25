namespace CentSharp
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
			this.octo = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.octo)).BeginInit();
			this.SuspendLayout();
			// 
			// octo
			// 
			this.octo.Image = global::CentSharp.Properties.Resources.octo;
			this.octo.Location = new System.Drawing.Point(433, 231);
			this.octo.Name = "octo";
			this.octo.Size = new System.Drawing.Size(121, 128);
			this.octo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.octo.TabIndex = 0;
			this.octo.TabStop = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Gray;
			this.ClientSize = new System.Drawing.Size(1016, 614);
			this.Controls.Add(this.octo);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "CentSharp Demo";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.octo)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox octo;
    }
}

