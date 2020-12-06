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
            this.OsszesSzorzo_Label = new System.Windows.Forms.Label();
            this.VarhatoNyeremeny_Label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Tet_Label = new System.Windows.Forms.Label();
            this.SzorzoErtek_Label = new System.Windows.Forms.Label();
            this.Tet_TextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Szelveny_Panel
            // 
            this.Szelveny_Panel.Location = new System.Drawing.Point(13, 13);
            this.Szelveny_Panel.Name = "Szelveny_Panel";
            this.Szelveny_Panel.Size = new System.Drawing.Size(1145, 283);
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
            // OsszesSzorzo_Label
            // 
            this.OsszesSzorzo_Label.AutoSize = true;
            this.OsszesSzorzo_Label.Location = new System.Drawing.Point(12, 317);
            this.OsszesSzorzo_Label.Name = "OsszesSzorzo_Label";
            this.OsszesSzorzo_Label.Size = new System.Drawing.Size(103, 17);
            this.OsszesSzorzo_Label.TabIndex = 2;
            this.OsszesSzorzo_Label.Text = "Összes Szorzó";
            // 
            // VarhatoNyeremeny_Label
            // 
            this.VarhatoNyeremeny_Label.AutoSize = true;
            this.VarhatoNyeremeny_Label.Location = new System.Drawing.Point(15, 391);
            this.VarhatoNyeremeny_Label.Name = "VarhatoNyeremeny_Label";
            this.VarhatoNyeremeny_Label.Size = new System.Drawing.Size(134, 17);
            this.VarhatoNyeremeny_Label.TabIndex = 3;
            this.VarhatoNyeremeny_Label.Text = "Várható Nyeremény";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(170, 391);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "label3";
            // 
            // Tet_Label
            // 
            this.Tet_Label.AutoSize = true;
            this.Tet_Label.Location = new System.Drawing.Point(15, 352);
            this.Tet_Label.Name = "Tet_Label";
            this.Tet_Label.Size = new System.Drawing.Size(100, 17);
            this.Tet_Label.TabIndex = 5;
            this.Tet_Label.Text = "Megjátszott tét";
            // 
            // SzorzoErtek_Label
            // 
            this.SzorzoErtek_Label.AutoSize = true;
            this.SzorzoErtek_Label.Location = new System.Drawing.Point(145, 317);
            this.SzorzoErtek_Label.Name = "SzorzoErtek_Label";
            this.SzorzoErtek_Label.Size = new System.Drawing.Size(46, 17);
            this.SzorzoErtek_Label.TabIndex = 6;
            this.SzorzoErtek_Label.Text = "label5";
            // 
            // Tet_TextBox
            // 
            this.Tet_TextBox.Location = new System.Drawing.Point(148, 352);
            this.Tet_TextBox.Name = "Tet_TextBox";
            this.Tet_TextBox.Size = new System.Drawing.Size(122, 22);
            this.Tet_TextBox.TabIndex = 7;
            // 
            // Szelveny_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 481);
            this.Controls.Add(this.Tet_TextBox);
            this.Controls.Add(this.SzorzoErtek_Label);
            this.Controls.Add(this.Tet_Label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.VarhatoNyeremeny_Label);
            this.Controls.Add(this.OsszesSzorzo_Label);
            this.Controls.Add(this.Exportalas_Button);
            this.Controls.Add(this.Szelveny_Panel);
            this.Name = "Szelveny_Form";
            this.Text = "Szelveny_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel Szelveny_Panel;
        private System.Windows.Forms.Button Exportalas_Button;
        private System.Windows.Forms.Label OsszesSzorzo_Label;
        private System.Windows.Forms.Label VarhatoNyeremeny_Label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Tet_Label;
        private System.Windows.Forms.Label SzorzoErtek_Label;
        private System.Windows.Forms.TextBox Tet_TextBox;
    }
}