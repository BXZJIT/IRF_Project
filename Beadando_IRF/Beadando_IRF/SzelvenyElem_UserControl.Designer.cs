namespace Beadando_IRF
{
    partial class SzelvenyElem_UserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SZE_Bajnoksag_Label = new System.Windows.Forms.Label();
            this.SZE_Merkozes_Label = new System.Windows.Forms.Label();
            this.SZE_Fogadas_Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SZE_Bajnoksag_Label
            // 
            this.SZE_Bajnoksag_Label.AutoSize = true;
            this.SZE_Bajnoksag_Label.ForeColor = System.Drawing.Color.White;
            this.SZE_Bajnoksag_Label.Location = new System.Drawing.Point(4, 4);
            this.SZE_Bajnoksag_Label.Name = "SZE_Bajnoksag_Label";
            this.SZE_Bajnoksag_Label.Size = new System.Drawing.Size(46, 17);
            this.SZE_Bajnoksag_Label.TabIndex = 0;
            this.SZE_Bajnoksag_Label.Text = "label1";
            // 
            // SZE_Merkozes_Label
            // 
            this.SZE_Merkozes_Label.AutoSize = true;
            this.SZE_Merkozes_Label.ForeColor = System.Drawing.Color.White;
            this.SZE_Merkozes_Label.Location = new System.Drawing.Point(397, 4);
            this.SZE_Merkozes_Label.Name = "SZE_Merkozes_Label";
            this.SZE_Merkozes_Label.Size = new System.Drawing.Size(46, 17);
            this.SZE_Merkozes_Label.TabIndex = 1;
            this.SZE_Merkozes_Label.Text = "label2";
            // 
            // SZE_Fogadas_Label
            // 
            this.SZE_Fogadas_Label.AutoSize = true;
            this.SZE_Fogadas_Label.ForeColor = System.Drawing.Color.White;
            this.SZE_Fogadas_Label.Location = new System.Drawing.Point(745, 4);
            this.SZE_Fogadas_Label.Name = "SZE_Fogadas_Label";
            this.SZE_Fogadas_Label.Size = new System.Drawing.Size(46, 17);
            this.SZE_Fogadas_Label.TabIndex = 2;
            this.SZE_Fogadas_Label.Text = "label3";
            // 
            // SzelvenyElem_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SZE_Fogadas_Label);
            this.Controls.Add(this.SZE_Merkozes_Label);
            this.Controls.Add(this.SZE_Bajnoksag_Label);
            this.Name = "SzelvenyElem_UserControl";
            this.Size = new System.Drawing.Size(1208, 27);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label SZE_Bajnoksag_Label;
        public System.Windows.Forms.Label SZE_Merkozes_Label;
        public System.Windows.Forms.Label SZE_Fogadas_Label;
    }
}
