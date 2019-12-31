namespace CoffeeTime
{
    partial class DonutCounter
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
            this.donutUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.donutUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // donutUpDown
            // 
            this.donutUpDown.Location = new System.Drawing.Point(64, 44);
            this.donutUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.donutUpDown.Name = "donutUpDown";
            this.donutUpDown.Size = new System.Drawing.Size(120, 22);
            this.donutUpDown.TabIndex = 0;
            this.donutUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.donutUpDown.ValueChanged += new System.EventHandler(this.DonutUpDown_ValueChanged);
            // 
            // DonutCounter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.donutUpDown);
            this.Name = "DonutCounter";
            this.Size = new System.Drawing.Size(265, 104);
            this.Load += new System.EventHandler(this.DonutCounter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.donutUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown donutUpDown;
    }
}
