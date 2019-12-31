namespace CoffeeTime
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
            this.DonutBtn = new System.Windows.Forms.Button();
            this.CoffeeBtn = new System.Windows.Forms.Button();
            this.listP = new System.Windows.Forms.FlowLayoutPanel();
            this.TB1 = new System.Windows.Forms.RichTextBox();
            this.rb1 = new CoffeeTime.Round_Button();
            this.SuspendLayout();
            // 
            // DonutBtn
            // 
            this.DonutBtn.Location = new System.Drawing.Point(156, 139);
            this.DonutBtn.Name = "DonutBtn";
            this.DonutBtn.Size = new System.Drawing.Size(75, 23);
            this.DonutBtn.TabIndex = 1;
            this.DonutBtn.Text = "Donut";
            this.DonutBtn.UseVisualStyleBackColor = true;
            this.DonutBtn.Click += new System.EventHandler(this.DonutBtn_Click);
            // 
            // CoffeeBtn
            // 
            this.CoffeeBtn.Location = new System.Drawing.Point(21, 139);
            this.CoffeeBtn.Name = "CoffeeBtn";
            this.CoffeeBtn.Size = new System.Drawing.Size(75, 23);
            this.CoffeeBtn.TabIndex = 2;
            this.CoffeeBtn.Text = "Coffee";
            this.CoffeeBtn.UseVisualStyleBackColor = true;
            this.CoffeeBtn.Click += new System.EventHandler(this.CoffeeBtn_Click);
            // 
            // listP
            // 
            this.listP.AutoScroll = true;
            this.listP.Location = new System.Drawing.Point(12, 190);
            this.listP.Name = "listP";
            this.listP.Size = new System.Drawing.Size(531, 272);
            this.listP.TabIndex = 3;
            // 
            // TB1
            // 
            this.TB1.Location = new System.Drawing.Point(575, 187);
            this.TB1.Name = "TB1";
            this.TB1.Size = new System.Drawing.Size(401, 311);
            this.TB1.TabIndex = 5;
            this.TB1.Text = "";
            // 
            // rb1
            // 
            this.rb1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.rb1.Location = new System.Drawing.Point(881, 12);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(95, 43);
            this.rb1.TabIndex = 4;
            this.rb1.Text = "Order";
            this.rb1.UseVisualStyleBackColor = false;
            this.rb1.Click += new System.EventHandler(this.Rb1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 524);
            this.Controls.Add(this.TB1);
            this.Controls.Add(this.rb1);
            this.Controls.Add(this.listP);
            this.Controls.Add(this.CoffeeBtn);
            this.Controls.Add(this.DonutBtn);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "Form1";
            this.Text = "Coffee Order System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button DonutBtn;
        private System.Windows.Forms.Button CoffeeBtn;
        private System.Windows.Forms.FlowLayoutPanel listP;
        private Round_Button rb1;
        private System.Windows.Forms.RichTextBox TB1;
    }
}

