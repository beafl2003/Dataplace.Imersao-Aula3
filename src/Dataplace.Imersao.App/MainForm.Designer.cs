namespace Dataplace.Imersao.App
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
            ((System.ComponentModel.ISupportInitialize)(this.docMain)).BeginInit();
            this.SuspendLayout();
            // 
            // cboDSNList
            // 
            this.cboDSNList.Size = new System.Drawing.Size(203, 24);
            // 
            // docMain
            // 
            this.docMain.Size = new System.Drawing.Size(320, 360);
            // 
            // UserMenu
            // 
            this.UserMenu.Size = new System.Drawing.Size(317, 596);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "MainForm";
            this.Text = "Hello world";
            ((System.ComponentModel.ISupportInitialize)(this.docMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}

