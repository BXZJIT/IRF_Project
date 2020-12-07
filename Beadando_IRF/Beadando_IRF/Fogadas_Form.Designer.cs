namespace Beadando_IRF
{
    partial class Fogadas_Form
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
            this.Szelveny_Label = new System.Windows.Forms.Label();
            this.Lehetosegek_Label = new System.Windows.Forms.Label();
            this.Merkozes_Label = new System.Windows.Forms.Label();
            this.Bajnoksag_Label = new System.Windows.Forms.Label();
            this.Veglegesites_Button = new System.Windows.Forms.Button();
            this.Hozzaadas_Button = new System.Windows.Forms.Button();
            this.Beolvasas_Button = new System.Windows.Forms.Button();
            this.Lehetosegek_Listbox = new System.Windows.Forms.ListBox();
            this.Merkozes_Listbox = new System.Windows.Forms.ListBox();
            this.Bajnoksag_Listbox = new System.Windows.Forms.ListBox();
            this.Szelveny_ListBox = new System.Windows.Forms.ListBox();
            this.Torles_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Szelveny_Label
            // 
            this.Szelveny_Label.AutoSize = true;
            this.Szelveny_Label.Location = new System.Drawing.Point(900, 55);
            this.Szelveny_Label.Name = "Szelveny_Label";
            this.Szelveny_Label.Size = new System.Drawing.Size(65, 17);
            this.Szelveny_Label.TabIndex = 21;
            this.Szelveny_Label.Text = "Szelvény";
            // 
            // Lehetosegek_Label
            // 
            this.Lehetosegek_Label.AutoSize = true;
            this.Lehetosegek_Label.Location = new System.Drawing.Point(544, 55);
            this.Lehetosegek_Label.Name = "Lehetosegek_Label";
            this.Lehetosegek_Label.Size = new System.Drawing.Size(147, 17);
            this.Lehetosegek_Label.TabIndex = 20;
            this.Lehetosegek_Label.Text = "Fogadási lehetőségek";
            // 
            // Merkozes_Label
            // 
            this.Merkozes_Label.AutoSize = true;
            this.Merkozes_Label.Location = new System.Drawing.Point(279, 55);
            this.Merkozes_Label.Name = "Merkozes_Label";
            this.Merkozes_Label.Size = new System.Drawing.Size(69, 17);
            this.Merkozes_Label.TabIndex = 19;
            this.Merkozes_Label.Text = "Mérkőzés";
            // 
            // Bajnoksag_Label
            // 
            this.Bajnoksag_Label.AutoSize = true;
            this.Bajnoksag_Label.Location = new System.Drawing.Point(4, 55);
            this.Bajnoksag_Label.Name = "Bajnoksag_Label";
            this.Bajnoksag_Label.Size = new System.Drawing.Size(74, 17);
            this.Bajnoksag_Label.TabIndex = 18;
            this.Bajnoksag_Label.Text = "Bajnokság";
            // 
            // Veglegesites_Button
            // 
            this.Veglegesites_Button.Location = new System.Drawing.Point(928, 444);
            this.Veglegesites_Button.Name = "Veglegesites_Button";
            this.Veglegesites_Button.Size = new System.Drawing.Size(224, 34);
            this.Veglegesites_Button.TabIndex = 17;
            this.Veglegesites_Button.Text = "Szelvény Véglegesítése";
            this.Veglegesites_Button.UseVisualStyleBackColor = true;
            // 
            // Hozzaadas_Button
            // 
            this.Hozzaadas_Button.Location = new System.Drawing.Point(822, 179);
            this.Hozzaadas_Button.Name = "Hozzaadas_Button";
            this.Hozzaadas_Button.Size = new System.Drawing.Size(75, 23);
            this.Hozzaadas_Button.TabIndex = 16;
            this.Hozzaadas_Button.Text = "Hozzáadás";
            this.Hozzaadas_Button.UseVisualStyleBackColor = true;
            // 
            // Beolvasas_Button
            // 
            this.Beolvasas_Button.Location = new System.Drawing.Point(21, 25);
            this.Beolvasas_Button.Name = "Beolvasas_Button";
            this.Beolvasas_Button.Size = new System.Drawing.Size(108, 23);
            this.Beolvasas_Button.TabIndex = 15;
            this.Beolvasas_Button.Text = "Beolvasás";
            this.Beolvasas_Button.UseVisualStyleBackColor = true;
            this.Beolvasas_Button.Click += new System.EventHandler(this.Beolvasas_Button_Click);
            // 
            // Lehetosegek_Listbox
            // 
            this.Lehetosegek_Listbox.FormattingEnabled = true;
            this.Lehetosegek_Listbox.ItemHeight = 16;
            this.Lehetosegek_Listbox.Location = new System.Drawing.Point(547, 85);
            this.Lehetosegek_Listbox.Name = "Lehetosegek_Listbox";
            this.Lehetosegek_Listbox.Size = new System.Drawing.Size(272, 340);
            this.Lehetosegek_Listbox.TabIndex = 13;
            // 
            // Merkozes_Listbox
            // 
            this.Merkozes_Listbox.FormattingEnabled = true;
            this.Merkozes_Listbox.ItemHeight = 16;
            this.Merkozes_Listbox.Location = new System.Drawing.Point(282, 85);
            this.Merkozes_Listbox.Name = "Merkozes_Listbox";
            this.Merkozes_Listbox.Size = new System.Drawing.Size(259, 340);
            this.Merkozes_Listbox.TabIndex = 12;
            this.Merkozes_Listbox.SelectedIndexChanged += new System.EventHandler(this.Merkozes_Listbox_SelectedIndexChanged);
            // 
            // Bajnoksag_Listbox
            // 
            this.Bajnoksag_Listbox.FormattingEnabled = true;
            this.Bajnoksag_Listbox.ItemHeight = 16;
            this.Bajnoksag_Listbox.Location = new System.Drawing.Point(7, 85);
            this.Bajnoksag_Listbox.Name = "Bajnoksag_Listbox";
            this.Bajnoksag_Listbox.Size = new System.Drawing.Size(269, 340);
            this.Bajnoksag_Listbox.TabIndex = 11;
            this.Bajnoksag_Listbox.SelectedIndexChanged += new System.EventHandler(this.Bajnoksag_Listbox_SelectedIndexChanged);
            // 
            // Szelveny_ListBox
            // 
            this.Szelveny_ListBox.FormattingEnabled = true;
            this.Szelveny_ListBox.ItemHeight = 16;
            this.Szelveny_ListBox.Location = new System.Drawing.Point(903, 85);
            this.Szelveny_ListBox.Name = "Szelveny_ListBox";
            this.Szelveny_ListBox.Size = new System.Drawing.Size(256, 340);
            this.Szelveny_ListBox.TabIndex = 22;
            // 
            // Torles_Button
            // 
            this.Torles_Button.Location = new System.Drawing.Point(822, 295);
            this.Torles_Button.Name = "Torles_Button";
            this.Torles_Button.Size = new System.Drawing.Size(75, 23);
            this.Torles_Button.TabIndex = 23;
            this.Torles_Button.Text = "Törlés";
            this.Torles_Button.UseVisualStyleBackColor = true;
            // 
            // Fogadas_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 490);
            this.Controls.Add(this.Torles_Button);
            this.Controls.Add(this.Szelveny_ListBox);
            this.Controls.Add(this.Szelveny_Label);
            this.Controls.Add(this.Lehetosegek_Label);
            this.Controls.Add(this.Merkozes_Label);
            this.Controls.Add(this.Bajnoksag_Label);
            this.Controls.Add(this.Veglegesites_Button);
            this.Controls.Add(this.Hozzaadas_Button);
            this.Controls.Add(this.Beolvasas_Button);
            this.Controls.Add(this.Lehetosegek_Listbox);
            this.Controls.Add(this.Merkozes_Listbox);
            this.Controls.Add(this.Bajnoksag_Listbox);
            this.Name = "Fogadas_Form";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Szelveny_Label;
        private System.Windows.Forms.Label Lehetosegek_Label;
        private System.Windows.Forms.Label Merkozes_Label;
        private System.Windows.Forms.Label Bajnoksag_Label;
        private System.Windows.Forms.Button Veglegesites_Button;
        private System.Windows.Forms.Button Hozzaadas_Button;
        private System.Windows.Forms.Button Beolvasas_Button;
        private System.Windows.Forms.ListBox Lehetosegek_Listbox;
        private System.Windows.Forms.ListBox Merkozes_Listbox;
        private System.Windows.Forms.ListBox Bajnoksag_Listbox;
        private System.Windows.Forms.ListBox Szelveny_ListBox;
        private System.Windows.Forms.Button Torles_Button;
    }
}

