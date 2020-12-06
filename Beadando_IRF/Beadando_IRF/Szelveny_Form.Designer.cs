namespace Beadando_IRF
{
    partial class Szelveny_Form
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Szelveny_Panel = new System.Windows.Forms.Panel();
            this.Exportalas_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Szelveny_Panel
            // 
            this.Szelveny_Panel.Location = new System.Drawing.Point(13, 13);
            this.Szelveny_Panel.Name = "Szelveny_Panel";
            this.Szelveny_Panel.Size = new System.Drawing.Size(1145, 394);
            this.Szelveny_Panel.TabIndex = 0;
            // 
            // Exportalas_Button
            // 
            this.Exportalas_Button.Location = new System.Drawing.Point(555, 413);
            this.Exportalas_Button.Name = "Exportalas_Button";
            this.Exportalas_Button.Size = new System.Drawing.Size(96, 23);
            this.Exportalas_Button.TabIndex = 1;
            this.Exportalas_Button.Text = "Exportálás";
            this.Exportalas_Button.UseVisualStyleBackColor = true;
            // 
            // Szelveny_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 481);
            this.Controls.Add(this.Exportalas_Button);
            this.Controls.Add(this.Szelveny_Panel);
            this.Name = "Szelveny_Form";
            this.Text = "Szelveny_Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel Szelveny_Panel;
        private System.Windows.Forms.Button Exportalas_Button;
    }
}