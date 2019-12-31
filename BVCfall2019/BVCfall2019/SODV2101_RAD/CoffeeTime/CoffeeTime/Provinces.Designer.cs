namespace CoffeeTime
{
    partial class Provinces
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
            this.provinceLb = new System.Windows.Forms.Label();
            this.provinceCmb = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // provinceLb
            // 
            this.provinceLb.AutoSize = true;
            this.provinceLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.provinceLb.Location = new System.Drawing.Point(3, 15);
            this.provinceLb.Name = "provinceLb";
            this.provinceLb.Size = new System.Drawing.Size(84, 24);
            this.provinceLb.TabIndex = 0;
            this.provinceLb.Text = "Province";
            // 
            // provinceCmb
            // 
            this.provinceCmb.FormattingEnabled = true;
            this.provinceCmb.Location = new System.Drawing.Point(146, 15);
            this.provinceCmb.Name = "provinceCmb";
            this.provinceCmb.Size = new System.Drawing.Size(239, 24);
            this.provinceCmb.TabIndex = 1;
            this.provinceCmb.SelectedIndexChanged += new System.EventHandler(this.ProvinceCmb_SelectedIndexChanged);
            // 
            // Provinces
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.provinceCmb);
            this.Controls.Add(this.provinceLb);
            this.Name = "Provinces";
            this.Size = new System.Drawing.Size(406, 60);
            this.Load += new System.EventHandler(this.Provinces_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label provinceLb;
        private System.Windows.Forms.ComboBox provinceCmb;
    }
}
